using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BibliographyItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("031c1f64-7f45-4c21-a34c-f030fe9f3c2e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03474e38-8728-4f82-833c-7ce6ff178b68"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1898bf28-f229-41d7-abc1-3bdbe79be147"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("472da88f-ede0-404f-8ccf-5eb42a74cf65"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7c0804ea-70f3-43ca-8a27-b807b8d2a649"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f522f71-cb71-4f02-8fe2-a6201caed6d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("acaebef8-96ac-47df-850a-3c7040f4264c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bef0cd91-8ff4-4075-bd62-20144192b8f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d1477d-0831-4246-8de5-22c31198e7d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3d4ac90-7cf3-4877-8ff2-83aafd003118"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("010d6d03-cb7b-4247-bdf2-e03313519348"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6b3b6dc2-0ecb-4693-b3c5-6b6b4aaff3b6"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("7ca5880b-7431-4e80-991b-b3849291d8bc"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c62e64f2-60ed-4b5f-8d10-bf9802303f16"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("259502f3-26ba-4243-a515-86721a8588cf"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("996a157a-976f-408b-9ccf-7e12bdb85842"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("9ff7cab2-5295-457f-9d63-220894d4080c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("f937b5ed-18b6-4178-bc3a-250a602a1d14"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("06922cfa-6028-40e3-9e87-81f4fc1cc973"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("423efa55-3ed8-48f8-a7d4-7615cb4fb6dc"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6a897abb-dc36-47aa-be89-9b07580e48e0"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("70ac574e-128d-4c92-b27c-6fa9bf691dd5"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("73762a70-3c1f-4429-9cbd-b060cf728cbe"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ab99ec60-0a9a-494a-8374-814cbeee00e3"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("940dfd58-2978-41c3-ae37-cd2c4cc6b663"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4e5204a0-2c04-49d6-8421-fc5cb80a8132"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("548ee064-91f0-4dda-903f-35f96223def2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5eb381e5-fe51-4cf5-ac88-cd709c501eca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a27e164f-b4cf-43ba-8585-2b7087c2d444"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("de27bb02-b815-43fc-a63f-d5c80d5003a2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fc78ed11-4747-4781-bf60-27aa23e59189"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("060f9e2b-32e1-42fc-915d-d5a59b522bfa"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6849dce3-bca7-4792-b9eb-2c2e1baada99"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c3f650d-2ef1-4add-a598-5b2ee53ea53b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b1e5c608-a6cc-469b-93a4-96935026a792"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("1bdf4e21-72d2-4c71-b7f9-61e818cb4291"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("4c561244-ee15-468f-a055-39f9dc1f8d44"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("99ef6acf-2793-4a6b-b8ec-44d35ae22a96"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c9ac0ae6-34fb-4a6d-8071-d8e7c0c69962"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ee02a935-f89b-4441-b8da-e6ebf5bec34b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5a5f5edf-c01f-4773-a560-b433fcff49bc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("980a2257-c668-468f-a986-1341ca929f2d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9d542454-6692-40bf-ac29-dd96762d7ffc"));

            migrationBuilder.CreateTable(
                name: "BibliographyItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Author = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsRead = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
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
                    table.PrimaryKey("PK_BibliographyItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BibliographyItems_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("35944d40-feb8-4fd8-b673-70346b321a25"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("5c8f343f-5914-4c64-a428-47970298ef7a"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("6bcca60b-1424-4be6-baf9-421d6b5ac415"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("76bc22ef-3379-4436-b671-043d3f6c4f9b"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("79adc72c-f1f5-4550-b48e-4465aeb4fdcb"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("7c19952b-71f7-4bd3-8405-3a5bee85d7a1"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("891baeb1-1fcb-4dcf-b21a-97387ba4f0b0"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("a0ad9da0-60a5-4574-8f7b-a25ffab4937c"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("d3546e39-8721-4976-bc90-35cffb988e81"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("e290474b-b9e8-4f0c-8f9c-96ffbdfb89a9"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1952c020-3ab9-4796-a7cd-46b472a3074f"), "GBP", new DateTime(2025, 3, 23, 1, 13, 57, 678, DateTimeKind.Utc).AddTicks(1288), 2, true, "British Pound", "£", null },
                    { new Guid("27255123-5644-494b-922f-9efa44b10a40"), "EUR", new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(9788), 2, true, "Euro", "€", null },
                    { new Guid("82cdec4c-c5d1-44ce-a7f5-51be054f8475"), "USD", new DateTime(2025, 3, 23, 1, 13, 57, 678, DateTimeKind.Utc).AddTicks(1279), 2, true, "US Dollar", "$", null },
                    { new Guid("e92a3e69-2cea-417e-8bd4-9254d0205416"), "CHF", new DateTime(2025, 3, 23, 1, 13, 57, 678, DateTimeKind.Utc).AddTicks(1292), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("37632803-2a2e-44fc-b6cd-a1b2c64dfec7"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(8526), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("df6aa845-828e-43fe-904f-cef89c73a164"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(6846), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("eea07e5c-3e16-4f3b-862e-d21bb48ce96c"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(8509), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("fb181e0e-3ac6-4ab8-b39e-c7c4032709b4"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(8530), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("36be0c4b-9608-4aad-8543-68fe334982ad"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(71), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("3f287a47-88b9-455a-8fa9-6ba6c97eee18"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(33), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("4a419f2b-9800-44ef-8b99-58cf0f145896"), new DateTime(2025, 3, 23, 1, 13, 57, 676, DateTimeKind.Utc).AddTicks(7017), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("72fae67d-1702-4e1d-8ba5-78b488d11f39"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(49), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("dff69e38-ab61-4de0-ab01-76963124e5cf"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(55), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("e6d41327-300d-4123-9ca4-608a44e63f9d"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(42), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("9edaa34d-fa82-4e71-8071-36cb10c785d6"), new DateTime(2025, 3, 23, 1, 13, 57, 677, DateTimeKind.Utc).AddTicks(2294), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0e0c0f46-841e-477d-85f4-264ea4ae71e6"), new DateTime(2025, 3, 23, 1, 13, 57, 676, DateTimeKind.Utc).AddTicks(3871), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("42b98c09-bfd3-46e6-a8b6-b08344b78bc6"), new DateTime(2025, 3, 23, 1, 13, 57, 676, DateTimeKind.Utc).AddTicks(3904), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("52122f0f-91b8-48bd-b114-31df8e171ccd"), new DateTime(2025, 3, 23, 1, 13, 57, 676, DateTimeKind.Utc).AddTicks(3908), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("a8977581-3261-4902-9a2d-29f01cc55c78"), new DateTime(2025, 3, 23, 1, 13, 57, 676, DateTimeKind.Utc).AddTicks(1779), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("c925054c-66ed-430a-bc24-22710800b8c8"), new DateTime(2025, 3, 23, 1, 13, 57, 676, DateTimeKind.Utc).AddTicks(3878), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("e1af8e8d-fd6c-4aa0-bb6e-5b893f0fb5cc"), new DateTime(2025, 3, 23, 1, 13, 57, 676, DateTimeKind.Utc).AddTicks(3900), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1677ee84-7d66-49cb-a3da-348596683b39"), null, new DateTime(2025, 3, 23, 1, 13, 57, 679, DateTimeKind.Utc).AddTicks(8063), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("54553c22-b421-4036-82fb-8311511d6fc5"), null, new DateTime(2025, 3, 23, 1, 13, 57, 679, DateTimeKind.Utc).AddTicks(8056), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("722cb86d-7297-4c57-b687-f51a2a474281"), null, new DateTime(2025, 3, 23, 1, 13, 57, 679, DateTimeKind.Utc).AddTicks(8048), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("7c518be1-4544-4455-8d97-deacf81d066f"), null, new DateTime(2025, 3, 23, 1, 13, 57, 679, DateTimeKind.Utc).AddTicks(6132), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("299446a2-0a25-4ad0-b0fa-dd2e16677fc8"), new DateTime(2025, 3, 23, 1, 13, 57, 678, DateTimeKind.Utc).AddTicks(5492), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("6caddd46-2da8-4947-85d0-da131f96c474"), new DateTime(2025, 3, 23, 1, 13, 57, 678, DateTimeKind.Utc).AddTicks(2551), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("9908d0f6-f9dd-4d0a-aa5d-a0664936ff45"), new DateTime(2025, 3, 23, 1, 13, 57, 678, DateTimeKind.Utc).AddTicks(5468), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("ae95545d-0739-40d2-93b2-b32c0129e586"), new DateTime(2025, 3, 23, 1, 13, 57, 678, DateTimeKind.Utc).AddTicks(5488), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("eec4a504-bf48-4cbc-a952-9dc7227e87df"), new DateTime(2025, 3, 23, 1, 13, 57, 678, DateTimeKind.Utc).AddTicks(5483), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 1, 13, 57, 680, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("79105d96-6927-4f95-9ae7-dde544f173a8"), new DateTime(2025, 3, 23, 1, 13, 57, 680, DateTimeKind.Utc).AddTicks(8218), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("847ff9a5-daa5-44c2-8f97-0f545567c614"), new DateTime(2025, 3, 23, 1, 13, 57, 680, DateTimeKind.Utc).AddTicks(8210), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("fd31f39d-cbfe-492b-a491-78b2223f9769"), new DateTime(2025, 3, 23, 1, 13, 57, 680, DateTimeKind.Utc).AddTicks(8195), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "+yAem5X+eV8X3hi2wmRwh1t7ngcZRgUSGcTt1WaZmtvzRPXREHO6L+HwSlpSnQzV");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "WjTyAKhY4cjBJDzkO+cI9WKDmV6XOf8r1+pwed3Dcp1/X0o1vF5Snv5KYN4INqj9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_b2d5@example.com", "user_1_b2d5@example.com", "USER_1_B2D5@EXAMPLE.COM", "USER_1_B2D5", "gcd8qBfP2y3rRWX1mM12hKHAUD07V6X7s5MfhYQ8Kz2QSNtd6BscHU8IDDr7FjSg", "user_1_b2d5@example.com", "user_1_b2d5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_d3de@example.com", "user_2_d3de@example.com", "USER_2_D3DE@EXAMPLE.COM", "USER_2_D3DE", "eeG+P6cgO83HYYwrJQOJzOfbg6NzSI+tjFhIZ4hfMjcXcuXa3vmvRgo5WTqLTP1Q", "user_2_d3de@example.com", "user_2_d3de" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_b989@example.com", "user_3_b989@example.com", "USER_3_B989@EXAMPLE.COM", "USER_3_B989", "in62FPfW9jDSIEDsEkOnH1yvWPmrglt2p01qZGJfjiOiG7V4Rz9Y9RpFN+fIGOV0", "user_3_b989@example.com", "user_3_b989" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_228f@example.com", "user_4_228f@example.com", "USER_4_228F@EXAMPLE.COM", "USER_4_228F", "IBY97V2KgWk8t8y3Ixp7OW2ZXuZ7sTB7hlqo6nUxIlmRVXjEvMx/MS0yVSnNXjoi", "user_4_228f@example.com", "user_4_228f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_9d9c@example.com", "user_5_9d9c@example.com", "USER_5_9D9C@EXAMPLE.COM", "USER_5_9D9C", "qBwU7FY0Yh4qEEaJM1lfM27jRi0Q6cORjis00bktCzA2lB1Q7jQdshBrtraaG86/", "user_5_9d9c@example.com", "user_5_9d9c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_0dd4@example.com", "user_6_0dd4@example.com", "USER_6_0DD4@EXAMPLE.COM", "USER_6_0DD4", "A59kPI4GOZhkEuB7ZwGhKGO69lYiIHm2I5GK/QO2rURcKC9KcgHHuKhlMai7zqh4", "user_6_0dd4@example.com", "user_6_0dd4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_6511@example.com", "user_7_6511@example.com", "USER_7_6511@EXAMPLE.COM", "USER_7_6511", "8xkf1uxP6D78kqgZ/C6bHddHXSzpxMcKqp1tp1+jrqxcHog6z021uqcdLAP8sy1q", "user_7_6511@example.com", "user_7_6511" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_3962@example.com", "user_8_3962@example.com", "USER_8_3962@EXAMPLE.COM", "USER_8_3962", "x4Y5PflRhoWLuviiDAMqMYTD2zq7Zg03V8wbTu2x0INj3VBMf8dK/ScNYZhohQw4", "user_8_3962@example.com", "user_8_3962" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_b3cd@example.com", "user_9_b3cd@example.com", "USER_9_B3CD@EXAMPLE.COM", "USER_9_B3CD", "6I20PfS+/KoiQ9oHYFEpdAcI0iNWpCb9GQnw9EuSV3cOdYEhImKcExO1+cTpKU0v", "user_9_b3cd@example.com", "user_9_b3cd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_1e85@example.com", "user_10_1e85@example.com", "USER_10_1E85@EXAMPLE.COM", "USER_10_1E85", "xU19xPq3arsiP6JFyvSQLOIDLz9AgU4FvoD0a3XG/4TxliQHBTUb0YqFadyR8TnM", "user_10_1e85@example.com", "user_10_1e85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_d206@example.com", "user_11_d206@example.com", "USER_11_D206@EXAMPLE.COM", "USER_11_D206", "GEph0heVWSdnYa7j4wWsRmCmKK6nqVvXzLoiPYYrS+bvbtOerTsrrcBXSxfyXnNq", "user_11_d206@example.com", "user_11_d206" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_cce9@example.com", "user_12_cce9@example.com", "USER_12_CCE9@EXAMPLE.COM", "USER_12_CCE9", "tbuaXTK7VmTeoBUSBsSPRmYPLaH8UT84wW22BaGfETKwxpSG0o63zN5MOqkkAewM", "user_12_cce9@example.com", "user_12_cce9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_3e79@example.com", "user_13_3e79@example.com", "USER_13_3E79@EXAMPLE.COM", "USER_13_3E79", "LzlEGg/Fjlwb828ldtW+4Z9eD1aPMpa+d9bOJcksoUTNHJv44jb7W9rVhgyS8TPv", "user_13_3e79@example.com", "user_13_3e79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_43a2@example.com", "user_14_43a2@example.com", "USER_14_43A2@EXAMPLE.COM", "USER_14_43A2", "NoFg7ITR1BzDpTdohMpo19OyLEzMjAeCMrJk0THYEclrmOrx+1lVkUrhqbylyXhz", "user_14_43a2@example.com", "user_14_43a2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_7865@example.com", "user_15_7865@example.com", "USER_15_7865@EXAMPLE.COM", "USER_15_7865", "n9SwwHSNcD9eC9nviKPBqpor4P3o9Phb3it2rswSFidAk7ldvoQeVJYbQS9nm6pd", "user_15_7865@example.com", "user_15_7865" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_2554@example.com", "user_16_2554@example.com", "USER_16_2554@EXAMPLE.COM", "USER_16_2554", "ewXq7Rb971uh/jUl1J4wenZHDFce05m9YMqRV/tOci4LvH/vnHgruAdgoF8znD1U", "user_16_2554@example.com", "user_16_2554" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_16f5@example.com", "user_17_16f5@example.com", "USER_17_16F5@EXAMPLE.COM", "USER_17_16F5", "0ToAwVhie8Me81Cqj6q8TjhIEFdkVd+PFj1Mo3/x+3GWBur6glUQ5k+LM4OBKRbY", "user_17_16f5@example.com", "user_17_16f5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_3697@example.com", "user_18_3697@example.com", "USER_18_3697@EXAMPLE.COM", "USER_18_3697", "FeptgQ8lWO61DTYSe5gI6VTmzBMY72e0HdtIQ1mZgeCD5RTf/t2NKgrcyTqYTLqM", "user_18_3697@example.com", "user_18_3697" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_751e@example.com", "user_19_751e@example.com", "USER_19_751E@EXAMPLE.COM", "USER_19_751E", "yWGSMSAAhyLNiouFoUrNKzO/oGzkWh1Uoak+8OSEi4VYW2Sovc8D7mYfoHBZmE1u", "user_19_751e@example.com", "user_19_751e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_397a@example.com", "user_20_397a@example.com", "USER_20_397A@EXAMPLE.COM", "USER_20_397A", "37odvCYnhf1Qa01u/Vo0wsndpWlkPqOVVcJXLzdRDnR76ne6sjSpom6KW0g95hL5", "user_20_397a@example.com", "user_20_397a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_9f38@example.com", "user_21_9f38@example.com", "USER_21_9F38@EXAMPLE.COM", "USER_21_9F38", "WvVdWVIYXXJVOukyMA9yBLac8gI0NMEwMRVM6gPOdxKfijNS5BVMih28NrF6598v", "user_21_9f38@example.com", "user_21_9f38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_2b9b@example.com", "user_22_2b9b@example.com", "USER_22_2B9B@EXAMPLE.COM", "USER_22_2B9B", "H8GOylU0akOsBcUAP4V5HYKP+3zDWsQ3ytu3iDOysHFKVyydtJKQrFlAm6CQpao6", "user_22_2b9b@example.com", "user_22_2b9b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_ba31@example.com", "user_23_ba31@example.com", "USER_23_BA31@EXAMPLE.COM", "USER_23_BA31", "tNloaEl3zlD3OGU3FgzgoP4DHoJRiEvswpDHE48wcYdaYG0NRSHEOvKETGNCEMe+", "user_23_ba31@example.com", "user_23_ba31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_71c1@example.com", "user_24_71c1@example.com", "USER_24_71C1@EXAMPLE.COM", "USER_24_71C1", "WB6iYQ7d6KVyseOjIrn4CfPwAZJ2fPJI4dEsJloWR7VEWGQvgQSvo8LYt5a1EPvn", "user_24_71c1@example.com", "user_24_71c1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_1d1e@example.com", "user_25_1d1e@example.com", "USER_25_1D1E@EXAMPLE.COM", "USER_25_1D1E", "o803OTGnaEEHJsJF4K00GWYUVfWMPLugJ8SqKh+B9Vr+Qsde0Ml7DmjiRf7+K5vl", "user_25_1d1e@example.com", "user_25_1d1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_5242@example.com", "user_26_5242@example.com", "USER_26_5242@EXAMPLE.COM", "USER_26_5242", "mJVqpDhKw37rzTtTzv7GilyWmD9ktMU37Y6M56lHa9ZWXAKoKJIPGsoByrPWbzrT", "user_26_5242@example.com", "user_26_5242" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_937a@example.com", "user_27_937a@example.com", "USER_27_937A@EXAMPLE.COM", "USER_27_937A", "Ucnd5mkuQf2Tr7zLH33wDtroBHNup6rhCGHm9FH6fnPV+hzM3YKzyzE+jFIGU43Q", "user_27_937a@example.com", "user_27_937a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_4927@example.com", "user_28_4927@example.com", "USER_28_4927@EXAMPLE.COM", "USER_28_4927", "+teUv7dtfMi2rdTk8K/epgkUT9Q0KB41Mkz5Q5qSGF4yiRe0ygqlrEFX1b2R8bts", "user_28_4927@example.com", "user_28_4927" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_ba4c@example.com", "user_29_ba4c@example.com", "USER_29_BA4C@EXAMPLE.COM", "USER_29_BA4C", "ncNn0vtXiIE44RylCzGpT9WXfEvj+v4146q5Iy0JGQusw/OFyOU4ggUsg2V5F15h", "user_29_ba4c@example.com", "user_29_ba4c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_0b5f@example.com", "user_30_0b5f@example.com", "USER_30_0B5F@EXAMPLE.COM", "USER_30_0B5F", "UUxbPuVbwkjsgud5/pgsUiPLR1Wpia0ZflNQpeXFxyQR/MA3REjHP4pCH7YqhJQX", "user_30_0b5f@example.com", "user_30_0b5f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_fc1f@example.com", "user_31_fc1f@example.com", "USER_31_FC1F@EXAMPLE.COM", "USER_31_FC1F", "5rmeNdFCwwI17nQBn0BSM38pnIswE+mUOOjY6lW0Ry/rwwOK3yaf4rUpdbqbj1+S", "user_31_fc1f@example.com", "user_31_fc1f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_83b9@example.com", "user_32_83b9@example.com", "USER_32_83B9@EXAMPLE.COM", "USER_32_83B9", "R9QNaktJauFK4AZLh3Rx6Vq1r1/K0PLEyyuDCFt2KsWVQ2qFMttnNddzGgDl1sVX", "user_32_83b9@example.com", "user_32_83b9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_3eab@example.com", "user_33_3eab@example.com", "USER_33_3EAB@EXAMPLE.COM", "USER_33_3EAB", "ApSUF9eVFir85jOsSwHUifis+gqa0FbW3SqdzQbXaCGyWZT7jL9bdoBiCV47dLrI", "user_33_3eab@example.com", "user_33_3eab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_c6cc@example.com", "user_34_c6cc@example.com", "USER_34_C6CC@EXAMPLE.COM", "USER_34_C6CC", "GO2bb1xHeC1KH4fxlkrPDhXhnbzOFsVCF6xd77HV2O0uZpuvkW9Gud/IFGlwVtiF", "user_34_c6cc@example.com", "user_34_c6cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_f5d4@example.com", "user_35_f5d4@example.com", "USER_35_F5D4@EXAMPLE.COM", "USER_35_F5D4", "avduyIuQZWh6CuuhgK/iDI9yhdxgKWELRiI+g6OATR9Jh54GaH1pvDDdldD9mzYa", "user_35_f5d4@example.com", "user_35_f5d4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_f820@example.com", "user_36_f820@example.com", "USER_36_F820@EXAMPLE.COM", "USER_36_F820", "p9daqmwVATjTl2xh4zQVjqZDje1OowbGiVig6D0x+fsu35+HvahMu/Ppw4UWSSCL", "user_36_f820@example.com", "user_36_f820" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_acce@example.com", "user_37_acce@example.com", "USER_37_ACCE@EXAMPLE.COM", "USER_37_ACCE", "IMpp2jaMCb9391ZHRNEliWIi0r40Uw7TqAO9Ommglh/5i5pZl8G60giov+8/ToMN", "user_37_acce@example.com", "user_37_acce" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_07e2@example.com", "user_38_07e2@example.com", "USER_38_07E2@EXAMPLE.COM", "USER_38_07E2", "3iwpzasKBGtj6AOyPuueKB77WXANzTrTIM4zzOMHAQr2wv6OitNW2KkKVrJl2egn", "user_38_07e2@example.com", "user_38_07e2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_aecd@example.com", "user_39_aecd@example.com", "USER_39_AECD@EXAMPLE.COM", "USER_39_AECD", "L7crs13eVl8xand0v0NKdJed9YEDmNTGE2uGEiyobvfbFnfH1q5oJ6Rk9w/x3du+", "user_39_aecd@example.com", "user_39_aecd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_368a@example.com", "user_40_368a@example.com", "USER_40_368A@EXAMPLE.COM", "USER_40_368A", "f97zBrTtUmvOwVRw2F2WU3V6MpVYlZZyj9se85jRODPubYhnA0vaK4SI+F/l5Sv7", "user_40_368a@example.com", "user_40_368a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_3803@example.com", "user_41_3803@example.com", "USER_41_3803@EXAMPLE.COM", "USER_41_3803", "Hr+2Bz0zjRs3SJNvITXRKOFbx65DUsEQ+CRAIJwe2oF42CJcTqpBn9k3bxesfYwN", "user_41_3803@example.com", "user_41_3803" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_46b0@example.com", "user_42_46b0@example.com", "USER_42_46B0@EXAMPLE.COM", "USER_42_46B0", "1KxWRtK+ZbNxtjoHAvjBw24b/vVRQC3JvSqeeyaiN6Ef/mKTHBiHr0Hi1RHsvnuu", "user_42_46b0@example.com", "user_42_46b0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_d49e@example.com", "user_43_d49e@example.com", "USER_43_D49E@EXAMPLE.COM", "USER_43_D49E", "zPxCidhDPm+Nk+LChwLeQL+AuAcasgrf5hmVayusMbIfd1w/nTfyWk1yxSMu78iZ", "user_43_d49e@example.com", "user_43_d49e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_f76f@example.com", "user_44_f76f@example.com", "USER_44_F76F@EXAMPLE.COM", "USER_44_F76F", "szWjaTFNGvzwLgcbLe29d7aCbE9B3yUqGCRTAcyIWGc+i3ipZJ/BfpJdq2QHGzNo", "user_44_f76f@example.com", "user_44_f76f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_6c58@example.com", "user_45_6c58@example.com", "USER_45_6C58@EXAMPLE.COM", "USER_45_6C58", "pTAfJsJWYu6R/vgoaxBHRDuCkZYeaFcMM4xnyfNzt40DXsfrF88+FIUyOvmkDTIp", "user_45_6c58@example.com", "user_45_6c58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_df63@example.com", "user_46_df63@example.com", "USER_46_DF63@EXAMPLE.COM", "USER_46_DF63", "uVC01KCaAXN4igJsQ8Hx7n3eqzqE0ryuqtWTqg8UfBEK9HsGP8ndUR60uYeAMr0s", "user_46_df63@example.com", "user_46_df63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_4525@example.com", "user_47_4525@example.com", "USER_47_4525@EXAMPLE.COM", "USER_47_4525", "iF6YzmkMhd8fBfpd4zq1WBQi2G6jCDCCzH/5K/Fz7pKALrnfKVrB8f8OfdJJnlzH", "user_47_4525@example.com", "user_47_4525" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_096e@example.com", "user_48_096e@example.com", "USER_48_096E@EXAMPLE.COM", "USER_48_096E", "2Xsp5tWKELpQudxXVoQQz/3PSI4oTPaf+mgvKliNbAJKR/wc9ZO2Erx1v0X10Nsv", "user_48_096e@example.com", "user_48_096e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_48c7@example.com", "user_49_48c7@example.com", "USER_49_48C7@EXAMPLE.COM", "USER_49_48C7", "ovEjGTUAhd/ssWT2mGft+xaiclxBk8pPRXe8vQOYRIUsZmwmn/48mLqdb9vwKfph", "user_49_48c7@example.com", "user_49_48c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_d56a@example.com", "user_50_d56a@example.com", "USER_50_D56A@EXAMPLE.COM", "USER_50_D56A", "CSrW4iw/ZcXC5u7I4xhG8CCO91FB6qhZdGmMAMdO5IIWoGBJovyZw2xdpAr6ZMyz", "user_50_d56a@example.com", "user_50_d56a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "PicdUQxGFbomS1kZr8Vjh8njgp4vMdPSuPWGhmkQ8Hq3CamfK7Adp3cw0BBVduJE");

            migrationBuilder.CreateIndex(
                name: "IX_BibliographyItems_AttachmentId",
                table: "BibliographyItems",
                column: "AttachmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BibliographyItems");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35944d40-feb8-4fd8-b673-70346b321a25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c8f343f-5914-4c64-a428-47970298ef7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6bcca60b-1424-4be6-baf9-421d6b5ac415"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76bc22ef-3379-4436-b671-043d3f6c4f9b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79adc72c-f1f5-4550-b48e-4465aeb4fdcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7c19952b-71f7-4bd3-8405-3a5bee85d7a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("891baeb1-1fcb-4dcf-b21a-97387ba4f0b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0ad9da0-60a5-4574-8f7b-a25ffab4937c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3546e39-8721-4976-bc90-35cffb988e81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e290474b-b9e8-4f0c-8f9c-96ffbdfb89a9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1952c020-3ab9-4796-a7cd-46b472a3074f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("27255123-5644-494b-922f-9efa44b10a40"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("82cdec4c-c5d1-44ce-a7f5-51be054f8475"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e92a3e69-2cea-417e-8bd4-9254d0205416"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("37632803-2a2e-44fc-b6cd-a1b2c64dfec7"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("df6aa845-828e-43fe-904f-cef89c73a164"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("eea07e5c-3e16-4f3b-862e-d21bb48ce96c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("fb181e0e-3ac6-4ab8-b39e-c7c4032709b4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("36be0c4b-9608-4aad-8543-68fe334982ad"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3f287a47-88b9-455a-8fa9-6ba6c97eee18"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("4a419f2b-9800-44ef-8b99-58cf0f145896"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("72fae67d-1702-4e1d-8ba5-78b488d11f39"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("dff69e38-ab61-4de0-ab01-76963124e5cf"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e6d41327-300d-4123-9ca4-608a44e63f9d"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("9edaa34d-fa82-4e71-8071-36cb10c785d6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0e0c0f46-841e-477d-85f4-264ea4ae71e6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("42b98c09-bfd3-46e6-a8b6-b08344b78bc6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52122f0f-91b8-48bd-b114-31df8e171ccd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a8977581-3261-4902-9a2d-29f01cc55c78"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c925054c-66ed-430a-bc24-22710800b8c8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e1af8e8d-fd6c-4aa0-bb6e-5b893f0fb5cc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1677ee84-7d66-49cb-a3da-348596683b39"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("54553c22-b421-4036-82fb-8311511d6fc5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("722cb86d-7297-4c57-b687-f51a2a474281"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c518be1-4544-4455-8d97-deacf81d066f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("299446a2-0a25-4ad0-b0fa-dd2e16677fc8"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6caddd46-2da8-4947-85d0-da131f96c474"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9908d0f6-f9dd-4d0a-aa5d-a0664936ff45"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ae95545d-0739-40d2-93b2-b32c0129e586"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("eec4a504-bf48-4cbc-a952-9dc7227e87df"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("79105d96-6927-4f95-9ae7-dde544f173a8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("847ff9a5-daa5-44c2-8f97-0f545567c614"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fd31f39d-cbfe-492b-a491-78b2223f9769"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("031c1f64-7f45-4c21-a34c-f030fe9f3c2e"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("03474e38-8728-4f82-833c-7ce6ff178b68"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("1898bf28-f229-41d7-abc1-3bdbe79be147"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("472da88f-ede0-404f-8ccf-5eb42a74cf65"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("7c0804ea-70f3-43ca-8a27-b807b8d2a649"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("9f522f71-cb71-4f02-8fe2-a6201caed6d7"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("acaebef8-96ac-47df-850a-3c7040f4264c"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("bef0cd91-8ff4-4075-bd62-20144192b8f9"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("f2d1477d-0831-4246-8de5-22c31198e7d8"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("f3d4ac90-7cf3-4877-8ff2-83aafd003118"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("010d6d03-cb7b-4247-bdf2-e03313519348"), "CHF", new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(6304), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("6b3b6dc2-0ecb-4693-b3c5-6b6b4aaff3b6"), "USD", new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(6293), 2, true, "US Dollar", "$", null },
                    { new Guid("7ca5880b-7431-4e80-991b-b3849291d8bc"), "GBP", new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(6302), 2, true, "British Pound", "£", null },
                    { new Guid("c62e64f2-60ed-4b5f-8d10-bf9802303f16"), "EUR", new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(4913), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("259502f3-26ba-4243-a515-86721a8588cf"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(3828), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("996a157a-976f-408b-9ccf-7e12bdb85842"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(2192), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("9ff7cab2-5295-457f-9d63-220894d4080c"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(3823), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("f937b5ed-18b6-4178-bc3a-250a602a1d14"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(3833), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("06922cfa-6028-40e3-9e87-81f4fc1cc973"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(7886), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("423efa55-3ed8-48f8-a7d4-7615cb4fb6dc"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(7883), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("6a897abb-dc36-47aa-be89-9b07580e48e0"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(7772), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("70ac574e-128d-4c92-b27c-6fa9bf691dd5"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(7784), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("73762a70-3c1f-4429-9cbd-b060cf728cbe"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(6056), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("ab99ec60-0a9a-494a-8374-814cbeee00e3"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(7878), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("940dfd58-2978-41c3-ae37-cd2c4cc6b663"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(9080), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4e5204a0-2c04-49d6-8421-fc5cb80a8132"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(3328), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("548ee064-91f0-4dda-903f-35f96223def2"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(4626), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("5eb381e5-fe51-4cf5-ac88-cd709c501eca"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(4608), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("a27e164f-b4cf-43ba-8585-2b7087c2d444"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(4623), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("de27bb02-b815-43fc-a63f-d5c80d5003a2"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(4612), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("fc78ed11-4747-4781-bf60-27aa23e59189"), new DateTime(2025, 3, 13, 21, 34, 0, 156, DateTimeKind.Utc).AddTicks(4603), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("060f9e2b-32e1-42fc-915d-d5a59b522bfa"), null, new DateTime(2025, 3, 13, 21, 34, 0, 158, DateTimeKind.Utc).AddTicks(6207), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("6849dce3-bca7-4792-b9eb-2c2e1baada99"), null, new DateTime(2025, 3, 13, 21, 34, 0, 158, DateTimeKind.Utc).AddTicks(6225), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("7c3f650d-2ef1-4add-a598-5b2ee53ea53b"), null, new DateTime(2025, 3, 13, 21, 34, 0, 158, DateTimeKind.Utc).AddTicks(5125), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("b1e5c608-a6cc-469b-93a4-96935026a792"), null, new DateTime(2025, 3, 13, 21, 34, 0, 158, DateTimeKind.Utc).AddTicks(6221), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("1bdf4e21-72d2-4c71-b7f9-61e818cb4291"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(9217), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("4c561244-ee15-468f-a055-39f9dc1f8d44"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(7538), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("99ef6acf-2793-4a6b-b8ec-44d35ae22a96"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(9221), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("c9ac0ae6-34fb-4a6d-8071-d8e7c0c69962"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(9208), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("ee02a935-f89b-4441-b8da-e6ebf5bec34b"), new DateTime(2025, 3, 13, 21, 34, 0, 157, DateTimeKind.Utc).AddTicks(9231), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 13, 21, 34, 0, 158, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5a5f5edf-c01f-4773-a560-b433fcff49bc"), new DateTime(2025, 3, 13, 21, 34, 0, 159, DateTimeKind.Utc).AddTicks(1090), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("980a2257-c668-468f-a986-1341ca929f2d"), new DateTime(2025, 3, 13, 21, 34, 0, 159, DateTimeKind.Utc).AddTicks(1071), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("9d542454-6692-40bf-ac29-dd96762d7ffc"), new DateTime(2025, 3, 13, 21, 34, 0, 159, DateTimeKind.Utc).AddTicks(1078), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "BGFJz7sMDSxAbG2xRynLk0a69Y/VYesYorcQSrDrc6+/xfeowLQ4SHFeacpj0y4p");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "v5OqLRm8nQ5w0J5j4JtQFD5PVk6OUFOXEBhfy8JuHwPqhEnxp4MeyEpyPD80KVUz");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_d805@example.com", "user_1_d805@example.com", "USER_1_D805@EXAMPLE.COM", "USER_1_D805", "hlKtlTWGxUiCXlJ17ZtkqLL0RYiVuV0bdCUQMTeTz1kyP5Ldy4a0sheJHhp+qOVU", "user_1_d805@example.com", "user_1_d805" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_38e6@example.com", "user_2_38e6@example.com", "USER_2_38E6@EXAMPLE.COM", "USER_2_38E6", "n2aAU3F8vY1fDbwC/go3cfpkRGk5uimC8QFZwGEcCou+GXY2qqPXGzntEbolkI/S", "user_2_38e6@example.com", "user_2_38e6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_4514@example.com", "user_3_4514@example.com", "USER_3_4514@EXAMPLE.COM", "USER_3_4514", "xfzgirWT9h5t3WvfcTLEMX02UCKMuVuKvsDuhEmHl6KZFPH18CD/H5JtjOMhliyc", "user_3_4514@example.com", "user_3_4514" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_f6cb@example.com", "user_4_f6cb@example.com", "USER_4_F6CB@EXAMPLE.COM", "USER_4_F6CB", "sjmGUeSm6G6ZtGZSsKGztgJLP6WHUI5lBAUnucu/80vv2KldcK0NavjkHA7fcOvJ", "user_4_f6cb@example.com", "user_4_f6cb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_f3b1@example.com", "user_5_f3b1@example.com", "USER_5_F3B1@EXAMPLE.COM", "USER_5_F3B1", "ipnSzmxxiyTOWDG1LvF767Rc0yViP1vVlOzTKonHsQCPSrOIh139mnZKYkjI+Euu", "user_5_f3b1@example.com", "user_5_f3b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_2f52@example.com", "user_6_2f52@example.com", "USER_6_2F52@EXAMPLE.COM", "USER_6_2F52", "yxMiK6XnZG9mvMzSL21ygUSOelneg9qyigEWaiAXZhotY8kJ08cwR+k5Bg8WAGrG", "user_6_2f52@example.com", "user_6_2f52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_7e4f@example.com", "user_7_7e4f@example.com", "USER_7_7E4F@EXAMPLE.COM", "USER_7_7E4F", "FIxKSeGYfcHxg1e93F/rMFU6vZA51CM4euKqY6m7K9VZmOgZe2zBWfNt3YH2gh9K", "user_7_7e4f@example.com", "user_7_7e4f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_2d8e@example.com", "user_8_2d8e@example.com", "USER_8_2D8E@EXAMPLE.COM", "USER_8_2D8E", "E1ePPz9sbE6MRaYli4RoBdJACAdnaQy485KKIwWKWTOLA+hN0T8ahk3+UWreKJ+L", "user_8_2d8e@example.com", "user_8_2d8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_a1f7@example.com", "user_9_a1f7@example.com", "USER_9_A1F7@EXAMPLE.COM", "USER_9_A1F7", "SjBDY/R02e8MWUY2bQd9XC9GiGhT4ZPl1BvH5XKNE6YCrzUyXAaQOAOaC3Rj6Md4", "user_9_a1f7@example.com", "user_9_a1f7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_c8b7@example.com", "user_10_c8b7@example.com", "USER_10_C8B7@EXAMPLE.COM", "USER_10_C8B7", "rOgr+lpkH7I5HehW79zUYgZiBwtA4ufhbS73lcNTxJoQmCkuoJadg94bncyoGsIE", "user_10_c8b7@example.com", "user_10_c8b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_babb@example.com", "user_11_babb@example.com", "USER_11_BABB@EXAMPLE.COM", "USER_11_BABB", "eHcC09FhpGmT9d5Rq46G6z2q2qPbpOI5+AtOADR/3Tusc0FMfOGfJhT4CcpQlztS", "user_11_babb@example.com", "user_11_babb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_8653@example.com", "user_12_8653@example.com", "USER_12_8653@EXAMPLE.COM", "USER_12_8653", "YU2h0AwrXE8IqpE8+XtBXIt6SUQnq7yzfXQtECyug9X0bOLAWu8UxvPppuionXdY", "user_12_8653@example.com", "user_12_8653" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_2d79@example.com", "user_13_2d79@example.com", "USER_13_2D79@EXAMPLE.COM", "USER_13_2D79", "1sy3OqMQCHxBEoT5HLs367nIgs1hNySi/bpo/z/UVlhG/eN0zbgNkz0n+17cy6SS", "user_13_2d79@example.com", "user_13_2d79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_3fd1@example.com", "user_14_3fd1@example.com", "USER_14_3FD1@EXAMPLE.COM", "USER_14_3FD1", "8jkLBzN04SXSwPsJ/XTusLa11EA5Tcl6dgu3KWvF+01QYK8L2zFWxHOVehvYlBCp", "user_14_3fd1@example.com", "user_14_3fd1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_ac60@example.com", "user_15_ac60@example.com", "USER_15_AC60@EXAMPLE.COM", "USER_15_AC60", "yPk/FmgmtNkxnCPV4qW+3vnBnTOYm9UjqJYKK2wnpSgwXoryvGTyWMuHPZT8ftxY", "user_15_ac60@example.com", "user_15_ac60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_0b82@example.com", "user_16_0b82@example.com", "USER_16_0B82@EXAMPLE.COM", "USER_16_0B82", "KCUYYzWye5NoJlj/BS6gIwkgMhE8uwSVXZaSGEQ2WgaRJj5mjARnuxmMXDFkmidH", "user_16_0b82@example.com", "user_16_0b82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_1133@example.com", "user_17_1133@example.com", "USER_17_1133@EXAMPLE.COM", "USER_17_1133", "YAPgPx+bz2TPg7zpd62sJug9Fch83CXS19UyJ1+qF9dLr+sg38JxmoigqS7VvkAL", "user_17_1133@example.com", "user_17_1133" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_1ce4@example.com", "user_18_1ce4@example.com", "USER_18_1CE4@EXAMPLE.COM", "USER_18_1CE4", "BTqQpAIKwlt/a4bkmfNJ+olhCXtoN++//44EjiCq8Zg2cUiO2FSQ8pZu2FdP4Dlv", "user_18_1ce4@example.com", "user_18_1ce4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_96f1@example.com", "user_19_96f1@example.com", "USER_19_96F1@EXAMPLE.COM", "USER_19_96F1", "ucctA8svbs2b9gzAjGQIpclVSs8jEL21VGGL3f4Tjp2fonzUwvscfzXxndivvm4z", "user_19_96f1@example.com", "user_19_96f1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_76b7@example.com", "user_20_76b7@example.com", "USER_20_76B7@EXAMPLE.COM", "USER_20_76B7", "IlHpylLc0SKFDcnD5We3vDHt4Ulpo+U83Ca292Plec5TyXKfKFWgkvs8zFegBtTJ", "user_20_76b7@example.com", "user_20_76b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_a21c@example.com", "user_21_a21c@example.com", "USER_21_A21C@EXAMPLE.COM", "USER_21_A21C", "7fhxr/gxJr4swMiessOYL5jP2hO8zJJ4j7Y33ivZ4ATSY68RsXLiXg9Kjgfnpf2a", "user_21_a21c@example.com", "user_21_a21c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_2b6c@example.com", "user_22_2b6c@example.com", "USER_22_2B6C@EXAMPLE.COM", "USER_22_2B6C", "m7xXVBS5ey1/2gGJtvg8pwUVekRvBRDh3wEhn5FRxNljtr/eIBVz7W7c8smBH7uM", "user_22_2b6c@example.com", "user_22_2b6c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_646a@example.com", "user_23_646a@example.com", "USER_23_646A@EXAMPLE.COM", "USER_23_646A", "tPIE3f2nSXHfpd6xjwXEo5ZrpLkqdvDsB1V2UhR6XC3kGU9BzVcY31jjGxjiyVS5", "user_23_646a@example.com", "user_23_646a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_ee59@example.com", "user_24_ee59@example.com", "USER_24_EE59@EXAMPLE.COM", "USER_24_EE59", "prs0lgKrJbZBs/H/z7EcCkFgpgbD3v7aaCvV8p7iN3vHXygBcrjc+Lw9GcwBTfww", "user_24_ee59@example.com", "user_24_ee59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_42a4@example.com", "user_25_42a4@example.com", "USER_25_42A4@EXAMPLE.COM", "USER_25_42A4", "JzvUfmt12ax+iuuWu40zcG4mahZua4KT/+pyb81P4lIb2KM1OsnUW53jotckQsIJ", "user_25_42a4@example.com", "user_25_42a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_d1f4@example.com", "user_26_d1f4@example.com", "USER_26_D1F4@EXAMPLE.COM", "USER_26_D1F4", "OmsXtL21wAWA/p/P/ldYVzNnxt+CSNA2gzFEJHbrt5bffEH2COWzvb7KFEKKYf12", "user_26_d1f4@example.com", "user_26_d1f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_db02@example.com", "user_27_db02@example.com", "USER_27_DB02@EXAMPLE.COM", "USER_27_DB02", "LBFGQyMDHEJQutcLXLuLBQRltwvnfL21jQiOZfeiIkxrrb0dG7JA23SQ3cEQl/FY", "user_27_db02@example.com", "user_27_db02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_ec21@example.com", "user_28_ec21@example.com", "USER_28_EC21@EXAMPLE.COM", "USER_28_EC21", "BI27jdM3THGOhAIXbTA1mZ1j7Y2JEOzmiqqnMdSkoyU16QmC0Mfxm3Dffos0vjL7", "user_28_ec21@example.com", "user_28_ec21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_79bc@example.com", "user_29_79bc@example.com", "USER_29_79BC@EXAMPLE.COM", "USER_29_79BC", "gUZtjqK5/8r3tFJhiJyt2A56ZuCdPNqw4oNCJYCTlzF4IkMEQfWObHUceuC5MnTu", "user_29_79bc@example.com", "user_29_79bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_817b@example.com", "user_30_817b@example.com", "USER_30_817B@EXAMPLE.COM", "USER_30_817B", "W2pZ2erelZP2lDXglZBB5xa83baD/oFfXane+1K3euBfGCpPmaFOmZL0i4YH0YtZ", "user_30_817b@example.com", "user_30_817b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_ce67@example.com", "user_31_ce67@example.com", "USER_31_CE67@EXAMPLE.COM", "USER_31_CE67", "Rr5MtWa+LJFor4V8kbVXgKbCy3fchRaYH16s6xmR2d173WGhLg7si/2qqQ2HoPYs", "user_31_ce67@example.com", "user_31_ce67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_9e1b@example.com", "user_32_9e1b@example.com", "USER_32_9E1B@EXAMPLE.COM", "USER_32_9E1B", "mdaK9KzC9wj6iuuLaJm95fWjtHCGo8kIW2YOrUPflVXxBRNFRzY86gzjBKzUZEWW", "user_32_9e1b@example.com", "user_32_9e1b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_1d41@example.com", "user_33_1d41@example.com", "USER_33_1D41@EXAMPLE.COM", "USER_33_1D41", "COPjFOFH4dWR//1JcE8C5YVxXlkNEyuex2xoQcWzITt5h+/lhY9BiuYLfAX58pLo", "user_33_1d41@example.com", "user_33_1d41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_c29a@example.com", "user_34_c29a@example.com", "USER_34_C29A@EXAMPLE.COM", "USER_34_C29A", "D3OSq3nAD5dUMERPL6XvAp1MZ9tIA6v7TLyA4BHXCjxD0y2SRqzPqWLIJPUUt3Ru", "user_34_c29a@example.com", "user_34_c29a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_117d@example.com", "user_35_117d@example.com", "USER_35_117D@EXAMPLE.COM", "USER_35_117D", "CmSsXZPDwnWCW4qxC3p9cGQoOFrarvWVlblHLi3R8YIRvIEZqqUr8dztj3tht6sz", "user_35_117d@example.com", "user_35_117d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_7181@example.com", "user_36_7181@example.com", "USER_36_7181@EXAMPLE.COM", "USER_36_7181", "8gaA4a1qIQb9ZtBuNE868KHF7FE14XFJtCtyekA02AnN3eKsJs1E9+iI3Yl2yTWY", "user_36_7181@example.com", "user_36_7181" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_5073@example.com", "user_37_5073@example.com", "USER_37_5073@EXAMPLE.COM", "USER_37_5073", "cWetF5VRo4m24dMHkENsuPgZgF4x2xMvROlSuxayJLxV2ypvx4A4T/oPmhHR1tC/", "user_37_5073@example.com", "user_37_5073" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_8521@example.com", "user_38_8521@example.com", "USER_38_8521@EXAMPLE.COM", "USER_38_8521", "Dbe+v7P184EgiLlQ/yCdAUkMTKNYpJ9CZkNUtRpJQlqQ1mdpPXNgH5qV2BnbsrIJ", "user_38_8521@example.com", "user_38_8521" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_2efd@example.com", "user_39_2efd@example.com", "USER_39_2EFD@EXAMPLE.COM", "USER_39_2EFD", "z1bubtwmxIgyW1dkZYxqJ1+7TjspmQ2yH00Ki/kFf9eGb8ZWAVdScCubIiT2WySw", "user_39_2efd@example.com", "user_39_2efd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_05ea@example.com", "user_40_05ea@example.com", "USER_40_05EA@EXAMPLE.COM", "USER_40_05EA", "NgsM9DJDL7VSuF/oOJGPp8Hp0jH3n7EPfI17PP4H0qxFzB8ccCjlU5+g8FrMIKoF", "user_40_05ea@example.com", "user_40_05ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_f824@example.com", "user_41_f824@example.com", "USER_41_F824@EXAMPLE.COM", "USER_41_F824", "ZRPdKhJCqLvYWN1S2NuCXxkKWltFJLOts6995MT+c6QLCCBlNaltcHNyGcPMbsx5", "user_41_f824@example.com", "user_41_f824" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_04df@example.com", "user_42_04df@example.com", "USER_42_04DF@EXAMPLE.COM", "USER_42_04DF", "kxCm5UOQw6NhQs/TfhRWTzJXLDaKGOuqMXjUtjkzdSkWgkMpbvyYyrwMh/G5P3K+", "user_42_04df@example.com", "user_42_04df" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_831f@example.com", "user_43_831f@example.com", "USER_43_831F@EXAMPLE.COM", "USER_43_831F", "4wsLNqRL+ajUwYlrivM/adH58yod7RM7gTqc9Kln9l1+1yWQpA+jSFQYVBQs31Aj", "user_43_831f@example.com", "user_43_831f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_a4d3@example.com", "user_44_a4d3@example.com", "USER_44_A4D3@EXAMPLE.COM", "USER_44_A4D3", "D/17Yi6BPsFRTnCUUYdyTai68nHu2V4kYr2ETn2LO1pRE7tjK9J/Lirn62QrCaYM", "user_44_a4d3@example.com", "user_44_a4d3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_bd10@example.com", "user_45_bd10@example.com", "USER_45_BD10@EXAMPLE.COM", "USER_45_BD10", "Q6BufOfmV+0vpHEoYcc8zPjB007A/RLkYAt1Klh9Jjo1vF39Duerp4V5/IyPFLpf", "user_45_bd10@example.com", "user_45_bd10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_ab17@example.com", "user_46_ab17@example.com", "USER_46_AB17@EXAMPLE.COM", "USER_46_AB17", "MevUzEvh/I+7wvQmcrabW2RcmomJKJC0qpfQ2JIcw9t/k0+W0ulncfejjGkl51e0", "user_46_ab17@example.com", "user_46_ab17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_65e8@example.com", "user_47_65e8@example.com", "USER_47_65E8@EXAMPLE.COM", "USER_47_65E8", "ux2FT4ez4ja6lnxVI2gYunsMNVAYrkXmnX5Lp827aZeKjci1ePaTkult2GCSTith", "user_47_65e8@example.com", "user_47_65e8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_99b1@example.com", "user_48_99b1@example.com", "USER_48_99B1@EXAMPLE.COM", "USER_48_99B1", "fyeHsv5s6Ve8HFrJ+i0QAZU2WSyfb0tJZ3uLHf0CC5JEk8udbNOHQSWi709xyJ8p", "user_48_99b1@example.com", "user_48_99b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_e89b@example.com", "user_49_e89b@example.com", "USER_49_E89B@EXAMPLE.COM", "USER_49_E89B", "8vdSnPfpEEmAEaYYmOgrdUFyU7vYEUB/EYNtSDxCcFz7uHSLDm6suRsAuTvYBPTe", "user_49_e89b@example.com", "user_49_e89b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_1153@example.com", "user_50_1153@example.com", "USER_50_1153@EXAMPLE.COM", "USER_50_1153", "g9ZBOcVV22+5xewhPW94zFV5/bJkTT06vT9hyaAEJkshNxg3Ajtbg4srJVvEyAMK", "user_50_1153@example.com", "user_50_1153" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "bs4DCnvOGhsUuoobUjxxJzKtgtqlaAc2WxkDNoFoUabw8qkjSCQ+zCzvD0Bthh+T");
        }
    }
}
