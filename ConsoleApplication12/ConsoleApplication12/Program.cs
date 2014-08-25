using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculating BMI
            Console.WriteLine("What is your weight in kg?");
            var weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your height in m?");
            var height = double.Parse(Console.ReadLine());
            var bmi = weight / (height * height);
            Console.WriteLine("Your BMI is {0}", bmi);
            Console.ReadLine();





        }
    }
}
