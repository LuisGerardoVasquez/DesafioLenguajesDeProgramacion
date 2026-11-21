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
        private Dictionary<Medicamento, int> receta = new Dictionary<Medicamento, int>();
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
            private set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("La fecha de la atención no puede ser futura.");
                }
                fechaAtencion = value;
            }
        }

        // METODOS
        public void RegistrarDiagnostico(string nuevoDiagnostico)
        {
            Diagnostico = nuevoDiagnostico;   // el setter valida que no esté vacío
        }

        public void GenerarReceta(Medicamento medicamento, int cantidad)
        {
            if (medicamento == null)
            {
                throw new ArgumentException("Seleccione un medicamento.");
            }
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor que cero.");
            }
            if (!medicamento.VerificarDisponibilidad())
            {
                throw new ArgumentException("El medicamento " + medicamento.NombreComercial + " está agotado.");
            }

            medicamento.ActualizarStock(-cantidad);   // lanza error si el stock no alcanza

            if (receta.ContainsKey(medicamento))
            {
                receta[medicamento] += cantidad;
            }
            else
            {
                receta.Add(medicamento, cantidad);
            }
        }

        public string ResumenReceta()
        {
            if (receta.Count == 0)
            {
                return "Sin receta";
            }
            string resumen = "";
            foreach (KeyValuePair<Medicamento, int> item in receta)
            {
                if (resumen != "")
                {
                    resumen += ", ";
                }
                resumen += item.Key.NombreComercial + " x" + item.Value;
            }
            return resumen;
        }
    }
}
