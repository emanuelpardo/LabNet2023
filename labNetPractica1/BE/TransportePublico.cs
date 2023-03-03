using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class TransportePublico 
    {
        private int numero;
        private int pasajeros;

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


        public TransportePublico()
        {

        }

        public TransportePublico(int Numero, int Pasajeros)
        {
            this.Numero = Numero;
            this.Pasajeros = Pasajeros;

        }

        public abstract string Avanzar();
        public abstract string Detenerse();

        
    }
}
