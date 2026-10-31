using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Cl_Medico
    {
        public int IdMedico { get; set; }
        public int IdEspecialidad { get; set; }
        public string Cedula { get; set; }
        public string NumeroColegiatura { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
    }
}
