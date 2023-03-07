using labNetPractica2.ModifiedExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.ExtensionMethods
{
    public static class DecimalExtensions
    {
        public static (decimal, string) DividirPorCero(this decimal dividendo)
        {
            decimal resultado = 0;
            string mensaje = "";
            try
            {
                resultado = dividendo / 0;

            }
            catch (DivideByZeroException ex)
            {
                mensaje += ex.Message + " - " + ex.StackTrace;
            }
            catch (Exception ex)
            {
                mensaje += ex.Message + " - " + ex.StackTrace;
            }
            finally
            {
                mensaje += "\r**PASO POR FINALLY**";
               
            }

            return (resultado, mensaje);


        }

        public static (decimal, string) Dividir(this decimal dividendo, decimal? divisor)
        {
            bool ok = true;
            decimal resultado = 0;
            string mensaje = "";
            try
            {
                resultado = dividendo / divisor.Value;

            }
            catch (DivideByZeroException ex)
            {
                ok = false;
                mensaje += $"Solo STEVEN SEAGAL puede divir por 0 {ex.Message} - {ex.StackTrace}";
            }
            catch (FormatException ex)
            {
                ok = false;
                mensaje += $"Seguro Ingreso una letra o no ingreso nada! {ex.Message} - {ex.StackTrace}";
            }
            catch (Exception ex)
            {
                ok = false;
                mensaje += ex.Message + " - " + ex.StackTrace;
            }
            finally
            {
                if (ok)
                    mensaje += "\rPasó por finally de manera exitosa";
                else
                    mensaje += "\rPasó por finally resultado ERRONEO!!!";
            }

            return (resultado, mensaje);


        }
    }
}
