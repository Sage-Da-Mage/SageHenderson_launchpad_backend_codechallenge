using LaunchpadCodeChallenge.Models.Entities.VMs.Department;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities
{
    // The Department Class
    public class Department
    {
        // Default constructor to allow the creation of empty Department Entities
        public Department()
        {

        }

        // The constructor for creating a Department from a DepartmentVM model
        public Department(DepartmentCreateVM src)
        {
            DepartmentId = src.DepartmentId;
            DepartmentName = src.DepartmentName;
            UniqueDepartmentAddress = src.UniqueDepartmentAddress;
            CompanyId = src.CompanyId;
        }

        // The constructor for updating a currently existing Department from a DepartmentUpdateVM
        public Department(DepartmentUpdateVM src)
        {
            DepartmentName = src.DepartmentName;
            UniqueDepartmentAddress = src.UniqueDepartmentAddress;
            CompanyId = src.CompanyId;
        }


        // A Department has an Id to differenciate it from others (can't be changed after assignment)
        [Key]
        public int DepartmentId { get; init; }

        // A Department must have a name
        [Required]
        public string DepartmentName { get; set; }

        // A department must have a uniqueDepartmentAddress no other Department has
        // (though it may be changed so long as no 2 departments share the same UniqueDepartmentAddress)
        [Required]
        public string UniqueDepartmentAddress { get; set; }

        // The Id of the company this department is a part of
        [Required]
        public int CompanyId { get; set; }

        // The Company Class that this department is a part of
        //[Required]
        //public Company Company { get; set; }

    }
}
