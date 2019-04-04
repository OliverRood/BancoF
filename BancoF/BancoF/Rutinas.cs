using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BancoF
{
    public class Rutinas
    {
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


    }
}
