using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Desglosador_Moneda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double Dinero, M1 = 0, M5 = 0, M10 = 0, M25 = 0, B50 = 0, B100 = 0, B200 = 0, B500 = 0, B1000 = 0, B2000 = 0;


            Console.WriteLine("Ingrese la cantidad de dinero a desglosar: ");
            Dinero = Convert.ToDouble(Console.ReadLine());

            if (Dinero >= 2000)
            {
                B2000 = Math.Abs(Dinero) / 2000;
                Dinero = Dinero - (B2000 * 2000);
            }
            else if (Dinero >= 1000)
            {
                B1000 = Math.Abs(Dinero) / 1000;
                Dinero = Dinero - (B1000 * 1000);
            }
            else if (Dinero >= 500)
            {

                B500 = Math.Abs(Dinero) / 500;
                Dinero = Dinero - (B500 * 500);
            }
            else if (Dinero >= 200)
            {
                B200 = Math.Abs(Dinero) / 200;
                Dinero = Dinero - (B200 * 200);
            }
            else if (Dinero >= 100)
            {
                B100 = Math.Abs(Dinero) / 100;
                Dinero = Dinero - (B100 * 100);
            }
            else if (Dinero >= 50)
            {
                B50 = Math.Abs(Dinero) / 50;
                Dinero = Dinero - (B100 * 50);
            }
            else if (Dinero >= 25)
            {
                M25 = Math.Abs(Dinero) / 25;
                Dinero = Dinero - (M25 * 25);
            }
            else if (Dinero >= 10)
            {
                M10 = Math.Abs(Dinero) / 10;
                Dinero = Dinero - (M10 * 10);
            }
            else if (Dinero >= 5)
            {
                M5 = Math.Abs(Dinero) / 5;
                Dinero = Dinero - (M5 * 5);
            }
            else if (Dinero >= 1)
            { 
            M1 = Math.Abs(Dinero) / 1;
            Dinero = Dinero - (M1 * 1);
            }
            //Salida
            Console.WriteLine("La cantidad en billetes de $2000: " + B2000);
            Console.WriteLine("La cantidad en billetes de $1000: " + B1000);
            Console.WriteLine("La cantidad en billetes de $500: " + B500);
            Console.WriteLine("La cantidad en billetes de $200: " + B200);
            Console.WriteLine("La cantidad en billetes de $100: " + B100);
            Console.WriteLine("La cantidad en billetes de $50: " + B50);
            Console.WriteLine("La cantidad en moneda  de $20: " + M25);
            Console.WriteLine("La cantidad en moneda  de $10: " + M10);
            Console.WriteLine("La cantidad en moneda  de $5: " + M5);
            Console.WriteLine("La cantidad en moneda  de $1: " + M1);
            Console.Read();
        }
    }
}

