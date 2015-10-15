namespace NumberPuzzle.Common
{
    public class Square
    {
        public Square Left { get; set; }
        public Square Right { get; set; }
        public Square Above { get; set; }
        public Square Below { get; set; }
        public Square LeftAcrossAbove { get; set; }
        public Square RightAcrossAbove { get; set; }
        public Square LeftAcrossBelow { get; set; }
        public Square RightAcrossBelow { get; set; }
        public int Value { get; set; }
    }
}
