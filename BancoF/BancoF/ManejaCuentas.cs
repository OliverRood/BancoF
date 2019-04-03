using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoF
{
    public class ManejaCuentas
    {

        private Dictionary<int, Cuenta> cuentas;

        public ManejaCuentas()
        {
            this.cuentas = new Dictionary<int, Cuenta>();
        }

        public bool Agrega(int claveCuenta, int claveCliente,double saldoInicial,string tipoCuenta)
        {
            bool flag = false;
            cuentas.Add(claveCuenta, new Cuenta(saldoInicial, tipoCuenta, claveCliente));
            flag=true;
            return flag;
        }
       
        public Cuenta BuscarCuenta(int claveC)
        {
            Cuenta temp = null;

                if(cuentas.ContainsKey(claveC)) 
                {
                
                    temp = cuentas[claveC];
                }

            return temp;
        }

        public bool EliminarCuenta(int claveC)
        {
            bool flag = false;

            if(cuentas.ContainsKey(claveC))
            cuentas.Remove(claveC);

            flag = true;

            return flag;
        }

        public int Size()
        {
            return cuentas.Count;
        }

        public String ImprimirPorCliente(int claveCliente)
        {
            string res = "";
            foreach (KeyValuePair<int, Cuenta> data in cuentas)
            {
                if (claveCliente == data.Value.pClaveCliente)
                {
                    res += String.Format(" CLAVE DE LA CUENTA: {0,-3:D4}\n{1}",data.Key,data.Value.ToString());
                }
            }
            return res;         
        }
    }
}