
namespace AnaOkulu
{
    partial class frm_SilinenKayitlar
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
            this.dt_ogrenci = new System.Windows.Forms.DataGridView();
            this.dt_ogretmen = new System.Windows.Forms.DataGridView();
            this.dt_veli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ogrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ogretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_veli)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_ogrenci
            // 
            this.dt_ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_ogrenci.Location = new System.Drawing.Point(30, 43);
            this.dt_ogrenci.Name = "dt_ogrenci";
            this.dt_ogrenci.RowHeadersWidth = 51;
            this.dt_ogrenci.RowTemplate.Height = 24;
            this.dt_ogrenci.Size = new System.Drawing.Size(528, 317);
            this.dt_ogrenci.TabIndex = 0;
            // 
            // dt_ogretmen
            // 
            this.dt_ogretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_ogretmen.Location = new System.Drawing.Point(582, 43);
            this.dt_ogretmen.Name = "dt_ogretmen";
            this.dt_ogretmen.RowHeadersWidth = 51;
            this.dt_ogretmen.RowTemplate.Height = 24;
            this.dt_ogretmen.Size = new System.Drawing.Size(479, 317);
            this.dt_ogretmen.TabIndex = 1;
            // 
            // dt_veli
            // 
            this.dt_veli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_veli.Location = new System.Drawing.Point(30, 401);
            this.dt_veli.Name = "dt_veli";
            this.dt_veli.RowHeadersWidth = 51;
            this.dt_veli.RowTemplate.Height = 24;
            this.dt_veli.Size = new System.Drawing.Size(1031, 230);
            this.dt_veli.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "SİLİNEN ÖĞRENCİLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "SİLİNEN ÖĞRETMENLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "SİLİNEN VELİLER";
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(858, 650);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(203, 46);
            this.btn_geri.TabIndex = 6;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // frm_SilinenKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 722);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_veli);
            this.Controls.Add(this.dt_ogretmen);
            this.Controls.Add(this.dt_ogrenci);
            this.Name = "frm_SilinenKayitlar";
            this.Text = "frm_SilinenKayitlar";
            this.Load += new System.EventHandler(this.frm_SilinenKayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_ogrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ogretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_veli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_ogrenci;
        private System.Windows.Forms.DataGridView dt_ogretmen;
        private System.Windows.Forms.DataGridView dt_veli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_geri;
    }
}