using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsernameFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17eb3cea-de68-480c-9865-4a054760ba98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3697cee4-a8fb-465e-8320-41db2f6130cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("592d1fa1-aecb-447c-80a1-ec63199a25a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69105467-07af-4acb-9f57-4e19c3cd3290"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b6391ec-29aa-45b3-9c92-0cc0bc84b8fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("951f0fca-43a6-4471-9038-acba9770fa26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b09470b-308a-4742-9003-fbc296f31a26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("adbdb57a-5a70-4456-a074-fa80270ca63d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c491a895-9072-4baa-b213-03209d1bd9ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd1a0356-9594-4fc7-9e7c-57dba78b40d9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("056cd6b6-9d66-4c45-b50f-a84d32f8d617"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5b171e0d-a946-4890-a5b4-eba30afe231c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8bf4f54b-0f11-4341-9c10-f8b38b7de63a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f17011a9-f22a-485c-9b69-db93fcadf042"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("146bf1df-102f-4edd-9fa5-5aabffc66978"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("38c79b2e-ddc6-416d-a6c4-539dca9dc688"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("b11768ad-74db-4497-be93-afd6b154c433"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("bf02c6e1-94fa-4551-8be7-d7eca9e33f12"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3980b986-8c96-451c-a050-a7924969b0c6"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("58521f44-f883-423e-af8d-2c51f3d682e9"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d5f65b01-a3a5-496e-81ff-ee8034e11a77"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f24dd29e-d780-4832-9c6d-843f51997841"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f95cda4d-9ee6-4047-bdcb-3457ec21e8f6"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fec3e351-095e-40c2-88ef-eff9104e8293"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("c4489a12-6b2e-46e8-9ef9-d7312d421b47"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("38410c74-65f0-4b8c-9560-70c86defe428"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("45a6d3fa-0de8-49aa-a85b-637b2ccb2412"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("500d9d46-2f56-4625-ad55-5be06dbd9985"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6318494f-4efd-4880-b06f-00ae603ca890"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6c35982a-e703-4f2b-a973-4b9f8e976bc8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7dc19212-3ab1-4abb-9c85-76fac248265d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("28683387-597e-4334-af73-dfd17ae0548a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7367b635-b175-48f3-b8ee-ec2277e2894b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dff24815-be6f-42bc-b043-3a6ecaeec9c1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f0649060-7d35-4d78-9a6a-095207e2e31d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3448dd99-0358-4601-9a75-62218b239331"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("423b0fd3-e4a4-4a92-a316-c4416cc81543"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("87cae171-0e0b-4dee-9eb4-779e7a7f37c0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ba9bd6ba-5780-4cfa-8e6d-e927d31d08e6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("dc934346-b5da-4e49-a754-6a73797e3c51"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7bf6cec5-7c34-4ca3-b6c7-84f48c5d6a7e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ad3dfac2-6514-4c90-9016-e34041331c7c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e7d16743-73a0-43b2-832d-6a66ca78e874"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ed2c4aa-037b-45d1-a520-d248d0b37aab"), "Vienna", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4476), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("449f1e52-a8b7-4d2a-b8fb-a6dd3650451f"), "Amsterdam", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4461), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("4848ad02-b004-4699-945e-89fef4d140bf"), "Madrid", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4471), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("5a7a435d-01dd-4c82-8cac-07847a442da4"), "Rome", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4467), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("61b6f335-aecd-402d-b51b-e442f355d414"), "London", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4464), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("70ac55f2-a9a7-4f25-976f-6deb9be134d3"), "Paris", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4448), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("8ecae63e-8ca2-4087-875e-152570de3c6e"), "Brussels", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(3675), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("9451593d-5378-49d9-a688-cc01bdcdd1dc"), "Bern", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4474), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("9901be28-4ceb-4655-99ce-282fa086315d"), "Berlin", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4457), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("f02728d2-7418-421a-8017-07dbfd0527da"), "Luxembourg", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4479), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("241db133-719d-41e3-874c-a45942c00729"), "GBP", new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(8272), 2, true, "British Pound", "£", null },
                    { new Guid("6aafd072-630b-4cf5-a226-84335a9bd91f"), "EUR", new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(7175), 2, true, "Euro", "€", null },
                    { new Guid("b10518b5-0bef-43f0-b123-c090c4eaea91"), "USD", new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(8266), 2, true, "US Dollar", "$", null },
                    { new Guid("cc6e0501-ff30-4f9e-9d82-129cf41a4bee"), "CHF", new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(8274), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1fee1144-78c4-4b11-8d85-a556c21e513e"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(6149), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("c3681633-0f6c-47a3-b2bf-a95df39aeb4b"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(4725), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("d8b6c2c8-b3f2-4d19-88f4-235cba844a19"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(6161), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("f4654dd7-a2b1-47ad-8179-a2bb77deee21"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(6159), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("10ffe8c7-2ad2-4dd1-9722-adbafbb5453c"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(950), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("5d6f6345-61ee-4fab-a85d-1167ff7de056"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(939), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("61fb1b62-63be-465b-970a-467420bd7cfa"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(954), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("81325055-e094-48fb-9b1a-529024273d5f"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(9182), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("8e581443-531d-4065-9a63-ee7cc93a84e1"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(952), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("e36b174a-d761-4a71-ab6d-8ef9b34e2a6e"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(947), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("debdb566-067e-47f1-a262-e3d0a7b28569"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(2170), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("24adf3eb-cba7-4738-b035-38f49808ac40"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7780), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("285a37c4-7f25-4060-9493-0f630b538d8c"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7770), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("7159c0c9-38b2-4921-9413-e1a0c312d321"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7768), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("8ce7c3b0-626b-417f-8350-5b86155d8da3"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7766), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("b22e342d-2369-4088-aa06-7284897d961c"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7757), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("dbefd6f2-d673-4155-9150-cf46f3041f05"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(6619), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00277422-6bfd-4157-be28-7e26f72f3f49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("11a1332f-85ac-458d-a272-fd9b7b411171"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("44ff8e1b-4b38-4f9a-ab2b-b77cbee44fff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("fc6265c0-10b8-4bf8-a6a3-7a3d51538607"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("18bd07c5-2c7c-4c17-8de3-888f5b63e1e0"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(757), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("20ea42af-4c4f-42a8-b750-23d1d218438d"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(748), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("7b6ab23b-6eb1-4039-a8e3-d866cadd1630"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(801), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("7c368677-cf1c-46b5-a40d-d681dd2f981b"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(9103), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("afddfdfb-c695-488f-b6e0-2ff5ecf042a5"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(803), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1d77f898-2a90-4cae-a8d5-eb4c98db2dcc"), new DateTime(2025, 2, 14, 12, 56, 29, 343, DateTimeKind.Utc).AddTicks(244), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("601763c7-8497-4100-94cd-12e001374f89"), new DateTime(2025, 2, 14, 12, 56, 29, 343, DateTimeKind.Utc).AddTicks(251), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("a1471090-996e-4816-8c24-598afacbcea6"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(9942), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 56, 29, 246, DateTimeKind.Utc).AddTicks(7110), new DateTime(2025, 2, 14, 12, 56, 29, 246, DateTimeKind.Utc).AddTicks(7095), "/Pm0tb+EbtZ5PFm9KV7nh7IfTtadgpcXMsn8OCdCOKmGPdlulVje35xmYcp0VfOG", new DateTime(2025, 2, 14, 12, 56, 29, 246, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_1@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 271, DateTimeKind.Utc).AddTicks(1777), "user_1@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 271, DateTimeKind.Utc).AddTicks(1772), "USER_1@EXAMPLE.COM", "+BMF1ik/R6y5HUpYdK6E3zHRLuIs3tIUPIfXsg5RIv5KgCugIY+x35M7DydVfENw", "user_1@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 271, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_2@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 278, DateTimeKind.Utc).AddTicks(7204), "user_2@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 278, DateTimeKind.Utc).AddTicks(7201), "USER_2@EXAMPLE.COM", "QEWERsjUcypZcOcwCPOsYK8Ch6wjQuN/89Ppfe9fPTD58VYw/D7VyB7Z7Py1N58h", "user_2@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 278, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_3@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 286, DateTimeKind.Utc).AddTicks(557), "user_3@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 286, DateTimeKind.Utc).AddTicks(554), "USER_3@EXAMPLE.COM", "xcDuj6ugmilc/LqZnn7DGFy9ZqZI4dx752tGSJzux0V+sq80s7EhyOdxAaYooJHA", "user_3@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 286, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_4@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 293, DateTimeKind.Utc).AddTicks(6080), "user_4@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 293, DateTimeKind.Utc).AddTicks(6077), "USER_4@EXAMPLE.COM", "dgrVOHmKZRl8rC1JrCPWHbxIyasdhh6GEK+25z7S3CPAYIQL/J5O8VTe7yXS4RjW", "user_4@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 293, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_5@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 299, DateTimeKind.Utc).AddTicks(8468), "user_5@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 299, DateTimeKind.Utc).AddTicks(8463), "USER_5@EXAMPLE.COM", "bU12w8sXel3MzLy0r+F10Kgn+ExAofgCEH9HRykpaJ/d7raWP4xUUhjYHaIZvClS", "user_5@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 299, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_6@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 305, DateTimeKind.Utc).AddTicks(5108), "user_6@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 305, DateTimeKind.Utc).AddTicks(5091), "USER_6@EXAMPLE.COM", "xJ7lwgE0tBv4zz2hRSrDD4/5xePUDIPDLaWuSnzWIE/P/YRBSA/rx19VK89+7Jl5", "user_6@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 305, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_7@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 316, DateTimeKind.Utc).AddTicks(3123), "user_7@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 316, DateTimeKind.Utc).AddTicks(3119), "USER_7@EXAMPLE.COM", "GtH93ZdjW8rlvyvGee8/3LoJ4dSgOXuHUUFH9UPQeuHKhgZjH41zWSAXGMHWCwso", "user_7@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 316, DateTimeKind.Utc).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_8@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 325, DateTimeKind.Utc).AddTicks(7057), "user_8@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 325, DateTimeKind.Utc).AddTicks(7054), "USER_8@EXAMPLE.COM", "dp3Ci4FZ1CYbDu3YEs9OCMxle+MGh9an/gkNT8SXO6dmRds3+de99WeFhUmVSwbB", "user_8@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 325, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_9@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 332, DateTimeKind.Utc).AddTicks(8975), "user_9@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 332, DateTimeKind.Utc).AddTicks(8971), "USER_9@EXAMPLE.COM", "/hplP/HOx2tsDWX3Qp+9IiZ7983IfUzDfvEBcguDFQMiEb4VD2I4glIlRRdCGD3C", "user_9@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 332, DateTimeKind.Utc).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user_10@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(3580), "user_10@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(3575), "USER_10@EXAMPLE.COM", "wCTGND6dGiq17alq4pof6sr31wBYarD+o4Q5iGEDssqLF9+smJSYCRmuge2k+kp0", "user_10@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 56, 29, 227, DateTimeKind.Utc).AddTicks(4147), new DateTime(2025, 2, 14, 12, 56, 29, 227, DateTimeKind.Utc).AddTicks(1186), new DateTime(2025, 2, 14, 12, 56, 29, 227, DateTimeKind.Utc).AddTicks(5331) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ed2c4aa-037b-45d1-a520-d248d0b37aab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("449f1e52-a8b7-4d2a-b8fb-a6dd3650451f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4848ad02-b004-4699-945e-89fef4d140bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a7a435d-01dd-4c82-8cac-07847a442da4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61b6f335-aecd-402d-b51b-e442f355d414"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70ac55f2-a9a7-4f25-976f-6deb9be134d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ecae63e-8ca2-4087-875e-152570de3c6e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9451593d-5378-49d9-a688-cc01bdcdd1dc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9901be28-4ceb-4655-99ce-282fa086315d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f02728d2-7418-421a-8017-07dbfd0527da"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("241db133-719d-41e3-874c-a45942c00729"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6aafd072-630b-4cf5-a226-84335a9bd91f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b10518b5-0bef-43f0-b123-c090c4eaea91"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cc6e0501-ff30-4f9e-9d82-129cf41a4bee"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("1fee1144-78c4-4b11-8d85-a556c21e513e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("c3681633-0f6c-47a3-b2bf-a95df39aeb4b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d8b6c2c8-b3f2-4d19-88f4-235cba844a19"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("f4654dd7-a2b1-47ad-8179-a2bb77deee21"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("10ffe8c7-2ad2-4dd1-9722-adbafbb5453c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5d6f6345-61ee-4fab-a85d-1167ff7de056"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("61fb1b62-63be-465b-970a-467420bd7cfa"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("81325055-e094-48fb-9b1a-529024273d5f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("8e581443-531d-4065-9a63-ee7cc93a84e1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e36b174a-d761-4a71-ab6d-8ef9b34e2a6e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("debdb566-067e-47f1-a262-e3d0a7b28569"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("24adf3eb-cba7-4738-b035-38f49808ac40"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("285a37c4-7f25-4060-9493-0f630b538d8c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7159c0c9-38b2-4921-9413-e1a0c312d321"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8ce7c3b0-626b-417f-8350-5b86155d8da3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b22e342d-2369-4088-aa06-7284897d961c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dbefd6f2-d673-4155-9150-cf46f3041f05"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00277422-6bfd-4157-be28-7e26f72f3f49"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("11a1332f-85ac-458d-a272-fd9b7b411171"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("44ff8e1b-4b38-4f9a-ab2b-b77cbee44fff"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fc6265c0-10b8-4bf8-a6a3-7a3d51538607"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("18bd07c5-2c7c-4c17-8de3-888f5b63e1e0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("20ea42af-4c4f-42a8-b750-23d1d218438d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7b6ab23b-6eb1-4039-a8e3-d866cadd1630"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7c368677-cf1c-46b5-a40d-d681dd2f981b"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("afddfdfb-c695-488f-b6e0-2ff5ecf042a5"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1d77f898-2a90-4cae-a8d5-eb4c98db2dcc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("601763c7-8497-4100-94cd-12e001374f89"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a1471090-996e-4816-8c24-598afacbcea6"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("17eb3cea-de68-480c-9865-4a054760ba98"), "Amsterdam", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1334), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("3697cee4-a8fb-465e-8320-41db2f6130cf"), "Berlin", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1327), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("592d1fa1-aecb-447c-80a1-ec63199a25a9"), "London", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1336), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("69105467-07af-4acb-9f57-4e19c3cd3290"), "Brussels", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(902), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("6b6391ec-29aa-45b3-9c92-0cc0bc84b8fd"), "Bern", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1343), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("951f0fca-43a6-4471-9038-acba9770fa26"), "Luxembourg", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1348), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("9b09470b-308a-4742-9003-fbc296f31a26"), "Paris", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1324), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("adbdb57a-5a70-4456-a074-fa80270ca63d"), "Rome", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1339), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("c491a895-9072-4baa-b213-03209d1bd9ed"), "Vienna", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1345), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("cd1a0356-9594-4fc7-9e7c-57dba78b40d9"), "Madrid", new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(1341), true, "ES", "ESP", "Spain", "España", "+34", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("056cd6b6-9d66-4c45-b50f-a84d32f8d617"), "EUR", new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(5319), 2, true, "Euro", "€", null },
                    { new Guid("5b171e0d-a946-4890-a5b4-eba30afe231c"), "USD", new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(6382), 2, true, "US Dollar", "$", null },
                    { new Guid("8bf4f54b-0f11-4341-9c10-f8b38b7de63a"), "GBP", new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(6387), 2, true, "British Pound", "£", null },
                    { new Guid("f17011a9-f22a-485c-9b69-db93fcadf042"), "CHF", new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(6388), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("146bf1df-102f-4edd-9fa5-5aabffc66978"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(3751), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("38c79b2e-ddc6-416d-a6c4-539dca9dc688"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(4676), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("b11768ad-74db-4497-be93-afd6b154c433"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(4669), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("bf02c6e1-94fa-4551-8be7-d7eca9e33f12"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(4678), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3980b986-8c96-451c-a050-a7924969b0c6"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(835), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("58521f44-f883-423e-af8d-2c51f3d682e9"), new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(9376), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("d5f65b01-a3a5-496e-81ff-ee8034e11a77"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(826), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("f24dd29e-d780-4832-9c6d-843f51997841"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(834), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("f95cda4d-9ee6-4047-bdcb-3457ec21e8f6"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(837), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("fec3e351-095e-40c2-88ef-eff9104e8293"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(839), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("c4489a12-6b2e-46e8-9ef9-d7312d421b47"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(1585), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("38410c74-65f0-4b8c-9560-70c86defe428"), new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(7533), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("45a6d3fa-0de8-49aa-a85b-637b2ccb2412"), new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(8416), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("500d9d46-2f56-4625-ad55-5be06dbd9985"), new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(8418), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("6318494f-4efd-4880-b06f-00ae603ca890"), new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(8408), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("6c35982a-e703-4f2b-a973-4b9f8e976bc8"), new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(8420), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("7dc19212-3ab1-4abb-9c85-76fac248265d"), new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(8414), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("28683387-597e-4334-af73-dfd17ae0548a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("7367b635-b175-48f3-b8ee-ec2277e2894b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("dff24815-be6f-42bc-b043-3a6ecaeec9c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("f0649060-7d35-4d78-9a6a-095207e2e31d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("3448dd99-0358-4601-9a75-62218b239331"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(8686), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("423b0fd3-e4a4-4a92-a316-c4416cc81543"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(8653), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("87cae171-0e0b-4dee-9eb4-779e7a7f37c0"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(8647), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("ba9bd6ba-5780-4cfa-8e6d-e927d31d08e6"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(8684), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("dc934346-b5da-4e49-a754-6a73797e3c51"), new DateTime(2025, 2, 14, 12, 50, 31, 879, DateTimeKind.Utc).AddTicks(7239), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("7bf6cec5-7c34-4ca3-b6c7-84f48c5d6a7e"), new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(5120), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("ad3dfac2-6514-4c90-9016-e34041331c7c"), new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(5373), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("e7d16743-73a0-43b2-832d-6a66ca78e874"), new DateTime(2025, 2, 14, 12, 50, 31, 880, DateTimeKind.Utc).AddTicks(5378), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 806, DateTimeKind.Utc).AddTicks(7293), new DateTime(2025, 2, 14, 12, 50, 31, 806, DateTimeKind.Utc).AddTicks(7283), "HwsJkiGqv/T0oEg46QI5yAdTMR9o4VPIAkopxveUzRj+R05NNLiRHo9ltSZzTBFm", new DateTime(2025, 2, 14, 12, 50, 31, 806, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 1@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 826, DateTimeKind.Utc).AddTicks(2216), "user 1@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 826, DateTimeKind.Utc).AddTicks(2214), "USER 1@EXAMPLE.COM", "TiRT5ZwOnZk76oqmvyl2z4Hc2g9wSZV2Ik2OfQc//ByspmwAQxPAPkWSk3xHQ0TY", "user 1@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 826, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 2@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 832, DateTimeKind.Utc).AddTicks(408), "user 2@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 832, DateTimeKind.Utc).AddTicks(406), "USER 2@EXAMPLE.COM", "FFksrN2F7dVk9xdrwtcCkp8CU9Wvee8qA9FgVTtt6w4W4ZHbjt8WtSE0UwG0gANl", "user 2@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 832, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 3@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 837, DateTimeKind.Utc).AddTicks(8630), "user 3@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 837, DateTimeKind.Utc).AddTicks(8621), "USER 3@EXAMPLE.COM", "SunmPMGlZ1OAEo8y5GtXLDVR2uM49ZQp0GpJOnCT8JmT7dO/04bx+ug91mbH4TWQ", "user 3@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 837, DateTimeKind.Utc).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 4@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 843, DateTimeKind.Utc).AddTicks(7658), "user 4@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 843, DateTimeKind.Utc).AddTicks(7654), "USER 4@EXAMPLE.COM", "p+kGaPnwCcPjb6W7t3DUfAjSotsRrRCFzvbx7FycV96B58KsL6h3CpB1aFD3+8Jo", "user 4@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 843, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 5@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 849, DateTimeKind.Utc).AddTicks(4524), "user 5@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 849, DateTimeKind.Utc).AddTicks(4522), "USER 5@EXAMPLE.COM", "vSof7o9f1+JG1qz+1IjWvmezZbtLFZTs6OboeqbHvfh7RUvLik0eUYxBjiN6zYGT", "user 5@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 849, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 6@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 855, DateTimeKind.Utc).AddTicks(5527), "user 6@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 855, DateTimeKind.Utc).AddTicks(5522), "USER 6@EXAMPLE.COM", "ggKgXsVqw6Pu/JaypNv3/RDNXg62bHeRkkzOzL4P30Q81dGm0cKB9mjbvjGXBkST", "user 6@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 855, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 7@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 861, DateTimeKind.Utc).AddTicks(4472), "user 7@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 861, DateTimeKind.Utc).AddTicks(4467), "USER 7@EXAMPLE.COM", "refxK/hsj/5P2fdsSbhuCvY4TPwIvme9CtgBO3EfaLsBy+J4M68BWkzl2arFHq7W", "user 7@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 861, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 8@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 866, DateTimeKind.Utc).AddTicks(9929), "user 8@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 866, DateTimeKind.Utc).AddTicks(9924), "USER 8@EXAMPLE.COM", "UNxJ75OeWbyK+Idm0XttjSV6dqchD+iWC4wFlu8/cpyl8L2Hgy9U0hmTA4GjVy+5", "user 8@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 866, DateTimeKind.Utc).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 9@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 872, DateTimeKind.Utc).AddTicks(7355), "user 9@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 872, DateTimeKind.Utc).AddTicks(7350), "USER 9@EXAMPLE.COM", "4V7kDw5PzOP7lhFcE3x/tMruNreua/QE5witMx3EfD7Emg2R5W/irnPJd78CbSsK", "user 9@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 872, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "user 10@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(5504), "user 10@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(5498), "USER 10@EXAMPLE.COM", "hAPe0BUg+Kia4cIiStBPQitShRojUC1Dx6X2r+scKRsaq36hAswYqtht3LMojyxq", "user 10@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 793, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 2, 14, 12, 50, 31, 793, DateTimeKind.Utc).AddTicks(1978), new DateTime(2025, 2, 14, 12, 50, 31, 793, DateTimeKind.Utc).AddTicks(5560) });
        }
    }
}
