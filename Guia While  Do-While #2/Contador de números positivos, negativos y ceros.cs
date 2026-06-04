int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            string entrada;

            do
            {
                Console.Write("Ingrese un número (o 'X' / 'N' para salir): ");
                entrada = Console.ReadLine();

                if (entrada != "X" && entrada != "x" && entrada != "N" && entrada != "n")
                {
                    int numero = Convert.ToInt32(entrada);

                    if (numero > 0)
                    {
                        positivos++;
                    }
                    else if (numero < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        ceros++;
                    }
                }

            } while (entrada != "X" && entrada != "x" && entrada != "N" && entrada != "n");

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);
