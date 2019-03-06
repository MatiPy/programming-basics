using System;

namespace loopTask4_2
{
    class Program
   
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tulostaa kertotaulun luvuille 1-9!");
            Console.Write("Aloita painamalla mitä tahansa näppäintä:");
            Console.ReadKey();
            for (int i = 1; i <= 9; i++)
                for (int j = 1; j <= 9; j++)
                    Console.WriteLine($"{i} x {j} = {i * j}");         
        
        }
    }
}
