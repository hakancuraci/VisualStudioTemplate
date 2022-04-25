using $ext_safeprojectname$.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace $ext_safeprojectname$.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<string> Get()
        {
            return _service.GetAll();
        }
    }
}
