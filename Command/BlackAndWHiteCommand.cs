using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class BlackAndWHiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black and White");
        }
    }
}
