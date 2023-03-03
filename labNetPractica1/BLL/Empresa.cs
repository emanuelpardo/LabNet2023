using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Empresa
    {
        List<TransportePublico> Lista_TransportePublico;
        public Empresa()
        {
            Lista_TransportePublico = new List<TransportePublico>();
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
