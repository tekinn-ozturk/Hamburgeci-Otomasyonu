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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Menüyü Kaydediyorum", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Menu menuy = new Menu();
                menuy.MenuAdi = txtMenuAdi.Text;
                menuy.MenuFiyati = (int)nudMenuFiyati.Value;
                Form2.Menuler.Add(menuy);
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
