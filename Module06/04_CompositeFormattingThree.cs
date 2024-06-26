using System;
using System.Collections.Generic;

namespace StringManipulationDemos
{
    public partial class Module06
    {
        public static void CompositeFormattingThree()
        {
            Console.Clear();
            
            var qualifyingTimes = new Dictionary<string, TimeSpan>
            {
                {"Damon Hill", new TimeSpan(0, 0, 1, 26, 875)},
                {"Jacques Villeneuve", new TimeSpan(0, 0, 1, 27, 070)},
                {"Michael Schumacher", new TimeSpan(0, 0, 1, 27, 707)}
            };
            
            Console.WriteLine("{0,-20}{1,10}", "Driver", "Lap Time");
            Console.WriteLine();

            foreach (var result in qualifyingTimes)
            {
                Console.WriteLine("{0,-20}{1,10:mm\\:ss\\.fff}", result.Key, result.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}