using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ColumnIsLoggedInAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("011253c8-cfce-4750-b3d5-3e797827b04c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0aa6454b-b170-4ef3-9955-074552a091a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31a9eecb-74ec-4025-be74-3b1047015a9b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("358c142e-f64e-4710-b04f-7bd007938dba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6449babe-9203-41dc-82ae-8d18d309c860"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("68cffb7f-f817-4483-9afb-131d7f170220"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ad1314a-629d-44f6-8bb8-503ea7623a93"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1315eed-4fb4-4592-af8b-be0edaf70a68"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2fab4ba-6694-4737-852a-7510607d65a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca629a9b-541b-4e62-bf14-4eeaa940f93b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("050d0499-3795-41b4-87a9-9fa6577ee5f4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("678ef4ca-43f8-444e-9678-32da5e99048a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("84f74f9b-5f0f-4a52-b9ca-6436f389472d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c6b6339c-1cf0-4e33-9a9e-ef6311eac7a9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("4e3c6cde-06f5-4c7a-9ce9-19e36ec207eb"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("548bc3de-c579-4d46-b364-af245e7e9aef"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("713e7ac2-66a3-4889-a410-0f92fcb00fc0"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("e1e83529-63ff-4b3b-b04b-cccd7f894376"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("05b4fc28-386d-40f5-a132-094bc595fdf0"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5dcc69cc-166b-4b6a-8bec-cb6808d7dbc3"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("65684e84-040b-48ff-846e-922f44061a45"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("68d7e228-925e-4171-824c-56b011ec5374"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a8cf6a52-c1ad-4634-99d3-35436c71a7da"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("def9c465-a8fc-4675-816f-51160b78ac58"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("04628364-2237-4b7c-9e8a-3d0276aae865"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("404261da-076d-405e-bc64-e1055d951968"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("60b334cd-6d23-401a-985c-da15e5775633"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9c32452d-e161-4af7-80fd-e6a32bf9f206"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a7b8462a-6e51-4d1c-bb26-f4d29fde880b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b2d0cc30-e83b-46a7-a08d-3d5b2c7fe87e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc9f631f-3887-4546-9017-b5b35863d006"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("05e534fd-00d7-418c-8102-dd2c49362caf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("157a0609-1869-4a68-aef3-cb80683c7e14"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3bf231c7-a949-41ca-8bf3-2e568eabfad7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("58a5301a-e352-4c03-87d1-81e885c4bbcb"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("2ebe7412-55ac-4764-b1e0-76ba82adf2b8"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("8c45398a-1fd3-43a2-9c6f-797f4122f505"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9b6782e6-c5f1-4cca-b05b-9459bb738b26"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("d597cf52-2d8c-44a9-bb31-eae48cdf0378"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("e7fdc66b-b37d-46e8-9fd6-a58f5b01bde3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("42e02350-61f8-4a32-bc80-3a09b23f179b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("868ab308-b684-46ef-9d10-13fd66621269"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b5f21e17-e9bc-430a-81de-d326ab6b557c"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "PhoneNumber",
                keyValue: null,
                column: "PhoneNumber",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsLoggedIn",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiration",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "IsLoggedIn", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "Token" },
                values: new object[] { false, "EjyQZaD4xfWePoQcDJz8/86p7s8PoDJvGr4bmpmpsrkQJur0OrNcFwRcoz1Yu9WV", null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "IsLoggedIn", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "Token" },
                values: new object[] { false, "xWJrziqhQlHM3vLzx0tQJ+2Svj6G7JOYJPeyRILsAzwvAIlfYEZfjVkXIkcTEo2d", null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_1_d958@example.com", "user_1_d958@example.com", false, "USER_1_D958@EXAMPLE.COM", "USER_1_D958", "6TvORFsLaSBq8BH45KySJqbNyd+YuzPYt/mfzKpfUD0eNjyyJOh1oWZznOVaGYfv", null, null, "user_1_d958@example.com", null, "user_1_d958" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_2_132a@example.com", "user_2_132a@example.com", false, "USER_2_132A@EXAMPLE.COM", "USER_2_132A", "yKRVt4zfxhSozDISxxNEIse9W9YP8vpwJrMV3mFYua6zBT9DoeS+7vk9De6mmvZy", null, null, "user_2_132a@example.com", null, "user_2_132a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_3_12c0@example.com", "user_3_12c0@example.com", false, "USER_3_12C0@EXAMPLE.COM", "USER_3_12C0", "/o7MToGCgPXaT1rqy4hiotykChFo+ESeKPM+cTW6t00wDRdYvOpfF6eqwywpYnOb", null, null, "user_3_12c0@example.com", null, "user_3_12c0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_4_76c1@example.com", "user_4_76c1@example.com", false, "USER_4_76C1@EXAMPLE.COM", "USER_4_76C1", "KjHflMytHwC4q2ZcEsW/W+N7v+sPVdBjcNwaatiUl+L7hdjEpaxzmYOHB9ms7JW9", null, null, "user_4_76c1@example.com", null, "user_4_76c1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_5_842a@example.com", "user_5_842a@example.com", false, "USER_5_842A@EXAMPLE.COM", "USER_5_842A", "pUCGF58VzSKvMN3Gphe6hWjBHAUwx2zMfBikiJo9/K+W1OOlrtp6SQeQWqb6nnaD", null, null, "user_5_842a@example.com", null, "user_5_842a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_6_38b3@example.com", "user_6_38b3@example.com", false, "USER_6_38B3@EXAMPLE.COM", "USER_6_38B3", "TKkoeiph53LFDZEBWyBWqoHvo+qXg3k9d8bwNVMQs6JxziqwrONyKX1iBdBS5sHK", null, null, "user_6_38b3@example.com", null, "user_6_38b3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_7_a81b@example.com", "user_7_a81b@example.com", false, "USER_7_A81B@EXAMPLE.COM", "USER_7_A81B", "nkv+yV7Y3cw+gWTCDt2/qo0ft5nO0Sl/y8m/cFGoV8CRdRzMRed0PSzwjmYhrSo3", null, null, "user_7_a81b@example.com", null, "user_7_a81b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_8_faff@example.com", "user_8_faff@example.com", false, "USER_8_FAFF@EXAMPLE.COM", "USER_8_FAFF", "shJZLWoO3TUXXZO2h8muwOmfhue5JUAf3cT5MZjYB2kc7owc7ch2kcPlVUgXZJIL", null, null, "user_8_faff@example.com", null, "user_8_faff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_9_5066@example.com", "user_9_5066@example.com", false, "USER_9_5066@EXAMPLE.COM", "USER_9_5066", "5ynoa761JP/Z3U5t0r4hthDtacG24gF5qSLDQk4LERDp6Za80LjqUdtkjx2dCCTB", null, null, "user_9_5066@example.com", null, "user_9_5066" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_10_b422@example.com", "user_10_b422@example.com", false, "USER_10_B422@EXAMPLE.COM", "USER_10_B422", "sDbAOlcAOdkJQX8/TufhJrCCk5xraixmZrchveK/fj7PaN2NhsVZjLB7HqnrY3zW", null, null, "user_10_b422@example.com", null, "user_10_b422" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_11_ccdb@example.com", "user_11_ccdb@example.com", false, "USER_11_CCDB@EXAMPLE.COM", "USER_11_CCDB", "cDuAJmEZaGUsNZ22aLvOIYHurGkYOccc52daSwWJYib0XYlgzdSu9W1Zo0pFoc/s", null, null, "user_11_ccdb@example.com", null, "user_11_ccdb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_12_b26e@example.com", "user_12_b26e@example.com", false, "USER_12_B26E@EXAMPLE.COM", "USER_12_B26E", "wm8//XPIh6C1eTgJwqyp8S+kCX6fOS7XpyltASFasvXxN1IjH0e3RjJnWT+fbZIr", null, null, "user_12_b26e@example.com", null, "user_12_b26e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_13_47df@example.com", "user_13_47df@example.com", false, "USER_13_47DF@EXAMPLE.COM", "USER_13_47DF", "nFgU5NcOJdmBaMYfGjmZkjd/AiB2kzYFt5i8h6ceyXNJggJgp02rM9SviQDIt7Zi", null, null, "user_13_47df@example.com", null, "user_13_47df" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_14_88c4@example.com", "user_14_88c4@example.com", false, "USER_14_88C4@EXAMPLE.COM", "USER_14_88C4", "80HBM3fezuNUgikHn/LL3/UP2Rycd0hqSx5uFOH/lEvvY9A0WwL1jZ8luIEtDWr6", null, null, "user_14_88c4@example.com", null, "user_14_88c4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_15_9e93@example.com", "user_15_9e93@example.com", false, "USER_15_9E93@EXAMPLE.COM", "USER_15_9E93", "w2baZ9b1azKav/GKxSefrQ9AvtkuCwRoAHw5quJ1i5OBM/aYPeY2ANi2aPdOCfXW", null, null, "user_15_9e93@example.com", null, "user_15_9e93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_16_9ac0@example.com", "user_16_9ac0@example.com", false, "USER_16_9AC0@EXAMPLE.COM", "USER_16_9AC0", "Hx5RwTNkeHSRYNgx634BKKAp0q1zkb0sm1mjB6G0RjBIprKkRHG0FKrcfN2YfB1h", null, null, "user_16_9ac0@example.com", null, "user_16_9ac0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_17_40b9@example.com", "user_17_40b9@example.com", false, "USER_17_40B9@EXAMPLE.COM", "USER_17_40B9", "ZGKqaXoRDRRTphMhMTaxbNOTeTQvTBYN/GQfoQ2hXm44pzs7KXf7FghkRdpl+Ehh", null, null, "user_17_40b9@example.com", null, "user_17_40b9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_18_dcfb@example.com", "user_18_dcfb@example.com", false, "USER_18_DCFB@EXAMPLE.COM", "USER_18_DCFB", "L6FnRL1AQBmcuAlMiRHrAth9jp8W5XGx2Udr4Co5kE20IBzoZy+nZXWphzx5M0yV", null, null, "user_18_dcfb@example.com", null, "user_18_dcfb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_19_afa7@example.com", "user_19_afa7@example.com", false, "USER_19_AFA7@EXAMPLE.COM", "USER_19_AFA7", "CxPMzm/8WGqojzGYDXM+CeQdPnLwzMBtPQpDpd0McsmZuH9+oWcWn6ktrN9JqgF/", null, null, "user_19_afa7@example.com", null, "user_19_afa7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_20_4f30@example.com", "user_20_4f30@example.com", false, "USER_20_4F30@EXAMPLE.COM", "USER_20_4F30", "FEc6e+6bfSUmeE7J1Nq2v8mQobLGRSvyfZ3Io19Hjm9wvCFNfD/GMyS0I5AxF3mM", null, null, "user_20_4f30@example.com", null, "user_20_4f30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_21_1bcd@example.com", "user_21_1bcd@example.com", false, "USER_21_1BCD@EXAMPLE.COM", "USER_21_1BCD", "vQHlrhfoFrB4edZ7zMFgoTuUuvfKfyQ8X4wSL+5agzBlFmG21Ag71up8Dqlj3V6T", null, null, "user_21_1bcd@example.com", null, "user_21_1bcd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_22_9d67@example.com", "user_22_9d67@example.com", false, "USER_22_9D67@EXAMPLE.COM", "USER_22_9D67", "8xLaWriHhicfhStBoeVNLUaXUi+57fUWytSxUTDLV/hAmeob22XXWKxi8h421ZIt", null, null, "user_22_9d67@example.com", null, "user_22_9d67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_23_6120@example.com", "user_23_6120@example.com", false, "USER_23_6120@EXAMPLE.COM", "USER_23_6120", "N9MKvmqnJPYv35kVNDacYbAdEzg1s1GbBEg88e7L5D13FaLjAOKvvsxrHsusl0JJ", null, null, "user_23_6120@example.com", null, "user_23_6120" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_24_4c25@example.com", "user_24_4c25@example.com", false, "USER_24_4C25@EXAMPLE.COM", "USER_24_4C25", "k4/jH9qVx4WEVrYriV4jQIOgCeCplGPHY0GhuHITwGqQg5ICKMwcdkQzTlPYdAlX", null, null, "user_24_4c25@example.com", null, "user_24_4c25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_25_d164@example.com", "user_25_d164@example.com", false, "USER_25_D164@EXAMPLE.COM", "USER_25_D164", "wEAzVP/m+YfXWlhfiYMve/aECmlwvvd5YQr8kEwmaIpFwAMnqjX119F4vv3vjJYu", null, null, "user_25_d164@example.com", null, "user_25_d164" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_26_7cdd@example.com", "user_26_7cdd@example.com", false, "USER_26_7CDD@EXAMPLE.COM", "USER_26_7CDD", "2iAkqv6Vy5Nd2/DVTBqqOk9c22xcRfn6G+wh60AOygG1rzHqPINOSpH2uziSP0oA", null, null, "user_26_7cdd@example.com", null, "user_26_7cdd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_27_4688@example.com", "user_27_4688@example.com", false, "USER_27_4688@EXAMPLE.COM", "USER_27_4688", "k7Gh9XQsTGMVD1vcmhR2rnuMzjF6ExD54wM47fLlliB+K3/kqaDNz6uPOC8MSz3V", null, null, "user_27_4688@example.com", null, "user_27_4688" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_28_eee7@example.com", "user_28_eee7@example.com", false, "USER_28_EEE7@EXAMPLE.COM", "USER_28_EEE7", "2GdBwqneWDvJKmx+JG4QjTIpXOqPWgObyKksShCbYTzl4oz3f9MRZVjezmB/iqrY", null, null, "user_28_eee7@example.com", null, "user_28_eee7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_29_3b8e@example.com", "user_29_3b8e@example.com", false, "USER_29_3B8E@EXAMPLE.COM", "USER_29_3B8E", "U82mYp251q0WiOEPQ18r73r35ikNpD6Nsk0bNnJZwAeEsqR8nUOstT1nmjWAJGcI", null, null, "user_29_3b8e@example.com", null, "user_29_3b8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_30_25b9@example.com", "user_30_25b9@example.com", false, "USER_30_25B9@EXAMPLE.COM", "USER_30_25B9", "TVq5g05jhNfJeiBz5/lV07d7F+x4wofuoTFxmffIaJnRgTcgpuM4wWA3quBuwahg", null, null, "user_30_25b9@example.com", null, "user_30_25b9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_31_a522@example.com", "user_31_a522@example.com", false, "USER_31_A522@EXAMPLE.COM", "USER_31_A522", "+5YxeFhI2E/k8kTRfhEbzZul3Noa9dRUO9vdPRGY61Ieb7oACZmPhipjFKuU6/HN", null, null, "user_31_a522@example.com", null, "user_31_a522" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_32_14d0@example.com", "user_32_14d0@example.com", false, "USER_32_14D0@EXAMPLE.COM", "USER_32_14D0", "iZtMxHSj7cPho0fOX3hedgmMrLkS35a0OZ/qIdFZ3JPMEnTWEpx8I4qdT7T5GmyC", null, null, "user_32_14d0@example.com", null, "user_32_14d0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_33_960e@example.com", "user_33_960e@example.com", false, "USER_33_960E@EXAMPLE.COM", "USER_33_960E", "sfFS2osevMBE2wLAv8LM4BqQXjYTrCX39zJf9AI8Xgxc+sxVaZBAIDtcCdszJllV", null, null, "user_33_960e@example.com", null, "user_33_960e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_34_5a05@example.com", "user_34_5a05@example.com", false, "USER_34_5A05@EXAMPLE.COM", "USER_34_5A05", "JhUesarVkPhkHzS4VeI4nGxEKdduUtSG23HOY1E6TaEMuT28vCAiYn8SOUAxGG5L", null, null, "user_34_5a05@example.com", null, "user_34_5a05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_35_5913@example.com", "user_35_5913@example.com", false, "USER_35_5913@EXAMPLE.COM", "USER_35_5913", "db2xeo6b1mcJsr+L4m45X+ixpX1ZFQ7fRqBZ0zMB0EZ3qXEyPGLMmm657i9wLVOL", null, null, "user_35_5913@example.com", null, "user_35_5913" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_36_4ce9@example.com", "user_36_4ce9@example.com", false, "USER_36_4CE9@EXAMPLE.COM", "USER_36_4CE9", "RsJEUjTSZdHNlofho+Ji7A7ACHLZ+3pzSkBFH6EXEEumPplwsylmfvL4KR3AUqRp", null, null, "user_36_4ce9@example.com", null, "user_36_4ce9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_37_3222@example.com", "user_37_3222@example.com", false, "USER_37_3222@EXAMPLE.COM", "USER_37_3222", "94Iam5KRnwiTWrA9nnOvcGYz2KPY60BHt2C+EN77JaMCh4PLnjlMBBRAEP+92hbq", null, null, "user_37_3222@example.com", null, "user_37_3222" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_38_4139@example.com", "user_38_4139@example.com", false, "USER_38_4139@EXAMPLE.COM", "USER_38_4139", "neyizr7/t9lMzksxwtjag+G0awIoAoHkAR+UFARNbIyQvyWdL3H6m9zfCOUl6mWF", null, null, "user_38_4139@example.com", null, "user_38_4139" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_39_8ea4@example.com", "user_39_8ea4@example.com", false, "USER_39_8EA4@EXAMPLE.COM", "USER_39_8EA4", "NoGoD/yFpS03UW15LYfnEwKWdg8Np54CpBd93+bmJxod4NsVOs/4ZYBgaER19BAa", null, null, "user_39_8ea4@example.com", null, "user_39_8ea4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_40_0d27@example.com", "user_40_0d27@example.com", false, "USER_40_0D27@EXAMPLE.COM", "USER_40_0D27", "edWKWxYFyt3koV1zCfMlq5Eb0mX71m99g2duwmYX7nq7o23QwAhHRSJ0LIzXcp6T", null, null, "user_40_0d27@example.com", null, "user_40_0d27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_41_50a3@example.com", "user_41_50a3@example.com", false, "USER_41_50A3@EXAMPLE.COM", "USER_41_50A3", "hEVCPiO0Xj+p8AUkXKuv/3zORZwy62yBt9fzVwaHwyNzgl+V1gINin//7gf62B4N", null, null, "user_41_50a3@example.com", null, "user_41_50a3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_42_57d1@example.com", "user_42_57d1@example.com", false, "USER_42_57D1@EXAMPLE.COM", "USER_42_57D1", "kSaIn4AsK39PMh23xF8C+R0bZf7VOoQodO7qURSAvzuhxIXpVYBmc8uzeW0Big8+", null, null, "user_42_57d1@example.com", null, "user_42_57d1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_43_bcff@example.com", "user_43_bcff@example.com", false, "USER_43_BCFF@EXAMPLE.COM", "USER_43_BCFF", "xo8d8V5MBwOKFZm6dq4wLtPk1Kn3OZnjj6pUqN5OQvtr58VBfMWmhtFuiRg/G9XO", null, null, "user_43_bcff@example.com", null, "user_43_bcff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_44_02cf@example.com", "user_44_02cf@example.com", false, "USER_44_02CF@EXAMPLE.COM", "USER_44_02CF", "xOM35WqcwCyF7KgfzuEcfQuSuWmbIGibPgmn3wwzvPgdkgLvmbdGmV+Q0MHNt44Q", null, null, "user_44_02cf@example.com", null, "user_44_02cf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_45_9055@example.com", "user_45_9055@example.com", false, "USER_45_9055@EXAMPLE.COM", "USER_45_9055", "CrlKKTnZPaUHFKiCEiH12P/fSfpXVLsbpvX7yR228ewSqNEgCQUOwDyvrv5ptday", null, null, "user_45_9055@example.com", null, "user_45_9055" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_46_7b22@example.com", "user_46_7b22@example.com", false, "USER_46_7B22@EXAMPLE.COM", "USER_46_7B22", "xRxR0hojkF0NHi2GlBBrhQu+WQKJYApEgKOnB7lJ1r63jNNmCukCbIgKAx11MmU0", null, null, "user_46_7b22@example.com", null, "user_46_7b22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_47_f85e@example.com", "user_47_f85e@example.com", false, "USER_47_F85E@EXAMPLE.COM", "USER_47_F85E", "2elNfJh0rIavuP8RYujI7yjrHupxUvD5HwDmVnJcmRIXXp1IO3v8WLU1DHQ3rl49", null, null, "user_47_f85e@example.com", null, "user_47_f85e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_48_42a9@example.com", "user_48_42a9@example.com", false, "USER_48_42A9@EXAMPLE.COM", "USER_48_42A9", "iXmI9ZEAU6Eh30UTap+xg5La5oKL5bdQofjOc4ap4+cE+pBydsRDo0wC/CKWr5Gr", null, null, "user_48_42a9@example.com", null, "user_48_42a9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_49_18f1@example.com", "user_49_18f1@example.com", false, "USER_49_18F1@EXAMPLE.COM", "USER_49_18F1", "Ec57BeDnSoN99bMKeQX0hjeY7OtEAeLeJIGenSutJfjdwWr6nlq/RTym4AtzuAWU", null, null, "user_49_18f1@example.com", null, "user_49_18f1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "IsLoggedIn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "Token", "UserName" },
                values: new object[] { "user_50_1fc8@example.com", "user_50_1fc8@example.com", false, "USER_50_1FC8@EXAMPLE.COM", "USER_50_1FC8", "yzhSI3CavXdzt2Ocxwqg4vpnOAdpWLcZ6+fs/x4iMv+x+w9tl1XogHN0KmQW9bdu", null, null, "user_50_1fc8@example.com", null, "user_50_1fc8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "IsLoggedIn", "PasswordHash", "RefreshToken", "RefreshTokenExpiration", "Token" },
                values: new object[] { false, "zudIu8WdFPOfFXQQsqOhEhOTlmp5+MMJO0OC+pCIl8GbIwRwn3+O9QoK3KvdbBgu", null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsLoggedIn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiration",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("011253c8-cfce-4750-b3d5-3e797827b04c"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("0aa6454b-b170-4ef3-9955-074552a091a4"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("31a9eecb-74ec-4025-be74-3b1047015a9b"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("358c142e-f64e-4710-b04f-7bd007938dba"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("6449babe-9203-41dc-82ae-8d18d309c860"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("68cffb7f-f817-4483-9afb-131d7f170220"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("6ad1314a-629d-44f6-8bb8-503ea7623a93"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("a1315eed-4fb4-4592-af8b-be0edaf70a68"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("a2fab4ba-6694-4737-852a-7510607d65a0"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("ca629a9b-541b-4e62-bf14-4eeaa940f93b"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("050d0499-3795-41b4-87a9-9fa6577ee5f4"), "USD", new DateTime(2025, 3, 4, 15, 49, 43, 192, DateTimeKind.Utc).AddTicks(1829), 2, true, "US Dollar", "$", null },
                    { new Guid("678ef4ca-43f8-444e-9678-32da5e99048a"), "EUR", new DateTime(2025, 3, 4, 15, 49, 43, 191, DateTimeKind.Utc).AddTicks(9441), 2, true, "Euro", "€", null },
                    { new Guid("84f74f9b-5f0f-4a52-b9ca-6436f389472d"), "GBP", new DateTime(2025, 3, 4, 15, 49, 43, 192, DateTimeKind.Utc).AddTicks(1847), 2, true, "British Pound", "£", null },
                    { new Guid("c6b6339c-1cf0-4e33-9a9e-ef6311eac7a9"), "CHF", new DateTime(2025, 3, 4, 15, 49, 43, 192, DateTimeKind.Utc).AddTicks(1851), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4e3c6cde-06f5-4c7a-9ce9-19e36ec207eb"), new DateTime(2025, 3, 4, 15, 49, 43, 191, DateTimeKind.Utc).AddTicks(3614), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("548bc3de-c579-4d46-b364-af245e7e9aef"), new DateTime(2025, 3, 4, 15, 49, 43, 191, DateTimeKind.Utc).AddTicks(6857), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("713e7ac2-66a3-4889-a410-0f92fcb00fc0"), new DateTime(2025, 3, 4, 15, 49, 43, 191, DateTimeKind.Utc).AddTicks(6880), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("e1e83529-63ff-4b3b-b04b-cccd7f894376"), new DateTime(2025, 3, 4, 15, 49, 43, 191, DateTimeKind.Utc).AddTicks(6886), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("05b4fc28-386d-40f5-a132-094bc595fdf0"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(7349), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("5dcc69cc-166b-4b6a-8bec-cb6808d7dbc3"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(7477), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("65684e84-040b-48ff-846e-922f44061a45"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(2926), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("68d7e228-925e-4171-824c-56b011ec5374"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(7460), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("a8cf6a52-c1ad-4634-99d3-35436c71a7da"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(7339), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("def9c465-a8fc-4675-816f-51160b78ac58"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(7464), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("04628364-2237-4b7c-9e8a-3d0276aae865"), new DateTime(2025, 3, 4, 15, 49, 43, 190, DateTimeKind.Utc).AddTicks(4470), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("404261da-076d-405e-bc64-e1055d951968"), new DateTime(2025, 3, 4, 15, 49, 43, 188, DateTimeKind.Utc).AddTicks(8213), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("60b334cd-6d23-401a-985c-da15e5775633"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(527), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("9c32452d-e161-4af7-80fd-e6a32bf9f206"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(534), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("a7b8462a-6e51-4d1c-bb26-f4d29fde880b"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(550), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("b2d0cc30-e83b-46a7-a08d-3d5b2c7fe87e"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(538), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("dc9f631f-3887-4546-9017-b5b35863d006"), new DateTime(2025, 3, 4, 15, 49, 43, 189, DateTimeKind.Utc).AddTicks(542), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("05e534fd-00d7-418c-8102-dd2c49362caf"), null, new DateTime(2025, 3, 4, 15, 49, 43, 193, DateTimeKind.Utc).AddTicks(8660), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("157a0609-1869-4a68-aef3-cb80683c7e14"), null, new DateTime(2025, 3, 4, 15, 49, 43, 193, DateTimeKind.Utc).AddTicks(7063), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("3bf231c7-a949-41ca-8bf3-2e568eabfad7"), null, new DateTime(2025, 3, 4, 15, 49, 43, 193, DateTimeKind.Utc).AddTicks(8655), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("58a5301a-e352-4c03-87d1-81e885c4bbcb"), null, new DateTime(2025, 3, 4, 15, 49, 43, 193, DateTimeKind.Utc).AddTicks(8646), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("2ebe7412-55ac-4764-b1e0-76ba82adf2b8"), new DateTime(2025, 3, 4, 15, 49, 43, 192, DateTimeKind.Utc).AddTicks(6863), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("8c45398a-1fd3-43a2-9c6f-797f4122f505"), new DateTime(2025, 3, 4, 15, 49, 43, 192, DateTimeKind.Utc).AddTicks(6877), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("9b6782e6-c5f1-4cca-b05b-9459bb738b26"), new DateTime(2025, 3, 4, 15, 49, 43, 192, DateTimeKind.Utc).AddTicks(4062), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("d597cf52-2d8c-44a9-bb31-eae48cdf0378"), new DateTime(2025, 3, 4, 15, 49, 43, 192, DateTimeKind.Utc).AddTicks(6884), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("e7fdc66b-b37d-46e8-9fd6-a58f5b01bde3"), new DateTime(2025, 3, 4, 15, 49, 43, 192, DateTimeKind.Utc).AddTicks(6880), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 4, 15, 49, 43, 194, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("42e02350-61f8-4a32-bc80-3a09b23f179b"), new DateTime(2025, 3, 4, 15, 49, 43, 194, DateTimeKind.Utc).AddTicks(6094), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("868ab308-b684-46ef-9d10-13fd66621269"), new DateTime(2025, 3, 4, 15, 49, 43, 194, DateTimeKind.Utc).AddTicks(5999), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("b5f21e17-e9bc-430a-81de-d326ab6b557c"), new DateTime(2025, 3, 4, 15, 49, 43, 194, DateTimeKind.Utc).AddTicks(6100), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "BsVRcsi00100r0G43ROzsLjVmaoDLWtcCv4fX6Di+XED75BtJ3/HpBUuV2Ijo29D");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "ImyVR4iotWt/QnBoUl4kDwxBYEiwftNG3FnOV8Lqy71q6jCd2EXBrQVo5HsFWZOE");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_4ebf@example.com", "user_1_4ebf@example.com", "USER_1_4EBF@EXAMPLE.COM", "USER_1_4EBF", "ro5nHj3m2qEolv27Kc9l7C5t8ziveeVB+QflGwAFhKeqANfTGTtK66I1/9PPnfH6", "user_1_4ebf@example.com", "user_1_4ebf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_9518@example.com", "user_2_9518@example.com", "USER_2_9518@EXAMPLE.COM", "USER_2_9518", "tP6vJXtHeRZ9o5AVCEfwlw6wthHXrm8f8irsDH0iIviN+SGg0jjHWEY0e0hl700B", "user_2_9518@example.com", "user_2_9518" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_2ac6@example.com", "user_3_2ac6@example.com", "USER_3_2AC6@EXAMPLE.COM", "USER_3_2AC6", "WRVg3EUdgHtO6kDHAIKmdRH1yxZTZEGoLDcOekmszH/bFnTCBdAfYM8AILpQCxC2", "user_3_2ac6@example.com", "user_3_2ac6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_e289@example.com", "user_4_e289@example.com", "USER_4_E289@EXAMPLE.COM", "USER_4_E289", "dZIAy78gKQCFLK6ATIxThArCXv6wGI+OISyaoU62uaUHZn5euYnuRjCAa4k8t1Nq", "user_4_e289@example.com", "user_4_e289" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_49ba@example.com", "user_5_49ba@example.com", "USER_5_49BA@EXAMPLE.COM", "USER_5_49BA", "HH4tdwiihJ1rvhO4dxUwAeUuSHFI+SlQcRbQreb+fuZWH9LsnCZxx5sY7U/u9TZ9", "user_5_49ba@example.com", "user_5_49ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_4659@example.com", "user_6_4659@example.com", "USER_6_4659@EXAMPLE.COM", "USER_6_4659", "RZRaV6/XW+IHKp3g4pelJ5xwmdeJyYGb1SDQLa77+15gYNrTA6dN6+jU4S2VrFkS", "user_6_4659@example.com", "user_6_4659" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_9c94@example.com", "user_7_9c94@example.com", "USER_7_9C94@EXAMPLE.COM", "USER_7_9C94", "woNEQtLRZOXMDRQ/kE8AIPn52o2B5cBdktY7DqeJwrTaY+Xd/0aMVZB6hf9EKIP5", "user_7_9c94@example.com", "user_7_9c94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_6edd@example.com", "user_8_6edd@example.com", "USER_8_6EDD@EXAMPLE.COM", "USER_8_6EDD", "rtvtyeNaCenu8lFPQaG9R3rHjldrJCxPOXqy2k0AjYAw3dQOsXJ5IYXL6r+k+Ju7", "user_8_6edd@example.com", "user_8_6edd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_95ff@example.com", "user_9_95ff@example.com", "USER_9_95FF@EXAMPLE.COM", "USER_9_95FF", "s9qYPbRfH9Pns6ZBeGe7mz1Fkic9fiamTr8Fkqs8lMV32bI35ArfAeahJE3ovjf4", "user_9_95ff@example.com", "user_9_95ff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_ceed@example.com", "user_10_ceed@example.com", "USER_10_CEED@EXAMPLE.COM", "USER_10_CEED", "imA/Bd7zVkCIw/m9T38oIlh9yH9Gb7riozV/nHNqDNcoUNq1QE49+Yp0acnXxsZI", "user_10_ceed@example.com", "user_10_ceed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_688c@example.com", "user_11_688c@example.com", "USER_11_688C@EXAMPLE.COM", "USER_11_688C", "X58ZD6zhm38AZ9wxZEofGfKubcKBC/RP924AJSVDDAMagmo70O/Nr8Dk5Cv2WivO", "user_11_688c@example.com", "user_11_688c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_1a9e@example.com", "user_12_1a9e@example.com", "USER_12_1A9E@EXAMPLE.COM", "USER_12_1A9E", "kALM19LFaanN5IZNwXiC+tzkYOpf63wqbjogO8lYfRm2LFFBWoPlK38TqA+d1mOV", "user_12_1a9e@example.com", "user_12_1a9e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_248e@example.com", "user_13_248e@example.com", "USER_13_248E@EXAMPLE.COM", "USER_13_248E", "Ji7mZD8iF9b20oABIXKPqWoiS9Rnh2Vd+SeUuZtMgQM/3pkh7h7mMv3F8/hboDuO", "user_13_248e@example.com", "user_13_248e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_1e80@example.com", "user_14_1e80@example.com", "USER_14_1E80@EXAMPLE.COM", "USER_14_1E80", "t9Zmvc9mXRrs4uMYRB4vXhEYiPcD19VJnGlKq1iVUH6pC2XAgj9rGl9xzY8KkMJ8", "user_14_1e80@example.com", "user_14_1e80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_e704@example.com", "user_15_e704@example.com", "USER_15_E704@EXAMPLE.COM", "USER_15_E704", "7WFRy8J2iSmMcRI+ir7VwNcrQHF7weD1l0Smo5uiEa/bC34lusPUs0eF1C1vre4r", "user_15_e704@example.com", "user_15_e704" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_3423@example.com", "user_16_3423@example.com", "USER_16_3423@EXAMPLE.COM", "USER_16_3423", "Hh5n+rgMNsv2FlVERtPMKR2+8zYPIclSTmZhtasbZ9l0jnPecLrDG+Dqrnq5/Bec", "user_16_3423@example.com", "user_16_3423" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_f047@example.com", "user_17_f047@example.com", "USER_17_F047@EXAMPLE.COM", "USER_17_F047", "UjyBK8wDiIXCxbDDp9laQNlRCzyCdBSfvBJGhpMfGlPIT529bqOgvFX9/Gq+gYlx", "user_17_f047@example.com", "user_17_f047" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_3dee@example.com", "user_18_3dee@example.com", "USER_18_3DEE@EXAMPLE.COM", "USER_18_3DEE", "uqY3100xnMX2ZX1UO7Bq/LPiRAmS6ibffKoxeHSu9gY8N2YqPrB/OL2DON9Kwpcu", "user_18_3dee@example.com", "user_18_3dee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_d4ba@example.com", "user_19_d4ba@example.com", "USER_19_D4BA@EXAMPLE.COM", "USER_19_D4BA", "MTK/oRSUOLZEngLMSw4g7JtgbaeF6bNdMzmqiQxr+/EbjO1zMUKUy3LXWkuEi42F", "user_19_d4ba@example.com", "user_19_d4ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_e039@example.com", "user_20_e039@example.com", "USER_20_E039@EXAMPLE.COM", "USER_20_E039", "N1hN3KF2vAsMBS5f309ExxmfeZqS/WXhL1WTxHa+RNZFoU4W15RzoX3T50CKps4m", "user_20_e039@example.com", "user_20_e039" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_3426@example.com", "user_21_3426@example.com", "USER_21_3426@EXAMPLE.COM", "USER_21_3426", "0YteI/D8JjrynJbisMLQD6Ud4pOHnjLOXVToxrGpS3H396xsh8k0R9wZhML7GBdf", "user_21_3426@example.com", "user_21_3426" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_5eda@example.com", "user_22_5eda@example.com", "USER_22_5EDA@EXAMPLE.COM", "USER_22_5EDA", "znhJrLq3cIX2u3CbXLPk9dhHVSNNPB5ARukXMugHFH859Vf/AdCLFfsyjixa9B8d", "user_22_5eda@example.com", "user_22_5eda" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_d289@example.com", "user_23_d289@example.com", "USER_23_D289@EXAMPLE.COM", "USER_23_D289", "olX6N+J2LCTt8IdXBwYnoq5cRWCi82v9hEgOe3n/kJtBEmP3Yon8JBFldi6uTwQK", "user_23_d289@example.com", "user_23_d289" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_7014@example.com", "user_24_7014@example.com", "USER_24_7014@EXAMPLE.COM", "USER_24_7014", "vpLKP3ApYX2gaD06zYZopR06ZyuPAwC/0bHjzASew26MVkx4GhiVQQWjAWi74XIi", "user_24_7014@example.com", "user_24_7014" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_1dbf@example.com", "user_25_1dbf@example.com", "USER_25_1DBF@EXAMPLE.COM", "USER_25_1DBF", "Cfmm6wQNMGwlZ2t6za1xafjyQ3y2IC9o8aDJ7IY/nYYXofPslZUyEguT/T6BX5Aj", "user_25_1dbf@example.com", "user_25_1dbf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_71b9@example.com", "user_26_71b9@example.com", "USER_26_71B9@EXAMPLE.COM", "USER_26_71B9", "uQlvkLhRzzeX5s/pT+ZEX8EHZ4VVrQ97DXsaoQ8pTnpgpTCDWyEVE6a7VVl2wGm3", "user_26_71b9@example.com", "user_26_71b9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_35a3@example.com", "user_27_35a3@example.com", "USER_27_35A3@EXAMPLE.COM", "USER_27_35A3", "d1ATBm4m5lIdTyXW/0SoQuh3E629YhGIvQeYC1qd371MsKO8/lkjQjCVRnp16uiq", "user_27_35a3@example.com", "user_27_35a3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_f1dc@example.com", "user_28_f1dc@example.com", "USER_28_F1DC@EXAMPLE.COM", "USER_28_F1DC", "hKcZRnGsuUTkIBH4P2b2kxWtKQbdR3o5T/QTydX9XaDGNLeX0UHFcz1zajQzD8cx", "user_28_f1dc@example.com", "user_28_f1dc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_82ee@example.com", "user_29_82ee@example.com", "USER_29_82EE@EXAMPLE.COM", "USER_29_82EE", "Sf74mRCa9fGgP/EbvUqSYY4jQ32Xc0l54hyYwoMc9OFUMXT9XnSXnl9sItP9r9/C", "user_29_82ee@example.com", "user_29_82ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_bd17@example.com", "user_30_bd17@example.com", "USER_30_BD17@EXAMPLE.COM", "USER_30_BD17", "L0QcYlwfHqQGWNTnBDhSUCzrLBaTY5KTRcyaJ21gqwd4JfH6b6iz161qa29Imhh1", "user_30_bd17@example.com", "user_30_bd17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_497d@example.com", "user_31_497d@example.com", "USER_31_497D@EXAMPLE.COM", "USER_31_497D", "tzt76lAvWxCxSHkbsqBUpb5gPNY8pFggDc/XQUBAxPDi7mEDD/HZxJ9HzftQbidK", "user_31_497d@example.com", "user_31_497d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_247f@example.com", "user_32_247f@example.com", "USER_32_247F@EXAMPLE.COM", "USER_32_247F", "llOUvkMFYvGcIOLynGjmLnJGcZqOA7SaeejLxnW/76e2xPwpYmXOhtX/1HvGd4QK", "user_32_247f@example.com", "user_32_247f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_c5dc@example.com", "user_33_c5dc@example.com", "USER_33_C5DC@EXAMPLE.COM", "USER_33_C5DC", "8e5RuvspBGpfuGyaU5ljoj1iZHL7Fuqg3D09XQgoODdIZ/B5PsZ7v3kvo/YqoeQJ", "user_33_c5dc@example.com", "user_33_c5dc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_ae42@example.com", "user_34_ae42@example.com", "USER_34_AE42@EXAMPLE.COM", "USER_34_AE42", "D1rsUJZnJ8JiQQLfHmgJAdb2V3V6ll+60Xz785RoZ06H1fsbIriihrJuNc5Q6e09", "user_34_ae42@example.com", "user_34_ae42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_6c7b@example.com", "user_35_6c7b@example.com", "USER_35_6C7B@EXAMPLE.COM", "USER_35_6C7B", "wyMjIc0HbxtCeRgf4TISPcDvMA4f5Ise51KVUzqDxPdSvUfaV+N4xH71W7R2NFzF", "user_35_6c7b@example.com", "user_35_6c7b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_6e02@example.com", "user_36_6e02@example.com", "USER_36_6E02@EXAMPLE.COM", "USER_36_6E02", "HzMvnpoO134ZIRd/7kqweShW7JUa2+DESi3qksuuJNmqcIMtDKP98a1gh3BxwE1s", "user_36_6e02@example.com", "user_36_6e02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_839b@example.com", "user_37_839b@example.com", "USER_37_839B@EXAMPLE.COM", "USER_37_839B", "pSyjOv5Nwa4JfCHKgDaJlx8LjKVxEvZHFW/HiTay5wtsq4KOU43h9j1r3V6f9mQU", "user_37_839b@example.com", "user_37_839b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_bc98@example.com", "user_38_bc98@example.com", "USER_38_BC98@EXAMPLE.COM", "USER_38_BC98", "UZgWNkLaZ5ed2DxzSBRA3BadlGL9keoNeCMaui6Vtkzxv5B7D7N2vF/TW1IClXi3", "user_38_bc98@example.com", "user_38_bc98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_4bfe@example.com", "user_39_4bfe@example.com", "USER_39_4BFE@EXAMPLE.COM", "USER_39_4BFE", "ro3FUgiFrOl13AtlIkSunoOGQUV3atNgsnCGm2zDDxAwB0cxkat0CyWqxx1+eXuY", "user_39_4bfe@example.com", "user_39_4bfe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_4520@example.com", "user_40_4520@example.com", "USER_40_4520@EXAMPLE.COM", "USER_40_4520", "2CkAUE02brP6yQtgBFSaxWowkHZAv+xTiak2pxAmVCOJ4Ld4IiHSV2VzkG0GBaBt", "user_40_4520@example.com", "user_40_4520" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_164c@example.com", "user_41_164c@example.com", "USER_41_164C@EXAMPLE.COM", "USER_41_164C", "CdrP+MIDuE0AicWG4wtpHKmsToo34T5PY2R9Mb+HdKx4r3+qnO+zp+T2wHbe4WIQ", "user_41_164c@example.com", "user_41_164c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_8f17@example.com", "user_42_8f17@example.com", "USER_42_8F17@EXAMPLE.COM", "USER_42_8F17", "P8D/lH8cYpcgXYpxCGgecjqdNVTPr/G/KphYkAlKbQKRh629TOsUvzsi2cVJYIMd", "user_42_8f17@example.com", "user_42_8f17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_0e46@example.com", "user_43_0e46@example.com", "USER_43_0E46@EXAMPLE.COM", "USER_43_0E46", "pdHebHARqBdLsV3fmx79WDkwgc8k4yHt9dR/bJ4E3zKqrF3IYFnnfNXyIUrZn4wX", "user_43_0e46@example.com", "user_43_0e46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_e80a@example.com", "user_44_e80a@example.com", "USER_44_E80A@EXAMPLE.COM", "USER_44_E80A", "VjoG0ERPrjLGPHAl95gg8TreR1eAAlKL9rIWpxiyHXKCv6JAUiRs1IhrAeVLQecA", "user_44_e80a@example.com", "user_44_e80a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_7303@example.com", "user_45_7303@example.com", "USER_45_7303@EXAMPLE.COM", "USER_45_7303", "+jY4vtzx7+WUP/DnVrGKUqcIfg8pa7KItDggg6a4n7O4t0uWMf5kY2BF09gugvuh", "user_45_7303@example.com", "user_45_7303" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_08c4@example.com", "user_46_08c4@example.com", "USER_46_08C4@EXAMPLE.COM", "USER_46_08C4", "atEMFgLX8fqSsdFLL8eFRut4agNQ52HQsgcy/MaJX+1kOa6UZ0bM/50KC1iLHrev", "user_46_08c4@example.com", "user_46_08c4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_a0f7@example.com", "user_47_a0f7@example.com", "USER_47_A0F7@EXAMPLE.COM", "USER_47_A0F7", "heXD+TVq+71pbC/VaM1NsxpVXz2LpUyEVEwz/GTNzuFqTvmPVCi09nj8iSsU+9uF", "user_47_a0f7@example.com", "user_47_a0f7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_a17f@example.com", "user_48_a17f@example.com", "USER_48_A17F@EXAMPLE.COM", "USER_48_A17F", "rLQ+fzUe9l4ADMLG+WvrvDjveS8lA+fuaSXiVQOAJ+Sq5Phb9RoAa5CmkDYobHGl", "user_48_a17f@example.com", "user_48_a17f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_4955@example.com", "user_49_4955@example.com", "USER_49_4955@EXAMPLE.COM", "USER_49_4955", "q3pVo/ErDfuZS7jU2BkvvHAJk6Pol8BSny85ROJ0F5yUfTLSvjOcM5SO4/F9H/4I", "user_49_4955@example.com", "user_49_4955" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_c847@example.com", "user_50_c847@example.com", "USER_50_C847@EXAMPLE.COM", "USER_50_C847", "0lX8Eb5Fby7BG6/TIaKQINvDjzffd7HMizciACRzBtU5XUFiZVmatIQU4ONqrJK3", "user_50_c847@example.com", "user_50_c847" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "x+Lxhj3wtli5B26c7G54RGnfGY5mAL0MnvCqm0806i37E1PWiU0968j7XhcidXru");
        }
    }
}
