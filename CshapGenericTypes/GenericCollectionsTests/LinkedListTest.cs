using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCollectionsTests
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void AddingAfterElementMethod()
        {

            var list = new LinkedList<String>();

            list.AddFirst("Marek");
            list.AddLast("Tomek");
            list.AddAfter(list.First, "Zenek");

            Assert.AreEqual("Zenek", list.First.Next.Value);

        }


        [TestMethod]
        public void AddingBeforeElementMethod()
        {

            var list = new LinkedList<String>();

            list.AddFirst("Marek");
            list.AddLast("Tomek");
            list.AddBefore(list.First, "Zenek");

            Assert.AreEqual("Zenek", list.First.Value);

        }


        [TestMethod]
        public void RemoveLastElementFromList()
        {

            var list = new LinkedList<String>();

            list.AddFirst("Marek");
            list.AddLast("Tomek");

            list.RemoveLast();

            Assert.AreEqual(list.First, list.Last);

        }

        [TestMethod]
        public void RemoveFirstElementFromList()
        {

            var list = new LinkedList<String>();

            list.AddFirst("Marek");
            list.AddLast("Tomek");

            list.RemoveFirst();

            Assert.AreEqual(list.Last, list.First);

        }


        [TestMethod]
        public void RemoveSpecifiedElementFromList()
        {

            var list = new LinkedList<String>();

            list.AddFirst("Marek");
            list.AddLast("Tomek");

            list.Remove("Marek");

            Assert.AreEqual("Tomek", list.Last.Value);
            Assert.IsFalse(list.Contains("Marek"));
        }

        [TestMethod]
        public void HasListContainsElement()
        {

            var list = new LinkedList<String>();

            list.AddFirst("Marek");
            list.AddLast("Tomek");

          
            Assert.IsTrue(list.Contains("Marek"));
        }


        [TestMethod]
        public void ClearTheListTest()
        {

            var list = new LinkedList<String>();

            list.AddFirst("Marek");
            list.AddLast("Tomek");

            Assert.AreEqual(2, list.Count);

            list.Clear();

            Assert.AreEqual(0, list.Count);
        }
    }
}
