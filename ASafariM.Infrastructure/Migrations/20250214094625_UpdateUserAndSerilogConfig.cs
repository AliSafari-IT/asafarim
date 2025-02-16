using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserAndSerilogConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ForgotPasswordToken",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ForgotPasswordTokenExpiration",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsGuest",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordResetToken",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

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
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "ForgotPasswordToken", "ForgotPasswordTokenExpiration", "IsGuest", "IsStandardUser", "IsSuperAdmin", "IsVerified", "LastLogin", "PasswordResetToken", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 46, 22, 212, DateTimeKind.Utc).AddTicks(3521), null, null, false, true, true, true, new DateTime(2025, 2, 14, 9, 46, 22, 212, DateTimeKind.Utc).AddTicks(903), null, new DateTime(2025, 2, 14, 9, 46, 22, 212, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "ForgotPasswordToken", "ForgotPasswordTokenExpiration", "IsActive", "IsAdmin", "IsBannedByAdmin", "IsBlocked", "IsDeleted", "IsEditor", "IsGuest", "IsLockedOut", "IsModerator", "IsPending", "IsStandardUser", "IsSuperAdmin", "IsVerified", "LastLogin", "LastName", "LinkUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetToken", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "Website" },
                values: new object[,]
                {
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"), 0, null, "user 1@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 246, DateTimeKind.Utc).AddTicks(1929), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 1@example.com", false, 0, "User 1", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 246, DateTimeKind.Utc).AddTicks(1924), "Example", null, false, null, null, "USER 1@EXAMPLE.COM", "USER 1", "6zqbbE2gVil5hqPC2S4hAcBbl11KnOAv08MV6dVumiTKp5REl14ykpoXmXjef3hv", null, null, "+123456781", true, null, "https://asafarim.com/logoT.svg", "user 1@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 246, DateTimeKind.Utc).AddTicks(1930), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 1", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"), 0, null, "user 2@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 253, DateTimeKind.Utc).AddTicks(9715), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 2@example.com", false, 0, "User 2", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 253, DateTimeKind.Utc).AddTicks(9712), "Example", null, false, null, null, "USER 2@EXAMPLE.COM", "USER 2", "8gs97gpxpkqE5ku107WXayb1zg4vN7fs8fb9LPhVsLicpcat80HyP/vHTNS7ZW1g", null, null, "+123456782", true, null, "https://asafarim.com/logoT.svg", "user 2@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 253, DateTimeKind.Utc).AddTicks(9717), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 2", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"), 0, null, "user 3@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 261, DateTimeKind.Utc).AddTicks(7101), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 3@example.com", false, 0, "User 3", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 261, DateTimeKind.Utc).AddTicks(7035), "Example", null, false, null, null, "USER 3@EXAMPLE.COM", "USER 3", "VZ1v7aRqle5ZJiJhzWO7aBmobxmHxwSclDEwM0t4OI9q8yvZ7kAYzAoakiGuWlFH", null, null, "+123456783", true, null, "https://asafarim.com/logoT.svg", "user 3@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 261, DateTimeKind.Utc).AddTicks(7103), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 3", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"), 0, null, "user 4@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 269, DateTimeKind.Utc).AddTicks(2015), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 4@example.com", false, 0, "User 4", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 269, DateTimeKind.Utc).AddTicks(2010), "Example", null, false, null, null, "USER 4@EXAMPLE.COM", "USER 4", "wfPTiuwRYO9Pbct4fP1PF2TAJCKGzAATx9opZxl6u6mSsVbeOriGaCARMJsw6DKI", null, null, "+123456784", true, null, "https://asafarim.com/logoT.svg", "user 4@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 269, DateTimeKind.Utc).AddTicks(2016), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 4", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"), 0, null, "user 5@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 277, DateTimeKind.Utc).AddTicks(160), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 5@example.com", false, 0, "User 5", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 277, DateTimeKind.Utc).AddTicks(156), "Example", null, false, null, null, "USER 5@EXAMPLE.COM", "USER 5", "kTbjHYUzMozSqUtO/f8RDwihdXrFGawLw1zDTLMTp0a/qQYWVbTpUmM/adQF3T55", null, null, "+123456785", true, null, "https://asafarim.com/logoT.svg", "user 5@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 277, DateTimeKind.Utc).AddTicks(162), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 5", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fba"), 0, null, "user 6@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 283, DateTimeKind.Utc).AddTicks(8790), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 6@example.com", false, 0, "User 6", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 283, DateTimeKind.Utc).AddTicks(8787), "Example", null, false, null, null, "USER 6@EXAMPLE.COM", "USER 6", "Zl5DoRsn65+1o8+6EdNYB7+bnZqJow14Kmh9BFJqdbqwJQBJjTUhS+NXf4Vxe+Zb", null, null, "+123456786", true, null, "https://asafarim.com/logoT.svg", "user 6@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 283, DateTimeKind.Utc).AddTicks(8791), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 6", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"), 0, null, "user 7@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 291, DateTimeKind.Utc).AddTicks(3880), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 7@example.com", false, 0, "User 7", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 291, DateTimeKind.Utc).AddTicks(3875), "Example", null, false, null, null, "USER 7@EXAMPLE.COM", "USER 7", "e6JGf9/xAy4NTyghaySOarvxd+Qwy0+gJGPQTOpaSCFb+obRsQgxid9rSCrcDHex", null, null, "+123456787", true, null, "https://asafarim.com/logoT.svg", "user 7@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 291, DateTimeKind.Utc).AddTicks(3881), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 7", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"), 0, null, "user 8@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 298, DateTimeKind.Utc).AddTicks(4502), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 8@example.com", false, 0, "User 8", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 298, DateTimeKind.Utc).AddTicks(4497), "Example", null, false, null, null, "USER 8@EXAMPLE.COM", "USER 8", "GiBE3xIpd3HItNkgGKVpSsjfXTlmPLonPsmJdF7sYuo8+lm+2Dc0Mq6tujiuOona", null, null, "+123456788", true, null, "https://asafarim.com/logoT.svg", "user 8@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 298, DateTimeKind.Utc).AddTicks(4503), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 8", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"), 0, null, "user 9@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 308, DateTimeKind.Utc).AddTicks(3600), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 9@example.com", false, 0, "User 9", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 308, DateTimeKind.Utc).AddTicks(3596), "Example", null, false, null, null, "USER 9@EXAMPLE.COM", "USER 9", "45za+LEgDiwSBDXLuEDon0cXru9G27bu2b/vB0SEf+V9HKWiGEMFm6v486w6e4OY", null, null, "+123456789", true, null, "https://asafarim.com/logoT.svg", "user 9@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 308, DateTimeKind.Utc).AddTicks(3602), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 9", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"), 0, null, "user 10@example.com", new DateTime(2025, 2, 14, 9, 46, 22, 321, DateTimeKind.Utc).AddTicks(9731), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user 10@example.com", false, 0, "User 10", null, null, true, true, false, false, false, false, true, false, false, false, false, false, false, new DateTime(2025, 2, 14, 9, 46, 22, 321, DateTimeKind.Utc).AddTicks(9727), "Example", null, false, null, null, "USER 10@EXAMPLE.COM", "USER 10", "7OesfCOUm4VOl0NjgRDzIP0FuTsoQ29NgRi8IpqZzD+sQI7EwVR/2oXbE4tTmrRQ", null, null, "+1234567810", true, null, "https://asafarim.com/logoT.svg", "user 10@example.com", false, new DateTime(2025, 2, 14, 9, 46, 22, 321, DateTimeKind.Utc).AddTicks(9733), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user 10", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ForgotPasswordToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ForgotPasswordTokenExpiration",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsGuest",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                table: "Users");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "IsStandardUser", "IsSuperAdmin", "IsVerified", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 59, 48, 974, DateTimeKind.Utc).AddTicks(3637), false, false, false, new DateTime(2025, 2, 10, 18, 59, 48, 974, DateTimeKind.Utc).AddTicks(619), new DateTime(2025, 2, 10, 18, 59, 48, 974, DateTimeKind.Utc).AddTicks(4587) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsBannedByAdmin", "IsBlocked", "IsDeleted", "IsEditor", "IsLockedOut", "IsModerator", "IsPending", "IsStandardUser", "IsSuperAdmin", "IsVerified", "LastLogin", "LastName", "LinkUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "Website" },
                values: new object[] { new Guid("553d6b66-5b55-4ed0-85a8-6ac98941879e"), 0, null, "user@example.com", new DateTime(2025, 2, 10, 18, 59, 48, 996, DateTimeKind.Utc).AddTicks(1195), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user@example.com", false, 0, "User", true, true, false, false, false, false, false, false, false, false, false, false, new DateTime(2025, 2, 10, 18, 59, 48, 996, DateTimeKind.Utc).AddTicks(1179), "Example", null, false, null, null, "USER@EXAMPLE.COM", "EXAMPLE_USER", "oW2X3P0AysSuqjhwAUrglBUeqPg/gTJewLJGS1uGikpGeLmlbEE6UCs7ROlPadcY", null, "+123456789", true, null, "https://asafarim.com/logoT.svg", "user@example.com", false, new DateTime(2025, 2, 10, 18, 59, 48, 996, DateTimeKind.Utc).AddTicks(1196), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "example_user", null });
        }
    }
}
