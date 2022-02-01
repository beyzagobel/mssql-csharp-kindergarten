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
    public partial class frm_AdminGiris : Form
    {
        public frm_AdminGiris()
        {
            InitializeComponent();
        }
       
        SqlConnection sqlConnection;

        private void giris_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=BEYZA;Initial Catalog=AnaOkulu;Integrated Security=True");
            sqlConnection.Open();

            SqlDataReader read;
            
            if (txt_kullanici.TextLength > 0 && txt_sifre.TextLength > 0)  // veri girişi yapılmış mı diye kontrol ediliyor
                {
                
                SqlCommand komut = new SqlCommand("Select * from Admin where Kullanici_Adi=@ad and Sifre=@sifre", sqlConnection);
                    komut.Parameters.AddWithValue("@ad", txt_kullanici.Text);
                    komut.Parameters.AddWithValue("@sifre", txt_sifre.Text);
                    komut.CommandText = "Select * from Admin where Kullanici_Adi='" + txt_kullanici.Text + "'";
                    read = komut.ExecuteReader();

                    if (read.Read() == true)
                    {
                        if (txt_sifre.Text == read["Sifre"].ToString())
                        {
                            MessageBox.Show("Giriş başarılı");
                            frm_AdminSayfasi adminSayfasi = new frm_AdminSayfasi();
                            adminSayfasi.Show();
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
                else if (txt_kullanici.TextLength > 0 && txt_sifre.TextLength == 0)
                {
                    MessageBox.Show("Lüften şifre giriniz");
                }

                else if (txt_kullanici.TextLength == 0 && txt_sifre.TextLength > 0)
                {
                    MessageBox.Show("Lüften kullanıcı adı giriniz");

                }

                else
                {
                    MessageBox.Show("Lüften kullanıcı adı ve şifre giriniz");

                }
                sqlConnection.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void frm_AdminGiris_Load(object sender, EventArgs e)
        {

        }
    }

}

