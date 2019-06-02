using System;
using System.Collections.Generic;
using System.Linq;
using RutinasDLL;
using System.Data.SqlClient;
using System.Data;

namespace BancoF
{
    public class ManejaCuentas
    {
        private ManejaCatalogoCuenta manejaCatalogo;
        public ManejaCuentas(ManejaCatalogoCuenta manejaTipo)
        {
            this.manejaCatalogo = manejaTipo;
        }

        public string Agrega(int claveCuenta, int claveCliente, double saldoInicial, string tipoCuenta)
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexionA = Rutinas.ConectaBD(cadenaConexion);
            SqlConnection conexionB = Rutinas.ConectaBD(cadenaConexion);
            string insercionA = "insert into Cuenta(Clave,Saldo,ID_TipoCuenta)";
            insercionA += "values(@claveCu,@saldo,@idTipo)";

            SqlCommand cmdA = new SqlCommand(insercionA, conexionA);
            SqlCommand cmdB = new SqlCommand("SP_AñadirCuentaCliente", conexionB);

            int idTipo = manejaCatalogo.BuscarIDTipo(tipoCuenta);

            //Inserción en Cuentas:
            cmdA.Parameters.Add("@claveCu",claveCuenta);
            cmdA.Parameters.Add("@saldo", saldoInicial);
            cmdA.Parameters.Add("@idTipo",idTipo);

            //Inserción en Cuentas-Clientes:
            cmdB.CommandType = CommandType.StoredProcedure;
            cmdB.Parameters.Add("@idCliente",claveCliente);
            cmdB.Parameters.Add("@claveCuenta",claveCuenta);

            try
            {
                cmdA.ExecuteNonQuery();
                cmdB.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                conexionA.Close();
                conexionB.Close();
                return ex.Message;
            }

            return "Cuenta agregada exitosamente.";
        }
       
        public Cuenta BuscarCuenta(int claveC)
        {
            Cuenta temp = null;

            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select c.Saldo, t.Nombre, cl.ID_Cliente from Cuenta c inner join Tipo_Cuenta t on t.ID = c.ID_TipoCuenta  ";
            consulta += "inner join Cuenta_Cliente cl on cl.Clave_Cuenta = c.Clave where c.Clave =@clave";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.Add("@clave", claveC);

            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    double saldo = Convert.ToDouble(lector.GetValue(0));
                    string tipo = lector.GetString(1);
                    int idCli = lector.GetInt32(2);
                    temp = new Cuenta(claveC,saldo,tipo,idCli);
                }
            }
            conexion.Close();

            return temp;
        }

        //Not yet :D
        /*public bool EliminarCuenta(int claveC)
        {
          
        }*/

        public int Size()
        {

            int count = 0;
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select count(Clave) from Cuenta";
            SqlDataReader lector = Rutinas.ObtenerLector(consulta, conexion);

            if (lector.HasRows)
            {
                while (lector.Read())
                    count = lector.GetInt32(0);
            }
            conexion.Close();
            return count;
        }

        public int NumCuentasCliente(int claveCliente)
        {
            int count = 0;
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select count(Clave) from Cuenta c ";
            consulta += "inner join Cuenta_Cliente cl on cl.Clave_Cuenta = c.Clave where cl.ID_Cliente = @idCliente";
            SqlCommand cmd = new SqlCommand(consulta,conexion);
            cmd.Parameters.Add("@idCliente",claveCliente);
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                    count = lector.GetInt32(0);
            }
            conexion.Close();

            return count;
        }

        public List<Cuenta> ObtenerPorCliente(int claveCliente)
        {
            List<Cuenta> temp = new List<Cuenta>();

            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select c.Clave from Cuenta c ";
            consulta += "inner join Cuenta_Cliente cl on cl.Clave_Cuenta = c.Clave where cl.ID_Cliente = @idCliente";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.Add("@idCliente", claveCliente);
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int claveCuenta = lector.GetInt32(0);
                    temp.Add(BuscarCuenta(claveCuenta));
                }
            }
            conexion.Close();


            return temp;         
        }

        public double obtenerSaldoTotalPorCliente(int claveCliente)
        {
            double saldoTotal = 0;

            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select  case when sum(c.Saldo) is null then 0 else sum(c.Saldo) end as [Saldo Actual] from Cuenta c ";
            consulta += "inner join Cuenta_Cliente cl on cl.Clave_Cuenta = c.Clave where cl.ID_Cliente = @idCliente";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.Add("@idCliente", claveCliente);
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    saldoTotal = Convert.ToDouble(lector.GetValue(0));
                }
            }

            return saldoTotal;
        }

        public bool ValidaMovimientos(int claveCuenta)
        {
            bool flag = true;
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SP_ValidaCuentaMovimientos",conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@claveCuenta",claveCuenta);
            cmd.Parameters.Add("@result",SqlDbType.Bit).Direction=ParameterDirection.ReturnValue;

            try
            {
                cmd.ExecuteNonQuery();
                int resultTemp = Convert.ToInt32(cmd.Parameters["@result"].Value);
                flag = resultTemp == 0 ? false : true;
            }
            catch (SqlException ex)
            {
                conexion.Close();
                return false;
            }
            conexion.Close();
            return flag;
        }
    }
}