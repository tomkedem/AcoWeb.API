﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AcoWeb.API.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleInCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HiredDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    OfficeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { new Guid("170ff47b-290a-4b22-acf7-8e265afeafb5"), "	876 Chicago Avenue", "Lindsay" },
                    { new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"), "1492 Brentwood Drive", "Oscar" },
                    { new Guid("7c862b39-c6d1-4c91-8181-c6cc35890bca"), "1477 Liberty Street", "WASHINGTON" },
                    { new Guid("99bc7e9d-9033-4752-a3db-a577447a7df3"), "1698 Brown Street d", "Payson" },
                    { new Guid("a228f20b-7458-4a8c-95ba-4b209965d677"), "1641 Granville Lane", "Newark" },
                    { new Guid("ca2abc8e-1bdc-4887-8f97-215fe050f22f"), "3406 Thrash Trail", "Maud" },
                    { new Guid("d097a599-4619-4473-ae86-d353c3069597"), "784 Byers Lanet", "Redding" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FullName", "HiredDate", "OfficeId", "RoleInCompany", "Salary" },
                values: new object[,]
                {
                    { new Guid("217cfe3f-f278-4ce8-84de-d9d523ca3802"), "Diane E Perry", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 3, 0, 0, 0)), new Guid("d097a599-4619-4473-ae86-d353c3069597"), "Sellman", 100000m },
                    { new Guid("270ed53a-053b-442a-9302-716959d0a51a"), "Kristi C Mauricio", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 3, 0, 0, 0)), new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"), "Credit officer", 200000m },
                    { new Guid("3675f42d-9bbb-488f-bd36-c7e6411c87d5"), "Crystal F Krupa", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1927), new TimeSpan(0, 3, 0, 0, 0)), new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"), "Developer", 420000m },
                    { new Guid("4fa3169e-0779-45cc-9139-dc4ee92cbd5f"), "Colton R Minton", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1922), new TimeSpan(0, 3, 0, 0, 0)), new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"), "Backend developer", 190000m },
                    { new Guid("532c9736-4fb6-4a4d-aa8f-e7a2d6a4ca49"), "Sarah R Crews", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1968), new TimeSpan(0, 3, 0, 0, 0)), new Guid("d097a599-4619-4473-ae86-d353c3069597"), "Sellman", 240000m },
                    { new Guid("5c0bd7ac-a87b-4e92-81bb-14de6fdc6808"), "Bart J Burgess", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 3, 0, 0, 0)), new Guid("d097a599-4619-4473-ae86-d353c3069597"), "Credit officer", 250000m },
                    { new Guid("6978cc16-5f5a-4020-bb79-4cc4dcc36b72"), "Antonio P Summers", new DateTimeOffset(new DateTime(2018, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, 3, 0, 0, 0)), new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"), "Manager", 200000m },
                    { new Guid("8588c7bf-2bd4-436a-a1fc-9c790895b9d5"), "Rhonda R Macklin", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 3, 0, 0, 0)), new Guid("ca2abc8e-1bdc-4887-8f97-215fe050f22f"), "Backend developer", 190000m },
                    { new Guid("85cbcd1f-8b72-4398-b2fe-b2776ab0be0f"), "Jessica R Gibbs", new DateTimeOffset(new DateTime(2018, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, 3, 0, 0, 0)), new Guid("ca2abc8e-1bdc-4887-8f97-215fe050f22f"), "Manager", 200000m },
                    { new Guid("b1ee8f72-0cc0-4cd9-bcc6-11183cf24da8"), "Thomas D Spates", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 3, 0, 0, 0)), new Guid("7c862b39-c6d1-4c91-8181-c6cc35890bca"), "Sellman", 200000m },
                    { new Guid("c3f4100c-f746-467b-ab9e-4c16361a44af"), "Willie M Overton", new DateTimeOffset(new DateTime(2018, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1954), new TimeSpan(0, 3, 0, 0, 0)), new Guid("ca2abc8e-1bdc-4887-8f97-215fe050f22f"), "Head Of Developers", 12500000m },
                    { new Guid("c5dceee6-ab09-42ab-bc30-cb0e91114b3d"), "Candy J Gilbert", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1944), new TimeSpan(0, 3, 0, 0, 0)), new Guid("7c862b39-c6d1-4c91-8181-c6cc35890bca"), "Web developer", 500000m },
                    { new Guid("d11d3a8d-30b6-4b3a-ad9b-ab2141a2f6bb"), "Gary E Owens", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1958), new TimeSpan(0, 3, 0, 0, 0)), new Guid("d097a599-4619-4473-ae86-d353c3069597"), "Sellman", 100000m },
                    { new Guid("d447d3e9-82d3-4aba-80ae-223a6683f5c3"), "Pattie L Foster", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 3, 0, 0, 0)), new Guid("7c862b39-c6d1-4c91-8181-c6cc35890bca"), "Sellman", 400000m },
                    { new Guid("ea3a236e-fda4-4e3f-ae1d-3bd3a535a177"), "Caitlin J Nicholson", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1930), new TimeSpan(0, 3, 0, 0, 0)), new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"), "Sellman", 100000m },
                    { new Guid("f3ad3974-0c05-4db0-bda0-dee18f00a291"), "Catherine J Easley", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, 3, 0, 0, 0)), new Guid("d097a599-4619-4473-ae86-d353c3069597"), "Web developer", 100000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_OfficeId",
                table: "Employees",
                column: "OfficeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
