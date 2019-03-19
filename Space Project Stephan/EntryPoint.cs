using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
        

namespace Space_Project_Stephan
{
    class Program
    {


        static void Main(string[] args)
        {

            Game G;
            G = new Game();
            G.MainMenu();
            G.OpeningDialogue();



            // CharacterSelection();
            // IntroductionDialogue();
        }
    }
}
