using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ABC
    {
       public struct point
        {
            public double p1;
            public double p2;
        }

        private point a;
        public void seta(double x, double y)
        {
            a.p1 = x;
            a.p2 = y;
        }
        public point geta()
        {
            return a;
        }

        private point b;
        public void setb(double x, double y)
        {
            b.p1 = x;
            b.p2 = y;
        }
        public point getb()
        {
            return b;
        }

        private point c;
        public void setc(double x, double y)
        {
            c.p1 = x;
            c.p2 = y;
        }
        public point getc()
        {
            return c;
        }

        public double P()
        {
            double ab = Math.Sqrt(Math.Pow((b.p1 - a.p1), 2) + Math.Pow((b.p2 - a.p2), 2));
            double bc = Math.Sqrt(Math.Pow((c.p1 - b.p1), 2) + Math.Pow((c.p2 - b.p2), 2));
            double ca = Math.Sqrt(Math.Pow((c.p1 - a.p1), 2) + Math.Pow((c.p2 - a.p2), 2));
            return (ab+bc+ca);
        }

        public double S()
        {
            double p2 = P()/2;
            double ab = Math.Sqrt(Math.Pow((b.p1 - a.p1), 2) + Math.Pow((b.p2 - a.p2), 2));
            double bc = Math.Sqrt(Math.Pow((c.p1 - b.p1), 2) + Math.Pow((c.p2 - b.p2), 2));
            double ca = Math.Sqrt(Math.Pow((c.p1 - a.p1), 2) + Math.Pow((c.p2 - a.p2), 2));
            return(Math.Sqrt(p2 * (p2 - ab)*(p2-bc)*(p2-ca)));
            
        }
    }
}
