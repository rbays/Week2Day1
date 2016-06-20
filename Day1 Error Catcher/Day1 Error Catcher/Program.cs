using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Error_Catcher
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,string> myDict = new Dictionary<string, string> { };

            int[] numbers = { 1, 2, 3, 4, 5 };
            
            try
            {
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("index out of range you silly billy");
            }

            try
            {
                int zero = 0;
                Console.WriteLine((10 / zero).ToString());
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("you can't divide by zero you numpty");
            }

            try
            {
                Console.WriteLine(myDict["hello"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("the Dictionary doesn't have that key!");
            }
            try
            {
                int number = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("it's the wrong format, couldn't be parsed");
            }
        }
    }
}
