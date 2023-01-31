using System;
namespace Guess35
{
    class Program
    {
        static void Main(string[] args)
        {
            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1, 36);
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Please guess a number in between 1-35.");
                if (Int32.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess was to high!");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess was to low!");
                    }
                    else
                    {
                        Console.WriteLine("The guess were correct! Congratulation!");
                        isRunning = false;
                    }
                }
                else
                {
                    Console.WriteLine("You must enter a valid number!");
                }

            }
        }
    }
}

