﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_WebAPI.Models;
using Microsoft.Extensions.Logging;

namespace Kantor_WebAPI.Controllers
{
    [Route("[controller]")]
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
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem0(String nama, String jeniskelamin, String alamat)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.InsertEmployee(nama, jeniskelamin, alamat);
        }

        [HttpPut(Name = "PUT")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem2(String id,String nama, String jeniskelamin, String alamat)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.UpdateEmployee(id, nama, jeniskelamin, alamat);
        }

        [HttpDelete ("{id}", Name = "Delete")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem1(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.DelEmployee(id);
        }
    }
}
