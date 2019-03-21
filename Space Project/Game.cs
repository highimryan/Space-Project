using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Console = Colorful.Console;

//using SpaceTrader.Currency;

namespace SpaceTrader
{
    public class Game
    {
        List<Planet> planets = new List<Planet>();
        List<Races> races = new List<Races>();

        Player hero;

        public Game()
        {
            var beer = new Items("Space Dust Beer", 1.2M);
            var flowers = new Items("Space flowers", 3.4M);
            var illegalArms = new Items("Illegal Arms", 1000.88M);
            var candy = new Items("Space Candy", 1.2M);
            var magazine = new Items("Walltopian Report", 1.2M);
            var food = new Items("Chicken", 1.2M);
            var gun = new Items("Laser gun", 800.0M);
            var ring = new Items("Intellect ring", 100.0M);

            planets.Add(
                new Planet("Earth",
                    "Home of humanity, a water based planet with many life forms.",
                    0, 0,
                    new List<Items>() { beer, illegalArms, food
                    }));

            planets.Add(
                new Planet("ZipZorkland",
                    "Home of the ZipZorkians, the world seems in chaos to an outsider.",
                    0, 4.367,
                    new List<Items>() { flowers, food, ring, candy
                    },
                    0.9M));

            planets.Add(
                new Planet("Walltopia",
                    "Home of the Walltopians, a structured planet with strict rules.",
                    6.00, 8.00,
                    new List<Items>() { beer, gun, candy  },
                    1.5M));

            hero = new Player(planets[0]);
        }

        public void Run()
        {
            MainMenu();

            //Dialogue.OpeningDialogue();

            var quitReason = EventLoop();

            Dialogue.EndMessage(quitReason);
        }

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

            Console.WriteLine("\n \t1. Start New Game\n \t2. Load Saved Game  ", Color.LimeGreen);
            var input = Console.ReadLine();

            switch (input) //Switch for Selecting New Game or Saved Game
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

        private QuitReason EventLoop()
        {
            QuitReason quitReason;

            do
            {
                Console.Clear();

                // Print the current location
                Console.WriteLine($"Planet: {hero.planet.name}    Age: {hero.age:f2} years    Credits: {hero.money:f1}\n");

                // Print a description of that location
                Console.WriteLine(hero.planet.description);

                // Provide options to the user re. things they can do
                PrintOptionList();

                var key = UI.ElicitInput();

                quitReason = ShouldQuit(HandleInput(key));
            } while (quitReason == QuitReason.DontQuit);

            return quitReason;
        }

        private QuitReason ShouldQuit(QuitReason quitReason)
        {
            QuitReason AgeCheck() => hero.age >= 70 ? QuitReason.Age : QuitReason.DontQuit;
            QuitReason MoneyCheck() => hero.money < 0 ? QuitReason.OutOfMoney : QuitReason.DontQuit;


            if (quitReason == QuitReason.DontQuit)
            {
                quitReason = AgeCheck();
            }

            if (quitReason == QuitReason.DontQuit)
            {
                quitReason = MoneyCheck();
            }

            return quitReason;
        }

        private void PrintOptionList()
        {
            Console.WriteLine();
            Console.WriteLine("1. Travel to other planets");
            Console.WriteLine("2. Buy item");
            Console.WriteLine("3. Sell item");
            Console.WriteLine("q. Quit");
        }

        private QuitReason HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Q:
                    return QuitReason.UserQuit;
                case ConsoleKey.D1:
                    TravelMenu();
                    break;
                case ConsoleKey.D2:
                    BuyMenu();
                    break;
                case ConsoleKey.D3:
                    SellMenu();
                    break;
            }

            return QuitReason.DontQuit;
        }

        private void SellMenu()
        {
            Console.Clear();

            if (hero.inventory.Any())
            {
                PrintItems(hero.inventory);

                var itemIndex = UI.ElicitInput("Which item would you like to sell: ", 1, hero.inventory.Count);

                if (!itemIndex.cancelled)
                {
                    hero.SellItem(hero.inventory[itemIndex.input - 1]);
                }
            }
            else
            {
                Console.WriteLine("Nothing to sell...");
                UI.ElicitInput("Press any key to continue...");
            }
        }

        private void BuyMenu()
        {
            Console.Clear();

            List<Items> items = hero.planet.item;

            PrintItems(items);

            var itemIndex = UI.ElicitInput("Which item would you like to buy: ", 1, items.Count);

            if (!itemIndex.cancelled)
            {
                hero.BuyItem(items[itemIndex.input - 1]);
            }
        }

        private void PrintItems(List<Items> items)
        {
            for (int i = 0; i < items.Count; ++i)
            {
                var item = items[i];
                var cost = hero.planet.CostOf(item);

                Console.WriteLine($"{i + 1}. {item.name} - {cost:f2}cr");
            }
        }

        private void TravelMenu()
        {
            var done = false;
            int selector = 0;
            int count = planets.Count;

            do
            {
                Console.Clear();
                Console.WriteLine("Travel to:");

                PrintLocationsAndDistances(selector);

                var key = UI.ElicitInput("");


                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        selector++;
                        selector %= count;
                        break;
                    case ConsoleKey.UpArrow:
                        selector--;
                        selector = (selector + count) % count;
                        break;
                    case ConsoleKey.Q:
                        done = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.Enter:
                        done = true;
                        var warpSpeed = UI.ElicitInput("How fast (in warp units) would you like to go?", 0.0, 9.5);
                        hero.TravelTo(planets[selector], warpSpeed);
                        break;
                }
            } while (!done);
        }

        private void PrintLocationsAndDistances(int selector)
        {
            for (int i = 0; i < planets.Count; ++i)
            {
                Planet destination = planets[i];

                var distance = hero.planet.DistanceTo(destination);

                Console.Write($" - ");

                if (i == selector)
                {
                    UI.Highlight();
                }

                Console.WriteLine($"{destination.name}: {distance:f2}ly");

                UI.ResetColors();
            }
        }
        
        public void NewGame()
        {
            Dialogue.OpeningDialogue();
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
            var player = Console.ReadLine();

            switch (player)
            {
                case "1":
                {
                    Console.WriteLine("You have chosen Earthling.", Color.SteelBlue);
                    Console.ReadLine();

                    new Races.Earthling().EarthlingBio();

                    Console.WriteLine("Are you sure? Hit y for yes or n for no.", Color.SteelBlue);
                    var answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        
                        Console.Clear();
                        Dialogue.IntroductionDialogue(yourName);
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

                    new Races.ZipZorker().ZipZorkerBio();

                    Console.WriteLine("Are you sure? Hit y for yes or n for no.", Color.SteelBlue);
                    var answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        
                        Console.Clear();
                        Dialogue.IntroductionDialogue(yourName);
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

                    new Races.Walltopian().WalltopianBio();

                    Console.WriteLine("Are you sure? Hit y for yes or n for no.", Color.SteelBlue);
                    var answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        Console.Clear();
                        Dialogue.IntroductionDialogue(yourName);
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