using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03e61219-a0b5-4a81-a405-8ea9748f2da7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("22866fec-7869-4527-894d-b89a1448272c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a7dcf9d-7933-4062-aa2f-aa15fbcb92d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("656f5550-0748-4050-9394-186bd9bd235d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("897278ff-33d0-43d6-9deb-0d2be5be11f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c693d95-ed80-4a13-a86d-aa536f6246aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc1f9fe8-792b-428b-8364-cf20753543f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6519c22-adfb-47c5-95b0-ffdb6d2e2c5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1cd3c55-4da6-45ef-b205-6ba755c2abbb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4acc52d-5a96-4e33-bc0a-9b8b2089bd73"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("2ccccd04-7bcf-423f-a5de-319f80a7658c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3fff6867-7696-4ea5-864a-d85d0468377d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("981c8174-9533-404e-95b3-f2239d35131d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e754874a-cb88-4bdd-9801-d6a3a8d9c2b4"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0aa33afb-e2c6-4166-b74a-e9bdfa4b4c78"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("4e7eb8a6-6ced-4cfb-b2af-8e37bbb63e6e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("a83e7b6b-2dff-4c31-8d7d-f274cb7228ab"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d0e8f8f8-080d-46e4-95a2-6c072fe1ea1a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("39639cb1-5498-4662-8734-b773259b5453"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("7831d9d1-b66d-47d6-8d30-082129fa8603"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("888de1b2-e650-4b1e-ac92-28dd6002d2bc"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("89b60708-d8be-49d1-a9fe-ccd5705f8c67"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b6d71bd8-bdd9-404b-9468-5f2af946b4f6"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("cfc24f1b-7b88-4fbf-abd0-3c0497521de0"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("1eb148b5-d009-4567-823b-54b0b8aaae30"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0063f531-66e4-4a97-bd03-5b06702cdee6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("148ae103-c5c2-4a25-9d75-96f3f2b36e30"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2e01fd0c-d264-415d-8882-9e1958fb356a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4065f3bf-a8cd-4bec-95ad-028930cd7e03"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("55a513f4-3f3b-480d-86dd-7839e5763231"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b906b7a5-7fe9-463f-8d40-2dcb8df630d5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("132a2a2c-97d0-40e6-995c-4a9ce5576416"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("17dccfce-e92b-445e-acb1-839286dc4450"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9e91b006-7f56-454b-aa23-62c1044cef13"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("afe838ba-8f0f-4d39-8789-d3f7dd0934f9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("515688c1-7bc8-4d21-bf1a-b17c7a94a1cc"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5970e2a2-2d20-4c2c-8ddc-38624e7452a7"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7acb42d8-754b-4c41-93d7-b613248f6b76"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9d6a8bab-fbc7-4485-a73d-5de114bfb43a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9f577bd2-cab9-47a9-8b3c-9cb8f785ce45"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1230f7ef-2ad1-4874-918e-eef77d80b722"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7ff22c11-b4a3-41ed-9343-fda3bf013ad0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9f628e1b-8dd9-49d1-a222-968206bb91c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0ea4656-f3a6-4da6-9e06-14251ec4f20d"));

            migrationBuilder.AddColumn<bool>(
                name: "IsBannedByAdmin",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEditor",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsModerator",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPending",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStandardUser",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSuperAdmin",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1648f386-9812-4f96-94d3-b77a7e38a4ec"), "Rome", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4388), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("260d4dbd-3990-46c5-a0e3-c2c2e89d019f"), "Madrid", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4392), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("526b2f5c-a86f-4784-83f4-0cb0721cf385"), "Amsterdam", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4368), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("6691fe81-7ab4-4d97-81d7-64206f599a7f"), "Berlin", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4363), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("86725127-cc55-49de-aa25-f34e8ff564b5"), "London", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4383), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("95c03a6d-dd58-4c4f-a51d-9328e0a1cdd0"), "Bern", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4396), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("a2ad1e63-8361-45f6-b979-a25a000b51e0"), "Brussels", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(3221), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("a78cf388-fcd2-4964-9ea4-c68e972daaa9"), "Vienna", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4402), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("aa7a8c6a-8465-4a72-9cb9-2808fdf0acf0"), "Paris", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4357), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("f2e7afb8-dfba-40e0-87af-51eb2fa8d6ed"), "Luxembourg", new DateTime(2025, 2, 10, 18, 59, 48, 999, DateTimeKind.Utc).AddTicks(4406), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c198ab3-8fbd-411f-8307-261fa4d887dc"), "EUR", new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(1853), 2, true, "Euro", "€", null },
                    { new Guid("1a24834d-3548-4686-9553-74bc82da84fb"), "CHF", new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(4004), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("8addab33-0778-4a80-a58e-ade4d7ca58ef"), "USD", new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(3981), 2, true, "US Dollar", "$", null },
                    { new Guid("c8fb9e0e-fd36-4680-bfd6-9bd27f2f2cf8"), "GBP", new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(4001), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("087ec2fa-eb0d-401f-9e3e-a31b237a10f6"), new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(317), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("350a885c-f6dc-4f4f-85ec-c1046bfcbd74"), new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(187), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("b30a9363-8a23-421c-9864-61a741944378"), new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(321), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("ddb2b178-8af9-48f8-b465-d14463ff6638"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(8943), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5bb1253e-5500-4bb9-bf0f-12aba90a9712"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(5211), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("cae42625-fd23-4f8f-b359-5519c859b1b8"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(5222), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("cb975699-d192-401e-81ea-201f1ef5f1e9"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(3610), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("ee5f85de-016f-4566-8789-3fe147263822"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(5227), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("f0a774a0-e4e4-46c0-82ba-3b757fda5a66"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(5224), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("f266d3cc-0273-4c4c-af2b-152ed6f0b056"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(5220), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("cae2f507-0bfc-405e-9389-38968e172263"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(6422), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("27a550b5-3dff-4d2a-94c7-33d9fe2d7033"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(2285), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("2da3f760-37e0-4522-8222-83feb03605b2"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(874), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("9f7d7551-ed1e-497e-a030-b3ce74d0d49d"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(2369), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("d03f9ddd-4540-439d-992e-00fcfb536f3a"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(2299), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("e378676c-d862-4ead-8623-e19769a051dc"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(2297), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("f27060de-d9ab-4442-b93d-b622f9945bb8"), new DateTime(2025, 2, 10, 18, 59, 48, 997, DateTimeKind.Utc).AddTicks(2366), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ccc9a36-3f22-40e7-9219-9bb599fec7a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("937142cb-10d2-4780-b01d-2676b1ecee2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("a83de6e7-a421-4936-904f-90ec83d23b25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("d7570e19-ec88-4f4a-b92f-004e900c86af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("08c4dd85-effd-40a4-9f63-20bbd4fa3d5e"), new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(8077), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("5a0b3f8a-fa2c-4d85-ba1d-ea109be66dad"), new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(5687), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("a8fd1d21-32eb-4e6b-a9c6-a7343ccfe5b0"), new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(8126), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("c05d8f8e-5553-45b6-b6b8-f4cb7e449040"), new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(8122), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("d06b705c-7dc9-4967-ae36-59396023c35a"), new DateTime(2025, 2, 10, 18, 59, 48, 998, DateTimeKind.Utc).AddTicks(8107), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 10, 18, 59, 49, 0, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("67d84007-e60a-40e5-b795-66e60d8f91dd"), new DateTime(2025, 2, 10, 18, 59, 49, 0, DateTimeKind.Utc).AddTicks(4603), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("ba9957ba-28ca-445e-8ad4-b76c1d82e1dd"), new DateTime(2025, 2, 10, 18, 59, 49, 0, DateTimeKind.Utc).AddTicks(4588), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("e5a6c790-3f14-4d42-9097-8d1283b52ab3"), new DateTime(2025, 2, 10, 18, 59, 49, 0, DateTimeKind.Utc).AddTicks(3981), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsBannedByAdmin", "IsBlocked", "IsDeleted", "IsEditor", "IsLockedOut", "IsModerator", "IsPending", "IsStandardUser", "IsSuperAdmin", "IsVerified", "LastLogin", "LastName", "LinkUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "Website" },
                values: new object[,]
                {
                    { new Guid("553d6b66-5b55-4ed0-85a8-6ac98941879e"), 0, null, "user@example.com", new DateTime(2025, 2, 10, 18, 59, 48, 996, DateTimeKind.Utc).AddTicks(1195), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user@example.com", false, 0, "User", true, true, false, false, false, false, false, false, false, false, false, false, new DateTime(2025, 2, 10, 18, 59, 48, 996, DateTimeKind.Utc).AddTicks(1179), "Example", null, false, null, null, "USER@EXAMPLE.COM", "EXAMPLE_USER", "oW2X3P0AysSuqjhwAUrglBUeqPg/gTJewLJGS1uGikpGeLmlbEE6UCs7ROlPadcY", null, "+123456789", true, null, "https://asafarim.com/logoT.svg", "user@example.com", false, new DateTime(2025, 2, 10, 18, 59, 48, 996, DateTimeKind.Utc).AddTicks(1196), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "example_user", null },
                    { new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), 0, null, "ali@asafarim.com", new DateTime(2025, 2, 10, 18, 59, 48, 974, DateTimeKind.Utc).AddTicks(3637), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali R.", true, true, false, false, false, false, false, false, false, false, false, false, new DateTime(2025, 2, 10, 18, 59, 48, 974, DateTimeKind.Utc).AddTicks(619), "Safari", null, false, null, null, "ALI@ASAFARIM.COM", "ALIRZA", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, "+123456789", true, null, "https://asafarim.com/logoT.svg", "ali@asafarim.com", false, new DateTime(2025, 2, 10, 18, 59, 48, 974, DateTimeKind.Utc).AddTicks(4587), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "alireza", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1648f386-9812-4f96-94d3-b77a7e38a4ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("260d4dbd-3990-46c5-a0e3-c2c2e89d019f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("526b2f5c-a86f-4784-83f4-0cb0721cf385"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6691fe81-7ab4-4d97-81d7-64206f599a7f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86725127-cc55-49de-aa25-f34e8ff564b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95c03a6d-dd58-4c4f-a51d-9328e0a1cdd0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2ad1e63-8361-45f6-b979-a25a000b51e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a78cf388-fcd2-4964-9ea4-c68e972daaa9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa7a8c6a-8465-4a72-9cb9-2808fdf0acf0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2e7afb8-dfba-40e0-87af-51eb2fa8d6ed"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0c198ab3-8fbd-411f-8307-261fa4d887dc"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1a24834d-3548-4686-9553-74bc82da84fb"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8addab33-0778-4a80-a58e-ade4d7ca58ef"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c8fb9e0e-fd36-4680-bfd6-9bd27f2f2cf8"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("087ec2fa-eb0d-401f-9e3e-a31b237a10f6"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("350a885c-f6dc-4f4f-85ec-c1046bfcbd74"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("b30a9363-8a23-421c-9864-61a741944378"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ddb2b178-8af9-48f8-b465-d14463ff6638"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5bb1253e-5500-4bb9-bf0f-12aba90a9712"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("cae42625-fd23-4f8f-b359-5519c859b1b8"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("cb975699-d192-401e-81ea-201f1ef5f1e9"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ee5f85de-016f-4566-8789-3fe147263822"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f0a774a0-e4e4-46c0-82ba-3b757fda5a66"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f266d3cc-0273-4c4c-af2b-152ed6f0b056"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("cae2f507-0bfc-405e-9389-38968e172263"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("27a550b5-3dff-4d2a-94c7-33d9fe2d7033"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2da3f760-37e0-4522-8222-83feb03605b2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9f7d7551-ed1e-497e-a030-b3ce74d0d49d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d03f9ddd-4540-439d-992e-00fcfb536f3a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e378676c-d862-4ead-8623-e19769a051dc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f27060de-d9ab-4442-b93d-b622f9945bb8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1ccc9a36-3f22-40e7-9219-9bb599fec7a7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("937142cb-10d2-4780-b01d-2676b1ecee2c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a83de6e7-a421-4936-904f-90ec83d23b25"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d7570e19-ec88-4f4a-b92f-004e900c86af"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("08c4dd85-effd-40a4-9f63-20bbd4fa3d5e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5a0b3f8a-fa2c-4d85-ba1d-ea109be66dad"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("a8fd1d21-32eb-4e6b-a9c6-a7343ccfe5b0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c05d8f8e-5553-45b6-b6b8-f4cb7e449040"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("d06b705c-7dc9-4967-ae36-59396023c35a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("67d84007-e60a-40e5-b795-66e60d8f91dd"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ba9957ba-28ca-445e-8ad4-b76c1d82e1dd"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e5a6c790-3f14-4d42-9097-8d1283b52ab3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("553d6b66-5b55-4ed0-85a8-6ac98941879e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"));

            migrationBuilder.DropColumn(
                name: "IsBannedByAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsEditor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsModerator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsPending",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsStandardUser",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsSuperAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03e61219-a0b5-4a81-a405-8ea9748f2da7"), "Bern", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9180), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("22866fec-7869-4527-894d-b89a1448272c"), "Madrid", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9176), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("3a7dcf9d-7933-4062-aa2f-aa15fbcb92d4"), "Vienna", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9183), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("656f5550-0748-4050-9394-186bd9bd235d"), "Berlin", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9160), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("897278ff-33d0-43d6-9deb-0d2be5be11f5"), "Rome", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9169), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("8c693d95-ed80-4a13-a86d-aa536f6246aa"), "Luxembourg", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9186), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("bc1f9fe8-792b-428b-8364-cf20753543f2"), "Amsterdam", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9163), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("c6519c22-adfb-47c5-95b0-ffdb6d2e2c5e"), "Paris", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9156), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("f1cd3c55-4da6-45ef-b205-6ba755c2abbb"), "London", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(9166), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("f4acc52d-5a96-4e33-bc0a-9b8b2089bd73"), "Brussels", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(8615), true, "BE", "BEL", "Belgium", "België", "+32", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ccccd04-7bcf-423f-a5de-319f80a7658c"), "GBP", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(3596), 2, true, "British Pound", "£", null },
                    { new Guid("3fff6867-7696-4ea5-864a-d85d0468377d"), "USD", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(3587), 2, true, "US Dollar", "$", null },
                    { new Guid("981c8174-9533-404e-95b3-f2239d35131d"), "CHF", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(3642), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("e754874a-cb88-4bdd-9801-d6a3a8d9c2b4"), "EUR", new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(2187), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0aa33afb-e2c6-4166-b74a-e9bdfa4b4c78"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(1366), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("4e7eb8a6-6ced-4cfb-b2af-8e37bbb63e6e"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(186), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("a83e7b6b-2dff-4c31-8d7d-f274cb7228ab"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(1363), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("d0e8f8f8-080d-46e4-95a2-6c072fe1ea1a"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(1356), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("39639cb1-5498-4662-8734-b773259b5453"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6669), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("7831d9d1-b66d-47d6-8d30-082129fa8603"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6672), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("888de1b2-e650-4b1e-ac92-28dd6002d2bc"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6623), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("89b60708-d8be-49d1-a9fe-ccd5705f8c67"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(5023), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("b6d71bd8-bdd9-404b-9468-5f2af946b4f6"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6631), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("cfc24f1b-7b88-4fbf-abd0-3c0497521de0"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(6640), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("1eb148b5-d009-4567-823b-54b0b8aaae30"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(7636), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0063f531-66e4-4a97-bd03-5b06702cdee6"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3774), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("148ae103-c5c2-4a25-9d75-96f3f2b36e30"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3710), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("2e01fd0c-d264-415d-8882-9e1958fb356a"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3770), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("4065f3bf-a8cd-4bec-95ad-028930cd7e03"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3772), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("55a513f4-3f3b-480d-86dd-7839e5763231"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(3767), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("b906b7a5-7fe9-463f-8d40-2dcb8df630d5"), new DateTime(2025, 2, 9, 20, 30, 20, 898, DateTimeKind.Utc).AddTicks(2570), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("132a2a2c-97d0-40e6-995c-4a9ce5576416"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("17dccfce-e92b-445e-acb1-839286dc4450"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("9e91b006-7f56-454b-aa23-62c1044cef13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("afe838ba-8f0f-4d39-8789-d3f7dd0934f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("515688c1-7bc8-4d21-bf1a-b17c7a94a1cc"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(4493), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("5970e2a2-2d20-4c2c-8ddc-38624e7452a7"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(5823), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("7acb42d8-754b-4c41-93d7-b613248f6b76"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(5833), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("9d6a8bab-fbc7-4485-a73d-5de114bfb43a"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(5817), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("9f577bd2-cab9-47a9-8b3c-9cb8f785ce45"), new DateTime(2025, 2, 9, 20, 30, 20, 899, DateTimeKind.Utc).AddTicks(5825), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 20, 30, 20, 900, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1230f7ef-2ad1-4874-918e-eef77d80b722"), new DateTime(2025, 2, 9, 20, 30, 20, 900, DateTimeKind.Utc).AddTicks(4422), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("7ff22c11-b4a3-41ed-9343-fda3bf013ad0"), new DateTime(2025, 2, 9, 20, 30, 20, 900, DateTimeKind.Utc).AddTicks(4413), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("9f628e1b-8dd9-49d1-a222-968206bb91c9"), new DateTime(2025, 2, 9, 20, 30, 20, 900, DateTimeKind.Utc).AddTicks(4076), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LinkUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "Website" },
                values: new object[,]
                {
                    { new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"), 0, null, "ali@asafarim.com", new DateTime(2025, 2, 9, 20, 30, 20, 883, DateTimeKind.Utc).AddTicks(2660), new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali R.", true, true, false, false, new DateTime(2025, 2, 9, 20, 30, 20, 883, DateTimeKind.Utc).AddTicks(201), "Safari", null, false, null, null, "ALI@ASAFARIM.COM", "ALIRZA", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, "+123456789", true, null, "https://asafarim.com/logoT.svg", "ali@asafarim.com", false, new DateTime(2025, 2, 9, 20, 30, 20, 883, DateTimeKind.Utc).AddTicks(3514), new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"), "alireza", null },
                    { new Guid("c0ea4656-f3a6-4da6-9e06-14251ec4f20d"), 0, null, "user@example.com", new DateTime(2025, 2, 9, 20, 30, 20, 897, DateTimeKind.Utc).AddTicks(4066), new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user@example.com", false, 0, "User", true, true, false, false, new DateTime(2025, 2, 9, 20, 30, 20, 897, DateTimeKind.Utc).AddTicks(4050), "Example", null, false, null, null, "USER@EXAMPLE.COM", "EXAMPLE_USER", "K5xcN3fxatw18eLGtLLoqwTYyN7hhHzyP0MkU4yCJcdPn61r3PVK+3SHlQiMaeKq", null, "+123456789", true, null, "https://asafarim.com/logoT.svg", "user@example.com", false, new DateTime(2025, 2, 9, 20, 30, 20, 897, DateTimeKind.Utc).AddTicks(4067), new Guid("2e87a96e-c37f-4701-8269-5472fb523af8"), "example_user", null }
                });
        }
    }
}
