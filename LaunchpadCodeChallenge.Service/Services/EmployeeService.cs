using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services
{
    public class EmployeeService
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
