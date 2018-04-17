using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Stock
    {
        public List<Vehiculo> vehiculos_disponibles = new List<Vehiculo>();
        public List<int> cantidad = new List<int>();
        
        public Stock(List<Vehiculo> vehiculos_disponibles, List<int> cantidad)
        {
            this.vehiculos_disponibles = vehiculos_disponibles;
            this.cantidad = cantidad;
        }
    }
}
