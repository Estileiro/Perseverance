namespace Plateau.nUnitTest
{
    public class PlateauTests
    {
        private Plateau _plateau { get; set; } = null;
        private string input { get; set; } = null;

        [SetUp]
        public void Setup()
        {

        }

        [TestCase()]
        public void PlateauCreationTest_EqualTest()
        {
            // Arrange
            string input = "5x5";
            int plateauWidth;
            int plateauHeight;
            bool[,] plateau = new bool[5, 5];

            // Act
            Plateau _plateau = new Plateau(input);

            string[] dimensions = input.Split('x');
            plateauWidth = int.Parse(dimensions[0]);
            plateauHeight = int.Parse(dimensions[1]);
            var expectedValue = new bool[plateauWidth, plateauHeight];

            // Assert
            Assert.That(expectedValue, Is.EqualTo(plateau));

            Assert.Pass();
        }

        [TestCase()]
        public void PlateauCreationTest_NotEqualTest()
        {
            // Arrange
            string input = "5x5";
            int plateauWidth;
            int plateauHeight;
            bool[,] plateau = new bool[1, 4];

            // Act
            Plateau _plateau = new Plateau(input);

            string[] dimensions = input.Split('x');
            plateauWidth = int.Parse(dimensions[0]);
            plateauHeight = int.Parse(dimensions[1]);
            var expectedValue = new bool[plateauWidth, plateauHeight];

            // Assert
            Assert.That((expectedValue), Is.Not.EqualTo(plateau));

            Assert.Pass();
        }
    }
}