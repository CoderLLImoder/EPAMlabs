using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StackLink<T> : Stack<T>
    {
        Elem<T> Top;

        public StackLink()
        {
            Top = null;
        }

        public StackLink(Stack<T> s)
        {
            Top = null;
            Count = s.Count;
            T[] data = new T[Count];
            s.CopyTo(data, 0);
            for (int i = 0; i < Count; i++)
                Push(data[i]);
        }

        //метод Add вызывает метод Enqueue
        public override void Add(T item)
        {
            Push(item);
        }

        public override void Clear()
        {
            Count = 0;
            Top = null;
        }

        public override object Clone()
        {
            return new StackLink<T>(this);
        }

        public override bool Contains(T item)
        {
            Elem<T> n = Top;
            while (n != null || !n.data.Equals(item))
                n = n.prev;
            if (n == null)
                return false;
            else
                return true;
        }

        public override void CopyTo(T[] array, int index)
        {
            Elem<T> n = Top;
            while (n.prev != null)
                n = n.prev;
            for (int i = index; i < index + Count; i++)
                if (i < array.Length)
                {
                    array[i] = n.data;
                    n = n.next;
                }
                else
                    throw new ArgumentOutOfRangeException();
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    Top = null;
                disposed = true;
            }
        }

        public override T Peek()
        {
            return Top.data;
        }

        public override T Pop()
        {
            T result = Top.data;
            Top = Top.prev;
            Top.next = null;
            Count--;
            return result;
        }

        public override void Push(T elem)
        {
            Top.next = new Elem<T>(elem);
            Top.next.prev = Top;
            Top = Top.next;
            Count++;
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
                {
                    Elem<T> n = Top;
                    while (n.prev != null)
                        n = n.prev;
                    for (int i = 0; i < index; i++)
                        n = n.next;
                    return n.data;
                }
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index < Count)
                {
                    Elem<T> n = Top;
                    while (n.prev != null)
                        n = n.prev;
                    for (int i = 0; i < index; i++)
                        n = n.next;
                    n.data = value;
                }
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        //переопределение стандартных методов
        public override bool Equals(object obj)
        {
            StackLink<T> l = obj as StackLink<T>;
            if (l == null || Count != l.Count)
                return false;
            else
            {
                bool b = true;
                int i = 0;
                while (i < Count || b == true)
                {
                    if (this[i].Equals(l[i]))
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
            if (Top == null)
                return "";
            else
            {
                Elem<T> n = Top;
                while (n.prev != null)
                    n = n.prev;
                StringBuilder sb = new StringBuilder();
                sb.Append(n.data);
                while (n != null)
                {
                    sb.Append(" ");
                    sb.Append(n.data);
                    n = n.next;
                }
                return sb.ToString();
            }
        }
    }
}