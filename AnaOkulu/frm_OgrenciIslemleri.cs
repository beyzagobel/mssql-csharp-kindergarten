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
    public partial class frm_OgrenciIslemleri : Form
    {
        public frm_OgrenciIslemleri()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;

        void griddoldur()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            da = new SqlDataAdapter("Select * from Ogrenci", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Ogrenci");
            dataGridView1.DataSource = ds.Tables["Ogrenci"];
            baglanti.Close();

        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TC.TextLength > 0 && txt_Ad.TextLength > 0 && txt_Soyad.TextLength > 0 && rich_adres.TextLength > 0)
                {
                    SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                    baglanti.Open();
                    string kayit = "insert into Ogrenci(TC,Ad,Soyad,DogumTarihi,KayitTarihi,Sinif,Adres) values(@P1, @P2, @P3, @P4, @P5, @P6,@P7)";
                    komut = new SqlCommand(kayit, baglanti);

                    komut.Parameters.AddWithValue("@P1", txt_TC.Text);
                    komut.Parameters.AddWithValue("@P2", txt_Ad.Text);
                    komut.Parameters.AddWithValue("@P3", txt_Soyad.Text);
                    komut.Parameters.AddWithValue("@P4", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@P5", dateTimePicker2.Value);
                    komut.Parameters.AddWithValue("@P6", cmb_sinif.Text);
                    komut.Parameters.AddWithValue("@P7", rich_adres.Text);

                    komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Öğrenci Kayıt İşlemi Gerçekleşti!");
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

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                baglanti.Open();

                string sorgu = "Update Ogrenci Set Ad=@P1,Soyad=@P2,DogumTarihi=@P3,KayitTarihi=@P4,Sinif=@P5,Adres=@P6 Where TC=@P7";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@P1", txt_Ad.Text);
                komut.Parameters.AddWithValue("@P2", txt_Soyad.Text);
                komut.Parameters.AddWithValue("@P3", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@P4", dateTimePicker2.Value);
                komut.Parameters.AddWithValue("@P5", cmb_sinif.Text);
                komut.Parameters.AddWithValue("@P6", rich_adres.Text);
                komut.Parameters.AddWithValue("@P7", txt_TC.Text);

                komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();


                MessageBox.Show("Öğrenci  Güncelleme İşlemi Gerçekleşti!");
                griddoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı işlem.");
            }
        
    }
        
    
        private void btn_ara_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            baglanti.Open();
            string kayit = "Select * from Ogrenci where TC=@P1";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@P1", txt_OgrenciTCAra.Text);
            da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                txt_TC.Text = dr["TC"].ToString();
                txt_Ad.Text = dr["Ad"].ToString();
                txt_Soyad.Text = dr["Soyad"].ToString();
                dateTimePicker1.Text = dr["DogumTarihi"].ToString();
                dateTimePicker2.Text = dr["KayitTarihi"].ToString();
                cmb_sinif.Text = dr["Sinif"].ToString();
                rich_adres.Text = dr["Adres"].ToString();
    
            }
            else
            {
                MessageBox.Show("Öğrenci Bulunamadı!");
                baglanti.Close();
            }

        }

        private void frm_OgrenciIslemleri_Load(object sender, EventArgs e)
        {
            griddoldur();
            cmb_sinif.Items.Add("A");
            cmb_sinif.Items.Add("B");
            cmb_sinif.Items.Add("C");

            txt_TC.MaxLength = 11;
            
        }

        private void btn_sill_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            baglanti.Open();
            string sorgu = "Select * from Ogrenci where TC=@P1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@P1", txt_OgrTCSil.Text);
            da = new SqlDataAdapter(komut);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    string isim = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                    dr.Close();
                    DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == durum)
                    {
                        string silmesorgusu = "Delete from Ogrenci where TC=@P1";
                        SqlCommand silkomutu = new SqlCommand(silmesorgusu, baglanti);
                        silkomutu.Parameters.AddWithValue("@P1", txt_OgrTCSil.Text);
                        silkomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silindi...");
                        griddoldur();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı...");
                        baglanti.Close();
                    }

                }
            }
        }

        private void btb_geri_Click(object sender, EventArgs e)
        {
            frm_AdminSayfasi adminSayfasi = new frm_AdminSayfasi();
            adminSayfasi.Show();
            this.Hide();
        }
    }
}
