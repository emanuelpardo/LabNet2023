using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World\nApreta enter para cerrar**");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " - " + ex.StackTrace);
            }
            finally
            { 
                Console.ReadLine(); 
            }
        }
    }
}
