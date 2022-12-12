using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitFlow.Models
{
    public class Person
    {
        public int Id_Person { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public int Phone { get; set; }
    }
}