using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class Messages : IMessages
    {
        public void FinalMessage(int x, int y, string direction)
        {
            Console.WriteLine($"Final position: ({x}, {y}), {direction}");
        }

        public void PlateauMessage()
        {
            Console.WriteLine("Enter the plateau size: ");
        }

        public void PlateauMessageCommand()
        {
            Console.WriteLine("Enter the commands: ");
        }
    }
}
