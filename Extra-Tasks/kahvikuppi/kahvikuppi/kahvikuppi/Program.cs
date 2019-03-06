using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kahvikuppi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kahvin koot: 1=pieni 2= keskikokoinen 3= iso");
            Console.Write("Syötä valintasi:");
            String valinta = Console.ReadLine();
            int hinta = 0;

            switch (valinta)
            {
                case "1":
                case "pieni":
                    hinta += 25;
                    break;

                case "2":
                case "keskikokoinen":
                    hinta += 25;
                    goto case "1";

                case "3":
                case "iso":
                    hinta = +50;
                    goto case "1";

                    default:
                    Console.WriteLine("Virheellinen valinta, valitse 1,2 tai 3");
                    break;

             }
                    if (hinta !=0)
            {
                Console.WriteLine("Syötä " + hinta + "senttiä");
           }

            Console.WriteLine("Kiitos asioinnistasi!");







        }
    }
}
