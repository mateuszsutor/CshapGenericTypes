using System.Collections.Generic;

namespace _3_GenericClassAndInterfaces
{
    public class BigQueue<T> : IQueue<T>
    {

        Queue<T> queue;

        public BigQueue()
        {
            queue = new Queue<T>();
        }

        public bool IsFull => throw new System.NotImplementedException();
        
        public bool IsEmpty 
        {
            get 
            {
                return queue.Count == 0;
            }
        }

        public T ReadValue()
        {
           return queue.Dequeue();
        }

        public void SaveValue(T value)
        {
            queue.Enqueue(value);
        }
    }
}