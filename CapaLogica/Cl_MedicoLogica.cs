using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Text;

namespace CapaLogica
{
    public class Cl_MedicoLogica
    {
        private readonly Cl_MedicoDatos objDatos =
                    new Cl_MedicoDatos();

        public DataTable ListarMedicos()
        {
            return objDatos.ListarMedicos();
        }

        public DataTable ListarMedicosActivos()
        {
            return objDatos.ListarMedicosActivos();
        }

        public DataTable ListarMedicosPorEspecialidad(int idEspecialidad)
        {
            if (idEspecialidad <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una especialidad.");
            }

            return objDatos.ListarMedicosPorEspecialidad(
                idEspecialidad);
        }

        public DataTable BuscarMedicos(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return objDatos.ListarMedicos();
            }

            return objDatos.BuscarMedicos(texto.Trim());
        }

        public void RegistrarMedico(Cl_Medico medico)
        {
            ValidarMedico(medico);
            LimpiarDatos(medico);

            objDatos.RegistrarMedico(medico);
        }

        public void ModificarMedico(Cl_Medico medico)
        {
            if (medico.IdMedico <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un médico para modificar.");
            }

            ValidarMedico(medico);
            LimpiarDatos(medico);

            objDatos.ModificarMedico(medico);
        }

        public void DarBajaMedico(int idMedico)
        {
            if (idMedico <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un médico para dar de baja.");
            }

            objDatos.DarBajaMedico(idMedico);
        }

        private void ValidarMedico(Cl_Medico medico)
        {
            if (medico == null)
            {
                throw new Exception(
                    "No se recibió la información del médico.");
            }

            if (medico.IdEspecialidad <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una especialidad.");
            }

            if (string.IsNullOrWhiteSpace(medico.Cedula))
            {
                throw new Exception(
                    "La cédula del médico es obligatoria.");
            }

            if (medico.Cedula.Trim().Length != 10)
            {
                throw new Exception(
                    "La cédula debe contener exactamente 10 números.");
            }

            foreach (char caracter in medico.Cedula.Trim())
            {
                if (!char.IsDigit(caracter))
                {
                    throw new Exception(
                        "La cédula solamente puede contener números.");
                }
            }

            if (string.IsNullOrWhiteSpace(
                medico.NumeroColegiatura))
            {
                throw new Exception(
                    "El número de colegiatura es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(medico.Nombres))
            {
                throw new Exception(
                    "Los nombres del médico son obligatorios.");
            }

            if (string.IsNullOrWhiteSpace(medico.Apellidos))
            {
                throw new Exception(
                    "Los apellidos del médico son obligatorios.");
            }

            if (!string.IsNullOrWhiteSpace(medico.Telefono))
            {
                foreach (char caracter in medico.Telefono.Trim())
                {
                    if (!char.IsDigit(caracter))
                    {
                        throw new Exception(
                            "El teléfono solamente puede contener números.");
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(medico.Correo))
            {
                try
                {
                    MailAddress correo =
                        new MailAddress(medico.Correo.Trim());
                }
                catch
                {
                    throw new Exception(
                        "El correo electrónico no tiene un formato válido.");
                }
            }

            if (medico.NumeroColegiatura.Trim().Length > 30)
            {
                throw new Exception(
                    "La colegiatura no puede superar los 30 caracteres.");
            }

            if (medico.Nombres.Trim().Length > 100)
            {
                throw new Exception(
                    "Los nombres no pueden superar los 100 caracteres.");
            }

            if (medico.Apellidos.Trim().Length > 100)
            {
                throw new Exception(
                    "Los apellidos no pueden superar los 100 caracteres.");
            }

            if (!string.IsNullOrWhiteSpace(medico.Telefono) &&
                medico.Telefono.Trim().Length > 15)
            {
                throw new Exception(
                    "El teléfono no puede superar los 15 caracteres.");
            }

            if (!string.IsNullOrWhiteSpace(medico.Correo) &&
                medico.Correo.Trim().Length > 150)
            {
                throw new Exception(
                    "El correo no puede superar los 150 caracteres.");
            }
        }

        private void LimpiarDatos(Cl_Medico medico)
        {
            medico.Cedula = medico.Cedula.Trim();

            medico.NumeroColegiatura =
                medico.NumeroColegiatura.Trim();

            medico.Nombres = medico.Nombres.Trim();
            medico.Apellidos = medico.Apellidos.Trim();

            medico.Telefono =
                medico.Telefono?.Trim() ?? string.Empty;

            medico.Correo =
                medico.Correo?.Trim() ?? string.Empty;
        }
    }
}
