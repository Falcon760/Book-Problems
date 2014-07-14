using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many years?");
            int years = int.Parse(Console.ReadLine());
                double rate = 2.0;
                int investment = 20000;
                double interestValue = investment * Math.Pow(years, 1 + (rate / 100));
                Console.WriteLine(interestValue);
                Console.ReadLine();
            
        }
    }
}
