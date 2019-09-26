using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    class Human
    {
        public static void HumanPlays()
        {
            
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int guess;
            
            int numberOfGuesses = 3;
            bool gameOver = false;

            Console.WriteLine("Human - Guess a number between 1 and 10");


            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;
                
                if (guess != randomNumber && numberOfGuesses == 0)
                {
                    Console.WriteLine("Your 3 guesses are up! Sucks to suck. You lose!");
                    gameOver = true;
                }
                
                else if (guess == randomNumber)
                {
                    Console.WriteLine("Winner!");
                    gameOver = true;
                }
                
                else if (guess > randomNumber)
                {
                    Console.WriteLine("The number is smaller than that!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Nope! Number is greater than that.");
                }
            }
            Console.ReadLine();
        }

    }
}
