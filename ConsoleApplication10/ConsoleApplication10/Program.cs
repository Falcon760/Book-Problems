using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int q = 0;
            int r = 0;
            int total = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                    q = q+i;
                if (i % 5 == 0)
                    r = r + i;
                total = r + q;

            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
