using BE;
using BL;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SuppliersController : Controller
    {
        private const string index = "Index";
        private BL_Suppliers _blsuppliers;
        public SuppliersController()
        {
            _blsuppliers = new BL_Suppliers();
        }
       
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                return View(_blsuppliers.GetListAll().Select(s => new SuppliersViewModel { ID = s.SupplierID, NombreCompania = s.CompanyName, NombreContacto = s.ContactName, Ciudad = s.City }).OrderBy(x => x.ID).ToList());
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
           
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id != null)
                    _blsuppliers.Delete(new Suppliers { SupplierID = id.Value });

                return RedirectToAction(index);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
          
        }

        [HttpGet]
        public ActionResult InsertEdit(int? id)
        {
            SuppliersViewModel Spw = new SuppliersViewModel();
            try
            {
                if (id != null)
                {
                    var s = _blsuppliers.GetListAll().Where(x => x.SupplierID == id.Value).FirstOrDefault();
                    Spw = new SuppliersViewModel
                    {
                        ID = s.SupplierID,
                        NombreCompania = s.CompanyName,
                        NombreContacto = s.ContactName,
                        Ciudad = s.City
                    };
                }

                return View(Spw);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            
        }

        [HttpPost]
        public ActionResult Guardar(SuppliersViewModel Svw)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (Svw.ID != null)
                    {
                        var s = _blsuppliers.GetListAll().Where(x => x.SupplierID == Svw.ID.Value).FirstOrDefault();
                        s.CompanyName = Svw.NombreCompania;
                        s.ContactName = Svw.NombreContacto;
                        s.City = Svw.Ciudad;
                        _blsuppliers.Modify(s);
                    }
                    else
                        _blsuppliers.Insert(new Suppliers { CompanyName = Svw.NombreCompania, ContactName = Svw.NombreContacto, City = Svw.Ciudad });
                   
                }
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            return RedirectToAction(index);


        }
    }
}