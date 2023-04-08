namespace Perseverance.nUnitTest
{
    public class RobotTests
    {
        private Robot _robot { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _robot = new Robot();
            _robot.Direction = 'N';
        }

        [Test]
        public void RobotDirection_EqualTest()
        {
            //Assing

            string input2 = "FFRFLFLF";

            //Act

            var NameDirection = _robot.RobotDirection(input2);

            //Assert

            Assert.AreEqual("West", NameDirection);

            Assert.Pass();
        }
    }
}