using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Elem<T>
    {
        public T data;
        public Elem<T> next;
        public Elem<T> prev;

        public Elem(T d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
}

