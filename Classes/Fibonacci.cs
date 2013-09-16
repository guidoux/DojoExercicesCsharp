using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoExercices
{
    public class Fibonacci
    {
        public int fibo(int x)
        {
            if (x == 0)
                return 0;
            else if (x == 1)
                return 1;
            else
                return fibo(x - 2) + fibo(x - 1);
        }
    }
}
