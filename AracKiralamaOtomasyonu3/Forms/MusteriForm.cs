using AracKiralamaOtomasyonu3.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    public partial class MusteriForm : Form
    {
        public int _musteriId;

        public MusteriForm(int musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;
            // Başlangıçta "Araçlar" içeriğini göster
            ShowControl(new AraclarControl(musteriId));
        }

        // Araçlar butonuna tıklandığında
        private void BtnAraclar_Click(object sender, EventArgs e)
        {
            ShowControl(new AraclarControl(_musteriId));
        }

        // Geçmiş Kiralamalar butonuna tıklandığında
        private void BtnGecmisKiralamalar_Click(object sender, EventArgs e)
        {
            ShowControl(new GecmisKiralamalarControl(_musteriId));
        }

        // Faturalar butonuna tıklandığında
        private void BtnFaturalar_Click(object sender, EventArgs e)
        {
            ShowControl(new FaturalarControl(_musteriId));
        }

        // İndirimler butonuna tıklandığında
        private void BtnIndirimler_Click(object sender, EventArgs e)
        {
            ShowControl(new IndirimlerControl());
        }

        // Yorum ve Puanlama butonuna tıklandığında
        private void BtnYorumPuanlama_Click(object sender, EventArgs e)
        {
            ShowControl(new YorumPuanlamaControl());
        }

        // Logout butonuna tıklandığında
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Çıkış yapmadan önce kullanıcıdan onay alalım
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Formu kapat ve LoginForm'u aç
                this.Hide(); // Ana formu gizle
                LoginForm loginForm = new LoginForm(); // LoginForm'u oluştur
                loginForm.Show(); // LoginForm'u göster
            }
        }

        // Ana panelde içerik göstermek için yardımcı metot
        private void ShowControl(UserControl control)
        {
            this.mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(control);
        }

        // Form kapanmadan önce kullanıcıya onay soralım
        private void MusteriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           

       
           
                Application.Exit();
            
        }
    }
}
