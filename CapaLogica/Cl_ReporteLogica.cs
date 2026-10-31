using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaLogica
{
    public class Cl_ReporteLogica
    {
        private readonly Cl_ReporteDatos objDatos =
                    new Cl_ReporteDatos();

        public DataTable GenerarReporte(
            DateTime fechaDesde,
            DateTime fechaHasta,
            int? idMedico,
            int? idPaciente,
            int? idEstado)
        {
            if (fechaDesde.Date > fechaHasta.Date)
            {
                throw new Exception(
                    "La fecha inicial no puede ser mayor que la fecha final.");
            }

            if (idMedico.HasValue && idMedico.Value <= 0)
            {
                idMedico = null;
            }

            if (idPaciente.HasValue && idPaciente.Value <= 0)
            {
                idPaciente = null;
            }

            if (idEstado.HasValue && idEstado.Value <= 0)
            {
                idEstado = null;
            }

            return objDatos.GenerarReporte(
                fechaDesde,
                fechaHasta,
                idMedico,
                idPaciente,
                idEstado);
        }
    }
}
