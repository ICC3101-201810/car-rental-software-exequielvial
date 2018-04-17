using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Persona
    {
        string nombre, apellido, rut, direccion, marca_auto, modelo_auto;
        int dias, licencia;
        public Persona(string nombre, string apellido, string rut, string direccion, string marca_auto, string modelo_auto, int dias, int licencia)
            {
            this.apellido = apellido;
            this.nombre = nombre;
            this.rut = rut;
            this.direccion = direccion;
            this.marca_auto = marca_auto;
            this.modelo_auto = modelo_auto;
            this.dias = dias;
            this.licencia = licencia;
            }
    }
}
