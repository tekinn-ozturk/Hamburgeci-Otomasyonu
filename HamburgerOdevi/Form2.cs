using HamburgerOdevi.Classes;
using HamburgerOdevi.EnumAll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerOdevi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static List<EkstraMalzeme> Ekstralar = new List<EkstraMalzeme>();
        public static List<Menu> Menuler = new List<Menu>();
        public void Form2_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.MenuAdi = "Whooper ";
            menu.MenuFiyati = 100;


            Menu menu1 = new Menu();
            menu1.MenuAdi = "King Chicken";
            menu1.MenuFiyati = 90;

			Menu menu2 = new Menu();
			menu2.MenuAdi = "Texas Smokehouse";
			menu2.MenuFiyati = 150;

			Menu menu3 = new Menu();
			menu3.MenuAdi = "Big King";
			menu3.MenuFiyati = 150;

			Menu menu4 = new Menu();
			menu4.MenuAdi = "Cheeseburger";
			menu4.MenuFiyati = 150;

			Menu menu5 = new Menu();
			menu5.MenuAdi = "King Beef";
			menu5.MenuFiyati = 150;

			Menu menu6 = new Menu();
			menu6.MenuAdi = "Chicken Royale";
			menu6.MenuFiyati = 150;





			EkstraMalzeme ekstra1 = new EkstraMalzeme();
            ekstra1.EkstraMalzemeAdi = "Ketçap";
            ekstra1.EkstraMalzemeFiyati = 1;
            Ekstralar.Add(ekstra1);


            EkstraMalzeme ekstra2 = new EkstraMalzeme();
            ekstra2.EkstraMalzemeAdi = "Mayonez";
            ekstra2.EkstraMalzemeFiyati = 1;
            Ekstralar.Add(ekstra2);



            Menuler.Add(menu);
            Menuler.Add(menu1);
            Menuler.Add(menu2);
            Menuler.Add(menu3);
            Menuler.Add(menu4);
            Menuler.Add(menu5);
            Menuler.Add(menu6);

            foreach (var item in Menuler)
            {
                cbxMenu.Items.Add(item);
            }

            foreach (EkstraMalzeme item in Ekstralar)
            {
                flpEkstraMalzeme.Controls.Add(new CheckBox() { Text = item.EkstraMalzemeAdi, Width = 100, AutoSize = false, Tag = item });


            }





        }
        //public double EkstraMalzemeFiyatHesapla(Siparis siparis)
        //{


        //}
        public static double toplamTutar = 0;
        // public static int sayac = 0;
        public static List<Siparis> siparisListesi = new List<Siparis>();
        public static List<double> tutarListesi = new List<double>();
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            siparis.Menu = (Menu)cbxMenu.SelectedItem;


            if (rbKucuk.Checked)
            {
                siparis.Boyut = EnumAll.Boyutlar.Küçük;
            }
            if (rbOrta.Checked)
            {
                siparis.Boyut = EnumAll.Boyutlar.Orta;
            }
            if (rbBuyuk.Checked)
            {
                siparis.Boyut = EnumAll.Boyutlar.Büyük;
            }

            siparis.Adet = (int)nudAdet.Value;


            siparis.MalzemeSecim = new List<EkstraMalzeme>();
            foreach (CheckBox item in flpEkstraMalzeme.Controls)
            {
                if (item.Checked)
                {
                    siparis.MalzemeSecim.Add((EkstraMalzeme)item.Tag);
                }
            }


            siparis.ToplamTutar = siparis.FiyatHesapla();
            //siparis.EkstraMalzemelerinToplamTutari = siparis.FiyatHesapla2();

            toplamTutar += siparis.ToplamTutar;
            lstSiparisListesi.Items.Add(siparis);

            siparisListesi.Add(siparis);

            lblToplamTutar.Text = toplamTutar.ToString();

            // sayac += 1;


        }
        public static int sayac = 0;
        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Siparişi Oluşturuyorum Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Siparişiniz Başarıyla Oluşturuldu!");
                lstSiparisListesi.Items.Clear();

                sayac++;


            }
            else
            {
                MessageBox.Show("Siparişiniz İptal Edildi!");

                lstSiparisListesi.Items.Clear();
                //sayac = 0;
            }



            tutarListesi.Add(toplamTutar);
            toplamTutar = 0;
            lblToplamTutar.Text = string.Empty;


        }
    }
}
