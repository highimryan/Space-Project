using System.Drawing;
using Colorful;

namespace SpaceTrader.Races
{
    internal class Races
    {
        public void Earthling()
        {
            Console.WriteLine("Age: 20\n", Color.SteelBlue);
            Console.WriteLine("Earthlings are a balanced race that have a calm temper.\n", Color.SteelBlue);
        }

        public void ZipZorker()
        {
            Console.WriteLine("Age: 20\n", Color.LightSeaGreen);
            Console.WriteLine(
                "ZipZorkers are small beings roughly 3 feet in height. They severely lack physical strength, but make up for that with superior intellect.",
                Color.LightSeaGreen);
            Console.WriteLine("ZipZorker are very unpredictable and have emotional outbursts at strange times.\n",
                Color.LightSeaGreen);
            Console.WriteLine("It is said that these small beings have telekinesis, but it has never been proven.\n",
                Color.LightSeaGreen);
        }

        public void Walltopian()
        {
            Console.WriteLine("Age: 20\n", Color.Red);
            Console.WriteLine("Walltopians are very large, strong creatures seemingly made of rock.\n", Color.Red);
        }
    }
}