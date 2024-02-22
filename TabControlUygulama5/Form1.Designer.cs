namespace TabControlUygulama5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Musteri = new System.Windows.Forms.TabPage();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Siparis = new System.Windows.Forms.TabPage();
            this.nTatlı = new System.Windows.Forms.NumericUpDown();
            this.nAnaYemek = new System.Windows.Forms.NumericUpDown();
            this.nSalata = new System.Windows.Forms.NumericUpDown();
            this.nCorba = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Hesap = new System.Windows.Forms.TabPage();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.TabControl1.SuspendLayout();
            this.Musteri.SuspendLayout();
            this.Siparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTatlı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAnaYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).BeginInit();
            this.Hesap.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Musteri);
            this.TabControl1.Controls.Add(this.Siparis);
            this.TabControl1.Controls.Add(this.Hesap);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(462, 438);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // Musteri
            // 
            this.Musteri.Controls.Add(this.txtAdres);
            this.Musteri.Controls.Add(this.txtTelefon);
            this.Musteri.Controls.Add(this.txtAdSoyad);
            this.Musteri.Controls.Add(this.label3);
            this.Musteri.Controls.Add(this.label2);
            this.Musteri.Controls.Add(this.label1);
            this.Musteri.Location = new System.Drawing.Point(4, 22);
            this.Musteri.Name = "Musteri";
            this.Musteri.Padding = new System.Windows.Forms.Padding(3);
            this.Musteri.Size = new System.Drawing.Size(454, 412);
            this.Musteri.TabIndex = 0;
            this.Musteri.Text = "Müşteri";
            this.Musteri.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(112, 82);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(197, 123);
            this.txtAdres.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(112, 46);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(197, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(112, 17);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(197, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // Siparis
            // 
            this.Siparis.Controls.Add(this.nTatlı);
            this.Siparis.Controls.Add(this.nAnaYemek);
            this.Siparis.Controls.Add(this.nSalata);
            this.Siparis.Controls.Add(this.nCorba);
            this.Siparis.Controls.Add(this.label7);
            this.Siparis.Controls.Add(this.label6);
            this.Siparis.Controls.Add(this.label5);
            this.Siparis.Controls.Add(this.label4);
            this.Siparis.Location = new System.Drawing.Point(4, 22);
            this.Siparis.Name = "Siparis";
            this.Siparis.Padding = new System.Windows.Forms.Padding(3);
            this.Siparis.Size = new System.Drawing.Size(454, 412);
            this.Siparis.TabIndex = 1;
            this.Siparis.Text = "Sipariş";
            this.Siparis.UseVisualStyleBackColor = true;
            // 
            // nTatlı
            // 
            this.nTatlı.Location = new System.Drawing.Point(91, 104);
            this.nTatlı.Name = "nTatlı";
            this.nTatlı.Size = new System.Drawing.Size(41, 20);
            this.nTatlı.TabIndex = 7;
            // 
            // nAnaYemek
            // 
            this.nAnaYemek.Location = new System.Drawing.Point(91, 76);
            this.nAnaYemek.Name = "nAnaYemek";
            this.nAnaYemek.Size = new System.Drawing.Size(41, 20);
            this.nAnaYemek.TabIndex = 6;
            // 
            // nSalata
            // 
            this.nSalata.Location = new System.Drawing.Point(91, 48);
            this.nSalata.Name = "nSalata";
            this.nSalata.Size = new System.Drawing.Size(41, 20);
            this.nSalata.TabIndex = 5;
            // 
            // nCorba
            // 
            this.nCorba.Location = new System.Drawing.Point(91, 21);
            this.nCorba.Name = "nCorba";
            this.nCorba.Size = new System.Drawing.Size(41, 20);
            this.nCorba.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tatlı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ana Yemek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çorba";
            // 
            // Hesap
            // 
            this.Hesap.Controls.Add(this.txtBilgi);
            this.Hesap.Location = new System.Drawing.Point(4, 22);
            this.Hesap.Name = "Hesap";
            this.Hesap.Size = new System.Drawing.Size(454, 412);
            this.Hesap.TabIndex = 2;
            this.Hesap.Text = "Hesap";
            this.Hesap.UseVisualStyleBackColor = true;
            this.Hesap.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBilgi.Location = new System.Drawing.Point(0, 0);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(454, 412);
            this.txtBilgi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 438);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.Musteri.ResumeLayout(false);
            this.Musteri.PerformLayout();
            this.Siparis.ResumeLayout(false);
            this.Siparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTatlı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAnaYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).EndInit();
            this.Hesap.ResumeLayout(false);
            this.Hesap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Musteri;
        private System.Windows.Forms.TabPage Siparis;
        private System.Windows.Forms.TabPage Hesap;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nTatlı;
        private System.Windows.Forms.NumericUpDown nAnaYemek;
        private System.Windows.Forms.NumericUpDown nSalata;
        private System.Windows.Forms.NumericUpDown nCorba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBilgi;
    }
}

