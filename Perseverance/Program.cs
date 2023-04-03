using System;
using Perseverance;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the plateau size: ");
        // Read the initial input
        string input1 = Console.ReadLine();
        string[] dimensions = input1.Split('x');
        int plateauWidth = int.Parse(dimensions[0]);
        int plateauHeight = int.Parse(dimensions[1]);

        // Create the plateau
        bool[,] plateau = new bool[plateauWidth, plateauHeight];

        Console.Write("Enter the commands: ");
        // Read the second input line containing the commands
        string input2 = Console.ReadLine();

        // Create the robot and set its initial position and facing direction
        Robot robot = new Robot();
        robot.X = 1;
        robot.Y = 1;
        robot.Direction = 'N';


        foreach (char c in input2)
        {
            if (c == 'L')
            {
                switch (robot.Direction)
                {
                    case 'N':
                        robot.Direction = 'W';
                        break;
                    case 'S':
                        robot.Direction = 'E';
                        break;
                    case 'E':
                        robot.Direction = 'N';
                        break;
                    case 'W':
                        robot.Direction = 'S';
                        break;
                }
            }
            else if (c == 'R')
            {
                switch (robot.Direction)
                {
                    case 'N':
                        robot.Direction = 'E';
                        break;
                    case 'S':
                        robot.Direction = 'W';
                        break;
                    case 'E':
                        robot.Direction = 'S';
                        break;
                    case 'W':
                        robot.Direction = 'N';
                        break;
                }
            }
            else if (c == 'F')
            {
                switch (robot.Direction)
                {
                    case 'N':
                        robot.Y++;
                        break;
                    case 'S':
                        robot.Y--;
                        break;
                    case 'E':
                        robot.X++;
                        break;
                    case 'W':
                        robot.X--;
                        break;
                }
            }
        }

        if (robot.Direction == 'N')
        {
            robot.NameDirection = "North";
        }
        else if (robot.Direction == 'S')
        {
            robot.NameDirection = "South";
        }
        else if (robot.Direction == 'W')
        {
            robot.NameDirection = "West";
        }
        else
        {
            robot.NameDirection = "East";
        }

        Console.WriteLine($"Final position: ({robot.X}, {robot.Y}), {robot.NameDirection}");
        Console.ReadKey();
    }
}