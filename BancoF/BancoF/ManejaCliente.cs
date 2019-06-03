using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using RutinasDLL;
namespace BancoF
{
    public class ManejaCliente
    {
        public ManejaCliente()
        {
           
        }

        public string Agrega(string Nombre, string Domicilio, string Ciudad, string Telefono)
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string insercion = "insert into Cliente(Nombre,Domicilio,Ciudad,Telefono)";
                   insercion += "values(@nom,@dom,@ciudad,@tel)";
            SqlCommand cmd = new SqlCommand(insercion, conexion);

            cmd.Parameters.Add("@nom",Nombre);
            cmd.Parameters.Add("@dom", Domicilio);
            cmd.Parameters.Add("@ciudad", Ciudad);
            cmd.Parameters.Add("@tel", Telefono);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                conexion.Close();
                return ex.Message;
            }

            return "Cliente agregado exitosamente";
        }

        public Cliente[] ObtenerClientes()
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select ID, Nombre, Domicilio, Ciudad, Telefono from Cliente";
            SqlDataReader lector = Rutinas.ObtenerLector(consulta,conexion);

            Cliente[] temp = new Cliente[this.Count()];

            if (lector.HasRows)
            {
                int con = 0;
                while(lector.Read())
                {
                    int ID = lector.GetInt32(0);
                    string nom = lector.GetString(1);
                    string dom = lector.GetString(2);
                    string ciudad = lector.GetString(3);
                    string tel = lector.GetString(4);
                    temp[con] = new Cliente(ID,nom,dom,ciudad,tel);
                    con++;
                }
            }
            conexion.Close();
            return temp;
        }

        public string ActualizaDireccíon(string direccion, int idCliente)
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string actualizacion = "Update Cliente set Domicilio=@newDom where id=@idCliente";
            SqlCommand cmd = new SqlCommand(actualizacion,conexion);

            cmd.Parameters.Add("@newDom",direccion);
            cmd.Parameters.Add("@idCliente",idCliente);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                conexion.Close();
                return ex.Message;
            }
            conexion.Close();
            return "Dirección del cliente actualizada exitosamente";
        }

        public string ActualizaTelefono(string tel, int idCliente)
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string actualizacion = "Update Cliente set telefono=@newTel where id=@idCliente";
            SqlCommand cmd = new SqlCommand(actualizacion, conexion);

            cmd.Parameters.Add("@newTel", tel);
            cmd.Parameters.Add("@idCliente", idCliente);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                conexion.Close();
                return ex.Message;
            }
            conexion.Close();
            return "Teléfono del cliente actualizada exitosamente";
        }

        public int Count()
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select count(ID) from Cliente";
            SqlDataReader lector = Rutinas.ObtenerLector(consulta, conexion);

            int count = 0;

            if (lector.HasRows)
            {
                while (lector.Read())
                    count = lector.GetInt32(0);
            }
            conexion.Close();
            return count;
        }

        public bool Existe(int key)
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select ID from Cliente where @ID=ID";
            SqlCommand cmd = new SqlCommand(consulta,conexion);
            cmd.Parameters.Add("@ID",key);

            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                conexion.Close();
                return true;
            }
            conexion.Close();

            return false;
        }

        public int KeyCliente(string Nombre)
        {
            int keyC = -1;
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select ID from Cliente where @nombre=Nombre";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.Add("@nombre", Nombre);
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.HasRows)
                while (lector.Read())
                    keyC = lector.GetInt32(0);

            conexion.Close();
            return keyC;
        }

        public Cliente ObtenerCliente(int key)
        {
            Cliente temp = null;
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select Nombre, Domicilio, Ciudad, Telefono from Cliente where @ID=ID";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.Add("@ID", key);

            try
            {
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        string nom = lector.GetString(0);
                        string dom = lector.GetString(1);
                        string ciudad = lector.GetString(2);
                        string tel = lector.GetString(3);
                        temp = new Cliente(key, nom, dom, ciudad, tel);
                    }
                }
                conexion.Close();
            }
            catch (SqlException)
            {
                conexion.Close();
                return null;
            }

            return temp;
        }

    }
}
