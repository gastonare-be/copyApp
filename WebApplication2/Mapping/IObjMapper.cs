using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Mapping
{
   public  interface IObjMapper
    {
        T Map<T>(object source);

        TDest Map<TSource, TDest>(TSource source);
    }
}
