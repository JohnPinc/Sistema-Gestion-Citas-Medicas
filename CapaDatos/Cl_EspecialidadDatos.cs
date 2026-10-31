using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaEntidades;

namespace CapaDatos
{
    public class Cl_EspecialidadDatos
    {
        private readonly Cl_Conexion objConexion = new Cl_Conexion();

        public DataTable ListarEspecialidades()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_especialidad_listar",
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

        public DataTable ListarEspecialidadesActivas()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_especialidad_listar_activas",
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

        public DataTable BuscarEspecialidades(string texto)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_especialidad_buscar",
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

        public void RegistrarEspecialidad(Cl_Especialidad especialidad)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_especialidad_registrar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@nombre",
                    SqlDbType.NVarChar,
                    100).Value = especialidad.Nombre;

                comando.Parameters.Add(
                    "@descripcion",
                    SqlDbType.NVarChar,
                    250).Value = especialidad.Descripcion ?? string.Empty;

                comando.Parameters.Add(
                    "@estado",
                    SqlDbType.Bit).Value = especialidad.Estado;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void ModificarEspecialidad(Cl_Especialidad especialidad)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_especialidad_modificar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_especialidad",
                    SqlDbType.Int).Value = especialidad.IdEspecialidad;

                comando.Parameters.Add(
                    "@nombre",
                    SqlDbType.NVarChar,
                    100).Value = especialidad.Nombre;

                comando.Parameters.Add(
                    "@descripcion",
                    SqlDbType.NVarChar,
                    250).Value = especialidad.Descripcion ?? string.Empty;

                comando.Parameters.Add(
                    "@estado",
                    SqlDbType.Bit).Value = especialidad.Estado;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void DarBajaEspecialidad(int idEspecialidad)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_especialidad_dar_baja",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_especialidad",
                    SqlDbType.Int).Value = idEspecialidad;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }
    }
}
