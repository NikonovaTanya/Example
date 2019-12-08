using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    class Invoice1
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        public int Account
        {
            get
            { return account;
            }
        }
        public string Customer
        {
            get
            {
                return customer;
            }
        }
        public string Provider
        {
            get
            {
                return provider;
            }
        }
        public Invoice1() { }
        private string article;
        public static int sum = 0;
        public static int sumWithoutVat = 0;
        private int quantity;
        public string Article
        { get
            {
                return article;
            }
            set
            {
                article = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public Invoice1(int a, string c, string p, string art, int count)
        {
            account = a;
            customer = c;
            provider = p;
            article = art;
            quantity = count;
        }
        
        public void getCost()
        {
            int getPrice=0;
            int getCostwithoutVAT = 0;
            int price = 0;
            if (article == "00001")
                price = 20;
            if (article == "00002")
                price = 10;
            if (article == "00003")
                price = 15;
            Console.WriteLine("Price: "+price + "     quantity:" + quantity);
            getPrice = price * quantity;
            Console.Write("Price all: "+getPrice);
            getCostwithoutVAT = getPrice - getPrice / 6;
            Console.WriteLine("     price all without VAT: " + getCostwithoutVAT);
            sum += getPrice;
            sumWithoutVat += getCostwithoutVAT;

        }
      
    }
}
