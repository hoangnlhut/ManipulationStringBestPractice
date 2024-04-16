using System;
using System.Globalization;
using System.Text.Json.Nodes;

namespace StringManipulationDemos
{
    public partial class Module09
    {
        public static void ParsingOtherTypes()
        {
            Console.Clear();

            // Enum

            var data = new []
            {
                "Monday",
                "November",
                "SATURDAY"
            };

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");
                // parse to enum

                Console.WriteLine(Enum.TryParse(typeof(DayOfWeek), item, true, out var dateOfWeek) ? $"{(DayOfWeek)dateOfWeek}" : "skipped");
            }
            
            // Char

            const string aLetterString = "A";

            Console.WriteLine(char.TryParse(aLetterString, out var charLetter)? $"{charLetter}": "skipped");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}