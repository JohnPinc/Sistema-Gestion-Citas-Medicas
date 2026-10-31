using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Cl_Cita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public int IdEstado { get; set; }

        public DateTime FechaCita { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public string Motivo { get; set; }
        public string Observaciones { get; set; }

        public int? IdCitaOrigen { get; set; }
    }
}
