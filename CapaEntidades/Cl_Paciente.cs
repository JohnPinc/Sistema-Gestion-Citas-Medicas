using System;
using System.Collections.Generic;
using System.Text;


namespace CapaEntidades
{
    public class Cl_Paciente
    {
        public int IdPaciente { get; set; }

        public string Cedula { get; set; } = string.Empty;

        public string Nombres { get; set; } = string.Empty;

        public string Apellidos { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        public string Genero { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public bool Estado { get; set; }
    }
}
