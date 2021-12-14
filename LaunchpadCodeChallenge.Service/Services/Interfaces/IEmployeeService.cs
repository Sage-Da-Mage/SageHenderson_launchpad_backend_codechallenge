using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services.Interfaces
{
    public interface IEmployeeService
    {

        public IEnumerable<Employee> GetAll();


        public IList<Employee> ListAll();

        public Department GetDepartmentById(int id);

    }
}
