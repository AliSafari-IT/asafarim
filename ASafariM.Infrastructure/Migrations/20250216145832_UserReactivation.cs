using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserReactivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d190222-df5f-42e2-a505-8bd7566ba780"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("118d9594-b6e0-4cf4-a898-2625d127eaca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d760cf0-93ba-44fe-b2e5-0cd7c8cabadc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34794100-f600-46ee-80ff-47b4de8da420"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46a63f03-b2e4-4c77-9ba3-c842eac92c95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5385ccc9-961d-4862-bb7c-946ad1a71f8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8df10e8e-0241-4d04-a0a4-1b482c86ed75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1688413-bd58-4da0-844d-9a2b5cc73675"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b27bc846-2d6e-45d4-8366-393577d1a1c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eab8146e-abb6-4ea6-955e-d94554013def"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1e8bfac0-3da4-4540-ac2c-8c39eb437620"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("7af89fdd-7c7f-4b54-b1f5-7db8257991f4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cca36f58-dd18-4117-a2fa-87b352312c2c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f2da445d-91b1-4f77-9b9e-48a9238c56b5"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("6c4bb5b6-6a39-4e78-8df9-a8e228c7bf15"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("81439e93-7b04-45c4-86b9-e3035ccfd23f"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("eaa22042-94ba-458c-a0fb-f36fc5d1b155"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ee633307-9113-4278-a563-cc530bdb0435"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("19c5c181-4bef-4285-a233-64c26094f48f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6d5dc4e9-cc72-428d-8f0c-578865efe08b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a09d4c9f-7c3a-4885-9261-35d67ac4bf7b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b30ba797-6e74-4c2e-8ad5-0b717e8c7829"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("de05f47e-e17d-46ef-b2a5-4c2321227655"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e1fb25ea-bd0d-43be-847c-167103600a8e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("e6cdf2ed-3516-4af5-b893-f3e1e7d8a0a9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("431b2b60-a935-4303-9d5e-f63cb8726222"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9a1af83f-7753-49eb-8a61-1686cf6d07e8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b3f3dc5b-7bc4-4f90-b9d4-3289a704d285"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c820b086-98d0-4b8c-ac13-c0b2e12c3e5d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f1d34870-9cf8-40d0-8909-c389cc7aedac"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fe86db55-3a8b-487d-9343-9fab843b7e8f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("27481fe8-561b-41fe-89b3-c3dbd30d38d5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("290a8a46-03b2-4ae0-abe3-89b7a2192d61"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("60fc34c7-2163-45aa-96a1-53e018aaa2d7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d93b5d79-600c-41ef-822e-730de11759ec"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("359fc307-c83b-406d-aceb-3cb783a2a491"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("4875a43d-130e-4f74-88cc-e1ec67cb42d2"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5bfe6331-1f0c-4397-8044-f2ee6c3ba56f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9a11634d-1a59-42a9-9011-a08f2fec9fa6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("bcf404a8-ac63-4b04-a98b-1d760c72fd78"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("23912e1a-7aa0-4408-bf38-775966da4bc0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9576ab1b-7002-40e2-9998-2adbb8003f3a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e354948c-ba09-4984-abc1-b40e495b4ae5"));

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordResetTokenExpiration",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReactivationReason",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReactivationRequestedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "IsAdmin", "LastLogin", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7224), false, new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7210), "nMzZyX9BL3fOz7xr19tm26hZSToATMS7FoTUHVH4yoFxfU5UqnxwYjOn0gSXyX5M", null, null, null, new DateTime(2025, 2, 16, 14, 58, 30, 466, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7910), "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7906), "USER_1_332E@EXAMPLE.COM", "USER_1_332E", "3bu7OICkfpZ78Stk2cAc6Lu/ue/wZPMK8/kzWOI/GXd6N898FqB0nCd6Gh1VaA7q", null, null, null, "user_1_332e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 498, DateTimeKind.Utc).AddTicks(7911), "user_1_332e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6661), "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6658), "USER_2_1D32@EXAMPLE.COM", "USER_2_1D32", "sY6TzmtYfeRstuEMMgmxbov0p2O/G9K3DzO6hiqlTh1BfGhkAvvtGEae7faJAHeV", null, null, null, "user_2_1d32@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 504, DateTimeKind.Utc).AddTicks(6663), "user_2_1d32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9521), "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9515), "USER_3_7EE4@EXAMPLE.COM", "USER_3_7EE4", "2IFuFA/vEQH6/RICZ41ehDjvb77Jc5L8mH/kMf9qahxvAnNAMVrysOsD+dkokeET", null, null, null, "user_3_7ee4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 510, DateTimeKind.Utc).AddTicks(9523), "user_3_7ee4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5941), "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5937), "USER_4_655B@EXAMPLE.COM", "USER_4_655B", "8YYignsoCTPPIte7WPen6P5rEj7os1p5usont1i6vX/2uslcgN53iImI4cs9g6JC", null, null, null, "user_4_655b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 517, DateTimeKind.Utc).AddTicks(5944), "user_4_655b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3128), "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3125), "USER_5_306B@EXAMPLE.COM", "USER_5_306B", "rzoISCS5cHPJ8a8coWTsFLVCI3hMUKUmc3rugHGKAiAmexBAC+FJoPipQ+pJieN5", null, null, null, "user_5_306b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 523, DateTimeKind.Utc).AddTicks(3130), "user_5_306b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4170), "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4167), "USER_6_5CF7@EXAMPLE.COM", "USER_6_5CF7", "oSFkIc5cwOSufrOolw1+K67vJPmlQye5vbn7saa6GwNQ9FBwbWMl0nvqiv+Na/uP", null, null, null, "user_6_5cf7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 530, DateTimeKind.Utc).AddTicks(4171), "user_6_5cf7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3840), "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3836), "USER_7_82D8@EXAMPLE.COM", "USER_7_82D8", "crkIYykeuzGNfUJll6B6kCA0XfDiIJwIqMCRCSpX8DDTpCEgvJ/JWYcc4RD8TQJ+", null, null, null, "user_7_82d8@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 536, DateTimeKind.Utc).AddTicks(3842), "user_7_82d8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7593), "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7587), "USER_8_D28D@EXAMPLE.COM", "USER_8_D28D", "ZIeT0UNMHDmmDpAvzFnoXpJE+1ERKoUH+jtGoOt7N/49ubewuj/IjNBsjifT5uB7", null, null, null, "user_8_d28d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 542, DateTimeKind.Utc).AddTicks(7594), "user_8_d28d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2185), "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2180), "USER_9_7E20@EXAMPLE.COM", "USER_9_7E20", "vrm5E09OoHMnozqcWCV5hk9C1cCwpL3LQv/MpPN9L0Ck0Eq9nt7sDP0DjH7CvXIj", null, null, null, "user_9_7e20@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 550, DateTimeKind.Utc).AddTicks(2186), "user_9_7e20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7730), "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7726), "USER_10_C6AD@EXAMPLE.COM", "USER_10_C6AD", "RjUhvqmj/R2xYdw3Fh5lqrJQnr06sWLrlHhV1Q7icscx2km/yj47ibQ5ZEsPCGtc", null, null, null, "user_10_c6ad@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 556, DateTimeKind.Utc).AddTicks(7732), "user_10_c6ad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4701), "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4698), "USER_11_DBA4@EXAMPLE.COM", "USER_11_DBA4", "TGJvWfxL1npRHKFS+nw2DcP4dDWd4nslVXsO/WTTnTQU37EfVTUg6jwawNNplL1d", null, null, null, "user_11_dba4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 564, DateTimeKind.Utc).AddTicks(4703), "user_11_dba4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(815), "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(810), "USER_12_AB1A@EXAMPLE.COM", "USER_12_AB1A", "LI6IZQH8UP7PNVzQBq1z43UMZX03hYSpWsHGTu08L7wO0sZvpcOHi+vccGqr9KNX", null, null, null, "user_12_ab1a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 575, DateTimeKind.Utc).AddTicks(816), "user_12_ab1a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8592), "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8586), "USER_13_9921@EXAMPLE.COM", "USER_13_9921", "msX+c1AtcYQ2xy5HeSw2cfQSmbbAAM9JM/NSQ10Ip3mbrwQWh3plBGlDs5R1TipQ", null, null, null, "user_13_9921@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 583, DateTimeKind.Utc).AddTicks(8593), "user_13_9921" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4155), "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4151), "USER_14_9B76@EXAMPLE.COM", "USER_14_9B76", "IVk1pa5K0tYTOQpND3+ea5ioPeBgmLcDwLOE9OyDU0mAqG7BbiZQWSATe3b6duPm", null, null, null, "user_14_9b76@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 594, DateTimeKind.Utc).AddTicks(4156), "user_14_9b76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6751), "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6747), "USER_15_9588@EXAMPLE.COM", "USER_15_9588", "v+lcUKFZK7dgcL7QvcHPSOBS9dp0pY//J6Tls5bAH8N+Iblv9df7nWH6dFZDBlAI", null, null, null, "user_15_9588@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 600, DateTimeKind.Utc).AddTicks(6752), "user_15_9588" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6959), "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6955), "USER_16_AABA@EXAMPLE.COM", "USER_16_AABA", "1fqdyEqNAx8/dUa5KUprS+C3ZnJxOvTlDvLoexb2rUph9qJRFvU4h3gtgZO0sx+x", null, null, null, "user_16_aaba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 606, DateTimeKind.Utc).AddTicks(6961), "user_16_aaba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8146), "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8138), "USER_17_DAAC@EXAMPLE.COM", "USER_17_DAAC", "0Pf1v0gxtKk23P8i+2UtnqhiGnIK9tR5cyDKUg11+wAbCS/uSuAqnGPNB4Daw7HH", null, null, null, "user_17_daac@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 633, DateTimeKind.Utc).AddTicks(8149), "user_17_daac" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9626), "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9620), "USER_18_425D@EXAMPLE.COM", "USER_18_425D", "89e/jgRr8dd+368apHERuZPY9sEyP3meS3Xj/nMY+itcuUn7R39hXyHCCXZn+31p", null, null, null, "user_18_425d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 645, DateTimeKind.Utc).AddTicks(9628), "user_18_425d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2132), "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2128), "USER_19_37B1@EXAMPLE.COM", "USER_19_37B1", "5Thiy90jgTr9Wv+Vm4eZXUXh2VpfVWOCAOXI/jjixstOMrroKzNeJvwSAz6PJHyM", null, null, null, "user_19_37b1@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 653, DateTimeKind.Utc).AddTicks(2133), "user_19_37b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3798), "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3790), "USER_20_A0C7@EXAMPLE.COM", "USER_20_A0C7", "WcGiw4bkfHrsXMMr5Z2j5ISIVc0GEBZpbkKVeDQ6OawK0GcXquthJOUOINmhdurQ", null, null, null, "user_20_a0c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 659, DateTimeKind.Utc).AddTicks(3803), "user_20_a0c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2140), "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2135), "USER_21_84C9@EXAMPLE.COM", "USER_21_84C9", "7xGXTs5cGlRAX2McvYm9reOwVJqGpSye18cXzzWMY0LlQWTrto38wmJb9EKrgoEg", null, null, null, "user_21_84c9@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 674, DateTimeKind.Utc).AddTicks(2141), "user_21_84c9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4648), "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4644), "USER_22_6FE0@EXAMPLE.COM", "USER_22_6FE0", "D4PNw6C/BIRlVoH0kf0lnQu4L+0T0mEC6jvLD/POpF9nif6jB1FYUQUyIyz4pqCa", null, null, null, "user_22_6fe0@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 681, DateTimeKind.Utc).AddTicks(4649), "user_22_6fe0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6517), "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6513), "USER_23_273D@EXAMPLE.COM", "USER_23_273D", "j4TNxmwPQH9vJrBXuYNlrMF2TUIm/YYE8ZkjAAcBue08LeAfmqkUASSws9sZSZM3", null, null, null, "user_23_273d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 687, DateTimeKind.Utc).AddTicks(6519), "user_23_273d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8015), "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8009), "USER_24_A0A3@EXAMPLE.COM", "USER_24_A0A3", "qLrlm9PLeovyx/0E6jqYJWnSqDIPKTSf2rSvI25dK9WgUb+ZHw3OvsU5XlgQyG8d", null, null, null, "user_24_a0a3@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 693, DateTimeKind.Utc).AddTicks(8016), "user_24_a0a3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(691), "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(687), "USER_25_2709@EXAMPLE.COM", "USER_25_2709", "76VidI8xon36d9sBhB5eoQDb3TeqVRz1w3nT91UNaE8ToYAaXluFlp9eje+/oNhh", null, null, null, "user_25_2709@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 700, DateTimeKind.Utc).AddTicks(692), "user_25_2709" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5971), "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5963), "USER_26_F15E@EXAMPLE.COM", "USER_26_F15E", "c50iSrbzLdFKaCN91SLwJ2s6cbnZUZVezL133l4XxHdYPTDMxYOv8WtgvUVBtOZ5", null, null, null, "user_26_f15e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 705, DateTimeKind.Utc).AddTicks(5979), "user_26_f15e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2943), "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2939), "USER_27_786B@EXAMPLE.COM", "USER_27_786B", "8DZKLRBTQ6wM70+0h0wyfxi8Mb9HrhpEaF7fjAT4SA9SUqF20wrPYFFdzoUnRp6f", null, null, null, "user_27_786b@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 712, DateTimeKind.Utc).AddTicks(2944), "user_27_786b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3071), "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3057), "USER_28_B52F@EXAMPLE.COM", "USER_28_B52F", "YDJRVuMe3eRgcseJ0A9NQyM6WHRJFjZYW2z16pGq86dUFZpcsnG81KTCJU9xj5of", null, null, null, "user_28_b52f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 721, DateTimeKind.Utc).AddTicks(3074), "user_28_b52f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2036), "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2031), "USER_29_F37F@EXAMPLE.COM", "USER_29_F37F", "3VEH5hhuhpc9N02sH3It+mzEQO9ganXGDBGxGr3QKVZwQjph4AC+NyAKI8FbZ+/2", null, null, null, "user_29_f37f@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 727, DateTimeKind.Utc).AddTicks(2038), "user_29_f37f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2924), "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2920), "USER_30_C4C7@EXAMPLE.COM", "USER_30_C4C7", "hLJR4djFmOlYBHPA7mxDPfB8LM0FynQOZh1ETweObvGJILgMERlKSrp/SO6GqmEh", null, null, null, "user_30_c4c7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 733, DateTimeKind.Utc).AddTicks(2925), "user_30_c4c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9547), "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9543), "USER_31_18EE@EXAMPLE.COM", "USER_31_18EE", "4gS04y1Js5cZExm1uE4NXHbYpiZT+O2kJ7/n6a1Xt9y1OHBpsLSayqABGod5twpz", null, null, null, "user_31_18ee@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 738, DateTimeKind.Utc).AddTicks(9548), "user_31_18ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1188), "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1185), "USER_32_06BA@EXAMPLE.COM", "USER_32_06BA", "WYDamRCmCqDCg0qs+fb+Mf6MQUp/Mf9gIAqIvSgGhej9P4xqjCr7N5SbUnddzfZb", null, null, null, "user_32_06ba@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 745, DateTimeKind.Utc).AddTicks(1190), "user_32_06ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2822), "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2817), "USER_33_C69D@EXAMPLE.COM", "USER_33_C69D", "vJTmDgwRiBjgFfGvKRmlvIGr/OQdhWNK3hVfPHW5Wo98pxwf7kPrd8X6kqXXi0H6", null, null, null, "user_33_c69d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 755, DateTimeKind.Utc).AddTicks(2823), "user_33_c69d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2794), "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2790), "USER_34_3660@EXAMPLE.COM", "USER_34_3660", "zFOcJtfMa8fG8BmuMcrqTCbMSRxRlF9ONna/7+4oiXBoZqrz7tRRLWb13W22F3O3", null, null, null, "user_34_3660@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 763, DateTimeKind.Utc).AddTicks(2795), "user_34_3660" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9082), "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9079), "USER_35_1174@EXAMPLE.COM", "USER_35_1174", "q4+UOCYKGOGM6/Q0zpW4KY9AHfi1yXy/hUkPQateawiBbjBBGp9OcMfTSXy9nn1t", null, null, null, "user_35_1174@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 769, DateTimeKind.Utc).AddTicks(9084), "user_35_1174" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6124), "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6120), "USER_36_CE26@EXAMPLE.COM", "USER_36_CE26", "5TGWj+Dh/kz79iRmPQw0JqOG4s37KxzFR5nuYUxyHKabR2JD9Jx/iTTWgMTW6PWX", null, null, null, "user_36_ce26@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 775, DateTimeKind.Utc).AddTicks(6124), "user_36_ce26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8051), "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8047), "USER_37_1CB7@EXAMPLE.COM", "USER_37_1CB7", "lz4ny9g+vyfgQVq50qW4dtZlf5RwKnSOTDOz2Tc6C1AHwc2EBC7AU2vhaeAR6ed/", null, null, null, "user_37_1cb7@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 781, DateTimeKind.Utc).AddTicks(8053), "user_37_1cb7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7004), "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7000), "USER_38_EA87@EXAMPLE.COM", "USER_38_EA87", "G37uShdARkkGOp0sG82ala0E/uOQnAqvM8yx8MR7PN3HGLkV5x64q+6kFwKaSRwE", null, null, null, "user_38_ea87@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 787, DateTimeKind.Utc).AddTicks(7006), "user_38_ea87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6452), "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6443), "USER_39_33FC@EXAMPLE.COM", "USER_39_33FC", "BgdYRlla2PbtLiaRaWHmFtXhr5rx060U3axyJWeFIP0HyODqI52ZJu/bPllsry+U", null, null, null, "user_39_33fc@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 793, DateTimeKind.Utc).AddTicks(6457), "user_39_33fc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5953), "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5948), "USER_40_0768@EXAMPLE.COM", "USER_40_0768", "BbG/sVVNfA49P2y0LDSij8OZwIGr+li/2FcGGNKpR8xOb7g9nkOiKILjMM8Xk7xy", null, null, null, "user_40_0768@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 800, DateTimeKind.Utc).AddTicks(5956), "user_40_0768" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1232), "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1228), "USER_41_9211@EXAMPLE.COM", "USER_41_9211", "Z3QYMC0ltgozy+K2XMMG/FRNog1yD1BmQVawcKH2yHHDguf2Qv5qOffyppgJnJAc", null, null, null, "user_41_9211@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 811, DateTimeKind.Utc).AddTicks(1233), "user_41_9211" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1763), "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1759), "USER_42_39B4@EXAMPLE.COM", "USER_42_39B4", "lrnpbfpRBsZ8O7J4jYdJ7xe9sO9K6tP+sModJJxtwGgL6aE8UbSuYbCaN5ToWjSu", null, null, null, "user_42_39b4@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 817, DateTimeKind.Utc).AddTicks(1765), "user_42_39b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(153), "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(149), "USER_43_1F1E@EXAMPLE.COM", "USER_43_1F1E", "H3AOdjOxohBcAq8QrjvmIDqF1WvptEIsM6W/i5ZRjEv5UzY7pVZUg06BzpMQbPMS", null, null, null, "user_43_1f1e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 823, DateTimeKind.Utc).AddTicks(158), "user_43_1f1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7465), "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7462), "USER_44_015D@EXAMPLE.COM", "USER_44_015D", "lLH35CSD1t7TZ6EfW9X3UTYLlP8YVbsPlgyFR92uqidYDG+k97K4IjLci0sxEnYP", null, null, null, "user_44_015d@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 829, DateTimeKind.Utc).AddTicks(7466), "user_44_015d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4147), "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4144), "USER_45_6359@EXAMPLE.COM", "USER_45_6359", "veifljGaztp066nNX6jQkrYo8dN1LE8lc1DNvAPckCixKtuA2p1wuvb8WMsbELv6", null, null, null, "user_45_6359@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 835, DateTimeKind.Utc).AddTicks(4149), "user_45_6359" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4036), "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4013), "USER_46_47AB@EXAMPLE.COM", "USER_46_47AB", "Fh2CoGG88uWogXovL0RLuPFZfcNkYUnAnXzHLNZxbcMEiC06OO7wAYTzCeev4oDP", null, null, null, "user_46_47ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 841, DateTimeKind.Utc).AddTicks(4043), "user_46_47ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2638), "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2634), "USER_47_07AB@EXAMPLE.COM", "USER_47_07AB", "qkTKWuzznvPPu3jwxbXimRWVDW1ZpCoSh69wtYiTtPX4OotafyScZQ1RRFvvRNjU", null, null, null, "user_47_07ab@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 848, DateTimeKind.Utc).AddTicks(2642), "user_47_07ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7467), "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7462), "USER_48_E965@EXAMPLE.COM", "USER_48_E965", "+KLBEcRg+Xb52rSZnAnYnspWlPZflNwz+3BmhWkzMBwUFqTXctCXka57WLZGdiqZ", null, null, null, "user_48_e965@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 853, DateTimeKind.Utc).AddTicks(7469), "user_48_e965" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(497), "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(494), "USER_49_2C6A@EXAMPLE.COM", "USER_49_2C6A", "rMRToWPyAp/mjBd2ouzjCtEhDxnJvnv1LXf6v3WmQjHBLeaqZT/sqzaBe2cel9Pq", null, null, null, "user_49_2c6a@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 859, DateTimeKind.Utc).AddTicks(498), "user_49_2c6a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6546), "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6534), "USER_50_462E@EXAMPLE.COM", "USER_50_462E", "2h1GQdYeiJ01IdCgWbuJ4cOPE8wr2ZXHQWEfhddsLENQ9xYjKY0TlefAVIrle+25", null, null, null, "user_50_462e@example.com", new DateTime(2025, 2, 16, 14, 58, 30, 865, DateTimeKind.Utc).AddTicks(6550), "user_50_462e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "PasswordResetTokenExpiration", "ReactivationReason", "ReactivationRequestedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 58, 30, 456, DateTimeKind.Utc).AddTicks(9625), new DateTime(2025, 2, 16, 14, 58, 30, 456, DateTimeKind.Utc).AddTicks(5774), "SndPAruXUwqEOT6I+OLMGIFRz3zk76cMFb583M9mqojvYEa8NgcsERzd9GpxqzuJ", null, null, null, new DateTime(2025, 2, 16, 14, 58, 30, 457, DateTimeKind.Utc).AddTicks(783) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "ForgotPasswordToken", "ForgotPasswordTokenExpiration", "IsActive", "IsAdmin", "IsBannedByAdmin", "IsBlocked", "IsDeleted", "IsEditor", "IsGuest", "IsLockedOut", "IsModerator", "IsPending", "IsStandardUser", "IsSuperAdmin", "IsUser", "IsVerified", "LastLogin", "LastName", "LinkUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetToken", "PasswordResetTokenExpiration", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "ProfilePicture", "ReactivationReason", "ReactivationRequestedAt", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "Website" },
                values: new object[] { new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"), 0, null, "asafarim.it@gmail.com", new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4759), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "asafarim.it@gmail.com", false, 0, "Deleted User", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4744), "Account", null, false, null, null, "ASAFARIM.IT@GMAIL.COM", "DELETED_USER", "6KEhQSe/8Q7X+/267eQwcU79b3IOqx6B4ZnlK+qIHqb2mk40hXiyJVUyUNljw2DM", null, null, null, "+1234567890", true, null, "https://asafarim.com/logoT.svg", null, null, "asafarim.it@gmail.com", false, new DateTime(2025, 2, 16, 14, 58, 30, 473, DateTimeKind.Utc).AddTicks(4761), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "deleted_user", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"));

            migrationBuilder.DropColumn(
                name: "PasswordResetTokenExpiration",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReactivationReason",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReactivationRequestedAt",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d190222-df5f-42e2-a505-8bd7566ba780"), "Brussels", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3188), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("118d9594-b6e0-4cf4-a898-2625d127eaca"), "Vienna", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3894), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("2d760cf0-93ba-44fe-b2e5-0cd7c8cabadc"), "Paris", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3865), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("34794100-f600-46ee-80ff-47b4de8da420"), "Amsterdam", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3873), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("46a63f03-b2e4-4c77-9ba3-c842eac92c95"), "Berlin", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3869), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("5385ccc9-961d-4862-bb7c-946ad1a71f8b"), "London", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3882), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("8df10e8e-0241-4d04-a0a4-1b482c86ed75"), "Luxembourg", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3898), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("a1688413-bd58-4da0-844d-9a2b5cc73675"), "Rome", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3886), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("b27bc846-2d6e-45d4-8366-393577d1a1c2"), "Madrid", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3889), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("eab8146e-abb6-4ea6-955e-d94554013def"), "Bern", new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(3892), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1e8bfac0-3da4-4540-ac2c-8c39eb437620"), "GBP", new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(8939), 2, true, "British Pound", "£", null },
                    { new Guid("7af89fdd-7c7f-4b54-b1f5-7db8257991f4"), "CHF", new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(8941), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("cca36f58-dd18-4117-a2fa-87b352312c2c"), "EUR", new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(8034), 2, true, "Euro", "€", null },
                    { new Guid("f2da445d-91b1-4f77-9b9e-48a9238c56b5"), "USD", new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(8927), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6c4bb5b6-6a39-4e78-8df9-a8e228c7bf15"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(7092), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("81439e93-7b04-45c4-86b9-e3035ccfd23f"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(7094), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("eaa22042-94ba-458c-a0fb-f36fc5d1b155"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(7081), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("ee633307-9113-4278-a563-cc530bdb0435"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(6060), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("19c5c181-4bef-4285-a233-64c26094f48f"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(3201), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("6d5dc4e9-cc72-428d-8f0c-578865efe08b"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(3210), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("a09d4c9f-7c3a-4885-9261-35d67ac4bf7b"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(3208), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("b30ba797-6e74-4c2e-8ad5-0b717e8c7829"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(3212), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("de05f47e-e17d-46ef-b2a5-4c2321227655"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(3214), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("e1fb25ea-bd0d-43be-847c-167103600a8e"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(2014), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("e6cdf2ed-3516-4af5-b893-f3e1e7d8a0a9"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(4080), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("431b2b60-a935-4303-9d5e-f63cb8726222"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(1000), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("9a1af83f-7753-49eb-8a61-1686cf6d07e8"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(994), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("b3f3dc5b-7bc4-4f90-b9d4-3289a704d285"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(1014), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("c820b086-98d0-4b8c-ac13-c0b2e12c3e5d"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(1004), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("f1d34870-9cf8-40d0-8909-c389cc7aedac"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(38), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("fe86db55-3a8b-487d-9343-9fab843b7e8f"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(1002), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("27481fe8-561b-41fe-89b3-c3dbd30d38d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("290a8a46-03b2-4ae0-abe3-89b7a2192d61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("60fc34c7-2163-45aa-96a1-53e018aaa2d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("d93b5d79-600c-41ef-822e-730de11759ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("359fc307-c83b-406d-aceb-3cb783a2a491"), new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(949), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("4875a43d-130e-4f74-88cc-e1ec67cb42d2"), new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(944), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("5bfe6331-1f0c-4397-8044-f2ee6c3ba56f"), new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(863), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("9a11634d-1a59-42a9-9011-a08f2fec9fa6"), new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(946), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("bcf404a8-ac63-4b04-a98b-1d760c72fd78"), new DateTime(2025, 2, 15, 16, 25, 28, 629, DateTimeKind.Utc).AddTicks(9696), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("23912e1a-7aa0-4408-bf38-775966da4bc0"), new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(7711), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("9576ab1b-7002-40e2-9998-2adbb8003f3a"), new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(7976), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("e354948c-ba09-4984-abc1-b40e495b4ae5"), new DateTime(2025, 2, 15, 16, 25, 28, 630, DateTimeKind.Utc).AddTicks(7970), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "IsAdmin", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 16, 25, 28, 327, DateTimeKind.Utc).AddTicks(7627), true, new DateTime(2025, 2, 15, 16, 25, 28, 327, DateTimeKind.Utc).AddTicks(7623), "nSNzsvmEqdFK2I3Y8M0okoVi3q0PnBpsJxPriLE6W6sodI7kkrMI3LNAK5qiKZKD", new DateTime(2025, 2, 15, 16, 25, 28, 327, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_9a95@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 347, DateTimeKind.Utc).AddTicks(1297), "user_1_9a95@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 347, DateTimeKind.Utc).AddTicks(1293), "USER_1_9A95@EXAMPLE.COM", "USER_1_9A95", "66lBqJJ99GOEbNQxWmnc9yYswRzgw0hPuRWTdhIfp9577R+sQHHr+K8a+6zHb14r", "user_1_9a95@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 347, DateTimeKind.Utc).AddTicks(1299), "user_1_9a95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_b9fe@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 353, DateTimeKind.Utc).AddTicks(2356), "user_2_b9fe@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 353, DateTimeKind.Utc).AddTicks(2353), "USER_2_B9FE@EXAMPLE.COM", "USER_2_B9FE", "pDukZBL3wuSsj58O8odS3EmkwOM09qHnCxZjvby5IjIp9O5Z10iH3tT0shsfTra3", "user_2_b9fe@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 353, DateTimeKind.Utc).AddTicks(2357), "user_2_b9fe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_5e90@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 358, DateTimeKind.Utc).AddTicks(8304), "user_3_5e90@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 358, DateTimeKind.Utc).AddTicks(8301), "USER_3_5E90@EXAMPLE.COM", "USER_3_5E90", "mz/g/wLCNESBF7O9t43y3MSweHrROcLpuVf21HqUjCL2sDY+nyifAdo9pDtyaVs8", "user_3_5e90@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 358, DateTimeKind.Utc).AddTicks(8305), "user_3_5e90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_3d7e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 364, DateTimeKind.Utc).AddTicks(6029), "user_4_3d7e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 364, DateTimeKind.Utc).AddTicks(6024), "USER_4_3D7E@EXAMPLE.COM", "USER_4_3D7E", "v77E12dkw1jG2ogSTCWpexfgHccGg0KvU16Gmcjc8BbF8UJCnD3Gqb/GcAXtt28h", "user_4_3d7e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 364, DateTimeKind.Utc).AddTicks(6030), "user_4_3d7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_b182@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 370, DateTimeKind.Utc).AddTicks(3933), "user_5_b182@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 370, DateTimeKind.Utc).AddTicks(3931), "USER_5_B182@EXAMPLE.COM", "USER_5_B182", "1SxkNjR0ZC55Ho17dwzNhnTDusRYGC3SvCCBsq9/U8oBDikkidRbcaxCVw8yxu+o", "user_5_b182@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 370, DateTimeKind.Utc).AddTicks(3934), "user_5_b182" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_e30e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 375, DateTimeKind.Utc).AddTicks(9610), "user_6_e30e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 375, DateTimeKind.Utc).AddTicks(9608), "USER_6_E30E@EXAMPLE.COM", "USER_6_E30E", "IWVBw6Pv8EO67f6XezvUZ1cBcDwP1MCUFyOJY10dXBYsQraHNOOHNwsufhSs+LDA", "user_6_e30e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 375, DateTimeKind.Utc).AddTicks(9611), "user_6_e30e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_2e2e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 382, DateTimeKind.Utc).AddTicks(2838), "user_7_2e2e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 382, DateTimeKind.Utc).AddTicks(2835), "USER_7_2E2E@EXAMPLE.COM", "USER_7_2E2E", "l+8/C1ofkzgQvSHxDyOyu9zepftI50r0hCWlfl8KyQ4bjLOUOgBvTRKtqbKVLWz5", "user_7_2e2e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 382, DateTimeKind.Utc).AddTicks(2840), "user_7_2e2e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_798a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 387, DateTimeKind.Utc).AddTicks(9591), "user_8_798a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 387, DateTimeKind.Utc).AddTicks(9588), "USER_8_798A@EXAMPLE.COM", "USER_8_798A", "Xagquy4Om74oGS0tNvXuKPX6U8BZRuR2dIm/55le2iPpQJxLUODPPKxmBqTabIZS", "user_8_798a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 387, DateTimeKind.Utc).AddTicks(9592), "user_8_798a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_2622@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 393, DateTimeKind.Utc).AddTicks(8091), "user_9_2622@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 393, DateTimeKind.Utc).AddTicks(8088), "USER_9_2622@EXAMPLE.COM", "USER_9_2622", "7tzeaZFqSKcgIDvc4KgEDFo+aBWgWL/yV670de7y5NPj/fIxOyvUikbk1DE27ts+", "user_9_2622@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 393, DateTimeKind.Utc).AddTicks(8092), "user_9_2622" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_3f81@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 399, DateTimeKind.Utc).AddTicks(2578), "user_10_3f81@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 399, DateTimeKind.Utc).AddTicks(2575), "USER_10_3F81@EXAMPLE.COM", "USER_10_3F81", "boyvrywVhiFLKAdaM4Y6iNQQ/DDsQtwHFemVHz9LdqhaGtqjtrgToU3TDpl/30EM", "user_10_3f81@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 399, DateTimeKind.Utc).AddTicks(2578), "user_10_3f81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_11_65ad@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 404, DateTimeKind.Utc).AddTicks(9926), "user_11_65ad@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 404, DateTimeKind.Utc).AddTicks(9924), "USER_11_65AD@EXAMPLE.COM", "USER_11_65AD", "FQJ4ccjgY9/lW78oZUb6jP/31b53CdbRORcz0CjWWfTsqHWWaDtunQEOuGEmbL5U", "user_11_65ad@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 404, DateTimeKind.Utc).AddTicks(9927), "user_11_65ad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_12_c27d@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 410, DateTimeKind.Utc).AddTicks(7304), "user_12_c27d@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 410, DateTimeKind.Utc).AddTicks(7302), "USER_12_C27D@EXAMPLE.COM", "USER_12_C27D", "0JDXORWfhbZ0Rm/GdDYcOKVvaeSm43LT1rsoGdADGOTLCcdguhi1IziIaVnxy9eS", "user_12_c27d@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 410, DateTimeKind.Utc).AddTicks(7305), "user_12_c27d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_13_59a0@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 416, DateTimeKind.Utc).AddTicks(4530), "user_13_59a0@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 416, DateTimeKind.Utc).AddTicks(4529), "USER_13_59A0@EXAMPLE.COM", "USER_13_59A0", "x37eaMDcpotQ0Twl4bw97jkPlBwMjhpHdDt5twssrdT4v7AHNG8nZ8PaR55UZuFg", "user_13_59a0@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 416, DateTimeKind.Utc).AddTicks(4531), "user_13_59a0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_14_a3b2@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 422, DateTimeKind.Utc).AddTicks(2000), "user_14_a3b2@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 422, DateTimeKind.Utc).AddTicks(1998), "USER_14_A3B2@EXAMPLE.COM", "USER_14_A3B2", "nNeLReednPeBoGGJky9Lrstn3hFmNpfdQj1Zfyrcp+dUrqD9pNbhPD0cO4gk4vP7", "user_14_a3b2@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 422, DateTimeKind.Utc).AddTicks(2001), "user_14_a3b2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_15_9fdb@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 429, DateTimeKind.Utc).AddTicks(4011), "user_15_9fdb@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 429, DateTimeKind.Utc).AddTicks(4008), "USER_15_9FDB@EXAMPLE.COM", "USER_15_9FDB", "fJroLo4AsHe6vOl7pE1TdFVjbQIVVqtcWHPITxwPNPGeXB8gikmB7ywnGvS9SjRS", "user_15_9fdb@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 429, DateTimeKind.Utc).AddTicks(4012), "user_15_9fdb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_16_15b4@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 435, DateTimeKind.Utc).AddTicks(514), "user_16_15b4@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 435, DateTimeKind.Utc).AddTicks(511), "USER_16_15B4@EXAMPLE.COM", "USER_16_15B4", "VcAB/5+k/9S8I6uENm438ZRkaKglcZrzbNOA6zb+9c9u99cMj8rLHDIHtBUfUByG", "user_16_15b4@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 435, DateTimeKind.Utc).AddTicks(514), "user_16_15b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_17_6cfa@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 441, DateTimeKind.Utc).AddTicks(269), "user_17_6cfa@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 441, DateTimeKind.Utc).AddTicks(266), "USER_17_6CFA@EXAMPLE.COM", "USER_17_6CFA", "sGXIAG9vdKr7SVyZm4WDfz1/4/M0x28JnmQHkBdHsoriuigvOtv1AI0R+mTUk0l8", "user_17_6cfa@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 441, DateTimeKind.Utc).AddTicks(270), "user_17_6cfa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_18_9f12@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 446, DateTimeKind.Utc).AddTicks(5331), "user_18_9f12@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 446, DateTimeKind.Utc).AddTicks(5329), "USER_18_9F12@EXAMPLE.COM", "USER_18_9F12", "WeK1CpqKvUDXlRXxrTprujfKGmPOe/kZ1s7UijEfHrAv2kuH/S+vGJoup01QnP2n", "user_18_9f12@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 446, DateTimeKind.Utc).AddTicks(5331), "user_18_9f12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_19_51d7@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 452, DateTimeKind.Utc).AddTicks(1054), "user_19_51d7@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 452, DateTimeKind.Utc).AddTicks(1052), "USER_19_51D7@EXAMPLE.COM", "USER_19_51D7", "iaE2ZMHYGxU27OSdI9OKRkJtLIdlLq7RDVEdGTPlY2seqrhnwSe7shPIKw/AH/Lj", "user_19_51d7@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 452, DateTimeKind.Utc).AddTicks(1055), "user_19_51d7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_20_9e16@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 458, DateTimeKind.Utc).AddTicks(1248), "user_20_9e16@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 458, DateTimeKind.Utc).AddTicks(1245), "USER_20_9E16@EXAMPLE.COM", "USER_20_9E16", "vFKWdPDZb8YPx1Y7G/Ae+hU+leeVvofWTCmrWYofaOaig3z3e67Zb1ATJxJ0v7pZ", "user_20_9e16@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 458, DateTimeKind.Utc).AddTicks(1249), "user_20_9e16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_21_51b1@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 463, DateTimeKind.Utc).AddTicks(6815), "user_21_51b1@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 463, DateTimeKind.Utc).AddTicks(6813), "USER_21_51B1@EXAMPLE.COM", "USER_21_51B1", "nMLxWAmIWtvI3OpMuJPFgNk5vOBTCbvQenNPIgjx9941QedIfVfbBwN1MonHFLzN", "user_21_51b1@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 463, DateTimeKind.Utc).AddTicks(6815), "user_21_51b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_22_ab97@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 469, DateTimeKind.Utc).AddTicks(3958), "user_22_ab97@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 469, DateTimeKind.Utc).AddTicks(3956), "USER_22_AB97@EXAMPLE.COM", "USER_22_AB97", "g1PBD/jj3hRY3LbDWA2l12QWNIoGzLB4HJuyrEFOupiGygIapOc0FJpS8TuJHbuu", "user_22_ab97@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 469, DateTimeKind.Utc).AddTicks(3959), "user_22_ab97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_23_4bbb@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 475, DateTimeKind.Utc).AddTicks(3393), "user_23_4bbb@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 475, DateTimeKind.Utc).AddTicks(3391), "USER_23_4BBB@EXAMPLE.COM", "USER_23_4BBB", "giHdyRpLDAVYuD0EQBqa0HLUUdk6RvTpya7yHIX/ZSEL/gQOCiAxpst4jQ9vt5u2", "user_23_4bbb@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 475, DateTimeKind.Utc).AddTicks(3394), "user_23_4bbb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_24_8205@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 480, DateTimeKind.Utc).AddTicks(8225), "user_24_8205@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 480, DateTimeKind.Utc).AddTicks(8223), "USER_24_8205@EXAMPLE.COM", "USER_24_8205", "aTeGRf/v5mfsPEWR48hPCklZwX1W9uwkL57af0Iz0iCArUVro0L9W8ETltO0Gv8z", "user_24_8205@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 480, DateTimeKind.Utc).AddTicks(8226), "user_24_8205" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_25_aee0@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 486, DateTimeKind.Utc).AddTicks(7163), "user_25_aee0@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 486, DateTimeKind.Utc).AddTicks(7160), "USER_25_AEE0@EXAMPLE.COM", "USER_25_AEE0", "mb1ow7CL/1CEmYJ+MLX0rvHtkMIf/FDoJkCqVZVGjK70zzzdElp/WMfmJO/NzU4e", "user_25_aee0@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 486, DateTimeKind.Utc).AddTicks(7164), "user_25_aee0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_26_9360@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 497, DateTimeKind.Utc).AddTicks(1423), "user_26_9360@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 497, DateTimeKind.Utc).AddTicks(1419), "USER_26_9360@EXAMPLE.COM", "USER_26_9360", "/tFq8osDmkaYRwc+y3ueoMjxOH2vFLWqr93LJcvSmkncQnZigpoa/9ZbAxXj6tir", "user_26_9360@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 497, DateTimeKind.Utc).AddTicks(1425), "user_26_9360" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_27_dedf@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 502, DateTimeKind.Utc).AddTicks(9485), "user_27_dedf@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 502, DateTimeKind.Utc).AddTicks(9479), "USER_27_DEDF@EXAMPLE.COM", "USER_27_DEDF", "P21DV2O8pdfUoLyzBqgpswWgVtIPrso98OmIBoBdcdZQlRBmJW3wis1k65p0GvIs", "user_27_dedf@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 502, DateTimeKind.Utc).AddTicks(9486), "user_27_dedf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_28_739d@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 508, DateTimeKind.Utc).AddTicks(3640), "user_28_739d@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 508, DateTimeKind.Utc).AddTicks(3636), "USER_28_739D@EXAMPLE.COM", "USER_28_739D", "yRxNHzOr53IcU+SpzLuhG9vlNFBOHoiJqHbKKw4HXd/Zrudv1COCpNVGI+UW9Ir2", "user_28_739d@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 508, DateTimeKind.Utc).AddTicks(3642), "user_28_739d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_29_6b2b@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 513, DateTimeKind.Utc).AddTicks(5287), "user_29_6b2b@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 513, DateTimeKind.Utc).AddTicks(5285), "USER_29_6B2B@EXAMPLE.COM", "USER_29_6B2B", "iyVK4+Z2PSTQlllJMS8Z1fFRRLDGiDE/pcvUsvYVPj6rR3YFy4kZteGIcO3pv4kg", "user_29_6b2b@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 513, DateTimeKind.Utc).AddTicks(5287), "user_29_6b2b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_30_5fed@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 519, DateTimeKind.Utc).AddTicks(1850), "user_30_5fed@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 519, DateTimeKind.Utc).AddTicks(1847), "USER_30_5FED@EXAMPLE.COM", "USER_30_5FED", "OvZxG9glds8HTMSPYbxU+eFW2uQyf2sXzEHSQCMbVwU7sTd5uFKZveSNoag7/doF", "user_30_5fed@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 519, DateTimeKind.Utc).AddTicks(1852), "user_30_5fed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_31_9eaa@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 524, DateTimeKind.Utc).AddTicks(7977), "user_31_9eaa@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 524, DateTimeKind.Utc).AddTicks(7970), "USER_31_9EAA@EXAMPLE.COM", "USER_31_9EAA", "H4VCywLJE53DhyTbdPLiv1/QpOG6xXUVkUd64SZIdDmV6wwA61ejp7FnI4I7F+hu", "user_31_9eaa@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 524, DateTimeKind.Utc).AddTicks(7982), "user_31_9eaa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_32_ebf6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 530, DateTimeKind.Utc).AddTicks(1752), "user_32_ebf6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 530, DateTimeKind.Utc).AddTicks(1749), "USER_32_EBF6@EXAMPLE.COM", "USER_32_EBF6", "69r8Umjdu8cB47loE0rRRFD1chkBZZeGa7au7595ueSUrFAETPQs8Peec24OPXnG", "user_32_ebf6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 530, DateTimeKind.Utc).AddTicks(1753), "user_32_ebf6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_33_b17c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 536, DateTimeKind.Utc).AddTicks(778), "user_33_b17c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 536, DateTimeKind.Utc).AddTicks(761), "USER_33_B17C@EXAMPLE.COM", "USER_33_B17C", "rgxJx0Oc1t/dBBqlvsyTl5Mshtorbale4wUHp6I+fmBdxjYDFPiZNjD+5VzDZc9U", "user_33_b17c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 536, DateTimeKind.Utc).AddTicks(779), "user_33_b17c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_34_01f4@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 541, DateTimeKind.Utc).AddTicks(4854), "user_34_01f4@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 541, DateTimeKind.Utc).AddTicks(4852), "USER_34_01F4@EXAMPLE.COM", "USER_34_01F4", "HkR3iScO7+aPqJtrUKdETSol1KZx6gjW70g5H/nlNNz1qU9+5qi61FvVXvuwalu5", "user_34_01f4@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 541, DateTimeKind.Utc).AddTicks(4855), "user_34_01f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_35_5c05@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 546, DateTimeKind.Utc).AddTicks(7919), "user_35_5c05@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 546, DateTimeKind.Utc).AddTicks(7917), "USER_35_5C05@EXAMPLE.COM", "USER_35_5C05", "1zGBJ437JOCa8YK4++f/U3rABb9VR6rmTBibi8NMyskHAOduXAU2zQ599lDHrDPq", "user_35_5c05@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 546, DateTimeKind.Utc).AddTicks(7920), "user_35_5c05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_36_5073@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 552, DateTimeKind.Utc).AddTicks(4737), "user_36_5073@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 552, DateTimeKind.Utc).AddTicks(4734), "USER_36_5073@EXAMPLE.COM", "USER_36_5073", "rDsotMhFM1EMqjQ/pP7ZCtraYAh29QvW2/5iIJnTv2BuZ7oUqOeZJ0s7rTRX20ej", "user_36_5073@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 552, DateTimeKind.Utc).AddTicks(4738), "user_36_5073" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_37_376c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 558, DateTimeKind.Utc).AddTicks(627), "user_37_376c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 558, DateTimeKind.Utc).AddTicks(624), "USER_37_376C@EXAMPLE.COM", "USER_37_376C", "wa1PETGMs4epFBtGaLuc80UbO5eaBhTZnDxBpm7FIpZrTBViEoV8e+gi/ChF/+lM", "user_37_376c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 558, DateTimeKind.Utc).AddTicks(628), "user_37_376c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_38_df74@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 563, DateTimeKind.Utc).AddTicks(3806), "user_38_df74@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 563, DateTimeKind.Utc).AddTicks(3804), "USER_38_DF74@EXAMPLE.COM", "USER_38_DF74", "5J4XGlqcIkBaES9sVeCDj6+abE1aSJesVqVjjo2R81mvkiKQ2PJs/VqtVJ+5QDzy", "user_38_df74@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 563, DateTimeKind.Utc).AddTicks(3807), "user_38_df74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_39_335c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 568, DateTimeKind.Utc).AddTicks(9713), "user_39_335c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 568, DateTimeKind.Utc).AddTicks(9709), "USER_39_335C@EXAMPLE.COM", "USER_39_335C", "M8+QSjgTkvO8MhkoL8ofHDSkuQuyBWyNqyCevUOTdR7MkbPevs1XU2UUawrmvavg", "user_39_335c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 568, DateTimeKind.Utc).AddTicks(9715), "user_39_335c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_40_74dd@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 574, DateTimeKind.Utc).AddTicks(4684), "user_40_74dd@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 574, DateTimeKind.Utc).AddTicks(4681), "USER_40_74DD@EXAMPLE.COM", "USER_40_74DD", "2kp/MxmabHFJ7URnZJuK17qFlIR2Dk7yohS4+mC9dyTvl8pJ6OE9pWEziiPqcmtP", "user_40_74dd@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 574, DateTimeKind.Utc).AddTicks(4684), "user_40_74dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_41_dbf6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 579, DateTimeKind.Utc).AddTicks(8538), "user_41_dbf6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 579, DateTimeKind.Utc).AddTicks(8536), "USER_41_DBF6@EXAMPLE.COM", "USER_41_DBF6", "dLsQI4F9REf8mL3SMM4o5UrEoGQxi+sIYh+IAfU9an+l7c1D5e1dSwMs5rBQlLoG", "user_41_dbf6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 579, DateTimeKind.Utc).AddTicks(8539), "user_41_dbf6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_42_ac54@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 585, DateTimeKind.Utc).AddTicks(3545), "user_42_ac54@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 585, DateTimeKind.Utc).AddTicks(3542), "USER_42_AC54@EXAMPLE.COM", "USER_42_AC54", "Ljw+9Q71UN7vkoonuMGUjSmLprIlv/04GKayUPCvf7m1whTuP1sggdBghqp0cCBm", "user_42_ac54@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 585, DateTimeKind.Utc).AddTicks(3547), "user_42_ac54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_43_e64a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 591, DateTimeKind.Utc).AddTicks(938), "user_43_e64a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 591, DateTimeKind.Utc).AddTicks(935), "USER_43_E64A@EXAMPLE.COM", "USER_43_E64A", "0Nmy+nAno0EorsgqDi5DjbL1sNlnl4zJNMOqF9UetruGHTdYuWeweLH3774gGIEf", "user_43_e64a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 591, DateTimeKind.Utc).AddTicks(939), "user_43_e64a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_44_e037@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 596, DateTimeKind.Utc).AddTicks(3605), "user_44_e037@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 596, DateTimeKind.Utc).AddTicks(3603), "USER_44_E037@EXAMPLE.COM", "USER_44_E037", "kYYR/iQQfGL/9zmte75dB88Unhk3R/rksRSuQCU7Aam/BN9VK+AZ0vMfVtjAn7BQ", "user_44_e037@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 596, DateTimeKind.Utc).AddTicks(3606), "user_44_e037" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_45_8568@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 601, DateTimeKind.Utc).AddTicks(8330), "user_45_8568@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 601, DateTimeKind.Utc).AddTicks(8328), "USER_45_8568@EXAMPLE.COM", "USER_45_8568", "c8IrhAohbETi/TcKLVYqAoaG0i9HdyoeuoeEv8cEprgacdn1D+EEILDbF2NY0L65", "user_45_8568@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 601, DateTimeKind.Utc).AddTicks(8331), "user_45_8568" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_46_b6bc@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 607, DateTimeKind.Utc).AddTicks(3474), "user_46_b6bc@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 607, DateTimeKind.Utc).AddTicks(3472), "USER_46_B6BC@EXAMPLE.COM", "USER_46_B6BC", "9/TzGahAhOoIMD9nvSNa6g5jdPO/k8mtmmpgvxu55ggd3GouMJhD7rIF/YTy6hZR", "user_46_b6bc@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 607, DateTimeKind.Utc).AddTicks(3475), "user_46_b6bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_47_345b@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 612, DateTimeKind.Utc).AddTicks(6163), "user_47_345b@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 612, DateTimeKind.Utc).AddTicks(6161), "USER_47_345B@EXAMPLE.COM", "USER_47_345B", "mXdpcOEDo3V6Bh4XP6ugg/8FByAYI5GXZ/qMpHlpY6KIgSwcNV2y617guSgjOpn2", "user_47_345b@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 612, DateTimeKind.Utc).AddTicks(6165), "user_47_345b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_48_1cb6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 618, DateTimeKind.Utc).AddTicks(516), "user_48_1cb6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 618, DateTimeKind.Utc).AddTicks(510), "USER_48_1CB6@EXAMPLE.COM", "USER_48_1CB6", "h3JtrotqGHhYunJSsCfRJyWXPt/DaCR/p3ITkEPHkW9SlQUbnbAcUvge6RtvW6qR", "user_48_1cb6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 618, DateTimeKind.Utc).AddTicks(518), "user_48_1cb6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_49_bc45@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 623, DateTimeKind.Utc).AddTicks(3039), "user_49_bc45@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 623, DateTimeKind.Utc).AddTicks(3033), "USER_49_BC45@EXAMPLE.COM", "USER_49_BC45", "u8bRYouTzDZnirCzKgrhZUFE/WPqNcmO5qZoCrG/0ZJzGcTU6S4BusWY8fyyEW+E", "user_49_bc45@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 623, DateTimeKind.Utc).AddTicks(3041), "user_49_bc45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_50_cafc@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 628, DateTimeKind.Utc).AddTicks(8081), "user_50_cafc@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 628, DateTimeKind.Utc).AddTicks(8077), "USER_50_CAFC@EXAMPLE.COM", "USER_50_CAFC", "PzjkNgaGlQxBliveK8khASoy7zxQl3/DJdSpaXhNBzf8gS51STyOKVZ9eBlkLzzG", "user_50_cafc@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 628, DateTimeKind.Utc).AddTicks(8083), "user_50_cafc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 16, 25, 28, 321, DateTimeKind.Utc).AddTicks(1002), new DateTime(2025, 2, 15, 16, 25, 28, 320, DateTimeKind.Utc).AddTicks(8342), "6mzry1T7QCj28LxTQqKZQkgSJ8K37EWReeW/DGm6LneB7II8Y/qFI3IVxJ1iyHwc", new DateTime(2025, 2, 15, 16, 25, 28, 321, DateTimeKind.Utc).AddTicks(1827) });
        }
    }
}
