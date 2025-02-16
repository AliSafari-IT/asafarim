using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1572e3ae-9850-421e-b895-9836eb3a9529"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35e2ac04-4f40-41b9-bb41-438a7e93d0c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ff7afef-6db6-4094-bc5b-cfd33fad229f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72cc2158-48c5-41c0-a0e1-64dc06a90e4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72d054a8-c57c-4a22-aad5-249db1fbda5c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ec9fa84-64d9-4925-afc6-c5913b9da12c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa81e98d-81a4-467f-91d7-d9de2bfd0e32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2fc0532-5f40-4a4f-aa5c-ffd4e16bf500"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5868739-dbc8-415d-b519-d515f692da8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4311c32-2c0c-4b39-a73e-e44522f54772"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("9883b66b-b9bf-4e9c-bf7f-2fa8f7dcf82b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("9bc38d5a-2e2e-443a-bde7-f6c7802ce879"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a18af334-c2f1-41f4-9585-0760ab697da3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bd01f44d-172d-4009-9bc6-a2fe99fd136c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("05b13df8-4103-40da-8982-bda7d75808c1"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("07240416-e746-4d10-b173-380ed60b7e64"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("47601495-078d-4e1e-a390-1d534a327e7c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("caa5fe38-6bde-4c62-87fc-605be72587b0"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0d1cd387-9b2c-4b67-86e5-f7b9c8f144ee"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("220229ff-788c-421c-89de-cc48d0933b38"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5a17ab27-3c91-4d54-ab1e-d94c9081ee9a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("78940904-a244-4520-b779-66cd550b814d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("badd4bf3-2836-49fd-a1fe-681d1bebb742"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e9111a6c-c999-4be2-ae25-34c783647730"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("a4c93ce5-3c2f-4f6b-abfe-95bad0a81acc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4661b21f-bd06-403c-94f3-7ca3790d18bd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9750955c-85b3-43cb-9724-58f2565954f6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c6aa0f78-abb1-4826-bcb1-0210b39d8055"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cbb09250-91a5-4c39-aeea-6f7530f061e8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f4f70352-a29d-47e2-97db-41740b60e464"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fb584561-3c11-4be6-a32c-b6a23282091c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("270fb739-8160-4147-93d5-9a36fad4f6c4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5f54087d-a422-4fe8-a69b-d5f2f84a253d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("80e2b3d4-c7de-4407-9848-17c36dd2ea0b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aad0aef6-e79a-41c6-be9b-09f0bdeffe9e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("0f161059-2d44-424c-b054-f3a8327a1c5e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("889171cf-c7f3-48ea-8bdb-0600943d8dac"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("b1949593-0a08-4d2c-9afe-d331f2386e71"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("b20f42ee-72bf-406d-aa09-f6872b2410d1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("e4cc0ebf-524f-4d21-ad23-cb51a4aa87c9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2232a25d-7541-45cf-8fad-5beefe2eee23"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5c6bc460-4ae1-4107-a104-5adbf006696b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e214eaba-4cb6-499c-9fc1-5ee8367b898f"));

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
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 826, DateTimeKind.Utc).AddTicks(2216), new DateTime(1975, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 826, DateTimeKind.Utc).AddTicks(2214), "USER_1", "TiRT5ZwOnZk76oqmvyl2z4Hc2g9wSZV2Ik2OfQc//ByspmwAQxPAPkWSk3xHQ0TY", new DateTime(2025, 2, 14, 12, 50, 31, 826, DateTimeKind.Utc).AddTicks(2219), "user_1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 832, DateTimeKind.Utc).AddTicks(408), new DateTime(1975, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 832, DateTimeKind.Utc).AddTicks(406), "USER_2", "FFksrN2F7dVk9xdrwtcCkp8CU9Wvee8qA9FgVTtt6w4W4ZHbjt8WtSE0UwG0gANl", new DateTime(2025, 2, 14, 12, 50, 31, 832, DateTimeKind.Utc).AddTicks(409), "user_2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 837, DateTimeKind.Utc).AddTicks(8630), new DateTime(1975, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 837, DateTimeKind.Utc).AddTicks(8621), "USER_3", "SunmPMGlZ1OAEo8y5GtXLDVR2uM49ZQp0GpJOnCT8JmT7dO/04bx+ug91mbH4TWQ", new DateTime(2025, 2, 14, 12, 50, 31, 837, DateTimeKind.Utc).AddTicks(8632), "user_3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 843, DateTimeKind.Utc).AddTicks(7658), new DateTime(1975, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 843, DateTimeKind.Utc).AddTicks(7654), "USER_4", "p+kGaPnwCcPjb6W7t3DUfAjSotsRrRCFzvbx7FycV96B58KsL6h3CpB1aFD3+8Jo", new DateTime(2025, 2, 14, 12, 50, 31, 843, DateTimeKind.Utc).AddTicks(7661), "user_4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 849, DateTimeKind.Utc).AddTicks(4524), new DateTime(1975, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 849, DateTimeKind.Utc).AddTicks(4522), "USER_5", "vSof7o9f1+JG1qz+1IjWvmezZbtLFZTs6OboeqbHvfh7RUvLik0eUYxBjiN6zYGT", new DateTime(2025, 2, 14, 12, 50, 31, 849, DateTimeKind.Utc).AddTicks(4525), "user_5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 855, DateTimeKind.Utc).AddTicks(5527), new DateTime(1975, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 855, DateTimeKind.Utc).AddTicks(5522), "USER_6", "ggKgXsVqw6Pu/JaypNv3/RDNXg62bHeRkkzOzL4P30Q81dGm0cKB9mjbvjGXBkST", new DateTime(2025, 2, 14, 12, 50, 31, 855, DateTimeKind.Utc).AddTicks(5529), "user_6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 861, DateTimeKind.Utc).AddTicks(4472), new DateTime(1975, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 861, DateTimeKind.Utc).AddTicks(4467), "USER_7", "refxK/hsj/5P2fdsSbhuCvY4TPwIvme9CtgBO3EfaLsBy+J4M68BWkzl2arFHq7W", new DateTime(2025, 2, 14, 12, 50, 31, 861, DateTimeKind.Utc).AddTicks(4475), "user_7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 866, DateTimeKind.Utc).AddTicks(9929), new DateTime(1975, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 866, DateTimeKind.Utc).AddTicks(9924), "USER_8", "UNxJ75OeWbyK+Idm0XttjSV6dqchD+iWC4wFlu8/cpyl8L2Hgy9U0hmTA4GjVy+5", new DateTime(2025, 2, 14, 12, 50, 31, 866, DateTimeKind.Utc).AddTicks(9931), "user_8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 872, DateTimeKind.Utc).AddTicks(7355), new DateTime(1975, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 872, DateTimeKind.Utc).AddTicks(7350), "USER_9", "4V7kDw5PzOP7lhFcE3x/tMruNreua/QE5witMx3EfD7Emg2R5W/irnPJd78CbSsK", new DateTime(2025, 2, 14, 12, 50, 31, 872, DateTimeKind.Utc).AddTicks(7358), "user_9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(5504), new DateTime(1975, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, true, new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(5498), "USER_10", "hAPe0BUg+Kia4cIiStBPQitShRojUC1Dx6X2r+scKRsaq36hAswYqtht3LMojyxq", new DateTime(2025, 2, 14, 12, 50, 31, 878, DateTimeKind.Utc).AddTicks(5507), "user_10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "NormalizedUserName", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 50, 31, 793, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 2, 14, 12, 50, 31, 793, DateTimeKind.Utc).AddTicks(1978), "ALI", new DateTime(2025, 2, 14, 12, 50, 31, 793, DateTimeKind.Utc).AddTicks(5560), "ali" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "ForgotPasswordToken", "ForgotPasswordTokenExpiration", "IsActive", "IsAdmin", "IsBannedByAdmin", "IsBlocked", "IsDeleted", "IsEditor", "IsGuest", "IsLockedOut", "IsModerator", "IsPending", "IsStandardUser", "IsSuperAdmin", "IsVerified", "LastLogin", "LastName", "LinkUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetToken", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "Website" },
                values: new object[] { new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"), 0, null, "user@example.com", new DateTime(2025, 2, 14, 12, 50, 31, 806, DateTimeKind.Utc).AddTicks(7293), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user@example.com", false, 0, "User", null, null, true, true, false, false, false, false, false, false, false, false, true, false, true, new DateTime(2025, 2, 14, 12, 50, 31, 806, DateTimeKind.Utc).AddTicks(7283), "Example", null, false, null, null, "USER@EXAMPLE.COM", "USER", "HwsJkiGqv/T0oEg46QI5yAdTMR9o4VPIAkopxveUzRj+R05NNLiRHo9ltSZzTBFm", null, null, "+1234567890", true, null, "https://asafarim.com/logoT.svg", "user@example.com", false, new DateTime(2025, 2, 14, 12, 50, 31, 806, DateTimeKind.Utc).AddTicks(7294), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user", null });

            migrationBuilder.CreateIndex(
                name: "IX_ProgressHistories_StatusReason",
                table: "ProgressHistories",
                column: "StatusReason",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProgressHistories_StatusReason",
                table: "ProgressHistories");

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1572e3ae-9850-421e-b895-9836eb3a9529"), "Brussels", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1125), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("35e2ac04-4f40-41b9-bb41-438a7e93d0c1"), "Vienna", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1760), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("3ff7afef-6db6-4094-bc5b-cfd33fad229f"), "Bern", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1756), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("72cc2158-48c5-41c0-a0e1-64dc06a90e4e"), "Amsterdam", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1737), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("72d054a8-c57c-4a22-aad5-249db1fbda5c"), "Madrid", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1747), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("7ec9fa84-64d9-4925-afc6-c5913b9da12c"), "Berlin", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1734), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("aa81e98d-81a4-467f-91d7-d9de2bfd0e32"), "London", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1741), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("b2fc0532-5f40-4a4f-aa5c-ffd4e16bf500"), "Paris", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1730), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("e5868739-dbc8-415d-b519-d515f692da8e"), "Rome", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1744), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("f4311c32-2c0c-4b39-a73e-e44522f54772"), "Luxembourg", new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(1763), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9883b66b-b9bf-4e9c-bf7f-2fa8f7dcf82b"), "CHF", new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(5136), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("9bc38d5a-2e2e-443a-bde7-f6c7802ce879"), "USD", new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(5126), 2, true, "US Dollar", "$", null },
                    { new Guid("a18af334-c2f1-41f4-9585-0760ab697da3"), "GBP", new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(5134), 2, true, "British Pound", "£", null },
                    { new Guid("bd01f44d-172d-4009-9bc6-a2fe99fd136c"), "EUR", new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(3736), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("05b13df8-4103-40da-8982-bda7d75808c1"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(2591), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("07240416-e746-4d10-b173-380ed60b7e64"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(2594), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("47601495-078d-4e1e-a390-1d534a327e7c"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(2580), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("caa5fe38-6bde-4c62-87fc-605be72587b0"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(1086), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d1cd387-9b2c-4b67-86e5-f7b9c8f144ee"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(5527), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("220229ff-788c-421c-89de-cc48d0933b38"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(7077), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("5a17ab27-3c91-4d54-ab1e-d94c9081ee9a"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(7100), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("78940904-a244-4520-b779-66cd550b814d"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(7088), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("badd4bf3-2836-49fd-a1fe-681d1bebb742"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(7097), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("e9111a6c-c999-4be2-ae25-34c783647730"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(7085), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("a4c93ce5-3c2f-4f6b-abfe-95bad0a81acc"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(8305), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4661b21f-bd06-403c-94f3-7ca3790d18bd"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(4208), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("9750955c-85b3-43cb-9724-58f2565954f6"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(2979), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("c6aa0f78-abb1-4826-bcb1-0210b39d8055"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(4205), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("cbb09250-91a5-4c39-aeea-6f7530f061e8"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(4202), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("f4f70352-a29d-47e2-97db-41740b60e464"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(4181), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("fb584561-3c11-4be6-a32c-b6a23282091c"), new DateTime(2025, 2, 14, 9, 46, 22, 322, DateTimeKind.Utc).AddTicks(4200), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("270fb739-8160-4147-93d5-9a36fad4f6c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("5f54087d-a422-4fe8-a69b-d5f2f84a253d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("80e2b3d4-c7de-4407-9848-17c36dd2ea0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("aad0aef6-e79a-41c6-be9b-09f0bdeffe9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("0f161059-2d44-424c-b054-f3a8327a1c5e"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(7892), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("889171cf-c7f3-48ea-8bdb-0600943d8dac"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(7895), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("b1949593-0a08-4d2c-9afe-d331f2386e71"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(7832), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("b20f42ee-72bf-406d-aa09-f6872b2410d1"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(7897), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("e4cc0ebf-524f-4d21-ad23-cb51a4aa87c9"), new DateTime(2025, 2, 14, 9, 46, 22, 323, DateTimeKind.Utc).AddTicks(6123), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2232a25d-7541-45cf-8fad-5beefe2eee23"), new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(6703), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("5c6bc460-4ae1-4107-a104-5adbf006696b"), new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(7039), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("e214eaba-4cb6-499c-9fc1-5ee8367b898f"), new DateTime(2025, 2, 14, 9, 46, 22, 324, DateTimeKind.Utc).AddTicks(7052), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 246, DateTimeKind.Utc).AddTicks(1929), new DateTime(1975, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 246, DateTimeKind.Utc).AddTicks(1924), "USER 1", "6zqbbE2gVil5hqPC2S4hAcBbl11KnOAv08MV6dVumiTKp5REl14ykpoXmXjef3hv", new DateTime(2025, 2, 14, 9, 46, 22, 246, DateTimeKind.Utc).AddTicks(1930), "user 1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 253, DateTimeKind.Utc).AddTicks(9715), new DateTime(1975, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 253, DateTimeKind.Utc).AddTicks(9712), "USER 2", "8gs97gpxpkqE5ku107WXayb1zg4vN7fs8fb9LPhVsLicpcat80HyP/vHTNS7ZW1g", new DateTime(2025, 2, 14, 9, 46, 22, 253, DateTimeKind.Utc).AddTicks(9717), "user 2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 261, DateTimeKind.Utc).AddTicks(7101), new DateTime(1975, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 261, DateTimeKind.Utc).AddTicks(7035), "USER 3", "VZ1v7aRqle5ZJiJhzWO7aBmobxmHxwSclDEwM0t4OI9q8yvZ7kAYzAoakiGuWlFH", new DateTime(2025, 2, 14, 9, 46, 22, 261, DateTimeKind.Utc).AddTicks(7103), "user 3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 269, DateTimeKind.Utc).AddTicks(2015), new DateTime(1975, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 269, DateTimeKind.Utc).AddTicks(2010), "USER 4", "wfPTiuwRYO9Pbct4fP1PF2TAJCKGzAATx9opZxl6u6mSsVbeOriGaCARMJsw6DKI", new DateTime(2025, 2, 14, 9, 46, 22, 269, DateTimeKind.Utc).AddTicks(2016), "user 4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 277, DateTimeKind.Utc).AddTicks(160), new DateTime(1975, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 277, DateTimeKind.Utc).AddTicks(156), "USER 5", "kTbjHYUzMozSqUtO/f8RDwihdXrFGawLw1zDTLMTp0a/qQYWVbTpUmM/adQF3T55", new DateTime(2025, 2, 14, 9, 46, 22, 277, DateTimeKind.Utc).AddTicks(162), "user 5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 283, DateTimeKind.Utc).AddTicks(8790), new DateTime(1975, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 283, DateTimeKind.Utc).AddTicks(8787), "USER 6", "Zl5DoRsn65+1o8+6EdNYB7+bnZqJow14Kmh9BFJqdbqwJQBJjTUhS+NXf4Vxe+Zb", new DateTime(2025, 2, 14, 9, 46, 22, 283, DateTimeKind.Utc).AddTicks(8791), "user 6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 291, DateTimeKind.Utc).AddTicks(3880), new DateTime(1975, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 291, DateTimeKind.Utc).AddTicks(3875), "USER 7", "e6JGf9/xAy4NTyghaySOarvxd+Qwy0+gJGPQTOpaSCFb+obRsQgxid9rSCrcDHex", new DateTime(2025, 2, 14, 9, 46, 22, 291, DateTimeKind.Utc).AddTicks(3881), "user 7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 298, DateTimeKind.Utc).AddTicks(4502), new DateTime(1975, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 298, DateTimeKind.Utc).AddTicks(4497), "USER 8", "GiBE3xIpd3HItNkgGKVpSsjfXTlmPLonPsmJdF7sYuo8+lm+2Dc0Mq6tujiuOona", new DateTime(2025, 2, 14, 9, 46, 22, 298, DateTimeKind.Utc).AddTicks(4503), "user 8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 308, DateTimeKind.Utc).AddTicks(3600), new DateTime(1975, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 308, DateTimeKind.Utc).AddTicks(3596), "USER 9", "45za+LEgDiwSBDXLuEDon0cXru9G27bu2b/vB0SEf+V9HKWiGEMFm6v486w6e4OY", new DateTime(2025, 2, 14, 9, 46, 22, 308, DateTimeKind.Utc).AddTicks(3602), "user 9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "CreatedAt", "DateOfBirth", "IsAdmin", "IsGuest", "IsStandardUser", "IsVerified", "LastLogin", "NormalizedUserName", "PasswordHash", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 321, DateTimeKind.Utc).AddTicks(9731), new DateTime(1975, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 321, DateTimeKind.Utc).AddTicks(9727), "USER 10", "7OesfCOUm4VOl0NjgRDzIP0FuTsoQ29NgRi8IpqZzD+sQI7EwVR/2oXbE4tTmrRQ", new DateTime(2025, 2, 14, 9, 46, 22, 321, DateTimeKind.Utc).AddTicks(9733), "user 10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "NormalizedUserName", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 212, DateTimeKind.Utc).AddTicks(3521), new DateTime(2025, 2, 14, 9, 46, 22, 212, DateTimeKind.Utc).AddTicks(903), "ALIRZA", new DateTime(2025, 2, 14, 9, 46, 22, 212, DateTimeKind.Utc).AddTicks(4417), "alireza" });
        }
    }
}
