using System;

namespace loopTask4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random noppa = new Random();
                 int summa;
                 int[] numero = new int[6];

            Console.WriteLine("Nopanheittoa");
            Console.Write("Ohjelma kertoo kuinkamonta kertaa kuutonen heitettiin tuhannesta heitosta");

                    for (int i = 1; i <= 1000; i++)
                    {
                        summa = noppa.Next(6);
                        numero[summa]++;

                             Console.Write($"{i}.  {summa + 1}\n ");
                    }

            Console.Write($"Kuutonen heitettiin {numero [5]} kertaa.\n");
        }
    }
}






