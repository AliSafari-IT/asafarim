using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLinksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Link_Projects_ProjectId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkPost_Link_LinksId",
                table: "LinkPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Link",
                table: "Link");

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

            migrationBuilder.RenameTable(
                name: "Link",
                newName: "Links");

            migrationBuilder.RenameIndex(
                name: "IX_Link_ProjectId",
                table: "Links",
                newName: "IX_Links_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Links",
                table: "Links",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("09ca5911-7e1d-4498-b085-ade32bfeb3ff"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("1dffda0e-4f01-4fea-9efa-2435c219ccc3"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("58b01a72-5be3-4796-8597-bf4e8534cf74"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("5db6fcf1-f2dc-433b-8c15-9bab99182738"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("61efd147-c690-4b8b-8073-a9004316ca81"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("7163474a-a9c9-4b00-99f0-95eb38d115bd"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("978f842e-2ad3-4e03-b7de-09c7c06b4752"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("c9679668-e538-42c7-af9d-b6a596a64baa"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("e3f03c7b-3a11-4c78-b47d-422156c287f7"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("e8f52ff3-ae7b-43b2-b3e0-79f96ad42d74"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04001865-57b1-4eb7-ad19-af76b5923ef3"), "USD", new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(7506), 2, true, "US Dollar", "$", null },
                    { new Guid("5bba8cb3-467f-48ab-bbb9-e381360afb5e"), "GBP", new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(7520), 2, true, "British Pound", "£", null },
                    { new Guid("a411507b-5428-4e8c-adaf-47baa5c2f09e"), "CHF", new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(7523), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("ddf98b3a-303a-43d1-ba87-bb72ce8bbcde"), "EUR", new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(6348), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("18cf105a-4c9c-4e50-8cf8-b4ecf8a219de"), new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(4557), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("41850229-3cef-4231-852b-267234648f83"), new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(4561), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("6424fe83-9b3b-420c-ae5f-d500451fa799"), new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(3351), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("aca80b2f-b8c1-4ac1-8299-bff74cb3a530"), new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(4564), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("11c857ca-b852-4aef-b77b-91fd20d976e0"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(8619), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("41181230-a303-41f0-894f-3009abf19ec1"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(8625), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("975b73c5-96bc-47a7-85b2-50d476d84c29"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(8600), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("994fdfe9-15e9-43e4-9887-e64baef6d40b"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(8622), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("d14d1827-e3c0-4a64-971a-37706246c185"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(8605), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("f6c8bf6a-0982-44f5-ab07-339cecd4dd21"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(6765), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("c53deb5b-6b09-4ab4-8a09-6789db25f768"), new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(425), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3282f437-2db3-415d-ba5d-25c35b28c702"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(3922), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("4870d922-4d42-4d34-a7eb-19966205847d"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(3926), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("488ee5c9-e139-4367-ac93-838d77c852bf"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(3907), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("78fdd2f3-7ade-4b9e-83b6-038754edd12f"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(3931), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("8ef4478c-dc1a-4a06-8bbe-a44ceb518ec7"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(2852), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("9b05b0f7-21db-48e4-9765-3a458ce202a5"), new DateTime(2025, 3, 12, 22, 28, 49, 952, DateTimeKind.Utc).AddTicks(3929), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("22648235-8464-4ced-97a1-37e01c302ab6"), null, new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(5523), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("40e34147-aa83-4431-a65e-ba2dca57a1fb"), null, new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(6368), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("6a52bcfc-d8e4-497a-ac3c-b9d3c1b5fcb1"), null, new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(6358), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("92a0991a-d7b9-4cc5-a628-5d3db92e5fe2"), null, new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(6353), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("3f8ef595-7fff-4b31-8252-b9d63201c5c6"), new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(294), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("ab7bfbbb-da12-47fd-9f42-2978d7cbabd6"), new DateTime(2025, 3, 12, 22, 28, 49, 953, DateTimeKind.Utc).AddTicks(8837), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("ce27c274-e52a-4f4c-a65e-143619508631"), new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(284), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("dc734527-754c-4eaa-846e-27c1e3174ec9"), new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(324), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("e4e0ba3f-1b2e-4bcb-b002-b043bc287864"), new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(292), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 22, 28, 49, 954, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("7ea31892-2b92-4634-bcd1-d651669b0d84"), new DateTime(2025, 3, 12, 22, 28, 49, 955, DateTimeKind.Utc).AddTicks(225), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("ca679982-647f-4c78-9714-f4126e4578cb"), new DateTime(2025, 3, 12, 22, 28, 49, 955, DateTimeKind.Utc).AddTicks(209), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("f76306b3-9813-4b91-a92c-5f87d96c4afb"), new DateTime(2025, 3, 12, 22, 28, 49, 955, DateTimeKind.Utc).AddTicks(217), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "M0jZ6/uhf3+T3KWo8VA45aiua5KpJUGiETkUn7lPXCl0IEx+YOn6YVertRZLYy+/");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "XEae7oVT9FMW7DUb8gWmBwYlGGs/BKLX1Sq7HLUIrhpzNzD1yv0FiLYxtk0KE4uD");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_126d@example.com", "user_1_126d@example.com", "USER_1_126D@EXAMPLE.COM", "USER_1_126D", "oM/tD8lI6QQy2ppbXq08n4GyZR6j46Ciknov646LPDSWVt2cKTFvIcPFkoyL6Nv5", "user_1_126d@example.com", "user_1_126d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_7019@example.com", "user_2_7019@example.com", "USER_2_7019@EXAMPLE.COM", "USER_2_7019", "6AKPvUjEy0gKkDAy+rCYK6OGGec7xWG80qLnw0dOlDD5uMamdLY+ptPolKei48yX", "user_2_7019@example.com", "user_2_7019" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_b0ff@example.com", "user_3_b0ff@example.com", "USER_3_B0FF@EXAMPLE.COM", "USER_3_B0FF", "K4oZ4UkC9sS8ZsfHA/fL2iXzL2zbSXJNxRrhN/kCX8H/Cz1VPMAzZhWlmBqfpYh2", "user_3_b0ff@example.com", "user_3_b0ff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_600d@example.com", "user_4_600d@example.com", "USER_4_600D@EXAMPLE.COM", "USER_4_600D", "8xVd+HLrQUtZ5QsQY6fHZR4Y/erYtAf3mYj5BHN4uAgFL+iqyQYP3YBOuKqQKiL0", "user_4_600d@example.com", "user_4_600d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_c5e4@example.com", "user_5_c5e4@example.com", "USER_5_C5E4@EXAMPLE.COM", "USER_5_C5E4", "z9+nxcOAGl+RTnRCaD225u+dvAdk5ecuXajJDnzIJnFTQFJCgNHrJ5Y9RVdX0Dcu", "user_5_c5e4@example.com", "user_5_c5e4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_7467@example.com", "user_6_7467@example.com", "USER_6_7467@EXAMPLE.COM", "USER_6_7467", "k1EHnEkcwkAg90XPl4Kz9wSkwOV08Feq6zFWPz0qRNUZ75G6zRVNI/FQaY5Ary2I", "user_6_7467@example.com", "user_6_7467" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_9f0b@example.com", "user_7_9f0b@example.com", "USER_7_9F0B@EXAMPLE.COM", "USER_7_9F0B", "Vdom155ko8Lg/YLeKrngImJjfoddv/GmjHlnQY1SBzzzpjd0eDAh69enDxt7HD8e", "user_7_9f0b@example.com", "user_7_9f0b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_bc1e@example.com", "user_8_bc1e@example.com", "USER_8_BC1E@EXAMPLE.COM", "USER_8_BC1E", "IIbSwLcz8nJPcxH1bgk6phv9YkBAY/VgTc/X5PMgfRWrsY443+ae1gRlcAfcdMPl", "user_8_bc1e@example.com", "user_8_bc1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_62ab@example.com", "user_9_62ab@example.com", "USER_9_62AB@EXAMPLE.COM", "USER_9_62AB", "wFzaz16JBFZisdihl1Ku4QsowTz0DaMIUaTKoaljNSTFDr33TD53TFcuCPDln48L", "user_9_62ab@example.com", "user_9_62ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_7045@example.com", "user_10_7045@example.com", "USER_10_7045@EXAMPLE.COM", "USER_10_7045", "YyPBa6tT8rk1Y9AiLsul35PUz4FxGLLBFHBOWDcP9ut/bfonE8q/6RYmzgJ3JDNx", "user_10_7045@example.com", "user_10_7045" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_9058@example.com", "user_11_9058@example.com", "USER_11_9058@EXAMPLE.COM", "USER_11_9058", "S1vB1jbOvoAiECz7qFo+MR/e0S1rcEBft5bAwcPVulM2Ui//sww3YVMXrjH7EEbd", "user_11_9058@example.com", "user_11_9058" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_041d@example.com", "user_12_041d@example.com", "USER_12_041D@EXAMPLE.COM", "USER_12_041D", "VdkiHL7HXcb8wcwbNtIJFsc1g0geZplvEeRpURV6ZxaorxQ6MAq6iKN7FneQtvPX", "user_12_041d@example.com", "user_12_041d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_ae6f@example.com", "user_13_ae6f@example.com", "USER_13_AE6F@EXAMPLE.COM", "USER_13_AE6F", "cPdsbvdnoepnfs1rQXtvOyOppbyPyKYerhOIBpz0nvVjfd5T5O33uzxlfEnlQJnd", "user_13_ae6f@example.com", "user_13_ae6f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_3389@example.com", "user_14_3389@example.com", "USER_14_3389@EXAMPLE.COM", "USER_14_3389", "mqyK41UUv1XDEdVdW3g7VDmsOcWw0ELYjLRFGaX+grQKSE2IlPELFY8bGYoZXj/h", "user_14_3389@example.com", "user_14_3389" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_3995@example.com", "user_15_3995@example.com", "USER_15_3995@EXAMPLE.COM", "USER_15_3995", "uvHwfuLm6MUh2JQiVSPXlUR4oeS+vjsup33B4PYIF48FtpTYYxylHxNyx/x/7ibR", "user_15_3995@example.com", "user_15_3995" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_4f0c@example.com", "user_16_4f0c@example.com", "USER_16_4F0C@EXAMPLE.COM", "USER_16_4F0C", "Qhuce173uxWg/QU1geyhRT/9LDuc0R1oVF6QZIGhr3iVOq7jqGBayPWsptr0nhrz", "user_16_4f0c@example.com", "user_16_4f0c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_7b6a@example.com", "user_17_7b6a@example.com", "USER_17_7B6A@EXAMPLE.COM", "USER_17_7B6A", "de9HW+VLBQLxakQegPnO+ciW1Jr2dcpGEBHAOuTVT4lxyHYOt31xUpTboZVT0rCX", "user_17_7b6a@example.com", "user_17_7b6a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_9b7d@example.com", "user_18_9b7d@example.com", "USER_18_9B7D@EXAMPLE.COM", "USER_18_9B7D", "DJCvR5qtgoe6jr06aK48WGx/5bIOBw5M5o87fD2vRkJhwQtjknpl9UyS21cdMz5G", "user_18_9b7d@example.com", "user_18_9b7d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_78d7@example.com", "user_19_78d7@example.com", "USER_19_78D7@EXAMPLE.COM", "USER_19_78D7", "BHl+pBJBo+r/doRdHvaFZk8micIURnq9N2I3+sZTKxRULU5xJSiGK4nI8Z62wQvs", "user_19_78d7@example.com", "user_19_78d7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_4dfe@example.com", "user_20_4dfe@example.com", "USER_20_4DFE@EXAMPLE.COM", "USER_20_4DFE", "pedZw/J4ybNtS2PmZwfpvsunwGnY7gs8EjKLGkDGXDEg4xwhsSR/8ZmLzAPPMuy4", "user_20_4dfe@example.com", "user_20_4dfe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_c949@example.com", "user_21_c949@example.com", "USER_21_C949@EXAMPLE.COM", "USER_21_C949", "EJG6pcYs1GnY5avArYwBZrPvxWPPpS77pdcmHNd5W9asLfBbUQsMrhVCh0E5F5mo", "user_21_c949@example.com", "user_21_c949" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_4cee@example.com", "user_22_4cee@example.com", "USER_22_4CEE@EXAMPLE.COM", "USER_22_4CEE", "Ab/Y7aOba/l+oHL8gcjojhg3sDD5zsFEpfmKd8r6uzxQ7cJ8Z6C+QWEqta3RIy4H", "user_22_4cee@example.com", "user_22_4cee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_99eb@example.com", "user_23_99eb@example.com", "USER_23_99EB@EXAMPLE.COM", "USER_23_99EB", "u6JhaHZp8vfxy9VH0ZFCuXtl1gzHWWWUQ0UJinW2UTpEMOo7Ouu35KoWgwTQB3Gv", "user_23_99eb@example.com", "user_23_99eb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_4c3c@example.com", "user_24_4c3c@example.com", "USER_24_4C3C@EXAMPLE.COM", "USER_24_4C3C", "N7u+wowB2HWnpfN4Tx4NbFiltrgwdvfgDsQPBIc1/80cE3cLLuLio+DHr19oD7Ke", "user_24_4c3c@example.com", "user_24_4c3c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_a5fc@example.com", "user_25_a5fc@example.com", "USER_25_A5FC@EXAMPLE.COM", "USER_25_A5FC", "4W3lnFh1NSntMgrfOCxahiLKErek+UTSkRIjOXoTT4ralvHUQz+bQK3fF13So8D4", "user_25_a5fc@example.com", "user_25_a5fc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_1668@example.com", "user_26_1668@example.com", "USER_26_1668@EXAMPLE.COM", "USER_26_1668", "06BIyEskc61cWrMgiwKSGmDULx9Viwxrq/gkLeiQ0MqIdoAL9HApb8HbTsiYXibG", "user_26_1668@example.com", "user_26_1668" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_9be6@example.com", "user_27_9be6@example.com", "USER_27_9BE6@EXAMPLE.COM", "USER_27_9BE6", "Yttzb8Vm3w4+7lJSe1YFRCWcZh+2Yr39ZBfXA6bZmZFqaU5rOFuZ/YQuO8Pt7lKU", "user_27_9be6@example.com", "user_27_9be6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_a8f4@example.com", "user_28_a8f4@example.com", "USER_28_A8F4@EXAMPLE.COM", "USER_28_A8F4", "oLlP7Fz7KYviyzvzsREiyJW+dkKwBk87AVnE3f8+MTIj2+ih/2Stl+H/Wa+x1ubP", "user_28_a8f4@example.com", "user_28_a8f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_3a4a@example.com", "user_29_3a4a@example.com", "USER_29_3A4A@EXAMPLE.COM", "USER_29_3A4A", "hkVx3xgUBEPlNy8JI2X2L5IVXXCF5mY+DGid6pDDXpQfpX+AaZ+YGs143kiBmtIb", "user_29_3a4a@example.com", "user_29_3a4a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_042c@example.com", "user_30_042c@example.com", "USER_30_042C@EXAMPLE.COM", "USER_30_042C", "FV+tIr6VHoyVMdaJdVx2ZTYWSMroPUKUcVc7Dio40skeDLdWFw8AB9Jc37bB1gZb", "user_30_042c@example.com", "user_30_042c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_b8bc@example.com", "user_31_b8bc@example.com", "USER_31_B8BC@EXAMPLE.COM", "USER_31_B8BC", "JeNLHpYd6ESVwuI5NUN65RwiZlSauPmwnEXeZxGGkNC+2OqIqZ3SVghJu7251ot9", "user_31_b8bc@example.com", "user_31_b8bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_5c06@example.com", "user_32_5c06@example.com", "USER_32_5C06@EXAMPLE.COM", "USER_32_5C06", "6Gdn4Sx1Z4TtWpa25Nfk1tlDsumzAAPyeiTyOfduawnNT3WPkj2BWIpSEcqcxTB5", "user_32_5c06@example.com", "user_32_5c06" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_1a61@example.com", "user_33_1a61@example.com", "USER_33_1A61@EXAMPLE.COM", "USER_33_1A61", "k0OUm/tXPHnKHo6QPx4457+p9crNj6AXSLnFwOoPuriL5NX7gpnnh4KpPbzLx3LM", "user_33_1a61@example.com", "user_33_1a61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_7760@example.com", "user_34_7760@example.com", "USER_34_7760@EXAMPLE.COM", "USER_34_7760", "LzRQiQFJ1JRyMG2wCtLEfzZksXHse2oY2mYoC+9j+LgtUBdaur5mUb3xcvUbQmTY", "user_34_7760@example.com", "user_34_7760" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_ca73@example.com", "user_35_ca73@example.com", "USER_35_CA73@EXAMPLE.COM", "USER_35_CA73", "baihlDOstpdZUFC1xnKYw1Ch6Xp6y8yybqHn2fWkMb4XIYXVeLvcPebI02ZZAlWt", "user_35_ca73@example.com", "user_35_ca73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_077a@example.com", "user_36_077a@example.com", "USER_36_077A@EXAMPLE.COM", "USER_36_077A", "huYnasw7F1aKVCZOl8FWXQTdJTrBeNdV/FAwrZdmxzivMLsPCGY0dsfb8uVB64Gk", "user_36_077a@example.com", "user_36_077a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_3d9f@example.com", "user_37_3d9f@example.com", "USER_37_3D9F@EXAMPLE.COM", "USER_37_3D9F", "B4EnmBmlDHVJLbRUAhHHPFP/+SmZDcFvE1OgqspJtQyrAioPoJr08oJjzPEsuJ5P", "user_37_3d9f@example.com", "user_37_3d9f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_842e@example.com", "user_38_842e@example.com", "USER_38_842E@EXAMPLE.COM", "USER_38_842E", "KUSTyTMCfjWOdLl7BaUzHudo7vpa/F5NuehdWWMQsu+9jl/ALcX4MrkUKhAT9G/s", "user_38_842e@example.com", "user_38_842e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_1050@example.com", "user_39_1050@example.com", "USER_39_1050@EXAMPLE.COM", "USER_39_1050", "igOh5DAK58BQCEl/WIVFdTrjQ6JpmA1GGfHXTK5EBjQD47ldRgqMMaXVYozJhJLt", "user_39_1050@example.com", "user_39_1050" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_b69b@example.com", "user_40_b69b@example.com", "USER_40_B69B@EXAMPLE.COM", "USER_40_B69B", "3t4lqFmrLBebbo3rZvxAlwFvNx7YxHvJ0bb50WFt0Bs22yh02fahsA91iKXhYszr", "user_40_b69b@example.com", "user_40_b69b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_75c0@example.com", "user_41_75c0@example.com", "USER_41_75C0@EXAMPLE.COM", "USER_41_75C0", "delVpDEIb7q2Z8t78oIBqDKz1uGLZqhO2ugVSxchTeMJtYm/dEBKL4+mTxV1k0rC", "user_41_75c0@example.com", "user_41_75c0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_c5c8@example.com", "user_42_c5c8@example.com", "USER_42_C5C8@EXAMPLE.COM", "USER_42_C5C8", "lDcPwGhiXbLz+xMofk0+CgaNoniFjU06QsJsqbdz4K9LRxhFCYtq92YzaOAP4Nl4", "user_42_c5c8@example.com", "user_42_c5c8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_9bad@example.com", "user_43_9bad@example.com", "USER_43_9BAD@EXAMPLE.COM", "USER_43_9BAD", "uJby/Mpy7oQ4u26CmbR0csV9rJ1cbxSE6wSuuZTUvc50M9FmZT7Km+hcTmyr2q4z", "user_43_9bad@example.com", "user_43_9bad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_694e@example.com", "user_44_694e@example.com", "USER_44_694E@EXAMPLE.COM", "USER_44_694E", "YbF51p7nhsqFckuKdvYGCWx7G/92WkrnwYz0edh04h113rqsNZ5AeabS2PZ3y63n", "user_44_694e@example.com", "user_44_694e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_dda8@example.com", "user_45_dda8@example.com", "USER_45_DDA8@EXAMPLE.COM", "USER_45_DDA8", "vZskD1xIwaLbsjPOYmaYapglU9LpZLjxptalGArQmrelbfOedFgJhPCmdXwq1isr", "user_45_dda8@example.com", "user_45_dda8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_8e38@example.com", "user_46_8e38@example.com", "USER_46_8E38@EXAMPLE.COM", "USER_46_8E38", "79sAWp/h/s9FSY8aYP7Pe8dFHL8QjO0JLWGaRCzuK7WgAxajKQvORfAtcWTCEla+", "user_46_8e38@example.com", "user_46_8e38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_6380@example.com", "user_47_6380@example.com", "USER_47_6380@EXAMPLE.COM", "USER_47_6380", "gKeE7CcfitbUwOokbKiOooqU942nXBXUL50JOW8cNS1gUjkKqa5glB4r8n3H6lQN", "user_47_6380@example.com", "user_47_6380" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_4788@example.com", "user_48_4788@example.com", "USER_48_4788@EXAMPLE.COM", "USER_48_4788", "J7UP7csjNGBSvqqhsdvyr3tBYuyfWhZsL8O+FRYPaly0GK53byq8I6XmsJwKD0Vz", "user_48_4788@example.com", "user_48_4788" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_4aff@example.com", "user_49_4aff@example.com", "USER_49_4AFF@EXAMPLE.COM", "USER_49_4AFF", "gzsr7HRiofMNm3mLqoZhypzQlxOkV1QlKUfxhC0FPlTQK3P3fKyEz820cJIsk0sv", "user_49_4aff@example.com", "user_49_4aff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_5d94@example.com", "user_50_5d94@example.com", "USER_50_5D94@EXAMPLE.COM", "USER_50_5D94", "eornIhp/QxUVZRoxuSwBQI6ejntrKWi3by/+lw4f7wHubugIK40jQgBmiegRtQYu", "user_50_5d94@example.com", "user_50_5d94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "3Wu+Y1P1CgEl+x548UaeHT6wG/jo3685ycfNzIbw7yGcq1EBXAmsEHxT96RIXmf4");

            migrationBuilder.AddForeignKey(
                name: "FK_LinkPost_Links_LinksId",
                table: "LinkPost",
                column: "LinksId",
                principalTable: "Links",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Projects_ProjectId",
                table: "Links",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinkPost_Links_LinksId",
                table: "LinkPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Projects_ProjectId",
                table: "Links");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Links",
                table: "Links");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("09ca5911-7e1d-4498-b085-ade32bfeb3ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1dffda0e-4f01-4fea-9efa-2435c219ccc3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58b01a72-5be3-4796-8597-bf4e8534cf74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5db6fcf1-f2dc-433b-8c15-9bab99182738"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61efd147-c690-4b8b-8073-a9004316ca81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7163474a-a9c9-4b00-99f0-95eb38d115bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("978f842e-2ad3-4e03-b7de-09c7c06b4752"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9679668-e538-42c7-af9d-b6a596a64baa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e3f03c7b-3a11-4c78-b47d-422156c287f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8f52ff3-ae7b-43b2-b3e0-79f96ad42d74"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("04001865-57b1-4eb7-ad19-af76b5923ef3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5bba8cb3-467f-48ab-bbb9-e381360afb5e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a411507b-5428-4e8c-adaf-47baa5c2f09e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ddf98b3a-303a-43d1-ba87-bb72ce8bbcde"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("18cf105a-4c9c-4e50-8cf8-b4ecf8a219de"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("41850229-3cef-4231-852b-267234648f83"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("6424fe83-9b3b-420c-ae5f-d500451fa799"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("aca80b2f-b8c1-4ac1-8299-bff74cb3a530"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("11c857ca-b852-4aef-b77b-91fd20d976e0"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("41181230-a303-41f0-894f-3009abf19ec1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("975b73c5-96bc-47a7-85b2-50d476d84c29"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("994fdfe9-15e9-43e4-9887-e64baef6d40b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d14d1827-e3c0-4a64-971a-37706246c185"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f6c8bf6a-0982-44f5-ab07-339cecd4dd21"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("c53deb5b-6b09-4ab4-8a09-6789db25f768"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3282f437-2db3-415d-ba5d-25c35b28c702"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4870d922-4d42-4d34-a7eb-19966205847d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("488ee5c9-e139-4367-ac93-838d77c852bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("78fdd2f3-7ade-4b9e-83b6-038754edd12f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8ef4478c-dc1a-4a06-8bbe-a44ceb518ec7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9b05b0f7-21db-48e4-9765-3a458ce202a5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("22648235-8464-4ced-97a1-37e01c302ab6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("40e34147-aa83-4431-a65e-ba2dca57a1fb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6a52bcfc-d8e4-497a-ac3c-b9d3c1b5fcb1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("92a0991a-d7b9-4cc5-a628-5d3db92e5fe2"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3f8ef595-7fff-4b31-8252-b9d63201c5c6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ab7bfbbb-da12-47fd-9f42-2978d7cbabd6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ce27c274-e52a-4f4c-a65e-143619508631"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("dc734527-754c-4eaa-846e-27c1e3174ec9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("e4e0ba3f-1b2e-4bcb-b002-b043bc287864"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7ea31892-2b92-4634-bcd1-d651669b0d84"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ca679982-647f-4c78-9714-f4126e4578cb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f76306b3-9813-4b91-a92c-5f87d96c4afb"));

            migrationBuilder.RenameTable(
                name: "Links",
                newName: "Link");

            migrationBuilder.RenameIndex(
                name: "IX_Links_ProjectId",
                table: "Link",
                newName: "IX_Link_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Link",
                table: "Link",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Projects_ProjectId",
                table: "Link",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LinkPost_Link_LinksId",
                table: "LinkPost",
                column: "LinksId",
                principalTable: "Link",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
