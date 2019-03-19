using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;


namespace Space_Project_Stephan
{
    class Game
    {
        public Game()
        {
            return; //default constructor
        }

        public void MainMenu()
        {

            int DA = 244; // 244
            int V = 212;
            int ID = 200;
            for (int i = 0; i <= 0 ; i++)
            {
                Console.WriteAscii("SPACE TRADER", Color.FromArgb(DA, V, ID));

                DA -= 18;
                V -= 36;
            } 



         



            Console.WriteLine("Press Enter to continue...", Color.SteelBlue);
            Console.ReadLine();
            Console.Clear();
        }
        public void OpeningDialogue()
        {
            Console.WriteLine("*****Hit enter to continue dialogue.*****\n", Color.SteelBlue);
            Console.WriteLine("You awaken in a cold, dark room...", Color.SteelBlue);
            Console.ReadLine();
            Console.WriteLine("A shrill voice pierces your ears", Color.SteelBlue);
            Console.WriteLine("\"You're awake, you're awake!\"", Color.HotPink);
            Console.ReadLine();
            Console.WriteLine("\"Quiet, Masha we don't know if we can trust this.... thing.\"", Color.Red);
            Console.ReadLine();
            Console.WriteLine("Masha replies", Color.SteelBlue);
            Console.WriteLine("\"Of course we can, Tork! We saved it, if it weren't for us it would still be floating in space.\"");
            Console.ReadLine();
            Console.WriteLine("Tork helps you up", Color.SteelBlue);
            Console.WriteLine("\"Who are you?\"");
            Console.ReadLine();

            Console.Clear();
            CharacterSelection();
        }

         public void CharacterSelection()
        {
            Console.WriteLine("Enter your name: ", Color.SteelBlue);
            string yourName;
            yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}, choose your race.", Color.SteelBlue);
            Console.WriteLine("1) Earthling", Color.SteelBlue);
            Console.WriteLine("2) Zipzorker", Color.SteelBlue);
            Console.WriteLine("3) Walltopian", Color.SteelBlue);
            var race = Console.ReadLine();

            Races races;
            races = new Races();

            switch (race)
            {
                case "1":
                case "Earthling":
                    {
                        Console.WriteLine("You have chosen Earthling.", Color.SteelBlue);
                        Console.ReadLine();
                        races.Earthling(); 
                        Console.WriteLine("Are you sure? Type Yes or No.", Color.SteelBlue);
                        var answer = Console.ReadLine();
                        if (answer == "Yes" || answer == "yes" || answer == "y")
                        {
                            Console.Clear();
                            IntroductionDialogue(yourName);
                            break;

                        }
                        else if (answer == "No" || answer == "no" || answer == "n")
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
                        races.ZipZorker();
                        Console.WriteLine("Are you sure? Type Yes or No.");
                        var answer = Console.ReadLine();
                        if (answer == "Yes" || answer == "yes" || answer == "y")
                        {
                            Console.Clear();
                            IntroductionDialogue(yourName);
                            break;
                        }
                        else if (answer == "No" || answer == "no" || answer == "n")
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
                        races.Walltopian();
                        Console.WriteLine("Are you sure? Type Yes or No.");
                        var answer = Console.ReadLine();
                        if (answer == "Yes" || answer == "yes" || answer == "y")
                        {
                            Console.Clear();
                            IntroductionDialogue(yourName);
                            break;
                        }
                        else if (answer == "No" || answer == "no" || answer == "n")
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

        public void IntroductionDialogue(string yourName)
        {
            Console.WriteLine($"Tork: \"Greetings {yourName}, welcome to the [ship name]!\"");
            Console.ReadLine();
            Console.WriteLine("Masha: \"I'm so happy we've found you... we need help.\"");
            Console.WriteLine("Tork: \"We don't need help, Masha! I've got this merchant business under control.\"");
            Console.WriteLine("Masha: \"Oh really, Tork? Do you remember what day it is?\"");
            Console.WriteLine("Tork begins to look flustered...");
            Console.ReadLine();
            Console.WriteLine("Masha: \"Tork has taken too many hits to the head, he has trouble with his memory... Not to mention he's a Walltopian.\"");
            // Add an if statement here, if the player is a zipzorker insert a negative response. 
            Console.WriteLine($"Masha: \"{yourName}, we picked you up just outside of Earth's atmosphere. Take a look at the map and help us choose what to do.\"");
            // This is where I want the user interface to start


        }
    }
}