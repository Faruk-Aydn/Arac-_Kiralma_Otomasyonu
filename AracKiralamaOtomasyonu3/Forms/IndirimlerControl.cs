
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

public partial class IndirimlerControl : UserControl
{
    private FlowLayoutPanel discountPanel;
    private List<Discount> discounts;
    private bool discountApplied = false;

    // Event tanımlama
    public event Action<string, double> DiscountSelected;

    // lblBaslik added as a field
    private LabelControl lblBaslik;
    private Panel topPanel; // Panel for top section (title)

    public IndirimlerControl()
    {
        InitializeDiscounts();
        SetupUI();
    }

    private void InitializeDiscounts()
    {
        // Örnek indirimler (Resimleri Resource'dan alıyoruz)
        discounts = new List<Discount>
        {
            new Discount { Image = AracKiralamaOtomasyonu3.Properties.Resources.dizel, Description = "Dizel araçlar %5 indirim", DiscountId = 1 },
            new Discount { Image = AracKiralamaOtomasyonu3.Properties.Resources.benzin, Description = "Benzinli araçlarda %8 indirim", DiscountId = 2 },
            new Discount { Image = AracKiralamaOtomasyonu3.Properties.Resources.indirim, Description = "Günlük kiralama ücreti 13.000 TL'den yüksek araçlarda %15 indirim", DiscountId = 3 }
        };
    }

    private void SetupUI()
    {
        this.Controls.Clear();

        // Arka plan rengini güncelleme
        this.BackColor = Color.FromArgb(30, 30, 45); // Daha koyu ve modern bir renk

        // Başlık (lblBaslik) oluşturuluyor
        lblBaslik = new LabelControl
        {
            Appearance = { Font = new Font("Segoe UI", 16F, FontStyle.Bold), ForeColor = Color.White },
            Dock = DockStyle.Top,
            Text = "İNDİRİMLER",
            Padding = new Padding(10, 20, 10, 10),
            Height = 67
        };

        // Top panel (header panel) for the title
        topPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 67,  // Match height with lblBaslik
            BackColor = Color.FromArgb(30, 30, 45) // Matching background color
        };

        // Adding the title label to the top panel
        topPanel.Controls.Add(lblBaslik);

