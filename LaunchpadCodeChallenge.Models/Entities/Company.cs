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
        // The Companies Id, so it can be differenciated
        [Key]
        public int CompanyId { get; init; }

        // The name of the Company
        [Required]
        public string CompanyName { get; set; }

    }
}
