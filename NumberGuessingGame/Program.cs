using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random(); // allows us to call the Next method - which will create a random number
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess what my favorite number is:");
            int userInput;
            do
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput < favNumber)
                {
                    Console.WriteLine("You're too low.  Too bad. So sad");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("You're too high and are terrible at this game");
                }
                else
                {
                    Console.WriteLine($"You got it dude!");
                }
            } while (userInput != favNumber);
        }
    }
}







  