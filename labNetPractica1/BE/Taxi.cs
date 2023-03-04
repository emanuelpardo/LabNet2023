using INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Taxi : TransportePublico
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

        //public string ValidacionPasajerosTipo()
        //{
        //    string paso = "";
        //    if(!ValidarPasajeros())
        //        paso = "Excede el límite de 4 pasajeros";

        //    return paso;

        //}

        //private bool ValidarPasajeros()
        //{
        //    bool ok = true;
        //    if (this.Pasajeros > 4)
        //        ok = false;
        //    return ok;

        //}
    }
}
