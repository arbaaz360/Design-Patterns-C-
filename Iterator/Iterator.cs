using System;

namespace Iterator
{
    public interface IIterator<T>
    {
        Boolean HasNext();
        T Current();
        void next();
    }
}
