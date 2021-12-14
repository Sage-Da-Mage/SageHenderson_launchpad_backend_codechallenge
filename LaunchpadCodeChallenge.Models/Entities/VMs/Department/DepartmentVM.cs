using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Department
{
    public class DepartmentVM
    {

        // The default constructor for creating empty DepartmentVM
        public DepartmentVM()
        {

        }

        // The Constructor for generating a DepartmentVM from a Department Entity
        public DepartmentVM(Entities.Department src)
        {
            DepartmentId = src.DepartmentId;
            DepartmentName = src.DepartmentName;
            UniqueDepartmentAddress = src.UniqueDepartmentAddress;
            CompanyId = src.CompanyId;
 
        }

        // A Department has an Id differentiating them from other Employees
        // which is unchangable after assignment
        public int DepartmentId { get; init; }

        // An Employee has a FirstName
        public string DepartmentName { get; set; }

        // An Employee has a LastName
        public string UniqueDepartmentAddress { get; set; }

        // An Employee has a JobTitle
        public int CompanyId { get; set; }


        // The Company class of the Company the Department belongs to
        //public Company Company { get; set; }



    }
}
