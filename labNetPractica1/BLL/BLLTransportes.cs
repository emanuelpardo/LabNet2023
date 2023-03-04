using BE;
using INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTransportes : IAgregarAlta<Taxi>, IAgregarAlta<Omnibus>
    {
        List<TransportePublico> Lista_TransportePublico;
        public BLLTransportes()
        {
            Lista_TransportePublico = new List<TransportePublico>();
        }

        public (bool, string) AgregarLista(string tipo, int numeropasajeros, int numerotransporte)
        {
            bool paso = true;
            string mensaje_devolucion = "";
            try
            {
                if (ExisteEnLista(numerotransporte, tipo) == false)
                {
                    if (!CantidadMaximaCinco(tipo))
                    {
                        if (tipo == TransportePublico.TipoOmnibus)
                        {
                            Omnibus OmnibusNuevo = new Omnibus(tipo, numerotransporte, numeropasajeros);
                            mensaje_devolucion = OmnibusNuevo.ValidacionPasajerosTipo();
                            if (!string.IsNullOrEmpty(mensaje_devolucion))
                                paso = false;
                            else
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
                    else
                    {
                        paso = false;
                        mensaje_devolucion += $"No puede haber mas de 5 {tipo}";
                    }
                }
                else
                {
                    paso = false;
                    mensaje_devolucion += $"Transporte {tipo} - {numerotransporte} ya existe";
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
            if (x != null)
                this.Lista_TransportePublico.Add(x);
        }

        public void Alta(Omnibus x)
        {
            if(x!=null)
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
        private bool ExisteEnLista(int numero, string tipo)
        {
            if (this.Lista_TransportePublico.Exists(x => x.Numero == numero && x.Tipo == tipo))
                return true;
            else
                return false;
        }

        private bool CantidadMaximaCinco(string tipo)
        {
            bool haycinco = false;
            try
            {
                    var i = Lista_TransportePublico?.Count(x => x.Tipo == tipo);
                    if (i >= 5)
                        haycinco = true;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return haycinco;
        }

        public List<TransportePublico> RetornarLista()
        {
            List<TransportePublico> Lista_Auxiliar = new List<TransportePublico>();
            foreach (var item in this.Lista_TransportePublico)
            {
                Lista_Auxiliar.Add(item);
            }
            return Lista_Auxiliar;
        }
    }
}
