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
                   insercion += "values(@nom,@dom,@ciudad@tel)";
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
           return clientes.ContainsKey(key);
        }

        public int KeyCliente(string Nombre)
        {
            int keyC = -1;
            for (int i = 0; i < clientes.Count; i++)
            {
                var dato = clientes.ElementAt(i);
                Cliente c = dato.Value;
                int keyA = dato.Key;
                if (c.pNombre.Equals(Nombre))
                {
                    keyC = keyA;
                }
            }
            return keyC;
        }

        public Cliente ObtenerCliente(int key)
        {
            Cliente temp = null;

            foreach (KeyValuePair<int, Cliente> item in clientes)
                if (item.Key == key)
                    temp = item.Value;

            return temp;
        }

        public override string ToString()
        {
            string str;
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < clientes.Count; i++)
            {
                var dato = clientes.ElementAt(i);
                Cliente c = dato.Value;
                int keyA = dato.Key;
                sb.AppendLine("\nCLAVE: " + keyA + "\n" + c);
            }
            str = sb.ToString();
            return str;
        }
    }
}
