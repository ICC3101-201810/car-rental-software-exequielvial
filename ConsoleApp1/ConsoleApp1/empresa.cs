using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa
    {
        bool permisobus;
        bool permisomaqpesada;
        int licencia;
        public Empresa(int licencia)
        {
            this.licencia = licencia;
        }
        public Boolean Permisoe(int licencia)
        {
            permisomaqpesada = false;
            permisobus = false;

            if (licencia >= 3)
            {
                permisomaqpesada = true;
                permisobus = true;
            }
            if (licencia >= 2)
            {
                permisobus = true;
            }
            return false;




        }
    }
}
            
    

