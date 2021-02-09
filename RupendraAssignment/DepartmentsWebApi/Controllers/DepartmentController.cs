using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepartmentsWebApi.Services;
namespace DepartmentsWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private IDepartmentService _departmentService;
        public  DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
    
        [HttpGet("GetPeopleInDepartment")]
        public IList<string> GetPeopleInDepartment(string departmentName)
        {
            return _departmentService.GetPeopleInDepartment(departmentName);
        }


        [HttpGet("GetDepartmentsByPerson")]
        public IList<string> GetDepartmentsByPerson(string surName, string foreName)
        {
            return _departmentService.GetDepartmentsByPerson(surName, foreName);
        }
    }
}
    