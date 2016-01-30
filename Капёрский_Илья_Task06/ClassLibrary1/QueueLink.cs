using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class QueueLink<T> : Queue<T>
    {
        private Elem<T> Head;   //начало
        private Elem<T> Tail;   //конец

        public QueueLink()
        {
            Head = null;
            Tail = null;
        }

        public QueueLink(QueueLink<T> q)
        {
            Head = null;
            Tail = null;
            Elem<T> n = q.Head;
            Count = q.Count;
            while (n != null)
            {
                Enqueue(n.data);
                n = n.next;
            }
        }

        public QueueLink(QueueArray<T> q)
        {
            Head = null;
            Tail = null;
            Count = q.Count;
            T[] data = new T[Count];
            q.CopyTo(data, 0);
            for (int i = 0; i < Count; i++)
                Enqueue(data[i]);
        }

        //метод Add вызывает метод Enqueue
        public override void Add(T item)
        {
            Enqueue(item);
        }

        public override void Clear()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        public override object Clone()
        {
            return new QueueLink<T>(this);
        }

        public override bool Contains(T item)
        {
            Elem<T> n = Head;
            while (n != Tail || !n.data.Equals(item))
                n = n.next;
            if (n == Tail)
                return false;
            else
                return true;
        }

        public override void CopyTo(T[] array, int index)
        {
            Elem<T> n = Head;
            for (int i = index; i < index + Count; i++)
                if (i < array.Length)
                {
                    array[i] = n.data;
                    n = n.next;
                }
                else
                    throw new ArgumentOutOfRangeException();
        }

        public override T Dequeue()
        {
            if (Head == null)
                throw new InvalidOperationException();
            else
            {
                T result = Head.data;
                if (Head.next == null)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head.next.prev = null;
                    Head = Head.next;
                }
                Count--;
                return result;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Head = null;
                    Tail = null;
                }
                disposed = true;
            }
        }

        public override void Enqueue(T elem)
        {
            if (Head == null)
            {
                Head = new Elem<T>(elem);
                Tail = Head;
                Count++;
            }
            else
            {
                Tail.next = new Elem<T>(elem);
                Tail.next.prev = Tail;
                Tail = Tail.next;
                Count++;
            }
        }

        public override T Peek()
        {
            return Head.data;
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
                    Elem<T> n = Head;
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
                    Elem<T> n = Head;
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
            QueueLink<T> l = obj as QueueLink<T>;
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
            if (Head == null)
                return "";
            else
            {
                Elem<T> n = Head.next;
                StringBuilder sb = new StringBuilder();
                sb.Append(Head.data);
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
