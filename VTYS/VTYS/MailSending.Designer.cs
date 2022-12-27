namespace VTYS
{
    partial class MailSending
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTmnEkle = new System.Windows.Forms.Button();
            this.dgGonderilecekler = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTmzle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.egitimSec = new System.Windows.Forms.ComboBox();
            this.dgKatilimcilar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEk = new System.Windows.Forms.TextBox();
            this.btnEk = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGndr = new System.Windows.Forms.Button();
            this.txticerik = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGonderilecekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKatilimcilar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gönderilecekler Listesi:";
            // 
            // btnTmnEkle
            // 
            this.btnTmnEkle.Location = new System.Drawing.Point(590, 369);
            this.btnTmnEkle.Name = "btnTmnEkle";
            this.btnTmnEkle.Size = new System.Drawing.Size(134, 23);
            this.btnTmnEkle.TabIndex = 16;
            this.btnTmnEkle.Text = "Tümünü Ekle";
            this.btnTmnEkle.UseVisualStyleBackColor = true;
            this.btnTmnEkle.Click += new System.EventHandler(this.btnTmnEkle_Click);
            // 
            // dgGonderilecekler
            // 
            this.dgGonderilecekler.AllowUserToOrderColumns = true;
            this.dgGonderilecekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGonderilecekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGonderilecekler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4});
            this.dgGonderilecekler.Location = new System.Drawing.Point(754, 65);
            this.dgGonderilecekler.Name = "dgGonderilecekler";
            this.dgGonderilecekler.Size = new System.Drawing.Size(274, 298);
            this.dgGonderilecekler.TabIndex = 15;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad-Soyad";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mail";
            this.Column4.Name = "Column4";
            // 
            // btnTmzle
            // 
            this.btnTmzle.Location = new System.Drawing.Point(754, 369);
            this.btnTmzle.Name = "btnTmzle";
            this.btnTmzle.Size = new System.Drawing.Size(274, 23);
            this.btnTmzle.TabIndex = 14;
            this.btnTmzle.Text = "Temizle";
            this.btnTmzle.UseVisualStyleBackColor = true;
            this.btnTmzle.Click += new System.EventHandler(this.btnTmzle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(450, 369);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(131, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Katılımcılar:";
            // 
            // egitimSec
            // 
            this.egitimSec.FormattingEnabled = true;
            this.egitimSec.Items.AddRange(new object[] {
            "Hepsi",
            "Eğitim 1",
            "Eğitim 2",
            "Eğitim 3"});
            this.egitimSec.Location = new System.Drawing.Point(450, 14);
            this.egitimSec.Name = "egitimSec";
            this.egitimSec.Size = new System.Drawing.Size(121, 21);
            this.egitimSec.TabIndex = 11;
            this.egitimSec.Text = "Eğitim Seç";
            this.egitimSec.SelectedIndexChanged += new System.EventHandler(this.egitimSec_SelectedIndexChanged);
            // 
            // dgKatilimcilar
            // 
            this.dgKatilimcilar.AllowUserToOrderColumns = true;
            this.dgKatilimcilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKatilimcilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKatilimcilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.dgKatilimcilar.Location = new System.Drawing.Point(450, 65);
            this.dgKatilimcilar.Name = "dgKatilimcilar";
            this.dgKatilimcilar.Size = new System.Drawing.Size(274, 298);
            this.dgKatilimcilar.TabIndex = 10;
            this.dgKatilimcilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKatilimcilar_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ad-Soyad";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mail";
            this.Column3.Name = "Column3";
            // 
            // txtEk
            // 
            this.txtEk.Location = new System.Drawing.Point(211, 342);
            this.txtEk.Name = "txtEk";
            this.txtEk.Size = new System.Drawing.Size(195, 20);
            this.txtEk.TabIndex = 45;
            // 
            // btnEk
            // 
            this.btnEk.Location = new System.Drawing.Point(130, 342);
            this.btnEk.Name = "btnEk";
            this.btnEk.Size = new System.Drawing.Size(75, 23);
            this.btnEk.TabIndex = 44;
            this.btnEk.Text = "Dosya";
            this.btnEk.UseVisualStyleBackColor = true;
            this.btnEk.Click += new System.EventHandler(this.btnEk_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Main Gönderilecek Kişi Sayısı: ";
            // 
            // btnGndr
            // 
            this.btnGndr.Location = new System.Drawing.Point(130, 369);
            this.btnGndr.Name = "btnGndr";
            this.btnGndr.Size = new System.Drawing.Size(276, 23);
            this.btnGndr.TabIndex = 42;
            this.btnGndr.Text = "Gönder";
            this.btnGndr.UseVisualStyleBackColor = true;
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(130, 201);
            this.txticerik.Multiline = true;
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(276, 135);
            this.txticerik.TabIndex = 41;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(130, 175);
            this.txtBaslik.Multiline = true;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(276, 20);
            this.txtBaslik.TabIndex = 40;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(130, 123);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(276, 20);
            this.txtSifre.TabIndex = 39;
            this.txtSifre.Text = "imwdtlgbwwthnkvd";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(130, 89);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(276, 20);
            this.txtMail.TabIndex = 38;
            this.txtMail.Text = "ferdiyilmaz.ras@gmail.com";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(130, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(276, 20);
            this.txtAd.TabIndex = 37;
            this.txtAd.Text = "Ferdi Yılmaz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "İçerik:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Başlık:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Gönderici Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Gönderici Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Gönderici Ad Soyad:";
            // 
            // MailSending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.txtEk);
            this.Controls.Add(this.btnEk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGndr);
            this.Controls.Add(this.txticerik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTmnEkle);
            this.Controls.Add(this.dgGonderilecekler);
            this.Controls.Add(this.btnTmzle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.egitimSec);
            this.Controls.Add(this.dgKatilimcilar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MailSending";
            this.Text = "MailSending";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MailSending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGonderilecekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKatilimcilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTmnEkle;
        private System.Windows.Forms.DataGridView dgGonderilecekler;
        private System.Windows.Forms.Button btnTmzle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox egitimSec;
        private System.Windows.Forms.DataGridView dgKatilimcilar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtEk;
        private System.Windows.Forms.Button btnEk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGndr;
        private System.Windows.Forms.TextBox txticerik;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}