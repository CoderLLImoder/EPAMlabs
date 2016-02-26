using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class StackLinkTest
    {
        [TestMethod] //заполнение стека 
        public void PushTest()
        {
            StackLink<object> data = new StackLink<object>();
            data.Push(8);
            data.Push(6);
            data.Push(10);

        }

        [TestMethod] //получение последнего элемента
        public void PopTest()
        {
            StackLink<object> data = new StackLink<object>();
            data.Push(8);
            data.Push(6);
            data.Push(10);
            data.Pop();

        }

        [TestMethod] //получение элемента из пустго стека
        public void PopEmptyTest()
        {
            StackLink<object> data = new StackLink<object>();
            data.Pop();

        }

        [TestMethod] //ICloneable
        public void CloneTest()
        {
            StackLink<object> data = new StackLink<object>();
            data.Push(8);
            data.Push(6);
            data.Push(10);
            data.Clone();

        }

        [TestMethod] //IEnumerable
        public void EnumerableTest()
        {
            StackLink<object> data = new StackLink<object>();
            data.Push(8);
            data.Push(6);
            data.Push(10);
            data.GetEnumerator();

        }

        [TestMethod] //IDisposable
        public void DisposeTest()
        {
            StackLink<object> data = new StackLink<object>();
            data.Push(8);
            data.Push(6);
            data.Push(10);
            data.Dispose();

        }
    }
}