using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.Entities.VMs.Department;
using LaunchpadCodeChallenge.Models.Entities.VMs.Employee;
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


        // Get all employees (CC required)
        [HttpGet]
        public async Task<List<EmployeeVM>> GetAll()
        {
            // Use the GetAll method from the Service layer
            var results = await _employeeService.GetAll();

            // Return the Employees gotten from the service layer
            return results;
        }

        // Get the department that an Employee belongs to from their DepartmentId (CC required)
        [HttpGet("department/{inputId}")]
        public async Task<DepartmentVM> GetDepartmentFromId([FromRoute] int inputId)
        {
            var results = await _employeeService.GetDepartmentById(inputId);

            return results;

        }
    }
}
