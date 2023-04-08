using Perseverance;

namespace Robot
{
    public class Direction : IDirection
    {
        private readonly Robot _robot;
        private readonly string _input;

        public ExecutionStatus Status { get; set; }

        public Direction(Robot robot, string input)
        {
            _robot = robot;
            _input = input;

            Status = ExecutionStatus.Unprocessed;
        }

        public void Execute()
        {
            foreach (char c in _input)
            {
                if (c == 'L')
                {
                    switch (_robot.Direction)
                    {
                        case 'N':
                            _robot.Direction = 'W';
                            break;
                        case 'S':
                            _robot.Direction = 'E';
                            break;
                        case 'E':
                            _robot.Direction = 'N';
                            break;
                        case 'W':
                            _robot.Direction = 'S';
                            break;
                    }
                }
                else if (c == 'R')
                {
                    switch (_robot.Direction)
                    {
                        case 'N':
                            _robot.Direction = 'E';
                            break;
                        case 'S':
                            _robot.Direction = 'W';
                            break;
                        case 'E':
                            _robot.Direction = 'S';
                            break;
                        case 'W':
                            _robot.Direction = 'N';
                            break;
                    }
                }
                else if (c == 'F')
                {
                    switch (_robot.Direction)
                    {
                        case 'N':
                            _robot.Y++;
                            break;
                        case 'S':
                            _robot.Y--;
                            break;
                        case 'E':
                            _robot.X++;
                            break;
                        case 'W':
                            _robot.X--;
                            break;
                    }
                }
            }

            // Name Direction
            if (_robot.Direction == 'N')
            {
                _robot.NameDirection = "North";
            }
            else if (_robot.Direction == 'S')
            {
                _robot.NameDirection = "South";
            }
            else if (_robot.Direction == 'W')
            {
                _robot.NameDirection = "West";
            }
            else
            {
                _robot.NameDirection = "East";
            }

            Status = ExecutionStatus.ExecuteSucceeded;
        }
    }
}

