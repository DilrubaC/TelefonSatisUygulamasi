
namespace TelefonSatisUygulamasi.Formlar
{
    partial class frmTelefonListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateGelis = new System.Windows.Forms.DateTimePicker();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTelefonMarkaAra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnMarkaModelGuncelle = new System.Windows.Forms.Button();
            this.lblYeniModel = new System.Windows.Forms.Label();
            this.lblYeniMarka = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.MaskedTextBox();
            this.txtCozunurluk = new System.Windows.Forms.MaskedTextBox();
            this.txtHafiza = new System.Windows.Forms.MaskedTextBox();
            this.txtIsletimSistemi = new System.Windows.Forms.MaskedTextBox();
            this.txtIslemci = new System.Windows.Forms.MaskedTextBox();
            this.txtKDV = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.MaskedTextBox();
            this.txtAlisFiyati = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateUretim = new System.Windows.Forms.DateTimePicker();
            this.txtImeiNo = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.fKTBLModelTBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonDataSet = new TelefonSatisUygulamasi.TelefonDataSet();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.tBLMarkaTableAdapter = new TelefonSatisUygulamasi.TelefonDataSetTableAdapters.TBLMarkaTableAdapter();
            this.tBLModelTableAdapter = new TelefonSatisUygulamasi.TelefonDataSetTableAdapters.TBLModelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateGelis);
            this.panel1.Controls.Add(this.btnResimEkle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTelefonMarkaAra);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnMarkaModelGuncelle);
            this.panel1.Controls.Add(this.lblYeniModel);
            this.panel1.Controls.Add(this.lblYeniMarka);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtRenk);
            this.panel1.Controls.Add(this.txtCozunurluk);
            this.panel1.Controls.Add(this.txtHafiza);
            this.panel1.Controls.Add(this.txtIsletimSistemi);
            this.panel1.Controls.Add(this.txtIslemci);
            this.panel1.Controls.Add(this.txtKDV);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtMiktari);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSatisFiyati);
            this.panel1.Controls.Add(this.txtAlisFiyati);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateUretim);
            this.panel1.Controls.Add(this.txtImeiNo);
            this.panel1.Controls.Add(this.txtSeriNo);
            this.panel1.Controls.Add(this.comboModel);
            this.panel1.Controls.Add(this.comboMarka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 330);
            this.panel1.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtID.Location = new System.Drawing.Point(128, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(177, 22);
            this.txtID.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Geliş Tarihi";
            // 
            // dateGelis
            // 
            this.dateGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGelis.Location = new System.Drawing.Point(129, 194);
            this.dateGelis.Name = "dateGelis";
            this.dateGelis.Size = new System.Drawing.Size(177, 22);
            this.dateGelis.TabIndex = 47;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(640, 218);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(139, 42);
            this.btnResimEkle.TabIndex = 45;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(640, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txtTelefonMarkaAra
            // 
            this.txtTelefonMarkaAra.Location = new System.Drawing.Point(905, 48);
            this.txtTelefonMarkaAra.Name = "txtTelefonMarkaAra";
            this.txtTelefonMarkaAra.Size = new System.Drawing.Size(229, 22);
            this.txtTelefonMarkaAra.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(811, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "Telefon Ara";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(830, 180);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 45);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(830, 240);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(112, 45);
            this.btnIptal.TabIndex = 40;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(830, 123);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 45);
            this.btnGuncelle.TabIndex = 39;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnMarkaModelGuncelle
            // 
            this.btnMarkaModelGuncelle.BackColor = System.Drawing.Color.White;
            this.btnMarkaModelGuncelle.Location = new System.Drawing.Point(462, 59);
            this.btnMarkaModelGuncelle.Name = "btnMarkaModelGuncelle";
            this.btnMarkaModelGuncelle.Size = new System.Drawing.Size(149, 45);
            this.btnMarkaModelGuncelle.TabIndex = 37;
            this.btnMarkaModelGuncelle.Text = "Marka Model Güncelle";
            this.btnMarkaModelGuncelle.UseVisualStyleBackColor = false;
            this.btnMarkaModelGuncelle.Click += new System.EventHandler(this.btnMarkaModelGuncelle_Click);
            // 
            // lblYeniModel
            // 
            this.lblYeniModel.AutoSize = true;
            this.lblYeniModel.Location = new System.Drawing.Point(338, 88);
            this.lblYeniModel.Name = "lblYeniModel";
            this.lblYeniModel.Size = new System.Drawing.Size(78, 17);
            this.lblYeniModel.TabIndex = 36;
            this.lblYeniModel.Text = "Yeni Model";
            // 
            // lblYeniMarka
            // 
            this.lblYeniMarka.AutoSize = true;
            this.lblYeniMarka.Location = new System.Drawing.Point(338, 63);
            this.lblYeniMarka.Name = "lblYeniMarka";
            this.lblYeniMarka.Size = new System.Drawing.Size(79, 17);
            this.lblYeniMarka.TabIndex = 35;
            this.lblYeniMarka.Text = "Yeni Marka";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Renk";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Çözünürlük";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Hafıza";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "İşletim Sistemi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "İşlemci";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "KDV";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(434, 277);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(177, 22);
            this.txtRenk.TabIndex = 23;
            // 
            // txtCozunurluk
            // 
            this.txtCozunurluk.Location = new System.Drawing.Point(434, 249);
            this.txtCozunurluk.Name = "txtCozunurluk";
            this.txtCozunurluk.Size = new System.Drawing.Size(177, 22);
            this.txtCozunurluk.TabIndex = 24;
            // 
            // txtHafiza
            // 
            this.txtHafiza.Location = new System.Drawing.Point(434, 220);
            this.txtHafiza.Name = "txtHafiza";
            this.txtHafiza.Size = new System.Drawing.Size(177, 22);
            this.txtHafiza.TabIndex = 25;
            // 
            // txtIsletimSistemi
            // 
            this.txtIsletimSistemi.Location = new System.Drawing.Point(434, 192);
            this.txtIsletimSistemi.Name = "txtIsletimSistemi";
            this.txtIsletimSistemi.Size = new System.Drawing.Size(177, 22);
            this.txtIsletimSistemi.TabIndex = 26;
            // 
            // txtIslemci
            // 
            this.txtIslemci.Location = new System.Drawing.Point(434, 163);
            this.txtIslemci.Name = "txtIslemci";
            this.txtIslemci.Size = new System.Drawing.Size(177, 22);
            this.txtIslemci.TabIndex = 27;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(434, 135);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(177, 22);
            this.txtKDV.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 287);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 17);
            this.label20.TabIndex = 22;
            this.label20.Text = "Miktarı";
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(128, 284);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(177, 22);
            this.txtMiktari.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Alış Fiyatı";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(128, 254);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(177, 22);
            this.txtSatisFiyati.TabIndex = 17;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(128, 224);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(177, 22);
            this.txtAlisFiyati.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Üretim Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Imei No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seri No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Marka";
            // 
            // dateUretim
            // 
            this.dateUretim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUretim.Location = new System.Drawing.Point(128, 165);
            this.dateUretim.Name = "dateUretim";
            this.dateUretim.Size = new System.Drawing.Size(177, 22);
            this.dateUretim.TabIndex = 11;
            // 
            // txtImeiNo
            // 
            this.txtImeiNo.Location = new System.Drawing.Point(128, 135);
            this.txtImeiNo.Name = "txtImeiNo";
            this.txtImeiNo.Size = new System.Drawing.Size(177, 22);
            this.txtImeiNo.TabIndex = 9;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(128, 106);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(177, 22);
            this.txtSeriNo.TabIndex = 10;
            // 
            // comboModel
            // 
            this.comboModel.DataSource = this.fKTBLModelTBLMarkaBindingSource;
            this.comboModel.DisplayMember = "Model";
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(128, 74);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(177, 24);
            this.comboModel.TabIndex = 8;
            // 
            // fKTBLModelTBLMarkaBindingSource
            // 
            this.fKTBLModelTBLMarkaBindingSource.DataMember = "FK_TBLModel_TBLMarka";
            this.fKTBLModelTBLMarkaBindingSource.DataSource = this.tBLMarkaBindingSource;
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
            // comboMarka
            // 
            this.comboMarka.DataSource = this.tBLMarkaBindingSource;
            this.comboMarka.DisplayMember = "Marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(128, 44);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(177, 24);
            this.comboMarka.TabIndex = 7;
            // 
            // tBLMarkaTableAdapter
            // 
            this.tBLMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // tBLModelTableAdapter
            // 
            this.tBLModelTableAdapter.ClearBeforeFill = true;
            // 
            // frmTelefonListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1150, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTelefonListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmTelefonListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateUretim;
        private System.Windows.Forms.TextBox txtImeiNo;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtSatisFiyati;
        private System.Windows.Forms.MaskedTextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtTelefonMarkaAra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnMarkaModelGuncelle;
        private System.Windows.Forms.Label lblYeniModel;
        private System.Windows.Forms.Label lblYeniMarka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtRenk;
        private System.Windows.Forms.MaskedTextBox txtCozunurluk;
        private System.Windows.Forms.MaskedTextBox txtHafiza;
        private System.Windows.Forms.MaskedTextBox txtIsletimSistemi;
        private System.Windows.Forms.MaskedTextBox txtIslemci;
        private System.Windows.Forms.MaskedTextBox txtKDV;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateGelis;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label15;
        private TelefonDataSet telefonDataSet;
        private System.Windows.Forms.BindingSource tBLMarkaBindingSource;
        private TelefonDataSetTableAdapters.TBLMarkaTableAdapter tBLMarkaTableAdapter;
        private System.Windows.Forms.BindingSource fKTBLModelTBLMarkaBindingSource;
        private TelefonDataSetTableAdapters.TBLModelTableAdapter tBLModelTableAdapter;
    }
}