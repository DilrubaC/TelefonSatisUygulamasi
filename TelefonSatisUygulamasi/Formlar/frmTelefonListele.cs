using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisUygulamasi.Formlar
{
    public partial class frmTelefonListele : Form
    {
        public frmTelefonListele()
        {
            InitializeComponent();
        }

        TelefonDataSetTableAdapters.UrunTableAdapter ds = new TelefonDataSetTableAdapters.UrunTableAdapter();
        private void frmTelefonListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'telefonDataSet.TBLModel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLModelTableAdapter.Fill(this.telefonDataSet.TBLModel);
            // TODO: Bu kod satırı 'telefonDataSet.TBLMarka' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLMarkaTableAdapter.Fill(this.telefonDataSet.TBLMarka);
            dataGridView1.DataSource = ds.listele2();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblYeniMarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblYeniModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSeriNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtImeiNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAlisFiyati.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtSatisFiyati.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtKDV.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtIslemci.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtIsletimSistemi.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtHafiza.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtCozunurluk.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtMiktari.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog()==DialogResult.OK)
                pictureBox1.ImageLocation = file.FileName;
        }

        private void btnMarkaModelGuncelle_Click(object sender, EventArgs e)
        {
            lblYeniMarka.Text = comboMarka.Text;
            lblYeniModel.Text = comboModel.Text;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Classlar.Telefon tel = new Classlar.Telefon();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update urun set marka='"+lblYeniMarka.Text+"',model= '"+lblYeniModel.Text+"' ,alisfiyati = '"+double.Parse(txtAlisFiyati.Text)+"',satisfiyati='" + double.Parse(txtSatisFiyati.Text) + "',miktari='"+int.Parse(txtMiktari.Text)+"' where ID='"+txtID.Text+"'";
            SqlCommand komut2 = new SqlCommand();
            tel.ESG(komut2, sorgu2);
            dataGridView1.DataSource = ds.listele2();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from urun where ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
            SqlCommand komut2 = new SqlCommand();
            tel.ESG(komut2, sorgu2);
            dataGridView1.DataSource = ds.listele2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
