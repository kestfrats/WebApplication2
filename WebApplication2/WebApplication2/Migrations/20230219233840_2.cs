using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleHashtags");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "99cc72a1-a964-428f-a950-95efb652ed38", "17f6b63e-a9a2-410e-ab66-20e64d810b8a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b166dc25-c49c-4820-83fa-042a595a9eb0", "d70c94fd-f0f6-4ce9-b403-164abf919d46" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99cc72a1-a964-428f-a950-95efb652ed38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b166dc25-c49c-4820-83fa-042a595a9eb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17f6b63e-a9a2-410e-ab66-20e64d810b8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d70c94fd-f0f6-4ce9-b403-164abf919d46");

            migrationBuilder.CreateTable(
                name: "ArticleHashtag",
                columns: table => new
                {
                    ArticlesID = table.Column<int>(type: "int", nullable: false),
                    HashtagsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleHashtag", x => new { x.ArticlesID, x.HashtagsID });
                    table.ForeignKey(
                        name: "FK_ArticleHashtag_Articles_ArticlesID",
                        column: x => x.ArticlesID,
                        principalTable: "Articles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleHashtag_Hashtags_HashtagsID",
                        column: x => x.HashtagsID,
                        principalTable: "Hashtags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c7c5530-c7bf-4f47-bb92-52f9d90a2c2b", "76cf4659-e87f-43fd-b2a6-4a6209613905", "standart", "STANDART" },
                    { "78df1d2b-c6bc-436b-a00c-376852109c68", "bed7cf4d-004d-4fda-82e6-0d61a2305d5e", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7613dd91-60fe-4746-b910-1894c63c4309", 0, "5549b5d2-ca2f-480f-a16b-710fa6ee87cc", "standart@standart.com", true, "Standart", "Standart", false, null, "STANDART@STANDART.COM", "STANDART@STANDART.COM", "AQAAAAEAACcQAAAAEE6DkZxJo4XqgrPlOlb2JI15hFYnfCXAH7wQfXFqGeOHT+eznfj6FMcEkanI8xrrxQ==", null, false, "f39e9280-3e1b-428e-b506-6d1594c8f110", false, "standart@standart.com" },
                    { "e67148cb-6179-4120-9bb5-6650a9a44782", 0, "a72b87dd-a671-4950-b12f-8a89cf07462d", "admin@admin.com", true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEAlN4q7KMNmPVSAt2rev/5d6LXK+HvqgWVV+HPDSDW/ZV9f34cGz9iYAiGpF4RN/RA==", null, false, "00b26a51-2140-4792-98ff-b48ed0657be9", false, "admin@admin.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "e67148cb-6179-4120-9bb5-6650a9a44782");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c7c5530-c7bf-4f47-bb92-52f9d90a2c2b", "7613dd91-60fe-4746-b910-1894c63c4309" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "78df1d2b-c6bc-436b-a00c-376852109c68", "e67148cb-6179-4120-9bb5-6650a9a44782" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleHashtag_HashtagsID",
                table: "ArticleHashtag",
                column: "HashtagsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleHashtag");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c7c5530-c7bf-4f47-bb92-52f9d90a2c2b", "7613dd91-60fe-4746-b910-1894c63c4309" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78df1d2b-c6bc-436b-a00c-376852109c68", "e67148cb-6179-4120-9bb5-6650a9a44782" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c7c5530-c7bf-4f47-bb92-52f9d90a2c2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78df1d2b-c6bc-436b-a00c-376852109c68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7613dd91-60fe-4746-b910-1894c63c4309");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e67148cb-6179-4120-9bb5-6650a9a44782");

            migrationBuilder.CreateTable(
                name: "ArticleHashtags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleID = table.Column<int>(type: "int", nullable: false),
                    HashtagID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleHashtags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArticleHashtags_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleHashtags_Hashtags_HashtagID",
                        column: x => x.HashtagID,
                        principalTable: "Hashtags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "99cc72a1-a964-428f-a950-95efb652ed38", "b606caed-7d8c-47a1-9ce0-f506e2a82490", "admin", "ADMIN" },
                    { "b166dc25-c49c-4820-83fa-042a595a9eb0", "a24618f3-b886-4085-b2bc-cbad2fc710d1", "standart", "STANDART" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17f6b63e-a9a2-410e-ab66-20e64d810b8a", 0, "63da39b5-3747-4d4f-bf61-4569e8fee4cd", "admin@admin.com", true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEK7gl6Pfglc8yczHx72z2Qi8kIYE9HnWmAqpi6sPsHWhlvfeubR7GEWfezpoXIBAiA==", null, false, "38aff21a-10a3-46e2-b1f0-56c529103157", false, "admin@admin.com" },
                    { "d70c94fd-f0f6-4ce9-b403-164abf919d46", 0, "8b96915d-1990-4b69-8f7c-3e0436030269", "standart@standart.com", true, "Standart", "Standart", false, null, "STANDART@STANDART.COM", "STANDART@STANDART.COM", "AQAAAAEAACcQAAAAEKYPEBP1G42iFFcvoHRCGzWx+5R+0fc4Rle8atY4M0HuHJD3uuxqboPB8zGi41H8LQ==", null, false, "47b9e225-1526-410f-8c98-6affafea8b1c", false, "standart@standart.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "17f6b63e-a9a2-410e-ab66-20e64d810b8a");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "99cc72a1-a964-428f-a950-95efb652ed38", "17f6b63e-a9a2-410e-ab66-20e64d810b8a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b166dc25-c49c-4820-83fa-042a595a9eb0", "d70c94fd-f0f6-4ce9-b403-164abf919d46" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleHashtags_ArticleID",
                table: "ArticleHashtags",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleHashtags_HashtagID",
                table: "ArticleHashtags",
                column: "HashtagID");
        }
    }
}
