using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sopa_de_letras
{


    class Sopa
    {

        Random pos = new Random();
        int forma;
        int pfil;
        int pcol;
        int ascii;
        string pActual;
        char[,] matriz;
        int filas;
        int colums;
        int cont=0; //Contador para la palabra
        bool vacio = false;
        string[] output ;
        string path = @"C:\\Users\\Usuario\\Desktop\\Plataformas\\Sopa.txt";



        public void SopaDeLetras(int F, int C, string[] palabra)
        {
            filas = F;
            colums = C;
            matriz = new char[filas, colums];

            output = new string[colums];


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matriz[i, j] = '.';


                }


            }

            //Almacena la palabra

            //horizontal normal po ahora cogiendo la primera palabra
            for (int k = 0; k < palabra.Length; k++)
            {
                forma = pos.Next(1, 7);
                /*1:Hotrizontal normal, 2: horizontal revez,  3: vertical, 4: vertical revez
                 * 5: diagonal, 6: diagonal revez
                 * 
                 */
                switch (forma)
                {

                    case 1://Horizontal
                        pfil = pos.Next(0, filas - 1);
                        pcol = pos.Next(0, colums - 1);

                        pActual = palabra[k];
                        int con = pcol;

                        if (pcol + pActual.Length <= colums) //Revisa que quepa
                        {
                            while (con < pcol + pActual.Length) //Revisa que los espacios esten vacios
                            {
                                if (matriz[pfil, con].Equals('.'))
                                {
                                    vacio = true;
                                }
                                else
                                {
                                    vacio = false;
                                    forma = 3;
                                    break;
                                }
                                con++;
                            }
                            if (pActual.Length + pcol <= colums && vacio == true)
                            {


                                for (int i = pcol; i < (pActual.Length + pcol); i++)//Agrega
                                {

                                    matriz[pfil, i] = pActual[cont];

                                    cont++;


                                }

                            }
                            cont = 0;

                        }
                        else
                        {
                            forma = 3;
                        }
                        break;

                    case 2:
                        //horizontal revez po ahora cogiendo la segunda palabra
                        pfil = pos.Next(0, filas - 1);
                        pcol = pos.Next(0, colums - 1);

                        pActual = palabra[k];
                        cont = pActual.Length - 1;
                        con = pcol;
                        if (pcol + pActual.Length <= colums) //Revisa que quepa
                        {
                            while (con < pcol + pActual.Length) //Revisa que los espacios esten vacios
                            {
                                if (matriz[pfil, con].Equals('.'))
                                {
                                    vacio = true;
                                }
                                else
                                {
                                    vacio = false;
                                    forma = 3;
                                    break;
                                }
                                con++;
                            }
                            if (pActual.Length + pcol <= colums && vacio == true)
                            {
                                for (int i = pcol; i < (pActual.Length + pcol); i++)
                                {


                                    matriz[pfil, i] = pActual[cont];

                                    cont--;


                                }
                            }
                            cont = 0;

                        }
                        else
                        {
                            forma = 3;
                        }
                        break;

                    case 3:
                        //Vertical normal cogiendo la tercera palabra

                        pfil = pos.Next(0, filas - 1);
                        pcol = pos.Next(0, colums - 1);

                        pActual = palabra[k];
                        int conf = pfil;
                        cont = 0;

                        if (pfil + pActual.Length <= filas)
                        {
                            while (conf < pfil + pActual.Length) //Revisa que los espacios esten vacios
                            {
                                if (matriz[conf, pcol].Equals('.'))
                                {
                                    vacio = true;
                                }
                                else
                                {
                                    vacio = false;
                                    forma = 5;
                                    break;
                                }
                                conf++;
                            }
                            if (pActual.Length + pfil <= filas && vacio == true)
                            {
                                for (int i = pfil; i < (pActual.Length + pfil); i++)
                                {

                                    matriz[i, pcol - 1] = pActual[cont];

                                    cont++;



                                }
                            }
                            cont = 0;
                        }
                        else
                        {
                            forma = 5;
                        }

                        break;

                    case 4:
                        //Vertical revez cogiendo la 4ta palabra

                        pfil = pos.Next(0, filas - 1);
                        pcol = pos.Next(0, colums - 1);

                        pActual = palabra[k];
                        conf = pfil;
                        if (pfil + pActual.Length <= filas)
                        {
                            while (conf < pfil + pActual.Length) //Revisa que los espacios esten vacios
                            {
                                if (matriz[conf, pcol].Equals('.'))
                                {
                                    vacio = true;
                                }
                                else
                                {
                                    vacio = false;
                                    forma = 5;
                                    break;
                                }
                                conf++;
                            }
                            if (pActual.Length + pfil <= filas && vacio == true)
                            {
                                cont = pActual.Length - 1;
                                for (int i = pfil; i < (pActual.Length + pfil); i++)
                                {

                                    matriz[i, pcol] = pActual[cont];

                                    cont--;


                                }
                            }
                            cont = 0;

                        }
                        else
                        {
                            forma = 5;
                        }
                        break;

                    case 5:
                        //Diagonal Normal cogiendo la5ta palabra

                        pfil = pos.Next(0, filas - 1);
                        pcol = pos.Next(0, colums - 1);

                        pActual = palabra[k];
                        conf = pfil;
                        con = pcol;
                        if (pfil + pActual.Length <= filas && pcol + pActual.Length <= colums)
                        {
                            while (conf < pfil + pActual.Length && con < pcol + pActual.Length) //Revisa que los espacios esten vacios
                            {
                                if (matriz[conf, con].Equals('.'))
                                {
                                    vacio = true;
                                }
                                else
                                {
                                    vacio = false;
                                    forma = 1;
                                    break;
                                }
                                conf++;
                                con++;
                            }
                            if (pActual.Length + pfil <= filas && vacio == true)
                            {
                                for (int i = pfil; i < (pActual.Length + pfil); i++)
                                {


                                    matriz[i, pcol] = pActual[cont];

                                    cont++;
                                    pcol++;




                                }
                            }
                            cont = 0;
                        }
                        else
                        {
                            forma = 1;
                        }
                        break;

                    case 6:
                        //Diagonal revez con la palabra 6

                        pfil = pos.Next(0, filas - 1);
                        pcol = pos.Next(0, colums - 1);

                        pActual = palabra[k];
                        conf = pfil;
                        con = pcol;
                        if (pfil + pActual.Length <= filas && pcol + pActual.Length <= colums)
                        {
                            while (conf < pfil + pActual.Length && con < pcol + pActual.Length) //Revisa que los espacios esten vacios
                            {
                                if (matriz[conf, con].Equals('.'))
                                {
                                    vacio = true;
                                }
                                else
                                {
                                    vacio = false;
                                    forma = 1;
                                    break;
                                }
                                conf++;
                                con++;
                            }
                            if (pActual.Length + pfil <= filas && vacio == true)
                            {
                                cont = pActual.Length - 1;
                                for (int i = pfil; i < (pActual.Length + pfil); i++)
                                {


                                    matriz[i, pcol] = pActual[cont];

                                    cont--;
                                    pcol++;




                                }
                            }
                            cont = 0;
                        }
                        else
                        {
                            forma = 1;
                        }
                        break;
                }


            }



            //Letras al azar
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    ascii = pos.Next(97, 122); //Caracteres ascci al azar


                    char conver = (char)ascii;
                    if (matriz[i, j].Equals('.')) { matriz[i, j] = conver; }


                }


            }

            //Lo imprime 

            using (StreamWriter file = new StreamWriter(path,true))
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {

                    Console.Write(matriz[i, j] + " ");
                     file.Write(matriz[i, j]+" "); //se agrega información al documento

                     
                    }
                    file.WriteLine();
                    Console.WriteLine();


                }

                file.WriteLine("Palabras: ");

                for (int i = 0; i<palabra.Length; i++)
                {
                    file.Write(" "+palabra[i]);
                }
                file.Close();

                Console.Read();
                
            }
        }

       
    }
}

