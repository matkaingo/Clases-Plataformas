using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    

    class Dividir
    {
        private int divisor;
        private string dividendo;
       
        int mil, cien, diez, un, restmil, restci, restdi;
        int resto;
        string lleva;

        public string divide(int ndivisor,int ndividendo)
        {
            int cont = 0;
            divisor = ndivisor;
            dividendo = ndividendo.ToString();
            lleva = dividendo[cont].ToString();
            Console.WriteLine(dividendo+ "|" +divisor);
            while (resto!=0)
            {
                if (Int32.Parse(lleva)<divisor)
                {
                    lleva += dividendo[cont+1];
                    cont++;
                }

                if (Int32.Parse(lleva) >= divisor)
                {
                    resto = Int32.Parse(lleva) % divisor;

                    lleva = " ";
                    lleva = resto.ToString() + dividendo[cont + 1];
                    Console.WriteLine(dividendo+"");
                    cont++;
                }
            }
            if (divisor<=mil)
            {
                
            }
            //Coge de a valor
            




            return "";
        }

    }
}
