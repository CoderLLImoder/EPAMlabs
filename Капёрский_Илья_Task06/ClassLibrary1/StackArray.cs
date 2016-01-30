using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StackArray<T> : Stack<T>
    {
        private T[] data;
        public int Capacity { get; private set; }

        public StackArray() : this(10) { }

        public StackArray(int cap)
        {
            Capacity = cap;
            Count = 0;
            data = new T[cap];
        }

        public StackArray(StackArray<T> s)
        {
            Count = s.Count;
            Capacity = s.Capacity;
            data = new T[Capacity];
            s.CopyTo(data, 0);
        }

        public StackArray(StackLink<T> s)
        {
            Count = s.Count;
            Capacity = (Count / 10 + 1) * 10;
            data = new T[Capacity];
            s.CopyTo(data, 0);
        }

        //метод Add вызывает метод Push
        public override void Add(T item)
        {
            Push(item);
        }

        public override void Clear()
        {
            Capacity = 10;
            Count = 0;
            data = new T[Capacity];
        }

        public override object Clone()
        {
            return new StackArray<T>(this);
        }

        public override bool Contains(T item)
        {
            return data.Contains(item);
        }

        public override void CopyTo(T[] array, int index)
        {
            for (int i = index; i < index + Count; i++)
                if (i < array.Length)
                    array[i] = data[i - index];
                else
                    throw new ArgumentOutOfRangeException();
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

        public override T Peek()
        {
            return data[Count - 1];
        }

        public override T Pop()
        {
            return data[--Count];
        }

        public override void Push(T elem)
        {
            if (Count == Capacity)
            {
                Capacity += 10;
                T[] newdata = new T[Capacity];
                for (int i = 0; i < Count; i++)
                    newdata[i] = data[i];
                data = newdata;
            }
            data[Count++] = elem;
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
            StackArray<T> q = obj as StackArray<T>;
            if (q == null || Count != q.Count)
                return false;
            else
            {
                bool b = true;
                int i = 0;
                while (i < Count || b == true)
                {
                    if (!this[i].Equals(q[i]))
                        b = false;
                    i++;
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
            if (Count == 0)
                return "";
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(data[0]);
                for (int i = 1; i < Count; i++)
                {
                    sb.Append(" ");
                    sb.Append(data[i]);
                }
                return sb.ToString();
            }
        }
    }
}