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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnEgitimEkle_Click(object sender, EventArgs e)
        {
            egitim_Ekle egitim_Ekle = new egitim_Ekle();
            egitim_Ekle.ShowDialog();
        }

        private void btnKatilimciEkle_Click(object sender, EventArgs e)
        {
            katilimci_Ekle katilimci_Ekle = new katilimci_Ekle();
            katilimci_Ekle.ShowDialog();
        }

        private void btnEgitimGoruntule_Click(object sender, EventArgs e)
        {
            egitim_Goruntule egitim_Goruntule = new egitim_Goruntule();
            egitim_Goruntule.Show();
        }

        private void btnKatilimciGoruntule_Click(object sender, EventArgs e)
        {
            katilimci_Goruntule katilimci_Goruntule = new katilimci_Goruntule();
            katilimci_Goruntule.Show();
        }

        private void btnEgitimGuncelle_Click(object sender, EventArgs e)
        {
            egitim_Guncelleme egitim_Guncelleme = new egitim_Guncelleme();
            egitim_Guncelleme.ShowDialog();
        }

        private void btnKatilimciGuncelle_Click(object sender, EventArgs e)
        {
            katilimci_Guncelle katilimci_Guncelleme = new katilimci_Guncelle();
            katilimci_Guncelleme.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailSending ms = new MailSending();
            ms.Show();
        }
    }
}
