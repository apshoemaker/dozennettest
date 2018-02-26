using AutoMapper;
using DozenNetTest.Domain.DTOs;
using DozenNetTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DozenNetTest.Domain.Mappings
{
    public class DefaultMapping : Profile
    {
        public DefaultMapping()
        {
            CreateMap<School, SchoolDTO>().ReverseMap();
        }
    }
}
