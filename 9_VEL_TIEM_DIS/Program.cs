using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_VEL_TIEM_DIS
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int opciones;
            double v,t,d,resultado;

            do
            {
                Console.WriteLine("Selecione que desea calcular: \n" +
                            "1 Velocidad: \n" +
                            "2 Tiemmpo:  \n" +
                            "3 Distancia: \n" +
                            "4 Salir: \n"
                   );

                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:

                        Console.WriteLine("INTRODUZCA DISTANCIA");
                        d = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA TIEMPO");
                        t = double.Parse(Console.ReadLine());
                        resultado = d/t;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + resultado);
                        Console.ReadLine();
                        break;

                    case 2:

                        Console.WriteLine("INTRODUZCA DISTANCIA");
                        d = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA VOLUMEN");
                        v = double.Parse(Console.ReadLine());
                        resultado = d/v;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + resultado);
                        Console.ReadLine();
                        break;

                    case 3:

                        Console.WriteLine("INTRODUZCA VOLUMEN");
                        v = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA TIEMPO");
                        t = double.Parse(Console.ReadLine());
                        resultado = v*t;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + resultado);
                        Console.ReadLine();
                        break;

                    case 4:

                        Console.Write("Saliendo del programa ");

                        break;

                    default:
                        Console.WriteLine("Opcion Numerica no Valida \n");
                        Console.ReadLine();
                        return;
                }
            } while (opciones != 4);
        }
    }
}
