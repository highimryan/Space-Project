using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Space_Project_Stephan
{
    class Races
    {
        public Races()
        {
            return; //default constructor
        }

        public void Earthling()
        {
            Console.WriteLine("Age: 20\n");
            Console.WriteLine("Earthlings are a balanced race that have a calm temperment.\n");


        }

        public void ZipZorker()
        {
            Console.WriteLine("Age: 20\n");
            Console.WriteLine("ZipZorkers are small beings roughly 3 feet in height. They severely lack physical strength, but make up for that with superior intellect.");
            Console.WriteLine("ZipZorker are very unpredictable and have emotional outbursts at strange times.\n");
            Console.WriteLine("It is said that these small beings have telekinesis, but it has never been proven.\n");
        }

        public void Walltopian()
        {
            Console.WriteLine("Age: 20\n");
            Console.WriteLine("Walltopians are very large, strong creatures seemingly made of rock.\n");
        }
    }
}
