using System;

namespace itsearviointi1_1_2
{
    class Program
    {

        static void Main(string[] args)
        {

            string lause = "";



            Console.WriteLine("Ohjelma tulostaa käyttäjän syötteen  kirjainten lukumääärien perusteella");

            lause = Console.ReadLine();
            Console.WriteLine("-------------------");

            for (int i = 0; i < lause.Length; i++)
            {
                Console.WriteLine(lause);

            }

        }


    }
}