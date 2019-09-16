using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Final
{
    // Maze is conceptualized of 3 columns with 5 spaces each. Player starts in the middle and can move around the maze until they find the correct
    // room which will lead to the exit. Will use mainly switch statements to handle the calling of functions as well as data validation. 
    // I know this doesn't necessarily completely follow the process you outlined on github but I was somewhat confused regarding keeping track of positioning 
    // and how to implement a "face north/south/west/east" system. 
    // Conor Reed itse1430
    class Program
    {
        static void Main ( string[] args )
        {
            gameTitle();
        }

        static void gameTitle()
        {
            string choice;
            Console.WriteLine(" -----------------------------------");
            Console.WriteLine(" ---- Welcome to the Maze Game! ----");
            Console.WriteLine(" ---- Press '1' to Begin!       ----");
            Console.WriteLine(" ---- Press '2' to Quit!        ----");
            Console.WriteLine(" -----------------------------------");
            Console.Write(" ---- Enter '1' or '2':  ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        gameStart();
                        break;
                    }
                case "2":
                    {
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You have not entered a valid input, please try again and enter a '1' or a '2'");
                        Console.ReadLine();
                        gameTitle();
                    }
            }

        }

        static void gameStart()
        {

        }

        static void gameWon()
        {
        }

        static void gameQuit()
        {
        }

        static void gameMiddle2()
        {
        }

        static void gameMiddle3()
        {
        }

        static void gameMiddle4()
        {
        }

        static void gameMiddle5()
        {
        }

        static void gameLeft1()
        {
        }

        static void gameLeft2()
        {
        }

        static void gameLeft3()
        {
        }

        static void gameLeft4()
        {
        }

        static void gameLeft5()
        {
        }

        static void gameRight1()
        {
        }

        static void gameRight2()
        {
        }

        static void gameRight3()
        {
        }

        static void gameRight4()
        {
        }

        static void gameRight5()
        {
        }
    }
}
