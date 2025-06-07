using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLinksToProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20a5541a-42ce-4d2b-a176-f2fa9c15a3b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3bb35296-398c-4c58-a06f-4d9cf19585ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42c4fe8d-b538-4a16-ada3-7baf0378ea5a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7cd4c509-4a5c-4323-a6f6-7dc4422dd3dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b88a31b-ec13-4ed3-9ea0-528f92bde9d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c1425a6-613b-4852-97d6-78e565eaf0a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da1aeb3a-db45-4167-b911-77d4577e2cf0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6340207-ee6f-4c63-b32b-ca3f2988b75a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1620483-7434-493a-971a-38792318494e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4d8f64a-d07d-4322-8496-2598ab7a0178"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("255cb300-3095-4753-89ae-b633dcb1aba8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a2bd7e0f-f0b8-4ac8-b1e0-2c02159f6c23"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d0eef624-5bac-4c55-9d79-10a6dbb5be05"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fb9940c6-634c-4ad2-8f40-34e707418447"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("6d0e0689-22fd-4bb4-a45b-11f29201cec9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("b93e2793-b767-4259-8df9-2d6e2f0a7f1b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("c050479c-5497-4011-a423-105241723488"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ffde1662-3e80-44a1-aec4-ba05be9b483b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("1762b40e-5aae-4fab-b1f0-a6b891f7c217"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("25f9006f-b20c-4239-b3d7-ae1ceeaf903a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3886d9ca-0599-417a-ab93-cb4e5aacc5e2"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6c208b50-3ab1-48f6-bd28-5852dee53592"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9abfc01b-d85d-421d-b54b-6baa3b16f4e4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b52c12af-f127-4e6b-bda1-7cc68bc236d1"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("f1ba79f8-0bdd-4c2c-a7d3-dab0056d1599"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("251b4f47-9641-4dfe-b8d8-257e6a9792c1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("36611b4c-caab-404a-bc97-1d6f43d945af"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("48a0c44e-985d-47a9-bee7-341243055ca7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("798e48f9-e5f8-4b36-a8ee-679f5d512033"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("91b142c8-88a8-4160-9e21-fd9e84f894f9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cfe0e731-3b74-4d48-9b8e-1e8c31926a78"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3f5d6005-de7e-4ffd-b155-9073cd626e54"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5996c08e-9258-4f88-a760-0624b00f83ad"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bf9a0a7b-02b1-442a-9715-9c8ba514f84f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e86241a8-6932-417f-b6a0-53680e0415b3"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3d7f2a89-20f3-4c13-8160-87e5974279b1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("869c53cd-9d21-4c08-8e89-739255e29421"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9ee65c27-62ee-4ef9-a289-0c9e2252f4db"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("a4c6d063-4f3c-4738-a123-32a0b6040c9f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c4549858-3392-4209-8a06-59cf1e2b54f1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6b80f51f-9729-4ef6-9ebc-c102c9bc47b0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("abeddc32-5c14-4d63-a91b-66fa6301ac63"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("aee6ccf1-7d98-4119-a8fb-085bfaf0e77a"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2e4284ad-fd8f-474d-82d3-36d1106cc6c6"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("812ecb92-00a2-439d-861f-4a2117a8d0c0"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("876f1a18-f0d1-445d-84e7-796781d08f65"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("8a55344c-764c-4da1-89ca-1e56cfef6940"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("9036e690-fd4d-4514-a5a6-42b2b46752e5"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("bf238aae-b8d6-4dba-88fe-9a2cff67625c"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("c407cb0f-fe97-4db1-ae0f-fd03682b4df2"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("cbe44ef0-0f18-419a-b8c1-80a28ff682c9"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("e94bf298-2d7b-4fe5-91db-11131cf5b80f"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("fccb8fb2-b631-4bb5-bc81-72a1c458a281"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03582c76-c17f-4677-8cad-8e13ced151c6"), "GBP", new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(2799), 2, true, "British Pound", "£", null },
                    { new Guid("5579bd39-36da-4f11-aeb8-276042c6bdff"), "EUR", new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(1710), 2, true, "Euro", "€", null },
                    { new Guid("8d19da2c-4e75-4a7a-a31e-35bf4cfc6568"), "CHF", new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(2801), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("d8559a39-4758-4fc6-bdf8-a66d3f370854"), "USD", new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(2792), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("7d14bbb1-9010-4d82-bdaa-e3fade0cbfe7"), new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(879), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("a3e23bb1-62c1-4cd7-a4c7-c264d1fe872f"), new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(883), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("a5125878-d061-413a-a9be-1d3a16ae533a"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(9702), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("d31b4d7a-b669-4d11-b78b-5124e08505d3"), new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(886), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("12296854-d3bc-42b6-bab1-b7ab202cf84c"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(6463), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("1b6483eb-19a8-46a0-ad0b-9c1341dde43f"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(6467), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("72f1c6a3-926c-4eda-844d-eb28ed65854f"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(6481), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("ae28a89d-2458-4dda-a55f-1245084f988c"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(6475), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("d016aece-23eb-4c15-bea7-ef92220c4c0a"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(5104), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("f473a42b-3386-47f9-9b8e-db6bea11ece2"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(6478), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("65450286-780c-40c0-81d3-674a9ccf7370"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(7509), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("09ea8bb8-022c-4e80-bc26-006a88e7b108"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(3909), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("273b4568-c74b-4c69-b62e-5dcabb221e76"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(3899), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("4becdcb1-2286-4d85-9c85-d8742fbbfcaf"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(3901), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("d08e1f16-81b7-42fa-9c0d-622c2b63e609"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(3896), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("f83f2142-a10f-438a-80f5-9a68fa3af50f"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(3893), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("fa3f2f06-84a2-4866-a651-677f72b6e6d3"), new DateTime(2025, 3, 12, 15, 51, 25, 104, DateTimeKind.Utc).AddTicks(2903), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0eb354ec-841f-4f6d-9b7e-b9c96b10b9a9"), null, new DateTime(2025, 3, 12, 15, 51, 25, 106, DateTimeKind.Utc).AddTicks(213), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("12b67a2e-1e53-42c8-99b1-aa81f5f5376e"), null, new DateTime(2025, 3, 12, 15, 51, 25, 106, DateTimeKind.Utc).AddTicks(1117), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("2b9dff5a-d52f-4d7d-b442-b76221f8b817"), null, new DateTime(2025, 3, 12, 15, 51, 25, 106, DateTimeKind.Utc).AddTicks(1104), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("db506e60-2244-4d6c-bbe7-b034bff911b8"), null, new DateTime(2025, 3, 12, 15, 51, 25, 106, DateTimeKind.Utc).AddTicks(1109), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("18e20b61-46e7-46d8-a629-fa7027dda505"), new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(5087), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("99b938ee-4268-4284-a4f2-8298530041d0"), new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(3779), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("acd98492-f72b-4af3-b371-a4951c1e803c"), new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(5089), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("dd81e0a3-d9fb-400f-9d05-c2d63f8d744e"), new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(5085), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("f99c1a4b-acae-4392-a098-4f3689d8bdd3"), new DateTime(2025, 3, 12, 15, 51, 25, 105, DateTimeKind.Utc).AddTicks(5078), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 15, 51, 25, 106, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2a3fdd71-0622-416c-b840-543f90b96fcf"), new DateTime(2025, 3, 12, 15, 51, 25, 106, DateTimeKind.Utc).AddTicks(4803), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("7f18202f-5d23-4451-bf07-65aac3666413"), new DateTime(2025, 3, 12, 15, 51, 25, 106, DateTimeKind.Utc).AddTicks(4788), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("fcf72864-59b9-4a78-b178-fc146967abcd"), new DateTime(2025, 3, 12, 15, 51, 25, 106, DateTimeKind.Utc).AddTicks(4794), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "aow34bPV2hO5yqZugQuO9+Yam8r4tgoCLHRdNkk9fNBTKsaXkb2+3drd8YrStLsE");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "vBN2kz74uxUaazvh0HeauTN9WS3dXSD9mrcpYB4Leb/NnCSLmPvpFofkeDdnC3qp");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_e7a9@example.com", "user_1_e7a9@example.com", "USER_1_E7A9@EXAMPLE.COM", "USER_1_E7A9", "XlRTeN5Sxfqxd9AQvzadhXwDmDoCFwabgtAEmJa/m/rUZwlZMIeX1pBQNV6S8agh", "user_1_e7a9@example.com", "user_1_e7a9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_b00f@example.com", "user_2_b00f@example.com", "USER_2_B00F@EXAMPLE.COM", "USER_2_B00F", "5mhl1aZZpn13qM979PiuAxcbEJONvgMQTe2GdXY0BxCKJgCnA5u17C8QFtRkKanI", "user_2_b00f@example.com", "user_2_b00f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_7db3@example.com", "user_3_7db3@example.com", "USER_3_7DB3@EXAMPLE.COM", "USER_3_7DB3", "kMXGI7FeF7UteiDxIUu8yTahRna2F17Pzq2DFrUjjVkipQDXAIADnYEGS9GV26wE", "user_3_7db3@example.com", "user_3_7db3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_9060@example.com", "user_4_9060@example.com", "USER_4_9060@EXAMPLE.COM", "USER_4_9060", "S/ekc8qcwyY+UtrTctlpgc6GeEmU9wXVK8X50qmB6F7bSC8CmU5liN3rkUKWVpcZ", "user_4_9060@example.com", "user_4_9060" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_1c9b@example.com", "user_5_1c9b@example.com", "USER_5_1C9B@EXAMPLE.COM", "USER_5_1C9B", "+oEkEYyQXQqQhdoN4MnjSfYYcY8kqo1r52daDVsUWwQmoVhUJC3Y6/MKVwvu7hXs", "user_5_1c9b@example.com", "user_5_1c9b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_28d7@example.com", "user_6_28d7@example.com", "USER_6_28D7@EXAMPLE.COM", "USER_6_28D7", "KKJa3+gE9PIfD7w+xfhDLcPLF1RgSeZrzdzssTTaeOVGa5JbNbAp2AyJinRYWokL", "user_6_28d7@example.com", "user_6_28d7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_8189@example.com", "user_7_8189@example.com", "USER_7_8189@EXAMPLE.COM", "USER_7_8189", "BHh37CWEW1yty0gR39Rta5djQQ5/jc3Tp5TgDIPy2LoaCp8YMmcEA1AscLbUv6J4", "user_7_8189@example.com", "user_7_8189" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_cb7e@example.com", "user_8_cb7e@example.com", "USER_8_CB7E@EXAMPLE.COM", "USER_8_CB7E", "yCXoFLGmYpV9sTvcrqDJH1AhkuS9nlRnGVeteio1WHo7k2sCW/KV8CG1SIpfgR7h", "user_8_cb7e@example.com", "user_8_cb7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_e557@example.com", "user_9_e557@example.com", "USER_9_E557@EXAMPLE.COM", "USER_9_E557", "BpgAR99X7lLyVFukXJqvUYhxIn+1E2yKRpIzctLHnPz/WCNKdobrzCd+FMKUNCvM", "user_9_e557@example.com", "user_9_e557" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_4bd7@example.com", "user_10_4bd7@example.com", "USER_10_4BD7@EXAMPLE.COM", "USER_10_4BD7", "ZYcC9IAPfmHmr0cihaCFSkagKIqm2Z8VowftPIi8Og/ZpBpVCHXKhH3wwHBydnHj", "user_10_4bd7@example.com", "user_10_4bd7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_89f3@example.com", "user_11_89f3@example.com", "USER_11_89F3@EXAMPLE.COM", "USER_11_89F3", "JqEFD2BcChYy/BvKBvNMno3CeQDxj8/kM++PLuH0t1tV11rfyHJZD0gzJYEXRpf3", "user_11_89f3@example.com", "user_11_89f3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_7572@example.com", "user_12_7572@example.com", "USER_12_7572@EXAMPLE.COM", "USER_12_7572", "4ZgPNYAp7duPrSJleGxGeFyRRyzcu51gm8o5eoFp8htZ6B3R/d8T0EBsK8aZjF9p", "user_12_7572@example.com", "user_12_7572" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_6e95@example.com", "user_13_6e95@example.com", "USER_13_6E95@EXAMPLE.COM", "USER_13_6E95", "GTAELcXtzQvOG/84NDPkQTUc8vmm8yye2O40Nld/w6z0zrlVYiyQ7/4xJvdMHO3r", "user_13_6e95@example.com", "user_13_6e95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_2fb2@example.com", "user_14_2fb2@example.com", "USER_14_2FB2@EXAMPLE.COM", "USER_14_2FB2", "lqrPi7PbRTXaADiON0I5XFsfZAX5rlR++up4QTGnlgSvSMecgEW9YdiRqUJIAMPS", "user_14_2fb2@example.com", "user_14_2fb2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_00e7@example.com", "user_15_00e7@example.com", "USER_15_00E7@EXAMPLE.COM", "USER_15_00E7", "qpqI7jHaQCJZ8awvaYELmoVbNgYDna+N2jVJLIU5HTAkC7ZlPFFzxuAIfplE2Gc1", "user_15_00e7@example.com", "user_15_00e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_d88e@example.com", "user_16_d88e@example.com", "USER_16_D88E@EXAMPLE.COM", "USER_16_D88E", "Znq/wdM29LHqYVyhfdC9vHzyfs6TskU4beTtJyYX6hHUJvbpEm5eaev71CX+CkRn", "user_16_d88e@example.com", "user_16_d88e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_5199@example.com", "user_17_5199@example.com", "USER_17_5199@EXAMPLE.COM", "USER_17_5199", "JuML9xuj5lCcLonfQeQNPggh8rDNqIGt1EBEti+CfthoaGzOOGuoB3ny6BRCge4o", "user_17_5199@example.com", "user_17_5199" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_8972@example.com", "user_18_8972@example.com", "USER_18_8972@EXAMPLE.COM", "USER_18_8972", "NlSmkKONK110HPGiuO5T/PVaKRVzqMZaEggjiVNE514ZVfVhUTVXZVGKAy952QS7", "user_18_8972@example.com", "user_18_8972" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_08fe@example.com", "user_19_08fe@example.com", "USER_19_08FE@EXAMPLE.COM", "USER_19_08FE", "MeMLyJRaOWYvH13D0NrZRK2XW2YsotoLZyvkcyXkQ7n90XOc/Zas6xsK9DPkvrR0", "user_19_08fe@example.com", "user_19_08fe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_f613@example.com", "user_20_f613@example.com", "USER_20_F613@EXAMPLE.COM", "USER_20_F613", "3SuKFywLFb6160iZYY6hwxoNkEI67w88C2z8aR3xr2Jz0mrEWnZ6yo/6rbHi5Gpb", "user_20_f613@example.com", "user_20_f613" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_c8af@example.com", "user_21_c8af@example.com", "USER_21_C8AF@EXAMPLE.COM", "USER_21_C8AF", "9t67Jrfldwkg6wTgfgirqfKroatoWSnrHVZC8ON2MjDuBlVZr5IN48ErmgnqTU7Z", "user_21_c8af@example.com", "user_21_c8af" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_6e6e@example.com", "user_22_6e6e@example.com", "USER_22_6E6E@EXAMPLE.COM", "USER_22_6E6E", "5Okk1RKFVS/meTIdBLY/vgvme6EHEK1I5RZVak9/p/tbrKksASKuXE8hwkx0WtAi", "user_22_6e6e@example.com", "user_22_6e6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_20c0@example.com", "user_23_20c0@example.com", "USER_23_20C0@EXAMPLE.COM", "USER_23_20C0", "mgtPxb0QXzH5iMwjwfnxk+FspYdExqHj82SDJ3znbdq0VyUt7rkC/FMrumG3GGH+", "user_23_20c0@example.com", "user_23_20c0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_6de2@example.com", "user_24_6de2@example.com", "USER_24_6DE2@EXAMPLE.COM", "USER_24_6DE2", "CetrPFmyYzvUtrm336zCxZ6KhSNVjGIakWG7178tCH4CVVN1AO6WYxdB2NbitpzF", "user_24_6de2@example.com", "user_24_6de2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_5956@example.com", "user_25_5956@example.com", "USER_25_5956@EXAMPLE.COM", "USER_25_5956", "kX42YO3B/xCmdf/tY2DHY2snhJlZEliXi3cvGDJmme2tPDBcyfeflNR0HUgssh7M", "user_25_5956@example.com", "user_25_5956" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_72ab@example.com", "user_26_72ab@example.com", "USER_26_72AB@EXAMPLE.COM", "USER_26_72AB", "yl3ULkZUu8+GANAhCPaVsZeN5rKURDmH5Q8LkyCWBRgbwqFGQgkjMjwrmbePZtzR", "user_26_72ab@example.com", "user_26_72ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_e25d@example.com", "user_27_e25d@example.com", "USER_27_E25D@EXAMPLE.COM", "USER_27_E25D", "wXNKZTv6XQtvV+F8OtWyoTpGFkmxQL2hqXwoGIxPhE1ptEmvTuXI60bKu8vjiQx9", "user_27_e25d@example.com", "user_27_e25d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_b059@example.com", "user_28_b059@example.com", "USER_28_B059@EXAMPLE.COM", "USER_28_B059", "7l/PyTe8BXjveOqEgnGkpwbwbyLxGX3/vw2+hKm/Ih4auozvSmzGEMjXCrMh4D/W", "user_28_b059@example.com", "user_28_b059" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_4d5b@example.com", "user_29_4d5b@example.com", "USER_29_4D5B@EXAMPLE.COM", "USER_29_4D5B", "NJrDalQJA3G3m664HKOWTKfYhKDCHlS/GzratfdTZfaOZj1xTIZoT/BrjuJ5tT84", "user_29_4d5b@example.com", "user_29_4d5b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_be64@example.com", "user_30_be64@example.com", "USER_30_BE64@EXAMPLE.COM", "USER_30_BE64", "gtc5An73yO7+B5xTCegWIeYkbTJ1q7NYRWia8C+dJWg2ct3QhhX5vv6GIElewZLJ", "user_30_be64@example.com", "user_30_be64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_ef4e@example.com", "user_31_ef4e@example.com", "USER_31_EF4E@EXAMPLE.COM", "USER_31_EF4E", "R0unK7GFK1qIhuNlkIGQIT0gudJv6NpgZsR0Eg/dYK53nZ35DPRl2suSC0D991fD", "user_31_ef4e@example.com", "user_31_ef4e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_1e32@example.com", "user_32_1e32@example.com", "USER_32_1E32@EXAMPLE.COM", "USER_32_1E32", "cKU6XG9vBTm1qI9Giyqsf9gsLiHoH3i1Z3U4NvgihBK5wvy/cHvUItDzr/Ro421H", "user_32_1e32@example.com", "user_32_1e32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_f003@example.com", "user_33_f003@example.com", "USER_33_F003@EXAMPLE.COM", "USER_33_F003", "5DQAJ2N+cGulGKWLZyme20oWEO0vL5no/gS5VF5umYMUzgn/f6HsWV9lyyqW9DdY", "user_33_f003@example.com", "user_33_f003" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_b5c6@example.com", "user_34_b5c6@example.com", "USER_34_B5C6@EXAMPLE.COM", "USER_34_B5C6", "UCwSBL0bjZn+g/XRHdH52b9clToofX6BbnGfNLDgHgYzQIl4hu6c8LFU1hKbaEeE", "user_34_b5c6@example.com", "user_34_b5c6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_6834@example.com", "user_35_6834@example.com", "USER_35_6834@EXAMPLE.COM", "USER_35_6834", "P8E4/w8b/TiVZluyouAYV4JR/2++rFuSSkI5lUjeXxKdk+I4dWU7Ey8mI3nNv7/q", "user_35_6834@example.com", "user_35_6834" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_a4fb@example.com", "user_36_a4fb@example.com", "USER_36_A4FB@EXAMPLE.COM", "USER_36_A4FB", "t5S08pbwQTlCg4tlbuFN2t7GWYia/iLkvNvkCrDMd62JriCU2OaPUVRp4+1i/PAQ", "user_36_a4fb@example.com", "user_36_a4fb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_1166@example.com", "user_37_1166@example.com", "USER_37_1166@EXAMPLE.COM", "USER_37_1166", "+wWTesxIzr/8SRc0G8RJNUEPTNjzbGMh2W9gg0kM4AtltWMJr5quhvsjLnSEYSSt", "user_37_1166@example.com", "user_37_1166" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_31c8@example.com", "user_38_31c8@example.com", "USER_38_31C8@EXAMPLE.COM", "USER_38_31C8", "TyaY7ROuVd/ggPX7BrgCGS4nVWK5U6eof3I3LiMBXbTDou3wpwbsTa55MlzPQLRM", "user_38_31c8@example.com", "user_38_31c8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_f489@example.com", "user_39_f489@example.com", "USER_39_F489@EXAMPLE.COM", "USER_39_F489", "SEfxT/KDYunf/0g4FQeeVjKx8zZMAyqtkYc3W2KIRLjrRM7zmMElBrbG0IhgBZjY", "user_39_f489@example.com", "user_39_f489" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_4658@example.com", "user_40_4658@example.com", "USER_40_4658@EXAMPLE.COM", "USER_40_4658", "LkZm9hsy65RjTcKNQgTCusspCQDLQ5Rz3TsMX2iD2xUyZKJkSs/+vI/1BaH9SnJs", "user_40_4658@example.com", "user_40_4658" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_c2a7@example.com", "user_41_c2a7@example.com", "USER_41_C2A7@EXAMPLE.COM", "USER_41_C2A7", "fGL2zbxAL8UDATUe9FNOmznVkS6NyxUj9gTeIlrQZisxh2fNySIxjT+i7ddSvrq/", "user_41_c2a7@example.com", "user_41_c2a7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_38d5@example.com", "user_42_38d5@example.com", "USER_42_38D5@EXAMPLE.COM", "USER_42_38D5", "JH0R5y95ch/sCOqdY9s+KOJOY+TLLCNYorx358Hrs8dWygSo+pwXAcNjDpeJ53Xl", "user_42_38d5@example.com", "user_42_38d5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_73b0@example.com", "user_43_73b0@example.com", "USER_43_73B0@EXAMPLE.COM", "USER_43_73B0", "TdzvPS7r++s/u4R5wNkREstr1zKgdbUk3swbDofjnOxRF97wFlDVw8JkZEqCKJCw", "user_43_73b0@example.com", "user_43_73b0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_b6bc@example.com", "user_44_b6bc@example.com", "USER_44_B6BC@EXAMPLE.COM", "USER_44_B6BC", "sg2felbOLFVtcFCMHE8yhffGDwf+iAnWNbnzNtVf/Wq2FH665NRCNZziZ9ZClio3", "user_44_b6bc@example.com", "user_44_b6bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_2bad@example.com", "user_45_2bad@example.com", "USER_45_2BAD@EXAMPLE.COM", "USER_45_2BAD", "NgbWYYg/ljpSifPINjd57ms/DF33//nCepCOAeQXFUE3rMtdkGsKGUa88sUW24bt", "user_45_2bad@example.com", "user_45_2bad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_3a13@example.com", "user_46_3a13@example.com", "USER_46_3A13@EXAMPLE.COM", "USER_46_3A13", "Dg/I/ORZP4/KaRRxxyiAqrHrXVjJjROyjgyFQ2jHAvnBD7iWft5YNX5kNpxBvlZO", "user_46_3a13@example.com", "user_46_3a13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_340b@example.com", "user_47_340b@example.com", "USER_47_340B@EXAMPLE.COM", "USER_47_340B", "RdEaM5gYuT4ATC/DB53Bdo+zUP93E4Usx7jfKuVGBYMWKEeVg5pN+WJy/6cZoELq", "user_47_340b@example.com", "user_47_340b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_c9e3@example.com", "user_48_c9e3@example.com", "USER_48_C9E3@EXAMPLE.COM", "USER_48_C9E3", "Od1mVNqcTpyo0OSsFhEOKb1wnl8FumxRMNBsDyx2NJ6nvLLJDWFMZX54UksHNomE", "user_48_c9e3@example.com", "user_48_c9e3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_63f6@example.com", "user_49_63f6@example.com", "USER_49_63F6@EXAMPLE.COM", "USER_49_63F6", "gzla2UHakPCRh+NqKFxeraxXKU68TKXpP5mBGEk8l+FHOZdx7gj/9hCGnk5gtQB9", "user_49_63f6@example.com", "user_49_63f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_0255@example.com", "user_50_0255@example.com", "USER_50_0255@EXAMPLE.COM", "USER_50_0255", "RZQWGFv5UTVZMaTDrEB1dFohWWGlZxXIWkCz+ief4RPm3rfdnzt3sBR8/S0COfqt", "user_50_0255@example.com", "user_50_0255" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "g9O3BSapPQCi98t9GNLndjMa8NVIomfhEtBOTVlUc2JumdnDuAZnNJQZ03LQqMxf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e4284ad-fd8f-474d-82d3-36d1106cc6c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("812ecb92-00a2-439d-861f-4a2117a8d0c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("876f1a18-f0d1-445d-84e7-796781d08f65"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a55344c-764c-4da1-89ca-1e56cfef6940"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9036e690-fd4d-4514-a5a6-42b2b46752e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf238aae-b8d6-4dba-88fe-9a2cff67625c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c407cb0f-fe97-4db1-ae0f-fd03682b4df2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cbe44ef0-0f18-419a-b8c1-80a28ff682c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e94bf298-2d7b-4fe5-91db-11131cf5b80f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fccb8fb2-b631-4bb5-bc81-72a1c458a281"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("03582c76-c17f-4677-8cad-8e13ced151c6"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5579bd39-36da-4f11-aeb8-276042c6bdff"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8d19da2c-4e75-4a7a-a31e-35bf4cfc6568"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d8559a39-4758-4fc6-bdf8-a66d3f370854"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("7d14bbb1-9010-4d82-bdaa-e3fade0cbfe7"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("a3e23bb1-62c1-4cd7-a4c7-c264d1fe872f"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("a5125878-d061-413a-a9be-1d3a16ae533a"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d31b4d7a-b669-4d11-b78b-5124e08505d3"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("12296854-d3bc-42b6-bab1-b7ab202cf84c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("1b6483eb-19a8-46a0-ad0b-9c1341dde43f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("72f1c6a3-926c-4eda-844d-eb28ed65854f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ae28a89d-2458-4dda-a55f-1245084f988c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d016aece-23eb-4c15-bea7-ef92220c4c0a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f473a42b-3386-47f9-9b8e-db6bea11ece2"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("65450286-780c-40c0-81d3-674a9ccf7370"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09ea8bb8-022c-4e80-bc26-006a88e7b108"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("273b4568-c74b-4c69-b62e-5dcabb221e76"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4becdcb1-2286-4d85-9c85-d8742fbbfcaf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d08e1f16-81b7-42fa-9c0d-622c2b63e609"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f83f2142-a10f-438a-80f5-9a68fa3af50f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fa3f2f06-84a2-4866-a651-677f72b6e6d3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0eb354ec-841f-4f6d-9b7e-b9c96b10b9a9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("12b67a2e-1e53-42c8-99b1-aa81f5f5376e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2b9dff5a-d52f-4d7d-b442-b76221f8b817"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("db506e60-2244-4d6c-bbe7-b034bff911b8"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("18e20b61-46e7-46d8-a629-fa7027dda505"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("99b938ee-4268-4284-a4f2-8298530041d0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("acd98492-f72b-4af3-b371-a4951c1e803c"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("dd81e0a3-d9fb-400f-9d05-c2d63f8d744e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f99c1a4b-acae-4392-a098-4f3689d8bdd3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2a3fdd71-0622-416c-b840-543f90b96fcf"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7f18202f-5d23-4451-bf07-65aac3666413"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fcf72864-59b9-4a78-b178-fc146967abcd"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("20a5541a-42ce-4d2b-a176-f2fa9c15a3b4"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("3bb35296-398c-4c58-a06f-4d9cf19585ab"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("42c4fe8d-b538-4a16-ada3-7baf0378ea5a"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("7cd4c509-4a5c-4323-a6f6-7dc4422dd3dd"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("9b88a31b-ec13-4ed3-9ea0-528f92bde9d5"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("9c1425a6-613b-4852-97d6-78e565eaf0a1"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("da1aeb3a-db45-4167-b911-77d4577e2cf0"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("e6340207-ee6f-4c63-b32b-ca3f2988b75a"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("f1620483-7434-493a-971a-38792318494e"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("f4d8f64a-d07d-4322-8496-2598ab7a0178"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("255cb300-3095-4753-89ae-b633dcb1aba8"), "USD", new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(5890), 2, true, "US Dollar", "$", null },
                    { new Guid("a2bd7e0f-f0b8-4ac8-b1e0-2c02159f6c23"), "CHF", new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(5936), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("d0eef624-5bac-4c55-9d79-10a6dbb5be05"), "EUR", new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(2388), 2, true, "Euro", "€", null },
                    { new Guid("fb9940c6-634c-4ad2-8f40-34e707418447"), "GBP", new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(5931), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6d0e0689-22fd-4bb4-a45b-11f29201cec9"), new DateTime(2025, 3, 12, 15, 46, 45, 764, DateTimeKind.Utc).AddTicks(7786), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("b93e2793-b767-4259-8df9-2d6e2f0a7f1b"), new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(482), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("c050479c-5497-4011-a423-105241723488"), new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(512), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null },
                    { new Guid("ffde1662-3e80-44a1-aec4-ba05be9b483b"), new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(491), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1762b40e-5aae-4fab-b1f0-a6b891f7c217"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8746), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("25f9006f-b20c-4239-b3d7-ae1ceeaf903a"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8721), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("3886d9ca-0599-417a-ab93-cb4e5aacc5e2"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8752), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("6c208b50-3ab1-48f6-bd28-5852dee53592"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8730), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("9abfc01b-d85d-421d-b54b-6baa3b16f4e4"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8758), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("b52c12af-f127-4e6b-bda1-7cc68bc236d1"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(5094), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("f1ba79f8-0bdd-4c2c-a7d3-dab0056d1599"), new DateTime(2025, 3, 12, 15, 46, 45, 764, DateTimeKind.Utc).AddTicks(1682), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("251b4f47-9641-4dfe-b8d8-257e6a9792c1"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2838), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("36611b4c-caab-404a-bc97-1d6f43d945af"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2843), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("48a0c44e-985d-47a9-bee7-341243055ca7"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2831), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("798e48f9-e5f8-4b36-a8ee-679f5d512033"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(498), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("91b142c8-88a8-4160-9e21-fd9e84f894f9"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2822), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("cfe0e731-3b74-4d48-9b8e-1e8c31926a78"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2860), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3f5d6005-de7e-4ffd-b155-9073cd626e54"), null, new DateTime(2025, 3, 12, 15, 46, 45, 767, DateTimeKind.Utc).AddTicks(6436), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("5996c08e-9258-4f88-a760-0624b00f83ad"), null, new DateTime(2025, 3, 12, 15, 46, 45, 767, DateTimeKind.Utc).AddTicks(6421), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("bf9a0a7b-02b1-442a-9715-9c8ba514f84f"), null, new DateTime(2025, 3, 12, 15, 46, 45, 767, DateTimeKind.Utc).AddTicks(6447), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("e86241a8-6932-417f-b6a0-53680e0415b3"), null, new DateTime(2025, 3, 12, 15, 46, 45, 767, DateTimeKind.Utc).AddTicks(4493), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("3d7f2a89-20f3-4c13-8160-87e5974279b1"), new DateTime(2025, 3, 12, 15, 46, 45, 766, DateTimeKind.Utc).AddTicks(3142), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("869c53cd-9d21-4c08-8e89-739255e29421"), new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(9857), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("9ee65c27-62ee-4ef9-a289-0c9e2252f4db"), new DateTime(2025, 3, 12, 15, 46, 45, 766, DateTimeKind.Utc).AddTicks(3132), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("a4c6d063-4f3c-4738-a123-32a0b6040c9f"), new DateTime(2025, 3, 12, 15, 46, 45, 766, DateTimeKind.Utc).AddTicks(2986), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("c4549858-3392-4209-8a06-59cf1e2b54f1"), new DateTime(2025, 3, 12, 15, 46, 45, 766, DateTimeKind.Utc).AddTicks(3138), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 15, 46, 45, 768, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6b80f51f-9729-4ef6-9ebc-c102c9bc47b0"), new DateTime(2025, 3, 12, 15, 46, 45, 769, DateTimeKind.Utc).AddTicks(1047), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("abeddc32-5c14-4d63-a91b-66fa6301ac63"), new DateTime(2025, 3, 12, 15, 46, 45, 769, DateTimeKind.Utc).AddTicks(1062), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("aee6ccf1-7d98-4119-a8fb-085bfaf0e77a"), new DateTime(2025, 3, 12, 15, 46, 45, 769, DateTimeKind.Utc).AddTicks(1067), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "DUxdAzLnjT9LZmW8kS8jiMYir7ImlGCPJQREVGXEJy89otcvat301L1giXhJtm6+");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "MvvgqrYES0md/uEYG1KYA93rx9ZiP5iXTjMnTJEfvIxq4cjnXeBjj3PmWQepkFSQ");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_1440@example.com", "user_1_1440@example.com", "USER_1_1440@EXAMPLE.COM", "USER_1_1440", "R1Enq5C8NYkxK0m+KcWQlvo91gnFbTUNOavMme9UDoR9SBcUa3DVGSZ/Rj5Gghi/", "user_1_1440@example.com", "user_1_1440" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_6527@example.com", "user_2_6527@example.com", "USER_2_6527@EXAMPLE.COM", "USER_2_6527", "tifmQ2bcZb7I7zw2dasUInGlfnyPgL69v3vvfmaIkt9QpOvQu1thwG8HQrZfdkzE", "user_2_6527@example.com", "user_2_6527" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_0346@example.com", "user_3_0346@example.com", "USER_3_0346@EXAMPLE.COM", "USER_3_0346", "GNCZkTXIVYBwRFa3RCHy2bC154ANBtyGFQ+Efif+FInruRnNfnZZlZOTojslcHxe", "user_3_0346@example.com", "user_3_0346" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_a07f@example.com", "user_4_a07f@example.com", "USER_4_A07F@EXAMPLE.COM", "USER_4_A07F", "UJTMJsyHA+RrTxEEufiKQZ2P4xAGLcsyKffNIxtaf2EmEtBKtZizcFQeo2q04VrX", "user_4_a07f@example.com", "user_4_a07f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_3b75@example.com", "user_5_3b75@example.com", "USER_5_3B75@EXAMPLE.COM", "USER_5_3B75", "Oj1elzxkfRodv1Hxf9dX5Xu7heMaA1F0qYjTk3qqqO2qqS0tHIiLhg4RFVSEAccQ", "user_5_3b75@example.com", "user_5_3b75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_4532@example.com", "user_6_4532@example.com", "USER_6_4532@EXAMPLE.COM", "USER_6_4532", "8OQv10UxHbIeSykcoL3DbLgujYGgjwrIsxL3PmUfftY7TUwqIb56jnF796lNVr4E", "user_6_4532@example.com", "user_6_4532" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_ce26@example.com", "user_7_ce26@example.com", "USER_7_CE26@EXAMPLE.COM", "USER_7_CE26", "X22dZ7pGYH4qfUlOUKSmGSnseF2KkaQONwJw/Z4eW8ztKzuZZj28ThEvVU4s4IBM", "user_7_ce26@example.com", "user_7_ce26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_cf8d@example.com", "user_8_cf8d@example.com", "USER_8_CF8D@EXAMPLE.COM", "USER_8_CF8D", "XzZicNgRg/drx4pgANKjpGKzYgMegRnXrqpHrcCee185Z8CVy1N4vxPfDMYq8ObY", "user_8_cf8d@example.com", "user_8_cf8d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_4299@example.com", "user_9_4299@example.com", "USER_9_4299@EXAMPLE.COM", "USER_9_4299", "MgkGKLPEUQVJo1vKrXKyyZhZToevNrrKR8ccsOn+6VTDnOnkl9r8/I3k8F7nSSew", "user_9_4299@example.com", "user_9_4299" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_4277@example.com", "user_10_4277@example.com", "USER_10_4277@EXAMPLE.COM", "USER_10_4277", "FhfhceV+97itKgyMawsO4SW8eJaT9FFxgrjKTw5OMhwPLSzivopVjjZdj2BSEaw1", "user_10_4277@example.com", "user_10_4277" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_fd98@example.com", "user_11_fd98@example.com", "USER_11_FD98@EXAMPLE.COM", "USER_11_FD98", "xIQFsJOhpXxuPr3J/aJ6CPsjg6y6xd1uR+r7SY8D8ZiQ0aXwNfswW+qZm6ameghI", "user_11_fd98@example.com", "user_11_fd98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_b3c9@example.com", "user_12_b3c9@example.com", "USER_12_B3C9@EXAMPLE.COM", "USER_12_B3C9", "KNRm/I3arTbUCyminuVeZdvxR+oehecVegcRKy8kcWmRVg2sfSeZ2QseF/q1IK7a", "user_12_b3c9@example.com", "user_12_b3c9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_5955@example.com", "user_13_5955@example.com", "USER_13_5955@EXAMPLE.COM", "USER_13_5955", "Y2m2+lrRzAT/fA2IRbqzTyJD37ZTvY4BGALr0HKkYe6f25FIlKPfzPT48v04jz5m", "user_13_5955@example.com", "user_13_5955" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_3de7@example.com", "user_14_3de7@example.com", "USER_14_3DE7@EXAMPLE.COM", "USER_14_3DE7", "TOekNhJdtsyM/1ENYZwCEGrL118jinvHMX9e/DN2fOeJXM2HArxfcH9Zpl2OFu1U", "user_14_3de7@example.com", "user_14_3de7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_0ce0@example.com", "user_15_0ce0@example.com", "USER_15_0CE0@EXAMPLE.COM", "USER_15_0CE0", "nYnGefVz6uBons+XR/qXvPz277YDidF8d5W5cCZBYU8zUJIvnLIVbiSxUn6Cec4F", "user_15_0ce0@example.com", "user_15_0ce0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_54a0@example.com", "user_16_54a0@example.com", "USER_16_54A0@EXAMPLE.COM", "USER_16_54A0", "DU95BsyYTqtB2PLw5/sT25AZ1L69oa1Ijs0CZYs4J1WO+V3cMY4jvpDufr+t5C0A", "user_16_54a0@example.com", "user_16_54a0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_a54c@example.com", "user_17_a54c@example.com", "USER_17_A54C@EXAMPLE.COM", "USER_17_A54C", "lg0HRdzJJZDddbWWHTvPogms5ef4NXBxAtlhtTebmXO5lP+zmtulBVb8B+SzqlU5", "user_17_a54c@example.com", "user_17_a54c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_4939@example.com", "user_18_4939@example.com", "USER_18_4939@EXAMPLE.COM", "USER_18_4939", "PRdvdi7cvjzeJUsoEYm6O3dSD8SSsPdYrx3NJFbJVAJuJMgwl22bfi/W5+QcclhG", "user_18_4939@example.com", "user_18_4939" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_cd83@example.com", "user_19_cd83@example.com", "USER_19_CD83@EXAMPLE.COM", "USER_19_CD83", "zCbhmWoy/gAH9Cq22oCIqTi/xJnGv+XdGeO802s68bdGmFOvw+cz+2BECsjQEt8j", "user_19_cd83@example.com", "user_19_cd83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_f200@example.com", "user_20_f200@example.com", "USER_20_F200@EXAMPLE.COM", "USER_20_F200", "XGRBvuVBEUbl6LIBlmMCdIUAt5O5WvDyQv2SPK173k+HfjcstC58pe6EWHoeuiNG", "user_20_f200@example.com", "user_20_f200" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_46f2@example.com", "user_21_46f2@example.com", "USER_21_46F2@EXAMPLE.COM", "USER_21_46F2", "i/lhZp0i1upfgzBgGad1g8KBye32mvYbn3hCwlMvQpgaiH4ENNUrj+lURvl0hfZS", "user_21_46f2@example.com", "user_21_46f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_efa6@example.com", "user_22_efa6@example.com", "USER_22_EFA6@EXAMPLE.COM", "USER_22_EFA6", "hoZq33Bu5kjuvpdKy4uIqtt3eTlRg4nmwOfRXnBJjQ0PNODCubgBKQRURcuo5ofi", "user_22_efa6@example.com", "user_22_efa6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_7012@example.com", "user_23_7012@example.com", "USER_23_7012@EXAMPLE.COM", "USER_23_7012", "6E2s47BECCVttUcoGOu+ySi0205lW2fJ47ntspgx7LQI7r6jht8sLd0IH5yY1lf1", "user_23_7012@example.com", "user_23_7012" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_f2a1@example.com", "user_24_f2a1@example.com", "USER_24_F2A1@EXAMPLE.COM", "USER_24_F2A1", "OomzGOw7SZ/WevXNxB4DQlmmXvpWc+XrvLHNxrihGVcgiH2rvKfVbbL4i6G+uk6J", "user_24_f2a1@example.com", "user_24_f2a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_dbbb@example.com", "user_25_dbbb@example.com", "USER_25_DBBB@EXAMPLE.COM", "USER_25_DBBB", "c0TOLLQEgNUDSatkTt5CcAKD3Fx73dnGD4FszWzOwlAa9uq6qFM2lP7QuzgX1UFp", "user_25_dbbb@example.com", "user_25_dbbb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_c765@example.com", "user_26_c765@example.com", "USER_26_C765@EXAMPLE.COM", "USER_26_C765", "PTTxLWY5JTtd/myJb6v7iOqvCpm0YyUnMEqxIYDHEcdSGDnUwGLw/5Pz4AgvSRnb", "user_26_c765@example.com", "user_26_c765" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_b627@example.com", "user_27_b627@example.com", "USER_27_B627@EXAMPLE.COM", "USER_27_B627", "dOzwBOM9HCuuRwZCahCNztMCbEuYKCTe/k83NV5zbFYhPLHleJ4981OF3wKharUn", "user_27_b627@example.com", "user_27_b627" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_742e@example.com", "user_28_742e@example.com", "USER_28_742E@EXAMPLE.COM", "USER_28_742E", "KOyJ0t87PbrthxlAoTSRuPIrDjGfhbzY7PXFHimKsLdDZZ4BaB97AukiR6+MAh8s", "user_28_742e@example.com", "user_28_742e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_e97d@example.com", "user_29_e97d@example.com", "USER_29_E97D@EXAMPLE.COM", "USER_29_E97D", "J+C/RLtlgvqEwEJRaFg8R3rxGGlEI7HTuuvmVrHJmfBi9g35xEgnIFU3QREanDMV", "user_29_e97d@example.com", "user_29_e97d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_137f@example.com", "user_30_137f@example.com", "USER_30_137F@EXAMPLE.COM", "USER_30_137F", "VfN/OOUF7PW3sff9HEq+FIIxi0WHBlOTWf6fFXIX89wAQxr3LkvJbBWVoOL3z7Ox", "user_30_137f@example.com", "user_30_137f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_1351@example.com", "user_31_1351@example.com", "USER_31_1351@EXAMPLE.COM", "USER_31_1351", "ck8YL8TTuLscGjxuX/lCBaPYOer7SRqifAPFLrr3FK1ySJsLas3EPOpe2Osy7DSA", "user_31_1351@example.com", "user_31_1351" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_e524@example.com", "user_32_e524@example.com", "USER_32_E524@EXAMPLE.COM", "USER_32_E524", "/EIxIsB0oMrPPWNLmWT7nGxeQ57C3A0OFoyST/Y9kYAugE8h3aXbYpt6Vf5qERZo", "user_32_e524@example.com", "user_32_e524" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_5a08@example.com", "user_33_5a08@example.com", "USER_33_5A08@EXAMPLE.COM", "USER_33_5A08", "s2Vo8lhRoObNl8GD0pRlNNambYcuZdvrxkmN1OBdG1dL2rK9cYcgDUtcpwZVt3/v", "user_33_5a08@example.com", "user_33_5a08" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_c96e@example.com", "user_34_c96e@example.com", "USER_34_C96E@EXAMPLE.COM", "USER_34_C96E", "rGhGX+hucngZRaK0flDukTa9RkOuplFIpXRNhzpfBm+ZfISbBP3CX91UrYVPrB76", "user_34_c96e@example.com", "user_34_c96e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_4ca4@example.com", "user_35_4ca4@example.com", "USER_35_4CA4@EXAMPLE.COM", "USER_35_4CA4", "yq7lWiOQmP8CzOweuUJvtOAsEZLY4LOiYvq1iB+DOPDP3q8RPAC4MabQn71ibZA5", "user_35_4ca4@example.com", "user_35_4ca4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_42ba@example.com", "user_36_42ba@example.com", "USER_36_42BA@EXAMPLE.COM", "USER_36_42BA", "siwmTG5QXqSOhlKvwsYX+cr+y8t45KrTzlbYZLeWJb+rWKzUmcComYcjLdE9npFV", "user_36_42ba@example.com", "user_36_42ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_7347@example.com", "user_37_7347@example.com", "USER_37_7347@EXAMPLE.COM", "USER_37_7347", "7Avpz4iEnnz4+SlxRHwKkguMj6jk+kf/yOQ34PfWKJuCo6+0t//8UCJD+H1AqK5p", "user_37_7347@example.com", "user_37_7347" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_7faf@example.com", "user_38_7faf@example.com", "USER_38_7FAF@EXAMPLE.COM", "USER_38_7FAF", "USyKY3hMAlMZmZ1QnxcNEbjRl5SnGiffZK9ATNCTIy6pRVhwZkqywbAk0F+B2DCg", "user_38_7faf@example.com", "user_38_7faf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_d777@example.com", "user_39_d777@example.com", "USER_39_D777@EXAMPLE.COM", "USER_39_D777", "47csR9aJL3eF8WwG0k6MnMy1JvWDspJn1Elq3knJetKuzWduE+wpfhgiDC6ULZQt", "user_39_d777@example.com", "user_39_d777" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_da80@example.com", "user_40_da80@example.com", "USER_40_DA80@EXAMPLE.COM", "USER_40_DA80", "crGfRj4AhCeW3A3LJAfEjZi8DHbusBQ405kbQqppLrngK3KKzxzZRRIk/xF8Hm3J", "user_40_da80@example.com", "user_40_da80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_fcba@example.com", "user_41_fcba@example.com", "USER_41_FCBA@EXAMPLE.COM", "USER_41_FCBA", "nQ04PM9zHXGYaqiqAFEDi+8J5ubbpg8ybNP19NoM2EZcAWTpAbmNjbulx61uPR3C", "user_41_fcba@example.com", "user_41_fcba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_ac80@example.com", "user_42_ac80@example.com", "USER_42_AC80@EXAMPLE.COM", "USER_42_AC80", "OIWryxmFvRqMRu26FiH9/WiQaU3SrDoyNYqITqTMu96ZSJmWgYlFEVe1KGO+Hrg6", "user_42_ac80@example.com", "user_42_ac80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_7d75@example.com", "user_43_7d75@example.com", "USER_43_7D75@EXAMPLE.COM", "USER_43_7D75", "t+f3ZMpSHyW/yty2gr9apttUBddliDoXsEcsN2Pqi6UFVr53tYG3JGf3GN7SLLfH", "user_43_7d75@example.com", "user_43_7d75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_2dee@example.com", "user_44_2dee@example.com", "USER_44_2DEE@EXAMPLE.COM", "USER_44_2DEE", "664f/cqi84t8c2XzaXIxryh8PNhY0brlFQXubGjdDCW4zH9UFAjBu+YWeAkToPwT", "user_44_2dee@example.com", "user_44_2dee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_5325@example.com", "user_45_5325@example.com", "USER_45_5325@EXAMPLE.COM", "USER_45_5325", "dWMN0LY2fM9bF0W+bQt/4SMgy0ZG19IHqtOhidSCsXvgJHa9RAsWo6IzhQwXX3eP", "user_45_5325@example.com", "user_45_5325" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_9f39@example.com", "user_46_9f39@example.com", "USER_46_9F39@EXAMPLE.COM", "USER_46_9F39", "f3NBRHwKnpYLu8ivrt1cIt1WNsgt7GPMVREmQSUT8GNKyY4S+WtJ+0aal2MSG58Z", "user_46_9f39@example.com", "user_46_9f39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_b050@example.com", "user_47_b050@example.com", "USER_47_B050@EXAMPLE.COM", "USER_47_B050", "Uobve4HczL3Rou77NHWKghaNYuzw/CbA/5UNM6AeDdpUf21cCnwGtfIZwELSPxKK", "user_47_b050@example.com", "user_47_b050" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_bee4@example.com", "user_48_bee4@example.com", "USER_48_BEE4@EXAMPLE.COM", "USER_48_BEE4", "lRUsUssN4leZVpcOefFXAiq+dt4TbGlaGYW0JvWrKpI3URfJEmwR5rk1Ga5zVXZi", "user_48_bee4@example.com", "user_48_bee4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_6ced@example.com", "user_49_6ced@example.com", "USER_49_6CED@EXAMPLE.COM", "USER_49_6CED", "HZM4lTcdZkG2Xzo9Kf4IXCoA7Unr4bzWXjaSz1Xbv0yiTq4mzBdsy1to/sInBjcI", "user_49_6ced@example.com", "user_49_6ced" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_ae1d@example.com", "user_50_ae1d@example.com", "USER_50_AE1D@EXAMPLE.COM", "USER_50_AE1D", "b9pqg8IWlXgmUEYmH1R5WVpye9LnqrF3qPQNh/SugeKKplifNeHQpojC8Dl06cT1", "user_50_ae1d@example.com", "user_50_ae1d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "zbFdaAGMHD7WZS836FjWGZlAKd11PFpMWmED58DQG/5Gb36csat4eEEhHie8T4PF");
        }
    }
}
