using Perseverance;

namespace Robot.nUnitTest
{
    public class RobotTests
    {
        private Robot _robot { get; set; } = null;
        private Direction _direction { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _robot = new Robot();
            _robot.Direction = 'N';
        }

        [TestCase()]
        public void RobotObjectCreationValueX_EqualTest()
        {
            // Arrange
            int expectedValueX = 1;

            // Act
            Robot robot = new Robot();
            int actualValueX = robot.X;

            // Assert
            Assert.That(actualValueX, Is.EqualTo(expectedValueX));

        }

        [TestCase()]
        public void RobotObjectCreationValueY_EqualTest()
        {
            // Arrange
            int expectedValueY = 1;

            // Act
            Robot robot = new Robot();
            int actualValueY = robot.Y;

            // Assert
            Assert.That(actualValueY, Is.EqualTo(expectedValueY));

        }

        [TestCase()]
        public void RobotDirection_EqualTest()
        {
            //Assing

            string input2 = "FFRFLFLF";

            //Act
            DirectionManager directionManager = new DirectionManager();

            Robot _robot = new Robot();

            Direction direction = new Direction(_robot, input2);

            directionManager.AddDirection(direction);

            directionManager.ProcessDirection();

            //Assert

            Assert.That(_robot.NameDirection, Is.EqualTo("West"));

            Assert.Pass();
        }

        [TestCase("FFFFFFFF")]
        public void RobotDirection_NotEqualTest(string input2)
        {
            //Act

            DirectionManager directionManager = new DirectionManager();

            Robot _robot = new Robot();

            Direction direction = new Direction(_robot, input2);

            directionManager.AddDirection(direction);

            directionManager.ProcessDirection();

            //Assert

            Assert.That(_robot.NameDirection, Is.Not.EqualTo("East")); ;

            Assert.Pass();
        }
    }
}