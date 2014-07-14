using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame3
{
    public class Players
    {
        public int Number { get; set; }
        public string Name { get; set; }

    }
    public class Team
    {
        List<Players> roster;

        public Team()
        {
            roster = new List<Players>();
        
        }
        
        public string Name { get; set; }
        public void AddRoster(string pname)
        {
            roster.Add(new Players { Name = pname });
        }
        public void ShowRoster()
        {
            foreach (Players n in roster)
            {
                Console.WriteLine(n.Name);
            }
        }
        public Team(string name)
        {
            roster = new List<Players>();
            Name = name;
        }
       
    }
    public class Game
    {
        public List<Team> teams;
        public Game()
        { }
        public Game(Team team1, Team team2)
        {

            teams = new List<Team>(2);
            teams.Add(team1);
            teams.Add(team2);
        }
      

        public void AddTeam(string name) 
        {
            teams.Add(new Team { Name = name });
        }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public void Score(int x, int y)
        {
            HomeScore = x;
            AwayScore = y;
           Console.WriteLine("The score is {0} to {1}", HomeScore, AwayScore);
        }
        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Team Red = new Team();
            Team Blue = new Team("Blue");
            Game game1 = new Game(Red, Blue);
            Red.Name = "Red";
            game1.Score(1, 2);
            Red.AddRoster("Miguel Cabrera");
            Red.AddRoster("Fernanda Rodney");
            Console.WriteLine("The roster for {0} is", Red.Name);
            Red.ShowRoster();

            Console.ReadLine();
            
                
        }
    }
}
