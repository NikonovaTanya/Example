using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    partial class Currency
    {
        public double USDconvertUAH(double money)
        {
            return money * Usd;
        }
        public double EURconvertUAH(double money)
        {
            return money * Eur;
        }
        public double RUBconvertUAH(double money)
        {
            return money * Rub;
        }
    }
}
