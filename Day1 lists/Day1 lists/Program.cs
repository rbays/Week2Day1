using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bookList = new List<String> {
                "Harry Potter",
                "Twilight",
                "The Bible",
                "Lord of the flies"
                };
            List<string> options = new List<string>{"list","add", "delete", "sort", "search", "exit"};
            bool playing = true;

            Console.WriteLine("current books in the list:");
            foreach (string book in bookList)
            {
                Console.WriteLine(book);
            }

            while (playing)
            {
                Console.WriteLine("");
                Console.WriteLine("what would you like to do?");
                foreach (string option in options)
                {
                    Console.Write(option + " ");
                }
                Console.WriteLine("");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "list":
                        Console.WriteLine("current books in the list:");
                        foreach (string book in bookList)
                        {
                            Console.WriteLine(book);
                        }
                        break;
                    case "add":
                        Console.WriteLine("What book would you like to add?");
                        bookList.Add(Console.ReadLine());
                        Console.WriteLine("book added to the list");
                        break;
                    case "delete":
                        Console.WriteLine("What book would you like to delete?");
                        string inputDelete = Console.ReadLine();
                        if (bookList.Contains(inputDelete))
                        {
                            bookList.Remove(inputDelete);
                            Console.WriteLine(inputDelete + " removed");
                        }
                        else
                        {
                            Console.WriteLine(inputDelete + " was not in the booklist");
                        }
                        break;
                    case "sort":
                        bookList.Sort();
                        break;
                    case "search":
                        Console.WriteLine("Enter book to search for");
                        string inputSearch = Console.ReadLine();
                        if (bookList.Contains(inputSearch))
                        {
                            Console.WriteLine(inputSearch + " is in the list");
                        }
                        else
                        {
                            Console.WriteLine(inputSearch + " is NOT in the list");
                        }
                        break;
                    case "exit":
                        playing = false;
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("command not recognised");
                        break;
                }
            }
        }
    }
}
