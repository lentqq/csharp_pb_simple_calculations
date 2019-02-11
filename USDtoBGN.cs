using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = Double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;

            Console.Write(Math.Round(BGN,2));
            Console.WriteLine(" BGN");
        }
    }
}
