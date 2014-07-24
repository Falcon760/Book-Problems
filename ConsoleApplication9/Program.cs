using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public class SumPrices
    {
        public static double Sum(double[] p, int start, int end)
        {
            if (start < end)
                return p[start] = Sum(p, start + 1, end);
            else
                return 0;

        }

    }
    public class Journey
    {

        private static String indent="";
            public static void TakeOneStep(int step)
            {Console.WriteLine("{0}Taking one step {1}", indent, step);
            }
        public static void Travel(int start, int finish)
            {
                string oldindent = indent;
                Console.WriteLine("{0}Starting travel from {1} to {2}", indent, start, finish);
                if (start < finish)
                {
                    TakeOneStep(start);
                    indent += "     ";
                    Travel(start + 1, finish);
                    indent = oldindent;


                }
                Console.WriteLine("{0}Finishing travel from {1} to {2}", indent, start, finish);

            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int finish = 5;
            Journey.Travel(start, finish);

            double[] prices = { 12.23, 23.55, 5.55, 2.55, 5.11 };
            Console.WriteLine("The sum is {0:C}", SumPrices.Sum(prices, 0, prices.Length));


            Console.ReadLine();
        }
    }
}
