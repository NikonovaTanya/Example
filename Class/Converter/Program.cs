using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            char chr;
            double money;
            Currency c = new Currency(23.55,26.025,0.345);
            do
            {

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("1 UAH = 23.55 USD = 26.025 EUR = 0.345 RUB");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Выберете пункт меню:");
                Console.WriteLine("  1 - converter UAH");
                Console.WriteLine("  2 - converter USD to UAH");
                Console.WriteLine("  3 - converter EUR to UAH");
                Console.WriteLine("  4 - converter RUB to UAH");
                Console.WriteLine("  0 - выход из программы");
                Console.WriteLine("");
                Console.WriteLine("");
                ch = Console.ReadLine()[0];
                switch (ch)
                {
                   case '1':
                        {
                            do
                            {
                                {
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("1 UAH = 23.55 USD = 26.025 EUR = 0.345 RUB");
                                    Console.WriteLine();
                                    Console.WriteLine(" 0- exit");
                                    Console.WriteLine(" 1- UAH to USD ");
                                    Console.WriteLine(" 2- UAH to EUR ");
                                    Console.WriteLine(" 3- UAH to RUB ");
                                    chr = Console.ReadLine()[0];
                                    {
                                        Console.Clear();
                                        switch (chr)
                                        {
                                            case '1':
                                                {
                                                    Console.Write("Enter UAH = ");
                                                    money = double.Parse(Console.ReadLine());
                                                    Console.WriteLine( "USD = "+ c.UAHconvertUSD(money));
                                                    Console.ReadKey();
                                                    Console.WriteLine(" 0 - exit ");
                                                    break;
                                                }
                                            case '2':
                                                {
                                                    Console.Write("Enter UAH = ");
                                                    money = double.Parse(Console.ReadLine());
                                                    Console.WriteLine("EUR = " + c.UAHconvertEUR(money));
                                                    Console.ReadKey();
                                                    Console.WriteLine(" 0 - exit ");
                                                    break;
                                                }
                                            case '3':
                                                {
                                                    Console.Write("Enter UAH = ");
                                                    money = double.Parse(Console.ReadLine());
                                                    Console.WriteLine("RUB = " + c.UAHconvertRUB(money));
                                                    Console.ReadKey();
                                                    Console.WriteLine(" 0 - exit ");
                                                    break;

                                                }
                                        }
                                    }
                                    Console.Clear();
                                }

                            } while (chr != '0');

                            break;

                        }
                    //------------------------------------------------------------
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("1 UAH = 23.55 USD = 26.025 EUR = 0.345 RUB");
                            Console.WriteLine();
                            Console.Write("Enter USD = ");
                            money = double.Parse(Console.ReadLine());
                            Console.WriteLine("UAH = " + c.USDconvertUAH(money));
                            Console.ReadKey();
                            Console.WriteLine(" 0 - exit ");
                            break;

                        }
                    //----------------------------------------------------------------------------------------
                    case '3':
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("1 UAH = 23.55 USD = 26.025 EUR = 0.345 RUB");
                            Console.WriteLine();
                            Console.Write("Enter EUR = ");
                            money = double.Parse(Console.ReadLine());
                            Console.WriteLine("UAH = " + c.EURconvertUAH(money));
                            Console.ReadKey();
                            Console.WriteLine(" 0 - exit ");
                            break;

                        }
                    //-------------------------------------------------------------------------------
                    case '4':
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("1 UAH = 23.55 USD = 26.025 EUR = 0.345 RUB");
                            Console.WriteLine();
                            Console.Write("Enter RUB = ");
                            money = double.Parse(Console.ReadLine());
                            Console.WriteLine("UAH = " + c.RUBconvertUAH(money));
                            Console.ReadKey();
                            Console.WriteLine(" 0 - exit ");
                            break;

                        }
                }
            } while (ch != '0');
        }
    }
}
