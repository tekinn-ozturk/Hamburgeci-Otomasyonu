namespace HamburgerOdevi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lstSiparisListesi = new ListBox();
            btnSiparisiTamamla = new Button();
            lblToplamTutar = new Label();
            label3 = new Label();
            btnSiparisEkle = new Button();
            nudAdet = new NumericUpDown();
            label2 = new Label();
            grpBoyutSeciniz = new GroupBox();
            rbBuyuk = new RadioButton();
            rbOrta = new RadioButton();
            rbKucuk = new RadioButton();
            cbxMenu = new ComboBox();
            label1 = new Label();
            pbResim = new PictureBox();
            flpEkstraMalzeme = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            grpBoyutSeciniz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // lstSiparisListesi
            // 
            lstSiparisListesi.FormattingEnabled = true;
            lstSiparisListesi.ItemHeight = 20;
            lstSiparisListesi.Location = new Point(404, 20);
            lstSiparisListesi.Name = "lstSiparisListesi";
            lstSiparisListesi.Size = new Size(660, 564);
            lstSiparisListesi.TabIndex = 35;
            // 
            // btnSiparisiTamamla
            // 
            btnSiparisiTamamla.Location = new Point(730, 665);
            btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            btnSiparisiTamamla.Size = new Size(263, 33);
            btnSiparisiTamamla.TabIndex = 34;
            btnSiparisiTamamla.Text = "Siparişi Tamamla";
            btnSiparisiTamamla.UseVisualStyleBackColor = true;
            btnSiparisiTamamla.Click += btnSiparisiTamamla_Click;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(584, 608);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(48, 20);
            lblToplamTutar.TabIndex = 33;
            lblToplamTutar.Text = "$ 0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 608);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 32;
            label3.Text = "Toplam Tutar";
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(42, 665);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(263, 37);
            btnSiparisEkle.TabIndex = 31;
            btnSiparisEkle.Text = "Sipariş Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(96, 601);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(209, 27);
            nudAdet.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 603);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 29;
            label2.Text = "Adet";
            // 
            // grpBoyutSeciniz
            // 
            grpBoyutSeciniz.Controls.Add(rbBuyuk);
            grpBoyutSeciniz.Controls.Add(rbOrta);
            grpBoyutSeciniz.Controls.Add(rbKucuk);
            grpBoyutSeciniz.Location = new Point(42, 311);
            grpBoyutSeciniz.Name = "grpBoyutSeciniz";
            grpBoyutSeciniz.Size = new Size(263, 69);
            grpBoyutSeciniz.TabIndex = 27;
            grpBoyutSeciniz.TabStop = false;
            grpBoyutSeciniz.Text = "Boyut Seçiniz";
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(156, 37);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(69, 24);
            rbBuyuk.TabIndex = 6;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(91, 37);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(59, 24);
            rbOrta.TabIndex = 5;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(6, 37);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(69, 24);
            rbKucuk.TabIndex = 4;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // cbxMenu
            // 
            cbxMenu.FormattingEnabled = true;
            cbxMenu.Location = new Point(42, 236);
            cbxMenu.Name = "cbxMenu";
            cbxMenu.Size = new Size(263, 28);
            cbxMenu.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 213);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 25;
            label1.Text = "MENÜ SEÇİN";
            // 
            // pbResim
            // 
            pbResim.BorderStyle = BorderStyle.FixedSingle;
            pbResim.Image = (Image)resources.GetObject("pbResim.Image");
            pbResim.Location = new Point(42, 12);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(263, 198);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 24;
            pbResim.TabStop = false;
            // 
            // flpEkstraMalzeme
            // 
            flpEkstraMalzeme.Location = new Point(42, 414);
            flpEkstraMalzeme.Name = "flpEkstraMalzeme";
            flpEkstraMalzeme.Size = new Size(263, 173);
            flpEkstraMalzeme.TabIndex = 36;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 722);
            Controls.Add(flpEkstraMalzeme);
            Controls.Add(lstSiparisListesi);
            Controls.Add(btnSiparisiTamamla);
            Controls.Add(lblToplamTutar);
            Controls.Add(label3);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nudAdet);
            Controls.Add(label2);
            Controls.Add(grpBoyutSeciniz);
            Controls.Add(cbxMenu);
            Controls.Add(label1);
            Controls.Add(pbResim);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            grpBoyutSeciniz.ResumeLayout(false);
            grpBoyutSeciniz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSiparisiTamamla;
        private Label lblToplamTutar;
        private Label label3;
        private Button btnSiparisEkle;
        private NumericUpDown nudAdet;
        private Label label2;
        private GroupBox grpBoyutSeciniz;
        private RadioButton rbBuyuk;
        private RadioButton rbOrta;
        private RadioButton rbKucuk;
        private ComboBox cbxMenu;
        private Label label1;
        private PictureBox pbResim;
        private FlowLayoutPanel flpEkstraMalzeme;
        public ListBox lstSiparisListesi;
    }
}