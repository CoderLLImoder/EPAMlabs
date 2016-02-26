using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListLink<T> : List<T>
    {
        private Elem<T> first;     //ссылка на первый элемент списка

       
        public ListLink()
        {
            first = null;
            Count = 0;
        }

        public ListLink(ListArray<T> l)
        {
            Count = l.Count;
            Elem<T> p = first;
            Elem<T> q = null;
            for (int i = 0; i < Count; i++)
            {
                p = new Elem<T>(l[i]);
                p.prev = q;
                if (q != null) q.next = p;
                q = p;
            }
        }

        public ListLink(ListLink<T> l)
        {
            Count = l.Count;
            Elem<T> p = first;
            Elem<T> q = null;
            for (int i = 0; i < Count; i++)
            {
                p = new Elem<T>(l[i]);                 //???????????????????????????????
                p.prev = q;
                if (q != null) q.next = p;
                q = p;
            }
        }

        
        public override void Add(T elem)
        {
            if (first == null)
            {
                first = new Elem<T>(elem);
                Count = 1;
            }
            else
            {
                Elem<T> n = first;
                while (n.next != null)
                    n = n.next;
                n.next = new Elem<T>(elem);
                n.next.prev = n;
                Count++;
            }
        }

        
        public override void Clear()
        {
            Count = 0;
            first = null;
        }

        public override object Clone()
        {
            return new ListLink<T>(this);
        }

        public override bool Contains(T elem)
        {
            if (first == null)
                return false;
            else
            {
                Elem<T> p = first;
                while (p != null || !elem.Equals(p.data))
                    p = p.next;
                if (p == null)
                    return false;
                else
                    return true;
            }
        }

        public override void CopyTo(T[] array, int index)
        {
            Elem<T> p = first;
            for (int i = index; i < index + Count; i++)
                if (i < array.Length)
                {
                    array[i] = p.data;
                    p = p.next;
                }
                else
                    throw new ArgumentOutOfRangeException();
        }

        
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    first = null;
                disposed = true;
            }
        }

        public override int Find(T elem)
        {
            if (first == null)
                return -1;
            else
            {
                int i = 0;
                Elem<T> n = first;
                while (n != null || !n.data.Equals(elem))
                {
                    n = n.next;
                    i++;
                }
                if (n == null)
                    //возвращает -1 если элемент не найден
                    return -1;
                else
                    //возвращает его индекс в случае успеха
                    return i;
            }
        }

        public override void Insert(T elem, int index)
        {
            if (first == null)
            {
                first = new Elem<T>(elem);
                Count++;
            }
            else
            {
                int i = 0;
                Elem<T> n = first;
                while (n.next != null || i != index)
                {
                    n = n.next;
                    i++;
                }
                if (i == index)
                {
                    Elem<T> p = new Elem<T>(elem);
                    p.prev = n;
                    p.next = n.next;
                    n.next.prev = p;
                    n.next = p;
                }
                else
                {
                    n.next = new Elem<T>(elem);
                    n.next.prev = n;
                }
                Count++;
            }
        }

        public override bool Remove(T elem)
        {
            if (first == null)
                return false;
            else
            {
                Elem<T> n = first;
                while (n.next != null || !n.next.data.Equals(elem))
                    n = n.next;
                if (n.next == null)
                    return false;
                else
                {
                    n.next.next.prev = n;
                    n.next = n.next.next;
                    Count--;
                    return true;
                }
            }
        }

        public override T this[int index]
        {
            get
            {
                if (index < Count)
                {
                    Elem<T> n = first;
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
                    Elem<T> n = first;
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
            ListLink<T> l = obj as ListLink<T>;
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
            if (first == null)
                return "";
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(first.data);
                Elem<T> n = first;
                while (n.next != null)
                {
                    n = n.next;
                    sb.Append(" ");
                    sb.Append(n.data);
                }
                return sb.ToString();
            }

        }
    }
}