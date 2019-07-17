using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Primo test = new Primo();
            int num = 388;

            int primo = test.Num(num);

            Console.WriteLine(primo);
            Console.Read();

        }
    }
}
