using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIweb.Models
{
    public class SuppliersModel
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

        [Required]
        [StringLength(40)]
        public string NombreCompania
        {
            get { return nombreCompania; }
            set { nombreCompania = value; }
        }
        [StringLength(30)]
        public string NombreContacto
        {
            get { return nombreContacto; }
            set { nombreContacto = value; }
        }
        [StringLength(15)]
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }


    }
}