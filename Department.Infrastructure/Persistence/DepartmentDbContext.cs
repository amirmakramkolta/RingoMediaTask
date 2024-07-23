using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Department.Infrastructure.Persistence
{
    public class DepartmentDbContext : DbContext
    {
        public DepartmentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Core.DomainEnties.Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
    

}
