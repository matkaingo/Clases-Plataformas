using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silabas
{
    class separador
    {
        private string s;
        private string separated = ""; //Almacena como va quedadno la palabra separada
        public void separa(string a)
        {
            s = a;
            String[] palabras = s.Split(new string[] { " " }, StringSplitOptions.None);
            Divisor divisor = new Divisor();

            for (int i = 0; i < palabras.Length; i++)
            {
                divisor.setString((String)palabras[i]);
                separated = separated + " " + divisor.silabear();
            }
            Console.WriteLine(separated);
            Console.Read();
        }
    }
}
