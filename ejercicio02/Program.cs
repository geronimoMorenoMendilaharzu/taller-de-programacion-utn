using System;

namespace ejercicioTaller2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRECIO_MILANESA = 210.00;
            const double PRECIO_HAMBURGUESA = 230.00;
            const double PRECIO_LOMITO = 270.00;

            int codigo = 0;
            int cantidad = 0;

            int milanesas = 0;
            int hamburguesas = 0;
            int lomitos = 0;

            double totalRecaudado = 0.0;

            double porcentajeRecaudacionMilanesas = 0.0;
            double porcentajeRecaudacionHamburguesas = 0.0;
            double porcentajeRecaudacionLomitos = 0.0;

            Console.Clear();

            Console.Write("Codigo Producto: ");
            codigo = Int32.Parse(Console.ReadLine());

            while (codigo != 0)
            {
                Console.Write("Cantidad: ");
                cantidad = Int32.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        {
                            milanesas = milanesas + cantidad;
                            break;
                        }

                    case 2:
                        {
                            hamburguesas = hamburguesas + cantidad;
                            break;
                        }

                    case 3:
                        {
                            lomitos = lomitos + cantidad;
                            break;
                        }

                        default:
                        {
                            Console.WriteLine("Error. Codigo desconocido");
                            Console.ReadKey();
                            break;
                        }

                        

                } // switch

                Console.Write("\n\nCodigo Producto: ");
                codigo = Int32.Parse(Console.ReadLine());

            } // while

            totalRecaudado = (milanesas * PRECIO_MILANESA) + (hamburguesas * PRECIO_HAMBURGUESA) + (lomitos * PRECIO_LOMITO);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Milanesas: {milanesas}");
            Console.WriteLine($"Hamburguesas: {hamburguesas}");
            Console.WriteLine($"Lomitos: {lomitos}");
            Console.WriteLine($"Total Recaudado: {totalRecaudado.ToString("0.00")}");

            Console.ReadKey();
        }
    }
}
