using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define access giving card
            string accesscard = "1606860297";

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
        }
    }
}