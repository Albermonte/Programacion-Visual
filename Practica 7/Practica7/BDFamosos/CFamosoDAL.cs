using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDFamosos
{
    public class CFamosoDAL
    {
        public string strConexion;

        public CFamosoDAL()
        {
            // Obtener la cadena de conexion: elija la adecuada para su instalacion
            //strConexion = @"Data Source=.\sqlexpress;" +
            //  @"Initial Catalog=bd_famosos; Integrated Security=True";

            strConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                @"AttachDBFilename=|DataDirectory|\bd_famosos.mdf; " +
                @"Integrated Security=True";

            // Si no es válido MSSQLLocalDB pruebe con v11.0
        }

        public ColCFamosos ObtenerFilasFamosos()
        {
            try
            {
                using (SqlConnection Conexion = new SqlConnection(strConexion))
                {
                    SqlCommand OrdenSql = new SqlCommand("stproObtenerFilasFamosos", Conexion);
                    OrdenSql.CommandType = CommandType.StoredProcedure;
                    // Crear una coleccion para todos los famosos
                    ColCFamosos colFamosos = new ColCFamosos();
                    // Abrir la base de datos
                    Conexion.Open();
                    SqlDataReader lector = OrdenSql.ExecuteReader();
                    while (lector.Read())
                    {
                        CFamosoBO fila = new CFamosoBO((int)lector["ID"], (string)lector["nombre"], (string)lector["apellidos"], (DateTime)lector["cumple"], (string)lector["imagen"]);
                        colFamosos.Add(fila);
                    }
                    return colFamosos;
                }
            }
            catch (SqlException err)
            {
                throw new ApplicationException("Error SELECT famoso");
            }
        }

        public void ActualizarFamosos(CFamosoBO bo)
        {
            try
            {
                using (SqlConnection Conexion = new SqlConnection(strConexion))
                {
                    SqlCommand OrdenSql = new SqlCommand("stproActualizarFamosos", Conexion);
                    OrdenSql.CommandType = CommandType.StoredProcedure;
                    // Parametros
                    OrdenSql.Parameters.AddWithValue("@ID", bo.Id);
                    OrdenSql.Parameters.AddWithValue("@NOMBRE", bo.Nombre);
                    OrdenSql.Parameters.AddWithValue("@APELLIDOS", bo.Apellidos);
                    OrdenSql.Parameters.AddWithValue("@CUMPLE", bo.Cumple);
                    OrdenSql.Parameters.AddWithValue("@IMAGEN", bo.Imagen);
                    // Abrir la base de datos
                    Conexion.Open();
                    OrdenSql.ExecuteNonQuery();
                    //Cerrar la conexion
                    Conexion.Close();
                }
            }
            catch (SqlException err)
            {
                throw new ApplicationException("Error ACTUALIZAR famoso");
            }
        }
    }
}
