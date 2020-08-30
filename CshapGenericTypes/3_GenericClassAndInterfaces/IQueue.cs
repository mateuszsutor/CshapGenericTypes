using System.Collections.Generic;

namespace _3_GenericClassAndInterfaces
{
    interface IQueue<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        bool IsFull { get; }

        T ReadValue();
        void SaveValue(T value);

        IEnumerable<Tout> SaveElementByNewType<Tout>();
    }
}