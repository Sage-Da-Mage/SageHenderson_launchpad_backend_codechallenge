using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Company
{
    public class CompanyCreateVM
    {
        [Key]
        public int CompanyId { get; init; }

        [Required]
        public string CompanyName { get; set; }
    }
}
