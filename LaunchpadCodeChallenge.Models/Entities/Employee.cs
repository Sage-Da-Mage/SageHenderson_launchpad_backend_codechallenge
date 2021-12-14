using LaunchpadCodeChallenge.Models.Entities.VMs;
using LaunchpadCodeChallenge.Models.Entities.VMs.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities
{
    public class Employee
    {

        // Default constructor to allow creation of an empty Employee entity
        public Employee()
        {

        }

        // The Constructor for creating an Employee from an EmployeeVM model
        public Employee(EmployeeCreateVM src)
        {
            EmployeeId = src.EmployeeId;
            FirstName = src.FirstName;
            LastName = src.LastName;
            JobTitle = src.JobTitle;
            AddressOfResidence = src.AddressOfResidence;
            DepartmentId = src.DepartmentId;
        }

        // The constructor for changing the properties of an Employee
        // from an EmployeeUpdateModel
        public Employee(EmployeeUpdateVM src)
        {
            FirstName = src.FirstName;
            LastName = src.LastName;
            JobTitle = src.JobTitle;
            AddressOfResidence = src.AddressOfResidence;
            DepartmentId = src.DepartmentId;
        }

         
        // An employee has an Id which is unchangable after assignment
        [Key]
        public int EmployeeId { get; set; }

        // An Employee has a FirstName
        [Required]
        public string FirstName { get; set; }

        // An Employee has a LastName
        [Required]
        public string LastName { get; set; }

        // An Employee has a JobTitle
        [Required]
        public string JobTitle { get; set; }

        // An employee has an AddressOfResidence
        [Required]
        public string AddressOfResidence { get; set; }

        // The Id of the Department this employee belongs to
        [Required]
        public int DepartmentId { get; set; }
        // The Department class of the Department the Employee belongs to
        //[Required]
        //public Department Department { get; set; }


    }
}