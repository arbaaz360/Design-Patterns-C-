using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public interface IComposite
    {
        void render();
    }

    public class Shape : IComposite
    {
        public void render()
        {
            Console.WriteLine("Rendering Shape.");
        }
    }
    public class Group : IComposite
    {
        private IList<IComposite> list = new List<IComposite>();
        
        public void Add(IComposite composite)
        {
            this.list.Add(composite);
        }
        public void render()
        {
            foreach(var com in list)
            {
                com.render();
            }
        }
    }
}
