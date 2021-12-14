using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities.VMs.Employee
{
    public class EmployeeVM
    {

        // The default constructor for creating empty EmployeeVMs
        public EmployeeVM()
        {

        }

        // The constructor for creating an EmployeeVM from a Employee Entity
        public EmployeeVM(Entities.Employee src)
        {
            EmployeeId = src.EmployeeId;
            FirstName = src.FirstName;
            LastName = src.LastName;
            JobTitle = src.JobTitle;
            AddressOfResidence = src.AddressOfResidence;
            DepartmentId = src.DepartmentId;
            //Department = src.Department;
        }

        // An employee has an Id differentiating them from other Employees
        // which is unchangable after assignment
        public int EmployeeId { get; init; }

        // An Employee has a FirstName
        public string FirstName { get; set; }

        // An Employee has a LastName
        public string LastName { get; set; }

        // An Employee has a JobTitle
        public string JobTitle { get; set; }

        // An employee has an AddressOfResidence
        public string AddressOfResidence { get; set; }

        // The Id of the Department this employee belongs to
        public int DepartmentId { get; set; }

        // The Department class of the Department the Employee belongs to
        //public Department Department { get; set; }

    }
}
