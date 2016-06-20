using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_project3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarves = new List<string> { "Sleepy", "Sneezey", "Grumpy", "Bashful", "Dopey", "Doc", "Happy" };
            var meals = new List<string> { };
            foreach(string dwarf in dwarves)
            {
                Console.WriteLine("what would {0} like to eat?", dwarf);
                string food = Console.ReadLine();
                meals.Add(food);
            }
            for (int i = 0; i < dwarves.Count; i++)
            {
                Console.WriteLine("{0}, your {1} is ready!!", dwarves[i], meals[i]);
            }
        }
    }
}
