using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DTO
{
    public class CustomersOrdersDTO
    {
        public string ClienteId{ get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteRegion { get; set; }
        public int? OrdenId { get; set; }
        public DateTime? OrdenFecha { get; set; }
        
        
    }
}
