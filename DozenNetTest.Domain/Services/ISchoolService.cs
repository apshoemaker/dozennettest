using DozenNetTest.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DozenNetTest.Domain.Services
{
    public interface ISchoolService
    {
        List<SchoolDTO> GetAllSchools();
    }
}
