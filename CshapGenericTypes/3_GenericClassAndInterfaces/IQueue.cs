using System.Collections.Generic;

namespace _3_GenericClassAndInterfaces
{
    public interface IQueue<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        bool IsFull { get; }

        T ReadValue();
        void SaveValue(T value);

        
    }
}