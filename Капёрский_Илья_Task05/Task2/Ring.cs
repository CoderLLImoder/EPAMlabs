using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ring
    {
        public Round IN=new Round();
        public Round OUT=new Round();

        public Ring(int Rin, int Rout)
        {
            IN.r = Rin;
            OUT.r = Rout;
        }

        public double GetArea()
        {
            return OUT.GetArea() - IN.GetArea();
        }

        public double GetLength()
        {
            return IN.GetLength() + OUT.GetLength();
        }
    }
}
