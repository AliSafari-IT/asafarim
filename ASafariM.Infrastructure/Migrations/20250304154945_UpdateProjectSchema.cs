using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("178fb5c9-0e15-4590-853d-60f1a6254722"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f97ec75-15b1-43c0-8e92-fbcf8adcfad4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33cc27d0-453b-490c-a84c-0463ba6cc55e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49703bb1-5422-45f4-8350-c38bc715c34d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49dc1c42-25c3-4773-9e25-844fed18e64d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62308f13-07f3-498e-9103-41b5ef334450"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6232278d-e7b7-46ad-832d-b19e178a5e65"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("acc0e240-2422-4cbd-98b5-df581430b10e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e214a56d-c348-4cbe-bf7a-e4c798ae7495"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea7567dd-11db-4414-877b-df4c2c216c86"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0afb6230-629a-425c-84e6-a448f12c13fe"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("29242680-ba1e-4d6e-8854-8fd194f28166"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5b6fbb5a-6ba5-4d4b-aaa1-6104430f6443"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f4613664-22ae-4f2c-8d01-be6260b38c39"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("59cb0ed6-bac1-4af4-adc5-2819c0f02eda"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("94c93979-b739-41ab-9be2-5cbbfb639c76"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("b1d971b5-7c2b-4fef-b4ae-ed26829d49e4"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("f44fd3dc-5878-46fc-b822-df3348435779"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0ed17047-9715-4031-b5cb-d9020eda4654"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("19607e5f-6efa-45fe-94fc-eb503849b6c1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("21ebfdaa-fd22-44b5-9b1e-02f3256a842a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6d99caca-5806-4be8-b6f1-d7c23c1af2d5"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("89b14cc1-7c20-4acc-ab30-3bb970fcb6d2"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("928a387d-40d1-4212-94b3-5d2e34a4334c"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("48cb7ade-f2bb-4426-8d02-b912876e4cca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("03d2cf8f-beb8-4455-ade0-efc5635e5c6a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4fbba298-ccbc-4f2d-b394-ff33b23fe274"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("61e4acc8-fc16-43e3-80ac-80bda54b2cfb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b4d0e151-3155-4508-9ee7-5110e74b2ce1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b53b026d-ae7b-497c-a851-e02c4fba9892"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fb62843b-9af4-4be7-ac4d-5bae89f98695"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4245e448-8c62-45dd-961d-29892f7eb482"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8e21f077-05a1-4fce-ab74-6967fd7e4eec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cff3246d-a9c3-4807-811d-a8a23eb0cfb7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fc4840eb-149b-4b6d-afaa-3c13376c3694"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("04405d90-002a-4f4f-9d90-33a4a086f334"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("71839c3f-b9eb-435b-a3e2-d770ed71f5e1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c2bb72b8-ee0e-4233-9206-da0a1f040fc1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f1860167-41bf-4f7b-8cea-0e5022a98c25"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f378bf36-407d-4e6d-b07e-5a0c64fb7c01"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("33bd44b3-77b1-4387-91fc-89dfe23cc74b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("46ca0aa4-6554-4af2-a727-2c0827ea5e98"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f96c65f7-fa93-455b-aea2-5690680b1f6d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("178fb5c9-0e15-4590-853d-60f1a6254722"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("1f97ec75-15b1-43c0-8e92-fbcf8adcfad4"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("33cc27d0-453b-490c-a84c-0463ba6cc55e"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("49703bb1-5422-45f4-8350-c38bc715c34d"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("49dc1c42-25c3-4773-9e25-844fed18e64d"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("62308f13-07f3-498e-9103-41b5ef334450"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("6232278d-e7b7-46ad-832d-b19e178a5e65"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("acc0e240-2422-4cbd-98b5-df581430b10e"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("e214a56d-c348-4cbe-bf7a-e4c798ae7495"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("ea7567dd-11db-4414-877b-df4c2c216c86"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0afb6230-629a-425c-84e6-a448f12c13fe"), "GBP", new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(9227), 2, true, "British Pound", "£", null },
                    { new Guid("29242680-ba1e-4d6e-8854-8fd194f28166"), "USD", new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(9214), 2, true, "US Dollar", "$", null },
                    { new Guid("5b6fbb5a-6ba5-4d4b-aaa1-6104430f6443"), "CHF", new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(9230), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("f4613664-22ae-4f2c-8d01-be6260b38c39"), "EUR", new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(8204), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("59cb0ed6-bac1-4af4-adc5-2819c0f02eda"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(7393), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null },
                    { new Guid("94c93979-b739-41ab-9be2-5cbbfb639c76"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(7385), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("b1d971b5-7c2b-4fef-b4ae-ed26829d49e4"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(6189), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("f44fd3dc-5878-46fc-b822-df3348435779"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(7390), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ed17047-9715-4031-b5cb-d9020eda4654"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2903), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("19607e5f-6efa-45fe-94fc-eb503849b6c1"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2906), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("21ebfdaa-fd22-44b5-9b1e-02f3256a842a"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2850), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("6d99caca-5806-4be8-b6f1-d7c23c1af2d5"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2909), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("89b14cc1-7c20-4acc-ab30-3bb970fcb6d2"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2846), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("928a387d-40d1-4212-94b3-5d2e34a4334c"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(1587), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("48cb7ade-f2bb-4426-8d02-b912876e4cca"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(4061), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("03d2cf8f-beb8-4455-ade0-efc5635e5c6a"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(575), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("4fbba298-ccbc-4f2d-b394-ff33b23fe274"), new DateTime(2025, 3, 4, 15, 39, 6, 393, DateTimeKind.Utc).AddTicks(9539), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("61e4acc8-fc16-43e3-80ac-80bda54b2cfb"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(569), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("b4d0e151-3155-4508-9ee7-5110e74b2ce1"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(579), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("b53b026d-ae7b-497c-a851-e02c4fba9892"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(565), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("fb62843b-9af4-4be7-ac4d-5bae89f98695"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(572), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4245e448-8c62-45dd-961d-29892f7eb482"), null, new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(6827), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("8e21f077-05a1-4fce-ab74-6967fd7e4eec"), null, new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(6823), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("cff3246d-a9c3-4807-811d-a8a23eb0cfb7"), null, new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(6835), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("fc4840eb-149b-4b6d-afaa-3c13376c3694"), null, new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(6053), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("04405d90-002a-4f4f-9d90-33a4a086f334"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(1430), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("71839c3f-b9eb-435b-a3e2-d770ed71f5e1"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(1432), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("c2bb72b8-ee0e-4233-9206-da0a1f040fc1"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(48), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("f1860167-41bf-4f7b-8cea-0e5022a98c25"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(1423), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("f378bf36-407d-4e6d-b07e-5a0c64fb7c01"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(1434), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("33bd44b3-77b1-4387-91fc-89dfe23cc74b"), new DateTime(2025, 3, 4, 15, 39, 6, 396, DateTimeKind.Utc).AddTicks(544), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("46ca0aa4-6554-4af2-a727-2c0827ea5e98"), new DateTime(2025, 3, 4, 15, 39, 6, 396, DateTimeKind.Utc).AddTicks(538), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("f96c65f7-fa93-455b-aea2-5690680b1f6d"), new DateTime(2025, 3, 4, 15, 39, 6, 396, DateTimeKind.Utc).AddTicks(547), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "pBJO16ZRczDcsw7FaG1xmMsy0zfjB4vHQirDRcIw2zB43qADu0P3PNBPiLUkwE9A");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "+7hN3xXgEpCAr6b4IV/Dwou/jjHRbGi24sUvn7YEgY/cBH2q6GIByRzD1HfEDmSM");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_896b@example.com", "user_1_896b@example.com", "USER_1_896B@EXAMPLE.COM", "USER_1_896B", "IeXh6bndC0xxyMCBjDviM4cl0EHB0QB6aSfz2uWTe+TR7uAZgcDhXZ49IwEIFqjw", "user_1_896b@example.com", "user_1_896b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_bf21@example.com", "user_2_bf21@example.com", "USER_2_BF21@EXAMPLE.COM", "USER_2_BF21", "mMGexvN+vZne5JnXekyNGtjDx1sCVmZL0kUZPwdSVp0MqtrGlhSLD9EpezmdJzba", "user_2_bf21@example.com", "user_2_bf21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_0be1@example.com", "user_3_0be1@example.com", "USER_3_0BE1@EXAMPLE.COM", "USER_3_0BE1", "rnIyZtmtVAM52XYp67QhyrZY0l7ghT4bQ9zWwZ+C+jotha5mUEX9KM7Qrhyc0Oyg", "user_3_0be1@example.com", "user_3_0be1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_32ea@example.com", "user_4_32ea@example.com", "USER_4_32EA@EXAMPLE.COM", "USER_4_32EA", "KsjOSwrhIUzq96yRBNEIkAIkP1NacE4T6urJVM3Bo74gF5eAgYRd++JHKDJEHR9b", "user_4_32ea@example.com", "user_4_32ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_2889@example.com", "user_5_2889@example.com", "USER_5_2889@EXAMPLE.COM", "USER_5_2889", "Sx9h4ySHPULmFAIhAlQ7qbx7Yo/EBksB8OuA6RNMdikTqFSX8O7C4uEy7yeCzwKf", "user_5_2889@example.com", "user_5_2889" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_3e29@example.com", "user_6_3e29@example.com", "USER_6_3E29@EXAMPLE.COM", "USER_6_3E29", "CR4ujjFPrn5sIzTnWWlMh8FBndWfZbJW0ZdfYzjWbXOiZmc15/HZoS3Un2BtRDHE", "user_6_3e29@example.com", "user_6_3e29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_47b1@example.com", "user_7_47b1@example.com", "USER_7_47B1@EXAMPLE.COM", "USER_7_47B1", "rBlJ63Zm5OdLQSuR2gkT5V09WtVdWVaAXV+tzK7jnILAUYdA0TgJup3096tgSFhV", "user_7_47b1@example.com", "user_7_47b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_fda4@example.com", "user_8_fda4@example.com", "USER_8_FDA4@EXAMPLE.COM", "USER_8_FDA4", "ze1jkMRYfdvyO6e0W2fq82KVkqipe7EwF7Qrm1gGk4qLA4IHyUdNVKo2NWq0TEeZ", "user_8_fda4@example.com", "user_8_fda4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_da72@example.com", "user_9_da72@example.com", "USER_9_DA72@EXAMPLE.COM", "USER_9_DA72", "WF4bf9zIO/DSMTtjiEi5UUK8PLs+ayUSzD7/6d2etUUxw0fwBQN9uZm53TOhjxDU", "user_9_da72@example.com", "user_9_da72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_57b0@example.com", "user_10_57b0@example.com", "USER_10_57B0@EXAMPLE.COM", "USER_10_57B0", "fd0uYVp5FWuVq3SUUz/wxBObQdBOgiKucFzemob2GpTRM+wWa1c+jE2kyZmAfPXV", "user_10_57b0@example.com", "user_10_57b0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_56cc@example.com", "user_11_56cc@example.com", "USER_11_56CC@EXAMPLE.COM", "USER_11_56CC", "/m+ZaWx+HmUQOo1txRt+M3m0Iahg2R6ZNlA20on5FBMippnC6TPr+K5EQhva21lL", "user_11_56cc@example.com", "user_11_56cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_3dec@example.com", "user_12_3dec@example.com", "USER_12_3DEC@EXAMPLE.COM", "USER_12_3DEC", "OK4hcbZVadEB45y8jqn/6Zk1dxGvjY2Rs3POTCjv4Mm9qqIfTvolnBjXqbLeKSei", "user_12_3dec@example.com", "user_12_3dec" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_88a1@example.com", "user_13_88a1@example.com", "USER_13_88A1@EXAMPLE.COM", "USER_13_88A1", "VEWK9shyhD0gDAFDC5CsdrI9Nmf1gkF7PpaxeZwSacYvGHgFdbHuRk6g+BqZKGL+", "user_13_88a1@example.com", "user_13_88a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_debe@example.com", "user_14_debe@example.com", "USER_14_DEBE@EXAMPLE.COM", "USER_14_DEBE", "sJ52sSso1mRoV7t5A4xpFm+lkwlHGnlfwmHeMXJFqWg65i4dVcO5LTrarPTVUbIR", "user_14_debe@example.com", "user_14_debe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_c5bf@example.com", "user_15_c5bf@example.com", "USER_15_C5BF@EXAMPLE.COM", "USER_15_C5BF", "ZnLU1k+ZcUI07TfnE/IAMTK6+GE4mgXAyjRtoCwUCGh6bLkar355fVz+tNcLgkmt", "user_15_c5bf@example.com", "user_15_c5bf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_4142@example.com", "user_16_4142@example.com", "USER_16_4142@EXAMPLE.COM", "USER_16_4142", "rRwe+VqApBR/lSsrkOpcZ1UKz5RuL3Qr6ToEV0WXr1MWWDYHEnSA4JYp0BoJfOyQ", "user_16_4142@example.com", "user_16_4142" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_bc80@example.com", "user_17_bc80@example.com", "USER_17_BC80@EXAMPLE.COM", "USER_17_BC80", "mkkaDosje8sb0Dn09ly5EDgOqCnQeCGxHR+vQBoqa2sVTYEB1fcFFb3Ia/D5JAfT", "user_17_bc80@example.com", "user_17_bc80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_3588@example.com", "user_18_3588@example.com", "USER_18_3588@EXAMPLE.COM", "USER_18_3588", "zO9r/cAceL1klt6IP6Wm7t26fLo0iNi3R96Q90isUmmBufk3f+vXmAg7WfuUAM17", "user_18_3588@example.com", "user_18_3588" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_dca4@example.com", "user_19_dca4@example.com", "USER_19_DCA4@EXAMPLE.COM", "USER_19_DCA4", "OfNuA1WcWyOuQuZCcyc2amsXvIkwO+aY3EkZ+JTH9JCuYZ6aOU3bhRru/dL5prEK", "user_19_dca4@example.com", "user_19_dca4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_7868@example.com", "user_20_7868@example.com", "USER_20_7868@EXAMPLE.COM", "USER_20_7868", "M9MDtnudq0Tjsj4gO2+kRAgfDlOspZ89XKukvlstOPJ9pq/fyd+wRPW9V2ktWNEu", "user_20_7868@example.com", "user_20_7868" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_53f6@example.com", "user_21_53f6@example.com", "USER_21_53F6@EXAMPLE.COM", "USER_21_53F6", "aCKZc6ZntRiBKLOrF9nE71kCfUE+e9YHrzuKCWjhaGBRwmuWsykEGeRUr4a0ZWTQ", "user_21_53f6@example.com", "user_21_53f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_3adf@example.com", "user_22_3adf@example.com", "USER_22_3ADF@EXAMPLE.COM", "USER_22_3ADF", "1EW7Wdlanm4E/Eu2/11epSb+gauk6XZmj+SdsNQcSB1rw7lmKhg6jQ9Fm0xWtyN3", "user_22_3adf@example.com", "user_22_3adf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_de6d@example.com", "user_23_de6d@example.com", "USER_23_DE6D@EXAMPLE.COM", "USER_23_DE6D", "bLCtiP5cTPS1RMyKQ5gabkRHK44k6hFKMaNhfBHd13r/5zOou4iHLD7Aepat/Fxl", "user_23_de6d@example.com", "user_23_de6d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_bb5c@example.com", "user_24_bb5c@example.com", "USER_24_BB5C@EXAMPLE.COM", "USER_24_BB5C", "ToI43Cdn/IBx8Wy7z7cZukrhwt2VvSruOQaAeQWsai0mfCUM08oBQlMltJ561Xp3", "user_24_bb5c@example.com", "user_24_bb5c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_4abf@example.com", "user_25_4abf@example.com", "USER_25_4ABF@EXAMPLE.COM", "USER_25_4ABF", "eQUhbCBGhnM1qd/E8XdosaxY7FDmb2Qa5wSAi0ZiAx+VGQwqwo2hKZ163Xtv7Bdy", "user_25_4abf@example.com", "user_25_4abf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_c9f2@example.com", "user_26_c9f2@example.com", "USER_26_C9F2@EXAMPLE.COM", "USER_26_C9F2", "3IZCYi0gYyy9sWdlAIIqryTdh56lhDeFWnawtNKMJzYZTaOgzoXLh2F5XnRrdwAq", "user_26_c9f2@example.com", "user_26_c9f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_9dfe@example.com", "user_27_9dfe@example.com", "USER_27_9DFE@EXAMPLE.COM", "USER_27_9DFE", "VyOSEHhdYzHYygeoxjGiVlI6BVFcGorPtXU1IZ6exJAtIjwrll+8peaZq3qL/TGX", "user_27_9dfe@example.com", "user_27_9dfe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_6a7f@example.com", "user_28_6a7f@example.com", "USER_28_6A7F@EXAMPLE.COM", "USER_28_6A7F", "1F817PGCTBgWRANTkdFM2SYr9xjh3yLoxQJ1pl6UofdkJP4D3r+3Tu8R0QieYGue", "user_28_6a7f@example.com", "user_28_6a7f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_3d12@example.com", "user_29_3d12@example.com", "USER_29_3D12@EXAMPLE.COM", "USER_29_3D12", "O3x9xZ6IWZGzYX724bQiNlozWEmPoqBRkJk1u/oa8I4aVryXVxSt05BdL8P3mcig", "user_29_3d12@example.com", "user_29_3d12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_1639@example.com", "user_30_1639@example.com", "USER_30_1639@EXAMPLE.COM", "USER_30_1639", "esz+Mnsin+pljtYPoW9Xc5vBHa8PeXCziGp3WYG6W4YLCwaKYFJTSGSrW6U1s9rz", "user_30_1639@example.com", "user_30_1639" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_d3b0@example.com", "user_31_d3b0@example.com", "USER_31_D3B0@EXAMPLE.COM", "USER_31_D3B0", "YELgst2a7OYX3CA3N+IQPrb5ml4D5bPDgOGuUDwDW5wF4g3e9TxWE+ND+vqcqII2", "user_31_d3b0@example.com", "user_31_d3b0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_3926@example.com", "user_32_3926@example.com", "USER_32_3926@EXAMPLE.COM", "USER_32_3926", "OZ4nEs2mQ1EtkXeG5h28L8ZNq4yo9O3uVAPTtZ0v48mUPPzJ0Zbcdknj1kpmH45t", "user_32_3926@example.com", "user_32_3926" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_1305@example.com", "user_33_1305@example.com", "USER_33_1305@EXAMPLE.COM", "USER_33_1305", "tTOSZJupBW9CzxAZlN20aR1kEOMkw1ec9ZAru3svm0XWX4qD+OsbuBHhl0zCJw4r", "user_33_1305@example.com", "user_33_1305" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_1f71@example.com", "user_34_1f71@example.com", "USER_34_1F71@EXAMPLE.COM", "USER_34_1F71", "aQuuEFumeXtBMkAntpRgl7y2gOsmDARHAH/iv6Px1/1PaOzy4M+yuZNZz6cZsM4P", "user_34_1f71@example.com", "user_34_1f71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_1017@example.com", "user_35_1017@example.com", "USER_35_1017@EXAMPLE.COM", "USER_35_1017", "bEWiFExXreyabXbAziAyJZytP8tug2THafKp4JO+Qs4bp51llh4lRNY0EWAD5Ihj", "user_35_1017@example.com", "user_35_1017" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_3652@example.com", "user_36_3652@example.com", "USER_36_3652@EXAMPLE.COM", "USER_36_3652", "GjB54KJWGcKNitUGoA29RyLpnTyJWyPeVc4A4FwdPL1Q5elc6/plEtPQ1c545mR/", "user_36_3652@example.com", "user_36_3652" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_4eab@example.com", "user_37_4eab@example.com", "USER_37_4EAB@EXAMPLE.COM", "USER_37_4EAB", "qmBprZFQCbfHhc0Z7Mnt2iKnyiZtO2Z3Mw1fpzHvJPTn+1z4Y38Iloepa+I7rxBt", "user_37_4eab@example.com", "user_37_4eab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_190e@example.com", "user_38_190e@example.com", "USER_38_190E@EXAMPLE.COM", "USER_38_190E", "9Jp1RmEhq88L2y5QHFEnRIpTbcpLbA3CEy/IHdmdy4e81EN3DJn3HoD6ktt2MTKN", "user_38_190e@example.com", "user_38_190e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_53ba@example.com", "user_39_53ba@example.com", "USER_39_53BA@EXAMPLE.COM", "USER_39_53BA", "LYXdIWFff5e+uOgYn0+3kp+c4MTWRhUunCTWJ3fo0Sp3Pfmh35WZkWreiwT1be8C", "user_39_53ba@example.com", "user_39_53ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_c5a4@example.com", "user_40_c5a4@example.com", "USER_40_C5A4@EXAMPLE.COM", "USER_40_C5A4", "C9sOMGH8ziKqW2UeVjbwsDgHimEa19aT1fQwn3StdXVfZJJjhtUm0u1dI/X1KzPD", "user_40_c5a4@example.com", "user_40_c5a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_da8a@example.com", "user_41_da8a@example.com", "USER_41_DA8A@EXAMPLE.COM", "USER_41_DA8A", "k/xo4rJPa7PlMuuBdzaWngflhPTctR+0U/QtOk23qQiWDCbRxEo/PrsjlwdfwQlj", "user_41_da8a@example.com", "user_41_da8a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_ea20@example.com", "user_42_ea20@example.com", "USER_42_EA20@EXAMPLE.COM", "USER_42_EA20", "SUSEaOKtXCI08nhdUfzYPNpBn/UjNyW//np42TMpHexoX2kJownT4ETZDXHvTbj2", "user_42_ea20@example.com", "user_42_ea20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_7fa1@example.com", "user_43_7fa1@example.com", "USER_43_7FA1@EXAMPLE.COM", "USER_43_7FA1", "C6s9RVGLluhJAvPcWs6mMN2ktnqs42qQJdGAiPawT3oq00608cpcbBZYt80l0dCv", "user_43_7fa1@example.com", "user_43_7fa1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_594c@example.com", "user_44_594c@example.com", "USER_44_594C@EXAMPLE.COM", "USER_44_594C", "LGEs+TUNW7UB+mCvmkYAHjw7tD9d9k/4wDl1NZ1y9HVlI7w4rNqkXaujZtMSl1hs", "user_44_594c@example.com", "user_44_594c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_cab6@example.com", "user_45_cab6@example.com", "USER_45_CAB6@EXAMPLE.COM", "USER_45_CAB6", "0Lt914cDw62yNm6jrFhB2+0IOOk73pRE4qaD2YZF+xXE8W8u5ZOYxpG9XGGYIFj8", "user_45_cab6@example.com", "user_45_cab6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_7d3e@example.com", "user_46_7d3e@example.com", "USER_46_7D3E@EXAMPLE.COM", "USER_46_7D3E", "8pIngPE+FWxNKszTgJp30jPo+wQ/tZpQezxAbwZxrFVlgv6uzy6i60l7GqGU6mDu", "user_46_7d3e@example.com", "user_46_7d3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_7e67@example.com", "user_47_7e67@example.com", "USER_47_7E67@EXAMPLE.COM", "USER_47_7E67", "umCqeJxA4EtqSIZ6rGQQGlvd4IM/CZNZC/jyzeT9zrGZBFDHOjaoVcLN+88jIe77", "user_47_7e67@example.com", "user_47_7e67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_80dd@example.com", "user_48_80dd@example.com", "USER_48_80DD@EXAMPLE.COM", "USER_48_80DD", "oTBt3/6O4vP1F3T8qPGYW6qXy/DtbVW+5evizhogC46QcU4qoVKHLqOCJTg2F5GR", "user_48_80dd@example.com", "user_48_80dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_c4a4@example.com", "user_49_c4a4@example.com", "USER_49_C4A4@EXAMPLE.COM", "USER_49_C4A4", "Sq9FQwzGSDo3Z5wsGnlWqj9xdPxti9XBmO054brWv1UqcW4rBOs2GlRkhLHv+u9m", "user_49_c4a4@example.com", "user_49_c4a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_b2fe@example.com", "user_50_b2fe@example.com", "USER_50_B2FE@EXAMPLE.COM", "USER_50_B2FE", "MEDaJwOxNnn1Tzc/M0nVYgsl8C4DcqUPP7pmTmkJNaZNoD/L69tVTCRFzW7YRk3q", "user_50_b2fe@example.com", "user_50_b2fe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "UZynG9It5F5OEZBDRFivIriozPvGEKrwSJF+tmaDB7vlFaRZNMujNPJrwZcX59Qz");
        }
    }
}
