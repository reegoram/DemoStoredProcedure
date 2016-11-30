using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DemoStoredProcedure
{
    class Datos
    {
        private String cadenaConexion = "Server=localhost;Database=biblioteca;Uid=demo;Pwd=P@$$w0rd;";
        private MySqlConnection con;

        public bool ExisteConexion()
        {
            try
            {
                con = new MySqlConnection(cadenaConexion);
                con.Open();
            }
            catch(MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Se ha registrado la siguiente excepción: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return true;
        }

        private DataSet EjecutarSelect(string nombreProcedimiento,string[] nombreParams, object[] param)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new MySqlConnection(cadenaConexion);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(nombreProcedimiento, con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (param != null)
                {
                    for (int i = 0; i < nombreParams.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(nombreParams[i], param[i]);
                    }
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Se ha registrado la siguiente excepción: " + ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return ds;
        }

        public bool RegistrarPrestamo(string usuario, string libro)
        {
            try
            {
                con = new MySqlConnection(cadenaConexion);

                DataTable dt;
                byte id_usuario = 0;
                string codigo_libro = string.Empty;
                
                dt = EjecutarSelect("identificar_usuario", new string[] { "usuario" }, new object[] { usuario }).Tables[0];
                if (dt.Rows.Count > 0)
                    id_usuario = byte.Parse(dt.Rows[0][0].ToString());
                else
                    return false;

                dt = EjecutarSelect("identificar_libro", new string[] { "nombre" }, new object[] { libro }).Tables[0];
                if (dt.Rows.Count > 0)
                    codigo_libro = dt.Rows[0][0].ToString();
                else
                    return false;

                con.Open();

                MySqlCommand cmd = new MySqlCommand("prestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("libro", codigo_libro);
                cmd.Parameters.AddWithValue("cod_usuario", id_usuario);

                return cmd.ExecuteNonQuery() != -1;

                
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Se ha registrado la siguiente excepción: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return true;
        }

        public DataSet TraerRegistros(string tabla)
        {
            if (tabla == "libros")
            {
                return EjecutarSelect("listar_libros", null, null);
            }
            else
            {
                //usuarios
                DataSet ds = new DataSet();
                try
                {
                    con = new MySqlConnection(cadenaConexion);
                    con.Open();

                    string cmd = "SELECT nombre FROM usuarios";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, con);
                    adapter.Fill(ds);
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine("Se ha registrado la siguiente excepción: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
                return ds;
            }
        }
    }
}
