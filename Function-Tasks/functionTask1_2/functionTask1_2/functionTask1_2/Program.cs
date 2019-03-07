using System;

namespace FunctionTask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Intro(out x, out y);
            Console.WriteLine(SmallerNumber(x, y));
        }

        static void Intro(out int number1, out int number2)
        {
            Console.WriteLine("Syötä ohjelmalle luku, funktio palauttaa arvonaan kahdesta annetusta luvusta pienemmän");
            Console.Write("syötä luku1:");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("syötä luku2:");
            number2 = int.Parse(Console.ReadLine());
        }

        static string SmallerNumber(int a, int b)
        {
            if (a == b)
                return $"Luku {a} on yhtäsuuri kuin {b}";
            else if (a < b)
                return $"luku {b} on isompi kuin {a}";
            else
                return $"luku {b} on pienempi kuin {a}";


        }
    }
}
