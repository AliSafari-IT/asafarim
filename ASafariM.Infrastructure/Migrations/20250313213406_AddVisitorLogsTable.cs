using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVisitorLogsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
