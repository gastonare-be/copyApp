using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace WebApplication2.Mapping
{
    public class ObjMapper : IObjMapper
    {
        private readonly IMapper _mapper;

        public ObjMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public T Map<T>(object source)
        {
            return _mapper.Map<T>(source);
        }



        public TDest Map<TSource, TDest>(TSource source)
        {
            return _mapper.Map<TSource, TDest>(source);
        }

    }
}
