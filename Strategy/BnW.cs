using System;

namespace Strategy
{
    public class BnW : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
