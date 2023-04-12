using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddDefaultsUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "718a0045-eb81-4f30-9f89-21bc8c01a1bb", "3df87a47-7ad5-4ab0-a378-9f4c8a354b82", "User", "USER" },
                    { "719a0045-ec81-4f30-9f89-21bc8c01a1bb", "00cd884e-ee65-41b2-a02c-3d339f0b64f4", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateJoined", "dateOfBirth", "firstname", "lastname", "taxId" },
                values: new object[,]
                {
                    { "719a0045-ec81-4f30-9fb9-21bc8c01a1bb", 0, "9c4c9a73-9ba5-445b-a90d-4b08b93cff09", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELH1jLC7Tr58gn45zLuz7SCYfh6i3UN7ojfjDt2zpLNfA3mB8RurIxvvt1NBDWMC6Q==", null, false, "890ccd01-fef4-4445-803f-06a7dd16ec2b", false, "admin@localhost.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", "Admin", null },
                    { "bc0d2fc9-52f7-4cf9-b3a1-6931ffd7da47", 0, "ed287954-5404-4fa7-b871-452561f04ae6", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGDuHp+7vIz1IfrKeJbj0eMFzZU0sN3088iqI5TyyNmJEie2uidqeUGIGa0jSVSd7g==", null, false, "97b8434d-f68a-4e75-96bb-e2da17711911", false, "user@localhost.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "719a0045-ec81-4f30-9f89-21bc8c01a1bb", "719a0045-ec81-4f30-9fb9-21bc8c01a1bb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "718a0045-eb81-4f30-9f89-21bc8c01a1bb", "bc0d2fc9-52f7-4cf9-b3a1-6931ffd7da47" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "719a0045-ec81-4f30-9f89-21bc8c01a1bb", "719a0045-ec81-4f30-9fb9-21bc8c01a1bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "718a0045-eb81-4f30-9f89-21bc8c01a1bb", "bc0d2fc9-52f7-4cf9-b3a1-6931ffd7da47" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "718a0045-eb81-4f30-9f89-21bc8c01a1bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "719a0045-ec81-4f30-9f89-21bc8c01a1bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "719a0045-ec81-4f30-9fb9-21bc8c01a1bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc0d2fc9-52f7-4cf9-b3a1-6931ffd7da47");
        }
    }
}
