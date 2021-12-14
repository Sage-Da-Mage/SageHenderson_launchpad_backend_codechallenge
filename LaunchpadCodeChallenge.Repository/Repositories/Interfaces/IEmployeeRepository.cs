using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Repository.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> Create(Employee src);                    // Create a new Employee

        
        Task<Employee> Get(int id);                             // Get a specific Employee by Id

        Task<List<Employee>> GetAll();                          // Get all Employees

        Task<Employee> Update(Employee src);                     // Update an existing Employee

        Task Delete(int id);                                    // Delete an Employee

    }
}
