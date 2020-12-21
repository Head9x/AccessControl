using System;
using System.IO;

namespace AccessControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read card.txt to find accesscard number
            FileStream f = new FileStream("D:\\visualstudio projekter\\AccessControl\\AccessControl\\card.txt", FileMode.OpenOrCreate);

            //declared stream reader
            StreamReader sr = new StreamReader(f);

            string accesscard = sr.ReadLine();

            //closing stream writer
            sr.Close();
            f.Close();

// Looping code            
Loop:
            // Present card to reader
            Console.WriteLine("Present card:");

            // Create a string storing card info
            string presentedCard = Console.ReadLine();

            // Check compare string with card number defined earlier
            if (presentedCard == accesscard)
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