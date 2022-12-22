using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisUygulamasi.Classlar
{
    class Kullanici
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Telefon;Integrated Security=True;Pooling=False");
        private string adisoyadi;
        private string telefon;
        string adres;
        string email;
        string kullaniciadi;
        string sifre;
        string gorevi;
        string resim;

        public string AdiSoyadi1
        {
            get
            { return adisoyadi; }
            set
            { adisoyadi = value; }
        }

        public string Adres { get => adres; set => adres = value; }
        public string Email { get => email; set => email = value; }
        public string Kullaniciadi { get => kullaniciadi; set => kullaniciadi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Gorevi { get => gorevi; set => gorevi = value; }
        public string Resim { get => resim; set => resim = value; }
        public void KullaniciGirisi(TextBox sifretxt, TextBox kullaniciaditxt)
        {
            if (kullaniciaditxt.Text == "" || sifretxt.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
               SqlCommand komut = new SqlCommand("select * from kullanici where kullaniciadi ='"+kullaniciaditxt.Text + "' and sifre = '"+sifretxt.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    frmAnaSayfa anasayfa = new frmAnaSayfa();
                    frmKullaniciGirisi.ActiveForm.Visible = false;
                    anasayfa.Show();
                                    }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve/veya şifrenizi kontrol ediniz!!!", "Uyarı-2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }
            }
        }


    }
}
