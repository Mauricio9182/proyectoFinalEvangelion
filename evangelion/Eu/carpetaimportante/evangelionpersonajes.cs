using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evangelion.Eu.carpetaimportante
{
    internal class evangelionpersonajes
    {
        // Informacion de conexión a la base de datos
        private string connectionString = "Server=127.0.0.1:3306;Database=evangelion;Uid=root;Pwd=Soynoob9182;";

        public string ConnectionString { get; internal set; }
        // el constructor
        public evangelionpersonajes(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=evangelion;Uid=" + usur + ";Pwd=" + pwd + ";";
        }

        public evangelionpersonajes()
        {
        }

        //La prueba de conexion
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        //metodo para leer personajes
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM evangelion_table";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }

        // Método para poder agregar un nuevo personaje
        public int CrearPersonaje(string nombre, string afiliacion,string estadomental,   int edad, int eva, bool check,  DateTime fechacreacion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO evangelion_table (nombre, afiliacion, estado_mental  , edad_del_personaje, eva_unidad,es_angel, fecha_creacion) VALUES(@nombre, @afiliacion, @estado_mental,  @edad_del_personaje, @eva_unidad,@es_angel, @fecha_creacion)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@afiliacion", afiliacion);
                    command.Parameters.AddWithValue("@estado_mental",estadomental);
                    command.Parameters.AddWithValue("@edad_del_personaje", edad);
                    command.Parameters.AddWithValue("@eva_unidad", eva);
                    command.Parameters.AddWithValue("@es_angel", check);
                    command.Parameters.AddWithValue("@fecha_creacion", fechacreacion);
                    return command.ExecuteNonQuery();
                }
            }
        }


        //Buscamos un personaje por su ID
        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM evangelion_table WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }

        // Método para actualizar un personaje
        public void ActualizarPersonaje(int id, string nombre, string afiliacion,  string estadomental, int edad, int eva, bool check,DateTime fechadecreacion)

        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE evangelion_table SET nombre = @nombre, afiliacion = @afiliacion,   estado_mental = @estado_mental,  edad_del_personaje = @edad_del_personaje, eva_unidad = @eva_unidad, es_angel = @es_angel,  fecha_creacion = @fecha_creacion WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@afiliacion", afiliacion);
                    command.Parameters.AddWithValue("@estado_mental", estadomental);
                    command.Parameters.AddWithValue("@edad_del_personaje", edad);
                    command.Parameters.AddWithValue("@eva_unidad", eva);
                    command.Parameters.AddWithValue("@es_angel", check);
                    command.Parameters.AddWithValue("@fecha_creacion", fechadecreacion);
                    command.ExecuteNonQuery();

                }
            }
        }
        // nuestro metodo para eliminar un personaje por medio del id
        public void EliminarPersonaje(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM evangelion_table WHERE id = @id";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No se encontró ningún personaje con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar eliminar el personaje: " + ex.Message);
            }
        }
        //Este método permite ejecutar cualquier consulta SQL que le proporciones en el parámetro consultaSQL, 
        public DataTable EjecutarConsulta(string consultaSQL)
        {
            DataTable resultado = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(consultaSQL, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(resultado);
                    }
                }
            }

            return resultado;
        }
        
    }
}
