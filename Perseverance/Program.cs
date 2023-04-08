using Robot;

public class Program
{
    static void Main(string[] args)
    {
            var messagesPlateu = new Messages.Messages();

            messagesPlateu.PlateauMessage();

            // Read the initial input
            string input1 = Console.ReadLine();

            Plateau.Plateau plateu = new Plateau.Plateau(input1);

            messagesPlateu.PlateauMessageCommand();

            // Read the second input line containing the commands

            DirectionManager directionManager = new DirectionManager();

            // Create the robot and set its initial position and facing direction
            Robot.Robot robot = new Robot.Robot();
            
            var input2 = Console.ReadLine();

            Direction direction = new Direction(robot,input2);

            directionManager.AddDirection(direction);

            directionManager.ProcessDirection();

            messagesPlateu.FinalMessage(robot.X, robot.Y, robot.NameDirection); 

            Console.ReadKey();
    }


}