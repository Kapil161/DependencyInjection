using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Repository.Contract;

namespace DependencyInjection.Repository.Services
{
    public class EmployeeServices:IEmployee
    {
        private List<Employee> Employees;
        public EmployeeServices()
        {
            Employees = new List<Employee>()
            {
              
                new Employee() { Id = 1, Name = "Kapil",Email = "kapiltyagi123@gmail.com",Gender = "Male",Address = "Sonipat"},
            new Employee() { Id = 2, Name = "Mohit", Email = "mohitsehrawat123@gmail.com", Gender = "Male", Address = "Noida" },
            new Employee() { Id = 3, Name = "Prashant", Email = "prashanttyagi123@gmail.com", Gender = "Male", Address = "Gaziabad" },
            new Employee() { Id = 4, Name = "Sumit", Email = "sumitkaushik123@gmail.com", Gender = "Male", Address = "Delhi" },
            new Employee() { Id = 5, Name = "Nitin", Email = "nitintyagi123@gmail.com", Gender = "Male", Address = "Mimarpur" },
             new Employee() { Id = 6, Name = "Akif", Email = "akifuddin123@gmail.com", Gender = "Male", Address = "Darbangha" },

             };
        }

        public int CountEmployees()
        {
            return Employees.Count;
        }

      

        public List<Employee> GetEmployees()
        {
            return Employees.ToList();
        }

        public Employee CreateEmployee(Employee employee)
        {
            Employees.Add(employee);
            return employee;
        }

        IEmployee IEmployee.CreateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
