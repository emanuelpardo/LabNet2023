using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SuppliersController : Controller
    {
        // GET: Suppliers
        public ActionResult Index()
        {
            BL_Suppliers _blsuppliers = new BL_Suppliers();
            List<Suppliers> Lista_suppliers = _blsuppliers.GetListAll();
            return View(Lista_suppliers);
        }
    }
}