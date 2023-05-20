using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcoWeb.API.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("217cfe3f-f278-4ce8-84de-d9d523ca3802"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("270ed53a-053b-442a-9302-716959d0a51a"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2433), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3675f42d-9bbb-488f-bd36-c7e6411c87d5"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2426), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4fa3169e-0779-45cc-9139-dc4ee92cbd5f"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("532c9736-4fb6-4a4d-aa8f-e7a2d6a4ca49"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2466), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5c0bd7ac-a87b-4e92-81bb-14de6fdc6808"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6978cc16-5f5a-4020-bb79-4cc4dcc36b72"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2018, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2358), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8588c7bf-2bd4-436a-a1fc-9c790895b9d5"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2449), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("85cbcd1f-8b72-4398-b2fe-b2776ab0be0f"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2018, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b1ee8f72-0cc0-4cd9-bcc6-11183cf24da8"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c3f4100c-f746-467b-ab9e-4c16361a44af"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2018, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2453), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c5dceee6-ab09-42ab-bc30-cb0e91114b3d"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2443), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d11d3a8d-30b6-4b3a-ad9b-ab2141a2f6bb"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2456), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d447d3e9-82d3-4aba-80ae-223a6683f5c3"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2439), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ea3a236e-fda4-4e3f-ae1d-3bd3a535a177"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2429), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f3ad3974-0c05-4db0-bda0-dee18f00a291"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 52, 0, 743, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 3, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("217cfe3f-f278-4ce8-84de-d9d523ca3802"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("270ed53a-053b-442a-9302-716959d0a51a"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3675f42d-9bbb-488f-bd36-c7e6411c87d5"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1927), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4fa3169e-0779-45cc-9139-dc4ee92cbd5f"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1922), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("532c9736-4fb6-4a4d-aa8f-e7a2d6a4ca49"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1968), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5c0bd7ac-a87b-4e92-81bb-14de6fdc6808"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6978cc16-5f5a-4020-bb79-4cc4dcc36b72"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2018, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8588c7bf-2bd4-436a-a1fc-9c790895b9d5"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("85cbcd1f-8b72-4398-b2fe-b2776ab0be0f"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2018, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b1ee8f72-0cc0-4cd9-bcc6-11183cf24da8"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c3f4100c-f746-467b-ab9e-4c16361a44af"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2018, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1954), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c5dceee6-ab09-42ab-bc30-cb0e91114b3d"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1944), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d11d3a8d-30b6-4b3a-ad9b-ab2141a2f6bb"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1958), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d447d3e9-82d3-4aba-80ae-223a6683f5c3"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ea3a236e-fda4-4e3f-ae1d-3bd3a535a177"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1930), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f3ad3974-0c05-4db0-bda0-dee18f00a291"),
                column: "HiredDate",
                value: new DateTimeOffset(new DateTime(2021, 5, 20, 16, 48, 46, 357, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
