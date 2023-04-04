using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Perseverance
{
    public class Robot : Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public virtual char Direction { get; set; }
        public virtual string? NameDirection { get; set; }

        private readonly ILogger _logger;

        public Robot()
        {

        }

        public override void RobotDirection()
        {
            throw new NotImplementedException();
        }

        public virtual void RobotDirection(string input) 
        {
            foreach (char c in input)
            {
                if (c == 'L')
                {
                    switch (Direction)
                    {
                        case 'N':
                            Direction = 'W';
                            break;
                        case 'S':
                            Direction = 'E';
                            break;
                        case 'E':
                            Direction = 'N';
                            break;
                        case 'W':
                            Direction = 'S';
                            break;
                    }
                }
                else if (c == 'R')
                {
                    switch (Direction)
                    {
                        case 'N':
                            Direction = 'E';
                            break;
                        case 'S':
                            Direction = 'W';
                            break;
                        case 'E':
                            Direction = 'S';
                            break;
                        case 'W':
                            Direction = 'N';
                            break;
                    }
                }
                else if (c == 'F')
                {
                    switch (Direction)
                    {
                        case 'N':
                            Y++;
                            break;
                        case 'S':
                            Y--;
                            break;
                        case 'E':
                            X++;
                            break;
                        case 'W':
                            X--;
                            break;
                    }
                }
            }
            
            // Name Direction
            if (Direction == 'N')
            {
                NameDirection = "North";
            }
            else if (Direction == 'S')
            {
                NameDirection = "South";
            }
            else if (Direction == 'W')
            {
                NameDirection = "West";
            }
            else
            {
                NameDirection = "East";
            }

            //Log
            if (NameDirection != "West")
            {
                _logger.Log($"Final position is wrong: {NameDirection}");
            }
        }
    }
}
