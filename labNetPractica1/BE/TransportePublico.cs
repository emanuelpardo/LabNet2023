using INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class TransportePublico : IValidacion
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

        public string ValidacionPasajerosTipo()
        {
            string paso = "";
            if (this is Omnibus)
            {
                if (!ValidarPasajeros(true))
                    paso = "Excede el límite de 100 pasajeros";

                
            }
            else if (this is Taxi)
            {
                if (!ValidarPasajeros(false))
                    paso = "Excede el límite de 4 pasajeros";
            }
            return paso;
        }

        private bool ValidarPasajeros(bool esOmnibus)
        {
            bool ok = true;
            if (esOmnibus && this.Pasajeros > 100)
                ok = false;
            if (!esOmnibus && this.Pasajeros > 4)
                ok = false;
            return ok;

        }
    }
    
        

}
