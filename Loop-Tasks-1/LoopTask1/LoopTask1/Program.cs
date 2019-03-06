using System;

namespace loopTask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskeee annetun luvun kertoman");
            
            int number = 0;
            int i = 1;
            int fact = 1;
            do
            {


                Console.Write("syötä luku:");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);


                if (number <= 0)
                {
                    Console.WriteLine("virheellinen syöte!");
                }
            } while (number <= 0);
                                                                                         //calculate factorial 1 * 2 * 3 * ... * n
                while (i <= number)
                {
                fact = fact * i;    //fact*=i
                i = i + 1;         //i++;

                }

                Console.WriteLine($"Luvun {number} ! = {fact}");

                                                                                                /*
                                                                                                 * for (i = 1; i <=; i++)
                                                                                                 * {
                                                                                                 *      fact * = i;
                                                                                                 * }
                                                                                                 * */
     
      

        }
    }
}
