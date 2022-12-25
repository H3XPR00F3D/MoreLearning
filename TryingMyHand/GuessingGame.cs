using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning
{
    public class GuessingGame
    {
        public static void Game() 
        {
            //Variables being used
            int max;
            int min;
            int guess;
            Random random= new();
            

            //Prompts user to the game
            Console.WriteLine("We are going to play a guessing game. You will input two numbers of different values, I will pick a random number in between. It is your job to guess the correct number. Good Luck.");
            Console.WriteLine();
            //Asks for 'min' variable value
            Console.WriteLine("Input the low number");
            min = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
            //Asks for 'max' variable value
            Console.WriteLine("Input the high number");
            max = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
            //sets up answer
            Console.WriteLine("The number range you have chosen is from " + min + " to " + max); Console.WriteLine();
            Console.WriteLine("I will pick a number. Ok, got it. What is your first guess?");
            // 'answer' value randomly generated.
            int answer = random.Next(min, max);
            guess = Convert.ToInt32(Console.ReadLine());

            //do loop to check  guess against answer.
            do 
            {
                if (guess > max || guess < min) { Console.WriteLine("Your answer is outside the range. Please guess again."); guess = Convert.ToInt32(Console.ReadLine()); }
                else if (guess < answer) { Console.WriteLine("Your guess is too low, try again."); guess = Convert.ToInt32(Console.ReadLine()); }
                else if (guess > answer) { Console.WriteLine("Your guess is too high, try again."); guess = Convert.ToInt32(Console.ReadLine()); }
               
            }
            while (guess != answer);

            while(guess == answer)
            {
                 Console.WriteLine(); Console.WriteLine("YOU WIN!!"); Console.WriteLine();
                break;
            }
        }
    }
}
