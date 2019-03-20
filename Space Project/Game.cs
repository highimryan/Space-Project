using System.Drawing;
using Colorful;
using SpaceTrader.Dialogue;
//using SpaceTrader.Currency;
using SpaceTrader.Races;
using SpaceTrader.Planets;
using SpaceTrader.SpaceShips;

namespace SpaceTrader
{
    internal class Game
    {
        public void MainMenu()
        {
            var DA = 245;
            var V = 212;
            var ID = 200;

            for (var i = 0; i <= 0; i++)
            {
                Console.WriteAscii("SPACE TRADER", Color.FromArgb(DA, V, ID));

                DA -= 18;
                V -= 36;
            }

            Console.WriteLine("\n \t1. Start New Game\n \t2. Load Saved Game  ", Color.SteelBlue);
            var input = Console.ReadLine();

            switch (input) //Switch on Key enum
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
           new NewToon().OpeningDialogue();
        }

        public void SavedGame()
        {
            // For loading SavedGame
        }


        public void CreateToon()
        {
            Console.WriteLine("Enter your name: ", Color.SteelBlue);
            var yourName = Console.ReadLine();

            Console.WriteLine($"Hello {yourName}, choose your race.", Color.SteelBlue);
            Console.WriteLine("\t1. Earthling", Color.SteelBlue);
            Console.WriteLine("\t2. Zipzorker", Color.SteelBlue);
            Console.WriteLine("\t3. Walltopian", Color.SteelBlue);
            var race = Console.ReadLine();

            Races.Races races;
            races = new Races.Races();

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
                        new NewToon().IntroductionDialogue(yourName);
                        break;
                    }

                    if (answer == "n")
                    {
                        Console.Clear();
                        CreateToon();
                        break;
                    }

                    Console.WriteLine("Please enter y or n.. Try again");
                    Console.ReadLine();
                    Console.Clear();
                    CreateToon();
                    break;
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
                        new NewToon().IntroductionDialogue(yourName);
                        break;
                    }

                    if (answer == "n")
                    {
                        Console.Clear();
                        CreateToon();
                        break;
                    }

                    Console.WriteLine("Please enter y or n.. Try again");
                    Console.ReadLine();
                    Console.Clear();
                    CreateToon();
                    break;
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
                        new NewToon().IntroductionDialogue(yourName);
                        break;
                    }

                    if (answer == "n")
                    {
                        Console.Clear();
                        CreateToon();
                        break;
                    }

                    Console.WriteLine("Please enter y or n... Try again");
                    Console.ReadLine();
                    Console.Clear();
                    CreateToon();
                    break;
                } // Removed default on switch(race)
                // added break to end of each case instead
            }
        }
    }
}