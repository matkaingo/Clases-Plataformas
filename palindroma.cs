public void Clasificacion(string Palabra)
        {
            int ult = Palabra.Length - 1;
            bool Error = false;
            int i = 0;

            while ((i < ult) && (!Error))
            {
                if (Palabra[i] == Palabra[ult])
                {
                    i++;
                    ult--;
                }
                else { Error = true; }
            }

            if (!Error)
            {
                Console.WriteLine("Es Palindorma");
            }
            else { Console.WriteLine("no es palindorma"); }


        }
        
