using CapaEntidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class Cl_CitaDatos
    {
        private readonly Cl_Conexion objConexion = new Cl_Conexion();

        public DataTable ListarCitas()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_listar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                return tabla;
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public DataTable BuscarCitas(string texto)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_buscar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@texto",
                    SqlDbType.NVarChar,
                    100).Value = texto;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                return tabla;
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public DataTable ListarEstadosCita()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_estado_cita_listar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                return tabla;
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public DataTable ValidarDisponibilidad(
            int idPaciente,
            int idMedico,
            DateTime fechaCita,
            TimeSpan horaInicio,
            TimeSpan horaFin,
            int? idCitaExcluir)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_validar_disponibilidad",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_paciente",
                    SqlDbType.Int).Value = idPaciente;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value = idMedico;

                comando.Parameters.Add(
                    "@fecha_cita",
                    SqlDbType.Date).Value = fechaCita.Date;

                comando.Parameters.Add(
                    "@hora_inicio",
                    SqlDbType.Time).Value = horaInicio;

                comando.Parameters.Add(
                    "@hora_fin",
                    SqlDbType.Time).Value = horaFin;

                comando.Parameters.Add(
                    "@id_cita_excluir",
                    SqlDbType.Int).Value =
                    idCitaExcluir.HasValue
                        ? idCitaExcluir.Value
                        : DBNull.Value;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                return tabla;
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public int RegistrarCita(Cl_Cita cita)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_registrar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_paciente",
                    SqlDbType.Int).Value = cita.IdPaciente;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value = cita.IdMedico;

                comando.Parameters.Add(
                    "@fecha_cita",
                    SqlDbType.Date).Value = cita.FechaCita.Date;

                comando.Parameters.Add(
                    "@hora_inicio",
                    SqlDbType.Time).Value = cita.HoraInicio;

                comando.Parameters.Add(
                    "@hora_fin",
                    SqlDbType.Time).Value = cita.HoraFin;

                comando.Parameters.Add(
                    "@motivo",
                    SqlDbType.NVarChar,
                    250).Value = cita.Motivo;

                comando.Parameters.Add(
                    "@observaciones",
                    SqlDbType.NVarChar,
                    500).Value = cita.Observaciones ?? string.Empty;

                object resultado = comando.ExecuteScalar();

                return Convert.ToInt32(resultado);
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void ModificarCita(Cl_Cita cita)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_modificar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_cita",
                    SqlDbType.Int).Value = cita.IdCita;

                comando.Parameters.Add(
                    "@id_paciente",
                    SqlDbType.Int).Value = cita.IdPaciente;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value = cita.IdMedico;

                comando.Parameters.Add(
                    "@fecha_cita",
                    SqlDbType.Date).Value = cita.FechaCita.Date;

                comando.Parameters.Add(
                    "@hora_inicio",
                    SqlDbType.Time).Value = cita.HoraInicio;

                comando.Parameters.Add(
                    "@hora_fin",
                    SqlDbType.Time).Value = cita.HoraFin;

                comando.Parameters.Add(
                    "@motivo",
                    SqlDbType.NVarChar,
                    250).Value = cita.Motivo;

                comando.Parameters.Add(
                    "@observaciones",
                    SqlDbType.NVarChar,
                    500).Value = cita.Observaciones ?? string.Empty;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void CancelarCita(int idCita, string observaciones)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_cancelar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_cita",
                    SqlDbType.Int).Value = idCita;

                comando.Parameters.Add(
                    "@observaciones",
                    SqlDbType.NVarChar,
                    500).Value = observaciones ?? string.Empty;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void MarcarAtendida(int idCita, string observaciones)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_marcar_atendida",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_cita",
                    SqlDbType.Int).Value = idCita;

                comando.Parameters.Add(
                    "@observaciones",
                    SqlDbType.NVarChar,
                    500).Value = observaciones ?? string.Empty;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void MarcarNoAsistida(int idCita, string observaciones)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_marcar_no_asistida",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_cita",
                    SqlDbType.Int).Value = idCita;

                comando.Parameters.Add(
                    "@observaciones",
                    SqlDbType.NVarChar,
                    500).Value = observaciones ?? string.Empty;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public int ReprogramarCita(
            int idCita,
            DateTime nuevaFecha,
            TimeSpan nuevaHoraInicio,
            TimeSpan nuevaHoraFin,
            string observaciones)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_reprogramar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_cita",
                    SqlDbType.Int).Value = idCita;

                comando.Parameters.Add(
                    "@nueva_fecha",
                    SqlDbType.Date).Value = nuevaFecha.Date;

                comando.Parameters.Add(
                    "@nueva_hora_inicio",
                    SqlDbType.Time).Value = nuevaHoraInicio;

                comando.Parameters.Add(
                    "@nueva_hora_fin",
                    SqlDbType.Time).Value = nuevaHoraFin;

                comando.Parameters.Add(
                    "@observaciones",
                    SqlDbType.NVarChar,
                    500).Value = observaciones ?? string.Empty;

                object resultado = comando.ExecuteScalar();

                return Convert.ToInt32(resultado);
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public DataTable ListarCitasPorMedico(int idMedico)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_listar_por_medico",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value = idMedico;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                return tabla;
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public DataTable HistorialPaciente(
            int idPaciente,
            DateTime? fechaDesde,
            DateTime? fechaHasta,
            int? idEstado)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_cita_historial_paciente",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_paciente",
                    SqlDbType.Int).Value = idPaciente;

                comando.Parameters.Add(
                    "@fecha_desde",
                    SqlDbType.Date).Value =
                    fechaDesde.HasValue
                        ? fechaDesde.Value.Date
                        : DBNull.Value;

                comando.Parameters.Add(
                    "@fecha_hasta",
                    SqlDbType.Date).Value =
                    fechaHasta.HasValue
                        ? fechaHasta.Value.Date
                        : DBNull.Value;

                comando.Parameters.Add(
                    "@id_estado",
                    SqlDbType.Int).Value =
                    idEstado.HasValue
                        ? idEstado.Value
                        : DBNull.Value;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
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

