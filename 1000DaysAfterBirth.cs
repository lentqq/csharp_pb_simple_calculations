using System;
using System.Collections.Generic;
using System.Globalization;


namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime date = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);

            date = date.AddDays(999);

            Console.WriteLine(date.ToString(format));
        }
    }
}
