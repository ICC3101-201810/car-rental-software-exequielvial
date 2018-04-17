using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Accesorio: Arriendo
    {
        string nombre;
        int precio;
        public Accesorio(string nombre,int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public Boolean disp;
        public Boolean Arriendo1()
        {
            if (disp == true)
            {
                disp = false; //ya que lo arrienda por lo que debo cambiarlo a false   
            }
            return false;
        }
    }
}
