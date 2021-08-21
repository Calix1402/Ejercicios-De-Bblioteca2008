using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLabriryEjemplo2;

namespace ConsoleAppEejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre ");
            Console.WriteLine("1.nombre ");
            Console.ReadLine();

            Console.WriteLine("Ingresar edad");
            Console.WriteLine("2.edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad > 18)
            {
                Console.WriteLine("ES MAYOR DE EDAD ");

            }

            else
            {
                Console.WriteLine("ES MENOR DE EDAD ");
            }
            Console.ReadLine();



        }
    }
}
