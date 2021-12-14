using LaunchpadCodeChallenge.Models.Entities;
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

        // Required Service method for Code Challenge
        public IEnumerable<Employee> GetAll()
        {
            // Pull in dummy data to return the list of all Employees.
            var result = ListOfEmployees;

            return result;

        }

        // Required Service method for Code Challenge
        public IList<Employee> ListAll()
        {
            // Make a new List to pull dummy data into
            List<Employee> result = new List<Employee>();

            // Pull in dummy data 
            result = ListOfEmployees;

            return result;

        }

        // Controller endpoint method for Question2
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

        private readonly List<Department> ListOfDepartments = new()
        {

            new Department
            {
                DepartmentId = 1,
                DepartmentName = "SuperGood",
                UniqueDepartmentAddress = "Silly Street",
                CompanyId = 1
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
