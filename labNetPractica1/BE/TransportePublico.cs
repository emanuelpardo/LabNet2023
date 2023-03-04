using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class TransportePublico 
    {
        public const string TipoOmnibus = "Omnibus";
        public const string TipoTaxi = "Taxi";

        private int numero;
        private int pasajeros;
        private string tipo;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Pasajeros
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }



        public TransportePublico()
        {

        }

        public TransportePublico(string Tipo, int Numero, int Pasajeros)
        {
            this.Tipo = Tipo;
            this.Numero = Numero;
            this.Pasajeros = Pasajeros;

        }

        public abstract string Avanzar();
        public abstract string Detenerse();

        
    }
}
