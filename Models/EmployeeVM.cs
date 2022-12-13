using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Onion_Arch.Models
{
    public class EmployeeVM
    {
        public int EmployeeID { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public Nullable<int> Age { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public Nullable<decimal> Salary { get; set; }

    }
}