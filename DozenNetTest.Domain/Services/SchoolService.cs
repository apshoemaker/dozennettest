using DozenNetTest.Domain.DTOs;
using DozenNetTest.Domain.Models;
using DozenNetTest.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DozenNetTest.Domain.Mappings;

namespace DozenNetTest.Domain.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IRepository<School> _schoolRepository;
        private readonly IMapper _mapper;

        public SchoolService(IRepository<School> schoolRepository,
                            IMapper mapper)
        {
            _schoolRepository = schoolRepository;
            _mapper = mapper;
        }

        public List<SchoolDTO> GetAllSchools()
        {
            var schools = _schoolRepository.GetAllList();

            var dto = schools.Select(s => _mapper.Map<School, SchoolDTO>(s)).ToList();

            return dto;
        }
    }
}
