using System;
using System.Collections.Generic;
using System.Text;

namespace BancoF
{
   public class Cuenta
    {
        private double saldo;
        private string nombreCuenta;
        private int claveCliente;
        private int clave;

        public Cuenta(int claveCuenta,double saldoInicial,string tipoCuenta,int claveCliente)
        {
            this.clave = claveCuenta;
            this.claveCliente = claveCliente;
            this.nombreCuenta = tipoCuenta;
            this.saldo = saldoInicial;
        }

        public int Clave
        {
            get => clave;
        }

        public double pSaldo
        {
            get => saldo;
            set => saldo = value;
        }
        public string pNombre
        {
            get => nombreCuenta;
            set => nombreCuenta = value;
        }
        public int pClaveCliente
        {
            get => claveCliente;
            set => claveCliente = value;//?
        }


        public override string ToString()
        {
            string res = String.Format(" TIPO DE CUENTA: {0,-5}\n CLAVE DEL CLIENTE ASOCIADO: {1,-3}\n " +
                "\n SALDO ACTUAL: {2,-3:c}",pNombre,pClaveCliente,pSaldo);
            return res;
        }
    }
}
