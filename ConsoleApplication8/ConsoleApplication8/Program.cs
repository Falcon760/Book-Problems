using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = new string[] { "USA", "France", "Gibaya", "England", "Zibabwe", "South Africa", "Uganda","Japan", "India", "Canada" };
            string[] states = new string[] {"Michigan", "Minnesota", "Washington", "Texas", "Virginia", "Florida", "Nevada"};
            //var result = from c in countries
            //             where c.StartsWith("U")
            //             orderby c
            //             select c;

            var result = from c in countries
                         where c == ""




            foreach (var item in result)
            {
                Console.WriteLine(item);  
            }

            




            Console.ReadLine();

        }
    }
}
