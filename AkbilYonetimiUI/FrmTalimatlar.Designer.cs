namespace AkbilYonetimiUI
{
    partial class FrmTalimatlar
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            anaMenuToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            cmbBoxAkbiller = new ComboBox();
            label1 = new Label();
            txtYuklenecekTutar = new TextBox();
            btnTalimatKaydet = new Button();
            label2 = new Label();
            lblBekleyenTalimat = new Label();
            checkBoxTumunuGoster = new CheckBox();
            dataGridViewTalimatlar = new DataGridView();
            timerBekleyenTalimat = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            talimatiYukleToolStripMenuItem = new ToolStripMenuItem();
            talimatiIptalEtToolStripMenuItem = new ToolStripMenuItem();
            groupBoxYukleme = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBoxYukleme.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenuToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1727, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            anaMenuToolStripMenuItem.Size = new Size(182, 45);
            anaMenuToolStripMenuItem.Text = "Ana Menü";
            anaMenuToolStripMenuItem.Click += anaMenuToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(163, 45);
            cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // cmbBoxAkbiller
            // 
            cmbBoxAkbiller.FormattingEnabled = true;
            cmbBoxAkbiller.Location = new Point(53, 91);
            cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            cmbBoxAkbiller.Size = new Size(670, 53);
            cmbBoxAkbiller.TabIndex = 1;
            cmbBoxAkbiller.SelectedIndexChanged += cmbBoxAkbiller_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 44);
            label1.Name = "label1";
            label1.Size = new Size(269, 45);
            label1.TabIndex = 2;
            label1.Text = "Yüklenecek Tutar:";
            // 
            // txtYuklenecekTutar
            // 
            txtYuklenecekTutar.Location = new Point(16, 114);
            txtYuklenecekTutar.Name = "txtYuklenecekTutar";
            txtYuklenecekTutar.Size = new Size(256, 50);
            txtYuklenecekTutar.TabIndex = 3;
            // 
            // btnTalimatKaydet
            // 
            btnTalimatKaydet.Location = new Point(430, 52);
            btnTalimatKaydet.Name = "btnTalimatKaydet";
            btnTalimatKaydet.Size = new Size(209, 112);
            btnTalimatKaydet.TabIndex = 4;
            btnTalimatKaydet.Text = "TALİMATI KAYDET";
            btnTalimatKaydet.UseVisualStyleBackColor = true;
            btnTalimatKaydet.Click += btnTalimatKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1104, 198);
            label2.Name = "label2";
            label2.Size = new Size(255, 45);
            label2.TabIndex = 5;
            label2.Text = "Bekleyen Talimat";
            // 
            // lblBekleyenTalimat
            // 
            lblBekleyenTalimat.AutoSize = true;
            lblBekleyenTalimat.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBekleyenTalimat.ForeColor = Color.Red;
            lblBekleyenTalimat.Location = new Point(1211, 260);
            lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            lblBekleyenTalimat.Size = new Size(77, 89);
            lblBekleyenTalimat.TabIndex = 6;
            lblBekleyenTalimat.Text = "0";
            // 
            // checkBoxTumunuGoster
            // 
            checkBoxTumunuGoster.AutoSize = true;
            checkBoxTumunuGoster.Location = new Point(53, 341);
            checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            checkBoxTumunuGoster.Size = new Size(272, 49);
            checkBoxTumunuGoster.TabIndex = 7;
            checkBoxTumunuGoster.Text = "Tümünü Göster";
            checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            checkBoxTumunuGoster.CheckedChanged += checkBoxTumunuGoster_CheckedChanged;
            // 
            // dataGridViewTalimatlar
            // 
            dataGridViewTalimatlar.AllowUserToAddRows = false;
            dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalimatlar.Location = new Point(43, 406);
            dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            dataGridViewTalimatlar.ReadOnly = true;
            dataGridViewTalimatlar.RowHeadersWidth = 62;
            dataGridViewTalimatlar.RowTemplate.Height = 33;
            dataGridViewTalimatlar.Size = new Size(1587, 672);
            dataGridViewTalimatlar.TabIndex = 8;
            // 
            // timerBekleyenTalimat
            // 
            timerBekleyenTalimat.Tick += timerBekleyenTalimat_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talimatiYukleToolStripMenuItem, talimatiIptalEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(258, 80);
            // 
            // talimatiYukleToolStripMenuItem
            // 
            talimatiYukleToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            talimatiYukleToolStripMenuItem.Image = Properties.Resources.tick;
            talimatiYukleToolStripMenuItem.Name = "talimatiYukleToolStripMenuItem";
            talimatiYukleToolStripMenuItem.Size = new Size(257, 38);
            talimatiYukleToolStripMenuItem.Text = "Talimatı Yükle";
            talimatiYukleToolStripMenuItem.Click += talimatiYukleToolStripMenuItem_Click;
            // 
            // talimatiIptalEtToolStripMenuItem
            // 
            talimatiIptalEtToolStripMenuItem.Image = Properties.Resources.iptal;
            talimatiIptalEtToolStripMenuItem.Name = "talimatiIptalEtToolStripMenuItem";
            talimatiIptalEtToolStripMenuItem.Size = new Size(257, 38);
            talimatiIptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            talimatiIptalEtToolStripMenuItem.Click += talimatiIptalEtToolStripMenuItem_Click;
            // 
            // groupBoxYukleme
            // 
            groupBoxYukleme.Controls.Add(label1);
            groupBoxYukleme.Controls.Add(txtYuklenecekTutar);
            groupBoxYukleme.Controls.Add(btnTalimatKaydet);
            groupBoxYukleme.Location = new Point(53, 146);
            groupBoxYukleme.Name = "groupBoxYukleme";
            groupBoxYukleme.Size = new Size(670, 189);
            groupBoxYukleme.TabIndex = 10;
            groupBoxYukleme.TabStop = false;
            // 
            // FrmTalimatlar
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1727, 1122);
            Controls.Add(groupBoxYukleme);
            Controls.Add(dataGridViewTalimatlar);
            Controls.Add(checkBoxTumunuGoster);
            Controls.Add(lblBekleyenTalimat);
            Controls.Add(label2);
            Controls.Add(cmbBoxAkbiller);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FrmTalimatlar";
            Text = "FrmTalimatlar";
            Load += FrmTalimatlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBoxYukleme.ResumeLayout(false);
            groupBoxYukleme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenuToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ComboBox cmbBoxAkbiller;
        private Label label1;
        private TextBox txtYuklenecekTutar;
        private Button btnTalimatKaydet;
        private Label label2;
        private Label lblBekleyenTalimat;
        private CheckBox checkBoxTumunuGoster;
        private DataGridView dataGridViewTalimatlar;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBoxYukleme;
        private ToolStripMenuItem talimatiYukleToolStripMenuItem;
        private ToolStripMenuItem talimatiIptalEtToolStripMenuItem;
    }
}