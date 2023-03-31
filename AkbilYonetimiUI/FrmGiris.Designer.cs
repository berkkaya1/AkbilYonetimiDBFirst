namespace AkbilYonetimiUI
{
    partial class FrmGiris
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
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            checkBoxHatirla = new CheckBox();
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.TitleBar;
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 45);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Snow;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 45);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Snow;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(173, 60);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 50);
            txtEmail.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(173, 133);
            txtSifre.Margin = new Padding(4, 4, 4, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(321, 50);
            txtSifre.TabIndex = 3;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.BackColor = Color.Snow;
            checkBoxHatirla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(265, 216);
            checkBoxHatirla.Margin = new Padding(4, 4, 4, 4);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(233, 49);
            checkBoxHatirla.TabIndex = 4;
            checkBoxHatirla.Text = "Beni Hatırla !";
            checkBoxHatirla.UseVisualStyleBackColor = false;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Snow;
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(48, 372);
            btnKayitOl.Margin = new Padding(4, 4, 4, 4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(455, 58);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Snow;
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(48, 294);
            btnGirisYap.Margin = new Padding(4, 4, 4, 4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(447, 59);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.galata_kulesi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 625);
            Controls.Add(btnGirisYap);
            Controls.Add(btnKayitOl);
            Controls.Add(checkBoxHatirla);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmGiris";
            Text = "FrmGiris";
            FormClosed += FrmGiris_FormClosed;
            Load += FrmGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private CheckBox checkBoxHatirla;
        private Button btnKayitOl;
        private Button btnGirisYap;
    }
}