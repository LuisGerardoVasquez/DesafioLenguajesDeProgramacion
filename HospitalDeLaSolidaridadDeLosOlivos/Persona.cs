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
        // ATRIBUTOS
        protected string idPersona;
        protected string nombreCompleto;
        protected string dniProtegido;
        protected string telefono;
        
        // CONSTRUCTOR
        protected Persona(string id, string nombre, string dni, string telefono)
        {
            IdPersona = id;
            Nombre = nombre;
            Dni = dni;
            Telefono = telefono;
        }

        // PROPIEDADES
        public string IdPersona
        {
            get { return idPersona; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El id es obligatorio.");
                }
                idPersona = value.Trim();
            }
        }
        public string Nombre
        {
            get { return nombreCompleto; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre es obligatorio.");
                }
                nombreCompleto = value.Trim();
            }
        }

        public string Dni
        {
            get { return dniProtegido; }
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

                dniProtegido = limpio;
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

        // METODOS
        public string ObtenerIdentificadorSeguro()
        {
            return "*****" + dniProtegido.Substring(5);
        }

        public virtual bool ValidarDatos()
        {
            return !string.IsNullOrWhiteSpace(idPersona)
                && !string.IsNullOrWhiteSpace(nombreCompleto)
                && !string.IsNullOrWhiteSpace(dniProtegido)
                && !string.IsNullOrWhiteSpace(telefono);
        }
        public abstract string ObtenerTipo();
    }
}
