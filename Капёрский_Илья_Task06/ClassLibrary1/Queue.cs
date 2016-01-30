using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Queue<T> : ICollection<T>, IEnumerable<T>, ICloneable, IDisposable
    {
        public int Count { get; protected set; }
        public bool IsReadOnly { get; }
        protected bool disposed = false;

        //перегрузка индексатора
        protected abstract T this[int index] { get; set; }

        //метод определён из за интерфейса ICollection
        public abstract void Add(T item);

        //очистка очереди
        public abstract void Clear();

        //копирование объекта
        public abstract object Clone();

        //проверка наличия элемента
        public abstract bool Contains(T item);

        //копирование очереди в массив с указанного индекса массива
        public abstract void CopyTo(T[] array, int arrayIndex);

        //удаление первого элемента очереди
        public abstract T Dequeue();

        //добавление элемента в начало очереди 
        public abstract void Enqueue(T elem);

        //возвращение первого элемента очереди
        public abstract T Peek();

        //метод определён из за интерфейса ICollection, для удаления элементов используется метод Dequeue
        public abstract bool Remove(T item);

        //получение перечеслителя
        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
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

        ~Queue()
        {
            Dispose(false);
        }
    }
}