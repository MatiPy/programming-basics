using System;

namespace loopTask4_3
{
    class Program
    {


        static void Main(string[] args)
        {

            Random rnd = new Random();
            int rndNumber;

            Console.WriteLine("Ohjelma tulostaa 20 satunnaista lukua väliltä 0-50");
            Console.WriteLine();



            for (int i = 0; i <= 20; i++)

            {
                rndNumber = rnd.Next(0, 50);
                Console.WriteLine($"{i + 1)

            }

        }
    }
}