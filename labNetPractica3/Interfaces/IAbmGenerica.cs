using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAbmGenerica<T>
    {

        void Insert(T x);
        void Delete(T x);
        void Modify(T x);

    }
}
