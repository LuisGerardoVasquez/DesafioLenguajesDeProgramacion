using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public static class CitaFactory
    {
        public static readonly string[] TiposValidos = { "Presencial", "Telemedicina" };

        public static CitaMedica CrearCita(string tipo, string id, Paciente paciente,
                                           PersonalSalud medico, DateTime fechaHora, string motivo)
        {
            switch (tipo)
            {
                case "Presencial":
                    return new CitaPresencial(id, paciente, medico, fechaHora, motivo);
                case "Telemedicina":
                    return new CitaTelemedicina(id, paciente, medico, fechaHora, motivo);
                default:
                    throw new ArgumentException("El tipo de cita no es válido.");
            }
        }
    }
}
