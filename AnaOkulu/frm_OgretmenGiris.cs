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
    public partial class frm_OgretmenGiris : Form
    {
        public frm_OgretmenGiris()
        {
            InitializeComponent();
        }
   

        SqlConnection sqlConnection;


        private void giris_Click_1(object sender, EventArgs e)
        {


            sqlConnection = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            sqlConnection.Open();
            SqlDataReader read;

            if (txt_KullaniciAdi.TextLength > 0 && txt_Sifre.TextLength > 0 && cmb_sinif.ToString().Length > 0)  // veri girişi yapılmış mı diye kontrol ediliyor
            {

                SqlCommand cmd = new SqlCommand("Select * from Ogretmen where Kullanici_Adi=@ad and Sifre=@sifre and Sinif=@sinif ", sqlConnection);
                cmd.Parameters.AddWithValue("@ad", txt_KullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", txt_Sifre.Text);
                cmd.Parameters.AddWithValue("@sinif", cmb_sinif.Text);

                cmd.CommandText = "Select * from Ogretmen  Where Kullanici_Adi='" + txt_KullaniciAdi.Text + "'";
                read = cmd.ExecuteReader();


                if (read.Read() == true  )
                {
                    if (txt_Sifre.Text == read["Sifre"].ToString() && cmb_sinif.Text == read["Sinif"].ToString())
                    {
                        MessageBox.Show("Giriş başarılı");
                        frm_OgretmenSayfasi ogretmenSayfasi = new frm_OgretmenSayfasi();
                        ogretmenSayfasi.kullaniciAdi = txt_KullaniciAdi.Text;
                        ogretmenSayfasi.sinif = cmb_sinif.Text;
                        ogretmenSayfasi.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("YANLIŞ ŞİFRE!!! Lütfen Şifrenizi kontrol ediniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız.Lütfen Bilgilerinizi kontrol ediniz.");

                }

            }
            else if (txt_KullaniciAdi.TextLength > 0 && txt_Sifre.TextLength == 0)
            {
                MessageBox.Show("Lüften şifre giriniz");
            }

            else if (txt_KullaniciAdi.TextLength == 0 && txt_Sifre.TextLength > 0)
            {
                MessageBox.Show("Lüften kullanıcı adı giriniz");

            }

            else
            {
                MessageBox.Show("Lüften kullanıcı adı ve şifre giriniz");

            }

            sqlConnection.Close();
        }

        private void geri_Click_1(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void frm_OgretmenGiris_Load(object sender, EventArgs e)
        {

        }
    }
    }

