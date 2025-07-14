using EmployeeApiDemo.Filters;
using EmployeeApiDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EmployeeApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [TypeFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new();

        public EmployeeController()
        {
            if (_employees.Count == 0)
                _employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1990, 5, 1),
                    Department = new Department { DeptId = 1, DeptName = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, SkillName = "C#" },
                        new Skill { Id = 2, SkillName = "SQL" }
                    }
                }
            };
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            // Simulate exception to test filter
            throw new Exception("Test exception occurred.");
            // return Ok(_employees);
        }

        [HttpPost]
        public ActionResult Add([FromBody] Employee emp)
        {
            _employees.Add(emp);
            return CreatedAtAction(nameof(Get), new { id = emp.Id }, emp);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Employee emp)
        {
            var e = _employees.Find(x => x.Id == id);
            if (e == null) return NotFound();

            e.Name = emp.Name;
            e.Salary = emp.Salary;
            e.Permanent = emp.Permanent;
            e.Department = emp.Department;
            e.Skills = emp.Skills;
            e.DateOfBirth = emp.DateOfBirth;

            return NoContent();
        }
    }
}
