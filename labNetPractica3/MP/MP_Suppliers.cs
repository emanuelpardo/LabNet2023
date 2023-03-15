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
    public class MP_Suppliers: IGetGenerica<Suppliers>, IAbmGenerica<Suppliers>
    {
        NorthwindContext _nwContext;
        public MP_Suppliers()
        {
            _nwContext = new NorthwindContext();
        }

        

        public List<Suppliers> GetListAll()
        {
            try
            {
                return _nwContext.Suppliers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Suppliers x)
        {
            try
            {
                _nwContext.Suppliers.Add(x);
                _nwContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Suppliers x)
        {
            throw new NotImplementedException();
        }
        public void Delete(Suppliers x)
        {
            throw new NotImplementedException();
        }
    }
}
