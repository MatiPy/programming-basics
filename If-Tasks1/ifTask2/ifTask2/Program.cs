using System;

namespace ifTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku pariton vai parillinen");
            Console.Write("Syötä numero:");

            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"Luku {number} on parillinen!");             //vanhempi tapa:             
                                                                                    //Console.WriteLine("Luku " + number + " on parillinen!"); vaihtoehtoinen tapa 

                else
                    Console.WriteLine($"luku {number} on pariton!");
            }
            else
                Console.WriteLine("Väärä Syöte!");

        



            









        }
    }
}
