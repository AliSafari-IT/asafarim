using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixUserAndEntityImplementations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttachmentPost");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03d56106-5458-4634-a9ac-2b63c98d21f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("121391ed-b992-4768-93b3-87bb2ca7c29a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e73e38a-4295-4e6e-b756-6d6a658f937e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("299a1453-669e-4db8-b882-0335598784a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("338857c7-aca1-42a4-994c-6ecd87c8e772"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3efb797e-9e62-4e86-b05e-5037e461be9f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("52752fd1-6850-4d46-b396-ac94a79a5380"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8219507a-dc5a-4a02-b8c0-ba7ad1d1e835"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3bd33d2-150d-4b9d-bff0-dc257ba3f079"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dde8c486-12e6-4fca-87a0-8b31bcf70050"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("796fad72-78ac-44bb-a3e1-2f4f3a5299b3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("815b2eef-ed9c-4acc-a7bb-5a8aab2ad3da"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8b4e227b-1136-4b13-b83d-1655311188d2"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b44d5f45-4546-4f46-b964-8307b31cfcfc"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0014142f-aa02-479b-bed1-410b7275b9c9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("1d4dce87-947e-4483-ae34-8ff1729b276e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("9550dee8-5d36-42ec-8407-ed59508a6a53"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("fc4b405a-5579-4877-8e22-cee84044b62d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("16589182-3c84-4c2e-9af8-ee4f33a3022d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5524fb23-d494-4511-961e-b9088806138b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("55a26735-9e42-4a43-ae18-83aac29d8543"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5cb67213-fdcf-4719-a897-5147401d75c8"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("64f25bd2-e453-4d41-a8ba-95d1b3fdd4f8"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d8ee0a7a-ceb9-4810-a9eb-7706007d468b"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("6193ac30-14b2-4c4d-be56-442ae714a47a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1f410b04-92a2-4e72-97e5-f02ec4b0039f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("29a914f5-0d34-4aca-a2af-2a8d1090e12b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3475bb84-3db4-4030-8895-cdd6b764938b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3bebe8c9-adcf-47cb-8c87-3a4ee7e9ceeb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("413bbb51-64b3-4c52-8c91-667606c2aba4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbf5bb9-deec-4f2a-b705-861e5123ea5e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("01920b21-024d-4c6b-96f2-91235baf8a33"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("07679d34-90b3-4d50-9848-3c2b96a6c1ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1fee52c8-5ed1-4218-aa16-a92f6d4ee17c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("73f7bac7-2c73-4869-b782-32a7f0979879"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("037a08e2-1b3c-42aa-9865-4ebebb77cf8e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("2988f9fb-364a-4aae-928f-7ed10e181422"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("39b77345-c09e-4982-98d3-f6dc9ea26ecf"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5f6d88c8-c02b-419d-b4c3-b57e8d8915ef"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ac5cff22-6ec5-46a7-86c5-f782ba2a47fa"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0e7c8fb9-ec48-4db2-a935-01b1fff7a35c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ca75b08f-c5fa-48e5-bc55-fb60642bed4a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e1ffebc9-e2ab-4fbc-9af0-6f5a1929418d"));

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
                name: "PhoneNumberConfirmed",
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
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PostId",
                table: "Attachment",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DueDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Assignee = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Initiatives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    TeamMembers = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GoalItems = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Initiatives", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06976aeb-2233-4591-9a55-1bf00ba61520"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("08dc6c56-1243-4b3a-9d66-a09ec49685c5"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("4968cf0a-036a-4f74-bfe4-b24fdbb48abd"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("5973cabb-fa1b-40ca-9081-847d47492232"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("7164ddac-1966-46f1-99da-62eda65f2cda"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("86493dcc-3595-43a2-83f5-4469bd2dfb85"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("b4596d0f-31b7-47a6-b9d4-1c8b8b1cb241"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("bc8ca7e4-35dc-4ed1-8a41-2b23fb860766"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("cc2b2edf-ec66-40bc-a864-f32999efd3de"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("ea20214d-e69e-4bbc-868f-529596e36214"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("56f13d74-7afe-410d-bc7f-62acd52c756c"), "CHF", new DateTime(2025, 3, 4, 12, 21, 0, 124, DateTimeKind.Utc).AddTicks(6323), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("a2a34e68-a880-45b3-a868-f731f390038f"), "EUR", new DateTime(2025, 3, 4, 12, 21, 0, 124, DateTimeKind.Utc).AddTicks(2623), 2, true, "Euro", "€", null },
                    { new Guid("ab8f1928-536f-4068-acd1-258a0f6f50e8"), "GBP", new DateTime(2025, 3, 4, 12, 21, 0, 124, DateTimeKind.Utc).AddTicks(6309), 2, true, "British Pound", "£", null },
                    { new Guid("f0d3a31b-1ebb-4b22-b942-ecdc9050ba1b"), "USD", new DateTime(2025, 3, 4, 12, 21, 0, 124, DateTimeKind.Utc).AddTicks(6279), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f329c06-a920-4cc8-adc5-3a5ddffff41b"), new DateTime(2025, 3, 4, 12, 21, 0, 123, DateTimeKind.Utc).AddTicks(9679), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("2e6180fc-e813-4822-bb66-e72ea656259f"), new DateTime(2025, 3, 4, 12, 21, 0, 123, DateTimeKind.Utc).AddTicks(9682), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("f6a0c83c-69b8-481c-920e-7d6ec1f1c887"), new DateTime(2025, 3, 4, 12, 21, 0, 123, DateTimeKind.Utc).AddTicks(9666), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("ffd4fbe6-e361-46f4-a85b-00e569753862"), new DateTime(2025, 3, 4, 12, 21, 0, 123, DateTimeKind.Utc).AddTicks(7012), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2c24f28b-f064-48f3-bf1e-369891dcac9f"), new DateTime(2025, 3, 4, 12, 21, 0, 123, DateTimeKind.Utc).AddTicks(10), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("4f29221a-0e8d-4f10-90c0-0fe285ccf54d"), new DateTime(2025, 3, 4, 12, 21, 0, 123, DateTimeKind.Utc).AddTicks(17), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("5f563a52-ce64-4c0b-9696-b6fe609ff579"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(9980), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("a1393f59-abc5-4005-be32-a51d150d7a17"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(7368), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("c976a642-60b7-40ce-a31b-93ef40ac5ec2"), new DateTime(2025, 3, 4, 12, 21, 0, 123, DateTimeKind.Utc).AddTicks(13), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("d637dd52-19ce-4a33-bca7-ce92589fe92e"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(9998), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("5d5e7f0d-0349-421f-b273-0698c4a4fdc4"), new DateTime(2025, 3, 4, 12, 21, 0, 123, DateTimeKind.Utc).AddTicks(1864), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("77ed25c4-f8ca-48a4-acae-bc6bf5f597b6"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(5786), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("7c7ffc6d-4323-4f22-b068-3b202d9ebf98"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(5792), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("89cd5c88-32af-4c5c-b169-0882a4cfd5cd"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(5695), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("c0f979f2-2ac3-4374-8722-44469dd163a5"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(5705), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("d11b4409-ad67-471c-b0d7-6f3ecd33c9e1"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(5789), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("dc72a8d2-b8c6-42b5-bff7-b705a9273bbb"), new DateTime(2025, 3, 4, 12, 21, 0, 122, DateTimeKind.Utc).AddTicks(4324), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2dd144bc-8a4b-4db5-8f0f-fcb912faf93d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("3255b64e-4b7b-4949-9608-3cf9a6b6ce63"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("419d27b0-951c-4c85-b010-8e5f45ac9762"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("64e9d0be-99c6-4b38-9ad3-7068ac511ae8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("0ce61777-082c-42f5-824e-4e40f83886ac"), new DateTime(2025, 3, 4, 12, 21, 0, 125, DateTimeKind.Utc).AddTicks(1814), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("49177106-28a4-4cb4-8e98-b2a61bfecef2"), new DateTime(2025, 3, 4, 12, 21, 0, 125, DateTimeKind.Utc).AddTicks(1823), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("7ef76c32-1364-4d8f-89dd-ffdd14facc26"), new DateTime(2025, 3, 4, 12, 21, 0, 124, DateTimeKind.Utc).AddTicks(8958), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("7f366be1-2a39-4446-96e0-7fd2915914ef"), new DateTime(2025, 3, 4, 12, 21, 0, 125, DateTimeKind.Utc).AddTicks(1791), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("b6ea92d5-ebac-4cbf-8ce2-0720f67276ae"), new DateTime(2025, 3, 4, 12, 21, 0, 125, DateTimeKind.Utc).AddTicks(1819), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 4, 12, 21, 0, 126, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("aa5298b1-d78d-4608-8a29-fdda63c96eec"), new DateTime(2025, 3, 4, 12, 21, 0, 126, DateTimeKind.Utc).AddTicks(9045), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("e83cb273-49ff-406b-97a1-9ff5f705babd"), new DateTime(2025, 3, 4, 12, 21, 0, 126, DateTimeKind.Utc).AddTicks(9054), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("eadb7ea5-97b0-4572-9b4f-1dbd5644eb98"), new DateTime(2025, 3, 4, 12, 21, 0, 126, DateTimeKind.Utc).AddTicks(8507), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "LockoutEnd", "PasswordHash" },
                values: new object[] { null, "oy0WAvMjmUD5Ys4hv4s/mpjw4LT4ifoWQmne6mtu1+uszrxAG3xcdqWk86ZzAmEA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "LockoutEnd", "PasswordHash" },
                values: new object[] { null, "E+rYeoP+vZP1j4NTaNzB9+6ucUHjZMewgc9QbZvcBcqyLYfC9RI8FWQbRWByU3OD" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_60a5@example.com", "user_1_60a5@example.com", null, "USER_1_60A5@EXAMPLE.COM", "USER_1_60A5", "g9G4+PjoNxzhPXPVa27I3gV4flgijjOMpD7MRG25RAjE2xpPN1TSyX0sSmPNi5MJ", "user_1_60a5@example.com", "user_1_60a5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_3fed@example.com", "user_2_3fed@example.com", null, "USER_2_3FED@EXAMPLE.COM", "USER_2_3FED", "2tmS1JWTrtp+5emqnPgsfFQ0HG3CgDa8BSm79sIU972H+XngH9FJc1VYp46Ttipv", "user_2_3fed@example.com", "user_2_3fed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_8c9a@example.com", "user_3_8c9a@example.com", null, "USER_3_8C9A@EXAMPLE.COM", "USER_3_8C9A", "ZcgGjLkbhSFLaJIkjW+EG+JOADeUjoAHb5ADoEfqqdTU87u4gIkaF7blxAcDRG3p", "user_3_8c9a@example.com", "user_3_8c9a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_d1bf@example.com", "user_4_d1bf@example.com", null, "USER_4_D1BF@EXAMPLE.COM", "USER_4_D1BF", "9Ow51xBS4duDEay3ttcHywDEgaqpoy/+Mfju9XcJc1fIkFMhiVlH3SYU1Cipsh7c", "user_4_d1bf@example.com", "user_4_d1bf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_400c@example.com", "user_5_400c@example.com", null, "USER_5_400C@EXAMPLE.COM", "USER_5_400C", "zrePXuwN6V60x3UeZ3lzSoF+QFuStOiLA6E6p22X10c4cqPJcvCinCYCEAUlfh7H", "user_5_400c@example.com", "user_5_400c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_b14f@example.com", "user_6_b14f@example.com", null, "USER_6_B14F@EXAMPLE.COM", "USER_6_B14F", "XHxghaQURobYoIJXQz6g7paGbv1OLo1cvtIpSmUYK/LVanIRtxLin8iPcjMacgXA", "user_6_b14f@example.com", "user_6_b14f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_8f43@example.com", "user_7_8f43@example.com", null, "USER_7_8F43@EXAMPLE.COM", "USER_7_8F43", "Y+AsEpB3hDShXGcE44R+F7TegjQ8blFWGvTICep81+Ys0C0EHxtlUvpQszIAvGRS", "user_7_8f43@example.com", "user_7_8f43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_a0d3@example.com", "user_8_a0d3@example.com", null, "USER_8_A0D3@EXAMPLE.COM", "USER_8_A0D3", "VGPa10kTn+e5oPHuPJeyZ2WmYmzq+RTcOHzErlQJmoKcdjn6TgEnKzKxi+/+KtJN", "user_8_a0d3@example.com", "user_8_a0d3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_cc4d@example.com", "user_9_cc4d@example.com", null, "USER_9_CC4D@EXAMPLE.COM", "USER_9_CC4D", "d4AYRpvr3BwkwobCYVqOTN+Hzd6lPJMYy5d1TGx+F7gjrHJnIWQ2+jkn5kfUAyBa", "user_9_cc4d@example.com", "user_9_cc4d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_53e3@example.com", "user_10_53e3@example.com", null, "USER_10_53E3@EXAMPLE.COM", "USER_10_53E3", "hh3YfzQpeDXlpGfRjFfo3VFbJR1cwjJJspXbU+/dkH4MXBJH367Nifv6rI1rXMMG", "user_10_53e3@example.com", "user_10_53e3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_8316@example.com", "user_11_8316@example.com", null, "USER_11_8316@EXAMPLE.COM", "USER_11_8316", "asUAXuajLzgTat3ojyY1Oc2hnrsyW/H5du4JPNJuhJBSLCpkMt6FxosiprGWytX4", "user_11_8316@example.com", "user_11_8316" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_09f3@example.com", "user_12_09f3@example.com", null, "USER_12_09F3@EXAMPLE.COM", "USER_12_09F3", "4Lsv/fHRm7GABBqMl5cBvji6bhd0UbGwJAE5VsvxyrzHXFEONoP2PPypDaNTjMuk", "user_12_09f3@example.com", "user_12_09f3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_07a6@example.com", "user_13_07a6@example.com", null, "USER_13_07A6@EXAMPLE.COM", "USER_13_07A6", "km9zIDnfJSL9DDh/yMdFTf9JSjrnMXpmBZxhR2RS75QUJsiCEP6M/9+z3CO7HAF+", "user_13_07a6@example.com", "user_13_07a6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_398b@example.com", "user_14_398b@example.com", null, "USER_14_398B@EXAMPLE.COM", "USER_14_398B", "TVBCt40VSR7bNkqAJKuq+ai6faAlAy1G3eRIrzxa1HXHaULlGf0ZV/PSs8wGqzue", "user_14_398b@example.com", "user_14_398b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_7e57@example.com", "user_15_7e57@example.com", null, "USER_15_7E57@EXAMPLE.COM", "USER_15_7E57", "NJpfzjBj2M2phjwDvs7Q+/cSOoN/TZkggXCkYOnIOAi/ffxMmb29PBNF8OzpOV8Z", "user_15_7e57@example.com", "user_15_7e57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_e2ba@example.com", "user_16_e2ba@example.com", null, "USER_16_E2BA@EXAMPLE.COM", "USER_16_E2BA", "VPgIEQyRxxcj7HXm3mY50bRHhkWqAuJE3sD7v+ttAejN+QK8LTGl6n4kDllTxBFs", "user_16_e2ba@example.com", "user_16_e2ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_d062@example.com", "user_17_d062@example.com", null, "USER_17_D062@EXAMPLE.COM", "USER_17_D062", "kclOfEg8lHW/E5eUc7wGxRomHyPHfc2/aShNZ+yvLvn6SfXOdwDrMFyhAzk9VChF", "user_17_d062@example.com", "user_17_d062" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_072e@example.com", "user_18_072e@example.com", null, "USER_18_072E@EXAMPLE.COM", "USER_18_072E", "h699mLAh/P3D+JCDU4bsTLfup7wEJfVNDPof3PKrWiuxSgjpsi9AC6ThedsIYBW5", "user_18_072e@example.com", "user_18_072e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_79e8@example.com", "user_19_79e8@example.com", null, "USER_19_79E8@EXAMPLE.COM", "USER_19_79E8", "iAY6bKw4yiWflsMwG/PRR45LQH7+33PZQp0/J7SVC8Hy+7Jqw2rlpXsMd0V7sDV7", "user_19_79e8@example.com", "user_19_79e8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_3f5f@example.com", "user_20_3f5f@example.com", null, "USER_20_3F5F@EXAMPLE.COM", "USER_20_3F5F", "h1lBx/NosC25r1pB9XD6vR77BU/PGgdPl3dBT5QhzZEIrQv3YBYPPMKDwxc61MB0", "user_20_3f5f@example.com", "user_20_3f5f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_ade0@example.com", "user_21_ade0@example.com", null, "USER_21_ADE0@EXAMPLE.COM", "USER_21_ADE0", "NKRag2A1XMvwbRHSuxruM+nxxoWb6+RG9RfpqA3156od2WCAyTmFfdgNzhMdkycw", "user_21_ade0@example.com", "user_21_ade0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_e74b@example.com", "user_22_e74b@example.com", null, "USER_22_E74B@EXAMPLE.COM", "USER_22_E74B", "ndoEpBoxkJ6sapRu/RbpuFC2M0fidJcs9N+gV/HlBPaIET5Ht28QWNIiX+DGPHHp", "user_22_e74b@example.com", "user_22_e74b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_1fb4@example.com", "user_23_1fb4@example.com", null, "USER_23_1FB4@EXAMPLE.COM", "USER_23_1FB4", "sqCN/4mvDmOkviK8JzkfZCfpeX1RuE4OoFdifApolH839NJMUENZC8+YCu/Ud4g5", "user_23_1fb4@example.com", "user_23_1fb4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_f89b@example.com", "user_24_f89b@example.com", null, "USER_24_F89B@EXAMPLE.COM", "USER_24_F89B", "klItneCnXYcRmz55eJdOx68S44ym4zXPPUPI0y4kf7jRo4VQqfzjP/1EFHEecU6U", "user_24_f89b@example.com", "user_24_f89b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_0bf6@example.com", "user_25_0bf6@example.com", null, "USER_25_0BF6@EXAMPLE.COM", "USER_25_0BF6", "l3cwRBELuwhxwGuOa9pN/EMrjcbrlpZ3Fcmd5SIIGvPH0+89a2fJ/nIvxdRAQ1n9", "user_25_0bf6@example.com", "user_25_0bf6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_5a1a@example.com", "user_26_5a1a@example.com", null, "USER_26_5A1A@EXAMPLE.COM", "USER_26_5A1A", "n11hSnFklpAtP7VtSR2TXic6IO4TV49aZE1GSNwqPwaS5tErR4GG7Wa8cLXQpXeW", "user_26_5a1a@example.com", "user_26_5a1a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_9893@example.com", "user_27_9893@example.com", null, "USER_27_9893@EXAMPLE.COM", "USER_27_9893", "mAlhcGE/nvrHOS5k9R+HXwYeapNk6ETpqpNvn571+XWYm/R2geMlhv9/4smOWaHe", "user_27_9893@example.com", "user_27_9893" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_9c22@example.com", "user_28_9c22@example.com", null, "USER_28_9C22@EXAMPLE.COM", "USER_28_9C22", "A8hYvW4eovoe8wHg/8eqF3yJHvTRKR5VTDzSdRwJac8x5MieKFd9tQWPCT9n5gBt", "user_28_9c22@example.com", "user_28_9c22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_a4e8@example.com", "user_29_a4e8@example.com", null, "USER_29_A4E8@EXAMPLE.COM", "USER_29_A4E8", "r2+07FBEZIfBkTfIOjMvT5RNFovpv6UlaRHwFMoGXngJ/xgCVjrzxAkoPDmqcExo", "user_29_a4e8@example.com", "user_29_a4e8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_f57f@example.com", "user_30_f57f@example.com", null, "USER_30_F57F@EXAMPLE.COM", "USER_30_F57F", "VOBS4LOyNRF7Pv/gjW7wb5vyQH/dtY7RO8huvCgCMX7EvTRdzpPQbhQJck1enbD5", "user_30_f57f@example.com", "user_30_f57f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_304e@example.com", "user_31_304e@example.com", null, "USER_31_304E@EXAMPLE.COM", "USER_31_304E", "ZqDBRFDn/dlEy0s1r9YSxuX9w9rHX5NVqeVmoKqdSRUUEwOTdU3pedZII0ahkx2b", "user_31_304e@example.com", "user_31_304e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_fdff@example.com", "user_32_fdff@example.com", null, "USER_32_FDFF@EXAMPLE.COM", "USER_32_FDFF", "RcRfOecTxrO/ONp2YaKS8Y+hyQsCZ6XWx1WWmWN9MJa4H14SRcvLjGIUeUb7b3ay", "user_32_fdff@example.com", "user_32_fdff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_e5ca@example.com", "user_33_e5ca@example.com", null, "USER_33_E5CA@EXAMPLE.COM", "USER_33_E5CA", "ujgKT3oECqkCEiyCRRhG9CjE9EF5EJJsiC3s9b1+9HdntRmnKb9qmU4zfDKcS8He", "user_33_e5ca@example.com", "user_33_e5ca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_a475@example.com", "user_34_a475@example.com", null, "USER_34_A475@EXAMPLE.COM", "USER_34_A475", "MXzVv9leNUSLsIbkFNsW+RL9CFd1Od3Fd0DugGYw2UCSLQrSej3w+ut6llfy2Sym", "user_34_a475@example.com", "user_34_a475" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_ccb0@example.com", "user_35_ccb0@example.com", null, "USER_35_CCB0@EXAMPLE.COM", "USER_35_CCB0", "zM/FnMFizjzCogAnLTxk8/rILqP751tJtnxIeTVrfX2hfwg/gg7N/v/75VYnJW1t", "user_35_ccb0@example.com", "user_35_ccb0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_1679@example.com", "user_36_1679@example.com", null, "USER_36_1679@EXAMPLE.COM", "USER_36_1679", "xs2wmFtgibAoRa18kr7YDCBrlCAavzz1pzs+SFL9uMLMVtUjbx0kno4Wi+gSh7Wj", "user_36_1679@example.com", "user_36_1679" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_9a40@example.com", "user_37_9a40@example.com", null, "USER_37_9A40@EXAMPLE.COM", "USER_37_9A40", "YKrDlqGH8iICGCgzUac8KF0WaYf8FGgHwL7CNQBpb32H5zLqugapVIUBg6aV/i55", "user_37_9a40@example.com", "user_37_9a40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_4879@example.com", "user_38_4879@example.com", null, "USER_38_4879@EXAMPLE.COM", "USER_38_4879", "sfUCMAqacL2O8ypCBkRGCgLCb2qxI/5Yi4OyDyBTcCdfeKvs/Hi9rFXXSwVaDYne", "user_38_4879@example.com", "user_38_4879" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_09ea@example.com", "user_39_09ea@example.com", null, "USER_39_09EA@EXAMPLE.COM", "USER_39_09EA", "aqMbYqFvrGlP6IZG/73fh948pOU7NKM7Va8mW1D+nm9hVoTQaSwfX8gTP5fvOccm", "user_39_09ea@example.com", "user_39_09ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_95cb@example.com", "user_40_95cb@example.com", null, "USER_40_95CB@EXAMPLE.COM", "USER_40_95CB", "AwRQ7WIUHkMEbuiwD/aiTlLFtD7cjYtSoTmyTM3pB7TThqKhVvdIvQByyowf6Mqj", "user_40_95cb@example.com", "user_40_95cb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_74ee@example.com", "user_41_74ee@example.com", null, "USER_41_74EE@EXAMPLE.COM", "USER_41_74EE", "EUdK0UVt6Lf+wR8Ue6wBbhoQoJjB7gVGNbM2QYCXAqiiA67TB6rteJnS7RtE2gNe", "user_41_74ee@example.com", "user_41_74ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_7d25@example.com", "user_42_7d25@example.com", null, "USER_42_7D25@EXAMPLE.COM", "USER_42_7D25", "hCNkIjf50Nu9gEWLkGBBBM47VWEgksSh4hK4t3yKDEUfFw3WvAvvzUAhiF1UdNUp", "user_42_7d25@example.com", "user_42_7d25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_2b44@example.com", "user_43_2b44@example.com", null, "USER_43_2B44@EXAMPLE.COM", "USER_43_2B44", "wO9b0QRuxWxslXqWPdFHFHNbV6SjyynSwlE2kwlvZpNOgZAnj0T7b19GqYSwe+ym", "user_43_2b44@example.com", "user_43_2b44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_b3ce@example.com", "user_44_b3ce@example.com", null, "USER_44_B3CE@EXAMPLE.COM", "USER_44_B3CE", "e6q6zob4uj+Q7lYDROEKbgyXTdcpRK6s+0/zxLRWk8lgpoWxi59vSGgtADY9nI0F", "user_44_b3ce@example.com", "user_44_b3ce" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_9019@example.com", "user_45_9019@example.com", null, "USER_45_9019@EXAMPLE.COM", "USER_45_9019", "PNNJ4+iLd4VjjDxqmWpOgWNobSXXttavh/MLEZcp9H+eHiIM8fQPQLo8YJIlKhcc", "user_45_9019@example.com", "user_45_9019" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_51bb@example.com", "user_46_51bb@example.com", null, "USER_46_51BB@EXAMPLE.COM", "USER_46_51BB", "r2Tsrri1uCTUzJYfKuO8aWTKNvVbH1CRdY1OOso42n4auvyDinbDuhT/VYXoKaxZ", "user_46_51bb@example.com", "user_46_51bb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_e85a@example.com", "user_47_e85a@example.com", null, "USER_47_E85A@EXAMPLE.COM", "USER_47_E85A", "zU7aAt4ovktNG8poMDRUa83d1I1PaHoFjMOHU47KesZsNfrNxaUe8f7DWRyqSIXa", "user_47_e85a@example.com", "user_47_e85a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_ed15@example.com", "user_48_ed15@example.com", null, "USER_48_ED15@EXAMPLE.COM", "USER_48_ED15", "fXRy/C/EPeM4V/sbDOeUzbQoCL3UXpKt66g8ahydKKfNL8ZuAxCw5ag7quw8gEpA", "user_48_ed15@example.com", "user_48_ed15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_d1d6@example.com", "user_49_d1d6@example.com", null, "USER_49_D1D6@EXAMPLE.COM", "USER_49_D1D6", "DHBHIS0iazMmsUcsCb9i4r+zAETzK+Y5CFUe4Vk2GLFHLOsLpF2D8Oc2XyNIS9FY", "user_49_d1d6@example.com", "user_49_d1d6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_2fda@example.com", "user_50_2fda@example.com", null, "USER_50_2FDA@EXAMPLE.COM", "USER_50_2FDA", "LMkOFvtBJaklF7JeB29hv1xCe0wLiWf9sYWvtfZ1KNaXt5FxSsLRM9Oon98HkGbv", "user_50_2fda@example.com", "user_50_2fda" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "LockoutEnd", "PasswordHash" },
                values: new object[] { null, "bdeWk6paX//hcNa8NitdoKS79pTpWPtV9SFZhF5uxJqt/dExn3YkKQOM4fJzpMYI" });

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_PostId",
                table: "Attachment",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_Posts_PostId",
                table: "Attachment",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_Posts_PostId",
                table: "Attachment");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Initiatives");

            migrationBuilder.DropIndex(
                name: "IX_Attachment_PostId",
                table: "Attachment");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06976aeb-2233-4591-9a55-1bf00ba61520"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08dc6c56-1243-4b3a-9d66-a09ec49685c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4968cf0a-036a-4f74-bfe4-b24fdbb48abd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5973cabb-fa1b-40ca-9081-847d47492232"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7164ddac-1966-46f1-99da-62eda65f2cda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86493dcc-3595-43a2-83f5-4469bd2dfb85"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4596d0f-31b7-47a6-b9d4-1c8b8b1cb241"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc8ca7e4-35dc-4ed1-8a41-2b23fb860766"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc2b2edf-ec66-40bc-a864-f32999efd3de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea20214d-e69e-4bbc-868f-529596e36214"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("56f13d74-7afe-410d-bc7f-62acd52c756c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a2a34e68-a880-45b3-a868-f731f390038f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ab8f1928-536f-4068-acd1-258a0f6f50e8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f0d3a31b-1ebb-4b22-b942-ecdc9050ba1b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0f329c06-a920-4cc8-adc5-3a5ddffff41b"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("2e6180fc-e813-4822-bb66-e72ea656259f"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("f6a0c83c-69b8-481c-920e-7d6ec1f1c887"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ffd4fbe6-e361-46f4-a85b-00e569753862"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("2c24f28b-f064-48f3-bf1e-369891dcac9f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("4f29221a-0e8d-4f10-90c0-0fe285ccf54d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5f563a52-ce64-4c0b-9696-b6fe609ff579"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a1393f59-abc5-4005-be32-a51d150d7a17"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c976a642-60b7-40ce-a31b-93ef40ac5ec2"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d637dd52-19ce-4a33-bca7-ce92589fe92e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("5d5e7f0d-0349-421f-b273-0698c4a4fdc4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77ed25c4-f8ca-48a4-acae-bc6bf5f597b6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7c7ffc6d-4323-4f22-b068-3b202d9ebf98"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("89cd5c88-32af-4c5c-b169-0882a4cfd5cd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0f979f2-2ac3-4374-8722-44469dd163a5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d11b4409-ad67-471c-b0d7-6f3ecd33c9e1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc72a8d2-b8c6-42b5-bff7-b705a9273bbb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2dd144bc-8a4b-4db5-8f0f-fcb912faf93d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3255b64e-4b7b-4949-9608-3cf9a6b6ce63"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("419d27b0-951c-4c85-b010-8e5f45ac9762"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("64e9d0be-99c6-4b38-9ad3-7068ac511ae8"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("0ce61777-082c-42f5-824e-4e40f83886ac"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("49177106-28a4-4cb4-8e98-b2a61bfecef2"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7ef76c32-1364-4d8f-89dd-ffdd14facc26"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7f366be1-2a39-4446-96e0-7fd2915914ef"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("b6ea92d5-ebac-4cbf-8ce2-0720f67276ae"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("aa5298b1-d78d-4608-8a29-fdda63c96eec"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e83cb273-49ff-406b-97a1-9ff5f705babd"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("eadb7ea5-97b0-4572-9b4f-1dbd5644eb98"));

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Attachment");

            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Users",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Users",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.CreateTable(
                name: "AttachmentPost",
                columns: table => new
                {
                    AttachmentsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PostsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentPost", x => new { x.AttachmentsId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_AttachmentPost_Attachment_AttachmentsId",
                        column: x => x.AttachmentsId,
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttachmentPost_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03d56106-5458-4634-a9ac-2b63c98d21f4"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("121391ed-b992-4768-93b3-87bb2ca7c29a"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("1e73e38a-4295-4e6e-b756-6d6a658f937e"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("299a1453-669e-4db8-b882-0335598784a8"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("338857c7-aca1-42a4-994c-6ecd87c8e772"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("3efb797e-9e62-4e86-b05e-5037e461be9f"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("52752fd1-6850-4d46-b396-ac94a79a5380"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("8219507a-dc5a-4a02-b8c0-ba7ad1d1e835"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("b3bd33d2-150d-4b9d-bff0-dc257ba3f079"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("dde8c486-12e6-4fca-87a0-8b31bcf70050"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("796fad72-78ac-44bb-a3e1-2f4f3a5299b3"), "CHF", new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(3682), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("815b2eef-ed9c-4acc-a7bb-5a8aab2ad3da"), "USD", new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(3644), 2, true, "US Dollar", "$", null },
                    { new Guid("8b4e227b-1136-4b13-b83d-1655311188d2"), "EUR", new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(2686), 2, true, "Euro", "€", null },
                    { new Guid("b44d5f45-4546-4f46-b964-8307b31cfcfc"), "GBP", new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(3675), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0014142f-aa02-479b-bed1-410b7275b9c9"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(1991), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("1d4dce87-947e-4483-ae34-8ff1729b276e"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(1988), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("9550dee8-5d36-42ec-8407-ed59508a6a53"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(968), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("fc4b405a-5579-4877-8e22-cee84044b62d"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(1982), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16589182-3c84-4c2e-9af8-ee4f33a3022d"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8059), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("5524fb23-d494-4511-961e-b9088806138b"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(6919), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("55a26735-9e42-4a43-ae18-83aac29d8543"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8065), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("5cb67213-fdcf-4719-a897-5147401d75c8"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8053), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("64f25bd2-e453-4d41-a8ba-95d1b3fdd4f8"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8061), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("d8ee0a7a-ceb9-4810-a9eb-7706007d468b"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8063), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("6193ac30-14b2-4c4d-be56-442ae714a47a"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(8992), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1f410b04-92a2-4e72-97e5-f02ec4b0039f"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5890), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("29a914f5-0d34-4aca-a2af-2a8d1090e12b"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5879), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("3475bb84-3db4-4030-8895-cdd6b764938b"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5873), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("3bebe8c9-adcf-47cb-8c87-3a4ee7e9ceeb"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5892), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("413bbb51-64b3-4c52-8c91-667606c2aba4"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(4824), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("bbbf5bb9-deec-4f2a-b705-861e5123ea5e"), new DateTime(2025, 2, 26, 8, 46, 55, 581, DateTimeKind.Utc).AddTicks(5881), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01920b21-024d-4c6b-96f2-91235baf8a33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("07679d34-90b3-4d50-9848-3c2b96a6c1ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null },
                    { new Guid("1fee52c8-5ed1-4218-aa16-a92f6d4ee17c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("73f7bac7-2c73-4869-b782-32a7f0979879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("037a08e2-1b3c-42aa-9865-4ebebb77cf8e"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(5544), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("2988f9fb-364a-4aae-928f-7ed10e181422"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(5539), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("39b77345-c09e-4982-98d3-f6dc9ea26ecf"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(5546), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("5f6d88c8-c02b-419d-b4c3-b57e8d8915ef"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(5548), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("ac5cff22-6ec5-46a7-86c5-f782ba2a47fa"), new DateTime(2025, 2, 26, 8, 46, 55, 582, DateTimeKind.Utc).AddTicks(4380), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 8, 46, 55, 583, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0e7c8fb9-ec48-4db2-a935-01b1fff7a35c"), new DateTime(2025, 2, 26, 8, 46, 55, 583, DateTimeKind.Utc).AddTicks(2805), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("ca75b08f-c5fa-48e5-bc55-fb60642bed4a"), new DateTime(2025, 2, 26, 8, 46, 55, 583, DateTimeKind.Utc).AddTicks(3076), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("e1ffebc9-e2ab-4fbc-9af0-6f5a1929418d"), new DateTime(2025, 2, 26, 8, 46, 55, 583, DateTimeKind.Utc).AddTicks(3082), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "LockoutEnd", "PasswordHash" },
                values: new object[] { null, "2eglRDK78LC4haZrynmOc1dmaf5RooOP+eFO6GcS1/YXWjvZDGS9xkqSy2DuIx46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "LockoutEnd", "PasswordHash" },
                values: new object[] { null, "jO0au6lVKdVs10F8s5J7DYvHcjD/LXI1LCHyHMa1Aozh8T5GS5WZaYlu1pbGVNM6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_8414@example.com", "user_1_8414@example.com", null, "USER_1_8414@EXAMPLE.COM", "USER_1_8414", "diJWpmmujBhDQ6o0IFohPJLPvQStz1ESqDxDlSwQWhl3PuAtJV2JiDUoRUzA8FlW", "user_1_8414@example.com", "user_1_8414" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_225b@example.com", "user_2_225b@example.com", null, "USER_2_225B@EXAMPLE.COM", "USER_2_225B", "7iuGKLN/XkzcMJTqc+Kr1n2X3AzybNRYhtaKkRdK19OpM37x9rlR4adMJlH0fK0E", "user_2_225b@example.com", "user_2_225b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_e36f@example.com", "user_3_e36f@example.com", null, "USER_3_E36F@EXAMPLE.COM", "USER_3_E36F", "KJvTzFbx56ib2mjMLOboRONhcR7sguyJOaKd21DDtfEDR7j7UYO997PMNYFiE7qq", "user_3_e36f@example.com", "user_3_e36f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_3b3b@example.com", "user_4_3b3b@example.com", null, "USER_4_3B3B@EXAMPLE.COM", "USER_4_3B3B", "IhXbUmddQDJMnS74+tSAtObBL59q2SNDcXd/gupqFg75fQ8mRF3MV5DTZS/d+HBk", "user_4_3b3b@example.com", "user_4_3b3b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_dd11@example.com", "user_5_dd11@example.com", null, "USER_5_DD11@EXAMPLE.COM", "USER_5_DD11", "Cu65hyp/K7eKppJjHfm9/+8n1SX56KhC+Jmen7dv3Tgv1STwQE4KDE8XIOiFZDIH", "user_5_dd11@example.com", "user_5_dd11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_239d@example.com", "user_6_239d@example.com", null, "USER_6_239D@EXAMPLE.COM", "USER_6_239D", "3JzCXyP/wTAuSYsZ0EqYpXGKoLfLmjO1YT7lIQvi73wPa269Rj+djogp5D8d3wcF", "user_6_239d@example.com", "user_6_239d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_1c66@example.com", "user_7_1c66@example.com", null, "USER_7_1C66@EXAMPLE.COM", "USER_7_1C66", "FsatcwSSJ3ZKCZIigQSja1HHgtIeEqSNphfBOYbCAiJM2xxTGKDOBwRoeH0Fgonl", "user_7_1c66@example.com", "user_7_1c66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_0c79@example.com", "user_8_0c79@example.com", null, "USER_8_0C79@EXAMPLE.COM", "USER_8_0C79", "V949JdTxn2rA+0pCrXB95NwOjcZdyd3kXZECihHG40ulPGOBEmGqMuFZolYJ/N8z", "user_8_0c79@example.com", "user_8_0c79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_b29b@example.com", "user_9_b29b@example.com", null, "USER_9_B29B@EXAMPLE.COM", "USER_9_B29B", "Yjnz2CwNKX7CRtDTQDSVsSxag+EcMREMhWjfA8UBFG+2vEBW7umVf9Ca7QekxwBR", "user_9_b29b@example.com", "user_9_b29b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_9d1e@example.com", "user_10_9d1e@example.com", null, "USER_10_9D1E@EXAMPLE.COM", "USER_10_9D1E", "G8t3+A4TYHzCth+T1es4Ly6+cEloOjiu5crR4gnBRR5IoK4AEzKj6A7kom85c25b", "user_10_9d1e@example.com", "user_10_9d1e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_f125@example.com", "user_11_f125@example.com", null, "USER_11_F125@EXAMPLE.COM", "USER_11_F125", "qR/EkuzQcJ2ertSsHyszxbDgArgu6THnfd7HSvQGjwVodNLcrG8fRDZ2cDahbHEt", "user_11_f125@example.com", "user_11_f125" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_7be9@example.com", "user_12_7be9@example.com", null, "USER_12_7BE9@EXAMPLE.COM", "USER_12_7BE9", "DAx6BgDq5167rYcNqH1rHqE1DRi2Su3EtIZeuiu4uA7WlQnpHhPk8nSGzunEmF4P", "user_12_7be9@example.com", "user_12_7be9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_3417@example.com", "user_13_3417@example.com", null, "USER_13_3417@EXAMPLE.COM", "USER_13_3417", "AKbkBBhCP30oRHZcR38mOEao31Ol7O5qiWICmTTTJOeddag8D99ot7A5z1QZ76Y6", "user_13_3417@example.com", "user_13_3417" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_e999@example.com", "user_14_e999@example.com", null, "USER_14_E999@EXAMPLE.COM", "USER_14_E999", "IHLMJYJoLXyRRkfeBVbs31O2A4sr7oiUmsooq0EZmmcSSr6cBYqv2bJDpmndcCys", "user_14_e999@example.com", "user_14_e999" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_afcb@example.com", "user_15_afcb@example.com", null, "USER_15_AFCB@EXAMPLE.COM", "USER_15_AFCB", "8YXtfsjM+27sZ2ixS3Hi1o6+zG0DBMxSFk+hL6aNm4HG5IKCLn73N7jCZNr4EMEb", "user_15_afcb@example.com", "user_15_afcb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_a028@example.com", "user_16_a028@example.com", null, "USER_16_A028@EXAMPLE.COM", "USER_16_A028", "nDmmpwqE0vGKW2JNtIe0SMn4Ac32LcDEHbB3yvilTDZpNdpE5zBa284FKXh+B21g", "user_16_a028@example.com", "user_16_a028" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_575a@example.com", "user_17_575a@example.com", null, "USER_17_575A@EXAMPLE.COM", "USER_17_575A", "wro25MbdSugpXG/EHCwTpN4BBzhDwGQ8Y7BAKGHXuQ5ZLl/uztwpvGde6k3oK+xI", "user_17_575a@example.com", "user_17_575a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_e474@example.com", "user_18_e474@example.com", null, "USER_18_E474@EXAMPLE.COM", "USER_18_E474", "vLl4vilrSpnf/6GFHMz7vzBKeUr/ZwvwWj4hH3fJHVHvV6YR4S1R4kKPyLY9SKQB", "user_18_e474@example.com", "user_18_e474" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_6100@example.com", "user_19_6100@example.com", null, "USER_19_6100@EXAMPLE.COM", "USER_19_6100", "2gK20OJS8p6KS8m7pvG5Nz3VGgmXySdX8jCTWyn3pqyE7ao/M5580vNPl4FuOpip", "user_19_6100@example.com", "user_19_6100" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_098a@example.com", "user_20_098a@example.com", null, "USER_20_098A@EXAMPLE.COM", "USER_20_098A", "6V11c1T3FDZZ4sSdvEuWMBDzOllXNDxxnWUiRWr9+MFRt1GvZlIw12+yGwLpcG3o", "user_20_098a@example.com", "user_20_098a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_fb9d@example.com", "user_21_fb9d@example.com", null, "USER_21_FB9D@EXAMPLE.COM", "USER_21_FB9D", "JvnX8PDnRt59+sV16aJ0CF4U68490PhtWQQt1auUnFRdo9lJnz0/Z8G4tn8HS4RZ", "user_21_fb9d@example.com", "user_21_fb9d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_82f4@example.com", "user_22_82f4@example.com", null, "USER_22_82F4@EXAMPLE.COM", "USER_22_82F4", "OTcNlqVBgrJLQ1x/kSUbhheqJy5Ngz4MdHQFggcVEdXP2IqDavfZJ1P2CIhm0dzN", "user_22_82f4@example.com", "user_22_82f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_fe48@example.com", "user_23_fe48@example.com", null, "USER_23_FE48@EXAMPLE.COM", "USER_23_FE48", "rKGZ9FMDsb3Hf0TZUicVdnQLTp1lvK1aCZ5X5djXJ8Fbnd283IZbe1VlsoFzZufU", "user_23_fe48@example.com", "user_23_fe48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_6118@example.com", "user_24_6118@example.com", null, "USER_24_6118@EXAMPLE.COM", "USER_24_6118", "TJwaIGhM9R1PYKJFxNvc6ErJt7DVn6+XbMpzeZLohoG4X+9XEJJku0bRtVK+ylNg", "user_24_6118@example.com", "user_24_6118" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_fd2c@example.com", "user_25_fd2c@example.com", null, "USER_25_FD2C@EXAMPLE.COM", "USER_25_FD2C", "0Wp3c0pWjonEIckHuJ3I84B/OXkKbvzQQMZhSp0Nh1yT/UehajrtTTClVot7HEgQ", "user_25_fd2c@example.com", "user_25_fd2c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_74e2@example.com", "user_26_74e2@example.com", null, "USER_26_74E2@EXAMPLE.COM", "USER_26_74E2", "J36yQvRge51D7jdlxX2CkgMFR84QUBt/fc163r9Wz8Y+U3QbwWztVJHdRfYNZa+b", "user_26_74e2@example.com", "user_26_74e2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_aced@example.com", "user_27_aced@example.com", null, "USER_27_ACED@EXAMPLE.COM", "USER_27_ACED", "h3j82f7Olc6Ek4rEb6ZnN8oO2HjHAuoE1iilbpYiqtA/W/7Y6LVtZw96nilxHT6r", "user_27_aced@example.com", "user_27_aced" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_9573@example.com", "user_28_9573@example.com", null, "USER_28_9573@EXAMPLE.COM", "USER_28_9573", "q2oE7AL95cz8e43fjNkSvJy8LPt+4Y8h5hCGce59rlg0fjQ/VrM11qkYXMdQlLNg", "user_28_9573@example.com", "user_28_9573" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_8b86@example.com", "user_29_8b86@example.com", null, "USER_29_8B86@EXAMPLE.COM", "USER_29_8B86", "I7YsYm0E07mC7bLTWHfIdHifofVsLH95EyBzFC7zShBzJttw0EGUHyIvaWb3IxpR", "user_29_8b86@example.com", "user_29_8b86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_d639@example.com", "user_30_d639@example.com", null, "USER_30_D639@EXAMPLE.COM", "USER_30_D639", "hlNxifdC24rQlvyeDD96XI8jk2TQ7m1PVajniPLzH0i6wgYaLT8VjcFf4iPM18q9", "user_30_d639@example.com", "user_30_d639" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_3e53@example.com", "user_31_3e53@example.com", null, "USER_31_3E53@EXAMPLE.COM", "USER_31_3E53", "z8CoIuKMpWyoFBjtrHOGKbaK3UnMbdu+/sWa3lDuUHaw6Uj1Xh1pMo23adxNNFB6", "user_31_3e53@example.com", "user_31_3e53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_4114@example.com", "user_32_4114@example.com", null, "USER_32_4114@EXAMPLE.COM", "USER_32_4114", "568jXMRIO6/4indsJJUg4jN1STEAhmldI0cQ9Y/VqeOTPW3VjzHiasQfXjE0mTRi", "user_32_4114@example.com", "user_32_4114" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_4f7c@example.com", "user_33_4f7c@example.com", null, "USER_33_4F7C@EXAMPLE.COM", "USER_33_4F7C", "wohaiHIXUlIoeyG5HlpCgxEMjqD0VgyXWFJxGPBiEKmoOWXIMJXxDddURbCd6ugM", "user_33_4f7c@example.com", "user_33_4f7c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_7587@example.com", "user_34_7587@example.com", null, "USER_34_7587@EXAMPLE.COM", "USER_34_7587", "fqvf5gLLFMTnDU2fRsK1trFy9mJVbPtGQd4i5cKkeuLavODm7yIk5KEkfoOSUewS", "user_34_7587@example.com", "user_34_7587" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_57f9@example.com", "user_35_57f9@example.com", null, "USER_35_57F9@EXAMPLE.COM", "USER_35_57F9", "hhFh3mBiDZWmLaPh9UN2k/UqIVxklf3p2L14kDCwOiquGdKn/bB54xL5/4Ma5SkO", "user_35_57f9@example.com", "user_35_57f9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_bf10@example.com", "user_36_bf10@example.com", null, "USER_36_BF10@EXAMPLE.COM", "USER_36_BF10", "EMnZgFJ2wJ1gcX9xG3KNNidWyzhXQq4qYB4W2X8qFBo9Z/GdDicE3mPKjZIOuxZJ", "user_36_bf10@example.com", "user_36_bf10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_713d@example.com", "user_37_713d@example.com", null, "USER_37_713D@EXAMPLE.COM", "USER_37_713D", "PQB8Wzxq2UgPQDXdc4UBzKXQdsAgtMM6net3Fx8krmxunx7lsiY7A65O8I0ZBWZN", "user_37_713d@example.com", "user_37_713d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_abd4@example.com", "user_38_abd4@example.com", null, "USER_38_ABD4@EXAMPLE.COM", "USER_38_ABD4", "FTG36Tz6RZfb9klFPcKJLnLdaqoJbs02qOdBnx6WB4Px47WG0mS8hoDA6tIg8Uaa", "user_38_abd4@example.com", "user_38_abd4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_dd7d@example.com", "user_39_dd7d@example.com", null, "USER_39_DD7D@EXAMPLE.COM", "USER_39_DD7D", "Y+wka8WuAqYWjuuFJY3SWXzmWnya/15DHssX4mGgEo+68x6o1Y741ONt9igBMlYl", "user_39_dd7d@example.com", "user_39_dd7d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_685d@example.com", "user_40_685d@example.com", null, "USER_40_685D@EXAMPLE.COM", "USER_40_685D", "h18KUK1S4S5U5seuLe6RxXJ6YCBtRUs4uH5msZP2QfXi96c/SHY+/5RnAr9Ge9J9", "user_40_685d@example.com", "user_40_685d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_6ec2@example.com", "user_41_6ec2@example.com", null, "USER_41_6EC2@EXAMPLE.COM", "USER_41_6EC2", "fZGUFBwBjry0GVIgr4UG3rAu5l+TimDEtWqJPY1jT3BhqOzCLTYJvlDCQWfqBAFe", "user_41_6ec2@example.com", "user_41_6ec2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_d7e9@example.com", "user_42_d7e9@example.com", null, "USER_42_D7E9@EXAMPLE.COM", "USER_42_D7E9", "SGueps9XgbXgE7+JRMwvK4fpziqRiqqmXhg7n3lcENLCHdx+gfo+T6Q/Uw8of6WT", "user_42_d7e9@example.com", "user_42_d7e9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_ddb4@example.com", "user_43_ddb4@example.com", null, "USER_43_DDB4@EXAMPLE.COM", "USER_43_DDB4", "T7AyP2llSeHusNOSEea5k2uqkRbR6J5XC/jwcxfzdfcO5Otpp7RndSES2IvX9EpJ", "user_43_ddb4@example.com", "user_43_ddb4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_7025@example.com", "user_44_7025@example.com", null, "USER_44_7025@EXAMPLE.COM", "USER_44_7025", "c4kdS9Mt2W5LFtQbDiCs+NUxV4Kd0+Oou2WBZLH/1os9FCZjWpcyVR05/bgOZUjk", "user_44_7025@example.com", "user_44_7025" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_fe9a@example.com", "user_45_fe9a@example.com", null, "USER_45_FE9A@EXAMPLE.COM", "USER_45_FE9A", "cuq0drW4773ycBbQb//Jf8JdyKbhGqZbA8BZuT1BvBwcOeZVfnsDod3AJ7ODjgtA", "user_45_fe9a@example.com", "user_45_fe9a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_4eb8@example.com", "user_46_4eb8@example.com", null, "USER_46_4EB8@EXAMPLE.COM", "USER_46_4EB8", "4k5g318JivTJYdP1XEZwZRcHzOMZeSh6+0dFjd0AtFbBN3/16y49KMnrXoZjGtuf", "user_46_4eb8@example.com", "user_46_4eb8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_c723@example.com", "user_47_c723@example.com", null, "USER_47_C723@EXAMPLE.COM", "USER_47_C723", "8wEPjdUitjS5izbFXNgh586qPWC2CGAmAAEcMYBgG7MpqM15LU6jvb+MgGCLpKzz", "user_47_c723@example.com", "user_47_c723" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_5591@example.com", "user_48_5591@example.com", null, "USER_48_5591@EXAMPLE.COM", "USER_48_5591", "iS0G/2ewwIOLl3VkWTDgN62pUPb2JmNVT3mLQ7Ia87B1CS7FwDaBxS2hVfhdBD3/", "user_48_5591@example.com", "user_48_5591" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_58b4@example.com", "user_49_58b4@example.com", null, "USER_49_58B4@EXAMPLE.COM", "USER_49_58B4", "H3c9/HTMWmdwmXp5u4aoMSx33WXAcJoFm1DkueXPTJhgG7joR27S3bIwKaYCtx6+", "user_49_58b4@example.com", "user_49_58b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_23e7@example.com", "user_50_23e7@example.com", null, "USER_50_23E7@EXAMPLE.COM", "USER_50_23E7", "HuGq0ZjpjtbZKYvZuucmSOcrM4rjhYcjgfz7RIhVZKzx4bxAr8Pa6G4zJNCJMolN", "user_50_23e7@example.com", "user_50_23e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "LockoutEnd", "PasswordHash" },
                values: new object[] { null, "FbJXQ7XOvSrmQeqm0VkXF0NNDCozdx5693yLqqhF1G8qXhWVuEs2Vly9CiLTAW7G" });

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentPost_PostsId",
                table: "AttachmentPost",
                column: "PostsId");
        }
    }
}
