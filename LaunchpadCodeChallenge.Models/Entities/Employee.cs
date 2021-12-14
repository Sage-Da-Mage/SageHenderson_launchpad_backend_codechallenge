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
        // An employee has an Id which is unchangable after assignment
        [Key]
        public int EmployeeId { get; init; }

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
        [Required]
        public Department Department { get; set; }


    }
}