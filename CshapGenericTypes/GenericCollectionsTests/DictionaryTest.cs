using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsTests
{

    [TestClass]
    public class DictionaryTest
    {
        [TestMethod]
        public void UseDictionaryAsMap()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "jeden");
            map.Add(2, "dwa");
            map.Add(3, "trzy");
            map.Add(4, "cztery");

            Assert.AreEqual("jeden", map[1]);
        }


        [TestMethod]
        public void SearchInDictionaryKey()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "jeden");
            map.Add(2, "dwa");
            map.Add(3, "trzy");
            map.Add(4, "cztery");

            Assert.IsTrue(map.ContainsKey(1));
        }

        [TestMethod]
        public void SearchInDictionaryValue()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "jeden");
            map.Add(2, "dwa");
            map.Add(3, "trzy");
            map.Add(4, "cztery");

            Assert.IsTrue(map.ContainsValue("dwa"));
        }

        [TestMethod]
        public void HasRemoveValueFromDictionaryByKey()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "jeden");
            map.Add(2, "dwa");
            map.Add(3, "trzy");
            map.Add(4, "cztery");

            map.Remove(2);

            Assert.IsFalse(map.ContainsKey(2));
            Assert.AreEqual(3, map.Count);
        }


        [TestMethod]
        public void ClearDictionaryTest()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "jeden");
            map.Add(2, "dwa");
            map.Add(3, "trzy");
            map.Add(4, "cztery");

            map.Clear();

            Assert.AreEqual(0, map.Count);
        }


        [TestMethod]
        public void UseDictionaryAsDictionary()
        {
            var map = new Dictionary<string, string>();
            map.Add("one", "jeden");
            map.Add("two", "dwa");
            map.Add("three", "trzy");
            map.Add("four", "cztery");
           
            Assert.AreEqual("trzy", map["three"]);
        }


    }
}
