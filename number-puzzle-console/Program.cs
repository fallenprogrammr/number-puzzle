using NumberPuzzle.Common;
using System;
using System.Collections.Generic;

namespace number_puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Layout8CrossConsoleDisplay.Draw();

            Console.ReadKey();
            Environment.Exit(0);


            Square[] layout;
            var occurredSequences = new List<int[]>();
            int[] sequence;
            do
            {
                do
                {
                    sequence = Sequence.GetRandomIntegerArray(1, 8);
                }
                while (occurredSequences.Contains(sequence));
                occurredSequences.Add(sequence);
                layout = Layout8Cross.InitializeWithSequence(sequence);
            }
            while (!Layout8Cross.IsValid(layout));
            PrintLayout(layout);
            Console.ReadKey();
        }

        private static void PrintLayout(Square[] layout)
        {
            Console.WriteLine("Sequence: ");

            foreach (var item in layout)
            {
                Console.Write(item.Value + " ");
            }
        }

    }
}
