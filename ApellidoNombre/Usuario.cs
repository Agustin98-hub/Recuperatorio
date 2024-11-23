using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApellidoNombre
{
    internal class Usuario
    {

        
            public int IdUsuario { get; set; }
            public string Nombre { get; set; }
            public string Email { get; set; }
            public int IdCategoria { get; set; }

            public Usuario(int idUsuario, string nombre, string email, int idCategoria)
            {
                IdUsuario = idUsuario;
                Nombre = nombre;
                Email = email;
                IdCategoria = idCategoria;
            }

        public class UsuarioDataAccess
        {
            private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Escritorio\Barria.accdb;";

            // Método para insertar un nuevo usuario
            public void InsertarUsuario(Usuario usuario)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "INSERT INTO Usuarios (idusuario, nombre, email, idcategoria) VALUES (?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("", usuario.Nombre);
                    cmd.Parameters.AddWithValue("", usuario.Email);
                    cmd.Parameters.AddWithValue("", usuario.IdCategoria);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Método para actualizar un usuario existente
            public void ActualizarUsuario(Usuario usuario)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "UPDATE Usuarios SET nombre = ?, email = ?, idcategoria = ? WHERE idusuario = ?";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("", usuario.Nombre);
                    cmd.Parameters.AddWithValue("", usuario.Email);
                    cmd.Parameters.AddWithValue("", usuario.IdCategoria);
                    cmd.Parameters.AddWithValue("", usuario.IdUsuario);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Método para eliminar un usuario por id
            public void EliminarUsuario(int idUsuario)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "DELETE FROM Usuarios WHERE idusuario = ?";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("", idUsuario);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Método para obtener todos los usuarios
            public List<Usuario> ObtenerUsuarios()
            {
                List<Usuario> usuarios = new List<Usuario>();
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT idusuario, nombre, email, idcategoria FROM Usuarios";
                    OleDbCommand cmd = new OleDbCommand(query, connection);

                    connection.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int idUsuario = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string email = reader.GetString(2);
                        int idCategoria = reader.GetInt32(3);

                        usuarios.Add(new Usuario(idUsuario, nombre, email, idCategoria));
                    }
                }
                return usuarios;
            }
        }

    }



}
