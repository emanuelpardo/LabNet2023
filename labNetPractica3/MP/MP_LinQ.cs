using BE;
using BE.DTO;
using DAL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP
{
    public class MP_LinQ : IGetForLinQ<object>
    {
        private NorthwindContext _nwContext;
        public MP_LinQ()
        {
            _nwContext = new NorthwindContext();
        }

        public object GetPuntoLinq(int punto)
        {
            List<object> ListaDevolucion = new List<object>();
            try
            {
                if (punto == 1)
                {
                    ListaDevolucion.Add(_nwContext.Customers.FirstOrDefault<Customers>());
                    return ListaDevolucion;
                }
                else if (punto == 2)
                    return _nwContext.Products.Where(p => p.UnitsInStock == 0).ToList();
                else if (punto == 3)
                    return _nwContext.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3M).ToList();
                else if (punto == 4)
                    return _nwContext.Customers.Where(c => c.Region == "WA").ToList();
                else if (punto == 5)
                {
                    ListaDevolucion.Add(_nwContext.Products.Where(p => p.ProductID == 789).FirstOrDefault());
                    return ListaDevolucion;
                }
                else if (punto == 6)
                    return (from c in _nwContext.Customers
                            select new CustomersNamesDTO
                            {
                                NombreMayuscula = c.CompanyName.ToUpper(),
                                NombreMinuscula = c.CompanyName.ToLower()

                            }).ToList();
                else if (punto == 7)
                {
                    DateTime filtro = new DateTime(1997, 1, 1);
                    return (from c in _nwContext.Customers
                            join o in _nwContext.Orders
                            on c.CustomerID equals o.CustomerID
                            where c.Region == "WA" && o.OrderDate > filtro
                            select new CustomersOrdersDTO
                            {
                                ClienteId = c.CustomerID,
                                ClienteNombre = c.CompanyName,
                                ClienteRegion = c.Region,
                                OrdenId = o.OrderID,
                                OrdenFecha = o.OrderDate
                            }).ToList();

                }
                else if (punto == 8)
                    return (from c in _nwContext.Customers
                            orderby c.CustomerID ascending
                            where c.Region == "WA"
                            select c).Take(3).ToList();
                else if (punto == 9)
                    return (from p in _nwContext.Products
                            orderby p.ProductName ascending
                            where p.ProductName != null
                            select p).ToList();
                else if (punto == 10)
                    return (from p in _nwContext.Products
                            orderby p.UnitsInStock descending
                            select p).ToList();
                else if (punto == 11)
                    return (from c in _nwContext.Categories
                            join p in _nwContext.Products
                            on c.CategoryID equals p.CategoryID
                            select new
                            {
                                c.CategoryName
                            }).GroupBy(c => c.CategoryName).ToList();
                else if (punto == 12)
                {
                    ListaDevolucion.Add(_nwContext.Products.FirstOrDefault());
                    return ListaDevolucion;
                }
                else if (punto == 13)
                    return (from c in _nwContext.Customers
                            join o in _nwContext.Orders
                            on c.CustomerID equals o.CustomerID into ordenes
                            select new CustomersOrdersCountDTO
                            {
                               NombreCustomer = c.CompanyName,
                               CantidadOrdenes = ordenes.Count()
                            }).OrderByDescending(co => co.CantidadOrdenes).ThenBy(co => co.NombreCustomer).ToList();
                else
                    return null;

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
