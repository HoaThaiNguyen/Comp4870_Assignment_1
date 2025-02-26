using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment_1.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53d09e80-5fad-45dc-b043-160c82e244e6", "07279eb2-88f1-4897-a608-3495010873e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "450d73a9-a795-46e2-b52d-2fec49196eff", "77fff10a-18ca-4f0d-b6b1-2b9d8502a2aa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "450d73a9-a795-46e2-b52d-2fec49196eff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53d09e80-5fad-45dc-b043-160c82e244e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07279eb2-88f1-4897-a608-3495010873e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77fff10a-18ca-4f0d-b6b1-2b9d8502a2aa");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 25, 20, 50, 22, 633, DateTimeKind.Local).AddTicks(2734), new DateTime(2025, 3, 4, 20, 50, 22, 633, DateTimeKind.Local).AddTicks(2734), new DateTime(2025, 2, 25, 20, 50, 22, 633, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bcab97de-ad0b-47bc-8fdd-04e90b5c1f66", null, new DateTime(2025, 2, 25, 20, 50, 22, 509, DateTimeKind.Local).AddTicks(813), "Admin role", "Admin", "ADMIN" },
                    { "c462939e-b10b-4252-9556-1783c3980155", null, new DateTime(2025, 2, 25, 20, 50, 22, 510, DateTimeKind.Local).AddTicks(5338), "Contributor role", "Contributor", "CONTRIBUTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsApproved", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c0a1bd7-1e51-4d37-838b-36f1c4f0fab1", 0, "12f58260-8149-42f9-894e-e6eed429976e", "a@a.a", true, "Adam", true, "Anderson", false, null, "A@A.A", "A@A.A", "P@$$w0rd", "AQAAAAIAAYagAAAAENhvFARAhMFJlxqpEt7RRnpGfqasTjvwhjlOSr2jBXIBMfW7B7Mcg/KeOnmVR9MfYQ==", null, false, "8072dc32-f21c-4c54-9135-95a64e0c5525", false, "a@a.a" },
                    { "bff07d44-135b-4915-9806-28b0c4d089ce", 0, "74d41e72-ddb3-44b8-8e7c-7d0f0dda258b", "c@c.c", true, "Cindy", true, "Cain", false, null, "C@C.C", "C@C.C", "P@$$w0rd", "AQAAAAIAAYagAAAAEPAEhqwx0HgWx+ZwSuYyFYbDhA38YtwOslUJjw9hdMMedIgKhz5cPNcneoAtbs0Otg==", null, false, "ea9419d3-746a-4ce8-90fe-1e3fd93de3e0", false, "c@c.c" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bcab97de-ad0b-47bc-8fdd-04e90b5c1f66", "1c0a1bd7-1e51-4d37-838b-36f1c4f0fab1" },
                    { "c462939e-b10b-4252-9556-1783c3980155", "bff07d44-135b-4915-9806-28b0c4d089ce" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bcab97de-ad0b-47bc-8fdd-04e90b5c1f66", "1c0a1bd7-1e51-4d37-838b-36f1c4f0fab1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c462939e-b10b-4252-9556-1783c3980155", "bff07d44-135b-4915-9806-28b0c4d089ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcab97de-ad0b-47bc-8fdd-04e90b5c1f66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c462939e-b10b-4252-9556-1783c3980155");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c0a1bd7-1e51-4d37-838b-36f1c4f0fab1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bff07d44-135b-4915-9806-28b0c4d089ce");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 52, 17, 987, DateTimeKind.Local).AddTicks(3267), new DateTime(2025, 3, 1, 7, 52, 17, 987, DateTimeKind.Local).AddTicks(3267), new DateTime(2025, 2, 22, 7, 52, 17, 987, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "450d73a9-a795-46e2-b52d-2fec49196eff", null, new DateTime(2025, 2, 22, 7, 52, 17, 872, DateTimeKind.Local).AddTicks(1585), "Admin role", "Admin", "ADMIN" },
                    { "53d09e80-5fad-45dc-b043-160c82e244e6", null, new DateTime(2025, 2, 22, 7, 52, 17, 873, DateTimeKind.Local).AddTicks(5162), "Contributor role", "Contributor", "CONTRIBUTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsApproved", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07279eb2-88f1-4897-a608-3495010873e2", 0, "36713f9e-24e5-42ae-b955-f8be55ec89a7", "c@c.c", true, "Cindy", true, "Cain", false, null, "C@C.C", "C@C.C", "P@$$w0rd", "AQAAAAIAAYagAAAAEE6KeaLMXJy8SdzdrW1FRAK9wV63iQedvhRuaOnaGj01K9BqV6UFYmGmZF6dH8+nmw==", null, false, "ec301f2e-3fea-4d35-8359-7e1fff24717a", false, "c@c.c" },
                    { "77fff10a-18ca-4f0d-b6b1-2b9d8502a2aa", 0, "2045cc10-6c8e-4050-a103-a647442cf347", "a@a.a", true, "Adam", true, "Anderson", false, null, "A@A.A", "A@A.A", "P@$$w0rd", "AQAAAAIAAYagAAAAEJxnc6+cFEzCQNA+rP258NDmikMJEA8Bt/gJC7CB8naoBNNp79vXdhpJOff8bTjN5A==", null, false, "79656213-48ef-472a-b963-fa40d33bdb3a", false, "a@a.a" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "53d09e80-5fad-45dc-b043-160c82e244e6", "07279eb2-88f1-4897-a608-3495010873e2" },
                    { "450d73a9-a795-46e2-b52d-2fec49196eff", "77fff10a-18ca-4f0d-b6b1-2b9d8502a2aa" }
                });
        }
    }
}
