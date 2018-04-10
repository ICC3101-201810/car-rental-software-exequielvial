using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class empresa:clientes
    {
        public string permiso;

        public empresa(string micliente, string mipermiso)
            :base(micliente)
        {
            permiso = mipermiso;
        }
    }
}
