using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.Entities.VMs.Department;
using LaunchpadCodeChallenge.Repository.Repositories.Interfaces;
using LaunchPadCodeChallenge.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        public async Task<DepartmentVM> Create(DepartmentCreateVM src)
        {
            // Generate a new Entity with the inputted data
            var newEntity = new Department(src);

            // Use that data to create the new Department
            var result = await _departmentRepository.Create(newEntity);

            // Create a DepartmentVM from the result to return/show
            var model = new DepartmentVM(result);

            // Return the result as an DepartmentVM
            return model;
        }

        // Get an Department by its EmployeeId
        public async Task<DepartmentVM> Get(int id)
        {

            // Get the Department entitiy from the repository
            var result = await _departmentRepository.Get(id);

            // Create the EmployeeVm that we will return
            var model = new DepartmentVM(result);

            // Return the Department VM in a 200 response
            return model;

        }

        // Modified GetAll after switching to database implementation
        public async Task<List<DepartmentVM>> GetAll()
        {
            // Get the Department entities from the repository
            var results = await _departmentRepository.GetAll();

            // Build the Department view models to return to the client
            var models = results.Select(employee => new DepartmentVM(employee)).ToList();

            // Return the EmployeeVMs
            return models;
        }

        public async Task<DepartmentVM> Update(DepartmentUpdateVM src, int departmentId)
        {

            // Make the repository update the Department
            var updateData = new Department(src);
            var result = await _departmentRepository.Update(updateData, departmentId);

            //Create the EmployeeVm model for returning to the client
            var model = new DepartmentVM(result);

            //Finally return the DepartmentVM to show that the change was sucessfull
            return model;
        }

        public async Task Delete(int id)
        {
            // Inform the repository to delete the specified Listing Entity
            await _departmentRepository.Delete(id);
        }


    }
}
