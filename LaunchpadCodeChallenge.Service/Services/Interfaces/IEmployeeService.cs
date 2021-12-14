using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.Entities.VMs.Department;
using LaunchpadCodeChallenge.Models.Entities.VMs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services.Interfaces
{
    public interface IEmployeeService
    {

        // Create a new Employee
        Task<EmployeeVM> Create(EmployeeCreateVM src);

        //Get a single existing Employee by its Id
        Task<EmployeeVM> Get(int id);

        //Update a currently existing Employee
        Task<EmployeeVM> Update(EmployeeUpdateVM src);

        // Delete a Employee
        Task Delete(int id);



        // Get all of the Employees currently existing (CC required)
        public Task<List<EmployeeVM>> GetAll();

        // List all of the Employees currently existing (CC required)
        public Task<List<EmployeeVM>> ListAll();

        // Get a department from an employee by it's DepartmentId (CC required)
        public Task<DepartmentVM> GetDepartmentById(int id);

    }
}
