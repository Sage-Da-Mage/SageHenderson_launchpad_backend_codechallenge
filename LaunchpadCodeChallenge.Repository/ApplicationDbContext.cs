using LaunchpadCodeChallenge.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Repository
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // This is where if I decided to, I could use Fluent API to use finer control over Db setup.
        }

        public DbSet<Employee> Employee { get; set; }



    }
}
