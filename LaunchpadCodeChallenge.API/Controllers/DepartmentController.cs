using LaunchpadCodeChallenge.Models.Entities.VMs.Department;
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
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }



        // Creates a Department from inputed data.
        [HttpPost]
        public async Task<ActionResult<DepartmentVM>> Create([FromBody] DepartmentCreateVM data)
        {
            // Have the service create the new Listing
            var result = await _departmentService.Create(data);

            //Return as 200 message along with the DepartmentVM
            return Ok(result);
        }

        // Get a Department by it's Id.
        [HttpGet("get/{id}")]
        public async Task<ActionResult<DepartmentVM>> Get([FromRoute] int id)
        {
            // Get the requested Listing entity from the service
            var result = await _departmentService.Get(id);

            // Return a 200 message with the ListingVM for the client
            return Ok(result);
        }


        // Update a Department using inputted data, excluding non-updatable properties
        // like id.
        [HttpPut("update/{departmentId}")]
        public async Task<ActionResult<DepartmentVM>> Update([FromBody] DepartmentUpdateVM data, [FromRoute] int departmentId)
        {
            // Update Listing entity from the service layer
            var result = await _departmentService.Update(data, departmentId);

            // Return a 200 code + the ListingVM to comfirm the update went through properly
            return Ok(result);
        }


        // Delete a listing from the database (determined by Id).
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            // Tell the repository to delete the requested Listing
            await _departmentService.Delete(id);

            // Return a 200 response to confirm it has completed
            return Ok();
        }


        // Get all departments (CC required)
        [HttpGet("getAll")]
        public async Task<List<DepartmentVM>> GetAll()
        {
            // Use the GetAll method from the Service layer
            var results = await _departmentService.GetAll();

            // Return the Departments gotten from the service layer
            return results;
        }



    }
}
