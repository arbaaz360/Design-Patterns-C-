using System;

namespace Strategy
{
    public class JPEG : ICompression
    {
        public void Compress()
        {
            Console.WriteLine("Compressing with JPEG algorithm.");
        }
    }
}
