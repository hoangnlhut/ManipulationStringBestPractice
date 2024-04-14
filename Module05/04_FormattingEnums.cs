using System;

namespace StringManipulationDemos
{
    public partial class Module05
    {
        public enum Status { Red = 1, Yellow = 2, Green = 3 }

        public static void FormattingEnums()
        {
            Console.Clear();
            
            var status = Status.Yellow;
            
            Console.WriteLine(status.ToString());
            Console.WriteLine(status.ToString("G")); //general form
            Console.WriteLine(status.ToString("D")); 
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(); 
        }
    }
}