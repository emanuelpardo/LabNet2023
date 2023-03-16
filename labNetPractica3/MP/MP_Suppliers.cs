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
    public class MP_Suppliers: IGetGenerica<Suppliers>, IAbmGenerica<Suppliers,string>
    {
        private NorthwindContext _nwContext;
        public MP_Suppliers()
        {
            _nwContext = new NorthwindContext();
        }
        public MP_Suppliers(NorthwindContext nc)
        {
            _nwContext = nc;
        }


        public List<Suppliers> GetListAll()
        {
            try
            {
                return _nwContext.Suppliers.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al traer Suppliers {ex.Message} -- {ex.StackTrace}");
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
                throw new Exception($"Error al Agregar Suppliers {ex.Message} -- {ex.StackTrace}");
            }
        }

        public void Modify(Suppliers x)
        {
            try
            {
                Suppliers SP =_nwContext.Suppliers.FirstOrDefault(s => s.SupplierID == x.SupplierID);
                SP.CompanyName = x.CompanyName;
                SP.ContactName = x.ContactName;
                SP.ContactTitle = x.ContactTitle;
                SP.City = x.City;
                _nwContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar Suppliers {ex.Message} -- {ex.StackTrace}");
            }

        }
        public void Delete(Suppliers x)
        {
            try
            {
             
                Suppliers SP = _nwContext.Suppliers.FirstOrDefault<Suppliers>(s => s.SupplierID == x.SupplierID);
                if (SP != null)
                {
                    List<Products> PR = SP.Products.ToList();
                    PR.ForEach(pr => pr.SupplierID = null);
                    _nwContext.Suppliers.Remove(SP);
                    _nwContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw new Exception($"Error al eliminar Suppliers {ex.Message} -- {ex.StackTrace}");
            }
        }

        public bool Existe(string x)
        {
           
            try
            {
               return _nwContext.Suppliers.Any(s => s.CompanyName.ToLower().Trim() == x.ToLower().Trim());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al confirmar existencia Suppliers {ex.Message} -- {ex.StackTrace}");
            }
           
        }
    }
}
