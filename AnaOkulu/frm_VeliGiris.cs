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
    public partial class frm_VeliGiris : Form
    {
        public frm_VeliGiris()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void giris_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            con.Open();
            SqlDataReader read;

            if (txt_KullaniciAdi.TextLength > 0 && txt_Sifre.TextLength > 0)  // veri girişi yapılmış mı diye kontrol ediliyor
            {

                SqlCommand cmd = new SqlCommand("Select * from Veli where Kullanici_Adi=@ad and Sifre=@sifre ",con);
                cmd.Parameters.AddWithValue("@ad", txt_KullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", txt_Sifre.Text);
                cmd.CommandText = "Select* from Veli where Kullanici_Adi = '" + txt_KullaniciAdi.Text + "'"; 
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    if (txt_Sifre.Text == read["Sifre"].ToString())
                    {
                        MessageBox.Show("Giriş başarılı");
                        frm_VeliSayfasi veliSayfasi = new frm_VeliSayfasi();
                        veliSayfasi.kullaniciAdi = txt_KullaniciAdi.Text;
                        veliSayfasi.Show();
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

          
            con.Close();
        
        }
        private void geri_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void frm_VeliGiris_Load(object sender, EventArgs e)
        {

        }
    }
    }
