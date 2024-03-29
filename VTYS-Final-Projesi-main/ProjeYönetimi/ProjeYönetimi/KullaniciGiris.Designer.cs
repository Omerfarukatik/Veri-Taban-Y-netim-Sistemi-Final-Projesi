namespace ProjeYönetimi
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.YeniKullaniciLabel = new System.Windows.Forms.Label();
            this.KayıtOlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikisButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gizleButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.GirisYapButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmailLabel.Location = new System.Drawing.Point(414, 333);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(54, 17);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email : ";
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.BackColor = System.Drawing.Color.Transparent;
            this.SifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SifreLabel.Location = new System.Drawing.Point(419, 377);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(49, 17);
            this.SifreLabel.TabIndex = 1;
            this.SifreLabel.Text = "Sifre : ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(474, 330);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(126, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(474, 374);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(126, 20);
            this.sifreTextBox.TabIndex = 3;
            // 
            // YeniKullaniciLabel
            // 
            this.YeniKullaniciLabel.AutoSize = true;
            this.YeniKullaniciLabel.BackColor = System.Drawing.Color.Transparent;
            this.YeniKullaniciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YeniKullaniciLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.YeniKullaniciLabel.Location = new System.Drawing.Point(418, 474);
            this.YeniKullaniciLabel.Name = "YeniKullaniciLabel";
            this.YeniKullaniciLabel.Size = new System.Drawing.Size(201, 17);
            this.YeniKullaniciLabel.TabIndex = 6;
            this.YeniKullaniciLabel.Text = "Aramıza Katılmak İster Misiniz?";
            // 
            // KayıtOlLinkLabel
            // 
            this.KayıtOlLinkLabel.AutoSize = true;
            this.KayıtOlLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.KayıtOlLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KayıtOlLinkLabel.Location = new System.Drawing.Point(494, 491);
            this.KayıtOlLinkLabel.Name = "KayıtOlLinkLabel";
            this.KayıtOlLinkLabel.Size = new System.Drawing.Size(46, 13);
            this.KayıtOlLinkLabel.TabIndex = 7;
            this.KayıtOlLinkLabel.TabStop = true;
            this.KayıtOlLinkLabel.Text = "Kayıt Ol!";
            this.KayıtOlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KayıtOlLinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cikisButton
            // 
            this.cikisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.cikisButton.FillColor = System.Drawing.Color.Transparent;
            this.cikisButton.IconColor = System.Drawing.Color.White;
            this.cikisButton.Location = new System.Drawing.Point(994, -1);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(45, 38);
            this.cikisButton.TabIndex = 9;
            // 
            // gizleButton
            // 
            this.gizleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gizleButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.gizleButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.gizleButton.FillColor = System.Drawing.Color.Transparent;
            this.gizleButton.IconColor = System.Drawing.Color.White;
            this.gizleButton.Location = new System.Drawing.Point(943, -1);
            this.gizleButton.Name = "gizleButton";
            this.gizleButton.Size = new System.Drawing.Size(45, 38);
            this.gizleButton.TabIndex = 10;
            // 
            // GirisYapButton
            // 
            this.GirisYapButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GirisYapButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GirisYapButton.ForeColor = System.Drawing.Color.White;
            this.GirisYapButton.Location = new System.Drawing.Point(474, 409);
            this.GirisYapButton.Name = "GirisYapButton";
            this.GirisYapButton.Size = new System.Drawing.Size(77, 20);
            this.GirisYapButton.TabIndex = 0;
            this.GirisYapButton.Text = "Giris Yap";
            this.GirisYapButton.Click += new System.EventHandler(this.GirisYapButton_Click);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 673);
            this.Controls.Add(this.GirisYapButton);
            this.Controls.Add(this.gizleButton);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KayıtOlLinkLabel);
            this.Controls.Add(this.YeniKullaniciLabel);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.EmailLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciGiris";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciGiris_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label YeniKullaniciLabel;
        private System.Windows.Forms.LinkLabel KayıtOlLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox cikisButton;
        private Guna.UI2.WinForms.Guna2ControlBox gizleButton;
        private Guna.UI2.WinForms.Guna2Button GirisYapButton;
    }
}

