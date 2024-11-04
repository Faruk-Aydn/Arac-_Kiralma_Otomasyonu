using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;

namespace AracKiralamaOtomasyonu3
{
    public partial class KiralayanForm : Form
    {
        private int _kiralayanId;
        private byte[] _aracResim;

        public KiralayanForm(int kiralayanId)
        {
            InitializeComponent();
            _kiralayanId = kiralayanId;
        }
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    _aracResim = File.ReadAllBytes(filePath); // Resmi byte array olarak sakla

                    using (var ms = new MemoryStream(_aracResim))
                    {
                        pbAracResim.Image = Image.FromStream(ms);
                    }

                }
            }
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
                    BakimTarihi = dtpBakimTarihi.Value,
                    Resim = _aracResim


                };

                context.Araclar.Add(arac);
                context.SaveChanges();

                MessageBox.Show("Araç başarıyla eklendi!");
                ListeyiGuncelle();
            }
        }
        private void btnAracSil_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var plaka = txtPlaka.Text.Trim().ToUpper();

                if (string.IsNullOrWhiteSpace(plaka))
                {
                    MessageBox.Show("Lütfen silmek istediğiniz aracın plaka alanını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var arac = context.Araclar.FirstOrDefault(a => a.Plaka.ToUpper() == plaka); // Veritabanında plakayı büyük harf olarak karşılaştırır

                if (arac != null)
                {
                    context.Araclar.Remove(arac);
                    context.SaveChanges();
                    MessageBox.Show("Araç başarıyla silindi!");
                    ListeyiGuncelle(); // Silme sonrası güncelle
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı veya plaka hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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


        // txtModel değişikliği algılama
        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            // İlgili işlem yapılabilir.
        }
    }
}
