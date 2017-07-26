using System;
using System.Collections.Generic;

namespace Birthdays
{
    class Program
    {
        static void Main()
        {
            // Setting up dictionary
            var birthdays = new Dictionary<string, string>
            {
                {"Alice", "Apr 1"},
                { "Bob", "Aug 12"},
                { "Carol", "Mar 4"}
            };

            //Setting up while loop
            while (true)
            {
                Console.WriteLine("Enter a name (blank to quit)");
                var name = Console.ReadLine();
                if (name == "")
                    break;

                if (name != null && birthdays.ContainsKey(name))
                    Console.WriteLine($"\n{birthdays[name]} is the birthday of {name}");

                else
                {
                    Console.WriteLine($"\nI do not have birthday information for {name}");
                    Console.Write("What is their birthday? ");
                    var bday = Console.ReadLine();
                    if (bday != null)
                    {
                        if (name != null) birthdays[name] = bday;
                        Console.WriteLine("\nBirthday database updated\n");
                    }
                }
            }

            Console.WriteLine("\n\nYou quit, press any key to continue");
            Console.ReadLine();
        }
    }
}
