using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_WebAPI.Models;
using Microsoft.Extensions.Logging;

namespace Kantor_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }
        [HttpGet(Name = "Get Employee")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetAllEmployee();
        }

        [HttpGet("{id}", Name = "GET")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }

        [HttpPost( Name = "POST")]
        public ActionResult<IEnumerable<EmployeeItem>> InsertEmployee(EmployeeItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.InsertEmployee(item);

        }
         [HttpPut("{id}", Name = "PUT")]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployee(String id,EmployeeItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.UpdateEmployee(id,item);

        }

        [HttpDelete("{id}", Name = "DEL")]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployee(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.DelEmployee(id);

        }
    }
}
