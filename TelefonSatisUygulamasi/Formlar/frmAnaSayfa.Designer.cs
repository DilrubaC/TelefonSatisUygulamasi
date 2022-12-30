
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnModelEkle = new System.Windows.Forms.Button();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.btnKullaniciListele = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnTelefonListele = new System.Windows.Forms.Button();
            this.btnTelefonEkle = new System.Windows.Forms.Button();
            this.panelSayfalar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnModelEkle);
            this.panel1.Controls.Add(this.btnMarkaEkle);
            this.panel1.Controls.Add(this.btnKullaniciListele);
            this.panel1.Controls.Add(this.btnKullaniciEkle);
            this.panel1.Controls.Add(this.btnTelefonListele);
            this.panel1.Controls.Add(this.btnTelefonEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageKey = "logout.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(709, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Çıkış";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-contact.png");
            this.ımageList1.Images.SetKeyName(1, "add-user.png");
            this.ımageList1.Images.SetKeyName(2, "add-userr.png");
            this.ımageList1.Images.SetKeyName(3, "call-log.png");
            this.ımageList1.Images.SetKeyName(4, "contact-list.png");
            this.ımageList1.Images.SetKeyName(5, "guest-list.png");
            this.ımageList1.Images.SetKeyName(6, "price-tag.png");
            this.ımageList1.Images.SetKeyName(7, "sales.png");
            this.ımageList1.Images.SetKeyName(8, "logout.png");
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.BackColor = System.Drawing.Color.White;
            this.btnModelEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModelEkle.ImageKey = "sales.png";
            this.btnModelEkle.ImageList = this.ımageList1;
            this.btnModelEkle.Location = new System.Drawing.Point(599, 12);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(94, 82);
            this.btnModelEkle.TabIndex = 2;
            this.btnModelEkle.Text = "Model Ekle";
            this.btnModelEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModelEkle.UseVisualStyleBackColor = false;
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.BackColor = System.Drawing.Color.White;
            this.btnMarkaEkle.ImageKey = "logout.png";
            this.btnMarkaEkle.ImageList = this.ımageList1;
            this.btnMarkaEkle.Location = new System.Drawing.Point(491, 15);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(94, 82);
            this.btnMarkaEkle.TabIndex = 1;
            this.btnMarkaEkle.Text = "Marka Ekle";
            this.btnMarkaEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarkaEkle.UseVisualStyleBackColor = false;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // btnKullaniciListele
            // 
            this.btnKullaniciListele.BackColor = System.Drawing.Color.White;
            this.btnKullaniciListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullaniciListele.ImageKey = "guest-list.png";
            this.btnKullaniciListele.ImageList = this.ımageList1;
            this.btnKullaniciListele.Location = new System.Drawing.Point(373, 12);
            this.btnKullaniciListele.Name = "btnKullaniciListele";
            this.btnKullaniciListele.Size = new System.Drawing.Size(94, 82);
            this.btnKullaniciListele.TabIndex = 0;
            this.btnKullaniciListele.Text = "Kullanıcı Listele";
            this.btnKullaniciListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullaniciListele.UseVisualStyleBackColor = false;
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BackColor = System.Drawing.Color.White;
            this.btnKullaniciEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullaniciEkle.ImageKey = "add-user.png";
            this.btnKullaniciEkle.ImageList = this.ımageList1;
            this.btnKullaniciEkle.Location = new System.Drawing.Point(258, 12);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(94, 82);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnTelefonListele
            // 
            this.btnTelefonListele.BackColor = System.Drawing.Color.White;
            this.btnTelefonListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTelefonListele.ImageKey = "call-log.png";
            this.btnTelefonListele.ImageList = this.ımageList1;
            this.btnTelefonListele.Location = new System.Drawing.Point(140, 12);
            this.btnTelefonListele.Name = "btnTelefonListele";
            this.btnTelefonListele.Size = new System.Drawing.Size(94, 82);
            this.btnTelefonListele.TabIndex = 0;
            this.btnTelefonListele.Text = "Telefon Listele";
            this.btnTelefonListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTelefonListele.UseVisualStyleBackColor = false;
            this.btnTelefonListele.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTelefonEkle
            // 
            this.btnTelefonEkle.BackColor = System.Drawing.Color.White;
            this.btnTelefonEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTelefonEkle.ImageKey = "add-contact.png";
            this.btnTelefonEkle.ImageList = this.ımageList1;
            this.btnTelefonEkle.Location = new System.Drawing.Point(26, 12);
            this.btnTelefonEkle.Name = "btnTelefonEkle";
            this.btnTelefonEkle.Size = new System.Drawing.Size(94, 82);
            this.btnTelefonEkle.TabIndex = 0;
            this.btnTelefonEkle.Text = "Telefon Ekle";
            this.btnTelefonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTelefonEkle.UseVisualStyleBackColor = false;
            this.btnTelefonEkle.Click += new System.EventHandler(this.btnTelefonEkle_Click);
            // 
            // panelSayfalar
            // 
            this.panelSayfalar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSayfalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSayfalar.Location = new System.Drawing.Point(0, 100);
            this.panelSayfalar.Name = "panelSayfalar";
            this.panelSayfalar.Size = new System.Drawing.Size(842, 651);
            this.panelSayfalar.TabIndex = 2;
            this.panelSayfalar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSayfalar_Paint);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(842, 751);
            this.Controls.Add(this.panelSayfalar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Satış Otomasyonu Ana Sayfa ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKullaniciListele;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnTelefonListele;
        private System.Windows.Forms.Button btnTelefonEkle;
        private System.Windows.Forms.Panel panelSayfalar;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModelEkle;
    }
}

// dilruba çoban 