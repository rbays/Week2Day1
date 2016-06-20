using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[5,5];
            Console.WriteLine("Enter 25 numbers into a 5x5 array");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Starting line {0}", (i + 1).ToString());
                for (int j = 0; j < 5; j++)
                {
                    bool result = false;
                    while (!result)
                    {
                        string input = Console.ReadLine();
                        result = Int32.TryParse(input, out myArray[i,j]);
                    }
                    Console.WriteLine(" number accepted");
                }
            }
            int total = 0;
            foreach(int number in myArray)
            {
                total += number;
            }
            decimal average = (decimal)total / myArray.Length;
            Console.WriteLine("the average is " + average.ToString());
            int lineSum;
            for (int i = 0; i < 5; i++)
            {
                lineSum = 0;
                for (int j = 0; j < 5; j++)
                {
                    lineSum += myArray[i, j];
                }
                Console.WriteLine("line {0} has a sum of {1}", i.ToString(), lineSum.ToString());
            }
        }
    }
}
