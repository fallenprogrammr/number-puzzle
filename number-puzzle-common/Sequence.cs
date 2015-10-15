using System;
using System.Linq;

namespace NumberPuzzle.Common
{
    public class Sequence
    {
        public static int[] GetRandomIntegerArray(int min, int max)
        {
            Random rnd = new Random();
            var numberSequence = new int[max];
            for (int i = 0; i <= 7; i++)
            {
                int nextNumber;
                do
                {
                    nextNumber = rnd.Next(min, max+1);
                }
                while (numberSequence.Contains(nextNumber));
                numberSequence[i] = nextNumber;
            }
            return numberSequence;
        }
    }
}
