using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCollectionsTests
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void CompareTwoSetsIntersectMethodTest()
        {
            HashSet<int> hashSet1 = new HashSet<int>() { 1, 2, 3, 4 };
            HashSet<int> hashSet2 = new HashSet<int>() { 2, 3, 4, 5 };


            // zostawia w hashset1 tylko te elementy które są wspolne dla hashset1 i hashset2 
            hashSet1.IntersectWith(hashSet2);

            // częsc wspólna dwóch setów
            int[] commonPart = new int[] { 2, 3, 4 };

            Assert.IsTrue(hashSet1.SetEquals(commonPart));
            Assert.IsTrue(hashSet1.SetEquals(commonPart));
        }


        [TestMethod]
        public void CreateFromTwoSetsNewSetUnionWithMethodTest()
        {
            HashSet<int> hashSet1 = new HashSet<int>() { 1, 2, 3, 4 };
            HashSet<int> hashSet2 = new HashSet<int>() { 2, 3, 4, 5 };


            // łączy wartości dwóch setów (bez dublowania)
            hashSet1.UnionWith(hashSet2);

            // połączenie dwóch setów
            int[] joinedTwoSetsValue = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(hashSet1.SetEquals(joinedTwoSetsValue));
        }

        [TestMethod]
        public void DifferenceBetweenTwoSetsSymmetricExceptWithMethodTest()
        {
            HashSet<int> hashSet1 = new HashSet<int>() { 1, 2, 3, 4 };
            HashSet<int> hashSet2 = new HashSet<int>() { 2, 3, 4, 5 };


            // ustawia w set1 wartośći które nie są częścią wspólną
            hashSet1.SymmetricExceptWith(hashSet2);

            // róznice w zawartości setów 1 i 2
            int[] differenceTwoSetsValue = new int[] { 1, 5 };

            Assert.IsTrue(hashSet1.SetEquals(differenceTwoSetsValue));
        }

        [TestMethod]
        public void RemoveSetMethodTest()
        {
            HashSet<int> hashSet1 = new HashSet<int>() { 1, 2, 3, 4 };

            bool result = hashSet1.Remove(3);

            Assert.IsTrue(result);
            Assert.IsFalse(hashSet1.Contains(3));
            Assert.AreEqual(3, hashSet1.Count());

        }

        [TestMethod]
        public void RemoveWhereSetMethodTest()
        {
            HashSet<double> hashSet1 = new HashSet<double>() { 1, 2, 3.2, 3.4, 3.6, 3.9, 4 };

            // warunek co powinno zostać usunięte z setu: liczby > od 3.2 i zarazem mniejsze od 4
            hashSet1.RemoveWhere(x => (x > 3.2 && x < 4));

            // wartości które powinny pozostać po usunięciu
            double[] values = new[] {1, 2, 3.2, 4};

            Assert.AreEqual(4, hashSet1.Count());
            Assert.IsTrue(hashSet1.SetEquals(values));

        }


        [TestMethod]
        public void ClearSetMethodTest()
        {
            HashSet<int> hashSet1 = new HashSet<int>() { 1, 2, 3, 4 };

            hashSet1.Clear();

            Assert.AreEqual(0, hashSet1.Count());

        }


        [TestMethod]
        public void ContainsSetMethodTest()
        {
            HashSet<int> hashSet1 = new HashSet<int>() { 1, 2, 3, 4 };

            Assert.IsTrue(hashSet1.Contains(3));
            Assert.IsFalse(hashSet1.Contains(99));
        }
    }
}
