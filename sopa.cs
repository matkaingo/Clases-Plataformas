class Sopa
    {
        
        Random pos = new Random();
        Random posX = new Random();
        Random posY = new Random();
        int posicionP;
        int pX;
        int py;
        string pActual;
        int[,] matriz;
        int fila;
        int colum;
        int cont;


        public string SopaDeLetras(int F, int C, string[] palabra)
        {
            fila = F;
            colum = C;
            matriz = new int[fila, colum];

            for (int i = 0; i< palabra.Length-1; i++)
            {
                posicionP = pos.Next(1, 6);
                pX = pos.Next(0, fila);
                py = pos.Next(0, colum);
                pActual = palabra[i];

                switch (posicionP)
                {
                    case 1: //Horizontal derecho

                        for (int k = 0; k<fila;k++)
                        {
                            for (int o = 0;o <colum; o++)
                            {
                                while (matriz[o, k].Equals(""))
                                {
                                    if (((pActual.Length) + pX) <= fila)
                                    {
                                        matriz[k, o] = pActual[k];
                                    }
                                    else posicionP = 3;
                                }
                                o++;
                            }
                            k++;
                        }
                        

                        break;

                    case 2: //Horizontal revez

                        break;

                    case 3: //Vertical derecho

                        break;

                    case 4: //Vertical revez

                        break;

                    case 5: //Diagonal derecho

                        break;

                    case 6: //Diagonal revez

                        break;

                }
            }


            return "";
        }

    }
}
