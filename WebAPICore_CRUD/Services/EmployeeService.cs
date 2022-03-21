using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore_CRUD.IServices;
using WebAPICore_CRUD.Models;

namespace WebAPICore_CRUD.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly APICoreDbContext dbContext;

        public EmployeeService(APICoreDbContext db)
        {
            dbContext = db;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            var employee = dbContext.Employee.ToList();
            return employee;
        }
        public Employee AddEmployee(Employee employee)
        {
            dbContext.Employee.Add(employee);    //adds employee to db
            dbContext.SaveChanges();             //after adding save the changes
            return employee;                     //returns that employee
        }

        public Employee DeleteEmployee(int id)
        {
            var emp = dbContext.Employee.Find(id);
            dbContext.Employee.Remove(emp);
            dbContext.SaveChanges();
            return emp;
        }

        public Employee UpdateEmployee(Employee emp)
        {
            dbContext.Entry(emp).State = EntityState.Modified;
            dbContext.SaveChanges();
            return emp;
        }
    }
}
