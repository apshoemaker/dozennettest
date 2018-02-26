using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DozenNetTest.Domain.Mappings
{
    public interface IMapper
    {
        TDest Map<TSource, TDest>(TSource source);

        IQueryable<TDest> Map<TSource, TDest>(IQueryable<TSource> sourceQuery);

        TDest Map<TSource, TDest>(TSource source, TDest destination);
    }
}
