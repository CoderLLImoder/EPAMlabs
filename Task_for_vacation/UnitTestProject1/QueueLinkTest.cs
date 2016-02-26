using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class QueueLinkTest
    {
        [TestMethod] //заполнение очереди 
        public void AddTest()
        {
            QueueLink<object> data = new QueueLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);

        }

        [TestMethod] //получение первого элемента
        public void TakeTest()
        {
            QueueLink<object> data = new QueueLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Peek();

        }

        [TestMethod] //получение элемента из пустой очереди
        public void TakeEmptyTest()
        {
            QueueLink<object> data = new QueueLink<object>();
            data.Peek();

        }

        [TestMethod] //ICloneable
        public void CloneTest()
        {
            QueueLink<object> data = new QueueLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Clone();

        }

        [TestMethod] //IEnumerable
        public void EnumerableTest()
        {
            QueueLink<object> data = new QueueLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.GetEnumerator();

        }

        [TestMethod] //IDisposable
        public void DisposeTest()
        {
            QueueLink<object> data = new QueueLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Dispose();

        }
    }
}