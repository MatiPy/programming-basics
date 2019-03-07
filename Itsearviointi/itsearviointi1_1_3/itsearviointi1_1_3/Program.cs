using System;

namespace itsearviointi1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[50];
            string lause = "";
            int laskuri = 0;
            int summa = 0;



            Console.WriteLine("Anna ohjelmalle lukuja, ohjelma tulostaa näytölle syötettyjen lukujen summan! -1 keskeyttää ohjelman");

            lause = Console.ReadLine();

            while (true)
            {
                taulukko[laskuri] = Convert.ToInt32(Console.ReadLine());
                if (taulukko[laskuri] == -1)
                    break;

                laskuri++;


            }

            for (int i = 0; i < laskuri; i++)
            {
                summa += taulukko[i];
                Console.WriteLine(taulukko[i]);
            }

            Console.WriteLine("lukujen summa on:" + summa );

        }
    }
}