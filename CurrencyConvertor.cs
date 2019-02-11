using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bgBGN = 1;
            double bgtoUSD = 1.79549;
            double bgtoEUR = 1.95583;
            double bgtoGBP = 2.53405;

            double sum = double.Parse(Console.ReadLine());

            string fromCurrency = Console.ReadLine();
            string toCurrency = Console.ReadLine();


            if (fromCurrency == "USD")
            {
                sum = sum * bgtoUSD;
            }
            else if (fromCurrency == "EUR")
            {
                sum = sum * bgtoEUR;
            }
            else if (fromCurrency == "GBP")
            {
                sum = sum * bgtoGBP;
            }


            if (toCurrency == "USD")
            {
                sum = sum / bgtoUSD;
            }
            else if (toCurrency == "EUR")
            {
                sum = sum / bgtoEUR;
            }
            else if (toCurrency == "GBP")
            {
                sum = sum / bgtoGBP;
            }
            Console.WriteLine(Math.Round(sum, 2) + " " + toCurrency);
        }
    }
}
