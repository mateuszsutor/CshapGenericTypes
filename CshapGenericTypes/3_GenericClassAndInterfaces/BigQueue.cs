using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

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

        public IEnumerator<T> GetEnumerator()
        {
            // 1 sposób

            return queue.GetEnumerator();

            // 2 sposób
            //foreach (var item in queue)
            //{
            //    //filtrowanie
            //    yield return item;
            //}
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        public virtual T ReadValue()
        {
           return queue.Dequeue();
        }

        public virtual void SaveValue(T value)
        {
            queue.Enqueue(value);
        }

        public IEnumerable<Tout> SaveElementByNewType<Tout>()
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in queue)
            {
                var result = converter.ConvertTo(item, typeof(Tout));
                yield return (Tout)result;

            }
            
        }
    }
}