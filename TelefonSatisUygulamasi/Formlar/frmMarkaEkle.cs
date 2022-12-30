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
    public partial class frmMarkaEkle : Form
    {
        public frmMarkaEkle()
        {
            InitializeComponent();
        }
        Classlar.Telefon tel = new Classlar.Telefon();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into TBLMarka values('"+txtMarka+"')";
            SqlCommand komut2 = new SqlCommand();
            tel.ESG(komut2, sorgu2);
        }
    }
}
