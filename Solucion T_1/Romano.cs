using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataformas_1
{
    public class Romano
    {
        public string Conversor(int num)
        {
            int coso = num;
            int i = 0;
            string numero = coso.ToString(); //Adquiere el numero primo
            string miles = "", cen="", dec="", uno="", romano = "";
            int mil, cien, diez, un, restmil,restci,restdi;
            mil = coso / 1000;
            restmil = coso % 1000;
            cien = restmil / 100;
            restci = restmil % 100;
            diez = restci / 10;
            restdi = restci % 10;
            un = restdi;

            switch (mil)
            {
                case 1: romano  = romano + ("M");break;
                case 2: romano = romano + ("MM"); break;
                case 3: romano = romano + ("MMM"); break;
            }
            switch (cien)
            {
                case 1: romano = romano + ("C"); break;
                case 2: romano = romano + ("CC"); break;
                case 3: romano = romano + ("CCC"); break;
                case 4: romano = romano + ("CD"); break;
                case 5: romano = romano + ("D"); break;
                case 6: romano = romano + ("DC"); break;
                case 7: romano = romano + ("DCC"); break;
                case 8: romano = romano + ("DCCC"); break;
                case 9: romano = romano + ("CM"); break;

            }
            switch (diez)
            {
                case 1: romano = romano + ("X"); break;
                case 2: romano = romano + ("XX"); break;
                case 3: romano = romano + ("XXX"); break;
                case 4: romano = romano + ("XL"); break;
                case 5: romano = romano + ("L"); break;
                case 6: romano = romano + ("LX"); break;
                case 7: romano = romano + ("LXX"); break;
                case 8: romano = romano + ("LXXX"); break;
                case 9: romano = romano + ("XC"); break;

            }
            switch (un)
            {
                case 1: romano = romano + ("I"); break;
                case 2: romano = romano + ("II"); break;
                case 3: romano = romano + ("III"); break;
                case 4: romano = romano + ("IV"); break;
                case 5: romano = romano + ("V"); break;
                case 6: romano = romano + ("VI"); break;
                case 7: romano = romano + ("VII"); break;
                case 8: romano = romano + ("VIII"); break;
                case 9: romano = romano + ("IX"); break;

            }

            return romano;
        }

    }
}
