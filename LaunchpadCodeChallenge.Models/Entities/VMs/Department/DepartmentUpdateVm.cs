using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Department
{
    // The difference between this file and DepartmentCreateVm is that
    // this file lacks DepartmentId since that shouldn't be updated
    public class DepartmentUpdateVM
    {

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
