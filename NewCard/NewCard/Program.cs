using System;
using System.IO;

namespace NewCard
{
    class Program
    {
        static void Main(string[] args)
        {
            // find out how many times program should add cards
            Console.WriteLine("How many cards should be configured? 8 is max number");
            string cards = Console.ReadLine();

            // convert string cards to int for loop
            int times = 0;
            Int32.TryParse(cards, out times);

            for (int i = 0; i < times; i++)
            {
                // Define new card
                Console.WriteLine("Present card");

                // Add new card as string
                string accesscard = Console.ReadLine();

                // Write data from card to file
                FileStream f = new FileStream("D:\\visualstudio projekter\\AccessControl\\AccessControl\\cards.txt", FileMode.Append);

                //declared stream writer
                StreamWriter s = new StreamWriter(f);

                Console.WriteLine("Writing data to file");

                s.WriteLine(accesscard);

                //closing stream writer
                s.Close();
                f.Close();

                // Finished
                Console.WriteLine("Data written to file");
            }
        }
    }
}