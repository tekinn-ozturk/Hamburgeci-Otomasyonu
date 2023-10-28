using HamburgerOdevi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerOdevi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Menüyü Kaydediyorum", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EkstraMalzeme ekstrax = new EkstraMalzeme();
                ekstrax.EkstraMalzemeAdi = txtEkstraMalzemeAdi.Text;
                ekstrax.EkstraMalzemeFiyati = (int)nudEkstraMalzemeFiyati.Value;
                Form2.Ekstralar.Add(ekstrax);
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kaydedilmedi");

                return;
            }
        }
    }
}
