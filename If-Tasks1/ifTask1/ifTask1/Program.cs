using System;

namespace ifTask1
{
    class Program

        //oneline comment

        /*multiline 
         * int
         * String
         * double
         * bool
         * char
         * 
         * comment     
         */
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku " + 
                "positiivinen, " +
                "negatiivinen vai nolla.");

            Console.Write("Syötä luku:");
            String userInput = Console.ReadLine();

            Console.WriteLine($"Syötit luvun: {userInput}");
                int number = int.Parse(userInput);

            if (number == 0)
                Console.WriteLine($"Numero {number} on nolla!");  //tulostaa käyttäjälle että numero on 0!
            else if (number<0)
                Console.WriteLine($"Numero {number} on negatiivinen!"); //tulostaa käyttäjälle että numero on negatiivinen!
            else 
                Console.WriteLine($"Numero {number} on positiivinen!"); //tulostaa käyttäjälle että numero on positiivinen!









        }
    }
}
