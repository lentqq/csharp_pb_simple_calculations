using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rdians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            var degrees = rad * 180 / Math.PI;

            Console.Write("Degrees is: ");
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
