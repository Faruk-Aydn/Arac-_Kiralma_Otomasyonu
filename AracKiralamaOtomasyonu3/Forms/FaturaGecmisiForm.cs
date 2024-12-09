using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AracKiralamaOtomasyonu3.Models;
using System.Data.Entity;
using AracKiralamaOtomasyonu3.DAL;

namespace AracKiralamaOtomasyonu3
{
    public partial class FaturaGecmisiForm : Form
    {
        private int _musteriId;

        public FaturaGecmisiForm(int musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;
        }

        private void FaturaGecmisiForm_Load(object sender, EventArgs e)
        {
            ListeFaturalari();  // Form yüklendiğinde faturaları listele
        }

        private void ListeFaturalari()
        {
            using (var context = new AracKiralamaContext())
            {
                var faturalar = context.Faturalar
                    .Include(f => f.Kiralama.Arac)
                    .Include(f => f.Kiralama.Kullanici)
                    .Where(f => f.Kiralama.KullaniciId == _musteriId)  // Sadece ilgili müşterinin faturalarını al
                    .Select(f => new
                    {
                        f.FaturaId,
                        AracModel = f.Kiralama.Arac.Model,
                        Plaka = f.Kiralama.Arac.Plaka,
                        FaturaTarihi = f.FaturaTarihi,
                        Tutar = f.Tutar
                    }).ToList();

                dgvFaturaGecmisi.DataSource = faturalar;

              
                dgvFaturaGecmisi.Columns["FaturaId"].Visible = false;
            }
        }

        private void dgvFaturaGecmisi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Geçerli bir satır seçilmişse
            {
                int faturaId = Convert.ToInt32(dgvFaturaGecmisi.Rows[e.RowIndex].Cells["FaturaId"].Value);
                FaturaDetayGoster(faturaId);
            }
        }

        private void FaturaDetayGoster(int faturaId)
        {
            using (var context = new AracKiralamaContext())
            {
                var fatura = context.Faturalar
                    .Include(f => f.Kiralama.Arac)
                    .Include(f => f.Kiralama.Kullanici)
                    .FirstOrDefault(f => f.FaturaId == faturaId);

                if (fatura != null)
                {
                    MessageBox.Show($"Fatura Detayları:\n\n" +
                                    $"Müşteri: {fatura.Kiralama.Kullanici.Ad} {fatura.Kiralama.Kullanici.Soyad}\n" +
                                    $"Araç Model: {fatura.Kiralama.Arac.Model}\n" +
                                    $"Plaka: {fatura.Kiralama.Arac.Plaka}\n" +
                                    $"Fatura Tarihi: {fatura.FaturaTarihi:dd/MM/yyyy}\n" +
                                    $"Tutar: {fatura.Tutar:C}", "Fatura Detayları", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
