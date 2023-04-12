using LeaveManagement.web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            var Hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = "719a0045-ec81-4f30-9fb9-21bc8c01a1bb",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     UserName = "admin@localhost.com",
                     firstname = "System",
                     lastname = "Admin",
                     PasswordHash = Hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },

                 new Employee
                 {
                     Id = "bc0d2fc9-52f7-4cf9-b3a1-6931ffd7da47",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     firstname = "System",
                     lastname = "User",
                     PasswordHash = Hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }
                 );

        }
    }
}