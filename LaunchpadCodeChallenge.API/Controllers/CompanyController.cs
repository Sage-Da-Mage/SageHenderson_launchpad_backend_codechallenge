using LaunchpadCodeChallenge.Models.Entities.VMs.Company;
using LaunchpadCodeChallenge.Service.Services.Interfaces;
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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }



        // Creates a Company from inputed data.
        [HttpPost]
        public async Task<ActionResult<CompanyVM>> Create([FromBody] CompanyCreateVM data)
        {
            // Have the service create the new Listing
            var result = await _companyService.Create(data);

            //Return as 200 message along with the CompanyVM
            return Ok(result);
        }

        // Get a Company by it's Id.
        [HttpGet("get/{id}")]
        public async Task<ActionResult<CompanyVM>> Get([FromRoute] int id)
        {
            // Get the requested Listing entity from the service
            var result = await _companyService.Get(id);

            // Return a 200 message with the ListingVM for the client
            return Ok(result);
        }


        // Update a Company using inputted data, excluding non-updatable properties
        // like id.
        [HttpPut("update/{companyId}")]
        public async Task<ActionResult<CompanyVM>> Update([FromBody] CompanyUpdateVM data, [FromRoute] int companyId)
        {
            // Update Listing entity from the service layer
            var result = await _companyService.Update(data, companyId);

            // Return a 200 code + the ListingVM to comfirm the update went through properly
            return Ok(result);
        }


        // Delete a listing from the database (determined by Id).
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            // Tell the repository to delete the requested Listing
            await _companyService.Delete(id);

            // Return a 200 response to confirm it has completed
            return Ok();
        }


        // Get all companys (CC required)
        [HttpGet("getAll")]
        public async Task<List<CompanyVM>> GetAll()
        {
            // Use the GetAll method from the Service layer
            var results = await _companyService.GetAll();

            // Return the Companys gotten from the service layer
            return results;
        }


    }
}
