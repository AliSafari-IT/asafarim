using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPortfoliosTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0cc46e58-47b1-45f9-86f5-284030c8e11c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("200a8455-0f72-4c7c-82cb-88675715e23a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e65ee89-dc6e-4db3-9302-46fae6f55aad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c2d1b9e-aeea-4cc3-9974-0d9caf668a4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("403d0c06-5d1d-4673-8f5f-1cf1a3a836c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f08d041-9c36-44ab-ae4c-b02a4029e3e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53d10411-e144-4215-91dd-360af9ec74fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5929cad3-9204-4b8f-a21f-a0b0a8a467c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94ac6dcb-0180-4b82-9ea6-d7a62c51b28d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bef58820-204a-4f07-8cf3-fdea3b935dbf"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1b86dde1-2092-4abe-9192-46bcff04c578"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("20f11132-4529-45c1-92da-adeeedd8bc23"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5d65b1f3-c974-4a1e-bb78-4225065082ea"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fd050ffa-5482-4f0f-9927-e23d7275dff6"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0916ab96-246e-47e4-a06b-febc9eb4d64d"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("96c23f59-45d3-4734-8894-eea79d8d811b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("c9bbf220-dc03-4e10-8b87-66b0f4ccc629"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("cb204c93-59a6-43d3-8f29-258d047fe1de"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3d96deae-d6e5-43d2-89b7-2b00ec491d5e"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b6231be4-d11b-42c1-9847-4e58c2648ea9"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b7eae529-8cc7-43ac-beca-67b455061b38"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ce59b538-8634-4f15-b65b-6ee7ad26cfb7"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d33e6a09-fedb-49b1-a028-7a929a18ee37"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f046dd1a-5f1f-4841-86c7-0317b3876f89"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("fbbff75b-6ac8-45bd-b3a7-07373e22bd76"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b61dfb5-49a0-4588-ae40-d17fbcdc8407"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ad459ad-7a80-4bc8-b23a-465b845fbf03"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f74b354-db81-4667-8a6d-9f9fdc997ca6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ba7a14ee-244e-4cc3-8941-b4a79d63b258"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e7bca87b-5862-4516-8c02-6148cac0f80d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fe07d465-fbc7-42e0-a28f-b9d9dcb15458"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a7c13f04-56d4-46f0-b806-8a2f3c64ff51"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ae9a985a-6451-4d85-916a-9aa6671d4035"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b84e9b02-59b9-40fa-a0a3-49160431fb8d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("eb2abc03-c95b-4264-89e4-827dcbdf91d0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("170475f5-d41e-46ac-ba6a-dd917c4ae77e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("613f8cf1-1725-4b3b-ac0b-8551bc4770de"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("72148966-fa79-4e3e-954a-b5e8acd0334a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("cdb17851-b58a-4b7c-a8e8-33c7ca72a39d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f784af2a-03b7-41de-9f7f-c436b610567a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("52c2b275-b99e-453a-af41-c1d634338158"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6f1d6e4b-d8f0-4486-832f-769d25b4e0e2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("867f2491-a693-4c28-a56c-5bdb123f5200"));

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    OwnerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Summary = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AboutMarkdown = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExperienceMarkdown = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublicationsMarkdown = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FundingMarkdown = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Visibility = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedMessage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portfolios_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("61c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("71c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("81c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("91c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("a1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("b1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("c1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("d1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("e1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("f1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("109fad37-2acb-405b-aea0-c29f78f87ff6"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("21e4e312-f5f8-4fd0-a741-5ae68deec96e"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("3a21f453-68ca-4034-852f-bb78345ecfba"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("7ced98c7-412a-49d7-b99a-9bc6b762dd08"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("9a65046f-5f7c-4c5d-a010-99dac6d6fb3f"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("a2d99c11-f214-47fa-9e80-beac0d41801a"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("b7f15f04-5fc6-4082-9056-2b2092022f4e"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("c5497f55-053e-4a40-b2ea-7e9000fdc395"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("cec2f4df-1527-42f3-89ec-645799fc8000"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("fc1a87f1-99b7-4a34-966c-f33c27bffbee"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00952b7a-2e63-4f27-b41e-cc050f33679c"), "CHF", new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(6947), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("177a9999-f3ac-4b10-9ff4-49cd1bf3211c"), "GBP", new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(6936), 2, true, "British Pound", "£", null },
                    { new Guid("b80920c1-15a4-4d3b-8450-5c314546f6c8"), "EUR", new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(2321), 2, true, "Euro", "€", null },
                    { new Guid("f03fd365-388d-42ac-b6c0-b83fe5ece1bb"), "USD", new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(6832), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("218574f2-4981-4aad-af41-94645297ea5e"), new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(436), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null },
                    { new Guid("2cfdadaa-e697-492b-a546-6412a82b5d1c"), new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(408), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("983b576e-6935-4d42-9a9a-09de0d3a197e"), new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(415), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("a194c629-dd6c-4c93-b7af-c41d7f65f562"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(7557), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("47f6b5e6-78ac-445f-b960-322d87a241e4"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(1068), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("5c7f476d-9650-4951-a930-b9bd8d5cea34"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(950), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("5eaa0e01-1cd2-4ae1-91ac-edebbbc10719"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(954), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("63fd0ead-3f90-4aa5-92c2-e6075a2cc91c"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(932), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("7099462e-9e6f-4eb3-ad33-ade03a10b912"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(8181), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("72e49c06-df15-41e9-875e-0565ae278a84"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(1064), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("f07c8a09-77b1-4742-a8ba-e62e52b46011"), new DateTime(2025, 4, 1, 16, 5, 27, 793, DateTimeKind.Utc).AddTicks(2957), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1b288cb6-6948-4cfc-8d15-78774f6f149a"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5786), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("7fefe91f-29b4-4ca6-8dde-f2765c29830b"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5754), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("b0d10fdc-5fa6-4f4f-924e-1df51bbdaf68"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5797), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("d7286970-b68b-47b7-868d-d0f2ec5b1b68"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5791), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("ea15de58-cff6-481f-886a-fc9223ab9bdf"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(3587), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("ff9ce8bb-2ecc-40ea-8f31-124868b67b9e"), new DateTime(2025, 4, 1, 16, 5, 27, 792, DateTimeKind.Utc).AddTicks(5765), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4cbb9c30-397f-4dc6-a8bb-c91bd18f5af4"), null, new DateTime(2025, 4, 1, 16, 5, 27, 796, DateTimeKind.Utc).AddTicks(9272), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("5ef570e9-b9fd-49e6-a542-ab29ea5cf72b"), null, new DateTime(2025, 4, 1, 16, 5, 27, 797, DateTimeKind.Utc).AddTicks(1514), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("64a15ff6-5753-43e1-8ad3-78710fd6a9f3"), null, new DateTime(2025, 4, 1, 16, 5, 27, 797, DateTimeKind.Utc).AddTicks(1533), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("fd0c394b-4fbc-4330-ac37-50130d8d8843"), null, new DateTime(2025, 4, 1, 16, 5, 27, 797, DateTimeKind.Utc).AddTicks(1527), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("38768416-1754-4b77-bcee-578340316f06"), new DateTime(2025, 4, 1, 16, 5, 27, 795, DateTimeKind.Utc).AddTicks(2700), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("6648f55d-5e1f-48d8-bae4-f068a52017f9"), new DateTime(2025, 4, 1, 16, 5, 27, 795, DateTimeKind.Utc).AddTicks(2680), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("930f8817-12f1-447f-a8da-fe6bb3cd156f"), new DateTime(2025, 4, 1, 16, 5, 27, 795, DateTimeKind.Utc).AddTicks(2719), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("c8214769-c5c5-4b96-8d5e-2e28f53e67b2"), new DateTime(2025, 4, 1, 16, 5, 27, 794, DateTimeKind.Utc).AddTicks(9763), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("df933175-638f-4831-89ce-9564b2df3797"), new DateTime(2025, 4, 1, 16, 5, 27, 795, DateTimeKind.Utc).AddTicks(2723), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 16, 5, 27, 797, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3d82ed20-fa3e-43ce-8cd7-82aab30f7594"), new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(1005), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("b9fe97ed-7a3b-4770-a9cb-c9e502bcaaab"), new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(969), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("f67be590-6d8e-4d1c-a389-1954a3a04af4"), new DateTime(2025, 4, 1, 16, 5, 27, 798, DateTimeKind.Utc).AddTicks(997), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "z1o14fDMFFAF5shoM0EneW8zvRjo7E8fOC3a9umNaeZ9oJIqQnvVEbkfxdtWD1Tn");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "qut7PgRa+BNJs7QJAsuR0YLGhWl4bUbqhNk9EB5J4mSEoB9qim1CrGlQ2lEJ1Tgu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_45a5@example.com", "user_1_45a5@example.com", "USER_1_45A5@EXAMPLE.COM", "USER_1_45A5", "94XEbRAO5sjM6+uSgN/aCTq/W8iIj/EejG8d6Gvcp1t/0nKcBzg8VoUhXm7mD3eX", "user_1_45a5@example.com", "user_1_45a5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_d8f6@example.com", "user_2_d8f6@example.com", "USER_2_D8F6@EXAMPLE.COM", "USER_2_D8F6", "k3jKYRq1znktMF+PqY/6MMXtrxFblqxc2SSEUPvhCNSUXfLlysvt+2hVUL4nvMJ5", "user_2_d8f6@example.com", "user_2_d8f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_c6aa@example.com", "user_3_c6aa@example.com", "USER_3_C6AA@EXAMPLE.COM", "USER_3_C6AA", "z0sGY0QYLH9cF8LNkXEW6cq5b0XcIH6JKUrO1jEowgB+7Jvta2nIL7SLvSYk4a5r", "user_3_c6aa@example.com", "user_3_c6aa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_e0d8@example.com", "user_4_e0d8@example.com", "USER_4_E0D8@EXAMPLE.COM", "USER_4_E0D8", "2R/vxa45LXGqo4b8vAoTKhdFPtRjUjyB0F+k3+PM4Q5w3F+8QisBY83aBMO9U5/s", "user_4_e0d8@example.com", "user_4_e0d8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_f0be@example.com", "user_5_f0be@example.com", "USER_5_F0BE@EXAMPLE.COM", "USER_5_F0BE", "j/L64mz6OvC0SbuzWi1f0Q9oPZ5GsvAOOrusNkoTwqipFHveWR6z9LPjFasLvuub", "user_5_f0be@example.com", "user_5_f0be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_7fdb@example.com", "user_6_7fdb@example.com", "USER_6_7FDB@EXAMPLE.COM", "USER_6_7FDB", "LmFMAznjfIs/DW3H97rVQEIZBrtGN+L+s0dKg6vm6z6VXyuTy78Sj7uRV94BGndX", "user_6_7fdb@example.com", "user_6_7fdb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_9a99@example.com", "user_7_9a99@example.com", "USER_7_9A99@EXAMPLE.COM", "USER_7_9A99", "SNFb6UQKLcpliq0ebs/PH4vWhkA7enVjvFJkgP5GBq1uEIITNT4XZlOYWZFIfTF8", "user_7_9a99@example.com", "user_7_9a99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_5760@example.com", "user_8_5760@example.com", "USER_8_5760@EXAMPLE.COM", "USER_8_5760", "TpwAonxJ8oYrSr0Mzl64N0eDppdwXn1L6yDVhMK4PhDUvVP73HWImYQVU11s9ARX", "user_8_5760@example.com", "user_8_5760" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_e5cf@example.com", "user_9_e5cf@example.com", "USER_9_E5CF@EXAMPLE.COM", "USER_9_E5CF", "/ofDOL3NLHZQcmN3t0xvAmBiyeoRV5mdf14jb6oVXLo+oAFwGxlaRJhyyVVkufFP", "user_9_e5cf@example.com", "user_9_e5cf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_d224@example.com", "user_10_d224@example.com", "USER_10_D224@EXAMPLE.COM", "USER_10_D224", "yPlCGO0DIGZErckh9FJrLjZzHnqb+I0S4r09AlcQNDDCRRVGo2w4djiqZEReSGAN", "user_10_d224@example.com", "user_10_d224" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_c69d@example.com", "user_11_c69d@example.com", "USER_11_C69D@EXAMPLE.COM", "USER_11_C69D", "0mCa/qlV1vemzBAp3JSyxLJNm1gDc7BzMBMWQXyOSFykXwEFkRvduk8/48W70kpF", "user_11_c69d@example.com", "user_11_c69d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_d0d3@example.com", "user_12_d0d3@example.com", "USER_12_D0D3@EXAMPLE.COM", "USER_12_D0D3", "JFrsoh3KreW313ihR0bomQV/nltPBx4eyEZ710iaH/C++CgMWpvGznKPaTHjc2pc", "user_12_d0d3@example.com", "user_12_d0d3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_56b2@example.com", "user_13_56b2@example.com", "USER_13_56B2@EXAMPLE.COM", "USER_13_56B2", "Yc4woH94ICN5p8gJ4h9dm9B6FSNNCASkoY0RYe90jVj79uS/3Z55kiEpfGtwFBUg", "user_13_56b2@example.com", "user_13_56b2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_f552@example.com", "user_14_f552@example.com", "USER_14_F552@EXAMPLE.COM", "USER_14_F552", "hafqs/bqfQFvdXmA4EiHuJp2Ny898TuYgICSTniwMaPx2SdmTwmn1+1v/fbm1XVM", "user_14_f552@example.com", "user_14_f552" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_f53e@example.com", "user_15_f53e@example.com", "USER_15_F53E@EXAMPLE.COM", "USER_15_F53E", "plv71I1fyJwDrHycTXengZaeRMH/QXmWXK8HDSDSG/ziX9lt24gz0Znurb5Mji1h", "user_15_f53e@example.com", "user_15_f53e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_00a6@example.com", "user_16_00a6@example.com", "USER_16_00A6@EXAMPLE.COM", "USER_16_00A6", "wJmW0fTVQWe6LaBhS9T75LhfGDL9Fk5f2Fuv1XkBOxuVxAiaQUg/DhTvBwI1U8ms", "user_16_00a6@example.com", "user_16_00a6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_c198@example.com", "user_17_c198@example.com", "USER_17_C198@EXAMPLE.COM", "USER_17_C198", "v0CfVvouUU8koO3mL2YJHAmoXSLgzPv2nn1MYBBMTRVVZqKDiowrKUttbNNtYNyG", "user_17_c198@example.com", "user_17_c198" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_ba62@example.com", "user_18_ba62@example.com", "USER_18_BA62@EXAMPLE.COM", "USER_18_BA62", "HrRFuG3APIPwt8Yhe3UhbdzSS+FafnZB1KKj83OlZK3tMkNij9Jy0A6s3ry4XJl0", "user_18_ba62@example.com", "user_18_ba62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_eceb@example.com", "user_19_eceb@example.com", "USER_19_ECEB@EXAMPLE.COM", "USER_19_ECEB", "T07z/gl3fO6Y1jKBAUO2nLdIyAZV3I6xGHXgUicVhfyvk69Jy4EN2E5hNO8sj9Gu", "user_19_eceb@example.com", "user_19_eceb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_29f3@example.com", "user_20_29f3@example.com", "USER_20_29F3@EXAMPLE.COM", "USER_20_29F3", "VxvtQo/macrdtjRgAolGc/4Ds/jr2s0QuFv5X143GF+CiuzTWU3XfYv8q3v02kST", "user_20_29f3@example.com", "user_20_29f3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_29e3@example.com", "user_21_29e3@example.com", "USER_21_29E3@EXAMPLE.COM", "USER_21_29E3", "XbROUfy44h2GSmrSOwK0GwefjZdufSpRPa+X+1ZhK2BR+17MCVFh51YT1bd2yHox", "user_21_29e3@example.com", "user_21_29e3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_3111@example.com", "user_22_3111@example.com", "USER_22_3111@EXAMPLE.COM", "USER_22_3111", "GzjxyEUIyk1rWSzWcLg94hDhLoXlbs9ZYrQxIkZRrJvu4IXqPFRZn3XuRrLmt+fD", "user_22_3111@example.com", "user_22_3111" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_8403@example.com", "user_23_8403@example.com", "USER_23_8403@EXAMPLE.COM", "USER_23_8403", "lSIBkWJ2HeLemjeXGtV3U2CNk2lTVl1aJFtxJpUlkPS/IB+sYadl7+RfMc7LmATD", "user_23_8403@example.com", "user_23_8403" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_ae17@example.com", "user_24_ae17@example.com", "USER_24_AE17@EXAMPLE.COM", "USER_24_AE17", "MZtMmPcSHg++HbABagsimVzCVY97xa1f6WPbn5K1qQJ7lCTlU6Ew28EgET5f0Bjp", "user_24_ae17@example.com", "user_24_ae17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_40f5@example.com", "user_25_40f5@example.com", "USER_25_40F5@EXAMPLE.COM", "USER_25_40F5", "9wHqbbvf4/yTg7CTJn0qqk3owB6IrWWYWh97rLgtMkQqn2t7pNxhr1CC3Jbw7F8g", "user_25_40f5@example.com", "user_25_40f5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_307d@example.com", "user_26_307d@example.com", "USER_26_307D@EXAMPLE.COM", "USER_26_307D", "UVq2BGGkfmyDPYFlbVV1XDw9aRTQNPA6+EZ/PZwMeFTVNxiCQ37DmQdlvXz1U2pb", "user_26_307d@example.com", "user_26_307d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_0b0a@example.com", "user_27_0b0a@example.com", "USER_27_0B0A@EXAMPLE.COM", "USER_27_0B0A", "BGOEB43jdQeJVLREMmC6lylHB+fBZB03w2V5Y555ef5Cbu9Mu50bAlyUViHujaoT", "user_27_0b0a@example.com", "user_27_0b0a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_0a11@example.com", "user_28_0a11@example.com", "USER_28_0A11@EXAMPLE.COM", "USER_28_0A11", "M2bgHZwbvFCyI0vfWnmZLg30wOzLUKf2RZTzWAJSOT1JO1W4C5MiEeohZ8tFvhJt", "user_28_0a11@example.com", "user_28_0a11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_ca1e@example.com", "user_29_ca1e@example.com", "USER_29_CA1E@EXAMPLE.COM", "USER_29_CA1E", "vMl5qPjDBxd08v/8p+bYem0WdZukOKIKKp5Hxg9k3j8s19QHABl0Au2LGnblWhjF", "user_29_ca1e@example.com", "user_29_ca1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_2711@example.com", "user_30_2711@example.com", "USER_30_2711@EXAMPLE.COM", "USER_30_2711", "9L01GiwR3iSX4rs88EPq+KQhJ1V9/m3HBf2Ly70vtDVzclPhLOnd8X8BI9ut18gt", "user_30_2711@example.com", "user_30_2711" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_2522@example.com", "user_31_2522@example.com", "USER_31_2522@EXAMPLE.COM", "USER_31_2522", "g3rFDuh2TjMWH1onad33C+oYuRt7uHjF+bTwt94YR/56LJS/OvNBRJTnV2nxg51k", "user_31_2522@example.com", "user_31_2522" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_c27c@example.com", "user_32_c27c@example.com", "USER_32_C27C@EXAMPLE.COM", "USER_32_C27C", "xtgJ5BQ8ClI8bGgBrWr02HvG0VEwbVaw/MxpxY2Vhlj9/dLhAfQ8fF7WUozHblT7", "user_32_c27c@example.com", "user_32_c27c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_da9a@example.com", "user_33_da9a@example.com", "USER_33_DA9A@EXAMPLE.COM", "USER_33_DA9A", "YQIVRrIhCXQxPulRFsfHiIYbk4GQ2h9DUlSUEaNPXjCYDKWwHu1XdWaymV1dMW2r", "user_33_da9a@example.com", "user_33_da9a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_80ad@example.com", "user_34_80ad@example.com", "USER_34_80AD@EXAMPLE.COM", "USER_34_80AD", "c0jethrTYcJkxLgbP6y3SfMeOvz7gxxK1A7h/sFeUZMnmSb0HZY63ZVzjyoLC3Ro", "user_34_80ad@example.com", "user_34_80ad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_c43e@example.com", "user_35_c43e@example.com", "USER_35_C43E@EXAMPLE.COM", "USER_35_C43E", "45bucARY+oSYMCclBjwH/TiCdF5S7w1pbO02im+Isrni1gHo6wJbHCB3fK/J2d9g", "user_35_c43e@example.com", "user_35_c43e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_b16e@example.com", "user_36_b16e@example.com", "USER_36_B16E@EXAMPLE.COM", "USER_36_B16E", "jckJbKCzVs/g0yibKDGBG4UyqJhWZ6cJnqXvoprkrk51Dy8G1pQrhrjLcEZqQxjh", "user_36_b16e@example.com", "user_36_b16e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_700f@example.com", "user_37_700f@example.com", "USER_37_700F@EXAMPLE.COM", "USER_37_700F", "Tw5qyKiaKk01+rO8Ok/i0sjwoHn9fnbFfPOfgmSpPJHMPMerHP7y8V6ExRh8nEw/", "user_37_700f@example.com", "user_37_700f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_808f@example.com", "user_38_808f@example.com", "USER_38_808F@EXAMPLE.COM", "USER_38_808F", "X0onDdvJssQk73KhOMF7N0LZff3mf6hP4cQhXCf7i08V0ht9+n+lSlFfoNAo8l4Z", "user_38_808f@example.com", "user_38_808f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_8424@example.com", "user_39_8424@example.com", "USER_39_8424@EXAMPLE.COM", "USER_39_8424", "AUWc6DRemfyPUPYJI7X7ZBHokMOPx2FCbVcCjwUuMpMcIiBT1v3B4l6GwvRCI06K", "user_39_8424@example.com", "user_39_8424" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_b3f0@example.com", "user_40_b3f0@example.com", "USER_40_B3F0@EXAMPLE.COM", "USER_40_B3F0", "7sRrdzTamgGZBaQGirbjpAwG/UYd8VvvLv065inzw1LpHOUNh+ZjZnJcZkLn7ceT", "user_40_b3f0@example.com", "user_40_b3f0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_25bb@example.com", "user_41_25bb@example.com", "USER_41_25BB@EXAMPLE.COM", "USER_41_25BB", "FwMNY+inSod2CkKyg7gNJtkX7i6L+MTl7aadl33ZO6j3ebHGlew7do0AdifQmo7g", "user_41_25bb@example.com", "user_41_25bb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_7f1b@example.com", "user_42_7f1b@example.com", "USER_42_7F1B@EXAMPLE.COM", "USER_42_7F1B", "qUaK5vXZuCjz+w/gaeiXKuygsP82UsLdeiVWq+WAKGs1fym45h0cWRY1PWgaPjk6", "user_42_7f1b@example.com", "user_42_7f1b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_3470@example.com", "user_43_3470@example.com", "USER_43_3470@EXAMPLE.COM", "USER_43_3470", "Td5g1NVP9cR0rvmYb12a2zlLaq/nTSy0rHYIUnfpipvqN8L+MG11K30ye3N2HGnj", "user_43_3470@example.com", "user_43_3470" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_4da0@example.com", "user_44_4da0@example.com", "USER_44_4DA0@EXAMPLE.COM", "USER_44_4DA0", "eCREwbiwN8StF0jnRquVbIt2O2SQZMkSsDp0QiME7SBCgi+UxX09lvNBVLdouUdU", "user_44_4da0@example.com", "user_44_4da0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_1bb1@example.com", "user_45_1bb1@example.com", "USER_45_1BB1@EXAMPLE.COM", "USER_45_1BB1", "8yooLrl79RG8BRS2LJyeeEbiJbWX0HQBVgew6pQH3wHdw3mEqWmmDvpOkCF/RMhO", "user_45_1bb1@example.com", "user_45_1bb1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_7ac6@example.com", "user_46_7ac6@example.com", "USER_46_7AC6@EXAMPLE.COM", "USER_46_7AC6", "IxY5dhLD1+LPRAtlRgCia3AFGWp47Atns/TVAv0ilFYjy2VdsflFLTq2irW110rp", "user_46_7ac6@example.com", "user_46_7ac6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_4853@example.com", "user_47_4853@example.com", "USER_47_4853@EXAMPLE.COM", "USER_47_4853", "lgIB2IBPo3hsi0BD74ntqmv5ZjbTKLmrJkGTI3Pk7UePcMn7+EKMvGTGGJHsVn40", "user_47_4853@example.com", "user_47_4853" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_5869@example.com", "user_48_5869@example.com", "USER_48_5869@EXAMPLE.COM", "USER_48_5869", "s8USoDqKoAPKIUS7KOU7rF+wq8mum3+Wiz2jgxJC5hJ4kNtAjZRfJx7HTUaTb6nh", "user_48_5869@example.com", "user_48_5869" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_326f@example.com", "user_49_326f@example.com", "USER_49_326F@EXAMPLE.COM", "USER_49_326F", "KO4tRj9LimBl2eKqi59Kac03NUcBC/fJQ3UrGCotmqlGzguW9RXLL0Qq+V6+d77Z", "user_49_326f@example.com", "user_49_326f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_aa3b@example.com", "user_50_aa3b@example.com", "USER_50_AA3B@EXAMPLE.COM", "USER_50_AA3B", "Qa42BdVctKszkrbEAVEuoe9gPvZd/LLVZSu5ChyMla6CqBC1jGwfocnqaPSRfjko", "user_50_aa3b@example.com", "user_50_aa3b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "/iaNYV8qRjwsy+shsob4Rixcz7Qy03uGNWCEcUtUqSA6N0LrdUR2mpKQHx+qSSYm");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_OwnerId",
                table: "Portfolios",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("109fad37-2acb-405b-aea0-c29f78f87ff6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21e4e312-f5f8-4fd0-a741-5ae68deec96e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a21f453-68ca-4034-852f-bb78345ecfba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ced98c7-412a-49d7-b99a-9bc6b762dd08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a65046f-5f7c-4c5d-a010-99dac6d6fb3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2d99c11-f214-47fa-9e80-beac0d41801a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7f15f04-5fc6-4082-9056-2b2092022f4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5497f55-053e-4a40-b2ea-7e9000fdc395"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cec2f4df-1527-42f3-89ec-645799fc8000"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc1a87f1-99b7-4a34-966c-f33c27bffbee"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("00952b7a-2e63-4f27-b41e-cc050f33679c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("177a9999-f3ac-4b10-9ff4-49cd1bf3211c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b80920c1-15a4-4d3b-8450-5c314546f6c8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f03fd365-388d-42ac-b6c0-b83fe5ece1bb"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("218574f2-4981-4aad-af41-94645297ea5e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("2cfdadaa-e697-492b-a546-6412a82b5d1c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("983b576e-6935-4d42-9a9a-09de0d3a197e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("a194c629-dd6c-4c93-b7af-c41d7f65f562"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("47f6b5e6-78ac-445f-b960-322d87a241e4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5c7f476d-9650-4951-a930-b9bd8d5cea34"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5eaa0e01-1cd2-4ae1-91ac-edebbbc10719"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("63fd0ead-3f90-4aa5-92c2-e6075a2cc91c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("7099462e-9e6f-4eb3-ad33-ade03a10b912"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("72e49c06-df15-41e9-875e-0565ae278a84"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("f07c8a09-77b1-4742-a8ba-e62e52b46011"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b288cb6-6948-4cfc-8d15-78774f6f149a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7fefe91f-29b4-4ca6-8dde-f2765c29830b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b0d10fdc-5fa6-4f4f-924e-1df51bbdaf68"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d7286970-b68b-47b7-868d-d0f2ec5b1b68"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ea15de58-cff6-481f-886a-fc9223ab9bdf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ff9ce8bb-2ecc-40ea-8f31-124868b67b9e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4cbb9c30-397f-4dc6-a8bb-c91bd18f5af4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5ef570e9-b9fd-49e6-a542-ab29ea5cf72b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("64a15ff6-5753-43e1-8ad3-78710fd6a9f3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fd0c394b-4fbc-4330-ac37-50130d8d8843"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("38768416-1754-4b77-bcee-578340316f06"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6648f55d-5e1f-48d8-bae4-f068a52017f9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("930f8817-12f1-447f-a8da-fe6bb3cd156f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c8214769-c5c5-4b96-8d5e-2e28f53e67b2"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("df933175-638f-4831-89ce-9564b2df3797"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3d82ed20-fa3e-43ce-8cd7-82aab30f7594"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b9fe97ed-7a3b-4770-a9cb-c9e502bcaaab"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f67be590-6d8e-4d1c-a389-1954a3a04af4"));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("61c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("71c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("81c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("91c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("a1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("b1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("c1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("d1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("e1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "BibliographyItems",
                keyColumn: "Id",
                keyValue: new Guid("f1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 230, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cc46e58-47b1-45f9-86f5-284030c8e11c"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("200a8455-0f72-4c7c-82cb-88675715e23a"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("2e65ee89-dc6e-4db3-9302-46fae6f55aad"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("3c2d1b9e-aeea-4cc3-9974-0d9caf668a4b"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("403d0c06-5d1d-4673-8f5f-1cf1a3a836c9"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("4f08d041-9c36-44ab-ae4c-b02a4029e3e8"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("53d10411-e144-4215-91dd-360af9ec74fc"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("5929cad3-9204-4b8f-a21f-a0b0a8a467c1"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("94ac6dcb-0180-4b82-9ea6-d7a62c51b28d"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("bef58820-204a-4f07-8cf3-fdea3b935dbf"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b86dde1-2092-4abe-9192-46bcff04c578"), "CHF", new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(8369), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("20f11132-4529-45c1-92da-adeeedd8bc23"), "GBP", new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(8367), 2, true, "British Pound", "£", null },
                    { new Guid("5d65b1f3-c974-4a1e-bb78-4225065082ea"), "USD", new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(8361), 2, true, "US Dollar", "$", null },
                    { new Guid("fd050ffa-5482-4f0f-9927-e23d7275dff6"), "EUR", new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(7308), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0916ab96-246e-47e4-a06b-febc9eb4d64d"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(6487), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("96c23f59-45d3-4734-8894-eea79d8d811b"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(5571), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("c9bbf220-dc03-4e10-8b87-66b0f4ccc629"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(6490), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("cb204c93-59a6-43d3-8f29-258d047fe1de"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(6498), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3d96deae-d6e5-43d2-89b7-2b00ec491d5e"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(1443), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("b6231be4-d11b-42c1-9847-4e58c2648ea9"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2572), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("b7eae529-8cc7-43ac-beca-67b455061b38"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2569), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("ce59b538-8634-4f15-b65b-6ee7ad26cfb7"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2522), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("d33e6a09-fedb-49b1-a028-7a929a18ee37"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2574), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("f046dd1a-5f1f-4841-86c7-0317b3876f89"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(2579), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("fbbff75b-6ac8-45bd-b3a7-07373e22bd76"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(3372), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1b61dfb5-49a0-4588-ae40-d17fbcdc8407"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(563), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("6ad459ad-7a80-4bc8-b23a-465b845fbf03"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(559), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("8f74b354-db81-4667-8a6d-9f9fdc997ca6"), new DateTime(2025, 4, 1, 11, 50, 58, 227, DateTimeKind.Utc).AddTicks(9548), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("ba7a14ee-244e-4cc3-8941-b4a79d63b258"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(570), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("e7bca87b-5862-4516-8c02-6148cac0f80d"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(572), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("fe07d465-fbc7-42e0-a28f-b9d9dcb15458"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(574), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a7c13f04-56d4-46f0-b806-8a2f3c64ff51"), null, new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(4591), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("ae9a985a-6451-4d85-916a-9aa6671d4035"), null, new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(5254), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("b84e9b02-59b9-40fa-a0a3-49160431fb8d"), null, new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(5249), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("eb2abc03-c95b-4264-89e4-827dcbdf91d0"), null, new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(5252), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("170475f5-d41e-46ac-ba6a-dd917c4ae77e"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(211), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("613f8cf1-1725-4b3b-ac0b-8551bc4770de"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(259), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("72148966-fa79-4e3e-954a-b5e8acd0334a"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(197), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("cdb17851-b58a-4b7c-a8e8-33c7ca72a39d"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(214), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("f784af2a-03b7-41de-9f7f-c436b610567a"), new DateTime(2025, 4, 1, 11, 50, 58, 228, DateTimeKind.Utc).AddTicks(9048), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("52c2b275-b99e-453a-af41-c1d634338158"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(8048), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("6f1d6e4b-d8f0-4486-832f-769d25b4e0e2"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(8051), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("867f2491-a693-4c28-a56c-5bdb123f5200"), new DateTime(2025, 4, 1, 11, 50, 58, 229, DateTimeKind.Utc).AddTicks(8039), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "Sx5zAw4hfvKYNYDhWwph5gEysYgyEdWUxSgx+nF6USJA0ArWXboLt4fgKxchjNv3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "3SSROBJk8vxcuotrMv4du2kc5X4Tgq9dc1IxEmnYgtYfB/HD7696/6+C7ApZX1OM");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_9111@example.com", "user_1_9111@example.com", "USER_1_9111@EXAMPLE.COM", "USER_1_9111", "/+XHc3XwvKD3Llmqmhs9YSOHsmr1NUNWqps4V9RgJR2yaGNC/4+V9MAcFMAsuzDx", "user_1_9111@example.com", "user_1_9111" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_fc14@example.com", "user_2_fc14@example.com", "USER_2_FC14@EXAMPLE.COM", "USER_2_FC14", "ryOTDDDKG82VO4UH4bWn0yJYFQv6jDkJSTYc7HqJuQVv088zMAFA6dy+RljB/j5L", "user_2_fc14@example.com", "user_2_fc14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_955c@example.com", "user_3_955c@example.com", "USER_3_955C@EXAMPLE.COM", "USER_3_955C", "jkSR2/M8oV1qBzSZRLj23hbu84r5Xwfc+JmZNKZc9vFG+jBDO4V2xqM90vfNouY+", "user_3_955c@example.com", "user_3_955c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_f59f@example.com", "user_4_f59f@example.com", "USER_4_F59F@EXAMPLE.COM", "USER_4_F59F", "H54XRfJR6pEHOyh3rfOt64VB21FhSuNF+TK66YVGQKSk2EwQsti9xsAk7DPT6vLI", "user_4_f59f@example.com", "user_4_f59f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_af31@example.com", "user_5_af31@example.com", "USER_5_AF31@EXAMPLE.COM", "USER_5_AF31", "3WaESMbS4sQVYpWO/ZCGpRIrvl8onRmpXxw+VN3bWiARy0KEOoSh8WKPxE/zowxe", "user_5_af31@example.com", "user_5_af31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_1c6f@example.com", "user_6_1c6f@example.com", "USER_6_1C6F@EXAMPLE.COM", "USER_6_1C6F", "bGpGH07paiLCy6+26CdbcWki5bq5/S8PFVa5akt1+sNEYrYhWjL6McKzl7nB4DR6", "user_6_1c6f@example.com", "user_6_1c6f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_a16f@example.com", "user_7_a16f@example.com", "USER_7_A16F@EXAMPLE.COM", "USER_7_A16F", "XOWq4fQltpDhlbuvUZ466hSlPiDGdtQdnNEzVYIvsXXpFt8DsAPsDhi0c27hEpto", "user_7_a16f@example.com", "user_7_a16f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_497e@example.com", "user_8_497e@example.com", "USER_8_497E@EXAMPLE.COM", "USER_8_497E", "uAjsHI5c9aNVtSCpt/C3hnHdEHRWK7gHHKlmAjqOYnO0vj7MULLDWLczhEPweg5u", "user_8_497e@example.com", "user_8_497e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_53ea@example.com", "user_9_53ea@example.com", "USER_9_53EA@EXAMPLE.COM", "USER_9_53EA", "J6rD7hozFN+dfAGMVuMRWrLLKX37iL741eZekbl+Ww55mYRJVSjFEzra66r5B18L", "user_9_53ea@example.com", "user_9_53ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_e9ba@example.com", "user_10_e9ba@example.com", "USER_10_E9BA@EXAMPLE.COM", "USER_10_E9BA", "HgzFuA6es6vdq2hRWvIGRXShKYF6/EMTPes0z2+/APARmQks0Gd5s7y+n3Pn3XrI", "user_10_e9ba@example.com", "user_10_e9ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_b054@example.com", "user_11_b054@example.com", "USER_11_B054@EXAMPLE.COM", "USER_11_B054", "+oJpj/aohnB1D2+tD8/zbpSA024NFoeQMjOaAhNCp9Iq9AZQME5zRuhhiM+Ym9PF", "user_11_b054@example.com", "user_11_b054" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_980e@example.com", "user_12_980e@example.com", "USER_12_980E@EXAMPLE.COM", "USER_12_980E", "heR0A+8K9G5ghAJWDFSpJFDqr5vD8nlHO0FXPAE1WtlwDLKxC+D7oBIbI4CZzFIj", "user_12_980e@example.com", "user_12_980e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_92c3@example.com", "user_13_92c3@example.com", "USER_13_92C3@EXAMPLE.COM", "USER_13_92C3", "j2Td0V+6KXYYKPYyX8q622uEFGrtv8GKeGdbd8CrwjklXr3wY3xma1Si7+54YObI", "user_13_92c3@example.com", "user_13_92c3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_9efa@example.com", "user_14_9efa@example.com", "USER_14_9EFA@EXAMPLE.COM", "USER_14_9EFA", "xdnv+pH7x21zs5xxHU/b3oNA/gAMPf0pACi7aKHUE9g0DHr5i0nPZplM3lLY+7Cj", "user_14_9efa@example.com", "user_14_9efa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_024b@example.com", "user_15_024b@example.com", "USER_15_024B@EXAMPLE.COM", "USER_15_024B", "6vf30BUFBgLzn6dtACiJMOVm9NVvCHQ5WympDFL8wWgLFc7Pck1HrrV0VxDSTJEa", "user_15_024b@example.com", "user_15_024b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_a93a@example.com", "user_16_a93a@example.com", "USER_16_A93A@EXAMPLE.COM", "USER_16_A93A", "SsMRzC3Q0dMSLe8xraCATcrah3eXobz7Bbz3lrlzZJRH3KlbyeTlq4lNo0EGHbJd", "user_16_a93a@example.com", "user_16_a93a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_8f6e@example.com", "user_17_8f6e@example.com", "USER_17_8F6E@EXAMPLE.COM", "USER_17_8F6E", "HkHvC9Q6mUTcVeZcOz5oQ6aJEvV5wVuN3/0i1uw5/p1CG/97GEZtp3CuhpZnQICg", "user_17_8f6e@example.com", "user_17_8f6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_5ca0@example.com", "user_18_5ca0@example.com", "USER_18_5CA0@EXAMPLE.COM", "USER_18_5CA0", "n8Geg1dNtxEmTE/22tR05Ofak31rnZqBC+ekHCpKiYV9bSyD8vY0OG2TGWVI7nVD", "user_18_5ca0@example.com", "user_18_5ca0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_3377@example.com", "user_19_3377@example.com", "USER_19_3377@EXAMPLE.COM", "USER_19_3377", "asY1CPVC95SnH/hTdhfe7PepUpzYA4sl0QUHChDin7CLIk4384c3UyjScYuihVVw", "user_19_3377@example.com", "user_19_3377" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_c580@example.com", "user_20_c580@example.com", "USER_20_C580@EXAMPLE.COM", "USER_20_C580", "f5wSPUWCjUDWMsp2dOoyowrMidEN18USesmGlgSs4KIwtqeEPJ6A3IVDh+EjPOgM", "user_20_c580@example.com", "user_20_c580" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_2ae4@example.com", "user_21_2ae4@example.com", "USER_21_2AE4@EXAMPLE.COM", "USER_21_2AE4", "BU0yR+U+ZnPyaBCwoZ5DfO1yELZ8SABqfImmnJQao4eQh7JiN9XGej48lylZmmB7", "user_21_2ae4@example.com", "user_21_2ae4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_d930@example.com", "user_22_d930@example.com", "USER_22_D930@EXAMPLE.COM", "USER_22_D930", "1AfdRq8+3li0fDJ4YShlADH68fUNPlgSBWMV/gAH9wodUYpcgDssrcOYdwiLnmCA", "user_22_d930@example.com", "user_22_d930" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_629e@example.com", "user_23_629e@example.com", "USER_23_629E@EXAMPLE.COM", "USER_23_629E", "40l1b/K1XHBH34eTd14apfCdNhen/Yv05bZEnJ8qmAHws3/XX1WB3/2zpG6zT2Fx", "user_23_629e@example.com", "user_23_629e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_e4e4@example.com", "user_24_e4e4@example.com", "USER_24_E4E4@EXAMPLE.COM", "USER_24_E4E4", "y0sZaHOdu7KazZjqIXf9ekvWP/qZaJHc4JVdSvBqLo4SU+tiVnrbUqeiUSwCgAWy", "user_24_e4e4@example.com", "user_24_e4e4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_1d7e@example.com", "user_25_1d7e@example.com", "USER_25_1D7E@EXAMPLE.COM", "USER_25_1D7E", "GkRzUpYKH8ciiIl+4zEtGXwF0TyJGYvi4s8FqCIlfMsfJ9ploSm4C8qlY0jf0bDL", "user_25_1d7e@example.com", "user_25_1d7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_db32@example.com", "user_26_db32@example.com", "USER_26_DB32@EXAMPLE.COM", "USER_26_DB32", "k6GS03kiXEeXoAcmfjx86Fyp0/mZYrbnF6xLeCtDlIx+7PM562QlGvZLOBUhpaG5", "user_26_db32@example.com", "user_26_db32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_5685@example.com", "user_27_5685@example.com", "USER_27_5685@EXAMPLE.COM", "USER_27_5685", "DjiJjPUwtQQklDjKoPt4XuxaFnn2edAWNBwWbEiukYI10ZML+Q/s37rgpkpehMhy", "user_27_5685@example.com", "user_27_5685" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_2df5@example.com", "user_28_2df5@example.com", "USER_28_2DF5@EXAMPLE.COM", "USER_28_2DF5", "F4Nzn1HyIZ/1gKknHVwedXQvBJnJhFrzYXpM8PGjtAIIvk/iwHgik30Fo3o1BpU9", "user_28_2df5@example.com", "user_28_2df5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_2fde@example.com", "user_29_2fde@example.com", "USER_29_2FDE@EXAMPLE.COM", "USER_29_2FDE", "9vHFHaj46gD4TgAQ6xs5N+mefWoCH4xVUHPT8gDks3o6UuXKGrSkrkF5mMOaWIv/", "user_29_2fde@example.com", "user_29_2fde" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_697a@example.com", "user_30_697a@example.com", "USER_30_697A@EXAMPLE.COM", "USER_30_697A", "yRXdtLbjZwI4EkCeWzka/65DBmk/P3XTlpqtP70iBl61Azhu8k8TBF9VYPXxf53A", "user_30_697a@example.com", "user_30_697a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_a80a@example.com", "user_31_a80a@example.com", "USER_31_A80A@EXAMPLE.COM", "USER_31_A80A", "tsfYOfQTGLDueCSzU6mjvP0rj1XXTBBiIJ6vwn9LMXIOXrfbuS0r/Hwkc+/DTall", "user_31_a80a@example.com", "user_31_a80a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_322a@example.com", "user_32_322a@example.com", "USER_32_322A@EXAMPLE.COM", "USER_32_322A", "Wzv7GGo+u9BHqbYDP0d3w8H89jijcf9DUzuu5vNltsCDyllc0QkTpgtPJQwOUjdg", "user_32_322a@example.com", "user_32_322a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_7cba@example.com", "user_33_7cba@example.com", "USER_33_7CBA@EXAMPLE.COM", "USER_33_7CBA", "Rq0vsVVLq3FdGmhA3PVIc7HkfI7Csn9KpAiAMaEn9FPcQkiEyRnf25JAG5lNfwPG", "user_33_7cba@example.com", "user_33_7cba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_ee12@example.com", "user_34_ee12@example.com", "USER_34_EE12@EXAMPLE.COM", "USER_34_EE12", "/r13BSxFJyjF+w2nqnhajgKtseMRSSzqkYuelFVAfSMH0W58znhT3XJrqbRZRUL7", "user_34_ee12@example.com", "user_34_ee12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_1afb@example.com", "user_35_1afb@example.com", "USER_35_1AFB@EXAMPLE.COM", "USER_35_1AFB", "vmIxQph0MmYLPhazjdmEndP/2GUF6B2Th+rfFiVTF3VCGukg1X3A7GC5Z2FcdUe7", "user_35_1afb@example.com", "user_35_1afb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_d903@example.com", "user_36_d903@example.com", "USER_36_D903@EXAMPLE.COM", "USER_36_D903", "HmZdngQY0iNivqtiAckl3UBGk7WZ0XyhAc2Ee4Kek9zs7/sKMkXsOxckOzEcDTNy", "user_36_d903@example.com", "user_36_d903" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_1cd4@example.com", "user_37_1cd4@example.com", "USER_37_1CD4@EXAMPLE.COM", "USER_37_1CD4", "fo1Sy0jFnOrYyKoApFscrUqzLCVXa8PuONguQ8Ehkmv8dpmkh280NB3LzHiEtV64", "user_37_1cd4@example.com", "user_37_1cd4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_ca26@example.com", "user_38_ca26@example.com", "USER_38_CA26@EXAMPLE.COM", "USER_38_CA26", "SU0hnYZStTwAv3dzSFT34GMMnv6urguOLRFFI2W0wyZz3rWSN3xKkWW909AXOGeV", "user_38_ca26@example.com", "user_38_ca26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_d222@example.com", "user_39_d222@example.com", "USER_39_D222@EXAMPLE.COM", "USER_39_D222", "5fEUgAzXTezSrSOvSSd80LMRIDb5G2ko+2fvR09AWkRDrQmegaoXEwjAA1scPS/j", "user_39_d222@example.com", "user_39_d222" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_a76b@example.com", "user_40_a76b@example.com", "USER_40_A76B@EXAMPLE.COM", "USER_40_A76B", "xhnQ4dFyCts20atePTa1sqDghMNDRygC0KQIPCLXqY8w+yfu6t6BeOU7LP3w4fkW", "user_40_a76b@example.com", "user_40_a76b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_4855@example.com", "user_41_4855@example.com", "USER_41_4855@EXAMPLE.COM", "USER_41_4855", "gu/5O7LnZrM7F5ii762XXUHWOE2kiN1Cv4tPpU49prum7JjvgVlYJk+4/31Tah4R", "user_41_4855@example.com", "user_41_4855" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_daf5@example.com", "user_42_daf5@example.com", "USER_42_DAF5@EXAMPLE.COM", "USER_42_DAF5", "zx3iX954ajNRd6VVd9bJJtdw7g/vcU02bddwxbvyHvYUuI1YCA/qteF0hLZ922ny", "user_42_daf5@example.com", "user_42_daf5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_d096@example.com", "user_43_d096@example.com", "USER_43_D096@EXAMPLE.COM", "USER_43_D096", "6ZixlLvaVV7tRNr5PupEFwuRgNJWwOOqyOlllYhvErvgJHMtZVPle9OQFsqp/7MV", "user_43_d096@example.com", "user_43_d096" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_30f5@example.com", "user_44_30f5@example.com", "USER_44_30F5@EXAMPLE.COM", "USER_44_30F5", "7RMeI2cAyeJM4XxRJckc9H2LPtYDAZv720TlJjpHBzwB7+4JYAhdMRXm5/smzueL", "user_44_30f5@example.com", "user_44_30f5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_4771@example.com", "user_45_4771@example.com", "USER_45_4771@EXAMPLE.COM", "USER_45_4771", "R0r/pZfzw3uKA6qw+wuQrPuEDQaL+Mzuwjoig6YJjiHpowhwlehWu2lailMuSIS1", "user_45_4771@example.com", "user_45_4771" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_e224@example.com", "user_46_e224@example.com", "USER_46_E224@EXAMPLE.COM", "USER_46_E224", "deF7exCgdiRx8Xsg0RDeGRrs5SEmGAUDgp6MddzihZq9OtYL2K5JgKySU6PzzxlL", "user_46_e224@example.com", "user_46_e224" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_2156@example.com", "user_47_2156@example.com", "USER_47_2156@EXAMPLE.COM", "USER_47_2156", "Q5OK8KV1MTewBFFazJe7IVLOb5ZpY1ljZQzKgVMlFtOhc5illzvdFI6vtl3vQllW", "user_47_2156@example.com", "user_47_2156" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_a143@example.com", "user_48_a143@example.com", "USER_48_A143@EXAMPLE.COM", "USER_48_A143", "EO5LN0PHh/8/KSKNX1EgdQXDkRJs/jcWifNOzntkS2BKL2SsjPqFMDrNvC46QW6r", "user_48_a143@example.com", "user_48_a143" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_a2e9@example.com", "user_49_a2e9@example.com", "USER_49_A2E9@EXAMPLE.COM", "USER_49_A2E9", "6BTQuiEDBaP4zbV7Y3mKche4QnaZNuKJVBRpnG/iKedqXVrNSRkgkhXo/jJmXnqX", "user_49_a2e9@example.com", "user_49_a2e9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_ce97@example.com", "user_50_ce97@example.com", "USER_50_CE97@EXAMPLE.COM", "USER_50_CE97", "rymaZFm0ArXTo5kQbm2Cpnyo5ErqIcLbXDQ+peeWJ3cSaJzqfqRKGLleIkR8MRkK", "user_50_ce97@example.com", "user_50_ce97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "ydtgl2iBisMeZI8EkgWEsMP5gm8jiqp2GgQ/8An+sOcBwxI9Dc1RDQRDo+mXpmUT");
        }
    }
}
