using System;

namespace HelloWorld
{
    class Program
    {
        static char Main ( /*string[] args*/ )
        {
          // movie data
          string title;
            int runLength;
            int releaseYear;
            string description;
            bool haveSeen;

            DisplayMenu ();
        }

        static char DisplayMenu ()
        {
            do
            {
                 Console.WriteLine("A)dd Movie");
                 Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
            if (input == "A")
            {
                    return 'A';
            } else if (input == "Q")
            {
                    return 'Q';
            } else
            {
                Console.WriteLine("Invalid Input");
            }

            } while(true);
           
           
        }           

   
        
        
    }
}
