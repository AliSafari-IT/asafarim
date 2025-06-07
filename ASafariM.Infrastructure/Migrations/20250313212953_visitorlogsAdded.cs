using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class visitorlogsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "VisitorLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IPAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VisitDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserAgent = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Referrer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Path = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsUnique = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SessionId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorLogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("14cac200-35a8-4508-9c99-3b83f8a51584"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("2226c1b1-eaf2-4fe1-818b-9b9d6d42f64d"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("24affc02-6467-4117-8fcb-772c8663e769"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("3fce737c-cc6c-4865-973b-b84aa6a2ffc8"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("56d4d203-463c-4118-87b4-bef96611e3e2"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("57d7d1b2-91c2-4a71-b447-abe761ad9602"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("6360cf47-6b3d-4909-857c-4c84ece7aefb"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("ae5b2500-f175-46ae-89fa-33624ff428c1"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("c9625c88-129d-4add-9ef3-c5fa71916909"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("f418d13c-91b3-4944-aba4-71789fa9f78a"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("05adbd79-ca57-4670-b1f4-4097e44e2c7d"), "USD", new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(1745), 2, true, "US Dollar", "$", null },
                    { new Guid("2a1bad9b-37a7-4636-bc22-3c49909f502e"), "EUR", new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(863), 2, true, "Euro", "€", null },
                    { new Guid("c72b6a81-5fdc-4e1d-9e84-1243beae6a7f"), "CHF", new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(1752), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("e0228447-83ae-4401-8d40-6650fb313e4c"), "GBP", new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(1750), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("099ed36c-374c-453a-bdb9-e4d24757c001"), new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(138), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("42c9d93e-e77d-4b86-8300-57f82ec25f21"), new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(134), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("a59fecc4-d2ad-4c5b-9200-ee13679f82eb"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(9136), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("e68efa96-0d18-456b-80b6-2a34a4724b81"), new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(141), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ef27efd-fdbe-4044-b663-afe8dd2c694b"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(6201), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("31f54852-828e-499b-b2ba-f0cd46eb4b80"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(6196), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("8fd817f1-c1ce-4a85-ab5f-f95d7f30ee87"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(6198), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("9d8a275a-da27-46a1-8c71-ed6e5ced45a1"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(6188), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("a63f9e0b-a700-4181-94bc-1a5a0b7db87d"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(6203), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("e91d2b1d-ada0-4183-833a-017c87609671"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(5118), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("94ca0401-5ef4-42f9-842e-22f45f345acf"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(7136), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("064d0c37-b74b-4da5-9d37-94228b0ac0ff"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(4079), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("09b85713-39c9-4e14-b808-2a04790091bf"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(4141), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("54d2e64c-69df-4ebc-b9ff-02ee717503ab"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(4073), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("61951454-bc35-4258-8ccd-ae1fbc7b86f2"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(4143), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("b33c1c73-8f9e-4b9f-80fc-c383d3deb054"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(4076), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("db9d4744-a57e-4417-8db3-24bbb3d28fed"), new DateTime(2025, 3, 13, 21, 29, 47, 526, DateTimeKind.Utc).AddTicks(3270), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3f224bf0-934c-4bf3-9e50-bbd9c02438a7"), null, new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(8143), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("c0191c90-75b6-468f-89d9-a54493a59510"), null, new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(8145), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("f42a31d9-fb90-4b88-81de-0826fa711d69"), null, new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(8135), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("fdd3d14f-7492-4bd5-9a20-bce4e6e7cb47"), null, new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(7443), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("0d22fc87-8e0c-4fb0-a578-99b701d6a64c"), new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(3813), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("2039c46e-33b8-4ff7-829d-c6d68341047a"), new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(2596), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("27331e4f-da42-46b9-bd11-6994c8e50a39"), new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(3822), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("3a3518cb-cc9e-4d13-a237-902b2ef33e0a"), new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(3820), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("866f3732-d04a-41a3-8589-818a050cd693"), new DateTime(2025, 3, 13, 21, 29, 47, 527, DateTimeKind.Utc).AddTicks(3829), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 13, 21, 29, 47, 528, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1b7cde9b-14a5-4425-abb4-e4ac5833555e"), new DateTime(2025, 3, 13, 21, 29, 47, 528, DateTimeKind.Utc).AddTicks(1256), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("980cb001-8867-43fe-8400-596ffd30f4f4"), new DateTime(2025, 3, 13, 21, 29, 47, 528, DateTimeKind.Utc).AddTicks(1268), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("d07c3776-e3b6-435d-aace-761c6226f2a2"), new DateTime(2025, 3, 13, 21, 29, 47, 528, DateTimeKind.Utc).AddTicks(1261), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "TLOPT2/tEEgbWHdOlbm0FQ5Fh+v88gchn5bRVkzJbU8F8+TR5ugX2pmHU2O76Rb8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "N9/BU8FeRW/wLIUs6gpeRQXrVVrwzUoxF+I+iZU8SnjUFrp0ixphdLXnyXTyXQIB");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_0123@example.com", "user_1_0123@example.com", "USER_1_0123@EXAMPLE.COM", "USER_1_0123", "v3so7EOUPZF4pU6b/9ZysatixY+nCJmBQ/lDnghMyAzIyPG6MFd8VyFB+Gef+R5s", "user_1_0123@example.com", "user_1_0123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_63ed@example.com", "user_2_63ed@example.com", "USER_2_63ED@EXAMPLE.COM", "USER_2_63ED", "t1tsu8tVOrR/xMP80Wl/xmEXsl7e+MlWg7gtlMAuQryI9OLEtq6DzETgoJtfz4M/", "user_2_63ed@example.com", "user_2_63ed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_1eff@example.com", "user_3_1eff@example.com", "USER_3_1EFF@EXAMPLE.COM", "USER_3_1EFF", "i8NWrIFZ+hgGiMU7voUidl75lpOO2z6+KkklGHLO1Js8qMbnCAMq6m+rm//P3To1", "user_3_1eff@example.com", "user_3_1eff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_9124@example.com", "user_4_9124@example.com", "USER_4_9124@EXAMPLE.COM", "USER_4_9124", "S7bP0CshkVSN4wUPUtVIXzID9b9eRKSpfnxQ6OX0BXH9rbTtBspe3BPG21zqLilh", "user_4_9124@example.com", "user_4_9124" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_ff48@example.com", "user_5_ff48@example.com", "USER_5_FF48@EXAMPLE.COM", "USER_5_FF48", "IpNA2IavuHoyJcGBeQRrROklpchpEegIlI9H2DhFVKe4aOsN0RXBqjktGRE/Ahhm", "user_5_ff48@example.com", "user_5_ff48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_f526@example.com", "user_6_f526@example.com", "USER_6_F526@EXAMPLE.COM", "USER_6_F526", "6NkRjJ34LN/4xkyhqK7y8K4g8NuBoKyMTT2nnxCM8lMphDa6o4ZQfl48SkL+4Yg3", "user_6_f526@example.com", "user_6_f526" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_c7d9@example.com", "user_7_c7d9@example.com", "USER_7_C7D9@EXAMPLE.COM", "USER_7_C7D9", "ljfd1BZUr0Ox8ryVx0U7U/KS6OnA4SkXKPkfN++9GnrbDz93Yv6QayGR2IuGzkMc", "user_7_c7d9@example.com", "user_7_c7d9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_9184@example.com", "user_8_9184@example.com", "USER_8_9184@EXAMPLE.COM", "USER_8_9184", "A+dO3V7uq7KQ3a84JLLwlwIR1opqIHdgn4A0I1poAYTGyDyv4AebcrseVwt67NDv", "user_8_9184@example.com", "user_8_9184" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_808c@example.com", "user_9_808c@example.com", "USER_9_808C@EXAMPLE.COM", "USER_9_808C", "wdtKT+9+HUz1LiIQU0e8QWN3mu7bGhYOI+ZQLIYCLBDvacUKLCY0eI2ywMdXgMDT", "user_9_808c@example.com", "user_9_808c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_9622@example.com", "user_10_9622@example.com", "USER_10_9622@EXAMPLE.COM", "USER_10_9622", "ehiHObHvY/dXgaWYZSNNDr26zKdiQ92k8bKm0VbNHZpzb7xxE9fpy0Y1VquwYCwi", "user_10_9622@example.com", "user_10_9622" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_0698@example.com", "user_11_0698@example.com", "USER_11_0698@EXAMPLE.COM", "USER_11_0698", "zwV0Q7/9ikATRH+3CTgGvQB3QeWISKuH0S+Opzz8NNgaNL41yKG/YVplsLh+56l9", "user_11_0698@example.com", "user_11_0698" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_296c@example.com", "user_12_296c@example.com", "USER_12_296C@EXAMPLE.COM", "USER_12_296C", "ct5u55MUgw8WVvujMGxfECRKmt6JDKisOP20AeK46cp34N/Pfev7G1eG0OU7KAMi", "user_12_296c@example.com", "user_12_296c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_f9fb@example.com", "user_13_f9fb@example.com", "USER_13_F9FB@EXAMPLE.COM", "USER_13_F9FB", "NYNwELuPAJwQmCvO1w3JFGnSBaPN9xfHqlFx8dvQgvHS2qJ+Uf1fjE6KO8dgjqND", "user_13_f9fb@example.com", "user_13_f9fb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_e418@example.com", "user_14_e418@example.com", "USER_14_E418@EXAMPLE.COM", "USER_14_E418", "BKmBA2vQQduGBMa1saxeeTi1GlI/AILYhi40i3t3LfJeR1MX72hRYAaedGAaLZ5y", "user_14_e418@example.com", "user_14_e418" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_a52f@example.com", "user_15_a52f@example.com", "USER_15_A52F@EXAMPLE.COM", "USER_15_A52F", "u2XZ4FgevC3uD+jLd8BqZ+/w4iT3OtED1jDvhY1Qd0r2ORQzD98TO/6UKc5EUvxs", "user_15_a52f@example.com", "user_15_a52f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_8a7d@example.com", "user_16_8a7d@example.com", "USER_16_8A7D@EXAMPLE.COM", "USER_16_8A7D", "PHBRpOCuHv8anskDvpWMwY2f8zyD61PlxqksK5Znx4o8fQynfsNkhS0vosa9UAI9", "user_16_8a7d@example.com", "user_16_8a7d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_026f@example.com", "user_17_026f@example.com", "USER_17_026F@EXAMPLE.COM", "USER_17_026F", "JpyajlZf1trKld8qXw2y1F4qfME2Elx3YQa8CTtLv68aiBeAFlHyoe6M45CpN/S6", "user_17_026f@example.com", "user_17_026f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_fd9c@example.com", "user_18_fd9c@example.com", "USER_18_FD9C@EXAMPLE.COM", "USER_18_FD9C", "4AbtG7jlTnWB1byMkDtuUJEdhhfsSFsAO+DngKakx+BIzsvsYOH9iS4AOxisNEhR", "user_18_fd9c@example.com", "user_18_fd9c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_acb8@example.com", "user_19_acb8@example.com", "USER_19_ACB8@EXAMPLE.COM", "USER_19_ACB8", "tp1n2tgKl6wqhe96RUqrCvn2KBnE2lco4aa/DF8l1CUXo5oM3Bn+6kxBMpls6fPE", "user_19_acb8@example.com", "user_19_acb8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_a2c1@example.com", "user_20_a2c1@example.com", "USER_20_A2C1@EXAMPLE.COM", "USER_20_A2C1", "LgGhSLpBenbNOqT19mjqilc9voogZSuQU1TyP3rIwWM3yv8sRujEs91Ip1bMHKlA", "user_20_a2c1@example.com", "user_20_a2c1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_f856@example.com", "user_21_f856@example.com", "USER_21_F856@EXAMPLE.COM", "USER_21_F856", "EQY/iCqAJ0LCE7pWOH0UGxq0iBrShWFiYdMFlMul2E3ZSM6v0NgkvMAzvq/Fg/fu", "user_21_f856@example.com", "user_21_f856" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_a61a@example.com", "user_22_a61a@example.com", "USER_22_A61A@EXAMPLE.COM", "USER_22_A61A", "joBDC7wwgnMFpvfenoCZvqaR2tBHiWkuXL1WeYGXfPzmgfHf3blMrcaBclCQ6nDA", "user_22_a61a@example.com", "user_22_a61a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_8de4@example.com", "user_23_8de4@example.com", "USER_23_8DE4@EXAMPLE.COM", "USER_23_8DE4", "vFJwbYXIOAuCm0Tk+eTz3Y/a0tsdYG4SNwTZkfpBK0J0ncH8xdDbjBP+47wYm99c", "user_23_8de4@example.com", "user_23_8de4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_76cc@example.com", "user_24_76cc@example.com", "USER_24_76CC@EXAMPLE.COM", "USER_24_76CC", "0jPBWYPCsOiVyFnE9DhW1MEFWvRLqyfUonmZVTeHdY7HuA8gYg0e45PILNgPuCLK", "user_24_76cc@example.com", "user_24_76cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_830b@example.com", "user_25_830b@example.com", "USER_25_830B@EXAMPLE.COM", "USER_25_830B", "ktW/6+x/1E1llyrUaTwYpnn/ZvgIfYicruC/Zb4os3Mr1hsaqwI1+2AN5ldpABQt", "user_25_830b@example.com", "user_25_830b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_55d4@example.com", "user_26_55d4@example.com", "USER_26_55D4@EXAMPLE.COM", "USER_26_55D4", "GqFP42J2PFzYsJ5ieOsMI/tnPmaKWg/qoFvh/SyYc0vna9ZdwSpMBH3HcuVhVlxn", "user_26_55d4@example.com", "user_26_55d4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_d9b6@example.com", "user_27_d9b6@example.com", "USER_27_D9B6@EXAMPLE.COM", "USER_27_D9B6", "wyVk6cWxeRXjXvhYED6NMC0klW5e2PuEuqBe654r94bJN2ytwtoGBfrbYwRg6nfT", "user_27_d9b6@example.com", "user_27_d9b6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_a2fc@example.com", "user_28_a2fc@example.com", "USER_28_A2FC@EXAMPLE.COM", "USER_28_A2FC", "8BXpbXAVZ9iC1ZP2D99NMDymYmp2tFiY5l/+OB5JzqIz6rI/pUhZeN4nVCLQe40l", "user_28_a2fc@example.com", "user_28_a2fc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_c4fc@example.com", "user_29_c4fc@example.com", "USER_29_C4FC@EXAMPLE.COM", "USER_29_C4FC", "Xiry4OyeEV+w3kSC0TmcHNtB1PB12DgQih1/bBXDstfLpbK68Oo8XRKqXpNTTEXo", "user_29_c4fc@example.com", "user_29_c4fc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_5e1b@example.com", "user_30_5e1b@example.com", "USER_30_5E1B@EXAMPLE.COM", "USER_30_5E1B", "vOFEQsA+vbqTKR0WGCTy0MrCiAn66KV0lqUCMD2gMPDbSG8b2uLZaxDcoiVKMZ+f", "user_30_5e1b@example.com", "user_30_5e1b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_cc28@example.com", "user_31_cc28@example.com", "USER_31_CC28@EXAMPLE.COM", "USER_31_CC28", "WvBQ0jDscxaH7GbWLhu5zxZvO8pxh8whsvq1Wkfk1/H3e6QpjQ35a0rXwt611/V4", "user_31_cc28@example.com", "user_31_cc28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_52d4@example.com", "user_32_52d4@example.com", "USER_32_52D4@EXAMPLE.COM", "USER_32_52D4", "AmNMM85AebM5YU8/KkRdyYuT2zN6CbKkbEeO9/J59GWesnxDmRhoxXb4hCbslIWi", "user_32_52d4@example.com", "user_32_52d4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_bc39@example.com", "user_33_bc39@example.com", "USER_33_BC39@EXAMPLE.COM", "USER_33_BC39", "LYjGwGnBbcUENYvdKv5GidphkPSnBZMII4ej6JOkXguMOnL3xqvDSsoDu4IxL1li", "user_33_bc39@example.com", "user_33_bc39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_0042@example.com", "user_34_0042@example.com", "USER_34_0042@EXAMPLE.COM", "USER_34_0042", "/lFsFeGAWVnTqMcCXXyLLa/Obnp1MjFCTY9aDCad88E6uu4swhhFCcX0SgEGR1u9", "user_34_0042@example.com", "user_34_0042" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_85bb@example.com", "user_35_85bb@example.com", "USER_35_85BB@EXAMPLE.COM", "USER_35_85BB", "EeOZzm2qxpr76GOvVznXDXfi7PGD1x3PMo2WPRrJUtN5oepj//6P5OkMqut14z6m", "user_35_85bb@example.com", "user_35_85bb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_6c7f@example.com", "user_36_6c7f@example.com", "USER_36_6C7F@EXAMPLE.COM", "USER_36_6C7F", "xBjyEPQ0lo3qsJXX4DCm4mq/G0qume2Q35wfrRUqJh6nDyfF/7sKBd5ZV0aBg6z0", "user_36_6c7f@example.com", "user_36_6c7f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_1851@example.com", "user_37_1851@example.com", "USER_37_1851@EXAMPLE.COM", "USER_37_1851", "lsA2WAk8pxR0vSHjRKciso/LEsYGmlo2GC/WV9qGs6xpLNJIhjFA5ZC+T/zMDvLp", "user_37_1851@example.com", "user_37_1851" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_f47e@example.com", "user_38_f47e@example.com", "USER_38_F47E@EXAMPLE.COM", "USER_38_F47E", "w6IsanUKdNYmZ5HZUUs8KUs/tHufRSjoeZcC5WsLKvSzm5/LC+kAIO6s8LY50NqW", "user_38_f47e@example.com", "user_38_f47e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_afb4@example.com", "user_39_afb4@example.com", "USER_39_AFB4@EXAMPLE.COM", "USER_39_AFB4", "XhrkWH7jzAS7VCgaGqQEDTdZhbmldPQ2QarUBNnSVSFBo+mHb6gwBwlQdncMEIXR", "user_39_afb4@example.com", "user_39_afb4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_2855@example.com", "user_40_2855@example.com", "USER_40_2855@EXAMPLE.COM", "USER_40_2855", "yaq4C1ywuiY7MyIW/oyo7icmXk8NsxhOEerRMbrk9kIcSu4qtmgumoJU2XPsu1j9", "user_40_2855@example.com", "user_40_2855" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_c21a@example.com", "user_41_c21a@example.com", "USER_41_C21A@EXAMPLE.COM", "USER_41_C21A", "u8MC0iY8lpviuK9bzOn+j8pDIPcaZ/RlsDgucpNHa3V3q9LDPceiYxbitVlGevvt", "user_41_c21a@example.com", "user_41_c21a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_143f@example.com", "user_42_143f@example.com", "USER_42_143F@EXAMPLE.COM", "USER_42_143F", "Hhz3mACB7FM+95PDFWkoIPZ03dqhmWYGDNkRnYMIQGBu10MbjO0XCVYSii6Pn52W", "user_42_143f@example.com", "user_42_143f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_55f6@example.com", "user_43_55f6@example.com", "USER_43_55F6@EXAMPLE.COM", "USER_43_55F6", "P12qpCXHdCOw3Lhud9IOv9wW663PhbiOl0ByzFbjZNEbZjTD8DWGb+EBbkH6GKNI", "user_43_55f6@example.com", "user_43_55f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_791b@example.com", "user_44_791b@example.com", "USER_44_791B@EXAMPLE.COM", "USER_44_791B", "8P1W1dNa+Ax6DBwOa7UQOWFOme6IqzgiJ176Yun9SWLogM3yOfbjma8lx/vNRbkE", "user_44_791b@example.com", "user_44_791b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_8816@example.com", "user_45_8816@example.com", "USER_45_8816@EXAMPLE.COM", "USER_45_8816", "B2857LaaPMEJGApBl0VXcvi47cFglVd8yQl/UJuL4ad4E/jqxMksFGbW1aaGojXJ", "user_45_8816@example.com", "user_45_8816" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_3e26@example.com", "user_46_3e26@example.com", "USER_46_3E26@EXAMPLE.COM", "USER_46_3E26", "8oA5ppxM8DieKvAVeHmX9oxErHHIq9YZv6Y3RSVhlQkjy2UmWUNJJesFmzMvlTtT", "user_46_3e26@example.com", "user_46_3e26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_2433@example.com", "user_47_2433@example.com", "USER_47_2433@EXAMPLE.COM", "USER_47_2433", "XP5Ws2H13sK25F07DZBewLTn+u12XJyJVGHey+v4CsrMFHyyEjx2L/pYPhDn0hus", "user_47_2433@example.com", "user_47_2433" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_7f54@example.com", "user_48_7f54@example.com", "USER_48_7F54@EXAMPLE.COM", "USER_48_7F54", "1gYq+MQTetU2diGnw9xu/yCtnH66ROphQQ9Q3y6xPoMJKHnD/0a4D4tBmK30UpLC", "user_48_7f54@example.com", "user_48_7f54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_d7e3@example.com", "user_49_d7e3@example.com", "USER_49_D7E3@EXAMPLE.COM", "USER_49_D7E3", "1Eq/pAI636DiQ6P/1Qxqz8JuKnQFbduqZiDv2CJdB/6nRGBw0ai6l1KsQLIayS82", "user_49_d7e3@example.com", "user_49_d7e3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_d1dd@example.com", "user_50_d1dd@example.com", "USER_50_D1DD@EXAMPLE.COM", "USER_50_D1DD", "izZxtxbMJslA5bkduDlQpO/rLcmKud8qRyfirliDMiFavN6dRjP6vbZCjvIJ7Tit", "user_50_d1dd@example.com", "user_50_d1dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "2ouKwvSi01ZRN7tnLmHuC5wyHdKDCLRcnVU2ebjqZ6htvYEihjjkcKrh5WiN0/tz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitorLogs");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("14cac200-35a8-4508-9c99-3b83f8a51584"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2226c1b1-eaf2-4fe1-818b-9b9d6d42f64d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24affc02-6467-4117-8fcb-772c8663e769"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3fce737c-cc6c-4865-973b-b84aa6a2ffc8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56d4d203-463c-4118-87b4-bef96611e3e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("57d7d1b2-91c2-4a71-b447-abe761ad9602"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6360cf47-6b3d-4909-857c-4c84ece7aefb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae5b2500-f175-46ae-89fa-33624ff428c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9625c88-129d-4add-9ef3-c5fa71916909"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f418d13c-91b3-4944-aba4-71789fa9f78a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("05adbd79-ca57-4670-b1f4-4097e44e2c7d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("2a1bad9b-37a7-4636-bc22-3c49909f502e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c72b6a81-5fdc-4e1d-9e84-1243beae6a7f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e0228447-83ae-4401-8d40-6650fb313e4c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("099ed36c-374c-453a-bdb9-e4d24757c001"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("42c9d93e-e77d-4b86-8300-57f82ec25f21"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("a59fecc4-d2ad-4c5b-9200-ee13679f82eb"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("e68efa96-0d18-456b-80b6-2a34a4724b81"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0ef27efd-fdbe-4044-b663-afe8dd2c694b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("31f54852-828e-499b-b2ba-f0cd46eb4b80"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("8fd817f1-c1ce-4a85-ab5f-f95d7f30ee87"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9d8a275a-da27-46a1-8c71-ed6e5ced45a1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a63f9e0b-a700-4181-94bc-1a5a0b7db87d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e91d2b1d-ada0-4183-833a-017c87609671"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("94ca0401-5ef4-42f9-842e-22f45f345acf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("064d0c37-b74b-4da5-9d37-94228b0ac0ff"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09b85713-39c9-4e14-b808-2a04790091bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54d2e64c-69df-4ebc-b9ff-02ee717503ab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("61951454-bc35-4258-8ccd-ae1fbc7b86f2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b33c1c73-8f9e-4b9f-80fc-c383d3deb054"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("db9d4744-a57e-4417-8db3-24bbb3d28fed"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3f224bf0-934c-4bf3-9e50-bbd9c02438a7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c0191c90-75b6-468f-89d9-a54493a59510"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f42a31d9-fb90-4b88-81de-0826fa711d69"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fdd3d14f-7492-4bd5-9a20-bce4e6e7cb47"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("0d22fc87-8e0c-4fb0-a578-99b701d6a64c"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("2039c46e-33b8-4ff7-829d-c6d68341047a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("27331e4f-da42-46b9-bd11-6994c8e50a39"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3a3518cb-cc9e-4d13-a237-902b2ef33e0a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("866f3732-d04a-41a3-8589-818a050cd693"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1b7cde9b-14a5-4425-abb4-e4ac5833555e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("980cb001-8867-43fe-8400-596ffd30f4f4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d07c3776-e3b6-435d-aace-761c6226f2a2"));

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
        }
    }
}
