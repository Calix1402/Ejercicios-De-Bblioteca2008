using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabriryEjemplo2
{
    public class SampleCollection2
    {
        static void Main()
        {
            string nombre;
            int num;
            Console.WriteLine("Jose Benavidez");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}, cuantos años tienes?", nombre);
            num = int.Parse(System.Console.ReadLine());
            Console.WriteLine("{0} tienes {18} años, eres mayor de edad ", nombre, num);
            Console.Read();







        }
    }
}
