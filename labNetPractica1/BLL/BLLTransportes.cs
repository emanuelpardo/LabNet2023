using BE;
using INterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTransportes: IAgregarAlta<Taxi>, IAgregarAlta<Omnibus>      
    {
        List<TransportePublico> Lista_TransportePublico;
        public BLLTransportes()
        {
            Lista_TransportePublico = new List<TransportePublico>();
        }

        public (bool,string) AgregarLista(string tipo, int numeropasajeros, int numerotransporte)
        {
            bool paso = true;
            string mensaje_devolucion = "";
            try
            {
                if (tipo == TransportePublico.TipoOmnibus)
                {
                    Omnibus OmnibusNuevo = new Omnibus(tipo, numeropasajeros, numerotransporte);
                    this.Alta(OmnibusNuevo);

                }
                else if (tipo == TransportePublico.TipoTaxi)
                {
                    Taxi TaxiNuevo = new Taxi();
                    TaxiNuevo.Tipo = tipo;
                    TaxiNuevo.Pasajeros = numeropasajeros;
                    TaxiNuevo.Numero = numerotransporte;
                    mensaje_devolucion = TaxiNuevo.ValidacionPasajerosTipo();
                    if (!string.IsNullOrEmpty(mensaje_devolucion))
                        paso = false;
                    else
                        this.Alta(TaxiNuevo);
                }
                else
                {
                    paso = false;
                    mensaje_devolucion += "Falla en AgregarLista";
                }
            }
            catch (Exception ex)
            {
                paso = false;
                mensaje_devolucion += ex.Message + ex.StackTrace;
            }
           
            return (paso, mensaje_devolucion);
        }

        public void Alta(Taxi x)
        {
            if(!this.Lista_TransportePublico.Exists(a => a.Numero == x.Numero && a.Tipo == x.Tipo))
                this.Lista_TransportePublico.Add(x);
        }

        public void Alta(Omnibus x)
        {
            if (!this.Lista_TransportePublico.Exists(a => a.Numero == x.Numero && a.Tipo == x.Tipo))
                this.Lista_TransportePublico.Add(x);
        }

        public bool Lista_esMenoraDiez()
        {
            bool paso = true;
            try
            {
                if (this.Lista_TransportePublico?.Count == 10)
                    paso = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return paso;        
        }
    }
}
