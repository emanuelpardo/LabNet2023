using labNetPractica2.ModifiedExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Logica
{
    public class Logic
    {
        public Logic()
        {

        }

        public decimal PuntoTres_ExcepcionDesdeLogic_a_Presentacion(string dividendo, string divisor)
        {
            try
            {
                if (!string.IsNullOrEmpty(dividendo) && !string.IsNullOrEmpty(divisor)
                    && decimal.TryParse(dividendo, out decimal dividendo_decimal)
                    && decimal.TryParse(divisor, out decimal divisor_decimal))
                    return dividendo_decimal / divisor_decimal;
                else
                    throw new FormatException();
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public decimal PuntoCuatro_ExcepcionPersonalizadaDesdeLogic_a_Presentacion(string dividendo, string divisor)
        {

            try
            {
                if (!string.IsNullOrEmpty(dividendo) && !string.IsNullOrEmpty(divisor)
                    && decimal.TryParse(dividendo, out decimal dividendo_decimal)
                    && decimal.TryParse(divisor, out decimal divisor_decimal))
                    return dividendo_decimal / divisor_decimal;
                else
                    throw new BadInputException();
            }
            catch (BadInputException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
