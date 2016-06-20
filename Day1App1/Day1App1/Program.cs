using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num = 2; //works
            //String ohSnap = "%$^&$ "; //works
            //int num2 = 10.9; //error, not an int
            //byte smallNum = -42; //error, not between 0 and 255
            //char word = 'word'; //error, too long
            //long bigNum = 12345678.9; //error is a double, long can't be decimal
            //float x = 3.5F; //works
            //decimal deciNum = 4.2m;//works

            int max = 100;
            Random rnd = new Random();
            int answer = rnd.Next(max);
            bool correct = false;
            int guesses = 0;
            while (!correct)
            {
                Console.WriteLine("Please enter a number up to " + max.ToString());
                string rawGuess = Console.ReadLine();
                int guess;
                if (int.TryParse(rawGuess, out guess))
                {
                    guesses++;
                    if(guess > answer)
                    {
                        Console.WriteLine("Too big");
                    }
                    else if (guess < answer)
                    {
                        Console.WriteLine("Too small");
                    }
                    else
                    {
                        correct = true;
                    }
                }
                else
                {
                    Console.WriteLine("Not a number!");
                }
            }
            Console.WriteLine("you got it in {0} guesses",guesses.ToString());
                        
        }
    }
}
