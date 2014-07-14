using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame
{
    public class Team
    {
        
        public string Name { get; set; }
        public int score { get; set; }
        //constructor
        public Team()
        {
            score = 0;
        }
        // add integer value to score
        // score = score + value;

        public void AddScore(int value)
        {
            score += value;
        }
      
    }
  
    
    class Program
    {
        static void Main(string[] args)
        {
            Team Red = new Team();
            Red.Name = "Red Team";
            Team Blue = new Team();
            Blue.Name = "Blue Team";
            Console.WriteLine("The score of {0} and {1} is {2} to {3}", Red.Name, Blue.Name,Red.score, Blue.score);
            Console.WriteLine("The game starts");
            Red.AddScore(2);
            Console.WriteLine("The score at halftime is {0} {1} and {2} {3}", Red.Name, Red.score, Blue.Name, Blue.score);
            Console.ReadLine();
        }
    }
}
