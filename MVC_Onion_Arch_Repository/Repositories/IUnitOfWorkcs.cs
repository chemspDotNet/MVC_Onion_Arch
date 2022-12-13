using OnionArchitectureMVC.Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo
{
    public interface IUnitOfWork:IDisposable
    {
        IEmployeeRepository Employees { get; }
        
        int Complete();
        
    }
}
