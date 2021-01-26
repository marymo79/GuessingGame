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

            if (userNumber == 7)
            {
                Console.WriteLine("You Won!!");
            }
            else if (userNumber == 0)
            {
                Console.WriteLine("0 is not a number between 1 and 10, loser");
                            }
            else if (userNumber == -1)
            {
                Console.WriteLine("End Game");
            }
            else
            {
                Console.WriteLine("Guess again");
                userNumber = Convert.ToInt32(Console.ReadLine());
                while (userNumber != 7)
                {
                    
                    if (userNumber == 7)
                    {
                        Console.WriteLine("You Won!!");
                    }
                    else if (userNumber == 0)
                    {
                        Console.WriteLine("0 is not a number between 1 and 10, loser");
                        break;
                    }
                    else if (userNumber == -1)
                    {
                        Console.WriteLine("End Game");
                        break;
                    }
                    else
                    {
                        while (userNumber != 7)
                        {
                            Console.WriteLine("Guess again");
                            userNumber = Convert.ToInt32(Console.ReadLine());

                            if (userNumber == 7)
                            {
                                Console.WriteLine("You Won!!");
                            }
                            else if (userNumber == 0)
                            {
                                Console.WriteLine("0 is not a number between 1 and 10, loser");
                                // this will repeat line in first loop 
                                break;
                                                            }
                            else if (userNumber == -1)
                            {
                                Console.WriteLine("Game Over");
                            }
                            else
                            {
                                Console.WriteLine("You are out guesses! GAME OVER!");
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
