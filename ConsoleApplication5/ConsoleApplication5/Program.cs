using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    abstract class Food
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Food()
        {
            // TODO: Complete member initialization
        }

    }
    class Hamburger : Food
    { }
    class Fries : Food
    {
    }
    public abstract class Restaurant
    {

        public abstract void GetMenu();
        public abstract void GetBill();
        public abstract void GetOrder();

    }
    class FastFoodRestaurant : Restaurant
    {
        Dictionary<string, double> menu2 = new Dictionary<string, double>()
        {
        {"Whopper", 3.99},
        {"Fries", 2.99}
        };
        string[] menu = { "Whopper", "Fries" };
        public override void GetMenu()
        {
            foreach (var item in this.menu)
            {
                Console.WriteLine(item);
            }
        }
        List<string> order = new List<string>();
        public override void GetOrder()
        {
            string item;

            do
            {
                Console.WriteLine("What do you want to order? Enter done to complete order: ");
                item = Console.ReadLine();
                for (int i = 0; i < menu.Length; i++)
                {

                    if (menu[i] == item)
                    {
                        order.Add(item);
                        Console.WriteLine("Added");
                        break;
                    }
                    if (menu[i] != item)
                    {
                        Console.WriteLine("Menu does not contain that item.");
                        break;
                    }
                }


            } while (item != "done");

        }
        public override void GetBill()
        {
            Console.WriteLine("Your order is:");
            foreach (var item in order)
            {
                Console.WriteLine(item);

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FastFoodRestaurant McDonalds = new FastFoodRestaurant();
            McDonalds.GetMenu();
            McDonalds.GetOrder();
            McDonalds.GetBill();

            Console.ReadLine();


        }
    }
}
