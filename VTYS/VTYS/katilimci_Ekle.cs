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
using System.ComponentModel.Design;


namespace VTYS
{
    public partial class katilimci_Ekle : Form
    {
        public katilimci_Ekle()
        {
            InitializeComponent();
        }
        void ekle()
        {
            string BaglantiAdresi = "Data Source = DESKTOP-2BLE3N6; Initial Catalog = egitim; Integrated Security = True;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = BaglantiAdresi;        //Örnek sql e bağlanıp açma şekli
            Baglanti.Open();

            string sql = "INSERT INTO OGRENCI(TC, AD, SOYAD, DOGUM_IL_ID, DOGUM_YERI, DOGUM_TRH, EMAIL, TELEFON, UNVAN_ID)" +
                  " VALUES(@TC, @AD, @SOYAD, @DOGUM_IL_ID, @DOGUM_YERI, @DOGUM_TRH, @EMAIL, @TELEFON, @UNVAN_ID)";
            SqlCommand commandAdd = new SqlCommand(sql, Baglanti);

            commandAdd.Parameters.AddWithValue("@TC", txt_tc.Text); // Örnek veritabanına ekleme şekli
            commandAdd.Parameters.AddWithValue("@AD", txt_ad.Text);
            commandAdd.Parameters.AddWithValue("@SOYAD", txt_soyad.Text);
            commandAdd.Parameters.AddWithValue("@DOGUM_IL_ID", int.Parse(txt_dogumIlId.Text));
            commandAdd.Parameters.AddWithValue("@DOGUM_YERI", txt_dogumYeri.Text);
            commandAdd.Parameters.AddWithValue("@DOGUM_TRH", datetime_DogumTarihi.Value);
            commandAdd.Parameters.AddWithValue("@EMAIL", txt_email.Text);
            commandAdd.Parameters.AddWithValue("@TELEFON", txt_telefon.Text);
            commandAdd.Parameters.AddWithValue("@UNVAN_ID", int.Parse(txt_unvanId.Text));
            commandAdd.ExecuteNonQuery();
            Baglanti.Close();

        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {

            if (txt_tc.Text != null || txt_ad.Text != null || txt_soyad.Text != null || txt_telefon.Text != null)
            {
                lbl_Uyari.Text = "* işareti olan alanlar boş bırakılamaz !";
                if (txt_tc.Text != "" || txt_ad.Text != "" || txt_soyad.Text != "" || txt_telefon.Text != "")
                {
                    lbl_Uyari.Text = "Kayıt Başarılı.";
                    ekle();
                }
            }
            else
            {
                lbl_Uyari.Text = "Kayıt Başarılı.";
                ekle();
            }

        }

    }
}
