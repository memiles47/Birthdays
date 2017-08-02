using System;

namespace Birthdays
{
    internal static class Program
    {
        private static void Main()
        {
            var birthday = new BirthdayData();
            var bdayQuery = new DataQuery();
            var birthdays = birthday.BDayData;

            DataQuery.NameCheck(birthdays);

            Console.WriteLine("\n\nYou quit, press any key to continue");
            Console.ReadLine();
        }
    }
}
