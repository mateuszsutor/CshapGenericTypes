using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCollectionsTests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void UsePeekMethodStack() 
        {
            var stack = new Stack<int>();

            stack.Push(1);           
            stack.Push(2);           
            stack.Push(3);           
            stack.Push(4);           


            //Peek() tylko podgląda co jest na ostatnim miejscu w stosie(pierwsze do wyjscia) !!! Nie sciąga elementu ze stosu!!!
            Assert.AreEqual(4, stack.Peek());
        }


        [TestMethod]
        public void UseContainsMethodStack()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Assert.IsTrue(stack.Contains(3));
            Assert.IsFalse(stack.Contains(9));

        }


        [TestMethod]
        public void UseToArrayMethodStack()
        {
            Queue<int> queue = new Queue<int>();

            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            var array = stack.ToArray();
            stack.Pop();

            Assert.AreEqual(4, array[0]);
            Assert.AreEqual(3, stack.Count());

        }


        [TestMethod]
        public void UseClearMethodStack()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Clear();

            Assert.AreEqual(0, stack.Count());

        }


    }
}
