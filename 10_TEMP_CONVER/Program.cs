using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TEMP_CONVER
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int opciones;
            double temperatura, resultado;

            do
            {
                Console.WriteLine("Selecione que desea calcular: \n" +
                            "1 Celcius a Kelvin: \n" +
                            "2 Celcius a Fareheim:: \n" +
                            "3 Fareheim a Celcius: \n" +
                            "4 Fareheim a Kelvin: \n" +
                            "5 Kelvin a Celcius:  \n" +
                            "6 Kelvin a Fareheim: \n" +
                            "7 Salir: \n"
                   );

                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:

                        Console.WriteLine("INTRODUZCA TEMPERATURA");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura + 273.15;
                        Console.WriteLine("El RESULTADO ES " + resultado);
                        Console.ReadLine();
                        break;

                    case 2:

                        Console.WriteLine("INTRODUZCA TEMPERATURA");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura * 1.8) +  32;
                        Console.WriteLine("El RESULTADO ES " + resultado);
                        Console.ReadLine();
                        break;

                    case 3:

                        Console.WriteLine("INTRODUZCA TEMPERATURA");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 32 ) * 1.8;
                        Console.WriteLine("El RESULTADO ES " + resultado);
                        Console.ReadLine();
                        break;

                    case 4:

                        Console.WriteLine("INTRODUZCA TEMPERATURA");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura + 459.67) * 1.8;
                        Console.WriteLine("El RESULTADO ES " + resultado);
                        Console.ReadLine();
                        break;

                    case 5:

                        Console.WriteLine("INTRODUZCA TEMPERATURA");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura - 273.15;
                        Console.WriteLine("El RESULTADO ES " + resultado);
                        Console.ReadLine();
                        break;

                    case 6:

                        Console.WriteLine("INTRODUZCA TEMPERATURA");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 273.15 ) * 1.8 + 32;
                        Console.WriteLine("El RESULTADO ES " + resultado);
                        Console.ReadLine();
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
