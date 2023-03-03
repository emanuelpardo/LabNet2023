using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Omnibus : TransportePublico
    {
        public Omnibus() : base()
        {
        }

        public Omnibus(string Tipo, int Numero, int Pasajero) : base(Tipo, Numero,Pasajero)
        { 
        }

        public override string Avanzar()
        {
            return "el Omnibus está avanzando";
        }

        public override string Detenerse()
        {
            return "el Omnibus está detenido";
        }
    }
}
