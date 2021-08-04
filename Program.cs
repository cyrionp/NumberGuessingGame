using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.Write("\nYour name: ");
            string name = Console.ReadLine();
            Console.Write("\nHow many guess do you want to do? : ");
            AttemptAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter numbers:");
            Console.Write("Lowest number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Highest number: ");
            int last = Convert.ToInt32(Console.ReadLine());

            RandomizedNumber = RandomNumber(first, last);

            Console.WriteLine("\nRandom number is generated\n");

            while (AttemptAmount > 0)
            {
                while (!RightGuess)
                {
                    Console.WriteLine($"You have {AttemptAmount} attempts left");
                    Console.Write("Your guess: ");
                    int guessedNumber = Convert.ToInt32(Console.ReadLine());

                    RightGuess = (guessedNumber == RandomizedNumber);
                    if (RightGuess)
                        break;
                    AttemptAmount--;
                    if (AttemptAmount == 0)
                        break;
                }

                break;
            }

            string message = (RightGuess) ? "won" : "defeated";
            Console.WriteLine($"\nGame is finished. {name}, you {message}!");
        }

        private static int RandomNumber(int first, int last)
        {
            Random random = new Random();
            return random.Next(first, last);
        }

        private static int AttemptAmount;
        private static int RandomizedNumber;
        private static bool RightGuess = false;
    }
}