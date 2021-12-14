using LaunchpadCodeChallenge.Models.Entities;
using LaunchPadCodeChallenge.Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;


        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        // Get all employees
        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {

            var results = _employeeService.GetAll();

            // Return the Employees gotten from the service layer
            return results;


        }

        // Get the department that an Employee belongs to from their DepartmentId
        [HttpGet("department/{inputId}")]
        public ActionResult<Department> GetDepartmentFromId([FromRoute] int inputId)
        {
            var results = _employeeService.GetDepartmentById(inputId);

            return Ok(results);

        }
    }
}
