using HamburgerOdevi.EnumAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdevi.Classes
{


    public  class Siparis
    {
        public Menu Menu { get; set; }
        public Boyutlar Boyut { get; set; }
        public   List<EkstraMalzeme> MalzemeSecim { get; set; }
        public int Adet { get; set; }
        public double ToplamTutar { get; set; }
        //public double EkstraMalzemelerinToplamTutari { get; set; }
        public double FiyatHesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += Menu.MenuFiyati;
            if (Boyut == Boyutlar.Orta)
            {
                ToplamTutar += 10;
            }

            if (Boyut == Boyutlar.Büyük)
            {
                ToplamTutar += 20;
            }



            foreach (EkstraMalzeme item in MalzemeSecim)
            {
                ToplamTutar += item.EkstraMalzemeFiyati;
            }

            ToplamTutar *= Adet;
            return ToplamTutar;
        }
       
        //public  double FiyatHesapla2()
        //{
        //    double ekstraMalzemeFiyatıToplam = 0;
        //    foreach (EkstraMalzeme item in MalzemeSecim)
        //    {
        //        ekstraMalzemeFiyatıToplam += item.EkstraMalzemeFiyati;
        //    }
        //    return ekstraMalzemeFiyatıToplam;
           
        //}
      
        public override string ToString()
        {

            if (MalzemeSecim.Count ==0)
            {
                return $"{Menu.MenuAdi} x {Adet} Adet, {Boyut} Boy,  {ToplamTutar} Lira";
            }
            else
            {
                string malzemeIsimleri = null;
                foreach (EkstraMalzeme item in MalzemeSecim)
                {
                    malzemeIsimleri += item.EkstraMalzemeAdi + ",";
                }

                malzemeIsimleri = malzemeIsimleri.Trim(',');
                return $"{Menu.MenuAdi} x {Adet} Adet, {Boyut} Boy, ({malzemeIsimleri}),  {ToplamTutar} Lira";
            }
            
        }




    }
}
