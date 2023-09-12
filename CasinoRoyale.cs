/* Casino Royale Project - IS350
 * This application will simulate a Casino Royale and keep track of operations. 
 * The program will depict various games to play, entertainment, and different people. 
 * Employees can clockin/out, customers can play games, or choose to experience some form of entertainment. 
 * Equivalent to a RPG program where user can experience functions of the business and customer offerings all in one system.
 * Sidney Rood
 */
using System;
using System.Text;

namespace CasinoRoyaleProject
{
    internal class CasinoRoyale
    {
        static void Main(string[] args)
        {
            //create people objects
            People p1 = new People("Sidney Rood", 21, "srood@yahoo.com", true, true);
            People p2 = new People();
            People p3 = new People("Derrick Henry", 27, "kingHenry@gmail.com", true, false);
            //call people methods (print, update, hotel, employeeClockIn)
            //p1.printPeopleDetails();
            //p2.printPeopleDetails();
            //p3.printPeopleDetails();
            //p1.updatePeopleDetails();
            //p1.printPeopleDetails();
            //p2.employeeClockInOut();

            //create game objects
            Game g1 = new Game("Poker", "Usually played as Texas Hold'em where players get 2 cards and make wagers based on their hand.", "Card Game - Strategy/Luck", 12, 0);
            Game g2 = new Game();
            Game g3 = new Game("BlackJack", "Card game where players try to get 21 and beat the dealer.","Card Game - Strategy/Luck", 18, 0);
            //call game methods (print, roulette, blackjack, slots, sportsBet)
            //g1.printGameDetails();
            //g2.printGameDetails();
            //g3.printGameDetails();
            //g2.playRoulette();
            g3.playBlackjack();

            //create entertainment objects
            Entertainment e1 = new Entertainment("Concert", "This is a show where a musicical artist plays live.", 50.00, 1000, "Thu-Sat");
            //call entertainment details (print, orderDrink, goToPool, buyConcertTickets)
            //e1.printEntDetails();

        }//main method
    }//class

    class People
    {
        string name;
        int age;
        string email;
        bool isCustomer;
        bool isRewardsMember;
        //string[] allPeople;

        public People()
        {
            name = "John Doe";
            age = 0;
            email = "xxxx@gmail.com";
            isCustomer = false;
            isRewardsMember = false;
            //allPeople = new string[20];
        }//default constructor

        public People(string n, int a, string e, bool iC, bool iRM) //int uNum
        {
            name = n;
            age = a;
            email = e;
            isCustomer = iC;
            isRewardsMember = iRM;
            //allPeople = new string[uNum];
        }//parameter constructor

        public void printPeopleDetails()
        {
            Console.WriteLine("Name: {0}\nAge: {1}\nEmail: {2}", name, age, email);
            Console.WriteLine("Customer: {0}\nRewards Member: {1}", isCustomer, isRewardsMember);
            Console.WriteLine();
            //foreach (string person in allPeople)
            //    Console.WriteLine(person);

        }//printPeopleDetails method

        public void updatePeopleDetails()
        {
            Console.WriteLine("What attribute would you like to change? (name, age, email, isCustomer, or isRewardsMember)");
            string userChange = Console.ReadLine()!;

            try
            {
                if (userChange == "name")
                {
                    Console.WriteLine("Please enter your new name:");
                    string newName = Console.ReadLine()!;
                    name = newName;
                    Console.WriteLine("Name has been changed to {0}.", newName);
                }//name IF
                if (userChange == "age")
                {
                    Console.WriteLine("Please enter your new age:");
                    int newAge = Convert.ToInt32(Console.ReadLine());
                    age = newAge;
                    Console.WriteLine("Age has been changed to {0}.", newAge);
                }//age IF
                if (userChange == "email")
                {
                    Console.WriteLine("Please enter your new email:");
                    string newEmail = Console.ReadLine()!;
                    email = newEmail;
                    Console.WriteLine("Email has been changed to {0}.", newEmail);
                }//email IF
                if (userChange == "isCustomer")
                {
                    Console.WriteLine("Please enter your new isCustomer (true = customer; false = not a customer):");
                    bool newIsCustomer = Convert.ToBoolean(Console.ReadLine());
                    isCustomer = newIsCustomer;
                    Console.WriteLine("isCustomer has been changed to {0}.", newIsCustomer);
                }//isCustomer IF
                if (userChange == "isRewardsMember")
                {
                    Console.WriteLine("Please enter your new isRewardsMember (true = Rewards Member; false = not a Rewards Member):");
                    bool newIsRewardsMember = Convert.ToBoolean(Console.ReadLine());
                    isRewardsMember = newIsRewardsMember;
                    Console.WriteLine("isRewardsMember has been changed to {0}.", newIsRewardsMember);
                }//rewards ELSE
            }
            catch
            {
                Console.WriteLine("Error. Invalid input.");
            }
        }//updatePeopleDetails method

        public void hotelReservation()
        {

        }//hotelReservation method

