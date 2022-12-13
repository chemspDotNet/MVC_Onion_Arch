using MVC_Onion_Arch_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MVC_Onion_Arch_Service.Models;
using MVC_Onion_Arch.Models;
using MVC_Onion_Arch_DAL.Data;

namespace MVC_Onion_Arch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeService EmployeeService = new EmployeeService();
       
        public ActionResult Index()
        {
           Mapper.CreateMap<EmployeeDTO, EmployeeVM>();
           var empDtos = EmployeeService.GetEmployeesInfo();
           var employeeVMs =  Mapper.Map<IEnumerable<EmployeeVM>>(empDtos);
           return View(employeeVMs);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int EmployeeID)
        {
            Mapper.CreateMap<EmployeeDTO, EmployeeVM>();
            var empDto = EmployeeService.GetEmployeesInfoByID(EmployeeID);
            var employeeVM = Mapper.Map<EmployeeVM>(empDto);

            return View(employeeVM);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            EmployeeVM emp = new EmployeeVM();
            return View(emp);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Employee emp = new Employee();
                emp.City = collection["City"];
                emp.Age = Int16.Parse(collection["Age"]);
                emp.Salary = Decimal.Parse(collection["Salary"]);
                //  emp.EmployeeID = EmployeeID;
                emp.Name = collection["Name"];
                EmployeeService.uow.Employees.Add(emp);
                EmployeeService.uow.Complete();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int EmployeeID)
        {
             Mapper.CreateMap<EmployeeDTO, EmployeeVM>();
            var empDto = EmployeeService.GetEmployeesInfoByID(EmployeeID);
            var employeeVM = Mapper.Map<EmployeeVM>(empDto);

            return View(employeeVM);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int EmployeeID, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Employee emp = EmployeeService.uow.Employees.GetByID(EmployeeID);
                emp.City = collection["City"];
                emp.Age = Int16.Parse(collection["Age"]);
                emp.Salary = Decimal.Parse(collection["Salary"]);
                emp.Name = collection["Name"];
              //  emp.EmployeeID = EmployeeID;

               
                EmployeeService.uow.Complete();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int EmployeeID)
        {
            Mapper.CreateMap<EmployeeDTO, EmployeeVM>();
            var empDto = EmployeeService.GetEmployeesInfoByID(EmployeeID);
            var employeeVM = Mapper.Map<EmployeeVM>(empDto);

            return View(employeeVM);

        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int EmployeeID, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var emp= EmployeeService.uow.Employees.GetByID(EmployeeID);

                this.EmployeeService.uow.Employees.Remove(emp);
                this.EmployeeService.uow.Complete();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
