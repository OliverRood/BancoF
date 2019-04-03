using System;
using System.Collections.Generic;

namespace BancoF
{
    public class ManejaMovimiento
    {

       private List<Movimiento> movimientos;
       private ManejaCuentas manejaC;

        public ManejaMovimiento(ManejaCuentas manejadora)
        {
            this.movimientos = new List<Movimiento>();
            this.manejaC = manejadora;
        }

        private bool Agrega(string Tipo, int ClaveCuenta, double Importe, string NombreDepositador)
        {
            bool flag = false;
            movimientos.Add(new Movimiento(Tipo, ClaveCuenta, Importe, NombreDepositador));
            flag = true;

            return flag;
        }

        public bool Deposito(double cant, int claveC,string nombreDepositante)
        {
            bool flag = false;
            Cuenta temp = manejaC.BuscarCuenta(claveC);

            if (temp!=null && cant>0)
            {
                temp.pSaldo += cant;
                Agrega("DEPOSITO",claveC,cant,nombreDepositante);
                flag = true;
            }

            return flag;
        }

        public bool Retiro(double cant, int claveC, string nombreDepositante)
        {
            bool flag = false;
            Cuenta temp = manejaC.BuscarCuenta(claveC);

            if (temp!=null && temp.pSaldo-cant>=0)
            {
                temp.pSaldo -= cant;
                Agrega("RETIRO", claveC, cant, nombreDepositante);
                flag = true;
            }

            return flag;
        }

        public String ImprimirPorCuenta(int claveC)
        {
            string res = "";

            foreach (Movimiento data in movimientos)
            {
                if (data.pClaveCuenta == claveC)
                    res += data.ToString()+"\n";
            }

            return res;
        }

    }
}
