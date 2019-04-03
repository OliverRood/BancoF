using System;
using System.Collections.Generic;

namespace BancoF
{
    public class ManejaCatalogoCuenta
    {

        private List <TipoCuenta> catalogo;
        private static int pos=0;

        public ManejaCatalogoCuenta()
        {
            catalogo = new List<TipoCuenta>();
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
            catalogo.Add(new TipoCuenta(Nombre, MontoMinimo, Descripcion));
        }

        public int Count()
        {
            return catalogo.Count;
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

        /*

            CONSULTAR SI ES NECESARIO

        public void elimina(string Nombre)
        {
            for (int i = 0; i < pos; i++)
            {
                if (catalogo[i] != null)
                {
                    if (catalogo[i].pNombre.Equals(Nombre.ToUpper()))
                    {
                        catalogo[i] = null;
                    }
                }
            }
        }
        */

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
    }
}
