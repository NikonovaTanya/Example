using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{    
    partial class Currency
    {
        private double usd;
        private double eur;
        private double rub;
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }
        public Currency() { }
        public Currency(double u, double e, double r)
        {
            this.Usd = u;
            this.Eur = e;
            this.Rub = r;
        }
        public double  UAHconvertUSD(double money)
        { 
          return money/ Usd;
        }
        public double UAHconvertEUR(double money)
        {
            return money / Eur;
        }
        public double UAHconvertRUB(double money)
        {
            return money/ Rub;
        }
        
    }
}
