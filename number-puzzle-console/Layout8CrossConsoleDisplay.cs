using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_puzzle
{
    class Layout8CrossConsoleDisplay
    {
        private const string boxEdge = "+";
        private const string boxHorizontal = "-";
        private const string boxVertical = "|";

        public static void Draw()
        {
            var left = Console.CursorLeft;
            var top = Console.CursorTop;
            DrawHorizontal();
            DrawVertical();
            DrawHorizontal();
        }

        private static void DrawVertical()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(Environment.NewLine);
                Console.Write(boxVertical);
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(boxVertical);
                Console.Write(Environment.NewLine);
            }
        }

        private static void DrawHorizontal()
        {
            Console.Write(boxEdge);
            for (int i = 0; i < 12; i++)
            {
                Console.Write(boxHorizontal);
            }
            Console.Write(boxEdge);
        }
    }
}
