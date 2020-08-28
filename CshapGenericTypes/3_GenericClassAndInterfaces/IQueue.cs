namespace _3_GenericClassAndInterfaces
{
    interface IQueue<T>
    {
        bool IsEmpty { get; }
        bool IsFull { get; }

        T ReadValue();
        void SaveValue(T value);
    }
}