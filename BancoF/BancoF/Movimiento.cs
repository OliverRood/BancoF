using System;
namespace BancoF
{
    public class Movimiento
    {

        private string Fecha;
        private string Tipo;
        private double Importe;
        private int ClaveCuenta;
        private string NombreDepositador;

        public Movimiento(string Fecha, string Tipo, int ClaveCuenta, double Importe, string NombreDepositador)
        {
            this.Fecha = Fecha;
            this.Tipo = Tipo;
            this.ClaveCuenta = ClaveCuenta;
            this.Importe = Importe;
            this.NombreDepositador = NombreDepositador;

        }

        public string pFecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }

        public int pClaveCuenta
        {
            get
            {
                return ClaveCuenta;
            }
            set
            {
                ClaveCuenta = value;
            }
        }

        public string pTipo
        {
            get
            {
                return Tipo;
            }
            set
            {
                Tipo = value;
            }
        }

        public double pImporte
        {
            get
            {
                return Importe;
            }
            set
            {
                Importe = value;
            }
        }

        public string pNombreDepositador
        {
            get
            {
                return NombreDepositador;
            }
            set
            {
                NombreDepositador = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("\nCLAVE DE LA CUENTA: {3,-3:D4}\nTIPO: {0}\nIMPORTE: {1}\nREALIZADOR: {2}", Tipo, Importe, NombreDepositador,ClaveCuenta);
            return str;
        }
    }
}
