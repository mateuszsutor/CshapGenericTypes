using System;
using _1_GenericType;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenrricTypeTest
{
    [TestClass]
    public class CircleQueueTests
    {

        [TestMethod]
        public void NewQueueIsEmpty()
        {
            var queue = new CircleQueue();

            Assert.IsTrue(queue.IsEmpty);
        }

        [TestMethod]
        public void ThreeElementsQueueAfterAddThreeElementIsFull()
        {
            var queue = new CircleQueue(capacity: 3);
            queue.SaveValue(3.3);
            queue.SaveValue(5);
            queue.SaveValue(10.8);

            Assert.IsTrue(queue.IsFull);
        }


        [TestMethod]
        public void HasFirstElementAddToQueueIsFirstRead()
        {
            var queue = new CircleQueue(capacity: 3);

            var value1 = 8.8;
            var value2 = 5.1;

            queue.SaveValue(value1);
            queue.SaveValue(value2);


            Assert.AreEqual(value1, queue.ReadValue());
            Assert.AreEqual(value2, queue.ReadValue());
            Assert.IsTrue(queue.IsEmpty);
        }

        [TestMethod]
        public void HasOverwriteValueWhenCapacityIsExceed()
        {
            var queue = new CircleQueue(capacity: 3);

            var values = new[] { 1.8, 3.5, 5.1, 7.6, 9.1, 11.0 };

            foreach (var item in values)
            {
                queue.SaveValue(item);
            }

            Assert.IsTrue(queue.IsFull);
            Assert.AreEqual(values[3], queue.ReadValue());
            Assert.AreEqual(values[4], queue.ReadValue());
            Assert.AreEqual(values[5], queue.ReadValue());
            Assert.IsTrue(queue.IsEmpty);
        }
    }
}
