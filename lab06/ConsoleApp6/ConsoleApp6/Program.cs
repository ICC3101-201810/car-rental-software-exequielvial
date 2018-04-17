using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo uno = new Vehiculo("suzuki", "swift", 20000, "auto");
            Vehiculo dos = new Vehiculo("suzuki", "vitara", 29000, "auto");
            Vehiculo tres = new Vehiculo("suzuki", "baleno", 19000, "auto");
            Vehiculo cuatro = new Vehiculo("suzuki", "dzire", 21500, "auto");
            Vehiculo cinco = new Vehiculo("John deere", "bt6", 50000, "retro");
            Vehiculo seis = new Vehiculo("John deere", "bt7", 55000, "retro");
            Vehiculo siete = new Vehiculo("John deere", "bt8", 58000, "retro");
            Vehiculo ocho = new Vehiculo("John deere", "bt9", 60000, "retro");
            List<Vehiculo> vehiculos_disponibles = new List<Vehiculo>();
            vehiculos_disponibles.Add(uno);
            vehiculos_disponibles.Add(dos);
            vehiculos_disponibles.Add(tres);
            vehiculos_disponibles.Add(cuatro);
            vehiculos_disponibles.Add(cinco);
            vehiculos_disponibles.Add(seis);
            vehiculos_disponibles.Add(siete);
            vehiculos_disponibles.Add(ocho);
            List<int> cantidad = new List<int>();
            cantidad.Add(1);
            cantidad.Add(3);
            cantidad.Add(17);
            cantidad.Add(9);
            cantidad.Add(6);
            cantidad.Add(8);
            cantidad.Add(7);
            cantidad.Add(3);
            int g = 1;
            int disponibilidad;


            string a,nombreu, apellidou, rutu, marca_vehiculou, modelo_vehiculou,tipou;
            int diasu, licenciau;
            double preciou;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Bienvenido a VIAL'S CAR RENTAL");
            while (g == 1)
                { 
                    Console.WriteLine("Porfavor ingrese una opción: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("1. Arrendar vehiculo");
                    Console.WriteLine("2. Devolver vehiculo");
                    Console.WriteLine("3. Salir");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n");
                    a = Console.ReadLine();

                    if (a == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Adios y gracias por preferirnos!");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Para salir aprete enter");
                            Console.ReadLine();
                            g = 2;
                        }
                    if (a == "1")
                         {

                            Console.WriteLine("Porfavor ingrese su nombre (sin apellido): ");
                            nombreu = Console.ReadLine();
                            Console.WriteLine("Porfavor ingrese su apellido: ");
                            apellidou = Console.ReadLine();
                            Console.WriteLine("Porfavor ingrese su rut (con guion): ");
                            rutu = Console.ReadLine();
                            Console.WriteLine("Porfavor ingrese el tipo de licencia que tiene (1,2 o 3)");
                            licenciau = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Porfavor ingrese el tipo de vehiculo que quiere arrendar (auto, camioneta,retro, motos, acuaticos, buses)");
                            tipou = Console.ReadLine();
                            Console.WriteLine("Porfavor ingrese la marca del vehiculo que quiere arrendar: ");
                            marca_vehiculou = Console.ReadLine();
                            Console.WriteLine("Ahora porfavor ingrese el modelo de este: ");
                            modelo_vehiculou = Console.ReadLine();
                            Console.WriteLine("Por ultimo ingrese la cantidad de días que lo va a arrendar: ");
                            diasu = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el precio que tiene el arriendo del auto por día");
                            preciou = Convert.ToDouble(Console.ReadLine());
                            g = 2;
                            Vehiculo arr = new Vehiculo(marca_vehiculou, modelo_vehiculou, preciou, tipou);
                            //disponibilidad = vehiculos_disponibles.Find(arr);

                         }
                    if (a == "2")
                        {
                            Console.WriteLine("Porfavor ingrese su nombre (sin apellido): ");
                            nombreu = Console.ReadLine();
                            Console.WriteLine("Porfavor ingrese su apellido: ");
                            apellidou = Console.ReadLine();
                            Console.WriteLine("Porfavor ingrese su rut (con guion): ");
                            rutu = Console.ReadLine();
                            Console.WriteLine("Porfavor ingrese el tipo de vehiculo que quiere devolver (auto, camioneta,retro, motos, acuaticos, buses)");
                            tipou = Console.ReadLine();
                            Console.WriteLine("Porfavor ingrese la marca del vehiculo que quiere devolver: ");
                            marca_vehiculou = Console.ReadLine();
                            Console.WriteLine("Ahora porfavor ingrese el modelo de este: ");
                            modelo_vehiculou = Console.ReadLine();
                            g = 2;
                        }
            }
        }
    }
}
