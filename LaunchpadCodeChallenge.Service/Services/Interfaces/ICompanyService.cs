﻿using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Service.Services.Interfaces
{
    interface ICompanyService
    {
        public IEnumerable<Company> GetAll();

        public IList<Company> ListAll();
    }
}
