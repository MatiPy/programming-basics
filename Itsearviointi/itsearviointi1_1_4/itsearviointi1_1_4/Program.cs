using System;

namespace itsearviointi1_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa;
            double erotus;
            double kerto;
            double jako;
            double userInput1;
            double userInput2;

            Console.WriteLine("Syötä ohjelmalle kaksi lukua ohjelma tulostaa lukujen yhteen, vähennys, kerto ja jakolaskut");

            userInput1 = Convert.ToDouble(Console.ReadLine());  
            userInput2 = Convert.ToDouble(Console.ReadLine());

            summa = userInput1 + userInput2;
            erotus = userInput1 - userInput2;
            kerto = userInput1 * userInput2;
            jako = userInput1 / userInput2;

            Console.WriteLine(userInput1 + "+" + userInput2 + "=" + summa);
            Console.WriteLine(userInput1 + "-" + userInput2 + "=" + erotus);
            Console.WriteLine(userInput1 + "*" + userInput2 + "=" + kerto);
            Console.WriteLine(userInput1 + "/" + userInput2 + "=" + jako);

           
        }
    }
}
