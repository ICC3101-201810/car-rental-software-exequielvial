using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sucursal
    {
        string nombre;
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        public List<Accesorio> accesorios = new List<Accesorio>();

        public Sucursal(string nombre, List<Accesorio> accesorios, List<Vehiculo> vehiculos)
        {
            this.nombre = nombre;
            this.accesorios = accesorios;
            this.vehiculos = vehiculos;
        }

        public void Sumarvehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }
    }
}
