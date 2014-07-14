using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculate = "Y"; 
            Console.WriteLine("Do you wish to calculate the area of a circle? Y or N");
            calculate = Console.ReadLine().ToUpper();
            do {
                Console.WriteLine("What is the radius of the circle?");
                int radius = int.Parse(Console.ReadLine());
                double area = Math.PI * (Math.Pow(radius, 2));
                Console.WriteLine("The area is PI times {0} squared, which is {1}", radius, area);
                Console.WriteLine("Do you wish to calculate another?");
                calculate = Console.ReadLine();
            } 
            while (calculate == "Y");

            Console.WriteLine("Goodbye");
            Console.ReadLine();



        }
    }
}
