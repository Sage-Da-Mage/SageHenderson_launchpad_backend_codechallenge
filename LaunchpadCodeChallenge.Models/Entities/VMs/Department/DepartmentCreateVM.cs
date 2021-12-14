using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Department
{
    public class DepartmentCreateVM
    {


        // A Department has an Id differentiating them from other Employees
        // which is unchangable after assignment
        [Key]
        public int DepartmentId { get; init; }

        // An Employee has a FirstName
        [Required]
        public string DepartmentName { get; set; }

        // An Employee has a LastName
        [Required]
        public string UniqueDepartmentAddress { get; set; }

        // An Employee has a JobTitle
        [Required]
        public int CompanyId { get; set; }


        // The Company class of the Company the Department belongs to
        //
        //public Company Company { get; set; }


    }
}
