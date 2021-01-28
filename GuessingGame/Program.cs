using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guessing Game");
            Console.WriteLine("Pick a number between 1 and 10");
            Console.WriteLine("If you want to leave the game, enter -1");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            Random rd = new Random();
            int magicNumber = rd.Next(1, 10);
            

            for (int count = 1; count <= 3; count++)
            {
                if (userNumber == magicNumber)
                {
                    Console.WriteLine("You Won!!");
                    break;
                }
                else if (userNumber == 0)
                {
                    Console.WriteLine("0 is not a number between 1 and 10, loser.");
                    break;
                }
                else if (userNumber == -1)
                {
                    Console.WriteLine("End Game");
                    break;
                }
                else
                {
                    if (userNumber > magicNumber)
                    {
                        Console.WriteLine("Your guess was too big.");
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too small.");
                    }
                
                    Console.WriteLine("Guess again.");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                
                }
            }
            if (userNumber != magicNumber)
            {
                if (userNumber == -1)
                {
                    Console.WriteLine("Goodbye!");
                }
                else if (userNumber == 0)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("You are out of guesses! GAME OVER!");
                }
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
