using System;

namespace loopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
          int klaava = 0;
          int kruuna = 0;
          int heitot = 0;


            Random kolikonheitto = new Random();

            Console.WriteLine("Heitä kolikkoa!");
            Console.WriteLine("Kerro ohjelmalle heittojen määrä!:");
            heitot = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < heitot; i++)
            {
                int heitto = kolikonheitto.Next(1, 3);

                    if (heitto == 1)
                
                           kruuna++;
                
                else
                
                    klaava++;
                
            }

                             Console.WriteLine("Heittoja:" + heitot +  kruuna + " kruunaa ja " + klaava + " klaavaa.");

        }
    }
}
