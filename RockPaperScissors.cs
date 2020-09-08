using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

// Basic Rock Papper Scissors game to understand C# syntax and fundamentals 
namespace RockPaperScissors

{

    class Program
    {

        static void Main(string[] args)
        {
            string inputPlayer;
            int randomInt;
            bool playAgain = true;
            Console.Write("Welocome to ROCK, PAPER or SCISSORS!!!\n");

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.Write("Choose between ROCK, PAPER or SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    string inputCPU;
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine($"Computer chose {inputCPU}");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine($"Computer chose {inputCPU}");

                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!!\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!!\n\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine($"Computer chose {inputCPU}");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!!\n\n");
                            }
                            break;

                        default:
                            {
                                Console.WriteLine("Invalid input");  //This case will never be hit 
                            }
                            break;
                    }

                Console.WriteLine("\nSCORE (First to 3 WINS!): \tPLAYER: {0} \tCPU: {1}", scorePlayer, scoreCPU);

                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("PLAYER HAS WON THE GAME!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU HAS WON THE GAME!!");
                }
                Console.WriteLine("Do you want to play again? (y/n): ");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                    Console.WriteLine("GoodBye!!!");
                }
                else
                {
                    Console.WriteLine("Invalid input! Use (y/n)");
                }
            }
        }

    }

}
