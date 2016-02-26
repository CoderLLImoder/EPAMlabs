using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Circle
    {
        public int x;
        public int y;
        public int r;
        public double GetLength()
        {
            return 2 * Math.PI * r;
        }
    }
}
