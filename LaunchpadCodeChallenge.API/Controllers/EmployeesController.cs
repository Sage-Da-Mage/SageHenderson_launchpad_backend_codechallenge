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



        // Creates a Employee from inputed data.
        [HttpPost]
        public async Task<ActionResult<EmployeeVM>> Create([FromBody] EmployeeCreateVM data)
        {
            // Have the service create the new Listing
            var result = await _employeeService.Create(data);

            //Return as 200 message along with the EmployeeVM
            return Ok(result);
        }

        // Get a Employee by it's Id.
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeVM>> Get([FromRoute] int id)
        {
            // Get the requested Listing entity from the service
            var result = await _employeeService.Get(id);

            // Return a 200 message with the ListingVM for the client
            return Ok(result);
        }


        // Update a Employee using inputted data, excluding non-updatable properties
        // like id.
        [HttpPut("employee/{id}")]
        public async Task<ActionResult<EmployeeVM>> Update([FromBody] EmployeeUpdateVM data)
        {
            // Update Listing entity from the service layer
            var result = await _employeeService.Update(data);

            // Return a 200 code + the ListingVM to comfirm the update went through properly
            return Ok(result);
        }


        // Delete a listing from the database (determined by Id).
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            // Tell the repository to delete the requested Listing
            await _employeeService.Delete(id);

            // Return a 200 response to confirm it has completed
            return Ok();
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
