using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace SpaceTrader
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

            for (int i = 0; i <= 0; i++)
            {
                Console.WriteAscii("SPACE TRADER", Color.FromArgb(DA, V, ID));

                DA -= 18;
                V -= 36;
            }

            Console.WriteLine("\n \t1. Start New Game\n \t2. Load Saved Game  ", Color.SteelBlue);
            var input = Console.ReadLine();

            switch (input)//Switch on Key enum
            {
                case "1":
                    {
                        NewGame();
                        break;
                    }
                case "2":
                    {
                        SavedGame();
                        break;
                    }
            }

            Console.ReadKey();
            Console.Clear();

        }

        public void NewGame()
        {
            OpeningDialogue();
        }

        public void SavedGame()
        {
            // For loading SavedGame
        }

        public void OpeningDialogue()
        {
            Console.Clear();
            string prompt = "Press any key to continue...";

            Console.WriteLine("You awaken in a cold, dark room...", Color.SteelBlue);
            UI.ElicitInput(prompt);

            Console.WriteLine("\nA shrill voice pierces your ears", Color.SteelBlue);
            Console.WriteLine("\"You're awake, you're awake!\"", Color.HotPink);
            UI.ElicitInput(prompt);

            Console.WriteLine("\"Quiet, Masha we don't know if we can trust this.... thing.\"", Color.Red);
            UI.ElicitInput(prompt);

            Console.WriteLine("Masha replies", Color.SteelBlue);
            Console.WriteLine("\"Of course we can, Tork! We saved it, if it weren't for us it would still be floating in space.\"", Color.HotPink);
            UI.ElicitInput(prompt);

            Console.WriteLine("Tork helps you up", Color.SteelBlue);
            Console.WriteLine("\"Who are you?\"", Color.Red);
            UI.ElicitInput(prompt);

            Console.Clear();

            CreateToon();
        }

        public void CreateToon() // Changed name from CharacterSelection to CreateToon
        {

            Console.WriteLine("Enter your name: ", Color.SteelBlue);
            string yourName = Console.ReadLine();

            Console.WriteLine($"Hello {yourName}, choose your race.", Color.SteelBlue);
            Console.WriteLine("\t1. Earthling", Color.SteelBlue);
            Console.WriteLine("\t2. Zipzorker", Color.SteelBlue);
            Console.WriteLine("\t3. Walltopian", Color.SteelBlue);
            var race = Console.ReadLine();

            Races races;
            races = new Races();

            switch (race)
            {
                case "1":
                    {
                        Console.WriteLine("You have chosen Earthling.", Color.SteelBlue);
                        Console.ReadLine();

                        races.Earthling();

                        Console.WriteLine("Are you sure? Hit y for yes or n for no.", Color.SteelBlue);
                        var answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            Console.Clear();
                            IntroductionDialogue(yourName);
                            break;
                        }
                        else if (answer == "n")
                        {
                            Console.Clear();
                            CreateToon();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter y or n.. Try again");
                            Console.ReadLine();
                            Console.Clear();
                            CreateToon();
                            break;
                        }

                    }
                case "2":
                    {
                        Console.WriteLine("You have chosen Zipzorker.", Color.SteelBlue);
                        Console.ReadLine();

                        races.ZipZorker();

                        Console.WriteLine("Are you sure? Hit y for yes or n for no.", Color.SteelBlue);
                        var answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            Console.Clear();
                            IntroductionDialogue(yourName);
                            break;
                        }
                        else if (answer == "n")
                        {
                            Console.Clear();
                            CreateToon();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter y or n.. Try again");
                            Console.ReadLine();
                            Console.Clear();
                            CreateToon();
                            break;
                        }

                    }
                case "3":
                    {
                        Console.WriteLine("You have chosen Walltopian.", Color.SteelBlue);
                        Console.ReadLine();

                        races.Walltopian();

                        Console.WriteLine("Are you sure? Hit y for yes or n for no.", Color.SteelBlue);
                        var answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            Console.Clear();
                            IntroductionDialogue(yourName);
                            break;
                        }
                        else if (answer == "n")
                        {
                            Console.Clear();
                            CreateToon();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter y or n... Try again");
                            Console.ReadLine();
                            Console.Clear();
                            CreateToon();
                            break;

                        }
                    } // Removed default on switch(race)
                      // added break to end of each case instead
            }
        }

        public void IntroductionDialogue(string yourName)
        {
            Console.WriteLine($"Tork: \"Greetings {yourName}, welcome to the [ship name]!\"", Color.Red);
            Console.ReadLine();
            Console.WriteLine("Masha: \"I'm so happy we've found you... we need help.\"", Color.HotPink);
            Console.WriteLine("Tork: \"We don't need help, Masha! I've got this merchant business under control.\"", Color.Red);
            Console.WriteLine("Masha: \"Oh really, Tork? Do you remember what day it is?\"", Color.HotPink);
            Console.WriteLine("Tork begins to look flustered...", Color.IndianRed);
            Console.ReadLine();
            Console.WriteLine("Masha: \"Tork has taken too many hits to the head, he has trouble with his memory... Not to mention he's a Walltopian.\"", Color.HotPink);
            // Add an if statement here, if the player is a zipzorker insert a negative response. 
            Console.WriteLine($"Masha: \"{yourName}, we picked you up just outside of Earth's atmosphere. Take a look at the map and help us choose what to do.\"", Color.HotPink);
            // maybe a menu screen where you can choose planets, view your age and inventory
        }
    }
}