using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round
    {
        private double x;
        public void setx(double value)
        {
            x=value;
        }
        public double getx()
        {
            return x;
        }

        private double y;
        public void sety(double value)
        {
            y = value;
        }
        public double gety()
        {
            return x;
        }

        private double r;
        public void setr(double value)
        {
            r = value;
        }
        public double getr()
        {
            return x;
        }

        public double Length()
        {
            return (2*Math.PI*r);
        }

        public double Square()
        {
            return (Math.PI * r * r);
        }
    }
}
