using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("| Welcome to my Dice Game |");
            Console.WriteLine("---------------------------");
            System.Threading.Thread.Sleep(1000);

            int playerRoll;
            int computerRoll;
            int playerScore = 0;
            int computerScore = 0;

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to roll" + "\n");
                Console.ReadKey(true);


                playerRoll = random.Next(1, 7);
                Console.WriteLine($"The player rolled: " + playerRoll);

                computerRoll = random.Next(1, 7);
                Console.WriteLine($"The computer rolled: " + computerRoll);

                if (playerRoll > computerRoll)
                {
                    playerScore++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRoll < computerRoll)
                {
                    computerScore++;
                    Console.WriteLine("Computer wins this round!");
                }
                else
                {
                    Console.WriteLine("This roll was a draw!");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine($"Player Score is: " + playerScore);
            Console.WriteLine($"Computer Score is: " + computerScore);

            if (playerScore > computerScore)
            {
                Console.WriteLine("THE PLAYER WINS THE GAME!!!");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("THE COMPUTER WINS THE GAME!!!");
            }
            else
            {
                Console.WriteLine("THE GAME WAS A DRAW!!!");
            }
            Console.ReadKey();
        }
    }
}
