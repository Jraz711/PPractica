﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero: ");

            int number = Convert.ToInt32(Console.ReadLine()) , factorial = 1;

            for(int i=1; i<=number; i++) 
            {
                factorial = factorial*i;
            }
            
            Console.WriteLine("El Factorial de "+ number +" "+"es " + factorial);


            Console.Read();

            //El Factorial de un numero es el resultado del multiplo descendiente de el.
        }
    }
}
