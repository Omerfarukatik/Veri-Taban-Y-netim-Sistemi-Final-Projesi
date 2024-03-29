namespace ProjeYönetimi
{
    partial class GorevGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevGuncelle));
            this.GorevlerComboBox = new System.Windows.Forms.ComboBox();
            this.HangiGorevLabel = new System.Windows.Forms.Label();
            this.BaslangicTarihiComboBox = new System.Windows.Forms.TextBox();
            this.BitisTarihiComboBox = new System.Windows.Forms.TextBox();
            this.BaslangicTarihiLabel = new System.Windows.Forms.Label();
            this.BitisTarihiLabel = new System.Windows.Forms.Label();
            this.DurumLabel = new System.Windows.Forms.Label();
            this.DurumComboBox = new System.Windows.Forms.ComboBox();
            this.GuncelleButton = new System.Windows.Forms.Button();
            this.gizleButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cikisButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ProjeLabel = new System.Windows.Forms.Label();
            this.ProjelerComboBox = new System.Windows.Forms.ComboBox();
            this.CalisanlarLabel = new System.Windows.Forms.Label();
            this.CalisanlarComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GorevlerComboBox
            // 
            this.GorevlerComboBox.FormattingEnabled = true;
            this.GorevlerComboBox.Location = new System.Drawing.Point(203, 71);
            this.GorevlerComboBox.Name = "GorevlerComboBox";
            this.GorevlerComboBox.Size = new System.Drawing.Size(121, 21);
            this.GorevlerComboBox.TabIndex = 0;
            this.GorevlerComboBox.SelectedIndexChanged += new System.EventHandler(this.GorevlerComboBox_SelectedIndexChanged);
            // 
            // HangiGorevLabel
            // 
            this.HangiGorevLabel.AutoSize = true;
            this.HangiGorevLabel.BackColor = System.Drawing.Color.Transparent;
            this.HangiGorevLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HangiGorevLabel.Location = new System.Drawing.Point(200, 56);
            this.HangiGorevLabel.Name = "HangiGorevLabel";
            this.HangiGorevLabel.Size = new System.Drawing.Size(82, 13);
            this.HangiGorevLabel.TabIndex = 1;
            this.HangiGorevLabel.Text = "Görev Seçiniz : ";
            // 
            // BaslangicTarihiComboBox
            // 
            this.BaslangicTarihiComboBox.Location = new System.Drawing.Point(58, 155);
            this.BaslangicTarihiComboBox.Name = "BaslangicTarihiComboBox";
            this.BaslangicTarihiComboBox.Size = new System.Drawing.Size(116, 20);
            this.BaslangicTarihiComboBox.TabIndex = 2;
            // 
            // BitisTarihiComboBox
            // 
            this.BitisTarihiComboBox.Location = new System.Drawing.Point(203, 156);
            this.BitisTarihiComboBox.Name = "BitisTarihiComboBox";
            this.BitisTarihiComboBox.Size = new System.Drawing.Size(121, 20);
            this.BitisTarihiComboBox.TabIndex = 3;
            // 
            // BaslangicTarihiLabel
            // 
            this.BaslangicTarihiLabel.AutoSize = true;
            this.BaslangicTarihiLabel.BackColor = System.Drawing.Color.Transparent;
            this.BaslangicTarihiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BaslangicTarihiLabel.Location = new System.Drawing.Point(55, 139);
            this.BaslangicTarihiLabel.Name = "BaslangicTarihiLabel";
            this.BaslangicTarihiLabel.Size = new System.Drawing.Size(91, 13);
            this.BaslangicTarihiLabel.TabIndex = 5;
            this.BaslangicTarihiLabel.Text = "Başlangıç Tarihi : ";
            // 
            // BitisTarihiLabel
            // 
            this.BitisTarihiLabel.AutoSize = true;
            this.BitisTarihiLabel.BackColor = System.Drawing.Color.Transparent;
            this.BitisTarihiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BitisTarihiLabel.Location = new System.Drawing.Point(200, 140);
            this.BitisTarihiLabel.Name = "BitisTarihiLabel";
            this.BitisTarihiLabel.Size = new System.Drawing.Size(64, 13);
            this.BitisTarihiLabel.TabIndex = 6;
            this.BitisTarihiLabel.Text = "Bitis Tarihi : ";
            // 
            // DurumLabel
            // 
            this.DurumLabel.AutoSize = true;
            this.DurumLabel.BackColor = System.Drawing.Color.Transparent;
            this.DurumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DurumLabel.Location = new System.Drawing.Point(336, 140);
            this.DurumLabel.Name = "DurumLabel";
            this.DurumLabel.Size = new System.Drawing.Size(53, 13);
            this.DurumLabel.TabIndex = 7;
            this.DurumLabel.Text = "Durumu : ";
            // 
            // DurumComboBox
            // 
            this.DurumComboBox.FormattingEnabled = true;
            this.DurumComboBox.Items.AddRange(new object[] {
            "Tamamlandı",
            "Devam Ediyor",
            "Tamamlanamadı"});
            this.DurumComboBox.Location = new System.Drawing.Point(339, 155);
            this.DurumComboBox.Name = "DurumComboBox";
            this.DurumComboBox.Size = new System.Drawing.Size(125, 21);
            this.DurumComboBox.TabIndex = 8;
            // 
            // GuncelleButton
            // 
            this.GuncelleButton.Location = new System.Drawing.Point(401, 208);
            this.GuncelleButton.Name = "GuncelleButton";
            this.GuncelleButton.Size = new System.Drawing.Size(75, 23);
            this.GuncelleButton.TabIndex = 9;
            this.GuncelleButton.Text = "Güncelle";
            this.GuncelleButton.UseVisualStyleBackColor = true;
            this.GuncelleButton.Click += new System.EventHandler(this.GuncelleButton_Click);
            // 
            // gizleButton
            // 
            this.gizleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gizleButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.gizleButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.gizleButton.FillColor = System.Drawing.Color.Transparent;
            this.gizleButton.IconColor = System.Drawing.Color.White;
            this.gizleButton.Location = new System.Drawing.Point(419, 2);
            this.gizleButton.Name = "gizleButton";
            this.gizleButton.Size = new System.Drawing.Size(45, 38);
            this.gizleButton.TabIndex = 14;
            // 
            // cikisButton
            // 
            this.cikisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.cikisButton.FillColor = System.Drawing.Color.Transparent;
            this.cikisButton.IconColor = System.Drawing.Color.White;
            this.cikisButton.Location = new System.Drawing.Point(470, 2);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(45, 38);
            this.cikisButton.TabIndex = 13;
            // 
            // ProjeLabel
            // 
            this.ProjeLabel.AutoSize = true;
            this.ProjeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProjeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProjeLabel.Location = new System.Drawing.Point(55, 55);
            this.ProjeLabel.Name = "ProjeLabel";
            this.ProjeLabel.Size = new System.Drawing.Size(74, 13);
            this.ProjeLabel.TabIndex = 16;
            this.ProjeLabel.Text = "Proje Seçiniz :";
            // 
            // ProjelerComboBox
            // 
            this.ProjelerComboBox.FormattingEnabled = true;
            this.ProjelerComboBox.Location = new System.Drawing.Point(58, 71);
            this.ProjelerComboBox.Name = "ProjelerComboBox";
            this.ProjelerComboBox.Size = new System.Drawing.Size(116, 21);
            this.ProjelerComboBox.TabIndex = 15;
            this.ProjelerComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjelerComboBox_SelectedIndexChanged);
            // 
            // CalisanlarLabel
            // 
            this.CalisanlarLabel.AutoSize = true;
            this.CalisanlarLabel.BackColor = System.Drawing.Color.Transparent;
            this.CalisanlarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CalisanlarLabel.Location = new System.Drawing.Point(339, 56);
            this.CalisanlarLabel.Name = "CalisanlarLabel";
            this.CalisanlarLabel.Size = new System.Drawing.Size(61, 13);
            this.CalisanlarLabel.TabIndex = 18;
            this.CalisanlarLabel.Text = "Çalışanlar : ";
            // 
            // CalisanlarComboBox
            // 
            this.CalisanlarComboBox.FormattingEnabled = true;
            this.CalisanlarComboBox.Location = new System.Drawing.Point(342, 71);
            this.CalisanlarComboBox.Name = "CalisanlarComboBox";
            this.CalisanlarComboBox.Size = new System.Drawing.Size(121, 21);
            this.CalisanlarComboBox.TabIndex = 17;
            this.CalisanlarComboBox.SelectedIndexChanged += new System.EventHandler(this.CalisanlarComboBox_SelectedIndexChanged);
            // 
            // GorevGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 263);
            this.Controls.Add(this.CalisanlarLabel);
            this.Controls.Add(this.CalisanlarComboBox);
            this.Controls.Add(this.ProjeLabel);
            this.Controls.Add(this.ProjelerComboBox);
            this.Controls.Add(this.gizleButton);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.GuncelleButton);
            this.Controls.Add(this.DurumComboBox);
            this.Controls.Add(this.DurumLabel);
            this.Controls.Add(this.BitisTarihiLabel);
            this.Controls.Add(this.BaslangicTarihiLabel);
            this.Controls.Add(this.BitisTarihiComboBox);
            this.Controls.Add(this.BaslangicTarihiComboBox);
            this.Controls.Add(this.HangiGorevLabel);
            this.Controls.Add(this.GorevlerComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GorevGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GorevGuncelle";
            this.Load += new System.EventHandler(this.GorevGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GorevlerComboBox;
        private System.Windows.Forms.Label HangiGorevLabel;
        private System.Windows.Forms.TextBox BaslangicTarihiComboBox;
        private System.Windows.Forms.TextBox BitisTarihiComboBox;
        private System.Windows.Forms.Label BaslangicTarihiLabel;
        private System.Windows.Forms.Label BitisTarihiLabel;
        private System.Windows.Forms.Label DurumLabel;
        private System.Windows.Forms.ComboBox DurumComboBox;
        private System.Windows.Forms.Button GuncelleButton;
        private Guna.UI2.WinForms.Guna2ControlBox gizleButton;
        private Guna.UI2.WinForms.Guna2ControlBox cikisButton;
        private System.Windows.Forms.Label ProjeLabel;
        private System.Windows.Forms.ComboBox ProjelerComboBox;
        private System.Windows.Forms.Label CalisanlarLabel;
        private System.Windows.Forms.ComboBox CalisanlarComboBox;
    }
}