using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public abstract class CitaMedica
    {
        // ATRIBUTOS
        private string idCita;
        private DateTime fechaHora;
        private string estado;
        private string motivo;
        private Paciente paciente;
        private PersonalSalud medico;

        // CONSTRUCTOR
        protected CitaMedica(string id, Paciente paciente, PersonalSalud medico,
                             DateTime fechaHora, string motivo)
        {
            IdCita = id;
            Paciente = paciente;
            Medico = medico;
            FechaHora = fechaHora;
            Motivo = motivo;
            estado = "Pendiente";
        }

        // PROPIEDADES
        public string IdCita
        {
            get { return idCita; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El id de la cita es obligatorio.");
                }
                idCita = value.Trim();
            }
        }

        public Paciente Paciente
        {
            get { return paciente; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("La cita debe tener un paciente.");
                }
                paciente = value;
            }
        }

        public PersonalSalud Medico
        {
            get { return medico; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("La cita debe tener un profesional de salud.");
                }
                medico = value;
            }
        }

        public DateTime FechaHora
        {
            get { return fechaHora; }
            private set
            {
                DateTime normalizada = NormalizarFecha(value);
                if (normalizada < DateTime.Now)
                {
                    throw new ArgumentException("La fecha de la cita no puede estar en el pasado.");
                }
                fechaHora = normalizada;
            }
        }

        public string Motivo
        {
            get { return motivo; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El motivo de la cita es obligatorio.");
                }
                motivo = value.Trim();
            }
        }

        public string Estado
        {
            get { return estado; }
        }

        // METODOS
        public static DateTime NormalizarFecha(DateTime fecha)
        {
            return new DateTime(fecha.Year, fecha.Month, fecha.Day, fecha.Hour, fecha.Minute, 0);
        }

        public bool ConfirmarCita()
        {
            if (estado != "Pendiente")
            {
                return false;
            }
            estado = "Atendida";
            return true;
        }

        public void CancelarCita()
        {
            if (estado == "Cancelada")
            {
                throw new ArgumentException("La cita ya está cancelada.");
            }
            if (estado == "Atendida")
            {
                throw new ArgumentException("No se puede cancelar una cita ya atendida.");
            }
            estado = "Cancelada";
        }

        public void Reprogramar(DateTime nuevaFecha)
        {
            if (estado != "Pendiente")
            {
                throw new ArgumentException("Solo se puede reprogramar una cita pendiente.");
            }
            FechaHora = nuevaFecha;
        }

        public abstract string ObtenerModalidad();
    }
}
