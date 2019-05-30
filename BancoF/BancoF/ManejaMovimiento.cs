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

        public string Agrega(double Monto, char Tipo, string Fecha, string Hora, int Folio_Movimiento, int Clave_Cuenta)
        {

            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string insertA = "insert into Movimiento (Monto, Tipo, Fecha, Hora) " +
                "values (@Monto, @Tipo, @Fecha, @Hora)";
            string insertB = "insert into Movimiento_Cuenta (Folio_Movimiento, Clave_Cuenta) " +
                "values (@Folio_Movimiento, @Clave_Cuenta)";

            SqlCommand cmdA = new SqlCommand(insertA, conexion);
            SqlCommand cmdB = new SqlCommand(insertB, conexion);

            cmdA.Parameters.Add("@Monto", Monto);
            cmdA.Parameters.Add("@Tipo", Tipo);
            cmdA.Parameters.Add("@Fecha", Fecha);
            cmdA.Parameters.Add("@Hora", Hora);

            cmdB.Parameters.Add("@Folio_Movimiento", Folio_Movimiento);
            cmdB.Parameters.Add("@Clave_Cuenta", Clave_Cuenta);

            try
            {
                cmdA.ExecuteNonQuery();
                cmdB.ExecuteNonQuery();
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
            string consulta = "select m.Monto, m.Tipo, m.Fecha, mc.Clave_Cuenta from Movimiento m " +
                "inner join Movimiento_Cuenta mc on mc.Folio_Movimiento = m.Folio where m.Folio = @Folio";
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
                    int ClaveCuenta = lector.GetInt32(3);
                    temp = new Movimiento(Monto, Tipo, Fecha, ClaveCuenta);
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
            string consulta = "select m.Monto, m.Tipo, m.Fecha, mc.Clave_Cuenta from Movimiento m " +
                "inner join Movimiento_Cuenta mc on mc.Folio_Movimiento = m.Folio";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader lector = Rutinas.ObtenerLector(consulta, conexion);
            int cont = 0; 
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    double Monto = lector.GetDouble(0);
                    char Tipo = Convert.ToChar(lector.GetValue(1));
                    string Fecha = lector.GetString(2);
                    int ClaveCuenta = lector.GetInt32(3);
                    movimientos[cont] = new Movimiento(Monto, Tipo, Fecha, ClaveCuenta);
                    cont++;
                }
            }
            conexion.Close();

            return movimientos;
        }

    }
}
