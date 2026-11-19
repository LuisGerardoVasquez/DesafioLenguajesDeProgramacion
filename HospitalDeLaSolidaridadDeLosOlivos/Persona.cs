using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }

        protected Persona(string nombre, string dni, string telefono)
        {
            Nombre = nombre;
            Dni = dni;
            Telefono = telefono;
        }
    }
}
