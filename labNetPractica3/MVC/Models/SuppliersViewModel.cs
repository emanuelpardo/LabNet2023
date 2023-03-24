using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class SuppliersViewModel
    {
        private int? id;
        private string nombreCompania;
        private string nombreContacto;
        private string ciudad;

        public int? ID
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage = "Nombre de Compañía es obligatorio")]
        [StringLength(40, ErrorMessage = "Agregue un caracter")]
        public string NombreCompania
        {
            get { return nombreCompania; }
            set { nombreCompania = value; }
        }
       
        public string NombreContacto
        {
            get { return nombreContacto; }
            set { nombreContacto = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }



    }
}