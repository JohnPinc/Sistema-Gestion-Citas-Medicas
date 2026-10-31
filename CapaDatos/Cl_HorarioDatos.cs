using CapaEntidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class Cl_HorarioDatos
    {
        private readonly Cl_Conexion objConexion = new Cl_Conexion();

        public DataTable ListarHorariosPorMedico(int idMedico)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_horario_listar_por_medico",
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

        public void RegistrarHorario(Cl_HorarioMedico horario)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_horario_registrar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value = horario.IdMedico;

                comando.Parameters.Add(
                    "@dia_semana",
                    SqlDbType.TinyInt).Value = horario.DiaSemana;

                comando.Parameters.Add(
                    "@hora_inicio",
                    SqlDbType.Time).Value = horario.HoraInicio;

                comando.Parameters.Add(
                    "@hora_fin",
                    SqlDbType.Time).Value = horario.HoraFin;

                comando.Parameters.Add(
                    "@estado",
                    SqlDbType.Bit).Value = horario.Estado;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void ModificarHorario(Cl_HorarioMedico horario)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_horario_modificar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_horario",
                    SqlDbType.Int).Value = horario.IdHorario;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value = horario.IdMedico;

                comando.Parameters.Add(
                    "@dia_semana",
                    SqlDbType.TinyInt).Value = horario.DiaSemana;

                comando.Parameters.Add(
                    "@hora_inicio",
                    SqlDbType.Time).Value = horario.HoraInicio;

                comando.Parameters.Add(
                    "@hora_fin",
                    SqlDbType.Time).Value = horario.HoraFin;

                comando.Parameters.Add(
                    "@estado",
                    SqlDbType.Bit).Value = horario.Estado;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void DarBajaHorario(int idHorario)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_horario_dar_baja",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_horario",
                    SqlDbType.Int).Value = idHorario;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }
    }
}

