 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListArray<T> : List<T>
    {
        private T[] data;         //массив значений
        protected int Capacity;     //ёмкость массива

      
        public ListArray() : this(10) { }

        public ListArray(ListArray<T> l)
        {
            Count = l.Count;
            Capacity = l.Capacity;
            data = new T[Capacity];
            for (int i = 0; i < Count; i++)
                data[i] = l.data[i];
        }

        public ListArray(ListLink<T> l)
        {
            Count = l.Count;
            Capacity = ((Count / 10) + 1) * 10;
            data = new T[Capacity];
            for (int i = 0; i < Count; i++)
                data[i] = l[i];
        }

        public ListArray(int capacity)
        {
            Count = 0;
            Capacity = capacity;
            data = new T[Capacity];
        }

        //метод getCapacity возвращает текущую ёмкость массива
        public int getCapacity()
        {
            return Capacity;
        }

        

       
        public override void Add(T elem)
        {
            if (Count == Capacity)
            {
                //увеличиваем ёмкость если достигли предела
                Capacity += 10;
                T[] newdata = new T[Capacity];
                for (int i = 0; i < Count; i++)
                    newdata[i] = data[i];
                newdata[Count++] = elem;
                data = newdata;
                return;
            }
            else
                data[Count++] = elem;
        }

       
        public override void Clear()
        {
            Capacity = 10;
            Count = 0;
            data = new T[Capacity];
        }

       
        public override object Clone()
        {
            return new ListArray<T>(this);
        }

       
        public override bool Contains(T elem)
        {
            return data.Contains(elem);
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

        
        public override int Find(T elem)
        {
            int i = 0;
            while (i < Count)
            {
                if (data[i].Equals(elem))
                    //возвращает его индекс в случае успеха
                    return i;
                i++;
            }
            //возвращает -1, если элемент не найден
            return -1;
        }

        
        public override void Insert(T elem, int index)
        {
            if (index >= Count)
                //если указанная позиция больше кол-ва элементов, то новый элемент становится следующим за последним
                Add(elem);
            else if (Count != Capacity)
            {
                int i;
                for (i = Count; i > index; i--)
                    data[i] = data[i - 1];
                data[i] = elem;
                Count++;
            }
            else
            {
                //увеличение ёмкости при необходимости
                Capacity += 10;
                T[] newdata = new T[Capacity];
                for (int i = 0; i < Count; i++)
                    newdata[i] = data[i];
                data = newdata;
                Insert(elem, index);
            }
            return;
        }

        
        public override bool Remove(T elem)
        {
            int index = Find(elem);
            if (index != -1)
            {
                for (int i = index; i < Count - 1; i++)
                    data[i] = data[i + 1];
                Count--;
                return true;
            }
            else
                return false;
        }

       
        public override T this[int index]
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
            ListArray<T> l = obj as ListArray<T>;
            if (l == null || Count != l.Count)
                return false;
            else
            {
                bool b = true;
                int i = 0;
                while (i < Count || b == true)
                {
                    if (!this[i].Equals(l[i]))
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
            if (Count != 0)
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
            else return "";
        }
    }
}