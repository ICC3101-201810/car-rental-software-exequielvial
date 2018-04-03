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
            List<string> sucursales1 = new List<string>();
            string a;
            string gfd;
            gfd = "t";
            while (gfd != "4")
            { 
            Console.WriteLine("bienvenido, agregue 1 si quiere agregar una sucursal, 2 si quiere agregar vehiculos, 3 si quiere agregar accesorios. Cuando termine ingrese 4 ");
            a = Console.ReadLine();
                while (a == "1")
                {
                    string s;
                    Console.WriteLine("ingrese el nombre de la sucursal: ");
                    s = Console.ReadLine();
                    int verificar;

                    verificar = sucursales1.IndexOf(s);
                    if (verificar != -1)
                    {
                        Console.WriteLine("esta sucursal ya esta en el sistema");
                    }
                    if (verificar == -1)
                    {
                        sucursales1.Add(s);

                    }

                }
                while (a == "2")
                {
                    string g;
                    Console.WriteLine("ingrese que tipo de vehiculo desea ingresar (auto,camion,bus,moto,acuatico,maquinaria pesada): ");
                    g = Console.ReadLine();
                    if ( g == "auto")
                    {
                        int au;
                        Console.WriteLine("ingrese la cantidad de autos que desea ingresar: ");
                        au = Int32.Parse(Console.ReadLine());
                    }
                    if (g == "camion")
                        {
                        int au;
                        Console.WriteLine("ingrese la cantidad de camiones que desea ingresar: ");
                        au = Int32.Parse(Console.ReadLine());
                        }
                    if (g == "bus")
                    {
                        int au;
                        Console.WriteLine("ingrese la cantidad de buses que desea ingresar: ");
                        au = Int32.Parse(Console.ReadLine());
                    }
                    if (g == "moto")
                    {
                        int au;
                        Console.WriteLine("ingrese la cantidad de motos que desea ingresar: ");
                        au = Int32.Parse(Console.ReadLine());
                    }
                    if (g== "acuatico")
                    {
                        int au;
                        Console.WriteLine("ingrese la cantidad de acuaticos que desea ingresar: ");
                        au = Int32.Parse(Console.ReadLine());
                    }
                    if (g == "maquinaria pesada")
                    {
                        int au;
                        Console.WriteLine("ingrese la cantidad de maquinaria pesada que desea ingresar: ");
                        au = Int32.Parse(Console.ReadLine());
                    }
                if ( a == "4")
                    {
                        gfd = "4";
                    }
                }

                   




                }
                while (a == "2")
                {
                    string au;
                    Console.WriteLine("ingrese 1 si desea ingresar autos, 2 si desea agregar acuaticos, 3 si desea agregar camiones, 4 si desea agregar motos, 5 si desea agregar buses, 6 si desea agregar maquinaria pesada: ");
                    au = Console.ReadLine();
                    if (au == "1")
                    {
                        Console.WriteLine("ingrese la cantidad de autos que desea ingresar")
                    }

                    
                }


            }
        }
    }
}
