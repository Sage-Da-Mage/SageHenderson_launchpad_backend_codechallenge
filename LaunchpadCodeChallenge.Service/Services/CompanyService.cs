using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.Entities.VMs.Company;
using LaunchpadCodeChallenge.Repository.Repositories;
using LaunchpadCodeChallenge.Service.Services.Interfaces;
using LaunchpadCodeChallenge.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<CompanyVM> Create(CompanyCreateVM src)
        {
            // Generate a new Entity with the inputted data
            var newEntity = new Company(src);

            // Use that data to create the new Company
            var result = await _companyRepository.Create(newEntity);

            // Create a CompanyVM from the result to return/show
            var model = new CompanyVM(result);

            // Return the result as an CompanyVM
            return model;
        }

        // Get an Company by its CompanyId
        public async Task<CompanyVM> Get(int id)
        {

            // Get the Company entitiy from the repository
            var result = await _companyRepository.Get(id);

            // Create the CompanyVm that we will return
            var model = new CompanyVM(result);

            // Return the Company VM in a 200 response
            return model;

        }

        // Modified GetAll after switching to database implementation
        public async Task<List<CompanyVM>> GetAll()
        {
            // Get the Company entities from the repository
            var results = await _companyRepository.GetAll();

            // Build the Company view models to return to the client
            var models = results.Select(company => new CompanyVM(company)).ToList();

            // Return the CompanyVMs
            return models;
        }

        public async Task<CompanyVM> Update(CompanyUpdateVM src)
        {

            // Make the repository update the Company
            var updateData = new Company(src);
            var result = await _companyRepository.Update(updateData);

            //Create the CompanyVm model for returning to the client
            var model = new CompanyVM(result);

            //Finally return the CompanyVM to show that the change was sucessfull
            return model;
        }

        public async Task Delete(int id)
        {
            // Inform the repository to delete the specified Listing Entity
            await _companyRepository.Delete(id);
        }


    }


}
