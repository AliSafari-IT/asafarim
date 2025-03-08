using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProjectUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06c8a551-c8c5-49cd-b643-c1a3971a1859"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36a3043a-b8d1-4e79-8c5e-619fc3392d8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d28ea38-e147-4360-b0af-19a88135d6f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("778154a8-7a17-4fad-b70c-04390b7269ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f60492c-f6d6-4b01-95c7-2d344f4131c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a595695e-7244-4dba-91da-ef65d950d6a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b185d158-017e-438f-9084-1f52943931a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c170a298-0f10-457a-884d-fe4828eb9d1c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8fec41b-acd7-460d-b387-477ab8b893e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0e8c398-9641-4198-a35e-af4c8cbf894d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3ea535f6-e9c7-4203-928d-2662d5f8eaba"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6393799a-4356-43b7-ab67-fee9a3b76eae"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6deefca2-8c56-453e-ab03-ee777f61187b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b9981069-f25e-4b60-8b7e-ae63f6844ef7"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("055e9e01-e069-42d2-94cb-4e0c75f2fbd9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("70a7c311-d893-4dce-8ea9-e919c11a88a6"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ace5e81f-42da-42ef-90a1-dc8a770c8103"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("eb319d94-2c87-4db3-aecb-bb35c30b6d3f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0fd17864-0a05-4134-97c8-e5788d06284c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("32ad67d2-1c3c-4054-b74b-6147620f8eee"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("64284b75-1b9c-4696-b1da-cd9bfd44897b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9741619e-0617-4fd4-9b06-69f430fc0d3f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ab1c444d-d4aa-4062-93a9-c0640063ad47"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d2ea900f-5cf0-4730-9029-db46f160257e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("2afb9d8a-0632-44d6-9b84-9d2fdd45286e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d4dc5d6-dc85-414f-843f-a2dbf413fa03"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4d38ea0e-1978-4ca2-84c4-82a6e241adc4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("83793248-a7da-4910-8874-ba32daa8e31b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8eaf27f8-ae32-4593-b1b8-fadcdd0ef1b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9f22226c-5b44-4a9c-88ff-4b0e7f172979"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c7766dfb-fefa-41fe-a936-4b9ef505dffb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0b941b36-14a8-493c-971d-c5429ddd35cd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("137af052-56e7-454b-bfe2-30c187c29ed5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("33c48aeb-01fd-4e44-8a72-0d1706eef070"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("53468b15-3b44-4927-acb8-2a5cbed415c4"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("361211cf-b50a-45ba-9eac-4e8fc8bc32ee"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("4453b21c-2b72-4f74-998d-a0d2ab98d09b"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("62e9040b-0376-4bd9-8404-0f14c8199ea7"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("8944f0c6-4566-488a-a1e4-0d192c08f6c6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("d2ec402e-7000-48bd-b290-43ffffdf70d0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1dd7f781-a870-4b61-b855-6a5e9792fe54"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("27736283-a5eb-41aa-9f8c-f3295430d698"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ffe9503a-9b24-4875-8ef6-9ef423bcd1c3"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03d56106-5458-4634-a9ac-2b63c98d21f4"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("121391ed-b992-4768-93b3-87bb2ca7c29a"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("1e73e38a-4295-4e6e-b756-6d6a658f937e"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("299a1453-669e-4db8-b882-0335598784a8"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("338857c7-aca1-42a4-994c-6ecd87c8e772"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("3efb797e-9e62-4e86-b05e-5037e461be9f"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("52752fd1-6850-4d46-b396-ac94a79a5380"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("8219507a-dc5a-4a02-b8c0-ba7ad1d1e835"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("b3bd33d2-150d-4b9d-bff0-dc257ba3f079"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("dde8c486-12e6-4fca-87a0-8b31bcf70050"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("796fad72-78ac-44bb-a3e1-2f4f3a5299b3"), "CHF", new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(3682), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("815b2eef-ed9c-4acc-a7bb-5a8aab2ad3da"), "USD", new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(3644), 2, true, "US Dollar", "$", null },
                    { new Guid("8b4e227b-1136-4b13-b83d-1655311188d2"), "EUR", new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(2686), 2, true, "Euro", "€", null },
                    { new Guid("b44d5f45-4546-4f46-b964-8307b31cfcfc"), "GBP", new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(3675), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0014142f-aa02-479b-bed1-410b7275b9c9"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(1991), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("1d4dce87-947e-4483-ae34-8ff1729b276e"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(1988), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("9550dee8-5d36-42ec-8407-ed59508a6a53"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(968), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("fc4b405a-5579-4877-8e22-cee84044b62d"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(1982), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16589182-3c84-4c2e-9af8-ee4f33a3022d"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8059), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("5524fb23-d494-4511-961e-b9088806138b"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(6919), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("55a26735-9e42-4a43-ae18-83aac29d8543"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8065), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("5cb67213-fdcf-4719-a897-5147401d75c8"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8053), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("64f25bd2-e453-4d41-a8ba-95d1b3fdd4f8"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8061), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("d8ee0a7a-ceb9-4810-a9eb-7706007d468b"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8063), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("6193ac30-14b2-4c4d-be56-442ae714a47a"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8992), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1f410b04-92a2-4e72-97e5-f02ec4b0039f"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5890), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("29a914f5-0d34-4aca-a2af-2a8d1090e12b"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5879), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("3475bb84-3db4-4030-8895-cdd6b764938b"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5873), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("3bebe8c9-adcf-47cb-8c87-3a4ee7e9ceeb"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5892), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("413bbb51-64b3-4c52-8c91-667606c2aba4"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(4824), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("bbbf5bb9-deec-4f2a-b705-861e5123ea5e"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5881), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01920b21-024d-4c6b-96f2-91235baf8a33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("07679d34-90b3-4d50-9848-3c2b96a6c1ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("1fee52c8-5ed1-4218-aa16-a92f6d4ee17c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("73f7bac7-2c73-4869-b782-32a7f0979879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("037a08e2-1b3c-42aa-9865-4ebebb77cf8e"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(5544), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("2988f9fb-364a-4aae-928f-7ed10e181422"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(5539), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("39b77345-c09e-4982-98d3-f6dc9ea26ecf"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(5546), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("5f6d88c8-c02b-419d-b4c3-b57e8d8915ef"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(5548), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("ac5cff22-6ec5-46a7-86c5-f782ba2a47fa"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(4380), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 8, 46, 55, 583, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0e7c8fb9-ec48-4db2-a935-01b1fff7a35c"), new DateTime(2025, 2, 26, 8, 46, 55, 583, DateTimeKind.Utc).AddTicks(2805), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("ca75b08f-c5fa-48e5-bc55-fb60642bed4a"), new DateTime(2025, 2, 26, 8, 46, 55, 583, DateTimeKind.Utc).AddTicks(3076), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("e1ffebc9-e2ab-4fbc-9af0-6f5a1929418d"), new DateTime(2025, 2, 26, 8, 46, 55, 583, DateTimeKind.Utc).AddTicks(3082), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "2eglRDK78LC4haZrynmOc1dmaf5RooOP+eFO6GcS1/YXWjvZDGS9xkqSy2DuIx46", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "jO0au6lVKdVs10F8s5J7DYvHcjD/LXI1LCHyHMa1Aozh8T5GS5WZaYlu1pbGVNM6", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_8414@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_1_8414@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_1_8414@EXAMPLE.COM", "USER_1_8414", "diJWpmmujBhDQ6o0IFohPJLPvQStz1ESqDxDlSwQWhl3PuAtJV2JiDUoRUzA8FlW", "user_1_8414@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_1_8414" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_225b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_2_225b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_2_225B@EXAMPLE.COM", "USER_2_225B", "7iuGKLN/XkzcMJTqc+Kr1n2X3AzybNRYhtaKkRdK19OpM37x9rlR4adMJlH0fK0E", "user_2_225b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_2_225b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_e36f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_3_e36f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_3_E36F@EXAMPLE.COM", "USER_3_E36F", "KJvTzFbx56ib2mjMLOboRONhcR7sguyJOaKd21DDtfEDR7j7UYO997PMNYFiE7qq", "user_3_e36f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_3_e36f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_3b3b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_4_3b3b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_4_3B3B@EXAMPLE.COM", "USER_4_3B3B", "IhXbUmddQDJMnS74+tSAtObBL59q2SNDcXd/gupqFg75fQ8mRF3MV5DTZS/d+HBk", "user_4_3b3b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_4_3b3b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_dd11@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_5_dd11@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_5_DD11@EXAMPLE.COM", "USER_5_DD11", "Cu65hyp/K7eKppJjHfm9/+8n1SX56KhC+Jmen7dv3Tgv1STwQE4KDE8XIOiFZDIH", "user_5_dd11@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_5_dd11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_239d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_6_239d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_6_239D@EXAMPLE.COM", "USER_6_239D", "3JzCXyP/wTAuSYsZ0EqYpXGKoLfLmjO1YT7lIQvi73wPa269Rj+djogp5D8d3wcF", "user_6_239d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_6_239d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_1c66@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_7_1c66@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_7_1C66@EXAMPLE.COM", "USER_7_1C66", "FsatcwSSJ3ZKCZIigQSja1HHgtIeEqSNphfBOYbCAiJM2xxTGKDOBwRoeH0Fgonl", "user_7_1c66@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_7_1c66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_0c79@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_8_0c79@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_8_0C79@EXAMPLE.COM", "USER_8_0C79", "V949JdTxn2rA+0pCrXB95NwOjcZdyd3kXZECihHG40ulPGOBEmGqMuFZolYJ/N8z", "user_8_0c79@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_8_0c79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_b29b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_9_b29b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_9_B29B@EXAMPLE.COM", "USER_9_B29B", "Yjnz2CwNKX7CRtDTQDSVsSxag+EcMREMhWjfA8UBFG+2vEBW7umVf9Ca7QekxwBR", "user_9_b29b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_9_b29b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_9d1e@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_10_9d1e@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_10_9D1E@EXAMPLE.COM", "USER_10_9D1E", "G8t3+A4TYHzCth+T1es4Ly6+cEloOjiu5crR4gnBRR5IoK4AEzKj6A7kom85c25b", "user_10_9d1e@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_10_9d1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_11_f125@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_11_f125@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_11_F125@EXAMPLE.COM", "USER_11_F125", "qR/EkuzQcJ2ertSsHyszxbDgArgu6THnfd7HSvQGjwVodNLcrG8fRDZ2cDahbHEt", "user_11_f125@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_11_f125" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_12_7be9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_12_7be9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_12_7BE9@EXAMPLE.COM", "USER_12_7BE9", "DAx6BgDq5167rYcNqH1rHqE1DRi2Su3EtIZeuiu4uA7WlQnpHhPk8nSGzunEmF4P", "user_12_7be9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_12_7be9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_13_3417@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_13_3417@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_13_3417@EXAMPLE.COM", "USER_13_3417", "AKbkBBhCP30oRHZcR38mOEao31Ol7O5qiWICmTTTJOeddag8D99ot7A5z1QZ76Y6", "user_13_3417@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_13_3417" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_14_e999@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_14_e999@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_14_E999@EXAMPLE.COM", "USER_14_E999", "IHLMJYJoLXyRRkfeBVbs31O2A4sr7oiUmsooq0EZmmcSSr6cBYqv2bJDpmndcCys", "user_14_e999@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_14_e999" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_15_afcb@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_15_afcb@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_15_AFCB@EXAMPLE.COM", "USER_15_AFCB", "8YXtfsjM+27sZ2ixS3Hi1o6+zG0DBMxSFk+hL6aNm4HG5IKCLn73N7jCZNr4EMEb", "user_15_afcb@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_15_afcb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_16_a028@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_16_a028@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_16_A028@EXAMPLE.COM", "USER_16_A028", "nDmmpwqE0vGKW2JNtIe0SMn4Ac32LcDEHbB3yvilTDZpNdpE5zBa284FKXh+B21g", "user_16_a028@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_16_a028" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_17_575a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_17_575a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_17_575A@EXAMPLE.COM", "USER_17_575A", "wro25MbdSugpXG/EHCwTpN4BBzhDwGQ8Y7BAKGHXuQ5ZLl/uztwpvGde6k3oK+xI", "user_17_575a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_17_575a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_18_e474@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_18_e474@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_18_E474@EXAMPLE.COM", "USER_18_E474", "vLl4vilrSpnf/6GFHMz7vzBKeUr/ZwvwWj4hH3fJHVHvV6YR4S1R4kKPyLY9SKQB", "user_18_e474@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_18_e474" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_19_6100@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_19_6100@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_19_6100@EXAMPLE.COM", "USER_19_6100", "2gK20OJS8p6KS8m7pvG5Nz3VGgmXySdX8jCTWyn3pqyE7ao/M5580vNPl4FuOpip", "user_19_6100@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_19_6100" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_20_098a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_20_098a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_20_098A@EXAMPLE.COM", "USER_20_098A", "6V11c1T3FDZZ4sSdvEuWMBDzOllXNDxxnWUiRWr9+MFRt1GvZlIw12+yGwLpcG3o", "user_20_098a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_20_098a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_21_fb9d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_21_fb9d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_21_FB9D@EXAMPLE.COM", "USER_21_FB9D", "JvnX8PDnRt59+sV16aJ0CF4U68490PhtWQQt1auUnFRdo9lJnz0/Z8G4tn8HS4RZ", "user_21_fb9d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_21_fb9d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_22_82f4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_22_82f4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_22_82F4@EXAMPLE.COM", "USER_22_82F4", "OTcNlqVBgrJLQ1x/kSUbhheqJy5Ngz4MdHQFggcVEdXP2IqDavfZJ1P2CIhm0dzN", "user_22_82f4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_22_82f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_23_fe48@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_23_fe48@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_23_FE48@EXAMPLE.COM", "USER_23_FE48", "rKGZ9FMDsb3Hf0TZUicVdnQLTp1lvK1aCZ5X5djXJ8Fbnd283IZbe1VlsoFzZufU", "user_23_fe48@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_23_fe48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_24_6118@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_24_6118@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_24_6118@EXAMPLE.COM", "USER_24_6118", "TJwaIGhM9R1PYKJFxNvc6ErJt7DVn6+XbMpzeZLohoG4X+9XEJJku0bRtVK+ylNg", "user_24_6118@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_24_6118" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_25_fd2c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_25_fd2c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_25_FD2C@EXAMPLE.COM", "USER_25_FD2C", "0Wp3c0pWjonEIckHuJ3I84B/OXkKbvzQQMZhSp0Nh1yT/UehajrtTTClVot7HEgQ", "user_25_fd2c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_25_fd2c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_26_74e2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_26_74e2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_26_74E2@EXAMPLE.COM", "USER_26_74E2", "J36yQvRge51D7jdlxX2CkgMFR84QUBt/fc163r9Wz8Y+U3QbwWztVJHdRfYNZa+b", "user_26_74e2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_26_74e2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_27_aced@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_27_aced@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_27_ACED@EXAMPLE.COM", "USER_27_ACED", "h3j82f7Olc6Ek4rEb6ZnN8oO2HjHAuoE1iilbpYiqtA/W/7Y6LVtZw96nilxHT6r", "user_27_aced@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_27_aced" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_28_9573@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_28_9573@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_28_9573@EXAMPLE.COM", "USER_28_9573", "q2oE7AL95cz8e43fjNkSvJy8LPt+4Y8h5hCGce59rlg0fjQ/VrM11qkYXMdQlLNg", "user_28_9573@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_28_9573" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_29_8b86@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_29_8b86@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_29_8B86@EXAMPLE.COM", "USER_29_8B86", "I7YsYm0E07mC7bLTWHfIdHifofVsLH95EyBzFC7zShBzJttw0EGUHyIvaWb3IxpR", "user_29_8b86@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_29_8b86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_30_d639@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_30_d639@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_30_D639@EXAMPLE.COM", "USER_30_D639", "hlNxifdC24rQlvyeDD96XI8jk2TQ7m1PVajniPLzH0i6wgYaLT8VjcFf4iPM18q9", "user_30_d639@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_30_d639" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_31_3e53@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_31_3e53@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_31_3E53@EXAMPLE.COM", "USER_31_3E53", "z8CoIuKMpWyoFBjtrHOGKbaK3UnMbdu+/sWa3lDuUHaw6Uj1Xh1pMo23adxNNFB6", "user_31_3e53@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_31_3e53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_32_4114@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_32_4114@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_32_4114@EXAMPLE.COM", "USER_32_4114", "568jXMRIO6/4indsJJUg4jN1STEAhmldI0cQ9Y/VqeOTPW3VjzHiasQfXjE0mTRi", "user_32_4114@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_32_4114" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_33_4f7c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_33_4f7c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_33_4F7C@EXAMPLE.COM", "USER_33_4F7C", "wohaiHIXUlIoeyG5HlpCgxEMjqD0VgyXWFJxGPBiEKmoOWXIMJXxDddURbCd6ugM", "user_33_4f7c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_33_4f7c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_34_7587@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_34_7587@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_34_7587@EXAMPLE.COM", "USER_34_7587", "fqvf5gLLFMTnDU2fRsK1trFy9mJVbPtGQd4i5cKkeuLavODm7yIk5KEkfoOSUewS", "user_34_7587@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_34_7587" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_35_57f9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_35_57f9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_35_57F9@EXAMPLE.COM", "USER_35_57F9", "hhFh3mBiDZWmLaPh9UN2k/UqIVxklf3p2L14kDCwOiquGdKn/bB54xL5/4Ma5SkO", "user_35_57f9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_35_57f9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_36_bf10@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_36_bf10@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_36_BF10@EXAMPLE.COM", "USER_36_BF10", "EMnZgFJ2wJ1gcX9xG3KNNidWyzhXQq4qYB4W2X8qFBo9Z/GdDicE3mPKjZIOuxZJ", "user_36_bf10@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_36_bf10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_37_713d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_37_713d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_37_713D@EXAMPLE.COM", "USER_37_713D", "PQB8Wzxq2UgPQDXdc4UBzKXQdsAgtMM6net3Fx8krmxunx7lsiY7A65O8I0ZBWZN", "user_37_713d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_37_713d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_38_abd4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_38_abd4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_38_ABD4@EXAMPLE.COM", "USER_38_ABD4", "FTG36Tz6RZfb9klFPcKJLnLdaqoJbs02qOdBnx6WB4Px47WG0mS8hoDA6tIg8Uaa", "user_38_abd4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_38_abd4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_39_dd7d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_39_dd7d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_39_DD7D@EXAMPLE.COM", "USER_39_DD7D", "Y+wka8WuAqYWjuuFJY3SWXzmWnya/15DHssX4mGgEo+68x6o1Y741ONt9igBMlYl", "user_39_dd7d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_39_dd7d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_40_685d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_40_685d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_40_685D@EXAMPLE.COM", "USER_40_685D", "h18KUK1S4S5U5seuLe6RxXJ6YCBtRUs4uH5msZP2QfXi96c/SHY+/5RnAr9Ge9J9", "user_40_685d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_40_685d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_41_6ec2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_41_6ec2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_41_6EC2@EXAMPLE.COM", "USER_41_6EC2", "fZGUFBwBjry0GVIgr4UG3rAu5l+TimDEtWqJPY1jT3BhqOzCLTYJvlDCQWfqBAFe", "user_41_6ec2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_41_6ec2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_42_d7e9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_42_d7e9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_42_D7E9@EXAMPLE.COM", "USER_42_D7E9", "SGueps9XgbXgE7+JRMwvK4fpziqRiqqmXhg7n3lcENLCHdx+gfo+T6Q/Uw8of6WT", "user_42_d7e9@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_42_d7e9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_43_ddb4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_43_ddb4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_43_DDB4@EXAMPLE.COM", "USER_43_DDB4", "T7AyP2llSeHusNOSEea5k2uqkRbR6J5XC/jwcxfzdfcO5Otpp7RndSES2IvX9EpJ", "user_43_ddb4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_43_ddb4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_44_7025@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_44_7025@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_44_7025@EXAMPLE.COM", "USER_44_7025", "c4kdS9Mt2W5LFtQbDiCs+NUxV4Kd0+Oou2WBZLH/1os9FCZjWpcyVR05/bgOZUjk", "user_44_7025@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_44_7025" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_45_fe9a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_45_fe9a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_45_FE9A@EXAMPLE.COM", "USER_45_FE9A", "cuq0drW4773ycBbQb//Jf8JdyKbhGqZbA8BZuT1BvBwcOeZVfnsDod3AJ7ODjgtA", "user_45_fe9a@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_45_fe9a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_46_4eb8@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_46_4eb8@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_46_4EB8@EXAMPLE.COM", "USER_46_4EB8", "4k5g318JivTJYdP1XEZwZRcHzOMZeSh6+0dFjd0AtFbBN3/16y49KMnrXoZjGtuf", "user_46_4eb8@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_46_4eb8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_47_c723@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_47_c723@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_47_C723@EXAMPLE.COM", "USER_47_C723", "8wEPjdUitjS5izbFXNgh586qPWC2CGAmAAEcMYBgG7MpqM15LU6jvb+MgGCLpKzz", "user_47_c723@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_47_c723" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_48_5591@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_48_5591@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_48_5591@EXAMPLE.COM", "USER_48_5591", "iS0G/2ewwIOLl3VkWTDgN62pUPb2JmNVT3mLQ7Ia87B1CS7FwDaBxS2hVfhdBD3/", "user_48_5591@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_48_5591" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_49_58b4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_49_58b4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_49_58B4@EXAMPLE.COM", "USER_49_58B4", "H3c9/HTMWmdwmXp5u4aoMSx33WXAcJoFm1DkueXPTJhgG7joR27S3bIwKaYCtx6+", "user_49_58b4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_49_58b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_50_23e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_50_23e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_50_23E7@EXAMPLE.COM", "USER_50_23E7", "HuGq0ZjpjtbZKYvZuucmSOcrM4rjhYcjgfz7RIhVZKzx4bxAr8Pa6G4zJNCJMolN", "user_50_23e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_50_23e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "FbJXQ7XOvSrmQeqm0VkXF0NNDCozdx5693yLqqhF1G8qXhWVuEs2Vly9CiLTAW7G", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03d56106-5458-4634-a9ac-2b63c98d21f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("121391ed-b992-4768-93b3-87bb2ca7c29a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e73e38a-4295-4e6e-b756-6d6a658f937e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("299a1453-669e-4db8-b882-0335598784a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("338857c7-aca1-42a4-994c-6ecd87c8e772"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3efb797e-9e62-4e86-b05e-5037e461be9f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("52752fd1-6850-4d46-b396-ac94a79a5380"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8219507a-dc5a-4a02-b8c0-ba7ad1d1e835"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3bd33d2-150d-4b9d-bff0-dc257ba3f079"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dde8c486-12e6-4fca-87a0-8b31bcf70050"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("796fad72-78ac-44bb-a3e1-2f4f3a5299b3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("815b2eef-ed9c-4acc-a7bb-5a8aab2ad3da"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8b4e227b-1136-4b13-b83d-1655311188d2"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b44d5f45-4546-4f46-b964-8307b31cfcfc"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0014142f-aa02-479b-bed1-410b7275b9c9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("1d4dce87-947e-4483-ae34-8ff1729b276e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("9550dee8-5d36-42ec-8407-ed59508a6a53"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("fc4b405a-5579-4877-8e22-cee84044b62d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("16589182-3c84-4c2e-9af8-ee4f33a3022d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5524fb23-d494-4511-961e-b9088806138b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("55a26735-9e42-4a43-ae18-83aac29d8543"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5cb67213-fdcf-4719-a897-5147401d75c8"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("64f25bd2-e453-4d41-a8ba-95d1b3fdd4f8"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d8ee0a7a-ceb9-4810-a9eb-7706007d468b"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("6193ac30-14b2-4c4d-be56-442ae714a47a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1f410b04-92a2-4e72-97e5-f02ec4b0039f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("29a914f5-0d34-4aca-a2af-2a8d1090e12b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3475bb84-3db4-4030-8895-cdd6b764938b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3bebe8c9-adcf-47cb-8c87-3a4ee7e9ceeb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("413bbb51-64b3-4c52-8c91-667606c2aba4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbf5bb9-deec-4f2a-b705-861e5123ea5e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("01920b21-024d-4c6b-96f2-91235baf8a33"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("07679d34-90b3-4d50-9848-3c2b96a6c1ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1fee52c8-5ed1-4218-aa16-a92f6d4ee17c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("73f7bac7-2c73-4869-b782-32a7f0979879"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("037a08e2-1b3c-42aa-9865-4ebebb77cf8e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("2988f9fb-364a-4aae-928f-7ed10e181422"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("39b77345-c09e-4982-98d3-f6dc9ea26ecf"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5f6d88c8-c02b-419d-b4c3-b57e8d8915ef"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ac5cff22-6ec5-46a7-86c5-f782ba2a47fa"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0e7c8fb9-ec48-4db2-a935-01b1fff7a35c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ca75b08f-c5fa-48e5-bc55-fb60642bed4a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e1ffebc9-e2ab-4fbc-9af0-6f5a1929418d"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06c8a551-c8c5-49cd-b643-c1a3971a1859"), "Rome", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2874), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("36a3043a-b8d1-4e79-8c5e-619fc3392d8a"), "Bern", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2883), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("3d28ea38-e147-4360-b0af-19a88135d6f7"), "London", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2871), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("778154a8-7a17-4fad-b70c-04390b7269ae"), "Brussels", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2440), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("7f60492c-f6d6-4b01-95c7-2d344f4131c1"), "Paris", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2863), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("a595695e-7244-4dba-91da-ef65d950d6a2"), "Amsterdam", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2869), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("b185d158-017e-438f-9084-1f52943931a3"), "Madrid", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2880), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("c170a298-0f10-457a-884d-fe4828eb9d1c"), "Vienna", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2886), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("c8fec41b-acd7-460d-b387-477ab8b893e4"), "Luxembourg", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2889), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("d0e8c398-9641-4198-a35e-af4c8cbf894d"), "Berlin", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2866), true, "DE", "DEU", "Germany", "Deutschland", "+49", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3ea535f6-e9c7-4203-928d-2662d5f8eaba"), "GBP", new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(8233), 2, true, "British Pound", "£", null },
                    { new Guid("6393799a-4356-43b7-ab67-fee9a3b76eae"), "USD", new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(8227), 2, true, "US Dollar", "$", null },
                    { new Guid("6deefca2-8c56-453e-ab03-ee777f61187b"), "CHF", new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(8234), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("b9981069-f25e-4b60-8b7e-ae63f6844ef7"), "EUR", new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(7212), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("055e9e01-e069-42d2-94cb-4e0c75f2fbd9"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(6422), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("70a7c311-d893-4dce-8ea9-e919c11a88a6"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(5439), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("ace5e81f-42da-42ef-90a1-dc8a770c8103"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(6424), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("eb319d94-2c87-4db3-aecb-bb35c30b6d3f"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(6416), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0fd17864-0a05-4134-97c8-e5788d06284c"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2083), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("32ad67d2-1c3c-4054-b74b-6147620f8eee"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2067), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("64284b75-1b9c-4696-b1da-cd9bfd44897b"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(932), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("9741619e-0617-4fd4-9b06-69f430fc0d3f"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2085), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("ab1c444d-d4aa-4062-93a9-c0640063ad47"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2073), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("d2ea900f-5cf0-4730-9029-db46f160257e"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2079), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("2afb9d8a-0632-44d6-9b84-9d2fdd45286e"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2883), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0d4dc5d6-dc85-414f-843f-a2dbf413fa03"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9767), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("4d38ea0e-1978-4ca2-84c4-82a6e241adc4"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9762), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("83793248-a7da-4910-8874-ba32daa8e31b"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9771), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("8eaf27f8-ae32-4593-b1b8-fadcdd0ef1b4"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9769), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("9f22226c-5b44-4a9c-88ff-4b0e7f172979"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(8773), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("c7766dfb-fefa-41fe-a936-4b9ef505dffb"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9772), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b941b36-14a8-493c-971d-c5429ddd35cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("137af052-56e7-454b-bfe2-30c187c29ed5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("33c48aeb-01fd-4e44-8a72-0d1706eef070"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("53468b15-3b44-4927-acb8-2a5cbed415c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("361211cf-b50a-45ba-9eac-4e8fc8bc32ee"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(142), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("4453b21c-2b72-4f74-998d-a0d2ab98d09b"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(9038), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("62e9040b-0376-4bd9-8404-0f14c8199ea7"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(157), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("8944f0c6-4566-488a-a1e4-0d192c08f6c6"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(148), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("d2ec402e-7000-48bd-b290-43ffffdf70d0"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(150), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1dd7f781-a870-4b61-b855-6a5e9792fe54"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(7673), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("27736283-a5eb-41aa-9f8c-f3295430d698"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(7961), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("ffe9503a-9b24-4875-8ef6-9ef423bcd1c3"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(7955), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7224), new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7210), "nMzZyX9BL3fOz7xr19tm26hZSToATMS7FoTUHVH4yoFxfU5UqnxwYjOn0gSXyX5M", new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4759), new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4744), "6KEhQSe/8Q7X+/267eQwcU79b3IOqx6B4ZnlK+qIHqb2mk40hXiyJVUyUNljw2DM", new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7910), "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7906), "USER_1_332E@EXAMPLE.COM", "USER_1_332E", "3bu7OICkfpZ78Stk2cAc6Lu/ue/wZPMK8/kzWOI/GXd6N898FqB0nCd6Gh1VaA7q", "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7911), "user_1_332e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6661), "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6658), "USER_2_1D32@EXAMPLE.COM", "USER_2_1D32", "sY6TzmtYfeRstuEMMgmxbov0p2O/G9K3DzO6hiqlTh1BfGhkAvvtGEae7faJAHeV", "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6663), "user_2_1d32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9521), "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9515), "USER_3_7EE4@EXAMPLE.COM", "USER_3_7EE4", "2IFuFA/vEQH6/RICZ41ehDjvb77Jc5L8mH/kMf9qahxvAnNAMVrysOsD+dkokeET", "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9523), "user_3_7ee4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5941), "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5937), "USER_4_655B@EXAMPLE.COM", "USER_4_655B", "8YYignsoCTPPIte7WPen6P5rEj7os1p5usont1i6vX/2uslcgN53iImI4cs9g6JC", "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5944), "user_4_655b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3128), "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3125), "USER_5_306B@EXAMPLE.COM", "USER_5_306B", "rzoISCS5cHPJ8a8coWTsFLVCI3hMUKUmc3rugHGKAiAmexBAC+FJoPipQ+pJieN5", "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3130), "user_5_306b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4170), "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4167), "USER_6_5CF7@EXAMPLE.COM", "USER_6_5CF7", "oSFkIc5cwOSufrOolw1+K67vJPmlQye5vbn7saa6GwNQ9FBwbWMl0nvqiv+Na/uP", "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4171), "user_6_5cf7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3840), "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3836), "USER_7_82D8@EXAMPLE.COM", "USER_7_82D8", "crkIYykeuzGNfUJll6B6kCA0XfDiIJwIqMCRCSpX8DDTpCEgvJ/JWYcc4RD8TQJ+", "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3842), "user_7_82d8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7593), "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7587), "USER_8_D28D@EXAMPLE.COM", "USER_8_D28D", "ZIeT0UNMHDmmDpAvzFnoXpJE+1ERKoUH+jtGoOt7N/49ubewuj/IjNBsjifT5uB7", "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7594), "user_8_d28d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2185), "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2180), "USER_9_7E20@EXAMPLE.COM", "USER_9_7E20", "vrm5E09OoHMnozqcWCV5hk9C1cCwpL3LQv/MpPN9L0Ck0Eq9nt7sDP0DjH7CvXIj", "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2186), "user_9_7e20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7730), "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7726), "USER_10_C6AD@EXAMPLE.COM", "USER_10_C6AD", "RjUhvqmj/R2xYdw3Fh5lqrJQnr06sWLrlHhV1Q7icscx2km/yj47ibQ5ZEsPCGtc", "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7732), "user_10_c6ad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4701), "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4698), "USER_11_DBA4@EXAMPLE.COM", "USER_11_DBA4", "TGJvWfxL1npRHKFS+nw2DcP4dDWd4nslVXsO/WTTnTQU37EfVTUg6jwawNNplL1d", "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4703), "user_11_dba4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(815), "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(810), "USER_12_AB1A@EXAMPLE.COM", "USER_12_AB1A", "LI6IZQH8UP7PNVzQBq1z43UMZX03hYSpWsHGTu08L7wO0sZvpcOHi+vccGqr9KNX", "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(816), "user_12_ab1a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8592), "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8586), "USER_13_9921@EXAMPLE.COM", "USER_13_9921", "msX+c1AtcYQ2xy5HeSw2cfQSmbbAAM9JM/NSQ10Ip3mbrwQWh3plBGlDs5R1TipQ", "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8593), "user_13_9921" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4155), "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4151), "USER_14_9B76@EXAMPLE.COM", "USER_14_9B76", "IVk1pa5K0tYTOQpND3+ea5ioPeBgmLcDwLOE9OyDU0mAqG7BbiZQWSATe3b6duPm", "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4156), "user_14_9b76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6751), "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6747), "USER_15_9588@EXAMPLE.COM", "USER_15_9588", "v+lcUKFZK7dgcL7QvcHPSOBS9dp0pY//J6Tls5bAH8N+Iblv9df7nWH6dFZDBlAI", "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6752), "user_15_9588" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6959), "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6955), "USER_16_AABA@EXAMPLE.COM", "USER_16_AABA", "1fqdyEqNAx8/dUa5KUprS+C3ZnJxOvTlDvLoexb2rUph9qJRFvU4h3gtgZO0sx+x", "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6961), "user_16_aaba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8146), "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8138), "USER_17_DAAC@EXAMPLE.COM", "USER_17_DAAC", "0Pf1v0gxtKk23P8i+2UtnqhiGnIK9tR5cyDKUg11+wAbCS/uSuAqnGPNB4Daw7HH", "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8149), "user_17_daac" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9626), "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9620), "USER_18_425D@EXAMPLE.COM", "USER_18_425D", "89e/jgRr8dd+368apHERuZPY9sEyP3meS3Xj/nMY+itcuUn7R39hXyHCCXZn+31p", "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9628), "user_18_425d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2132), "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2128), "USER_19_37B1@EXAMPLE.COM", "USER_19_37B1", "5Thiy90jgTr9Wv+Vm4eZXUXh2VpfVWOCAOXI/jjixstOMrroKzNeJvwSAz6PJHyM", "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2133), "user_19_37b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3798), "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3790), "USER_20_A0C7@EXAMPLE.COM", "USER_20_A0C7", "WcGiw4bkfHrsXMMr5Z2j5ISIVc0GEBZpbkKVeDQ6OawK0GcXquthJOUOINmhdurQ", "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3803), "user_20_a0c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2140), "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2135), "USER_21_84C9@EXAMPLE.COM", "USER_21_84C9", "7xGXTs5cGlRAX2McvYm9reOwVJqGpSye18cXzzWMY0LlQWTrto38wmJb9EKrgoEg", "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2141), "user_21_84c9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4648), "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4644), "USER_22_6FE0@EXAMPLE.COM", "USER_22_6FE0", "D4PNw6C/BIRlVoH0kf0lnQu4L+0T0mEC6jvLD/POpF9nif6jB1FYUQUyIyz4pqCa", "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4649), "user_22_6fe0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6517), "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6513), "USER_23_273D@EXAMPLE.COM", "USER_23_273D", "j4TNxmwPQH9vJrBXuYNlrMF2TUIm/YYE8ZkjAAcBue08LeAfmqkUASSws9sZSZM3", "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6519), "user_23_273d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8015), "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8009), "USER_24_A0A3@EXAMPLE.COM", "USER_24_A0A3", "qLrlm9PLeovyx/0E6jqYJWnSqDIPKTSf2rSvI25dK9WgUb+ZHw3OvsU5XlgQyG8d", "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8016), "user_24_a0a3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(691), "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(687), "USER_25_2709@EXAMPLE.COM", "USER_25_2709", "76VidI8xon36d9sBhB5eoQDb3TeqVRz1w3nT91UNaE8ToYAaXluFlp9eje+/oNhh", "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(692), "user_25_2709" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5971), "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5963), "USER_26_F15E@EXAMPLE.COM", "USER_26_F15E", "c50iSrbzLdFKaCN91SLwJ2s6cbnZUZVezL133l4XxHdYPTDMxYOv8WtgvUVBtOZ5", "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5979), "user_26_f15e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2943), "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2939), "USER_27_786B@EXAMPLE.COM", "USER_27_786B", "8DZKLRBTQ6wM70+0h0wyfxi8Mb9HrhpEaF7fjAT4SA9SUqF20wrPYFFdzoUnRp6f", "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2944), "user_27_786b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3071), "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3057), "USER_28_B52F@EXAMPLE.COM", "USER_28_B52F", "YDJRVuMe3eRgcseJ0A9NQyM6WHRJFjZYW2z16pGq86dUFZpcsnG81KTCJU9xj5of", "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3074), "user_28_b52f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2036), "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2031), "USER_29_F37F@EXAMPLE.COM", "USER_29_F37F", "3VEH5hhuhpc9N02sH3It+mzEQO9ganXGDBGxGr3QKVZwQjph4AC+NyAKI8FbZ+/2", "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2038), "user_29_f37f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2924), "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2920), "USER_30_C4C7@EXAMPLE.COM", "USER_30_C4C7", "hLJR4djFmOlYBHPA7mxDPfB8LM0FynQOZh1ETweObvGJILgMERlKSrp/SO6GqmEh", "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2925), "user_30_c4c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9547), "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9543), "USER_31_18EE@EXAMPLE.COM", "USER_31_18EE", "4gS04y1Js5cZExm1uE4NXHbYpiZT+O2kJ7/n6a1Xt9y1OHBpsLSayqABGod5twpz", "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9548), "user_31_18ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1188), "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1185), "USER_32_06BA@EXAMPLE.COM", "USER_32_06BA", "WYDamRCmCqDCg0qs+fb+Mf6MQUp/Mf9gIAqIvSgGhej9P4xqjCr7N5SbUnddzfZb", "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1190), "user_32_06ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2822), "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2817), "USER_33_C69D@EXAMPLE.COM", "USER_33_C69D", "vJTmDgwRiBjgFfGvKRmlvIGr/OQdhWNK3hVfPHW5Wo98pxwf7kPrd8X6kqXXi0H6", "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2823), "user_33_c69d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2794), "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2790), "USER_34_3660@EXAMPLE.COM", "USER_34_3660", "zFOcJtfMa8fG8BmuMcrqTCbMSRxRlF9ONna/7+4oiXBoZqrz7tRRLWb13W22F3O3", "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2795), "user_34_3660" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9082), "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9079), "USER_35_1174@EXAMPLE.COM", "USER_35_1174", "q4+UOCYKGOGM6/Q0zpW4KY9AHfi1yXy/hUkPQateawiBbjBBGp9OcMfTSXy9nn1t", "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9084), "user_35_1174" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6124), "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6120), "USER_36_CE26@EXAMPLE.COM", "USER_36_CE26", "5TGWj+Dh/kz79iRmPQw0JqOG4s37KxzFR5nuYUxyHKabR2JD9Jx/iTTWgMTW6PWX", "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6124), "user_36_ce26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8051), "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8047), "USER_37_1CB7@EXAMPLE.COM", "USER_37_1CB7", "lz4ny9g+vyfgQVq50qW4dtZlf5RwKnSOTDOz2Tc6C1AHwc2EBC7AU2vhaeAR6ed/", "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8053), "user_37_1cb7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7004), "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7000), "USER_38_EA87@EXAMPLE.COM", "USER_38_EA87", "G37uShdARkkGOp0sG82ala0E/uOQnAqvM8yx8MR7PN3HGLkV5x64q+6kFwKaSRwE", "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7006), "user_38_ea87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6452), "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6443), "USER_39_33FC@EXAMPLE.COM", "USER_39_33FC", "BgdYRlla2PbtLiaRaWHmFtXhr5rx060U3axyJWeFIP0HyODqI52ZJu/bPllsry+U", "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6457), "user_39_33fc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5953), "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5948), "USER_40_0768@EXAMPLE.COM", "USER_40_0768", "BbG/sVVNfA49P2y0LDSij8OZwIGr+li/2FcGGNKpR8xOb7g9nkOiKILjMM8Xk7xy", "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5956), "user_40_0768" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1232), "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1228), "USER_41_9211@EXAMPLE.COM", "USER_41_9211", "Z3QYMC0ltgozy+K2XMMG/FRNog1yD1BmQVawcKH2yHHDguf2Qv5qOffyppgJnJAc", "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1233), "user_41_9211" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1763), "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1759), "USER_42_39B4@EXAMPLE.COM", "USER_42_39B4", "lrnpbfpRBsZ8O7J4jYdJ7xe9sO9K6tP+sModJJxtwGgL6aE8UbSuYbCaN5ToWjSu", "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1765), "user_42_39b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(153), "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(149), "USER_43_1F1E@EXAMPLE.COM", "USER_43_1F1E", "H3AOdjOxohBcAq8QrjvmIDqF1WvptEIsM6W/i5ZRjEv5UzY7pVZUg06BzpMQbPMS", "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(158), "user_43_1f1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7465), "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7462), "USER_44_015D@EXAMPLE.COM", "USER_44_015D", "lLH35CSD1t7TZ6EfW9X3UTYLlP8YVbsPlgyFR92uqidYDG+k97K4IjLci0sxEnYP", "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7466), "user_44_015d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4147), "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4144), "USER_45_6359@EXAMPLE.COM", "USER_45_6359", "veifljGaztp066nNX6jQkrYo8dN1LE8lc1DNvAPckCixKtuA2p1wuvb8WMsbELv6", "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4149), "user_45_6359" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4036), "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4013), "USER_46_47AB@EXAMPLE.COM", "USER_46_47AB", "Fh2CoGG88uWogXovL0RLuPFZfcNkYUnAnXzHLNZxbcMEiC06OO7wAYTzCeev4oDP", "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4043), "user_46_47ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2638), "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2634), "USER_47_07AB@EXAMPLE.COM", "USER_47_07AB", "qkTKWuzznvPPu3jwxbXimRWVDW1ZpCoSh69wtYiTtPX4OotafyScZQ1RRFvvRNjU", "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2642), "user_47_07ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7467), "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7462), "USER_48_E965@EXAMPLE.COM", "USER_48_E965", "+KLBEcRg+Xb52rSZnAnYnspWlPZflNwz+3BmhWkzMBwUFqTXctCXka57WLZGdiqZ", "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7469), "user_48_e965" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(497), "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(494), "USER_49_2C6A@EXAMPLE.COM", "USER_49_2C6A", "rMRToWPyAp/mjBd2ouzjCtEhDxnJvnv1LXf6v3WmQjHBLeaqZT/sqzaBe2cel9Pq", "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(498), "user_49_2c6a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6546), "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6534), "USER_50_462E@EXAMPLE.COM", "USER_50_462E", "2h1GQdYeiJ01IdCgWbuJ4cOPE8wr2ZXHQWEfhddsLENQ9xYjKY0TlefAVIrle+25", "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6550), "user_50_462e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 58, 30, 456, DateTimeKind.Utc).AddTicks(9625), new DateTime(2025, 2, 16, 14, 58, 30, 456, DateTimeKind.Utc).AddTicks(5774), "SndPAruXUwqEOT6I+OLMGIFRz3zk76cMFb583M9mqojvYEa8NgcsERzd9GpxqzuJ", new DateTime(2025, 2, 16, 14, 58, 30, 457, DateTimeKind.Utc).AddTicks(783) });
        }
    }
}
