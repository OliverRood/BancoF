﻿using RutinasDLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BancoF
{
    public class ManejaCatalogoCuenta
    {

        public ManejaCatalogoCuenta()
        {
            agregaBase();
        }

        private void agregaBase()
        {
           /* agrega("PREMIUM",20000,"PRIVILEGIOS BASICOS. NO INCLUYE TARJETA FISICA");
            agrega("BASICA",4000,"REQUIERE SALDO MINIMO");
            agrega("NOMINA",0,"DEPOSITOS DE NOMINA");*/ 
            //Nop
        }

        public string agrega(string Nombre, double MontoMinimo, string Descripcion)
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string insert = "insert into Tipo_Cuenta (Nombre, MontoMinimo, Descripcion) " +
                "values (@Nombre, @MontoMinimo, @Descripcion)";

            SqlCommand cmd = new SqlCommand(insert, conexion);

            cmd.Parameters.Add("@Nombre", Nombre);
            cmd.Parameters.Add("@MontoMinimo", MontoMinimo);
            cmd.Parameters.Add("@Descripcion", Descripcion);

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

            return "Tipo de cuenta agregada exitosamente";
        }

        public int Count()
        {
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select count(ID) from Tipo_Cuenta";
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


        public TipoCuenta consulta(string Nombre)
        {

            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select * from Tipo_Cuenta where Nombre = '" + Nombre + "'";
            SqlDataReader lector = Rutinas.ObtenerLector(consulta, conexion);

            TipoCuenta cuenta = null;

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int ID = lector.GetInt32(0);
                    string NombreTC = lector.GetString(1);
                    double MontoMinimo =Convert.ToDouble(lector.GetValue(2));
                    string Descripcion = lector.GetString(3);
                    cuenta = new TipoCuenta(NombreTC, MontoMinimo, Descripcion);
                }
            }
            conexion.Close();

            return cuenta;
        }

        /*

            CONSULTAR SI ES NECESARIO

        public void elimina(string Nombre)
        {
            for (int i = 0; i < pos; i++)
            {
                if (catalogo[i] != null)
                {
                    if (catalogo[i].pNombre.Equals(Nombre.ToUpper()))
                    {
                        catalogo[i] = null;
                    }
                }
            }
        }
        */

        public string[] obtieneNombres()
        {
            String[] nombres = new String[this.Count()];
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select Nombre from Tipo_Cuenta";
            SqlDataReader lector = Rutinas.ObtenerLector(consulta, conexion);

            if (lector.HasRows)
            {
                int cont = 0;
                while (lector.Read())
                {
                    nombres[cont] = lector.GetString(0);
                    cont++;
                }
            }
            conexion.Close();
            return nombres;
        }

        public int BuscarIDTipo(string nombre)
        {
            int keyC = -1;
            string cadenaConexion = Rutinas.ObtenerStringConexion();
            SqlConnection conexion = Rutinas.ConectaBD(cadenaConexion);
            string consulta = "select ID from Tipo_Cuenta where @nombre=Nombre";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.Add("@nombre", nombre);
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.HasRows)
                while (lector.Read())
                    keyC = lector.GetInt32(0);

            conexion.Close();
            return keyC;
        }
    }
}
