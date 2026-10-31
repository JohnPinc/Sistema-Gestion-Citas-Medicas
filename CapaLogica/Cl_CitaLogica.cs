using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaLogica
{
    public class Cl_CitaLogica
    {
        private readonly Cl_CitaDatos objDatos =
                    new Cl_CitaDatos();

        public DataTable ListarCitas()
        {
            return objDatos.ListarCitas();
        }

        public DataTable BuscarCitas(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return objDatos.ListarCitas();
            }

            return objDatos.BuscarCitas(texto.Trim());
        }

        public DataTable ListarEstadosCita()
        {
            return objDatos.ListarEstadosCita();
        }

        public DataTable ListarCitasPorMedico(int idMedico)
        {
            if (idMedico <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un médico.");
            }

            return objDatos.ListarCitasPorMedico(idMedico);
        }

        public DataTable ValidarDisponibilidad(
            int idPaciente,
            int idMedico,
            DateTime fechaCita,
            TimeSpan horaInicio,
            TimeSpan horaFin,
            int? idCitaExcluir)
        {
            ValidarFechaHorario(
                idPaciente,
                idMedico,
                fechaCita,
                horaInicio,
                horaFin);

            return objDatos.ValidarDisponibilidad(
                idPaciente,
                idMedico,
                fechaCita,
                horaInicio,
                horaFin,
                idCitaExcluir);
        }

        public int RegistrarCita(Cl_Cita cita)
        {
            ValidarCita(cita);

            LimpiarDatos(cita);

            return objDatos.RegistrarCita(cita);
        }

        public void ModificarCita(Cl_Cita cita)
        {
            if (cita.IdCita <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una cita para modificar.");
            }

            ValidarCita(cita);

            LimpiarDatos(cita);

            objDatos.ModificarCita(cita);
        }

        public void CancelarCita(
            int idCita,
            string observaciones)
        {
            if (idCita <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una cita para cancelar.");
            }

            if (!string.IsNullOrWhiteSpace(observaciones) &&
                observaciones.Trim().Length > 500)
            {
                throw new Exception(
                    "Las observaciones no pueden superar los 500 caracteres.");
            }

            objDatos.CancelarCita(
                idCita,
                observaciones?.Trim() ?? string.Empty);
        }

        public void MarcarAtendida(
            int idCita,
            string observaciones)
        {
            if (idCita <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una cita.");
            }

            ValidarObservaciones(observaciones);

            objDatos.MarcarAtendida(
                idCita,
                observaciones?.Trim() ?? string.Empty);
        }

        public void MarcarNoAsistida(
            int idCita,
            string observaciones)
        {
            if (idCita <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una cita.");
            }

            ValidarObservaciones(observaciones);

            objDatos.MarcarNoAsistida(
                idCita,
                observaciones?.Trim() ?? string.Empty);
        }

        public int ReprogramarCita(
            int idCita,
            DateTime nuevaFecha,
            TimeSpan nuevaHoraInicio,
            TimeSpan nuevaHoraFin,
            string observaciones)
        {
            if (idCita <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una cita para reprogramar.");
            }

            ValidarNuevaFechaHorario(
                nuevaFecha,
                nuevaHoraInicio,
                nuevaHoraFin);

            ValidarObservaciones(observaciones);

            return objDatos.ReprogramarCita(
                idCita,
                nuevaFecha,
                nuevaHoraInicio,
                nuevaHoraFin,
                observaciones?.Trim() ?? string.Empty);
        }

        public DataTable HistorialPaciente(
            int idPaciente,
            DateTime? fechaDesde,
            DateTime? fechaHasta,
            int? idEstado)
        {
            if (idPaciente <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un paciente.");
            }

            if (fechaDesde.HasValue &&
                fechaHasta.HasValue &&
                fechaDesde.Value.Date > fechaHasta.Value.Date)
            {
                throw new Exception(
                    "La fecha inicial no puede ser mayor que la fecha final.");
            }

            return objDatos.HistorialPaciente(
                idPaciente,
                fechaDesde,
                fechaHasta,
                idEstado);
        }

        private void ValidarCita(Cl_Cita cita)
        {
            if (cita == null)
            {
                throw new Exception(
                    "No se recibió la información de la cita.");
            }

            ValidarFechaHorario(
                cita.IdPaciente,
                cita.IdMedico,
                cita.FechaCita,
                cita.HoraInicio,
                cita.HoraFin);

            if (string.IsNullOrWhiteSpace(cita.Motivo))
            {
                throw new Exception(
                    "El motivo de la cita es obligatorio.");
            }

            if (cita.Motivo.Trim().Length > 250)
            {
                throw new Exception(
                    "El motivo no puede superar los 250 caracteres.");
            }

            ValidarObservaciones(cita.Observaciones);
        }

        private void ValidarFechaHorario(
            int idPaciente,
            int idMedico,
            DateTime fechaCita,
            TimeSpan horaInicio,
            TimeSpan horaFin)
        {
            if (idPaciente <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un paciente.");
            }

            if (idMedico <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un médico.");
            }

            ValidarNuevaFechaHorario(
                fechaCita,
                horaInicio,
                horaFin);
        }

        private void ValidarNuevaFechaHorario(
            DateTime fecha,
            TimeSpan horaInicio,
            TimeSpan horaFin)
        {
            if (fecha.Date < DateTime.Today)
            {
                throw new Exception(
                    "La fecha de la cita no puede ser anterior a la fecha actual.");
            }

            if (horaInicio < TimeSpan.Zero ||
                horaInicio >= TimeSpan.FromDays(1))
            {
                throw new Exception(
                    "La hora de inicio no es válida.");
            }

            if (horaFin <= TimeSpan.Zero ||
                horaFin > TimeSpan.FromDays(1))
            {
                throw new Exception(
                    "La hora final no es válida.");
            }

            if (horaInicio >= horaFin)
            {
                throw new Exception(
                    "La hora de inicio debe ser menor que la hora final.");
            }

            if (fecha.Date == DateTime.Today &&
                horaInicio <= DateTime.Now.TimeOfDay)
            {
                throw new Exception(
                    "La hora de la cita debe ser posterior a la hora actual.");
            }
        }

        private void ValidarObservaciones(
            string observaciones)
        {
            if (!string.IsNullOrWhiteSpace(observaciones) &&
                observaciones.Trim().Length > 500)
            {
                throw new Exception(
                    "Las observaciones no pueden superar los 500 caracteres.");
            }
        }

        private void LimpiarDatos(Cl_Cita cita)
        {
            cita.Motivo = cita.Motivo.Trim();

            cita.Observaciones =
                cita.Observaciones?.Trim() ?? string.Empty;
        }
    }
}