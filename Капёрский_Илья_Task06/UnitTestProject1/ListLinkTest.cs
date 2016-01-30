using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class ListLinkTest
    {
        [TestMethod] //Тзаполнение списка 
        public void AppendTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);

        }

        [TestMethod] //заполнение с использованием Insert
        public void InsertTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Insert(4, 1);

        }

        [TestMethod] //Добавление элемента в заполненный список
        public void AppendInFullListTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(4);
            data.Add(10);

        }

        [TestMethod] //Поиск существующего элемента
        public void FindItemTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Find(10);
        }

        [TestMethod] //Поиск не существующего элемента
        public void FindNotExistItemTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Find(11);
        }

        [TestMethod] //Удаление элемента из списка 
        public void DeleteTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Remove(2);

        }

        [TestMethod] //Удаление несуществующего элемента 
        public void DeleteNotExistItemTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Remove(5);

        }

        [TestMethod] //Поиск в пустом списке
        public void FindInEmptyListTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Find(11);
        }

        [TestMethod] //ICloneable
        public void CloneTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Clone();

        }

        [TestMethod] //IEnumerable
        public void EnumerableTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.GetEnumerator();

        }

        [TestMethod] //IDisposable
        public void DisposeTest()
        {
            ListLink<object> data = new ListLink<object>();
            data.Add(8);
            data.Add(6);
            data.Add(10);
            data.Dispose();

        }
    }
}
