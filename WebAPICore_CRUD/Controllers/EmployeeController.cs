using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore_CRUD.IServices;
using WebAPICore_CRUD.Models;

namespace WebAPICore_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employee)
        {
            employeeService = employee;          //now this employee can be used to call services
        }

        [HttpGet]
       /* [Route("[action]")]
        [Route("api/Employee/GetEmployee")]*/
        public IEnumerable<Employee> GetEmployee()
        {
            return employeeService.GetEmployee();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public Employee AddEmployee(Employee emp)
        {
            return employeeService.AddEmployee(emp);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Employee/EditEmployee")]
        public Employee EditEmployee(Employee emp)
        {
            return employeeService.UpdateEmployee(emp);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Employee/DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return employeeService.DeleteEmployee(id);
        }
    }
}
