using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Text;

namespace CapaLogica
{
    public class Cl_PacienteLogica
    {
        private readonly Cl_PacienteDatos objDatos =
                    new Cl_PacienteDatos();

        public DataTable ListarPacientes()
        {
            return objDatos.ListarPacientes();
        }

        public DataTable ListarPacientesActivos()
        {
            return objDatos.ListarPacientesActivos();
        }

        public DataTable BuscarPacientes(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return objDatos.ListarPacientes();
            }

            return objDatos.BuscarPacientes(texto.Trim());
        }

        public void RegistrarPaciente(Cl_Paciente paciente)
        {
            ValidarPaciente(paciente);

            LimpiarDatos(paciente);

            objDatos.RegistrarPaciente(paciente);
        }

        public void ModificarPaciente(Cl_Paciente paciente)
        {
            if (paciente.IdPaciente <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un paciente para modificar.");
            }

            ValidarPaciente(paciente);

            LimpiarDatos(paciente);

            objDatos.ModificarPaciente(paciente);
        }

        public void DarBajaPaciente(int idPaciente)
        {
            if (idPaciente <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un paciente para dar de baja.");
            }

            objDatos.DarBajaPaciente(idPaciente);
        }

        private void ValidarPaciente(Cl_Paciente paciente)
        {
            if (paciente == null)
            {
                throw new Exception(
                    "No se recibió la información del paciente.");
            }

            if (string.IsNullOrWhiteSpace(paciente.Cedula))
            {
                throw new Exception(
                    "La cédula del paciente es obligatoria.");
            }

            if (paciente.Cedula.Trim().Length != 10)
            {
                throw new Exception(
                    "La cédula debe contener exactamente 10 números.");
            }

            foreach (char caracter in paciente.Cedula.Trim())
            {
                if (!char.IsDigit(caracter))
                {
                    throw new Exception(
                        "La cédula solamente puede contener números.");
                }
            }

            if (string.IsNullOrWhiteSpace(paciente.Nombres))
            {
                throw new Exception(
                    "Los nombres del paciente son obligatorios.");
            }

            if (string.IsNullOrWhiteSpace(paciente.Apellidos))
            {
                throw new Exception(
                    "Los apellidos del paciente son obligatorios.");
            }

            if (paciente.FechaNacimiento.Date > DateTime.Today)
            {
                throw new Exception(
                    "La fecha de nacimiento no puede ser futura.");
            }

            if (string.IsNullOrWhiteSpace(paciente.Genero))
            {
                throw new Exception(
                    "Debe seleccionar el género del paciente.");
            }

            if (!string.IsNullOrWhiteSpace(paciente.Telefono))
            {
                foreach (char caracter in paciente.Telefono.Trim())
                {
                    if (!char.IsDigit(caracter))
                    {
                        throw new Exception(
                            "El teléfono solamente puede contener números.");
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(paciente.Correo))
            {
                try
                {
                    MailAddress correo =
                        new MailAddress(paciente.Correo.Trim());
                }
                catch
                {
                    throw new Exception(
                        "El correo electrónico no tiene un formato válido.");
                }
            }

            if (paciente.Nombres.Trim().Length > 100)
            {
                throw new Exception(
                    "Los nombres no pueden superar los 100 caracteres.");
            }

            if (paciente.Apellidos.Trim().Length > 100)
            {
                throw new Exception(
                    "Los apellidos no pueden superar los 100 caracteres.");
            }

            if (!string.IsNullOrWhiteSpace(paciente.Direccion) &&
                paciente.Direccion.Trim().Length > 250)
            {
                throw new Exception(
                    "La dirección no puede superar los 250 caracteres.");
            }
        }

        private void LimpiarDatos(Cl_Paciente paciente)
        {
            paciente.Cedula = paciente.Cedula.Trim();
            paciente.Nombres = paciente.Nombres.Trim();
            paciente.Apellidos = paciente.Apellidos.Trim();
            paciente.Genero = paciente.Genero.Trim();

            paciente.Telefono =
                paciente.Telefono?.Trim() ?? string.Empty;

            paciente.Correo =
                paciente.Correo?.Trim() ?? string.Empty;

            paciente.Direccion =
                paciente.Direccion?.Trim() ?? string.Empty;
        }
    }
}
