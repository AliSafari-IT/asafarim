using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectIdToLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fd30469-a260-408d-b12c-ad5b4dcc4c99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4416080f-b075-4b72-b7a0-9d00a30bf28b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c24fbde-c8cf-46be-ae37-b8cef62181a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73c2795b-5ff4-48c8-aeb6-0c7dfdc394a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("755c4c3a-d6b6-49e1-9a88-d41997e93dc4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7761667e-f5da-4d8a-922e-6edde8a57922"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0d0f4f1-00ff-4884-abb6-7f630373e99d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad40d064-d94d-4181-8eb7-20a65ae7090f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb561671-80b3-45af-b821-328524fca94e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f82be211-d963-4345-a6a9-41911764be6a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b92f1bd1-65b8-4ac2-96b0-4b203d9d05ba"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c4603961-1c1d-4bb9-85e3-d270e7355fb7"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c6cb1892-35fb-4b8a-b986-f84a628b073f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("defb7812-ba6b-4422-8d49-35fb63ab1ed7"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("2f289fab-746e-49ab-a656-88fba8eb74b7"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("6fb08530-f03b-4214-bacf-1784e9b95fbe"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d7f1ba6a-1d47-49cf-9ed9-de0251f29a51"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("e699923b-a85c-4aa5-aed1-92b8f008a5f1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("1559f988-2183-4ad8-a3e0-bcedddb04bcc"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("26a6ef15-51ef-4ee5-95ea-5dd2d978ebe0"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3e6f0285-f526-4c0d-a3f1-6471f0e185eb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("8cb0063d-0f48-4d10-b6bc-89818edb7feb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ada9e2ec-87ff-4800-af43-d01d3910504b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f4e35ca4-930e-425a-a62b-b59300410ddd"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("7255e35e-ca20-44dd-ba22-36cb282cf850"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("01d51ca9-4ee1-49c8-bb50-5c8adac72c67"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("12e1f938-b239-4f1d-9573-710e0264a8fa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("140838c8-5068-4ed4-92e8-99db5112a72a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("28b57485-a1da-4c45-9f3d-174dd45c9e0a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1a0db22-e7d2-4004-bcfa-35c73274f92f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b246cf74-a6ad-44f1-bc5f-98cf82530985"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("128118ce-cacd-49ac-9f55-caf2d42dadad"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("abb7dadc-8390-485d-85f8-be01e90bd955"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f63a4e39-4a5c-45e5-95d5-dbf266adc41b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fc723927-5c70-4e97-a6d2-bbbe357515b1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("1e242dd0-2988-47ef-b06f-0201dfed3242"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("68eff3da-209b-4e43-8832-cae8b9e1c880"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("779c1164-4076-43e7-b1fc-e3980575b1cf"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("93cfbe30-3864-49ae-9d97-3c1342f5030e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f8a229ba-1382-47ab-b8ce-acbe70974fa2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("52eb2e81-426b-4585-9344-d0fade047f45"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8b0b01d4-3a12-498a-8dbb-ec59d86e2be4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8fe1281d-f4c9-45de-bd4a-0c20f4ce1543"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "Link",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("20a5541a-42ce-4d2b-a176-f2fa9c15a3b4"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("3bb35296-398c-4c58-a06f-4d9cf19585ab"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("42c4fe8d-b538-4a16-ada3-7baf0378ea5a"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("7cd4c509-4a5c-4323-a6f6-7dc4422dd3dd"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("9b88a31b-ec13-4ed3-9ea0-528f92bde9d5"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("9c1425a6-613b-4852-97d6-78e565eaf0a1"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("da1aeb3a-db45-4167-b911-77d4577e2cf0"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("e6340207-ee6f-4c63-b32b-ca3f2988b75a"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("f1620483-7434-493a-971a-38792318494e"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("f4d8f64a-d07d-4322-8496-2598ab7a0178"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("255cb300-3095-4753-89ae-b633dcb1aba8"), "USD", new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(5890), 2, true, "US Dollar", "$", null },
                    { new Guid("a2bd7e0f-f0b8-4ac8-b1e0-2c02159f6c23"), "CHF", new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(5936), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("d0eef624-5bac-4c55-9d79-10a6dbb5be05"), "EUR", new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(2388), 2, true, "Euro", "€", null },
                    { new Guid("fb9940c6-634c-4ad2-8f40-34e707418447"), "GBP", new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(5931), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6d0e0689-22fd-4bb4-a45b-11f29201cec9"), new DateTime(2025, 3, 12, 15, 46, 45, 764, DateTimeKind.Utc).AddTicks(7786), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("b93e2793-b767-4259-8df9-2d6e2f0a7f1b"), new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(482), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("c050479c-5497-4011-a423-105241723488"), new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(512), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null },
                    { new Guid("ffde1662-3e80-44a1-aec4-ba05be9b483b"), new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(491), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1762b40e-5aae-4fab-b1f0-a6b891f7c217"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8746), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("25f9006f-b20c-4239-b3d7-ae1ceeaf903a"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8721), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("3886d9ca-0599-417a-ab93-cb4e5aacc5e2"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8752), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("6c208b50-3ab1-48f6-bd28-5852dee53592"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8730), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("9abfc01b-d85d-421d-b54b-6baa3b16f4e4"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(8758), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("b52c12af-f127-4e6b-bda1-7cc68bc236d1"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(5094), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("f1ba79f8-0bdd-4c2c-a7d3-dab0056d1599"), new DateTime(2025, 3, 12, 15, 46, 45, 764, DateTimeKind.Utc).AddTicks(1682), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("251b4f47-9641-4dfe-b8d8-257e6a9792c1"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2838), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("36611b4c-caab-404a-bc97-1d6f43d945af"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2843), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("48a0c44e-985d-47a9-bee7-341243055ca7"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2831), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("798e48f9-e5f8-4b36-a8ee-679f5d512033"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(498), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("91b142c8-88a8-4160-9e21-fd9e84f894f9"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2822), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("cfe0e731-3b74-4d48-9b8e-1e8c31926a78"), new DateTime(2025, 3, 12, 15, 46, 45, 763, DateTimeKind.Utc).AddTicks(2860), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3f5d6005-de7e-4ffd-b155-9073cd626e54"), null, new DateTime(2025, 3, 12, 15, 46, 45, 767, DateTimeKind.Utc).AddTicks(6436), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("5996c08e-9258-4f88-a760-0624b00f83ad"), null, new DateTime(2025, 3, 12, 15, 46, 45, 767, DateTimeKind.Utc).AddTicks(6421), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("bf9a0a7b-02b1-442a-9715-9c8ba514f84f"), null, new DateTime(2025, 3, 12, 15, 46, 45, 767, DateTimeKind.Utc).AddTicks(6447), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("e86241a8-6932-417f-b6a0-53680e0415b3"), null, new DateTime(2025, 3, 12, 15, 46, 45, 767, DateTimeKind.Utc).AddTicks(4493), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("3d7f2a89-20f3-4c13-8160-87e5974279b1"), new DateTime(2025, 3, 12, 15, 46, 45, 766, DateTimeKind.Utc).AddTicks(3142), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("869c53cd-9d21-4c08-8e89-739255e29421"), new DateTime(2025, 3, 12, 15, 46, 45, 765, DateTimeKind.Utc).AddTicks(9857), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("9ee65c27-62ee-4ef9-a289-0c9e2252f4db"), new DateTime(2025, 3, 12, 15, 46, 45, 766, DateTimeKind.Utc).AddTicks(3132), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("a4c6d063-4f3c-4738-a123-32a0b6040c9f"), new DateTime(2025, 3, 12, 15, 46, 45, 766, DateTimeKind.Utc).AddTicks(2986), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("c4549858-3392-4209-8a06-59cf1e2b54f1"), new DateTime(2025, 3, 12, 15, 46, 45, 766, DateTimeKind.Utc).AddTicks(3138), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 15, 46, 45, 768, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6b80f51f-9729-4ef6-9ebc-c102c9bc47b0"), new DateTime(2025, 3, 12, 15, 46, 45, 769, DateTimeKind.Utc).AddTicks(1047), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("abeddc32-5c14-4d63-a91b-66fa6301ac63"), new DateTime(2025, 3, 12, 15, 46, 45, 769, DateTimeKind.Utc).AddTicks(1062), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("aee6ccf1-7d98-4119-a8fb-085bfaf0e77a"), new DateTime(2025, 3, 12, 15, 46, 45, 769, DateTimeKind.Utc).AddTicks(1067), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "DUxdAzLnjT9LZmW8kS8jiMYir7ImlGCPJQREVGXEJy89otcvat301L1giXhJtm6+");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "MvvgqrYES0md/uEYG1KYA93rx9ZiP5iXTjMnTJEfvIxq4cjnXeBjj3PmWQepkFSQ");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_1440@example.com", "user_1_1440@example.com", "USER_1_1440@EXAMPLE.COM", "USER_1_1440", "R1Enq5C8NYkxK0m+KcWQlvo91gnFbTUNOavMme9UDoR9SBcUa3DVGSZ/Rj5Gghi/", "user_1_1440@example.com", "user_1_1440" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_6527@example.com", "user_2_6527@example.com", "USER_2_6527@EXAMPLE.COM", "USER_2_6527", "tifmQ2bcZb7I7zw2dasUInGlfnyPgL69v3vvfmaIkt9QpOvQu1thwG8HQrZfdkzE", "user_2_6527@example.com", "user_2_6527" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_0346@example.com", "user_3_0346@example.com", "USER_3_0346@EXAMPLE.COM", "USER_3_0346", "GNCZkTXIVYBwRFa3RCHy2bC154ANBtyGFQ+Efif+FInruRnNfnZZlZOTojslcHxe", "user_3_0346@example.com", "user_3_0346" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_a07f@example.com", "user_4_a07f@example.com", "USER_4_A07F@EXAMPLE.COM", "USER_4_A07F", "UJTMJsyHA+RrTxEEufiKQZ2P4xAGLcsyKffNIxtaf2EmEtBKtZizcFQeo2q04VrX", "user_4_a07f@example.com", "user_4_a07f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_3b75@example.com", "user_5_3b75@example.com", "USER_5_3B75@EXAMPLE.COM", "USER_5_3B75", "Oj1elzxkfRodv1Hxf9dX5Xu7heMaA1F0qYjTk3qqqO2qqS0tHIiLhg4RFVSEAccQ", "user_5_3b75@example.com", "user_5_3b75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_4532@example.com", "user_6_4532@example.com", "USER_6_4532@EXAMPLE.COM", "USER_6_4532", "8OQv10UxHbIeSykcoL3DbLgujYGgjwrIsxL3PmUfftY7TUwqIb56jnF796lNVr4E", "user_6_4532@example.com", "user_6_4532" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_ce26@example.com", "user_7_ce26@example.com", "USER_7_CE26@EXAMPLE.COM", "USER_7_CE26", "X22dZ7pGYH4qfUlOUKSmGSnseF2KkaQONwJw/Z4eW8ztKzuZZj28ThEvVU4s4IBM", "user_7_ce26@example.com", "user_7_ce26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_cf8d@example.com", "user_8_cf8d@example.com", "USER_8_CF8D@EXAMPLE.COM", "USER_8_CF8D", "XzZicNgRg/drx4pgANKjpGKzYgMegRnXrqpHrcCee185Z8CVy1N4vxPfDMYq8ObY", "user_8_cf8d@example.com", "user_8_cf8d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_4299@example.com", "user_9_4299@example.com", "USER_9_4299@EXAMPLE.COM", "USER_9_4299", "MgkGKLPEUQVJo1vKrXKyyZhZToevNrrKR8ccsOn+6VTDnOnkl9r8/I3k8F7nSSew", "user_9_4299@example.com", "user_9_4299" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_4277@example.com", "user_10_4277@example.com", "USER_10_4277@EXAMPLE.COM", "USER_10_4277", "FhfhceV+97itKgyMawsO4SW8eJaT9FFxgrjKTw5OMhwPLSzivopVjjZdj2BSEaw1", "user_10_4277@example.com", "user_10_4277" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_fd98@example.com", "user_11_fd98@example.com", "USER_11_FD98@EXAMPLE.COM", "USER_11_FD98", "xIQFsJOhpXxuPr3J/aJ6CPsjg6y6xd1uR+r7SY8D8ZiQ0aXwNfswW+qZm6ameghI", "user_11_fd98@example.com", "user_11_fd98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_b3c9@example.com", "user_12_b3c9@example.com", "USER_12_B3C9@EXAMPLE.COM", "USER_12_B3C9", "KNRm/I3arTbUCyminuVeZdvxR+oehecVegcRKy8kcWmRVg2sfSeZ2QseF/q1IK7a", "user_12_b3c9@example.com", "user_12_b3c9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_5955@example.com", "user_13_5955@example.com", "USER_13_5955@EXAMPLE.COM", "USER_13_5955", "Y2m2+lrRzAT/fA2IRbqzTyJD37ZTvY4BGALr0HKkYe6f25FIlKPfzPT48v04jz5m", "user_13_5955@example.com", "user_13_5955" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_3de7@example.com", "user_14_3de7@example.com", "USER_14_3DE7@EXAMPLE.COM", "USER_14_3DE7", "TOekNhJdtsyM/1ENYZwCEGrL118jinvHMX9e/DN2fOeJXM2HArxfcH9Zpl2OFu1U", "user_14_3de7@example.com", "user_14_3de7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_0ce0@example.com", "user_15_0ce0@example.com", "USER_15_0CE0@EXAMPLE.COM", "USER_15_0CE0", "nYnGefVz6uBons+XR/qXvPz277YDidF8d5W5cCZBYU8zUJIvnLIVbiSxUn6Cec4F", "user_15_0ce0@example.com", "user_15_0ce0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_54a0@example.com", "user_16_54a0@example.com", "USER_16_54A0@EXAMPLE.COM", "USER_16_54A0", "DU95BsyYTqtB2PLw5/sT25AZ1L69oa1Ijs0CZYs4J1WO+V3cMY4jvpDufr+t5C0A", "user_16_54a0@example.com", "user_16_54a0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_a54c@example.com", "user_17_a54c@example.com", "USER_17_A54C@EXAMPLE.COM", "USER_17_A54C", "lg0HRdzJJZDddbWWHTvPogms5ef4NXBxAtlhtTebmXO5lP+zmtulBVb8B+SzqlU5", "user_17_a54c@example.com", "user_17_a54c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_4939@example.com", "user_18_4939@example.com", "USER_18_4939@EXAMPLE.COM", "USER_18_4939", "PRdvdi7cvjzeJUsoEYm6O3dSD8SSsPdYrx3NJFbJVAJuJMgwl22bfi/W5+QcclhG", "user_18_4939@example.com", "user_18_4939" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_cd83@example.com", "user_19_cd83@example.com", "USER_19_CD83@EXAMPLE.COM", "USER_19_CD83", "zCbhmWoy/gAH9Cq22oCIqTi/xJnGv+XdGeO802s68bdGmFOvw+cz+2BECsjQEt8j", "user_19_cd83@example.com", "user_19_cd83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_f200@example.com", "user_20_f200@example.com", "USER_20_F200@EXAMPLE.COM", "USER_20_F200", "XGRBvuVBEUbl6LIBlmMCdIUAt5O5WvDyQv2SPK173k+HfjcstC58pe6EWHoeuiNG", "user_20_f200@example.com", "user_20_f200" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_46f2@example.com", "user_21_46f2@example.com", "USER_21_46F2@EXAMPLE.COM", "USER_21_46F2", "i/lhZp0i1upfgzBgGad1g8KBye32mvYbn3hCwlMvQpgaiH4ENNUrj+lURvl0hfZS", "user_21_46f2@example.com", "user_21_46f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_efa6@example.com", "user_22_efa6@example.com", "USER_22_EFA6@EXAMPLE.COM", "USER_22_EFA6", "hoZq33Bu5kjuvpdKy4uIqtt3eTlRg4nmwOfRXnBJjQ0PNODCubgBKQRURcuo5ofi", "user_22_efa6@example.com", "user_22_efa6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_7012@example.com", "user_23_7012@example.com", "USER_23_7012@EXAMPLE.COM", "USER_23_7012", "6E2s47BECCVttUcoGOu+ySi0205lW2fJ47ntspgx7LQI7r6jht8sLd0IH5yY1lf1", "user_23_7012@example.com", "user_23_7012" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_f2a1@example.com", "user_24_f2a1@example.com", "USER_24_F2A1@EXAMPLE.COM", "USER_24_F2A1", "OomzGOw7SZ/WevXNxB4DQlmmXvpWc+XrvLHNxrihGVcgiH2rvKfVbbL4i6G+uk6J", "user_24_f2a1@example.com", "user_24_f2a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_dbbb@example.com", "user_25_dbbb@example.com", "USER_25_DBBB@EXAMPLE.COM", "USER_25_DBBB", "c0TOLLQEgNUDSatkTt5CcAKD3Fx73dnGD4FszWzOwlAa9uq6qFM2lP7QuzgX1UFp", "user_25_dbbb@example.com", "user_25_dbbb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_c765@example.com", "user_26_c765@example.com", "USER_26_C765@EXAMPLE.COM", "USER_26_C765", "PTTxLWY5JTtd/myJb6v7iOqvCpm0YyUnMEqxIYDHEcdSGDnUwGLw/5Pz4AgvSRnb", "user_26_c765@example.com", "user_26_c765" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_b627@example.com", "user_27_b627@example.com", "USER_27_B627@EXAMPLE.COM", "USER_27_B627", "dOzwBOM9HCuuRwZCahCNztMCbEuYKCTe/k83NV5zbFYhPLHleJ4981OF3wKharUn", "user_27_b627@example.com", "user_27_b627" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_742e@example.com", "user_28_742e@example.com", "USER_28_742E@EXAMPLE.COM", "USER_28_742E", "KOyJ0t87PbrthxlAoTSRuPIrDjGfhbzY7PXFHimKsLdDZZ4BaB97AukiR6+MAh8s", "user_28_742e@example.com", "user_28_742e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_e97d@example.com", "user_29_e97d@example.com", "USER_29_E97D@EXAMPLE.COM", "USER_29_E97D", "J+C/RLtlgvqEwEJRaFg8R3rxGGlEI7HTuuvmVrHJmfBi9g35xEgnIFU3QREanDMV", "user_29_e97d@example.com", "user_29_e97d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_137f@example.com", "user_30_137f@example.com", "USER_30_137F@EXAMPLE.COM", "USER_30_137F", "VfN/OOUF7PW3sff9HEq+FIIxi0WHBlOTWf6fFXIX89wAQxr3LkvJbBWVoOL3z7Ox", "user_30_137f@example.com", "user_30_137f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_1351@example.com", "user_31_1351@example.com", "USER_31_1351@EXAMPLE.COM", "USER_31_1351", "ck8YL8TTuLscGjxuX/lCBaPYOer7SRqifAPFLrr3FK1ySJsLas3EPOpe2Osy7DSA", "user_31_1351@example.com", "user_31_1351" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_e524@example.com", "user_32_e524@example.com", "USER_32_E524@EXAMPLE.COM", "USER_32_E524", "/EIxIsB0oMrPPWNLmWT7nGxeQ57C3A0OFoyST/Y9kYAugE8h3aXbYpt6Vf5qERZo", "user_32_e524@example.com", "user_32_e524" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_5a08@example.com", "user_33_5a08@example.com", "USER_33_5A08@EXAMPLE.COM", "USER_33_5A08", "s2Vo8lhRoObNl8GD0pRlNNambYcuZdvrxkmN1OBdG1dL2rK9cYcgDUtcpwZVt3/v", "user_33_5a08@example.com", "user_33_5a08" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_c96e@example.com", "user_34_c96e@example.com", "USER_34_C96E@EXAMPLE.COM", "USER_34_C96E", "rGhGX+hucngZRaK0flDukTa9RkOuplFIpXRNhzpfBm+ZfISbBP3CX91UrYVPrB76", "user_34_c96e@example.com", "user_34_c96e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_4ca4@example.com", "user_35_4ca4@example.com", "USER_35_4CA4@EXAMPLE.COM", "USER_35_4CA4", "yq7lWiOQmP8CzOweuUJvtOAsEZLY4LOiYvq1iB+DOPDP3q8RPAC4MabQn71ibZA5", "user_35_4ca4@example.com", "user_35_4ca4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_42ba@example.com", "user_36_42ba@example.com", "USER_36_42BA@EXAMPLE.COM", "USER_36_42BA", "siwmTG5QXqSOhlKvwsYX+cr+y8t45KrTzlbYZLeWJb+rWKzUmcComYcjLdE9npFV", "user_36_42ba@example.com", "user_36_42ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_7347@example.com", "user_37_7347@example.com", "USER_37_7347@EXAMPLE.COM", "USER_37_7347", "7Avpz4iEnnz4+SlxRHwKkguMj6jk+kf/yOQ34PfWKJuCo6+0t//8UCJD+H1AqK5p", "user_37_7347@example.com", "user_37_7347" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_7faf@example.com", "user_38_7faf@example.com", "USER_38_7FAF@EXAMPLE.COM", "USER_38_7FAF", "USyKY3hMAlMZmZ1QnxcNEbjRl5SnGiffZK9ATNCTIy6pRVhwZkqywbAk0F+B2DCg", "user_38_7faf@example.com", "user_38_7faf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_d777@example.com", "user_39_d777@example.com", "USER_39_D777@EXAMPLE.COM", "USER_39_D777", "47csR9aJL3eF8WwG0k6MnMy1JvWDspJn1Elq3knJetKuzWduE+wpfhgiDC6ULZQt", "user_39_d777@example.com", "user_39_d777" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_da80@example.com", "user_40_da80@example.com", "USER_40_DA80@EXAMPLE.COM", "USER_40_DA80", "crGfRj4AhCeW3A3LJAfEjZi8DHbusBQ405kbQqppLrngK3KKzxzZRRIk/xF8Hm3J", "user_40_da80@example.com", "user_40_da80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_fcba@example.com", "user_41_fcba@example.com", "USER_41_FCBA@EXAMPLE.COM", "USER_41_FCBA", "nQ04PM9zHXGYaqiqAFEDi+8J5ubbpg8ybNP19NoM2EZcAWTpAbmNjbulx61uPR3C", "user_41_fcba@example.com", "user_41_fcba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_ac80@example.com", "user_42_ac80@example.com", "USER_42_AC80@EXAMPLE.COM", "USER_42_AC80", "OIWryxmFvRqMRu26FiH9/WiQaU3SrDoyNYqITqTMu96ZSJmWgYlFEVe1KGO+Hrg6", "user_42_ac80@example.com", "user_42_ac80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_7d75@example.com", "user_43_7d75@example.com", "USER_43_7D75@EXAMPLE.COM", "USER_43_7D75", "t+f3ZMpSHyW/yty2gr9apttUBddliDoXsEcsN2Pqi6UFVr53tYG3JGf3GN7SLLfH", "user_43_7d75@example.com", "user_43_7d75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_2dee@example.com", "user_44_2dee@example.com", "USER_44_2DEE@EXAMPLE.COM", "USER_44_2DEE", "664f/cqi84t8c2XzaXIxryh8PNhY0brlFQXubGjdDCW4zH9UFAjBu+YWeAkToPwT", "user_44_2dee@example.com", "user_44_2dee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_5325@example.com", "user_45_5325@example.com", "USER_45_5325@EXAMPLE.COM", "USER_45_5325", "dWMN0LY2fM9bF0W+bQt/4SMgy0ZG19IHqtOhidSCsXvgJHa9RAsWo6IzhQwXX3eP", "user_45_5325@example.com", "user_45_5325" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_9f39@example.com", "user_46_9f39@example.com", "USER_46_9F39@EXAMPLE.COM", "USER_46_9F39", "f3NBRHwKnpYLu8ivrt1cIt1WNsgt7GPMVREmQSUT8GNKyY4S+WtJ+0aal2MSG58Z", "user_46_9f39@example.com", "user_46_9f39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_b050@example.com", "user_47_b050@example.com", "USER_47_B050@EXAMPLE.COM", "USER_47_B050", "Uobve4HczL3Rou77NHWKghaNYuzw/CbA/5UNM6AeDdpUf21cCnwGtfIZwELSPxKK", "user_47_b050@example.com", "user_47_b050" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_bee4@example.com", "user_48_bee4@example.com", "USER_48_BEE4@EXAMPLE.COM", "USER_48_BEE4", "lRUsUssN4leZVpcOefFXAiq+dt4TbGlaGYW0JvWrKpI3URfJEmwR5rk1Ga5zVXZi", "user_48_bee4@example.com", "user_48_bee4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_6ced@example.com", "user_49_6ced@example.com", "USER_49_6CED@EXAMPLE.COM", "USER_49_6CED", "HZM4lTcdZkG2Xzo9Kf4IXCoA7Unr4bzWXjaSz1Xbv0yiTq4mzBdsy1to/sInBjcI", "user_49_6ced@example.com", "user_49_6ced" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_ae1d@example.com", "user_50_ae1d@example.com", "USER_50_AE1D@EXAMPLE.COM", "USER_50_AE1D", "b9pqg8IWlXgmUEYmH1R5WVpye9LnqrF3qPQNh/SugeKKplifNeHQpojC8Dl06cT1", "user_50_ae1d@example.com", "user_50_ae1d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "zbFdaAGMHD7WZS836FjWGZlAKd11PFpMWmED58DQG/5Gb36csat4eEEhHie8T4PF");

            migrationBuilder.CreateIndex(
                name: "IX_Link_ProjectId",
                table: "Link",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Projects_ProjectId",
                table: "Link",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Link_Projects_ProjectId",
                table: "Link");

            migrationBuilder.DropIndex(
                name: "IX_Link_ProjectId",
                table: "Link");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20a5541a-42ce-4d2b-a176-f2fa9c15a3b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3bb35296-398c-4c58-a06f-4d9cf19585ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42c4fe8d-b538-4a16-ada3-7baf0378ea5a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7cd4c509-4a5c-4323-a6f6-7dc4422dd3dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b88a31b-ec13-4ed3-9ea0-528f92bde9d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c1425a6-613b-4852-97d6-78e565eaf0a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da1aeb3a-db45-4167-b911-77d4577e2cf0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6340207-ee6f-4c63-b32b-ca3f2988b75a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1620483-7434-493a-971a-38792318494e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4d8f64a-d07d-4322-8496-2598ab7a0178"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("255cb300-3095-4753-89ae-b633dcb1aba8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a2bd7e0f-f0b8-4ac8-b1e0-2c02159f6c23"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d0eef624-5bac-4c55-9d79-10a6dbb5be05"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fb9940c6-634c-4ad2-8f40-34e707418447"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("6d0e0689-22fd-4bb4-a45b-11f29201cec9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("b93e2793-b767-4259-8df9-2d6e2f0a7f1b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("c050479c-5497-4011-a423-105241723488"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ffde1662-3e80-44a1-aec4-ba05be9b483b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("1762b40e-5aae-4fab-b1f0-a6b891f7c217"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("25f9006f-b20c-4239-b3d7-ae1ceeaf903a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3886d9ca-0599-417a-ab93-cb4e5aacc5e2"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6c208b50-3ab1-48f6-bd28-5852dee53592"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9abfc01b-d85d-421d-b54b-6baa3b16f4e4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b52c12af-f127-4e6b-bda1-7cc68bc236d1"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("f1ba79f8-0bdd-4c2c-a7d3-dab0056d1599"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("251b4f47-9641-4dfe-b8d8-257e6a9792c1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("36611b4c-caab-404a-bc97-1d6f43d945af"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("48a0c44e-985d-47a9-bee7-341243055ca7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("798e48f9-e5f8-4b36-a8ee-679f5d512033"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("91b142c8-88a8-4160-9e21-fd9e84f894f9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cfe0e731-3b74-4d48-9b8e-1e8c31926a78"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3f5d6005-de7e-4ffd-b155-9073cd626e54"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5996c08e-9258-4f88-a760-0624b00f83ad"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bf9a0a7b-02b1-442a-9715-9c8ba514f84f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e86241a8-6932-417f-b6a0-53680e0415b3"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3d7f2a89-20f3-4c13-8160-87e5974279b1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("869c53cd-9d21-4c08-8e89-739255e29421"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9ee65c27-62ee-4ef9-a289-0c9e2252f4db"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("a4c6d063-4f3c-4738-a123-32a0b6040c9f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c4549858-3392-4209-8a06-59cf1e2b54f1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6b80f51f-9729-4ef6-9ebc-c102c9bc47b0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("abeddc32-5c14-4d63-a91b-66fa6301ac63"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("aee6ccf1-7d98-4119-a8fb-085bfaf0e77a"));

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Link");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2fd30469-a260-408d-b12c-ad5b4dcc4c99"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("4416080f-b075-4b72-b7a0-9d00a30bf28b"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("4c24fbde-c8cf-46be-ae37-b8cef62181a3"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("73c2795b-5ff4-48c8-aeb6-0c7dfdc394a6"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("755c4c3a-d6b6-49e1-9a88-d41997e93dc4"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("7761667e-f5da-4d8a-922e-6edde8a57922"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("a0d0f4f1-00ff-4884-abb6-7f630373e99d"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("ad40d064-d94d-4181-8eb7-20a65ae7090f"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("cb561671-80b3-45af-b821-328524fca94e"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("f82be211-d963-4345-a6a9-41911764be6a"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b92f1bd1-65b8-4ac2-96b0-4b203d9d05ba"), "GBP", new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(5250), 2, true, "British Pound", "£", null },
                    { new Guid("c4603961-1c1d-4bb9-85e3-d270e7355fb7"), "USD", new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(5241), 2, true, "US Dollar", "$", null },
                    { new Guid("c6cb1892-35fb-4b8a-b986-f84a628b073f"), "CHF", new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(5253), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("defb7812-ba6b-4422-8d49-35fb63ab1ed7"), "EUR", new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(3478), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2f289fab-746e-49ab-a656-88fba8eb74b7"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(2532), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null },
                    { new Guid("6fb08530-f03b-4214-bacf-1784e9b95fbe"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(1254), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("d7f1ba6a-1d47-49cf-9ed9-de0251f29a51"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(2526), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("e699923b-a85c-4aa5-aed1-92b8f008a5f1"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(2541), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1559f988-2183-4ad8-a3e0-bcedddb04bcc"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6918), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("26a6ef15-51ef-4ee5-95ea-5dd2d978ebe0"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6909), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("3e6f0285-f526-4c0d-a3f1-6471f0e185eb"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6915), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("8cb0063d-0f48-4d10-b6bc-89818edb7feb"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6893), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("ada9e2ec-87ff-4800-af43-d01d3910504b"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(6912), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("f4e35ca4-930e-425a-a62b-b59300410ddd"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(4305), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("7255e35e-ca20-44dd-ba22-36cb282cf850"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(8375), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("01d51ca9-4ee1-49c8-bb50-5c8adac72c67"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1933), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null },
                    { new Guid("12e1f938-b239-4f1d-9573-710e0264a8fa"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1946), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("140838c8-5068-4ed4-92e8-99db5112a72a"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(241), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("28b57485-a1da-4c45-9f3d-174dd45c9e0a"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1924), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("b1a0db22-e7d2-4004-bcfa-35c73274f92f"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1950), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("b246cf74-a6ad-44f1-bc5f-98cf82530985"), new DateTime(2025, 3, 5, 13, 48, 57, 804, DateTimeKind.Utc).AddTicks(1929), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("128118ce-cacd-49ac-9f55-caf2d42dadad"), null, new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(4391), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("abb7dadc-8390-485d-85f8-be01e90bd955"), null, new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(4405), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("f63a4e39-4a5c-45e5-95d5-dbf266adc41b"), null, new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(4401), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("fc723927-5c70-4e97-a6d2-bbbe357515b1"), null, new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(3266), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("1e242dd0-2988-47ef-b06f-0201dfed3242"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(7678), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("68eff3da-209b-4e43-8832-cae8b9e1c880"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(7689), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("779c1164-4076-43e7-b1fc-e3980575b1cf"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(7687), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("93cfbe30-3864-49ae-9d97-3c1342f5030e"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(7671), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("f8a229ba-1382-47ab-b8ce-acbe70974fa2"), new DateTime(2025, 3, 5, 13, 48, 57, 805, DateTimeKind.Utc).AddTicks(6202), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("52eb2e81-426b-4585-9344-d0fade047f45"), new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(8794), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("8b0b01d4-3a12-498a-8dbb-ec59d86e2be4"), new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(8780), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("8fe1281d-f4c9-45de-bd4a-0c20f4ce1543"), new DateTime(2025, 3, 5, 13, 48, 57, 806, DateTimeKind.Utc).AddTicks(8797), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "1WShZQnZ9stw/xJRITPECc8Sv64ZPv/QdBSemssp/afRd40LYg0Pnee2Ok38Mdxs");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "rIrP5mO9ND1bJUIzix7Otb4b/UtyaDFt3UmPIab/9DRM7EBnREI9ONfkIR7aGjHw");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_d3eb@example.com", "user_1_d3eb@example.com", "USER_1_D3EB@EXAMPLE.COM", "USER_1_D3EB", "yLPmvjyv8YmZafNsfQKI2QYbb+ZmpmkptsXCC7KjuInjiyr4W87d/UPd+ItyPeEC", "user_1_d3eb@example.com", "user_1_d3eb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_026c@example.com", "user_2_026c@example.com", "USER_2_026C@EXAMPLE.COM", "USER_2_026C", "MdaS7dMyZEKpTB8vath8o6OedK4LIMKH/gWWFu8jhOHj5R3c3qdnoPzsZUY2H3D+", "user_2_026c@example.com", "user_2_026c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_bb67@example.com", "user_3_bb67@example.com", "USER_3_BB67@EXAMPLE.COM", "USER_3_BB67", "APv5uclXw3AiXNj4AjYbIJWKXrJK9AZSQNNR1ivOWgaXRQtZV2mBBjcWzc9VOE/L", "user_3_bb67@example.com", "user_3_bb67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_1b90@example.com", "user_4_1b90@example.com", "USER_4_1B90@EXAMPLE.COM", "USER_4_1B90", "ej/+Aj2amur1pTDD/Koiho1Klt7fyijX8zGygdPYBnq9LjLKwXFbKVsizpb/Yelh", "user_4_1b90@example.com", "user_4_1b90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_718d@example.com", "user_5_718d@example.com", "USER_5_718D@EXAMPLE.COM", "USER_5_718D", "BDCQHTOphaLNrxUiyNRw62khygCXysg7X1Ur/QOUAdiBoGMjDJxtwnHhLadMEJl9", "user_5_718d@example.com", "user_5_718d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_62f4@example.com", "user_6_62f4@example.com", "USER_6_62F4@EXAMPLE.COM", "USER_6_62F4", "v5gjZHE6mCQn06sGrWKcWZLDRw/Aj1/YYDUB5od5qqVkGhNTVULDyvDPEoaR1ZkX", "user_6_62f4@example.com", "user_6_62f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_9ba4@example.com", "user_7_9ba4@example.com", "USER_7_9BA4@EXAMPLE.COM", "USER_7_9BA4", "cMEiPuOJ5Xhn0OHKKAy+v24xSgo295LMvy/Y1pOFOTJJZTi4jmT2rd26cSQLryji", "user_7_9ba4@example.com", "user_7_9ba4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_88f8@example.com", "user_8_88f8@example.com", "USER_8_88F8@EXAMPLE.COM", "USER_8_88F8", "0WinHzx1iIwU3orZqSTB19dH887QBowOn2ikOvQMXRR49nQUmqm4ak1DFEx3vHX1", "user_8_88f8@example.com", "user_8_88f8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_f52a@example.com", "user_9_f52a@example.com", "USER_9_F52A@EXAMPLE.COM", "USER_9_F52A", "IV9qmS6Q8K+Jd/F3jNCVHy3fqVtjTraX/qzyPyq4DBm846jcPWPmv7kB+iFFPbMi", "user_9_f52a@example.com", "user_9_f52a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_7c80@example.com", "user_10_7c80@example.com", "USER_10_7C80@EXAMPLE.COM", "USER_10_7C80", "/XluS8nXkIzTvQzyC6JYqLuZpubs9YpGpqeSiizE6bVdnGhT+KggToH99+xJpMXP", "user_10_7c80@example.com", "user_10_7c80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_a17e@example.com", "user_11_a17e@example.com", "USER_11_A17E@EXAMPLE.COM", "USER_11_A17E", "hFKNAtwcqMUTpFn7DcbiiSHmQRUiHkHuAgEYk291EFnG61oUc+c4EhxRI9H5/c1+", "user_11_a17e@example.com", "user_11_a17e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_606b@example.com", "user_12_606b@example.com", "USER_12_606B@EXAMPLE.COM", "USER_12_606B", "PMEVYXTyf+XJ55efK6eCq3zIyDz+lkh40PIARJUqxNAZJqzd3wDvkInI5iKrwevh", "user_12_606b@example.com", "user_12_606b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_2e6f@example.com", "user_13_2e6f@example.com", "USER_13_2E6F@EXAMPLE.COM", "USER_13_2E6F", "Of+czZdxCwSHcjno0+gWex1EkxF+e/lHikHm4GaRfK6hUiNTPCrFkXvYdg8CxBPm", "user_13_2e6f@example.com", "user_13_2e6f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_9d45@example.com", "user_14_9d45@example.com", "USER_14_9D45@EXAMPLE.COM", "USER_14_9D45", "kygnJTh3adic/4ja+ZpJGSWx/cpxDDtO5lqMmL+mo1Hoar4ZdjoVdEXylZelTu54", "user_14_9d45@example.com", "user_14_9d45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_4b03@example.com", "user_15_4b03@example.com", "USER_15_4B03@EXAMPLE.COM", "USER_15_4B03", "yqcLlRTQXn1cMA5yOxkf7zzY9hVWZ1ENgXOonTjzaeQS2+OZtVA+b0OppZeWEfMQ", "user_15_4b03@example.com", "user_15_4b03" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_40fc@example.com", "user_16_40fc@example.com", "USER_16_40FC@EXAMPLE.COM", "USER_16_40FC", "bJdnELcUrr/TNGo5/xr9kHPyKdMTA2uRDTmJezXmyU1YN2EkvjOfnbHfv8obmHcl", "user_16_40fc@example.com", "user_16_40fc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_b13b@example.com", "user_17_b13b@example.com", "USER_17_B13B@EXAMPLE.COM", "USER_17_B13B", "av/PBUEQ6SiwSZtB6zTJERtnHgq6AmlWNwnRpy0yEzE5bOrGeCD0XsB9jOWtrP9y", "user_17_b13b@example.com", "user_17_b13b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_2ef4@example.com", "user_18_2ef4@example.com", "USER_18_2EF4@EXAMPLE.COM", "USER_18_2EF4", "/XBuwTSkuaPxRWr8JWpaLTfRXtagMadD4JpKOX4Ro1s1RKwElo116CW27nQowGDD", "user_18_2ef4@example.com", "user_18_2ef4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_5e25@example.com", "user_19_5e25@example.com", "USER_19_5E25@EXAMPLE.COM", "USER_19_5E25", "TziUxf8d3tP6+UacldQvlLd38AogQn/pGroMocFPh+slkJBO8QFZTq1BXGZzV6pn", "user_19_5e25@example.com", "user_19_5e25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_62f7@example.com", "user_20_62f7@example.com", "USER_20_62F7@EXAMPLE.COM", "USER_20_62F7", "Je9RizBB8DoGTyKitFmwG6N2QAByH7bA1Nd7w+43uc1tTagEVhlwY6Rjj7vRrvyb", "user_20_62f7@example.com", "user_20_62f7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_d326@example.com", "user_21_d326@example.com", "USER_21_D326@EXAMPLE.COM", "USER_21_D326", "DBS/+OLVQSy2T2u8Ep+wkfdCGYM30gLMojMTZ8mJoQ9WghSjkoLOrUy4HXiMLPDA", "user_21_d326@example.com", "user_21_d326" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_864e@example.com", "user_22_864e@example.com", "USER_22_864E@EXAMPLE.COM", "USER_22_864E", "NsjjnWfAGKY0UemAteqG8jPrTF0KkhqyJiITpKBk9Ar0aBKfouJdae+WreEkC/o5", "user_22_864e@example.com", "user_22_864e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_e74d@example.com", "user_23_e74d@example.com", "USER_23_E74D@EXAMPLE.COM", "USER_23_E74D", "kqyjjESKBgux8j3fz5ulw/oeheDKasCCp7GvwTnRvD6QrBpEBn3uYDyjd/q01BI+", "user_23_e74d@example.com", "user_23_e74d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_6216@example.com", "user_24_6216@example.com", "USER_24_6216@EXAMPLE.COM", "USER_24_6216", "rIWl38bCZVWTBhpCHuO7O+tmwWyiqJy3UXvPqagl57N67j+l7ej0xsflqw8cumEU", "user_24_6216@example.com", "user_24_6216" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_b8cc@example.com", "user_25_b8cc@example.com", "USER_25_B8CC@EXAMPLE.COM", "USER_25_B8CC", "l18CuqY/S1DZB6rZ2zAgYqPEN7HeyXHf2+8JqmP+qOHO4oKen3JU5/rWflwy/qti", "user_25_b8cc@example.com", "user_25_b8cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_ed79@example.com", "user_26_ed79@example.com", "USER_26_ED79@EXAMPLE.COM", "USER_26_ED79", "uilSsvyAi+RlTk8jOYXbxlH3y1016scaWadmD9tEXkSpP8iKj5ncYi+pn/GzMk6A", "user_26_ed79@example.com", "user_26_ed79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_6448@example.com", "user_27_6448@example.com", "USER_27_6448@EXAMPLE.COM", "USER_27_6448", "sjezEUyiC+98sNX4sfb8ZrZ4CKtN8WPG/4QnaFQtbvza7yfkfkKgNF0yWF4crBG1", "user_27_6448@example.com", "user_27_6448" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_b8b4@example.com", "user_28_b8b4@example.com", "USER_28_B8B4@EXAMPLE.COM", "USER_28_B8B4", "KPMSx7acjQZVMBGl23gd+VnMzFXBZuGilN1qP4RYmLhQQrJzR8IbR0UKCTFbDMtB", "user_28_b8b4@example.com", "user_28_b8b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_92eb@example.com", "user_29_92eb@example.com", "USER_29_92EB@EXAMPLE.COM", "USER_29_92EB", "V/z3ETjAmrsba++JorzvlUePI5Zc33wdRlfmKqta0hNZaXD1nttxx4KmZP0D8dvT", "user_29_92eb@example.com", "user_29_92eb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_8391@example.com", "user_30_8391@example.com", "USER_30_8391@EXAMPLE.COM", "USER_30_8391", "YnL418eGNWy1pFnZ2HTb0QnYpfImqfUCXjKw8Cr8x70USqdjWgXJWPLfXzG5HWc9", "user_30_8391@example.com", "user_30_8391" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_754f@example.com", "user_31_754f@example.com", "USER_31_754F@EXAMPLE.COM", "USER_31_754F", "A1/P4zgtmN5pNzOGj7Jkq4YN4eEAqYV2oDMJzwoteKF1Dj7iBfmOs0DL6sLNyqu0", "user_31_754f@example.com", "user_31_754f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_6899@example.com", "user_32_6899@example.com", "USER_32_6899@EXAMPLE.COM", "USER_32_6899", "yVYJXmVMvvWXA+zN+sJDEVRBnKaP1Q9Hvfsaby+GpJZkcEz7M+kpxjdQEoh752Ce", "user_32_6899@example.com", "user_32_6899" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_612e@example.com", "user_33_612e@example.com", "USER_33_612E@EXAMPLE.COM", "USER_33_612E", "OM+2n+IwoQb8mfmwW/uFrA2+H2MA4znWnpdkUPXsKqDWDkZ7HJE9YjCXuTp+TcWm", "user_33_612e@example.com", "user_33_612e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_b6ce@example.com", "user_34_b6ce@example.com", "USER_34_B6CE@EXAMPLE.COM", "USER_34_B6CE", "kDwbk6Ll1NBdAo7zWidOOnIDoT1zn2eibJo0YuruC3HrpuyVrkwr87y2hiyI37HE", "user_34_b6ce@example.com", "user_34_b6ce" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_2e33@example.com", "user_35_2e33@example.com", "USER_35_2E33@EXAMPLE.COM", "USER_35_2E33", "XT1BlmsbRiCz86zzqVuZVrl67JwsGTEdmHqUYkv9K9+aKohRlq2+Q+OzwxqZSMb9", "user_35_2e33@example.com", "user_35_2e33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_0ee7@example.com", "user_36_0ee7@example.com", "USER_36_0EE7@EXAMPLE.COM", "USER_36_0EE7", "jEzWRqyFbl3a46VaeBuO9Zzv5ipijNCuZZyukOqXfl2Myl5AZ5Vn1PnLIITEPPNY", "user_36_0ee7@example.com", "user_36_0ee7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_39d3@example.com", "user_37_39d3@example.com", "USER_37_39D3@EXAMPLE.COM", "USER_37_39D3", "AdRbVXW7fbn+o+1RCR5c57/4QFZ9oXA2DV/7AhgO5+5JdYxavlNZ33Y2An8g9F9q", "user_37_39d3@example.com", "user_37_39d3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_8247@example.com", "user_38_8247@example.com", "USER_38_8247@EXAMPLE.COM", "USER_38_8247", "hF2Q+BqHqz6ReRGfMfIiPxfHL6V9uqh7aIZWExwkqZfzV82z+iLMJABxpK28A5wR", "user_38_8247@example.com", "user_38_8247" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_7fc9@example.com", "user_39_7fc9@example.com", "USER_39_7FC9@EXAMPLE.COM", "USER_39_7FC9", "C1lX5SGNExtY5B8U0Mxc7KfGlQBkaSNqLidY58zMya6qiCFQkUc08JWIYIDwRH9B", "user_39_7fc9@example.com", "user_39_7fc9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_32c0@example.com", "user_40_32c0@example.com", "USER_40_32C0@EXAMPLE.COM", "USER_40_32C0", "Qj1EVC41AeS2hWMc+4ydBD8vcuW9kHQJCf2D4QaIAq6eX8Yu+uCdHUT4m72QSrXa", "user_40_32c0@example.com", "user_40_32c0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_0924@example.com", "user_41_0924@example.com", "USER_41_0924@EXAMPLE.COM", "USER_41_0924", "ebwD2N4rOzegLfz/E9f2m0OIvkS9VRQ2GHdvxJksjxMpvjD5w/3/0z5LGjJTxj2K", "user_41_0924@example.com", "user_41_0924" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_f128@example.com", "user_42_f128@example.com", "USER_42_F128@EXAMPLE.COM", "USER_42_F128", "XmAqDZxMXw7mqxbnTSSgdVwB94sPkzSmuB4jhqnW5eDdAaEwLVL9Ex39TIDtvBvT", "user_42_f128@example.com", "user_42_f128" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_10e2@example.com", "user_43_10e2@example.com", "USER_43_10E2@EXAMPLE.COM", "USER_43_10E2", "nhOmgeU3BIe2iqxOQPeT5m74sAbpU0uei8fXdC8IozAuavUKSPk2UIsU9qfs/SAI", "user_43_10e2@example.com", "user_43_10e2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_9321@example.com", "user_44_9321@example.com", "USER_44_9321@EXAMPLE.COM", "USER_44_9321", "BRHG6dcdxLIANIQkROgnLkripOqHGTCbW64iPP3JkIhZSfs3i+SwcrhBX+WSCPqW", "user_44_9321@example.com", "user_44_9321" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_ceed@example.com", "user_45_ceed@example.com", "USER_45_CEED@EXAMPLE.COM", "USER_45_CEED", "wEdS964UYmBfVGCXi8wXh9K8dSBed5WMyLdqLctZTrgtxQQFqC3okaAptIA4U7V7", "user_45_ceed@example.com", "user_45_ceed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_84b2@example.com", "user_46_84b2@example.com", "USER_46_84B2@EXAMPLE.COM", "USER_46_84B2", "/M3emPcbrblx9Z/t37WxwJ/3AW1uscKchTawmz0SFwOz4GHdnZduV2LtwGibFas7", "user_46_84b2@example.com", "user_46_84b2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_7ffb@example.com", "user_47_7ffb@example.com", "USER_47_7FFB@EXAMPLE.COM", "USER_47_7FFB", "H9SJjeNkLvCmcjp6crgtLlQTTZJA8+xzzcSLlKtl7o5YidVSAJItHNOrf8Ji8Jo4", "user_47_7ffb@example.com", "user_47_7ffb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_7e72@example.com", "user_48_7e72@example.com", "USER_48_7E72@EXAMPLE.COM", "USER_48_7E72", "h4xUBohJ21Gg5filSGwP5YmUf9FVYOBzwGXdLleimdFhhAKBuKv0PmxlTNTHL1kw", "user_48_7e72@example.com", "user_48_7e72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_3c8e@example.com", "user_49_3c8e@example.com", "USER_49_3C8E@EXAMPLE.COM", "USER_49_3C8E", "cuyoZ3Yh8Mtn/SXKxDsL4h/9/eVgFTLkORtcrld39aoDm4HLEUf029eb7JT7sAGM", "user_49_3c8e@example.com", "user_49_3c8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_ce00@example.com", "user_50_ce00@example.com", "USER_50_CE00@EXAMPLE.COM", "USER_50_CE00", "/4AlCzi1C+ZOToqbeNNotqrAsr0D2mHJn9Kf8sLnBYwvTiHO7uaUvRSgD4SVMsD9", "user_50_ce00@example.com", "user_50_ce00" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "dgk64OinRYFYWE7J8BO9r9X7Ztoet36AAVKumisFmnVGbzQyeICAq3hbykvgv01p");
        }
    }
}
