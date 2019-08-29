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

            while (true)
            {  
            char input = DisplayMenu ();
            if (input == 'A')
                AddMove();
            else if (input == 'Q')
              break;  
            };
          

        }

        static char DisplayMenu ()
        {
            do
            {
                 Console.WriteLine("A)dd Movie");
                 Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
            if (input == "A" || input == "a")
            {
                    return 'A';
            } else if (input == "Q" || input == "q")
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
