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
    public partial class frm_SilinenKayitlar : Form
    {
        public frm_SilinenKayitlar()
        {
            InitializeComponent();
        }

        void SilinenOgrenci()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from SilinenOgrenci", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "SilinenOgrenci");
            dt_ogrenci.DataSource = ds.Tables["SilinenOgrenci"];
            baglanti.Close();

        }

        void SilinenOgretmen()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from SilinenOgretmen", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "SilinenOgretmen");
            dt_ogretmen.DataSource = ds.Tables["SilinenOgretmen"];
            baglanti.Close();

        }

        void SilinenVeli()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from SilinenVeli", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "SilinenVeli");
            dt_veli.DataSource = ds.Tables["SilinenVeli"];
            baglanti.Close();

        }

        private void frm_SilinenKayitlar_Load(object sender, EventArgs e)
        {
            SilinenOgrenci();
            SilinenOgretmen();
            SilinenVeli();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            frm_AdminSayfasi adminSayfasi = new frm_AdminSayfasi();
            adminSayfasi.Show();
            this.Hide();
        }

    }
}
