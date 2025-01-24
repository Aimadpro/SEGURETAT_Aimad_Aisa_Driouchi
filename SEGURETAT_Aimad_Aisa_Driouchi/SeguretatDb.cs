using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace SEGURETAT_Aimad_Aisa_Driouchi
{
    public static class SeguretatDb
    {
        static int id = 0;
        public static bool buscarUsuario(string correo, string contrasenya)
        {
            
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos = null;
            bool encontrado = false;
            string contrasenyaEncontrada = "";

            // Establecemos la conexión a la base de datos
            sentencia.Connection = ConnectionSql.connexio;

            try
            {
                // Preparar la consulta SQL
                sentencia.CommandText = "SELECT contrasenya, id FROM usuaris WHERE correu = @correu";

                // Parametrizamos la consulta para evitar inyecciones SQL
                sentencia.Parameters.AddWithValue("@correu", correo);

                // Abrir la conexión a la base de datos
                ConnectionSql.connexio.Open();

                // Ejecutar la consulta
                datos = sentencia.ExecuteReader();

                // Verificar si se encontraron resultados
                if (datos.HasRows)
                {
                    while (datos.Read())
                    {
                        // Obtener la contraseña almacenada
                        contrasenyaEncontrada = datos["contrasenya"].ToString();
                        id = (int)datos["id"];
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                // Manejar errores de la base de datos
                MessageBox.Show("Error en la consulta SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro tipo de error
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión de manera segura
                if (ConnectionSql.connexio.State == System.Data.ConnectionState.Open)
                {
                    ConnectionSql.connexio.Close();
                }

                // Cerrar el SqlDataReader si está abierto
                if (datos != null && !datos.IsClosed)
                {
                    datos.Close();
                }
            }

            // Verificar si la contraseña es correcta utilizando BCrypt
            if (!string.IsNullOrEmpty(contrasenyaEncontrada))
            {
                encontrado = BCrypt.Net.BCrypt.EnhancedVerify(contrasenya, contrasenyaEncontrada, HashType.SHA512);
            }

            return encontrado;
        }

        
        public static DataTable selectDataGrid()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos = null;
            DataTable taula = new DataTable();

            sentencia.Connection = ConnectionSql.connexio;
            sentencia.Parameters.AddWithValue("@id", id);
            // para mostrar solo la info del usuario seleccionado sentencia.CommandText = "select  rols.actiu, correu,usuaris.nom,cognoms, rols.nom AS nomRol  from usuaris inner join rols on usuaris.rols_id = rols.id where usuaris.id = @id";
            sentencia.CommandText = "select rols.id,  usuaris.id, rols.actiu, correu,usuaris.nom,cognoms, rols.nom AS nomRol  from usuaris inner join rols on usuaris.rols_id = rols.id";

            ConnectionSql.connexio.Open();

            datos = sentencia.ExecuteReader();
            taula.Load(datos);

            ConnectionSql.connexio.Close();

            return taula;
        }
        public static DataTable selectRols()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos = null;
            DataTable taula = new DataTable();

            sentencia.Connection= ConnectionSql.connexio;
            sentencia.CommandText = "select * from rols where actiu = 1";

            ConnectionSql.connexio.Open();

            datos = sentencia.ExecuteReader();
            taula.Load(datos);

            ConnectionSql.connexio.Close();

            return taula;


        }
        public static void deleteUser(int id)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos = null;
            DataTable taula = new DataTable();

            sentencia.Connection = ConnectionSql.connexio;
            sentencia.Parameters.AddWithValue("@id", id);
            // para mostrar solo la info del usuario seleccionado sentencia.CommandText = "select  rols.actiu, correu,usuaris.nom,cognoms, rols.nom AS nomRol  from usuaris inner join rols on usuaris.rols_id = rols.id where usuaris.id = @id";
            sentencia.CommandText = "delete from usuaris where id = @id";

            ConnectionSql.connexio.Open();
            MessageBox.Show("Se ha eliminado correctamente");
            sentencia.ExecuteNonQuery();
            ConnectionSql.connexio.Close();

           
        }
        public static void insertarNuevosUsuarios(string correu, string nom, string cognoms, string contrasenya, int rol, Boolean actiu) 
        {
            if (actiu == false)
            {
                MessageBox.Show("De momento no hgay ningún rol que permita un usuario inactivo, se cambiará a activo");
            }
            else {
                SqlCommand sentencia = new SqlCommand();
            sentencia.Connection = ConnectionSql.connexio;
           

            sentencia.Parameters.AddWithValue("@correu", correu);
            sentencia.Parameters.AddWithValue("@nom", nom);
            sentencia.Parameters.AddWithValue("@cognoms", cognoms);
            sentencia.Parameters.AddWithValue("@contrasenya", contrasenya);
            sentencia.Parameters.AddWithValue("@rol", rol);
            sentencia.Parameters.AddWithValue("@actiu", actiu );

           //sentencia.CommandText = "insert into usuaris values (@correu, @nom, @cognoms,@contrasenya,(SELECT ID FROM rols WHERE nom = @rol), @actiu)";
            sentencia.CommandText = "insert into usuaris values (@correu, @nom, @cognoms,@contrasenya,@rol, @actiu)";
            
    
            ConnectionSql.connexio.Open();
            sentencia.ExecuteNonQuery();
            ConnectionSql.connexio.Close();
            }
        }
        /*
        public static int selectRol(string nomRol)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos = null;
            int rolId = 0;
            sentencia.Connection = ConnectionSql.connexio;

            sentencia.Parameters.AddWithValue("@rol", nomRol);

            sentencia.CommandText = "SELECT ID FROM rols WHERE nom = @rol";


            ConnectionSql.connexio.Open();
            datos = sentencia.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    // Obtener la contraseña almacenada
                    rolId = (int)datos["id"];
                }
            }
            
            else
            {
                MessageBox.Show("Rol no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            ConnectionSql.connexio.Close();
            return rolId;
        }
        */
        public static void Insert(String nom, String apellido, int edad)
        {
            SqlCommand sentencia = new SqlCommand();
            sentencia.Connection = ConnectionSql.connexio;
            sentencia.CommandText = "insert into Persona values (@nom, @apellido, @edad)";
            sentencia.Parameters.AddWithValue("@edad", edad);
            sentencia.Parameters.AddWithValue("@apellido", apellido);
            sentencia.Parameters.AddWithValue("@nom", nom);
            ConnectionSql.connexio.Open();
            sentencia.ExecuteNonQuery();
            ConnectionSql.connexio.Close();
        }


    }
}
