using BE;
using DAL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP
{
   
    public class MP_Shippers : IGetGenerica<Shippers>
    {
        private NorthwindContext _nwContext;

        public MP_Shippers()
        {
            _nwContext = new NorthwindContext();
        }


        public List<Shippers> GetListAll()
        {
            try
            {
              return _nwContext.Shippers.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al traer Shippers {ex.Message} -- {ex.StackTrace}");
            }

        }
    }
}
