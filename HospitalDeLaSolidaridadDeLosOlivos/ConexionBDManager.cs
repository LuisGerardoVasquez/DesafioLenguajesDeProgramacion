using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public sealed class ConexionBDManager
    {
        // ATRIBUTOS
        private static ConexionBDManager _instancia;
        private static readonly object _lock = new object();

        // PROPIEDADES
        public string RutaBaseDatos { get; set; }
        public List<Paciente> Pacientes { get; private set; }
        public List<PersonalSalud> Personal { get; private set; }
        public List<Medicamento> Medicamentos { get; private set; }
        public List<CitaMedica> Citas { get; private set; }

        // CONSTRUCTOR
        private ConexionBDManager()
        {
            RutaBaseDatos = "Datos";

            Pacientes = new List<Paciente>
            {
                // Datos iniciales
                new Paciente("PC-0001", "Ana Torres", "71131346", "910248156", "HC-0001", new DateTime(1990, 5, 14), "O+"),
                new Paciente("PC-0002", "Luis Rojas", "23696822", "992141574", "HC-0002", new DateTime(1985, 11, 2), "B+"),
                new Paciente("PC-0003", "María Quispe", "82717431", "933437900", "HC-0003", new DateTime(2001, 3, 27), "A-"),
                new Paciente("PC-0004", "Carlos Mendoza", "45812093", "987654321", "HC-0004", new DateTime(1978, 8, 9), "AB+"),
                new Paciente("PC-0005", "Rosa Huamán", "60237415", "945128376", "HC-0005", new DateTime(1995, 1, 30), "O-"),
                new Paciente("PC-0006", "Jorge Salazar", "38291746", "921345678", "HC-0006", new DateTime(1969, 12, 3), "A+"),
                new Paciente("PC-0007", "Lucía Paredes", "72406158", "958231467", "HC-0007", new DateTime(2003, 6, 18), "B-"),
                new Paciente("PC-0008", "Miguel Vargas", "19573820", "936782145", "HC-0008", new DateTime(1982, 4, 25), "O+"),
                new Paciente("PC-0009", "Elena Chávez", "56184973", "914567823", "HC-0009", new DateTime(1990, 9, 11), "AB-"),
                new Paciente("PC-0010", "Pedro Ramírez", "80329651", "973214685", "HC-0010", new DateTime(1957, 2, 7), "A+")
            };

            Personal = new List<PersonalSalud>
            {
                //Datos iniciales
                new PersonalSalud("PS-0001", "Ricardo Medina", "41256873", "987123456", "45821", "Medicina general"),
                new PersonalSalud("PS-0002", "Patricia León", "33718492", "956234781", "38210", "Pediatría"),
                new PersonalSalud("PS-0003", "Sandra Quiroz", "70521364", "934567218", "62874", "Enfermería"),
                new PersonalSalud("PS-0004", "Karen Flores", "48193627", "921876543", "57439", "Obstetricia"),
                new PersonalSalud("PS-0005", "Daniel Alva", "62459187", "945671238", "71352", "Psicología"),
                new PersonalSalud("PS-0006", "Mariana Soto", "53217894", "968123745", "49083", "Nutrición"),
                new PersonalSalud("PS-0007", "Hugo Benavides", "36874215", "912345678", "53167", "Podología"),
                new PersonalSalud("PS-0008", "Alberto Cruz", "29846153", "968345127", "29716", "Medicina general"),
                new PersonalSalud("PS-0009", "Julia Ortega", "74382951", "977654321", "66240", "Pediatría"),
                new PersonalSalud("PS-0010", "Rosa Delgado", "41729638", "935482176", "58904", "Enfermería")
            };

            Medicamentos = new List<Medicamento>
            {
                //Datos iniciales
                new Medicamento("MD-0001", "Paracetamol 500 mg", 120),
                new Medicamento("MD-0002", "Ibuprofeno 400 mg", 80),
                new Medicamento("MD-0003", "Amoxicilina 500 mg", 45),
                new Medicamento("MD-0004", "Loratadina 10 mg", 60),
                new Medicamento("MD-0005", "Omeprazol 20 mg", 90),
                new Medicamento("MD-0006", "Metformina 850 mg", 30),
                new Medicamento("MD-0007", "Losartán 50 mg", 55),
                new Medicamento("MD-0008", "Salbutamol inhalador", 8),
                new Medicamento("MD-0009", "Suero oral", 150),
                new Medicamento("MD-0010", "Diclofenaco 50 mg", 0)
            };

            Citas = new List<CitaMedica>
            {
                //Datos iniciales
                CitaFactory.CrearCita("Presencial",   "CT-0001", Pacientes[0], Personal[0], DateTime.Today.AddDays(1).AddHours(9),  "Control general"),
                CitaFactory.CrearCita("Telemedicina", "CT-0002", Pacientes[1], Personal[7], DateTime.Today.AddDays(1).AddHours(10), "Consulta de seguimiento"),
                CitaFactory.CrearCita("Presencial",   "CT-0003", Pacientes[2], Personal[3], DateTime.Today.AddDays(2).AddHours(11), "Control prenatal"),
                CitaFactory.CrearCita("Telemedicina", "CT-0004", Pacientes[3], Personal[4], DateTime.Today.AddDays(2).AddHours(15), "Sesión de psicología"),
                CitaFactory.CrearCita("Presencial",   "CT-0005", Pacientes[4], Personal[5], DateTime.Today.AddDays(3).AddHours(9),  "Evaluación nutricional"),
                CitaFactory.CrearCita("Presencial",   "CT-0006", Pacientes[5], Personal[6], DateTime.Today.AddDays(3).AddHours(10), "Revisión podológica"),
                CitaFactory.CrearCita("Telemedicina", "CT-0007", Pacientes[6], Personal[0], DateTime.Today.AddDays(4).AddHours(16), "Consulta general"),
                CitaFactory.CrearCita("Presencial",   "CT-0008", Pacientes[7], Personal[2], DateTime.Today.AddDays(4).AddHours(8),  "Control de enfermería")
            };

            // Datos iniciales
            AtencionMedica at1 = new AtencionMedica("AT-0001", "Rinofaringitis aguda", "Reposo e hidratación", DateTime.Today.AddDays(-30));
            at1.GenerarReceta(Medicamentos[0], 2);
            Pacientes[0].AgregarAtencion(at1);

            Pacientes[0].AgregarAtencion(new AtencionMedica("AT-0002", "Control de rutina", "Sin tratamiento", DateTime.Today.AddDays(-10)));

            AtencionMedica at3 = new AtencionMedica("AT-0003", "Gastritis leve", "Dieta blanda", DateTime.Today.AddDays(-20));
            at3.GenerarReceta(Medicamentos[4], 1);
            Pacientes[1].AgregarAtencion(at3);

            Pacientes[2].AgregarAtencion(new AtencionMedica("AT-0004", "Control prenatal", "Suplemento vitamínico", DateTime.Today.AddDays(-7)));
            Pacientes[3].AgregarAtencion(new AtencionMedica("AT-0005", "Estrés laboral", "Seguimiento psicológico", DateTime.Today.AddDays(-15)));
        }

        // METODOS
        public static ConexionBDManager ObtenerInstancia()
        {
            lock (_lock)
            {
                if (_instancia == null)
                {
                    _instancia = new ConexionBDManager();
                }
                return _instancia;
            }
        }
    }

}
