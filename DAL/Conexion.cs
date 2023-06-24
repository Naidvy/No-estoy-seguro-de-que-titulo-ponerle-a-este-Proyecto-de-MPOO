using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexion
    {
        private static string NombreAplicacion = "GeneradorCapas";
        private static string Servidor = @"Norman\SALLY";
        private static string Usuario = "";
        private static string Password = "";
        private static string BaseDatos = "MPOO";

        public static string ConexionString (bool SqlAutentication = true)
        {
            SqlConnectionStringBuilder ConstructorCadenaConexion = new()
            {
                ApplicationName = NombreAplicacion,
                IntegratedSecurity = !SqlAutentication,
                DataSource = Servidor,
                InitialCatalog = BaseDatos
            };
            if (SqlAutentication)
            {
                ConstructorCadenaConexion.UserID = Usuario;
                ConstructorCadenaConexion.Password = Password;
            }
            return ConstructorCadenaConexion.ConnectionString;
        }
    }
}
