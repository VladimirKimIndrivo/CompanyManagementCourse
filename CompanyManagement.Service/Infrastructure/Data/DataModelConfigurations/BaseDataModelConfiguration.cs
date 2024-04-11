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
    public class BaseDataModelConfiguration<T> : IEntityTypeConfiguration<BaseDataModel<T>> where T : struct
    {   
        public void Configure(EntityTypeBuilder<BaseDataModel<T>> builder)
        {
            builder.HasKey(b => b.Id);
        }
    }
}
