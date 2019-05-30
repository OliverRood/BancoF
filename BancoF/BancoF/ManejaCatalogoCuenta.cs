using System;
using System.Collections.Generic;
using RutinasDLL;
using System.Data.SqlClient;

namespace BancoF
{
    public class ManejaCatalogoCuenta
    {

        private TipoCuenta[] catalogo;
        private static int pos=0;

        public ManejaCatalogoCuenta()
        {
            catalogo = new TipoCuenta[10];
            agregaBase();
        }

        private void agregaBase()
        {
            agrega("PREMIUM",20000,"PRIVILEGIOS BASICOS. NO INCLUYE TARJETA FISICA");
            agrega("BASICA",4000,"REQUIERE SALDO MINIMO");
            agrega("NOMINA",0,"DEPOSITOS DE NOMINA");
        }

        public void agrega(string Nombre, double MontoMinimo, string Descripcion)
        {
            catalogo[pos] = new TipoCuenta(Nombre, MontoMinimo, Descripcion);
            pos++;
        }

        public int Count()
        {
            return pos;
        }

        public TipoCuenta consulta(string Nombre)
        {
            TipoCuenta cuenta = null;
            for (int i = 0; i < pos; i++)
            {
                if (catalogo[i]!=null)
                {
                    if (catalogo[i].pNombre.Equals(Nombre))
                    {
                        cuenta = catalogo[i];
                    }
                }
            }
            return cuenta;
        }

        public String[] obtieneNombres()
        {
            String[] nombres = new String[catalogo.Length];
            for (int i = 0; i < catalogo.Length; i++)
            {
                if (catalogo[i] != null)
                {
                    nombres[i] = catalogo[i].pNombre;
                }
            }
            return nombres;
        }

        public override string ToString()
        {
            string str;
            var sb = new System.Text.StringBuilder();
            foreach (TipoCuenta item in catalogo)
            {
                if (item!=null)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            str = sb.ToString();
            return str;
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
