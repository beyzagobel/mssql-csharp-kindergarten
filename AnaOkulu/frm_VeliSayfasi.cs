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

namespace AnaOkulu
{
    public partial class frm_VeliSayfasi : Form
    {
        public frm_VeliSayfasi()
        {
            InitializeComponent();
        }

        public string kullaniciAdi { get; set; }

        void griddoldurR()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            SqlCommand komut = new SqlCommand("VeliProc", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            dr.Fill(ds, "VeliOgrNot");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void frm_VeliSayfasi_Load(object sender, EventArgs e)
        {
            griddoldurR();

            lbl_adSoyad.Text = kullaniciAdi;


        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
