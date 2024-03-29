namespace ProjeYönetimi
{
    partial class CalisanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanEkle));
            this.calisanlarListesiComboBox = new System.Windows.Forms.ComboBox();
            this.calisanlarListesiLabel = new System.Windows.Forms.Label();
            this.calisanEkleButton = new System.Windows.Forms.Button();
            this.gizleButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cikisButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // calisanlarListesiComboBox
            // 
            this.calisanlarListesiComboBox.FormattingEnabled = true;
            this.calisanlarListesiComboBox.Location = new System.Drawing.Point(38, 83);
            this.calisanlarListesiComboBox.Name = "calisanlarListesiComboBox";
            this.calisanlarListesiComboBox.Size = new System.Drawing.Size(189, 21);
            this.calisanlarListesiComboBox.TabIndex = 0;
            // 
            // calisanlarListesiLabel
            // 
            this.calisanlarListesiLabel.AutoSize = true;
            this.calisanlarListesiLabel.BackColor = System.Drawing.Color.Transparent;
            this.calisanlarListesiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calisanlarListesiLabel.Location = new System.Drawing.Point(38, 64);
            this.calisanlarListesiLabel.Name = "calisanlarListesiLabel";
            this.calisanlarListesiLabel.Size = new System.Drawing.Size(90, 13);
            this.calisanlarListesiLabel.TabIndex = 1;
            this.calisanlarListesiLabel.Text = "Çalışanlar Listesi :";
            // 
            // calisanEkleButton
            // 
            this.calisanEkleButton.Location = new System.Drawing.Point(242, 83);
            this.calisanEkleButton.Name = "calisanEkleButton";
            this.calisanEkleButton.Size = new System.Drawing.Size(75, 23);
            this.calisanEkleButton.TabIndex = 2;
            this.calisanEkleButton.Text = "Ekle";
            this.calisanEkleButton.UseVisualStyleBackColor = true;
            // 
            // gizleButton
            // 
            this.gizleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gizleButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.gizleButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.gizleButton.FillColor = System.Drawing.Color.Transparent;
            this.gizleButton.IconColor = System.Drawing.Color.White;
            this.gizleButton.Location = new System.Drawing.Point(255, -2);
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
            this.cikisButton.Location = new System.Drawing.Point(306, -2);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(45, 38);
            this.cikisButton.TabIndex = 13;
            // 
            // CalisanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 172);
            this.Controls.Add(this.gizleButton);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.calisanEkleButton);
            this.Controls.Add(this.calisanlarListesiLabel);
            this.Controls.Add(this.calisanlarListesiComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalisanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalisanEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox calisanlarListesiComboBox;
        private System.Windows.Forms.Label calisanlarListesiLabel;
        private System.Windows.Forms.Button calisanEkleButton;
        private Guna.UI2.WinForms.Guna2ControlBox gizleButton;
        private Guna.UI2.WinForms.Guna2ControlBox cikisButton;
    }
}