using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitFlow.Models
{
    public class EmployeeRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Code { get; set; }
    }
}