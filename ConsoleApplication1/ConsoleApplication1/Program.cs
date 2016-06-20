using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[5];
            int[] count = { 0, 1, 2, 3, 4 };
            
            foreach (int i in count)
            {
                numbers[i] = i * 5;
            }
            
            foreach (int output in numbers)
            {
                Console.WriteLine(output);
            }
        }
    }
}
