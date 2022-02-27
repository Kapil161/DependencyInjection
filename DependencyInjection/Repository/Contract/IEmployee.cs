using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Repository.Contract
{
     public interface IEmployee
    {
        IEmployee CreateEmployee(Employee employee);
        List<Employee> GetEmployees();
        int CountEmployees();
    }
}
