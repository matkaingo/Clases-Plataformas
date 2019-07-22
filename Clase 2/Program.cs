using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucesionFibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibo suce = new Fibo();

            int num = suce.Secuencia(12);

            Console.WriteLine("El # es: "+num);
            Console.Read();
        }
    }
}
