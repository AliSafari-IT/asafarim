using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BibliographyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("058ac7ea-0fa1-49a1-9aee-eec8bd95a099"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("0af6ddf2-fc14-4e80-aeb8-e7374ff31532"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("4104b34e-1d5f-4c09-a4bf-53b649ab5902"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("4773d13c-a6a4-46da-b589-53daa6027edb"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("512dddda-8b69-48bc-a4ed-abcea791117f"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("6fc6c4f6-f5f0-4ef4-aad4-4e07aefb2c51"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("7e40ff57-d825-4136-9c4e-f2a3d9d6f975"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("8cdcce16-0d4a-42ed-a11d-a14db328e2e2"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("b0eb49c6-4484-4427-8496-e2f0dd50bd94"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("e7357a5a-ed1c-4630-9bef-68726e77cb69"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02d16b39-068f-4e9b-9f83-5edf2138ed06"), "CHF", new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(3079), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("144e5560-6754-4a81-a1b1-545c59537696"), "EUR", new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(1447), 2, true, "Euro", "€", null },
                    { new Guid("536c3a5d-bd72-4e51-8537-f3b51372a88e"), "USD", new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(3066), 2, true, "US Dollar", "$", null },
                    { new Guid("ecb5265f-d365-4c05-8924-e292a21bda89"), "GBP", new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(3077), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("157357bd-edd5-4611-9c24-739f70980a38"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(89), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null },
                    { new Guid("326bff6c-7c23-4c17-b5e7-86a11450e290"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(8243), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("737d2787-2a1f-4571-b509-860beb7a98ae"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(73), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("d642684a-4c47-47a1-8109-f126f537efb9"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(85), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6b7faddb-0152-494c-8108-08fddd931166"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2907), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("a5540390-cb48-4fc0-94a0-5438ab352523"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2893), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("b8c075e0-09a1-449a-8cad-37a2006bbfe1"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2813), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("c8c20fd6-4956-4e24-b21e-3cd3ccd88ec7"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2820), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("dc43b813-08ed-45fa-ba6a-80de59d85591"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(587), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null },
                    { new Guid("dda9e46f-4b95-4dc7-b42c-151e87e0408e"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(2897), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("2e3f723e-b24d-4d37-94a6-03d6ffff0de5"), new DateTime(2025, 3, 23, 1, 20, 36, 556, DateTimeKind.Utc).AddTicks(4287), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2598e53c-199e-48e5-9e6d-e6c7c8aff8a6"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9123), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("4d3918ed-0929-4d16-9b76-578832ed3669"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9074), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("88f9c01e-d6c4-4cfe-9b6b-166f0e1570d4"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9078), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("943bf88a-a95c-478d-b4e1-965115f81923"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9119), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("d8918f70-37a9-454f-9026-8591ecddb906"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(9108), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("ebea86cf-6d3d-4dd0-a7fc-b762427b1ec1"), new DateTime(2025, 3, 23, 1, 20, 36, 555, DateTimeKind.Utc).AddTicks(7504), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2a6fc865-8476-4796-b6d4-456005259a2c"), null, new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(4799), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("c34adfef-528c-48bd-8d36-634977b924a2"), null, new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(4791), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("e2ff127b-c38f-46e5-afe6-685bb7d8f9d5"), null, new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(3511), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null },
                    { new Guid("e49d36d9-e87d-4ff4-97a8-e0cb9b7f1483"), null, new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(4795), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("6e0e428c-8961-44a1-86ad-af24c2d31f36"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(6587), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("9bb4f5c3-c216-4ac2-914b-f29eebcc3abe"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(6575), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("bc9c578e-e25b-43ae-aae2-741657fde460"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(4432), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("c9ed37f3-f886-4ed3-847f-71f66503a3a7"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(6589), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("e506c17b-9d79-4b92-ba2d-30eff6501335"), new DateTime(2025, 3, 23, 1, 20, 36, 557, DateTimeKind.Utc).AddTicks(6592), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1334022d-4e6e-4325-a5dd-58f4a301e801"), new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(9679), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("6fbefcaf-0251-46a4-87dd-fc7727e9f832"), new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(9676), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("c93703ad-1c7e-4b29-a748-f9a6238bf9e2"), new DateTime(2025, 3, 23, 1, 20, 36, 558, DateTimeKind.Utc).AddTicks(9668), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "/Nez0ZfaApOnLYezCYqgVWfytTwTnsu6b9iuJzh1+tiqC/ppnysCUIN4tpJVBRR3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "b5k6HID6gJPstLpJPRKbcZyLhenwdMuOGs0WcC3+ZK8JmPWgKGDKDukRdJZfJR5l");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_47ae@example.com", "user_1_47ae@example.com", "USER_1_47AE@EXAMPLE.COM", "USER_1_47AE", "X4uDwWM2lCrTk5eUI0XLQgKRjn4rou8av8H2LFZZ8fsIWcOLIWhL3eX8pIBuFbIl", "user_1_47ae@example.com", "user_1_47ae" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_719c@example.com", "user_2_719c@example.com", "USER_2_719C@EXAMPLE.COM", "USER_2_719C", "kwA6y+ooYcLH7aNm+KlAdNirVdZY24Pxq2HcAJbllTKBG1sA2ggA8A/Pxc5QLeUA", "user_2_719c@example.com", "user_2_719c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_f7d6@example.com", "user_3_f7d6@example.com", "USER_3_F7D6@EXAMPLE.COM", "USER_3_F7D6", "uUlQJnY82bknLfMWtJUnw+9+kB+VLVa3Yzu3k4TPByvHx/D9G2/3FFTWTwoxfx8d", "user_3_f7d6@example.com", "user_3_f7d6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_c955@example.com", "user_4_c955@example.com", "USER_4_C955@EXAMPLE.COM", "USER_4_C955", "/BmqP1L5D6MyTAMygXz98lYyZlMTOePsuMUazzB/Iysr5RW/RlbAtK2yUcvm2J/v", "user_4_c955@example.com", "user_4_c955" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_2a86@example.com", "user_5_2a86@example.com", "USER_5_2A86@EXAMPLE.COM", "USER_5_2A86", "LwUdLRCndgVe4AkIuHcRp7vNgMvf48olrywfdujEatLSDn0FIQ8ouQEctIaC7xAC", "user_5_2a86@example.com", "user_5_2a86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_b933@example.com", "user_6_b933@example.com", "USER_6_B933@EXAMPLE.COM", "USER_6_B933", "gjqvPu1IjG/JQnhIEYYyeQEnKlC0QnYl0SUIbto8rUd7qdh3BFOSeBUEl2L8Q6us", "user_6_b933@example.com", "user_6_b933" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_33b1@example.com", "user_7_33b1@example.com", "USER_7_33B1@EXAMPLE.COM", "USER_7_33B1", "Llj2TA8LjNYgqAQLq2owctDhEmgXyhRk9PzVivAu4+/uqydXaRS5DCIVN47Av0qc", "user_7_33b1@example.com", "user_7_33b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_20b2@example.com", "user_8_20b2@example.com", "USER_8_20B2@EXAMPLE.COM", "USER_8_20B2", "fImW9QG1mp9vQrftQmO+DxY39lpfwBLkuBS0q+LD1gY6hXvKHV+qJBaufV78sWgn", "user_8_20b2@example.com", "user_8_20b2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_a230@example.com", "user_9_a230@example.com", "USER_9_A230@EXAMPLE.COM", "USER_9_A230", "6t8SYWYnnVrLxrdhYnK6e/naa5/pYPAzNj3kUnCXwOs+JG12nhRKX1awfsCGqzDd", "user_9_a230@example.com", "user_9_a230" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_02f2@example.com", "user_10_02f2@example.com", "USER_10_02F2@EXAMPLE.COM", "USER_10_02F2", "4MRrPvC+STULZENnuzT4NMiixdyv0xGsl1NXihAvdf49WqWaySf0ovSfZjt3KGLY", "user_10_02f2@example.com", "user_10_02f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_7a86@example.com", "user_11_7a86@example.com", "USER_11_7A86@EXAMPLE.COM", "USER_11_7A86", "vih1H9menqF4T6N6oidczPOH2/Cu5Q6ooDwJSIWAAk7jBsc9WyJWb1SVrWgYNUzV", "user_11_7a86@example.com", "user_11_7a86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_73cc@example.com", "user_12_73cc@example.com", "USER_12_73CC@EXAMPLE.COM", "USER_12_73CC", "FjhHaOB0r85hY7n1i5UwnjmvLUbjoQXEIONoLfoeif+8oktmMS+aO7j0DpVyFMtG", "user_12_73cc@example.com", "user_12_73cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_c05e@example.com", "user_13_c05e@example.com", "USER_13_C05E@EXAMPLE.COM", "USER_13_C05E", "nhUkY+lHNPXYfZlBqpsZ3nx63zzlc3fezNSr/suUdRGGLPs0pI0pdwGMngMjSbib", "user_13_c05e@example.com", "user_13_c05e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_ee69@example.com", "user_14_ee69@example.com", "USER_14_EE69@EXAMPLE.COM", "USER_14_EE69", "3t2dFPMu3tlgOUjthM3ZQioQ+A3L3F7bZKUA6Sy1ppJotS4iSRryDyu5LMHlJ0Jo", "user_14_ee69@example.com", "user_14_ee69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_9347@example.com", "user_15_9347@example.com", "USER_15_9347@EXAMPLE.COM", "USER_15_9347", "h7RChsgGTqcResnr9zLzNePnnoEiJxPhGWTDM0xG+ZkcCBL904DnL1mNKRKJq3j4", "user_15_9347@example.com", "user_15_9347" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_c077@example.com", "user_16_c077@example.com", "USER_16_C077@EXAMPLE.COM", "USER_16_C077", "k3FAFWuDJRx+TY2iA5V6t9OX9woFUhXFKsiZ+8+6Mx9HXp9kzT+hGPQxzRoJd0+c", "user_16_c077@example.com", "user_16_c077" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_7a2c@example.com", "user_17_7a2c@example.com", "USER_17_7A2C@EXAMPLE.COM", "USER_17_7A2C", "ZbDitljPeFqitxW+m0jm4ry3VZYHgJ+FHyncMfdJHmv6VzL4sticbtK3XPRs91PV", "user_17_7a2c@example.com", "user_17_7a2c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_b46d@example.com", "user_18_b46d@example.com", "USER_18_B46D@EXAMPLE.COM", "USER_18_B46D", "XnlgUTWM1fk+EP0rdBM4jCMH1g+/gmcdhLxfJGY5kfLzs4LAUwFbo5INxDlmupyN", "user_18_b46d@example.com", "user_18_b46d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_f825@example.com", "user_19_f825@example.com", "USER_19_F825@EXAMPLE.COM", "USER_19_F825", "ue+7nMetdbPzWoBKUdt+DbkoGgTPL3Cox2SoD2X0a+BRit+nb+eLNDV82Dr89/oN", "user_19_f825@example.com", "user_19_f825" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_d5c5@example.com", "user_20_d5c5@example.com", "USER_20_D5C5@EXAMPLE.COM", "USER_20_D5C5", "PYuZaPvwYLFi3zw7K+4iIMErpUdUfjmLJiV7C04gypFCgF258VYy+IBbg0hV2vBi", "user_20_d5c5@example.com", "user_20_d5c5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_041a@example.com", "user_21_041a@example.com", "USER_21_041A@EXAMPLE.COM", "USER_21_041A", "uvGk9q8p3BA7LCyfe5nnuN+GG97D7YDN/yqowhHnNbYEj3a+32s28v3vvuqJq10H", "user_21_041a@example.com", "user_21_041a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_c40a@example.com", "user_22_c40a@example.com", "USER_22_C40A@EXAMPLE.COM", "USER_22_C40A", "V2ITgoMNsAvO4BPqM07bzstfutOMSsZIiQYYoxXv6fwu2Dug8jP3zAE4v704EpBn", "user_22_c40a@example.com", "user_22_c40a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_f163@example.com", "user_23_f163@example.com", "USER_23_F163@EXAMPLE.COM", "USER_23_F163", "XTYUM4YzrKfVQPk34tXCola7ZUkAcYxorESF2SkrSTUEQGH2uQPflU48WTxr321U", "user_23_f163@example.com", "user_23_f163" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_3849@example.com", "user_24_3849@example.com", "USER_24_3849@EXAMPLE.COM", "USER_24_3849", "E7Of5nkgw7Yv02sCA50AVMG2V0NPEWOy9IusVtQX9WJOLo3jCzKo9OyQnSkz0T6d", "user_24_3849@example.com", "user_24_3849" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_ac40@example.com", "user_25_ac40@example.com", "USER_25_AC40@EXAMPLE.COM", "USER_25_AC40", "rAq4q8KTrNhcDIoRBIZGI24oUA3gHOq+PqgQD/jIaMfZZSbuTeVfbMRZ8JdPAnl7", "user_25_ac40@example.com", "user_25_ac40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_ba0b@example.com", "user_26_ba0b@example.com", "USER_26_BA0B@EXAMPLE.COM", "USER_26_BA0B", "MKg5rqv7rnCVLSRC8zwTY92p4zNoFfNG4nbaqBJPDpS68j9JkhnXO+tORoy6az7h", "user_26_ba0b@example.com", "user_26_ba0b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_b779@example.com", "user_27_b779@example.com", "USER_27_B779@EXAMPLE.COM", "USER_27_B779", "npnfFhUc6FIybW3dWTM+YUKN58CVqBbNxW/+RhAxdQic3uLMGPJOIszw/fpb2DTh", "user_27_b779@example.com", "user_27_b779" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_7b36@example.com", "user_28_7b36@example.com", "USER_28_7B36@EXAMPLE.COM", "USER_28_7B36", "8kHg0uYGu6gxDedHCTzhe7apSX4QoBieQpHhqBn+gIY7Su31guvyLVRQmp9rRX/M", "user_28_7b36@example.com", "user_28_7b36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_f8bc@example.com", "user_29_f8bc@example.com", "USER_29_F8BC@EXAMPLE.COM", "USER_29_F8BC", "L7qjSpX3YlllhY5RVdmZeVBcQJn+P+cCdw/+I1l8kbSBVy1vhtrAGr2OTebIldSS", "user_29_f8bc@example.com", "user_29_f8bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_dbd2@example.com", "user_30_dbd2@example.com", "USER_30_DBD2@EXAMPLE.COM", "USER_30_DBD2", "qe5jyNMrgxs9ZDZf/VJfSm3WqflGMFHz1VVJain3bgYw298M+O3BlOytx3VSKDyT", "user_30_dbd2@example.com", "user_30_dbd2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_7ef4@example.com", "user_31_7ef4@example.com", "USER_31_7EF4@EXAMPLE.COM", "USER_31_7EF4", "GM4Oi4ib9lzNSlgf0r7nI0Gph22ASyDo8kAqq+kf6RLJwAJJwEBNYfbZrrYb807N", "user_31_7ef4@example.com", "user_31_7ef4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_3ce3@example.com", "user_32_3ce3@example.com", "USER_32_3CE3@EXAMPLE.COM", "USER_32_3CE3", "N8mP3ishwVSFxg1T4JPiHjNMLlFu2miRJVnBS1GxJpW16LqO4eA4TV99PJb8ZiOf", "user_32_3ce3@example.com", "user_32_3ce3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_c8d2@example.com", "user_33_c8d2@example.com", "USER_33_C8D2@EXAMPLE.COM", "USER_33_C8D2", "pEQp9/YZs8ehoI2wY7CqgWNI5LrU3f/EAKUHJ8blSZ4TKcpthEZqN0WqSJzD6aZ+", "user_33_c8d2@example.com", "user_33_c8d2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_cde6@example.com", "user_34_cde6@example.com", "USER_34_CDE6@EXAMPLE.COM", "USER_34_CDE6", "TeKmii9zUxXyEgjy9NIo3xLZRGIUOkkFHsEz7ae/2XkIaZ/Ws06hTzO92qR+cGp1", "user_34_cde6@example.com", "user_34_cde6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_6f91@example.com", "user_35_6f91@example.com", "USER_35_6F91@EXAMPLE.COM", "USER_35_6F91", "3TdjdPP/vzBE6hHyGpsXtW61wIieuxrdGIfRlPbdxFy0s6CIBRQLL9KcUt9FKEAd", "user_35_6f91@example.com", "user_35_6f91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_f87e@example.com", "user_36_f87e@example.com", "USER_36_F87E@EXAMPLE.COM", "USER_36_F87E", "56gHgOubGxbt/Veq8DAlsN12JeeN2FCjLIWIe7lWlIPXeXeD/eVB3VFvRfq3XiEf", "user_36_f87e@example.com", "user_36_f87e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_522d@example.com", "user_37_522d@example.com", "USER_37_522D@EXAMPLE.COM", "USER_37_522D", "oUGfM4suzGFvDkasNHV/HbPLzd276jjiLP14aoj07EbYYUzKxzKHLG7YAR/il6y+", "user_37_522d@example.com", "user_37_522d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_0cee@example.com", "user_38_0cee@example.com", "USER_38_0CEE@EXAMPLE.COM", "USER_38_0CEE", "vYlff7xxZ7L4YETjBm57+yL0kn3K6SEaC6i/kNpRK0+MvF2vMbAJhvXGLd/uGydf", "user_38_0cee@example.com", "user_38_0cee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_5999@example.com", "user_39_5999@example.com", "USER_39_5999@EXAMPLE.COM", "USER_39_5999", "MnE6YOEpE+Of+l7G8NY4K8a2tllrauZMF00UewLG5TM304coJiwUOFHG0WN8LqNv", "user_39_5999@example.com", "user_39_5999" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_7c58@example.com", "user_40_7c58@example.com", "USER_40_7C58@EXAMPLE.COM", "USER_40_7C58", "gl5d8J3pj7B7h140yfyer7Qs5NWkAvVd0tID0NCSatPl4yK/WuqigWKKwYtPj5n7", "user_40_7c58@example.com", "user_40_7c58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_fc2b@example.com", "user_41_fc2b@example.com", "USER_41_FC2B@EXAMPLE.COM", "USER_41_FC2B", "zPv0FhZi4rHdsYWmsZ9RbZZ/mtRFIKbpYUEALrOCruimdci/HTMmuR6zOeD8HxMh", "user_41_fc2b@example.com", "user_41_fc2b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_873a@example.com", "user_42_873a@example.com", "USER_42_873A@EXAMPLE.COM", "USER_42_873A", "/v6MkD9lsCpNQrRT0yRxWJRa+9prJAhmQT/+GOw3reVYVZfEQgjy+DIxSfrBttuo", "user_42_873a@example.com", "user_42_873a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_f4d8@example.com", "user_43_f4d8@example.com", "USER_43_F4D8@EXAMPLE.COM", "USER_43_F4D8", "mPQYMKtSbauhm8V6DKrdJdpOBhYg33+FAmPz8JPJAThua3LQVZ9CrNorDKzuya/0", "user_43_f4d8@example.com", "user_43_f4d8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_d28f@example.com", "user_44_d28f@example.com", "USER_44_D28F@EXAMPLE.COM", "USER_44_D28F", "zBQ/sLNea5xkCmTGLodPqgjocG0cfcuvkCre81v/ZgupW03mV0gqoOIT9GrkA4fE", "user_44_d28f@example.com", "user_44_d28f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_9bdd@example.com", "user_45_9bdd@example.com", "USER_45_9BDD@EXAMPLE.COM", "USER_45_9BDD", "odC2aiYfN0cqk+JtUZRkaQg7/ruLXXfXfTv3ti6HtUOzca/95Wwg/K6akZ+6FarJ", "user_45_9bdd@example.com", "user_45_9bdd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_7d45@example.com", "user_46_7d45@example.com", "USER_46_7D45@EXAMPLE.COM", "USER_46_7D45", "3JkkvoN0KO+ufKskUJdQ8MdoBwbTtmTbpmfHyXyBGMuY2KtO6k3KFG4yrIVuf9iD", "user_46_7d45@example.com", "user_46_7d45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_48cc@example.com", "user_47_48cc@example.com", "USER_47_48CC@EXAMPLE.COM", "USER_47_48CC", "5VY06uC2klzrxcHu1kuFZVwF0zcsTklTFe2MKmBw+nP0+dubaYt+ajZvZAzCT1Oc", "user_47_48cc@example.com", "user_47_48cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_fb05@example.com", "user_48_fb05@example.com", "USER_48_FB05@EXAMPLE.COM", "USER_48_FB05", "27f4q+0cQRnZKbECr68YNndqdmkeSic60hLwVRMPID62PN/CrfNWNDYBuGsUy1fS", "user_48_fb05@example.com", "user_48_fb05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_813f@example.com", "user_49_813f@example.com", "USER_49_813F@EXAMPLE.COM", "USER_49_813F", "IdQIfn8XE3aOS+jTGkdKU7m0P9Z8vRXHMMCsYlFylcuEpuqsQpUPBliByFbxEw6J", "user_49_813f@example.com", "user_49_813f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_6a52@example.com", "user_50_6a52@example.com", "USER_50_6A52@EXAMPLE.COM", "USER_50_6A52", "//057DRCgEvvFP7Zi7VYGMaCMUkqHRYQk492G3OR8FU6YfL+ZR5t+jsPLmw0OMSs", "user_50_6a52@example.com", "user_50_6a52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "+k+H6GPl4XJagn3kndeKw3FJ+tZhN6aYJsMSUX89XsC+kzwR74XLQ+8w5GgNwd89");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("058ac7ea-0fa1-49a1-9aee-eec8bd95a099"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0af6ddf2-fc14-4e80-aeb8-e7374ff31532"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4104b34e-1d5f-4c09-a4bf-53b649ab5902"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4773d13c-a6a4-46da-b589-53daa6027edb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("512dddda-8b69-48bc-a4ed-abcea791117f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fc6c4f6-f5f0-4ef4-aad4-4e07aefb2c51"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e40ff57-d825-4136-9c4e-f2a3d9d6f975"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8cdcce16-0d4a-42ed-a11d-a14db328e2e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0eb49c6-4484-4427-8496-e2f0dd50bd94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7357a5a-ed1c-4630-9bef-68726e77cb69"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("02d16b39-068f-4e9b-9f83-5edf2138ed06"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("144e5560-6754-4a81-a1b1-545c59537696"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("536c3a5d-bd72-4e51-8537-f3b51372a88e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ecb5265f-d365-4c05-8924-e292a21bda89"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("157357bd-edd5-4611-9c24-739f70980a38"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("326bff6c-7c23-4c17-b5e7-86a11450e290"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("737d2787-2a1f-4571-b509-860beb7a98ae"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d642684a-4c47-47a1-8109-f126f537efb9"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6b7faddb-0152-494c-8108-08fddd931166"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a5540390-cb48-4fc0-94a0-5438ab352523"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b8c075e0-09a1-449a-8cad-37a2006bbfe1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c8c20fd6-4956-4e24-b21e-3cd3ccd88ec7"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("dc43b813-08ed-45fa-ba6a-80de59d85591"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("dda9e46f-4b95-4dc7-b42c-151e87e0408e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("2e3f723e-b24d-4d37-94a6-03d6ffff0de5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2598e53c-199e-48e5-9e6d-e6c7c8aff8a6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4d3918ed-0929-4d16-9b76-578832ed3669"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("88f9c01e-d6c4-4cfe-9b6b-166f0e1570d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("943bf88a-a95c-478d-b4e1-965115f81923"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d8918f70-37a9-454f-9026-8591ecddb906"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ebea86cf-6d3d-4dd0-a7fc-b762427b1ec1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2a6fc865-8476-4796-b6d4-456005259a2c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c34adfef-528c-48bd-8d36-634977b924a2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e2ff127b-c38f-46e5-afe6-685bb7d8f9d5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e49d36d9-e87d-4ff4-97a8-e0cb9b7f1483"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6e0e428c-8961-44a1-86ad-af24c2d31f36"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9bb4f5c3-c216-4ac2-914b-f29eebcc3abe"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("bc9c578e-e25b-43ae-aae2-741657fde460"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c9ed37f3-f886-4ed3-847f-71f66503a3a7"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("e506c17b-9d79-4b92-ba2d-30eff6501335"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1334022d-4e6e-4325-a5dd-58f4a301e801"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6fbefcaf-0251-46a4-87dd-fc7727e9f832"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c93703ad-1c7e-4b29-a748-f9a6238bf9e2"));

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
        }
    }
}
