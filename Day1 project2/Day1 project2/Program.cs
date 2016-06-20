using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string candidate1 = "John Smith";
            string candidate2 = "Tom Jones";
            Array cand1array = candidate1.Split(' ');
            Array cand2array = candidate2.Split(' ');
            string[] candidates = { candidate1, candidate2 };
            foreach (string person in candidates)
            {
                Console.WriteLine("The candidate {0} is standing", person);
            }
            Console.WriteLine("Who do you think will win?");
            string input = Console.ReadLine();
            bool validInput = false;
            foreach (string person in candidates)
            {
                if (input.ToLower() == person.ToLower())
                {
                    validInput = true;
                }
            }

            const string Candidate1 = "john smith";
            const string Candidate2 = "tom jones";

            if (validInput)
            {
                switch (input.ToLower())
                {
                    case (Candidate1):
                        Console.WriteLine("I liked him in Pocohontas");
                        break;
                    case (Candidate2):
                        Console.WriteLine("Delilah was pretty good I guess");
                        break;
                    default:
                        Console.WriteLine("This shouldn't be able to come up");
                        break;
                }
            }
            else
            {
                Console.WriteLine("That wasn't one of the options");
            }

        }

    }
}
