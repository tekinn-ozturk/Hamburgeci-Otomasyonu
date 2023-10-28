namespace HamburgerOdevi
{
    partial class Form5
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
            menuStrip1 = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            siparişYönetimiToolStripMenuItem1 = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menüEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraEkleToolStripMenuItem = new ToolStripMenuItem();
            grpEkstraMalzemeBilgileri = new GroupBox();
            btnEkstraMalzemeKaydet = new Button();
            nudEkstraMalzemeFiyati = new NumericUpDown();
            txtEkstraMalzemeAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            grpEkstraMalzemeBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(455, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem, siparişYönetimiToolStripMenuItem1 });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(129, 24);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(198, 26);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            // 
            // siparişYönetimiToolStripMenuItem1
            // 
            siparişYönetimiToolStripMenuItem1.Name = "siparişYönetimiToolStripMenuItem1";
            siparişYönetimiToolStripMenuItem1.Size = new Size(198, 26);
            siparişYönetimiToolStripMenuItem1.Text = "Sipariş Yönetimi";
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menüEkleToolStripMenuItem, ekstraEkleToolStripMenuItem });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(116, 24);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menüEkleToolStripMenuItem
            // 
            menüEkleToolStripMenuItem.Name = "menüEkleToolStripMenuItem";
            menüEkleToolStripMenuItem.Size = new Size(162, 26);
            menüEkleToolStripMenuItem.Text = "Menü Ekle";
            // 
            // ekstraEkleToolStripMenuItem
            // 
            ekstraEkleToolStripMenuItem.Name = "ekstraEkleToolStripMenuItem";
            ekstraEkleToolStripMenuItem.Size = new Size(162, 26);
            ekstraEkleToolStripMenuItem.Text = "Ekstra Ekle";
            // 
            // grpEkstraMalzemeBilgileri
            // 
            grpEkstraMalzemeBilgileri.Controls.Add(btnEkstraMalzemeKaydet);
            grpEkstraMalzemeBilgileri.Controls.Add(nudEkstraMalzemeFiyati);
            grpEkstraMalzemeBilgileri.Controls.Add(txtEkstraMalzemeAdi);
            grpEkstraMalzemeBilgileri.Controls.Add(label2);
            grpEkstraMalzemeBilgileri.Controls.Add(label1);
            grpEkstraMalzemeBilgileri.Location = new Point(12, 42);
            grpEkstraMalzemeBilgileri.Name = "grpEkstraMalzemeBilgileri";
            grpEkstraMalzemeBilgileri.Size = new Size(395, 196);
            grpEkstraMalzemeBilgileri.TabIndex = 6;
            grpEkstraMalzemeBilgileri.TabStop = false;
            grpEkstraMalzemeBilgileri.Text = "Ekstra Malzeme Bilgileri";
            // 
            // btnEkstraMalzemeKaydet
            // 
            btnEkstraMalzemeKaydet.Location = new Point(179, 126);
            btnEkstraMalzemeKaydet.Name = "btnEkstraMalzemeKaydet";
            btnEkstraMalzemeKaydet.Size = new Size(198, 58);
            btnEkstraMalzemeKaydet.TabIndex = 4;
            btnEkstraMalzemeKaydet.Text = "Ekstra Malzeme Kaydet";
            btnEkstraMalzemeKaydet.UseVisualStyleBackColor = true;
            btnEkstraMalzemeKaydet.Click += btnEkstraMalzemeKaydet_Click;
            // 
            // nudEkstraMalzemeFiyati
            // 
            nudEkstraMalzemeFiyati.Location = new Point(156, 83);
            nudEkstraMalzemeFiyati.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudEkstraMalzemeFiyati.Name = "nudEkstraMalzemeFiyati";
            nudEkstraMalzemeFiyati.Size = new Size(221, 27);
            nudEkstraMalzemeFiyati.TabIndex = 3;
            // 
            // txtEkstraMalzemeAdi
            // 
            txtEkstraMalzemeAdi.Location = new Point(156, 35);
            txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            txtEkstraMalzemeAdi.Size = new Size(227, 27);
            txtEkstraMalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 85);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 1;
            label2.Text = "Ekstra Malzeme Fiyatı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 38);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 285);
            Controls.Add(grpEkstraMalzemeBilgileri);
            Controls.Add(menuStrip1);
            Name = "Form5";
            Text = "Form5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpEkstraMalzemeBilgileri.ResumeLayout(false);
            grpEkstraMalzemeBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem1;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menüEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraEkleToolStripMenuItem;
        private GroupBox grpEkstraMalzemeBilgileri;
        private Button btnEkstraMalzemeKaydet;
        private NumericUpDown nudEkstraMalzemeFiyati;
        private TextBox txtEkstraMalzemeAdi;
        private Label label2;
        private Label label1;
    }
}