using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Product
    {
        public int productID { get; set; }
        public string name { get; set; }

    }
    class Warehouse
    {
        List<Product> products;
        public Warehouse()
        {

            products = new List<Product>();
        }
        public void addProduct(int number, string pname)

        {
   
            products.Add(new Product { productID = number, name = pname });

        }
        public void ListProudcts()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p.name + p.productID);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse EastSide1 = new Warehouse();
            EastSide1.addProduct(1, "Television");
            EastSide1.addProduct(2, "VCR");
            EastSide1.ListProudcts();
            Console.ReadLine();
        }
    }
}
