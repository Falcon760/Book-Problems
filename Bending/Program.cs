using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending
{
    public interface IBendable
    {
        string Name { get; set; }
        void Bend();
      
    }

    class Spoon : IBendable
    {
        public string Name { get; set; }
     public void Bend()
        {
            Console.WriteLine("You bend the spoon with your mind.");
        }
    }

    class Arm : IBendable
    {
        public string Name { get; set; }
        public void Bend()
        {
            Console.WriteLine("You bend your arm and not your spoon.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Arm leftArm = new Arm();
            leftArm.Name = "Left Arm";
            Spoon Spoon1 = new Spoon();
            Spoon1.Name = "Metal Spoon of Death";
            leftArm.Bend();
            Spoon1.Bend();

            Console.ReadLine();
        }
    }
}
