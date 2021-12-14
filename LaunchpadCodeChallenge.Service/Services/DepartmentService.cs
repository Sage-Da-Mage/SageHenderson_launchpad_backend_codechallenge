using LaunchpadCodeChallenge.Models.Entities;
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

        // A department Equivelant to the required Employee Code for the Code Challenge.
        public IEnumerable<Department> GetAll()
        {
            var result = ListOfDepartments;

            return result;

        }


        // A department Equivelant to the required Employee Code for the Code Challenge.
        public IList<Department> GetList()
        {
            // Make a new List to pull dummy data into
            List<Department> result = new List<Department>();

            // Pull in dummy data 
            result = ListOfDepartments;

            return result;

        }


        private readonly List<Department> ListOfDepartments = new()
        {

            new Department
            {
                DepartmentId = 1,
                DepartmentName = "SuperGood",
                UniqueDepartmentAddress = "Silly Street"
            },

            new Department
            {
                DepartmentId = 2,
                DepartmentName = "UltraGreat",
                UniqueDepartmentAddress = "Wall Street",
                CompanyId = 1
            },

            new Department
            {
                DepartmentId = 3,
                DepartmentName = "FantasticExcellent",
                UniqueDepartmentAddress = "Yellow Brick Road",
                CompanyId = 2
            }

        };
    }
}
