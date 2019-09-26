using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    class Computer
    {
        public static void ComputerPlays()
        
        {
            Random random = new Random();
            
            int returnValue = random.Next(1, 101);
            int Guess = 3;
            

            Console.WriteLine("Human - Write number for computer to guess that is between 1-100:");

            while (Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.Read());

                if (Guess < returnValue)
                {
                    Console.WriteLine("Nope the number is higher than " + Guess + ". Try again!");
                }
                else if (Guess > returnValue)
                {
                    Console.WriteLine("No, the number is lower than " + Guess + ". Guess again!");
                }
                
            }
            

            Console.WriteLine("Well done! The answer was " + returnValue);

            
            Console.ReadLine();
           
        }
    }
}
