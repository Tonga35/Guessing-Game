using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord="giraffe";
            string guess = "";
            int guessCounter = 0;
            string[] clues = new string[8];

            clues[0] = "";
            clues[1] = "Clue: It has spots";
            clues[2] = "Another clue: It's a mammal";
            clues[3] = "One more clue: It lives in africa (i think)";
            clues[4] = "And another one: It has a very long neck";
            clues[5] = "Really? you didn't get it with the very long neck?";
            clues[6] = "Ok, now you are trolling. Just write \"giraffe\" and be done with it.";
            clues[7] = "Ok then.";

            while (guess != secretWord && guessCounter <= 7)
            {
                for (int i = 0; i <= guessCounter; i++)
                {
                    Console.WriteLine(clues[i]);
                }
                Console.Write("Guess the animal: ");
                guess = Console.ReadLine();
                guessCounter++;
            } 

            if (guessCounter >= 8)
            {
                Console.WriteLine("You Lost");
            }
            else
            {
                Console.WriteLine("You've won!");
            }
        }
    }
}
