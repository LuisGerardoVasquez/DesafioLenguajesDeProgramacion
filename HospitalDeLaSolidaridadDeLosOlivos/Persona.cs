using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public abstract class Persona
    {
        private string nombre;
        private string dni;
        private string telefono;
        protected Persona(string nombre, string dni, string telefono)
        {
            Nombre = nombre;
            Dni = dni;
            Telefono = telefono;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre es obligatorio.");
                }
                nombre = value.Trim();
            }
        }

        public string Dni
        {
            get { return dni; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El DNI es obligatorio.");
                }

                string limpio = value.Trim();

                if (limpio.Length != 8 || !limpio.All(char.IsDigit))
                {
                    throw new ArgumentException("El DNI debe tener 8 dígitos numéricos.");
                }

                dni = limpio;
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El teléfono es obligatorio.");
                }

                string limpio = value.Trim();

                if (limpio.Length != 9 || !limpio.All(char.IsDigit))
                {
                    throw new ArgumentException("El teléfono debe tener 9 dígitos numéricos.");
                }

                telefono = limpio;
            }
        }
    }
}
