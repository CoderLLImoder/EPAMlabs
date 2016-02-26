using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class ListArrayTest
    {
        [TestMethod] //заполнение списка 
        public void AppendTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(10);

        }

        [TestMethod] //заполнение с использованием Insert
        public void InsertTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Insert(4, 1);

        }

        [TestMethod] //Добавление элемента в заполненный список
        public void AppendInFullListTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(4);
            data.Add(10);

        }

        [TestMethod] //Поиск существующего элемента
        public void FindItemTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Find(10);
        }

        [TestMethod] //Поиск не существующего элемента
        public void FindNotExistItemTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Find(11);
        }

        [TestMethod] //Поиск в пустом списке
        public void FindInEmptyListTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Find(11);
        }

        [TestMethod] //Удаление элемента из списка 
        public void DeleteTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Remove(2);

        }

        [TestMethod] //Удаление несуществующего элемента 
        public void DeleteNotExistItemTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Remove(5);

        }

        [TestMethod] //ICloneable
        public void CloneTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Clone();

        }

        [TestMethod] //IEnumerable
        public void EnumerableTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.GetEnumerator();

        }

        [TestMethod] //IDisposable
        public void DisposeTest()
        {
            int n = 3;
            ListArray<object> data = new ListArray<object>(n);
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Dispose();

        }



    }
}