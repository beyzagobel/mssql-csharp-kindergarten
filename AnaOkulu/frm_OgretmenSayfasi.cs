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
    public partial class frm_OgretmenSayfasi : Form
    {
        public frm_OgretmenSayfasi()
        {
            InitializeComponent();
        }

        public string kullaniciAdi { get; set; }
        public string sinif { get; set; }

        private void frm_OgretmenSayfasi_Load(object sender, EventArgs e)
        {

            lbl_kullaniciad.Text = kullaniciAdi;
            lbl_sinif.Text = sinif;

            if (lbl_sinif.Text == "A")
            {
                lbl_sinifbilgi.Text= "A";
            }
            else if (lbl_sinif.Text == "B")
            {
                lbl_sinifbilgi.Text = "B";
            }
            else
            {
                lbl_sinifbilgi.Text = "C";
            }

            cmb_notlar.Items.Add("1");
            cmb_notlar.Items.Add("2");
            cmb_notlar.Items.Add("3");
            cmb_notlar.Items.Add("4");
            cmb_notlar.Items.Add("5");


            griddoldur();

        }
       
        void griddoldur()
        {
            if (lbl_sinifbilgi.Text == "A")
            {

                SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                SqlCommand komut = new SqlCommand("SinifA", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                dr.Fill(ds, "A Sınıfı Öğrencileri");
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (lbl_sinifbilgi.Text == "B")
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                SqlCommand komut = new SqlCommand("SinifB", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                dr.Fill(ds, "B Sınıfı Öğrencileri");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                SqlCommand komut = new SqlCommand("SinifC", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                dr.Fill(ds, "C Sınıfı Öğrencileri");
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            baglanti.Open();

            string sorgu = "Update Notlar Set OgrNot=@P1 Where OgrenciTC=@P2 ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@P1", cmb_notlar.Text);
            komut.Parameters.AddWithValue("@P2", txt_OgrTC.Text);

            komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Öğrenci Not Güncelleme İşlemi Gerçekleşti!");
            griddoldur();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                baglanti.Open();

                string sorgu = "insert into Notlar (OgrenciTC,OgrNot) values (@P1,@P2)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@P1", txt_OgrTC.Text);
                komut.Parameters.AddWithValue("@P2", cmb_notlar.Text);

                komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Öğrenci Not Kaydetme İşlemi Gerçekleşti!");
                griddoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Öğrenci Bulunamadı!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
