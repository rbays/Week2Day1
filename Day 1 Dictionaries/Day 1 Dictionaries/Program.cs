using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> languages = new Dictionary<string, string>()
            {
                {"javascript", "a programming language that runs in browsers."},
                {"c#", "a compiled coding language, edit with Visual Studio."},
                {"python", "easily readable language, run in IDLE, indentation matters."}
            };
            bool playing = true;
            string[] options = { "add", "search", "count", "list", "exit" };
            while (playing)
            {
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");
                foreach(string option in options)
                {
                    Console.Write(option + " ");
                }
                Console.WriteLine("");
                string inputOption = (Console.ReadLine()).ToLower();
                switch (inputOption)
                {
                    case "add":
                        Console.WriteLine("Please enter your key (language name):");
                        string keyIn = Console.ReadLine();
                        Console.WriteLine("Please enter your definition:");
                        string descIn = Console.ReadLine();
                        languages.Add(keyIn, descIn);
                        Console.WriteLine("{0} added", keyIn);
                        break;
                    case "search":
                        Console.WriteLine("What would you like to search for?");
                        string inputSearch = Console.ReadLine();
                        if (languages.ContainsKey(inputSearch)){
                            Console.WriteLine(languages[inputSearch]);
                        }
                        else
                        {
                            Console.WriteLine("key not in dictionary!");
                        }
                        break;
                    case "count":
                        Console.WriteLine(languages.Count);
                        break;
                    case "list":
                        Console.WriteLine("The following keys are in the dictionary:");
                        foreach(string key in languages.Keys)
                        {
                            Console.WriteLine(key);
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Thank you for using this dictionary");
                        playing = false;
                        break;
                    default:
                        Console.WriteLine("Command not recognised");
                        break;
                }
            }
        }       
    }
}

        
    

