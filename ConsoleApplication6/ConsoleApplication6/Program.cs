using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] string1 = { "something", "something2" };
            List<string> string2 = new List<string>() {"what", "huh"};
            Console.WriteLine("Enter a string: ");
            var item = Console.ReadLine();
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] == item)
                {
                    Console.WriteLine("This was found.");
                    break;
                }
                else
                    Console.WriteLine("This was not found.");
            }

            Console.ReadLine();
        }
    }
}
