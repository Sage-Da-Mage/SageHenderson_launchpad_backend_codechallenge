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

        Task<Department> Create(Department src);                    // Create a new Department


        Task<Department> Get(int id);                               // Get a specific Department by Id

        Task<List<Department>> GetAll();                            // Get all Department

        Task<Department> Update(Department src, int departmentId);  // Update an existing Department

        Task Delete(int id);                                        // Delete an Department
    }
}
