using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Company
{
    // The difference between this file and CompanyCreateVM is that
    // this file lacks CompanyId since that shouldn't be updated
    public class CompanyUpdateVM
    {

        [Required]
        public string CompanyName { get; set; }

    }
}
