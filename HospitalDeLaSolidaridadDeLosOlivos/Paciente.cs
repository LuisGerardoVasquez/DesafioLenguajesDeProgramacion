using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public class Paciente : Persona
    {
        // ATRIBUTOS 
        public static readonly string[] TiposSangreValidos =
            { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" };

        private string numeroHistoriaClinica;
        private DateTime fechaNacimiento;
        private string tipoSangre;
        private List<AtencionMedica> atenciones = new List<AtencionMedica>();

        // CONSTRUCTOR
        public Paciente(
            string id, string nombre, string dni, string telefono,
            string historiaClinica, DateTime nacimiento, string sangre)
            : base(id, nombre, dni, telefono)
        {
            NumeroHistoriaClinica = historiaClinica;
            FechaNacimiento = nacimiento;
            TipoSangre = sangre;
        }

        // PROPIEDADES
        public string NumeroHistoriaClinica
        {
            get { return numeroHistoriaClinica; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El número de historia clínica es obligatorio.");
                numeroHistoriaClinica = value.Trim();
            }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set
            {
                if (value.Date > DateTime.Today)
                    throw new ArgumentException("La fecha de nacimiento no puede ser futura.");
                fechaNacimiento = value.Date;
            }
        }

        public string TipoSangre
        {
            get { return tipoSangre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El tipo de sangre es obligatorio.");

                string limpio = value.Trim().ToUpper();

                if (!TiposSangreValidos.Contains(limpio))
                    throw new ArgumentException("El tipo de sangre no es válido.");
    
                tipoSangre = limpio;
            }
        }

        // METODOS
        public void AgregarAtencion(AtencionMedica atencion)
        {
            if (atencion == null)
                throw new ArgumentException("La atención no puede ser nula.");
            atenciones.Add(atencion);
        }

        public List<AtencionMedica> ConsultarHistorial()
        {
            return new List<AtencionMedica>(atenciones);
        }

        public void RegistrarDatos()
        {
            if (!ValidarDatos())
                throw new ArgumentException("Faltan datos obligatorios del paciente.");
        }

        public override bool ValidarDatos()
        {
            return base.ValidarDatos()
                && !string.IsNullOrWhiteSpace(numeroHistoriaClinica)
                && !string.IsNullOrWhiteSpace(tipoSangre);
        }
    }
}
