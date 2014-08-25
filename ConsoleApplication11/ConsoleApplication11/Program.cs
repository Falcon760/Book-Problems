using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            var number = Console.ReadLine();
            int count = 0;
            char[] test = number.ToCharArray();
            for (int i = number.Length+1; i >= test.Length; i--)
            {
                if (test[i] == 0)
                    count++;
                
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
