using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace SpaceTrader
{
    static class UI
    {
        public struct IntInput
        {
            public int input;
            public bool cancelled;

            public IntInput(bool cancelled)
            {
                this.input = -1;
                this.cancelled = cancelled;
            }

            public IntInput(int input)
            {
                this.input = input;
                this.cancelled = false;
            }
        }

        public static ConsoleKey ElicitInput(string prompt = "> ")
        {
            var cursorLeftPos = Console.CursorLeft;
            var cursorTopPos = Console.CursorTop;

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write(prompt);

            Console.SetCursorPosition(cursorLeftPos, cursorTopPos);

            return Console.ReadKey(true).Key;
        }

        public static double ElicitInput(string prompt, double lower, double upper)
        {
            bool valid = false;
            double input = 0.0;

            Console.WriteLine($"{prompt} (Range: [{lower:f1}, {upper:f1}))");

            do
            {
                Console.Write($"> ");

                try
                {
                    input = double.Parse(Console.ReadLine());

                    if ((input > lower) && (input <= upper))
                    {
                        valid = true;
                    }
                }
                catch (FormatException)
                { }
            } while (!valid);

            return input;
        }

        public static IntInput ElicitInput(string prompt, int lower, int upper)
        {
            bool valid = false;
            IntInput output = new IntInput();

            Console.WriteLine($"{prompt}");

            do
            {
                Console.Write($"> ");

                try
                {
                    var input = Console.ReadLine();

                    if (input == "q")
                    {
                        output = new IntInput(true);
                        valid = true;
                    }
                    else
                    {
                        var i = int.Parse(input);

                        if ((i >= lower) && (i <= upper))
                        {
                            output = new IntInput(i);
                            valid = true;
                        }
                    }
                }
                catch (FormatException)
                { }
            } while (!valid);

            return output;
        }

        public static void Highlight()
        {
            var background = Console.BackgroundColor;
            var foreground = Console.ForegroundColor;

            Console.ForegroundColor = background;
            Console.BackgroundColor = foreground;
        }

        public static void ResetColors()
        {
            Console.ResetColor();
        }
    }
}