        public void employeeClockInOut()
        {
            bool clockIn = false;
            int hours = 0;
            Console.WriteLine("Hello {0}!\nWould you like to clock in?", name);
            string employeeAction = Console.ReadLine()!;

            if (employeeAction == "yes")
                clockIn = true;
            else
                clockIn = false;

            while (clockIn == true)
            {
                hours++;
                Console.WriteLine("You have been clocked in for {0} hours. Would you like to clock out?", hours);
                if (Console.ReadLine() == "yes")
                    clockIn = false;

                if (hours == 8)
                {
                    clockIn = false;
                    Console.WriteLine("You have reached the max amount of hours for the day.");
                }
            }//while

            Console.WriteLine("{0}, you have successfully logged {1} hours. Have a great day!", name, hours);
        }//employeeClockInOut method
    }//people Class (employees/customers)

    class Game
    {
        string gameName;
        string gameDescription;
        string gType;
        int totalSeats;
        double totalBets;

        public Game()
        {
            gameName = "Default game";
            gameDescription = "Player wagers based on 5 card draw.";
            gType = "Default type";
            totalSeats = 0;
            totalBets = 0;
        }//default constructor

        public Game(string gN, string gD, string gT, int tS, double tB)
        {
            gameName = gN;
            gameDescription = gD;
            gType = gT;
            totalSeats = tS;
            totalBets = tB;
        }//parameter constructor

        public void printGameDetails()
        {
            Console.WriteLine("Game: {0}\nDescription: {1}\nType: {2}", gameName, gameDescription, gType);
            Console.WriteLine("Total Seats: {0}\nTotal Bets: {1}", totalSeats, totalBets);
            Console.WriteLine();

        }//printGameDetails method

        public void playRoulette()
        {
            Console.WriteLine("Welcome to the Roulette Table!\nHow much money would you like to buy in for?");
            double buyIn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much would you like to bet?(min=5)");
            double bets = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("How many numbers will you bet on?");
            //int amountOfNums = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            bool keepPlaying = true;
            double winnings = 0;
            //int[] playerNums = new int[amountOfNums];

            while (bets >= 5 && buyIn > 0 && keepPlaying == true)
            {
                Console.WriteLine("Input a number to bet on (0-36):");
                int playerNum = Convert.ToInt32(Console.ReadLine());

                int spin = r.Next(0, 36);
                Console.WriteLine("The spin landed on number {0}", spin);

                if (playerNum == spin)
                {
                    winnings = (bets * 36) + bets; //calculate winnings
                    buyIn += winnings; //add winnings to buyIn
                    Console.WriteLine("You won ${0}. Your total buy in is now ${1}!", winnings, buyIn);
                }//if to check if player won spin or not
                else
                {
                    buyIn -= bets;
                    Console.WriteLine("You lost. Your total buy in is now ${0}.", buyIn);
                }//else lost bet

                Console.WriteLine("Would you like to play again?");
                string playAgain = Console.ReadLine()!;

                if (playAgain == "yes")
                    keepPlaying = true;
                else
                    keepPlaying = false;
            }//while

            if (buyIn == 0)
                Console.WriteLine("You lost all your money. Thanks for playing!");
            else
                Console.WriteLine("You are leaving with a total of ${0}. Thanks for playing!", buyIn);
        }//playRoulette method

