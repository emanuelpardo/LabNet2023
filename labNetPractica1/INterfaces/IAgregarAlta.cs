using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterfaces
{
    public interface IAgregarAlta<T>
    {
        void Alta(T x);
        (bool,string) AgregarLista(string tipo, int numeropasajeros, int numerotransporte);
    }
}
