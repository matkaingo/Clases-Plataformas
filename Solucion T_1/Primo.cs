using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroPrimo
{
    public class Primo
    {

        public int Num(int numero)
        {
            int divisor = 2;
            int con = 0;
            int numeros = 0;
            while (con < numero) {
                for (int i = 1; i <= divisor; i++)
                {
                    if (divisor % i == 0)
                    {
                        numeros++;
                    }
                }
                if (numeros <= 2)
                {
                    con++;
                }
                divisor++;
                numeros = 0;
            }

      
            return divisor-1;
        }
    }
}

