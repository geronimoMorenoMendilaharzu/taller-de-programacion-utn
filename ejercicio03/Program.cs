using System;

namespace tallerEjercicio3
{
    class Program
    {

        static public double Porcentaje(double parte, double todo)
        {
            double porcentaje = 0.0;

            // porcentaje = (parte / todo) * 100;

            porcentaje = (double)(parte * 100) / todo;

            return porcentaje;
        }

        static void Main(string[] args)
        {
            const double VALOR_AUTO = 150;
            const double VALOR_CAMIONETA = 200;
            const double VALOR_CAMION = 320;

            int codigo = 0;

            int autos = 0;
            int camionetas = 0;
            int camiones = 0;

            int totalVehiculos = 0;

            double porcentajeAutos = 0.0;
            double porcentajeCamionetas = 0.0;
            double porcentajeCamiones = 0.0;

            double recaudacionAutos = 0.0;
            double recaudacionCamionetas = 0.0;
            double recaudacionCamiones = 0.0;

            double recaudacionTotal = 0.0;

            double porcentajeRecaudacionAutos = 0.0;
            double porcentajeRecaudacionCamionetas = 0.0;
            double porcentajeRecaudacionCamiones = 0.0;

            Console.Clear();

            Console.Write("Codigo: ");
            codigo = Int32.Parse(Console.ReadLine());

            while (codigo != 0)
            {
                Console.Clear();
                switch (codigo)
                {
                    case 1: // autos
                        {
                            autos++;
                            recaudacionAutos = VALOR_AUTO * autos;
                            break;
                        }

                    case 2: // camionetas
                        {
                            camionetas = camionetas + 1;
                            recaudacionCamionetas = VALOR_CAMIONETA * camionetas;
                            break;
                        }

                    case 3: // camiones
                        {
                            camiones += 1;
                            recaudacionCamiones = VALOR_CAMION * camiones;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Error. Codigo desconocido");
                            Console.ReadKey();
                            break;
                        }

                } // switch

                totalVehiculos = autos + camionetas + camiones;

                if (totalVehiculos > 0)
                {

                    porcentajeAutos = Porcentaje(autos, totalVehiculos);
                    porcentajeCamionetas = Porcentaje(camionetas, totalVehiculos);
                    porcentajeCamiones = Porcentaje(camiones, totalVehiculos);

                    // recaudacionAutos = recaudacionAutos + VALOR_AUTO;

                    recaudacionTotal = recaudacionAutos + recaudacionCamionetas + recaudacionCamiones;

                    porcentajeRecaudacionAutos = Porcentaje(recaudacionAutos, recaudacionTotal);
                    porcentajeRecaudacionCamionetas = Porcentaje(recaudacionCamionetas, recaudacionTotal);
                    porcentajeRecaudacionCamiones = Porcentaje(recaudacionCamiones, recaudacionTotal);

                    Console.Clear();

                    Console.WriteLine("INFORME");
                    Console.WriteLine("Vehiculos");
                    Console.WriteLine($"Autos: {autos} ({porcentajeAutos.ToString("0.00")}%)");
                    Console.WriteLine($"Camionetas: {camionetas} ({porcentajeCamionetas.ToString("0.00")})%");
                    Console.WriteLine($"Camiones: {camiones} ({porcentajeCamiones.ToString("0.00")})%");
                    Console.WriteLine($"Total vehiculos: {totalVehiculos}");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Recaudacion");
                    Console.WriteLine($"Autos: $ {recaudacionAutos} ({porcentajeRecaudacionAutos.ToString("0.00")}%)");
                    Console.WriteLine($"Camionetas: $ {recaudacionCamionetas} ({porcentajeRecaudacionCamionetas.ToString("0.00")})%");
                    Console.WriteLine($"Camiones: $ {recaudacionCamiones} ({porcentajeRecaudacionCamiones.ToString("0.00")})%");
                    Console.WriteLine($"Total recaudado: $ {recaudacionTotal}");

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Aun no se registraron vehiculos...");
                    Console.ReadKey();
                }

                Console.Write("Codigo: ");
                codigo = Int32.Parse(Console.ReadLine());

            } // while

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Fin del programa... ");
            Console.ReadKey();
        }
    }
}
