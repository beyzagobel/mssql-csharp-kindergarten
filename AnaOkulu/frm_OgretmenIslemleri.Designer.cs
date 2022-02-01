
namespace AnaOkulu
{
    partial class frm_OgretmenIslemleri
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
            this.txt_KullaniciAdi = new System.Windows.Forms.GroupBox();
            this.btb_geri = new System.Windows.Forms.Button();
            this.cmb_sinif = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_kulllanici = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sill = new System.Windows.Forms.Button();
            this.txt_OgretmenTC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_OgretmenTCAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.txt_KullaniciAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Controls.Add(this.btb_geri);
            this.txt_KullaniciAdi.Controls.Add(this.cmb_sinif);
            this.txt_KullaniciAdi.Controls.Add(this.label4);
            this.txt_KullaniciAdi.Controls.Add(this.txt_Sifre);
            this.txt_KullaniciAdi.Controls.Add(this.txt_kulllanici);
            this.txt_KullaniciAdi.Controls.Add(this.lbl_Sifre);
            this.txt_KullaniciAdi.Controls.Add(this.label3);
            this.txt_KullaniciAdi.Controls.Add(this.richTextBox1);
            this.txt_KullaniciAdi.Controls.Add(this.label1);
            this.txt_KullaniciAdi.Controls.Add(this.btn_kaydet);
            this.txt_KullaniciAdi.Controls.Add(this.txt_Soyad);
            this.txt_KullaniciAdi.Controls.Add(this.txt_Ad);
            this.txt_KullaniciAdi.Controls.Add(this.txt_TC);
            this.txt_KullaniciAdi.Controls.Add(this.label5);
            this.txt_KullaniciAdi.Controls.Add(this.label6);
            this.txt_KullaniciAdi.Controls.Add(this.label7);
            this.txt_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(883, 32);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(322, 638);
            this.txt_KullaniciAdi.TabIndex = 4;
            this.txt_KullaniciAdi.TabStop = false;
            this.txt_KullaniciAdi.Text = "ÖĞRETMEN ";
            // 
            // btb_geri
            // 
            this.btb_geri.Location = new System.Drawing.Point(29, 576);
            this.btb_geri.Name = "btb_geri";
            this.btb_geri.Size = new System.Drawing.Size(259, 45);
            this.btb_geri.TabIndex = 26;
            this.btb_geri.Text = "GERİ";
            this.btb_geri.UseVisualStyleBackColor = true;
            this.btb_geri.Click += new System.EventHandler(this.btb_geri_Click);
            // 
            // cmb_sinif
            // 
            this.cmb_sinif.FormattingEnabled = true;
            this.cmb_sinif.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmb_sinif.Location = new System.Drawing.Point(128, 210);
            this.cmb_sinif.Name = "cmb_sinif";
            this.cmb_sinif.Size = new System.Drawing.Size(160, 24);
            this.cmb_sinif.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sınıfı";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(130, 312);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(158, 22);
            this.txt_Sifre.TabIndex = 23;
            // 
            // txt_kulllanici
            // 
            this.txt_kulllanici.Location = new System.Drawing.Point(128, 259);
            this.txt_kulllanici.Name = "txt_kulllanici";
            this.txt_kulllanici.Size = new System.Drawing.Size(160, 22);
            this.txt_kulllanici.TabIndex = 22;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(27, 315);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(37, 17);
            this.lbl_Sifre.TabIndex = 21;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "KullaniciAdi";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(111, 382);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 75);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adres";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(29, 513);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(259, 45);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(128, 154);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(160, 22);
            this.txt_Soyad.TabIndex = 8;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(128, 96);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(160, 22);
            this.txt_Ad.TabIndex = 7;
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(128, 48);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(160, 22);
            this.txt_TC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "TC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 320);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sill);
            this.groupBox1.Controls.Add(this.txt_OgretmenTC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(43, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 170);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Silme Penceresi";
            // 
            // btn_sill
            // 
            this.btn_sill.Location = new System.Drawing.Point(30, 93);
            this.btn_sill.Name = "btn_sill";
            this.btn_sill.Size = new System.Drawing.Size(300, 43);
            this.btn_sill.TabIndex = 2;
            this.btn_sill.Text = "SİL";
            this.btn_sill.UseVisualStyleBackColor = true;
            this.btn_sill.Click += new System.EventHandler(this.btn_sill_Click);
            // 
            // txt_OgretmenTC
            // 
            this.txt_OgretmenTC.Location = new System.Drawing.Point(174, 38);
            this.txt_OgretmenTC.Name = "txt_OgretmenTC";
            this.txt_OgretmenTC.Size = new System.Drawing.Size(156, 27);
            this.txt_OgretmenTC.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "ÖĞRETMEN TC : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ara);
            this.groupBox2.Controls.Add(this.txt_OgretmenTCAra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_güncelle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(441, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 170);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Güncelleme Penceresi";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(22, 94);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(141, 42);
            this.btn_ara.TabIndex = 3;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_OgretmenTCAra
            // 
            this.txt_OgretmenTCAra.Location = new System.Drawing.Point(193, 32);
            this.txt_OgretmenTCAra.Name = "txt_OgretmenTCAra";
            this.txt_OgretmenTCAra.Size = new System.Drawing.Size(133, 27);
            this.txt_OgretmenTCAra.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "ÖĞRETMEN TC : ";
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(193, 93);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(135, 43);
            this.btn_güncelle.TabIndex = 14;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // frm_OgretmenIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Name = "frm_OgretmenIslemleri";
            this.Text = "ÖĞRETMEN İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frm_OgretmenIslemleri_Load);
            this.txt_KullaniciAdi.ResumeLayout(false);
            this.txt_KullaniciAdi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txt_KullaniciAdi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_kulllanici;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_sinif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sill;
        private System.Windows.Forms.TextBox txt_OgretmenTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_OgretmenTCAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btb_geri;
    }
}