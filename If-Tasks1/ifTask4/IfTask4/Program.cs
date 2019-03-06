using System;

namespace iftask1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä ohjelmalle kolme erillaista lukua, ohjelma lajittelee numerot nousevaan järjestykseen");

            Console.Write("Syötä ensimmäinen luku: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Syötä kolmas luku: ");
            int c = Convert.ToInt32(Console.ReadLine());

            string output;

            if (a <  b)
            {
                if (b < c)
                {
                    output = ($"{a} --->{b}---> {c}");
                   
                } 
                 else if (a < c)
                {
                      output = string.Format("{0}, {1}, {2}", a, c, b);
                }
                else
                {
                         output = string.Format("{0}, {1}, {2}", c, a, b);
                }
            }
            else
            {
                  if (a < c)
                {
                        output = string.Format("{0}, {1}, {2}", b, a, c);
                }
                         else if (b < c)
                {
                    output = string.Format("{0}, {1}, {2}", b, c, a);
                }
                else
                {
                    output = string.Format("{0}, {1}, {2}", c, b, a);
                }
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
