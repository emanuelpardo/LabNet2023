using INterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Taxi : TransportePublico, IValidacion
    {
        public Taxi() : base()
        {
        }

        public Taxi(string Tipo, int Numero, int Pasajeros) : base(Tipo, Numero, Pasajeros)
        {
        }

        public override string Avanzar()
        {
            return "el Taxi está avanzando";
        }

        public override string Detenerse()
        {
            return "el Taxi está detenido";
        }

        public string ValidacionPasajerosTipo()
        {
            string paso = "";
            if (this.Numero > 4)
            {
                paso = "Excede el límite de 4 pasajeros";
            }

            return paso;

        }
    }
}
