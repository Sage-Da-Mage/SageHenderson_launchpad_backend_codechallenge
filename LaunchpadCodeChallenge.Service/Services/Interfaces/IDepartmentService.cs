using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadCodeChallenge.Service.Services.Interfaces
{
    public interface IDepartmentService
    {

        public IEnumerable<Department> GetAll();


        public IList<Department> GetList();


    }
}
