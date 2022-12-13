using AutoMapper;
using MVC_Onion_Arch_DAL.Data;
using MVC_Onion_Arch_Service.Models;
using OnionArchitectureMVC.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Onion_Arch_Service
{
    public class EmployeeService
    {
        public UnitOfWork uow { get; set; }
        
        public EmployeeService()
        {
            EmployeeDBEntities employeeDBEntities = new EmployeeDBEntities();
            uow = new UnitOfWork(employeeDBEntities);
           
        }


        public EmployeeDTO GetEmployeesInfoByID(int id)
        { 
            Employee emp = uow.Employees.GetByID(id);
            Mapper.CreateMap<Employee, EmployeeDTO>();
            EmployeeDTO empDTO = Mapper.Map<EmployeeDTO>(emp);

            return empDTO;
        }


        public IEnumerable<EmployeeDTO> GetEmployeesInfo()
        {

            var emps = uow.Employees.GetAll();
            Mapper.CreateMap<Employee,EmployeeDTO>();

            var empDTOs = Mapper.Map <IEnumerable< EmployeeDTO>>(emps);
            return empDTOs;
        }
    }
}
