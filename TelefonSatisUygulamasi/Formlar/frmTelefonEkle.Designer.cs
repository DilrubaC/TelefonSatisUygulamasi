
namespace TelefonSatisUygulamasi.Formlar
{
    partial class frmTelefonEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.tBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonDataSet = new TelefonSatisUygulamasi.TelefonDataSet();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.fKTBLModelTBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.txtImeiNo = new System.Windows.Forms.TextBox();
            this.dateUretim = new System.Windows.Forms.DateTimePicker();
            this.dateGelis = new System.Windows.Forms.DateTimePicker();
            this.txtAlisFiyati = new System.Windows.Forms.MaskedTextBox();
            this.txtSatisFiyati = new System.Windows.Forms.MaskedTextBox();
            this.txtKDV = new System.Windows.Forms.MaskedTextBox();
            this.txtIslemci = new System.Windows.Forms.MaskedTextBox();
            this.txtIsletimSistemi = new System.Windows.Forms.MaskedTextBox();
            this.txtHafiza = new System.Windows.Forms.MaskedTextBox();
            this.txtCozunurluk = new System.Windows.Forms.MaskedTextBox();
            this.txtRenk = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.tBLMarkaTableAdapter = new TelefonSatisUygulamasi.TelefonDataSetTableAdapters.TBLMarkaTableAdapter();
            this.tBLModelTableAdapter = new TelefonSatisUygulamasi.TelefonDataSetTableAdapters.TBLModelTableAdapter();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMarka
            // 
            this.comboMarka.DataSource = this.tBLMarkaBindingSource;
            this.comboMarka.DisplayMember = "Marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(208, 12);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(177, 24);
            this.comboMarka.TabIndex = 0;
            // 
            // tBLMarkaBindingSource
            // 
            this.tBLMarkaBindingSource.DataMember = "TBLMarka";
            this.tBLMarkaBindingSource.DataSource = this.telefonDataSet;
            // 
            // telefonDataSet
            // 
            this.telefonDataSet.DataSetName = "TelefonDataSet";
            this.telefonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboModel
            // 
            this.comboModel.DataSource = this.fKTBLModelTBLMarkaBindingSource;
            this.comboModel.DisplayMember = "Model";
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(208, 53);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(177, 24);
            this.comboModel.TabIndex = 1;
            // 
            // fKTBLModelTBLMarkaBindingSource
            // 
            this.fKTBLModelTBLMarkaBindingSource.DataMember = "FK_TBLModel_TBLMarka";
            this.fKTBLModelTBLMarkaBindingSource.DataSource = this.tBLMarkaBindingSource;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(208, 94);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(177, 22);
            this.txtSeriNo.TabIndex = 2;
            // 
            // txtImeiNo
            // 
            this.txtImeiNo.Location = new System.Drawing.Point(208, 133);
            this.txtImeiNo.Name = "txtImeiNo";
            this.txtImeiNo.Size = new System.Drawing.Size(177, 22);
            this.txtImeiNo.TabIndex = 2;
            // 
            // dateUretim
            // 
            this.dateUretim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUretim.Location = new System.Drawing.Point(208, 172);
            this.dateUretim.Name = "dateUretim";
            this.dateUretim.Size = new System.Drawing.Size(177, 22);
            this.dateUretim.TabIndex = 3;
            // 
            // dateGelis
            // 
            this.dateGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGelis.Location = new System.Drawing.Point(208, 211);
            this.dateGelis.Name = "dateGelis";
            this.dateGelis.Size = new System.Drawing.Size(177, 22);
            this.dateGelis.TabIndex = 4;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(208, 250);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(177, 22);
            this.txtAlisFiyati.TabIndex = 5;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(208, 287);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(177, 22);
            this.txtSatisFiyati.TabIndex = 5;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(208, 361);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(177, 22);
            this.txtKDV.TabIndex = 5;
            // 
            // txtIslemci
            // 
            this.txtIslemci.Location = new System.Drawing.Point(208, 400);
            this.txtIslemci.Name = "txtIslemci";
            this.txtIslemci.Size = new System.Drawing.Size(177, 22);
            this.txtIslemci.TabIndex = 5;
            // 
            // txtIsletimSistemi
            // 
            this.txtIsletimSistemi.Location = new System.Drawing.Point(208, 439);
            this.txtIsletimSistemi.Name = "txtIsletimSistemi";
            this.txtIsletimSistemi.Size = new System.Drawing.Size(177, 22);
            this.txtIsletimSistemi.TabIndex = 5;
            // 
            // txtHafiza
            // 
            this.txtHafiza.Location = new System.Drawing.Point(208, 478);
            this.txtHafiza.Name = "txtHafiza";
            this.txtHafiza.Size = new System.Drawing.Size(177, 22);
            this.txtHafiza.TabIndex = 5;
            // 
            // txtCozunurluk
            // 
            this.txtCozunurluk.Location = new System.Drawing.Point(208, 517);
            this.txtCozunurluk.Name = "txtCozunurluk";
            this.txtCozunurluk.Size = new System.Drawing.Size(177, 22);
            this.txtCozunurluk.TabIndex = 5;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(208, 556);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(177, 22);
            this.txtRenk.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seri No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imei No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Üretim Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Geliş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "KDV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "İşlemci";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "İşletim Sistemi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Hafıza";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 520);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Çözünürlük";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 559);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Renk";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(143, 606);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 52);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(298, 606);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(140, 52);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(428, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(428, 175);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(139, 42);
            this.btnResimEkle.TabIndex = 9;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // tBLMarkaTableAdapter
            // 
            this.tBLMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // tBLModelTableAdapter
            // 
            this.tBLModelTableAdapter.ClearBeforeFill = true;
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(208, 327);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(177, 22);
            this.txtMiktari.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(101, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Miktarı";
            // 
            // frmTelefonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 710);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtCozunurluk);
            this.Controls.Add(this.txtHafiza);
            this.Controls.Add(this.txtIsletimSistemi);
            this.Controls.Add(this.txtIslemci);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.dateGelis);
            this.Controls.Add(this.dateUretim);
            this.Controls.Add(this.txtImeiNo);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.comboMarka);
            this.Name = "frmTelefonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmTelefonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.TextBox txtImeiNo;
        private System.Windows.Forms.DateTimePicker dateUretim;
        private System.Windows.Forms.DateTimePicker dateGelis;
        private System.Windows.Forms.MaskedTextBox txtAlisFiyati;
        private System.Windows.Forms.MaskedTextBox txtSatisFiyati;
        private System.Windows.Forms.MaskedTextBox txtKDV;
        private System.Windows.Forms.MaskedTextBox txtIslemci;
        private System.Windows.Forms.MaskedTextBox txtIsletimSistemi;
        private System.Windows.Forms.MaskedTextBox txtHafiza;
        private System.Windows.Forms.MaskedTextBox txtCozunurluk;
        private System.Windows.Forms.MaskedTextBox txtRenk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimEkle;
        private TelefonDataSet telefonDataSet;
        private System.Windows.Forms.BindingSource tBLMarkaBindingSource;
        private TelefonDataSetTableAdapters.TBLMarkaTableAdapter tBLMarkaTableAdapter;
        private System.Windows.Forms.BindingSource fKTBLModelTBLMarkaBindingSource;
        private TelefonDataSetTableAdapters.TBLModelTableAdapter tBLModelTableAdapter;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Label label15;
    }
}