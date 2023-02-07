using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OPFraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;
            double x1, x2, y1, y2, resultado;

            do
            {
                Console.WriteLine("Selecione la figura que desea calcular el Area: \n" +
                            "1 Suma: \n" +
                            "2 Resta:  \n" +
                            "3 Multiplicacion: \n" +
                            "4 Division: \n" +
                            "5 Salir: \n"
                   );

                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:

                        Console.WriteLine("INTRODUZCA NUMERADOR DE LA PRIMERA FRACCION");
                        x1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA DENOMINADOR DE LA PRIMERA FRACCION");
                        y1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA NUMERADOR DE LA SEGUNDA FRACCION");
                        x2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA DENOMINADOR DE LA SEGUNDA FRACCION");
                        y2 = double.Parse(Console.ReadLine());
                        resultado = ;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + resultado);
                        Console.ReadLine();
                        break;

                    case 2:

                        Console.WriteLine("INTRODUZCA RADIO");
                        r = double.Parse(Console.ReadLine());
                        a = Math.PI * Math.Pow(r, 2);
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + a);
                        Console.ReadLine();
                        break;

                    case 3:

                        Console.WriteLine("INTRODUZCA BASE ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA ALTURA");
                        h = double.Parse(Console.ReadLine());
                        a = (b * h) / 2;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + a);
                        Console.ReadLine();
                        break;

                    case 4:

                        Console.WriteLine("INTRODUZCA PERIMETRO");
                        p = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA APOTEMA");
                        A = double.Parse(Console.ReadLine());
                        a = (p * A) / 2;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + a);
                        Console.ReadLine();
                        break;

                    case 5:

                        Console.Write("Saliendo del programa ");

                        break;

                    default:
                        Console.WriteLine("Opcion Numerica no Valida \n");
                        Console.ReadLine();
                        return;
                }
            } while (opciones != 5);
        }
    }
}
