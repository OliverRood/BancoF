using System;
using System.Collections.Generic;
using System.Text;

namespace BancoF
{
    public class Cliente
    {

        private string nombre;
        private string domicilio;
        private string ciudad;
        private string telefono;
        private int id;

        public Cliente(int ID, string nom, string dom, string ci, string tel)
        {
            this.id = ID;
            this.nombre = nom;
            this.domicilio = dom;
            this.ciudad = ci;
            this.telefono = tel;
        }

        public int ID {
            get => ID;
            }

        public string pNombre {
            get => nombre;
            set => nombre = value;
        }
        public string pDomicilio {
            get => domicilio;
            set => domicilio = value;
        }
        public string pCiudad {
            get => ciudad;
            set => ciudad = value;
        }
        public string pTelefono {
            get => telefono;
            set => telefono = value;
        }
        

        public override string ToString()
        {
            string res = String.Format(" NOMBRE: {0,-5}\n CIUDAD DE RESIDENCIA: {1,-3}\n DOMICILIO: {2,-5}\n " +
                "TELEFONO: {3,-5}",pNombre,pCiudad,pDomicilio,pTelefono);
            return res;
        }
    }
}
