using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataformas_1
{
    public class Par_Impar
    {
        public string Clasifi(int num)
        {
            int numo = num;
            string clasi = "";
                if (numo%2==0)
                {
                    clasi = "Es par";
                }
            else
            {
                clasi = "Es impar";

            }
            return clasi;
        }
              
    }
   
}
