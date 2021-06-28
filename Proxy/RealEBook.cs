using System;
using System.Collections.Generic;

namespace Proxy
{
    public interface IEBook
    {
        void show();
        string getFileName();
    }

    public class RealEBook : IEBook
    {
        private string fileName { get; set; }

        public RealEBook(string fileName)
        {
            this.fileName = fileName;
            load(); //Memory Intensive Operation in constructor
        }
        public void load()
        {
            Console.WriteLine("Loading file: " + fileName);
        }
        public void show()
        {
            Console.WriteLine("showing file " + fileName);
        }

        public string getFileName()
        {
            return fileName;
        }
    }

    public class EBookProxy : IEBook
    {
        private string fileName { get; set; }
        private IEBook eBook = null; // We are not initializing this because that would defeat the purpose.

        public EBookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string getFileName()
        {
            return eBook.getFileName();
        }

        public void show()
        {
            if (eBook == null)
                eBook = new RealEBook(fileName);
            eBook.show();
        }
    }

    public class Library
    {
        public IDictionary<string,IEBook> eBooks = new Dictionary<string,IEBook>();

        public void OpenEbook(string bookName)
        {
            IEBook book = null;
            eBooks.TryGetValue(bookName, out book);
            book.show();
        }
    }
}
