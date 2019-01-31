using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fotocopiadora.Mapping
{
    public interface IObjMapper
    {
        T Map<T>(object source);

        TDest Map<TSource, TDest>(TSource source);
    }
}