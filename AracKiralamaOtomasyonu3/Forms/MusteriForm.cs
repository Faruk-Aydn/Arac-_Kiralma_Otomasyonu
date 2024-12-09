using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;
using System.Data.Entity;

namespace AracKiralamaOtomasyonu3
{
    public partial class MusteriForm : Form
    {
        private int _musteriId;
        private System.Timers.Timer _hatirlatmaTimer;


        public MusteriForm(int musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;
            StartHatirlatmaTimer();
            dgvMevcutAraclar.SelectionChanged += dgvMevcutAraclar_SelectionChanged;
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
            AracListesiniYukle();
            StyleDataGridView(dgvMevcutAraclar);
        }

        private void AracListesiniYukle()
        {
            using (var context = new AracKiralamaContext())
            {
                dgvMevcutAraclar.DataSource = context.Araclar
                    .Where(a => !a.KiralandiMi)
                    .Select(a => new
                    {
                      
                        a.Model,
                        a.Plaka,
                        a.Fiyat
                    })
                    .ToList();
            }
        }

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

        private void StartHatirlatmaTimer()
        {
            _hatirlatmaTimer = new System.Timers.Timer
            {
                Interval = 86400000,
                AutoReset = true
            };
            _hatirlatmaTimer.Elapsed += (sender, e) => TeslimHatirlatma();
            _hatirlatmaTimer.Start();
        }

        private void TeslimHatirlatma()
        {
            using (var context = new AracKiralamaContext())
            {
                var yaklasanTeslimler = context.Kiralamalar
                    .Where(k => k.TeslimTarihi.HasValue && k.TeslimTarihi.Value.Date == DateTime.Now.Date.AddDays(1))
                    .Include(k => k.Kullanici)
                    .ToList();

                foreach (var kiralama in yaklasanTeslimler)
                {
                    MessageBox.Show($"{kiralama.Kullanici.Ad}, aracınızı yarın teslim etmeniz gerekmektedir.",
                                    "Teslim Hatırlatma",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void FiltreleAraclar(string model)
        {
            using (var context = new AracKiralamaContext())
            {
                var araclar = context.Araclar
                    .Where(a => a.Model.Contains(model) && !a.KiralandiMi)
                    .Select(a => new
                    {
                       
                        a.Model,
                        a.Plaka,
                        a.Fiyat
                    })
                    .ToList();

                dgvMevcutAraclar.DataSource = araclar;
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string model = txtModel.Text;
            FiltreleAraclar(model);
        }

        private void btnFaturaGecmisi_Click(object sender, EventArgs e)
        {
            FaturaGecmisiForm faturaForm = new FaturaGecmisiForm(_musteriId);
            faturaForm.ShowDialog();
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            if (dgvMevcutAraclar.SelectedRows.Count > 0)
            {
                int aracId = Convert.ToInt32(dgvMevcutAraclar.SelectedRows[0].Cells["AracId"].Value);
                int kiralamaGunu = (int)numKiralamaGunu.Value;

                OdemeForm odemeForm = new OdemeForm();
                odemeForm.ShowDialog();

                if (odemeForm.OdemeBasarili)
                {
                    using (var context = new AracKiralamaContext())
                    {
                        var kiralama = new Kiralama
                        {
                            AracId = aracId,
                            KullaniciId = _musteriId,
                            KiralamaTarihi = DateTime.Now,
                            TeslimTarihi = DateTime.Now.AddDays(kiralamaGunu)
                        };
                        context.Kiralamalar.Add(kiralama);

                        var arac = context.Araclar.Find(aracId);
                        arac.KiralandiMi = true;
                        context.SaveChanges();

                        decimal toplamTutar = arac.Fiyat * kiralamaGunu;
                        Fatura fatura = new Fatura
                        {
                            KiralamaId = kiralama.KiralamaId,
                            Tutar = toplamTutar,
                            FaturaTarihi = DateTime.Now
                        };
                        context.Faturalar.Add(fatura);
                        context.SaveChanges();

                        MessageBox.Show(
                            $"Fatura Detayları:\n\n" +
                            $"Müşteri: {context.Kullanicilar.Find(_musteriId).Ad} {context.Kullanicilar.Find(_musteriId).Soyad}\n" +
                            $"Araç: {arac.Model}\n" +
                            $"Plaka: {arac.Plaka}\n" +
                            $"Kiralama Tarihi: {kiralama.KiralamaTarihi:dd/MM/yyyy}\n" +
                            $"Teslim Tarihi: {kiralama.TeslimTarihi:dd/MM/yyyy}\n" +
                            $"Toplam Tutar: {toplamTutar:C}",
                            "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Araç başarıyla kiralandı ve ödeme tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AracListesiniYukle();
                }
                else
                {
                    MessageBox.Show("Ödeme başarısız. Kiralama işlemi iptal edildi.", "Ödeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen kiralamak istediğiniz aracı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGecmisiGor_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var kiralamaGecmisi = context.Kiralamalar
                    .Where(k => k.KullaniciId == _musteriId)
                    .Include(k => k.Arac)
                    .Include(k => k.Kullanici)
                    .ToList();

                var gosterilecekVeri = kiralamaGecmisi.Select(k => new
                {
                    k.Arac.Model,
                    k.Arac.Plaka,
                    k.KiralamaTarihi,
                    TeslimTarihi = k.TeslimTarihi.HasValue
                        ? k.TeslimTarihi.Value.ToString("dd/MM/yyyy")
                        : "Henüz Teslim Edilmedi"
                }).ToList();

                dgvKiralanmisAraclar.DataSource = gosterilecekVeri;
            }
        }

        private void dgvMevcutAraclar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMevcutAraclar.SelectedRows.Count > 0)
            {
                int aracId = Convert.ToInt32(dgvMevcutAraclar.SelectedRows[0].Cells["AracId"].Value);
                FotograflariGoster(aracId);
            }
        }
            private void FotograflariGoster(int aracId)
            {
                flowLayoutPanel1.Controls.Clear(); // Mevcut fotoğrafları temizle

                using (var context = new AracKiralamaContext())
                {
                    var fotograflar = context.AracFotograflar
                        .Where(f => f.AracId == aracId)
                        .Select(f => f.FotoData)
                        .ToList();

                    foreach (var foto in fotograflar)
                    {
                        var pb = new PictureBox();
                        pb.Image = Image.FromStream(new MemoryStream(foto));
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Width = 100;
                        pb.Height = 100;
                        flowLayoutPanel1.Controls.Add(pb);
                    }
                }
            }
        }
    }

