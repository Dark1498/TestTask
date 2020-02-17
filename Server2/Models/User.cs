using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Iin { get; set; }
        public DateTime Birthday { get; set; }
    }
}