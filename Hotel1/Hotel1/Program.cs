using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    public abstract class Accomodation
    {
        public abstract void ShowRooms();
        public abstract void Reserve();
        public abstract void CheckIn();
        public abstract void TipStaff();
        public abstract void PayBill();
    }

    public class Room
    {
        public int Number { get; set; }
        public double Price { get; set; }
    }

    class CampGround : Accomodation
    {
        public override void CheckIn()
        {

            if (reservations.Count > 0)
                Console.WriteLine("You carry your bags to your cabin.");
            else
                Console.WriteLine("You didn't reserve anything.  Goodbye.");
        }
        public override void TipStaff()
        {
            if (reservations.Count > 0)
                Console.WriteLine("You tip the staff.");
            else
                Console.WriteLine("You jip the staff.");
        }
        public override void PayBill()
        {
            if (reservations.Count > 0)
            {
                Console.WriteLine("Your bill is:");
                foreach (var item in reservations)
                {
                    Console.WriteLine("Cabin Number {0}: {1:C}", item.Number, item.Price);
                }
            }
            else
                Console.WriteLine("You have no bill.");

        }
        
        List<Room> cabin = new List<Room>
        { new Room { Number = 1,  Price = 299.00 },
            new Room { Number = 2, Price = 299.00 },
            new Room { Number = 3, Price = 399.00 }        
        };
        public override void ShowRooms()
        {
            foreach (var item in cabin)
            {
                Console.WriteLine("{0} : {1:C}", item.Number, item.Price);
            }

        }
        List<Room> reservations = new List<Room>();
 
        public override void Reserve()
        {
            
            Console.WriteLine("Which cabin number do you want to reserve?");
            int wanted = int.Parse(Console.ReadLine());
            for (int i = 0; i < cabin.Count; i++)
            {
                if (cabin[i].Number == wanted)
                {
                    reservations.Add( new Room {Number = wanted, Price = cabin[i].Price });

                break;
                }
                
            }
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CampGround yellowstone = new CampGround();
            yellowstone.ShowRooms();
            
            yellowstone.Reserve();
            yellowstone.CheckIn();
        yellowstone.TipStaff();
        yellowstone.PayBill();



            Console.ReadLine();
        }
    }
}
