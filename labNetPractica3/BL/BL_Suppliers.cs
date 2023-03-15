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
    public class BL_Suppliers : IGetGenerica<Suppliers>, IAbmGenerica<Suppliers>
    {
        private MP_Suppliers _mpSuppliers;
           
        public BL_Suppliers()
        {
            _mpSuppliers = new MP_Suppliers();
        }

       

        public List<Suppliers> GetListAll()
        {
            try
            {
                return _mpSuppliers.GetListAll();
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
                _mpSuppliers.Insert(x);
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
