using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Employee
{
    // The difference between UpdateVm and CreateVM is that 
    // the UpdateVM does not have the unchangable properties (EmployeeId)
    public class EmployeeUpdateVM
    {
        // The Properties of an Employee,
        // Comments describing them are in the Employee.cs file

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string AddressOfResidence { get; set; }

        [Required]
        public int DepartmentId { get; set; }




    }
}
