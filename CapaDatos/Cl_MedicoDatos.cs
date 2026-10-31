using CapaEntidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class Cl_MedicoDatos
    {
        private readonly Cl_Conexion objConexion = new Cl_Conexion();

        public DataTable ListarMedicos()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_medico_listar",
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

        public DataTable ListarMedicosActivos()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_medico_listar_activos",
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

        public DataTable ListarMedicosPorEspecialidad(int idEspecialidad)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_medico_listar_por_especialidad",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_especialidad",
                    SqlDbType.Int).Value = idEspecialidad;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                return tabla;
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public DataTable BuscarMedicos(string texto)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_medico_buscar",
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

        public void RegistrarMedico(Cl_Medico medico)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_medico_registrar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_especialidad",
                    SqlDbType.Int).Value = medico.IdEspecialidad;

                comando.Parameters.Add(
                    "@cedula",
                    SqlDbType.VarChar,
                    10).Value = medico.Cedula;

                comando.Parameters.Add(
                    "@numero_colegiatura",
                    SqlDbType.VarChar,
                    30).Value = medico.NumeroColegiatura;

                comando.Parameters.Add(
                    "@nombres",
                    SqlDbType.NVarChar,
                    100).Value = medico.Nombres;

                comando.Parameters.Add(
                    "@apellidos",
                    SqlDbType.NVarChar,
                    100).Value = medico.Apellidos;

                comando.Parameters.Add(
                    "@telefono",
                    SqlDbType.VarChar,
                    15).Value = medico.Telefono ?? string.Empty;

                comando.Parameters.Add(
                    "@correo",
                    SqlDbType.VarChar,
                    150).Value = medico.Correo ?? string.Empty;

                comando.Parameters.Add(
                    "@estado",
                    SqlDbType.Bit).Value = medico.Estado;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void ModificarMedico(Cl_Medico medico)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_medico_modificar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value = medico.IdMedico;

                comando.Parameters.Add(
                    "@id_especialidad",
                    SqlDbType.Int).Value = medico.IdEspecialidad;

                comando.Parameters.Add(
                    "@cedula",
                    SqlDbType.VarChar,
                    10).Value = medico.Cedula;

                comando.Parameters.Add(
                    "@numero_colegiatura",
                    SqlDbType.VarChar,
                    30).Value = medico.NumeroColegiatura;

                comando.Parameters.Add(
                    "@nombres",
                    SqlDbType.NVarChar,
                    100).Value = medico.Nombres;

                comando.Parameters.Add(
                    "@apellidos",
                    SqlDbType.NVarChar,
                    100).Value = medico.Apellidos;

                comando.Parameters.Add(
                    "@telefono",
                    SqlDbType.VarChar,
                    15).Value = medico.Telefono ?? string.Empty;

                comando.Parameters.Add(
                    "@correo",
                    SqlDbType.VarChar,
                    150).Value = medico.Correo ?? string.Empty;

                comando.Parameters.Add(
                    "@estado",
                    SqlDbType.Bit).Value = medico.Estado;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void DarBajaMedico(int idMedico)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_medico_dar_baja",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_medico",
                    SqlDbType.Int).Value = idMedico;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }
    }
}
