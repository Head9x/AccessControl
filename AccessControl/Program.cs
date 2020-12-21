using System;
using System.IO;

namespace AccessControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read card.txt to find accesscard number
            FileStream f = new FileStream("D:\\visualstudio projekter\\AccessControl\\AccessControl\\cards.txt", FileMode.OpenOrCreate);

            //declared stream reader
            StreamReader sr = new StreamReader(f);

            string accesscard = sr.ReadLine();
            string accesscard1 = sr.ReadLine();
            string accesscard2 = sr.ReadLine();
            string accesscard3 = sr.ReadLine();
            string accesscard4 = sr.ReadLine();
            string accesscard5 = sr.ReadLine();
            string accesscard6 = sr.ReadLine();
            string accesscard7 = sr.ReadLine();
            string accesscard8 = sr.ReadLine();

            //closing stream writer
            sr.Close();
            f.Close();

// Looping code            
Loop:
            // Present card to reader
            Console.WriteLine("Present card:");

            // Create a string storing card info
            string presentedCard = Console.ReadLine();

            // Check compare string with card list made by NewCard program
            if (presentedCard == accesscard || presentedCard == accesscard1 || presentedCard == accesscard2 || presentedCard == accesscard3 || presentedCard == accesscard4 || presentedCard == accesscard5 || presentedCard == accesscard6 || presentedCard == accesscard7)
            {
                Console.WriteLine("Card Accepted");

            }
            else
            {
                Console.WriteLine("Card Denied");

            };
            goto Loop;
        }
    }
}