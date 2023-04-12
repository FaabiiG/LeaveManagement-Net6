using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                  new IdentityUserRole<string>
                  {
                      RoleId= "719a0045-ec81-4f30-9f89-21bc8c01a1bb",
                      UserId= "719a0045-ec81-4f30-9fb9-21bc8c01a1bb"
                  },

                   new IdentityUserRole<string>
                   {
                       RoleId = "718a0045-eb81-4f30-9f89-21bc8c01a1bb",
                       UserId = "bc0d2fc9-52f7-4cf9-b3a1-6931ffd7da47"
                   }

                );
        }
    }
}