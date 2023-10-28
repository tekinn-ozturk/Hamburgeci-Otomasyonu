namespace HamburgerOdevi
{
    partial class Form3
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
            lstTumSiparisler = new ListBox();
            label1 = new Label();
            grpCiro = new GroupBox();
            lblCiro = new Label();
            grpToplamSiparisSayisi = new GroupBox();
            lblToplamSiparisSayisi = new Label();
            grpEkstraMalzemeGeliri = new GroupBox();
            lblExtraMalzemeGeliri = new Label();
            grpSatilanUrunAdedi = new GroupBox();
            lblSiparisAdeti = new Label();
            grpCiro.SuspendLayout();
            grpToplamSiparisSayisi.SuspendLayout();
            grpEkstraMalzemeGeliri.SuspendLayout();
            grpSatilanUrunAdedi.SuspendLayout();
            SuspendLayout();
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 20;
            lstTumSiparisler.Location = new Point(12, 79);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(409, 524);
            lstTumSiparisler.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "Tüm Siparişler";
            // 
            // grpCiro
            // 
            grpCiro.Controls.Add(lblCiro);
            grpCiro.Location = new Point(496, 113);
            grpCiro.Name = "grpCiro";
            grpCiro.Size = new Size(250, 89);
            grpCiro.TabIndex = 6;
            grpCiro.TabStop = false;
            grpCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(101, 34);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(48, 20);
            lblCiro.TabIndex = 34;
            lblCiro.Text = "$ 0.00";
            // 
            // grpToplamSiparisSayisi
            // 
            grpToplamSiparisSayisi.Controls.Add(lblToplamSiparisSayisi);
            grpToplamSiparisSayisi.Location = new Point(498, 220);
            grpToplamSiparisSayisi.Name = "grpToplamSiparisSayisi";
            grpToplamSiparisSayisi.Size = new Size(250, 89);
            grpToplamSiparisSayisi.TabIndex = 7;
            grpToplamSiparisSayisi.TabStop = false;
            grpToplamSiparisSayisi.Text = "Toplam Siparis Sayisi";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.AutoSize = true;
            lblToplamSiparisSayisi.ForeColor = Color.Red;
            lblToplamSiparisSayisi.Location = new Point(117, 34);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(17, 20);
            lblToplamSiparisSayisi.TabIndex = 35;
            lblToplamSiparisSayisi.Text = "0";
            // 
            // grpEkstraMalzemeGeliri
            // 
            grpEkstraMalzemeGeliri.Controls.Add(lblExtraMalzemeGeliri);
            grpEkstraMalzemeGeliri.Location = new Point(495, 342);
            grpEkstraMalzemeGeliri.Name = "grpEkstraMalzemeGeliri";
            grpEkstraMalzemeGeliri.Size = new Size(250, 89);
            grpEkstraMalzemeGeliri.TabIndex = 7;
            grpEkstraMalzemeGeliri.TabStop = false;
            grpEkstraMalzemeGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // lblExtraMalzemeGeliri
            // 
            lblExtraMalzemeGeliri.AutoSize = true;
            lblExtraMalzemeGeliri.ForeColor = Color.Red;
            lblExtraMalzemeGeliri.Location = new Point(101, 34);
            lblExtraMalzemeGeliri.Name = "lblExtraMalzemeGeliri";
            lblExtraMalzemeGeliri.Size = new Size(48, 20);
            lblExtraMalzemeGeliri.TabIndex = 34;
            lblExtraMalzemeGeliri.Text = "$ 0.00";
            // 
            // grpSatilanUrunAdedi
            // 
            grpSatilanUrunAdedi.Controls.Add(lblSiparisAdeti);
            grpSatilanUrunAdedi.Location = new Point(496, 484);
            grpSatilanUrunAdedi.Name = "grpSatilanUrunAdedi";
            grpSatilanUrunAdedi.Size = new Size(250, 89);
            grpSatilanUrunAdedi.TabIndex = 7;
            grpSatilanUrunAdedi.TabStop = false;
            grpSatilanUrunAdedi.Text = "Satılan Ürün Adedi";
            // 
            // lblSiparisAdeti
            // 
            lblSiparisAdeti.AutoSize = true;
            lblSiparisAdeti.ForeColor = Color.Red;
            lblSiparisAdeti.Location = new Point(101, 34);
            lblSiparisAdeti.Name = "lblSiparisAdeti";
            lblSiparisAdeti.Size = new Size(17, 20);
            lblSiparisAdeti.TabIndex = 34;
            lblSiparisAdeti.Text = "0";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 656);
            Controls.Add(grpSatilanUrunAdedi);
            Controls.Add(grpEkstraMalzemeGeliri);
            Controls.Add(grpToplamSiparisSayisi);
            Controls.Add(grpCiro);
            Controls.Add(label1);
            Controls.Add(lstTumSiparisler);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            grpCiro.ResumeLayout(false);
            grpCiro.PerformLayout();
            grpToplamSiparisSayisi.ResumeLayout(false);
            grpToplamSiparisSayisi.PerformLayout();
            grpEkstraMalzemeGeliri.ResumeLayout(false);
            grpEkstraMalzemeGeliri.PerformLayout();
            grpSatilanUrunAdedi.ResumeLayout(false);
            grpSatilanUrunAdedi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstTumSiparisler;
        private Label label1;
        private GroupBox grpCiro;
        private GroupBox grpToplamSiparisSayisi;
        private GroupBox grpEkstraMalzemeGeliri;
        private GroupBox grpSatilanUrunAdedi;
        private Label lblCiro;
        private Label lblExtraMalzemeGeliri;
        private Label lblSiparisAdeti;
        private Label lblToplamSiparisSayisi;
    }
}