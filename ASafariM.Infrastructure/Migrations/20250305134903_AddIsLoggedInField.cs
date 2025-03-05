using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsLoggedInField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04e1db5c-cea8-4e76-83c7-677b3e32099e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13d70ed8-dd46-46fe-99e1-b9871081e52c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e949d35-83bf-41f8-85c6-e9a6747a67c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("44e8b866-9ffe-4f06-b594-dac8e1811027"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b11d086-90bb-4367-846b-cfb864015231"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7cd492c6-e788-46d2-908b-7ead9fcebdbf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9038ff90-b290-42f9-9e43-5988434ee8fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2fb8e8b-7686-4ce4-a84c-6b9ac9a4bfe6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c00b6594-2ba3-4c5b-b15c-ab1098cc4e39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c95c47c6-6be3-4dd3-b5e4-c39e20676f9e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("025cd1b3-1b4c-44e8-b7f0-85dda33415b0"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("36ccc6f8-216c-43dd-b8f5-6a76eebccde9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a92fe68a-cd1d-4cdf-ac23-066b417e4ca9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b4a32afe-e33e-4b2e-b65b-25b250624e7a"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("03aae2f9-6474-4911-8033-79308ffd0994"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("74396458-b0b9-4e80-9d7c-f6c6e25c49d5"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("afd53535-29bf-4524-8e82-261039722a6b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("bbe459b6-2a42-4f82-a615-2b188fc96212"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6d041bd2-a8f6-44ca-8cb3-bf4cc5be9e40"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("872c3ce2-b353-4820-933d-2aa2b0d076ad"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("db7b1a06-3dc7-41c6-8630-c6c6fffdd59f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("dc61eef6-59f1-4458-9ac5-6fc71849eb86"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ecf7f88d-ac91-40c6-b7a2-8f48723fd5a5"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f49f6bff-92fa-4319-bdd7-f25c3ff97231"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("23fc22be-1347-4a18-b5bf-133dbb7c5580"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("203efa20-ec83-416c-8c7c-e15db60b3376"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5c916406-a240-4bf7-b060-9246a2e2ed95"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a55c57c8-3483-4d7f-bec0-6d469b9e6bbc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d8a359ac-1643-44b1-bed9-28e05753a181"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f02b99e7-b2ed-485c-8360-1658750d3ad5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fb6235ea-c95f-4995-b3e1-e51b144f7987"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0c2e195b-1b62-4623-9c14-fa82eccf8dbf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("43416a93-2167-4354-9cc4-bbf72f34ea28"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("75dfe181-65f9-4a1e-8bcc-ddfc8d0db817"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("97426829-0bdb-455c-a1af-435318d4f660"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3179aad1-c782-4fd0-9cb4-f10fc79c5360"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("406c64f6-5439-407b-971a-c028897f2974"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("579147fc-2f60-46dd-802d-1bcc30c66324"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("a352502c-19d8-4b9e-8527-05828a70bb84"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c1e54dc8-d803-4f56-b645-4e4c2a3a4eb1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0802724c-918b-44b0-a3b1-a37e40307d40"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a759b72a-bb37-449c-869b-5629502b1726"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ceea4503-d173-48aa-819a-19439e1a8cc6"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsLoggedIn",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2fd30469-a260-408d-b12c-ad5b4dcc4c99"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("4416080f-b075-4b72-b7a0-9d00a30bf28b"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("4c24fbde-c8cf-46be-ae37-b8cef62181a3"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("73c2795b-5ff4-48c8-aeb6-0c7dfdc394a6"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("755c4c3a-d6b6-49e1-9a88-d41997e93dc4"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("7761667e-f5da-4d8a-922e-6edde8a57922"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("a0d0f4f1-00ff-4884-abb6-7f630373e99d"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("ad40d064-d94d-4181-8eb7-20a65ae7090f"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("cb561671-80b3-45af-b821-328524fca94e"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("f82be211-d963-4345-a6a9-41911764be6a"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b92f1bd1-65b8-4ac2-96b0-4b203d9d05ba"), "GBP", new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(5250), 2, true, "British Pound", "£", null },
                    { new Guid("c4603961-1c1d-4bb9-85e3-d270e7355fb7"), "USD", new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(5241), 2, true, "US Dollar", "$", null },
                    { new Guid("c6cb1892-35fb-4b8a-b986-f84a628b073f"), "CHF", new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(5253), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("defb7812-ba6b-4422-8d49-35fb63ab1ed7"), "EUR", new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(3478), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2f289fab-746e-49ab-a656-88fba8eb74b7"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(2532), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("6fb08530-f03b-4214-bacf-1784e9b95fbe"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(1254), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("d7f1ba6a-1d47-49cf-9ed9-de0251f29a51"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(2526), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("e699923b-a85c-4aa5-aed1-92b8f008a5f1"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(2541), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1559f988-2183-4ad8-a3e0-bcedddb04bcc"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6918), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("26a6ef15-51ef-4ee5-95ea-5dd2d978ebe0"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6909), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("3e6f0285-f526-4c0d-a3f1-6471f0e185eb"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6915), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("8cb0063d-0f48-4d10-b6bc-89818edb7feb"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6893), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("ada9e2ec-87ff-4800-af43-d01d3910504b"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6912), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("f4e35ca4-930e-425a-a62b-b59300410ddd"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(4305), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("7255e35e-ca20-44dd-ba22-36cb282cf850"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(8375), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("01d51ca9-4ee1-49c8-bb50-5c8adac72c67"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1933), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("12e1f938-b239-4f1d-9573-710e0264a8fa"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1946), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("140838c8-5068-4ed4-92e8-99db5112a72a"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(241), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("28b57485-a1da-4c45-9f3d-174dd45c9e0a"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1924), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("b1a0db22-e7d2-4004-bcfa-35c73274f92f"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1950), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("b246cf74-a6ad-44f1-bc5f-98cf82530985"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1929), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("128118ce-cacd-49ac-9f55-caf2d42dadad"), null, new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(4391), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("abb7dadc-8390-485d-85f8-be01e90bd955"), null, new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(4405), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("f63a4e39-4a5c-45e5-95d5-dbf266adc41b"), null, new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(4401), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("fc723927-5c70-4e97-a6d2-bbbe357515b1"), null, new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(3266), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("1e242dd0-2988-47ef-b06f-0201dfed3242"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(7678), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("68eff3da-209b-4e43-8832-cae8b9e1c880"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(7689), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("779c1164-4076-43e7-b1fc-e3980575b1cf"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(7687), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("93cfbe30-3864-49ae-9d97-3c1342f5030e"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(7671), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("f8a229ba-1382-47ab-b8ce-acbe70974fa2"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(6202), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("52eb2e81-426b-4585-9344-d0fade047f45"), new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(8794), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("8b0b01d4-3a12-498a-8dbb-ec59d86e2be4"), new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(8780), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("8fe1281d-f4c9-45de-bd4a-0c20f4ce1543"), new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(8797), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "1WShZQnZ9stw/xJRITPECc8Sv64ZPv/QdBSemssp/afRd40LYg0Pnee2Ok38Mdxs");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "rIrP5mO9ND1bJUIzix7Otb4b/UtyaDFt3UmPIab/9DRM7EBnREI9ONfkIR7aGjHw");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_d3eb@example.com", "user_1_d3eb@example.com", "USER_1_D3EB@EXAMPLE.COM", "USER_1_D3EB", "yLPmvjyv8YmZafNsfQKI2QYbb+ZmpmkptsXCC7KjuInjiyr4W87d/UPd+ItyPeEC", "user_1_d3eb@example.com", "user_1_d3eb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_026c@example.com", "user_2_026c@example.com", "USER_2_026C@EXAMPLE.COM", "USER_2_026C", "MdaS7dMyZEKpTB8vath8o6OedK4LIMKH/gWWFu8jhOHj5R3c3qdnoPzsZUY2H3D+", "user_2_026c@example.com", "user_2_026c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_bb67@example.com", "user_3_bb67@example.com", "USER_3_BB67@EXAMPLE.COM", "USER_3_BB67", "APv5uclXw3AiXNj4AjYbIJWKXrJK9AZSQNNR1ivOWgaXRQtZV2mBBjcWzc9VOE/L", "user_3_bb67@example.com", "user_3_bb67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_1b90@example.com", "user_4_1b90@example.com", "USER_4_1B90@EXAMPLE.COM", "USER_4_1B90", "ej/+Aj2amur1pTDD/Koiho1Klt7fyijX8zGygdPYBnq9LjLKwXFbKVsizpb/Yelh", "user_4_1b90@example.com", "user_4_1b90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_718d@example.com", "user_5_718d@example.com", "USER_5_718D@EXAMPLE.COM", "USER_5_718D", "BDCQHTOphaLNrxUiyNRw62khygCXysg7X1Ur/QOUAdiBoGMjDJxtwnHhLadMEJl9", "user_5_718d@example.com", "user_5_718d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_62f4@example.com", "user_6_62f4@example.com", "USER_6_62F4@EXAMPLE.COM", "USER_6_62F4", "v5gjZHE6mCQn06sGrWKcWZLDRw/Aj1/YYDUB5od5qqVkGhNTVULDyvDPEoaR1ZkX", "user_6_62f4@example.com", "user_6_62f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_9ba4@example.com", "user_7_9ba4@example.com", "USER_7_9BA4@EXAMPLE.COM", "USER_7_9BA4", "cMEiPuOJ5Xhn0OHKKAy+v24xSgo295LMvy/Y1pOFOTJJZTi4jmT2rd26cSQLryji", "user_7_9ba4@example.com", "user_7_9ba4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_88f8@example.com", "user_8_88f8@example.com", "USER_8_88F8@EXAMPLE.COM", "USER_8_88F8", "0WinHzx1iIwU3orZqSTB19dH887QBowOn2ikOvQMXRR49nQUmqm4ak1DFEx3vHX1", "user_8_88f8@example.com", "user_8_88f8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_f52a@example.com", "user_9_f52a@example.com", "USER_9_F52A@EXAMPLE.COM", "USER_9_F52A", "IV9qmS6Q8K+Jd/F3jNCVHy3fqVtjTraX/qzyPyq4DBm846jcPWPmv7kB+iFFPbMi", "user_9_f52a@example.com", "user_9_f52a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_7c80@example.com", "user_10_7c80@example.com", "USER_10_7C80@EXAMPLE.COM", "USER_10_7C80", "/XluS8nXkIzTvQzyC6JYqLuZpubs9YpGpqeSiizE6bVdnGhT+KggToH99+xJpMXP", "user_10_7c80@example.com", "user_10_7c80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_a17e@example.com", "user_11_a17e@example.com", "USER_11_A17E@EXAMPLE.COM", "USER_11_A17E", "hFKNAtwcqMUTpFn7DcbiiSHmQRUiHkHuAgEYk291EFnG61oUc+c4EhxRI9H5/c1+", "user_11_a17e@example.com", "user_11_a17e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_606b@example.com", "user_12_606b@example.com", "USER_12_606B@EXAMPLE.COM", "USER_12_606B", "PMEVYXTyf+XJ55efK6eCq3zIyDz+lkh40PIARJUqxNAZJqzd3wDvkInI5iKrwevh", "user_12_606b@example.com", "user_12_606b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_2e6f@example.com", "user_13_2e6f@example.com", "USER_13_2E6F@EXAMPLE.COM", "USER_13_2E6F", "Of+czZdxCwSHcjno0+gWex1EkxF+e/lHikHm4GaRfK6hUiNTPCrFkXvYdg8CxBPm", "user_13_2e6f@example.com", "user_13_2e6f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_9d45@example.com", "user_14_9d45@example.com", "USER_14_9D45@EXAMPLE.COM", "USER_14_9D45", "kygnJTh3adic/4ja+ZpJGSWx/cpxDDtO5lqMmL+mo1Hoar4ZdjoVdEXylZelTu54", "user_14_9d45@example.com", "user_14_9d45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_4b03@example.com", "user_15_4b03@example.com", "USER_15_4B03@EXAMPLE.COM", "USER_15_4B03", "yqcLlRTQXn1cMA5yOxkf7zzY9hVWZ1ENgXOonTjzaeQS2+OZtVA+b0OppZeWEfMQ", "user_15_4b03@example.com", "user_15_4b03" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_40fc@example.com", "user_16_40fc@example.com", "USER_16_40FC@EXAMPLE.COM", "USER_16_40FC", "bJdnELcUrr/TNGo5/xr9kHPyKdMTA2uRDTmJezXmyU1YN2EkvjOfnbHfv8obmHcl", "user_16_40fc@example.com", "user_16_40fc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_b13b@example.com", "user_17_b13b@example.com", "USER_17_B13B@EXAMPLE.COM", "USER_17_B13B", "av/PBUEQ6SiwSZtB6zTJERtnHgq6AmlWNwnRpy0yEzE5bOrGeCD0XsB9jOWtrP9y", "user_17_b13b@example.com", "user_17_b13b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_2ef4@example.com", "user_18_2ef4@example.com", "USER_18_2EF4@EXAMPLE.COM", "USER_18_2EF4", "/XBuwTSkuaPxRWr8JWpaLTfRXtagMadD4JpKOX4Ro1s1RKwElo116CW27nQowGDD", "user_18_2ef4@example.com", "user_18_2ef4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_5e25@example.com", "user_19_5e25@example.com", "USER_19_5E25@EXAMPLE.COM", "USER_19_5E25", "TziUxf8d3tP6+UacldQvlLd38AogQn/pGroMocFPh+slkJBO8QFZTq1BXGZzV6pn", "user_19_5e25@example.com", "user_19_5e25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_62f7@example.com", "user_20_62f7@example.com", "USER_20_62F7@EXAMPLE.COM", "USER_20_62F7", "Je9RizBB8DoGTyKitFmwG6N2QAByH7bA1Nd7w+43uc1tTagEVhlwY6Rjj7vRrvyb", "user_20_62f7@example.com", "user_20_62f7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_d326@example.com", "user_21_d326@example.com", "USER_21_D326@EXAMPLE.COM", "USER_21_D326", "DBS/+OLVQSy2T2u8Ep+wkfdCGYM30gLMojMTZ8mJoQ9WghSjkoLOrUy4HXiMLPDA", "user_21_d326@example.com", "user_21_d326" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_864e@example.com", "user_22_864e@example.com", "USER_22_864E@EXAMPLE.COM", "USER_22_864E", "NsjjnWfAGKY0UemAteqG8jPrTF0KkhqyJiITpKBk9Ar0aBKfouJdae+WreEkC/o5", "user_22_864e@example.com", "user_22_864e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_e74d@example.com", "user_23_e74d@example.com", "USER_23_E74D@EXAMPLE.COM", "USER_23_E74D", "kqyjjESKBgux8j3fz5ulw/oeheDKasCCp7GvwTnRvD6QrBpEBn3uYDyjd/q01BI+", "user_23_e74d@example.com", "user_23_e74d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_6216@example.com", "user_24_6216@example.com", "USER_24_6216@EXAMPLE.COM", "USER_24_6216", "rIWl38bCZVWTBhpCHuO7O+tmwWyiqJy3UXvPqagl57N67j+l7ej0xsflqw8cumEU", "user_24_6216@example.com", "user_24_6216" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_b8cc@example.com", "user_25_b8cc@example.com", "USER_25_B8CC@EXAMPLE.COM", "USER_25_B8CC", "l18CuqY/S1DZB6rZ2zAgYqPEN7HeyXHf2+8JqmP+qOHO4oKen3JU5/rWflwy/qti", "user_25_b8cc@example.com", "user_25_b8cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_ed79@example.com", "user_26_ed79@example.com", "USER_26_ED79@EXAMPLE.COM", "USER_26_ED79", "uilSsvyAi+RlTk8jOYXbxlH3y1016scaWadmD9tEXkSpP8iKj5ncYi+pn/GzMk6A", "user_26_ed79@example.com", "user_26_ed79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_6448@example.com", "user_27_6448@example.com", "USER_27_6448@EXAMPLE.COM", "USER_27_6448", "sjezEUyiC+98sNX4sfb8ZrZ4CKtN8WPG/4QnaFQtbvza7yfkfkKgNF0yWF4crBG1", "user_27_6448@example.com", "user_27_6448" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_b8b4@example.com", "user_28_b8b4@example.com", "USER_28_B8B4@EXAMPLE.COM", "USER_28_B8B4", "KPMSx7acjQZVMBGl23gd+VnMzFXBZuGilN1qP4RYmLhQQrJzR8IbR0UKCTFbDMtB", "user_28_b8b4@example.com", "user_28_b8b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_92eb@example.com", "user_29_92eb@example.com", "USER_29_92EB@EXAMPLE.COM", "USER_29_92EB", "V/z3ETjAmrsba++JorzvlUePI5Zc33wdRlfmKqta0hNZaXD1nttxx4KmZP0D8dvT", "user_29_92eb@example.com", "user_29_92eb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_8391@example.com", "user_30_8391@example.com", "USER_30_8391@EXAMPLE.COM", "USER_30_8391", "YnL418eGNWy1pFnZ2HTb0QnYpfImqfUCXjKw8Cr8x70USqdjWgXJWPLfXzG5HWc9", "user_30_8391@example.com", "user_30_8391" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_754f@example.com", "user_31_754f@example.com", "USER_31_754F@EXAMPLE.COM", "USER_31_754F", "A1/P4zgtmN5pNzOGj7Jkq4YN4eEAqYV2oDMJzwoteKF1Dj7iBfmOs0DL6sLNyqu0", "user_31_754f@example.com", "user_31_754f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_6899@example.com", "user_32_6899@example.com", "USER_32_6899@EXAMPLE.COM", "USER_32_6899", "yVYJXmVMvvWXA+zN+sJDEVRBnKaP1Q9Hvfsaby+GpJZkcEz7M+kpxjdQEoh752Ce", "user_32_6899@example.com", "user_32_6899" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_612e@example.com", "user_33_612e@example.com", "USER_33_612E@EXAMPLE.COM", "USER_33_612E", "OM+2n+IwoQb8mfmwW/uFrA2+H2MA4znWnpdkUPXsKqDWDkZ7HJE9YjCXuTp+TcWm", "user_33_612e@example.com", "user_33_612e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_b6ce@example.com", "user_34_b6ce@example.com", "USER_34_B6CE@EXAMPLE.COM", "USER_34_B6CE", "kDwbk6Ll1NBdAo7zWidOOnIDoT1zn2eibJo0YuruC3HrpuyVrkwr87y2hiyI37HE", "user_34_b6ce@example.com", "user_34_b6ce" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_2e33@example.com", "user_35_2e33@example.com", "USER_35_2E33@EXAMPLE.COM", "USER_35_2E33", "XT1BlmsbRiCz86zzqVuZVrl67JwsGTEdmHqUYkv9K9+aKohRlq2+Q+OzwxqZSMb9", "user_35_2e33@example.com", "user_35_2e33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_0ee7@example.com", "user_36_0ee7@example.com", "USER_36_0EE7@EXAMPLE.COM", "USER_36_0EE7", "jEzWRqyFbl3a46VaeBuO9Zzv5ipijNCuZZyukOqXfl2Myl5AZ5Vn1PnLIITEPPNY", "user_36_0ee7@example.com", "user_36_0ee7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_39d3@example.com", "user_37_39d3@example.com", "USER_37_39D3@EXAMPLE.COM", "USER_37_39D3", "AdRbVXW7fbn+o+1RCR5c57/4QFZ9oXA2DV/7AhgO5+5JdYxavlNZ33Y2An8g9F9q", "user_37_39d3@example.com", "user_37_39d3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_8247@example.com", "user_38_8247@example.com", "USER_38_8247@EXAMPLE.COM", "USER_38_8247", "hF2Q+BqHqz6ReRGfMfIiPxfHL6V9uqh7aIZWExwkqZfzV82z+iLMJABxpK28A5wR", "user_38_8247@example.com", "user_38_8247" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_7fc9@example.com", "user_39_7fc9@example.com", "USER_39_7FC9@EXAMPLE.COM", "USER_39_7FC9", "C1lX5SGNExtY5B8U0Mxc7KfGlQBkaSNqLidY58zMya6qiCFQkUc08JWIYIDwRH9B", "user_39_7fc9@example.com", "user_39_7fc9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_32c0@example.com", "user_40_32c0@example.com", "USER_40_32C0@EXAMPLE.COM", "USER_40_32C0", "Qj1EVC41AeS2hWMc+4ydBD8vcuW9kHQJCf2D4QaIAq6eX8Yu+uCdHUT4m72QSrXa", "user_40_32c0@example.com", "user_40_32c0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_0924@example.com", "user_41_0924@example.com", "USER_41_0924@EXAMPLE.COM", "USER_41_0924", "ebwD2N4rOzegLfz/E9f2m0OIvkS9VRQ2GHdvxJksjxMpvjD5w/3/0z5LGjJTxj2K", "user_41_0924@example.com", "user_41_0924" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_f128@example.com", "user_42_f128@example.com", "USER_42_F128@EXAMPLE.COM", "USER_42_F128", "XmAqDZxMXw7mqxbnTSSgdVwB94sPkzSmuB4jhqnW5eDdAaEwLVL9Ex39TIDtvBvT", "user_42_f128@example.com", "user_42_f128" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_10e2@example.com", "user_43_10e2@example.com", "USER_43_10E2@EXAMPLE.COM", "USER_43_10E2", "nhOmgeU3BIe2iqxOQPeT5m74sAbpU0uei8fXdC8IozAuavUKSPk2UIsU9qfs/SAI", "user_43_10e2@example.com", "user_43_10e2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_9321@example.com", "user_44_9321@example.com", "USER_44_9321@EXAMPLE.COM", "USER_44_9321", "BRHG6dcdxLIANIQkROgnLkripOqHGTCbW64iPP3JkIhZSfs3i+SwcrhBX+WSCPqW", "user_44_9321@example.com", "user_44_9321" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_ceed@example.com", "user_45_ceed@example.com", "USER_45_CEED@EXAMPLE.COM", "USER_45_CEED", "wEdS964UYmBfVGCXi8wXh9K8dSBed5WMyLdqLctZTrgtxQQFqC3okaAptIA4U7V7", "user_45_ceed@example.com", "user_45_ceed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_84b2@example.com", "user_46_84b2@example.com", "USER_46_84B2@EXAMPLE.COM", "USER_46_84B2", "/M3emPcbrblx9Z/t37WxwJ/3AW1uscKchTawmz0SFwOz4GHdnZduV2LtwGibFas7", "user_46_84b2@example.com", "user_46_84b2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_7ffb@example.com", "user_47_7ffb@example.com", "USER_47_7FFB@EXAMPLE.COM", "USER_47_7FFB", "H9SJjeNkLvCmcjp6crgtLlQTTZJA8+xzzcSLlKtl7o5YidVSAJItHNOrf8Ji8Jo4", "user_47_7ffb@example.com", "user_47_7ffb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_7e72@example.com", "user_48_7e72@example.com", "USER_48_7E72@EXAMPLE.COM", "USER_48_7E72", "h4xUBohJ21Gg5filSGwP5YmUf9FVYOBzwGXdLleimdFhhAKBuKv0PmxlTNTHL1kw", "user_48_7e72@example.com", "user_48_7e72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_3c8e@example.com", "user_49_3c8e@example.com", "USER_49_3C8E@EXAMPLE.COM", "USER_49_3C8E", "cuyoZ3Yh8Mtn/SXKxDsL4h/9/eVgFTLkORtcrld39aoDm4HLEUf029eb7JT7sAGM", "user_49_3c8e@example.com", "user_49_3c8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_ce00@example.com", "user_50_ce00@example.com", "USER_50_CE00@EXAMPLE.COM", "USER_50_CE00", "/4AlCzi1C+ZOToqbeNNotqrAsr0D2mHJn9Kf8sLnBYwvTiHO7uaUvRSgD4SVMsD9", "user_50_ce00@example.com", "user_50_ce00" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "dgk64OinRYFYWE7J8BO9r9X7Ztoet36AAVKumisFmnVGbzQyeICAq3hbykvgv01p");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fd30469-a260-408d-b12c-ad5b4dcc4c99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4416080f-b075-4b72-b7a0-9d00a30bf28b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c24fbde-c8cf-46be-ae37-b8cef62181a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73c2795b-5ff4-48c8-aeb6-0c7dfdc394a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("755c4c3a-d6b6-49e1-9a88-d41997e93dc4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7761667e-f5da-4d8a-922e-6edde8a57922"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0d0f4f1-00ff-4884-abb6-7f630373e99d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad40d064-d94d-4181-8eb7-20a65ae7090f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb561671-80b3-45af-b821-328524fca94e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f82be211-d963-4345-a6a9-41911764be6a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b92f1bd1-65b8-4ac2-96b0-4b203d9d05ba"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c4603961-1c1d-4bb9-85e3-d270e7355fb7"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c6cb1892-35fb-4b8a-b986-f84a628b073f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("defb7812-ba6b-4422-8d49-35fb63ab1ed7"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("2f289fab-746e-49ab-a656-88fba8eb74b7"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("6fb08530-f03b-4214-bacf-1784e9b95fbe"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d7f1ba6a-1d47-49cf-9ed9-de0251f29a51"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("e699923b-a85c-4aa5-aed1-92b8f008a5f1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("1559f988-2183-4ad8-a3e0-bcedddb04bcc"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("26a6ef15-51ef-4ee5-95ea-5dd2d978ebe0"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3e6f0285-f526-4c0d-a3f1-6471f0e185eb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("8cb0063d-0f48-4d10-b6bc-89818edb7feb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ada9e2ec-87ff-4800-af43-d01d3910504b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f4e35ca4-930e-425a-a62b-b59300410ddd"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("7255e35e-ca20-44dd-ba22-36cb282cf850"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("01d51ca9-4ee1-49c8-bb50-5c8adac72c67"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("12e1f938-b239-4f1d-9573-710e0264a8fa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("140838c8-5068-4ed4-92e8-99db5112a72a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("28b57485-a1da-4c45-9f3d-174dd45c9e0a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1a0db22-e7d2-4004-bcfa-35c73274f92f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b246cf74-a6ad-44f1-bc5f-98cf82530985"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("128118ce-cacd-49ac-9f55-caf2d42dadad"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("abb7dadc-8390-485d-85f8-be01e90bd955"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f63a4e39-4a5c-45e5-95d5-dbf266adc41b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fc723927-5c70-4e97-a6d2-bbbe357515b1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("1e242dd0-2988-47ef-b06f-0201dfed3242"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("68eff3da-209b-4e43-8832-cae8b9e1c880"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("779c1164-4076-43e7-b1fc-e3980575b1cf"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("93cfbe30-3864-49ae-9d97-3c1342f5030e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f8a229ba-1382-47ab-b8ce-acbe70974fa2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("52eb2e81-426b-4585-9344-d0fade047f45"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8b0b01d4-3a12-498a-8dbb-ec59d86e2be4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8fe1281d-f4c9-45de-bd4a-0c20f4ce1543"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsLoggedIn",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldDefaultValue: false);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04e1db5c-cea8-4e76-83c7-677b3e32099e"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("13d70ed8-dd46-46fe-99e1-b9871081e52c"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("2e949d35-83bf-41f8-85c6-e9a6747a67c4"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("44e8b866-9ffe-4f06-b594-dac8e1811027"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("7b11d086-90bb-4367-846b-cfb864015231"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("7cd492c6-e788-46d2-908b-7ead9fcebdbf"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("9038ff90-b290-42f9-9e43-5988434ee8fa"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("b2fb8e8b-7686-4ce4-a84c-6b9ac9a4bfe6"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("c00b6594-2ba3-4c5b-b15c-ab1098cc4e39"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("c95c47c6-6be3-4dd3-b5e4-c39e20676f9e"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("025cd1b3-1b4c-44e8-b7f0-85dda33415b0"), "GBP", new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(3227), 2, true, "British Pound", "£", null },
                    { new Guid("36ccc6f8-216c-43dd-b8f5-6a76eebccde9"), "EUR", new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(1482), 2, true, "Euro", "€", null },
                    { new Guid("a92fe68a-cd1d-4cdf-ac23-066b417e4ca9"), "CHF", new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(3231), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("b4a32afe-e33e-4b2e-b65b-25b250624e7a"), "USD", new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(3218), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("03aae2f9-6474-4911-8033-79308ffd0994"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(9975), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("74396458-b0b9-4e80-9d7c-f6c6e25c49d5"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(9961), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("afd53535-29bf-4524-8e82-261039722a6b"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(8030), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("bbe459b6-2a42-4f82-a615-2b188fc96212"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(9980), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6d041bd2-a8f6-44ca-8cb3-bf4cc5be9e40"), new DateTime(2025, 3, 5, 12, 21, 20, 952, DateTimeKind.Utc).AddTicks(9927), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("872c3ce2-b353-4820-933d-2aa2b0d076ad"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(2338), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("db7b1a06-3dc7-41c6-8630-c6c6fffdd59f"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(2358), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("dc61eef6-59f1-4458-9ac5-6fc71849eb86"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(2353), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("ecf7f88d-ac91-40c6-b7a2-8f48723fd5a5"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(2331), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("f49f6bff-92fa-4319-bdd7-f25c3ff97231"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(2342), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("23fc22be-1347-4a18-b5bf-133dbb7c5580"), new DateTime(2025, 3, 5, 12, 21, 20, 953, DateTimeKind.Utc).AddTicks(3992), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("203efa20-ec83-416c-8c7c-e15db60b3376"), new DateTime(2025, 3, 5, 12, 21, 20, 952, DateTimeKind.Utc).AddTicks(8018), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("5c916406-a240-4bf7-b060-9246a2e2ed95"), new DateTime(2025, 3, 5, 12, 21, 20, 952, DateTimeKind.Utc).AddTicks(8047), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("a55c57c8-3483-4d7f-bec0-6d469b9e6bbc"), new DateTime(2025, 3, 5, 12, 21, 20, 952, DateTimeKind.Utc).AddTicks(8037), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("d8a359ac-1643-44b1-bed9-28e05753a181"), new DateTime(2025, 3, 5, 12, 21, 20, 952, DateTimeKind.Utc).AddTicks(8043), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("f02b99e7-b2ed-485c-8360-1658750d3ad5"), new DateTime(2025, 3, 5, 12, 21, 20, 952, DateTimeKind.Utc).AddTicks(6049), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("fb6235ea-c95f-4995-b3e1-e51b144f7987"), new DateTime(2025, 3, 5, 12, 21, 20, 952, DateTimeKind.Utc).AddTicks(8052), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0c2e195b-1b62-4623-9c14-fa82eccf8dbf"), null, new DateTime(2025, 3, 5, 12, 21, 20, 955, DateTimeKind.Utc).AddTicks(5849), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("43416a93-2167-4354-9cc4-bbf72f34ea28"), null, new DateTime(2025, 3, 5, 12, 21, 20, 955, DateTimeKind.Utc).AddTicks(4575), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("75dfe181-65f9-4a1e-8bcc-ddfc8d0db817"), null, new DateTime(2025, 3, 5, 12, 21, 20, 955, DateTimeKind.Utc).AddTicks(5843), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("97426829-0bdb-455c-a1af-435318d4f660"), null, new DateTime(2025, 3, 5, 12, 21, 20, 955, DateTimeKind.Utc).AddTicks(5854), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("3179aad1-c782-4fd0-9cb4-f10fc79c5360"), new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(6783), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("406c64f6-5439-407b-971a-c028897f2974"), new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(6797), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("579147fc-2f60-46dd-802d-1bcc30c66324"), new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(6800), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("a352502c-19d8-4b9e-8527-05828a70bb84"), new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(4531), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("c1e54dc8-d803-4f56-b645-4e4c2a3a4eb1"), new DateTime(2025, 3, 5, 12, 21, 20, 954, DateTimeKind.Utc).AddTicks(6793), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 12, 21, 20, 955, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0802724c-918b-44b0-a3b1-a37e40307d40"), new DateTime(2025, 3, 5, 12, 21, 20, 956, DateTimeKind.Utc).AddTicks(1505), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("a759b72a-bb37-449c-869b-5629502b1726"), new DateTime(2025, 3, 5, 12, 21, 20, 956, DateTimeKind.Utc).AddTicks(1510), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("ceea4503-d173-48aa-819a-19439e1a8cc6"), new DateTime(2025, 3, 5, 12, 21, 20, 956, DateTimeKind.Utc).AddTicks(1496), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "EjyQZaD4xfWePoQcDJz8/86p7s8PoDJvGr4bmpmpsrkQJur0OrNcFwRcoz1Yu9WV");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "xWJrziqhQlHM3vLzx0tQJ+2Svj6G7JOYJPeyRILsAzwvAIlfYEZfjVkXIkcTEo2d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_d958@example.com", "user_1_d958@example.com", "USER_1_D958@EXAMPLE.COM", "USER_1_D958", "6TvORFsLaSBq8BH45KySJqbNyd+YuzPYt/mfzKpfUD0eNjyyJOh1oWZznOVaGYfv", "user_1_d958@example.com", "user_1_d958" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_132a@example.com", "user_2_132a@example.com", "USER_2_132A@EXAMPLE.COM", "USER_2_132A", "yKRVt4zfxhSozDISxxNEIse9W9YP8vpwJrMV3mFYua6zBT9DoeS+7vk9De6mmvZy", "user_2_132a@example.com", "user_2_132a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_12c0@example.com", "user_3_12c0@example.com", "USER_3_12C0@EXAMPLE.COM", "USER_3_12C0", "/o7MToGCgPXaT1rqy4hiotykChFo+ESeKPM+cTW6t00wDRdYvOpfF6eqwywpYnOb", "user_3_12c0@example.com", "user_3_12c0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_76c1@example.com", "user_4_76c1@example.com", "USER_4_76C1@EXAMPLE.COM", "USER_4_76C1", "KjHflMytHwC4q2ZcEsW/W+N7v+sPVdBjcNwaatiUl+L7hdjEpaxzmYOHB9ms7JW9", "user_4_76c1@example.com", "user_4_76c1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_842a@example.com", "user_5_842a@example.com", "USER_5_842A@EXAMPLE.COM", "USER_5_842A", "pUCGF58VzSKvMN3Gphe6hWjBHAUwx2zMfBikiJo9/K+W1OOlrtp6SQeQWqb6nnaD", "user_5_842a@example.com", "user_5_842a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_38b3@example.com", "user_6_38b3@example.com", "USER_6_38B3@EXAMPLE.COM", "USER_6_38B3", "TKkoeiph53LFDZEBWyBWqoHvo+qXg3k9d8bwNVMQs6JxziqwrONyKX1iBdBS5sHK", "user_6_38b3@example.com", "user_6_38b3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_a81b@example.com", "user_7_a81b@example.com", "USER_7_A81B@EXAMPLE.COM", "USER_7_A81B", "nkv+yV7Y3cw+gWTCDt2/qo0ft5nO0Sl/y8m/cFGoV8CRdRzMRed0PSzwjmYhrSo3", "user_7_a81b@example.com", "user_7_a81b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_faff@example.com", "user_8_faff@example.com", "USER_8_FAFF@EXAMPLE.COM", "USER_8_FAFF", "shJZLWoO3TUXXZO2h8muwOmfhue5JUAf3cT5MZjYB2kc7owc7ch2kcPlVUgXZJIL", "user_8_faff@example.com", "user_8_faff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_5066@example.com", "user_9_5066@example.com", "USER_9_5066@EXAMPLE.COM", "USER_9_5066", "5ynoa761JP/Z3U5t0r4hthDtacG24gF5qSLDQk4LERDp6Za80LjqUdtkjx2dCCTB", "user_9_5066@example.com", "user_9_5066" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_b422@example.com", "user_10_b422@example.com", "USER_10_B422@EXAMPLE.COM", "USER_10_B422", "sDbAOlcAOdkJQX8/TufhJrCCk5xraixmZrchveK/fj7PaN2NhsVZjLB7HqnrY3zW", "user_10_b422@example.com", "user_10_b422" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_ccdb@example.com", "user_11_ccdb@example.com", "USER_11_CCDB@EXAMPLE.COM", "USER_11_CCDB", "cDuAJmEZaGUsNZ22aLvOIYHurGkYOccc52daSwWJYib0XYlgzdSu9W1Zo0pFoc/s", "user_11_ccdb@example.com", "user_11_ccdb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_b26e@example.com", "user_12_b26e@example.com", "USER_12_B26E@EXAMPLE.COM", "USER_12_B26E", "wm8//XPIh6C1eTgJwqyp8S+kCX6fOS7XpyltASFasvXxN1IjH0e3RjJnWT+fbZIr", "user_12_b26e@example.com", "user_12_b26e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_47df@example.com", "user_13_47df@example.com", "USER_13_47DF@EXAMPLE.COM", "USER_13_47DF", "nFgU5NcOJdmBaMYfGjmZkjd/AiB2kzYFt5i8h6ceyXNJggJgp02rM9SviQDIt7Zi", "user_13_47df@example.com", "user_13_47df" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_88c4@example.com", "user_14_88c4@example.com", "USER_14_88C4@EXAMPLE.COM", "USER_14_88C4", "80HBM3fezuNUgikHn/LL3/UP2Rycd0hqSx5uFOH/lEvvY9A0WwL1jZ8luIEtDWr6", "user_14_88c4@example.com", "user_14_88c4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_9e93@example.com", "user_15_9e93@example.com", "USER_15_9E93@EXAMPLE.COM", "USER_15_9E93", "w2baZ9b1azKav/GKxSefrQ9AvtkuCwRoAHw5quJ1i5OBM/aYPeY2ANi2aPdOCfXW", "user_15_9e93@example.com", "user_15_9e93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_9ac0@example.com", "user_16_9ac0@example.com", "USER_16_9AC0@EXAMPLE.COM", "USER_16_9AC0", "Hx5RwTNkeHSRYNgx634BKKAp0q1zkb0sm1mjB6G0RjBIprKkRHG0FKrcfN2YfB1h", "user_16_9ac0@example.com", "user_16_9ac0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_40b9@example.com", "user_17_40b9@example.com", "USER_17_40B9@EXAMPLE.COM", "USER_17_40B9", "ZGKqaXoRDRRTphMhMTaxbNOTeTQvTBYN/GQfoQ2hXm44pzs7KXf7FghkRdpl+Ehh", "user_17_40b9@example.com", "user_17_40b9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_dcfb@example.com", "user_18_dcfb@example.com", "USER_18_DCFB@EXAMPLE.COM", "USER_18_DCFB", "L6FnRL1AQBmcuAlMiRHrAth9jp8W5XGx2Udr4Co5kE20IBzoZy+nZXWphzx5M0yV", "user_18_dcfb@example.com", "user_18_dcfb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_afa7@example.com", "user_19_afa7@example.com", "USER_19_AFA7@EXAMPLE.COM", "USER_19_AFA7", "CxPMzm/8WGqojzGYDXM+CeQdPnLwzMBtPQpDpd0McsmZuH9+oWcWn6ktrN9JqgF/", "user_19_afa7@example.com", "user_19_afa7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_4f30@example.com", "user_20_4f30@example.com", "USER_20_4F30@EXAMPLE.COM", "USER_20_4F30", "FEc6e+6bfSUmeE7J1Nq2v8mQobLGRSvyfZ3Io19Hjm9wvCFNfD/GMyS0I5AxF3mM", "user_20_4f30@example.com", "user_20_4f30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_1bcd@example.com", "user_21_1bcd@example.com", "USER_21_1BCD@EXAMPLE.COM", "USER_21_1BCD", "vQHlrhfoFrB4edZ7zMFgoTuUuvfKfyQ8X4wSL+5agzBlFmG21Ag71up8Dqlj3V6T", "user_21_1bcd@example.com", "user_21_1bcd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_9d67@example.com", "user_22_9d67@example.com", "USER_22_9D67@EXAMPLE.COM", "USER_22_9D67", "8xLaWriHhicfhStBoeVNLUaXUi+57fUWytSxUTDLV/hAmeob22XXWKxi8h421ZIt", "user_22_9d67@example.com", "user_22_9d67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_6120@example.com", "user_23_6120@example.com", "USER_23_6120@EXAMPLE.COM", "USER_23_6120", "N9MKvmqnJPYv35kVNDacYbAdEzg1s1GbBEg88e7L5D13FaLjAOKvvsxrHsusl0JJ", "user_23_6120@example.com", "user_23_6120" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_4c25@example.com", "user_24_4c25@example.com", "USER_24_4C25@EXAMPLE.COM", "USER_24_4C25", "k4/jH9qVx4WEVrYriV4jQIOgCeCplGPHY0GhuHITwGqQg5ICKMwcdkQzTlPYdAlX", "user_24_4c25@example.com", "user_24_4c25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_d164@example.com", "user_25_d164@example.com", "USER_25_D164@EXAMPLE.COM", "USER_25_D164", "wEAzVP/m+YfXWlhfiYMve/aECmlwvvd5YQr8kEwmaIpFwAMnqjX119F4vv3vjJYu", "user_25_d164@example.com", "user_25_d164" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_7cdd@example.com", "user_26_7cdd@example.com", "USER_26_7CDD@EXAMPLE.COM", "USER_26_7CDD", "2iAkqv6Vy5Nd2/DVTBqqOk9c22xcRfn6G+wh60AOygG1rzHqPINOSpH2uziSP0oA", "user_26_7cdd@example.com", "user_26_7cdd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_4688@example.com", "user_27_4688@example.com", "USER_27_4688@EXAMPLE.COM", "USER_27_4688", "k7Gh9XQsTGMVD1vcmhR2rnuMzjF6ExD54wM47fLlliB+K3/kqaDNz6uPOC8MSz3V", "user_27_4688@example.com", "user_27_4688" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_eee7@example.com", "user_28_eee7@example.com", "USER_28_EEE7@EXAMPLE.COM", "USER_28_EEE7", "2GdBwqneWDvJKmx+JG4QjTIpXOqPWgObyKksShCbYTzl4oz3f9MRZVjezmB/iqrY", "user_28_eee7@example.com", "user_28_eee7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_3b8e@example.com", "user_29_3b8e@example.com", "USER_29_3B8E@EXAMPLE.COM", "USER_29_3B8E", "U82mYp251q0WiOEPQ18r73r35ikNpD6Nsk0bNnJZwAeEsqR8nUOstT1nmjWAJGcI", "user_29_3b8e@example.com", "user_29_3b8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_25b9@example.com", "user_30_25b9@example.com", "USER_30_25B9@EXAMPLE.COM", "USER_30_25B9", "TVq5g05jhNfJeiBz5/lV07d7F+x4wofuoTFxmffIaJnRgTcgpuM4wWA3quBuwahg", "user_30_25b9@example.com", "user_30_25b9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_a522@example.com", "user_31_a522@example.com", "USER_31_A522@EXAMPLE.COM", "USER_31_A522", "+5YxeFhI2E/k8kTRfhEbzZul3Noa9dRUO9vdPRGY61Ieb7oACZmPhipjFKuU6/HN", "user_31_a522@example.com", "user_31_a522" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_14d0@example.com", "user_32_14d0@example.com", "USER_32_14D0@EXAMPLE.COM", "USER_32_14D0", "iZtMxHSj7cPho0fOX3hedgmMrLkS35a0OZ/qIdFZ3JPMEnTWEpx8I4qdT7T5GmyC", "user_32_14d0@example.com", "user_32_14d0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_960e@example.com", "user_33_960e@example.com", "USER_33_960E@EXAMPLE.COM", "USER_33_960E", "sfFS2osevMBE2wLAv8LM4BqQXjYTrCX39zJf9AI8Xgxc+sxVaZBAIDtcCdszJllV", "user_33_960e@example.com", "user_33_960e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_5a05@example.com", "user_34_5a05@example.com", "USER_34_5A05@EXAMPLE.COM", "USER_34_5A05", "JhUesarVkPhkHzS4VeI4nGxEKdduUtSG23HOY1E6TaEMuT28vCAiYn8SOUAxGG5L", "user_34_5a05@example.com", "user_34_5a05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_5913@example.com", "user_35_5913@example.com", "USER_35_5913@EXAMPLE.COM", "USER_35_5913", "db2xeo6b1mcJsr+L4m45X+ixpX1ZFQ7fRqBZ0zMB0EZ3qXEyPGLMmm657i9wLVOL", "user_35_5913@example.com", "user_35_5913" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_4ce9@example.com", "user_36_4ce9@example.com", "USER_36_4CE9@EXAMPLE.COM", "USER_36_4CE9", "RsJEUjTSZdHNlofho+Ji7A7ACHLZ+3pzSkBFH6EXEEumPplwsylmfvL4KR3AUqRp", "user_36_4ce9@example.com", "user_36_4ce9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_3222@example.com", "user_37_3222@example.com", "USER_37_3222@EXAMPLE.COM", "USER_37_3222", "94Iam5KRnwiTWrA9nnOvcGYz2KPY60BHt2C+EN77JaMCh4PLnjlMBBRAEP+92hbq", "user_37_3222@example.com", "user_37_3222" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_4139@example.com", "user_38_4139@example.com", "USER_38_4139@EXAMPLE.COM", "USER_38_4139", "neyizr7/t9lMzksxwtjag+G0awIoAoHkAR+UFARNbIyQvyWdL3H6m9zfCOUl6mWF", "user_38_4139@example.com", "user_38_4139" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_8ea4@example.com", "user_39_8ea4@example.com", "USER_39_8EA4@EXAMPLE.COM", "USER_39_8EA4", "NoGoD/yFpS03UW15LYfnEwKWdg8Np54CpBd93+bmJxod4NsVOs/4ZYBgaER19BAa", "user_39_8ea4@example.com", "user_39_8ea4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_0d27@example.com", "user_40_0d27@example.com", "USER_40_0D27@EXAMPLE.COM", "USER_40_0D27", "edWKWxYFyt3koV1zCfMlq5Eb0mX71m99g2duwmYX7nq7o23QwAhHRSJ0LIzXcp6T", "user_40_0d27@example.com", "user_40_0d27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_50a3@example.com", "user_41_50a3@example.com", "USER_41_50A3@EXAMPLE.COM", "USER_41_50A3", "hEVCPiO0Xj+p8AUkXKuv/3zORZwy62yBt9fzVwaHwyNzgl+V1gINin//7gf62B4N", "user_41_50a3@example.com", "user_41_50a3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_57d1@example.com", "user_42_57d1@example.com", "USER_42_57D1@EXAMPLE.COM", "USER_42_57D1", "kSaIn4AsK39PMh23xF8C+R0bZf7VOoQodO7qURSAvzuhxIXpVYBmc8uzeW0Big8+", "user_42_57d1@example.com", "user_42_57d1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_bcff@example.com", "user_43_bcff@example.com", "USER_43_BCFF@EXAMPLE.COM", "USER_43_BCFF", "xo8d8V5MBwOKFZm6dq4wLtPk1Kn3OZnjj6pUqN5OQvtr58VBfMWmhtFuiRg/G9XO", "user_43_bcff@example.com", "user_43_bcff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_02cf@example.com", "user_44_02cf@example.com", "USER_44_02CF@EXAMPLE.COM", "USER_44_02CF", "xOM35WqcwCyF7KgfzuEcfQuSuWmbIGibPgmn3wwzvPgdkgLvmbdGmV+Q0MHNt44Q", "user_44_02cf@example.com", "user_44_02cf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_9055@example.com", "user_45_9055@example.com", "USER_45_9055@EXAMPLE.COM", "USER_45_9055", "CrlKKTnZPaUHFKiCEiH12P/fSfpXVLsbpvX7yR228ewSqNEgCQUOwDyvrv5ptday", "user_45_9055@example.com", "user_45_9055" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_7b22@example.com", "user_46_7b22@example.com", "USER_46_7B22@EXAMPLE.COM", "USER_46_7B22", "xRxR0hojkF0NHi2GlBBrhQu+WQKJYApEgKOnB7lJ1r63jNNmCukCbIgKAx11MmU0", "user_46_7b22@example.com", "user_46_7b22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_f85e@example.com", "user_47_f85e@example.com", "USER_47_F85E@EXAMPLE.COM", "USER_47_F85E", "2elNfJh0rIavuP8RYujI7yjrHupxUvD5HwDmVnJcmRIXXp1IO3v8WLU1DHQ3rl49", "user_47_f85e@example.com", "user_47_f85e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_42a9@example.com", "user_48_42a9@example.com", "USER_48_42A9@EXAMPLE.COM", "USER_48_42A9", "iXmI9ZEAU6Eh30UTap+xg5La5oKL5bdQofjOc4ap4+cE+pBydsRDo0wC/CKWr5Gr", "user_48_42a9@example.com", "user_48_42a9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_18f1@example.com", "user_49_18f1@example.com", "USER_49_18F1@EXAMPLE.COM", "USER_49_18F1", "Ec57BeDnSoN99bMKeQX0hjeY7OtEAeLeJIGenSutJfjdwWr6nlq/RTym4AtzuAWU", "user_49_18f1@example.com", "user_49_18f1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_1fc8@example.com", "user_50_1fc8@example.com", "USER_50_1FC8@EXAMPLE.COM", "USER_50_1FC8", "yzhSI3CavXdzt2Ocxwqg4vpnOAdpWLcZ6+fs/x4iMv+x+w9tl1XogHN0KmQW9bdu", "user_50_1fc8@example.com", "user_50_1fc8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "zudIu8WdFPOfFXQQsqOhEhOTlmp5+MMJO0OC+pCIl8GbIwRwn3+O9QoK3KvdbBgu");
        }
    }
}
