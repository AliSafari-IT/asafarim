using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatePortfoliosTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("61c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("71c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("81c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("91c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("a1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("b1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("c1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("d1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("e1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("f1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("109fad37-2acb-405b-aea0-c29f78f87ff6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21e4e312-f5f8-4fd0-a741-5ae68deec96e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a21f453-68ca-4034-852f-bb78345ecfba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ced98c7-412a-49d7-b99a-9bc6b762dd08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a65046f-5f7c-4c5d-a010-99dac6d6fb3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2d99c11-f214-47fa-9e80-beac0d41801a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7f15f04-5fc6-4082-9056-2b2092022f4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5497f55-053e-4a40-b2ea-7e9000fdc395"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cec2f4df-1527-42f3-89ec-645799fc8000"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc1a87f1-99b7-4a34-966c-f33c27bffbee"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("00952b7a-2e63-4f27-b41e-cc050f33679c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("177a9999-f3ac-4b10-9ff4-49cd1bf3211c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b80920c1-15a4-4d3b-8450-5c314546f6c8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f03fd365-388d-42ac-b6c0-b83fe5ece1bb"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("218574f2-4981-4aad-af41-94645297ea5e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("2cfdadaa-e697-492b-a546-6412a82b5d1c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("983b576e-6935-4d42-9a9a-09de0d3a197e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("a194c629-dd6c-4c93-b7af-c41d7f65f562"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("47f6b5e6-78ac-445f-b960-322d87a241e4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5c7f476d-9650-4951-a930-b9bd8d5cea34"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5eaa0e01-1cd2-4ae1-91ac-edebbbc10719"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("63fd0ead-3f90-4aa5-92c2-e6075a2cc91c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("7099462e-9e6f-4eb3-ad33-ade03a10b912"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("72e49c06-df15-41e9-875e-0565ae278a84"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("f07c8a09-77b1-4742-a8ba-e62e52b46011"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b288cb6-6948-4cfc-8d15-78774f6f149a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7fefe91f-29b4-4ca6-8dde-f2765c29830b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b0d10fdc-5fa6-4f4f-924e-1df51bbdaf68"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d7286970-b68b-47b7-868d-d0f2ec5b1b68"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ea15de58-cff6-481f-886a-fc9223ab9bdf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ff9ce8bb-2ecc-40ea-8f31-124868b67b9e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4cbb9c30-397f-4dc6-a8bb-c91bd18f5af4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5ef570e9-b9fd-49e6-a542-ab29ea5cf72b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("64a15ff6-5753-43e1-8ad3-78710fd6a9f3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fd0c394b-4fbc-4330-ac37-50130d8d8843"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("38768416-1754-4b77-bcee-578340316f06"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6648f55d-5e1f-48d8-bae4-f068a52017f9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("930f8817-12f1-447f-a8da-fe6bb3cd156f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c8214769-c5c5-4b96-8d5e-2e28f53e67b2"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("df933175-638f-4831-89ce-9564b2df3797"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3d82ed20-fa3e-43ce-8cd7-82aab30f7594"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b9fe97ed-7a3b-4770-a9cb-c9e502bcaaab"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f67be590-6d8e-4d1c-a389-1954a3a04af4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Portfolios",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Portfolios",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Portfolios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Portfolios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "BibliographyItems",
                columns: new[] { "Id", "AttachmentId", "Author", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Genre", "IsActive", "IsDeleted", "IsRead", "Title", "UpdatedAt", "UpdatedBy", "Year" },
                values: new object[,]
                {
                    { new Guid("61c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Robert C. Martin", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(5368), "System", null, null, null, "Software Development", true, false, true, "Clean Code: A Handbook of Agile Software Craftsmanship", null, null, 2008 },
                    { new Guid("71c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Andrew Hunt, David Thomas", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7452), "System", null, null, null, "Software Development", true, false, true, "The Pragmatic Programmer", null, null, 1999 },
                    { new Guid("81c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7461), "System", null, null, null, "Object-Oriented Programming", true, false, true, "Design Patterns: Elements of Reusable Object-Oriented Software", null, null, 1994 },
                    { new Guid("91c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Jon Skeet", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7484), "System", null, null, null, ".NET", true, false, false, "C# in Depth", null, null, 2019 },
                    { new Guid("a1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Andrew Lock", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7492), "System", null, null, null, ".NET", true, false, false, "ASP.NET Core in Action", null, null, 2021 },
                    { new Guid("b1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Eric Evans", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7500), "System", null, null, null, "Software Architecture", true, false, true, "Domain-Driven Design: Tackling Complexity in the Heart of Software", null, null, 2003 },
                    { new Guid("c1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Martin Fowler", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7517), "System", null, null, null, "Software Development", true, false, false, "Refactoring: Improving the Design of Existing Code", null, null, 2018 },
                    { new Guid("d1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Jon P Smith", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7531), "System", null, null, null, ".NET", true, false, true, "Entity Framework Core in Action", null, null, 2018 },
                    { new Guid("e1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Robert C. Martin", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7541), "System", null, null, null, "Software Architecture", true, false, true, "Clean Architecture: A Craftsman's Guide to Software Structure and Design", null, null, 2017 },
                    { new Guid("f1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Martin Fowler", new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7554), "System", null, null, null, "Software Architecture", true, false, false, "Patterns of Enterprise Application Architecture", null, null, 2002 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("109fad37-2acb-405b-aea0-c29f78f87ff6"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("21e4e312-f5f8-4fd0-a741-5ae68deec96e"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("3a21f453-68ca-4034-852f-bb78345ecfba"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("7ced98c7-412a-49d7-b99a-9bc6b762dd08"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("9a65046f-5f7c-4c5d-a010-99dac6d6fb3f"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("a2d99c11-f214-47fa-9e80-beac0d41801a"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("b7f15f04-5fc6-4082-9056-2b2092022f4e"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("c5497f55-053e-4a40-b2ea-7e9000fdc395"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("cec2f4df-1527-42f3-89ec-645799fc8000"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("fc1a87f1-99b7-4a34-966c-f33c27bffbee"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00952b7a-2e63-4f27-b41e-cc050f33679c"), "CHF", new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(6947), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("177a9999-f3ac-4b10-9ff4-49cd1bf3211c"), "GBP", new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(6936), 2, true, "British Pound", "£", null },
                    { new Guid("b80920c1-15a4-4d3b-8450-5c314546f6c8"), "EUR", new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(2321), 2, true, "Euro", "€", null },
                    { new Guid("f03fd365-388d-42ac-b6c0-b83fe5ece1bb"), "USD", new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(6832), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("218574f2-4981-4aad-af41-94645297ea5e"), new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(436), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null },
                    { new Guid("2cfdadaa-e697-492b-a546-6412a82b5d1c"), new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(408), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("983b576e-6935-4d42-9a9a-09de0d3a197e"), new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(415), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("a194c629-dd6c-4c93-b7af-c41d7f65f562"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(7557), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("47f6b5e6-78ac-445f-b960-322d87a241e4"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(1068), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("5c7f476d-9650-4951-a930-b9bd8d5cea34"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(950), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("5eaa0e01-1cd2-4ae1-91ac-edebbbc10719"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(954), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("63fd0ead-3f90-4aa5-92c2-e6075a2cc91c"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(932), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("7099462e-9e6f-4eb3-ad33-ade03a10b912"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(8181), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("72e49c06-df15-41e9-875e-0565ae278a84"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(1064), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("f07c8a09-77b1-4742-a8ba-e62e52b46011"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(2957), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1b288cb6-6948-4cfc-8d15-78774f6f149a"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5786), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("7fefe91f-29b4-4ca6-8dde-f2765c29830b"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5754), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("b0d10fdc-5fa6-4f4f-924e-1df51bbdaf68"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5797), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("d7286970-b68b-47b7-868d-d0f2ec5b1b68"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5791), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("ea15de58-cff6-481f-886a-fc9223ab9bdf"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(3587), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("ff9ce8bb-2ecc-40ea-8f31-124868b67b9e"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5765), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4cbb9c30-397f-4dc6-a8bb-c91bd18f5af4"), null, new DateTime(2025, 4, 1, 16, 5, 27, 796, DateTimeKind.Utc).AddTicks(9272), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("5ef570e9-b9fd-49e6-a542-ab29ea5cf72b"), null, new DateTime(2025, 4, 1, 16, 5, 27, 797, DateTimeKind.Utc).AddTicks(1514), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("64a15ff6-5753-43e1-8ad3-78710fd6a9f3"), null, new DateTime(2025, 4, 1, 16, 5, 27, 797, DateTimeKind.Utc).AddTicks(1533), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("fd0c394b-4fbc-4330-ac37-50130d8d8843"), null, new DateTime(2025, 4, 1, 16, 5, 27, 797, DateTimeKind.Utc).AddTicks(1527), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("38768416-1754-4b77-bcee-578340316f06"), new DateTime(2025, 4, 1, 16, 5, 27, 795, DateTimeKind.Utc).AddTicks(2700), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("6648f55d-5e1f-48d8-bae4-f068a52017f9"), new DateTime(2025, 4, 1, 16, 5, 27, 795, DateTimeKind.Utc).AddTicks(2680), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("930f8817-12f1-447f-a8da-fe6bb3cd156f"), new DateTime(2025, 4, 1, 16, 5, 27, 795, DateTimeKind.Utc).AddTicks(2719), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("c8214769-c5c5-4b96-8d5e-2e28f53e67b2"), new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(9763), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("df933175-638f-4831-89ce-9564b2df3797"), new DateTime(2025, 4, 1, 16, 5, 27, 795, DateTimeKind.Utc).AddTicks(2723), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), new DateTime(2025, 4, 1, 16, 5, 27, 797, DateTimeKind.Utc).AddTicks(7795), "System", null, null, null, "Test Topic description", true, false, "Test Topic name", null, "test-topic-slug", null, null },
                    { new Guid("f67be590-6d8e-4d1c-a389-1954a3a04af4"), new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(997), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "ForgotPasswordToken", "ForgotPasswordTokenExpiration", "IsActive", "IsAdmin", "IsBannedByAdmin", "IsBlocked", "IsDeleted", "IsEditor", "IsGuest", "IsLockedOut", "IsModerator", "IsPending", "IsStandardUser", "IsSuperAdmin", "IsUser", "IsVerified", "LastLogin", "LastName", "LinkUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetToken", "PasswordResetTokenExpiration", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "ProfilePicture", "ReactivationReason", "ReactivationRequestedAt", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "Website" },
                values: new object[,]
                {
                    { new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"), 0, null, "demo_user@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "demo_user@example.com", false, 0, "Demo User", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Account", null, false, null, null, "DEMO_USER@EXAMPLE.COM", "DEMO_USER", "z1o14fDMFFAF5shoM0EneW8zvRjo7E8fOC3a9umNaeZ9oJIqQnvVEbkfxdtWD1Tn", null, null, null, "+1234567890", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "demo_user@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "demo_user", null },
                    { new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"), 0, null, "asafarim.it@gmail.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "asafarim.it@gmail.com", false, 0, "Deleted User", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Account", null, false, null, null, "ASAFARIM.IT@GMAIL.COM", "DELETED_USER", "qut7PgRa+BNJs7QJAsuR0YLGhWl4bUbqhNk9EB5J4mSEoB9qim1CrGlQ2lEJ1Tgu", null, null, null, "+1234567890", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "asafarim.it@gmail.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "deleted_user", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"), 0, null, "user_1_45a5@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_1_45a5@example.com", false, 0, "User 1", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_1_45A5@EXAMPLE.COM", "USER_1_45A5", "94XEbRAO5sjM6+uSgN/aCTq/W8iIj/EejG8d6Gvcp1t/0nKcBzg8VoUhXm7mD3eX", null, null, null, "+123456781", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_1_45a5@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_1_45a5", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"), 0, null, "user_2_d8f6@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_2_d8f6@example.com", false, 0, "User 2", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_2_D8F6@EXAMPLE.COM", "USER_2_D8F6", "k3jKYRq1znktMF+PqY/6MMXtrxFblqxc2SSEUPvhCNSUXfLlysvt+2hVUL4nvMJ5", null, null, null, "+123456782", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_2_d8f6@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_2_d8f6", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"), 0, null, "user_3_c6aa@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_3_c6aa@example.com", false, 0, "User 3", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_3_C6AA@EXAMPLE.COM", "USER_3_C6AA", "z0sGY0QYLH9cF8LNkXEW6cq5b0XcIH6JKUrO1jEowgB+7Jvta2nIL7SLvSYk4a5r", null, null, null, "+123456783", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_3_c6aa@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_3_c6aa", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"), 0, null, "user_4_e0d8@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_4_e0d8@example.com", false, 0, "User 4", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_4_E0D8@EXAMPLE.COM", "USER_4_E0D8", "2R/vxa45LXGqo4b8vAoTKhdFPtRjUjyB0F+k3+PM4Q5w3F+8QisBY83aBMO9U5/s", null, null, null, "+123456784", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_4_e0d8@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_4_e0d8", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"), 0, null, "user_5_f0be@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_5_f0be@example.com", false, 0, "User 5", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_5_F0BE@EXAMPLE.COM", "USER_5_F0BE", "j/L64mz6OvC0SbuzWi1f0Q9oPZ5GsvAOOrusNkoTwqipFHveWR6z9LPjFasLvuub", null, null, null, "+123456785", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_5_f0be@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_5_f0be", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fba"), 0, null, "user_6_7fdb@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_6_7fdb@example.com", false, 0, "User 6", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_6_7FDB@EXAMPLE.COM", "USER_6_7FDB", "LmFMAznjfIs/DW3H97rVQEIZBrtGN+L+s0dKg6vm6z6VXyuTy78Sj7uRV94BGndX", null, null, null, "+123456786", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_6_7fdb@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_6_7fdb", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"), 0, null, "user_7_9a99@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_7_9a99@example.com", false, 0, "User 7", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_7_9A99@EXAMPLE.COM", "USER_7_9A99", "SNFb6UQKLcpliq0ebs/PH4vWhkA7enVjvFJkgP5GBq1uEIITNT4XZlOYWZFIfTF8", null, null, null, "+123456787", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_7_9a99@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_7_9a99", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"), 0, null, "user_8_5760@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_8_5760@example.com", false, 0, "User 8", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_8_5760@EXAMPLE.COM", "USER_8_5760", "TpwAonxJ8oYrSr0Mzl64N0eDppdwXn1L6yDVhMK4PhDUvVP73HWImYQVU11s9ARX", null, null, null, "+123456788", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_8_5760@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_8_5760", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"), 0, null, "user_9_e5cf@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_9_e5cf@example.com", false, 0, "User 9", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_9_E5CF@EXAMPLE.COM", "USER_9_E5CF", "/ofDOL3NLHZQcmN3t0xvAmBiyeoRV5mdf14jb6oVXLo+oAFwGxlaRJhyyVVkufFP", null, null, null, "+123456789", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_9_e5cf@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_9_e5cf", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"), 0, null, "user_10_d224@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_10_d224@example.com", false, 0, "User 10", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_10_D224@EXAMPLE.COM", "USER_10_D224", "yPlCGO0DIGZErckh9FJrLjZzHnqb+I0S4r09AlcQNDDCRRVGo2w4djiqZEReSGAN", null, null, null, "+1234567810", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_10_d224@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_10_d224", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"), 0, null, "user_11_c69d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_11_c69d@example.com", false, 0, "User 11", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_11_C69D@EXAMPLE.COM", "USER_11_C69D", "0mCa/qlV1vemzBAp3JSyxLJNm1gDc7BzMBMWQXyOSFykXwEFkRvduk8/48W70kpF", null, null, null, "+1234567811", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_11_c69d@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_11_c69d", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"), 0, null, "user_12_d0d3@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_12_d0d3@example.com", false, 0, "User 12", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_12_D0D3@EXAMPLE.COM", "USER_12_D0D3", "JFrsoh3KreW313ihR0bomQV/nltPBx4eyEZ710iaH/C++CgMWpvGznKPaTHjc2pc", null, null, null, "+1234567812", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_12_d0d3@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_12_d0d3", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"), 0, null, "user_13_56b2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_13_56b2@example.com", false, 0, "User 13", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_13_56B2@EXAMPLE.COM", "USER_13_56B2", "Yc4woH94ICN5p8gJ4h9dm9B6FSNNCASkoY0RYe90jVj79uS/3Z55kiEpfGtwFBUg", null, null, null, "+1234567813", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_13_56b2@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_13_56b2", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"), 0, null, "user_14_f552@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_14_f552@example.com", false, 0, "User 14", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_14_F552@EXAMPLE.COM", "USER_14_F552", "hafqs/bqfQFvdXmA4EiHuJp2Ny898TuYgICSTniwMaPx2SdmTwmn1+1v/fbm1XVM", null, null, null, "+1234567814", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_14_f552@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_14_f552", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"), 0, null, "user_15_f53e@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_15_f53e@example.com", false, 0, "User 15", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_15_F53E@EXAMPLE.COM", "USER_15_F53E", "plv71I1fyJwDrHycTXengZaeRMH/QXmWXK8HDSDSG/ziX9lt24gz0Znurb5Mji1h", null, null, null, "+1234567815", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_15_f53e@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_15_f53e", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"), 0, null, "user_16_00a6@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_16_00a6@example.com", false, 0, "User 16", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_16_00A6@EXAMPLE.COM", "USER_16_00A6", "wJmW0fTVQWe6LaBhS9T75LhfGDL9Fk5f2Fuv1XkBOxuVxAiaQUg/DhTvBwI1U8ms", null, null, null, "+1234567816", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_16_00a6@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_16_00a6", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"), 0, null, "user_17_c198@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_17_c198@example.com", false, 0, "User 17", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_17_C198@EXAMPLE.COM", "USER_17_C198", "v0CfVvouUU8koO3mL2YJHAmoXSLgzPv2nn1MYBBMTRVVZqKDiowrKUttbNNtYNyG", null, null, null, "+1234567817", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_17_c198@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_17_c198", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"), 0, null, "user_18_ba62@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_18_ba62@example.com", false, 0, "User 18", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_18_BA62@EXAMPLE.COM", "USER_18_BA62", "HrRFuG3APIPwt8Yhe3UhbdzSS+FafnZB1KKj83OlZK3tMkNij9Jy0A6s3ry4XJl0", null, null, null, "+1234567818", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_18_ba62@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_18_ba62", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"), 0, null, "user_19_eceb@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_19_eceb@example.com", false, 0, "User 19", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_19_ECEB@EXAMPLE.COM", "USER_19_ECEB", "T07z/gl3fO6Y1jKBAUO2nLdIyAZV3I6xGHXgUicVhfyvk69Jy4EN2E5hNO8sj9Gu", null, null, null, "+1234567819", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_19_eceb@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_19_eceb", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"), 0, null, "user_20_29f3@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_20_29f3@example.com", false, 0, "User 20", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_20_29F3@EXAMPLE.COM", "USER_20_29F3", "VxvtQo/macrdtjRgAolGc/4Ds/jr2s0QuFv5X143GF+CiuzTWU3XfYv8q3v02kST", null, null, null, "+1234567820", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_20_29f3@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_20_29f3", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"), 0, null, "user_21_29e3@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_21_29e3@example.com", false, 0, "User 21", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_21_29E3@EXAMPLE.COM", "USER_21_29E3", "XbROUfy44h2GSmrSOwK0GwefjZdufSpRPa+X+1ZhK2BR+17MCVFh51YT1bd2yHox", null, null, null, "+1234567821", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_21_29e3@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_21_29e3", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fca"), 0, null, "user_22_3111@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_22_3111@example.com", false, 0, "User 22", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_22_3111@EXAMPLE.COM", "USER_22_3111", "GzjxyEUIyk1rWSzWcLg94hDhLoXlbs9ZYrQxIkZRrJvu4IXqPFRZn3XuRrLmt+fD", null, null, null, "+1234567822", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_22_3111@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_22_3111", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"), 0, null, "user_23_8403@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_23_8403@example.com", false, 0, "User 23", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_23_8403@EXAMPLE.COM", "USER_23_8403", "lSIBkWJ2HeLemjeXGtV3U2CNk2lTVl1aJFtxJpUlkPS/IB+sYadl7+RfMc7LmATD", null, null, null, "+1234567823", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_23_8403@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_23_8403", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"), 0, null, "user_24_ae17@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_24_ae17@example.com", false, 0, "User 24", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_24_AE17@EXAMPLE.COM", "USER_24_AE17", "MZtMmPcSHg++HbABagsimVzCVY97xa1f6WPbn5K1qQJ7lCTlU6Ew28EgET5f0Bjp", null, null, null, "+1234567824", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_24_ae17@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_24_ae17", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"), 0, null, "user_25_40f5@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_25_40f5@example.com", false, 0, "User 25", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_25_40F5@EXAMPLE.COM", "USER_25_40F5", "9wHqbbvf4/yTg7CTJn0qqk3owB6IrWWYWh97rLgtMkQqn2t7pNxhr1CC3Jbw7F8g", null, null, null, "+1234567825", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_25_40f5@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_25_40f5", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fce"), 0, null, "user_26_307d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_26_307d@example.com", false, 0, "User 26", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_26_307D@EXAMPLE.COM", "USER_26_307D", "UVq2BGGkfmyDPYFlbVV1XDw9aRTQNPA6+EZ/PZwMeFTVNxiCQ37DmQdlvXz1U2pb", null, null, null, "+1234567826", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_26_307d@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_26_307d", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"), 0, null, "user_27_0b0a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_27_0b0a@example.com", false, 0, "User 27", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_27_0B0A@EXAMPLE.COM", "USER_27_0B0A", "BGOEB43jdQeJVLREMmC6lylHB+fBZB03w2V5Y555ef5Cbu9Mu50bAlyUViHujaoT", null, null, null, "+1234567827", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_27_0b0a@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_27_0b0a", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"), 0, null, "user_28_0a11@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_28_0a11@example.com", false, 0, "User 28", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_28_0A11@EXAMPLE.COM", "USER_28_0A11", "M2bgHZwbvFCyI0vfWnmZLg30wOzLUKf2RZTzWAJSOT1JO1W4C5MiEeohZ8tFvhJt", null, null, null, "+1234567828", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_28_0a11@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_28_0a11", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"), 0, null, "user_29_ca1e@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_29_ca1e@example.com", false, 0, "User 29", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_29_CA1E@EXAMPLE.COM", "USER_29_CA1E", "vMl5qPjDBxd08v/8p+bYem0WdZukOKIKKp5Hxg9k3j8s19QHABl0Au2LGnblWhjF", null, null, null, "+1234567829", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_29_ca1e@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_29_ca1e", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"), 0, null, "user_30_2711@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_30_2711@example.com", false, 0, "User 30", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_30_2711@EXAMPLE.COM", "USER_30_2711", "9L01GiwR3iSX4rs88EPq+KQhJ1V9/m3HBf2Ly70vtDVzclPhLOnd8X8BI9ut18gt", null, null, null, "+1234567830", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_30_2711@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_30_2711", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"), 0, null, "user_31_2522@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_31_2522@example.com", false, 0, "User 31", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_31_2522@EXAMPLE.COM", "USER_31_2522", "g3rFDuh2TjMWH1onad33C+oYuRt7uHjF+bTwt94YR/56LJS/OvNBRJTnV2nxg51k", null, null, null, "+1234567831", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_31_2522@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_31_2522", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"), 0, null, "user_32_c27c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_32_c27c@example.com", false, 0, "User 32", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_32_C27C@EXAMPLE.COM", "USER_32_C27C", "xtgJ5BQ8ClI8bGgBrWr02HvG0VEwbVaw/MxpxY2Vhlj9/dLhAfQ8fF7WUozHblT7", null, null, null, "+1234567832", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_32_c27c@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_32_c27c", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"), 0, null, "user_33_da9a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_33_da9a@example.com", false, 0, "User 33", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_33_DA9A@EXAMPLE.COM", "USER_33_DA9A", "YQIVRrIhCXQxPulRFsfHiIYbk4GQ2h9DUlSUEaNPXjCYDKWwHu1XdWaymV1dMW2r", null, null, null, "+1234567833", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_33_da9a@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_33_da9a", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"), 0, null, "user_34_80ad@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_34_80ad@example.com", false, 0, "User 34", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_34_80AD@EXAMPLE.COM", "USER_34_80AD", "c0jethrTYcJkxLgbP6y3SfMeOvz7gxxK1A7h/sFeUZMnmSb0HZY63ZVzjyoLC3Ro", null, null, null, "+1234567834", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_34_80ad@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_34_80ad", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"), 0, null, "user_35_c43e@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_35_c43e@example.com", false, 0, "User 35", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_35_C43E@EXAMPLE.COM", "USER_35_C43E", "45bucARY+oSYMCclBjwH/TiCdF5S7w1pbO02im+Isrni1gHo6wJbHCB3fK/J2d9g", null, null, null, "+1234567835", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_35_c43e@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_35_c43e", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"), 0, null, "user_36_b16e@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_36_b16e@example.com", false, 0, "User 36", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_36_B16E@EXAMPLE.COM", "USER_36_B16E", "jckJbKCzVs/g0yibKDGBG4UyqJhWZ6cJnqXvoprkrk51Dy8G1pQrhrjLcEZqQxjh", null, null, null, "+1234567836", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_36_b16e@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_36_b16e", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"), 0, null, "user_37_700f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_37_700f@example.com", false, 0, "User 37", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_37_700F@EXAMPLE.COM", "USER_37_700F", "Tw5qyKiaKk01+rO8Ok/i0sjwoHn9fnbFfPOfgmSpPJHMPMerHP7y8V6ExRh8nEw/", null, null, null, "+1234567837", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_37_700f@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_37_700f", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fda"), 0, null, "user_38_808f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_38_808f@example.com", false, 0, "User 38", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_38_808F@EXAMPLE.COM", "USER_38_808F", "X0onDdvJssQk73KhOMF7N0LZff3mf6hP4cQhXCf7i08V0ht9+n+lSlFfoNAo8l4Z", null, null, null, "+1234567838", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_38_808f@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_38_808f", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"), 0, null, "user_39_8424@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_39_8424@example.com", false, 0, "User 39", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_39_8424@EXAMPLE.COM", "USER_39_8424", "AUWc6DRemfyPUPYJI7X7ZBHokMOPx2FCbVcCjwUuMpMcIiBT1v3B4l6GwvRCI06K", null, null, null, "+1234567839", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_39_8424@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_39_8424", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"), 0, null, "user_40_b3f0@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_40_b3f0@example.com", false, 0, "User 40", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_40_B3F0@EXAMPLE.COM", "USER_40_B3F0", "7sRrdzTamgGZBaQGirbjpAwG/UYd8VvvLv065inzw1LpHOUNh+ZjZnJcZkLn7ceT", null, null, null, "+1234567840", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_40_b3f0@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_40_b3f0", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"), 0, null, "user_41_25bb@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_41_25bb@example.com", false, 0, "User 41", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_41_25BB@EXAMPLE.COM", "USER_41_25BB", "FwMNY+inSod2CkKyg7gNJtkX7i6L+MTl7aadl33ZO6j3ebHGlew7do0AdifQmo7g", null, null, null, "+1234567841", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_41_25bb@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_41_25bb", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fde"), 0, null, "user_42_7f1b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_42_7f1b@example.com", false, 0, "User 42", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_42_7F1B@EXAMPLE.COM", "USER_42_7F1B", "qUaK5vXZuCjz+w/gaeiXKuygsP82UsLdeiVWq+WAKGs1fym45h0cWRY1PWgaPjk6", null, null, null, "+1234567842", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_42_7f1b@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_42_7f1b", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"), 0, null, "user_43_3470@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_43_3470@example.com", false, 0, "User 43", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_43_3470@EXAMPLE.COM", "USER_43_3470", "Td5g1NVP9cR0rvmYb12a2zlLaq/nTSy0rHYIUnfpipvqN8L+MG11K30ye3N2HGnj", null, null, null, "+1234567843", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_43_3470@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_43_3470", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"), 0, null, "user_44_4da0@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_44_4da0@example.com", false, 0, "User 44", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_44_4DA0@EXAMPLE.COM", "USER_44_4DA0", "eCREwbiwN8StF0jnRquVbIt2O2SQZMkSsDp0QiME7SBCgi+UxX09lvNBVLdouUdU", null, null, null, "+1234567844", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_44_4da0@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_44_4da0", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"), 0, null, "user_45_1bb1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_45_1bb1@example.com", false, 0, "User 45", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_45_1BB1@EXAMPLE.COM", "USER_45_1BB1", "8yooLrl79RG8BRS2LJyeeEbiJbWX0HQBVgew6pQH3wHdw3mEqWmmDvpOkCF/RMhO", null, null, null, "+1234567845", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_45_1bb1@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_45_1bb1", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"), 0, null, "user_46_7ac6@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_46_7ac6@example.com", false, 0, "User 46", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_46_7AC6@EXAMPLE.COM", "USER_46_7AC6", "IxY5dhLD1+LPRAtlRgCia3AFGWp47Atns/TVAv0ilFYjy2VdsflFLTq2irW110rp", null, null, null, "+1234567846", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_46_7ac6@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_46_7ac6", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"), 0, null, "user_47_4853@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_47_4853@example.com", false, 0, "User 47", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_47_4853@EXAMPLE.COM", "USER_47_4853", "lgIB2IBPo3hsi0BD74ntqmv5ZjbTKLmrJkGTI3Pk7UePcMn7+EKMvGTGGJHsVn40", null, null, null, "+1234567847", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_47_4853@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_47_4853", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"), 0, null, "user_48_5869@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1979, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_48_5869@example.com", false, 0, "User 48", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_48_5869@EXAMPLE.COM", "USER_48_5869", "s8USoDqKoAPKIUS7KOU7rF+wq8mum3+Wiz2jgxJC5hJ4kNtAjZRfJx7HTUaTb6nh", null, null, null, "+1234567848", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_48_5869@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_48_5869", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"), 0, null, "user_49_326f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1979, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_49_326f@example.com", false, 0, "User 49", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_49_326F@EXAMPLE.COM", "USER_49_326F", "KO4tRj9LimBl2eKqi59Kac03NUcBC/fJQ3UrGCotmqlGzguW9RXLL0Qq+V6+d77Z", null, null, null, "+1234567849", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_49_326f@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_49_326f", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"), 0, null, "user_50_aa3b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1979, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_50_aa3b@example.com", false, 0, "User 50", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Example", null, false, null, null, "USER_50_AA3B@EXAMPLE.COM", "USER_50_AA3B", "Qa42BdVctKszkrbEAVEuoe9gPvZd/LLVZSu5ChyMla6CqBC1jGwfocnqaPSRfjko", null, null, null, "+1234567850", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "user_50_aa3b@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_50_aa3b", null },
                    { new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), 0, null, "demo_admin@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "demo_admin@example.com", false, 0, "Demo Admin", null, null, true, true, false, false, false, false, false, false, false, false, true, true, true, true, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Account", null, false, null, null, "DEMO_ADMIN@EXAMPLE.COM", "DEMO_ADMIN", "/iaNYV8qRjwsy+shsob4Rixcz7Qy03uGNWCEcUtUqSA6N0LrdUR2mpKQHx+qSSYm", null, null, null, "+123456789", true, null, "https://asafarim.com/logoT.svg", null, null, null, null, "demo_admin@example.com", null, false, new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "demo_admin", null }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3d82ed20-fa3e-43ce-8cd7-82aab30f7594"), new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(1005), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("b9fe97ed-7a3b-4770-a9cb-c9e502bcaaab"), new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(969), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });
        }
    }
}
