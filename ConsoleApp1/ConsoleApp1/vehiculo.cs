using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehiculo
    {
        string marca;
        string modelo;
        public double precio; //me indica el precio para arrendar este vehiculo
        

        public Vehiculo(string marca, string modelo,int precio)
        {
            this.precio = precio;
            this.marca = marca;
            this.modelo = modelo;
        

        }

      
        
    }
}
