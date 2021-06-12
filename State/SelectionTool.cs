using System;

namespace State
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show selection icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Select items.");
        }
    }
}
