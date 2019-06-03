using RutinasDLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BancoF
{
    public class ManejaMovimiento
    {
        ManejaCuentas manejaCuentas;

        public ManejaMovimiento(ManejaCuentas manejaCuentas)
        {
            this.manejaCuentas = manejaCuentas;
        }

        public string Agrega(double Monto, char Tipo, DateTime Fecha, DateTime Hora, int Clave_Cuenta, string NombreDepositante)
        {

            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string insertA = "insert into Movimiento (Monto, Tipo, Fecha, Hora, Clave_Cuenta, NombreDepositante) " +
                "values (@Monto, @Tipo, @Fecha, @Hora, @Clave_Cuenta, @NombreDepositante)";

            SqlCommand cmd = new SqlCommand(insertA, conexion);

            cmd.Parameters.Add("@Monto", Monto);
            cmd.Parameters.Add("@Tipo", Tipo);
            cmd.Parameters.Add("@Fecha", Fecha);
            cmd.Parameters.Add("@Hora", Hora);
            cmd.Parameters.Add("@Clave_Cuenta", Clave_Cuenta);
            cmd.Parameters.Add("@NombreDepositante", NombreDepositante);

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

            return "Movimiento realizado exitosamente";
        }

        public Movimiento ObtenerMovimiento(int Folio)
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select Monto, Tipo, convert(varchar, Fecha, 1), convert(varchar, Hora, 8), Clave_Cuenta, NombreDepositante from Movimiento Where Folio = @Folio";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.Add("@Folio", Folio);
            SqlDataReader lector = Rutinas.ObtenerLector(consulta, conexion);
            Movimiento temp = null;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    double Monto = lector.GetDouble(0);
                    char Tipo = Convert.ToChar(lector.GetValue(1));
                    string Fecha = lector.GetString(2);
                    string Hora = lector.GetString(3);
                    int ClaveCuenta = lector.GetInt32(4);
                    string Nombre = lector.GetString(5);
                    temp = new Movimiento(Monto, Tipo, Fecha, Hora, ClaveCuenta, Nombre);
                }
            }
            conexion.Close();

            return temp;
        }

        public int Count()
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select count(Folio) from Movimiento";
            SqlDataReader lector = Rutinas.ObtenerLector(consulta, conexion);

            int cont = 0;
            if (lector.HasRows)
            {
                while (lector.Read())
                    cont = lector.GetInt32(0);
            }
            conexion.Close();
            return cont;
        }

        public Movimiento[] obtieneMovimientos()
        {
            Movimiento[] movimientos = new Movimiento[this.Count()];
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select Monto, Tipo, convert(varchar, Fecha, 1), convert(varchar, Hora, 8), Clave_Cuenta, NombreDepositante from Movimiento";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader lector = Rutinas.ObtenerLector(consulta, conexion);
            int cont = 0; 
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    double Monto = Convert.ToDouble(lector.GetValue(0));
                    char Tipo = Convert.ToChar(lector.GetValue(1));
                    string Fecha = lector.GetString(2);
                    string Hora = lector.GetString(3);
                    int ClaveCuenta = lector.GetInt32(4);
                    string Nombre = lector.GetString(5);
                    movimientos[cont] = new Movimiento(Monto, Tipo, Fecha, Hora, ClaveCuenta, Nombre);
                    cont++;
                }
            }
            conexion.Close();

            return movimientos;
        }

    }
}
