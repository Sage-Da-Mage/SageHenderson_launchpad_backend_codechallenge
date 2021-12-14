using LaunchpadCodeChallenge.Models.Entities.VMs.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities
{
    // The Company class, each Company has a list of Departments
    public class Company
    {
        // The default constructor for creating empty Company Entities
        public Company()
        {

        }

        // The constructor that creates a Company from a CompanyVM model
        public Company(CompanyCreateVM src)
        {
            CompanyId = src.CompanyId;
            CompanyName = src.CompanyName;
        }

        // The constructor that updates a currently existing Company with a CompanyUpdateVm
        public Company(CompanyUpdateVM src)
        {
            CompanyName = src.CompanyName;
        }

        // The Companies Id, so it can be differenciated
        [Key]
        public int CompanyId { get; init; }

        // The name of the Company
        [Required]
        public string CompanyName { get; set; }

    }
}
