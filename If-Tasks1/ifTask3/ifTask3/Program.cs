using System;

namespace ifTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku " + "positiivinen, " +
                "negatiivinen, " + "pariton, " + "parillinen vai nolla.");
            Console.Write("Syötä numero:");

            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"Luku {number} on parillinen!");            

                else
                    Console.WriteLine($"luku {number} on pariton!");
            }    

            if (isNumber)
            {
                if (number % 2 == -1)
                    Console.WriteLine($"luku {number} on pariton" + $"luku { number}  sekä negatiivinen"  ); 


                           
            }


            else
                Console.WriteLine("Väärä Syöte!");















        }
    }
}
