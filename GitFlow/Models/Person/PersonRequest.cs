using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitFlow.Models
{
    public class PersonRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public int Phone { get; set; }
    }
}