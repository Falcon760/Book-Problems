using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Exercises
{
    class Program
    {
        class Employee
        {
            public static double Totalhours(double hours)
            {
                double pay = 7.50;
                double Totalhours = pay * hours;
                return Totalhours;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What are your hours for the week?");
            int hours = int.Parse(Console.ReadLine());
            decimal pay = 7.50M;
            if (hours > 40)
            {
                decimal RegularPay = pay * 40;
                int Overtimehours = hours - 40;
                decimal OvertimePay = 11.25M * Overtimehours;
                decimal TotalPay = RegularPay + OvertimePay;
                Console.WriteLine("Your hours for the week are {0} and your total pay is {1}", hours, TotalPay);
            }
            else
            {
                decimal Totalhours = pay * hours;
                Console.WriteLine("Your hours for the week are {0} and your total pay is {1}", hours, Totalhours);
            }

            Console.ReadLine();
        }

        
    }
}
