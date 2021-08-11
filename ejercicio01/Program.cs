using System;

namespace tallerEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double INTERES_3_CUOTAS = 0.00;
            const double INTERES_6_CUOTAS = 0.17;
            const double INTERES_12_CUOTAS = 0.25;
            const double DESCUENTO_1_PAGO = 0.10;

            double montoVenta = 0.0;
            int cuotas = 0;
            double montoTotal = 0.0;

            double montoCuota = 0.0;

            double totalPagado = 0.0;

            double saldo = 0.0;

            bool cuotasValidas = false;

            int colCuota = 0;
            int colMontoCuota = 0;
            int colPagado = 0;
            int colSaldo = 0;
            int filPago = 0;




            Console.Clear();

            Console.Write("Monto Venta: ");
            montoVenta = Double.Parse(Console.ReadLine());

            Console.Write("Cuotas: ");
            cuotas = Int32.Parse(Console.ReadLine());

            cuotasValidas = true;

            switch (cuotas)
            {
                case 1:
                    {
                        montoTotal = montoVenta - (montoVenta * DESCUENTO_1_PAGO);
                        break;
                    }

                case 3:
                    {
                        montoTotal = montoVenta + (montoVenta * INTERES_3_CUOTAS);
                        break;
                    }

                case 6:
                    {
                        montoTotal = montoVenta + (montoVenta * INTERES_6_CUOTAS);
                        break;
                    }
                case 12:
                    {
                        montoTotal = montoVenta + (montoVenta * INTERES_12_CUOTAS);
                        break;
                    }

                default:
                    {
                        cuotasValidas = false;
                        Console.WriteLine("Error. Cantidad incorrecta de cuotas");
                        break;
                    }

            } // switch

            if (cuotasValidas)
            {
                if (cuotas == 1)
                {
                    Console.WriteLine($"Total a pagar: $ {montoTotal}");
                }
                else
                {
                    colCuota = 1;
                    colMontoCuota = 9;
                    colPagado = 20;
                    colSaldo = 31;
                    filPago = 8;


                    // Plan de pagos
                    montoCuota = montoTotal / cuotas;

                    totalPagado = 0.00;
                    saldo = montoTotal;

                    Console.Clear();

                    Console.WriteLine($"Monto Venta: $ {montoVenta.ToString("0.00")}");
                    Console.WriteLine($"Cuotas: {cuotas}");
                    Console.WriteLine($"Monto Total: $ {montoTotal.ToString("0.00")}");
                    Console.WriteLine();

                    Console.WriteLine(" PLAN DE PAGOS");
                    Console.WriteLine();

                    Console.SetCursorPosition(colCuota, 7);
                    Console.Write("CUOTA");

                    Console.SetCursorPosition(colMontoCuota, 7);
                    Console.Write("MONTO");

                    Console.SetCursorPosition(colPagado, 7);
                    Console.Write("PAGADO");

                    Console.SetCursorPosition(colSaldo, 7);
                    Console.Write("SALDO");


                    for (int i = 1; i <= cuotas; i++)
                    {
                        totalPagado = totalPagado + montoCuota;
                        saldo = saldo - montoCuota;

                        Console.SetCursorPosition(colCuota, filPago);
                        Console.Write($"{i}");

                        Console.SetCursorPosition(colMontoCuota, filPago);
                        Console.Write($"{montoCuota.ToString("0.00")}");

                        Console.SetCursorPosition(colPagado, filPago);
                        Console.Write($"{totalPagado.ToString("0.00")}");

                        Console.SetCursorPosition(colSaldo, filPago);
                        Console.Write($"{saldo.ToString("0.00")}");

                        filPago++;
                    }

                }

            }

            Console.ReadKey();
        }
    }
}