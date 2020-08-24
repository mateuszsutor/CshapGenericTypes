using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GenericCollectionsTests
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void AddToEndList()
        {
            List<int> numbersList = new List<int> { 1, 2, 3 };

            numbersList.Add(4);

            Assert.AreEqual(4, numbersList.Last());

            // Assert.AreEqual(4, numbersList[3]); // alternatywa

        }

        [TestMethod]
        public void AddToEndListFewElements()
        {
            List<int> numbersList = new List<int> { 1, 2, 3 };

            List<int> lists = new List<int> { 4, 5, 6, 7 };
            numbersList.AddRange(lists);

            Assert.AreEqual(7, numbersList[6]);
        }


        [TestMethod]
        public void AddAtSpecificPositionToList()
        {
            List<int> numbersList = new List<int> { 1, 2, 3 };

            numbersList.Insert(1, 8);

            Assert.AreEqual(8, numbersList[1]);

        }




        [TestMethod]
        public void RemoveElementFromList()
        {
            List<int> numbersList = new List<int> { 1, 2, 3 };

            numbersList.Remove(2);

            Assert.IsTrue(numbersList.SequenceEqual(new[] { 1, 3 }));

            Assert.IsFalse(numbersList.Contains(2));

        }


        [TestMethod]
        public void RemoveSpecificElementFromList()
        {
            List<int> numbersList = new List<int> { 1, 2, 3 };

            numbersList.RemoveAt(2);

            Assert.IsTrue(numbersList.SequenceEqual(new[] { 1, 2 }));

            Assert.IsFalse(numbersList.Contains(3));

        }

        [TestMethod]
        public void FindSpecificIndexElementAtList()
        {
            List<int> numbersList = new List<int> { 1, 2, 3 };

            Assert.AreEqual(numbersList.IndexOf(3), 2);

        }

        [TestMethod]
        public void ContainsNuberAtList()
        {
            List<int> numbersList = new List<int> { 45, 99, 26 };

            Assert.IsTrue(numbersList.Contains(99));

        }
    }
}
