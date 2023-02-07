using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FuncionTrigonometrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;
            double angulo, radianes, resultado;

            do
            {
                Console.WriteLine("Selecione la figura que desea calcular el volumen: \n" +
                            "1 Seno: \n" +
                            "2 Coseno:  \n" +
                            "3 Secante \n" +
                            "4 Cosecante:: \n" +
                            "5 Tangente: \n" +
                            "6 Cotangente: \n" +
                            "7 Salir: \n"
                   );
                
                opciones = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa Angulo");
                angulo = double.Parse(Console.ReadLine());
                radianes =  angulo * Math.PI / 180;
                
                switch (opciones)
                {
                    case 1:

                        resultado = Math.Sin(radianes);
                        Console.WriteLine("El Seno de " + angulo + " grados es:" + resultado + "\n");
                        break;

                    case 2:

                        resultado = Math.Cos(radianes);
                        break;

                    case 3:

                        resultado = Math.Sin(radianes);
                        break;

                    case 4:

                        resultado = Math.Cosh(radianes);
                        break;

                    case 5:

                        resultado = Math.Tan(radianes);
                        Console.WriteLine("El Seno de " + angulo + " grados es:" + resultado + "\n");
                        break;

                    case 6:

                        resultado = 1 /Math.Tan(radianes);
                        Console.WriteLine("El Seno de " + angulo + " grados es:" + resultado + "\n");
                        break;


                    case 7:

                        Console.Write("Saliendo del programa ");

                        break;

                    default:
                        Console.WriteLine("Opcion Numerica no Valida \n");
                        Console.ReadLine();
                        return;
                }
            } while (opciones != 7);
        }
    }
}
