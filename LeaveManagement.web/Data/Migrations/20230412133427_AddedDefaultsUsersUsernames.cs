using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddedDefaultsUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "718a0045-eb81-4f30-9f89-21bc8c01a1bb",
                column: "ConcurrencyStamp",
                value: "59ec849b-d43d-459b-84c1-07b5ed8d63bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "719a0045-ec81-4f30-9f89-21bc8c01a1bb",
                column: "ConcurrencyStamp",
                value: "36a11180-7e74-4f8d-aaeb-56236af8ce72");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "719a0045-ec81-4f30-9fb9-21bc8c01a1bb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3412ca8-1d1e-430f-83cc-6ac8a8862aec", "AQAAAAEAACcQAAAAEOAwc8Z6etF4c8C4m79PPRlvJ2vPHeeIS0PUNrzkd9vSpFdHCBTxIV8DGaZ7OOoPmA==", "e4c9ebb1-d367-451b-97d8-4518fe91391f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc0d2fc9-52f7-4cf9-b3a1-6931ffd7da47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76843a62-931f-4762-98a8-3effe2ae059b", "AQAAAAEAACcQAAAAEOO09j6C1eMZpHSUeFMukpb2CqkymacxffDblwocWMbDGOifwrReoOojxIJ52uYXpw==", "84cd4742-2b5c-46a8-af42-c2b8c360acb5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "718a0045-eb81-4f30-9f89-21bc8c01a1bb",
                column: "ConcurrencyStamp",
                value: "3df87a47-7ad5-4ab0-a378-9f4c8a354b82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "719a0045-ec81-4f30-9f89-21bc8c01a1bb",
                column: "ConcurrencyStamp",
                value: "00cd884e-ee65-41b2-a02c-3d339f0b64f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "719a0045-ec81-4f30-9fb9-21bc8c01a1bb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c4c9a73-9ba5-445b-a90d-4b08b93cff09", "AQAAAAEAACcQAAAAELH1jLC7Tr58gn45zLuz7SCYfh6i3UN7ojfjDt2zpLNfA3mB8RurIxvvt1NBDWMC6Q==", "890ccd01-fef4-4445-803f-06a7dd16ec2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc0d2fc9-52f7-4cf9-b3a1-6931ffd7da47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed287954-5404-4fa7-b871-452561f04ae6", "AQAAAAEAACcQAAAAEGDuHp+7vIz1IfrKeJbj0eMFzZU0sN3088iqI5TyyNmJEie2uidqeUGIGa0jSVSd7g==", "97b8434d-f68a-4e75-96bb-e2da17711911" });
        }
    }
}
