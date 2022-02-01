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
    public partial class frm_VeliIslemleri : Form
    {
        public frm_VeliIslemleri()
        {
            InitializeComponent();
        }

     
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;

       
        void griddoldur()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            da = new SqlDataAdapter("Select * from Veli", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds,"Veli");
            dataGridView1.DataSource = ds.Tables["Veli"];
            baglanti.Close();
            
        }


    
        private void btn_kaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_TC.TextLength > 0 && txt_Ad.TextLength > 0 && txt_Soyad.TextLength > 0 && txt_kullanıcı.TextLength > 0 && rich_adres.TextLength > 0)
                {
                    SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                    baglanti.Open();
                    string kayit = "insert into Veli(VeliTC,Ad,Soyad,Kullanici_Adi,Sifre,Adres) values(@P1, @P2, @P3, @P4, @P5, @P6)";
                    komut = new SqlCommand(kayit, baglanti);

                    komut.Parameters.AddWithValue("@P1", txt_TC.Text);
                    komut.Parameters.AddWithValue("@P2", txt_Ad.Text);
                    komut.Parameters.AddWithValue("@P3", txt_Soyad.Text);
                    komut.Parameters.AddWithValue("@P4", txt_kullanıcı.Text);
                    komut.Parameters.AddWithValue("@P5", txt_Sifre.Text);
                    komut.Parameters.AddWithValue("@P6", rich_adres.Text);

                    komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Veli Kayıt İşlemi Gerçekleşti!");
                    griddoldur();

                }
                else
                {
                    MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ ! ");
                }
            }
            catch (Exception) { MessageBox.Show("Hatalı kayot işlemi."); }
            
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                baglanti.Open();

                string sorgu = "Update Veli Set Ad=@P1,Soyad=@P2,Kullanici_Adi=@P3,Sifre=@P4,Adres=@P5 Where VeliTC=@P6 ";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@P1", txt_Ad.Text);
                komut.Parameters.AddWithValue("@P2", txt_Soyad.Text);
                komut.Parameters.AddWithValue("@P3", txt_kullanıcı.Text);
                komut.Parameters.AddWithValue("@P4", txt_Sifre.Text);
                komut.Parameters.AddWithValue("@P5", rich_adres.Text);
                komut.Parameters.AddWithValue("@P6", txt_TC.Text);

                komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Veli Güncelleme İşlemi Gerçekleşti!");
                griddoldur();

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Güncelle İşlemi");
            }

            }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            baglanti.Open();
            string kayit = "Select * from Veli where VeliTC=@P1";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@P1", txt_VeliTCAra.Text);
            da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                txt_TC.Text = dr["VeliTC"].ToString();
                txt_Ad.Text = dr["Ad"].ToString();
                txt_Soyad.Text = dr["Soyad"].ToString();
                txt_kullanıcı.Text = dr["Kullanici_Adi"].ToString();
                txt_Sifre.Text = dr["Sifre"].ToString();
                rich_adres.Text = dr["Adres"].ToString();

            }
            else
            {
                MessageBox.Show("Veli Bulunamadı!");
                baglanti.Close();
            }

        }


        private void frm_VeliIslemleri_Load(object sender, EventArgs e)
        {
            griddoldur();
            txt_TC.MaxLength = 11;

        }

        private void btn_sill_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
                baglanti.Open();
                string sorgu = "Select * from Veli where VeliTC=@P1";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@P1", txt_VeliTCSil.Text);
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
                            string silmesorgusu = "Delete from Veli where VeliTC=@P1";
                            SqlCommand silkomutu = new SqlCommand(silmesorgusu, baglanti);
                            silkomutu.Parameters.AddWithValue("@P1", txt_VeliTCSil.Text);
                            silkomutu.ExecuteNonQuery();
                            MessageBox.Show("Kayıt silindi...");
                            griddoldur();
                        }
                        else
                        {
                            MessageBox.Show("Veli bulunamadı...");
                            baglanti.Close();
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Silme İşlemi!");
            }
            
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            frm_AdminSayfasi adminSayfasi = new frm_AdminSayfasi();
            adminSayfasi.Show();
            this.Hide();
        }

    }
}
