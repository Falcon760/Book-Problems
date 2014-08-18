using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            do
            {
                Console.WriteLine("What do you wish to do \n" +
                                   "1 - Calculate the area of a circle \n" +
                                   "2 - Find the circumference of a circle \n" +
                                   "3 - Find the volume of a cynlinder \n" +
                                   "-1 - Quit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("What is the radius of your circle?");
                    int radius = int.Parse(Console.ReadLine());
                    double result = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("What is the radius?");
                    int radius = int.Parse(Console.ReadLine());
                    double result = 2 * Math.PI * radius;
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("What is the radius?");
                    int radius = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the height?");
                    int height = int.Parse(Console.ReadLine());
                    double result = Math.PI * ((Math.Pow(radius, 2) * height));
                    Console.WriteLine(result);
                    Console.ReadLine();
                }

            } while (choice != -1);


            Console.ReadLine();
        }
    }
}
