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
            Romano roman = new Romano();
            Letra let = new Letra();

            int num = 400;

            int numP = primo.Num(num);
            string clasifica = clasifi.Clasifi(numP);
            string romano = roman.Conversor(numP);
            string letra = let.enletras(numP);

            Console.WriteLine("\nRepaso POO, Plataformas empresariales \n-------------------------------");
            Console.WriteLine("Primo:\nEl # primo "+num+" es:\n "+numP);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Par/Impar de "+numP+":\n "+clasifica);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(numP+" en Romano:\n " +romano);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(numP+" En letra:\n "+letra);
            Console.WriteLine("---------------------------------");

            Console.Read();
        }
    }
}
