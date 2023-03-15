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
        NorthwindContext _nwContext;

        public MP_Shippers()
        {
            _nwContext = new NorthwindContext();
        }

      

        public List<Shippers> GetListAll()
        {
            try
            {
             return _nwContext.Shippers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public void Insert(Shippers x)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public void Modify(Shippers x)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public void Delete(Shippers x)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
    }
}
