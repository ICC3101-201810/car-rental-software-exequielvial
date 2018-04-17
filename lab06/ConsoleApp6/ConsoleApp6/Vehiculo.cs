using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Vehiculo
    {
        string marca, modelo, tipo;
        double precio;

        public Vehiculo(string marca, string modelo, double precio, string tipo)
        {
      
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.tipo = tipo;
        }
    }
}
