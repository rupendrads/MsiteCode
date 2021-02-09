using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepartmentsWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("FindCustomersShortetRoute")]
        public  IList<string> FindCustomersShortetRoute(int x, int y)
        {
            _customerService.FindCustomersShortetRoute(x, y);

            return  _customerService.FilteredCustomers;
        }
    }
}
