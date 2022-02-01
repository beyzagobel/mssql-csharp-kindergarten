using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AnaOkulu
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
   
        
        private void button1_Click(object sender, EventArgs e)
        {
            frm_AdminGiris adminGiris = new frm_AdminGiris();
            adminGiris.Show();
            this.Hide();
        }

      
        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_OgretmenGiris ogretmenGiris = new frm_OgretmenGiris();
            ogretmenGiris.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            frm_VeliGiris veliGiris = new frm_VeliGiris();
            veliGiris.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);  // Programdan güvenli çıkış komutu
        }
    }
}
