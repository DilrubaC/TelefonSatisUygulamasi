
namespace TelefonSatisUygulamasi.Formlar
{
    partial class frmModelEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.tBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonDataSet = new TelefonSatisUygulamasi.TelefonDataSet();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tBLMarkaTableAdapter = new TelefonSatisUygulamasi.TelefonDataSetTableAdapters.TBLMarkaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marka";
            // 
            // comboMarka
            // 
            this.comboMarka.DataSource = this.tBLMarkaBindingSource;
            this.comboMarka.DisplayMember = "Marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(113, 39);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(177, 24);
            this.comboMarka.TabIndex = 7;
            this.comboMarka.ValueMember = "id";
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
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(113, 79);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(177, 22);
            this.txtModel.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(113, 119);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(180, 41);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tBLMarkaTableAdapter
            // 
            this.tBLMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // frmModelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 208);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMarka);
            this.Name = "frmModelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmModelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnEkle;
        private TelefonDataSet telefonDataSet;
        private System.Windows.Forms.BindingSource tBLMarkaBindingSource;
        private TelefonDataSetTableAdapters.TBLMarkaTableAdapter tBLMarkaTableAdapter;
    }
}