using System;
using System.Drawing;
using Console = Colorful.Console;

namespace SpaceTrader
{
    public class Dialogue
    {
        public static void OpeningDialogue()
        {
            Console.Clear();
            var prompt = "Press any key to continue...";

            Console.WriteLine("You awaken in a cold, dark room...", Color.SteelBlue);
            UI.ElicitInput(prompt);

            Console.WriteLine("\nA shrill voice pierces your ears", Color.SteelBlue);
            Console.WriteLine("\"You're awake, you're awake!\"", Color.HotPink);
            UI.ElicitInput(prompt);

            Console.WriteLine("\"Quiet, Masha we don't know if we can trust this.... thing.\"", Color.Red);
            UI.ElicitInput(prompt);

            Console.WriteLine("Masha replies", Color.SteelBlue);
            Console.WriteLine("\"Of course we can, Tork! We saved it, if it weren't for us it would still be floating in space.\"",
                Color.HotPink);
            UI.ElicitInput(prompt);

            Console.WriteLine("Tork helps you up", Color.SteelBlue);
            Console.WriteLine("\"Who are you?\"", Color.Red);
            UI.ElicitInput(prompt);

            Console.Clear();

            new Game().CreateToon();
        }

        public static void IntroductionDialogue(string yourName)
        {
            Console.WriteLine($"Tork: \"Greetings {yourName}, welcome to the [ship name]!\"", Color.Red);
            Console.ReadLine();
            Console.WriteLine("Masha: \"I'm so happy we've found you... we need help.\"", Color.HotPink);
            Console.WriteLine("Tork: \"We don't need help, Masha! I've got this merchant business under control.\"",Color.Red);
            Console.WriteLine("Masha: \"Oh really, Tork? Do you remember what day it is?\"", Color.HotPink);
            Console.WriteLine("Tork begins to look flustered...", Color.IndianRed);
            Console.ReadLine();
            Console.WriteLine("Masha: \"Tork has taken too many hits to the head, he has trouble with his memory... Not to mention he's a Walltopian.\"",Color.HotPink);
            // Add an if statement here, if the player is a ZipZorker insert a negative response. 
            Console.WriteLine($"Masha: \"{yourName}, we picked you up just outside of Earth's atmosphere. Take a look at the map and help us choose what to do.\"",Color.HotPink);
            // maybe a menu screen where you can choose planets, view your age and inventory
        }

        public static void EndMessage(QuitReason quitReason)
        {
            Console.Clear();

            switch (quitReason)
            {
                case QuitReason.UserQuit:
                    Console.WriteLine("Sorry to see you go...\n\n");
                    break;
                case QuitReason.Age:
                    Console.WriteLine("You're 70 years old... The time has come for you to retire.\n\n");
                    break;
                case QuitReason.OutOfMoney:
                    Console.WriteLine("Your last penny spent, a debtor's prison colony awaits your remaining years.");
                    break;
                case QuitReason.DontQuit:
                    throw new NotImplementedException("Shouldn't be quitting with DontQuit reason");
            }
        }
    }
}