using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido ingrese una de las siguientes opciones: ");
            Console.WriteLine("1. Agregar una sucursal");
            Console.WriteLine("2. Agregar algun");
            Vehiculo auto1 = new Vehiculo("honda", "civic", 13000000);
            Console.WriteLine(auto1.precio);
            Console.ReadLine();
        }
    }
}
