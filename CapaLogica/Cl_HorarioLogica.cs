using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaLogica
{
    public class Cl_HorarioLogica
    {
        private readonly Cl_HorarioDatos objDatos =
                    new Cl_HorarioDatos();

        public DataTable ListarHorariosPorMedico(int idMedico)
        {
            if (idMedico <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un médico.");
            }

            return objDatos.ListarHorariosPorMedico(idMedico);
        }

        public void RegistrarHorario(Cl_HorarioMedico horario)
        {
            ValidarHorario(horario);

            objDatos.RegistrarHorario(horario);
        }

        public void ModificarHorario(Cl_HorarioMedico horario)
        {
            if (horario.IdHorario <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un horario para modificar.");
            }

            ValidarHorario(horario);

            objDatos.ModificarHorario(horario);
        }

        public void DarBajaHorario(int idHorario)
        {
            if (idHorario <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un horario para dar de baja.");
            }

            objDatos.DarBajaHorario(idHorario);
        }

        private void ValidarHorario(Cl_HorarioMedico horario)
        {
            if (horario == null)
            {
                throw new Exception(
                    "No se recibió la información del horario.");
            }

            if (horario.IdMedico <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un médico.");
            }

            if (horario.DiaSemana < 1 ||
                horario.DiaSemana > 7)
            {
                throw new Exception(
                    "Debe seleccionar un día de la semana válido.");
            }

            if (horario.HoraInicio >= horario.HoraFin)
            {
                throw new Exception(
                    "La hora de inicio debe ser menor que la hora final.");
            }

            if (horario.HoraInicio < TimeSpan.Zero ||
                horario.HoraInicio >= TimeSpan.FromDays(1))
            {
                throw new Exception(
                    "La hora de inicio no es válida.");
            }

            if (horario.HoraFin <= TimeSpan.Zero ||
                horario.HoraFin > TimeSpan.FromDays(1))
            {
                throw new Exception(
                    "La hora final no es válida.");
            }
        }
    }
}