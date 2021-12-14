using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Employee
{
    // The VM that is used to create an EmployeeVm
    public class EmployeeCreateVm
    {
        // The comments describing the properties below are in Employee.cs

        [Key]
        public int EmployeeId { get; set; }

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
