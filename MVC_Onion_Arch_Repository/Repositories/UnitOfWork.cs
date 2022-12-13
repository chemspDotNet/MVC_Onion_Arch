using MVC_Onion_Arch_DAL.Data;
using OnionArchitectureMVC.Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeDBEntities _context;
        public UnitOfWork(EmployeeDBEntities context)
        {
            _context = context;
             Employees = new EmployeeRepository(_context);
              }

        public IEmployeeRepository Employees { get; set; }
        
        public int Complete(){
          return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
