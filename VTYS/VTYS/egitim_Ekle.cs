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

namespace VTYS
{
    public partial class egitim_Ekle : Form
    {
        public egitim_Ekle()
        {
            InitializeComponent();
        }

        void ekle()
        {
            //string adi, soyadi, telefon, eposta;
            //adi = txtAdi.Text;
            //soyadi = txtSoyadi.Text;
            //telefon = txtTelefon.Text;
            //eposta = txtEposta.Text;

            //string sql = "INSERT INTO tblmusteri(ADI, SOYADI, EPOSTA, TELEFON)" +
            //      " VALUES('" + adi + "','" + soyadi + "','" + telefon + "','" + eposta + "')";

        }

        private void btn_egitimEkle_Click(object sender, EventArgs e)
        {
            //string BaglantiAdresi = "Server=.;Database=Hokumus;User Id=sa;Password=123456;";
            //SqlConnection Baglanti = new SqlConnection();
            //Baglanti.ConnectionString = BaglantiAdresi;        Örnek sql e bağlanıp açma şekli
            //Baglanti.Open();

            //Baglanti.Database.Insert(0,txt_egitimID.Text);   Örnek veritabanına ekleme şekli

            if (txt_zamanId.Text != null || txt_egitmenId.Text != null || txt_versionId.Text != null || txt_logId.Text != null || txt_egitimID.Text != null || txt_kimlikId.Text != null || txt_egitimDetayId.Text != null)
            {
                lbl_Uyari.Text = "* işareti olan alanlar boş bırakılamaz !";
                if (txt_zamanId.Text != "" && txt_egitmenId.Text != "" && txt_versionId.Text != "" && txt_logId.Text != "" && txt_egitimID.Text != "" && txt_kimlikId.Text != "" && txt_egitimDetayId.Text != "")
                {
                    lbl_Uyari.Text = "Kayıt Başarılı.";
                    ekle();
                }
            }
            if (txt_zamanId.Text != "" && txt_egitmenId.Text != "" && txt_versionId.Text != "" && txt_logId.Text != "" && txt_egitimID.Text != "" && txt_kimlikId.Text != "" && txt_egitimDetayId.Text != "")
            {
                lbl_Uyari.Text = "Kayıt Başarılı.";
                ekle();

            }
        }

    }
}
