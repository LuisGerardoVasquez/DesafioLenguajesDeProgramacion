using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public class CitaPresencial : CitaMedica
    {
        public CitaPresencial(string id, Paciente paciente, PersonalSalud medico,
                              DateTime fechaHora, string motivo)
            : base(id, paciente, medico, fechaHora, motivo)
        {
        }

        public override string ObtenerModalidad()
        {
            return "Presencial";
        }
    }
}
