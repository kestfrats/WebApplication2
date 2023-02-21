using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a64418bc-45bb-42c5-9bf7-397afb8b8653", "402edbfc-aad5-4175-892c-5ae42c6eec65" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df5f7712-da84-4a8a-8d4f-5de54bc669af", "4322b9bf-b1c0-41db-9023-05006b4b371b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a64418bc-45bb-42c5-9bf7-397afb8b8653");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df5f7712-da84-4a8a-8d4f-5de54bc669af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "402edbfc-aad5-4175-892c-5ae42c6eec65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4322b9bf-b1c0-41db-9023-05006b4b371b");

            migrationBuilder.DropColumn(
                name: "OrginalClicks",
                table: "HashtagsStatistics");

            migrationBuilder.DropColumn(
                name: "OrginalClicks",
                table: "ArticleStatistics");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0aaa8177-6f8b-43a3-80bf-7943a8eb3b8f", "e958aba1-1a2a-48a2-93af-d22213fe28a7", "admin", "ADMIN" },
                    { "4be327c4-b45d-47c6-9281-7b70d006a641", "7345d3df-a6fe-40b5-bc21-8492bc3fad5c", "standart", "STANDART" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2bc1e13a-b43a-4833-bd81-a6612d4913c9", 0, "8eae30e2-8ce7-4db4-9f9a-b666df5710e5", "standart@standart.com", true, "Standart", "Standart", false, null, "STANDART@STANDART.COM", "STANDART@STANDART.COM", "AQAAAAEAACcQAAAAEGPEOBPL69hchv+q8W5AGV5zqd6el6GAB/UKVTUeTroTEALbN2FDhwVVOTiZS+YZ/Q==", null, false, "09ade845-dddd-4967-ad57-68fc5a5aa8db", false, "standart@standart.com" },
                    { "552009e3-12da-4dd7-989e-84524c6d7cf6", 0, "d48474a5-6ebc-4284-bab2-c2fab2876cfc", "admin@admin.com", true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEN3tc1XFUzxF0ybJNfL4aVg4FPhjk15AMhSlwPLKWuU1qDmhxS0sacgDIaTS9+vstg==", null, false, "de2db0d2-f273-4ab9-982a-15e4ef558afc", false, "admin@admin.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "552009e3-12da-4dd7-989e-84524c6d7cf6");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4be327c4-b45d-47c6-9281-7b70d006a641", "2bc1e13a-b43a-4833-bd81-a6612d4913c9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0aaa8177-6f8b-43a3-80bf-7943a8eb3b8f", "552009e3-12da-4dd7-989e-84524c6d7cf6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4be327c4-b45d-47c6-9281-7b70d006a641", "2bc1e13a-b43a-4833-bd81-a6612d4913c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0aaa8177-6f8b-43a3-80bf-7943a8eb3b8f", "552009e3-12da-4dd7-989e-84524c6d7cf6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0aaa8177-6f8b-43a3-80bf-7943a8eb3b8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4be327c4-b45d-47c6-9281-7b70d006a641");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bc1e13a-b43a-4833-bd81-a6612d4913c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "552009e3-12da-4dd7-989e-84524c6d7cf6");

            migrationBuilder.AddColumn<int>(
                name: "OrginalClicks",
                table: "HashtagsStatistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrginalClicks",
                table: "ArticleStatistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a64418bc-45bb-42c5-9bf7-397afb8b8653", "1b87c3b0-ad14-4c45-b721-e129ce7566b8", "admin", "ADMIN" },
                    { "df5f7712-da84-4a8a-8d4f-5de54bc669af", "52393ed9-ea47-4255-8f07-a7449fd3e331", "standart", "STANDART" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "402edbfc-aad5-4175-892c-5ae42c6eec65", 0, "2e85e402-f8b5-47ab-9006-c0574695724d", "admin@admin.com", true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEMeGctYKVBygYnV6/Q0MY8nQh81SKkWBUYYHSINy5WifrxJGFABfw0WxFfOTfCSEag==", null, false, "bb55809a-29c8-4d6f-b3b9-5ed6c3dac6cf", false, "admin@admin.com" },
                    { "4322b9bf-b1c0-41db-9023-05006b4b371b", 0, "6ac97e98-32c5-4885-bea6-25371181078e", "standart@standart.com", true, "Standart", "Standart", false, null, "STANDART@STANDART.COM", "STANDART@STANDART.COM", "AQAAAAEAACcQAAAAEGIQU3zMcOETp19Cqcqai50j4hSvD2mlINu3lHoSmVk7W+h6vdghXj4gan+SOV836g==", null, false, "fb8c422d-663b-4a67-a959-ca640304b789", false, "standart@standart.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "402edbfc-aad5-4175-892c-5ae42c6eec65");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a64418bc-45bb-42c5-9bf7-397afb8b8653", "402edbfc-aad5-4175-892c-5ae42c6eec65" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "df5f7712-da84-4a8a-8d4f-5de54bc669af", "4322b9bf-b1c0-41db-9023-05006b4b371b" });
        }
    }
}
