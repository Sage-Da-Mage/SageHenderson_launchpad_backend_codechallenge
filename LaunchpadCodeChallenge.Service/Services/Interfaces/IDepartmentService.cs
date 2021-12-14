using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.Entities.VMs.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services.Interfaces
{
    public interface IDepartmentService
    {

        // Create a new Department
        Task<DepartmentVM> Create(DepartmentCreateVM src);

        //Get a single existing Department by its Id
        Task<DepartmentVM> Get(int id);

        Task<List<DepartmentVM>> GetAll();

        //Update a currently existing Department
        Task<DepartmentVM> Update(DepartmentUpdateVM src);

        // Delete a Department
        Task Delete(int id);


    }
}
