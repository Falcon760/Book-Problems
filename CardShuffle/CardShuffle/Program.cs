using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle
{
   

    static public class FisherYates
    {
        static Random r = new Random();
        //	Based on Java code from wikipedia:
        //	http://en.wikipedia.org/wiki/Fisher-Yates_shuffle
        static public void Shuffle(int[] deck)
        {
            for (int n = deck.Length - 1; n > 0; --n) //deck of 5 would make n = 4
            {
                int a = r.Next(n + 1);  //a is random number out of deck length, ex 5
                int temp = deck[n];  // temp becomes 4th element
                deck[n] = deck[a];  //4th element becomes random number
                deck[a] = temp;  // random element in deck changes places 
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int[] somecards = { 1, 2, 3, 4, 5,6,7,8,9,10 };
            FisherYates.Shuffle(somecards);
            foreach (var item in somecards)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadLine();

        }
    }
}
