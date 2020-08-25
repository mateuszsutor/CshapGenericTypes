using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCollectionsTests
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void UsePeekMethod() 
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);


            //Peek() tylko podgląda co jest na pierwszym miejscu w kolejce !!! Nie usuwa elementu!!!
            Assert.AreEqual(1, queue.Peek());
        }


        [TestMethod]
        public void UseContainsMethod()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            
            Assert.IsTrue(queue.Contains(3));
            Assert.IsFalse(queue.Contains(9));

        }


        [TestMethod]
        public void UseToArrayMethod()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            var array = queue.ToArray();
            queue.Dequeue();

            Assert.AreEqual(1, array.First());
            Assert.AreEqual(3, queue.Count());

        }


        [TestMethod]
        public void UseClearMethod()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Clear();

            Assert.AreEqual(0, queue.Count());

        }


    }
}
