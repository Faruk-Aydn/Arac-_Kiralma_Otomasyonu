using AracKiralamaOtomasyonu3.Forms;
using System;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    public partial class KiralayanForm : Form
    {
        public int _kiralayanId;
        public KiralayanForm(int kiralayanId)
        {
            _kiralayanId = kiralayanId;
            InitializeComponent();
            ShowControl(new KiralanmamisControl(_kiralayanId));
        }

        private void BtnAvailableCars_Click(object sender, EventArgs e)
        {
            ShowControl(new KiralanmamisControl(_kiralayanId));
        }

        private void BtnRentedCars_Click(object sender, EventArgs e)
        {
            ShowControl(new KiralanmisControl(_kiralayanId));
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            ShowControl(new AddCarControl(_kiralayanId));
        }
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            // Müşteri kontrolünü göster
            ShowControl(new MusteriControl());
        }
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

        private void ShowControl(UserControl control)
        {
            this.mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(control);
        }

    
    }
}
