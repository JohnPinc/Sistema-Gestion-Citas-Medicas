using CapaEntidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class Cl_PacienteDatos
    {
        private readonly Cl_Conexion objConexion = new Cl_Conexion();

        public DataTable ListarPacientes()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_paciente_listar",
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

        public DataTable ListarPacientesActivos()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_paciente_listar_activos",
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

        public DataTable BuscarPacientes(string texto)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_paciente_buscar",
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

        public void RegistrarPaciente(Cl_Paciente paciente)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_paciente_registrar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@cedula",
                    SqlDbType.VarChar,
                    10).Value = paciente.Cedula;

                comando.Parameters.Add(
                    "@nombres",
                    SqlDbType.NVarChar,
                    100).Value = paciente.Nombres;

                comando.Parameters.Add(
                    "@apellidos",
                    SqlDbType.NVarChar,
                    100).Value = paciente.Apellidos;

                comando.Parameters.Add(
                    "@fecha_nacimiento",
                    SqlDbType.Date).Value = paciente.FechaNacimiento;

                comando.Parameters.Add(
                    "@genero",
                    SqlDbType.NVarChar,
                    20).Value = paciente.Genero;

                comando.Parameters.Add(
                    "@telefono",
                    SqlDbType.VarChar,
                    15).Value = paciente.Telefono ?? string.Empty;

                comando.Parameters.Add(
                    "@correo",
                    SqlDbType.VarChar,
                    150).Value = paciente.Correo ?? string.Empty;

                comando.Parameters.Add(
                    "@direccion",
                    SqlDbType.NVarChar,
                    250).Value = paciente.Direccion ?? string.Empty;

                comando.Parameters.Add(
                    "@estado",
                    SqlDbType.Bit).Value = paciente.Estado;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void ModificarPaciente(Cl_Paciente paciente)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_paciente_modificar",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_paciente",
                    SqlDbType.Int).Value = paciente.IdPaciente;

                comando.Parameters.Add(
                    "@cedula",
                    SqlDbType.VarChar,
                    10).Value = paciente.Cedula;

                comando.Parameters.Add(
                    "@nombres",
                    SqlDbType.NVarChar,
                    100).Value = paciente.Nombres;

                comando.Parameters.Add(
                    "@apellidos",
                    SqlDbType.NVarChar,
                    100).Value = paciente.Apellidos;

                comando.Parameters.Add(
                    "@fecha_nacimiento",
                    SqlDbType.Date).Value = paciente.FechaNacimiento;

                comando.Parameters.Add(
                    "@genero",
                    SqlDbType.NVarChar,
                    20).Value = paciente.Genero;

                comando.Parameters.Add(
                    "@telefono",
                    SqlDbType.VarChar,
                    15).Value = paciente.Telefono ?? string.Empty;

                comando.Parameters.Add(
                    "@correo",
                    SqlDbType.VarChar,
                    150).Value = paciente.Correo ?? string.Empty;

                comando.Parameters.Add(
                    "@direccion",
                    SqlDbType.NVarChar,
                    250).Value = paciente.Direccion ?? string.Empty;

                comando.Parameters.Add(
                    "@estado",
                    SqlDbType.Bit).Value = paciente.Estado;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }

        public void DarBajaPaciente(int idPaciente)
        {
            try
            {
                SqlCommand comando = new SqlCommand(
                    "sp_paciente_dar_baja",
                    objConexion.AbrirConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(
                    "@id_paciente",
                    SqlDbType.Int).Value = idPaciente;

                comando.ExecuteNonQuery();
            }
            finally
            {
                objConexion.CerrarConexion();
            }
        }
    }
}
