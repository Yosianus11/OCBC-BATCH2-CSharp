using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTest_Mock.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Designation { get; set; }
    }
}