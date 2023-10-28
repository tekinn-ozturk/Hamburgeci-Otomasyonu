namespace HamburgerOdevi
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
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
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1114, 28);
			menuStrip1.TabIndex = 1;
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
			siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
			// 
			// siparişYönetimiToolStripMenuItem1
			// 
			siparişYönetimiToolStripMenuItem1.Name = "siparişYönetimiToolStripMenuItem1";
			siparişYönetimiToolStripMenuItem1.Size = new Size(198, 26);
			siparişYönetimiToolStripMenuItem1.Text = "Sipariş Yönetimi";
			siparişYönetimiToolStripMenuItem1.Click += siparişYönetimiToolStripMenuItem1_Click;
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
			menüEkleToolStripMenuItem.Click += menüEkleToolStripMenuItem_Click;
			// 
			// ekstraEkleToolStripMenuItem
			// 
			ekstraEkleToolStripMenuItem.Name = "ekstraEkleToolStripMenuItem";
			ekstraEkleToolStripMenuItem.Size = new Size(162, 26);
			ekstraEkleToolStripMenuItem.Text = "Ekstra Ekle";
			ekstraEkleToolStripMenuItem.Click += ekstraEkleToolStripMenuItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1114, 653);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
		
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
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
	}
}