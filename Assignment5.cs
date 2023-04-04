/* Sidney Rood
 * Assignment 5: Pirate's Plunder - IS350
 * Program will help a pirate do some accounting and hopefully gain some treasure
 * There will be 2 simulations, one being indefinitely and another being a set amount of years
 * Each year pirate has equal chance to gain or lose 25 gold
 * Game ends when user retires, gold is greater than 1000 or goes down to 0, or number of years is executed
 */

namespace Assignment5
{
    internal class Assignment5
    {
        static void Main(string[] args)
        {
            try
            {
                //create variables
                int treasure = 0;
                int year = 1;
                bool isActive = true;

                Random r = new Random();// random number to determine gold reward

                do
                {
                    //get user input for starting amount of treasure
                    Console.WriteLine("Ahoy mate! What do you want your starting treasure to be? (enter a whole integer between 0 and 1000)");
                    treasure = Convert.ToInt32(Console.ReadLine());
                } while (treasure <= 0 || treasure >= 1000);

                Console.WriteLine("You currently have {0} gold. Good luck!", treasure);

                Console.WriteLine("Do you want to experience the years indefinitely (1) or enter an amount of years to find treasure (2) or retire (3)?");
                int gameType = Convert.ToInt32(Console.ReadLine());

                if (gameType == 1) //game 1 - loop until goldAMount is > 1000 or < 0
                {
                    while (treasure >= 0 && treasure <= 1000)
                    {
                        if (r.Next(0, 2) == 0)
                        {
                            treasure = treasure + 25;//increase gold amount
                        }
                        else
                        {
                            treasure = treasure - 25;//decrease gold amount
                        }

                        year++;//increment year
                               //display updated gold amount plus year
                        Console.WriteLine("You have {0} gold and it is year {1}!", treasure, year);

                        if (treasure <= 0 || treasure >= 1000)
                            Console.WriteLine("Game Over.");
                    }
                }
                else if (gameType == 2) //game 2 - loop based on number of years indicated by user
                {
                    //capture user input
                    Console.WriteLine("Arghhh! How many years would you like to go through?");
                    int duration = Convert.ToInt32(Console.ReadLine());

                    while (year <= duration)
                    {
                        if (r.Next(0, 2) == 0)
                        {
                            treasure = treasure + 25;//increase gold amount
                        }
                        else
                        {
                            treasure = treasure - 25;//decrease gold amount
                        }

                        year++;//increment year
                               //display updated gold amount plus year
                        Console.WriteLine("You have {0} gold and it is year {1}!", treasure, year);
                    }
                }
                else //retired
                    isActive = false;

                if (!isActive)//Game ends when user has 0 gold
                    Console.WriteLine("Game Over.");
            }
            catch
            {
                Console.WriteLine("Error. Please input a valid integer next time pirates!");
            }

        }//M
    }//C
}//NS