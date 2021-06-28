using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
