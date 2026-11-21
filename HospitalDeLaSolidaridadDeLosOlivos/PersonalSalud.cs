using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public class PersonalSalud : Persona
    {
        // ATRIBUTO
        public static readonly string[] EspecialidadesValidas =
        {"Medicina general", "Pediatría", "Enfermería", "Obstetricia", "Psicología", "Nutrición", "Podología"};
        private string colegiaturaCMP;
        private string especialidad;
        private bool estadoDisponibilidad = true;

        // CONTRUCTOR
        public PersonalSalud(string id, string nombre, string dni, string telefono,
                             string cmp, string especialidad)
            : base(id, nombre, dni, telefono)
        {
            ColegiaturaCMP = cmp;
            Especialidad = especialidad;
        }
        // PROPIEDADES
        public string ColegiaturaCMP
        {
            get { return colegiaturaCMP; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La colegiatura es obligatoria.");
                }
                string limpio = value.Trim();
                if (limpio.Length < 5 || limpio.Length > 6 || !limpio.All(char.IsDigit))
                {
                    throw new ArgumentException("La colegiatura debe tener 5 o 6 dígitos.");
                }
                colegiaturaCMP = limpio;
            }
        }

        public string Especialidad
        {
            get { return especialidad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La especialidad es obligatoria.");
                }
                string limpio = value.Trim();
                if (!EspecialidadesValidas.Contains(limpio))
                {
                    throw new ArgumentException("La especialidad no es válida.");
                }
                especialidad = limpio;
            }
        }

        public bool EstadoDisponibilidad
        {
            get { return estadoDisponibilidad; }
        }

        // METODOS
        public override string ObtenerTipo()
        {
            return "Personal de Salud";
        }

        public void ProgramarHorario(bool disponible)
        {
            estadoDisponibilidad = disponible;
        }

        public void AtenderCita()
        {
            if (!estadoDisponibilidad)
                throw new InvalidOperationException("El profesional no está disponible.");
        }
    }
}
