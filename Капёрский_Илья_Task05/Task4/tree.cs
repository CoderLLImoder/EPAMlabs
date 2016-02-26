using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class tree : Barrier
    {
        public Place RndStart()
        {
            return start;
        }

        public Place RndFinish()
        {
            return finish;
        }
    }
}
