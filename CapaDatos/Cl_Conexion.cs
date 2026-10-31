using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;



namespace CapaDatos
{
    public class Cl_Conexion
    {
        private readonly string cadenaConexion =
                    @"Server=.\SQLEXPRESS;Database=db_citas_medicas;Integrated Security=True;TrustServerCertificate=True;";

        private SqlConnection conexion;

        public Cl_Conexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            return conexion;
        }
    }
}
