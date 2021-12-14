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
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create a new Department
        public async Task<Department> Create(Department src)
        {

            _context.Department.Add(src);                     // Preform the add in the memory
            await _context.SaveChangesAsync();              // Save the changes to the database

            // Return the new Department, new EmployeeId will by added by Entity Framework automatically
            return src;
        }

        // Get a single listing by Id
        public async Task<Department> Get(int id)
        {

            // Get the Department Entity you are seeking
            var result = await _context.Department.FirstOrDefaultAsync(i => i.DepartmentId == id);


            // return the retrieved entry
            return result;

        }

        // Get all of the listings in the database
        public async Task<List<Department>> GetAll()
        {
            // Get all of the Department Entities
            var results = await _context.Department.ToListAsync();

            //Return the Department Entities retrieved from the above line
            return results;
        }

        // Update a currently existing Department
        public async Task<Department> Update(Department src, int departmentId)
        {

            // Add the inputted employeeId to the src
            src.DepartmentId = departmentId;

            // Get the entity to update
            var result = await _context.Department.FirstOrDefaultAsync(i => i.DepartmentId == src.DepartmentId);


            // Preform the update on the Department entity
            result.DepartmentName = src.DepartmentName;
            result.UniqueDepartmentAddress = src.UniqueDepartmentAddress;
            result.CompanyId = src.CompanyId;

            // Save the updates to the database
            await _context.SaveChangesAsync();

            // Return the Actual entity class and not the src class so that we are sure that the database Department is correct
            return result;
        }

        // Delete a specific Department
        public async Task Delete(int id)
        {
            // Get the specific Department Entity you wish to delete
            var result = await _context.Department.FirstAsync(i => i.DepartmentId == id);

            //Remove the entity from the collection in your memory
            _context.Remove(result);

            // Remove the entity from the database
            await _context.SaveChangesAsync();
        }


    }
}
