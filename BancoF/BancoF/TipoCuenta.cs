using System;
namespace ProyectoBancoP2
{
    public class TipoCuenta
    {

        private string Nombre;
        private double MontoMinimo;
        private string Descripcion;
        
        public TipoCuenta(string Nombre, double MontoMinimo, string Descripcion)
        {
            this.Nombre = Nombre;
            this.MontoMinimo = MontoMinimo;
            this.Descripcion = Descripcion;
        }

        public string pNombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public double pMontoMinimo
        {
            get
            {
                return MontoMinimo;
            }
            set
            {
                MontoMinimo = value;
            }
        }

        public string pDescripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("\nNOMBRE: {0}\nMONTO MINIMO: {1:c}\nDESCRIPCION: {2}", Nombre, MontoMinimo, Descripcion);
            return str;
        }
    }
}
