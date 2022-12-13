using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Onion_Arch_Service.Models
{
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string City { get; set; }
        public Nullable<decimal> Salary { get; set; }
    }
}
