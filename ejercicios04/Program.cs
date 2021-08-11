using System;

namespace tallerEjercicio4b
{
    class Program
    {
        static public int Menu()
        {
            int opcion = 0;

            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("1- Seleccionar cantidad de filas");
            Console.WriteLine("2- Seleccionar cantidad de columnas");
            Console.WriteLine("3- Maximo y minimo valores a generar");
            Console.WriteLine("4- Generar Matrices");
            Console.WriteLine("5- Sumar Matrices");
            Console.WriteLine("6- Multiplicar por un escalar");
            Console.WriteLine("7- Intercambiar filas");
            Console.WriteLine("8- Intercambiar columnas");
            Console.WriteLine("9- Mostrar Matriz");
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.Write("Opcion: ");
            opcion = Int32.Parse(Console.ReadLine());

            return opcion;
        }


        static public void EstablecerFilas(ref int cantidadFilas, int maximoFilas)
        {
            // Validar RANGO de enteros con while
            Console.Write($"Filas a utilizar (maximo {maximoFilas}): ");
            cantidadFilas = Int32.Parse(Console.ReadLine());
            while ((cantidadFilas <= 0) || (cantidadFilas > maximoFilas))
            {
                Console.WriteLine($"\nError. Las filas deben estar entre 1 y {maximoFilas}");
                Console.Write($"\nFilas a utilizar (maximo {maximoFilas}): ");
                cantidadFilas = Int32.Parse(Console.ReadLine());
            }
            // Validar RANGO de enteros con while
            Console.WriteLine();
        }

        static public void EstablecerColumnas(ref int cantidadColumnas, int maximoColumnas)
        {
            // Validar RANGO de enteros con do-while
            do
            {
                Console.Write($"\nColumnas a utilizar (maximo {maximoColumnas}): ");
                cantidadColumnas = Int32.Parse(Console.ReadLine());

                if ((cantidadColumnas <= 0) || (cantidadColumnas > maximoColumnas))
                {
                    Console.WriteLine($"\nError. Las columnas deben estar entre 1 y {maximoColumnas}");
                }

            } while ((cantidadColumnas <= 0) || (cantidadColumnas > maximoColumnas));
            // Validar RANGO de enteros con do-while
            Console.WriteLine();
        }


        static public void GenerarMatriz(int[,] mat, int topeFilas, int topeColumnas, int valorMin, int valorMax)
        {
            Random generador = new Random();

            for (int f = 0; f < topeFilas; f++)
            {
                for (int c = 0; c < topeColumnas; c++)
                {
                    mat[f, c] = generador.Next(valorMin, valorMax + 1);
                }
            }
        }

        static public void MostrarMatriz(int[,] mat, int topeFilas, int topeColumnas)
        {
            for (int f = 0; f < topeFilas; f++)
            {
                for (int c = 0; c < topeColumnas; c++)
                {
                    // Procesar la celda
                    Console.Write($"{mat[f, c].ToString("00")}  ");
                } // columnas

                Console.WriteLine();
                Console.WriteLine();

            } // filas

        }


        static public void SumarMatrices(int[,] matA, int[,] matB, int[,] matC, int topeFilas, int topeColumnas)
        {

            for (int f = 0; f < topeFilas; f++)
            {
                for (int c = 0; c < topeColumnas; c++)
                {
                    matC[f, c] = matA[f, c] + matB[f, c];
                } // columnas

            } // filas


        }


        static public void MultiplicarMatrizPorEscalar(int[,] m, int topeFilas, int topeColumnas, int numeroEscalar)
        {

            for (int f = 0; f < topeFilas; f++)
            {
                for (int c = 0; c < topeColumnas; c++)
                {
                    m[f, c] = m[f, c] * numeroEscalar;
                } // columnas

            } // filas


        }


