using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11195222-1910-488b-98b5-197377303d10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42905c6b-9cc2-4723-8c51-b7c9c2f11430"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c2c4777-be05-446d-bb56-26cbfe8f1a21"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6cc0a5b4-99dd-4fbb-9336-3faa02bcc87f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("859752a7-f92f-4f41-8345-8c2603a42ba7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e681651-3f8e-498f-99b0-3f196c88a616"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af4b0629-e2d1-4805-8f18-d1425decf075"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b33d1172-a109-4a03-87b1-55e648f8e7db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce867af2-bdb8-4d61-9498-d7fe9d965458"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f01697ae-3d19-4bb7-8849-358ccc8cb6e3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b94b53df-983d-49ee-8aab-e65b8c796b5a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bc6ef463-ba69-4133-b540-30e375aabaf5"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ca96ef27-868a-4981-a1f0-c4df23eb6ca8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f83fabae-9f7c-411c-8849-a146834efc3b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("19b858eb-c42e-44ad-a636-518f9a529606"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("2c0bddff-b45f-4837-9e95-4a6bbcf45119"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("cccc55d7-d5d5-4a07-ab58-38a50c261322"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ccd2fcb8-f043-44ad-9b1b-dd7c89eff63a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0fdc2587-2425-4516-9cb3-d90a8b2dd653"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("285ca1b9-22ae-45a2-85ec-bf346deca57a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("4dc35326-88b6-42be-b943-0a41e6937585"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a3db5f4b-713d-424a-921c-4d1287f3aa4d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("af0668c3-19c6-483b-9d52-eb8ba41092cb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d6987a20-0bb9-4c4b-9478-af118d5a43ec"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("b7943343-5153-43b6-896e-86e84deab981"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("18d2073c-18df-428e-85cb-d40b116bfcbc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3aad1ea8-4e31-4baa-97b4-44638dacbb4e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4d90cdbf-5f88-4e67-bfdc-1465c20f1edf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f9cc908-3a04-49b7-b8b5-e381abc770f1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("acd96219-b79d-488d-9cea-241571d061e0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ca2144a0-bf2a-45d2-a054-8b2485eccd5d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("50d88ee1-6518-4d4f-b9df-91dce466983b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("622fcb6f-8859-40be-8230-3ceb1c6f77fe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aba70367-2324-4c4d-a88f-6602e5e5da8a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cdd25436-de12-40b4-8d4f-5c6d10a5c3cc"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("35289622-b39e-44f0-8d2d-7c800373659a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("4c95384d-e490-43c2-9a6f-5f8466480dc5"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("581bb615-3722-45eb-91a6-0ebdef84b2d9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5c8d70ed-7bcc-4a5c-b5e5-0028d2325e3d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9e507964-a0cd-45f3-a5ef-dd57d2b06770"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2a5d9c5d-5c8a-432d-8b24-90a0cbff1c05"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("94427b7c-6a1c-41ee-86b7-c12eb597bec3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fdaa37d2-672a-4884-a3cc-8527fd35a55a"));

            migrationBuilder.AddColumn<bool>(
                name: "IsUser",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0e22ddab-717e-42bf-8533-c8221f5302a3"), "Berlin", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2291), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("12b41a91-d6cc-4a8b-a263-e7fd36ff37a4"), "Rome", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2378), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("30689c8b-29fd-45e0-99aa-7a93e40b9218"), "Paris", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2281), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("4f8ed61b-17f0-4a53-a59e-5533bd1ca9ad"), "Bern", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2384), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("6b75fb1c-84d0-4d16-b3f5-e65bc9c23607"), "Amsterdam", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2371), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("76da300c-537e-4dd5-8aba-d9085bc142d2"), "Vienna", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2387), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("96c2c97d-690e-4234-818a-78d58c8cd08f"), "Brussels", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(1573), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("9e5e9851-1a22-4fad-b438-2f01b12510c8"), "London", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2375), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("edfedafd-f09c-4715-a4e4-c89aa513b612"), "Madrid", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2381), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("f94b65af-8e26-4870-8115-80dda4caf41c"), "Luxembourg", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2390), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("172d42a2-4f40-4060-9f3d-8fbb49a7f674"), "USD", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6352), 2, true, "US Dollar", "$", null },
                    { new Guid("3af61412-c3a7-426b-bf2b-43775fab8b53"), "EUR", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(5259), 2, true, "Euro", "€", null },
                    { new Guid("636775eb-d830-4d46-a042-1d55b675b342"), "CHF", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6360), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("fb1e9bb4-6d0b-407b-9077-c74793c33cac"), "GBP", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6358), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("430c3357-4abf-42aa-a395-4f160d9105ae"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4215), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("48579b09-f674-41f3-909c-aabff0f21a62"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(2726), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("5fe0543d-7e70-4a83-9947-2ae5aa8a0e3e"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4223), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("e2031a74-33a7-404c-b6af-c95d5b41f331"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4225), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16b949e7-b4a6-4a78-ad49-22082bad122b"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8519), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("2529ef8d-6d83-4af1-afe0-4e179f9cad88"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8514), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("56daa222-05de-4dac-8c69-0770058dfb39"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8507), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("5c3e3197-0d7d-43a7-bf55-f2b88530e3e4"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8517), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("e31f149a-385b-4423-9498-a472dd5c38d1"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(7109), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("fac3f6f8-84e6-4ec2-81bb-8eabe665869e"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8522), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("791601e7-db1b-4c47-943f-d39b13442b74"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(9500), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("132f6378-c3b0-4a4b-ae1e-48758a54d1c4"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5832), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("6097b82f-2f65-4b4a-8365-610f329da128"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5829), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("671be8aa-b4ad-4bd8-b6f2-81147194c46e"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5845), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("7777983f-583f-4e81-8b95-9a464d991461"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(4725), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("a5a91b25-1d64-449e-8e8e-c667aa14a7f0"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5827), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("e0232132-93e8-42be-a765-008707d82627"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5820), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5e45c6b0-5adb-4d70-a92f-7866a09338fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("89beac11-2705-48a8-ad88-0f57a44cd400"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("8b235b63-017c-4a2a-bcb6-2398dcdb0515"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("f098f1a3-8692-4ce9-86f0-92557bfe3329"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("566319c2-4d49-4c7c-bc6a-3aaf3e506a3a"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8560), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("6b14cab7-7ab8-4ad9-8321-f52646782c0a"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8558), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("a28ebd2a-ec51-4776-b42f-124179b7b2af"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8588), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("c3b21ece-fe8e-4f06-82b5-68741eaed073"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(7256), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("efcecd78-a5e8-4c46-9e18-7d8ecad2cbb9"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8551), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4335f708-81f5-4978-9656-297f431dcb53"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7702), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("7e97d66c-db54-47f2-a37e-3c54d4f1b96d"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7402), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("e67b25cd-6079-4bb6-a9a1-2cd718f118bc"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7709), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "IsUser", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4223), true, new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4209), "21O0ZZzxUly48wQU1wbHwpkiDgGnUaBVIsYDDw50zTQLRGEgkjnrIdkyoRaGxS2R", new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_27ac@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4028), "user_1_27ac@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4023), "USER_1_27AC@EXAMPLE.COM", "USER_1_27AC", "TPYvYMTD2MT0HF2rtf8Dg1DYO6bbEea56ZK+UxfUh2J2rxsT5syDLHuscaadOLNZ", "user_1_27ac@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4030), "user_1_27ac" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_0e2b@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5581), "user_2_0e2b@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5578), "USER_2_0E2B@EXAMPLE.COM", "USER_2_0E2B", "+QmUyNzGT/ENRiVHBAr3vp0flurbbVNsH9dya+8xB50yWMj6L5Hryy+RXScPbWGr", "user_2_0e2b@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5582), "user_2_0e2b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_05e6@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3415), "user_3_05e6@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3410), "USER_3_05E6@EXAMPLE.COM", "USER_3_05E6", "xFK5BIiuQsLAw+kkNrxtDMzGvkJHaIWvp4MM+sFOPgL4i/xQawPMQ56IEieTKveo", "user_3_05e6@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3417), "user_3_05e6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_8b11@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9863), "user_4_8b11@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9859), "USER_4_8B11@EXAMPLE.COM", "USER_4_8B11", "CF+Ud3s3kIpjf7JWp4BwFHtL0Ys1VeJ0B+We7M7n8htUvEBysazMcg6quUOZkXgQ", "user_4_8b11@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9864), "user_4_8b11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_b7b7@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8074), "user_5_b7b7@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8070), "USER_5_B7B7@EXAMPLE.COM", "USER_5_B7B7", "Isd4uFid1hiCX8F5rYwsxiNSi1C4LWPzpCqgNcHnRmaRu96KIkJlKcI7zx75hKJD", "user_5_b7b7@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8076), "user_5_b7b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_b911@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1285), "user_6_b911@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1281), "USER_6_B911@EXAMPLE.COM", "USER_6_B911", "y4jzrUyYijyNQQ6IGo+PZWtBRe+p+40gejUj0dRh/rSfo1xlLoPwnZy80Erlf7iT", "user_6_b911@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1287), "user_6_b911" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_672d@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4797), "user_7_672d@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4793), "USER_7_672D@EXAMPLE.COM", "USER_7_672D", "bezFTDkcW/tWp0+JHlNzFpCtsSoCGt50ZTP/yk6yLMuJSJPRiVtA1j2Ovh+WVgDR", "user_7_672d@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4799), "user_7_672d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_be02@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8079), "user_8_be02@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8076), "USER_8_BE02@EXAMPLE.COM", "USER_8_BE02", "j4J5a0kvbRCkpSMuRyOfEWaMjMk5lCIRbixteCVEUCIjIhvssNfmtxZW0EPfcCsG", "user_8_be02@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8081), "user_8_be02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_3b00@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3350), "user_9_3b00@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3345), "USER_9_3B00@EXAMPLE.COM", "USER_9_3B00", "/oGrAHb5BryniXLN1fYE0v9XMOtgYPqbaco3gUnAiJKhifEWJssD68Fnb9FabHlA", "user_9_3b00@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3352), "user_9_3b00" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "IsUser", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_7f38@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1704), "user_10_7f38@example.com", true, new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1695), "USER_10_7F38@EXAMPLE.COM", "USER_10_7F38", "5kON/sirrfwYdjLGgPy5S6w3tdQBQKgPzEQjn6XL2jmQRrWzXR8Nva8EIVFB7t3R", "user_10_7f38@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1711), "user_10_7f38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "IsUser", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(7283), true, new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(2142), new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(8804) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e22ddab-717e-42bf-8533-c8221f5302a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12b41a91-d6cc-4a8b-a263-e7fd36ff37a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30689c8b-29fd-45e0-99aa-7a93e40b9218"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f8ed61b-17f0-4a53-a59e-5533bd1ca9ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b75fb1c-84d0-4d16-b3f5-e65bc9c23607"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76da300c-537e-4dd5-8aba-d9085bc142d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96c2c97d-690e-4234-818a-78d58c8cd08f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e5e9851-1a22-4fad-b438-2f01b12510c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edfedafd-f09c-4715-a4e4-c89aa513b612"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f94b65af-8e26-4870-8115-80dda4caf41c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("172d42a2-4f40-4060-9f3d-8fbb49a7f674"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3af61412-c3a7-426b-bf2b-43775fab8b53"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("636775eb-d830-4d46-a042-1d55b675b342"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fb1e9bb4-6d0b-407b-9077-c74793c33cac"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("430c3357-4abf-42aa-a395-4f160d9105ae"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("48579b09-f674-41f3-909c-aabff0f21a62"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("5fe0543d-7e70-4a83-9947-2ae5aa8a0e3e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("e2031a74-33a7-404c-b6af-c95d5b41f331"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("16b949e7-b4a6-4a78-ad49-22082bad122b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("2529ef8d-6d83-4af1-afe0-4e179f9cad88"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("56daa222-05de-4dac-8c69-0770058dfb39"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5c3e3197-0d7d-43a7-bf55-f2b88530e3e4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e31f149a-385b-4423-9498-a472dd5c38d1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fac3f6f8-84e6-4ec2-81bb-8eabe665869e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("791601e7-db1b-4c47-943f-d39b13442b74"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("132f6378-c3b0-4a4b-ae1e-48758a54d1c4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6097b82f-2f65-4b4a-8365-610f329da128"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("671be8aa-b4ad-4bd8-b6f2-81147194c46e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7777983f-583f-4e81-8b95-9a464d991461"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5a91b25-1d64-449e-8e8e-c667aa14a7f0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e0232132-93e8-42be-a765-008707d82627"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5e45c6b0-5adb-4d70-a92f-7866a09338fc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("89beac11-2705-48a8-ad88-0f57a44cd400"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8b235b63-017c-4a2a-bcb6-2398dcdb0515"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f098f1a3-8692-4ce9-86f0-92557bfe3329"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("566319c2-4d49-4c7c-bc6a-3aaf3e506a3a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6b14cab7-7ab8-4ad9-8321-f52646782c0a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("a28ebd2a-ec51-4776-b42f-124179b7b2af"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c3b21ece-fe8e-4f06-82b5-68741eaed073"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("efcecd78-a5e8-4c46-9e18-7d8ecad2cbb9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4335f708-81f5-4978-9656-297f431dcb53"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7e97d66c-db54-47f2-a37e-3c54d4f1b96d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e67b25cd-6079-4bb6-a9a1-2cd718f118bc"));

            migrationBuilder.DropColumn(
                name: "IsUser",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11195222-1910-488b-98b5-197377303d10"), "Berlin", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8110), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("42905c6b-9cc2-4723-8c51-b7c9c2f11430"), "Vienna", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8126), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("5c2c4777-be05-446d-bb56-26cbfe8f1a21"), "Bern", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8123), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("6cc0a5b4-99dd-4fbb-9336-3faa02bcc87f"), "Paris", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8103), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("859752a7-f92f-4f41-8345-8c2603a42ba7"), "London", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8115), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("9e681651-3f8e-498f-99b0-3f196c88a616"), "Brussels", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(7566), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("af4b0629-e2d1-4805-8f18-d1425decf075"), "Madrid", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8121), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("b33d1172-a109-4a03-87b1-55e648f8e7db"), "Rome", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8119), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("ce867af2-bdb8-4d61-9498-d7fe9d965458"), "Amsterdam", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8113), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("f01697ae-3d19-4bb7-8849-358ccc8cb6e3"), "Luxembourg", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8128), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b94b53df-983d-49ee-8aab-e65b8c796b5a"), "EUR", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(2903), 2, true, "Euro", "€", null },
                    { new Guid("bc6ef463-ba69-4133-b540-30e375aabaf5"), "USD", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(3773), 2, true, "US Dollar", "$", null },
                    { new Guid("ca96ef27-868a-4981-a1f0-c4df23eb6ca8"), "CHF", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(3823), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("f83fabae-9f7c-411c-8849-a146834efc3b"), "GBP", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(3779), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("19b858eb-c42e-44ad-a636-518f9a529606"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(2239), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("2c0bddff-b45f-4837-9e95-4a6bbcf45119"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(2233), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("cccc55d7-d5d5-4a07-ab58-38a50c261322"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(2241), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("ccd2fcb8-f043-44ad-9b1b-dd7c89eff63a"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(1304), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0fdc2587-2425-4516-9cb3-d90a8b2dd653"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8573), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("285ca1b9-22ae-45a2-85ec-bf346deca57a"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(7196), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("4dc35326-88b6-42be-b943-0a41e6937585"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8575), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("a3db5f4b-713d-424a-921c-4d1287f3aa4d"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8566), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("af0668c3-19c6-483b-9d52-eb8ba41092cb"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8579), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("d6987a20-0bb9-4c4b-9478-af118d5a43ec"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8578), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("b7943343-5153-43b6-896e-86e84deab981"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(9392), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("18d2073c-18df-428e-85cb-d40b116bfcbc"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(4993), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("3aad1ea8-4e31-4baa-97b4-44638dacbb4e"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6119), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("4d90cdbf-5f88-4e67-bfdc-1465c20f1edf"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6156), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("8f9cc908-3a04-49b7-b8b5-e381abc770f1"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6153), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("acd96219-b79d-488d-9cea-241571d061e0"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6168), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("ca2144a0-bf2a-45d2-a054-8b2485eccd5d"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6151), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("50d88ee1-6518-4d4f-b9df-91dce466983b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("622fcb6f-8859-40be-8230-3ceb1c6f77fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("aba70367-2324-4c4d-a88f-6602e5e5da8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("cdd25436-de12-40b4-8d4f-5c6d10a5c3cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("35289622-b39e-44f0-8d2d-7c800373659a"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(5526), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("4c95384d-e490-43c2-9a6f-5f8466480dc5"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(5535), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("581bb615-3722-45eb-91a6-0ebdef84b2d9"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(4476), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("5c8d70ed-7bcc-4a5c-b5e5-0028d2325e3d"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(5533), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("9e507964-a0cd-45f3-a5ef-dd57d2b06770"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(5531), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 13, 13, 22, 590, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2a5d9c5d-5c8a-432d-8b24-90a0cbff1c05"), new DateTime(2025, 2, 14, 13, 13, 22, 590, DateTimeKind.Utc).AddTicks(1843), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("94427b7c-6a1c-41ee-86b7-c12eb597bec3"), new DateTime(2025, 2, 14, 13, 13, 22, 590, DateTimeKind.Utc).AddTicks(2109), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("fdaa37d2-672a-4884-a3cc-8527fd35a55a"), new DateTime(2025, 2, 14, 13, 13, 22, 590, DateTimeKind.Utc).AddTicks(2103), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 13, 13, 22, 513, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 2, 14, 13, 13, 22, 513, DateTimeKind.Utc).AddTicks(251), "uolP1gu/qGbU93kcPNR5a5xobk+XOzPthlf2DpyYdzZrkZ0wTrX6YY99R8KFAylY", new DateTime(2025, 2, 14, 13, 13, 22, 513, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_5dbb@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 533, DateTimeKind.Utc).AddTicks(5347), "user_1_5dbb@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 533, DateTimeKind.Utc).AddTicks(5343), "USER_1_5DBB@EXAMPLE.COM", "USER_1_5DBB", "/p2RQi6tYfYRlYI2GS1ywooL4xIsjwQltgxyoPALNwoIa1oO089fIwOLSj3MWEh3", "user_1_5dbb@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 533, DateTimeKind.Utc).AddTicks(5348), "user_1_5dbb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_e17d@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 539, DateTimeKind.Utc).AddTicks(9931), "user_2_e17d@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 539, DateTimeKind.Utc).AddTicks(9926), "USER_2_E17D@EXAMPLE.COM", "USER_2_E17D", "kb3VpDikGZKzUVgWvED06p1BLZrK5AGKLHhfCBDJcAvOnOHeFh0V19HGZDi8VScF", "user_2_e17d@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 539, DateTimeKind.Utc).AddTicks(9932), "user_2_e17d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_75c9@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 545, DateTimeKind.Utc).AddTicks(9840), "user_3_75c9@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 545, DateTimeKind.Utc).AddTicks(9833), "USER_3_75C9@EXAMPLE.COM", "USER_3_75C9", "Pg/7Zecdg+Cwj1iVjtFzxdy+Ihu+lf/s4ostdWGm4SRJEI2gZOgz349xK02zlPUY", "user_3_75c9@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 545, DateTimeKind.Utc).AddTicks(9842), "user_3_75c9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_9dc3@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 551, DateTimeKind.Utc).AddTicks(9278), "user_4_9dc3@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 551, DateTimeKind.Utc).AddTicks(9273), "USER_4_9DC3@EXAMPLE.COM", "USER_4_9DC3", "hZAKWgHjlLglVEIvYTIqkAKMr1Xz0/kFv22AIAGcxh1QeL3fUISQccsnbx5Ix+O+", "user_4_9dc3@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 551, DateTimeKind.Utc).AddTicks(9279), "user_4_9dc3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_0340@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 558, DateTimeKind.Utc).AddTicks(2440), "user_5_0340@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 558, DateTimeKind.Utc).AddTicks(2435), "USER_5_0340@EXAMPLE.COM", "USER_5_0340", "ojnqT9py/k1H4c1gHCJGI/lTF84/bo59dHjVlsMwNouXidt0C2taffS5sD/AS0wu", "user_5_0340@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 558, DateTimeKind.Utc).AddTicks(2441), "user_5_0340" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_1205@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 564, DateTimeKind.Utc).AddTicks(1890), "user_6_1205@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 564, DateTimeKind.Utc).AddTicks(1886), "USER_6_1205@EXAMPLE.COM", "USER_6_1205", "UEbVF8lrJGMw1NdqEEI8bmSNp+3K8UuxjZnySfnFKu79j44j75HDUDlRbs/8yn29", "user_6_1205@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 564, DateTimeKind.Utc).AddTicks(1892), "user_6_1205" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_3765@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 570, DateTimeKind.Utc).AddTicks(1538), "user_7_3765@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 570, DateTimeKind.Utc).AddTicks(1533), "USER_7_3765@EXAMPLE.COM", "USER_7_3765", "H3kky7IfpH1V2dpEIC+oaOYelXonYZxF52CdoTBvZ0pUVKtw7mb1B6rl2YTwB5uW", "user_7_3765@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 570, DateTimeKind.Utc).AddTicks(1539), "user_7_3765" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_2966@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 576, DateTimeKind.Utc).AddTicks(1204), "user_8_2966@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 576, DateTimeKind.Utc).AddTicks(1194), "USER_8_2966@EXAMPLE.COM", "USER_8_2966", "kr5pvfVbsJP9BKNUVdcdubdbaARJS/nPVyc4kpARZAj9Zs0R+PW1cNN8QFtA/Q2+", "user_8_2966@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 576, DateTimeKind.Utc).AddTicks(1207), "user_8_2966" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_cf0c@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 582, DateTimeKind.Utc).AddTicks(298), "user_9_cf0c@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 582, DateTimeKind.Utc).AddTicks(293), "USER_9_CF0C@EXAMPLE.COM", "USER_9_CF0C", "fK5+FqGPRa64sI+T3zUZViWs6QijGsCrB9EGDBkFgLLotpait8Bp2+9TF9NA/uIv", "user_9_cf0c@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 582, DateTimeKind.Utc).AddTicks(299), "user_9_cf0c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_efc0@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(2711), "user_10_efc0@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(2707), "USER_10_EFC0@EXAMPLE.COM", "USER_10_EFC0", "5gT6MYI9eWxIPcPglgxHIUvmgqNB2FIRYDy7WBIGwI+UvGX89Qt4aGhwVEJI+JhO", "user_10_efc0@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(2712), "user_10_efc0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 13, 13, 22, 498, DateTimeKind.Utc).AddTicks(3830), new DateTime(2025, 2, 14, 13, 13, 22, 498, DateTimeKind.Utc).AddTicks(1498), new DateTime(2025, 2, 14, 13, 13, 22, 498, DateTimeKind.Utc).AddTicks(4606) });
        }
    }
}
