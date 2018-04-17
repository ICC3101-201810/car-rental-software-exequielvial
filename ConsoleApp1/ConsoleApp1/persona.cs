using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona
    {
        int licencia;
        public Persona(int licencia)
        {
            this.licencia = licencia;

        }
        public bool permiso;
        public Boolean Permiso(int licencia)
        {
            
            if (licencia == 1)
            {
                permiso = true;
            }
            else
            {
                permiso = false;
            }
            return false;

        }
    }
}
