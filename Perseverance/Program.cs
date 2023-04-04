using System;
using Perseverance;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the plateau size: ");
            // Read the initial input
            string input1 = Console.ReadLine();

            Plateu plateu = new Plateu();

            plateu.dimensions = input1.Split('x');
            plateu.plateauWidth = int.Parse(plateu.dimensions[0]);
            plateu.plateauHeight = int.Parse(plateu.dimensions[1]);

            // Create the plateau
            bool[,] plateau = new bool[plateu.plateauWidth, plateu.plateauHeight];

            Console.Write("Enter the commands: ");
            // Read the second input line containing the commands
            string input2 = Console.ReadLine();

            // Create the robot and set its initial position and facing direction
            Robot robot = new Robot();


            robot.X = 1;
            robot.Y = 1;
            robot.Direction = 'N';
            robot.RobotDirection(input2);

            Console.WriteLine($"Final position: ({robot.X}, {robot.Y}), {robot.NameDirection}"); 
        }
        catch (Exception e)
        {
            Console.WriteLine("Check your input again! Please restart the process from 0");
        }
        Console.ReadKey();
    }


}