﻿using System;
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
    public partial class frmModelEkle : Form
    {
        public frmModelEkle()
        {
            InitializeComponent();
        }

        private void frmModelEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'telefonDataSet.TBLMarka' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLMarkaTableAdapter.Fill(this.telefonDataSet.TBLMarka);

        }
        Classlar.Telefon tel = new Classlar.Telefon();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into TBLModel values('"+comboMarka.SelectedValue+"','" + txtModel + "')";
            SqlCommand komut2 = new SqlCommand();
            tel.ESG(komut2, sorgu2);
        }
    }
}
