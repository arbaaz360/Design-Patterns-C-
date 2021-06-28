using System.Collections.Generic;

namespace Observer
{
    public class Subject
    {

        public List<IObserver> Observers { get; set; } = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        internal void NotifyObservers()
        {
            foreach (var observer in this.Observers)
            {
                observer.Update();
            }
        }
    }
}
