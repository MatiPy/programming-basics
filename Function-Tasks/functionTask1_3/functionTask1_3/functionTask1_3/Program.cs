using System;

namespace functionTask1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int retNumber = NumberFromRange(-10, 10);
            Console.Write($"syötit sallitun luvun {retNumber}");
        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {

            do
            {
                Console.WriteLine($"Syötä luku alueelta {lowerBound} ... {upperBound} ");
                string userInput = Console.ReadLine();
                int userNumber = int.Parse(userInput);


                if (userNumber >= lowerBound && userNumber <= upperBound)

                return userNumber;

                                                                                        //int userNumber = int.parse(userInput);
        
                else
                
                    Console.WriteLine("väärä syöte!");


            } while (true);


        }
    }

}