        public void playBlackjack()
        {
            bool keepPlaying = true;
            Random r = new Random();

            Console.WriteLine("Welcome to the BlackJack Table!\nHow much money would you like to buy in for?");
            double buyIn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much would you like to bet?(min=5)");
            double bets = Convert.ToInt32(Console.ReadLine());

            while (keepPlaying && buyIn > 0 && bets >= 5)
            {
                int dealerCard1 = r.Next(1, 11);
                int dealerCard2 = r.Next(1, 11);
                int playerCard1 = r.Next(1, 11);
                int playerCard2 = r.Next(1, 11);
                int dealerCardTotal = dealerCard1 + dealerCard2;
                int playerCardTotal = playerCard1 + playerCard2;

                Console.WriteLine("The dealer has a {0} showing...", dealerCard2);
                Console.WriteLine("You have a {0} and a {1}.\nWould you like to hit or stay?", playerCard1, playerCard2);
                string uChoice = Console.ReadLine()!;

                if (dealerCardTotal == 21)
                {
                    Console.WriteLine("The Dealer has BlackJack with a {0} and a {1}.", dealerCard1, dealerCard2);
                    buyIn -= bets;
                }//if to check if dealer has blackjack after initial deal
                if (playerCardTotal == 21)
                {
                    Console.WriteLine("You have BlackJack with a {0} and a {1}!", playerCard1, playerCard2);
                    buyIn += bets * 1.5;
                }//if to check if player has blackjack after initial deal
                else
                {
                    if (uChoice == "hit")
                    {
                        int playerCard3 = r.Next(1, 11);
                        playerCardTotal += playerCard3;
                        Console.WriteLine("You got a {0}. You now have a total of {1}.", playerCard3, playerCardTotal);
                        if (playerCardTotal > 21)
                        {
                            buyIn -= bets;
                            Console.WriteLine("You lost by busting with a {0}.", playerCardTotal);
                        }//if to check if busted
                        else
                        {
                            Console.WriteLine("Hit or Stay?");
                            string uChoice2 = Console.ReadLine()!;
                            if (uChoice2 == "hit")
                            {
                                int playerCard4 = r.Next(1, 11);
                                playerCardTotal += playerCard4;
                                Console.WriteLine("You got a {0}. You now have a total of {1}.", playerCard4, playerCardTotal);

                                if (playerCardTotal > 21)
                                {
                                    buyIn -= bets;
                                    Console.WriteLine("You lost by busting with a {0}.", playerCardTotal);
                                }//if to check if
                                Console.WriteLine("Hit or stay?");
                                string uChoice3 = Console.ReadLine()!;
                                if (uChoice3 == "hit")
                                {
                                    int playerCard5 = r.Next(1, 11);
                                    playerCardTotal += playerCard5;
                                    Console.WriteLine("You got a {0}. You now have a total of {1}.", playerCard5, playerCardTotal);

                                    if (playerCardTotal > 21)
                                    {
                                        buyIn -= bets;
                                        Console.WriteLine("You lost by busting with a {0}.", playerCardTotal);
                                    }//if to check if busted
                                    Console.WriteLine("Hit or stay?");
                                    string uChoice4 = Console.ReadLine()!;
                                    if (uChoice4 == "hit")
                                    {
                                        int playerCard6 = r.Next(1, 11);
                                        playerCardTotal += playerCard6;
                                        Console.WriteLine("You got a {0}. You now have a total of {1}.", playerCard6, playerCardTotal);

                                        if (playerCardTotal > 21)
                                        {
                                            buyIn -= bets;
                                            Console.WriteLine("You lost by busting with a {0}.", playerCardTotal);
                                        }//if to check if busted
                                    }
                                }//if to hit
                            }//if to hit
                        }//else to keep playing
                    }//if for hit
                }//else to play out rest of game

                Console.WriteLine("The dealer's second card is a {0} with a total of {1}", dealerCard1, dealerCardTotal);
                while (dealerCardTotal < 17)
                {
                    int dealerCard3 = r.Next(1, 11);
                    dealerCardTotal += dealerCard3;
                    Console.WriteLine("The dealer got a {0} with a total of {1}", dealerCard3, dealerCardTotal);
                }//while loop for dealer to finish his turn

                if (dealerCardTotal > 21)
                {
                    Console.WriteLine("The dealer busted with {0}. You Won!", dealerCardTotal);
                    buyIn += bets;
                }//If dealer busts
                if (dealerCardTotal > playerCardTotal && dealerCardTotal <= 21)
                {
                    Console.WriteLine("The dealer won with a {0}. You had {1}.", dealerCardTotal, playerCardTotal);
                    buyIn -= bets;
                }//check if dealer won
                if (playerCardTotal > dealerCardTotal && playerCardTotal <= 21)
                {
                    Console.WriteLine("You won with a {0}! The dealer had {1}.", playerCardTotal, dealerCardTotal);
                    buyIn += bets;
                }//check if player won
                if (playerCardTotal == dealerCardTotal)
                    Console.WriteLine("Push.");
                
                Console.WriteLine("You now have ${0}", buyIn);
                Console.WriteLine("Would you like to play again?");
                string playAgain = Console.ReadLine()!;

                if (playAgain == "yes")
                    keepPlaying = true;
                else
                    keepPlaying = false;
            }//while loop allow user to keep playing

            if (buyIn == 0)
                Console.WriteLine("You lost all your money. Thanks for playing!");
            else
                Console.WriteLine("You are leaving with a total of ${0}. Thanks for playing!", buyIn);

        }//playBlackjack method

        public void playSlots()
        {
            Console.WriteLine("To play, input money:");
            double moneyInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much would you like to bet per spin?");

            
        }//playSlots method

        public void placeSportsBet()
        {

        }//placeSportsBet method
    }//game class

    class Entertainment
    {
        string entName;
        string entDescription;
        double cost;
        int customerLimit;
        string daysOffered;

        public Entertainment()
        {
            entName = "Default Entertainment";
            entDescription = "A fun event for the family.";
            cost = 0;
            customerLimit = 0;
            daysOffered = "Mon-Fri";
        }//default constructor

        public Entertainment(string eN, string eD, double c, int cL, string dO)
        {
            entName = eN;
            entDescription = eD;
            cost = c;
            customerLimit = cL;
            daysOffered = dO;
        }//parameter constructor

        public void printEntDetails()
        {
            Console.WriteLine("Entertainment Name: {0}\nDescription: {1}", entName, entDescription);
            Console.WriteLine("Cost: {0}\nCustomer Limit: {1}\nDays Offered: {2}", cost, customerLimit, daysOffered);
        }//printEntDetails method

        public void orderDrinkAtBar()
        {

        }//orderDrinkAtBar method

        public void goToPool()
        {

        }//goToPool method

        public void buyConcertTickets()
        {

        }//buyConcertTickets method
    }//entertainment Class

}//namespace