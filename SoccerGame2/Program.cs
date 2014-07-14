using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame2
{
    public class Game
    {

        public string Name { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public string AwayTeamName { get; set; }
        public string HomeTeamName { get; set; }

        public Game()
    {
        HomeScore = 0;
        AwayScore = 0;
    }
        public void AddScoreH(Game x, int value)
        {
            x.HomeScore += value;
        }
        public void AddScoreA(Game x, int value)
        {
            x.AwayScore += value;
        }
    }
   class Team
    {
        //int score = 0;
        public Team()
        {
            int score = 0;
        }
    
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            
            Team Red = new Team();
            Team Blue = new Team();
            Game game1 = new Game();
            game1.AwayTeamName = "Red";
            game1.HomeTeamName = "Blue";
            game1.Name = "Red vs Blue Game";
            Console.WriteLine("The score of {0} is {1} {2} and {3} {4}", 
                game1.Name, game1.HomeTeamName, game1.HomeScore, game1.AwayTeamName, game1.AwayScore);
            
            game1.AddScoreA(game1, 1);
            Console.WriteLine("The score of {0} is {1} {2} and {3} {4}",
                game1.Name, game1.HomeTeamName, game1.HomeScore, game1.AwayTeamName, game1.AwayScore);

            Console.ReadLine();
            Game game2 = new Game();
            game2.AwayTeamName = "Red";
            game2.HomeTeamName = "Blue";
            game2.AddScoreA(game2, 3);
            game2.AddScoreH(game2, 2);
            Console.WriteLine("After halftime, the score of {0} is {1} {2} and {3} {4}",
                game2.Name, game2.HomeTeamName, game2.HomeScore, game2.AwayTeamName, game2.AwayScore);

            Console.ReadLine();

        }
    }
}
