
namespace AnaOkulu
{
    partial class frm_AdminSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OgretmenIslemleri = new System.Windows.Forms.Button();
            this.btn_VeliIslemleri = new System.Windows.Forms.Button();
            this.btn_OgrenciIslemleri = new System.Windows.Forms.Button();
            this.btn_Cıkıs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SilinenKayitlar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OgretmenIslemleri
            // 
            this.btn_OgretmenIslemleri.ForeColor = System.Drawing.Color.Green;
            this.btn_OgretmenIslemleri.Location = new System.Drawing.Point(24, 53);
            this.btn_OgretmenIslemleri.Name = "btn_OgretmenIslemleri";
            this.btn_OgretmenIslemleri.Size = new System.Drawing.Size(204, 89);
            this.btn_OgretmenIslemleri.TabIndex = 2;
            this.btn_OgretmenIslemleri.Text = "Öğretmen İşlemleri";
            this.btn_OgretmenIslemleri.UseVisualStyleBackColor = true;
            this.btn_OgretmenIslemleri.Click += new System.EventHandler(this.btn_OgretmenIslemleri_Click);
            // 
            // btn_VeliIslemleri
            // 
            this.btn_VeliIslemleri.ForeColor = System.Drawing.Color.Green;
            this.btn_VeliIslemleri.Location = new System.Drawing.Point(24, 160);
            this.btn_VeliIslemleri.Name = "btn_VeliIslemleri";
            this.btn_VeliIslemleri.Size = new System.Drawing.Size(204, 89);
            this.btn_VeliIslemleri.TabIndex = 3;
            this.btn_VeliIslemleri.Text = "Veli İşlemleri";
            this.btn_VeliIslemleri.UseVisualStyleBackColor = true;
            this.btn_VeliIslemleri.Click += new System.EventHandler(this.btn_VeliIslemleri_Click_1);
            // 
            // btn_OgrenciIslemleri
            // 
            this.btn_OgrenciIslemleri.ForeColor = System.Drawing.Color.Green;
            this.btn_OgrenciIslemleri.Location = new System.Drawing.Point(261, 53);
            this.btn_OgrenciIslemleri.Name = "btn_OgrenciIslemleri";
            this.btn_OgrenciIslemleri.Size = new System.Drawing.Size(204, 89);
            this.btn_OgrenciIslemleri.TabIndex = 4;
            this.btn_OgrenciIslemleri.Text = "Öğrenci İşlemleri";
            this.btn_OgrenciIslemleri.UseVisualStyleBackColor = true;
            this.btn_OgrenciIslemleri.Click += new System.EventHandler(this.btn_OgrenciIslemleri_Click);
            // 
            // btn_Cıkıs
            // 
            this.btn_Cıkıs.BackColor = System.Drawing.Color.White;
            this.btn_Cıkıs.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cıkıs.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Cıkıs.Location = new System.Drawing.Point(142, 269);
            this.btn_Cıkıs.Name = "btn_Cıkıs";
            this.btn_Cıkıs.Size = new System.Drawing.Size(204, 89);
            this.btn_Cıkıs.TabIndex = 6;
            this.btn_Cıkıs.Text = "ÇIKIŞ";
            this.btn_Cıkıs.UseVisualStyleBackColor = false;
            this.btn_Cıkıs.Click += new System.EventHandler(this.btn_Cıkıs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SilinenKayitlar);
            this.groupBox1.Controls.Add(this.btn_Cıkıs);
            this.groupBox1.Controls.Add(this.btn_OgrenciIslemleri);
            this.groupBox1.Controls.Add(this.btn_OgretmenIslemleri);
            this.groupBox1.Controls.Add(this.btn_VeliIslemleri);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(33, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 387);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADMİN İŞLEMLERİ";
            // 
            // btn_SilinenKayitlar
            // 
            this.btn_SilinenKayitlar.ForeColor = System.Drawing.Color.Green;
            this.btn_SilinenKayitlar.Location = new System.Drawing.Point(261, 160);
            this.btn_SilinenKayitlar.Name = "btn_SilinenKayitlar";
            this.btn_SilinenKayitlar.Size = new System.Drawing.Size(204, 89);
            this.btn_SilinenKayitlar.TabIndex = 7;
            this.btn_SilinenKayitlar.Text = "Silinen Tüm Kayıtlar";
            this.btn_SilinenKayitlar.UseVisualStyleBackColor = true;
            this.btn_SilinenKayitlar.Click += new System.EventHandler(this.btn_SilinenKayitlar_Click);
            // 
            // frm_AdminSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(558, 487);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_AdminSayfasi";
            this.Text = "ADMİN SAYFASI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_OgretmenIslemleri;
        private System.Windows.Forms.Button btn_VeliIslemleri;
        private System.Windows.Forms.Button btn_OgrenciIslemleri;
        private System.Windows.Forms.Button btn_Cıkıs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SilinenKayitlar;
    }
}