using System;
using System.Collections.Generic;

namespace Birthdays
{
    public static class DataQuery
    {
        public static void NameCheck(Dictionary<string, string> birthdays)
        {
            while (true)
            {
                Console.Write("Enter a name (blank to quit): ");
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
                    if (bday == null) continue;
                    if (name != null) birthdays[name] = bday;
                    Console.WriteLine("\nBirthday database updated\n");
                }
            }
        }
    }
}