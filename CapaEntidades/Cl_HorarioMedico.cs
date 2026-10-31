using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Cl_HorarioMedico
    {
        public int IdHorario { get; set; }
        public int IdMedico { get; set; }
        public int DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public bool Estado { get; set; }
    }
}
