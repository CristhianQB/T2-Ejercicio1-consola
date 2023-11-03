using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace T2_Ejercicio1_consola
{
    internal class Program
    {

        static void Main()
        {
            Console.Write("Ingresa el número de pesos a analizar: ");
            int ndepesos = int.Parse(Console.ReadLine());

            if (ndepesos > 0 && ndepesos <= 300)
            {

                int[] pesorandom = new int[ndepesos];

                Random random = new Random();
                for (int i = 0; i < ndepesos; i++)
                {
                    pesorandom[i] = random.Next(1, 200);
                }

                int suma = 0;
                for (int i = 0; i < pesorandom.Length; i++)
                {
                    suma += pesorandom[i];
                }

                int promedio = 0;

                for (int i = 0; i < pesorandom.Length; i++)
                {
                    promedio += pesorandom[i];

                }

                float promedio2 = promedio / (float)ndepesos;

                int pesosmenores = 0;
                for (int i = 0; i < pesorandom.Length; i++)
                {
                    if (pesorandom[i] < 60)
                    {
                        pesosmenores++;
                    }
                }


                int pesosmayores = 0;
                for (int i = 0; i < pesorandom.Length; i++)
                {
                    if (pesorandom[i] > 100)
                    {
                        pesosmayores++;
                    }
                }

                Console.Write("========================================\n" +
                    "Procesando ...\n" +
                    "========================================\n" +
                    "La suma de todos los pesos es: " + suma + "\n" +
                    "El promedio de todos los pesos es: " + promedio2 + "\n" +
                    "========================================\n" +
                    "Menos de 60kg: " + pesosmenores + "\n" +
                    "Más de 100kg: " + pesosmayores + "\n");

                Console.ReadKey();
            }
            else
            {
                Console.Write("Ha excedido el número permitido\n" +
                    "por favor ingrese uno no mayor a 300");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }

    }
}
