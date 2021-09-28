using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace eCommerceStarterCode.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/examples/user
        [HttpGet]
        public IActionResult Get()
        {
            var customers = _context.Customers;
            return Ok(customers);
        }
    }
}







Message ali daley, Kory Attleson, Stas Mironenko, Treveon Edwards
















