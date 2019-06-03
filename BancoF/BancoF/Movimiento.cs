using System;
namespace BancoF
{
    public class Movimiento
    {

        private string Fecha;
        private string Hora;
        private char Tipo;
        private double Importe;
        private int ClaveCuenta;
        private string NombreRealizo;

        public Movimiento(double Importe, char Tipo, string Fecha, string Hora, int ClaveCuenta, string NombreRealizo)
        {
            this.Fecha = Fecha;
            this.Hora = Hora;
            this.Tipo = Tipo;
            this.ClaveCuenta = ClaveCuenta;
            this.Importe = Importe;
            this.NombreRealizo = NombreRealizo;
        }

        public string pFecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        public string pHora
        {
            get { return Hora; }
            set { Hora = value; }
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

        public char pTipo
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
        
        public string pNombreRealizo
        {
            get
            {
                return NombreRealizo;
            }
            set
            {
                NombreRealizo = value;
            }
        }
        
        /*
        public override string ToString()
        {
            string str = string.Format("\nCLAVE DE LA CUENTA: {3,-3:D4}\nTIPO: {0}\nIMPORTE: {1}\nREALIZADOR: {2}", Tipo, Importe, NombreDepositador,ClaveCuenta);
            return str;
        }
        */
    }
}