        static void Main(string[] args)
        {

            const int FILAS = 25;
            const int COLUMNAS = 25;

            int[,] matrizA = new int[FILAS, COLUMNAS];
            int[,] matrizB = new int[FILAS, COLUMNAS];
            int[,] matrizC = new int[FILAS, COLUMNAS];

            int opc = 0;

            int respuesta = 0;

            int filas = FILAS;
            int columnas = COLUMNAS;

            int maximo = 0; // Maximo valor a generar en forma aleatoria
            int minimo = 0; // Minimo valor a generar en forma aleatoria

            int escalar = 0;

            int idxfa = 0; // Indice de la primera fila en el intercambio
            int idxfb = 0; // Indice de la segunda fila en el intercambio

            int idxca = 0; // Indice de la primera columna en el intercambio
            int idxcb = 0; // Indice de la segunda columna en el intercambio

            int aux = 0;

            do
            {
                Console.Clear();
                opc = Menu();
                Console.Clear();

                switch (opc)
                {

                    case 1:
                        {
                            Console.WriteLine("Seleccionar filas de la matriz\n");

                            EstablecerFilas(ref filas, FILAS);

                            Console.WriteLine($"\nSe establecio filas en {filas}");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Seleccionar columnas de la matriz\n");

                            EstablecerColumnas(ref columnas, COLUMNAS);

                            Console.WriteLine($"\nSe establecio columnas en {columnas}");
                            break;
                        }


                    case 3:
                        {
                            Console.WriteLine("Maximo y minimo valores a generar");

                            // TODO: Verifcar que minimo sea mas pequeño que maximo

                            Console.Write("Minimo a generar: ");
                            minimo = Int32.Parse(Console.ReadLine());

                            Console.Write("Maximo a generar: ");
                            maximo = Int32.Parse(Console.ReadLine());

                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Generar Matriz");

                            Console.Write("Matriz a generar (1-A / 2-B): ");
                            respuesta = Int32.Parse(Console.ReadLine());

                            if (respuesta == 1)
                            {
                                GenerarMatriz(matrizA, filas, columnas, minimo, maximo);
                            }
                            else
                            {
                                if (respuesta == 2)
                                {
                                    GenerarMatriz(matrizB, filas, columnas, minimo, maximo);
                                }
                                else
                                {
                                    Console.WriteLine("Error al indicar la matriz");
                                }
                            }


                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Sumar Matrices");

                            SumarMatrices(matrizA, matrizB, matrizC, filas, columnas);

                            Console.WriteLine("\nLa suma se realizo con exito...");
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Multiplicar por un escalar\n");

                            Console.Write("Escalar: ");
                            escalar = Int32.Parse(Console.ReadLine());

                            MultiplicarMatrizPorEscalar(matrizA, filas, columnas, escalar);

                            Console.WriteLine($"\nLa multiplicacion por el escalar {escalar} se realizo con exito...");

                            break;
                        }

                    case 7:
                        {
                            Console.WriteLine("Intercambiar filas\n");

                            Console.Write("Ingrese fila a: ");
                            idxfa = Int32.Parse(Console.ReadLine());

                            Console.Write("Ingrese fila b: ");
                            idxfb = Int32.Parse(Console.ReadLine());

                            for (int c = 0; c < columnas; c++)
                            {
                                //intercambio celda por celda
                                aux = matrizA[idxfa, c];
                                matrizA[idxfa, c] = matrizA[idxfb, c];
                                matrizA[idxfb, c] = aux;
                            }

                            Console.WriteLine($"\nSe intercambiaron correctamente las filas {idxfa} y {idxfb}");

                            break;
                        }

                    case 8:
                        {
                            Console.WriteLine("Intercambiar columnas");
                            break;
                        }

                    case 9:
                        {
                            Console.WriteLine("Mostrar Matriz");

                            Console.Write("Matriz a mostrar (1-A / 2-B / 3-C): ");
                            respuesta = Int32.Parse(Console.ReadLine());

                            Console.WriteLine();

                            switch (respuesta)
                            {
                                case 1: { MostrarMatriz(matrizA, filas, columnas); break; }
                                case 2: { MostrarMatriz(matrizB, filas, columnas); break; }
                                case 3: { MostrarMatriz(matrizC, filas, columnas); break; }
                                default: { Console.WriteLine("Error al especificar la matriz"); break; }
                            }

                            break;
                        }

                    case 0:
                        {
                            Console.WriteLine("Fin del programa");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("ERROR. Opcion inexistente...");
                            break;
                        }

                } // switch

                Console.ReadKey();

            } while (opc != 0);



        }

    }
}