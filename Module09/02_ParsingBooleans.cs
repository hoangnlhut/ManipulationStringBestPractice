using System;

namespace StringManipulationDemos
{
    public partial class Module09
    {
        public static void ParsingBooleans()
        {
            Console.Clear();

            var data = new[]
            {
                "true",
                "false",
                "TRUE",
                "Not true",
                null
            };

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");

                try
                {
                    var boolValue = bool.Parse(item);
                    Console.WriteLine(boolValue);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input to conversion to bool type");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("null value");
                }
            }

            Console.WriteLine();

            foreach (var item in data)
            {
                var result = bool.TryParse(item, out var booleanResult) ? $"{booleanResult}" : "skipped";
                Console.WriteLine($"{item} is {result}");
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}