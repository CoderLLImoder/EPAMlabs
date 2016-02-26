using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Round : Circle
    {
        public double GetArea()
        {
            return Math.PI * r * r;
        }
    }
}
