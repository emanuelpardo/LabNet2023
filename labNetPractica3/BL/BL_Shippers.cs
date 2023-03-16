using BE;
using Interfaces;
using MP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_Shippers : IGetGenerica<Shippers>
    {
        private MP_Shippers _mpShippers;
        public BL_Shippers()
        {
            _mpShippers = new MP_Shippers();
        }
        public List<Shippers> GetListAll()
        {
            try
            {
                return _mpShippers.GetListAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
               
    }
}
