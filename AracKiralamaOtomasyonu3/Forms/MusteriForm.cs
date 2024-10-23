using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; // For custom colors
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;

namespace AracKiralamaOtomasyonu3
{
    public partial class MusteriForm : Form
    {
        private int _musteriId;

        public MusteriForm(int musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            // Form arka plan rengini ayarla
            this.BackColor = Color.CadetBlue;

            // Mevcut araçları listeleyin
            using (var context = new AracKiralamaContext())
            {
                dgvMevcutAraclar.DataSource = context.Araclar
                    .Where(a => !a.KiralandiMi) // Kiralanmamış araçlar
                    .Select(a => new
                    {
                        a.AracId,
                        a.Model,
                        a.Plaka,
                        a.Fiyat
                    })
                    .ToList();
            }

            // DataGridView stil ayarları
            StyleDataGridView(dgvMevcutAraclar);
            StyleDataGridView(dgvKiralamaGecmisi);
        }

        // DataGridView stillendirme fonksiyonu
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv.DefaultCellStyle.BackColor = Color.LightGray;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Arial", 10);
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            if (dgvMevcutAraclar.SelectedRows.Count > 0)
            {
                int aracId = Convert.ToInt32(dgvMevcutAraclar.SelectedRows[0].Cells["AracId"].Value);
                using (var context = new AracKiralamaContext())
                {
                    var kiralama = new Kiralama
                    {
                        AracId = aracId,
                        KullaniciId = _musteriId,
                        KiralamaTarihi = DateTime.Now
                    };
                    context.Kiralamalar.Add(kiralama);

                    var arac = context.Araclar.Find(aracId);
                    arac.KiralandiMi = true;
                    context.SaveChanges();
                }

                MessageBox.Show("Araç başarıyla kiralandı!");

                // Ödeme formuna yönlendirme
                OdemeForm odemeForm = new OdemeForm();
                odemeForm.ShowDialog();

                MusteriForm_Load(sender, e); // Listeyi yenile
            }
        }

        private void btnGecmisiGor_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var kiralamaGecmisi = context.Kiralamalar
                    .Where(k => k.KullaniciId == _musteriId)
                    .Select(k => new
                    {
                        k.Arac.Model,
                        k.Arac.Plaka,
                        k.KiralamaTarihi,
                        TeslimTarihi = k.TeslimTarihi.HasValue ? k.TeslimTarihi.Value : (DateTime?)null
                    })
                    .ToList();

                var gosterilecekVeri = kiralamaGecmisi.Select(k => new
                {
                    k.Model,
                    k.Plaka,
                    k.KiralamaTarihi,
                    TeslimTarihi = k.TeslimTarihi.HasValue
                        ? k.TeslimTarihi.Value.ToString("dd/MM/yyyy")
                        : "Henüz Teslim Edilmedi"
                }).ToList();

                dgvKiralamaGecmisi.DataSource = gosterilecekVeri;
            }
        }
    }
}
