using EmployeeJwtApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeJwtApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")] // Role-based access
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Velan", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Gokul", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "Arun", Department = "Finance", Salary = 47000 }
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return BadRequest("Invalid employee id");

            emp.Name = updatedEmp.Name;
            emp.Department = updatedEmp.Department;
            emp.Salary = updatedEmp.Salary;

            return Ok(emp);
        }
    }
}
