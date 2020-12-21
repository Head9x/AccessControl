using System;
using System.IO;

namespace NewCard
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define new card
            Console.WriteLine("Present card");

            // Add new card as string
            string accesscard = Console.ReadLine();

            // Write data from card to file
            FileStream f = new FileStream("D:\\visualstudio projekter\\AccessControl\\AccessControl\\card.txt", FileMode.OpenOrCreate);

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