        // FlowLayoutPanel için yeni stil
        discountPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            Padding = new Padding(10),
            BackColor = Color.FromArgb(30, 30, 45), // Arka plan rengini aynen kullanıyoruz
        };

        // İndirim panellerini eklemek
        foreach (var discount in discounts)
        {
            var panel = CreateDiscountPanel(discount);
            discountPanel.Controls.Add(panel);
        }

        // Kontrolün üst kısmına başlık ekleniyor ve discount paneli altına yerleştiriliyor
        this.Controls.Add(discountPanel);
        this.Controls.Add(topPanel); // Ensure the title is at the top
    }

    private Panel CreateDiscountPanel(Discount discount)
    {
        var panel = new Panel
        {
            Width = 300,
            Height = 230,
            Margin = new Padding(10),
            BackColor = Color.FromArgb(30, 30, 45), // Panel arka planı daha koyu
            BorderStyle = BorderStyle.None, // Daha modern görünüm için kenarlık yok
            Padding = new Padding(5)
        };

        // Resim kutusu (daha modern bir kenarlık ve rounded köşeler)
        var pictureBox = new PictureBox
        {
            Image = discount.Image,
            SizeMode = PictureBoxSizeMode.StretchImage,
            Dock = DockStyle.Top,
            Height = 120,
            BorderStyle = BorderStyle.FixedSingle, // Modern bir kenarlık ekledik
            Margin = new Padding(5),
            BackColor = Color.White, // Resim etrafında beyaz bir alan bırakıyoruz
            Cursor = Cursors.Hand // Resme tıklanabilir gösterimi ekliyoruz
        };

        var label = new Label
        {
            Text = discount.Description,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            ForeColor = Color.White, // Yazı rengini beyaz yapıyoruz
            Padding = new Padding(5),
            Cursor = Cursors.Hand // Etkileşim için tıklanabilir
        };

        pictureBox.Click += (sender, e) => ApplyDiscount(discount);
        label.Click += (sender, e) => ApplyDiscount(discount);

        panel.Controls.Add(label);
        panel.Controls.Add(pictureBox);

        return panel;
    }

    private void ApplyDiscount(Discount discount)
    {
        if (discountApplied)
        {
            MessageBox.Show("Zaten bir indirim uyguladınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        discountApplied = true;
        MessageBox.Show($"{discount.Description} uygulandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Kiralanmamış araçlara indirim uygulanır.
        ApplyDiscountToVehicles(discount);

        // Event yayınlama
        OnDiscountSelected(discount.Description, GetDiscountPercentage(discount.DiscountId));
    }

    private void ApplyDiscountToVehicles(Discount discount)
    {
        using (var context = new AracKiralamaContext())
        {
            // İndirim türüne göre araçları filtrele
            List<Arac> discountedCars;

            if (discount.DiscountId == 1) // Dizel araçlar için %5 indirim
            {
                discountedCars = context.Araclar
                                        .Where(a => !a.KiralandiMi && a.YakitCinsi == "Dizel")
                                        .ToList();
            }
            else if (discount.DiscountId == 2) // Benzinli araçlar için %8 indirim
            {
                discountedCars = context.Araclar
                                        .Where(a => !a.KiralandiMi && a.YakitCinsi == "Benzinli")
                                        .ToList();
            }
            else if (discount.DiscountId == 3) // 13.000 TL'den yüksek araçlar için %15 indirim
            {
                discountedCars = context.Araclar
                                        .Where(a => !a.KiralandiMi && a.Fiyat > 13000)
                                        .ToList();
            }
            else
            {
                discountedCars = new List<Arac>(); // Geçersiz indirim türü
            }

            // İndirim simgesini byte[] formatına dönüştürme
            byte[] discountImage = ImageToByteArray(AracKiralamaOtomasyonu3.Properties.Resources.discount2);

            // Her bir araca indirim uygula
            foreach (var car in discountedCars)
            {
                decimal discountedPrice = car.Fiyat - car.Fiyat * (decimal)(discount.DiscountId == 1 ? 0.05 : discount.DiscountId == 2 ? 0.08 : 0.15);
                car.Fiyat = discountedPrice;
                car.IndirimliFiyat = discountedPrice;
                car.IndirimResmi = discountImage; // İndirim simgesini byte[] olarak sakla
            }

            // Değişiklikleri veritabanına kaydet
            context.SaveChanges();

            MessageBox.Show($"{discount.Description} ile indirim uygulandı.", "İndirim Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Bitmap'i byte[] formatına dönüştürme yardımcı metodu
    private byte[] ImageToByteArray(System.Drawing.Image image)
    {
        using (var memoryStream = new System.IO.MemoryStream())
        {
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png); // Resmi PNG formatında kaydediyoruz
            return memoryStream.ToArray();
        }
    }

    // Event tetikleyicisi
    private void OnDiscountSelected(string discountDescription, double discountPercentage)
    {
        DiscountSelected?.Invoke(discountDescription, discountPercentage);
    }

    // İndirim yüzdesi alma (DiscountId'ye göre)
    private double GetDiscountPercentage(int discountId)
    {
        switch (discountId)
        {
            case 1:
                return 5; // Dizel araçlar %5 indirim
            case 2:
                return 8; // Benzinli araçlar %8 indirim
            case 3:
                return 15; // 13K üzeri araçlar %15 indirim
            default:
                return 0;
        }
    }
}

public class Discount
{
    public Image Image { get; set; }
    public string Description { get; set; }
    public int DiscountId { get; set; }
}