using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GenericClassAndInterfaces
{

    public class CircleQueue<T> : BigQueue<T>
    {
        private int _capacity;

        public CircleQueue(int capacity = 5)
        {
            _capacity = capacity;
        }

        public override void SaveValue(T value)
        {
            base.SaveValue(value);
            
            if (queue.Count > _capacity)
            {
                queue.Dequeue();
            }
        }

        public override bool IsFull 
        {
            get 
            {
                return queue.Count == _capacity;
            }
        } 
    }
}
