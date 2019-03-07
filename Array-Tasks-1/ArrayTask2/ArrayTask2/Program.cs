using System;
using System.Globalization;
namespace ArrayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //CultureInfo culture = new CultureInfo("sv-SV");
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("ohjelma alustaa kokonaisluku taulukon(10 alkiota) johon arvotaan lukuja 0....50");
            int[] iT = new int[100];
            Random rnd = new Random();
           
          
            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(50);
            }
         

            for (int i = 0; i < iT.Length; i++)
            {

                 int Sum(params int[] iT)
                {
                    int result = 0;

                    for (int i = 0; i < iT.Length; i++)
                    {
                        result += iT[i];
                    }

                    return result;
                }

                
                    decimal Average(params int[] iT)
                { 
                    int sum = Sum(iT);
                    decimal keskiarvo = Average(iT);
                    decimal result = (decimal)sum / iT.Length;
                    return result;
                }

            }


            Console.WriteLine("ohjelma päättyy");
        }
    }
}
