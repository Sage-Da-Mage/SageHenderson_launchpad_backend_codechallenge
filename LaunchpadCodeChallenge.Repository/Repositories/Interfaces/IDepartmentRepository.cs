using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Repository.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {

        Task<Department> Create(Department src);                    // Create a new Employee


        Task<Department> Get(int id);                             // Get a specific Employee by Id

        Task<List<Department>> GetAll();                          // Get all Employees

        Task<Department> Update(Department src);                     // Update an existing Employee

        Task Delete(int id);                                    // Delete an Employee
    }
}
