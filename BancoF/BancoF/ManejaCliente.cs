using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoF
{
    public class ManejaCliente
    {

        Dictionary<int, Cliente> clientes;
        int countClave = 1;

        public ManejaCliente()
        {
            clientes = new Dictionary<int, Cliente>();
        }

        public void Agrega(string Nombre, string Domicilio, string Ciudad, string Telefono)
        {
            clientes.Add(countClave, new Cliente(Nombre, Domicilio, Ciudad, Telefono));
            countClave++;
        }

        public Cliente[] ObtenerClientes()
        {
            Cliente[] temp = new Cliente[clientes.Count()];

            for(int i = 0; i < clientes.Count(); i++)
            {
                temp[i] = clientes.ElementAt(i).Value;
            }

            return temp;
        }



        public int Count()
        {
            return clientes.Count;
        }

        public bool Existe(int key)
        {
           return clientes.ContainsKey(key);
        }

        public int KeyCliente(string Nombre)
        {
            int keyC = -1;
            for (int i = 0; i < clientes.Count; i++)
            {
                var dato = clientes.ElementAt(i);
                Cliente c = dato.Value;
                int keyA = dato.Key;
                if (c.pNombre.Equals(Nombre))
                {
                    keyC = keyA;
                }
            }
            return keyC;
        }

        public Cliente ObtenerCliente(int key)
        {
            Cliente temp = null;

            foreach (KeyValuePair<int, Cliente> item in clientes)
                if (item.Key == key)
                    temp = item.Value;

            return temp;
        }

        public override string ToString()
        {
            string str;
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < clientes.Count; i++)
            {
                var dato = clientes.ElementAt(i);
                Cliente c = dato.Value;
                int keyA = dato.Key;
                sb.AppendLine("\nCLAVE: " + keyA + "\n" + c);
            }
            str = sb.ToString();
            return str;
        }
    }
}
