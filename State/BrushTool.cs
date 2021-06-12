using System;

namespace State
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show brush icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a straight line.");
        }
    }
}
