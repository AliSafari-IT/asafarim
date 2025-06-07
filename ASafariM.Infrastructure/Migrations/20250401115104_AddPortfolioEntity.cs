using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPortfolioEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BibliographyItems_Attachment_AttachmentId",
                table: "BibliographyItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectMembers",
                table: "ProjectMembers");

            migrationBuilder.DropIndex(
                name: "IX_ProjectMembers_UserId",
                table: "ProjectMembers");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("058ac7ea-0fa1-49a1-9aee-eec8bd95a099"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0af6ddf2-fc14-4e80-aeb8-e7374ff31532"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4104b34e-1d5f-4c09-a4bf-53b649ab5902"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4773d13c-a6a4-46da-b589-53daa6027edb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("512dddda-8b69-48bc-a4ed-abcea791117f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fc6c4f6-f5f0-4ef4-aad4-4e07aefb2c51"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e40ff57-d825-4136-9c4e-f2a3d9d6f975"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8cdcce16-0d4a-42ed-a11d-a14db328e2e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0eb49c6-4484-4427-8496-e2f0dd50bd94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7357a5a-ed1c-4630-9bef-68726e77cb69"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("02d16b39-068f-4e9b-9f83-5edf2138ed06"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("144e5560-6754-4a81-a1b1-545c59537696"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("536c3a5d-bd72-4e51-8537-f3b51372a88e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ecb5265f-d365-4c05-8924-e292a21bda89"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("157357bd-edd5-4611-9c24-739f70980a38"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("326bff6c-7c23-4c17-b5e7-86a11450e290"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("737d2787-2a1f-4571-b509-860beb7a98ae"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d642684a-4c47-47a1-8109-f126f537efb9"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6b7faddb-0152-494c-8108-08fddd931166"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a5540390-cb48-4fc0-94a0-5438ab352523"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b8c075e0-09a1-449a-8cad-37a2006bbfe1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c8c20fd6-4956-4e24-b21e-3cd3ccd88ec7"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("dc43b813-08ed-45fa-ba6a-80de59d85591"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("dda9e46f-4b95-4dc7-b42c-151e87e0408e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("2e3f723e-b24d-4d37-94a6-03d6ffff0de5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2598e53c-199e-48e5-9e6d-e6c7c8aff8a6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4d3918ed-0929-4d16-9b76-578832ed3669"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("88f9c01e-d6c4-4cfe-9b6b-166f0e1570d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("943bf88a-a95c-478d-b4e1-965115f81923"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d8918f70-37a9-454f-9026-8591ecddb906"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ebea86cf-6d3d-4dd0-a7fc-b762427b1ec1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2a6fc865-8476-4796-b6d4-456005259a2c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c34adfef-528c-48bd-8d36-634977b924a2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e2ff127b-c38f-46e5-afe6-685bb7d8f9d5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e49d36d9-e87d-4ff4-97a8-e0cb9b7f1483"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6e0e428c-8961-44a1-86ad-af24c2d31f36"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9bb4f5c3-c216-4ac2-914b-f29eebcc3abe"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("bc9c578e-e25b-43ae-aae2-741657fde460"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c9ed37f3-f886-4ed3-847f-71f66503a3a7"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("e506c17b-9d79-4b92-ba2d-30eff6501335"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1334022d-4e6e-4325-a5dd-58f4a301e801"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6fbefcaf-0251-46a4-87dd-fc7727e9f832"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c93703ad-1c7e-4b29-a748-f9a6238bf9e2"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId1",
                table: "ProjectMembers",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectMembers",
                table: "ProjectMembers",
                columns: new[] { "UserId", "ProjectId" });

            migrationBuilder.InsertData(
                table: "BibliographyItems",
                columns: new[] { "Id", "AttachmentId", "Author", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Genre", "IsActive", "IsDeleted", "IsRead", "Title", "UpdatedAt", "UpdatedBy", "Year" },
                values: new object[,]
                {
                    { new Guid("61c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Robert C. Martin", new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(9542), "System", null, null, null, "Software Development", true, false, true, "Clean Code: A Handbook of Agile Software Craftsmanship", null, null, 2008 },
                    { new Guid("71c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Andrew Hunt, David Thomas", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(201), "System", null, null, null, "Software Development", true, false, true, "The Pragmatic Programmer", null, null, 1999 },
                    { new Guid("81c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(205), "System", null, null, null, "Object-Oriented Programming", true, false, true, "Design Patterns: Elements of Reusable Object-Oriented Software", null, null, 1994 },
                    { new Guid("91c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Jon Skeet", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(212), "System", null, null, null, ".NET", true, false, false, "C# in Depth", null, null, 2019 },
                    { new Guid("a1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Andrew Lock", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(215), "System", null, null, null, ".NET", true, false, false, "ASP.NET Core in Action", null, null, 2021 },
                    { new Guid("b1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Eric Evans", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(217), "System", null, null, null, "Software Architecture", true, false, true, "Domain-Driven Design: Tackling Complexity in the Heart of Software", null, null, 2003 },
                    { new Guid("c1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Martin Fowler", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(221), "System", null, null, null, "Software Development", true, false, false, "Refactoring: Improving the Design of Existing Code", null, null, 2018 },
                    { new Guid("d1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Jon P Smith", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(223), "System", null, null, null, ".NET", true, false, true, "Entity Framework Core in Action", null, null, 2018 },
                    { new Guid("e1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Robert C. Martin", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(226), "System", null, null, null, "Software Architecture", true, false, true, "Clean Architecture: A Craftsman's Guide to Software Structure and Design", null, null, 2017 },
                    { new Guid("f1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"), null, "Martin Fowler", new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(229), "System", null, null, null, "Software Architecture", true, false, false, "Patterns of Enterprise Application Architecture", null, null, 2002 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cc46e58-47b1-45f9-86f5-284030c8e11c"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("200a8455-0f72-4c7c-82cb-88675715e23a"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("2e65ee89-dc6e-4db3-9302-46fae6f55aad"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("3c2d1b9e-aeea-4cc3-9974-0d9caf668a4b"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("403d0c06-5d1d-4673-8f5f-1cf1a3a836c9"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("4f08d041-9c36-44ab-ae4c-b02a4029e3e8"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("53d10411-e144-4215-91dd-360af9ec74fc"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("5929cad3-9204-4b8f-a21f-a0b0a8a467c1"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("94ac6dcb-0180-4b82-9ea6-d7a62c51b28d"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("bef58820-204a-4f07-8cf3-fdea3b935dbf"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b86dde1-2092-4abe-9192-46bcff04c578"), "CHF", new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(8369), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("20f11132-4529-45c1-92da-adeeedd8bc23"), "GBP", new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(8367), 2, true, "British Pound", "£", null },
                    { new Guid("5d65b1f3-c974-4a1e-bb78-4225065082ea"), "USD", new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(8361), 2, true, "US Dollar", "$", null },
                    { new Guid("fd050ffa-5482-4f0f-9927-e23d7275dff6"), "EUR", new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(7308), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0916ab96-246e-47e4-a06b-febc9eb4d64d"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(6487), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("96c23f59-45d3-4734-8894-eea79d8d811b"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(5571), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("c9bbf220-dc03-4e10-8b87-66b0f4ccc629"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(6490), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("cb204c93-59a6-43d3-8f29-258d047fe1de"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(6498), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3d96deae-d6e5-43d2-89b7-2b00ec491d5e"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(1443), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("b6231be4-d11b-42c1-9847-4e58c2648ea9"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2572), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("b7eae529-8cc7-43ac-beca-67b455061b38"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2569), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("ce59b538-8634-4f15-b65b-6ee7ad26cfb7"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2522), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("d33e6a09-fedb-49b1-a028-7a929a18ee37"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2574), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("f046dd1a-5f1f-4841-86c7-0317b3876f89"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2579), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("fbbff75b-6ac8-45bd-b3a7-07373e22bd76"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(3372), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1b61dfb5-49a0-4588-ae40-d17fbcdc8407"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(563), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("6ad459ad-7a80-4bc8-b23a-465b845fbf03"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(559), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("8f74b354-db81-4667-8a6d-9f9fdc997ca6"), new DateTime(2025, 4, 1, 11, 50, 58, 227, DateTimeKind.Utc).AddTicks(9548), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("ba7a14ee-244e-4cc3-8941-b4a79d63b258"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(570), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("e7bca87b-5862-4516-8c02-6148cac0f80d"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(572), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("fe07d465-fbc7-42e0-a28f-b9d9dcb15458"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(574), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a7c13f04-56d4-46f0-b806-8a2f3c64ff51"), null, new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(4591), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("ae9a985a-6451-4d85-916a-9aa6671d4035"), null, new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(5254), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("b84e9b02-59b9-40fa-a0a3-49160431fb8d"), null, new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(5249), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("eb2abc03-c95b-4264-89e4-827dcbdf91d0"), null, new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(5252), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("170475f5-d41e-46ac-ba6a-dd917c4ae77e"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(211), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("613f8cf1-1725-4b3b-ac0b-8551bc4770de"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(259), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("72148966-fa79-4e3e-954a-b5e8acd0334a"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(197), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("cdb17851-b58a-4b7c-a8e8-33c7ca72a39d"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(214), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("f784af2a-03b7-41de-9f7f-c436b610567a"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(9048), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("52c2b275-b99e-453a-af41-c1d634338158"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(8048), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("6f1d6e4b-d8f0-4486-832f-769d25b4e0e2"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(8051), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("867f2491-a693-4c28-a56c-5bdb123f5200"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(8039), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "Sx5zAw4hfvKYNYDhWwph5gEysYgyEdWUxSgx+nF6USJA0ArWXboLt4fgKxchjNv3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "3SSROBJk8vxcuotrMv4du2kc5X4Tgq9dc1IxEmnYgtYfB/HD7696/6+C7ApZX1OM");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_9111@example.com", "user_1_9111@example.com", "USER_1_9111@EXAMPLE.COM", "USER_1_9111", "/+XHc3XwvKD3Llmqmhs9YSOHsmr1NUNWqps4V9RgJR2yaGNC/4+V9MAcFMAsuzDx", "user_1_9111@example.com", "user_1_9111" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_fc14@example.com", "user_2_fc14@example.com", "USER_2_FC14@EXAMPLE.COM", "USER_2_FC14", "ryOTDDDKG82VO4UH4bWn0yJYFQv6jDkJSTYc7HqJuQVv088zMAFA6dy+RljB/j5L", "user_2_fc14@example.com", "user_2_fc14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_955c@example.com", "user_3_955c@example.com", "USER_3_955C@EXAMPLE.COM", "USER_3_955C", "jkSR2/M8oV1qBzSZRLj23hbu84r5Xwfc+JmZNKZc9vFG+jBDO4V2xqM90vfNouY+", "user_3_955c@example.com", "user_3_955c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_f59f@example.com", "user_4_f59f@example.com", "USER_4_F59F@EXAMPLE.COM", "USER_4_F59F", "H54XRfJR6pEHOyh3rfOt64VB21FhSuNF+TK66YVGQKSk2EwQsti9xsAk7DPT6vLI", "user_4_f59f@example.com", "user_4_f59f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_af31@example.com", "user_5_af31@example.com", "USER_5_AF31@EXAMPLE.COM", "USER_5_AF31", "3WaESMbS4sQVYpWO/ZCGpRIrvl8onRmpXxw+VN3bWiARy0KEOoSh8WKPxE/zowxe", "user_5_af31@example.com", "user_5_af31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_1c6f@example.com", "user_6_1c6f@example.com", "USER_6_1C6F@EXAMPLE.COM", "USER_6_1C6F", "bGpGH07paiLCy6+26CdbcWki5bq5/S8PFVa5akt1+sNEYrYhWjL6McKzl7nB4DR6", "user_6_1c6f@example.com", "user_6_1c6f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_a16f@example.com", "user_7_a16f@example.com", "USER_7_A16F@EXAMPLE.COM", "USER_7_A16F", "XOWq4fQltpDhlbuvUZ466hSlPiDGdtQdnNEzVYIvsXXpFt8DsAPsDhi0c27hEpto", "user_7_a16f@example.com", "user_7_a16f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_497e@example.com", "user_8_497e@example.com", "USER_8_497E@EXAMPLE.COM", "USER_8_497E", "uAjsHI5c9aNVtSCpt/C3hnHdEHRWK7gHHKlmAjqOYnO0vj7MULLDWLczhEPweg5u", "user_8_497e@example.com", "user_8_497e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_53ea@example.com", "user_9_53ea@example.com", "USER_9_53EA@EXAMPLE.COM", "USER_9_53EA", "J6rD7hozFN+dfAGMVuMRWrLLKX37iL741eZekbl+Ww55mYRJVSjFEzra66r5B18L", "user_9_53ea@example.com", "user_9_53ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_e9ba@example.com", "user_10_e9ba@example.com", "USER_10_E9BA@EXAMPLE.COM", "USER_10_E9BA", "HgzFuA6es6vdq2hRWvIGRXShKYF6/EMTPes0z2+/APARmQks0Gd5s7y+n3Pn3XrI", "user_10_e9ba@example.com", "user_10_e9ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_b054@example.com", "user_11_b054@example.com", "USER_11_B054@EXAMPLE.COM", "USER_11_B054", "+oJpj/aohnB1D2+tD8/zbpSA024NFoeQMjOaAhNCp9Iq9AZQME5zRuhhiM+Ym9PF", "user_11_b054@example.com", "user_11_b054" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_980e@example.com", "user_12_980e@example.com", "USER_12_980E@EXAMPLE.COM", "USER_12_980E", "heR0A+8K9G5ghAJWDFSpJFDqr5vD8nlHO0FXPAE1WtlwDLKxC+D7oBIbI4CZzFIj", "user_12_980e@example.com", "user_12_980e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_92c3@example.com", "user_13_92c3@example.com", "USER_13_92C3@EXAMPLE.COM", "USER_13_92C3", "j2Td0V+6KXYYKPYyX8q622uEFGrtv8GKeGdbd8CrwjklXr3wY3xma1Si7+54YObI", "user_13_92c3@example.com", "user_13_92c3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_9efa@example.com", "user_14_9efa@example.com", "USER_14_9EFA@EXAMPLE.COM", "USER_14_9EFA", "xdnv+pH7x21zs5xxHU/b3oNA/gAMPf0pACi7aKHUE9g0DHr5i0nPZplM3lLY+7Cj", "user_14_9efa@example.com", "user_14_9efa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_024b@example.com", "user_15_024b@example.com", "USER_15_024B@EXAMPLE.COM", "USER_15_024B", "6vf30BUFBgLzn6dtACiJMOVm9NVvCHQ5WympDFL8wWgLFc7Pck1HrrV0VxDSTJEa", "user_15_024b@example.com", "user_15_024b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_a93a@example.com", "user_16_a93a@example.com", "USER_16_A93A@EXAMPLE.COM", "USER_16_A93A", "SsMRzC3Q0dMSLe8xraCATcrah3eXobz7Bbz3lrlzZJRH3KlbyeTlq4lNo0EGHbJd", "user_16_a93a@example.com", "user_16_a93a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_8f6e@example.com", "user_17_8f6e@example.com", "USER_17_8F6E@EXAMPLE.COM", "USER_17_8F6E", "HkHvC9Q6mUTcVeZcOz5oQ6aJEvV5wVuN3/0i1uw5/p1CG/97GEZtp3CuhpZnQICg", "user_17_8f6e@example.com", "user_17_8f6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_5ca0@example.com", "user_18_5ca0@example.com", "USER_18_5CA0@EXAMPLE.COM", "USER_18_5CA0", "n8Geg1dNtxEmTE/22tR05Ofak31rnZqBC+ekHCpKiYV9bSyD8vY0OG2TGWVI7nVD", "user_18_5ca0@example.com", "user_18_5ca0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_3377@example.com", "user_19_3377@example.com", "USER_19_3377@EXAMPLE.COM", "USER_19_3377", "asY1CPVC95SnH/hTdhfe7PepUpzYA4sl0QUHChDin7CLIk4384c3UyjScYuihVVw", "user_19_3377@example.com", "user_19_3377" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_c580@example.com", "user_20_c580@example.com", "USER_20_C580@EXAMPLE.COM", "USER_20_C580", "f5wSPUWCjUDWMsp2dOoyowrMidEN18USesmGlgSs4KIwtqeEPJ6A3IVDh+EjPOgM", "user_20_c580@example.com", "user_20_c580" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_2ae4@example.com", "user_21_2ae4@example.com", "USER_21_2AE4@EXAMPLE.COM", "USER_21_2AE4", "BU0yR+U+ZnPyaBCwoZ5DfO1yELZ8SABqfImmnJQao4eQh7JiN9XGej48lylZmmB7", "user_21_2ae4@example.com", "user_21_2ae4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_d930@example.com", "user_22_d930@example.com", "USER_22_D930@EXAMPLE.COM", "USER_22_D930", "1AfdRq8+3li0fDJ4YShlADH68fUNPlgSBWMV/gAH9wodUYpcgDssrcOYdwiLnmCA", "user_22_d930@example.com", "user_22_d930" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_629e@example.com", "user_23_629e@example.com", "USER_23_629E@EXAMPLE.COM", "USER_23_629E", "40l1b/K1XHBH34eTd14apfCdNhen/Yv05bZEnJ8qmAHws3/XX1WB3/2zpG6zT2Fx", "user_23_629e@example.com", "user_23_629e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_e4e4@example.com", "user_24_e4e4@example.com", "USER_24_E4E4@EXAMPLE.COM", "USER_24_E4E4", "y0sZaHOdu7KazZjqIXf9ekvWP/qZaJHc4JVdSvBqLo4SU+tiVnrbUqeiUSwCgAWy", "user_24_e4e4@example.com", "user_24_e4e4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_1d7e@example.com", "user_25_1d7e@example.com", "USER_25_1D7E@EXAMPLE.COM", "USER_25_1D7E", "GkRzUpYKH8ciiIl+4zEtGXwF0TyJGYvi4s8FqCIlfMsfJ9ploSm4C8qlY0jf0bDL", "user_25_1d7e@example.com", "user_25_1d7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_db32@example.com", "user_26_db32@example.com", "USER_26_DB32@EXAMPLE.COM", "USER_26_DB32", "k6GS03kiXEeXoAcmfjx86Fyp0/mZYrbnF6xLeCtDlIx+7PM562QlGvZLOBUhpaG5", "user_26_db32@example.com", "user_26_db32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_5685@example.com", "user_27_5685@example.com", "USER_27_5685@EXAMPLE.COM", "USER_27_5685", "DjiJjPUwtQQklDjKoPt4XuxaFnn2edAWNBwWbEiukYI10ZML+Q/s37rgpkpehMhy", "user_27_5685@example.com", "user_27_5685" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_2df5@example.com", "user_28_2df5@example.com", "USER_28_2DF5@EXAMPLE.COM", "USER_28_2DF5", "F4Nzn1HyIZ/1gKknHVwedXQvBJnJhFrzYXpM8PGjtAIIvk/iwHgik30Fo3o1BpU9", "user_28_2df5@example.com", "user_28_2df5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_2fde@example.com", "user_29_2fde@example.com", "USER_29_2FDE@EXAMPLE.COM", "USER_29_2FDE", "9vHFHaj46gD4TgAQ6xs5N+mefWoCH4xVUHPT8gDks3o6UuXKGrSkrkF5mMOaWIv/", "user_29_2fde@example.com", "user_29_2fde" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_697a@example.com", "user_30_697a@example.com", "USER_30_697A@EXAMPLE.COM", "USER_30_697A", "yRXdtLbjZwI4EkCeWzka/65DBmk/P3XTlpqtP70iBl61Azhu8k8TBF9VYPXxf53A", "user_30_697a@example.com", "user_30_697a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_a80a@example.com", "user_31_a80a@example.com", "USER_31_A80A@EXAMPLE.COM", "USER_31_A80A", "tsfYOfQTGLDueCSzU6mjvP0rj1XXTBBiIJ6vwn9LMXIOXrfbuS0r/Hwkc+/DTall", "user_31_a80a@example.com", "user_31_a80a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_322a@example.com", "user_32_322a@example.com", "USER_32_322A@EXAMPLE.COM", "USER_32_322A", "Wzv7GGo+u9BHqbYDP0d3w8H89jijcf9DUzuu5vNltsCDyllc0QkTpgtPJQwOUjdg", "user_32_322a@example.com", "user_32_322a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_7cba@example.com", "user_33_7cba@example.com", "USER_33_7CBA@EXAMPLE.COM", "USER_33_7CBA", "Rq0vsVVLq3FdGmhA3PVIc7HkfI7Csn9KpAiAMaEn9FPcQkiEyRnf25JAG5lNfwPG", "user_33_7cba@example.com", "user_33_7cba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_ee12@example.com", "user_34_ee12@example.com", "USER_34_EE12@EXAMPLE.COM", "USER_34_EE12", "/r13BSxFJyjF+w2nqnhajgKtseMRSSzqkYuelFVAfSMH0W58znhT3XJrqbRZRUL7", "user_34_ee12@example.com", "user_34_ee12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_1afb@example.com", "user_35_1afb@example.com", "USER_35_1AFB@EXAMPLE.COM", "USER_35_1AFB", "vmIxQph0MmYLPhazjdmEndP/2GUF6B2Th+rfFiVTF3VCGukg1X3A7GC5Z2FcdUe7", "user_35_1afb@example.com", "user_35_1afb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_d903@example.com", "user_36_d903@example.com", "USER_36_D903@EXAMPLE.COM", "USER_36_D903", "HmZdngQY0iNivqtiAckl3UBGk7WZ0XyhAc2Ee4Kek9zs7/sKMkXsOxckOzEcDTNy", "user_36_d903@example.com", "user_36_d903" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_1cd4@example.com", "user_37_1cd4@example.com", "USER_37_1CD4@EXAMPLE.COM", "USER_37_1CD4", "fo1Sy0jFnOrYyKoApFscrUqzLCVXa8PuONguQ8Ehkmv8dpmkh280NB3LzHiEtV64", "user_37_1cd4@example.com", "user_37_1cd4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_ca26@example.com", "user_38_ca26@example.com", "USER_38_CA26@EXAMPLE.COM", "USER_38_CA26", "SU0hnYZStTwAv3dzSFT34GMMnv6urguOLRFFI2W0wyZz3rWSN3xKkWW909AXOGeV", "user_38_ca26@example.com", "user_38_ca26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_d222@example.com", "user_39_d222@example.com", "USER_39_D222@EXAMPLE.COM", "USER_39_D222", "5fEUgAzXTezSrSOvSSd80LMRIDb5G2ko+2fvR09AWkRDrQmegaoXEwjAA1scPS/j", "user_39_d222@example.com", "user_39_d222" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_a76b@example.com", "user_40_a76b@example.com", "USER_40_A76B@EXAMPLE.COM", "USER_40_A76B", "xhnQ4dFyCts20atePTa1sqDghMNDRygC0KQIPCLXqY8w+yfu6t6BeOU7LP3w4fkW", "user_40_a76b@example.com", "user_40_a76b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_4855@example.com", "user_41_4855@example.com", "USER_41_4855@EXAMPLE.COM", "USER_41_4855", "gu/5O7LnZrM7F5ii762XXUHWOE2kiN1Cv4tPpU49prum7JjvgVlYJk+4/31Tah4R", "user_41_4855@example.com", "user_41_4855" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_daf5@example.com", "user_42_daf5@example.com", "USER_42_DAF5@EXAMPLE.COM", "USER_42_DAF5", "zx3iX954ajNRd6VVd9bJJtdw7g/vcU02bddwxbvyHvYUuI1YCA/qteF0hLZ922ny", "user_42_daf5@example.com", "user_42_daf5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_d096@example.com", "user_43_d096@example.com", "USER_43_D096@EXAMPLE.COM", "USER_43_D096", "6ZixlLvaVV7tRNr5PupEFwuRgNJWwOOqyOlllYhvErvgJHMtZVPle9OQFsqp/7MV", "user_43_d096@example.com", "user_43_d096" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_30f5@example.com", "user_44_30f5@example.com", "USER_44_30F5@EXAMPLE.COM", "USER_44_30F5", "7RMeI2cAyeJM4XxRJckc9H2LPtYDAZv720TlJjpHBzwB7+4JYAhdMRXm5/smzueL", "user_44_30f5@example.com", "user_44_30f5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_4771@example.com", "user_45_4771@example.com", "USER_45_4771@EXAMPLE.COM", "USER_45_4771", "R0r/pZfzw3uKA6qw+wuQrPuEDQaL+Mzuwjoig6YJjiHpowhwlehWu2lailMuSIS1", "user_45_4771@example.com", "user_45_4771" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_e224@example.com", "user_46_e224@example.com", "USER_46_E224@EXAMPLE.COM", "USER_46_E224", "deF7exCgdiRx8Xsg0RDeGRrs5SEmGAUDgp6MddzihZq9OtYL2K5JgKySU6PzzxlL", "user_46_e224@example.com", "user_46_e224" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_2156@example.com", "user_47_2156@example.com", "USER_47_2156@EXAMPLE.COM", "USER_47_2156", "Q5OK8KV1MTewBFFazJe7IVLOb5ZpY1ljZQzKgVMlFtOhc5illzvdFI6vtl3vQllW", "user_47_2156@example.com", "user_47_2156" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_a143@example.com", "user_48_a143@example.com", "USER_48_A143@EXAMPLE.COM", "USER_48_A143", "EO5LN0PHh/8/KSKNX1EgdQXDkRJs/jcWifNOzntkS2BKL2SsjPqFMDrNvC46QW6r", "user_48_a143@example.com", "user_48_a143" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_a2e9@example.com", "user_49_a2e9@example.com", "USER_49_A2E9@EXAMPLE.COM", "USER_49_A2E9", "6BTQuiEDBaP4zbV7Y3mKche4QnaZNuKJVBRpnG/iKedqXVrNSRkgkhXo/jJmXnqX", "user_49_a2e9@example.com", "user_49_a2e9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_ce97@example.com", "user_50_ce97@example.com", "USER_50_CE97@EXAMPLE.COM", "USER_50_CE97", "rymaZFm0ArXTo5kQbm2Cpnyo5ErqIcLbXDQ+peeWJ3cSaJzqfqRKGLleIkR8MRkK", "user_50_ce97@example.com", "user_50_ce97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "ydtgl2iBisMeZI8EkgWEsMP5gm8jiqp2GgQ/8An+sOcBwxI9Dc1RDQRDo+mXpmUT");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ProjectId1",
                table: "ProjectMembers",
                column: "ProjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BibliographyItems_Attachment_AttachmentId",
                table: "BibliographyItems",
                column: "AttachmentId",
                principalTable: "Attachment",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Projects_ProjectId1",
                table: "ProjectMembers",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BibliographyItems_Attachment_AttachmentId",
                table: "BibliographyItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Projects_ProjectId1",
                table: "ProjectMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectMembers",
                table: "ProjectMembers");

            migrationBuilder.DropIndex(
                name: "IX_ProjectMembers_ProjectId1",
                table: "ProjectMembers");

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
                keyValue: new Guid("0cc46e58-47b1-45f9-86f5-284030c8e11c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("200a8455-0f72-4c7c-82cb-88675715e23a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e65ee89-dc6e-4db3-9302-46fae6f55aad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c2d1b9e-aeea-4cc3-9974-0d9caf668a4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("403d0c06-5d1d-4673-8f5f-1cf1a3a836c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f08d041-9c36-44ab-ae4c-b02a4029e3e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53d10411-e144-4215-91dd-360af9ec74fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5929cad3-9204-4b8f-a21f-a0b0a8a467c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94ac6dcb-0180-4b82-9ea6-d7a62c51b28d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bef58820-204a-4f07-8cf3-fdea3b935dbf"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1b86dde1-2092-4abe-9192-46bcff04c578"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("20f11132-4529-45c1-92da-adeeedd8bc23"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5d65b1f3-c974-4a1e-bb78-4225065082ea"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fd050ffa-5482-4f0f-9927-e23d7275dff6"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0916ab96-246e-47e4-a06b-febc9eb4d64d"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("96c23f59-45d3-4734-8894-eea79d8d811b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("c9bbf220-dc03-4e10-8b87-66b0f4ccc629"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("cb204c93-59a6-43d3-8f29-258d047fe1de"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3d96deae-d6e5-43d2-89b7-2b00ec491d5e"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b6231be4-d11b-42c1-9847-4e58c2648ea9"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b7eae529-8cc7-43ac-beca-67b455061b38"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ce59b538-8634-4f15-b65b-6ee7ad26cfb7"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d33e6a09-fedb-49b1-a028-7a929a18ee37"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f046dd1a-5f1f-4841-86c7-0317b3876f89"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("fbbff75b-6ac8-45bd-b3a7-07373e22bd76"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b61dfb5-49a0-4588-ae40-d17fbcdc8407"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ad459ad-7a80-4bc8-b23a-465b845fbf03"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f74b354-db81-4667-8a6d-9f9fdc997ca6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ba7a14ee-244e-4cc3-8941-b4a79d63b258"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e7bca87b-5862-4516-8c02-6148cac0f80d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fe07d465-fbc7-42e0-a28f-b9d9dcb15458"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a7c13f04-56d4-46f0-b806-8a2f3c64ff51"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ae9a985a-6451-4d85-916a-9aa6671d4035"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b84e9b02-59b9-40fa-a0a3-49160431fb8d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("eb2abc03-c95b-4264-89e4-827dcbdf91d0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("170475f5-d41e-46ac-ba6a-dd917c4ae77e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("613f8cf1-1725-4b3b-ac0b-8551bc4770de"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("72148966-fa79-4e3e-954a-b5e8acd0334a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("cdb17851-b58a-4b7c-a8e8-33c7ca72a39d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f784af2a-03b7-41de-9f7f-c436b610567a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("52c2b275-b99e-453a-af41-c1d634338158"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6f1d6e4b-d8f0-4486-832f-769d25b4e0e2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("867f2491-a693-4c28-a56c-5bdb123f5200"));

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "ProjectMembers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectMembers",
                table: "ProjectMembers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("058ac7ea-0fa1-49a1-9aee-eec8bd95a099"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("0af6ddf2-fc14-4e80-aeb8-e7374ff31532"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("4104b34e-1d5f-4c09-a4bf-53b649ab5902"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("4773d13c-a6a4-46da-b589-53daa6027edb"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("512dddda-8b69-48bc-a4ed-abcea791117f"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("6fc6c4f6-f5f0-4ef4-aad4-4e07aefb2c51"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("7e40ff57-d825-4136-9c4e-f2a3d9d6f975"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("8cdcce16-0d4a-42ed-a11d-a14db328e2e2"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("b0eb49c6-4484-4427-8496-e2f0dd50bd94"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("e7357a5a-ed1c-4630-9bef-68726e77cb69"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02d16b39-068f-4e9b-9f83-5edf2138ed06"), "CHF", new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(3079), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("144e5560-6754-4a81-a1b1-545c59537696"), "EUR", new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(1447), 2, true, "Euro", "€", null },
                    { new Guid("536c3a5d-bd72-4e51-8537-f3b51372a88e"), "USD", new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(3066), 2, true, "US Dollar", "$", null },
                    { new Guid("ecb5265f-d365-4c05-8924-e292a21bda89"), "GBP", new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(3077), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("157357bd-edd5-4611-9c24-739f70980a38"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(89), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null },
                    { new Guid("326bff6c-7c23-4c17-b5e7-86a11450e290"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(8243), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("737d2787-2a1f-4571-b509-860beb7a98ae"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(73), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("d642684a-4c47-47a1-8109-f126f537efb9"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(85), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6b7faddb-0152-494c-8108-08fddd931166"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2907), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("a5540390-cb48-4fc0-94a0-5438ab352523"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2893), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("b8c075e0-09a1-449a-8cad-37a2006bbfe1"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2813), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("c8c20fd6-4956-4e24-b21e-3cd3ccd88ec7"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2820), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("dc43b813-08ed-45fa-ba6a-80de59d85591"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(587), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("dda9e46f-4b95-4dc7-b42c-151e87e0408e"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2897), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("2e3f723e-b24d-4d37-94a6-03d6ffff0de5"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(4287), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2598e53c-199e-48e5-9e6d-e6c7c8aff8a6"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9123), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("4d3918ed-0929-4d16-9b76-578832ed3669"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9074), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("88f9c01e-d6c4-4cfe-9b6b-166f0e1570d4"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9078), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("943bf88a-a95c-478d-b4e1-965115f81923"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9119), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("d8918f70-37a9-454f-9026-8591ecddb906"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9108), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("ebea86cf-6d3d-4dd0-a7fc-b762427b1ec1"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(7504), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2a6fc865-8476-4796-b6d4-456005259a2c"), null, new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(4799), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("c34adfef-528c-48bd-8d36-634977b924a2"), null, new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(4791), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("e2ff127b-c38f-46e5-afe6-685bb7d8f9d5"), null, new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(3511), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("e49d36d9-e87d-4ff4-97a8-e0cb9b7f1483"), null, new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(4795), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("6e0e428c-8961-44a1-86ad-af24c2d31f36"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(6587), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("9bb4f5c3-c216-4ac2-914b-f29eebcc3abe"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(6575), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("bc9c578e-e25b-43ae-aae2-741657fde460"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(4432), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("c9ed37f3-f886-4ed3-847f-71f66503a3a7"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(6589), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("e506c17b-9d79-4b92-ba2d-30eff6501335"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(6592), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1334022d-4e6e-4325-a5dd-58f4a301e801"), new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(9679), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("6fbefcaf-0251-46a4-87dd-fc7727e9f832"), new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(9676), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("c93703ad-1c7e-4b29-a748-f9a6238bf9e2"), new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(9668), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "/Nez0ZfaApOnLYezCYqgVWfytTwTnsu6b9iuJzh1+tiqC/ppnysCUIN4tpJVBRR3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "b5k6HID6gJPstLpJPRKbcZyLhenwdMuOGs0WcC3+ZK8JmPWgKGDKDukRdJZfJR5l");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_47ae@example.com", "user_1_47ae@example.com", "USER_1_47AE@EXAMPLE.COM", "USER_1_47AE", "X4uDwWM2lCrTk5eUI0XLQgKRjn4rou8av8H2LFZZ8fsIWcOLIWhL3eX8pIBuFbIl", "user_1_47ae@example.com", "user_1_47ae" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_719c@example.com", "user_2_719c@example.com", "USER_2_719C@EXAMPLE.COM", "USER_2_719C", "kwA6y+ooYcLH7aNm+KlAdNirVdZY24Pxq2HcAJbllTKBG1sA2ggA8A/Pxc5QLeUA", "user_2_719c@example.com", "user_2_719c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_f7d6@example.com", "user_3_f7d6@example.com", "USER_3_F7D6@EXAMPLE.COM", "USER_3_F7D6", "uUlQJnY82bknLfMWtJUnw+9+kB+VLVa3Yzu3k4TPByvHx/D9G2/3FFTWTwoxfx8d", "user_3_f7d6@example.com", "user_3_f7d6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_c955@example.com", "user_4_c955@example.com", "USER_4_C955@EXAMPLE.COM", "USER_4_C955", "/BmqP1L5D6MyTAMygXz98lYyZlMTOePsuMUazzB/Iysr5RW/RlbAtK2yUcvm2J/v", "user_4_c955@example.com", "user_4_c955" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_2a86@example.com", "user_5_2a86@example.com", "USER_5_2A86@EXAMPLE.COM", "USER_5_2A86", "LwUdLRCndgVe4AkIuHcRp7vNgMvf48olrywfdujEatLSDn0FIQ8ouQEctIaC7xAC", "user_5_2a86@example.com", "user_5_2a86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_b933@example.com", "user_6_b933@example.com", "USER_6_B933@EXAMPLE.COM", "USER_6_B933", "gjqvPu1IjG/JQnhIEYYyeQEnKlC0QnYl0SUIbto8rUd7qdh3BFOSeBUEl2L8Q6us", "user_6_b933@example.com", "user_6_b933" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_33b1@example.com", "user_7_33b1@example.com", "USER_7_33B1@EXAMPLE.COM", "USER_7_33B1", "Llj2TA8LjNYgqAQLq2owctDhEmgXyhRk9PzVivAu4+/uqydXaRS5DCIVN47Av0qc", "user_7_33b1@example.com", "user_7_33b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_20b2@example.com", "user_8_20b2@example.com", "USER_8_20B2@EXAMPLE.COM", "USER_8_20B2", "fImW9QG1mp9vQrftQmO+DxY39lpfwBLkuBS0q+LD1gY6hXvKHV+qJBaufV78sWgn", "user_8_20b2@example.com", "user_8_20b2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_a230@example.com", "user_9_a230@example.com", "USER_9_A230@EXAMPLE.COM", "USER_9_A230", "6t8SYWYnnVrLxrdhYnK6e/naa5/pYPAzNj3kUnCXwOs+JG12nhRKX1awfsCGqzDd", "user_9_a230@example.com", "user_9_a230" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_02f2@example.com", "user_10_02f2@example.com", "USER_10_02F2@EXAMPLE.COM", "USER_10_02F2", "4MRrPvC+STULZENnuzT4NMiixdyv0xGsl1NXihAvdf49WqWaySf0ovSfZjt3KGLY", "user_10_02f2@example.com", "user_10_02f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_7a86@example.com", "user_11_7a86@example.com", "USER_11_7A86@EXAMPLE.COM", "USER_11_7A86", "vih1H9menqF4T6N6oidczPOH2/Cu5Q6ooDwJSIWAAk7jBsc9WyJWb1SVrWgYNUzV", "user_11_7a86@example.com", "user_11_7a86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_73cc@example.com", "user_12_73cc@example.com", "USER_12_73CC@EXAMPLE.COM", "USER_12_73CC", "FjhHaOB0r85hY7n1i5UwnjmvLUbjoQXEIONoLfoeif+8oktmMS+aO7j0DpVyFMtG", "user_12_73cc@example.com", "user_12_73cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_c05e@example.com", "user_13_c05e@example.com", "USER_13_C05E@EXAMPLE.COM", "USER_13_C05E", "nhUkY+lHNPXYfZlBqpsZ3nx63zzlc3fezNSr/suUdRGGLPs0pI0pdwGMngMjSbib", "user_13_c05e@example.com", "user_13_c05e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_ee69@example.com", "user_14_ee69@example.com", "USER_14_EE69@EXAMPLE.COM", "USER_14_EE69", "3t2dFPMu3tlgOUjthM3ZQioQ+A3L3F7bZKUA6Sy1ppJotS4iSRryDyu5LMHlJ0Jo", "user_14_ee69@example.com", "user_14_ee69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_9347@example.com", "user_15_9347@example.com", "USER_15_9347@EXAMPLE.COM", "USER_15_9347", "h7RChsgGTqcResnr9zLzNePnnoEiJxPhGWTDM0xG+ZkcCBL904DnL1mNKRKJq3j4", "user_15_9347@example.com", "user_15_9347" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_c077@example.com", "user_16_c077@example.com", "USER_16_C077@EXAMPLE.COM", "USER_16_C077", "k3FAFWuDJRx+TY2iA5V6t9OX9woFUhXFKsiZ+8+6Mx9HXp9kzT+hGPQxzRoJd0+c", "user_16_c077@example.com", "user_16_c077" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_7a2c@example.com", "user_17_7a2c@example.com", "USER_17_7A2C@EXAMPLE.COM", "USER_17_7A2C", "ZbDitljPeFqitxW+m0jm4ry3VZYHgJ+FHyncMfdJHmv6VzL4sticbtK3XPRs91PV", "user_17_7a2c@example.com", "user_17_7a2c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_b46d@example.com", "user_18_b46d@example.com", "USER_18_B46D@EXAMPLE.COM", "USER_18_B46D", "XnlgUTWM1fk+EP0rdBM4jCMH1g+/gmcdhLxfJGY5kfLzs4LAUwFbo5INxDlmupyN", "user_18_b46d@example.com", "user_18_b46d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_f825@example.com", "user_19_f825@example.com", "USER_19_F825@EXAMPLE.COM", "USER_19_F825", "ue+7nMetdbPzWoBKUdt+DbkoGgTPL3Cox2SoD2X0a+BRit+nb+eLNDV82Dr89/oN", "user_19_f825@example.com", "user_19_f825" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_d5c5@example.com", "user_20_d5c5@example.com", "USER_20_D5C5@EXAMPLE.COM", "USER_20_D5C5", "PYuZaPvwYLFi3zw7K+4iIMErpUdUfjmLJiV7C04gypFCgF258VYy+IBbg0hV2vBi", "user_20_d5c5@example.com", "user_20_d5c5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_041a@example.com", "user_21_041a@example.com", "USER_21_041A@EXAMPLE.COM", "USER_21_041A", "uvGk9q8p3BA7LCyfe5nnuN+GG97D7YDN/yqowhHnNbYEj3a+32s28v3vvuqJq10H", "user_21_041a@example.com", "user_21_041a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_c40a@example.com", "user_22_c40a@example.com", "USER_22_C40A@EXAMPLE.COM", "USER_22_C40A", "V2ITgoMNsAvO4BPqM07bzstfutOMSsZIiQYYoxXv6fwu2Dug8jP3zAE4v704EpBn", "user_22_c40a@example.com", "user_22_c40a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_f163@example.com", "user_23_f163@example.com", "USER_23_F163@EXAMPLE.COM", "USER_23_F163", "XTYUM4YzrKfVQPk34tXCola7ZUkAcYxorESF2SkrSTUEQGH2uQPflU48WTxr321U", "user_23_f163@example.com", "user_23_f163" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_3849@example.com", "user_24_3849@example.com", "USER_24_3849@EXAMPLE.COM", "USER_24_3849", "E7Of5nkgw7Yv02sCA50AVMG2V0NPEWOy9IusVtQX9WJOLo3jCzKo9OyQnSkz0T6d", "user_24_3849@example.com", "user_24_3849" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_ac40@example.com", "user_25_ac40@example.com", "USER_25_AC40@EXAMPLE.COM", "USER_25_AC40", "rAq4q8KTrNhcDIoRBIZGI24oUA3gHOq+PqgQD/jIaMfZZSbuTeVfbMRZ8JdPAnl7", "user_25_ac40@example.com", "user_25_ac40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_ba0b@example.com", "user_26_ba0b@example.com", "USER_26_BA0B@EXAMPLE.COM", "USER_26_BA0B", "MKg5rqv7rnCVLSRC8zwTY92p4zNoFfNG4nbaqBJPDpS68j9JkhnXO+tORoy6az7h", "user_26_ba0b@example.com", "user_26_ba0b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_b779@example.com", "user_27_b779@example.com", "USER_27_B779@EXAMPLE.COM", "USER_27_B779", "npnfFhUc6FIybW3dWTM+YUKN58CVqBbNxW/+RhAxdQic3uLMGPJOIszw/fpb2DTh", "user_27_b779@example.com", "user_27_b779" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_7b36@example.com", "user_28_7b36@example.com", "USER_28_7B36@EXAMPLE.COM", "USER_28_7B36", "8kHg0uYGu6gxDedHCTzhe7apSX4QoBieQpHhqBn+gIY7Su31guvyLVRQmp9rRX/M", "user_28_7b36@example.com", "user_28_7b36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_f8bc@example.com", "user_29_f8bc@example.com", "USER_29_F8BC@EXAMPLE.COM", "USER_29_F8BC", "L7qjSpX3YlllhY5RVdmZeVBcQJn+P+cCdw/+I1l8kbSBVy1vhtrAGr2OTebIldSS", "user_29_f8bc@example.com", "user_29_f8bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_dbd2@example.com", "user_30_dbd2@example.com", "USER_30_DBD2@EXAMPLE.COM", "USER_30_DBD2", "qe5jyNMrgxs9ZDZf/VJfSm3WqflGMFHz1VVJain3bgYw298M+O3BlOytx3VSKDyT", "user_30_dbd2@example.com", "user_30_dbd2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_7ef4@example.com", "user_31_7ef4@example.com", "USER_31_7EF4@EXAMPLE.COM", "USER_31_7EF4", "GM4Oi4ib9lzNSlgf0r7nI0Gph22ASyDo8kAqq+kf6RLJwAJJwEBNYfbZrrYb807N", "user_31_7ef4@example.com", "user_31_7ef4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_3ce3@example.com", "user_32_3ce3@example.com", "USER_32_3CE3@EXAMPLE.COM", "USER_32_3CE3", "N8mP3ishwVSFxg1T4JPiHjNMLlFu2miRJVnBS1GxJpW16LqO4eA4TV99PJb8ZiOf", "user_32_3ce3@example.com", "user_32_3ce3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_c8d2@example.com", "user_33_c8d2@example.com", "USER_33_C8D2@EXAMPLE.COM", "USER_33_C8D2", "pEQp9/YZs8ehoI2wY7CqgWNI5LrU3f/EAKUHJ8blSZ4TKcpthEZqN0WqSJzD6aZ+", "user_33_c8d2@example.com", "user_33_c8d2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_cde6@example.com", "user_34_cde6@example.com", "USER_34_CDE6@EXAMPLE.COM", "USER_34_CDE6", "TeKmii9zUxXyEgjy9NIo3xLZRGIUOkkFHsEz7ae/2XkIaZ/Ws06hTzO92qR+cGp1", "user_34_cde6@example.com", "user_34_cde6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_6f91@example.com", "user_35_6f91@example.com", "USER_35_6F91@EXAMPLE.COM", "USER_35_6F91", "3TdjdPP/vzBE6hHyGpsXtW61wIieuxrdGIfRlPbdxFy0s6CIBRQLL9KcUt9FKEAd", "user_35_6f91@example.com", "user_35_6f91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_f87e@example.com", "user_36_f87e@example.com", "USER_36_F87E@EXAMPLE.COM", "USER_36_F87E", "56gHgOubGxbt/Veq8DAlsN12JeeN2FCjLIWIe7lWlIPXeXeD/eVB3VFvRfq3XiEf", "user_36_f87e@example.com", "user_36_f87e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_522d@example.com", "user_37_522d@example.com", "USER_37_522D@EXAMPLE.COM", "USER_37_522D", "oUGfM4suzGFvDkasNHV/HbPLzd276jjiLP14aoj07EbYYUzKxzKHLG7YAR/il6y+", "user_37_522d@example.com", "user_37_522d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_0cee@example.com", "user_38_0cee@example.com", "USER_38_0CEE@EXAMPLE.COM", "USER_38_0CEE", "vYlff7xxZ7L4YETjBm57+yL0kn3K6SEaC6i/kNpRK0+MvF2vMbAJhvXGLd/uGydf", "user_38_0cee@example.com", "user_38_0cee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_5999@example.com", "user_39_5999@example.com", "USER_39_5999@EXAMPLE.COM", "USER_39_5999", "MnE6YOEpE+Of+l7G8NY4K8a2tllrauZMF00UewLG5TM304coJiwUOFHG0WN8LqNv", "user_39_5999@example.com", "user_39_5999" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_7c58@example.com", "user_40_7c58@example.com", "USER_40_7C58@EXAMPLE.COM", "USER_40_7C58", "gl5d8J3pj7B7h140yfyer7Qs5NWkAvVd0tID0NCSatPl4yK/WuqigWKKwYtPj5n7", "user_40_7c58@example.com", "user_40_7c58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_fc2b@example.com", "user_41_fc2b@example.com", "USER_41_FC2B@EXAMPLE.COM", "USER_41_FC2B", "zPv0FhZi4rHdsYWmsZ9RbZZ/mtRFIKbpYUEALrOCruimdci/HTMmuR6zOeD8HxMh", "user_41_fc2b@example.com", "user_41_fc2b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_873a@example.com", "user_42_873a@example.com", "USER_42_873A@EXAMPLE.COM", "USER_42_873A", "/v6MkD9lsCpNQrRT0yRxWJRa+9prJAhmQT/+GOw3reVYVZfEQgjy+DIxSfrBttuo", "user_42_873a@example.com", "user_42_873a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_f4d8@example.com", "user_43_f4d8@example.com", "USER_43_F4D8@EXAMPLE.COM", "USER_43_F4D8", "mPQYMKtSbauhm8V6DKrdJdpOBhYg33+FAmPz8JPJAThua3LQVZ9CrNorDKzuya/0", "user_43_f4d8@example.com", "user_43_f4d8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_d28f@example.com", "user_44_d28f@example.com", "USER_44_D28F@EXAMPLE.COM", "USER_44_D28F", "zBQ/sLNea5xkCmTGLodPqgjocG0cfcuvkCre81v/ZgupW03mV0gqoOIT9GrkA4fE", "user_44_d28f@example.com", "user_44_d28f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_9bdd@example.com", "user_45_9bdd@example.com", "USER_45_9BDD@EXAMPLE.COM", "USER_45_9BDD", "odC2aiYfN0cqk+JtUZRkaQg7/ruLXXfXfTv3ti6HtUOzca/95Wwg/K6akZ+6FarJ", "user_45_9bdd@example.com", "user_45_9bdd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_7d45@example.com", "user_46_7d45@example.com", "USER_46_7D45@EXAMPLE.COM", "USER_46_7D45", "3JkkvoN0KO+ufKskUJdQ8MdoBwbTtmTbpmfHyXyBGMuY2KtO6k3KFG4yrIVuf9iD", "user_46_7d45@example.com", "user_46_7d45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_48cc@example.com", "user_47_48cc@example.com", "USER_47_48CC@EXAMPLE.COM", "USER_47_48CC", "5VY06uC2klzrxcHu1kuFZVwF0zcsTklTFe2MKmBw+nP0+dubaYt+ajZvZAzCT1Oc", "user_47_48cc@example.com", "user_47_48cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_fb05@example.com", "user_48_fb05@example.com", "USER_48_FB05@EXAMPLE.COM", "USER_48_FB05", "27f4q+0cQRnZKbECr68YNndqdmkeSic60hLwVRMPID62PN/CrfNWNDYBuGsUy1fS", "user_48_fb05@example.com", "user_48_fb05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_813f@example.com", "user_49_813f@example.com", "USER_49_813F@EXAMPLE.COM", "USER_49_813F", "IdQIfn8XE3aOS+jTGkdKU7m0P9Z8vRXHMMCsYlFylcuEpuqsQpUPBliByFbxEw6J", "user_49_813f@example.com", "user_49_813f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_6a52@example.com", "user_50_6a52@example.com", "USER_50_6A52@EXAMPLE.COM", "USER_50_6A52", "//057DRCgEvvFP7Zi7VYGMaCMUkqHRYQk492G3OR8FU6YfL+ZR5t+jsPLmw0OMSs", "user_50_6a52@example.com", "user_50_6a52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "+k+H6GPl4XJagn3kndeKw3FJ+tZhN6aYJsMSUX89XsC+kzwR74XLQ+8w5GgNwd89");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_UserId",
                table: "ProjectMembers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BibliographyItems_Attachment_AttachmentId",
                table: "BibliographyItems",
                column: "AttachmentId",
                principalTable: "Attachment",
                principalColumn: "Id");
        }
    }
}
