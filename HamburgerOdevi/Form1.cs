using System.Security.Cryptography.X509Certificates;

namespace HamburgerOdevi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2Getir();
		}

		public void Form2Getir()
		{
			Form2 frm2 = new Form2();
			this.Width = frm2.Width + 50;
			this.Height = frm2.Height + 50;
			frm2.MdiParent = this;
			frm2.Show();
			frm2.Dock = DockStyle.Fill;
			frm2.FormBorderStyle = FormBorderStyle.None;

		}

		private void sipariþYönetimiToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3();
			this.Width = frm3.Width + 50;
			this.Height = frm3.Height + 50;
			frm3.MdiParent = this;
			frm3.Show();
			frm3.Dock = DockStyle.Fill;
			frm3.FormBorderStyle = FormBorderStyle.None;
		}

		private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form4 frm4 = new Form4();
			this.Width = frm4.Width + 50;
			this.Height = frm4.Height + 50;
			frm4.MdiParent = this;
			frm4.Show();
			frm4.Dock = DockStyle.Fill;
			frm4.FormBorderStyle = FormBorderStyle.None;

		}

		private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form5 frm5 = new Form5();
			this.Width = frm5.Width + 50;
			this.Height = frm5.Height + 50;
			frm5.MdiParent = this;
			frm5.Show();
			frm5.Dock = DockStyle.Fill;
			frm5.FormBorderStyle = FormBorderStyle.None;

		}

	
	}
}