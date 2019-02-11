using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.Pow(radius, 2) * Math.PI;
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine("Area = {0} \n Perimeter ={1}", area, perimeter);

        }
    }
}
