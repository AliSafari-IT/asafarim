using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e22ddab-717e-42bf-8533-c8221f5302a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12b41a91-d6cc-4a8b-a263-e7fd36ff37a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30689c8b-29fd-45e0-99aa-7a93e40b9218"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f8ed61b-17f0-4a53-a59e-5533bd1ca9ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b75fb1c-84d0-4d16-b3f5-e65bc9c23607"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76da300c-537e-4dd5-8aba-d9085bc142d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96c2c97d-690e-4234-818a-78d58c8cd08f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e5e9851-1a22-4fad-b438-2f01b12510c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edfedafd-f09c-4715-a4e4-c89aa513b612"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f94b65af-8e26-4870-8115-80dda4caf41c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("172d42a2-4f40-4060-9f3d-8fbb49a7f674"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3af61412-c3a7-426b-bf2b-43775fab8b53"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("636775eb-d830-4d46-a042-1d55b675b342"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fb1e9bb4-6d0b-407b-9077-c74793c33cac"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("430c3357-4abf-42aa-a395-4f160d9105ae"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("48579b09-f674-41f3-909c-aabff0f21a62"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("5fe0543d-7e70-4a83-9947-2ae5aa8a0e3e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("e2031a74-33a7-404c-b6af-c95d5b41f331"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("16b949e7-b4a6-4a78-ad49-22082bad122b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("2529ef8d-6d83-4af1-afe0-4e179f9cad88"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("56daa222-05de-4dac-8c69-0770058dfb39"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5c3e3197-0d7d-43a7-bf55-f2b88530e3e4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e31f149a-385b-4423-9498-a472dd5c38d1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fac3f6f8-84e6-4ec2-81bb-8eabe665869e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("791601e7-db1b-4c47-943f-d39b13442b74"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("132f6378-c3b0-4a4b-ae1e-48758a54d1c4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6097b82f-2f65-4b4a-8365-610f329da128"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("671be8aa-b4ad-4bd8-b6f2-81147194c46e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7777983f-583f-4e81-8b95-9a464d991461"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5a91b25-1d64-449e-8e8e-c667aa14a7f0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e0232132-93e8-42be-a765-008707d82627"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5e45c6b0-5adb-4d70-a92f-7866a09338fc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("89beac11-2705-48a8-ad88-0f57a44cd400"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8b235b63-017c-4a2a-bcb6-2398dcdb0515"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f098f1a3-8692-4ce9-86f0-92557bfe3329"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("566319c2-4d49-4c7c-bc6a-3aaf3e506a3a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6b14cab7-7ab8-4ad9-8321-f52646782c0a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("a28ebd2a-ec51-4776-b42f-124179b7b2af"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c3b21ece-fe8e-4f06-82b5-68741eaed073"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("efcecd78-a5e8-4c46-9e18-7d8ecad2cbb9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4335f708-81f5-4978-9656-297f431dcb53"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7e97d66c-db54-47f2-a37e-3c54d4f1b96d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e67b25cd-6079-4bb6-a9a1-2cd718f118bc"));

            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Users",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

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
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastLogin", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "demo_user@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 327, DateTimeKind.Utc).AddTicks(7627), "demo_user@example.com", "Demo User", new DateTime(2025, 2, 15, 16, 25, 28, 327, DateTimeKind.Utc).AddTicks(7623), "Account", "DEMO_USER@EXAMPLE.COM", "DEMO_USER", "nSNzsvmEqdFK2I3Y8M0okoVi3q0PnBpsJxPriLE6W6sodI7kkrMI3LNAK5qiKZKD", "demo_user@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 327, DateTimeKind.Utc).AddTicks(7628), "demo_user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_9a95@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 347, DateTimeKind.Utc).AddTicks(1297), new DateTime(1975, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_1_9a95@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 347, DateTimeKind.Utc).AddTicks(1293), "USER_1_9A95@EXAMPLE.COM", "USER_1_9A95", "66lBqJJ99GOEbNQxWmnc9yYswRzgw0hPuRWTdhIfp9577R+sQHHr+K8a+6zHb14r", "user_1_9a95@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 347, DateTimeKind.Utc).AddTicks(1299), "user_1_9a95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_b9fe@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 353, DateTimeKind.Utc).AddTicks(2356), new DateTime(1975, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_2_b9fe@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 353, DateTimeKind.Utc).AddTicks(2353), "USER_2_B9FE@EXAMPLE.COM", "USER_2_B9FE", "pDukZBL3wuSsj58O8odS3EmkwOM09qHnCxZjvby5IjIp9O5Z10iH3tT0shsfTra3", "user_2_b9fe@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 353, DateTimeKind.Utc).AddTicks(2357), "user_2_b9fe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_5e90@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 358, DateTimeKind.Utc).AddTicks(8304), new DateTime(1975, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_3_5e90@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 358, DateTimeKind.Utc).AddTicks(8301), "USER_3_5E90@EXAMPLE.COM", "USER_3_5E90", "mz/g/wLCNESBF7O9t43y3MSweHrROcLpuVf21HqUjCL2sDY+nyifAdo9pDtyaVs8", "user_3_5e90@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 358, DateTimeKind.Utc).AddTicks(8305), "user_3_5e90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_3d7e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 364, DateTimeKind.Utc).AddTicks(6029), new DateTime(1975, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_4_3d7e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 364, DateTimeKind.Utc).AddTicks(6024), "USER_4_3D7E@EXAMPLE.COM", "USER_4_3D7E", "v77E12dkw1jG2ogSTCWpexfgHccGg0KvU16Gmcjc8BbF8UJCnD3Gqb/GcAXtt28h", "user_4_3d7e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 364, DateTimeKind.Utc).AddTicks(6030), "user_4_3d7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_b182@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 370, DateTimeKind.Utc).AddTicks(3933), new DateTime(1975, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_5_b182@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 370, DateTimeKind.Utc).AddTicks(3931), "USER_5_B182@EXAMPLE.COM", "USER_5_B182", "1SxkNjR0ZC55Ho17dwzNhnTDusRYGC3SvCCBsq9/U8oBDikkidRbcaxCVw8yxu+o", "user_5_b182@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 370, DateTimeKind.Utc).AddTicks(3934), "user_5_b182" });

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
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_2e2e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 382, DateTimeKind.Utc).AddTicks(2838), new DateTime(1975, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_7_2e2e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 382, DateTimeKind.Utc).AddTicks(2835), "USER_7_2E2E@EXAMPLE.COM", "USER_7_2E2E", "l+8/C1ofkzgQvSHxDyOyu9zepftI50r0hCWlfl8KyQ4bjLOUOgBvTRKtqbKVLWz5", "user_7_2e2e@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 382, DateTimeKind.Utc).AddTicks(2840), "user_7_2e2e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_798a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 387, DateTimeKind.Utc).AddTicks(9591), new DateTime(1975, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_8_798a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 387, DateTimeKind.Utc).AddTicks(9588), "USER_8_798A@EXAMPLE.COM", "USER_8_798A", "Xagquy4Om74oGS0tNvXuKPX6U8BZRuR2dIm/55le2iPpQJxLUODPPKxmBqTabIZS", "user_8_798a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 387, DateTimeKind.Utc).AddTicks(9592), "user_8_798a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_2622@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 393, DateTimeKind.Utc).AddTicks(8091), new DateTime(1975, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_9_2622@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 393, DateTimeKind.Utc).AddTicks(8088), "USER_9_2622@EXAMPLE.COM", "USER_9_2622", "7tzeaZFqSKcgIDvc4KgEDFo+aBWgWL/yV670de7y5NPj/fIxOyvUikbk1DE27ts+", "user_9_2622@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 393, DateTimeKind.Utc).AddTicks(8092), "user_9_2622" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_3f81@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 399, DateTimeKind.Utc).AddTicks(2578), new DateTime(1975, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_10_3f81@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 399, DateTimeKind.Utc).AddTicks(2575), "USER_10_3F81@EXAMPLE.COM", "USER_10_3F81", "boyvrywVhiFLKAdaM4Y6iNQQ/DDsQtwHFemVHz9LdqhaGtqjtrgToU3TDpl/30EM", "user_10_3f81@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 399, DateTimeKind.Utc).AddTicks(2578), "user_10_3f81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastLogin", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "demo_admin@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 321, DateTimeKind.Utc).AddTicks(1002), "demo_admin@example.com", "Demo Admin", new DateTime(2025, 2, 15, 16, 25, 28, 320, DateTimeKind.Utc).AddTicks(8342), "Account", "DEMO_ADMIN@EXAMPLE.COM", "DEMO_ADMIN", "6mzry1T7QCj28LxTQqKZQkgSJ8K37EWReeW/DGm6LneB7II8Y/qFI3IVxJ1iyHwc", "demo_admin@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 321, DateTimeKind.Utc).AddTicks(1827), "demo_admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "ForgotPasswordToken", "ForgotPasswordTokenExpiration", "IsActive", "IsAdmin", "IsBannedByAdmin", "IsBlocked", "IsDeleted", "IsEditor", "IsGuest", "IsLockedOut", "IsModerator", "IsPending", "IsStandardUser", "IsSuperAdmin", "IsUser", "IsVerified", "LastLogin", "LastName", "LinkUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetToken", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "Website" },
                values: new object[,]
                {
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"), 0, null, "user_11_65ad@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 404, DateTimeKind.Utc).AddTicks(9926), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1975, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_11_65ad@example.com", false, 0, "User 11", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 404, DateTimeKind.Utc).AddTicks(9924), "Example", null, false, null, null, "USER_11_65AD@EXAMPLE.COM", "USER_11_65AD", "FQJ4ccjgY9/lW78oZUb6jP/31b53CdbRORcz0CjWWfTsqHWWaDtunQEOuGEmbL5U", null, null, "+1234567811", true, null, "https://asafarim.com/logoT.svg", "user_11_65ad@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 404, DateTimeKind.Utc).AddTicks(9927), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_11_65ad", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"), 0, null, "user_12_c27d@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 410, DateTimeKind.Utc).AddTicks(7304), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_12_c27d@example.com", false, 0, "User 12", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 410, DateTimeKind.Utc).AddTicks(7302), "Example", null, false, null, null, "USER_12_C27D@EXAMPLE.COM", "USER_12_C27D", "0JDXORWfhbZ0Rm/GdDYcOKVvaeSm43LT1rsoGdADGOTLCcdguhi1IziIaVnxy9eS", null, null, "+1234567812", true, null, "https://asafarim.com/logoT.svg", "user_12_c27d@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 410, DateTimeKind.Utc).AddTicks(7305), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_12_c27d", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"), 0, null, "user_13_59a0@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 416, DateTimeKind.Utc).AddTicks(4530), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_13_59a0@example.com", false, 0, "User 13", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 416, DateTimeKind.Utc).AddTicks(4529), "Example", null, false, null, null, "USER_13_59A0@EXAMPLE.COM", "USER_13_59A0", "x37eaMDcpotQ0Twl4bw97jkPlBwMjhpHdDt5twssrdT4v7AHNG8nZ8PaR55UZuFg", null, null, "+1234567813", true, null, "https://asafarim.com/logoT.svg", "user_13_59a0@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 416, DateTimeKind.Utc).AddTicks(4531), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_13_59a0", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"), 0, null, "user_14_a3b2@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 422, DateTimeKind.Utc).AddTicks(2000), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_14_a3b2@example.com", false, 0, "User 14", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 422, DateTimeKind.Utc).AddTicks(1998), "Example", null, false, null, null, "USER_14_A3B2@EXAMPLE.COM", "USER_14_A3B2", "nNeLReednPeBoGGJky9Lrstn3hFmNpfdQj1Zfyrcp+dUrqD9pNbhPD0cO4gk4vP7", null, null, "+1234567814", true, null, "https://asafarim.com/logoT.svg", "user_14_a3b2@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 422, DateTimeKind.Utc).AddTicks(2001), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_14_a3b2", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"), 0, null, "user_15_9fdb@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 429, DateTimeKind.Utc).AddTicks(4011), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_15_9fdb@example.com", false, 0, "User 15", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 429, DateTimeKind.Utc).AddTicks(4008), "Example", null, false, null, null, "USER_15_9FDB@EXAMPLE.COM", "USER_15_9FDB", "fJroLo4AsHe6vOl7pE1TdFVjbQIVVqtcWHPITxwPNPGeXB8gikmB7ywnGvS9SjRS", null, null, "+1234567815", true, null, "https://asafarim.com/logoT.svg", "user_15_9fdb@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 429, DateTimeKind.Utc).AddTicks(4012), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_15_9fdb", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"), 0, null, "user_16_15b4@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 435, DateTimeKind.Utc).AddTicks(514), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_16_15b4@example.com", false, 0, "User 16", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 435, DateTimeKind.Utc).AddTicks(511), "Example", null, false, null, null, "USER_16_15B4@EXAMPLE.COM", "USER_16_15B4", "VcAB/5+k/9S8I6uENm438ZRkaKglcZrzbNOA6zb+9c9u99cMj8rLHDIHtBUfUByG", null, null, "+1234567816", true, null, "https://asafarim.com/logoT.svg", "user_16_15b4@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 435, DateTimeKind.Utc).AddTicks(514), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_16_15b4", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"), 0, null, "user_17_6cfa@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 441, DateTimeKind.Utc).AddTicks(269), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_17_6cfa@example.com", false, 0, "User 17", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 441, DateTimeKind.Utc).AddTicks(266), "Example", null, false, null, null, "USER_17_6CFA@EXAMPLE.COM", "USER_17_6CFA", "sGXIAG9vdKr7SVyZm4WDfz1/4/M0x28JnmQHkBdHsoriuigvOtv1AI0R+mTUk0l8", null, null, "+1234567817", true, null, "https://asafarim.com/logoT.svg", "user_17_6cfa@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 441, DateTimeKind.Utc).AddTicks(270), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_17_6cfa", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"), 0, null, "user_18_9f12@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 446, DateTimeKind.Utc).AddTicks(5331), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_18_9f12@example.com", false, 0, "User 18", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 446, DateTimeKind.Utc).AddTicks(5329), "Example", null, false, null, null, "USER_18_9F12@EXAMPLE.COM", "USER_18_9F12", "WeK1CpqKvUDXlRXxrTprujfKGmPOe/kZ1s7UijEfHrAv2kuH/S+vGJoup01QnP2n", null, null, "+1234567818", true, null, "https://asafarim.com/logoT.svg", "user_18_9f12@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 446, DateTimeKind.Utc).AddTicks(5331), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_18_9f12", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"), 0, null, "user_19_51d7@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 452, DateTimeKind.Utc).AddTicks(1054), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_19_51d7@example.com", false, 0, "User 19", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 452, DateTimeKind.Utc).AddTicks(1052), "Example", null, false, null, null, "USER_19_51D7@EXAMPLE.COM", "USER_19_51D7", "iaE2ZMHYGxU27OSdI9OKRkJtLIdlLq7RDVEdGTPlY2seqrhnwSe7shPIKw/AH/Lj", null, null, "+1234567819", true, null, "https://asafarim.com/logoT.svg", "user_19_51d7@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 452, DateTimeKind.Utc).AddTicks(1055), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_19_51d7", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"), 0, null, "user_20_9e16@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 458, DateTimeKind.Utc).AddTicks(1248), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_20_9e16@example.com", false, 0, "User 20", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 458, DateTimeKind.Utc).AddTicks(1245), "Example", null, false, null, null, "USER_20_9E16@EXAMPLE.COM", "USER_20_9E16", "vFKWdPDZb8YPx1Y7G/Ae+hU+leeVvofWTCmrWYofaOaig3z3e67Zb1ATJxJ0v7pZ", null, null, "+1234567820", true, null, "https://asafarim.com/logoT.svg", "user_20_9e16@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 458, DateTimeKind.Utc).AddTicks(1249), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_20_9e16", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"), 0, null, "user_21_51b1@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 463, DateTimeKind.Utc).AddTicks(6815), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_21_51b1@example.com", false, 0, "User 21", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 463, DateTimeKind.Utc).AddTicks(6813), "Example", null, false, null, null, "USER_21_51B1@EXAMPLE.COM", "USER_21_51B1", "nMLxWAmIWtvI3OpMuJPFgNk5vOBTCbvQenNPIgjx9941QedIfVfbBwN1MonHFLzN", null, null, "+1234567821", true, null, "https://asafarim.com/logoT.svg", "user_21_51b1@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 463, DateTimeKind.Utc).AddTicks(6815), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_21_51b1", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fca"), 0, null, "user_22_ab97@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 469, DateTimeKind.Utc).AddTicks(3958), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_22_ab97@example.com", false, 0, "User 22", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 469, DateTimeKind.Utc).AddTicks(3956), "Example", null, false, null, null, "USER_22_AB97@EXAMPLE.COM", "USER_22_AB97", "g1PBD/jj3hRY3LbDWA2l12QWNIoGzLB4HJuyrEFOupiGygIapOc0FJpS8TuJHbuu", null, null, "+1234567822", true, null, "https://asafarim.com/logoT.svg", "user_22_ab97@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 469, DateTimeKind.Utc).AddTicks(3959), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_22_ab97", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"), 0, null, "user_23_4bbb@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 475, DateTimeKind.Utc).AddTicks(3393), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1976, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_23_4bbb@example.com", false, 0, "User 23", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 475, DateTimeKind.Utc).AddTicks(3391), "Example", null, false, null, null, "USER_23_4BBB@EXAMPLE.COM", "USER_23_4BBB", "giHdyRpLDAVYuD0EQBqa0HLUUdk6RvTpya7yHIX/ZSEL/gQOCiAxpst4jQ9vt5u2", null, null, "+1234567823", true, null, "https://asafarim.com/logoT.svg", "user_23_4bbb@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 475, DateTimeKind.Utc).AddTicks(3394), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_23_4bbb", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"), 0, null, "user_24_8205@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 480, DateTimeKind.Utc).AddTicks(8225), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_24_8205@example.com", false, 0, "User 24", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 480, DateTimeKind.Utc).AddTicks(8223), "Example", null, false, null, null, "USER_24_8205@EXAMPLE.COM", "USER_24_8205", "aTeGRf/v5mfsPEWR48hPCklZwX1W9uwkL57af0Iz0iCArUVro0L9W8ETltO0Gv8z", null, null, "+1234567824", true, null, "https://asafarim.com/logoT.svg", "user_24_8205@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 480, DateTimeKind.Utc).AddTicks(8226), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_24_8205", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"), 0, null, "user_25_aee0@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 486, DateTimeKind.Utc).AddTicks(7163), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_25_aee0@example.com", false, 0, "User 25", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 486, DateTimeKind.Utc).AddTicks(7160), "Example", null, false, null, null, "USER_25_AEE0@EXAMPLE.COM", "USER_25_AEE0", "mb1ow7CL/1CEmYJ+MLX0rvHtkMIf/FDoJkCqVZVGjK70zzzdElp/WMfmJO/NzU4e", null, null, "+1234567825", true, null, "https://asafarim.com/logoT.svg", "user_25_aee0@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 486, DateTimeKind.Utc).AddTicks(7164), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_25_aee0", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fce"), 0, null, "user_26_9360@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 497, DateTimeKind.Utc).AddTicks(1423), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_26_9360@example.com", false, 0, "User 26", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 497, DateTimeKind.Utc).AddTicks(1419), "Example", null, false, null, null, "USER_26_9360@EXAMPLE.COM", "USER_26_9360", "/tFq8osDmkaYRwc+y3ueoMjxOH2vFLWqr93LJcvSmkncQnZigpoa/9ZbAxXj6tir", null, null, "+1234567826", true, null, "https://asafarim.com/logoT.svg", "user_26_9360@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 497, DateTimeKind.Utc).AddTicks(1425), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_26_9360", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"), 0, null, "user_27_dedf@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 502, DateTimeKind.Utc).AddTicks(9485), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_27_dedf@example.com", false, 0, "User 27", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 502, DateTimeKind.Utc).AddTicks(9479), "Example", null, false, null, null, "USER_27_DEDF@EXAMPLE.COM", "USER_27_DEDF", "P21DV2O8pdfUoLyzBqgpswWgVtIPrso98OmIBoBdcdZQlRBmJW3wis1k65p0GvIs", null, null, "+1234567827", true, null, "https://asafarim.com/logoT.svg", "user_27_dedf@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 502, DateTimeKind.Utc).AddTicks(9486), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_27_dedf", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"), 0, null, "user_28_739d@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 508, DateTimeKind.Utc).AddTicks(3640), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_28_739d@example.com", false, 0, "User 28", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 508, DateTimeKind.Utc).AddTicks(3636), "Example", null, false, null, null, "USER_28_739D@EXAMPLE.COM", "USER_28_739D", "yRxNHzOr53IcU+SpzLuhG9vlNFBOHoiJqHbKKw4HXd/Zrudv1COCpNVGI+UW9Ir2", null, null, "+1234567828", true, null, "https://asafarim.com/logoT.svg", "user_28_739d@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 508, DateTimeKind.Utc).AddTicks(3642), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_28_739d", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"), 0, null, "user_29_6b2b@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 513, DateTimeKind.Utc).AddTicks(5287), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_29_6b2b@example.com", false, 0, "User 29", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 513, DateTimeKind.Utc).AddTicks(5285), "Example", null, false, null, null, "USER_29_6B2B@EXAMPLE.COM", "USER_29_6B2B", "iyVK4+Z2PSTQlllJMS8Z1fFRRLDGiDE/pcvUsvYVPj6rR3YFy4kZteGIcO3pv4kg", null, null, "+1234567829", true, null, "https://asafarim.com/logoT.svg", "user_29_6b2b@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 513, DateTimeKind.Utc).AddTicks(5287), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_29_6b2b", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"), 0, null, "user_30_5fed@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 519, DateTimeKind.Utc).AddTicks(1850), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_30_5fed@example.com", false, 0, "User 30", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 519, DateTimeKind.Utc).AddTicks(1847), "Example", null, false, null, null, "USER_30_5FED@EXAMPLE.COM", "USER_30_5FED", "OvZxG9glds8HTMSPYbxU+eFW2uQyf2sXzEHSQCMbVwU7sTd5uFKZveSNoag7/doF", null, null, "+1234567830", true, null, "https://asafarim.com/logoT.svg", "user_30_5fed@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 519, DateTimeKind.Utc).AddTicks(1852), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_30_5fed", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"), 0, null, "user_31_9eaa@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 524, DateTimeKind.Utc).AddTicks(7977), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_31_9eaa@example.com", false, 0, "User 31", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 524, DateTimeKind.Utc).AddTicks(7970), "Example", null, false, null, null, "USER_31_9EAA@EXAMPLE.COM", "USER_31_9EAA", "H4VCywLJE53DhyTbdPLiv1/QpOG6xXUVkUd64SZIdDmV6wwA61ejp7FnI4I7F+hu", null, null, "+1234567831", true, null, "https://asafarim.com/logoT.svg", "user_31_9eaa@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 524, DateTimeKind.Utc).AddTicks(7982), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_31_9eaa", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"), 0, null, "user_32_ebf6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 530, DateTimeKind.Utc).AddTicks(1752), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_32_ebf6@example.com", false, 0, "User 32", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 530, DateTimeKind.Utc).AddTicks(1749), "Example", null, false, null, null, "USER_32_EBF6@EXAMPLE.COM", "USER_32_EBF6", "69r8Umjdu8cB47loE0rRRFD1chkBZZeGa7au7595ueSUrFAETPQs8Peec24OPXnG", null, null, "+1234567832", true, null, "https://asafarim.com/logoT.svg", "user_32_ebf6@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 530, DateTimeKind.Utc).AddTicks(1753), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_32_ebf6", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"), 0, null, "user_33_b17c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 536, DateTimeKind.Utc).AddTicks(778), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_33_b17c@example.com", false, 0, "User 33", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 536, DateTimeKind.Utc).AddTicks(761), "Example", null, false, null, null, "USER_33_B17C@EXAMPLE.COM", "USER_33_B17C", "rgxJx0Oc1t/dBBqlvsyTl5Mshtorbale4wUHp6I+fmBdxjYDFPiZNjD+5VzDZc9U", null, null, "+1234567833", true, null, "https://asafarim.com/logoT.svg", "user_33_b17c@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 536, DateTimeKind.Utc).AddTicks(779), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_33_b17c", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"), 0, null, "user_34_01f4@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 541, DateTimeKind.Utc).AddTicks(4854), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_34_01f4@example.com", false, 0, "User 34", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 541, DateTimeKind.Utc).AddTicks(4852), "Example", null, false, null, null, "USER_34_01F4@EXAMPLE.COM", "USER_34_01F4", "HkR3iScO7+aPqJtrUKdETSol1KZx6gjW70g5H/nlNNz1qU9+5qi61FvVXvuwalu5", null, null, "+1234567834", true, null, "https://asafarim.com/logoT.svg", "user_34_01f4@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 541, DateTimeKind.Utc).AddTicks(4855), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_34_01f4", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"), 0, null, "user_35_5c05@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 546, DateTimeKind.Utc).AddTicks(7919), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1977, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_35_5c05@example.com", false, 0, "User 35", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 546, DateTimeKind.Utc).AddTicks(7917), "Example", null, false, null, null, "USER_35_5C05@EXAMPLE.COM", "USER_35_5C05", "1zGBJ437JOCa8YK4++f/U3rABb9VR6rmTBibi8NMyskHAOduXAU2zQ599lDHrDPq", null, null, "+1234567835", true, null, "https://asafarim.com/logoT.svg", "user_35_5c05@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 546, DateTimeKind.Utc).AddTicks(7920), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_35_5c05", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"), 0, null, "user_36_5073@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 552, DateTimeKind.Utc).AddTicks(4737), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_36_5073@example.com", false, 0, "User 36", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 552, DateTimeKind.Utc).AddTicks(4734), "Example", null, false, null, null, "USER_36_5073@EXAMPLE.COM", "USER_36_5073", "rDsotMhFM1EMqjQ/pP7ZCtraYAh29QvW2/5iIJnTv2BuZ7oUqOeZJ0s7rTRX20ej", null, null, "+1234567836", true, null, "https://asafarim.com/logoT.svg", "user_36_5073@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 552, DateTimeKind.Utc).AddTicks(4738), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_36_5073", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"), 0, null, "user_37_376c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 558, DateTimeKind.Utc).AddTicks(627), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_37_376c@example.com", false, 0, "User 37", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 558, DateTimeKind.Utc).AddTicks(624), "Example", null, false, null, null, "USER_37_376C@EXAMPLE.COM", "USER_37_376C", "wa1PETGMs4epFBtGaLuc80UbO5eaBhTZnDxBpm7FIpZrTBViEoV8e+gi/ChF/+lM", null, null, "+1234567837", true, null, "https://asafarim.com/logoT.svg", "user_37_376c@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 558, DateTimeKind.Utc).AddTicks(628), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_37_376c", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fda"), 0, null, "user_38_df74@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 563, DateTimeKind.Utc).AddTicks(3806), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_38_df74@example.com", false, 0, "User 38", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 563, DateTimeKind.Utc).AddTicks(3804), "Example", null, false, null, null, "USER_38_DF74@EXAMPLE.COM", "USER_38_DF74", "5J4XGlqcIkBaES9sVeCDj6+abE1aSJesVqVjjo2R81mvkiKQ2PJs/VqtVJ+5QDzy", null, null, "+1234567838", true, null, "https://asafarim.com/logoT.svg", "user_38_df74@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 563, DateTimeKind.Utc).AddTicks(3807), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_38_df74", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"), 0, null, "user_39_335c@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 568, DateTimeKind.Utc).AddTicks(9713), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_39_335c@example.com", false, 0, "User 39", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 568, DateTimeKind.Utc).AddTicks(9709), "Example", null, false, null, null, "USER_39_335C@EXAMPLE.COM", "USER_39_335C", "M8+QSjgTkvO8MhkoL8ofHDSkuQuyBWyNqyCevUOTdR7MkbPevs1XU2UUawrmvavg", null, null, "+1234567839", true, null, "https://asafarim.com/logoT.svg", "user_39_335c@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 568, DateTimeKind.Utc).AddTicks(9715), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_39_335c", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"), 0, null, "user_40_74dd@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 574, DateTimeKind.Utc).AddTicks(4684), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_40_74dd@example.com", false, 0, "User 40", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 574, DateTimeKind.Utc).AddTicks(4681), "Example", null, false, null, null, "USER_40_74DD@EXAMPLE.COM", "USER_40_74DD", "2kp/MxmabHFJ7URnZJuK17qFlIR2Dk7yohS4+mC9dyTvl8pJ6OE9pWEziiPqcmtP", null, null, "+1234567840", true, null, "https://asafarim.com/logoT.svg", "user_40_74dd@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 574, DateTimeKind.Utc).AddTicks(4684), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_40_74dd", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"), 0, null, "user_41_dbf6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 579, DateTimeKind.Utc).AddTicks(8538), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_41_dbf6@example.com", false, 0, "User 41", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 579, DateTimeKind.Utc).AddTicks(8536), "Example", null, false, null, null, "USER_41_DBF6@EXAMPLE.COM", "USER_41_DBF6", "dLsQI4F9REf8mL3SMM4o5UrEoGQxi+sIYh+IAfU9an+l7c1D5e1dSwMs5rBQlLoG", null, null, "+1234567841", true, null, "https://asafarim.com/logoT.svg", "user_41_dbf6@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 579, DateTimeKind.Utc).AddTicks(8539), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_41_dbf6", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fde"), 0, null, "user_42_ac54@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 585, DateTimeKind.Utc).AddTicks(3545), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_42_ac54@example.com", false, 0, "User 42", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 585, DateTimeKind.Utc).AddTicks(3542), "Example", null, false, null, null, "USER_42_AC54@EXAMPLE.COM", "USER_42_AC54", "Ljw+9Q71UN7vkoonuMGUjSmLprIlv/04GKayUPCvf7m1whTuP1sggdBghqp0cCBm", null, null, "+1234567842", true, null, "https://asafarim.com/logoT.svg", "user_42_ac54@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 585, DateTimeKind.Utc).AddTicks(3547), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_42_ac54", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"), 0, null, "user_43_e64a@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 591, DateTimeKind.Utc).AddTicks(938), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_43_e64a@example.com", false, 0, "User 43", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 591, DateTimeKind.Utc).AddTicks(935), "Example", null, false, null, null, "USER_43_E64A@EXAMPLE.COM", "USER_43_E64A", "0Nmy+nAno0EorsgqDi5DjbL1sNlnl4zJNMOqF9UetruGHTdYuWeweLH3774gGIEf", null, null, "+1234567843", true, null, "https://asafarim.com/logoT.svg", "user_43_e64a@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 591, DateTimeKind.Utc).AddTicks(939), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_43_e64a", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"), 0, null, "user_44_e037@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 596, DateTimeKind.Utc).AddTicks(3605), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_44_e037@example.com", false, 0, "User 44", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 596, DateTimeKind.Utc).AddTicks(3603), "Example", null, false, null, null, "USER_44_E037@EXAMPLE.COM", "USER_44_E037", "kYYR/iQQfGL/9zmte75dB88Unhk3R/rksRSuQCU7Aam/BN9VK+AZ0vMfVtjAn7BQ", null, null, "+1234567844", true, null, "https://asafarim.com/logoT.svg", "user_44_e037@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 596, DateTimeKind.Utc).AddTicks(3606), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_44_e037", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"), 0, null, "user_45_8568@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 601, DateTimeKind.Utc).AddTicks(8330), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_45_8568@example.com", false, 0, "User 45", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 601, DateTimeKind.Utc).AddTicks(8328), "Example", null, false, null, null, "USER_45_8568@EXAMPLE.COM", "USER_45_8568", "c8IrhAohbETi/TcKLVYqAoaG0i9HdyoeuoeEv8cEprgacdn1D+EEILDbF2NY0L65", null, null, "+1234567845", true, null, "https://asafarim.com/logoT.svg", "user_45_8568@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 601, DateTimeKind.Utc).AddTicks(8331), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_45_8568", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"), 0, null, "user_46_b6bc@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 607, DateTimeKind.Utc).AddTicks(3474), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_46_b6bc@example.com", false, 0, "User 46", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 607, DateTimeKind.Utc).AddTicks(3472), "Example", null, false, null, null, "USER_46_B6BC@EXAMPLE.COM", "USER_46_B6BC", "9/TzGahAhOoIMD9nvSNa6g5jdPO/k8mtmmpgvxu55ggd3GouMJhD7rIF/YTy6hZR", null, null, "+1234567846", true, null, "https://asafarim.com/logoT.svg", "user_46_b6bc@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 607, DateTimeKind.Utc).AddTicks(3475), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_46_b6bc", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"), 0, null, "user_47_345b@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 612, DateTimeKind.Utc).AddTicks(6163), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1978, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_47_345b@example.com", false, 0, "User 47", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 612, DateTimeKind.Utc).AddTicks(6161), "Example", null, false, null, null, "USER_47_345B@EXAMPLE.COM", "USER_47_345B", "mXdpcOEDo3V6Bh4XP6ugg/8FByAYI5GXZ/qMpHlpY6KIgSwcNV2y617guSgjOpn2", null, null, "+1234567847", true, null, "https://asafarim.com/logoT.svg", "user_47_345b@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 612, DateTimeKind.Utc).AddTicks(6165), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_47_345b", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"), 0, null, "user_48_1cb6@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 618, DateTimeKind.Utc).AddTicks(516), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1979, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_48_1cb6@example.com", false, 0, "User 48", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 618, DateTimeKind.Utc).AddTicks(510), "Example", null, false, null, null, "USER_48_1CB6@EXAMPLE.COM", "USER_48_1CB6", "h3JtrotqGHhYunJSsCfRJyWXPt/DaCR/p3ITkEPHkW9SlQUbnbAcUvge6RtvW6qR", null, null, "+1234567848", true, null, "https://asafarim.com/logoT.svg", "user_48_1cb6@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 618, DateTimeKind.Utc).AddTicks(518), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_48_1cb6", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"), 0, null, "user_49_bc45@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 623, DateTimeKind.Utc).AddTicks(3039), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1979, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_49_bc45@example.com", false, 0, "User 49", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 623, DateTimeKind.Utc).AddTicks(3033), "Example", null, false, null, null, "USER_49_BC45@EXAMPLE.COM", "USER_49_BC45", "u8bRYouTzDZnirCzKgrhZUFE/WPqNcmO5qZoCrG/0ZJzGcTU6S4BusWY8fyyEW+E", null, null, "+1234567849", true, null, "https://asafarim.com/logoT.svg", "user_49_bc45@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 623, DateTimeKind.Utc).AddTicks(3041), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_49_bc45", null },
                    { new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"), 0, null, "user_50_cafc@example.com", new DateTime(2025, 2, 15, 16, 25, 28, 628, DateTimeKind.Utc).AddTicks(8081), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), new DateTime(1979, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "user_50_cafc@example.com", false, 0, "User 50", null, null, true, false, false, false, false, false, false, false, false, false, true, false, true, true, new DateTime(2025, 2, 15, 16, 25, 28, 628, DateTimeKind.Utc).AddTicks(8077), "Example", null, false, null, null, "USER_50_CAFC@EXAMPLE.COM", "USER_50_CAFC", "PzjkNgaGlQxBliveK8khASoy7zxQl3/DJdSpaXhNBzf8gS51STyOKVZ9eBlkLzzG", null, null, "+1234567850", true, null, "https://asafarim.com/logoT.svg", "user_50_cafc@example.com", false, new DateTime(2025, 2, 15, 16, 25, 28, 628, DateTimeKind.Utc).AddTicks(8083), new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"), "user_50_cafc", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"));

            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0e22ddab-717e-42bf-8533-c8221f5302a3"), "Berlin", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2291), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("12b41a91-d6cc-4a8b-a263-e7fd36ff37a4"), "Rome", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2378), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("30689c8b-29fd-45e0-99aa-7a93e40b9218"), "Paris", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2281), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("4f8ed61b-17f0-4a53-a59e-5533bd1ca9ad"), "Bern", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2384), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("6b75fb1c-84d0-4d16-b3f5-e65bc9c23607"), "Amsterdam", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2371), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("76da300c-537e-4dd5-8aba-d9085bc142d2"), "Vienna", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2387), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("96c2c97d-690e-4234-818a-78d58c8cd08f"), "Brussels", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(1573), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("9e5e9851-1a22-4fad-b438-2f01b12510c8"), "London", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2375), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("edfedafd-f09c-4715-a4e4-c89aa513b612"), "Madrid", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2381), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("f94b65af-8e26-4870-8115-80dda4caf41c"), "Luxembourg", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2390), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("172d42a2-4f40-4060-9f3d-8fbb49a7f674"), "USD", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6352), 2, true, "US Dollar", "$", null },
                    { new Guid("3af61412-c3a7-426b-bf2b-43775fab8b53"), "EUR", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(5259), 2, true, "Euro", "€", null },
                    { new Guid("636775eb-d830-4d46-a042-1d55b675b342"), "CHF", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6360), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("fb1e9bb4-6d0b-407b-9077-c74793c33cac"), "GBP", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6358), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("430c3357-4abf-42aa-a395-4f160d9105ae"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4215), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("48579b09-f674-41f3-909c-aabff0f21a62"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(2726), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("5fe0543d-7e70-4a83-9947-2ae5aa8a0e3e"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4223), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("e2031a74-33a7-404c-b6af-c95d5b41f331"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4225), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16b949e7-b4a6-4a78-ad49-22082bad122b"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8519), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("2529ef8d-6d83-4af1-afe0-4e179f9cad88"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8514), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("56daa222-05de-4dac-8c69-0770058dfb39"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8507), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("5c3e3197-0d7d-43a7-bf55-f2b88530e3e4"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8517), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("e31f149a-385b-4423-9498-a472dd5c38d1"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(7109), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("fac3f6f8-84e6-4ec2-81bb-8eabe665869e"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8522), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("791601e7-db1b-4c47-943f-d39b13442b74"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(9500), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("132f6378-c3b0-4a4b-ae1e-48758a54d1c4"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5832), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("6097b82f-2f65-4b4a-8365-610f329da128"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5829), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("671be8aa-b4ad-4bd8-b6f2-81147194c46e"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5845), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("7777983f-583f-4e81-8b95-9a464d991461"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(4725), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("a5a91b25-1d64-449e-8e8e-c667aa14a7f0"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5827), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("e0232132-93e8-42be-a765-008707d82627"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5820), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5e45c6b0-5adb-4d70-a92f-7866a09338fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("89beac11-2705-48a8-ad88-0f57a44cd400"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("8b235b63-017c-4a2a-bcb6-2398dcdb0515"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("f098f1a3-8692-4ce9-86f0-92557bfe3329"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("566319c2-4d49-4c7c-bc6a-3aaf3e506a3a"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8560), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("6b14cab7-7ab8-4ad9-8321-f52646782c0a"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8558), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("a28ebd2a-ec51-4776-b42f-124179b7b2af"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8588), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("c3b21ece-fe8e-4f06-82b5-68741eaed073"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(7256), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("efcecd78-a5e8-4c46-9e18-7d8ecad2cbb9"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8551), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4335f708-81f5-4978-9656-297f431dcb53"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7702), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("7e97d66c-db54-47f2-a37e-3c54d4f1b96d"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7402), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("e67b25cd-6079-4bb6-a9a1-2cd718f118bc"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7709), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastLogin", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4223), "user@example.com", "User", new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4209), "Example", "USER@EXAMPLE.COM", "USER", "21O0ZZzxUly48wQU1wbHwpkiDgGnUaBVIsYDDw50zTQLRGEgkjnrIdkyoRaGxS2R", "user@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4224), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_27ac@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4028), new DateTime(1975, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_1_27ac@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4023), "USER_1_27AC@EXAMPLE.COM", "USER_1_27AC", "TPYvYMTD2MT0HF2rtf8Dg1DYO6bbEea56ZK+UxfUh2J2rxsT5syDLHuscaadOLNZ", "user_1_27ac@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4030), "user_1_27ac" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_0e2b@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5581), new DateTime(1975, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_2_0e2b@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5578), "USER_2_0E2B@EXAMPLE.COM", "USER_2_0E2B", "+QmUyNzGT/ENRiVHBAr3vp0flurbbVNsH9dya+8xB50yWMj6L5Hryy+RXScPbWGr", "user_2_0e2b@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5582), "user_2_0e2b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_05e6@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3415), new DateTime(1975, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_3_05e6@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3410), "USER_3_05E6@EXAMPLE.COM", "USER_3_05E6", "xFK5BIiuQsLAw+kkNrxtDMzGvkJHaIWvp4MM+sFOPgL4i/xQawPMQ56IEieTKveo", "user_3_05e6@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3417), "user_3_05e6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_8b11@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9863), new DateTime(1975, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_4_8b11@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9859), "USER_4_8B11@EXAMPLE.COM", "USER_4_8B11", "CF+Ud3s3kIpjf7JWp4BwFHtL0Ys1VeJ0B+We7M7n8htUvEBysazMcg6quUOZkXgQ", "user_4_8b11@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9864), "user_4_8b11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_b7b7@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8074), new DateTime(1975, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_5_b7b7@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8070), "USER_5_B7B7@EXAMPLE.COM", "USER_5_B7B7", "Isd4uFid1hiCX8F5rYwsxiNSi1C4LWPzpCqgNcHnRmaRu96KIkJlKcI7zx75hKJD", "user_5_b7b7@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8076), "user_5_b7b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_b911@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1285), "user_6_b911@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1281), "USER_6_B911@EXAMPLE.COM", "USER_6_B911", "y4jzrUyYijyNQQ6IGo+PZWtBRe+p+40gejUj0dRh/rSfo1xlLoPwnZy80Erlf7iT", "user_6_b911@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1287), "user_6_b911" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_672d@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4797), new DateTime(1975, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_7_672d@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4793), "USER_7_672D@EXAMPLE.COM", "USER_7_672D", "bezFTDkcW/tWp0+JHlNzFpCtsSoCGt50ZTP/yk6yLMuJSJPRiVtA1j2Ovh+WVgDR", "user_7_672d@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4799), "user_7_672d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_be02@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8079), new DateTime(1975, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_8_be02@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8076), "USER_8_BE02@EXAMPLE.COM", "USER_8_BE02", "j4J5a0kvbRCkpSMuRyOfEWaMjMk5lCIRbixteCVEUCIjIhvssNfmtxZW0EPfcCsG", "user_8_be02@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8081), "user_8_be02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_3b00@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3350), new DateTime(1975, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_9_3b00@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3345), "USER_9_3B00@EXAMPLE.COM", "USER_9_3B00", "/oGrAHb5BryniXLN1fYE0v9XMOtgYPqbaco3gUnAiJKhifEWJssD68Fnb9FabHlA", "user_9_3b00@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3352), "user_9_3b00" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_7f38@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1704), new DateTime(1975, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "user_10_7f38@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1695), "USER_10_7F38@EXAMPLE.COM", "USER_10_7F38", "5kON/sirrfwYdjLGgPy5S6w3tdQBQKgPzEQjn6XL2jmQRrWzXR8Nva8EIVFB7t3R", "user_10_7f38@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1711), "user_10_7f38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastLogin", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "ali@asafarim.com", new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(7283), "ali@asafarim.com", "Ali R.", new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(2142), "Safari", "ALI@ASAFARIM.COM", "ALI", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", "ali@asafarim.com", new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(8804), "ali" });
        }
    }
}
