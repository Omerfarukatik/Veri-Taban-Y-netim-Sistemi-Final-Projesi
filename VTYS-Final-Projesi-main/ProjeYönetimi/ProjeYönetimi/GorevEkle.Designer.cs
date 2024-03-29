namespace ProjeYönetimi
{
    partial class GorevEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevEkle));
            this.projeComboBox = new System.Windows.Forms.ComboBox();
            this.ProjeLabel = new System.Windows.Forms.Label();
            this.GorevLabel = new System.Windows.Forms.Label();
            this.CalisanlarComboBox = new System.Windows.Forms.ComboBox();
            this.calisanLabel = new System.Windows.Forms.Label();
            this.KaydetButton = new System.Windows.Forms.Button();
            this.gizleButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cikisButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.GorevTextBox = new System.Windows.Forms.TextBox();
            this.BaslangicTextBox = new System.Windows.Forms.TextBox();
            this.BaslangicLabel = new System.Windows.Forms.Label();
            this.BitisTextBox = new System.Windows.Forms.TextBox();
            this.BitisLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projeComboBox
            // 
            this.projeComboBox.FormattingEnabled = true;
            this.projeComboBox.Location = new System.Drawing.Point(40, 45);
            this.projeComboBox.Name = "projeComboBox";
            this.projeComboBox.Size = new System.Drawing.Size(121, 21);
            this.projeComboBox.TabIndex = 0;
            this.projeComboBox.SelectedIndexChanged += new System.EventHandler(this.projeComboBox_SelectedIndexChanged);
            // 
            // ProjeLabel
            // 
            this.ProjeLabel.AutoSize = true;
            this.ProjeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProjeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProjeLabel.Location = new System.Drawing.Point(37, 29);
            this.ProjeLabel.Name = "ProjeLabel";
            this.ProjeLabel.Size = new System.Drawing.Size(40, 13);
            this.ProjeLabel.TabIndex = 1;
            this.ProjeLabel.Text = "Proje : ";
            // 
            // GorevLabel
            // 
            this.GorevLabel.AutoSize = true;
            this.GorevLabel.BackColor = System.Drawing.Color.Transparent;
            this.GorevLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GorevLabel.Location = new System.Drawing.Point(37, 98);
            this.GorevLabel.Name = "GorevLabel";
            this.GorevLabel.Size = new System.Drawing.Size(45, 13);
            this.GorevLabel.TabIndex = 3;
            this.GorevLabel.Text = "Görev : ";
            // 
            // CalisanlarComboBox
            // 
            this.CalisanlarComboBox.FormattingEnabled = true;
            this.CalisanlarComboBox.Location = new System.Drawing.Point(170, 45);
            this.CalisanlarComboBox.Name = "CalisanlarComboBox";
            this.CalisanlarComboBox.Size = new System.Drawing.Size(121, 21);
            this.CalisanlarComboBox.TabIndex = 4;
            this.CalisanlarComboBox.SelectedIndexChanged += new System.EventHandler(this.CalisanlarComboBox_SelectedIndexChanged);
            // 
            // calisanLabel
            // 
            this.calisanLabel.AutoSize = true;
            this.calisanLabel.BackColor = System.Drawing.Color.Transparent;
            this.calisanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calisanLabel.Location = new System.Drawing.Point(167, 29);
            this.calisanLabel.Name = "calisanLabel";
            this.calisanLabel.Size = new System.Drawing.Size(50, 13);
            this.calisanLabel.TabIndex = 5;
            this.calisanLabel.Text = "Çalışan : ";
            // 
            // KaydetButton
            // 
            this.KaydetButton.Location = new System.Drawing.Point(353, 140);
            this.KaydetButton.Name = "KaydetButton";
            this.KaydetButton.Size = new System.Drawing.Size(75, 23);
            this.KaydetButton.TabIndex = 6;
            this.KaydetButton.Text = "Kaydet";
            this.KaydetButton.UseVisualStyleBackColor = true;
            this.KaydetButton.Click += new System.EventHandler(this.KaydetButton_Click);
            // 
            // gizleButton
            // 
            this.gizleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gizleButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.gizleButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.gizleButton.FillColor = System.Drawing.Color.Transparent;
            this.gizleButton.IconColor = System.Drawing.Color.White;
            this.gizleButton.Location = new System.Drawing.Point(431, 1);
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
            this.cikisButton.Location = new System.Drawing.Point(482, 1);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(45, 38);
            this.cikisButton.TabIndex = 13;
            // 
            // GorevTextBox
            // 
            this.GorevTextBox.Location = new System.Drawing.Point(40, 114);
            this.GorevTextBox.Name = "GorevTextBox";
            this.GorevTextBox.Size = new System.Drawing.Size(121, 20);
            this.GorevTextBox.TabIndex = 15;
            // 
            // BaslangicTextBox
            // 
            this.BaslangicTextBox.Location = new System.Drawing.Point(170, 114);
            this.BaslangicTextBox.Name = "BaslangicTextBox";
            this.BaslangicTextBox.Size = new System.Drawing.Size(121, 20);
            this.BaslangicTextBox.TabIndex = 17;
            // 
            // BaslangicLabel
            // 
            this.BaslangicLabel.AutoSize = true;
            this.BaslangicLabel.BackColor = System.Drawing.Color.Transparent;
            this.BaslangicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BaslangicLabel.Location = new System.Drawing.Point(167, 98);
            this.BaslangicLabel.Name = "BaslangicLabel";
            this.BaslangicLabel.Size = new System.Drawing.Size(91, 13);
            this.BaslangicLabel.TabIndex = 16;
            this.BaslangicLabel.Text = "Başlangıç Tarihi : ";
            // 
            // BitisTextBox
            // 
            this.BitisTextBox.Location = new System.Drawing.Point(307, 114);
            this.BitisTextBox.Name = "BitisTextBox";
            this.BitisTextBox.Size = new System.Drawing.Size(121, 20);
            this.BitisTextBox.TabIndex = 19;
            // 
            // BitisLabel
            // 
            this.BitisLabel.AutoSize = true;
            this.BitisLabel.BackColor = System.Drawing.Color.Transparent;
            this.BitisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BitisLabel.Location = new System.Drawing.Point(304, 98);
            this.BitisLabel.Name = "BitisLabel";
            this.BitisLabel.Size = new System.Drawing.Size(64, 13);
            this.BitisLabel.TabIndex = 18;
            this.BitisLabel.Text = "Bitiş Tarihi : ";
            // 
            // GorevEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 200);
            this.Controls.Add(this.BitisTextBox);
            this.Controls.Add(this.BitisLabel);
            this.Controls.Add(this.BaslangicTextBox);
            this.Controls.Add(this.BaslangicLabel);
            this.Controls.Add(this.GorevTextBox);
            this.Controls.Add(this.gizleButton);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.KaydetButton);
            this.Controls.Add(this.calisanLabel);
            this.Controls.Add(this.CalisanlarComboBox);
            this.Controls.Add(this.GorevLabel);
            this.Controls.Add(this.ProjeLabel);
            this.Controls.Add(this.projeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GorevEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GorevEkle";
            this.Load += new System.EventHandler(this.GorevEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projeComboBox;
        private System.Windows.Forms.Label ProjeLabel;
        private System.Windows.Forms.Label GorevLabel;
        private System.Windows.Forms.ComboBox CalisanlarComboBox;
        private System.Windows.Forms.Label calisanLabel;
        private System.Windows.Forms.Button KaydetButton;
        private Guna.UI2.WinForms.Guna2ControlBox gizleButton;
        private Guna.UI2.WinForms.Guna2ControlBox cikisButton;
        private System.Windows.Forms.TextBox GorevTextBox;
        private System.Windows.Forms.TextBox BaslangicTextBox;
        private System.Windows.Forms.Label BaslangicLabel;
        private System.Windows.Forms.TextBox BitisTextBox;
        private System.Windows.Forms.Label BitisLabel;
    }
}