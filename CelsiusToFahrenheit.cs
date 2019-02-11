using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());
            double F = C * 1.8 + 32;

            Console.Write("Degree to Fahrenheit is: ");
            Console.WriteLine(Math.Round(F,2));
        }
    }
}
