namespace NumberPuzzle.Common
{
    public class Layout8Cross
    {
        public static Square[] InitializeWithSequence(int[] sequence)
        {
            var layout = new Square[8];
            for (int i = 0; i < layout.Length; i++)
            {
                layout[i] = new Square();
            }
            layout[0].Above = null;
            layout[0].Left = null;
            layout[0].Right = layout[1];
            layout[0].Below = layout[3];
            layout[0].LeftAcrossAbove = null;
            layout[0].LeftAcrossBelow = layout[2];
            layout[0].RightAcrossAbove = null;
            layout[0].RightAcrossBelow = layout[4];

            layout[1].Above = null;
            layout[1].Left = layout[0];
            layout[1].Right = null;
            layout[1].Below = layout[4];
            layout[1].LeftAcrossAbove = null;
            layout[1].LeftAcrossBelow = layout[3];
            layout[1].RightAcrossAbove = null;
            layout[1].RightAcrossBelow = layout[5];

            layout[2].Above = null;
            layout[2].Left = null;
            layout[2].Right = layout[3];
            layout[2].Below = null;
            layout[2].LeftAcrossAbove = null;
            layout[2].LeftAcrossBelow = null;
            layout[2].RightAcrossAbove = layout[0];
            layout[2].RightAcrossBelow = layout[6];

            layout[3].Above = layout[0];
            layout[3].Left = layout[2];
            layout[3].Right = layout[4];
            layout[3].Below = layout[6];
            layout[3].LeftAcrossAbove = null;
            layout[3].LeftAcrossBelow = null;
            layout[3].RightAcrossAbove = layout[1];
            layout[3].RightAcrossBelow = layout[7];

            layout[4].Above = layout[1];
            layout[4].Left = layout[3];
            layout[4].Right = layout[5];
            layout[4].Below = layout[7];
            layout[4].LeftAcrossAbove = layout[0];
            layout[4].LeftAcrossBelow = layout[6];
            layout[4].RightAcrossAbove = null;
            layout[4].RightAcrossBelow = layout[4];

            layout[5].Above = null;
            layout[5].Left = layout[4];
            layout[5].Right = null;
            layout[5].Below = null;
            layout[5].LeftAcrossAbove = layout[1];
            layout[5].LeftAcrossBelow = layout[7];
            layout[5].RightAcrossAbove = null;
            layout[5].RightAcrossBelow = null;

            layout[6].Above = layout[3];
            layout[6].Left = null;
            layout[6].Right = layout[7];
            layout[6].Below = null;
            layout[6].LeftAcrossAbove = layout[2];
            layout[6].LeftAcrossBelow = null;
            layout[6].RightAcrossAbove = layout[4];
            layout[6].RightAcrossBelow = null;

            layout[7].Above = layout[4];
            layout[7].Left = layout[6];
            layout[7].Right = null;
            layout[7].Below = null;
            layout[7].LeftAcrossAbove = layout[3];
            layout[7].LeftAcrossBelow = null;
            layout[7].RightAcrossAbove = layout[5];
            layout[7].RightAcrossBelow = null;

            PopulateWithSequence(layout, sequence);

            return layout;
        }

        private static void PopulateWithSequence(Square[] layout, int[] sequence)
        {
            for (int i = 0; i <= 7; i++)
            {
                layout[i].Value = sequence[i];
            }
        }

        public static bool IsValid(Square[] layout)
        {
            for (int i = 0; i < 7; i++)
            {

                if (!(IsAdjacentValueValid(layout[i].Value, layout[i].Above) &&
                    IsAdjacentValueValid(layout[i].Value, layout[i].Below) &&
                    IsAdjacentValueValid(layout[i].Value, layout[i].Left) &&
                    IsAdjacentValueValid(layout[i].Value, layout[i].Right) &&
                    IsAdjacentValueValid(layout[i].Value, layout[i].LeftAcrossAbove) &&
                    IsAdjacentValueValid(layout[i].Value, layout[i].LeftAcrossBelow) &&
                    IsAdjacentValueValid(layout[i].Value, layout[i].RightAcrossAbove) &&
                    IsAdjacentValueValid(layout[i].Value, layout[i].RightAcrossBelow)))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsAdjacentValueValid(int referenceValue, Square adjacentBlock)
        {
            if (adjacentBlock != null)
            {
                if(!IsValueValid(referenceValue, adjacentBlock.Value))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsValueValid(int referenceValue, int valueToCheck)
        {
            if ((valueToCheck == referenceValue + 1) || (valueToCheck == referenceValue - 1))
            {
                return false;
            }
            return true;
        }        
    }
}
