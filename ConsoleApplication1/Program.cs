using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //grade point average checker

            Console.WriteLine("What is your grade point average?");
            double gradePoint = double.Parse(Console.ReadLine());

            if (gradePoint >= 3.5)
            {
                Console.WriteLine("Congratulations, you qualify for the honor role.");
            }
            else if (gradePoint < 2.0)
            {
                Console.WriteLine("You are on probation buddy.");
            }
            else
            {
                Console.WriteLine("Good job.");
            }

            Console.ReadLine();
        }
    }
}
