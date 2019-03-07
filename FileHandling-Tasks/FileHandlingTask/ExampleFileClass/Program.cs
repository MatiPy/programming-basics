using System;
using System.IO;
namespace ExampleFileClass
{
    class Program
    {
        static void Main()
        {
            // Read in every line in specified file.
            // ... This will store all lines in an array in memory.
            string[] lines = File.ReadAllLines(@"C:\TEMP\TESTI.DAT");
            foreach (string line in lines)
            {
                // Do something with the line.
                if (line.Length > 80)
                {
                    // Important code.
                }
            }
        }

    }
}