using System;

namespace StringTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma laskee käyttäjän lauseesta L kirjaimet");
            string lause = Console.ReadLine();

                int count = 0;
                while (count < lause.Length && lause[count] == '$')
                count++;


        }
    }
}
