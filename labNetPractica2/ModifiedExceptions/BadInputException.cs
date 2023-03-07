using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.ModifiedExceptions
{
    public class BadInputException : Exception
    {

        public BadInputException() : base()
        {

        }
        public override string Message => "Excepcion Personalizada!! **NUMERO NULO**"; 
    }
}
