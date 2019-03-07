using System;

namespace itsearviointi1_1_1
{
    class Program
    {

        static void Main(string[] args)
        {

            string lause = "";



            Console.WriteLine("Ohjelma tulostaa käyttäjän syötteen viisinkertaisena ");

            lause = Console.ReadLine();
            Console.WriteLine("-------------------");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(lause);

            }

        }


    }
}