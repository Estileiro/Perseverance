
namespace Robot
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public string? NameDirection { get; set; }

        public Robot()
        {
            X = 1;
            Y = 1;
            Direction = 'N';
        }

        //public virtual string RobotDirection(string input)
        //{
        //    foreach (char c in input)
        //    {
        //        if (c == 'L')
        //        {
        //            switch (Direction)
        //            {
        //                case 'N':
        //                    Direction = 'W';
        //                    break;
        //                case 'S':
        //                    Direction = 'E';
        //                    break;
        //                case 'E':
        //                    Direction = 'N';
        //                    break;
        //                case 'W':
        //                    Direction = 'S';
        //                    break;
        //            }
        //        }
        //        else if (c == 'R')
        //        {
        //            switch (Direction)
        //            {
        //                case 'N':
        //                    Direction = 'E';
        //                    break;
        //                case 'S':
        //                    Direction = 'W';
        //                    break;
        //                case 'E':
        //                    Direction = 'S';
        //                    break;
        //                case 'W':
        //                    Direction = 'N';
        //                    break;
        //            }
        //        }
        //        else if (c == 'F')
        //        {
        //            switch (Direction)
        //            {
        //                case 'N':
        //                    Y++;
        //                    break;
        //                case 'S':
        //                    Y--;
        //                    break;
        //                case 'E':
        //                    X++;
        //                    break;
        //                case 'W':
        //                    X--;
        //                    break;
        //            }
        //        }
        //    }

        //    // Name Direction
        //    if (Direction == 'N')
        //    {
        //        NameDirection = "North";
        //    }
        //    else if (Direction == 'S')
        //    {
        //        NameDirection = "South";
        //    }
        //    else if (Direction == 'W')
        //    {
        //        NameDirection = "West";
        //    }
        //    else
        //    {
        //        NameDirection = "East";
        //    }

        //    return NameDirection;
        //}
    }
}

