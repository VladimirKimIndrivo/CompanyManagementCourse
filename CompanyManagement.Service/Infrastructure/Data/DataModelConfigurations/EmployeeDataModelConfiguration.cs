using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagement.Service.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyManagement.Service.Infrastructure.Data.DataModelConfigurations
{
    public class EmployeeDataModelConfiguration : IEntityTypeConfiguration<EmployeeDataModel>
    {
        public void Configure(EntityTypeBuilder<EmployeeDataModel> builder)
        {
            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(70);

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(70);
        }
    }
}
