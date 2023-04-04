/* Sidney Rood
 * Assignment 6 - IS350
 * Program will simulate the war card game
 * Consists of two players and uses methods to have them play war until there is a winner
 */

using System.Reflection.Metadata.Ecma335;

namespace Assignment6
{
    internal class Assignment6
    {
        static void Main(string[] args)
        {
            //Welcome message and prompt user for players names
            Console.WriteLine("Welcome to War! Don't worry just the card game!");
            Console.WriteLine("Enter player 1's name:");
            string p1Name = Console.ReadLine();
            Console.WriteLine("Enter player 2's name:");
            string p2Name = Console.ReadLine();

            War(p1Name, p2Name); //Call war method

        }//Main Method

        static int Draw()
        {
            Random r = new Random();
            return r.Next(1, 14);
        }

        static void War(string p1Name, string p2Name)
        {
            //Initial card count
            int p1CardTotal = 26;
            int p2CardTotal = 26;
            int rounds = 0;
            string winner = "";

            //Loop to play game out
            while (p1CardTotal > 0 && p2CardTotal > 0)
            {
                //let player1 draw a card
                int p1Draw = Draw();
                int p2Draw = Draw();

                //If statement for card comparison
                if (p1Draw > p2Draw) //p1 win with high card
                {
                    p1CardTotal++;
                    p2CardTotal--;
                    Console.WriteLine("{0} won with {1} over {2}", p1Name, p1Draw, p2Draw);
                }
                else if (p2Draw > p1Draw) //p2 win with high card
                {
                    p2CardTotal++;
                    p1CardTotal--;
                    Console.WriteLine("{0} won with {1} over {2}", p2Name, p2Draw, p1Draw);
                }
                else
                {
                    continue; //tie, so move to next round 
                }
                //Show updated card count every round
                Console.WriteLine("{0} has {1} cards, and {2} has {3} cards.", p1Name, p1CardTotal, p2Name, p2CardTotal);
                rounds++;
            }

            //Display the winner and congragulate them
            if (p1CardTotal > 0)
                winner = p1Name;
            else if (p2CardTotal > 0)
                winner = p2Name;

            Console.WriteLine("After {0} rounds, {1} claims victory! Great job at War! Thanks for playing.", rounds, winner);
        }

    }//Class
}//Namespace