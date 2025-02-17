using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixDynamicValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06c8a551-c8c5-49cd-b643-c1a3971a1859"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36a3043a-b8d1-4e79-8c5e-619fc3392d8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d28ea38-e147-4360-b0af-19a88135d6f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("778154a8-7a17-4fad-b70c-04390b7269ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f60492c-f6d6-4b01-95c7-2d344f4131c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a595695e-7244-4dba-91da-ef65d950d6a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b185d158-017e-438f-9084-1f52943931a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c170a298-0f10-457a-884d-fe4828eb9d1c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8fec41b-acd7-460d-b387-477ab8b893e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0e8c398-9641-4198-a35e-af4c8cbf894d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3ea535f6-e9c7-4203-928d-2662d5f8eaba"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6393799a-4356-43b7-ab67-fee9a3b76eae"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6deefca2-8c56-453e-ab03-ee777f61187b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b9981069-f25e-4b60-8b7e-ae63f6844ef7"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("055e9e01-e069-42d2-94cb-4e0c75f2fbd9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("70a7c311-d893-4dce-8ea9-e919c11a88a6"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ace5e81f-42da-42ef-90a1-dc8a770c8103"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("eb319d94-2c87-4db3-aecb-bb35c30b6d3f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0fd17864-0a05-4134-97c8-e5788d06284c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("32ad67d2-1c3c-4054-b74b-6147620f8eee"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("64284b75-1b9c-4696-b1da-cd9bfd44897b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9741619e-0617-4fd4-9b06-69f430fc0d3f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ab1c444d-d4aa-4062-93a9-c0640063ad47"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d2ea900f-5cf0-4730-9029-db46f160257e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("2afb9d8a-0632-44d6-9b84-9d2fdd45286e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d4dc5d6-dc85-414f-843f-a2dbf413fa03"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4d38ea0e-1978-4ca2-84c4-82a6e241adc4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("83793248-a7da-4910-8874-ba32daa8e31b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8eaf27f8-ae32-4593-b1b8-fadcdd0ef1b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9f22226c-5b44-4a9c-88ff-4b0e7f172979"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c7766dfb-fefa-41fe-a936-4b9ef505dffb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0b941b36-14a8-493c-971d-c5429ddd35cd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("137af052-56e7-454b-bfe2-30c187c29ed5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("33c48aeb-01fd-4e44-8a72-0d1706eef070"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("53468b15-3b44-4927-acb8-2a5cbed415c4"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("361211cf-b50a-45ba-9eac-4e8fc8bc32ee"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("4453b21c-2b72-4f74-998d-a0d2ab98d09b"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("62e9040b-0376-4bd9-8404-0f14c8199ea7"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("8944f0c6-4566-488a-a1e4-0d192c08f6c6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("d2ec402e-7000-48bd-b290-43ffffdf70d0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1dd7f781-a870-4b61-b855-6a5e9792fe54"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("27736283-a5eb-41aa-9f8c-f3295430d698"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ffe9503a-9b24-4875-8ef6-9ef423bcd1c3"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("396b7360-0760-480f-8582-4253c2564b18"), "Rome", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9201), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("3a7a0867-b04d-4180-9625-e65899b4a2f2"), "Luxembourg", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9232), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("3b85a039-5956-42d9-bdf9-9347b8884fa0"), "Paris", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9167), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("473f82b4-1028-4ff1-9d4e-fd609e7dd47d"), "Berlin", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9176), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("51b8ff4c-d912-40dc-a1b2-07a84254a55b"), "Vienna", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9224), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("62c7c039-4adb-4026-8f09-2e603d13b8a3"), "Brussels", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(8929), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("a1d5a8b0-a23f-4a5b-96c3-7c222acc9b94"), "Amsterdam", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9185), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("dbc5b3eb-c2fd-4a3f-a5d0-3294b604e5d6"), "Madrid", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9209), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("e744222f-471c-4e4a-83a1-8e15431efbfe"), "London", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9193), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("f6846cb7-90ab-4951-ad67-67e9df3ff7fc"), "Bern", new DateTime(2025, 2, 17, 10, 49, 9, 732, DateTimeKind.Utc).AddTicks(9217), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0014aee9-ad30-40d9-be5b-88afd0779ccf"), "EUR", new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(3057), 2, true, "Euro", "€", null },
                    { new Guid("7e32f51e-90cc-4a8c-93f9-9f4ce1f5e154"), "USD", new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(3626), 2, true, "US Dollar", "$", null },
                    { new Guid("842dd16d-a75a-446a-b46c-ed2349467855"), "GBP", new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(3640), 2, true, "British Pound", "£", null },
                    { new Guid("aede3ab6-a612-4a8f-8796-e872216872aa"), "CHF", new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(3649), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5a4540b1-9525-4b2f-93f5-38d870ae50a0"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(2216), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("8a19c6cc-b855-4012-88ae-936b32512390"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(2229), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("c03f91a8-4354-4c04-9b72-ad568cf4c93f"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(1323), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("d863c296-1c4e-403c-9ff5-406c825d0156"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(2187), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("421880fb-5204-45b5-b555-7d3beb5c7c1e"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(8932), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("53513d05-0770-42b3-965d-c78ea7ba229d"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(7951), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("6d2f45c6-f258-442c-8833-46988aefb58e"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(8941), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("9afc09f5-4f3d-4e1e-b540-bd0c6796bf87"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(8956), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("dd41d1b3-24ee-4436-9bb3-939e826cf489"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(8948), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("de7f2baf-288e-4558-98b0-0040e4ace0c6"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(8911), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("ccc5fee1-798c-4e8a-af2d-5fd62554c4b3"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(9590), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5ad63c9f-6699-4d4d-bf7d-65bfb7ac3a63"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(6760), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("6e58fcb7-476a-4d73-a6da-c5479c905672"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(6767), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("8faab8ce-7fde-4b59-80d4-cc6dc8bf154e"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(6737), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("92184ec0-a5bf-4ce6-9141-0f80c3a25e08"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(6751), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("ae988741-9be7-4523-adb6-9030ab0e9215"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(6775), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("e9409f40-b12c-43b5-b2d0-2e8343dc62b0"), new DateTime(2025, 2, 17, 10, 49, 9, 728, DateTimeKind.Utc).AddTicks(6147), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b555e7a-4ff7-416f-ab31-dbdd34e29cb4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("343f0de1-80f0-4819-92c3-8d5a35dc03b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("6d0e0f00-6097-43e1-986e-777ab6f9c6ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("89b795b2-02e6-40c2-bcec-615a3a940bb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("1aa4e3c7-96db-4fc6-8da9-bd7fad50bd72"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(5243), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("651bd8f9-ad8e-41f3-9ef6-233b7b3029d8"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(4224), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("994aeb3c-38f2-4e6e-a8fb-ae879362f334"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(5253), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("aeb392c1-acc3-4ba9-a6f0-ca0f6c6bbf38"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(5202), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("f1f6c6ab-a8c1-41c8-9e4b-7458f1f5b4bc"), new DateTime(2025, 2, 17, 10, 49, 9, 729, DateTimeKind.Utc).AddTicks(5231), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 17, 10, 49, 9, 733, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("81ad75f4-2a5f-4c0b-8efd-3a345c9fff76"), new DateTime(2025, 2, 17, 10, 49, 9, 733, DateTimeKind.Utc).AddTicks(3636), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("de7c68ff-b8b4-4e1e-9942-0d6675798a89"), new DateTime(2025, 2, 17, 10, 49, 9, 733, DateTimeKind.Utc).AddTicks(3648), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("e9932ff4-0049-41ba-bc35-1c9425909201"), new DateTime(2025, 2, 17, 10, 49, 9, 733, DateTimeKind.Utc).AddTicks(3460), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 10, 49, 8, 765, DateTimeKind.Utc).AddTicks(1958), new DateTime(2025, 2, 17, 10, 49, 8, 765, DateTimeKind.Utc).AddTicks(1930), "zQyXgrDx5iQLk8v+5OeF5aAHwEA+5looBL8XoQVSuWmZSCWYbrFSHUSYnRsH1eTq", new DateTime(2025, 2, 17, 10, 49, 8, 765, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 10, 49, 8, 794, DateTimeKind.Utc).AddTicks(5703), new DateTime(2025, 2, 17, 10, 49, 8, 794, DateTimeKind.Utc).AddTicks(5673), "fKUJn9e72QeIghtGHWPw6A6Hz9PXFeKievsod3nDkn4h5nVrel4peb/6hSdQRMr4", new DateTime(2025, 2, 17, 10, 49, 8, 794, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_a558@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_1_a558@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_1_A558@EXAMPLE.COM", "USER_1_A558", "QmH+2VYWvaSeMqeP4tCSn839GRWAaadUiY6r0qM1X3U4PdmJPLVsseg/hSon6rQu", "user_1_a558@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_1_a558" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_a986@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_2_a986@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_2_A986@EXAMPLE.COM", "USER_2_A986", "h+dw598g9oExgHOnq0pQpqLT71ciwTQOU6vyC11AsiMWd2MPsJXNkwZ2XAKULKxt", "user_2_a986@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_2_a986" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_b029@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_3_b029@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_3_B029@EXAMPLE.COM", "USER_3_B029", "f9u4OiFPy0lIR2uv2NJgxErH3rVjqASzHUO7YQh3ZJhMl6LLYNqGgbF5uU4hmmC7", "user_3_b029@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_3_b029" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_fb14@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_4_fb14@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_4_FB14@EXAMPLE.COM", "USER_4_FB14", "6CiXCjZ7YgbSMNzbcsTkMgLAg3e4+fUOfPQ3vcJeriYML5WbKgPUuaFQhnQSR//W", "user_4_fb14@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_4_fb14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_54e1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_5_54e1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_5_54E1@EXAMPLE.COM", "USER_5_54E1", "jLC9ZkEskehkXpbBbiZVTuWfQ47RYFfgv8xzKnLQ4bquDO1E6EFS/WE7y+omFv9z", "user_5_54e1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_5_54e1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_4f82@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_6_4f82@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_6_4F82@EXAMPLE.COM", "USER_6_4F82", "yAwZ/hCo42jHhFLTTQth+lqh56nHEoF6AqisdCi1OxSDKX5nDWaWFm9xXFDG89ah", "user_6_4f82@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_6_4f82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_e05f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_7_e05f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_7_E05F@EXAMPLE.COM", "USER_7_E05F", "3H02+jHvDWEbKhAOQTHQESmxbupN89Cc/Y9gOL+J1O2czuvVEgrR6Bh4VJ9xglcN", "user_7_e05f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_7_e05f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_feca@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_8_feca@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_8_FECA@EXAMPLE.COM", "USER_8_FECA", "CXsIHiqkVrRoeBZ+z9+721miEDKNKjksk1Sk6DNfrvcdq3jzqwq+gEjAHioMylUN", "user_8_feca@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_8_feca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_8c72@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_9_8c72@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_9_8C72@EXAMPLE.COM", "USER_9_8C72", "1PWp7CtWdc7W9AtnMgQ8Rexcp4tV68tqvWFniQLrJ3GQ7fmDxGGxUvGrfd7CvKWA", "user_9_8c72@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_9_8c72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_73e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_10_73e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_10_73E7@EXAMPLE.COM", "USER_10_73E7", "agoRQCVs73+ITefATLlhCxYlC2oYnlshG9Au57J+qQRA7bLOcbcWA5v4IGurkDJx", "user_10_73e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_10_73e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_11_a323@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_11_a323@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_11_A323@EXAMPLE.COM", "USER_11_A323", "Zm7J9EwAAfKZl4iaser0rnnKASCjGMKmgFU13q3oPWmeofrHHWKls9aYl7Hjydkd", "user_11_a323@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_11_a323" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_12_1cca@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_12_1cca@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_12_1CCA@EXAMPLE.COM", "USER_12_1CCA", "8UKi7T0qomUk3cTh7Bd3AXayybi1oIOIiFvrSpIWGi1PCORQ6951097zY3H8OjE3", "user_12_1cca@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_12_1cca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_13_9550@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_13_9550@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_13_9550@EXAMPLE.COM", "USER_13_9550", "0JLidWIAxOpm1sbySb8DdXFi6pQ2AaObdKtMlj5ZIgPh1SkN2JN7ad7WHf20XA2g", "user_13_9550@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_13_9550" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_14_ada4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_14_ada4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_14_ADA4@EXAMPLE.COM", "USER_14_ADA4", "QbNBSZNZxipwiFF16o38U5Szz38PXjK5cQ0Onf3LW9W+DS8o7jkw4bJzZ/dSHPGV", "user_14_ada4@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_14_ada4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_15_e392@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_15_e392@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_15_E392@EXAMPLE.COM", "USER_15_E392", "HoTe9Bp0N17aW0UggU2jyeXeNtWcsO4RKX9U1D3acSy4uUb5QiFiM+Xx2NtRWFqn", "user_15_e392@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_15_e392" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_16_c0f1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_16_c0f1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_16_C0F1@EXAMPLE.COM", "USER_16_C0F1", "7h2fA3HwJoUAUwQSD0gCH9NSfthsPHksN6UeHoUjU/B4NnieZBXbZ5FwBOzo9WN2", "user_16_c0f1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_16_c0f1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_17_f7ee@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_17_f7ee@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_17_F7EE@EXAMPLE.COM", "USER_17_F7EE", "IZf6sqMg44yYTJAXUryV11/wFZsnk3rhqOwcH5Hzje3hGNk5rITAWkxNPPcN2/lt", "user_17_f7ee@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_17_f7ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_18_47ef@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_18_47ef@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_18_47EF@EXAMPLE.COM", "USER_18_47EF", "IxXXbX4s/NrIiq3FRnaxfY8fQ60kJfF+Nmqrxi9h/V06UDklB4u0wnwVQUijAbCV", "user_18_47ef@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_18_47ef" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_19_fc8c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_19_fc8c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_19_FC8C@EXAMPLE.COM", "USER_19_FC8C", "BuGvNxWu7pPZ2Tc/VPhYrPeiCfk++m60BQ22FJGoUeCgUQjBKpA889Zg2+wkx96c", "user_19_fc8c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_19_fc8c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_20_674d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_20_674d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_20_674D@EXAMPLE.COM", "USER_20_674D", "7NO9I9CdUxSnZDKSckqyUrrKEmj8HRX7PVexWorT0CGNzUzqUgQezFdVHTjqCTfE", "user_20_674d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_20_674d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_21_26f1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_21_26f1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_21_26F1@EXAMPLE.COM", "USER_21_26F1", "HuFHb1MamPfRV0roqMymYHO9ZYlGEvnvGTNy4Yb5+DTWPWnnoddNAEclgwWNJFF+", "user_21_26f1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_21_26f1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_22_16b7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_22_16b7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_22_16B7@EXAMPLE.COM", "USER_22_16B7", "3Ca+/oq+QbkUasmIkRsBH8PVGpU1M4yhwSyC9s56Mht6Dqbz3Q7XH8JDHybeEmui", "user_22_16b7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_22_16b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_23_492b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_23_492b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_23_492B@EXAMPLE.COM", "USER_23_492B", "1PkehuoeChoP6KIaEXc1fcHZvMYiuhbFdKnU/40On2Pq6un1Nn5CAfG2qZ6ChV79", "user_23_492b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_23_492b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_24_2f5b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_24_2f5b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_24_2F5B@EXAMPLE.COM", "USER_24_2F5B", "u594fd4SmT9MpSm7Hee+gsIhK5sBxqhig8dK172vQGbILXJp9v2J20Nbnbi6uhlk", "user_24_2f5b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_24_2f5b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_25_e7e2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_25_e7e2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_25_E7E2@EXAMPLE.COM", "USER_25_E7E2", "HryWrle/d2kYDhMWF0kl4EHvyCTzL2qz7GM88kUWQfbCXHlBOH3xnnnS6N5J5D85", "user_25_e7e2@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_25_e7e2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_26_694d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_26_694d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_26_694D@EXAMPLE.COM", "USER_26_694D", "/DasPkFGum0A13kTzf7PVRhN6wFPjYX82xsiNtgUddSjpdVykgY9Rot0KrchJKy0", "user_26_694d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_26_694d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_27_9e1f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_27_9e1f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_27_9E1F@EXAMPLE.COM", "USER_27_9E1F", "i5+x2/kkPPRM6rFxmpg2o0F4ZG36LsLxlnbDQ+gmceDmefU4uzSEcKhfaTJhYNV9", "user_27_9e1f@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_27_9e1f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_28_4b39@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_28_4b39@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_28_4B39@EXAMPLE.COM", "USER_28_4B39", "O6dJc6mlc0faPlhmkv0JQ6xYFieihtPgRsgpN5Va8M/JQlWWYcBRtwLCqCLH/xIL", "user_28_4b39@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_28_4b39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_29_9ccc@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_29_9ccc@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_29_9CCC@EXAMPLE.COM", "USER_29_9CCC", "90HViSH4rLKB/zj6tZP/2ZafqRSlM2KKFsh1+mKRHfRudE99pkdjj4tBnf8BrMce", "user_29_9ccc@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_29_9ccc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_30_72e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_30_72e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_30_72E7@EXAMPLE.COM", "USER_30_72E7", "uo69/TmamtS7JBOJL79+TF1icOHGan3WtpfKUBdQ+L52HccB+EfXeURqEDCUDPCt", "user_30_72e7@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_30_72e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_31_9ab6@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_31_9ab6@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_31_9AB6@EXAMPLE.COM", "USER_31_9AB6", "1vjIcXQGxh7e7F0iUrJlDIsO7YSwZtKzwqWE2yffgPD5sWodXSOU0hGEIMo6gf63", "user_31_9ab6@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_31_9ab6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_32_9d8d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_32_9d8d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_32_9D8D@EXAMPLE.COM", "USER_32_9D8D", "ur/b/nrlx2q8qpiwcfrIzHfZKj93Cq1KfP01LM5Xhpp9E3r+2D87DWouZA4ZItnR", "user_32_9d8d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_32_9d8d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_33_5f3d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_33_5f3d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_33_5F3D@EXAMPLE.COM", "USER_33_5F3D", "vahLyOLj/cDUr5UXnFUy1A6D6JC1eCQKWf0DRcg5b/5YeQQoNaq86i61K4bCmqE4", "user_33_5f3d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_33_5f3d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_34_fbe5@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_34_fbe5@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_34_FBE5@EXAMPLE.COM", "USER_34_FBE5", "5mVplbKkbj2LppTNt7qEYk/qgX6f373amzkR3+ayR3fYeXfGST4Im7RjKD/GJKEE", "user_34_fbe5@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_34_fbe5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_35_76a5@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_35_76a5@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_35_76A5@EXAMPLE.COM", "USER_35_76A5", "uXyc38Ppl9kggBp2o7g2tMKPBj0l4Ex1ZFfsN/XNZzFqNzIfzkKd6K/iAprKY2AZ", "user_35_76a5@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_35_76a5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_36_5a02@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_36_5a02@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_36_5A02@EXAMPLE.COM", "USER_36_5A02", "ZAsAEL1Le1jGeqHxtbDdtuNwy8TvzHUYSEgSZi9CBbkQGHGLldi6KGRKQlKPv30i", "user_36_5a02@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_36_5a02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_37_2297@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_37_2297@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_37_2297@EXAMPLE.COM", "USER_37_2297", "IrLPlB+RaXTWRzUO21EDWGHbhG3JncPDa/TEDlK8YZ7vw5adBUEb1e644Ya3X1At", "user_37_2297@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_37_2297" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_38_838c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_38_838c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_38_838C@EXAMPLE.COM", "USER_38_838C", "bTftvAC6K29pXuO1haXl3WHJkkeB2k1uJ37crYHdJOCAmMVNZklZJLMWMD/gs2MH", "user_38_838c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_38_838c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_39_59be@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_39_59be@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_39_59BE@EXAMPLE.COM", "USER_39_59BE", "gHWnJMaqH3tVJ09a1Mo9cw0StkkrVppoi/UbzTV/3f9cC5LCAOmKJr3De0XaOxZu", "user_39_59be@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_39_59be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_40_664b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_40_664b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_40_664B@EXAMPLE.COM", "USER_40_664B", "kydfk0IBbIJIAaF3BmXk3nnXENxmyaZKtegZ9zsqLDfowOT0uC/9VYPndR+rxIgU", "user_40_664b@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_40_664b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_41_b975@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_41_b975@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_41_B975@EXAMPLE.COM", "USER_41_B975", "mBAIB2ZA4QdUGeNkmVpBMq0p3e5G/hec5AV3iw2HCBzEb7zD569gR7jmXvDuAJus", "user_41_b975@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_41_b975" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_42_8b5d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_42_8b5d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_42_8B5D@EXAMPLE.COM", "USER_42_8B5D", "KyriBcZdntVoBt034x4BuR4TTVoNY/b1SbyRQtwgaXYp0oe0rbXayhJVJviterI7", "user_42_8b5d@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_42_8b5d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_43_f1e1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_43_f1e1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_43_F1E1@EXAMPLE.COM", "USER_43_F1E1", "NVt0XIGR0COPqNzyVxVH8f6AFs2nFyTU9JciGgSrkA4q253fVTNtks7dLynXZdzL", "user_43_f1e1@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_43_f1e1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_44_06fd@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_44_06fd@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_44_06FD@EXAMPLE.COM", "USER_44_06FD", "CUBKe6q3BXQFrK8XYdQXNlNbDmrioWb5Eo0889gzZTH8ilnoQMUTIJd6HNFqdgmD", "user_44_06fd@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_44_06fd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_45_f34c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_45_f34c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_45_F34C@EXAMPLE.COM", "USER_45_F34C", "OuFK29WcQjPCBfW830HEq93rl1BDewdN+UW+dHT0eL5ae8Lf1C0zLGj0p8xnfhjq", "user_45_f34c@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_45_f34c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_46_fda3@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_46_fda3@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_46_FDA3@EXAMPLE.COM", "USER_46_FDA3", "qY5JOM3j3ZTWv2Rra/zTBHk7mGFtdGwd7cDxTfiMCftbO1V+OavoXK1x37Ypxra2", "user_46_fda3@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_46_fda3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_47_a7c8@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_47_a7c8@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_47_A7C8@EXAMPLE.COM", "USER_47_A7C8", "BlfGz1Ut/KZiJsH+Dw2SI7pWt4X8/Y3JI/ucycrdTnqrjNy/MVDW4TKYFGrvexB4", "user_47_a7c8@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_47_a7c8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_48_8754@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_48_8754@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_48_8754@EXAMPLE.COM", "USER_48_8754", "kiKaOyNN22t/P/M5RuugYM3yV8LDOYE5A6B4LKqPm6XKjGEBTRjsaToNKb5PyqYz", "user_48_8754@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_48_8754" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_49_7265@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_49_7265@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_49_7265@EXAMPLE.COM", "USER_49_7265", "Ut7FXrJ7ZBw2OkdlYrhP9sR9LTmIn5eZ8V/atoBpa7R9ukehLQZfAQDTX0+XFIxE", "user_49_7265@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_49_7265" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_50_c254@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_50_c254@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "USER_50_C254@EXAMPLE.COM", "USER_50_C254", "sKbalvCN3T2odhuPBbeXJ4BG79xczYo0R+wVw35i6cuHU4jj/vSBPcz41MUwgy04", "user_50_c254@example.com", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "user_50_c254" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 10, 49, 8, 715, DateTimeKind.Utc).AddTicks(8822), new DateTime(2025, 2, 17, 10, 49, 8, 715, DateTimeKind.Utc).AddTicks(6733), "fKRU3+sJWXI4Ty9cdR2cc6NUYaeb9F6eJRE9QM0LC3iPGlnJ8Q6wS19Dz4X4PAG7", new DateTime(2025, 2, 17, 10, 49, 8, 715, DateTimeKind.Utc).AddTicks(9267) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("396b7360-0760-480f-8582-4253c2564b18"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a7a0867-b04d-4180-9625-e65899b4a2f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b85a039-5956-42d9-bdf9-9347b8884fa0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("473f82b4-1028-4ff1-9d4e-fd609e7dd47d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51b8ff4c-d912-40dc-a1b2-07a84254a55b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62c7c039-4adb-4026-8f09-2e603d13b8a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1d5a8b0-a23f-4a5b-96c3-7c222acc9b94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dbc5b3eb-c2fd-4a3f-a5d0-3294b604e5d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e744222f-471c-4e4a-83a1-8e15431efbfe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6846cb7-90ab-4951-ad67-67e9df3ff7fc"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0014aee9-ad30-40d9-be5b-88afd0779ccf"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("7e32f51e-90cc-4a8c-93f9-9f4ce1f5e154"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("842dd16d-a75a-446a-b46c-ed2349467855"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("aede3ab6-a612-4a8f-8796-e872216872aa"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("5a4540b1-9525-4b2f-93f5-38d870ae50a0"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("8a19c6cc-b855-4012-88ae-936b32512390"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("c03f91a8-4354-4c04-9b72-ad568cf4c93f"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d863c296-1c4e-403c-9ff5-406c825d0156"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("421880fb-5204-45b5-b555-7d3beb5c7c1e"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("53513d05-0770-42b3-965d-c78ea7ba229d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6d2f45c6-f258-442c-8833-46988aefb58e"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9afc09f5-4f3d-4e1e-b540-bd0c6796bf87"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("dd41d1b3-24ee-4436-9bb3-939e826cf489"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("de7f2baf-288e-4558-98b0-0040e4ace0c6"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("ccc5fee1-798c-4e8a-af2d-5fd62554c4b3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5ad63c9f-6699-4d4d-bf7d-65bfb7ac3a63"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6e58fcb7-476a-4d73-a6da-c5479c905672"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8faab8ce-7fde-4b59-80d4-cc6dc8bf154e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92184ec0-a5bf-4ce6-9141-0f80c3a25e08"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ae988741-9be7-4523-adb6-9030ab0e9215"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e9409f40-b12c-43b5-b2d0-2e8343dc62b0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0b555e7a-4ff7-416f-ab31-dbdd34e29cb4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("343f0de1-80f0-4819-92c3-8d5a35dc03b4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6d0e0f00-6097-43e1-986e-777ab6f9c6ca"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("89b795b2-02e6-40c2-bcec-615a3a940bb0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("1aa4e3c7-96db-4fc6-8da9-bd7fad50bd72"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("651bd8f9-ad8e-41f3-9ef6-233b7b3029d8"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("994aeb3c-38f2-4e6e-a8fb-ae879362f334"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("aeb392c1-acc3-4ba9-a6f0-ca0f6c6bbf38"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f1f6c6ab-a8c1-41c8-9e4b-7458f1f5b4bc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("81ad75f4-2a5f-4c0b-8efd-3a345c9fff76"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("de7c68ff-b8b4-4e1e-9942-0d6675798a89"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e9932ff4-0049-41ba-bc35-1c9425909201"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06c8a551-c8c5-49cd-b643-c1a3971a1859"), "Rome", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2874), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("36a3043a-b8d1-4e79-8c5e-619fc3392d8a"), "Bern", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2883), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("3d28ea38-e147-4360-b0af-19a88135d6f7"), "London", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2871), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("778154a8-7a17-4fad-b70c-04390b7269ae"), "Brussels", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2440), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("7f60492c-f6d6-4b01-95c7-2d344f4131c1"), "Paris", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2863), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("a595695e-7244-4dba-91da-ef65d950d6a2"), "Amsterdam", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2869), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("b185d158-017e-438f-9084-1f52943931a3"), "Madrid", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2880), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("c170a298-0f10-457a-884d-fe4828eb9d1c"), "Vienna", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2886), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("c8fec41b-acd7-460d-b387-477ab8b893e4"), "Luxembourg", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2889), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("d0e8c398-9641-4198-a35e-af4c8cbf894d"), "Berlin", new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(2866), true, "DE", "DEU", "Germany", "Deutschland", "+49", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3ea535f6-e9c7-4203-928d-2662d5f8eaba"), "GBP", new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(8233), 2, true, "British Pound", "£", null },
                    { new Guid("6393799a-4356-43b7-ab67-fee9a3b76eae"), "USD", new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(8227), 2, true, "US Dollar", "$", null },
                    { new Guid("6deefca2-8c56-453e-ab03-ee777f61187b"), "CHF", new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(8234), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("b9981069-f25e-4b60-8b7e-ae63f6844ef7"), "EUR", new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(7212), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("055e9e01-e069-42d2-94cb-4e0c75f2fbd9"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(6422), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("70a7c311-d893-4dce-8ea9-e919c11a88a6"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(5439), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("ace5e81f-42da-42ef-90a1-dc8a770c8103"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(6424), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("eb319d94-2c87-4db3-aecb-bb35c30b6d3f"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(6416), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0fd17864-0a05-4134-97c8-e5788d06284c"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2083), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("32ad67d2-1c3c-4054-b74b-6147620f8eee"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2067), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("64284b75-1b9c-4696-b1da-cd9bfd44897b"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(932), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("9741619e-0617-4fd4-9b06-69f430fc0d3f"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2085), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("ab1c444d-d4aa-4062-93a9-c0640063ad47"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2073), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("d2ea900f-5cf0-4730-9029-db46f160257e"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2079), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("2afb9d8a-0632-44d6-9b84-9d2fdd45286e"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(2883), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0d4dc5d6-dc85-414f-843f-a2dbf413fa03"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9767), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("4d38ea0e-1978-4ca2-84c4-82a6e241adc4"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9762), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("83793248-a7da-4910-8874-ba32daa8e31b"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9771), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("8eaf27f8-ae32-4593-b1b8-fadcdd0ef1b4"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9769), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("9f22226c-5b44-4a9c-88ff-4b0e7f172979"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(8773), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("c7766dfb-fefa-41fe-a936-4b9ef505dffb"), new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(9772), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b941b36-14a8-493c-971d-c5429ddd35cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("137af052-56e7-454b-bfe2-30c187c29ed5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("33c48aeb-01fd-4e44-8a72-0d1706eef070"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("53468b15-3b44-4927-acb8-2a5cbed415c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("361211cf-b50a-45ba-9eac-4e8fc8bc32ee"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(142), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("4453b21c-2b72-4f74-998d-a0d2ab98d09b"), new DateTime(2025, 2, 16, 14, 58, 30, 866, DateTimeKind.Utc).AddTicks(9038), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("62e9040b-0376-4bd9-8404-0f14c8199ea7"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(157), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("8944f0c6-4566-488a-a1e4-0d192c08f6c6"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(148), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("d2ec402e-7000-48bd-b290-43ffffdf70d0"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(150), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1dd7f781-a870-4b61-b855-6a5e9792fe54"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(7673), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("27736283-a5eb-41aa-9f8c-f3295430d698"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(7961), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("ffe9503a-9b24-4875-8ef6-9ef423bcd1c3"), new DateTime(2025, 2, 16, 14, 58, 30, 867, DateTimeKind.Utc).AddTicks(7955), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7224), new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7210), "nMzZyX9BL3fOz7xr19tm26hZSToATMS7FoTUHVH4yoFxfU5UqnxwYjOn0gSXyX5M", new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4759), new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4744), "6KEhQSe/8Q7X+/267eQwcU79b3IOqx6B4ZnlK+qIHqb2mk40hXiyJVUyUNljw2DM", new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7910), "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7906), "USER_1_332E@EXAMPLE.COM", "USER_1_332E", "3bu7OICkfpZ78Stk2cAc6Lu/ue/wZPMK8/kzWOI/GXd6N898FqB0nCd6Gh1VaA7q", "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7911), "user_1_332e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6661), "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6658), "USER_2_1D32@EXAMPLE.COM", "USER_2_1D32", "sY6TzmtYfeRstuEMMgmxbov0p2O/G9K3DzO6hiqlTh1BfGhkAvvtGEae7faJAHeV", "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6663), "user_2_1d32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9521), "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9515), "USER_3_7EE4@EXAMPLE.COM", "USER_3_7EE4", "2IFuFA/vEQH6/RICZ41ehDjvb77Jc5L8mH/kMf9qahxvAnNAMVrysOsD+dkokeET", "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9523), "user_3_7ee4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5941), "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5937), "USER_4_655B@EXAMPLE.COM", "USER_4_655B", "8YYignsoCTPPIte7WPen6P5rEj7os1p5usont1i6vX/2uslcgN53iImI4cs9g6JC", "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5944), "user_4_655b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3128), "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3125), "USER_5_306B@EXAMPLE.COM", "USER_5_306B", "rzoISCS5cHPJ8a8coWTsFLVCI3hMUKUmc3rugHGKAiAmexBAC+FJoPipQ+pJieN5", "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3130), "user_5_306b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4170), "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4167), "USER_6_5CF7@EXAMPLE.COM", "USER_6_5CF7", "oSFkIc5cwOSufrOolw1+K67vJPmlQye5vbn7saa6GwNQ9FBwbWMl0nvqiv+Na/uP", "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4171), "user_6_5cf7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3840), "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3836), "USER_7_82D8@EXAMPLE.COM", "USER_7_82D8", "crkIYykeuzGNfUJll6B6kCA0XfDiIJwIqMCRCSpX8DDTpCEgvJ/JWYcc4RD8TQJ+", "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3842), "user_7_82d8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7593), "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7587), "USER_8_D28D@EXAMPLE.COM", "USER_8_D28D", "ZIeT0UNMHDmmDpAvzFnoXpJE+1ERKoUH+jtGoOt7N/49ubewuj/IjNBsjifT5uB7", "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7594), "user_8_d28d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2185), "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2180), "USER_9_7E20@EXAMPLE.COM", "USER_9_7E20", "vrm5E09OoHMnozqcWCV5hk9C1cCwpL3LQv/MpPN9L0Ck0Eq9nt7sDP0DjH7CvXIj", "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2186), "user_9_7e20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7730), "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7726), "USER_10_C6AD@EXAMPLE.COM", "USER_10_C6AD", "RjUhvqmj/R2xYdw3Fh5lqrJQnr06sWLrlHhV1Q7icscx2km/yj47ibQ5ZEsPCGtc", "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7732), "user_10_c6ad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4701), "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4698), "USER_11_DBA4@EXAMPLE.COM", "USER_11_DBA4", "TGJvWfxL1npRHKFS+nw2DcP4dDWd4nslVXsO/WTTnTQU37EfVTUg6jwawNNplL1d", "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4703), "user_11_dba4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(815), "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(810), "USER_12_AB1A@EXAMPLE.COM", "USER_12_AB1A", "LI6IZQH8UP7PNVzQBq1z43UMZX03hYSpWsHGTu08L7wO0sZvpcOHi+vccGqr9KNX", "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(816), "user_12_ab1a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8592), "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8586), "USER_13_9921@EXAMPLE.COM", "USER_13_9921", "msX+c1AtcYQ2xy5HeSw2cfQSmbbAAM9JM/NSQ10Ip3mbrwQWh3plBGlDs5R1TipQ", "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8593), "user_13_9921" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4155), "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4151), "USER_14_9B76@EXAMPLE.COM", "USER_14_9B76", "IVk1pa5K0tYTOQpND3+ea5ioPeBgmLcDwLOE9OyDU0mAqG7BbiZQWSATe3b6duPm", "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4156), "user_14_9b76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6751), "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6747), "USER_15_9588@EXAMPLE.COM", "USER_15_9588", "v+lcUKFZK7dgcL7QvcHPSOBS9dp0pY//J6Tls5bAH8N+Iblv9df7nWH6dFZDBlAI", "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6752), "user_15_9588" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6959), "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6955), "USER_16_AABA@EXAMPLE.COM", "USER_16_AABA", "1fqdyEqNAx8/dUa5KUprS+C3ZnJxOvTlDvLoexb2rUph9qJRFvU4h3gtgZO0sx+x", "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6961), "user_16_aaba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8146), "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8138), "USER_17_DAAC@EXAMPLE.COM", "USER_17_DAAC", "0Pf1v0gxtKk23P8i+2UtnqhiGnIK9tR5cyDKUg11+wAbCS/uSuAqnGPNB4Daw7HH", "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8149), "user_17_daac" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9626), "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9620), "USER_18_425D@EXAMPLE.COM", "USER_18_425D", "89e/jgRr8dd+368apHERuZPY9sEyP3meS3Xj/nMY+itcuUn7R39hXyHCCXZn+31p", "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9628), "user_18_425d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2132), "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2128), "USER_19_37B1@EXAMPLE.COM", "USER_19_37B1", "5Thiy90jgTr9Wv+Vm4eZXUXh2VpfVWOCAOXI/jjixstOMrroKzNeJvwSAz6PJHyM", "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2133), "user_19_37b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3798), "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3790), "USER_20_A0C7@EXAMPLE.COM", "USER_20_A0C7", "WcGiw4bkfHrsXMMr5Z2j5ISIVc0GEBZpbkKVeDQ6OawK0GcXquthJOUOINmhdurQ", "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3803), "user_20_a0c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2140), "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2135), "USER_21_84C9@EXAMPLE.COM", "USER_21_84C9", "7xGXTs5cGlRAX2McvYm9reOwVJqGpSye18cXzzWMY0LlQWTrto38wmJb9EKrgoEg", "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2141), "user_21_84c9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4648), "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4644), "USER_22_6FE0@EXAMPLE.COM", "USER_22_6FE0", "D4PNw6C/BIRlVoH0kf0lnQu4L+0T0mEC6jvLD/POpF9nif6jB1FYUQUyIyz4pqCa", "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4649), "user_22_6fe0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6517), "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6513), "USER_23_273D@EXAMPLE.COM", "USER_23_273D", "j4TNxmwPQH9vJrBXuYNlrMF2TUIm/YYE8ZkjAAcBue08LeAfmqkUASSws9sZSZM3", "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6519), "user_23_273d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8015), "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8009), "USER_24_A0A3@EXAMPLE.COM", "USER_24_A0A3", "qLrlm9PLeovyx/0E6jqYJWnSqDIPKTSf2rSvI25dK9WgUb+ZHw3OvsU5XlgQyG8d", "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8016), "user_24_a0a3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(691), "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(687), "USER_25_2709@EXAMPLE.COM", "USER_25_2709", "76VidI8xon36d9sBhB5eoQDb3TeqVRz1w3nT91UNaE8ToYAaXluFlp9eje+/oNhh", "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(692), "user_25_2709" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5971), "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5963), "USER_26_F15E@EXAMPLE.COM", "USER_26_F15E", "c50iSrbzLdFKaCN91SLwJ2s6cbnZUZVezL133l4XxHdYPTDMxYOv8WtgvUVBtOZ5", "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5979), "user_26_f15e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2943), "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2939), "USER_27_786B@EXAMPLE.COM", "USER_27_786B", "8DZKLRBTQ6wM70+0h0wyfxi8Mb9HrhpEaF7fjAT4SA9SUqF20wrPYFFdzoUnRp6f", "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2944), "user_27_786b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3071), "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3057), "USER_28_B52F@EXAMPLE.COM", "USER_28_B52F", "YDJRVuMe3eRgcseJ0A9NQyM6WHRJFjZYW2z16pGq86dUFZpcsnG81KTCJU9xj5of", "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3074), "user_28_b52f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2036), "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2031), "USER_29_F37F@EXAMPLE.COM", "USER_29_F37F", "3VEH5hhuhpc9N02sH3It+mzEQO9ganXGDBGxGr3QKVZwQjph4AC+NyAKI8FbZ+/2", "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2038), "user_29_f37f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2924), "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2920), "USER_30_C4C7@EXAMPLE.COM", "USER_30_C4C7", "hLJR4djFmOlYBHPA7mxDPfB8LM0FynQOZh1ETweObvGJILgMERlKSrp/SO6GqmEh", "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2925), "user_30_c4c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9547), "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9543), "USER_31_18EE@EXAMPLE.COM", "USER_31_18EE", "4gS04y1Js5cZExm1uE4NXHbYpiZT+O2kJ7/n6a1Xt9y1OHBpsLSayqABGod5twpz", "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9548), "user_31_18ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1188), "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1185), "USER_32_06BA@EXAMPLE.COM", "USER_32_06BA", "WYDamRCmCqDCg0qs+fb+Mf6MQUp/Mf9gIAqIvSgGhej9P4xqjCr7N5SbUnddzfZb", "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1190), "user_32_06ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2822), "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2817), "USER_33_C69D@EXAMPLE.COM", "USER_33_C69D", "vJTmDgwRiBjgFfGvKRmlvIGr/OQdhWNK3hVfPHW5Wo98pxwf7kPrd8X6kqXXi0H6", "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2823), "user_33_c69d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2794), "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2790), "USER_34_3660@EXAMPLE.COM", "USER_34_3660", "zFOcJtfMa8fG8BmuMcrqTCbMSRxRlF9ONna/7+4oiXBoZqrz7tRRLWb13W22F3O3", "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2795), "user_34_3660" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9082), "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9079), "USER_35_1174@EXAMPLE.COM", "USER_35_1174", "q4+UOCYKGOGM6/Q0zpW4KY9AHfi1yXy/hUkPQateawiBbjBBGp9OcMfTSXy9nn1t", "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9084), "user_35_1174" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6124), "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6120), "USER_36_CE26@EXAMPLE.COM", "USER_36_CE26", "5TGWj+Dh/kz79iRmPQw0JqOG4s37KxzFR5nuYUxyHKabR2JD9Jx/iTTWgMTW6PWX", "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6124), "user_36_ce26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8051), "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8047), "USER_37_1CB7@EXAMPLE.COM", "USER_37_1CB7", "lz4ny9g+vyfgQVq50qW4dtZlf5RwKnSOTDOz2Tc6C1AHwc2EBC7AU2vhaeAR6ed/", "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8053), "user_37_1cb7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7004), "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7000), "USER_38_EA87@EXAMPLE.COM", "USER_38_EA87", "G37uShdARkkGOp0sG82ala0E/uOQnAqvM8yx8MR7PN3HGLkV5x64q+6kFwKaSRwE", "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7006), "user_38_ea87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6452), "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6443), "USER_39_33FC@EXAMPLE.COM", "USER_39_33FC", "BgdYRlla2PbtLiaRaWHmFtXhr5rx060U3axyJWeFIP0HyODqI52ZJu/bPllsry+U", "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6457), "user_39_33fc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5953), "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5948), "USER_40_0768@EXAMPLE.COM", "USER_40_0768", "BbG/sVVNfA49P2y0LDSij8OZwIGr+li/2FcGGNKpR8xOb7g9nkOiKILjMM8Xk7xy", "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5956), "user_40_0768" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1232), "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1228), "USER_41_9211@EXAMPLE.COM", "USER_41_9211", "Z3QYMC0ltgozy+K2XMMG/FRNog1yD1BmQVawcKH2yHHDguf2Qv5qOffyppgJnJAc", "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1233), "user_41_9211" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1763), "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1759), "USER_42_39B4@EXAMPLE.COM", "USER_42_39B4", "lrnpbfpRBsZ8O7J4jYdJ7xe9sO9K6tP+sModJJxtwGgL6aE8UbSuYbCaN5ToWjSu", "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1765), "user_42_39b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(153), "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(149), "USER_43_1F1E@EXAMPLE.COM", "USER_43_1F1E", "H3AOdjOxohBcAq8QrjvmIDqF1WvptEIsM6W/i5ZRjEv5UzY7pVZUg06BzpMQbPMS", "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(158), "user_43_1f1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7465), "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7462), "USER_44_015D@EXAMPLE.COM", "USER_44_015D", "lLH35CSD1t7TZ6EfW9X3UTYLlP8YVbsPlgyFR92uqidYDG+k97K4IjLci0sxEnYP", "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7466), "user_44_015d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4147), "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4144), "USER_45_6359@EXAMPLE.COM", "USER_45_6359", "veifljGaztp066nNX6jQkrYo8dN1LE8lc1DNvAPckCixKtuA2p1wuvb8WMsbELv6", "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4149), "user_45_6359" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4036), "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4013), "USER_46_47AB@EXAMPLE.COM", "USER_46_47AB", "Fh2CoGG88uWogXovL0RLuPFZfcNkYUnAnXzHLNZxbcMEiC06OO7wAYTzCeev4oDP", "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4043), "user_46_47ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2638), "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2634), "USER_47_07AB@EXAMPLE.COM", "USER_47_07AB", "qkTKWuzznvPPu3jwxbXimRWVDW1ZpCoSh69wtYiTtPX4OotafyScZQ1RRFvvRNjU", "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2642), "user_47_07ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7467), "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7462), "USER_48_E965@EXAMPLE.COM", "USER_48_E965", "+KLBEcRg+Xb52rSZnAnYnspWlPZflNwz+3BmhWkzMBwUFqTXctCXka57WLZGdiqZ", "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7469), "user_48_e965" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(497), "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(494), "USER_49_2C6A@EXAMPLE.COM", "USER_49_2C6A", "rMRToWPyAp/mjBd2ouzjCtEhDxnJvnv1LXf6v3WmQjHBLeaqZT/sqzaBe2cel9Pq", "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(498), "user_49_2c6a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6546), "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6534), "USER_50_462E@EXAMPLE.COM", "USER_50_462E", "2h1GQdYeiJ01IdCgWbuJ4cOPE8wr2ZXHQWEfhddsLENQ9xYjKY0TlefAVIrle+25", "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6550), "user_50_462e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 58, 30, 456, DateTimeKind.Utc).AddTicks(9625), new DateTime(2025, 2, 16, 14, 58, 30, 456, DateTimeKind.Utc).AddTicks(5774), "SndPAruXUwqEOT6I+OLMGIFRz3zk76cMFb583M9mqojvYEa8NgcsERzd9GpxqzuJ", new DateTime(2025, 2, 16, 14, 58, 30, 457, DateTimeKind.Utc).AddTicks(783) });
        }
    }
}
