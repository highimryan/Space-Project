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
            Console.WriteLine("Enter your name: ");
            var YourName = Console.ReadLine();
            Console.Clear();
            CharacterSelection();
        }

        private static void CharacterSelection()
        {
            


        }
    }
}
