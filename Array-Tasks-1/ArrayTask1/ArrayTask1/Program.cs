using System;

namespace ArrayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma alustaa kokonaisluku taulukon(10 alkiota) johon arvotaan lukuja 0....100");
            int[] numbers = new int[10];
            Random rnd = new Random();
          
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
            }
         

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine("ohjelma päättyy");

        }

    }
}
