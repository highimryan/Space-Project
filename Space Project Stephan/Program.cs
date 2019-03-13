using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Project_Stephan
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
            OpeningDialogue();
        }
        public static void MainMenu()
        {
            
            Console.WriteLine("000000  000000    0    000000  000000");
            Console.WriteLine("0       0    0   0 0   0       0     ");
            Console.WriteLine("000000  000000  00000  0       000000");
            Console.WriteLine("     0  0       0   0  0       0     ");
            Console.WriteLine("000000  0       0   0  000000  000000\n");
                


            Console.WriteLine("Hit any key to continue...");
            Console.ReadLine();
            Console.Clear();
         }
        public static void OpeningDialogue()
        {
            Console.WriteLine("*****Hit enter to continue dialogue.*****\n");
            Console.WriteLine("You awaken in a cold, dark room...");
            Console.ReadLine();
            Console.WriteLine("A shrill voice pierces your ears");
            Console.WriteLine("\"You're awake, you're awake!\"");
            Console.ReadLine();
            Console.WriteLine("\"Quiet, Masha we don't know if we can trust this.... thing.\"");
            Console.ReadLine();
            Console.WriteLine("Masha replies");
            Console.WriteLine("\"Of course we can, Tork! We saved it, if it weren't for us it would still be floating in space.\"");
            Console.ReadLine();
            Console.WriteLine("Tork helps you up");
            Console.WriteLine("\"Who are you?\"");
            Console.ReadLine();

            Console.Clear();
            CharacterSelection();
        }

        public static void CharacterSelection()
        {
            Console.WriteLine("Enter your name: ");
            var YourName = Console.ReadLine();
            Console.WriteLine($"Hello {YourName}, choose your race.");
            Console.WriteLine("1) Earthling");
            Console.WriteLine("2) Zipzorker");
            Console.WriteLine("3) Walltopian");
            var race = Console.ReadLine();

            switch (race)
            {
                case "1":
                case "Earthling":
                    {
                        Console.WriteLine("You have chosen Earthling.");
                        Console.ReadLine();
                        // Insert Description - 
                        Console.WriteLine("Are you sure? Type Yes or No.");
                        var answer = Console.ReadLine();
                        if (answer == "Yes")
                        {
                            //continue to next method
                        }
                        else if (answer == "No")
                        {
                            Console.Clear();
                            CharacterSelection();
                        }
                        else
                        {
                            Console.WriteLine("Please enter Yes or No");
                            Console.ReadLine();
                            Console.Clear();
                            CharacterSelection();
                        }
                        break;
                    }
                case "2":
                case "Zipzorker":
                    {
                        Console.WriteLine("You have chosen Zipzorker.");
                        Console.ReadLine();
                        // Insert Description - 
                        Console.WriteLine("Are you sure? Type Yes or No.");
                        var answer = Console.ReadLine();
                        if (answer == "Yes")
                        {
                            //continue to next method
                        }
                        else if (answer == "No")
                        {
                            Console.Clear();
                            CharacterSelection();
                        }
                        else
                        {
                            Console.WriteLine("Please enter Yes or No");
                            Console.ReadLine();
                            Console.Clear();
                            CharacterSelection();
                        }
                            break;
                    }
                case "3":
                case "Walltopian":
                    {
                        Console.WriteLine("You have chosen Walltopian.");
                        Console.ReadLine();
                        // Insert Description - 
                        Console.WriteLine("Are you sure? Type Yes or No.");
                        var answer = Console.ReadLine();
                        if (answer == "Yes")
                        {
                            //continue to next method
                        }
                        else if (answer == "No")
                        {
                            Console.Clear();
                            CharacterSelection();
                        }
                        else
                        {
                            Console.WriteLine("Please enter Yes or No");
                            Console.ReadLine();
                            Console.Clear();
                            CharacterSelection();
                        }
                            break;
                    }
                default:
                    {
                        Console.WriteLine("Your response was not valid, please try again.");
                        Console.WriteLine("Press 'ENTER' to try again");
                        Console.ReadLine();
                        Console.Clear();
                        CharacterSelection();
                        break;
                    }
            }

        }
    }
}
