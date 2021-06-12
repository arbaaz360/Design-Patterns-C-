using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();
        public void Push(string url) { urls.Add(url); }
        public string Pop()
        {
            var lastIndex = urls.Count - 1;
            var lastUrl = urls[lastIndex];
            urls.Remove(lastUrl);
            return lastUrl;
        }

        public List<string> GetUrls() { return urls; }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }
        public class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }
            public string Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return index < history.urls.Count;
            }

            public void next()
            {
                index++;
            }
        }
    }
}
