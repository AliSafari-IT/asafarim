using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserUniqueConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ed2c4aa-037b-45d1-a520-d248d0b37aab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("449f1e52-a8b7-4d2a-b8fb-a6dd3650451f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4848ad02-b004-4699-945e-89fef4d140bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a7a435d-01dd-4c82-8cac-07847a442da4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61b6f335-aecd-402d-b51b-e442f355d414"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70ac55f2-a9a7-4f25-976f-6deb9be134d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ecae63e-8ca2-4087-875e-152570de3c6e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9451593d-5378-49d9-a688-cc01bdcdd1dc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9901be28-4ceb-4655-99ce-282fa086315d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f02728d2-7418-421a-8017-07dbfd0527da"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("241db133-719d-41e3-874c-a45942c00729"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6aafd072-630b-4cf5-a226-84335a9bd91f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b10518b5-0bef-43f0-b123-c090c4eaea91"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cc6e0501-ff30-4f9e-9d82-129cf41a4bee"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("1fee1144-78c4-4b11-8d85-a556c21e513e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("c3681633-0f6c-47a3-b2bf-a95df39aeb4b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d8b6c2c8-b3f2-4d19-88f4-235cba844a19"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("f4654dd7-a2b1-47ad-8179-a2bb77deee21"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("10ffe8c7-2ad2-4dd1-9722-adbafbb5453c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5d6f6345-61ee-4fab-a85d-1167ff7de056"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("61fb1b62-63be-465b-970a-467420bd7cfa"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("81325055-e094-48fb-9b1a-529024273d5f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("8e581443-531d-4065-9a63-ee7cc93a84e1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e36b174a-d761-4a71-ab6d-8ef9b34e2a6e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("debdb566-067e-47f1-a262-e3d0a7b28569"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("24adf3eb-cba7-4738-b035-38f49808ac40"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("285a37c4-7f25-4060-9493-0f630b538d8c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7159c0c9-38b2-4921-9413-e1a0c312d321"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8ce7c3b0-626b-417f-8350-5b86155d8da3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b22e342d-2369-4088-aa06-7284897d961c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dbefd6f2-d673-4155-9150-cf46f3041f05"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00277422-6bfd-4157-be28-7e26f72f3f49"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("11a1332f-85ac-458d-a272-fd9b7b411171"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("44ff8e1b-4b38-4f9a-ab2b-b77cbee44fff"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fc6265c0-10b8-4bf8-a6a3-7a3d51538607"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("18bd07c5-2c7c-4c17-8de3-888f5b63e1e0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("20ea42af-4c4f-42a8-b750-23d1d218438d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7b6ab23b-6eb1-4039-a8e3-d866cadd1630"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7c368677-cf1c-46b5-a40d-d681dd2f981b"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("afddfdfb-c695-488f-b6e0-2ff5ecf042a5"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1d77f898-2a90-4cae-a8d5-eb4c98db2dcc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("601763c7-8497-4100-94cd-12e001374f89"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a1471090-996e-4816-8c24-598afacbcea6"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserName",
                keyValue: null,
                column: "UserName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11195222-1910-488b-98b5-197377303d10"), "Berlin", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8110), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("42905c6b-9cc2-4723-8c51-b7c9c2f11430"), "Vienna", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8126), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("5c2c4777-be05-446d-bb56-26cbfe8f1a21"), "Bern", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8123), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("6cc0a5b4-99dd-4fbb-9336-3faa02bcc87f"), "Paris", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8103), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("859752a7-f92f-4f41-8345-8c2603a42ba7"), "London", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8115), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("9e681651-3f8e-498f-99b0-3f196c88a616"), "Brussels", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(7566), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("af4b0629-e2d1-4805-8f18-d1425decf075"), "Madrid", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8121), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("b33d1172-a109-4a03-87b1-55e648f8e7db"), "Rome", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8119), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("ce867af2-bdb8-4d61-9498-d7fe9d965458"), "Amsterdam", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8113), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("f01697ae-3d19-4bb7-8849-358ccc8cb6e3"), "Luxembourg", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(8128), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b94b53df-983d-49ee-8aab-e65b8c796b5a"), "EUR", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(2903), 2, true, "Euro", "€", null },
                    { new Guid("bc6ef463-ba69-4133-b540-30e375aabaf5"), "USD", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(3773), 2, true, "US Dollar", "$", null },
                    { new Guid("ca96ef27-868a-4981-a1f0-c4df23eb6ca8"), "CHF", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(3823), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("f83fabae-9f7c-411c-8849-a146834efc3b"), "GBP", new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(3779), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("19b858eb-c42e-44ad-a636-518f9a529606"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(2239), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("2c0bddff-b45f-4837-9e95-4a6bbcf45119"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(2233), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("cccc55d7-d5d5-4a07-ab58-38a50c261322"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(2241), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("ccd2fcb8-f043-44ad-9b1b-dd7c89eff63a"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(1304), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0fdc2587-2425-4516-9cb3-d90a8b2dd653"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8573), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("285ca1b9-22ae-45a2-85ec-bf346deca57a"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(7196), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("4dc35326-88b6-42be-b943-0a41e6937585"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8575), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("a3db5f4b-713d-424a-921c-4d1287f3aa4d"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8566), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("af0668c3-19c6-483b-9d52-eb8ba41092cb"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8579), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("d6987a20-0bb9-4c4b-9478-af118d5a43ec"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(8578), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("b7943343-5153-43b6-896e-86e84deab981"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(9392), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("18d2073c-18df-428e-85cb-d40b116bfcbc"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(4993), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("3aad1ea8-4e31-4baa-97b4-44638dacbb4e"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6119), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("4d90cdbf-5f88-4e67-bfdc-1465c20f1edf"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6156), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("8f9cc908-3a04-49b7-b8b5-e381abc770f1"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6153), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("acd96219-b79d-488d-9cea-241571d061e0"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6168), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("ca2144a0-bf2a-45d2-a054-8b2485eccd5d"), new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(6151), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("50d88ee1-6518-4d4f-b9df-91dce466983b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("622fcb6f-8859-40be-8230-3ceb1c6f77fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("aba70367-2324-4c4d-a88f-6602e5e5da8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("cdd25436-de12-40b4-8d4f-5c6d10a5c3cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("35289622-b39e-44f0-8d2d-7c800373659a"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(5526), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("4c95384d-e490-43c2-9a6f-5f8466480dc5"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(5535), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("581bb615-3722-45eb-91a6-0ebdef84b2d9"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(4476), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("5c8d70ed-7bcc-4a5c-b5e5-0028d2325e3d"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(5533), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("9e507964-a0cd-45f3-a5ef-dd57d2b06770"), new DateTime(2025, 2, 14, 13, 13, 22, 589, DateTimeKind.Utc).AddTicks(5531), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 13, 13, 22, 590, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2a5d9c5d-5c8a-432d-8b24-90a0cbff1c05"), new DateTime(2025, 2, 14, 13, 13, 22, 590, DateTimeKind.Utc).AddTicks(1843), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("94427b7c-6a1c-41ee-86b7-c12eb597bec3"), new DateTime(2025, 2, 14, 13, 13, 22, 590, DateTimeKind.Utc).AddTicks(2109), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("fdaa37d2-672a-4884-a3cc-8527fd35a55a"), new DateTime(2025, 2, 14, 13, 13, 22, 590, DateTimeKind.Utc).AddTicks(2103), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 13, 13, 22, 513, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 2, 14, 13, 13, 22, 513, DateTimeKind.Utc).AddTicks(251), "uolP1gu/qGbU93kcPNR5a5xobk+XOzPthlf2DpyYdzZrkZ0wTrX6YY99R8KFAylY", new DateTime(2025, 2, 14, 13, 13, 22, 513, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_5dbb@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 533, DateTimeKind.Utc).AddTicks(5347), "user_1_5dbb@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 533, DateTimeKind.Utc).AddTicks(5343), "USER_1_5DBB@EXAMPLE.COM", "USER_1_5DBB", "/p2RQi6tYfYRlYI2GS1ywooL4xIsjwQltgxyoPALNwoIa1oO089fIwOLSj3MWEh3", "user_1_5dbb@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 533, DateTimeKind.Utc).AddTicks(5348), "user_1_5dbb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_e17d@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 539, DateTimeKind.Utc).AddTicks(9931), "user_2_e17d@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 539, DateTimeKind.Utc).AddTicks(9926), "USER_2_E17D@EXAMPLE.COM", "USER_2_E17D", "kb3VpDikGZKzUVgWvED06p1BLZrK5AGKLHhfCBDJcAvOnOHeFh0V19HGZDi8VScF", "user_2_e17d@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 539, DateTimeKind.Utc).AddTicks(9932), "user_2_e17d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_75c9@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 545, DateTimeKind.Utc).AddTicks(9840), "user_3_75c9@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 545, DateTimeKind.Utc).AddTicks(9833), "USER_3_75C9@EXAMPLE.COM", "USER_3_75C9", "Pg/7Zecdg+Cwj1iVjtFzxdy+Ihu+lf/s4ostdWGm4SRJEI2gZOgz349xK02zlPUY", "user_3_75c9@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 545, DateTimeKind.Utc).AddTicks(9842), "user_3_75c9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_9dc3@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 551, DateTimeKind.Utc).AddTicks(9278), "user_4_9dc3@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 551, DateTimeKind.Utc).AddTicks(9273), "USER_4_9DC3@EXAMPLE.COM", "USER_4_9DC3", "hZAKWgHjlLglVEIvYTIqkAKMr1Xz0/kFv22AIAGcxh1QeL3fUISQccsnbx5Ix+O+", "user_4_9dc3@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 551, DateTimeKind.Utc).AddTicks(9279), "user_4_9dc3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_0340@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 558, DateTimeKind.Utc).AddTicks(2440), "user_5_0340@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 558, DateTimeKind.Utc).AddTicks(2435), "USER_5_0340@EXAMPLE.COM", "USER_5_0340", "ojnqT9py/k1H4c1gHCJGI/lTF84/bo59dHjVlsMwNouXidt0C2taffS5sD/AS0wu", "user_5_0340@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 558, DateTimeKind.Utc).AddTicks(2441), "user_5_0340" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_1205@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 564, DateTimeKind.Utc).AddTicks(1890), "user_6_1205@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 564, DateTimeKind.Utc).AddTicks(1886), "USER_6_1205@EXAMPLE.COM", "USER_6_1205", "UEbVF8lrJGMw1NdqEEI8bmSNp+3K8UuxjZnySfnFKu79j44j75HDUDlRbs/8yn29", "user_6_1205@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 564, DateTimeKind.Utc).AddTicks(1892), "user_6_1205" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_3765@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 570, DateTimeKind.Utc).AddTicks(1538), "user_7_3765@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 570, DateTimeKind.Utc).AddTicks(1533), "USER_7_3765@EXAMPLE.COM", "USER_7_3765", "H3kky7IfpH1V2dpEIC+oaOYelXonYZxF52CdoTBvZ0pUVKtw7mb1B6rl2YTwB5uW", "user_7_3765@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 570, DateTimeKind.Utc).AddTicks(1539), "user_7_3765" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_2966@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 576, DateTimeKind.Utc).AddTicks(1204), "user_8_2966@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 576, DateTimeKind.Utc).AddTicks(1194), "USER_8_2966@EXAMPLE.COM", "USER_8_2966", "kr5pvfVbsJP9BKNUVdcdubdbaARJS/nPVyc4kpARZAj9Zs0R+PW1cNN8QFtA/Q2+", "user_8_2966@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 576, DateTimeKind.Utc).AddTicks(1207), "user_8_2966" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_cf0c@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 582, DateTimeKind.Utc).AddTicks(298), "user_9_cf0c@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 582, DateTimeKind.Utc).AddTicks(293), "USER_9_CF0C@EXAMPLE.COM", "USER_9_CF0C", "fK5+FqGPRa64sI+T3zUZViWs6QijGsCrB9EGDBkFgLLotpait8Bp2+9TF9NA/uIv", "user_9_cf0c@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 582, DateTimeKind.Utc).AddTicks(299), "user_9_cf0c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_efc0@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(2711), "user_10_efc0@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(2707), "USER_10_EFC0@EXAMPLE.COM", "USER_10_EFC0", "5gT6MYI9eWxIPcPglgxHIUvmgqNB2FIRYDy7WBIGwI+UvGX89Qt4aGhwVEJI+JhO", "user_10_efc0@example.com", new DateTime(2025, 2, 14, 13, 13, 22, 588, DateTimeKind.Utc).AddTicks(2712), "user_10_efc0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 13, 13, 22, 498, DateTimeKind.Utc).AddTicks(3830), new DateTime(2025, 2, 14, 13, 13, 22, 498, DateTimeKind.Utc).AddTicks(1498), new DateTime(2025, 2, 14, 13, 13, 22, 498, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_NormalizedEmail",
                table: "Users",
                column: "NormalizedEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_NormalizedUserName",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_NormalizedEmail",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_NormalizedUserName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11195222-1910-488b-98b5-197377303d10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42905c6b-9cc2-4723-8c51-b7c9c2f11430"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c2c4777-be05-446d-bb56-26cbfe8f1a21"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6cc0a5b4-99dd-4fbb-9336-3faa02bcc87f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("859752a7-f92f-4f41-8345-8c2603a42ba7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e681651-3f8e-498f-99b0-3f196c88a616"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af4b0629-e2d1-4805-8f18-d1425decf075"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b33d1172-a109-4a03-87b1-55e648f8e7db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce867af2-bdb8-4d61-9498-d7fe9d965458"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f01697ae-3d19-4bb7-8849-358ccc8cb6e3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b94b53df-983d-49ee-8aab-e65b8c796b5a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bc6ef463-ba69-4133-b540-30e375aabaf5"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ca96ef27-868a-4981-a1f0-c4df23eb6ca8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f83fabae-9f7c-411c-8849-a146834efc3b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("19b858eb-c42e-44ad-a636-518f9a529606"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("2c0bddff-b45f-4837-9e95-4a6bbcf45119"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("cccc55d7-d5d5-4a07-ab58-38a50c261322"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ccd2fcb8-f043-44ad-9b1b-dd7c89eff63a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0fdc2587-2425-4516-9cb3-d90a8b2dd653"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("285ca1b9-22ae-45a2-85ec-bf346deca57a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("4dc35326-88b6-42be-b943-0a41e6937585"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a3db5f4b-713d-424a-921c-4d1287f3aa4d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("af0668c3-19c6-483b-9d52-eb8ba41092cb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d6987a20-0bb9-4c4b-9478-af118d5a43ec"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("b7943343-5153-43b6-896e-86e84deab981"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("18d2073c-18df-428e-85cb-d40b116bfcbc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3aad1ea8-4e31-4baa-97b4-44638dacbb4e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4d90cdbf-5f88-4e67-bfdc-1465c20f1edf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f9cc908-3a04-49b7-b8b5-e381abc770f1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("acd96219-b79d-488d-9cea-241571d061e0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ca2144a0-bf2a-45d2-a054-8b2485eccd5d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("50d88ee1-6518-4d4f-b9df-91dce466983b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("622fcb6f-8859-40be-8230-3ceb1c6f77fe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aba70367-2324-4c4d-a88f-6602e5e5da8a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cdd25436-de12-40b4-8d4f-5c6d10a5c3cc"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("35289622-b39e-44f0-8d2d-7c800373659a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("4c95384d-e490-43c2-9a6f-5f8466480dc5"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("581bb615-3722-45eb-91a6-0ebdef84b2d9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5c8d70ed-7bcc-4a5c-b5e5-0028d2325e3d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9e507964-a0cd-45f3-a5ef-dd57d2b06770"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2a5d9c5d-5c8a-432d-8b24-90a0cbff1c05"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("94427b7c-6a1c-41ee-86b7-c12eb597bec3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fdaa37d2-672a-4884-a3cc-8527fd35a55a"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ed2c4aa-037b-45d1-a520-d248d0b37aab"), "Vienna", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4476), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("449f1e52-a8b7-4d2a-b8fb-a6dd3650451f"), "Amsterdam", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4461), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("4848ad02-b004-4699-945e-89fef4d140bf"), "Madrid", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4471), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("5a7a435d-01dd-4c82-8cac-07847a442da4"), "Rome", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4467), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("61b6f335-aecd-402d-b51b-e442f355d414"), "London", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4464), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("70ac55f2-a9a7-4f25-976f-6deb9be134d3"), "Paris", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4448), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("8ecae63e-8ca2-4087-875e-152570de3c6e"), "Brussels", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(3675), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("9451593d-5378-49d9-a688-cc01bdcdd1dc"), "Bern", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4474), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("9901be28-4ceb-4655-99ce-282fa086315d"), "Berlin", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4457), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("f02728d2-7418-421a-8017-07dbfd0527da"), "Luxembourg", new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(4479), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("241db133-719d-41e3-874c-a45942c00729"), "GBP", new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(8272), 2, true, "British Pound", "£", null },
                    { new Guid("6aafd072-630b-4cf5-a226-84335a9bd91f"), "EUR", new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(7175), 2, true, "Euro", "€", null },
                    { new Guid("b10518b5-0bef-43f0-b123-c090c4eaea91"), "USD", new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(8266), 2, true, "US Dollar", "$", null },
                    { new Guid("cc6e0501-ff30-4f9e-9d82-129cf41a4bee"), "CHF", new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(8274), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1fee1144-78c4-4b11-8d85-a556c21e513e"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(6149), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("c3681633-0f6c-47a3-b2bf-a95df39aeb4b"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(4725), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("d8b6c2c8-b3f2-4d19-88f4-235cba844a19"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(6161), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("f4654dd7-a2b1-47ad-8179-a2bb77deee21"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(6159), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("10ffe8c7-2ad2-4dd1-9722-adbafbb5453c"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(950), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("5d6f6345-61ee-4fab-a85d-1167ff7de056"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(939), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("61fb1b62-63be-465b-970a-467420bd7cfa"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(954), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("81325055-e094-48fb-9b1a-529024273d5f"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(9182), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("8e581443-531d-4065-9a63-ee7cc93a84e1"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(952), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("e36b174a-d761-4a71-ab6d-8ef9b34e2a6e"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(947), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("debdb566-067e-47f1-a262-e3d0a7b28569"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(2170), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("24adf3eb-cba7-4738-b035-38f49808ac40"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7780), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("285a37c4-7f25-4060-9493-0f630b538d8c"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7770), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("7159c0c9-38b2-4921-9413-e1a0c312d321"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7768), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("8ce7c3b0-626b-417f-8350-5b86155d8da3"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7766), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("b22e342d-2369-4088-aa06-7284897d961c"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(7757), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("dbefd6f2-d673-4155-9150-cf46f3041f05"), new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(6619), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00277422-6bfd-4157-be28-7e26f72f3f49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("11a1332f-85ac-458d-a272-fd9b7b411171"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("44ff8e1b-4b38-4f9a-ab2b-b77cbee44fff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("fc6265c0-10b8-4bf8-a6a3-7a3d51538607"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("18bd07c5-2c7c-4c17-8de3-888f5b63e1e0"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(757), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("20ea42af-4c4f-42a8-b750-23d1d218438d"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(748), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("7b6ab23b-6eb1-4039-a8e3-d866cadd1630"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(801), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("7c368677-cf1c-46b5-a40d-d681dd2f981b"), new DateTime(2025, 2, 14, 12, 56, 29, 341, DateTimeKind.Utc).AddTicks(9103), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("afddfdfb-c695-488f-b6e0-2ff5ecf042a5"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(803), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1d77f898-2a90-4cae-a8d5-eb4c98db2dcc"), new DateTime(2025, 2, 14, 12, 56, 29, 343, DateTimeKind.Utc).AddTicks(244), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("601763c7-8497-4100-94cd-12e001374f89"), new DateTime(2025, 2, 14, 12, 56, 29, 343, DateTimeKind.Utc).AddTicks(251), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("a1471090-996e-4816-8c24-598afacbcea6"), new DateTime(2025, 2, 14, 12, 56, 29, 342, DateTimeKind.Utc).AddTicks(9942), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "CreatedAt", "LastLogin", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 56, 29, 246, DateTimeKind.Utc).AddTicks(7110), new DateTime(2025, 2, 14, 12, 56, 29, 246, DateTimeKind.Utc).AddTicks(7095), "/Pm0tb+EbtZ5PFm9KV7nh7IfTtadgpcXMsn8OCdCOKmGPdlulVje35xmYcp0VfOG", new DateTime(2025, 2, 14, 12, 56, 29, 246, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 271, DateTimeKind.Utc).AddTicks(1777), "user_1@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 271, DateTimeKind.Utc).AddTicks(1772), "USER_1@EXAMPLE.COM", "USER_1", "+BMF1ik/R6y5HUpYdK6E3zHRLuIs3tIUPIfXsg5RIv5KgCugIY+x35M7DydVfENw", "user_1@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 271, DateTimeKind.Utc).AddTicks(1779), "user_1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 278, DateTimeKind.Utc).AddTicks(7204), "user_2@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 278, DateTimeKind.Utc).AddTicks(7201), "USER_2@EXAMPLE.COM", "USER_2", "QEWERsjUcypZcOcwCPOsYK8Ch6wjQuN/89Ppfe9fPTD58VYw/D7VyB7Z7Py1N58h", "user_2@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 278, DateTimeKind.Utc).AddTicks(7206), "user_2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 286, DateTimeKind.Utc).AddTicks(557), "user_3@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 286, DateTimeKind.Utc).AddTicks(554), "USER_3@EXAMPLE.COM", "USER_3", "xcDuj6ugmilc/LqZnn7DGFy9ZqZI4dx752tGSJzux0V+sq80s7EhyOdxAaYooJHA", "user_3@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 286, DateTimeKind.Utc).AddTicks(559), "user_3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 293, DateTimeKind.Utc).AddTicks(6080), "user_4@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 293, DateTimeKind.Utc).AddTicks(6077), "USER_4@EXAMPLE.COM", "USER_4", "dgrVOHmKZRl8rC1JrCPWHbxIyasdhh6GEK+25z7S3CPAYIQL/J5O8VTe7yXS4RjW", "user_4@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 293, DateTimeKind.Utc).AddTicks(6081), "user_4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 299, DateTimeKind.Utc).AddTicks(8468), "user_5@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 299, DateTimeKind.Utc).AddTicks(8463), "USER_5@EXAMPLE.COM", "USER_5", "bU12w8sXel3MzLy0r+F10Kgn+ExAofgCEH9HRykpaJ/d7raWP4xUUhjYHaIZvClS", "user_5@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 299, DateTimeKind.Utc).AddTicks(8470), "user_5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 305, DateTimeKind.Utc).AddTicks(5108), "user_6@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 305, DateTimeKind.Utc).AddTicks(5091), "USER_6@EXAMPLE.COM", "USER_6", "xJ7lwgE0tBv4zz2hRSrDD4/5xePUDIPDLaWuSnzWIE/P/YRBSA/rx19VK89+7Jl5", "user_6@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 305, DateTimeKind.Utc).AddTicks(5109), "user_6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 316, DateTimeKind.Utc).AddTicks(3123), "user_7@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 316, DateTimeKind.Utc).AddTicks(3119), "USER_7@EXAMPLE.COM", "USER_7", "GtH93ZdjW8rlvyvGee8/3LoJ4dSgOXuHUUFH9UPQeuHKhgZjH41zWSAXGMHWCwso", "user_7@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 316, DateTimeKind.Utc).AddTicks(3124), "user_7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 325, DateTimeKind.Utc).AddTicks(7057), "user_8@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 325, DateTimeKind.Utc).AddTicks(7054), "USER_8@EXAMPLE.COM", "USER_8", "dp3Ci4FZ1CYbDu3YEs9OCMxle+MGh9an/gkNT8SXO6dmRds3+de99WeFhUmVSwbB", "user_8@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 325, DateTimeKind.Utc).AddTicks(7058), "user_8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 332, DateTimeKind.Utc).AddTicks(8975), "user_9@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 332, DateTimeKind.Utc).AddTicks(8971), "USER_9@EXAMPLE.COM", "USER_9", "/hplP/HOx2tsDWX3Qp+9IiZ7983IfUzDfvEBcguDFQMiEb4VD2I4glIlRRdCGD3C", "user_9@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 332, DateTimeKind.Utc).AddTicks(8978), "user_9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(3580), "user_10@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(3575), "USER_10@EXAMPLE.COM", "USER_10", "wCTGND6dGiq17alq4pof6sr31wBYarD+o4Q5iGEDssqLF9+smJSYCRmuge2k+kp0", "user_10@example.com", new DateTime(2025, 2, 14, 12, 56, 29, 340, DateTimeKind.Utc).AddTicks(3582), "user_10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 12, 56, 29, 227, DateTimeKind.Utc).AddTicks(4147), new DateTime(2025, 2, 14, 12, 56, 29, 227, DateTimeKind.Utc).AddTicks(1186), new DateTime(2025, 2, 14, 12, 56, 29, 227, DateTimeKind.Utc).AddTicks(5331) });
        }
    }
}
