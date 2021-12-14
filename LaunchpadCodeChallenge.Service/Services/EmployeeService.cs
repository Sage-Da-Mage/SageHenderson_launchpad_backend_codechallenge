using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.Entities.VMs.Department;
using LaunchpadCodeChallenge.Models.Entities.VMs.Employee;
using LaunchpadCodeChallenge.Repository.Repositories.Interfaces;
using LaunchPadCodeChallenge.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<EmployeeVM> Create(EmployeeCreateVM src)
        {
            // Generate a new Entity with the inputted data
            var newEntity = new Employee(src);

            // Use that data to create the new Employee
            var result = await _employeeRepository.Create(newEntity);

            // Create a EmployeeVM from the result to return/show
            var model = new EmployeeVM(result);

            // Return the result as an EmployeeVM
            return model;
        }

        // Get an Employee by its EmployeeId
        public async Task<EmployeeVM> Get(int EmployeeId)
        {

            // Get the Employee entitiy from the repository
            var result = await _employeeRepository.Get(EmployeeId);

            // Create the EmployeeVm that we will return
            var model = new EmployeeVM(result);

            // Return the Employee VM in a 200 response
            return model;

        }

        // Modified GetAll after switching to database implementation
        public async Task<List<EmployeeVM>> GetAll()
        {
            // Get the Employee entities from the repository
            var results = await _employeeRepository.GetAll();

            // Build the Employee view models to return to the client
            var models = results.Select(employee => new EmployeeVM(employee)).ToList();

            // Return the EmployeeVMs
            return models;
        }

        public async Task<EmployeeVM> Update(EmployeeUpdateVM src, int employeeId)
        {

            // Make the repository update the Employee
            var updateData = new Employee(src);
            var result = await _employeeRepository.Update(updateData, employeeId);

            //Create the EmployeeVm model for returning to the client
            var model = new EmployeeVM(result);

            //Finally return the EmployeeVM to show that the change was sucessfull
            return model;
        }

        public async Task Delete(int id)
        {
            // Inform the repository to delete the specified Listing Entity
            await _employeeRepository.Delete(id);
        }

        public async Task<DepartmentVM> GetDepartmentById(int departmentId)
        {
            // Get the department from DepartmentRepository by the DepartmentId that the Employee has
            var results = await _departmentRepository.Get(departmentId);

            // Make the Department into a DepartmentVm for the client
            var model = new DepartmentVM(results);

            // Return the DepartmentVM
            return model;

        }

        /* In-memory implementation of GetAll, no longer used
        //Required Service method for Code Challenge (CC required)
        public IEnumerable<Employee> GetAll()
        {
            // Pull in dummy data to return the list of all Employees.
            var result = ListOfEmployees;

            return result;

        }*/

        // Required Service method for Code Challenge (CC required) 
        // Effectively the same as GetAll at this point.
        public async Task<List<EmployeeVM>> ListAll()
        {
            // Get the Employee entities from the repository
            var results = await _employeeRepository.GetAll();

            // Build the Employee view models to return to the client
            var models = results.Select(employee => new EmployeeVM(employee)).ToList();

            // Return the EmployeeVMs
            return models;

        }

        /* Prior implementation of GetDepartmentById, no longer used
         * 
        // Controller endpoint method for Question2 (CC required)
        public Department GetDepartmentById(int id)
        {

            List<Department> depoList = new List<Department>();

            depoList = ListOfDepartments;

            foreach (Department depoCheck in depoList)
            {

                if(depoCheck.DepartmentId == id)
                {
                    return depoCheck;
                }
            }
            return null;

        }*/
    }
}
