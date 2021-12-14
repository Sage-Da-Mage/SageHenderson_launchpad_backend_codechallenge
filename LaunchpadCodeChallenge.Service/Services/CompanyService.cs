using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services
{
    public class CompanyService : ICompanyService
    {
        // Required Service method for Code Challenge
        public IEnumerable<Company> GetAll()
        {
            // Pull in dummy data to return the list of all Employees.
            var result = ListOfCompanies;

            return result;

        }

        // Required Service method for Code Challenge
        public IList<Company> ListAll()
        {
            // Make a new List to pull dummy data into
            List<Company> result = new List<Company>();

            // Pull in dummy data 
            result = ListOfCompanies;

            return result;

        }


        private readonly List<Company> ListOfCompanies = new()
        {
            new Company
            {
                CompanyId = 1,
                CompanyName = "Rad Company",
            },

            new Company
            {
                CompanyId = 2,
                CompanyName = "Fantastic Company"
            }
        };

    }


}
