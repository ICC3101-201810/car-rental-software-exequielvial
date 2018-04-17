using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arriendo
    {
        public Boolean disponible; 
        public Boolean Arriendo1()
        {
            if (disponible == true)
            {
                disponible = false; //ya que lo arrienda por lo que debo cambiarlo a false   
            }
            return false; //porque si está disponible lo va a arrendar, si no está disponible va a seguir en false
        }

    }
}
