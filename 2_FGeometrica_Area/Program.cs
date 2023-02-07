using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGeometrica_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;
            double a,A,b,h,p,r,v;

            do
            {
                Console.WriteLine("Selecione la figura que desea calcular el Area: \n" +
                            "1 Cuadrado: \n" +
                            "2 Circulo:  \n" +
                            "3 Triangulo: \n" +
                            "4 Pentagono: \n" +
                            "5 Hexagono: \n" +
                            "6 Salir: \n"
                   );
                
                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:

                        Console.WriteLine("INTRODUZCA BASE ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA ALTURA ");
                        h = int.Parse(Console.ReadLine());
                        a = b * h;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + a);
                        Console.ReadLine();
                        break;

                    case 2:

                        Console.WriteLine("INTRODUZCA RADIO");
                        r = double.Parse(Console.ReadLine());
                        a =  Math.PI * Math.Pow(r, 2);
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

                        Console.WriteLine("INTRODUZCA PERIMETRO");
                        p = double.Parse(Console.ReadLine());
                        Console.WriteLine("INTRODUZCA APOTEMA");
                        A = double.Parse(Console.ReadLine());
                        a = (p * A) / 2;
                        Console.WriteLine("El RESULTADO DEL CALCULO ES: " + a);
                        Console.ReadLine();
                        break;

                    case 6:

                        Console.Write("Saliendo del programa ");

                        break;

                    default:
                        Console.WriteLine("Opcion Numerica no Valida \n");
                        Console.ReadLine();
                        return;
                }
            } while (opciones != 6);
        }
    }
}
