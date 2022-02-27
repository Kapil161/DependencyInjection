using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Repository.Contract;
using DependencyInjection.Models;


namespace DependencyInjection.Controllers
{
    public class EmployeeController : Controller
    {
        

           
        public IEmployee EmployeeService { get; }

        public EmployeeController(IEmployee _employeeService)
        {
            EmployeeService = _employeeService;
        }

        public IActionResult Index()
        {
            var emps=EmployeeService.GetEmployees();
            return View(emps);
        }
    }
}
