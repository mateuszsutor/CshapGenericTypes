using System.Collections.Generic;

namespace _3_GenericClassAndInterfaces
{
    public class BigQueue<T> : IQueue<T>
    {

        protected Queue<T> queue;

        public BigQueue()
        {
            queue = new Queue<T>();
        }

        public virtual bool IsFull => throw new System.NotImplementedException();
        
        public virtual bool IsEmpty 
        {
            get 
            {
                return queue.Count == 0;
            }
        }

        public virtual T ReadValue()
        {
           return queue.Dequeue();
        }

        public virtual void SaveValue(T value)
        {
            queue.Enqueue(value);
        }
    }
}