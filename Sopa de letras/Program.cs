using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopa_de_letras
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pal = new string[6] {"HOLA","PATO","COLA","GUARO","ÑALEA","TORRE"};
            Sopa sop = new Sopa();
            sop.SopaDeLetras(20,31,pal);
            
        }
    }
}
