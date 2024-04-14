using System;

namespace StringManipulationDemos
{
    public partial class Module04
    {
        public static void ReadOnlySpan()
        {
            Console.Clear();

            var data = new[]
            {
                "Make: Ford, Model: Fiesta",
                "make: Punto",
                "Ferrari f40, car",
                "1. ford"
            };

            ReadOnlySpan<char> makeSpan = new[] { 'm', 'a', 'k', 'e' };

            foreach (var entry in data)
            {
                Console.WriteLine(entry);

                var entrySpan = entry.AsSpan(); // create a read-only span over the string's memory.

                var isValid = entrySpan.Slice(0, makeSpan.Length).SequenceEqual(makeSpan);
                Console.WriteLine(isValid ? "VALID" : "INVALID");
                
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}