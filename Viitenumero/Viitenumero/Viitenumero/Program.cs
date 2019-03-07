using System;

class Program
{
    static void Main(string[] args)
    {
        string givenRfcNbr = "";
        string rfcNbr = "";
        do
        {
            Console.WriteLine("--------------Kotimainen viitenumero--------------------------------");
            Console.WriteLine("Kerro ohjelmalle mitä haluat tehdä valitse vaihtoehto 1 tai 2: \n--------------------------------------------------------------------");
            Console.WriteLine($"1. Haluan tarkastaa kotimaisen viitenumeron");
            Console.WriteLine($"2. Haluan luoda kotimaisen viitenumeron");
            bool isNumber = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int caseSwitch);
            if (isNumber)
            {
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Anna ohjelmalle viitenumero");
                        rfcNbr = Console.ReadLine();

                        string output = rfcNbr.Substring(rfcNbr.Length - 1, 1); Console.WriteLine($"{output}");
                        string alkuosa = rfcNbr.Substring(0, rfcNbr.Length - 1); Console.WriteLine($"{alkuosa}");
                        string output2 = Hash(alkuosa); if (output == output2.Substring(output2.Length - 1, 1))
                            Console.WriteLine("Viitenumero on oikein");
                    else
                            Console.WriteLine("Viitenumero on virheellinen"); break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Syötä viitenumeron alkuosa");  
                        
                        rfcNbr = Console.ReadLine();
                        Console.WriteLine($"{Hash(givenRfcNbr)}");
                        Console.WriteLine("Viitenumero luotu"); break;
                }
            }
        } while (true);
    }
    static void Delay()
    {
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public static string Hash(string alku)
    {
        int sum = 0;
        var stress = new int[] { 7, 3, 1 };
        int indx = 0;
        for (int c = alku.Length - 1; c >= 0; c--)
        {
            sum += stress[indx++] * int.Parse(alku.Substring(c, 1));
            if (indx >= stress.Length)
            {
                indx = 0;
            }
        }
        return alku + ((10 - sum % 10) % 10).ToString();
    }
    
}
