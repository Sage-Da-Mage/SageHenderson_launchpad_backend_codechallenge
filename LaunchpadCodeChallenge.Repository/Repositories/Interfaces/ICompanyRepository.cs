using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Repository.Repositories.Interfaces
{
    public interface ICompanyRepository
    {
        Task<Company> Create(Company src);                    // Create a new Company


        Task<Company> Get(int id);                             // Get a specific Company by Id

        Task<List<Company>> GetAll();                          // Get all Employees

        Task<Company> Update(Company src);                     // Update an existing Company

        Task Delete(int id);                                    // Delete an Company
    }
}
