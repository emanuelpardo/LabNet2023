using APIweb.Models;
using BE;
using BL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIweb.Controllers
{
    public class ValuesController : ApiController
    {

        private BL_Suppliers _blsuppliers;
        public ValuesController()
        {
            _blsuppliers = new BL_Suppliers();
        }
           
        // GET api/values
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                List<Suppliers> ListaSuppliers = _blsuppliers.GetListAll();
                if (ListaSuppliers?.Count > 0)
                    return Ok(ListaSuppliers.Select(s => new SuppliersModel { ID = s.SupplierID, NombreCompania = s.CompanyName, NombreContacto = s.ContactName, Ciudad = s.City }).OrderBy(x => x.ID).ToList());
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
           
        }

        // GET api/values/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                Suppliers supplier = _blsuppliers.GetListAll().Where(s => s.SupplierID == id).FirstOrDefault();
                if (supplier != null)
                    return Ok(new SuppliersModel {ID = supplier.SupplierID, NombreCompania = supplier.CompanyName, NombreContacto = supplier.ContactName, Ciudad = supplier.City });
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }


        }

        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody] SuppliersModel supplier)
        {
            try
            {
                if (!string.IsNullOrEmpty(supplier?.NombreCompania))
                {
                    _blsuppliers.Insert(new Suppliers { CompanyName = supplier?.NombreCompania, ContactName = supplier?.NombreContacto, City = supplier?.Ciudad});
                    return Ok("ingresado correctamente");
                }
            else
                    return BadRequest("Asegurese de ingresar los datos correctamente. El metodo post debe tener un supplier que no sea null o que contenga mínimamente un CompanyName");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // PUT api/values
        [HttpPut]
        public IHttpActionResult Put([FromBody] SuppliersModel UpdatingSupplier)
        {
            try
            {
               
                Suppliers supplier = _blsuppliers.GetListAll().Where(s => s.SupplierID == UpdatingSupplier?.ID).FirstOrDefault();
                if (supplier != null && !string.IsNullOrEmpty(UpdatingSupplier?.NombreCompania))
                {
                    supplier.CompanyName = UpdatingSupplier.NombreCompania;
                    supplier.ContactName = UpdatingSupplier.NombreContacto;
                    supplier.City = UpdatingSupplier.Ciudad;
                    _blsuppliers.Modify(supplier);
                    return Ok("Actualizado Correctamente");
                }
                else
                    return BadRequest("Asegurese de ingresar los datos correctamente. El metodo PUT/PATCH debe tener un supplier que no sea null o que contenga mínimamente un CompanyName");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE api/values/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Suppliers supplier = _blsuppliers.GetListAll().Where(s => s.SupplierID == id).FirstOrDefault();
                if (supplier != null)
                {
                    _blsuppliers.Delete(supplier);
                    return Ok($"Eliminación completa id = {id}");
                }
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }

}

