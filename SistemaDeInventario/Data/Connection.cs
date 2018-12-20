using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaDeInventario.Structures;
using System.Windows.Forms;

namespace SistemaDeInventario.Data
{
    class Connection
    {

        public void CambiarUsuario(string user)
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                SqlCommand cmd = new SqlCommand(String.Format("Update Sistema set Usuario='{0}'", user));
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EjecutarQuery(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sintaxis " + ex, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string TraerElemento(string query)
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                string data = "";
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data = reader.GetString(0);
                }
                return data;
            }
        }

        public int TraerNumero(string query)
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                int data = 0;
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data = reader.GetInt32(0);
                }
                return data;
            }
        }

        public DataTable LlenarTabla(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    return dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sintaxis " + ex, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Departamento> LlenarListaDeparta(int exclu)
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                int i = 1;
                List<Departamento> lsDepa = new List<Departamento>();
                SqlCommand cmd = new SqlCommand("Select * from dbo.Departamento");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (i != exclu)
                    {
                        lsDepa.Add(new Departamento(reader["Nombre"].ToString(), reader["Encargado"].ToString(), reader["Subencargado"].ToString()));
                    }
                    i++;
                }
                return lsDepa;
            }
        }

        public List<string> LlenarListaUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                List<string> ls = new List<string>();
                ls.Add("Seleccione un encargado");
                SqlCommand cmd = new SqlCommand("Select nombre from dbo.Usuario");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ls.Add(reader["Nombre"].ToString());
                }
                return ls;
            }
        }

        public Usuario ObtenerDatosUsuario(int id)
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                int i = 0;
                string temp = "";
                Usuario user = new Usuario();
                Object[] datos = { id, user.User, temp, user.Mail, user.Name, user.Age, user.Rol };
                SqlCommand cmd = new SqlCommand(String.Format("Select * from dbo.Usuario where id = {0}", id));
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    while (i < 7)
                    {
                        if (reader.IsDBNull(i))
                        {
                            if (i == 5 || i == 6)
                            {
                                datos[i] = 0;
                            }
                            else
                            {
                                datos[i] = "";
                            }
                        }
                        else
                        {
                            if (i == 5 || i == 6 || i == 0)
                            {
                                datos[i] = reader.GetInt32(i);
                            }
                            else
                            {
                                datos[i] = reader.GetString(i);
                            }
                        }
                        i++;
                    }
                    user.id = int.Parse(datos[0].ToString());
                    user.User = datos[1].ToString();
                    user.Mail = datos[3].ToString();
                    user.Name = datos[4].ToString();
                    user.Age = int.Parse(datos[5].ToString());
                    user.Rol = int.Parse(datos[6].ToString());
                }
                return user;
            }
        }

        public string EliminarElemento(int id, string tabla)
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                string query = String.Format("delete {0} where id = {1}", tabla, id);
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                return "El elemento se ha \n eliminado correctamente";
            }
        }

        public int LogIn(string user, string pass)
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                string query = String.Format("Select count(*) from Usuario where Usuario = '{0}' and Contrasena = '{1}'", user, pass);
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                return (int)(cmd.ExecuteScalar());
            }
        }

        public int ObtenerRol()
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                int data = 0;
                string query = String.Format("Select Rol from Usuario where Usuario = '{0}';", Global.Usuario);
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data = reader.GetInt32(0);
                }
                return data;
            }
        }

        public int ObtenerID()
        {
            using (SqlConnection conn = new SqlConnection(SistemaDeInventario.Properties.Settings.Default.InventarioConnectionString))
            {
                int data = 0;
                string query = String.Format("Select Id from Usuario where Usuario = '{0}';", Global.Usuario);
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data = reader.GetInt32(0);
                }
                return data;
            }
        }

    }
}
