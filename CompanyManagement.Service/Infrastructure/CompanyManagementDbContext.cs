using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagement.Service.Domain;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.Service.Infrastructure
{
    public class CompanyManagementDbContext : DbContext
    {
        public DbSet<EmployeeDataModel> Employees { get; }  
        public CompanyManagementDbContext(DbContextOptions<CompanyManagementDbContext> options) : base(options)
        {   
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyManagementDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                switch (entry.Entity)
                {
                    case BaseDataModel<Guid> tracker:
                        switch (entry.State)
                        {
                            case EntityState.Added:
                                tracker.CreatedAt = DateTimeOffset.Now;
                                tracker.ModifiedAt = DateTimeOffset.Now;    
                                break;
                            case EntityState.Modified:
                                tracker.ModifiedAt = DateTimeOffset.Now;
                                break;
                        }
                    break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
