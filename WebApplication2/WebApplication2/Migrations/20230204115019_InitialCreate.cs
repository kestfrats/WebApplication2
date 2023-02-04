using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41433472-6bb1-4cf6-98d2-e63a57f28f05", "32e358b1-8c13-4825-b4ed-bf1ad7c642e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f2cb4e0-57b8-465f-95b1-240c56ae52fa", "e72bfad1-8117-4965-8a9e-af8e1469a417" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f2cb4e0-57b8-465f-95b1-240c56ae52fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41433472-6bb1-4cf6-98d2-e63a57f28f05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32e358b1-8c13-4825-b4ed-bf1ad7c642e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e72bfad1-8117-4965-8a9e-af8e1469a417");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "264204ab-45f7-4172-ad10-44d02503d2df", "4ee2080a-e585-4624-87b5-acf9058ee1c2", "standart", "STANDART" },
                    { "a34aa39c-198b-4e1b-b618-c6681048cc17", "9214263b-7153-4c41-9148-09188f88a219", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "65bdf8d0-1db9-47bc-91f5-9ef63031246c", 0, "0008da2c-3ae6-46f9-8b6e-6503ecabbb5d", "admin@admin.com", true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENVKZXOtAUMIKsnPUZgW72EC0J3rx1GcPzHq7HwtTO0O3jUyDc2jpw0IGVrqZUBWPg==", null, false, "dc187bf2-4726-4258-8905-20e969e0606e", false, "admin@admin.com" },
                    { "b3a44b42-e780-43b3-a0f0-ff2c571c9183", 0, "bfdee65e-00b5-4a0f-b4cd-ba63346552a2", "standart@standart.com", true, "Standart", "Standart", false, null, "STANDART@STANDART.COM", "STANDART@STANDART.COM", "AQAAAAEAACcQAAAAEIHROZEnSoMcN0ansLJZg7b+8Otim2lHoN0zimkMFA8BQNbnhtFXphDuT/Tm6besaw==", null, false, "f9323acb-6f7b-4f0c-ab01-7d2bf9aec0dc", false, "standart@standart.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "65bdf8d0-1db9-47bc-91f5-9ef63031246c");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a34aa39c-198b-4e1b-b618-c6681048cc17", "65bdf8d0-1db9-47bc-91f5-9ef63031246c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "264204ab-45f7-4172-ad10-44d02503d2df", "b3a44b42-e780-43b3-a0f0-ff2c571c9183" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a34aa39c-198b-4e1b-b618-c6681048cc17", "65bdf8d0-1db9-47bc-91f5-9ef63031246c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "264204ab-45f7-4172-ad10-44d02503d2df", "b3a44b42-e780-43b3-a0f0-ff2c571c9183" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "264204ab-45f7-4172-ad10-44d02503d2df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a34aa39c-198b-4e1b-b618-c6681048cc17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65bdf8d0-1db9-47bc-91f5-9ef63031246c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3a44b42-e780-43b3-a0f0-ff2c571c9183");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f2cb4e0-57b8-465f-95b1-240c56ae52fa", "d4949733-eab0-4fe1-8c6b-390d7dc738c0", "standart", "STANDART" },
                    { "41433472-6bb1-4cf6-98d2-e63a57f28f05", "c0ac9b4f-71b5-4cd0-912e-5a1ac7c61684", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32e358b1-8c13-4825-b4ed-bf1ad7c642e9", 0, "21b49a49-d3ce-4c8f-9169-640b9a5e2e5c", "admin@admin.com", true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOSRI+t7NRN5tk+f/mJKrLRVUse99WD7yCe6+TZKJSxRjSKJHlPNy7SU54srDwl0rA==", null, false, "0af5dc7a-dcd2-4b1a-a496-ce17fe0d1ccb", false, "admin@admin.com" },
                    { "e72bfad1-8117-4965-8a9e-af8e1469a417", 0, "bf42d41e-2164-4139-a0a9-b937f54da48a", "standart@standart.com", true, "Standart", "Standart", false, null, "STANDART@STANDART.COM", "STANDART@STANDART.COM", "AQAAAAEAACcQAAAAEHeEbOhQEPnS3mxf8uPmnx/crsuV9a26Q7qd5L31y6fI5GN/umcrW2d/2h7lLD3nsw==", null, false, "d145a0c7-77ad-4ee4-bda2-c98061703d1d", false, "standart@standart.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "32e358b1-8c13-4825-b4ed-bf1ad7c642e9");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "41433472-6bb1-4cf6-98d2-e63a57f28f05", "32e358b1-8c13-4825-b4ed-bf1ad7c642e9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1f2cb4e0-57b8-465f-95b1-240c56ae52fa", "e72bfad1-8117-4965-8a9e-af8e1469a417" });
        }
    }
}
