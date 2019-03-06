using System;

namespace loopTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;
           
            Console.WriteLine("Ohjelma laskee parittomien ja parillisten lukujen summan!");
            Console.Write("syötä lukusi:");
            number = int.Parse(Console.ReadLine());
            
            while(i <= number)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i; 
                    
                }
                
                else
                {
                    oddSum = oddSum + i; 
                    

                }
                i++;
            }
            Console.WriteLine($"parillisten summa on {evenSum}");
            Console.WriteLine($"parittomien summa on {oddSum}");


        }
    }
}
