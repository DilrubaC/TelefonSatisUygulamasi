using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisUygulamasi.Classlar
{
    class Telefon
    {
        SqlConnection baglanti = new SqlConnection(Veritabani.strbaglanti);
       public int ESG(SqlCommand komut , string sorgu )// ComboBox marka , ComboBox model, TextBox serino,TextBox imeino,DateTimePicker dateuretim, DateTimePicker dategelis, MaskedTextBox alisfiyati,MaskedTextBox satisfiyati,MaskedTextBox kdv, MaskedTextBox islemci, MaskedTextBox isletimsistemi,MaskedTextBox hafiza,MaskedTextBox cozunurluk,MaskedTextBox  renk,PictureBox resim)
        {
            int sonuc = 0;
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
            try
            {
                sonuc = komut.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı","Bilgi,",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch(Exception ex)
            { 
            
                string hata = ex.Message;
                MessageBox.Show(hata);
                
            }
            finally
            {
                baglanti.Close();
            }

            return sonuc;

        }

    }
}
