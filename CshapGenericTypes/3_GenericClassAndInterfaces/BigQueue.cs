namespace _3_GenericClassAndInterfaces
{
    internal class BigQueue<T> : IQueue<T>
    {
        private int capacity;

        public BigQueue(int capacity)
        {
            this.capacity = capacity;
        }

        public bool IsEmpty => throw new System.NotImplementedException();

        public bool IsFull => throw new System.NotImplementedException();

        public T ReadValue()
        {
            throw new System.NotImplementedException();
        }

        public void SaveValue(T value)
        {
            throw new System.NotImplementedException();
        }
    }
}