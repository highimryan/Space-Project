using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = System.Console;

namespace SpaceTrader
{
    public class Races
    {
        public class Earthling
        {
            public void EarthlingBio()
            {
                Console.WriteLine("Age: 20\n", Color.SteelBlue);
                Console.WriteLine("Earthlings are a balanced race that have a calm disposition.\n", Color.SteelBlue);

           
                Console.WriteLine(@"                mmmmm      ",Color.SteelBlue);
                Console.WriteLine(@"               m/o o\m     ", Color.SteelBlue);
                Console.WriteLine(@"              _m\ ~ /m_    ", Color.SteelBlue);
                Console.WriteLine(@"             /|       |\   ", Color.SteelBlue);
                Console.WriteLine(@"            // \     / \\  ", Color.SteelBlue);
                Console.WriteLine(@"           //   |   |   \\ ", Color.SteelBlue);
                Console.WriteLine(@"           W   |_____|   W ", Color.SteelBlue);
                Console.WriteLine(@"              /   _   \    ", Color.SteelBlue);
                Console.WriteLine(@"              |--| |--|    ", Color.SteelBlue);
                Console.WriteLine(@"             _|--| |--|_   ", Color.SteelBlue);
                Console.WriteLine(@"            /____| |____\  ", Color.SteelBlue);
                

            }
        }

        public class ZipZorker
        {
            public void ZipZorkerBio()
            {
                Console.WriteLine("Age: 20\n", Color.LightSeaGreen);
                Console.WriteLine(
                    "ZipZorkers are small beings roughly 3 feet in height. They severely lack physical strength, but make up for that with superior intellect.",
                    Color.LightSeaGreen);
                Console.WriteLine("ZipZorker are very unpredictable and have emotional outbursts at strange times.\n",
                    Color.LightSeaGreen);
                Console.WriteLine("It is said that these small beings have telekinesis, but it has never been proven.\n",
                    Color.LightSeaGreen);

                Console.WriteLine(@"              |      ", Color.SteelBlue);
                Console.WriteLine(@"             _|_      ", Color.SteelBlue);
                Console.WriteLine(@"            |o o|     ", Color.SteelBlue);
                Console.WriteLine(@"           \ \O/ /       ", Color.SteelBlue);
                Console.WriteLine(@"            \/ \/      ", Color.SteelBlue);
                Console.WriteLine(@"             |_|      ", Color.SteelBlue);
                Console.WriteLine(@"           _/   \_       ", Color.SteelBlue);



            }
        }

        public class Walltopian
        {
            public void WalltopianBio()
            {
                Colorful.Console.WriteLine("Age: 20\n", Color.Red);
                Colorful.Console.WriteLine("Walltopians are very large, strong creatures seemingly made of rock.\n", Color.Red);



                Console.WriteLine(@"           _____               ", Color.Red);
                Console.WriteLine(@"          /-----\              ", Color.Red);
                Console.WriteLine(@"          |{o o}|               ", Color.Red);
                Console.WriteLine(@"        __| +++ |__               ", Color.Red);
                Console.WriteLine(@"       /| | | | | |\                  ", Color.Red);
                Console.WriteLine(@"      / /|-------|\ \                   ", Color.Red);
                Console.WriteLine(@"     / / |-------| \ \                   ", Color.Red);
                Console.WriteLine(@"     WW  |-------|  WW                  ", Color.Red);
                Console.WriteLine(@"         |-------|              ", Color.Red);
                Console.WriteLine(@"         |---|---|                ", Color.Red);
                Console.WriteLine(@"       __|---|---|__                ", Color.Red);
                Console.WriteLine(@"      |______|______|                   ", Color.Red);
            }
        }
    }
}
