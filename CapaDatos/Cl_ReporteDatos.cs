using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class Cl_ReporteDatos
    {
        private readonly Cl_Conexion objConexion = new Cl_Conexion();

        public DataTable GenerarReporte(
            DateTime fechaDesde,
            DateTime fechaHasta,
            int? idMedico,
            int? idPaciente,
            int? idEstado)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_reporte_citas",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@fecha_desde",
                    SqlDbType.Date).Value = fechaDesde.Date;

                comando.Parameters.Add(
                    "@fecha_hasta",
                    SqlDbType.Date).Value = fechaHasta.Date;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value =
                    idMedico.HasValue
                        ? idMedico.Value
                        : DBNull.Value;

                comando.Parameters.Add(
                    "@id_paciente",
                    SqlDbType.Int).Value =
                    idPaciente.HasValue
                        ? idPaciente.Value
                        : DBNull.Value;

                comando.Parameters.Add(
                    "@id_estado",
                    SqlDbType.Int).Value =
                    idEstado.HasValue
                        ? idEstado.Value
                        : DBNull.Value;

                SqlDataAdapter adaptador =
                    new SqlDataAdapter(comando);

                adaptador.Fill(tabla);

                return tabla;
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }
    }
}
