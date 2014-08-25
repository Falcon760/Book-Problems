using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindChill_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the current temperature? ");
            var temp = double.Parse(Console.ReadLine());
            Console.Write("What is the current wind speed? ");
            var wind_speed = double.Parse(Console.ReadLine());
            
            var wind_chill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(wind_speed,.16);
            Console.WriteLine("The wind chill is {0}", wind_chill);
            Console.ReadLine();
        }
    }
}
