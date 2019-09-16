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
                        break;
                    }
            }

        }

        static void gameStart()
        {
            string choice;
            Console.WriteLine("You awaken and find yourself laying in a strange room");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left and right");
            Console.WriteLine("behind you there is nothing but a wall made of concrete.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Go into the room on your right ");
            Console.WriteLine("4.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameMiddle2();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameLeft1();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameRight1();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-4)");
                        Console.ReadLine();
                        gameStart();
                        break;
                    }
            }

        }

        static void gameWon()
        {
            Console.Clear();
            Console.WriteLine("-------------------CONGRATULATIONS!!!!-------------------");
            Console.WriteLine("-------------------YOU WIN!!!!---------------------------");
            Console.WriteLine("-------------------THANKS FOR PLAYING--------------------");
            Console.WriteLine("-------------------Press any key return to start---------");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        static void gameQuit()
        {
            string choice;
            Console.Clear();
            Console.WriteLine("Are you sure you want to quit?");
            Console.WriteLine("1.) Yes ");
            Console.WriteLine("2.) No (Return to title screen) ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        Environment.Exit(0);
                        break;
                    }
                case "2":
                    {
                        gameTitle();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please give a valid input 1 or 2");
                        Console.WriteLine("Press Enter to try again ");
                        Console.ReadLine();
                        gameQuit();
                        break;
                    }
            }
            

        }
        static void gameMiddle1()
        {
            string choice;
            Console.WriteLine("You find yourself back in the strange room that you woke up in");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left and right");
            Console.WriteLine("behind you there is nothing but a wall made of concrete.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Go into the room on your right ");
            Console.WriteLine("4.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameMiddle2();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameLeft1();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameRight1();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-4)");
                        Console.ReadLine();
                        gameStart();
                        break;
                    }
            }

        }

        static void gameMiddle2() 
        {
            string choice;
            Console.WriteLine("You approach a sturdy looking metal door and enter a new room.");
            Console.WriteLine("This room looks like it was cleaned recently, but there is nothing of any note inside.");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left and right");
            Console.WriteLine("behind you is the room you started in");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Go into the room on your right ");
            Console.WriteLine("4.) Turn around and go back to the room behind you ");
            Console.WriteLine("5.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameMiddle3();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameLeft2();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameRight2();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameMiddle1();
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-5)");
                        Console.ReadLine();
                        gameMiddle2();
                        break;
                    }
            }
        }

        static void gameMiddle3() 
        {
            string choice;
            Console.WriteLine("You enter a room and notice a creepy mannequin in the center. It feels as though it's eyes follow your own");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left and right");
            Console.WriteLine("behind you there is another room");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Go into the room on your right ");
            Console.WriteLine("4.) Turn around and go back to the room behind you ");
            Console.WriteLine("5.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameMiddle4();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameLeft3();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameRight3();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameMiddle2();
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-5)");
                        Console.ReadLine();
                        gameMiddle3();
                        break;
                    }
            }
        }

        static void gameMiddle4() 
        {
            string choice;
            Console.WriteLine("You enter a room that is in serious need of remodeling. ");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left and right");
            Console.WriteLine("behind you there is another room");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Go into the room on your right ");
            Console.WriteLine("4.) Turn around and go back to the room behind you ");
            Console.WriteLine("5.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameMiddle5();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameLeft4();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameRight4();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameMiddle3();
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-5)");
                        Console.ReadLine();
                        gameMiddle4();
                        break;
                    }
            }
        }

        static void gameMiddle5()
        {
            string choice;
            Console.WriteLine("You enter a room and are immediately drawn to a golden rope that leads to a trapdoor on the ceiling");
            Console.WriteLine("Looking around you see a concrete wall in front of you");
            Console.WriteLine("as well as a room on your left and right");
            Console.WriteLine("behind you there is another room");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward and climb the rope ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Go into the room on your right ");
            Console.WriteLine("4.) Turn around and go back to the room behind you ");
            Console.WriteLine("5.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You struggle to climb the rope but eventually make it to sweet freedom.");
                        gameWon();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameLeft5();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameRight5();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameMiddle4();
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-5)");
                        Console.ReadLine();
                        gameMiddle5();
                        break;
                    }
            }
        }

        static void gameLeft1() 
        {
            string choice;
            Console.WriteLine("You find yourself in an odd room that is filled with cheezits");
            Console.WriteLine("They look quite tasty, but you don't think they will help you out of the maze.");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your right, theres nothing but wall to your left");
            Console.WriteLine("behind you there is nothing but a wall made of concrete.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your right ");
            Console.WriteLine("3.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameLeft2();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameMiddle1();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-3)");
                        Console.ReadLine();
                        gameLeft1();
                        break;
                    }
            }
        }

        static void gameLeft2() 
        {
            string choice;
            Console.WriteLine("You find yourself in a room filled with puppies.");
            Console.WriteLine("You play with them for some time but you yearn to escape this maze so begin to observe your surroundings.");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your right, but nothing but wall to your left");
            Console.WriteLine("behind you is another hallway to a different room.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your right ");
            Console.WriteLine("3.) Turn around and go back to the room behind you ");
            Console.WriteLine("4.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameLeft3();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameMiddle2();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameLeft1();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-4)");
                        Console.ReadLine();
                        gameLeft2();
                        break;
                    }
            }
        }

        static void gameLeft3() 
        {
            string choice;
            Console.WriteLine("You enter the room and find yourself surrounded by miley cyrus posters, you should leave ASAP");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your right, but nothing but wall to your left");
            Console.WriteLine("behind you is another hallway to a different room.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your right ");
            Console.WriteLine("3.) Turn around and go back to the room behind you ");
            Console.WriteLine("4.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameLeft4();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameMiddle3();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameLeft2();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-4)");
                        Console.ReadLine();
                        gameLeft3();
                        break;
                    }
            }
        }

        static void gameLeft4() 
        {
            string choice;
            Console.WriteLine("You enter the room only to find a sleeping goblin, you make sure to be silent as not to wake him.");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your right, but nothing but wall to your left");
            Console.WriteLine("behind you is another hallway to a different room.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your right ");
            Console.WriteLine("3.) Turn around and go back to the room behind you ");
            Console.WriteLine("4.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameLeft5();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameMiddle4();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameLeft3();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-4)");
                        Console.ReadLine();
                        gameLeft4();
                        break;
                    }
            }
        }

        static void gameLeft5() 
        {
            string choice;
            Console.WriteLine("You find yourself at the end of a long hallway, curiously enough, there is an arrow pointing to your right.");
            Console.WriteLine("It would seem it would be smart to head to the door on the right.");
            Console.WriteLine("There is nothing but solid concrete in front and to your left.");
            Console.WriteLine("Your only options are to go back or to the right. ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Go into the room on your right ");
            Console.WriteLine("2.) Turn around and go back to the room behind you ");
            Console.WriteLine("3.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move into the room on your right with a tingle in your spine");
                        gameMiddle5();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameLeft4();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-3)");
                        Console.ReadLine();
                        gameLeft5();
                        break;
                    }
            }
        }

        static void gameRight1() 
        {
            string choice;
            Console.WriteLine("You find yourself in a room filled with golf balls");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left");
            Console.WriteLine("behind you and to your right there is nothing but a wall made of concrete.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameRight2();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameMiddle1();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-3)");
                        Console.ReadLine();
                        gameRight1();
                        break;
                    }
            }
        }

        static void gameRight2() 
        {
            string choice;
            Console.WriteLine("You find yourself in a room filled with unfinished math equations. Curious.");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left, but a wall to your right");
            Console.WriteLine("behind you is the another hallway");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Turn around and go back to the room behind you ");
            Console.WriteLine("4.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameRight3();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameMiddle2();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameRight1();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-4)");
                        gameRight2();
                        break;
                    }
            }
        }

        static void gameRight3() 
        {
            string choice;
            Console.WriteLine("You find yourself in a room that has a cash register in the center. Intriguing. ");
            Console.WriteLine("However you open the register to find that it is empty. Pity");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left, but a wall to your right");
            Console.WriteLine("behind you is the another hallway");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Turn around and go back to the room behind you ");
            Console.WriteLine("4.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameRight4();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameMiddle3();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameRight2();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-4)");
                        gameRight3();
                        break;
                    }
            }
        }

        static void gameRight4() 
        {
            string choice;
            Console.WriteLine("You find yourself in a room filled with unfiled tax returns.");
            Console.WriteLine("Looking around you see a hallway in front of you");
            Console.WriteLine("as well as a room on your left, but a wall to your right");
            Console.WriteLine("behind you is the another hallway");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Move forward down the hallway ");
            Console.WriteLine("2.) Go into the room on your left ");
            Console.WriteLine("3.) Turn around and go back to the room behind you ");
            Console.WriteLine("4.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move forward down the hallway with a tingle in your spine");
                        gameRight5();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameMiddle4();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameRight3();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-4)");
                        gameRight4();
                        break;
                    }
            }
        }

        static void gameRight5() 
        {
            string choice;
            Console.WriteLine("You reach the end of the long hallway and notice a peculiar sign that points to the left.");
            Console.WriteLine("The only options are to go back to the room you came from or go to the left. ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.) Go into the room on your left ");
            Console.WriteLine("2.) Turn around and go back to the room behind you ");
            Console.WriteLine("3.) Go to sleep (Quit) ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You move into the room on your left with a tingle in your spine");
                        gameMiddle5();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You decide that you've gone the wrong way and go back to the room behind you");
                        gameRight4();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You decide that you've had enough of these shenanigans and want to go back to sleep");
                        gameQuit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That wasn't a valid input, press Enter to try again");
                        Console.WriteLine("(Valid Input is a number 1-3)");
                        gameRight5();
                        break;
                    }
            }
        }
    }
}
