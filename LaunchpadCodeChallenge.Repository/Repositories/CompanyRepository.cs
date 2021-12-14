using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Repository.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {

        private readonly ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create a new Company
        public async Task<Company> Create(Company src)
        {

            _context.Company.Add(src);                      // Preform the add in the memory
            await _context.SaveChangesAsync();              // Save the changes to the database

            // Return the new Company, new EmployeeId will by added by Entity Framework automatically
            return src;
        }

        // Get a single listing by Id
        public async Task<Company> Get(int id)
        {

            // Get the Company Entity you are seeking
            var result = await _context.Company.FirstOrDefaultAsync(i => i.CompanyId == id);

            // return the retrieved entry
            return result;

        }

        // Get all of the listings in the database
        public async Task<List<Company>> GetAll()
        {
            // Get all of the Company Entities
            var results = await _context.Company.ToListAsync();

            //Return the Company Entities retrieved from the above line
            return results;
        }

        // Update a currently existing Company
        public async Task<Company> Update(Company src)
        {

            // Get the entity to update
            var result = await _context.Company.FirstOrDefaultAsync(i => i.CompanyId == src.CompanyId);


            // Preform the update on the Company entity
            result.CompanyName = src.CompanyName;


            // Save the updates to the database
            await _context.SaveChangesAsync();

            // Return the Actual entity class and not the src class so that we are sure that the database Company is correct
            return result;
        }

        // Delete a specific Company
        public async Task Delete(int id)
        {
            // Get the specific Company Entity you wish to delete
            var result = await _context.Company.FirstAsync(i => i.CompanyId == id);

            //Remove the entity from the collection in your memory
            _context.Remove(result);

            // Remove the entity from the database
            await _context.SaveChangesAsync();
        }




    }
}
