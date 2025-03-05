using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPostRelatedPostRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostAttachment_MarkdownFiles_AttachmentId",
                table: "PostAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_Users_CommenterId",
                table: "PostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostRelatedPost_Posts_PostId",
                table: "PostRelatedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Posts_PostId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostRelatedPost",
                table: "PostRelatedPost");

            migrationBuilder.DropIndex(
                name: "IX_PostRelatedPost_PostId",
                table: "PostRelatedPost");

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

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"));

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "PostComment");

            migrationBuilder.RenameColumn(
                name: "IsPausedTo",
                table: "Projects",
                newName: "PausedUntil");

            migrationBuilder.RenameColumn(
                name: "IsExtendedTo",
                table: "Projects",
                newName: "ExtendedUntil");

            migrationBuilder.RenameColumn(
                name: "IsCompletedBy",
                table: "Projects",
                newName: "CompletedBy");

            migrationBuilder.RenameColumn(
                name: "IsCompletedAt",
                table: "Projects",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "IsCancelledby",
                table: "Projects",
                newName: "CancelledBy");

            migrationBuilder.RenameColumn(
                name: "IsCancelledAt",
                table: "Projects",
                newName: "CompletedAt");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PostRelatedPost",
                newName: "RelatedPostId");

            migrationBuilder.RenameColumn(
                name: "CommenterId",
                table: "PostComment",
                newName: "CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_PostComment_CommenterId",
                table: "PostComment",
                newName: "IX_PostComment_CommentId");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Topics",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Slug",
                keyValue: null,
                column: "Slug",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Topics",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Topics",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Topics",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Topics",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Topics",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Topics",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Topics",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "CommentId",
                table: "Tags",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Tags",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Tags",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Tags",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Tags",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Tags",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tags",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "PostId",
                table: "Tags",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Tags",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Roles",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Roles",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Roles",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Roles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Roles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Roles",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Roles",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledAt",
                table: "Projects",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Projects",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Projects",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Projects",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Projects",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Projects",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Projects",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProjectMembers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProjectMembers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProjectMembers",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "ProjectMembers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "ProjectMembers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProjectMembers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProjectMembers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProjectMembers",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProjectMembers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProgressHistories",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProgressHistories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProgressHistories",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "ProgressHistories",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "ProgressHistories",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProgressHistories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProgressHistories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PrivacyPreferences",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "PrivacyPreferences",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "PrivacyPreferences",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "PrivacyPreferences",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PrivacyPreferences",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PrivacyPreferences",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "PrivacyPreferences",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PostTags",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "CreatedBy",
                keyValue: null,
                column: "CreatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Posts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Posts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "LinkedAt",
                table: "PostLink",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AssignedAt",
                table: "PostCategory",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                table: "PostCategory",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AttachedAt",
                table: "PostAttachment",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                table: "PostAttachment",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "MarkdownFiles",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "MarkdownFiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "MarkdownFiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "MarkdownFiles",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MarkdownFiles",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MarkdownFileHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MarkdownFileHistories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "MarkdownFileHistories",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "MarkdownFileHistories",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "MarkdownFileHistories",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "MarkdownFileHistories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MarkdownFileHistories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MarkdownFileHistories",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "MarkdownFileHistories",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Link",
                keyColumn: "Url",
                keyValue: null,
                column: "Url",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Link",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Link",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Link",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Link",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Link",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Link",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Initiatives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Initiatives",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "Initiatives",
                keyColumn: "CreatedBy",
                keyValue: null,
                column: "CreatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Initiatives",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Initiatives",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Initiatives",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Initiatives",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Initiatives",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "GeographicalPreferences",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "GeographicalPreferences",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "GeographicalPreferences",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "GeographicalPreferences",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "GeographicalPreferences",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "GeographicalPreferences",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "GeographicalPreferences",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FileFormats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "FileFormats",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "FileFormats",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "FileFormats",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FileFormats",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "FileFormats",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DateFormats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DateFormats",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "DateFormats",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "DateFormats",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DateFormats",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "DateFormats",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Comment",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Text",
                keyValue: null,
                column: "Text",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Comment",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentCommentId",
                table: "Comment",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Comment",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Category",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Category",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Category",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Category",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Category",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Category",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Category",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Category",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Attachment",
                keyColumn: "Url",
                keyValue: null,
                column: "Url",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Attachment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Attachment",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Attachment",
                keyColumn: "FileName",
                keyValue: null,
                column: "FileName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Attachment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Attachment",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Attachment",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Assignments",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Assignments",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "CreatedBy",
                keyValue: null,
                column: "CreatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Assignments",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Assignments",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Assignments",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Assignments",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Assignments",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostRelatedPost",
                table: "PostRelatedPost",
                columns: new[] { "PostId", "RelatedPostId" });

            migrationBuilder.CreateTable(
                name: "PostTopic",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TopicId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
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
                    table.PrimaryKey("PK_PostTopic", x => new { x.PostId, x.TopicId });
                    table.ForeignKey(
                        name: "FK_PostTopic_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTopic_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("178fb5c9-0e15-4590-853d-60f1a6254722"), "Luxembourg", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("1f97ec75-15b1-43c0-8e92-fbcf8adcfad4"), "Brussels", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("33cc27d0-453b-490c-a84c-0463ba6cc55e"), "Berlin", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("49703bb1-5422-45f4-8350-c38bc715c34d"), "Paris", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("49dc1c42-25c3-4773-9e25-844fed18e64d"), "Vienna", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("62308f13-07f3-498e-9103-41b5ef334450"), "Amsterdam", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("6232278d-e7b7-46ad-832d-b19e178a5e65"), "Rome", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("acc0e240-2422-4cbd-98b5-df581430b10e"), "London", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("e214a56d-c348-4cbe-bf7a-e4c798ae7495"), "Madrid", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("ea7567dd-11db-4414-877b-df4c2c216c86"), "Bern", new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0afb6230-629a-425c-84e6-a448f12c13fe"), "GBP", new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(9227), 2, true, "British Pound", "£", null },
                    { new Guid("29242680-ba1e-4d6e-8854-8fd194f28166"), "USD", new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(9214), 2, true, "US Dollar", "$", null },
                    { new Guid("5b6fbb5a-6ba5-4d4b-aaa1-6104430f6443"), "CHF", new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(9230), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("f4613664-22ae-4f2c-8d01-be6260b38c39"), "EUR", new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(8204), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("59cb0ed6-bac1-4af4-adc5-2819c0f02eda"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(7393), "System", null, null, null, "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, false, null, null },
                    { new Guid("94c93979-b739-41ab-9be2-5cbbfb639c76"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(7385), "System", null, null, null, "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, false, null, null },
                    { new Guid("b1d971b5-7c2b-4fef-b4ae-ed26829d49e4"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(6189), "System", null, null, null, "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, false, null, null },
                    { new Guid("f44fd3dc-5878-46fc-b822-df3348435779"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(7390), "System", null, null, null, "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "Extension", "IsActive", "IsDefault", "IsDeleted", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ed17047-9715-4031-b5cb-d9020eda4654"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2903), "System", null, null, null, "JavaScript source code file", ".js", true, false, false, 10, "application/javascript", "JavaScript", true, false, null, null },
                    { new Guid("19607e5f-6efa-45fe-94fc-eb503849b6c1"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2906), "System", null, null, null, "JavaScript Object Notation data file", ".json", true, false, false, 10, "application/json", "JSON", true, false, null, null },
                    { new Guid("21ebfdaa-fd22-44b5-9b1e-02f3256a842a"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2850), "System", null, null, null, "TypeScript React component file", ".tsx", true, false, false, 10, "application/typescript+react", "TypeScript React", true, false, null, null },
                    { new Guid("6d99caca-5806-4be8-b6f1-d7c23c1af2d5"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2909), "System", null, null, null, "Markdown text format", ".md", true, false, false, 10, "text/markdown", "Markdown", true, false, null, null },
                    { new Guid("89b14cc1-7c20-4acc-ab30-3bb970fcb6d2"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(2846), "System", null, null, null, "TypeScript source code file", ".ts", true, false, false, 10, "application/typescript", "TypeScript", true, false, null, null },
                    { new Guid("928a387d-40d1-4212-94b3-5d2e34a4334c"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(1587), "System", null, null, null, "Simple text document format", ".txt", true, false, false, 10, "text/plain", "Plain Text", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("48cb7ade-f2bb-4426-8d02-b912876e4cca"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(4061), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("03d2cf8f-beb8-4455-ade0-efc5635e5c6a"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(575), "System", null, null, null, "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", true, false, "Editor", null, null },
                    { new Guid("4fbba298-ccbc-4f2d-b394-ff33b23fe274"), new DateTime(2025, 3, 4, 15, 39, 6, 393, DateTimeKind.Utc).AddTicks(9539), "System", null, null, null, "Admin role has full administrative privileges, except for application management.", true, false, "Admin", null, null },
                    { new Guid("61e4acc8-fc16-43e3-80ac-80bda54b2cfb"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(569), "System", null, null, null, "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", true, false, "User", null, null },
                    { new Guid("b4d0e151-3155-4508-9ee7-5110e74b2ce1"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(579), "System", null, null, null, "Has full control over the application and can manage all aspects.", true, false, "SuperAdmin", null, null },
                    { new Guid("b53b026d-ae7b-497c-a851-e02c4fba9892"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(565), "System", null, null, null, "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", true, false, "Moderator", null, null },
                    { new Guid("fb62843b-9af4-4be7-ac4d-5bae89f98695"), new DateTime(2025, 3, 4, 15, 39, 6, 394, DateTimeKind.Utc).AddTicks(572), "System", null, null, null, "Guest role is the least privileged role. They can only view public articles.", true, false, "Guest", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CommentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "PostId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4245e448-8c62-45dd-961d-29892f7eb482"), null, new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(6827), "System", null, null, null, "Test Tag description 3", true, false, "Test Tag name 3", null, "test-tag-slug-3", null, null },
                    { new Guid("8e21f077-05a1-4fce-ab74-6967fd7e4eec"), null, new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(6823), "System", null, null, null, "Test Tag description 2", true, false, "Test Tag name 2", null, "test-tag-slug-2", null, null },
                    { new Guid("cff3246d-a9c3-4807-811d-a8a23eb0cfb7"), null, new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(6835), "System", null, null, null, "Test Tag description 4", true, false, "Test Tag name 4", null, "test-tag-slug-4", null, null },
                    { new Guid("fc4840eb-149b-4b6d-afaa-3c13376c3694"), null, new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(6053), "System", null, null, null, "Test Tag description", true, false, "Test Tag name", null, "test-tag-slug", null, null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("04405d90-002a-4f4f-9d90-33a4a086f334"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(1430), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("71839c3f-b9eb-435b-a3e2-d770ed71f5e1"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(1432), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("c2bb72b8-ee0e-4233-9206-da0a1f040fc1"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(48), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("f1860167-41bf-4f7b-8cea-0e5022a98c25"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(1423), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("f378bf36-407d-4e6d-b07e-5a0c64fb7c01"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(1434), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), new DateTime(2025, 3, 4, 15, 39, 6, 395, DateTimeKind.Utc).AddTicks(9315), "System", null, null, null, "Test Topic description", true, false, "Test Topic name", null, "test-topic-slug", null, null },
                    { new Guid("33bd44b3-77b1-4387-91fc-89dfe23cc74b"), new DateTime(2025, 3, 4, 15, 39, 6, 396, DateTimeKind.Utc).AddTicks(544), "System", null, null, null, "Test Topic description 3", true, false, "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "pBJO16ZRczDcsw7FaG1xmMsy0zfjB4vHQirDRcIw2zB43qADu0P3PNBPiLUkwE9A");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "+7hN3xXgEpCAr6b4IV/Dwou/jjHRbGi24sUvn7YEgY/cBH2q6GIByRzD1HfEDmSM");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_896b@example.com", "user_1_896b@example.com", "USER_1_896B@EXAMPLE.COM", "USER_1_896B", "IeXh6bndC0xxyMCBjDviM4cl0EHB0QB6aSfz2uWTe+TR7uAZgcDhXZ49IwEIFqjw", "user_1_896b@example.com", "user_1_896b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_bf21@example.com", "user_2_bf21@example.com", "USER_2_BF21@EXAMPLE.COM", "USER_2_BF21", "mMGexvN+vZne5JnXekyNGtjDx1sCVmZL0kUZPwdSVp0MqtrGlhSLD9EpezmdJzba", "user_2_bf21@example.com", "user_2_bf21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_0be1@example.com", "user_3_0be1@example.com", "USER_3_0BE1@EXAMPLE.COM", "USER_3_0BE1", "rnIyZtmtVAM52XYp67QhyrZY0l7ghT4bQ9zWwZ+C+jotha5mUEX9KM7Qrhyc0Oyg", "user_3_0be1@example.com", "user_3_0be1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_32ea@example.com", "user_4_32ea@example.com", "USER_4_32EA@EXAMPLE.COM", "USER_4_32EA", "KsjOSwrhIUzq96yRBNEIkAIkP1NacE4T6urJVM3Bo74gF5eAgYRd++JHKDJEHR9b", "user_4_32ea@example.com", "user_4_32ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_2889@example.com", "user_5_2889@example.com", "USER_5_2889@EXAMPLE.COM", "USER_5_2889", "Sx9h4ySHPULmFAIhAlQ7qbx7Yo/EBksB8OuA6RNMdikTqFSX8O7C4uEy7yeCzwKf", "user_5_2889@example.com", "user_5_2889" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_3e29@example.com", "user_6_3e29@example.com", "USER_6_3E29@EXAMPLE.COM", "USER_6_3E29", "CR4ujjFPrn5sIzTnWWlMh8FBndWfZbJW0ZdfYzjWbXOiZmc15/HZoS3Un2BtRDHE", "user_6_3e29@example.com", "user_6_3e29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_47b1@example.com", "user_7_47b1@example.com", "USER_7_47B1@EXAMPLE.COM", "USER_7_47B1", "rBlJ63Zm5OdLQSuR2gkT5V09WtVdWVaAXV+tzK7jnILAUYdA0TgJup3096tgSFhV", "user_7_47b1@example.com", "user_7_47b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_fda4@example.com", "user_8_fda4@example.com", "USER_8_FDA4@EXAMPLE.COM", "USER_8_FDA4", "ze1jkMRYfdvyO6e0W2fq82KVkqipe7EwF7Qrm1gGk4qLA4IHyUdNVKo2NWq0TEeZ", "user_8_fda4@example.com", "user_8_fda4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_da72@example.com", "user_9_da72@example.com", "USER_9_DA72@EXAMPLE.COM", "USER_9_DA72", "WF4bf9zIO/DSMTtjiEi5UUK8PLs+ayUSzD7/6d2etUUxw0fwBQN9uZm53TOhjxDU", "user_9_da72@example.com", "user_9_da72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_57b0@example.com", "user_10_57b0@example.com", "USER_10_57B0@EXAMPLE.COM", "USER_10_57B0", "fd0uYVp5FWuVq3SUUz/wxBObQdBOgiKucFzemob2GpTRM+wWa1c+jE2kyZmAfPXV", "user_10_57b0@example.com", "user_10_57b0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_56cc@example.com", "user_11_56cc@example.com", "USER_11_56CC@EXAMPLE.COM", "USER_11_56CC", "/m+ZaWx+HmUQOo1txRt+M3m0Iahg2R6ZNlA20on5FBMippnC6TPr+K5EQhva21lL", "user_11_56cc@example.com", "user_11_56cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_3dec@example.com", "user_12_3dec@example.com", "USER_12_3DEC@EXAMPLE.COM", "USER_12_3DEC", "OK4hcbZVadEB45y8jqn/6Zk1dxGvjY2Rs3POTCjv4Mm9qqIfTvolnBjXqbLeKSei", "user_12_3dec@example.com", "user_12_3dec" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_88a1@example.com", "user_13_88a1@example.com", "USER_13_88A1@EXAMPLE.COM", "USER_13_88A1", "VEWK9shyhD0gDAFDC5CsdrI9Nmf1gkF7PpaxeZwSacYvGHgFdbHuRk6g+BqZKGL+", "user_13_88a1@example.com", "user_13_88a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_debe@example.com", "user_14_debe@example.com", "USER_14_DEBE@EXAMPLE.COM", "USER_14_DEBE", "sJ52sSso1mRoV7t5A4xpFm+lkwlHGnlfwmHeMXJFqWg65i4dVcO5LTrarPTVUbIR", "user_14_debe@example.com", "user_14_debe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_c5bf@example.com", "user_15_c5bf@example.com", "USER_15_C5BF@EXAMPLE.COM", "USER_15_C5BF", "ZnLU1k+ZcUI07TfnE/IAMTK6+GE4mgXAyjRtoCwUCGh6bLkar355fVz+tNcLgkmt", "user_15_c5bf@example.com", "user_15_c5bf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_4142@example.com", "user_16_4142@example.com", "USER_16_4142@EXAMPLE.COM", "USER_16_4142", "rRwe+VqApBR/lSsrkOpcZ1UKz5RuL3Qr6ToEV0WXr1MWWDYHEnSA4JYp0BoJfOyQ", "user_16_4142@example.com", "user_16_4142" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_bc80@example.com", "user_17_bc80@example.com", "USER_17_BC80@EXAMPLE.COM", "USER_17_BC80", "mkkaDosje8sb0Dn09ly5EDgOqCnQeCGxHR+vQBoqa2sVTYEB1fcFFb3Ia/D5JAfT", "user_17_bc80@example.com", "user_17_bc80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_3588@example.com", "user_18_3588@example.com", "USER_18_3588@EXAMPLE.COM", "USER_18_3588", "zO9r/cAceL1klt6IP6Wm7t26fLo0iNi3R96Q90isUmmBufk3f+vXmAg7WfuUAM17", "user_18_3588@example.com", "user_18_3588" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_dca4@example.com", "user_19_dca4@example.com", "USER_19_DCA4@EXAMPLE.COM", "USER_19_DCA4", "OfNuA1WcWyOuQuZCcyc2amsXvIkwO+aY3EkZ+JTH9JCuYZ6aOU3bhRru/dL5prEK", "user_19_dca4@example.com", "user_19_dca4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_7868@example.com", "user_20_7868@example.com", "USER_20_7868@EXAMPLE.COM", "USER_20_7868", "M9MDtnudq0Tjsj4gO2+kRAgfDlOspZ89XKukvlstOPJ9pq/fyd+wRPW9V2ktWNEu", "user_20_7868@example.com", "user_20_7868" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_53f6@example.com", "user_21_53f6@example.com", "USER_21_53F6@EXAMPLE.COM", "USER_21_53F6", "aCKZc6ZntRiBKLOrF9nE71kCfUE+e9YHrzuKCWjhaGBRwmuWsykEGeRUr4a0ZWTQ", "user_21_53f6@example.com", "user_21_53f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_3adf@example.com", "user_22_3adf@example.com", "USER_22_3ADF@EXAMPLE.COM", "USER_22_3ADF", "1EW7Wdlanm4E/Eu2/11epSb+gauk6XZmj+SdsNQcSB1rw7lmKhg6jQ9Fm0xWtyN3", "user_22_3adf@example.com", "user_22_3adf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_de6d@example.com", "user_23_de6d@example.com", "USER_23_DE6D@EXAMPLE.COM", "USER_23_DE6D", "bLCtiP5cTPS1RMyKQ5gabkRHK44k6hFKMaNhfBHd13r/5zOou4iHLD7Aepat/Fxl", "user_23_de6d@example.com", "user_23_de6d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_bb5c@example.com", "user_24_bb5c@example.com", "USER_24_BB5C@EXAMPLE.COM", "USER_24_BB5C", "ToI43Cdn/IBx8Wy7z7cZukrhwt2VvSruOQaAeQWsai0mfCUM08oBQlMltJ561Xp3", "user_24_bb5c@example.com", "user_24_bb5c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_4abf@example.com", "user_25_4abf@example.com", "USER_25_4ABF@EXAMPLE.COM", "USER_25_4ABF", "eQUhbCBGhnM1qd/E8XdosaxY7FDmb2Qa5wSAi0ZiAx+VGQwqwo2hKZ163Xtv7Bdy", "user_25_4abf@example.com", "user_25_4abf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_c9f2@example.com", "user_26_c9f2@example.com", "USER_26_C9F2@EXAMPLE.COM", "USER_26_C9F2", "3IZCYi0gYyy9sWdlAIIqryTdh56lhDeFWnawtNKMJzYZTaOgzoXLh2F5XnRrdwAq", "user_26_c9f2@example.com", "user_26_c9f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_9dfe@example.com", "user_27_9dfe@example.com", "USER_27_9DFE@EXAMPLE.COM", "USER_27_9DFE", "VyOSEHhdYzHYygeoxjGiVlI6BVFcGorPtXU1IZ6exJAtIjwrll+8peaZq3qL/TGX", "user_27_9dfe@example.com", "user_27_9dfe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_6a7f@example.com", "user_28_6a7f@example.com", "USER_28_6A7F@EXAMPLE.COM", "USER_28_6A7F", "1F817PGCTBgWRANTkdFM2SYr9xjh3yLoxQJ1pl6UofdkJP4D3r+3Tu8R0QieYGue", "user_28_6a7f@example.com", "user_28_6a7f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_3d12@example.com", "user_29_3d12@example.com", "USER_29_3D12@EXAMPLE.COM", "USER_29_3D12", "O3x9xZ6IWZGzYX724bQiNlozWEmPoqBRkJk1u/oa8I4aVryXVxSt05BdL8P3mcig", "user_29_3d12@example.com", "user_29_3d12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_1639@example.com", "user_30_1639@example.com", "USER_30_1639@EXAMPLE.COM", "USER_30_1639", "esz+Mnsin+pljtYPoW9Xc5vBHa8PeXCziGp3WYG6W4YLCwaKYFJTSGSrW6U1s9rz", "user_30_1639@example.com", "user_30_1639" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_d3b0@example.com", "user_31_d3b0@example.com", "USER_31_D3B0@EXAMPLE.COM", "USER_31_D3B0", "YELgst2a7OYX3CA3N+IQPrb5ml4D5bPDgOGuUDwDW5wF4g3e9TxWE+ND+vqcqII2", "user_31_d3b0@example.com", "user_31_d3b0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_3926@example.com", "user_32_3926@example.com", "USER_32_3926@EXAMPLE.COM", "USER_32_3926", "OZ4nEs2mQ1EtkXeG5h28L8ZNq4yo9O3uVAPTtZ0v48mUPPzJ0Zbcdknj1kpmH45t", "user_32_3926@example.com", "user_32_3926" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_1305@example.com", "user_33_1305@example.com", "USER_33_1305@EXAMPLE.COM", "USER_33_1305", "tTOSZJupBW9CzxAZlN20aR1kEOMkw1ec9ZAru3svm0XWX4qD+OsbuBHhl0zCJw4r", "user_33_1305@example.com", "user_33_1305" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_1f71@example.com", "user_34_1f71@example.com", "USER_34_1F71@EXAMPLE.COM", "USER_34_1F71", "aQuuEFumeXtBMkAntpRgl7y2gOsmDARHAH/iv6Px1/1PaOzy4M+yuZNZz6cZsM4P", "user_34_1f71@example.com", "user_34_1f71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_1017@example.com", "user_35_1017@example.com", "USER_35_1017@EXAMPLE.COM", "USER_35_1017", "bEWiFExXreyabXbAziAyJZytP8tug2THafKp4JO+Qs4bp51llh4lRNY0EWAD5Ihj", "user_35_1017@example.com", "user_35_1017" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_3652@example.com", "user_36_3652@example.com", "USER_36_3652@EXAMPLE.COM", "USER_36_3652", "GjB54KJWGcKNitUGoA29RyLpnTyJWyPeVc4A4FwdPL1Q5elc6/plEtPQ1c545mR/", "user_36_3652@example.com", "user_36_3652" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_4eab@example.com", "user_37_4eab@example.com", "USER_37_4EAB@EXAMPLE.COM", "USER_37_4EAB", "qmBprZFQCbfHhc0Z7Mnt2iKnyiZtO2Z3Mw1fpzHvJPTn+1z4Y38Iloepa+I7rxBt", "user_37_4eab@example.com", "user_37_4eab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_190e@example.com", "user_38_190e@example.com", "USER_38_190E@EXAMPLE.COM", "USER_38_190E", "9Jp1RmEhq88L2y5QHFEnRIpTbcpLbA3CEy/IHdmdy4e81EN3DJn3HoD6ktt2MTKN", "user_38_190e@example.com", "user_38_190e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_53ba@example.com", "user_39_53ba@example.com", "USER_39_53BA@EXAMPLE.COM", "USER_39_53BA", "LYXdIWFff5e+uOgYn0+3kp+c4MTWRhUunCTWJ3fo0Sp3Pfmh35WZkWreiwT1be8C", "user_39_53ba@example.com", "user_39_53ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_c5a4@example.com", "user_40_c5a4@example.com", "USER_40_C5A4@EXAMPLE.COM", "USER_40_C5A4", "C9sOMGH8ziKqW2UeVjbwsDgHimEa19aT1fQwn3StdXVfZJJjhtUm0u1dI/X1KzPD", "user_40_c5a4@example.com", "user_40_c5a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_da8a@example.com", "user_41_da8a@example.com", "USER_41_DA8A@EXAMPLE.COM", "USER_41_DA8A", "k/xo4rJPa7PlMuuBdzaWngflhPTctR+0U/QtOk23qQiWDCbRxEo/PrsjlwdfwQlj", "user_41_da8a@example.com", "user_41_da8a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_ea20@example.com", "user_42_ea20@example.com", "USER_42_EA20@EXAMPLE.COM", "USER_42_EA20", "SUSEaOKtXCI08nhdUfzYPNpBn/UjNyW//np42TMpHexoX2kJownT4ETZDXHvTbj2", "user_42_ea20@example.com", "user_42_ea20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_7fa1@example.com", "user_43_7fa1@example.com", "USER_43_7FA1@EXAMPLE.COM", "USER_43_7FA1", "C6s9RVGLluhJAvPcWs6mMN2ktnqs42qQJdGAiPawT3oq00608cpcbBZYt80l0dCv", "user_43_7fa1@example.com", "user_43_7fa1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_594c@example.com", "user_44_594c@example.com", "USER_44_594C@EXAMPLE.COM", "USER_44_594C", "LGEs+TUNW7UB+mCvmkYAHjw7tD9d9k/4wDl1NZ1y9HVlI7w4rNqkXaujZtMSl1hs", "user_44_594c@example.com", "user_44_594c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_cab6@example.com", "user_45_cab6@example.com", "USER_45_CAB6@EXAMPLE.COM", "USER_45_CAB6", "0Lt914cDw62yNm6jrFhB2+0IOOk73pRE4qaD2YZF+xXE8W8u5ZOYxpG9XGGYIFj8", "user_45_cab6@example.com", "user_45_cab6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_7d3e@example.com", "user_46_7d3e@example.com", "USER_46_7D3E@EXAMPLE.COM", "USER_46_7D3E", "8pIngPE+FWxNKszTgJp30jPo+wQ/tZpQezxAbwZxrFVlgv6uzy6i60l7GqGU6mDu", "user_46_7d3e@example.com", "user_46_7d3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_7e67@example.com", "user_47_7e67@example.com", "USER_47_7E67@EXAMPLE.COM", "USER_47_7E67", "umCqeJxA4EtqSIZ6rGQQGlvd4IM/CZNZC/jyzeT9zrGZBFDHOjaoVcLN+88jIe77", "user_47_7e67@example.com", "user_47_7e67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_80dd@example.com", "user_48_80dd@example.com", "USER_48_80DD@EXAMPLE.COM", "USER_48_80DD", "oTBt3/6O4vP1F3T8qPGYW6qXy/DtbVW+5evizhogC46QcU4qoVKHLqOCJTg2F5GR", "user_48_80dd@example.com", "user_48_80dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_c4a4@example.com", "user_49_c4a4@example.com", "USER_49_C4A4@EXAMPLE.COM", "USER_49_C4A4", "Sq9FQwzGSDo3Z5wsGnlWqj9xdPxti9XBmO054brWv1UqcW4rBOs2GlRkhLHv+u9m", "user_49_c4a4@example.com", "user_49_c4a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_b2fe@example.com", "user_50_b2fe@example.com", "USER_50_B2FE@EXAMPLE.COM", "USER_50_B2FE", "MEDaJwOxNnn1Tzc/M0nVYgsl8C4DcqUPP7pmTmkJNaZNoD/L69tVTCRFzW7YRk3q", "user_50_b2fe@example.com", "user_50_b2fe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "UZynG9It5F5OEZBDRFivIriozPvGEKrwSJF+tmaDB7vlFaRZNMujNPJrwZcX59Qz");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeletedMessage", "Description", "IsActive", "IsDeleted", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("46ca0aa4-6554-4af2-a727-2c0827ea5e98"), new DateTime(2025, 3, 4, 15, 39, 6, 396, DateTimeKind.Utc).AddTicks(538), "System", null, null, null, "Test Topic description 2", true, false, "Test Topic name 2", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("f96c65f7-fa93-455b-aea2-5690680b1f6d"), new DateTime(2025, 3, 4, 15, 39, 6, 396, DateTimeKind.Utc).AddTicks(547), "System", null, null, null, "Test Topic description 4", true, false, "Test Topic name 4", new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CommentId",
                table: "Tags",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_PostId",
                table: "Tags",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostRelatedPost_RelatedPostId",
                table: "PostRelatedPost",
                column: "RelatedPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ParentCommentId",
                table: "Comment",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTopic_TopicId",
                table: "PostTopic",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Comment_ParentCommentId",
                table: "Comment",
                column: "ParentCommentId",
                principalTable: "Comment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Users_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostAttachment_Attachment_AttachmentId",
                table: "PostAttachment",
                column: "AttachmentId",
                principalTable: "Attachment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_Comment_CommentId",
                table: "PostComment",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostRelatedPost_Posts_PostId",
                table: "PostRelatedPost",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostRelatedPost_Posts_RelatedPostId",
                table: "PostRelatedPost",
                column: "RelatedPostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Comment_CommentId",
                table: "Tags",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Posts_PostId",
                table: "Tags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Comment_ParentCommentId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Users_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostAttachment_Attachment_AttachmentId",
                table: "PostAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_Comment_CommentId",
                table: "PostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostRelatedPost_Posts_PostId",
                table: "PostRelatedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_PostRelatedPost_Posts_RelatedPostId",
                table: "PostRelatedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Comment_CommentId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Posts_PostId",
                table: "Tags");

            migrationBuilder.DropTable(
                name: "PostTopic");

            migrationBuilder.DropIndex(
                name: "IX_Tags_CommentId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_PostId",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostRelatedPost",
                table: "PostRelatedPost");

            migrationBuilder.DropIndex(
                name: "IX_PostRelatedPost_RelatedPostId",
                table: "PostRelatedPost");

            migrationBuilder.DropIndex(
                name: "IX_Comment_ParentCommentId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_UserId",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("178fb5c9-0e15-4590-853d-60f1a6254722"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f97ec75-15b1-43c0-8e92-fbcf8adcfad4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33cc27d0-453b-490c-a84c-0463ba6cc55e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49703bb1-5422-45f4-8350-c38bc715c34d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49dc1c42-25c3-4773-9e25-844fed18e64d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62308f13-07f3-498e-9103-41b5ef334450"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6232278d-e7b7-46ad-832d-b19e178a5e65"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("acc0e240-2422-4cbd-98b5-df581430b10e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e214a56d-c348-4cbe-bf7a-e4c798ae7495"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea7567dd-11db-4414-877b-df4c2c216c86"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0afb6230-629a-425c-84e6-a448f12c13fe"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("29242680-ba1e-4d6e-8854-8fd194f28166"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5b6fbb5a-6ba5-4d4b-aaa1-6104430f6443"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f4613664-22ae-4f2c-8d01-be6260b38c39"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("59cb0ed6-bac1-4af4-adc5-2819c0f02eda"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("94c93979-b739-41ab-9be2-5cbbfb639c76"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("b1d971b5-7c2b-4fef-b4ae-ed26829d49e4"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("f44fd3dc-5878-46fc-b822-df3348435779"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0ed17047-9715-4031-b5cb-d9020eda4654"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("19607e5f-6efa-45fe-94fc-eb503849b6c1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("21ebfdaa-fd22-44b5-9b1e-02f3256a842a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6d99caca-5806-4be8-b6f1-d7c23c1af2d5"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("89b14cc1-7c20-4acc-ab30-3bb970fcb6d2"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("928a387d-40d1-4212-94b3-5d2e34a4334c"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("48cb7ade-f2bb-4426-8d02-b912876e4cca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("03d2cf8f-beb8-4455-ade0-efc5635e5c6a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4fbba298-ccbc-4f2d-b394-ff33b23fe274"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("61e4acc8-fc16-43e3-80ac-80bda54b2cfb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b4d0e151-3155-4508-9ee7-5110e74b2ce1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b53b026d-ae7b-497c-a851-e02c4fba9892"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fb62843b-9af4-4be7-ac4d-5bae89f98695"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4245e448-8c62-45dd-961d-29892f7eb482"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8e21f077-05a1-4fce-ab74-6967fd7e4eec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cff3246d-a9c3-4807-811d-a8a23eb0cfb7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fc4840eb-149b-4b6d-afaa-3c13376c3694"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("04405d90-002a-4f4f-9d90-33a4a086f334"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("71839c3f-b9eb-435b-a3e2-d770ed71f5e1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c2bb72b8-ee0e-4233-9206-da0a1f040fc1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f1860167-41bf-4f7b-8cea-0e5022a98c25"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f378bf36-407d-4e6d-b07e-5a0c64fb7c01"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("33bd44b3-77b1-4387-91fc-89dfe23cc74b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("46ca0aa4-6554-4af2-a727-2c0827ea5e98"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f96c65f7-fa93-455b-aea2-5690680b1f6d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"));

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CancelledAt",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProgressHistories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProgressHistories");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "ProgressHistories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProgressHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProgressHistories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PrivacyPreferences");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "PrivacyPreferences");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "PrivacyPreferences");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "PrivacyPreferences");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PrivacyPreferences");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PrivacyPreferences");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "PrivacyPreferences");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PostTags");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "LinkedAt",
                table: "PostLink");

            migrationBuilder.DropColumn(
                name: "AssignedAt",
                table: "PostCategory");

            migrationBuilder.DropColumn(
                name: "IsPrimary",
                table: "PostCategory");

            migrationBuilder.DropColumn(
                name: "AttachedAt",
                table: "PostAttachment");

            migrationBuilder.DropColumn(
                name: "IsPrimary",
                table: "PostAttachment");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "MarkdownFiles");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "MarkdownFiles");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "MarkdownFiles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "MarkdownFiles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MarkdownFiles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MarkdownFileHistories");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Link");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Initiatives");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Initiatives");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Initiatives");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "GeographicalPreferences");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "GeographicalPreferences");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "GeographicalPreferences");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "GeographicalPreferences");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "GeographicalPreferences");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "GeographicalPreferences");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "GeographicalPreferences");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FileFormats");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "FileFormats");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "FileFormats");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "FileFormats");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FileFormats");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "FileFormats");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DateFormats");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DateFormats");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "DateFormats");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "DateFormats");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DateFormats");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "DateFormats");

            migrationBuilder.DropColumn(
                name: "ParentCommentId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "PausedUntil",
                table: "Projects",
                newName: "IsPausedTo");

            migrationBuilder.RenameColumn(
                name: "ExtendedUntil",
                table: "Projects",
                newName: "IsExtendedTo");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Projects",
                newName: "IsCompletedAt");

            migrationBuilder.RenameColumn(
                name: "CompletedBy",
                table: "Projects",
                newName: "IsCompletedBy");

            migrationBuilder.RenameColumn(
                name: "CompletedAt",
                table: "Projects",
                newName: "IsCancelledAt");

            migrationBuilder.RenameColumn(
                name: "CancelledBy",
                table: "Projects",
                newName: "IsCancelledby");

            migrationBuilder.RenameColumn(
                name: "RelatedPostId",
                table: "PostRelatedPost",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "PostComment",
                newName: "CommenterId");

            migrationBuilder.RenameIndex(
                name: "IX_PostComment_CommentId",
                table: "PostComment",
                newName: "IX_PostComment_CommenterId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Topics",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Topics",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Topics",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Roles",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Roles",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "ProgressHistories",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "ProgressHistories",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Posts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "PostId",
                table: "Posts",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "PostComment",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Link",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Link",
                keyColumn: "UpdatedBy",
                keyValue: null,
                column: "UpdatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Link",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Link",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Link",
                keyColumn: "DeletedBy",
                keyValue: null,
                column: "DeletedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Link",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Initiatives",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Initiatives",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Initiatives",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Initiatives",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "UpdatedBy",
                keyValue: null,
                column: "UpdatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Comment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comment",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "DeletedBy",
                keyValue: null,
                column: "DeletedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Comment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Attachment",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Attachment",
                keyColumn: "UpdatedBy",
                keyValue: null,
                column: "UpdatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Attachment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Attachment",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Attachment",
                keyColumn: "DeletedBy",
                keyValue: null,
                column: "DeletedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Attachment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Assignments",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Assignments",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Assignments",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Assignments",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostRelatedPost",
                table: "PostRelatedPost",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TagsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), new DateTime(2025, 3, 4, 12, 21, 0, 126, DateTimeKind.Utc).AddTicks(6462), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description", "Test Topic name", null, "test-topic-slug", null, null },
                    { new Guid("aa5298b1-d78d-4608-8a29-fdda63c96eec"), new DateTime(2025, 3, 4, 12, 21, 0, 126, DateTimeKind.Utc).AddTicks(9045), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "oy0WAvMjmUD5Ys4hv4s/mpjw4LT4ifoWQmne6mtu1+uszrxAG3xcdqWk86ZzAmEA");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1448da39-cdaf-47a9-9fb1-960d81dd704b"),
                column: "PasswordHash",
                value: "E+rYeoP+vZP1j4NTaNzB9+6ucUHjZMewgc9QbZvcBcqyLYfC9RI8FWQbRWByU3OD");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_1_60a5@example.com", "user_1_60a5@example.com", "USER_1_60A5@EXAMPLE.COM", "USER_1_60A5", "g9G4+PjoNxzhPXPVa27I3gV4flgijjOMpD7MRG25RAjE2xpPN1TSyX0sSmPNi5MJ", "user_1_60a5@example.com", "user_1_60a5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_2_3fed@example.com", "user_2_3fed@example.com", "USER_2_3FED@EXAMPLE.COM", "USER_2_3FED", "2tmS1JWTrtp+5emqnPgsfFQ0HG3CgDa8BSm79sIU972H+XngH9FJc1VYp46Ttipv", "user_2_3fed@example.com", "user_2_3fed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_3_8c9a@example.com", "user_3_8c9a@example.com", "USER_3_8C9A@EXAMPLE.COM", "USER_3_8C9A", "ZcgGjLkbhSFLaJIkjW+EG+JOADeUjoAHb5ADoEfqqdTU87u4gIkaF7blxAcDRG3p", "user_3_8c9a@example.com", "user_3_8c9a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_4_d1bf@example.com", "user_4_d1bf@example.com", "USER_4_D1BF@EXAMPLE.COM", "USER_4_D1BF", "9Ow51xBS4duDEay3ttcHywDEgaqpoy/+Mfju9XcJc1fIkFMhiVlH3SYU1Cipsh7c", "user_4_d1bf@example.com", "user_4_d1bf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_5_400c@example.com", "user_5_400c@example.com", "USER_5_400C@EXAMPLE.COM", "USER_5_400C", "zrePXuwN6V60x3UeZ3lzSoF+QFuStOiLA6E6p22X10c4cqPJcvCinCYCEAUlfh7H", "user_5_400c@example.com", "user_5_400c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_6_b14f@example.com", "user_6_b14f@example.com", "USER_6_B14F@EXAMPLE.COM", "USER_6_B14F", "XHxghaQURobYoIJXQz6g7paGbv1OLo1cvtIpSmUYK/LVanIRtxLin8iPcjMacgXA", "user_6_b14f@example.com", "user_6_b14f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_7_8f43@example.com", "user_7_8f43@example.com", "USER_7_8F43@EXAMPLE.COM", "USER_7_8F43", "Y+AsEpB3hDShXGcE44R+F7TegjQ8blFWGvTICep81+Ys0C0EHxtlUvpQszIAvGRS", "user_7_8f43@example.com", "user_7_8f43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_8_a0d3@example.com", "user_8_a0d3@example.com", "USER_8_A0D3@EXAMPLE.COM", "USER_8_A0D3", "VGPa10kTn+e5oPHuPJeyZ2WmYmzq+RTcOHzErlQJmoKcdjn6TgEnKzKxi+/+KtJN", "user_8_a0d3@example.com", "user_8_a0d3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_9_cc4d@example.com", "user_9_cc4d@example.com", "USER_9_CC4D@EXAMPLE.COM", "USER_9_CC4D", "d4AYRpvr3BwkwobCYVqOTN+Hzd6lPJMYy5d1TGx+F7gjrHJnIWQ2+jkn5kfUAyBa", "user_9_cc4d@example.com", "user_9_cc4d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_10_53e3@example.com", "user_10_53e3@example.com", "USER_10_53E3@EXAMPLE.COM", "USER_10_53E3", "hh3YfzQpeDXlpGfRjFfo3VFbJR1cwjJJspXbU+/dkH4MXBJH367Nifv6rI1rXMMG", "user_10_53e3@example.com", "user_10_53e3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_11_8316@example.com", "user_11_8316@example.com", "USER_11_8316@EXAMPLE.COM", "USER_11_8316", "asUAXuajLzgTat3ojyY1Oc2hnrsyW/H5du4JPNJuhJBSLCpkMt6FxosiprGWytX4", "user_11_8316@example.com", "user_11_8316" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_12_09f3@example.com", "user_12_09f3@example.com", "USER_12_09F3@EXAMPLE.COM", "USER_12_09F3", "4Lsv/fHRm7GABBqMl5cBvji6bhd0UbGwJAE5VsvxyrzHXFEONoP2PPypDaNTjMuk", "user_12_09f3@example.com", "user_12_09f3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_13_07a6@example.com", "user_13_07a6@example.com", "USER_13_07A6@EXAMPLE.COM", "USER_13_07A6", "km9zIDnfJSL9DDh/yMdFTf9JSjrnMXpmBZxhR2RS75QUJsiCEP6M/9+z3CO7HAF+", "user_13_07a6@example.com", "user_13_07a6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_14_398b@example.com", "user_14_398b@example.com", "USER_14_398B@EXAMPLE.COM", "USER_14_398B", "TVBCt40VSR7bNkqAJKuq+ai6faAlAy1G3eRIrzxa1HXHaULlGf0ZV/PSs8wGqzue", "user_14_398b@example.com", "user_14_398b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_15_7e57@example.com", "user_15_7e57@example.com", "USER_15_7E57@EXAMPLE.COM", "USER_15_7E57", "NJpfzjBj2M2phjwDvs7Q+/cSOoN/TZkggXCkYOnIOAi/ffxMmb29PBNF8OzpOV8Z", "user_15_7e57@example.com", "user_15_7e57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_16_e2ba@example.com", "user_16_e2ba@example.com", "USER_16_E2BA@EXAMPLE.COM", "USER_16_E2BA", "VPgIEQyRxxcj7HXm3mY50bRHhkWqAuJE3sD7v+ttAejN+QK8LTGl6n4kDllTxBFs", "user_16_e2ba@example.com", "user_16_e2ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_17_d062@example.com", "user_17_d062@example.com", "USER_17_D062@EXAMPLE.COM", "USER_17_D062", "kclOfEg8lHW/E5eUc7wGxRomHyPHfc2/aShNZ+yvLvn6SfXOdwDrMFyhAzk9VChF", "user_17_d062@example.com", "user_17_d062" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_18_072e@example.com", "user_18_072e@example.com", "USER_18_072E@EXAMPLE.COM", "USER_18_072E", "h699mLAh/P3D+JCDU4bsTLfup7wEJfVNDPof3PKrWiuxSgjpsi9AC6ThedsIYBW5", "user_18_072e@example.com", "user_18_072e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_19_79e8@example.com", "user_19_79e8@example.com", "USER_19_79E8@EXAMPLE.COM", "USER_19_79E8", "iAY6bKw4yiWflsMwG/PRR45LQH7+33PZQp0/J7SVC8Hy+7Jqw2rlpXsMd0V7sDV7", "user_19_79e8@example.com", "user_19_79e8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_20_3f5f@example.com", "user_20_3f5f@example.com", "USER_20_3F5F@EXAMPLE.COM", "USER_20_3F5F", "h1lBx/NosC25r1pB9XD6vR77BU/PGgdPl3dBT5QhzZEIrQv3YBYPPMKDwxc61MB0", "user_20_3f5f@example.com", "user_20_3f5f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fc9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_21_ade0@example.com", "user_21_ade0@example.com", "USER_21_ADE0@EXAMPLE.COM", "USER_21_ADE0", "NKRag2A1XMvwbRHSuxruM+nxxoWb6+RG9RfpqA3156od2WCAyTmFfdgNzhMdkycw", "user_21_ade0@example.com", "user_21_ade0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fca"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_22_e74b@example.com", "user_22_e74b@example.com", "USER_22_E74B@EXAMPLE.COM", "USER_22_E74B", "ndoEpBoxkJ6sapRu/RbpuFC2M0fidJcs9N+gV/HlBPaIET5Ht28QWNIiX+DGPHHp", "user_22_e74b@example.com", "user_22_e74b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_23_1fb4@example.com", "user_23_1fb4@example.com", "USER_23_1FB4@EXAMPLE.COM", "USER_23_1FB4", "sqCN/4mvDmOkviK8JzkfZCfpeX1RuE4OoFdifApolH839NJMUENZC8+YCu/Ud4g5", "user_23_1fb4@example.com", "user_23_1fb4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_24_f89b@example.com", "user_24_f89b@example.com", "USER_24_F89B@EXAMPLE.COM", "USER_24_F89B", "klItneCnXYcRmz55eJdOx68S44ym4zXPPUPI0y4kf7jRo4VQqfzjP/1EFHEecU6U", "user_24_f89b@example.com", "user_24_f89b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_25_0bf6@example.com", "user_25_0bf6@example.com", "USER_25_0BF6@EXAMPLE.COM", "USER_25_0BF6", "l3cwRBELuwhxwGuOa9pN/EMrjcbrlpZ3Fcmd5SIIGvPH0+89a2fJ/nIvxdRAQ1n9", "user_25_0bf6@example.com", "user_25_0bf6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fce"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_26_5a1a@example.com", "user_26_5a1a@example.com", "USER_26_5A1A@EXAMPLE.COM", "USER_26_5A1A", "n11hSnFklpAtP7VtSR2TXic6IO4TV49aZE1GSNwqPwaS5tErR4GG7Wa8cLXQpXeW", "user_26_5a1a@example.com", "user_26_5a1a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fcf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_27_9893@example.com", "user_27_9893@example.com", "USER_27_9893@EXAMPLE.COM", "USER_27_9893", "mAlhcGE/nvrHOS5k9R+HXwYeapNk6ETpqpNvn571+XWYm/R2geMlhv9/4smOWaHe", "user_27_9893@example.com", "user_27_9893" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_28_9c22@example.com", "user_28_9c22@example.com", "USER_28_9C22@EXAMPLE.COM", "USER_28_9C22", "A8hYvW4eovoe8wHg/8eqF3yJHvTRKR5VTDzSdRwJac8x5MieKFd9tQWPCT9n5gBt", "user_28_9c22@example.com", "user_28_9c22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_29_a4e8@example.com", "user_29_a4e8@example.com", "USER_29_A4E8@EXAMPLE.COM", "USER_29_A4E8", "r2+07FBEZIfBkTfIOjMvT5RNFovpv6UlaRHwFMoGXngJ/xgCVjrzxAkoPDmqcExo", "user_29_a4e8@example.com", "user_29_a4e8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_30_f57f@example.com", "user_30_f57f@example.com", "USER_30_F57F@EXAMPLE.COM", "USER_30_F57F", "VOBS4LOyNRF7Pv/gjW7wb5vyQH/dtY7RO8huvCgCMX7EvTRdzpPQbhQJck1enbD5", "user_30_f57f@example.com", "user_30_f57f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_31_304e@example.com", "user_31_304e@example.com", "USER_31_304E@EXAMPLE.COM", "USER_31_304E", "ZqDBRFDn/dlEy0s1r9YSxuX9w9rHX5NVqeVmoKqdSRUUEwOTdU3pedZII0ahkx2b", "user_31_304e@example.com", "user_31_304e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_32_fdff@example.com", "user_32_fdff@example.com", "USER_32_FDFF@EXAMPLE.COM", "USER_32_FDFF", "RcRfOecTxrO/ONp2YaKS8Y+hyQsCZ6XWx1WWmWN9MJa4H14SRcvLjGIUeUb7b3ay", "user_32_fdff@example.com", "user_32_fdff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_33_e5ca@example.com", "user_33_e5ca@example.com", "USER_33_E5CA@EXAMPLE.COM", "USER_33_E5CA", "ujgKT3oECqkCEiyCRRhG9CjE9EF5EJJsiC3s9b1+9HdntRmnKb9qmU4zfDKcS8He", "user_33_e5ca@example.com", "user_33_e5ca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_34_a475@example.com", "user_34_a475@example.com", "USER_34_A475@EXAMPLE.COM", "USER_34_A475", "MXzVv9leNUSLsIbkFNsW+RL9CFd1Od3Fd0DugGYw2UCSLQrSej3w+ut6llfy2Sym", "user_34_a475@example.com", "user_34_a475" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_35_ccb0@example.com", "user_35_ccb0@example.com", "USER_35_CCB0@EXAMPLE.COM", "USER_35_CCB0", "zM/FnMFizjzCogAnLTxk8/rILqP751tJtnxIeTVrfX2hfwg/gg7N/v/75VYnJW1t", "user_35_ccb0@example.com", "user_35_ccb0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_36_1679@example.com", "user_36_1679@example.com", "USER_36_1679@EXAMPLE.COM", "USER_36_1679", "xs2wmFtgibAoRa18kr7YDCBrlCAavzz1pzs+SFL9uMLMVtUjbx0kno4Wi+gSh7Wj", "user_36_1679@example.com", "user_36_1679" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fd9"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_37_9a40@example.com", "user_37_9a40@example.com", "USER_37_9A40@EXAMPLE.COM", "USER_37_9A40", "YKrDlqGH8iICGCgzUac8KF0WaYf8FGgHwL7CNQBpb32H5zLqugapVIUBg6aV/i55", "user_37_9a40@example.com", "user_37_9a40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fda"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_38_4879@example.com", "user_38_4879@example.com", "USER_38_4879@EXAMPLE.COM", "USER_38_4879", "sfUCMAqacL2O8ypCBkRGCgLCb2qxI/5Yi4OyDyBTcCdfeKvs/Hi9rFXXSwVaDYne", "user_38_4879@example.com", "user_38_4879" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdb"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_39_09ea@example.com", "user_39_09ea@example.com", "USER_39_09EA@EXAMPLE.COM", "USER_39_09EA", "aqMbYqFvrGlP6IZG/73fh948pOU7NKM7Va8mW1D+nm9hVoTQaSwfX8gTP5fvOccm", "user_39_09ea@example.com", "user_39_09ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdc"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_40_95cb@example.com", "user_40_95cb@example.com", "USER_40_95CB@EXAMPLE.COM", "USER_40_95CB", "AwRQ7WIUHkMEbuiwD/aiTlLFtD7cjYtSoTmyTM3pB7TThqKhVvdIvQByyowf6Mqj", "user_40_95cb@example.com", "user_40_95cb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_41_74ee@example.com", "user_41_74ee@example.com", "USER_41_74EE@EXAMPLE.COM", "USER_41_74EE", "EUdK0UVt6Lf+wR8Ue6wBbhoQoJjB7gVGNbM2QYCXAqiiA67TB6rteJnS7RtE2gNe", "user_41_74ee@example.com", "user_41_74ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fde"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_42_7d25@example.com", "user_42_7d25@example.com", "USER_42_7D25@EXAMPLE.COM", "USER_42_7D25", "hCNkIjf50Nu9gEWLkGBBBM47VWEgksSh4hK4t3yKDEUfFw3WvAvvzUAhiF1UdNUp", "user_42_7d25@example.com", "user_42_7d25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fdf"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_43_2b44@example.com", "user_43_2b44@example.com", "USER_43_2B44@EXAMPLE.COM", "USER_43_2B44", "wO9b0QRuxWxslXqWPdFHFHNbV6SjyynSwlE2kwlvZpNOgZAnj0T7b19GqYSwe+ym", "user_43_2b44@example.com", "user_43_2b44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe0"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_44_b3ce@example.com", "user_44_b3ce@example.com", "USER_44_B3CE@EXAMPLE.COM", "USER_44_B3CE", "e6q6zob4uj+Q7lYDROEKbgyXTdcpRK6s+0/zxLRWk8lgpoWxi59vSGgtADY9nI0F", "user_44_b3ce@example.com", "user_44_b3ce" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_45_9019@example.com", "user_45_9019@example.com", "USER_45_9019@EXAMPLE.COM", "USER_45_9019", "PNNJ4+iLd4VjjDxqmWpOgWNobSXXttavh/MLEZcp9H+eHiIM8fQPQLo8YJIlKhcc", "user_45_9019@example.com", "user_45_9019" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe2"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_46_51bb@example.com", "user_46_51bb@example.com", "USER_46_51BB@EXAMPLE.COM", "USER_46_51BB", "r2Tsrri1uCTUzJYfKuO8aWTKNvVbH1CRdY1OOso42n4auvyDinbDuhT/VYXoKaxZ", "user_46_51bb@example.com", "user_46_51bb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_47_e85a@example.com", "user_47_e85a@example.com", "USER_47_E85A@EXAMPLE.COM", "USER_47_E85A", "zU7aAt4ovktNG8poMDRUa83d1I1PaHoFjMOHU47KesZsNfrNxaUe8f7DWRyqSIXa", "user_47_e85a@example.com", "user_47_e85a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe4"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_48_ed15@example.com", "user_48_ed15@example.com", "USER_48_ED15@EXAMPLE.COM", "USER_48_ED15", "fXRy/C/EPeM4V/sbDOeUzbQoCL3UXpKt66g8ahydKKfNL8ZuAxCw5ag7quw8gEpA", "user_48_ed15@example.com", "user_48_ed15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe5"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_49_d1d6@example.com", "user_49_d1d6@example.com", "USER_49_D1D6@EXAMPLE.COM", "USER_49_D1D6", "DHBHIS0iazMmsUcsCb9i4r+zAETzK+Y5CFUe4Vk2GLFHLOsLpF2D8Oc2XyNIS9FY", "user_49_d1d6@example.com", "user_49_d1d6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fe6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "user_50_2fda@example.com", "user_50_2fda@example.com", "USER_50_2FDA@EXAMPLE.COM", "USER_50_2FDA", "LMkOFvtBJaklF7JeB29hv1xCe0wLiWf9sYWvtfZ1KNaXt5FxSsLRM9Oon98HkGbv", "user_50_2fda@example.com", "user_50_2fda" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                column: "PasswordHash",
                value: "bdeWk6paX//hcNa8NitdoKS79pTpWPtV9SFZhF5uxJqt/dExn3YkKQOM4fJzpMYI");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("e83cb273-49ff-406b-97a1-9ff5f705babd"), new DateTime(2025, 3, 4, 12, 21, 0, 126, DateTimeKind.Utc).AddTicks(9054), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("eadb7ea5-97b0-4572-9b4f-1dbd5644eb98"), new DateTime(2025, 3, 4, 12, 21, 0, 126, DateTimeKind.Utc).AddTicks(8507), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostId",
                table: "Posts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostRelatedPost_PostId",
                table: "PostRelatedPost",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagsId",
                table: "PostTag",
                column: "TagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostAttachment_MarkdownFiles_AttachmentId",
                table: "PostAttachment",
                column: "AttachmentId",
                principalTable: "MarkdownFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_Users_CommenterId",
                table: "PostComment",
                column: "CommenterId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostRelatedPost_Posts_PostId",
                table: "PostRelatedPost",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Posts_PostId",
                table: "Posts",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }
    }
}
