using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DozenNetTest.Domain.Mappings
{
    public class Mapper : IMapper
    {
        private MapperConfiguration configurations;

        private AutoMapper.IMapper mapper;

        public Mapper()
        {
            configurations = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DefaultMapping>();
            });

            mapper = configurations.CreateMapper();
        }

        public IQueryable<TDest> Map<TSource, TDest>(IQueryable<TSource> query)
        {
            return query.ProjectTo<TDest>(configurations);
        }

        public TDest Map<TSource, TDest>(TSource source)
        {
            return mapper.Map<TSource, TDest>(source);
        }

        public TDest Map<TSource, TDest>(TSource source, TDest destination)
        {
            return mapper.Map<TSource, TDest>(source, destination);
        }
    }
}
