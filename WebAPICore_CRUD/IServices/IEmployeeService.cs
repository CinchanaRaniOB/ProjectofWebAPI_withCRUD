using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore_CRUD.Models;

namespace WebAPICore_CRUD.IServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployee();
        Employee AddEmployee(Employee emp);
        Employee UpdateEmployee(Employee emp);
        Employee DeleteEmployee(int id);
    }
}
