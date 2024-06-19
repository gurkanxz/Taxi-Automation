namespace TaksiDurakOtomasyon
{
    partial class Veritabani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veritabani));
            this.btn_gosterGizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.chbx_uzakSunucu = new System.Windows.Forms.CheckBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.tx_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.tx_veritabaniAdi = new System.Windows.Forms.TextBox();
            this.tx_sunucuAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gosterGizle
            // 
            this.btn_gosterGizle.BackColor = System.Drawing.Color.Transparent;
            this.btn_gosterGizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gosterGizle.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_gosterGizle.Location = new System.Drawing.Point(532, 221);
            this.btn_gosterGizle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gosterGizle.Name = "btn_gosterGizle";
            this.btn_gosterGizle.Size = new System.Drawing.Size(50, 31);
            this.btn_gosterGizle.TabIndex = 15;
            this.btn_gosterGizle.UseVisualStyleBackColor = false;
            this.btn_gosterGizle.Click += new System.EventHandler(this.btn_gosterGizle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(66)))));
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_kaydet.Location = new System.Drawing.Point(340, 292);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(100, 28);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // chbx_uzakSunucu
            // 
            this.chbx_uzakSunucu.AutoSize = true;
            this.chbx_uzakSunucu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_uzakSunucu.Location = new System.Drawing.Point(162, 165);
            this.chbx_uzakSunucu.Margin = new System.Windows.Forms.Padding(4);
            this.chbx_uzakSunucu.Name = "chbx_uzakSunucu";
            this.chbx_uzakSunucu.Size = new System.Drawing.Size(175, 20);
            this.chbx_uzakSunucu.TabIndex = 13;
            this.chbx_uzakSunucu.Text = "Uzak Sunucu Bağlantısı :";
            this.chbx_uzakSunucu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_uzakSunucu.UseVisualStyleBackColor = true;
            this.chbx_uzakSunucu.CheckedChanged += new System.EventHandler(this.chbx_uzakSunucu_CheckedChanged);
            // 
            // tx_sifre
            // 
            this.tx_sifre.Enabled = false;
            this.tx_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sifre.Location = new System.Drawing.Point(271, 225);
            this.tx_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(253, 27);
            this.tx_sifre.TabIndex = 9;
            // 
            // tx_kullaniciAdi
            // 
            this.tx_kullaniciAdi.Enabled = false;
            this.tx_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_kullaniciAdi.Location = new System.Drawing.Point(271, 193);
            this.tx_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tx_kullaniciAdi.Name = "tx_kullaniciAdi";
            this.tx_kullaniciAdi.Size = new System.Drawing.Size(253, 27);
            this.tx_kullaniciAdi.TabIndex = 10;
            // 
            // tx_veritabaniAdi
            // 
            this.tx_veritabaniAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_veritabaniAdi.Location = new System.Drawing.Point(271, 121);
            this.tx_veritabaniAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tx_veritabaniAdi.Name = "tx_veritabaniAdi";
            this.tx_veritabaniAdi.Size = new System.Drawing.Size(253, 27);
            this.tx_veritabaniAdi.TabIndex = 11;
            // 
            // tx_sunucuAdi
            // 
            this.tx_sunucuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sunucuAdi.Location = new System.Drawing.Point(271, 89);
            this.tx_sunucuAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tx_sunucuAdi.Name = "tx_sunucuAdi";
            this.tx_sunucuAdi.Size = new System.Drawing.Size(253, 27);
            this.tx_sunucuAdi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanici Adi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Veritabanı Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sunucu Adı :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaksiDurakOtomasyon.Properties.Resources.giphy2;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 352);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 38);
            this.panel2.TabIndex = 21;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TaksiDurakOtomasyon.Properties.Resources.cross_13077712__3_;
            this.button1.Location = new System.Drawing.Point(645, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 38);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(832, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(2, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "VERİTABANI";
            // 
            // Veritabani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(681, 383);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_gosterGizle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.chbx_uzakSunucu);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_kullaniciAdi);
            this.Controls.Add(this.tx_veritabaniAdi);
            this.Controls.Add(this.tx_sunucuAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Veritabani";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabani";
            this.Load += new System.EventHandler(this.Veritabani_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gosterGizle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.CheckBox chbx_uzakSunucu;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.TextBox tx_kullaniciAdi;
        private System.Windows.Forms.TextBox tx_veritabaniAdi;
        private System.Windows.Forms.TextBox tx_sunucuAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}