using NumberPuzzle.Common;
using System;
using System.Collections.Generic;

namespace number_puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var layout = new Square[8];
            var occurredSequences = new List<Sequence>();
            Layout.Initialize(layout);
            do
            {
                Layout.PopulateWithSequence(layout, Sequence.GetRandomSequence(occurredSequences));
            }
            while (!Layout.IsValid(layout));
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
