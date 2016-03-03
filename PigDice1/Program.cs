using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            ///welcome screen
            
                Console.WriteLine("WELCOME TO PIG'S DIE!!!<('@')>");
                Console.WriteLine("-Press enter to roll die.");
                Console.WriteLine("-Add up each roll to get your turn points.");
                Console.WriteLine("-Be careful not to roll a 1. That will make you loose all your turn points.");
                Console.WriteLine("-Press B to bank your turn points towards your game points.");
                Console.WriteLine("-Get 100 points to win");

            


            ///rolls random interger between 1 and 6
            int turnTotal = 0;
            int gameTotal = 0;
            while (gameTotal < 100)
            {
                while (true)
                {
                    int die = rnd.Next(1, 7);
                    Console.WriteLine("You rolled a " + die);

                    if (die == 1)
                    {
                        turnTotal = 0;
                        Console.WriteLine("Let's go again!");
                        break;
                    }
                    else
                    {
                        turnTotal += die;

                        Console.WriteLine("Turn total is " + turnTotal + " and game total is " + gameTotal);
                        Console.WriteLine("Press enter to roll again or B to bank and end turn.");
                        var userInput = Console.ReadLine();



                        if (userInput == "b")
                        {
                            gameTotal += turnTotal;
                            turnTotal = 0;
                            break;
                        }
                    }
                }
                ///while game total less than 100 keep going
                ///{
                ///while ^ true/player turn loop
                ///display
                /// if turn score equals 0 next turn
                ///else add dice roll to turn total
                ///ask if bank or roll
                ///if bank add turn total to game total also break
                ///if roll loop back to roll
                ///
                ///result is saved
                ///add value to 2-6
                ///first result added to second and so one
                ///must be able to bank sums
                ///if 1 rolled nothing scored and new turn starts
                ///end the game on score of >= 100


            }
        }
    }
}

