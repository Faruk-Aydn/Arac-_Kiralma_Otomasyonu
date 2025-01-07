using System;
using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    partial class KiralayanForm
    {
        private Panel sideMenuPanel;
        private Panel mainPanel;
        private Button btnAvailableCars;
        private Button btnRentedCars;
        private Button btnAddCar;
        private Button BtnCustomers;
        private Button btnLogout;

        private PictureBox logoPictureBox; // Logo için alan

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralayanForm));
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnRentedCars = new System.Windows.Forms.Button();
            this.btnAvailableCars = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sideMenuPanel.Controls.Add(this.btnAddCar);
            this.sideMenuPanel.Controls.Add(this.btnRentedCars);
            this.sideMenuPanel.Controls.Add(this.btnAvailableCars);
            this.sideMenuPanel.Controls.Add(this.BtnCustomers);
            this.sideMenuPanel.Controls.Add(this.btnLogout);
            this.sideMenuPanel.Controls.Add(this.logoPictureBox);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 700);
            this.sideMenuPanel.TabIndex = 1;
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAddCar.FlatAppearance.BorderSize = 0;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCar.Image")));
            this.btnAddCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.Location = new System.Drawing.Point(0, 271);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(200, 50);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = " Araç Ekle";
            this.btnAddCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // btnRentedCars
            // 
            this.btnRentedCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRentedCars.FlatAppearance.BorderSize = 0;
            this.btnRentedCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentedCars.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRentedCars.ForeColor = System.Drawing.Color.White;
            this.btnRentedCars.Image = ((System.Drawing.Image)(resources.GetObject("btnRentedCars.Image")));
            this.btnRentedCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentedCars.Location = new System.Drawing.Point(3, 215);
            this.btnRentedCars.Name = "btnRentedCars";
            this.btnRentedCars.Size = new System.Drawing.Size(200, 50);
            this.btnRentedCars.TabIndex = 1;
            this.btnRentedCars.Text = " Kiralanmış Araçlar";
            this.btnRentedCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRentedCars.UseVisualStyleBackColor = false;
            this.btnRentedCars.Click += new System.EventHandler(this.BtnRentedCars_Click);
            // 
            // btnAvailableCars
            // 
            this.btnAvailableCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAvailableCars.FlatAppearance.BorderSize = 0;
            this.btnAvailableCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailableCars.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAvailableCars.ForeColor = System.Drawing.Color.White;
            this.btnAvailableCars.Image = ((System.Drawing.Image)(resources.GetObject("btnAvailableCars.Image")));
            this.btnAvailableCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableCars.Location = new System.Drawing.Point(3, 159);
            this.btnAvailableCars.Name = "btnAvailableCars";
            this.btnAvailableCars.Size = new System.Drawing.Size(200, 50);
            this.btnAvailableCars.TabIndex = 2;
            this.btnAvailableCars.Text = " Kiralanmamış Araçlar";
            this.btnAvailableCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvailableCars.UseVisualStyleBackColor = false;
            this.btnAvailableCars.Click += new System.EventHandler(this.BtnAvailableCars_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCustomers.FlatAppearance.BorderSize = 0;
            this.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomers.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCustomers.ForeColor = System.Drawing.Color.White;
            this.BtnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomers.Image")));
            this.BtnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.Location = new System.Drawing.Point(0, 327);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(200, 50);
            this.BtnCustomers.TabIndex = 3;
            this.BtnCustomers.Text = " Müşteriler";
            this.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-3, 386);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = " Çıkış Yap";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.logoPictureBox.Image = global::AracKiralamaOtomasyonu3.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(200, 164);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(840, 700);
            this.mainPanel.TabIndex = 0;
            // 
            // KiralayanForm
            // 
            this.ClientSize = new System.Drawing.Size(1040, 700);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KiralayanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiralayan Formu";
            this.sideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
