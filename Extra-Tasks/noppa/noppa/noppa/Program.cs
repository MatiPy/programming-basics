using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int satunnainen1 = rng.Next(1, 6);
            Double satunnainen2 = rng.NextDouble();
            Console.WriteLine("Int: " + satunnainen1);
            Console.WriteLine("Double: " + satunnainen2);

            switch(satunnainen1)
            {
                case 1:
                    Console.WriteLine("satunnainen oli yksi !");
                    break;

                case 2:
                    Console.WriteLine("satunnainen oli kaksi !");
                    break;

                case 3:
                    Console.WriteLine("satunnainen oli kolme !");
                    break;

                case 4:
                    Console.WriteLine("satunnainen oli neljä !");
                    break;


                case 5:
                    Console.WriteLine("satunnainen oli viisi !");
                    break;

                default:
                    Console.WriteLine("satunnainen oli jotain muuta kuin 1-5 !");
                    break;
            }
        }
    }
}
