using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Threading.Tasks;

namespace RutinasDLL
{
    public class Rutinas
    {
        public static SqlException ESalida;
        public static SqlConnection ConectaBD(String strConec)
        {

            SqlConnection conn = new SqlConnection(strConec);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {

                ESalida = ex;
                return null;
            }

            return conn;
        }

        public static SqlDataReader ObtenerLector(String instrSelect, SqlConnection conn)
        {
            SqlDataReader lector = null;

            SqlCommand cmd = new SqlCommand(instrSelect, conn);
            try
            {
                lector = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {

                ESalida = ex;
                conn.Close();
                return null;
            }
            return lector;
        }

        public static string ObtenerStringConexion()
        {
            string strCadena = "";
            int nItems = ConfigurationManager.ConnectionStrings.Count;
            if (nItems > 0)
            { 
                strCadena = ConfigurationManager.ConnectionStrings[nItems - 1].ConnectionString;
            }
            return strCadena;
        }

        public static bool ValidaCaracteres(string st)
        {
            bool flag = false;
            Regex rgx = new Regex(@"^(([A-Za-z])+\s?)+$");

            if (rgx.IsMatch(st))
                flag = true;

            return flag;
        }

        public static bool ValidaBlancos(string data)
        {
            return (string.IsNullOrEmpty(data));
        }

        public static bool ValidaTelefono(string value)
        {
            Regex regex = new Regex(@"^((\+[52]{2}(\s|\-)?)?(((\(\d{3}\))|(\d{3}))((\s|\-)?(\d{3}))((\s|\-)?(\d{2})){2}))$");
            Match match = regex.Match(value);
            if (match.Success)
                return true;

            return false;
        }

        public static bool ValidaDomicilio(string value)
        {
            Regex regex = new Regex(@"^[a-zA-ZñÑ]*(?=.*[0-9]).*$");
            Match match = regex.Match(value);
            if (match.Success)
                return true;

            return false;
        }

        public static bool ValidaNumCuenta(string value)
        {
            Regex regex = new Regex(@"^(\d{7})$");
            Match match = regex.Match(value);
            if (match.Success)
                return true;

            return false;
        }

        public static bool ValidaDecimal(string value)
        {
            Regex regex = new Regex(@"^\d+([.]\d{1,2})?$");
            Match match = regex.Match(value);
            if (match.Success)
                return true;

            return false;
        }
    }
}
