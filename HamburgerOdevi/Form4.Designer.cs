namespace HamburgerOdevi
{
    partial class Form4
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
            grpMenuBilgileri = new GroupBox();
            btnMenuKaydet = new Button();
            nudMenuFiyati = new NumericUpDown();
            txtMenuAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyati).BeginInit();
            SuspendLayout();
            // 
            // grpMenuBilgileri
            // 
            grpMenuBilgileri.Controls.Add(btnMenuKaydet);
            grpMenuBilgileri.Controls.Add(nudMenuFiyati);
            grpMenuBilgileri.Controls.Add(txtMenuAdi);
            grpMenuBilgileri.Controls.Add(label2);
            grpMenuBilgileri.Controls.Add(label1);
            grpMenuBilgileri.Location = new Point(56, 68);
            grpMenuBilgileri.Name = "grpMenuBilgileri";
            grpMenuBilgileri.Size = new Size(365, 190);
            grpMenuBilgileri.TabIndex = 5;
            grpMenuBilgileri.TabStop = false;
            grpMenuBilgileri.Text = "Menü Bilgileri";
            // 
            // btnMenuKaydet
            // 
            btnMenuKaydet.Location = new Point(100, 126);
            btnMenuKaydet.Name = "btnMenuKaydet";
            btnMenuKaydet.Size = new Size(198, 58);
            btnMenuKaydet.TabIndex = 4;
            btnMenuKaydet.Text = "Menü Kaydet";
            btnMenuKaydet.UseVisualStyleBackColor = true;
            btnMenuKaydet.Click += btnMenuKaydet_Click;
            // 
            // nudMenuFiyati
            // 
            nudMenuFiyati.Location = new Point(98, 80);
            nudMenuFiyati.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMenuFiyati.Name = "nudMenuFiyati";
            nudMenuFiyati.Size = new Size(221, 27);
            nudMenuFiyati.TabIndex = 3;
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(100, 35);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(210, 27);
            txtMenuAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 85);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Menu Fiyatı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 38);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 285);
            Controls.Add(grpMenuBilgileri);
            Name = "Form4";
            Text = "Form4";
            grpMenuBilgileri.ResumeLayout(false);
            grpMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpMenuBilgileri;
        private TextBox txtMenuAdi;
        private Label label2;
        private Label label1;
        private Button btnMenuKaydet;
        private NumericUpDown nudMenuFiyati;
    }
}