using LeaveManagement.web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {

            builder.HasData(
                new IdentityRole
                {
                    Id = "719a0045-ec81-4f30-9f89-21bc8c01a1bb",
                    Name = "Administrator",
                    NormalizedName = Role.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "718a0045-eb81-4f30-9f89-21bc8c01a1bb",
                    Name = "User",
                    NormalizedName = Role.User.ToUpper()
                }
            ) ;
            
        }
    }
}