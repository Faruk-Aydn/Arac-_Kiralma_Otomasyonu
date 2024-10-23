using System;
using System.Linq;
using System.Windows.Forms;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;

namespace AracKiralamaOtomasyonu3
{
    public partial class KiralayanForm : Form
    {
        private int _kiralayanId;

        public KiralayanForm(int kiralayanId)
        {
            InitializeComponent();
            _kiralayanId = kiralayanId;
       
        }

        // Araç ekleme butonuna tıklama işlemi
        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var arac = new Arac
                {
                    Model = txtModel.Text,
                    Plaka = txtPlaka.Text,
                    Fiyat = decimal.Parse(txtFiyat.Text),
                    BakimTarihi = dtpBakimTarihi.Value
                };

                context.Araclar.Add(arac);
                context.SaveChanges();

                MessageBox.Show("Araç başarıyla eklendi!");
                ListeyiGuncelle();
            }
        }
      

        // Araç silme butonuna tıklama işlemi
        private void btnAracSil_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var plaka = txtPlaka.Text;
                var arac = context.Araclar.FirstOrDefault(a => a.Plaka == plaka);

                if (arac != null)
                {
                    context.Araclar.Remove(arac);
                    context.SaveChanges();
                    MessageBox.Show("Araç başarıyla silindi!");
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı!");
                }
            }

            ListeyiGuncelle();
        }

        // Kiralanan araçları listele
        private void btnKiralananAraclar_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var kiralananAraclar = context.Araclar
                    .Where(a => a.KiralandiMi == true)  // Kiralanmış araçları getir
                    .ToList();

                dgvAraclar.DataSource = kiralananAraclar;
            }
        }

        // Kiralanmayan araçları listele
        private void btnKiralanmayanAraclar_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var kiralanmayanAraclar = context.Araclar
                    .Where(a => a.KiralandiMi == false)  // Kiralanmamış araçları getir
                    .ToList();

                dgvAraclar.DataSource = kiralanmayanAraclar;
            }
        }

        // Araç listelerini güncelleme
        private void ListeyiGuncelle()
        {
            using (var context = new AracKiralamaContext())
            {
                var araclar = context.Araclar.ToList();  // Tüm araçları getir
                dgvAraclar.DataSource = araclar;  // Araçları DataGridView'e ata
            }
        }

        // Form yüklendiğinde araçları listeleme
        private void KiralayanForm_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
