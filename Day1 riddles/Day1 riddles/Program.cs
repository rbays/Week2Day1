using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day1_riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string riddle1 = "What gets wetter as it dries?";
            string riddle2 = "What's brown and sticky?";
            bool answered1 = false;
            bool answered2 = false;
            while (!answered1)
            {
                Console.WriteLine(riddle1);
                string guess = Console.ReadLine().ToLower();
                if (Regex.IsMatch(guess, "towel"))
                {
                    Console.WriteLine("correct");
                    answered1 = true;
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
            do
            {
                Console.WriteLine(riddle2);
                string guess = Console.ReadLine().ToLower();
                if (Regex.IsMatch(guess, "stick"))
                {
                    Console.WriteLine("correct");
                    answered2 = true;
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            } while (!answered2);
            Console.WriteLine("You got them both right!");
        }
    }
}
