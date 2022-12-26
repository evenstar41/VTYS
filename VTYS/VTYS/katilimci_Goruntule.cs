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
    public partial class katilimci_Goruntule : Form
    {
        public katilimci_Goruntule()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable tablo;

        void katilimciGoruntle()
        {
            //conn = new SqlConnection("Data Source=.;Initial Catalog=dbRehber;Integrated Security=True");
            //adapter = new SqlDataAdapter("SELECT *FROM Kisiler", conn);
            //tablo = new DataTable();
            //conn.Open();
            //adapter.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            //conn.Close();
        }
        private void katilimci_Goruntule_Load(object sender, EventArgs e)
        {
            katilimciGoruntle();
        }
    }
}
