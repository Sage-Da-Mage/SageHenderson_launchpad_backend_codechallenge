using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Repository.Repositories
{
    // Generate/store test/dummy data for use before/without database support
    // (each list reappears in their respective service), this is the collection for easy acess.
    public class InMemoryRepository
    {

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


        private readonly List<Employee> ListOfEmployees = new()
        {
            new Employee
            {

                EmployeeId = 1,
                FirstName = "Stephan",
                LastName = "Hunter",
                JobTitle = "Forager",
                AddressOfResidence = "22 Burbank street",
                DepartmentId = 1
            },

            new Employee
            {
                EmployeeId = 2,
                FirstName = "Jessie",
                LastName = "James",
                JobTitle = "Thief",
                AddressOfResidence = "Pallet Town",
                DepartmentId = 1
            },

            new Employee
            {
                EmployeeId = 3,
                FirstName = "Bruce",
                LastName = "Hammer",
                JobTitle = "Body Builder",
                AddressOfResidence = "Hammer Maynor",
                DepartmentId = 1
            },

            new Employee
            {
                EmployeeId = 4,
                FirstName = "Drizzt",
                LastName = "Doduren",
                JobTitle = "Accountant",
                AddressOfResidence = "Detroit",
                DepartmentId = 2
            },

            new Employee
            {
                EmployeeId = 5,
                FirstName = "Wolfgang",
                LastName = "Skrillix",
                JobTitle = "Musician",
                AddressOfResidence = "Timeline square",
                DepartmentId = 2
            },

            new Employee
            {
                EmployeeId = 6,
                FirstName = "Steve",
                LastName = "ST",
                JobTitle = "Survivor",
                AddressOfResidence = "The Entities Realm",
                DepartmentId = 3
            }

        };


    }
}

