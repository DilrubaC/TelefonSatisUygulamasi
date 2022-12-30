using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisUygulamasi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            panelSayfalar.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Left;
            panelSayfalar.Controls.Add(frm);
            frm.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Formlar.frmTelefonListele telliste = new Formlar.frmTelefonListele();
            FormGetir(telliste);
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmYeniKullanici yeni = new frmYeniKullanici();
            FormGetir(yeni);
        }

        private void panelSayfalar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnTelefonEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmTelefonEkle telekle = new Formlar.frmTelefonEkle();
            FormGetir(telekle);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmMarkaEkle ekle = new Formlar.frmMarkaEkle();
            ekle.Show();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmModelEkle ekle = new Formlar.frmModelEkle  ();
            ekle.Show();
        }
    }
}
