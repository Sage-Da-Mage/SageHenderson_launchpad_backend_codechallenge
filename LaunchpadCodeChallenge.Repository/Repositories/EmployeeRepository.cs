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
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create a new Employee
        public async Task<Employee> Create(Employee src)
        {

            _context.Employee.Add(src);                     // Preform the add in the memory
            await _context.SaveChangesAsync();              // Save the changes to the database

            // Return the new Employee, new EmployeeId will by added by Entity Framework automatically
            return src;
        }

        // Get a single listing by Id
        public async Task<Employee> Get(int id)
        {

            // Get the Employee Entity you are seeking
            var result = await _context.Employee.FirstOrDefaultAsync(i => i.EmployeeId == id);

            // return the retrieved entry
            return result;

        }

        // Get all of the listings in the database
        public async Task<List<Employee>> GetAll()
        {
            // Get all of the Employee Entities
            var results = await _context.Employee.ToListAsync();

            //Return the Employee Entities retrieved from the above line
            return results;
        }

        // Update a currently existing Employee
        public async Task<Employee> Update(Employee src)
        {

            // Get the entity to update
            var result = await _context.Employee.FirstOrDefaultAsync(i => i.EmployeeId == src.EmployeeId);


            // Preform the update on the Employee entity
            result.FirstName = src.FirstName;
            result.LastName = src.LastName;
            result.JobTitle = src.JobTitle;
            result.AddressOfResidence = src.AddressOfResidence;
            result.DepartmentId = src.DepartmentId;

            // Save the updates to the database
            await _context.SaveChangesAsync();

            // Return the Actual entity class and not the src class so that we are sure that the database Employee is correct
            return result;
        }

        // Delete a specific Employee
        public async Task Delete(int id)
        {
            // Get the specific Employee Entity you wish to delete
            var result = await _context.Employee.FirstAsync(i => i.EmployeeId == id);

            //Remove the entity from the collection in your memory
            _context.Remove(result);

            // Remove the entity from the database
            await _context.SaveChangesAsync();
        }


    }
}
