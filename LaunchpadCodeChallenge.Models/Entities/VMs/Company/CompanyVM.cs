using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Company
{
    public class CompanyVM
    {

        // The default constructor for createing an empty CompanyVm
        public CompanyVM()
        {

        }

        // The Constructor for generating a CompanyVM from a Company Entity
        public CompanyVM(Entities.Company src)
        {
            CompanyId = src.CompanyId;
            CompanyName = src.CompanyName;
        }

        public int CompanyId { get; init; }

        public string CompanyName { get; set; }


    }
}
