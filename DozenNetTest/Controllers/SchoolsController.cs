using Autofac;
using DozenNetTest.Domain.DTOs;
using DozenNetTest.Domain.Models;
using DozenNetTest.Domain.Services;
using DozenNetTest.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DozenNetTest.Controllers
{
    public class SchoolsController : ApiController
    {
        private ISchoolService _schoolService;

        public SchoolsController()
        {

        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            _schoolService = Ioc.Container.Resolve<ISchoolService>();
            var schools = _schoolService.GetAllSchools();
            return Ok(schools);
        }

        [Route("students")]
        public IHttpActionResult GetStudents(SchoolDTO dto)
        {
            return Ok();
        }
    }
}
