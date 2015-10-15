using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberPuzzle.Common
{
    public class Sequence
    {
        public int[] NumberSequence { get; set; }
        public Sequence()
        {
            NumberSequence = new int[8];
        }

        public static Sequence GetRandomSequence(List<Sequence> occurredSequences)
        {
            Random rnd = new Random();
            var sequence = new Sequence();
            do
            {
                for (int i = 0; i <= 7; i++)
                {
                    int nextNumber;
                    do
                    {
                        nextNumber = rnd.Next(1, 9);
                    }
                    while (sequence.NumberSequence.Contains(nextNumber));
                    sequence.NumberSequence[i] = nextNumber;
                }
            } while (occurredSequences.Contains(sequence));
            occurredSequences.Add(sequence);
            return sequence;
        }
    }
}
