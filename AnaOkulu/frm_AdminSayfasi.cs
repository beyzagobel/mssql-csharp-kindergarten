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
    public partial class frm_AdminSayfasi : Form
    {
        public frm_AdminSayfasi()
        {
            InitializeComponent();
        }
        
        private void btn_OgrenciIslemleri_Click(object sender, EventArgs e)
        {
            frm_OgrenciIslemleri ogrenciIslemleri = new frm_OgrenciIslemleri();
            ogrenciIslemleri.Show();
            this.Hide();
        }

   
        private void btn_OgretmenIslemleri_Click(object sender, EventArgs e)
        {
            frm_OgretmenIslemleri ogretmenIslemleri = new frm_OgretmenIslemleri();
            ogretmenIslemleri.Show();
            this.Hide();
        }


        private void btn_Cıkıs_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }


        private void btn_SilinenKayitlar_Click(object sender, EventArgs e)
        {
            frm_SilinenKayitlar silinenKayitlar = new frm_SilinenKayitlar();
            silinenKayitlar.Show();
            this.Hide();
        }


        private void btn_VeliIslemleri_Click_1(object sender, EventArgs e)
        {
            frm_VeliIslemleri veliIslemleri = new frm_VeliIslemleri();
            veliIslemleri.Show();
            this.Hide();
        }
    }
}
