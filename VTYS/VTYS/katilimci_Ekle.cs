using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //string adi, soyadi, telefon, eposta;
            //adi = txtAdi.Text;
            //soyadi = txtSoyadi.Text;
            //telefon = txtTelefon.Text;
            //eposta = txtEposta.Text;

            //string sql = "INSERT INTO tblmusteri(ADI, SOYADI, EPOSTA, TELEFON)" +
            //      " VALUES('" + adi + "','" + soyadi + "','" + telefon + "','" + eposta + "')";

        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_kimlikId.Text != null)
            {
                lbl_Uyari.Text = "Kimlik ID boş bırakılamaz !";
                if (txt_kimlikId.Text != "")
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
