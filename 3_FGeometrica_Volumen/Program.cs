using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FGeometrica_Volumen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;
            double a, h, r, v;

            do
            {
                Console.WriteLine("Selecione la figura que desea calcular el volumen: \n" +
                            "1 Cubo: \n" +
                            "2 Esfera:  \n" +
                            "3 Cono: \n" +
                            "4 Piramide: \n" +
                            "5 Salir: \n"
                   );
                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:

                        Console.WriteLine("INTRODUZCA CANTIDAD DE LADOS ");
                        a = int.Parse(Console.ReadLine());
                        v = Math.Pow(a, 3);
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + v);
                        Console.ReadLine();
                        break;

                    case 2:

                        Console.WriteLine("INTRODUZCA RADIO");
                        r = double.Parse(Console.ReadLine());
                        v = 1.333 * Math.PI * Math.Pow(r, 3);
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + v);
                        Console.ReadLine();
                        break;

                    case 3:

                        Console.WriteLine("INTRODUZCA ALTURA");
                        h = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA RADIO");
                        r = double.Parse(Console.ReadLine());
                        v = (Math.PI * Math.Pow(r, 2) * h) / 3;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + v);
                        Console.ReadLine();
                        break;

                    case 4:

                        Console.WriteLine("INTRODUZCA CANTIDAD DE LADOS");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA ALTURA");
                        h = double.Parse(Console.ReadLine());
                        v = (Math.Pow(a, 2) * h) / 3;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + v);
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
