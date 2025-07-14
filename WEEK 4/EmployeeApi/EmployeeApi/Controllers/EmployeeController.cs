using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Velan", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Gokul", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "Arun", Department = "Finance", Salary = 47000 }
        };

        // PUT: api/Employee/2
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update properties
            existingEmployee.Name = updatedEmp.Name;
            existingEmployee.Department = updatedEmp.Department;
            existingEmployee.Salary = updatedEmp.Salary;

            return Ok(existingEmployee); // Return updated employee
        }
    }
}
