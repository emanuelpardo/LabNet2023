using Interfaces;
using MP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class BL_LinQ : IGetForLinQ<object>
    {
        private MP_LinQ _mpLinQ;
       public BL_LinQ()
        {
            _mpLinQ = new MP_LinQ();
        }

        public object GetPuntoLinq(int punto)
        {
            try
            {
                return _mpLinQ.GetPuntoLinq(punto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
