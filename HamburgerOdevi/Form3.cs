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
    public partial class Form3 : Form

    {

        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            foreach (var item in Form2.siparisListesi)
            {
                lstTumSiparisler.Items.Add(item);

            }
            double toplamCiro = 0;
            foreach (double item in Form2.tutarListesi)
            {
                toplamCiro += item;
                lblCiro.Text = toplamCiro.ToString();
            }
            //Bunu adet için düşünebiliriz!
            //for (int i = 1; i <= Form2.siparisListesi.Count; i++)
            //{
            //    lblToplamSiparisSayisi.Text = i.ToString();
            //}

            lblToplamSiparisSayisi.Text = Form2.sayac.ToString();

            double satilanAdetSayisi = 0;
            double ekstraMalzemelerinToplamFiyati = 0;
            foreach (Siparis siparis in Form2.siparisListesi)
            {
                satilanAdetSayisi += siparis.Adet;


                foreach (var item in siparis.MalzemeSecim)
                {
                    ekstraMalzemelerinToplamFiyati += item.EkstraMalzemeFiyati;
                }
            }
            lblExtraMalzemeGeliri.Text = ekstraMalzemelerinToplamFiyati.ToString();
            lblSiparisAdeti.Text = satilanAdetSayisi.ToString();

           
           






        }
    }
}
