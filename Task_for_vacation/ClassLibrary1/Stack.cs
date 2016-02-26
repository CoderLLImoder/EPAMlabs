using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Stack<T> : ICollection<T>, IEnumerable<T>, ICloneable, IDisposable
    {
        public int Count { get; protected set; }
        public bool IsReadOnly { get; }
        protected bool disposed = false;

        //перегрузка индексатора
        protected abstract T this[int index] { get; set; }

        //метод определён из за интерфейса ICollection
        public abstract void Add(T item);

        //очистка стека
        public abstract void Clear();

        //создание копии объекта
        public abstract object Clone();

        //проверка наличия элемента
        public abstract bool Contains(T elem);

        //копирование списка в массив с указанного индекса массива
        public abstract void CopyTo(T[] array, int index);

        //возвращение вершины стека
        public abstract T Peek();

        //извлечение вершины стека
        public abstract T Pop();

        //добавление элемента в стек
        public abstract void Push(T elem);

        //метод определён из за интерфейса ICollection, для удаления элементов используется метод Pop
        public abstract bool Remove(T item);

        //получение перечеслителя
        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
       
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected abstract void Dispose(bool disposing);

        ~Stack()
        {
            Dispose(false);
        }
    }
}