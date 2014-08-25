using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = 0;
            Console.WriteLine("We will calculate the distance between two points:");
            Console.WriteLine("Enter X1:");
            var x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2:");
            var x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1:");
            var y1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter Y2:");
            var y2 = double.Parse(Console.ReadLine());
            distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            Console.WriteLine(distance);
            Console.ReadLine();
            }
          
        }
    }

