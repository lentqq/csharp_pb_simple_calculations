﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input inches = ");

            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;

            Console.WriteLine("Centimeters = " + centimeters);
                    
        }
    }
}
