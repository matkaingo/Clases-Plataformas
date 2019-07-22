using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucesionFibo
{
    class Fibo
    {
        public int Secuencia(int fib)
        {
            int l = fib;
            int i = 0;
            int[] fibo = new int[l];
            int result;
            do
            {
                if (i == 0)
                {
                    fibo[i] = 0;
                }
                else if (i == 1)
                {
                    fibo[i] = 1;
                }
                else
                {
                    fibo[i] = fibo[i - 1] + fibo[i - 2];
                }

                result = fibo[i];
                i++;
            } while (i<l);

            return result;
        }
    }
}
