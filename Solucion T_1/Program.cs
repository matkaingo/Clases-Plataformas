using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataformas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Primo primo = new Primo();
            Par_Impar clasifi = new Par_Impar();

            int num = 388;

            int numP = primo.Num(num);
            string clasifica = clasifi.Clasifi(numP);

            Console.WriteLine("\nRepaso POO, Plataformas empresariales \n-------------------------------");
            Console.WriteLine("Primoi:\nEl # primo 388 es:\n "+numP);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Par/Impar:\n "+clasifica);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("En Romano:\n" );
            Console.WriteLine("---------------------------------");
            Console.WriteLine("En letra:\n");
            Console.WriteLine("---------------------------------");

            Console.Read();
        }
    }
}
