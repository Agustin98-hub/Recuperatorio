using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApellidoNombre
{
    internal class Actividad
    {
        
            public int ID_Actividades { get; set; }
            public string Descripcion { get; set; }
            public DateTime FechaActividad { get; set; }
            public int ID_Usuario { get; set; }

            public Actividad(int idActividades, string descripcion, DateTime fechaActividad, int idUsuario)
            {
                ID_Actividades = idActividades;
                Descripcion = descripcion;
                FechaActividad = fechaActividad;
                ID_Usuario = idUsuario;
            }

        public class ActividadDataAccess
        {
            private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Escritorio\Barria.accdb;";

            // Método para insertar una nueva actividad
            public void InsertarActividad(Actividad actividad)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "INSERT INTO Actividades (ID_Actividades, Descripcion, FechaActividad, ID_Usuario) VALUES (?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("", actividad.ID_Actividades);
                    cmd.Parameters.AddWithValue("", actividad.Descripcion);
                    cmd.Parameters.AddWithValue("", actividad.FechaActividad);
                    cmd.Parameters.AddWithValue("", actividad.ID_Usuario);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Método para actualizar una actividad existente
            public void ActualizarActividad(Actividad actividad)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "UPDATE Actividades SET Descripcion = ?, FechaActividad = ?, ID_Usuario = ? WHERE ID_Actividades = ?";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("", actividad.Descripcion);
                    cmd.Parameters.AddWithValue("", actividad.FechaActividad);
                    cmd.Parameters.AddWithValue("", actividad.ID_Usuario);
                    cmd.Parameters.AddWithValue("", actividad.ID_Actividades);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Método para eliminar una actividad por ID
            public void EliminarActividad(int idActividad)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "DELETE FROM Actividades WHERE ID_Actividades = ?";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("", idActividad);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Método para obtener todas las actividades
            public List<Actividad> ObtenerActividades()
            {
                List<Actividad> actividades = new List<Actividad>();
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT ID_Actividades, Descripcion, FechaActividad, ID_Usuario FROM Actividades";
                    OleDbCommand cmd = new OleDbCommand(query, connection);

                    connection.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int idActividades = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);
                        DateTime fechaActividad = reader.GetDateTime(2);
                        int idUsuario = reader.GetInt32(3);

                        actividades.Add(new Actividad(idActividades, descripcion, fechaActividad, idUsuario));
                    }
                }
                return actividades;
            }
        }
    }

}
