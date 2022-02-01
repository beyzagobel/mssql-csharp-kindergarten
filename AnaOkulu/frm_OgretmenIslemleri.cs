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
    public partial class frm_OgretmenIslemleri : Form
    {
        public frm_OgretmenIslemleri()
        {
            InitializeComponent();
        }


        void griddoldur()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogretmen", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Ogretmen");
            dataGridView1.DataSource = ds.Tables["Ogretmen"];
            baglanti.Close();

        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TC.TextLength > 0 && txt_Ad.TextLength > 0 && txt_Soyad.TextLength > 0 && txt_kulllanici.TextLength > 0 && txt_Sifre.TextLength > 0 && richTextBox1.TextLength > 0)
                {
                    SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                    baglanti.Open();
                    string kayit = "insert into Ogretmen(OgretmenTC,Ad,Soyad,Sinif,Kullanici_Adi,Sifre,Adres) values(@P1, @P2, @P3, @P4, @P5, @P6,@P7)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);

                    komut.Parameters.AddWithValue("@P1", txt_TC.Text);
                    komut.Parameters.AddWithValue("@P2", txt_Ad.Text);
                    komut.Parameters.AddWithValue("@P3", txt_Soyad.Text);
                    komut.Parameters.AddWithValue("@P4", cmb_sinif.Text);
                    komut.Parameters.AddWithValue("@P5", txt_kulllanici.Text);
                    komut.Parameters.AddWithValue("@P6", txt_Sifre.Text);
                    komut.Parameters.AddWithValue("@P7", richTextBox1.Text);

                    komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Öğretmen Kayıt İşlemi Gerçekleşti!");
                    griddoldur();

                }
                else
                {
                    MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ ! ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı kayıt işlemi.");
            }

        }


        private void btn_ara_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            baglanti.Open();
            string kayit = "Select * from Ogretmen where OgretmenTC=@P1";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@P1", txt_OgretmenTCAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                txt_TC.Text = dr["OgretmenTC"].ToString();
                txt_Ad.Text = dr["Ad"].ToString();
                txt_Soyad.Text = dr["Soyad"].ToString();
                cmb_sinif.Text = dr["Sinif"].ToString();
                txt_kulllanici.Text = dr["Kullanici_Adi"].ToString();
                txt_Sifre.Text = dr["Sifre"].ToString();
                richTextBox1.Text = dr["Adres"].ToString();

            }
            else
            {
                MessageBox.Show("Öğretmen Bulunamadı!");
                baglanti.Close();
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                baglanti.Open();

                string sorgu = "Update Ogretmen Set Ad=@P1,Soyad=@P2,Sinif=@P3,Kullanici_Adi=@P4,Sifre=@P5,Adres=@P6 Where OgretmenTC=@P7 ";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@P1", txt_Ad.Text);
                komut.Parameters.AddWithValue("@P2", txt_Soyad.Text);
                komut.Parameters.AddWithValue("@P3", cmb_sinif.Text);
                komut.Parameters.AddWithValue("@P4", txt_kulllanici.Text);
                komut.Parameters.AddWithValue("@P5", txt_Sifre.Text);
                komut.Parameters.AddWithValue("@P6", richTextBox1.Text);
                komut.Parameters.AddWithValue("@P7", txt_OgretmenTCAra.Text);

                komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Öğretmen Güncelleme İşlemi Gerçekleşti!");
                griddoldur();

            }
            catch (Exception)
            {
                MessageBox.Show("hatalı İşlem.");
            }

        }

        private void btn_sill_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            baglanti.Open();
            string sorgu = "Select * from Ogretmen where OgretmenTC=@P1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@P1", txt_OgretmenTC.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    string isim = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                    dr.Close();
                    DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == durum)
                    {
                        string silmesorgusu = "Delete from Ogretmen where OgretmenTC=@P1";
                        SqlCommand silkomutu = new SqlCommand(silmesorgusu, baglanti);
                        silkomutu.Parameters.AddWithValue("@P1", txt_OgretmenTC.Text);
                        silkomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silindi...");
                        griddoldur();
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen bulunamadı...");
                        baglanti.Close();
                    }

                }
            }
        }

        private void frm_OgretmenIslemleri_Load(object sender, EventArgs e)
        {
            griddoldur();
            txt_TC.MaxLength = 11;

        }

        private void btb_geri_Click(object sender, EventArgs e)
        {
            frm_AdminSayfasi adminSayfasi = new frm_AdminSayfasi();
            adminSayfasi.Show();
            this.Hide();
    }

    }
}
