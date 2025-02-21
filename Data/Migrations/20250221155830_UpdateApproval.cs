using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment_1.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApproval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a977926-eb69-426f-9cac-76b210c26879", "203a30c1-5d45-4752-bfc3-758c78e1551d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "afef018a-6de9-41f8-9072-5ea40ace09d8", "637c8927-9087-4224-b2c7-ca3afaeb5a4c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a977926-eb69-426f-9cac-76b210c26879");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afef018a-6de9-41f8-9072-5ea40ace09d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "203a30c1-5d45-4752-bfc3-758c78e1551d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "637c8927-9087-4224-b2c7-ca3afaeb5a4c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a2d26240-27e2-4833-a4dd-b706fc3657e8", null, new DateTime(2025, 2, 21, 7, 58, 28, 127, DateTimeKind.Local).AddTicks(9787), "Contributor role", "Contributor", "CONTRIBUTOR" },
                    { "ed9f131a-b508-438e-a2b0-da7594be0635", null, new DateTime(2025, 2, 21, 7, 58, 28, 126, DateTimeKind.Local).AddTicks(4794), "Admin role", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "23c8ad8c-2ba6-436a-a27d-35e50eb5880f", 0, "64dd8679-e8e5-4c65-8c21-26592df19537", "c@c.c", true, "Cindy", "Cain", false, null, "C@C.C", "C@C.C", "AQAAAAIAAYagAAAAEAr5l4xd3u8PcpYth7/9yiSqYHToY8s9z6tkOOEDIbsOMDBFI9Hnf8EZtp54aUbBCQ==", null, false, "f945af48-16ba-4ebc-a2cf-376967665eb5", false, "c@c.c" },
                    { "eb28ecce-5b4a-464f-a840-be132abd8c21", 0, "b37eba6f-0429-4b34-b095-39b982702eac", "a@a.a", true, "Adam", "Anderson", false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEBUtxPOXITIOeX0/M4bs3t6U2zeSxTOa/Z7Km84L7cOPT4WtvifTNeV/Xrwl8srMdQ==", null, false, "9796b0a4-5b71-4e16-b970-4bfd41481755", false, "a@a.a" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a2d26240-27e2-4833-a4dd-b706fc3657e8", "23c8ad8c-2ba6-436a-a27d-35e50eb5880f" },
                    { "ed9f131a-b508-438e-a2b0-da7594be0635", "eb28ecce-5b4a-464f-a840-be132abd8c21" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2d26240-27e2-4833-a4dd-b706fc3657e8", "23c8ad8c-2ba6-436a-a27d-35e50eb5880f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed9f131a-b508-438e-a2b0-da7594be0635", "eb28ecce-5b4a-464f-a840-be132abd8c21" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2d26240-27e2-4833-a4dd-b706fc3657e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed9f131a-b508-438e-a2b0-da7594be0635");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23c8ad8c-2ba6-436a-a27d-35e50eb5880f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb28ecce-5b4a-464f-a840-be132abd8c21");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a977926-eb69-426f-9cac-76b210c26879", null, new DateTime(2025, 2, 20, 18, 28, 2, 938, DateTimeKind.Local).AddTicks(4803), "Admin role", "Admin", "ADMIN" },
                    { "afef018a-6de9-41f8-9072-5ea40ace09d8", null, new DateTime(2025, 2, 20, 18, 28, 2, 939, DateTimeKind.Local).AddTicks(8050), "Contributor role", "Contributor", "CONTRIBUTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "203a30c1-5d45-4752-bfc3-758c78e1551d", 0, "b1407843-c3ff-4164-a7f7-88af91e312ea", "a@a.a", true, "Adam", "Anderson", false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEG9oyvEw9kpgAL6nZJZdWds6gxaBIbIH/jbkoGdA67kuSao4DVxsK1bScyqzj+otcg==", null, false, "6872cc61-6bcc-4722-822d-9b4c0890a2fd", false, "a@a.a" },
                    { "637c8927-9087-4224-b2c7-ca3afaeb5a4c", 0, "0cd36e9f-cd07-4cf8-9eba-da0d5b03d025", "c@c.c", true, "Cindy", "Cain", false, null, "C@C.C", "C@C.C", "AQAAAAIAAYagAAAAED4a8iwMMkxYf8tFAz4zGNjneVWiwQlv4VsBnpL7xS/Zx+kqUDtANuFSzOA8Bc7gQw==", null, false, "5cd3abf7-df98-4dbb-877d-5ab0a8a0a42b", false, "c@c.c" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a977926-eb69-426f-9cac-76b210c26879", "203a30c1-5d45-4752-bfc3-758c78e1551d" },
                    { "afef018a-6de9-41f8-9072-5ea40ace09d8", "637c8927-9087-4224-b2c7-ca3afaeb5a4c" }
                });
        }
    }
}
