using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Calificacion_Lit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduzca su nota practica: ");
            int NP = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor introduzca su nota Primer parcial: ");
            int PP = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor introduzca su nota Segundo parcial: ");
            int SP = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor introduzca su nota final: ");
            int NF = int.Parse(Console.ReadLine());

            int Pparciales = (SP + PP) / 2;
            int promedio = (Pparciales + NP + NF) / 3;


            if (promedio <= 59)
            {
                Console.WriteLine("F - Reprobado    ");
            }
            else if (promedio >= 60 && promedio <= 69)
            {
                Console.WriteLine("D - Reprobado   ");
            }
            else if (promedio >= 70 && promedio <= 79)
            {
                Console.WriteLine("C - Aprobado  ");
            }
            else if (promedio >= 80 && promedio <= 89)
            {
                Console.WriteLine("B - Aprobado  ");
            }
            else if (promedio >= 90 && promedio <= 100)
            {
                Console.WriteLine("A - Aprobado   ");
            }

            Console.ReadLine();
        }
    }
}
