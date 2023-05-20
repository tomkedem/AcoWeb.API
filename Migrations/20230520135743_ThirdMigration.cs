using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcoWeb.API.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "HiredDate",
                table: "Employees",
                newName: "HireDate");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("217cfe3f-f278-4ce8-84de-d9d523ca3802"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Diane", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Perry" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("270ed53a-053b-442a-9302-716959d0a51a"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Kristi", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Mauricio" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3675f42d-9bbb-488f-bd36-c7e6411c87d5"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Crystal", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Krupa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4fa3169e-0779-45cc-9139-dc4ee92cbd5f"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Colton", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Minton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("532c9736-4fb6-4a4d-aa8f-e7a2d6a4ca49"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Sarah", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Crews" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5c0bd7ac-a87b-4e92-81bb-14de6fdc6808"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Bart", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Burgess" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6978cc16-5f5a-4020-bb79-4cc4dcc36b72"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Antonio", new DateTimeOffset(new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "P Summers" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8588c7bf-2bd4-436a-a1fc-9c790895b9d5"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Rhonda", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Macklin" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("85cbcd1f-8b72-4398-b2fe-b2776ab0be0f"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Jessica", new DateTimeOffset(new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Gibbs" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b1ee8f72-0cc0-4cd9-bcc6-11183cf24da8"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Thomas", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Spates" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c3f4100c-f746-467b-ab9e-4c16361a44af"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Willie", new DateTimeOffset(new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Overton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c5dceee6-ab09-42ab-bc30-cb0e91114b3d"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Candy", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Gilbert" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d11d3a8d-30b6-4b3a-ad9b-ab2141a2f6bb"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Gary", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Owens" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d447d3e9-82d3-4aba-80ae-223a6683f5c3"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Pattie", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Foster" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ea3a236e-fda4-4e3f-ae1d-3bd3a535a177"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Caitlin", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Nicholson" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f3ad3974-0c05-4db0-bda0-dee18f00a291"),
                columns: new[] { "FirstName", "HireDate", "LastName" },
                values: new object[] { "Catherine", new DateTimeOffset(new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Easley" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "HireDate",
                table: "Employees",
                newName: "HiredDate");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("217cfe3f-f278-4ce8-84de-d9d523ca3802"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Diane E Perry", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("270ed53a-053b-442a-9302-716959d0a51a"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Kristi C Mauricio", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2433), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3675f42d-9bbb-488f-bd36-c7e6411c87d5"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Crystal F Krupa", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2426), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4fa3169e-0779-45cc-9139-dc4ee92cbd5f"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Colton R Minton", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("532c9736-4fb6-4a4d-aa8f-e7a2d6a4ca49"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Sarah R Crews", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2466), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5c0bd7ac-a87b-4e92-81bb-14de6fdc6808"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Bart J Burgess", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6978cc16-5f5a-4020-bb79-4cc4dcc36b72"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Antonio P Summers", new DateTimeOffset(new DateTime(2018, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2358), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8588c7bf-2bd4-436a-a1fc-9c790895b9d5"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Rhonda R Macklin", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2449), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("85cbcd1f-8b72-4398-b2fe-b2776ab0be0f"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Jessica R Gibbs", new DateTimeOffset(new DateTime(2018, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b1ee8f72-0cc0-4cd9-bcc6-11183cf24da8"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Thomas D Spates", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c3f4100c-f746-467b-ab9e-4c16361a44af"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Willie M Overton", new DateTimeOffset(new DateTime(2018, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2453), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c5dceee6-ab09-42ab-bc30-cb0e91114b3d"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Candy J Gilbert", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2443), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d11d3a8d-30b6-4b3a-ad9b-ab2141a2f6bb"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Gary E Owens", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2456), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d447d3e9-82d3-4aba-80ae-223a6683f5c3"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Pattie L Foster", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2439), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ea3a236e-fda4-4e3f-ae1d-3bd3a535a177"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Caitlin J Nicholson", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2429), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f3ad3974-0c05-4db0-bda0-dee18f00a291"),
                columns: new[] { "FullName", "HiredDate" },
                values: new object[] { "Catherine J Easley", new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 3, 0, 0, 0)) });
        }
    }
}
