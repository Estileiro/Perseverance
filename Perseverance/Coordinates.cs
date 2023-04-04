using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perseverance
{
    public abstract class Coordinates
    {
        public char Direction { get; set; }
        public string? NameDirection { get; set; }
        public abstract void RobotDirection();

    }
}
