using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("34F4249A-E193-4224-B881-43FB15C8DCFB"),
                RoleId = Guid.Parse("A0F0F0F0-90FA-4ECB-8B5C-D50FCDA470E9"),
            },new AppUserRole
            {
                UserId = Guid.Parse("906CF7B6-99AD-49D4-80DD-70B75E6B1DD6"),
                RoleId = Guid.Parse("99CC3570-90FA-4ECB-8B5C-D50FCDA470E9"),
            });
        }
    }
}
