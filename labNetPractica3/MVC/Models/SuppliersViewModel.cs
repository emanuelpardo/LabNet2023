using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class SuppliersViewModel
    {
        private const string errorNombreContacto = "El Nombre del Contacto debe tener máximo 30 caracteres";
        private const string errorNombreCompaniaR = "Nombre de Compañía es obligatorio";
        private const string errorNombreCompania = "El nombre de la compañía debe tener máximo 40 caracteres";
        private const string errorCiudad = "La ciudad debe tener máximo 15 caracteres";
        private int? id;
        private string nombreCompania;
        private string nombreContacto;
        private string ciudad;

        public int? ID
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage = errorNombreCompaniaR)]
        [StringLength(40, ErrorMessage = errorNombreCompania)]
        public string NombreCompania
        {
            get { return nombreCompania; }
            set { nombreCompania = value; }
        }
        [StringLength(30, ErrorMessage = errorNombreContacto)]
        public string NombreContacto
        {
            get { return nombreContacto; }
            set { nombreContacto = value; }
        }
        [StringLength(15, ErrorMessage = errorCiudad)]
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }



    }
}