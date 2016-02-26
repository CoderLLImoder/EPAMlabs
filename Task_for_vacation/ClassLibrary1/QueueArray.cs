using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class QueueArray<T> : Queue<T>
    {
        private T[] data;       
        public int Capacity { get; private set; }  //размер массива
        private int head;       //голова очереди
        private int tail;       //хвост очереди
        private bool full;      //флаг отображающий заполненность очереди


       
        public QueueArray() : this(10) { }

        public QueueArray(int cap)
        {
            Count++;
            Capacity = cap;
            head = 0;
            tail = 0;
            full = false;
            data = new T[cap];
        }

        public QueueArray(QueueArray<T> q)
        {
            Count = q.Count;
            Capacity = q.Capacity;
            data = new T[Capacity];
            q.CopyTo(data, 0);
        }

        public QueueArray(QueueLink<T> q)
        {
            Count = q.Count;
            Capacity = ((Count / 10) + 1) * 10;
            data = new T[Capacity];
            q.CopyTo(data, 0);
        }

       
        //метод Add вызывает метод Enqueue
        public override void Add(T item)
        {
            Enqueue(item);
        }

        
        public override void Clear()
        {
            Capacity = 10;
            Count = 0;
            head = 0; tail = 0;
            full = false;
            data = new T[Capacity];
        }

        public override object Clone()
        {
            return new QueueArray<T>(this);
        }

        public override bool Contains(T item)
        {
            return data.Contains(item);
        }

        public override void CopyTo(T[] array, int index)
        {
            int p = head;
            for (int i = index; i < index + Count; i++)
                if (i < array.Length)
                {
                    array[i] = data[p];
                    p = (p + 1) % Capacity;
                }
                else
                    throw new ArgumentOutOfRangeException();
        }

        public override T Dequeue()
        {
            if (head == tail && !full)
                throw new InvalidOperationException();
            else
            {
                T result = data[head];
                head = (head + 1) % Capacity;
                return result;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    data = null;
                disposed = true;
            }
        }

        public override void Enqueue(T elem)
        {
            if (full)
            {
                //уведичение ёмкости при необходимости
                Capacity += 10;
                T[] newdata = new T[Capacity];
                newdata[0] = data[head];
                head = (head + 1) % (Capacity - 10);
                int i = 1;
                while (head != tail)
                {
                    newdata[i] = data[head];
                    head = (head + 1) % (Capacity - 10);
                    i++;
                }
                head = 0;
                newdata[Count++] = elem;
                tail = Count;

            }
            else
            {
                data[tail] = elem;
                tail = (tail + 1) % Capacity;
                if (head == tail) full = true;
            }
        }

        public override T Peek()
        {
            return data[head];
        }

        //метод определён из-за интерфейса ICollection, для удаления элементов используется метод Dequeue
        public override bool Remove(T item)
        {
            return false;
        }

        protected override T this[int index]
        {
            get
            {
                if (index < Count)
                    return data[index];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index < Count)
                    data[index] = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        //переопределение стандартных методов

        public override bool Equals(object obj)
        {
            QueueArray<T> q = obj as QueueArray<T>;
            if (q == null || Count != q.Count)
                return false;
            else
            {
                int i1 = head, i2 = q.head;
                bool b = true;
                while (i1 != tail || b == true)
                {
                    if (!this[i1].Equals(q[i2]))
                        b = false;
                    i1 = (i1 + 1) % Capacity;
                    i2 = (i2 + 1) % q.Capacity;
                }
                return b;
            }
        }

        public override int GetHashCode()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Count; i++)
                sb.Append(this[i]);
            return int.Parse(sb.ToString());
        }

        public override string ToString()
        {
            if (head == tail && !full)
                return "";
            else
            {
                StringBuilder sb = new StringBuilder();
                int i = head;
                sb.Append(data[i]);
                i = (i + 1) % Capacity;
                while (i != tail)
                {
                    sb.Append(" ");
                    sb.Append(data[i]);
                    head = (head + 1) % Capacity;
                }
                return sb.ToString();
            }
        }
    }
}
