using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.Entities.VMs.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Service.Services.Interfaces
{
    public interface ICompanyService
    {
        // Create a new Company
        Task<CompanyVM> Create(CompanyCreateVM src);

        //Get a single existing Company by its Id
        Task<CompanyVM> Get(int id);

        Task<List<CompanyVM>> GetAll();

        //Update a currently existing Company
        Task<CompanyVM> Update(CompanyUpdateVM src, int companyId);

        // Delete a Company
        Task Delete(int id);

    }
}
