using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class List<T> : ICollection<T>, IEnumerable<T>, IDisposable, ICloneable
    {
        public int Count { get; protected set; }        //длина списка
        public bool IsReadOnly { get; }
        protected bool disposed = false;                // Для определения избыточных вызовов

        //добавление элемента в конец
        public abstract void Add(T elem);

        //очистка списка
        public abstract void Clear();

        //создание копии объекта
        public abstract object Clone();

        //проверка наличия элемента
        public abstract bool Contains(T elem);

        //копирование списка в массив с указанного индекса массива
        public abstract void CopyTo(T[] array, int index);

        //получение индекса элемента
        public abstract int Find(T elem);

        //перегрузка индексатора
        public abstract T this[int index] { get; set; }

        //добавлеие элемента на указанную позицию
        public abstract void Insert(T elem, int index);

        //удаление элемента
        public abstract bool Remove(T elem);

        //получение перечислятеля
        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator<T>(this);
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

        ~List()
        {
            Dispose(false);
        }
    }
}
    