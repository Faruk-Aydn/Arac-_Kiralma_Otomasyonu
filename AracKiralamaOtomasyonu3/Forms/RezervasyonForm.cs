using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;
using System;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3.Forms
{
    public partial class RezervasyonForm : Form
    {
        public bool RezervasyonBasarili { get; private set; }
        private int aracId;
        private int _musteriId;

        // Constructor
        public RezervasyonForm(int aracId, int musteriId)
        {
            InitializeComponent();
            this.aracId = aracId;
            this._musteriId = musteriId;
            RezervasyonBasarili = false;
        }

        // Form yüklendiğinde yapılacak işlemler
        private void RezervasyonForm_Load(object sender, EventArgs e)
        {
            // Eğer istenirse başlangıç tarihi ve teslim tarihi önceden ayarlanabilir
            dtpBaslangicTarihi.EditValue = DateTime.Now; // Başlangıç tarihi bugünden
            dtpTeslimTarihi.EditValue = DateTime.Now.AddDays(1);  // Teslim tarihi 1 gün sonrası
        }

        // Rezervasyon yap butonuna tıklanınca
        private void BtnRezervasyonYap_Click(object sender, EventArgs e)
        {
            var baslangicTarihi = dtpBaslangicTarihi.EditValue as DateTime?;
            var teslimTarihi = dtpTeslimTarihi.EditValue as DateTime?;

            if (baslangicTarihi == null || teslimTarihi == null)
            {
                MessageBox.Show("Lütfen geçerli tarihler seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (teslimTarihi <= baslangicTarihi)
            {
                MessageBox.Show("Teslim tarihi, başlangıç tarihinden sonraya olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int gunSayisi = (teslimTarihi.Value - baslangicTarihi.Value).Days;

            if (gunSayisi <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir süre aralığı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RezervasyonBasarili = true;
            using (var context = new AracKiralamaContext())
            {
                var arac = context.Araclar.Find(aracId);

                // Rezervasyon bilgilerini ekle
                var rezervasyon = new Rezervasyon
                {
                    AracId = aracId,
                    KullaniciId = _musteriId,
                    RezervasyonTarihi = DateTime.Now,
                    BaslangicTarihi = baslangicTarihi.Value,
                    TeslimTarihi = teslimTarihi.Value,
                    Durum = "Aktif"
                };

                context.Rezervasyonlar.Add(rezervasyon);
                context.SaveChanges();

                // Araç durumu "Rezerve Edildi" olarak güncelleniyor
                arac.Durum = "Rezerve Edildi";
                context.SaveChanges();

                // Rezervasyon başarılı mesajı
                MessageBox.Show($"Başarıyla  {arac.Marka} {arac.Model} için {gunSayisi} günlük rezervasyon yaptınız.\n" +
                    $"Başlangıç Tarihi: {baslangicTarihi.Value:dd/MM/yyyy}\n" +
                    $"Teslim Tarihi: {teslimTarihi.Value:dd/MM/yyyy}",
                    "Rezervasyon Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();  // Rezervasyon formunu kapat
            }
        }

        // İptal butonuna tıklanınca form kapanır
        private void BtnIptal_Click(object sender, EventArgs e)
        {
            RezervasyonBasarili = false;
            this.Close();  // Rezervasyon formunu iptal et
        }
    }
}
