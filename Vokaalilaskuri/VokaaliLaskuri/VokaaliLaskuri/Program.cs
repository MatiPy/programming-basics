using System;

namespace VokaaliLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on vokaalilaskuri-ohjelma!\n");
            Console.WriteLine("Anna ohjelmalle viesti, ohjelma laskee vokaaleiden määrän\n");

            string message = UserInput();
            Console.WriteLine($"Viestissäsi: {message} oli yhteensä {VCalc(message)} vokaalia!\n");
        }
        static string UserInput()
        {
            Console.Write("Syötä ohjelmalle viestisi:\n"); string userInput = Console.ReadLine(); return userInput;
        }
        static int VCalc(string usermessage)
        {
            usermessage = usermessage.ToLower(); int count = 0;
            for (int i = 0; i < usermessage.Length; i++)
            {
                if (usermessage[i] == 'a' ||
                    usermessage[i] == 'e' ||
                    usermessage[i] == 'i' ||
                    usermessage[i] == 'o' ||
                    usermessage[i] == 'u' ||
                    usermessage[i] == 'y' ||
                    usermessage[i] == 'ä' ||
                    usermessage[i] == 'ö')
                {
                    count++;
                }
            }
            return count;

        }
    }
}
