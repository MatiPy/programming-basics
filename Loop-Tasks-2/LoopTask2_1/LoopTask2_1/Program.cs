using System;

namespace loopTask4_1
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Random rnd = new Random();                                                           // Luodaan uusi ilmentymä rnd oliosta Random.
            int rndNumber;                                                                      // metodi arpoo luvun 0...1 väliltä ---> 
            


            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret");
            Console.WriteLine("#\tRND     SQRT");                                                        /* \t --> tab
                                                                                                             \n --> uusirivi */

            for (int i = 0; i < 10; i++)                                                                       // for sanan jälkeen tab -> for (int i = 0; i < 10; i++)
            {
                rndNumber = rnd.Next(2, 10);
                Console.WriteLine($"{i + 1}.\t {rndNumber}.\t{Math.Sqrt(rndNumber)}");
            }



            //int i = 0;
            //while (1<10)
            //{
            //    rndNumber = rnd.Next(2, 10);
            //    Console.WriteLine($"{i + 1}.\t {rndNumber}.\t{Math.Sqrt(rndNumber)}");
            //    i = i + 1; //i++
            //                                                                                                   // ctrl+k+c muokkaa kommentiksi
            //}                                                                                                 // ctrl+k+u palauttaa


        }
    }
}
