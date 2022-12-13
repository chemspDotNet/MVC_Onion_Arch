
using MVC_Onion_Arch_DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDBEntities employeeDBEntities) : base(employeeDBEntities)
        {

        }
        
       // public TestDBEntities TestDBEntities { get { return Context as TestDBEntities; } }

        
        IEnumerable<Employee> IEmployeeRepository.GetEmployeeInfo(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
