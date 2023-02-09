using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0,num2 = 1,num3,num4;

            Console.Write("Ingresa cuanto numero desea de la serie fibonacci: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La serie fibonacci de: " + num3);
            Console.Write(num1 + " " + num2 + " ");
            for (int i = 2; i < num3; i++)
            {
                num4 = num1 + num2;
                Console.Write(num4 + " ");
                num1 = num2;
                num2 = num4;
            }



            Console.Read();
        }
    }
}
