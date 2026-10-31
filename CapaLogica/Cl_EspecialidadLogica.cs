using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaLogica
{
    public class Cl_EspecialidadLogica
    {
        private readonly Cl_EspecialidadDatos objDatos =
                    new Cl_EspecialidadDatos();

        public DataTable ListarEspecialidades()
        {
            return objDatos.ListarEspecialidades();
        }

        public DataTable ListarEspecialidadesActivas()
        {
            return objDatos.ListarEspecialidadesActivas();
        }

        public DataTable BuscarEspecialidades(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return objDatos.ListarEspecialidades();
            }

            return objDatos.BuscarEspecialidades(texto.Trim());
        }

        public void RegistrarEspecialidad(Cl_Especialidad especialidad)
        {
            ValidarEspecialidad(especialidad);

            especialidad.Nombre = especialidad.Nombre.Trim();
            especialidad.Descripcion =
                especialidad.Descripcion?.Trim() ?? string.Empty;

            objDatos.RegistrarEspecialidad(especialidad);
        }

        public void ModificarEspecialidad(Cl_Especialidad especialidad)
        {
            if (especialidad.IdEspecialidad <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una especialidad para modificar.");
            }

            ValidarEspecialidad(especialidad);

            especialidad.Nombre = especialidad.Nombre.Trim();
            especialidad.Descripcion =
                especialidad.Descripcion?.Trim() ?? string.Empty;

            objDatos.ModificarEspecialidad(especialidad);
        }

        public void DarBajaEspecialidad(int idEspecialidad)
        {
            if (idEspecialidad <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una especialidad para dar de baja.");
            }

            objDatos.DarBajaEspecialidad(idEspecialidad);
        }

        private void ValidarEspecialidad(Cl_Especialidad especialidad)
        {
            if (especialidad == null)
            {
                throw new Exception(
                    "No se recibió la información de la especialidad.");
            }

            if (string.IsNullOrWhiteSpace(especialidad.Nombre))
            {
                throw new Exception(
                    "El nombre de la especialidad es obligatorio.");
            }

            if (especialidad.Nombre.Trim().Length > 100)
            {
                throw new Exception(
                    "El nombre no puede superar los 100 caracteres.");
            }

            if (!string.IsNullOrWhiteSpace(especialidad.Descripcion) &&
                especialidad.Descripcion.Trim().Length > 250)
            {
                throw new Exception(
                    "La descripción no puede superar los 250 caracteres.");
            }
        }
    }
}
