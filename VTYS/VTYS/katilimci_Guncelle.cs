using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace VTYS
{
    public partial class katilimci_Guncelle : Form
    {
        public katilimci_Guncelle()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection(@"Data Source = DESKTOP-2BLE3N6; Initial Catalog = egitim; Integrated Security = True;");
        


        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            Baglanti.Open();
            string sorgu = "UPDATE OGRENCI SET TC=@TC, AD=@AD, SOYAD=@SOYAD, DOGUM_IL_ID=@DOGUM_IL_ID, DOGUM_YERI=@DOGUM_YERI, " +
                "DOGUM_TRH=@DOGUM_TRH, EMAIL=@EMAIL, TELEFON=@TELEFON, UNVAN_ID=@UNVAN_ID WHERE @TC =" + txt_tc.Text + "";
            SqlCommand commandAdd = new SqlCommand(sorgu, Baglanti);

            commandAdd.Parameters.AddWithValue("@TC", txt_tc.Text); // Örnek veritabanına ekleme şekli
            commandAdd.Parameters.AddWithValue("@AD", txt_ad.Text);
            commandAdd.Parameters.AddWithValue("@SOYAD", txt_soyad.Text);
            commandAdd.Parameters.AddWithValue("@DOGUM_IL_ID", int.Parse(txt_dogumIlId.Text));
            commandAdd.Parameters.AddWithValue("@DOGUM_YERI", txt_dogumYeri.Text);
            commandAdd.Parameters.AddWithValue("@DOGUM_TRH", datetime_DogumTarihiUpdate.Value);
            commandAdd.Parameters.AddWithValue("@EMAIL", txt_email.Text);
            commandAdd.Parameters.AddWithValue("@TELEFON", txt_telefon.Text);
            commandAdd.Parameters.AddWithValue("@UNVAN_ID", int.Parse(txt_unvanId.Text));
            commandAdd.ExecuteNonQuery();
            Baglanti.Close();
        }
        private void btn_bul_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            string sorgu = "SELECT * FROM OGRENCI WHERE TC =" + txt_tc.Text + "";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            oku.Read();
            txt_kimlikId.Text = oku["KIMLIK_ID"].ToString();
            txt_ad.Text = oku["AD"].ToString();
            txt_soyad.Text = oku["SOYAD"].ToString();
            txt_dogumIlId.Text = oku["DOGUM_IL_ID"].ToString();
            txt_dogumYeri.Text = oku["DOGUM_YERI"].ToString();
            datetime_DogumTarihiUpdate.Value = (DateTime)oku["DOGUM_TRH"];
            txt_email.Text = oku["EMAIL"].ToString();
            txt_telefon.Text = oku["TELEFON"].ToString();
            txt_unvanId.Text = oku["UNVAN_ID"].ToString();

            Baglanti.Close();
        }

    }
}
