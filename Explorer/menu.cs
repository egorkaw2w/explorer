using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer
{
    internal class menu
    {
        private int minStrlochka;
        private int maxStrlochka;

        public menu(int min, int max)
        {
            minStrlochka = min;
            maxStrlochka = max;
        }
        public int Show()
        {
            int pos = 1;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != minStrlochka)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != maxStrlochka)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    pos = -1;
                }
            }while (key.Key != ConsoleKey.Enter);

            return pos - minStrlochka;
        }
    }
}
