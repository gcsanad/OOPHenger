﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPHenger
{
    public class Cso : Henger
    {
        double falVastagsag;

        public Cso(double sugar, double magassag) : base(sugar,magassag)
        {
            this.falVastagsag = 1;
        }
        public Cso(double sugar, double magassag, double falvastagsag):base(sugar, magassag)
        {
            this.falVastagsag= falvastagsag;
        }


        public double FalVastagsag
        {
            get => falVastagsag;
           
        }

        public override double Terfogat()
        {
            return Math.Round(base.Terfogat()-Math.Pow(GetSugar - falVastagsag,2)* Math.PI*GetMagassag,2);
        }

        public override string? ToString()
        {
            return $"Jellemzők >> térfogat:{Terfogat()}; sugár:{GetSugar}; magasság:{GetMagassag}; falvastagság:{falVastagsag}";
        }
    }
}