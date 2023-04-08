namespace Plateau
{
    public class Plateau : Dimensions
    {
        private new string[] dimensions = { };
        private int plateauWidth { get; set; }
        private int plateauHeight { get; set; }

        public Plateau(string input1)
        {
            dimensions = input1.Split('x');
            plateauWidth = int.Parse(dimensions[0]);
            plateauHeight = int.Parse(dimensions[1]);

            // Create the plateau
            bool[,] plateau = new bool[plateauWidth, plateauHeight];
        }
    }
}