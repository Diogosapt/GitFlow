using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitFlow.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Code { get; set; }
    }
}