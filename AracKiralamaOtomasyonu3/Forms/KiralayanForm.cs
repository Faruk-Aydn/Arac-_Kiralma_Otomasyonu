using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        private int _currentPhotoIndex = 0;
        private List<byte[]> _aracFotograflar = new List<byte[]>();

        public KiralayanForm(int kiralayanId)
        {
            InitializeComponent();
            _kiralayanId = kiralayanId;
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        byte[] fotoData = File.ReadAllBytes(filePath);
                        _aracFotograflar.Add(fotoData);
                    }
                    _currentPhotoIndex = _aracFotograflar.Count - openFileDialog.FileNames.Length; // Yeni eklenen resimlerin ilkine git
                    ShowPhoto();
                    MessageBox.Show("Fotoğraflar başarıyla yüklendi.");
                }
            }
        }

        private void dgvAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvAraclar.Rows[e.RowIndex];
                int aracId = (int)selectedRow.Cells["AracId"].Value;

                using (var context = new AracKiralamaContext())
                {
                    var arac = context.Araclar
                        .Include(a => a.FotografListesi)
                        .FirstOrDefault(a => a.AracId == aracId);

                    if (arac != null && arac.FotografListesi.Any())
                    {
                        _aracFotograflar = arac.FotografListesi.Select(f => f.FotoData).ToList();
                        _currentPhotoIndex = 0;
                        ShowPhoto();
                    }
                    else
                    {
                        pictureBoxAracResim.Image = null;
                        _aracFotograflar.Clear();
                    }
                }
            }
        }

        private void ShowPhoto()
        {
            if (_aracFotograflar.Count > 0)
            {
                using (var ms = new MemoryStream(_aracFotograflar[_currentPhotoIndex]))
                {
                    pictureBoxAracResim.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxAracResim.Image = null;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_aracFotograflar.Count > 0)
            {
                _currentPhotoIndex = (_currentPhotoIndex + 1) % _aracFotograflar.Count;
                ShowPhoto();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_aracFotograflar.Count > 0)
            {
                _currentPhotoIndex = (_currentPhotoIndex - 1 + _aracFotograflar.Count) % _aracFotograflar.Count;
                ShowPhoto();
            }
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                decimal fiyat;
                if (!decimal.TryParse(txtFiyat.Text, out fiyat))
                {
                    MessageBox.Show("Lütfen geçerli bir fiyat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var arac = new Arac
                {
                    Model = txtModel.Text,
                    Plaka = txtPlaka.Text,
                    Fiyat = fiyat,
                    KiralandiMi = false,
                    BakimTarihi = dtpBakimTarihi.Value,
                    FotografListesi = _aracFotograflar.Select(foto => new AracFotograf { FotoData = foto }).ToList()
                };

                context.Araclar.Add(arac);
                context.SaveChanges();

                MessageBox.Show("Araç ve fotoğraflar başarıyla eklendi!");
                ListeyiGuncelle();
                _aracFotograflar.Clear();
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

                var arac = context.Araclar.FirstOrDefault(a => a.Plaka.ToUpper() == plaka);

                if (arac != null)
                {
                    context.Araclar.Remove(arac);
                    context.SaveChanges();
                    MessageBox.Show("Araç başarıyla silindi!");
                    ListeyiGuncelle();
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı veya plaka hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKiralananAraclar_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var kiralananAraclar = context.Araclar
                    .Where(a => a.KiralandiMi == true)  // Kiralanmış araçları getir
                  .Select(a => new
                  {
                      a.AracId,
                      a.Model,
                      a.Plaka,
                      a.Fiyat,
                      a.KiralandiMi,
                      a.BakimTarihi
                  })
                    .ToList();

                dgvAraclar.DataSource = kiralananAraclar;
            }
        }

        private void btnKiralanmayanAraclar_Click(object sender, EventArgs e)
        {
            using (var context = new AracKiralamaContext())
            {
                var kiralanmayanAraclar = context.Araclar
                    .Where(a => a.KiralandiMi == false)  // Kiralanmamış araçları getir
                     .Select(a => new
                     {
                         a.AracId,
                         a.Model,
                         a.Plaka,
                         a.Fiyat,
                         a.KiralandiMi,
                         a.BakimTarihi
                     })
                    .ToList();

                dgvAraclar.DataSource = kiralanmayanAraclar;
            }
        }

        private void ListeyiGuncelle()
        {
            using (var context = new AracKiralamaContext())
            {
                var araclar = context.Araclar
                                     .Include(a => a.FotografListesi)
                                     .Select(a => new
                                     {
                                         a.AracId,
                                         a.Model,
                                         a.Plaka,
                                         a.Fiyat,
                                         a.KiralandiMi,
                                         a.BakimTarihi
                                         // FotografListesi'ni hariç tuttuk
                                     })
                                     .ToList();

                dgvAraclar.DataSource = araclar;
            }
        }

        private void KiralayanForm_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }
    }
}
