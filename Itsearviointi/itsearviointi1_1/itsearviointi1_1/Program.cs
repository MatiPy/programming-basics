using System;

namespace itsearviointi1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma toistaa käyttäjän kirjoittaman lauseen viisinkertaisesti");
            Console.WriteLine("Kirjoita ohjelmalle lause!");

            int n;
            int userInput;

            


            while (true)
            {
                Console.WriteLine("lauseesi:");
                n = int.Parse(Console.ReadLine());
                // string userInput = Console.ReadLine();
                // number = int.TryParse(userInput);

                if (n >= 5)
                {

                    Console.WriteLine(Console.ReadKey());


                }
                else 
                {
                    //Console.WriteLine(Console.ReadKey());
                    break;
                }
                {
                  
                    Console.WriteLine(n);
                }
            


            }
        }
    }
}
