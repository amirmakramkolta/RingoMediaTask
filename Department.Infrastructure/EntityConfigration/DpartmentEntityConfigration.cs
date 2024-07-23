using Department.Core.DomainEnties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Infrastructure.EntityConfigration
{
    public class DpartmentEntityConfigration : IEntityTypeConfiguration<Core.DomainEnties.Department>
    {
        public void Configure(EntityTypeBuilder<Core.DomainEnties.Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.ParentDpartmentId).IsRequired(false);
            builder.HasOne(x => x.ParentDepartment)
                .WithMany(x => x.ChildDepartment)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(x => x.ParentDpartmentId);
        }
    }
}
