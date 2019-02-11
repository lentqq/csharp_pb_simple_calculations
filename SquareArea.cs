using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");

            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + a * a);
        }
    }
}
