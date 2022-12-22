
namespace TelefonSatisUygulamasi
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTelefonEkle = new System.Windows.Forms.Button();
            this.btnTelefonListele = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnKullaniciListele = new System.Windows.Forms.Button();
            this.btnMüsteriEkle = new System.Windows.Forms.Button();
            this.btnMüsteriListele = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnYapilanSatislar = new System.Windows.Forms.Button();
            this.panelSayfalar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnYapilanSatislar);
            this.panel1.Controls.Add(this.btnSatisYap);
            this.panel1.Controls.Add(this.btnMüsteriListele);
            this.panel1.Controls.Add(this.btnMüsteriEkle);
            this.panel1.Controls.Add(this.btnKullaniciListele);
            this.panel1.Controls.Add(this.btnKullaniciEkle);
            this.panel1.Controls.Add(this.btnTelefonListele);
            this.panel1.Controls.Add(this.btnTelefonEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTelefonEkle
            // 
            this.btnTelefonEkle.Location = new System.Drawing.Point(73, 12);
            this.btnTelefonEkle.Name = "btnTelefonEkle";
            this.btnTelefonEkle.Size = new System.Drawing.Size(94, 73);
            this.btnTelefonEkle.TabIndex = 0;
            this.btnTelefonEkle.Text = "Telefon Ekle";
            this.btnTelefonEkle.UseVisualStyleBackColor = true;
            // 
            // btnTelefonListele
            // 
            this.btnTelefonListele.Location = new System.Drawing.Point(187, 12);
            this.btnTelefonListele.Name = "btnTelefonListele";
            this.btnTelefonListele.Size = new System.Drawing.Size(94, 73);
            this.btnTelefonListele.TabIndex = 0;
            this.btnTelefonListele.Text = "Telefon Listele";
            this.btnTelefonListele.UseVisualStyleBackColor = true;
            this.btnTelefonListele.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(305, 12);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(94, 73);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnKullaniciListele
            // 
            this.btnKullaniciListele.Location = new System.Drawing.Point(420, 12);
            this.btnKullaniciListele.Name = "btnKullaniciListele";
            this.btnKullaniciListele.Size = new System.Drawing.Size(94, 73);
            this.btnKullaniciListele.TabIndex = 0;
            this.btnKullaniciListele.Text = "Kullanıcı Listele";
            this.btnKullaniciListele.UseVisualStyleBackColor = true;
            // 
            // btnMüsteriEkle
            // 
            this.btnMüsteriEkle.Location = new System.Drawing.Point(534, 12);
            this.btnMüsteriEkle.Name = "btnMüsteriEkle";
            this.btnMüsteriEkle.Size = new System.Drawing.Size(94, 73);
            this.btnMüsteriEkle.TabIndex = 0;
            this.btnMüsteriEkle.Text = "Müşteri Ekle";
            this.btnMüsteriEkle.UseVisualStyleBackColor = true;
            // 
            // btnMüsteriListele
            // 
            this.btnMüsteriListele.Location = new System.Drawing.Point(649, 12);
            this.btnMüsteriListele.Name = "btnMüsteriListele";
            this.btnMüsteriListele.Size = new System.Drawing.Size(94, 73);
            this.btnMüsteriListele.TabIndex = 0;
            this.btnMüsteriListele.Text = "Müşteri Listele";
            this.btnMüsteriListele.UseVisualStyleBackColor = true;
            this.btnMüsteriListele.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(762, 12);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(94, 73);
            this.btnSatisYap.TabIndex = 0;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnYapilanSatislar
            // 
            this.btnYapilanSatislar.Location = new System.Drawing.Point(876, 12);
            this.btnYapilanSatislar.Name = "btnYapilanSatislar";
            this.btnYapilanSatislar.Size = new System.Drawing.Size(94, 73);
            this.btnYapilanSatislar.TabIndex = 0;
            this.btnYapilanSatislar.Text = "Yapılan Satışlar";
            this.btnYapilanSatislar.UseVisualStyleBackColor = true;
            this.btnYapilanSatislar.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelSayfalar
            // 
            this.panelSayfalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSayfalar.Location = new System.Drawing.Point(0, 100);
            this.panelSayfalar.Name = "panelSayfalar";
            this.panelSayfalar.Size = new System.Drawing.Size(1057, 631);
            this.panelSayfalar.TabIndex = 2;
            this.panelSayfalar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSayfalar_Paint);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1057, 731);
            this.Controls.Add(this.panelSayfalar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Satış Otomasyonu Ana Sayfa ";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnMüsteriListele;
        private System.Windows.Forms.Button btnMüsteriEkle;
        private System.Windows.Forms.Button btnKullaniciListele;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnTelefonListele;
        private System.Windows.Forms.Button btnTelefonEkle;
        private System.Windows.Forms.Button btnYapilanSatislar;
        private System.Windows.Forms.Panel panelSayfalar;
    }
}

