using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public class AtencionMedica
    {
        // ATRIBUTOS
        private string idAtencion;
        private string diagnostico;
        private string tratamiento;
        private DateTime fechaAtencion;

        // CONSTRUCTOR
        public AtencionMedica(string id, string diagnostico, string tratamiento, DateTime fecha)
        {
            IdAtencion = id;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            FechaAtencion = fecha;
        }

        // PROPIEDADES
        public string IdAtencion
        {
            get { return idAtencion; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El id de la atención es obligatorio.");
                idAtencion = value.Trim();
            }
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El diagnóstico es obligatorio.");
                diagnostico = value.Trim();
            }
        }

        public string Tratamiento
        {
            get { return tratamiento; }
            private set { tratamiento = (value ?? "").Trim(); }
        }

        public DateTime FechaAtencion
        {
            get { return fechaAtencion; }
            private set { fechaAtencion = value; }
        }
    }
}
