﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdevi.Classes
{

    public class Menu
    {
        public string MenuAdi { get; set; }
        public double MenuFiyati { get; set; }


        public override string ToString()
        {
            return $"{MenuAdi} Menü";
        }


    }
}
