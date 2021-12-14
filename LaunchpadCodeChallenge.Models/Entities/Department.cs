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
        // A Department has an Id to differenciate it from others (can't be changed after assignment)
        [Key]
        public int DepartmentId { get; init; }

        // A Department must have a name
        [Required]
        public string DepartmentName { get; set; }

        // A department must have a uniqueDepartmentAddress no other Department has
        // (though it may be changed so long as no 2 departments share the same UniqueDepartmentAddress)
        [Key]
        public string UniqueDepartmentAddress { get; set; }

        // The Id of the company this department is a part of
        [Required]
        public int CompanyId { get; set; }

        // The Company Class that this department is a part of
        //[Required]
        //public Company Company { get; set; }

    }
}
