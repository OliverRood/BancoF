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

        public int NumCuentasCliente(int claveCliente)
        {
            int numCuentas = 0;

            foreach (Cuenta item in cuentas.Values)
                if (item.pClaveCliente == claveCliente)
                    numCuentas++;

            return numCuentas;
        }

        public KeyValuePair<int, Cuenta>[] ObtenerPorCliente(int claveCliente)
        {
            KeyValuePair<int, Cuenta>[] temp = new KeyValuePair<int, Cuenta>[NumCuentasCliente(claveCliente)];
            int count = 0;

            foreach(KeyValuePair<int, Cuenta> item in cuentas)
                if (item.Value.pClaveCliente == claveCliente)
                {
                    temp[count] = item;
                    count++;
                }
            
            return temp;         
        }

        public double obtenerSaldoTotalPorCliente(int claveCliente)
        {
            double saldoTotal = 0;
            foreach (KeyValuePair<int, Cuenta> item in cuentas) {
                if (item.Value.pClaveCliente == claveCliente)
                {
                    saldoTotal += item.Value.pSaldo;
                }
            }
            return saldoTotal;
        }
    }
}