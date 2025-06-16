CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;
ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `AccessibilityPreferences` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `EnableHighContrastMode` tinyint(1) NOT NULL,
    `EnableScreenReaderSupport` tinyint(1) NOT NULL,
    `TextScalingFactor` int NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AccessibilityPreferences` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Attachment` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Url` longtext CHARACTER SET utf8mb4 NULL,
    `FileName` longtext CHARACTER SET utf8mb4 NULL,
    `Description` longtext CHARACTER SET utf8mb4 NULL,
    `Type` longtext CHARACTER SET utf8mb4 NULL,
    `Size` longtext CHARACTER SET utf8mb4 NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `UpdatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeletedAt` datetime(6) NULL,
    `DeletedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Attachment` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Category` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NULL,
    `Description` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Category` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Comment` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Text` longtext CHARACTER SET utf8mb4 NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `UpdatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeletedAt` datetime(6) NULL,
    `DeletedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Comment` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Countries` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `IsoCode` varchar(2) CHARACTER SET utf8mb4 NOT NULL,
    `IsoCode3` varchar(3) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Capital` varchar(100) CHARACTER SET utf8mb4 NULL,
    `NativeName` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `PhoneCode` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_Countries` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Currencies` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Code` varchar(3) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Symbol` varchar(5) CHARACTER SET utf8mb4 NOT NULL,
    `DecimalPlaces` int NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_Currencies` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `DateFormats` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Format` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `DisplayName` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `Example` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `IsDefault` tinyint(1) NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_DateFormats` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `FileFormats` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Extension` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `MimeType` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Description` varchar(255) CHARACTER SET utf8mb4 NULL,
    `SupportsEditing` tinyint(1) NOT NULL,
    `SupportsAnnotations` tinyint(1) NOT NULL,
    `MaxSizeInMB` int NOT NULL,
    `IsDefault` tinyint(1) NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_FileFormats` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `LanguagePreferences` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Language` int NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_LanguagePreferences` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Link` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Url` longtext CHARACTER SET utf8mb4 NULL,
    `Name` longtext CHARACTER SET utf8mb4 NULL,
    `Description` longtext CHARACTER SET utf8mb4 NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `UpdatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeletedAt` datetime(6) NULL,
    `DeletedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Link` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `NotificationPreferences` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `ReceiveEmailNotifications` tinyint(1) NOT NULL,
    `ReceiveSmsNotifications` tinyint(1) NOT NULL,
    `IsSubscribedToNewsletter` tinyint(1) NOT NULL,
    `NotificationFrequencyInHours` int NOT NULL,
    `AllowMarketingEmails` tinyint(1) NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_NotificationPreferences` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `PaginationSettings` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `ItemsPerPage` int NOT NULL,
    `ShowPageNumbers` tinyint(1) NOT NULL,
    `ShowFirstLastButtons` tinyint(1) NOT NULL,
    `VisiblePageRange` int NOT NULL,
    `EnableInfiniteScroll` tinyint(1) NOT NULL,
    `ShowItemsCount` tinyint(1) NOT NULL,
    `ShowPageSizeSelector` tinyint(1) NOT NULL,
    `PageSizeOptions` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `IsDefault` tinyint(1) NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_PaginationSettings` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `PrivacyPreferences` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `IsProfilePublic` tinyint(1) NOT NULL,
    `AllowSearchByEmail` tinyint(1) NOT NULL,
    `EnableTwoFactorAuthentication` tinyint(1) NOT NULL,
    `AllowDataSharing` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_PrivacyPreferences` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Roles` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `Description` varchar(200) CHARACTER SET utf8mb4 NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `CreatedBy` char(36) COLLATE ascii_general_ci NOT NULL,
    `UpdatedBy` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_Roles` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `SitemapItems` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `PageName` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Description` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Slug` longtext CHARACTER SET utf8mb4 NOT NULL,
    `AccessByRole` int NOT NULL,
    `ParentId` char(36) COLLATE ascii_general_ci NULL,
    `Order` int NOT NULL,
    `Icon` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsExternalLink` tinyint(1) NOT NULL,
    `ExternalLink` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IsHidden` tinyint(1) NOT NULL,
    `IsDisabled` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `UpdatedAt` datetime(6) NOT NULL,
    `DeletedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DeletedAt` datetime(6) NULL,
    `Version` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IsPublished` tinyint(1) NOT NULL,
    `PublishedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `PublishedDate` datetime(6) NULL,
    `UnpublishBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `UnpublishDate` datetime(6) NULL,
    `IsUnpublished` tinyint(1) NOT NULL,
    `IsDraft` tinyint(1) NOT NULL,
    `IsArchived` tinyint(1) NOT NULL,
    `ArchivedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `ArchivedDate` datetime(6) NULL,
    `ParentItemId` char(36) COLLATE ascii_general_ci NULL,
    `Url` longtext CHARACTER SET utf8mb4 NOT NULL,
    `LastModified` datetime(6) NOT NULL,
    `ChangeFrequency` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Priority` double NOT NULL,
    `SitemapItemId` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_SitemapItems` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SitemapItems_SitemapItems_ParentItemId` FOREIGN KEY (`ParentItemId`) REFERENCES `SitemapItems` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_SitemapItems_SitemapItems_SitemapItemId` FOREIGN KEY (`SitemapItemId`) REFERENCES `SitemapItems` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Tags` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Description` longtext CHARACTER SET utf8mb4 NULL,
    `Slug` varchar(255) CHARACTER SET utf8mb4 NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_Tags` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `TimeZones` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `StandardName` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `UtcOffset` varchar(6) CHARACTER SET utf8mb4 NOT NULL,
    `UsesDaylightSaving` tinyint(1) NOT NULL,
    `DstOffset` varchar(6) CHARACTER SET utf8mb4 NULL,
    `IsActive` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_TimeZones` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Topics` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Description` longtext CHARACTER SET utf8mb4 NULL,
    `Slug` varchar(255) CHARACTER SET utf8mb4 NULL,
    `ParentTopicId` char(36) COLLATE ascii_general_ci NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `CreatedBy` char(36) COLLATE ascii_general_ci NOT NULL,
    `UpdatedBy` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_Topics` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Topics_Topics_ParentTopicId` FOREIGN KEY (`ParentTopicId`) REFERENCES `Topics` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `ThemePreferences` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `IsDarkTheme` tinyint(1) NOT NULL,
    `FontSize` longtext CHARACTER SET utf8mb4 NOT NULL,
    `LanguageId` char(36) COLLATE ascii_general_ci NOT NULL,
    `AccentColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `BackgroundColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `PrimaryColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `SecondaryColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `TertiaryColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DarkModeTextColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `LightModeTextColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DarkModeBackgroundColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `LightModeBackgroundColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DarkModePrimaryColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `LightModePrimaryColor` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `CreatedBy` char(36) COLLATE ascii_general_ci NOT NULL,
    `UpdatedBy` char(36) COLLATE ascii_general_ci NULL,
    `IsDarkModeEnabled` tinyint(1) NOT NULL,
    `IsHighContrastModeEnabled` tinyint(1) NOT NULL,
    `IsReducedMotionEnabled` tinyint(1) NOT NULL,
    CONSTRAINT `PK_ThemePreferences` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ThemePreferences_LanguagePreferences_LanguageId` FOREIGN KEY (`LanguageId`) REFERENCES `LanguagePreferences` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `MiscellaneousPreferences` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `FileFormatId` char(36) COLLATE ascii_general_ci NOT NULL,
    `PaginationSettingsId` char(36) COLLATE ascii_general_ci NOT NULL,
    `EnableAutoSave` tinyint(1) NOT NULL,
    `EnableRealTimeUpdates` tinyint(1) NOT NULL,
    `DefaultDashboardView` longtext CHARACTER SET utf8mb4 NOT NULL,
    `ShowActivityTimeline` tinyint(1) NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    CONSTRAINT `PK_MiscellaneousPreferences` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_MiscellaneousPreferences_FileFormats_FileFormatId` FOREIGN KEY (`FileFormatId`) REFERENCES `FileFormats` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_MiscellaneousPreferences_PaginationSettings_PaginationSettin~` FOREIGN KEY (`PaginationSettingsId`) REFERENCES `PaginationSettings` (`Id`) ON DELETE RESTRICT
) CHARACTER SET=utf8mb4;

CREATE TABLE `GeographicalPreferences` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `CountryId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CurrencyId` char(36) COLLATE ascii_general_ci NOT NULL,
    `TimeZoneId` char(36) COLLATE ascii_general_ci NOT NULL,
    `DateFormatId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_GeographicalPreferences` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_GeographicalPreferences_Countries_CountryId` FOREIGN KEY (`CountryId`) REFERENCES `Countries` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_GeographicalPreferences_Currencies_CurrencyId` FOREIGN KEY (`CurrencyId`) REFERENCES `Currencies` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_GeographicalPreferences_DateFormats_DateFormatId` FOREIGN KEY (`DateFormatId`) REFERENCES `DateFormats` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_GeographicalPreferences_TimeZones_TimeZoneId` FOREIGN KEY (`TimeZoneId`) REFERENCES `TimeZones` (`Id`) ON DELETE RESTRICT
) CHARACTER SET=utf8mb4;

CREATE TABLE `SitemapItemTopic` (
    `SitemapItemId` char(36) COLLATE ascii_general_ci NOT NULL,
    `TopicsId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_SitemapItemTopic` PRIMARY KEY (`SitemapItemId`, `TopicsId`),
    CONSTRAINT `FK_SitemapItemTopic_SitemapItems_SitemapItemId` FOREIGN KEY (`SitemapItemId`) REFERENCES `SitemapItems` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SitemapItemTopic_Topics_TopicsId` FOREIGN KEY (`TopicsId`) REFERENCES `Topics` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AttachmentPost` (
    `AttachmentsId` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostsId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_AttachmentPost` PRIMARY KEY (`AttachmentsId`, `PostsId`),
    CONSTRAINT `FK_AttachmentPost_Attachment_AttachmentsId` FOREIGN KEY (`AttachmentsId`) REFERENCES `Attachment` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `CategoryPost` (
    `CategoriesId` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostsId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_CategoryPost` PRIMARY KEY (`CategoriesId`, `PostsId`),
    CONSTRAINT `FK_CategoryPost_Category_CategoriesId` FOREIGN KEY (`CategoriesId`) REFERENCES `Category` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `CommentPost` (
    `CommentsId` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostsId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_CommentPost` PRIMARY KEY (`CommentsId`, `PostsId`),
    CONSTRAINT `FK_CommentPost_Comment_CommentsId` FOREIGN KEY (`CommentsId`) REFERENCES `Comment` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `LinkPost` (
    `LinksId` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostsId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_LinkPost` PRIMARY KEY (`LinksId`, `PostsId`),
    CONSTRAINT `FK_LinkPost_Link_LinksId` FOREIGN KEY (`LinksId`) REFERENCES `Link` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `MarkdownFileHistories` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `MarkdownFileId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ContentSnapshot` longtext CHARACTER SET utf8mb4 NOT NULL,
    `ChangedByUserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ChangedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_MarkdownFileHistories` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `MarkdownFiles` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Title` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Content` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Visibility` nvarchar(50) NOT NULL,
    `AuthorName` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CreatedBy` char(36) COLLATE ascii_general_ci NOT NULL,
    `UpdatedBy` char(36) COLLATE ascii_general_ci NOT NULL,
    `ProjectId` char(36) COLLATE ascii_general_ci NULL,
    `ParentMdFileId` char(36) COLLATE ascii_general_ci NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `Path` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_MarkdownFiles` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_MarkdownFiles_MarkdownFiles_ParentMdFileId` FOREIGN KEY (`ParentMdFileId`) REFERENCES `MarkdownFiles` (`Id`) ON DELETE SET NULL
) CHARACTER SET=utf8mb4;

CREATE TABLE `MarkdownFileUsers` (
    `MarkdownFileId` char(36) COLLATE ascii_general_ci NOT NULL,
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `DateCollaborated` datetime(6) NOT NULL,
    `CollaborationStopDate` datetime(6) NULL,
    `CollaborationRole` int NOT NULL,
    CONSTRAINT `PK_MarkdownFileUsers` PRIMARY KEY (`MarkdownFileId`, `UserId`),
    CONSTRAINT `FK_MarkdownFileUsers_MarkdownFiles_MarkdownFileId` FOREIGN KEY (`MarkdownFileId`) REFERENCES `MarkdownFiles` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `PostAttachment` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostId` char(36) COLLATE ascii_general_ci NOT NULL,
    `AttachmentId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_PostAttachment` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_PostAttachment_MarkdownFiles_AttachmentId` FOREIGN KEY (`AttachmentId`) REFERENCES `MarkdownFiles` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `PostCategory` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CategoryId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_PostCategory` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_PostCategory_Category_CategoryId` FOREIGN KEY (`CategoryId`) REFERENCES `Category` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `PostCollaborator` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CollaboratorId` char(36) COLLATE ascii_general_ci NOT NULL,
    `IsAdmin` tinyint(1) NOT NULL,
    CONSTRAINT `PK_PostCollaborator` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `PostComment` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Comment` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CommenterId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CommentedAt` datetime(6) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    CONSTRAINT `PK_PostComment` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `PostLink` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostId` char(36) COLLATE ascii_general_ci NOT NULL,
    `LinkId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_PostLink` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_PostLink_MarkdownFiles_LinkId` FOREIGN KEY (`LinkId`) REFERENCES `MarkdownFiles` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `PostRelatedPost` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `PostId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_PostRelatedPost` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Posts` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Title` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Content` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Summary` longtext CHARACTER SET utf8mb4 NULL,
    `Excerpt` longtext CHARACTER SET utf8mb4 NULL,
    `Slug` longtext CHARACTER SET utf8mb4 NULL,
    `PublishedDate` datetime(6) NULL,
    `AuthorId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ViewCount` int NOT NULL,
    `CommentCount` int NOT NULL,
    `IsPublished` tinyint(1) NOT NULL,
    `IsDraft` tinyint(1) NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `DeletedAt` datetime(6) NULL,
    `CreatedBy` longtext CHARACTER SET utf8mb4 NULL,
    `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL,
    `DeletedBy` longtext CHARACTER SET utf8mb4 NULL,
    `Status` int NOT NULL,
    `StatusMessage` longtext CHARACTER SET utf8mb4 NULL,
    `StatusColor` longtext CHARACTER SET utf8mb4 NULL,
    `StatusIcon` longtext CHARACTER SET utf8mb4 NULL,
    `StatusTooltip` longtext CHARACTER SET utf8mb4 NULL,
    `IsArchived` tinyint(1) NOT NULL,
    `AudioUrls` longtext CHARACTER SET utf8mb4 NULL,
    `VideoUrls` longtext CHARACTER SET utf8mb4 NULL,
    `ImageUrls` longtext CHARACTER SET utf8mb4 NULL,
    `MetaDescription` longtext CHARACTER SET utf8mb4 NULL,
    `Description` longtext CHARACTER SET utf8mb4 NULL,
    `PostId` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_Posts` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Posts_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `PostTag` (
    `PostsId` char(36) COLLATE ascii_general_ci NOT NULL,
    `TagsId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_PostTag` PRIMARY KEY (`PostsId`, `TagsId`),
    CONSTRAINT `FK_PostTag_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_PostTag_Tags_TagsId` FOREIGN KEY (`TagsId`) REFERENCES `Tags` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `PostTags` (
    `PostId` char(36) COLLATE ascii_general_ci NOT NULL,
    `TagId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_PostTags` PRIMARY KEY (`PostId`, `TagId`),
    CONSTRAINT `FK_PostTags_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_PostTags_Tags_TagId` FOREIGN KEY (`TagId`) REFERENCES `Tags` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Users` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Email` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `IsAdmin` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `ProfilePicture` longtext CHARACTER SET utf8mb4 NULL,
    `DateOfBirth` datetime(6) NULL,
    `LastLogin` datetime(6) NULL,
    `FailedLoginAttempts` int NOT NULL,
    `IsLockedOut` tinyint(1) NOT NULL,
    `PenName` varchar(50) CHARACTER SET utf8mb4 NULL,
    `Website` longtext CHARACTER SET utf8mb4 NULL,
    `Biography` varchar(1500) CHARACTER SET utf8mb4 NULL,
    `Name` longtext CHARACTER SET utf8mb4 NULL,
    `FirstName` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `LastName` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `LinkUrl` longtext CHARACTER SET utf8mb4 NULL,
    `UpdatedBy` char(36) COLLATE ascii_general_ci NULL,
    `CreatedBy` char(36) COLLATE ascii_general_ci NOT NULL,
    `IsDeleted` tinyint(1) NULL,
    `UpdatedAt` datetime(6) NULL,
    `DeletedBy` char(36) COLLATE ascii_general_ci NULL,
    `DeletedAt` datetime(6) NULL,
    `IsActive` tinyint(1) NULL,
    `LockoutEnd` datetime(6) NULL,
    `PhoneNumberConfirmed` tinyint(1) NULL,
    `PostId` char(36) COLLATE ascii_general_ci NULL,
    `UserName` longtext CHARACTER SET utf8mb4 NULL,
    `NormalizedUserName` varchar(50) CHARACTER SET utf8mb4 NULL,
    `NormalizedEmail` longtext CHARACTER SET utf8mb4 NULL,
    `EmailConfirmed` tinyint(1) NOT NULL,
    `PasswordHash` longtext CHARACTER SET utf8mb4 NOT NULL,
    `SecurityStamp` longtext CHARACTER SET utf8mb4 NOT NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NOT NULL,
    `PhoneNumber` longtext CHARACTER SET utf8mb4 NULL,
    `TwoFactorEnabled` tinyint(1) NOT NULL,
    `LockoutEnabled` tinyint(1) NOT NULL,
    `AccessFailedCount` int NOT NULL,
    CONSTRAINT `PK_Users` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Users_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Projects` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` nvarchar(120) NOT NULL,
    `Description` nvarchar(500) NOT NULL,
    `Visibility` nvarchar(50) NOT NULL,
    `OwnerId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `StartDate` datetime(6) NULL,
    `EndDate` datetime(6) NULL,
    `Status` int NOT NULL,
    `Budget` double NULL,
    `ActualBudget` double NULL,
    `RemainingBudget` double NULL,
    `IsCancelled` tinyint(1) NOT NULL,
    `IsCancelledby` char(36) COLLATE ascii_general_ci NULL,
    `IsCancelledAt` datetime(6) NULL,
    `IsCompleted` tinyint(1) NOT NULL,
    `IsCompletedAt` datetime(6) NULL,
    `IsCompletedBy` char(36) COLLATE ascii_general_ci NULL,
    `IsPaused` tinyint(1) NOT NULL,
    `IsPausedTo` datetime(6) NULL,
    `IsExtended` tinyint(1) NOT NULL,
    `IsExtendedTo` datetime(6) NULL,
    `MarkdownFileId` char(36) COLLATE ascii_general_ci NULL,
    `UserId` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_Projects` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Projects_MarkdownFiles_MarkdownFileId` FOREIGN KEY (`MarkdownFileId`) REFERENCES `MarkdownFiles` (`Id`),
    CONSTRAINT `FK_Projects_Users_OwnerId` FOREIGN KEY (`OwnerId`) REFERENCES `Users` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Projects_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `UserAccessibilityPreferences` (
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `AccessibilityPreferenceId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserAccessibilityPreferences` PRIMARY KEY (`UserId`, `AccessibilityPreferenceId`),
    CONSTRAINT `FK_UserAccessibilityPreferences_AccessibilityPreferences_Access~` FOREIGN KEY (`AccessibilityPreferenceId`) REFERENCES `AccessibilityPreferences` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserAccessibilityPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `UserGeographicalPreferences` (
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `GeographicalPreferenceId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserGeographicalPreferences` PRIMARY KEY (`UserId`, `GeographicalPreferenceId`),
    CONSTRAINT `FK_UserGeographicalPreferences_GeographicalPreferences_Geograph~` FOREIGN KEY (`GeographicalPreferenceId`) REFERENCES `GeographicalPreferences` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserGeographicalPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `UserLanguagePreferences` (
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `LanguagePreferenceId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserLanguagePreferences` PRIMARY KEY (`UserId`, `LanguagePreferenceId`),
    CONSTRAINT `FK_UserLanguagePreferences_LanguagePreferences_LanguagePreferen~` FOREIGN KEY (`LanguagePreferenceId`) REFERENCES `LanguagePreferences` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserLanguagePreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `UserMiscellaneousPreferences` (
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `MiscellaneousPreferenceId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserMiscellaneousPreferences` PRIMARY KEY (`UserId`, `MiscellaneousPreferenceId`),
    CONSTRAINT `FK_UserMiscellaneousPreferences_MiscellaneousPreferences_Miscel~` FOREIGN KEY (`MiscellaneousPreferenceId`) REFERENCES `MiscellaneousPreferences` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserMiscellaneousPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `UserNotificationPreferences` (
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `NotificationPreferenceId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserNotificationPreferences` PRIMARY KEY (`UserId`, `NotificationPreferenceId`),
    CONSTRAINT `FK_UserNotificationPreferences_NotificationPreferences_Notifica~` FOREIGN KEY (`NotificationPreferenceId`) REFERENCES `NotificationPreferences` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserNotificationPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `UserPrivacyPreferences` (
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `PrivacyPreferenceId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserPrivacyPreferences` PRIMARY KEY (`UserId`, `PrivacyPreferenceId`),
    CONSTRAINT `FK_UserPrivacyPreferences_PrivacyPreferences_PrivacyPreferenceId` FOREIGN KEY (`PrivacyPreferenceId`) REFERENCES `PrivacyPreferences` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserPrivacyPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `UserRoles` (
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `RoleId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserRoles` PRIMARY KEY (`UserId`, `RoleId`),
    CONSTRAINT `FK_UserRoles_Roles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `Roles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserRoles_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `UserThemePreferences` (
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ThemePreferenceId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserThemePreferences` PRIMARY KEY (`UserId`, `ThemePreferenceId`),
    CONSTRAINT `FK_UserThemePreferences_ThemePreferences_ThemePreferenceId` FOREIGN KEY (`ThemePreferenceId`) REFERENCES `ThemePreferences` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserThemePreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `ProgressHistories` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `ProjectId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ProgressPercentage` int NOT NULL,
    `Description` varchar(500) CHARACTER SET utf8mb4 NULL,
    `Notes` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `PlannedBudget` double NULL,
    `ActualCost` double NULL,
    `BudgetVariance` double NULL,
    `PlannedStartDate` datetime(6) NULL,
    `ActualStartDate` datetime(6) NULL,
    `PlannedEndDate` datetime(6) NULL,
    `ActualEndDate` datetime(6) NULL,
    `TimeVarianceInDays` int NULL,
    `TotalMilestones` int NOT NULL,
    `CompletedMilestones` int NOT NULL,
    `CurrentStatus` int NOT NULL,
    `StatusReason` varchar(500) CHARACTER SET utf8mb4 NULL,
    `RiskLevel` varchar(50) CHARACTER SET utf8mb4 NULL,
    `RiskDescription` varchar(500) CHARACTER SET utf8mb4 NULL,
    `MitigationPlan` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `CreatedBy` char(36) COLLATE ascii_general_ci NOT NULL,
    `UpdatedBy` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_ProgressHistories` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProgressHistories_Projects_ProjectId` FOREIGN KEY (`ProjectId`) REFERENCES `Projects` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `ProjectMembers` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `ProjectId` char(36) COLLATE ascii_general_ci NOT NULL,
    `UserId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ProjectMemberType` int NOT NULL,
    CONSTRAINT `PK_ProjectMembers` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProjectMembers_Projects_ProjectId` FOREIGN KEY (`ProjectId`) REFERENCES `Projects` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProjectMembers_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('03e61219-a0b5-4a81-a405-8ea9748f2da7', 'Bern', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('22866fec-7869-4527-894d-b89a1448272c', 'Madrid', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('3a7dcf9d-7933-4062-aa2f-aa15fbcb92d4', 'Vienna', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('656f5550-0748-4050-9394-186bd9bd235d', 'Berlin', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('897278ff-33d0-43d6-9deb-0d2be5be11f5', 'Rome', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('8c693d95-ed80-4a13-a86d-aa536f6246aa', 'Luxembourg', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('bc1f9fe8-792b-428b-8364-cf20753543f2', 'Amsterdam', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('c6519c22-adfb-47c5-95b0-ffdb6d2e2c5e', 'Paris', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('f1cd3c55-4da6-45ef-b205-6ba755c2abbb', 'London', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('f4acc52d-5a96-4e33-bc0a-9b8b2089bd73', 'Brussels', TIMESTAMP '2025-02-09 20:30:20', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('2ccccd04-7bcf-423f-a5de-319f80a7658c', 'GBP', TIMESTAMP '2025-02-09 20:30:20', 2, TRUE, 'British Pound', '£', NULL),
('3fff6867-7696-4ea5-864a-d85d0468377d', 'USD', TIMESTAMP '2025-02-09 20:30:20', 2, TRUE, 'US Dollar', '$', NULL),
('981c8174-9533-404e-95b3-f2239d35131d', 'CHF', TIMESTAMP '2025-02-09 20:30:20', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('e754874a-cb88-4bdd-9801-d6a3a8d9c2b4', 'EUR', TIMESTAMP '2025-02-09 20:30:20', 2, TRUE, 'Euro', '€', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('0aa33afb-e2c6-4166-b74a-e9bdfa4b4c78', TIMESTAMP '2025-02-09 20:30:20', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('4e7eb8a6-6ced-4cfb-b2af-8e37bbb63e6e', TIMESTAMP '2025-02-09 20:30:20', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL),
('a83e7b6b-2dff-4c31-8d7d-f274cb7228ab', TIMESTAMP '2025-02-09 20:30:20', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('d0e8f8f8-080d-46e4-95a2-6c072fe1ea1a', TIMESTAMP '2025-02-09 20:30:20', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('39639cb1-5498-4662-8734-b773259b5453', TIMESTAMP '2025-02-09 20:30:20', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('7831d9d1-b66d-47d6-8d30-082129fa8603', TIMESTAMP '2025-02-09 20:30:20', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('888de1b2-e650-4b1e-ac92-28dd6002d2bc', TIMESTAMP '2025-02-09 20:30:20', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('89b60708-d8be-49d1-a9fe-ccd5705f8c67', TIMESTAMP '2025-02-09 20:30:20', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('b6d71bd8-bdd9-404b-9468-5f2af946b4f6', TIMESTAMP '2025-02-09 20:30:20', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL),
('cfc24f1b-7b88-4fbf-abd0-3c0497521de0', TIMESTAMP '2025-02-09 20:30:20', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('1eb148b5-d009-4567-823b-54b0b8aaae30', TIMESTAMP '2025-02-09 20:30:20', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0063f531-66e4-4a97-bd03-5b06702cdee6', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('148ae103-c5c2-4a25-9d75-96f3f2b36e30', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('2e01fd0c-d264-415d-8882-9e1958fb356a', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('4065f3bf-a8cd-4bec-95ad-028930cd7e03', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('55a513f4-3f3b-480d-86dd-7839e5763231', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL),
('b906b7a5-7fe9-463f-8d40-2dcb8df630d5', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('132a2a2c-97d0-40e6-995c-4a9ce5576416', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL),
('17dccfce-e92b-445e-acb1-839286dc4450', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('9e91b006-7f56-454b-aa23-62c1044cef13', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('afe838ba-8f0f-4d39-8789-d3f7dd0934f9', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('515688c1-7bc8-4d21-bf1a-b17c7a94a1cc', TIMESTAMP '2025-02-09 20:30:20', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('5970e2a2-2d20-4c2c-8ddc-38624e7452a7', TIMESTAMP '2025-02-09 20:30:20', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('7acb42d8-754b-4c41-93d7-b613248f6b76', TIMESTAMP '2025-02-09 20:30:20', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('9d6a8bab-fbc7-4485-a73d-5de114bfb43a', TIMESTAMP '2025-02-09 20:30:20', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('9f577bd2-cab9-47a9-8b3c-9cb8f785ce45', TIMESTAMP '2025-02-09 20:30:20', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00');

INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('3fa85f64-5717-4562-b3fc-2c963f66afa6', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Test Topic description', 'Test Topic name', NULL, 'test-topic-slug', NULL, NULL),
('7ff22c11-b4a3-41ed-9343-fda3bf013ad0', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

INSERT INTO `Users` (`Id`, `AccessFailedCount`, `Biography`, `ConcurrencyStamp`, `CreatedAt`, `CreatedBy`, `DateOfBirth`, `DeletedAt`, `DeletedBy`, `Email`, `EmailConfirmed`, `FailedLoginAttempts`, `FirstName`, `IsActive`, `IsAdmin`, `IsDeleted`, `IsLockedOut`, `LastLogin`, `LastName`, `LinkUrl`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PenName`, `PhoneNumber`, `PhoneNumberConfirmed`, `PostId`, `ProfilePicture`, `SecurityStamp`, `TwoFactorEnabled`, `UpdatedAt`, `UpdatedBy`, `UserName`, `Website`)
VALUES ('2e87a96e-c37f-4701-8269-5472fb523af8', 0, NULL, 'ali@asafarim.com', TIMESTAMP '2025-02-09 20:30:20', '2e87a96e-c37f-4701-8269-5472fb523af8', TIMESTAMP '1975-07-15 00:00:00', NULL, NULL, 'ali@asafarim.com', FALSE, 0, 'Ali R.', TRUE, TRUE, FALSE, FALSE, TIMESTAMP '2025-02-09 20:30:20', 'Safari', NULL, FALSE, NULL, NULL, 'ALI@ASAFARIM.COM', 'ALIRZA', 'm7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G', NULL, '+123456789', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'ali@asafarim.com', FALSE, TIMESTAMP '2025-02-09 20:30:20', '2e87a96e-c37f-4701-8269-5472fb523af8', 'alireza', NULL),
('c0ea4656-f3a6-4da6-9e06-14251ec4f20d', 0, NULL, 'user@example.com', TIMESTAMP '2025-02-09 20:30:20', '2e87a96e-c37f-4701-8269-5472fb523af8', TIMESTAMP '1975-07-15 00:00:00', NULL, NULL, 'user@example.com', FALSE, 0, 'User', TRUE, TRUE, FALSE, FALSE, TIMESTAMP '2025-02-09 20:30:20', 'Example', NULL, FALSE, NULL, NULL, 'USER@EXAMPLE.COM', 'EXAMPLE_USER', 'K5xcN3fxatw18eLGtLLoqwTYyN7hhHzyP0MkU4yCJcdPn61r3PVK+3SHlQiMaeKq', NULL, '+123456789', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user@example.com', FALSE, TIMESTAMP '2025-02-09 20:30:20', '2e87a96e-c37f-4701-8269-5472fb523af8', 'example_user', NULL);

INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1230f7ef-2ad1-4874-918e-eef77d80b722', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('9f628e1b-8dd9-49d1-a222-968206bb91c9', TIMESTAMP '2025-02-09 20:30:20', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL);

CREATE INDEX `IX_AttachmentPost_PostsId` ON `AttachmentPost` (`PostsId`);

CREATE INDEX `IX_CategoryPost_PostsId` ON `CategoryPost` (`PostsId`);

CREATE INDEX `IX_CommentPost_PostsId` ON `CommentPost` (`PostsId`);

CREATE UNIQUE INDEX `IX_Countries_IsoCode` ON `Countries` (`IsoCode`);

CREATE UNIQUE INDEX `IX_Countries_IsoCode3` ON `Countries` (`IsoCode3`);

CREATE UNIQUE INDEX `IX_Currencies_Code` ON `Currencies` (`Code`);

CREATE UNIQUE INDEX `IX_DateFormats_Format` ON `DateFormats` (`Format`);

CREATE UNIQUE INDEX `IX_FileFormats_Extension` ON `FileFormats` (`Extension`);

CREATE UNIQUE INDEX `IX_FileFormats_MimeType` ON `FileFormats` (`MimeType`);

CREATE INDEX `IX_GeographicalPreferences_CountryId` ON `GeographicalPreferences` (`CountryId`);

CREATE INDEX `IX_GeographicalPreferences_CurrencyId` ON `GeographicalPreferences` (`CurrencyId`);

CREATE INDEX `IX_GeographicalPreferences_DateFormatId` ON `GeographicalPreferences` (`DateFormatId`);

CREATE INDEX `IX_GeographicalPreferences_TimeZoneId` ON `GeographicalPreferences` (`TimeZoneId`);

CREATE INDEX `IX_LinkPost_PostsId` ON `LinkPost` (`PostsId`);

CREATE INDEX `IX_MarkdownFileHistories_MarkdownFileId` ON `MarkdownFileHistories` (`MarkdownFileId`);

CREATE INDEX `IX_MarkdownFiles_CreatedBy` ON `MarkdownFiles` (`CreatedBy`);

CREATE INDEX `IX_MarkdownFiles_ParentMdFileId` ON `MarkdownFiles` (`ParentMdFileId`);

CREATE INDEX `IX_MarkdownFiles_ProjectId` ON `MarkdownFiles` (`ProjectId`);

CREATE INDEX `IX_MarkdownFileUsers_UserId` ON `MarkdownFileUsers` (`UserId`);

CREATE INDEX `IX_MiscellaneousPreferences_FileFormatId` ON `MiscellaneousPreferences` (`FileFormatId`);

CREATE INDEX `IX_MiscellaneousPreferences_PaginationSettingsId` ON `MiscellaneousPreferences` (`PaginationSettingsId`);

CREATE INDEX `IX_PostAttachment_AttachmentId` ON `PostAttachment` (`AttachmentId`);

CREATE INDEX `IX_PostAttachment_PostId` ON `PostAttachment` (`PostId`);

CREATE INDEX `IX_PostCategory_CategoryId` ON `PostCategory` (`CategoryId`);

CREATE INDEX `IX_PostCategory_PostId` ON `PostCategory` (`PostId`);

CREATE INDEX `IX_PostCollaborator_CollaboratorId` ON `PostCollaborator` (`CollaboratorId`);

CREATE INDEX `IX_PostCollaborator_PostId` ON `PostCollaborator` (`PostId`);

CREATE INDEX `IX_PostComment_CommenterId` ON `PostComment` (`CommenterId`);

CREATE INDEX `IX_PostComment_PostId` ON `PostComment` (`PostId`);

CREATE INDEX `IX_PostLink_LinkId` ON `PostLink` (`LinkId`);

CREATE INDEX `IX_PostLink_PostId` ON `PostLink` (`PostId`);

CREATE INDEX `IX_PostRelatedPost_PostId` ON `PostRelatedPost` (`PostId`);

CREATE INDEX `IX_Posts_AuthorId` ON `Posts` (`AuthorId`);

CREATE INDEX `IX_Posts_PostId` ON `Posts` (`PostId`);

CREATE INDEX `IX_PostTag_TagsId` ON `PostTag` (`TagsId`);

CREATE INDEX `IX_PostTags_TagId` ON `PostTags` (`TagId`);

CREATE UNIQUE INDEX `IX_ProgressHistories_ProjectId` ON `ProgressHistories` (`ProjectId`);

CREATE INDEX `IX_ProjectMembers_ProjectId` ON `ProjectMembers` (`ProjectId`);

CREATE INDEX `IX_ProjectMembers_UserId` ON `ProjectMembers` (`UserId`);

CREATE INDEX `IX_Projects_MarkdownFileId` ON `Projects` (`MarkdownFileId`);

CREATE INDEX `IX_Projects_OwnerId` ON `Projects` (`OwnerId`);

CREATE INDEX `IX_Projects_UserId` ON `Projects` (`UserId`);

CREATE INDEX `IX_SitemapItems_ParentItemId` ON `SitemapItems` (`ParentItemId`);

CREATE INDEX `IX_SitemapItems_SitemapItemId` ON `SitemapItems` (`SitemapItemId`);

CREATE INDEX `IX_SitemapItemTopic_TopicsId` ON `SitemapItemTopic` (`TopicsId`);

CREATE UNIQUE INDEX `IX_Tags_Slug` ON `Tags` (`Slug`);

CREATE INDEX `IX_ThemePreferences_LanguageId` ON `ThemePreferences` (`LanguageId`);

CREATE UNIQUE INDEX `IX_TimeZones_StandardName` ON `TimeZones` (`StandardName`);

CREATE INDEX `IX_Topics_ParentTopicId` ON `Topics` (`ParentTopicId`);

CREATE UNIQUE INDEX `IX_Topics_Slug` ON `Topics` (`Slug`);

CREATE INDEX `IX_UserAccessibilityPreferences_AccessibilityPreferenceId` ON `UserAccessibilityPreferences` (`AccessibilityPreferenceId`);

CREATE INDEX `IX_UserGeographicalPreferences_GeographicalPreferenceId` ON `UserGeographicalPreferences` (`GeographicalPreferenceId`);

CREATE INDEX `IX_UserLanguagePreferences_LanguagePreferenceId` ON `UserLanguagePreferences` (`LanguagePreferenceId`);

CREATE INDEX `IX_UserMiscellaneousPreferences_MiscellaneousPreferenceId` ON `UserMiscellaneousPreferences` (`MiscellaneousPreferenceId`);

CREATE INDEX `IX_UserNotificationPreferences_NotificationPreferenceId` ON `UserNotificationPreferences` (`NotificationPreferenceId`);

CREATE INDEX `IX_UserPrivacyPreferences_PrivacyPreferenceId` ON `UserPrivacyPreferences` (`PrivacyPreferenceId`);

CREATE INDEX `IX_UserRoles_RoleId` ON `UserRoles` (`RoleId`);

CREATE INDEX `IX_Users_PostId` ON `Users` (`PostId`);

CREATE INDEX `IX_UserThemePreferences_ThemePreferenceId` ON `UserThemePreferences` (`ThemePreferenceId`);

ALTER TABLE `AttachmentPost` ADD CONSTRAINT `FK_AttachmentPost_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `CategoryPost` ADD CONSTRAINT `FK_CategoryPost_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `CommentPost` ADD CONSTRAINT `FK_CommentPost_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `LinkPost` ADD CONSTRAINT `FK_LinkPost_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `MarkdownFileHistories` ADD CONSTRAINT `FK_MarkdownFileHistories_MarkdownFiles_MarkdownFileId` FOREIGN KEY (`MarkdownFileId`) REFERENCES `MarkdownFiles` (`Id`) ON DELETE CASCADE;

ALTER TABLE `MarkdownFiles` ADD CONSTRAINT `FK_MarkdownFiles_Projects_ProjectId` FOREIGN KEY (`ProjectId`) REFERENCES `Projects` (`Id`) ON DELETE SET NULL;

ALTER TABLE `MarkdownFiles` ADD CONSTRAINT `FK_MarkdownFiles_Users_CreatedBy` FOREIGN KEY (`CreatedBy`) REFERENCES `Users` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `MarkdownFileUsers` ADD CONSTRAINT `FK_MarkdownFileUsers_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostAttachment` ADD CONSTRAINT `FK_PostAttachment_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostCategory` ADD CONSTRAINT `FK_PostCategory_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostCollaborator` ADD CONSTRAINT `FK_PostCollaborator_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostCollaborator` ADD CONSTRAINT `FK_PostCollaborator_Users_CollaboratorId` FOREIGN KEY (`CollaboratorId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostComment` ADD CONSTRAINT `FK_PostComment_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostComment` ADD CONSTRAINT `FK_PostComment_Users_CommenterId` FOREIGN KEY (`CommenterId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostLink` ADD CONSTRAINT `FK_PostLink_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostRelatedPost` ADD CONSTRAINT `FK_PostRelatedPost_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE;

ALTER TABLE `Posts` ADD CONSTRAINT `FK_Posts_Users_AuthorId` FOREIGN KEY (`AuthorId`) REFERENCES `Users` (`Id`) ON DELETE RESTRICT;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250209203021_AddLanguageId', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '03e61219-a0b5-4a81-a405-8ea9748f2da7';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '22866fec-7869-4527-894d-b89a1448272c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3a7dcf9d-7933-4062-aa2f-aa15fbcb92d4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '656f5550-0748-4050-9394-186bd9bd235d';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '897278ff-33d0-43d6-9deb-0d2be5be11f5';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '8c693d95-ed80-4a13-a86d-aa536f6246aa';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'bc1f9fe8-792b-428b-8364-cf20753543f2';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c6519c22-adfb-47c5-95b0-ffdb6d2e2c5e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f1cd3c55-4da6-45ef-b205-6ba755c2abbb';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f4acc52d-5a96-4e33-bc0a-9b8b2089bd73';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '2ccccd04-7bcf-423f-a5de-319f80a7658c';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '3fff6867-7696-4ea5-864a-d85d0468377d';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '981c8174-9533-404e-95b3-f2239d35131d';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'e754874a-cb88-4bdd-9801-d6a3a8d9c2b4';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '0aa33afb-e2c6-4166-b74a-e9bdfa4b4c78';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '4e7eb8a6-6ced-4cfb-b2af-8e37bbb63e6e';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'a83e7b6b-2dff-4c31-8d7d-f274cb7228ab';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'd0e8f8f8-080d-46e4-95a2-6c072fe1ea1a';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '39639cb1-5498-4662-8734-b773259b5453';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '7831d9d1-b66d-47d6-8d30-082129fa8603';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '888de1b2-e650-4b1e-ac92-28dd6002d2bc';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '89b60708-d8be-49d1-a9fe-ccd5705f8c67';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'b6d71bd8-bdd9-404b-9468-5f2af946b4f6';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'cfc24f1b-7b88-4fbf-abd0-3c0497521de0';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '1eb148b5-d009-4567-823b-54b0b8aaae30';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '0063f531-66e4-4a97-bd03-5b06702cdee6';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '148ae103-c5c2-4a25-9d75-96f3f2b36e30';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '2e01fd0c-d264-415d-8882-9e1958fb356a';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4065f3bf-a8cd-4bec-95ad-028930cd7e03';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '55a513f4-3f3b-480d-86dd-7839e5763231';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b906b7a5-7fe9-463f-8d40-2dcb8df630d5';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '132a2a2c-97d0-40e6-995c-4a9ce5576416';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '17dccfce-e92b-445e-acb1-839286dc4450';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '9e91b006-7f56-454b-aa23-62c1044cef13';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'afe838ba-8f0f-4d39-8789-d3f7dd0934f9';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '515688c1-7bc8-4d21-bf1a-b17c7a94a1cc';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '5970e2a2-2d20-4c2c-8ddc-38624e7452a7';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '7acb42d8-754b-4c41-93d7-b613248f6b76';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '9d6a8bab-fbc7-4485-a73d-5de114bfb43a';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '9f577bd2-cab9-47a9-8b3c-9cb8f785ce45';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '1230f7ef-2ad1-4874-918e-eef77d80b722';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '7ff22c11-b4a3-41ed-9343-fda3bf013ad0';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '9f628e1b-8dd9-49d1-a222-968206bb91c9';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '2e87a96e-c37f-4701-8269-5472fb523af8';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = 'c0ea4656-f3a6-4da6-9e06-14251ec4f20d';
SELECT ROW_COUNT();


ALTER TABLE `Users` ADD `IsBannedByAdmin` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `IsBlocked` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `IsEditor` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `IsModerator` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `IsPending` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `IsStandardUser` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `IsSuperAdmin` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `IsVerified` tinyint(1) NOT NULL DEFAULT FALSE;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('1648f386-9812-4f96-94d3-b77a7e38a4ec', 'Rome', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('260d4dbd-3990-46c5-a0e3-c2c2e89d019f', 'Madrid', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('526b2f5c-a86f-4784-83f4-0cb0721cf385', 'Amsterdam', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('6691fe81-7ab4-4d97-81d7-64206f599a7f', 'Berlin', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('86725127-cc55-49de-aa25-f34e8ff564b5', 'London', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('95c03a6d-dd58-4c4f-a51d-9328e0a1cdd0', 'Bern', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('a2ad1e63-8361-45f6-b979-a25a000b51e0', 'Brussels', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('a78cf388-fcd2-4964-9ea4-c68e972daaa9', 'Vienna', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('aa7a8c6a-8465-4a72-9cb9-2808fdf0acf0', 'Paris', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('f2e7afb8-dfba-40e0-87af-51eb2fa8d6ed', 'Luxembourg', TIMESTAMP '2025-02-10 18:59:48', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('0c198ab3-8fbd-411f-8307-261fa4d887dc', 'EUR', TIMESTAMP '2025-02-10 18:59:48', 2, TRUE, 'Euro', '€', NULL),
('1a24834d-3548-4686-9553-74bc82da84fb', 'CHF', TIMESTAMP '2025-02-10 18:59:48', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('8addab33-0778-4a80-a58e-ade4d7ca58ef', 'USD', TIMESTAMP '2025-02-10 18:59:48', 2, TRUE, 'US Dollar', '$', NULL),
('c8fb9e0e-fd36-4680-bfd6-9bd27f2f2cf8', 'GBP', TIMESTAMP '2025-02-10 18:59:48', 2, TRUE, 'British Pound', '£', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('087ec2fa-eb0d-401f-9e3e-a31b237a10f6', TIMESTAMP '2025-02-10 18:59:48', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('350a885c-f6dc-4f4f-85ec-c1046bfcbd74', TIMESTAMP '2025-02-10 18:59:48', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL),
('b30a9363-8a23-421c-9864-61a741944378', TIMESTAMP '2025-02-10 18:59:48', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('ddb2b178-8af9-48f8-b465-d14463ff6638', TIMESTAMP '2025-02-10 18:59:48', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('5bb1253e-5500-4bb9-bf0f-12aba90a9712', TIMESTAMP '2025-02-10 18:59:48', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('cae42625-fd23-4f8f-b359-5519c859b1b8', TIMESTAMP '2025-02-10 18:59:48', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('cb975699-d192-401e-81ea-201f1ef5f1e9', TIMESTAMP '2025-02-10 18:59:48', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('ee5f85de-016f-4566-8789-3fe147263822', TIMESTAMP '2025-02-10 18:59:48', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('f0a774a0-e4e4-46c0-82ba-3b757fda5a66', TIMESTAMP '2025-02-10 18:59:48', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('f266d3cc-0273-4c4c-af2b-152ed6f0b056', TIMESTAMP '2025-02-10 18:59:48', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('cae2f507-0bfc-405e-9389-38968e172263', TIMESTAMP '2025-02-10 18:59:48', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('27a550b5-3dff-4d2a-94c7-33d9fe2d7033', TIMESTAMP '2025-02-10 18:59:48', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('2da3f760-37e0-4522-8222-83feb03605b2', TIMESTAMP '2025-02-10 18:59:48', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL),
('9f7d7551-ed1e-497e-a030-b3ce74d0d49d', TIMESTAMP '2025-02-10 18:59:48', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('d03f9ddd-4540-439d-992e-00fcfb536f3a', TIMESTAMP '2025-02-10 18:59:48', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('e378676c-d862-4ead-8623-e19769a051dc', TIMESTAMP '2025-02-10 18:59:48', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL),
('f27060de-d9ab-4442-b93d-b622f9945bb8', TIMESTAMP '2025-02-10 18:59:48', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('1ccc9a36-3f22-40e7-9219-9bb599fec7a7', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL),
('937142cb-10d2-4780-b01d-2676b1ecee2c', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('a83de6e7-a421-4936-904f-90ec83d23b25', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('d7570e19-ec88-4f4a-b92f-004e900c86af', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('08c4dd85-effd-40a4-9f63-20bbd4fa3d5e', TIMESTAMP '2025-02-10 18:59:48', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('5a0b3f8a-fa2c-4d85-ba1d-ea109be66dad', TIMESTAMP '2025-02-10 18:59:48', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('a8fd1d21-32eb-4e6b-a9c6-a7343ccfe5b0', TIMESTAMP '2025-02-10 18:59:48', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('c05d8f8e-5553-45b6-b6b8-f4cb7e449040', TIMESTAMP '2025-02-10 18:59:48', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('d06b705c-7dc9-4967-ae36-59396023c35a', TIMESTAMP '2025-02-10 18:59:48', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-10 18:59:49'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('67d84007-e60a-40e5-b795-66e60d8f91dd', TIMESTAMP '2025-02-10 18:59:49', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('ba9957ba-28ca-445e-8ad4-b76c1d82e1dd', TIMESTAMP '2025-02-10 18:59:49', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('e5a6c790-3f14-4d42-9097-8d1283b52ab3', TIMESTAMP '2025-02-10 18:59:49', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL);

INSERT INTO `Users` (`Id`, `AccessFailedCount`, `Biography`, `ConcurrencyStamp`, `CreatedAt`, `CreatedBy`, `DateOfBirth`, `DeletedAt`, `DeletedBy`, `Email`, `EmailConfirmed`, `FailedLoginAttempts`, `FirstName`, `IsActive`, `IsAdmin`, `IsBannedByAdmin`, `IsBlocked`, `IsDeleted`, `IsEditor`, `IsLockedOut`, `IsModerator`, `IsPending`, `IsStandardUser`, `IsSuperAdmin`, `IsVerified`, `LastLogin`, `LastName`, `LinkUrl`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PenName`, `PhoneNumber`, `PhoneNumberConfirmed`, `PostId`, `ProfilePicture`, `SecurityStamp`, `TwoFactorEnabled`, `UpdatedAt`, `UpdatedBy`, `UserName`, `Website`)
VALUES ('553d6b66-5b55-4ed0-85a8-6ac98941879e', 0, NULL, 'user@example.com', TIMESTAMP '2025-02-10 18:59:48', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-15 00:00:00', NULL, NULL, 'user@example.com', FALSE, 0, 'User', TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-10 18:59:48', 'Example', NULL, FALSE, NULL, NULL, 'USER@EXAMPLE.COM', 'EXAMPLE_USER', 'oW2X3P0AysSuqjhwAUrglBUeqPg/gTJewLJGS1uGikpGeLmlbEE6UCs7ROlPadcY', NULL, '+123456789', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user@example.com', FALSE, TIMESTAMP '2025-02-10 18:59:48', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'example_user', NULL),
('8048da39-cdaf-47a9-9fb1-960d81dd704a', 0, NULL, 'ali@asafarim.com', TIMESTAMP '2025-02-10 18:59:48', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-15 00:00:00', NULL, NULL, 'ali@asafarim.com', FALSE, 0, 'Ali R.', TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-10 18:59:48', 'Safari', NULL, FALSE, NULL, NULL, 'ALI@ASAFARIM.COM', 'ALIRZA', 'm7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G', NULL, '+123456789', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'ali@asafarim.com', FALSE, TIMESTAMP '2025-02-10 18:59:48', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'alireza', NULL);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250210185953_AddUserFields', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '1648f386-9812-4f96-94d3-b77a7e38a4ec';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '260d4dbd-3990-46c5-a0e3-c2c2e89d019f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '526b2f5c-a86f-4784-83f4-0cb0721cf385';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6691fe81-7ab4-4d97-81d7-64206f599a7f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '86725127-cc55-49de-aa25-f34e8ff564b5';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '95c03a6d-dd58-4c4f-a51d-9328e0a1cdd0';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a2ad1e63-8361-45f6-b979-a25a000b51e0';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a78cf388-fcd2-4964-9ea4-c68e972daaa9';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'aa7a8c6a-8465-4a72-9cb9-2808fdf0acf0';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f2e7afb8-dfba-40e0-87af-51eb2fa8d6ed';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '0c198ab3-8fbd-411f-8307-261fa4d887dc';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '1a24834d-3548-4686-9553-74bc82da84fb';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '8addab33-0778-4a80-a58e-ade4d7ca58ef';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'c8fb9e0e-fd36-4680-bfd6-9bd27f2f2cf8';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '087ec2fa-eb0d-401f-9e3e-a31b237a10f6';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '350a885c-f6dc-4f4f-85ec-c1046bfcbd74';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'b30a9363-8a23-421c-9864-61a741944378';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'ddb2b178-8af9-48f8-b465-d14463ff6638';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5bb1253e-5500-4bb9-bf0f-12aba90a9712';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'cae42625-fd23-4f8f-b359-5519c859b1b8';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'cb975699-d192-401e-81ea-201f1ef5f1e9';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'ee5f85de-016f-4566-8789-3fe147263822';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f0a774a0-e4e4-46c0-82ba-3b757fda5a66';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f266d3cc-0273-4c4c-af2b-152ed6f0b056';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'cae2f507-0bfc-405e-9389-38968e172263';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '27a550b5-3dff-4d2a-94c7-33d9fe2d7033';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '2da3f760-37e0-4522-8222-83feb03605b2';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '9f7d7551-ed1e-497e-a030-b3ce74d0d49d';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'd03f9ddd-4540-439d-992e-00fcfb536f3a';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'e378676c-d862-4ead-8623-e19769a051dc';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'f27060de-d9ab-4442-b93d-b622f9945bb8';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '1ccc9a36-3f22-40e7-9219-9bb599fec7a7';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '937142cb-10d2-4780-b01d-2676b1ecee2c';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'a83de6e7-a421-4936-904f-90ec83d23b25';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'd7570e19-ec88-4f4a-b92f-004e900c86af';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '08c4dd85-effd-40a4-9f63-20bbd4fa3d5e';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '5a0b3f8a-fa2c-4d85-ba1d-ea109be66dad';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'a8fd1d21-32eb-4e6b-a9c6-a7343ccfe5b0';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'c05d8f8e-5553-45b6-b6b8-f4cb7e449040';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'd06b705c-7dc9-4967-ae36-59396023c35a';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '67d84007-e60a-40e5-b795-66e60d8f91dd';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'ba9957ba-28ca-445e-8ad4-b76c1d82e1dd';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'e5a6c790-3f14-4d42-9097-8d1283b52ab3';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '553d6b66-5b55-4ed0-85a8-6ac98941879e';
SELECT ROW_COUNT();


ALTER TABLE `Users` ADD `ForgotPasswordToken` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Users` ADD `ForgotPasswordTokenExpiration` datetime(6) NULL;

ALTER TABLE `Users` ADD `IsGuest` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `PasswordResetToken` datetime(6) NULL;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('1572e3ae-9850-421e-b895-9836eb3a9529', 'Brussels', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('35e2ac04-4f40-41b9-bb41-438a7e93d0c1', 'Vienna', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('3ff7afef-6db6-4094-bc5b-cfd33fad229f', 'Bern', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('72cc2158-48c5-41c0-a0e1-64dc06a90e4e', 'Amsterdam', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('72d054a8-c57c-4a22-aad5-249db1fbda5c', 'Madrid', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('7ec9fa84-64d9-4925-afc6-c5913b9da12c', 'Berlin', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('aa81e98d-81a4-467f-91d7-d9de2bfd0e32', 'London', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('b2fc0532-5f40-4a4f-aa5c-ffd4e16bf500', 'Paris', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('e5868739-dbc8-415d-b519-d515f692da8e', 'Rome', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('f4311c32-2c0c-4b39-a73e-e44522f54772', 'Luxembourg', TIMESTAMP '2025-02-14 09:46:22', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('9883b66b-b9bf-4e9c-bf7f-2fa8f7dcf82b', 'CHF', TIMESTAMP '2025-02-14 09:46:22', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('9bc38d5a-2e2e-443a-bde7-f6c7802ce879', 'USD', TIMESTAMP '2025-02-14 09:46:22', 2, TRUE, 'US Dollar', '$', NULL),
('a18af334-c2f1-41f4-9585-0760ab697da3', 'GBP', TIMESTAMP '2025-02-14 09:46:22', 2, TRUE, 'British Pound', '£', NULL),
('bd01f44d-172d-4009-9bc6-a2fe99fd136c', 'EUR', TIMESTAMP '2025-02-14 09:46:22', 2, TRUE, 'Euro', '€', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('05b13df8-4103-40da-8982-bda7d75808c1', TIMESTAMP '2025-02-14 09:46:22', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('07240416-e746-4d10-b173-380ed60b7e64', TIMESTAMP '2025-02-14 09:46:22', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('47601495-078d-4e1e-a390-1d534a327e7c', TIMESTAMP '2025-02-14 09:46:22', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL),
('caa5fe38-6bde-4c62-87fc-605be72587b0', TIMESTAMP '2025-02-14 09:46:22', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('0d1cd387-9b2c-4b67-86e5-f7b9c8f144ee', TIMESTAMP '2025-02-14 09:46:22', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('220229ff-788c-421c-89de-cc48d0933b38', TIMESTAMP '2025-02-14 09:46:22', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('5a17ab27-3c91-4d54-ab1e-d94c9081ee9a', TIMESTAMP '2025-02-14 09:46:22', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('78940904-a244-4520-b779-66cd550b814d', TIMESTAMP '2025-02-14 09:46:22', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('badd4bf3-2836-49fd-a1fe-681d1bebb742', TIMESTAMP '2025-02-14 09:46:22', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('e9111a6c-c999-4be2-ae25-34c783647730', TIMESTAMP '2025-02-14 09:46:22', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('a4c93ce5-3c2f-4f6b-abfe-95bad0a81acc', TIMESTAMP '2025-02-14 09:46:22', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('4661b21f-bd06-403c-94f3-7ca3790d18bd', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('9750955c-85b3-43cb-9724-58f2565954f6', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL),
('c6aa0f78-abb1-4826-bcb1-0210b39d8055', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('cbb09250-91a5-4c39-aeea-6f7530f061e8', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('f4f70352-a29d-47e2-97db-41740b60e464', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('fb584561-3c11-4be6-a32c-b6a23282091c', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('270fb739-8160-4147-93d5-9a36fad4f6c4', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL),
('5f54087d-a422-4fe8-a69b-d5f2f84a253d', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('80e2b3d4-c7de-4407-9848-17c36dd2ea0b', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('aad0aef6-e79a-41c6-be9b-09f0bdeffe9e', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('0f161059-2d44-424c-b054-f3a8327a1c5e', TIMESTAMP '2025-02-14 09:46:22', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('889171cf-c7f3-48ea-8bdb-0600943d8dac', TIMESTAMP '2025-02-14 09:46:22', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('b1949593-0a08-4d2c-9afe-d331f2386e71', TIMESTAMP '2025-02-14 09:46:22', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('b20f42ee-72bf-406d-aa09-f6872b2410d1', TIMESTAMP '2025-02-14 09:46:22', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('e4cc0ebf-524f-4d21-ad23-cb51a4aa87c9', TIMESTAMP '2025-02-14 09:46:22', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-14 09:46:22'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('2232a25d-7541-45cf-8fad-5beefe2eee23', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('5c6bc460-4ae1-4107-a104-5adbf006696b', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('e214eaba-4cb6-499c-9fc1-5ee8367b898f', TIMESTAMP '2025-02-14 09:46:22', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL);

UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 09:46:22', `ForgotPasswordToken` = NULL, `ForgotPasswordTokenExpiration` = NULL, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsSuperAdmin` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 09:46:22', `PasswordResetToken` = NULL, `UpdatedAt` = TIMESTAMP '2025-02-14 09:46:22'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `Users` (`Id`, `AccessFailedCount`, `Biography`, `ConcurrencyStamp`, `CreatedAt`, `CreatedBy`, `DateOfBirth`, `DeletedAt`, `DeletedBy`, `Email`, `EmailConfirmed`, `FailedLoginAttempts`, `FirstName`, `ForgotPasswordToken`, `ForgotPasswordTokenExpiration`, `IsActive`, `IsAdmin`, `IsBannedByAdmin`, `IsBlocked`, `IsDeleted`, `IsEditor`, `IsGuest`, `IsLockedOut`, `IsModerator`, `IsPending`, `IsStandardUser`, `IsSuperAdmin`, `IsVerified`, `LastLogin`, `LastName`, `LinkUrl`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PasswordResetToken`, `PenName`, `PhoneNumber`, `PhoneNumberConfirmed`, `PostId`, `ProfilePicture`, `SecurityStamp`, `TwoFactorEnabled`, `UpdatedAt`, `UpdatedBy`, `UserName`, `Website`)
VALUES ('7fb725c6-3250-b856-604e-69f27e228fb5', 0, NULL, 'user 1@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-01 00:00:00', NULL, NULL, 'user 1@example.com', FALSE, 0, 'User 1', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 1@EXAMPLE.COM', 'USER 1', '6zqbbE2gVil5hqPC2S4hAcBbl11KnOAv08MV6dVumiTKp5REl14ykpoXmXjef3hv', NULL, NULL, '+123456781', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 1@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 1', NULL),
('7fb725c6-3250-b856-604e-69f27e228fb6', 0, NULL, 'user 2@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-02 00:00:00', NULL, NULL, 'user 2@example.com', FALSE, 0, 'User 2', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 2@EXAMPLE.COM', 'USER 2', '8gs97gpxpkqE5ku107WXayb1zg4vN7fs8fb9LPhVsLicpcat80HyP/vHTNS7ZW1g', NULL, NULL, '+123456782', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 2@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 2', NULL),
('7fb725c6-3250-b856-604e-69f27e228fb7', 0, NULL, 'user 3@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-03 00:00:00', NULL, NULL, 'user 3@example.com', FALSE, 0, 'User 3', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 3@EXAMPLE.COM', 'USER 3', 'VZ1v7aRqle5ZJiJhzWO7aBmobxmHxwSclDEwM0t4OI9q8yvZ7kAYzAoakiGuWlFH', NULL, NULL, '+123456783', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 3@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 3', NULL),
('7fb725c6-3250-b856-604e-69f27e228fb8', 0, NULL, 'user 4@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-04 00:00:00', NULL, NULL, 'user 4@example.com', FALSE, 0, 'User 4', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 4@EXAMPLE.COM', 'USER 4', 'wfPTiuwRYO9Pbct4fP1PF2TAJCKGzAATx9opZxl6u6mSsVbeOriGaCARMJsw6DKI', NULL, NULL, '+123456784', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 4@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 4', NULL),
('7fb725c6-3250-b856-604e-69f27e228fb9', 0, NULL, 'user 5@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-05 00:00:00', NULL, NULL, 'user 5@example.com', FALSE, 0, 'User 5', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 5@EXAMPLE.COM', 'USER 5', 'kTbjHYUzMozSqUtO/f8RDwihdXrFGawLw1zDTLMTp0a/qQYWVbTpUmM/adQF3T55', NULL, NULL, '+123456785', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 5@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 5', NULL),
('7fb725c6-3250-b856-604e-69f27e228fba', 0, NULL, 'user 6@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-06 00:00:00', NULL, NULL, 'user 6@example.com', FALSE, 0, 'User 6', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 6@EXAMPLE.COM', 'USER 6', 'Zl5DoRsn65+1o8+6EdNYB7+bnZqJow14Kmh9BFJqdbqwJQBJjTUhS+NXf4Vxe+Zb', NULL, NULL, '+123456786', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 6@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 6', NULL),
('7fb725c6-3250-b856-604e-69f27e228fbb', 0, NULL, 'user 7@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-07 00:00:00', NULL, NULL, 'user 7@example.com', FALSE, 0, 'User 7', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 7@EXAMPLE.COM', 'USER 7', 'e6JGf9/xAy4NTyghaySOarvxd+Qwy0+gJGPQTOpaSCFb+obRsQgxid9rSCrcDHex', NULL, NULL, '+123456787', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 7@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 7', NULL),
('7fb725c6-3250-b856-604e-69f27e228fbc', 0, NULL, 'user 8@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-08 00:00:00', NULL, NULL, 'user 8@example.com', FALSE, 0, 'User 8', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 8@EXAMPLE.COM', 'USER 8', 'GiBE3xIpd3HItNkgGKVpSsjfXTlmPLonPsmJdF7sYuo8+lm+2Dc0Mq6tujiuOona', NULL, NULL, '+123456788', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 8@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 8', NULL),
('7fb725c6-3250-b856-604e-69f27e228fbd', 0, NULL, 'user 9@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-09 00:00:00', NULL, NULL, 'user 9@example.com', FALSE, 0, 'User 9', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 9@EXAMPLE.COM', 'USER 9', '45za+LEgDiwSBDXLuEDon0cXru9G27bu2b/vB0SEf+V9HKWiGEMFm6v486w6e4OY', NULL, NULL, '+123456789', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 9@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 9', NULL),
('7fb725c6-3250-b856-604e-69f27e228fbe', 0, NULL, 'user 10@example.com', TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-10 00:00:00', NULL, NULL, 'user 10@example.com', FALSE, 0, 'User 10', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TIMESTAMP '2025-02-14 09:46:22', 'Example', NULL, FALSE, NULL, NULL, 'USER 10@EXAMPLE.COM', 'USER 10', '7OesfCOUm4VOl0NjgRDzIP0FuTsoQ29NgRi8IpqZzD+sQI7EwVR/2oXbE4tTmrRQ', NULL, NULL, '+1234567810', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user 10@example.com', FALSE, TIMESTAMP '2025-02-14 09:46:22', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user 10', NULL);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250214094625_UpdateUserAndSerilogConfig', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '1572e3ae-9850-421e-b895-9836eb3a9529';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '35e2ac04-4f40-41b9-bb41-438a7e93d0c1';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3ff7afef-6db6-4094-bc5b-cfd33fad229f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '72cc2158-48c5-41c0-a0e1-64dc06a90e4e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '72d054a8-c57c-4a22-aad5-249db1fbda5c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7ec9fa84-64d9-4925-afc6-c5913b9da12c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'aa81e98d-81a4-467f-91d7-d9de2bfd0e32';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b2fc0532-5f40-4a4f-aa5c-ffd4e16bf500';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'e5868739-dbc8-415d-b519-d515f692da8e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f4311c32-2c0c-4b39-a73e-e44522f54772';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '9883b66b-b9bf-4e9c-bf7f-2fa8f7dcf82b';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '9bc38d5a-2e2e-443a-bde7-f6c7802ce879';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'a18af334-c2f1-41f4-9585-0760ab697da3';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'bd01f44d-172d-4009-9bc6-a2fe99fd136c';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '05b13df8-4103-40da-8982-bda7d75808c1';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '07240416-e746-4d10-b173-380ed60b7e64';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '47601495-078d-4e1e-a390-1d534a327e7c';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'caa5fe38-6bde-4c62-87fc-605be72587b0';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '0d1cd387-9b2c-4b67-86e5-f7b9c8f144ee';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '220229ff-788c-421c-89de-cc48d0933b38';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5a17ab27-3c91-4d54-ab1e-d94c9081ee9a';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '78940904-a244-4520-b779-66cd550b814d';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'badd4bf3-2836-49fd-a1fe-681d1bebb742';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'e9111a6c-c999-4be2-ae25-34c783647730';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'a4c93ce5-3c2f-4f6b-abfe-95bad0a81acc';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4661b21f-bd06-403c-94f3-7ca3790d18bd';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '9750955c-85b3-43cb-9724-58f2565954f6';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'c6aa0f78-abb1-4826-bcb1-0210b39d8055';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'cbb09250-91a5-4c39-aeea-6f7530f061e8';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'f4f70352-a29d-47e2-97db-41740b60e464';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'fb584561-3c11-4be6-a32c-b6a23282091c';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '270fb739-8160-4147-93d5-9a36fad4f6c4';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '5f54087d-a422-4fe8-a69b-d5f2f84a253d';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '80e2b3d4-c7de-4407-9848-17c36dd2ea0b';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'aad0aef6-e79a-41c6-be9b-09f0bdeffe9e';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '0f161059-2d44-424c-b054-f3a8327a1c5e';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '889171cf-c7f3-48ea-8bdb-0600943d8dac';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'b1949593-0a08-4d2c-9afe-d331f2386e71';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'b20f42ee-72bf-406d-aa09-f6872b2410d1';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'e4cc0ebf-524f-4d21-ad23-cb51a4aa87c9';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '2232a25d-7541-45cf-8fad-5beefe2eee23';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '5c6bc460-4ae1-4107-a104-5adbf006696b';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'e214eaba-4cb6-499c-9fc1-5ee8367b898f';
SELECT ROW_COUNT();


INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('17eb3cea-de68-480c-9865-4a054760ba98', 'Amsterdam', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('3697cee4-a8fb-465e-8320-41db2f6130cf', 'Berlin', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('592d1fa1-aecb-447c-80a1-ec63199a25a9', 'London', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('69105467-07af-4acb-9f57-4e19c3cd3290', 'Brussels', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('6b6391ec-29aa-45b3-9c92-0cc0bc84b8fd', 'Bern', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('951f0fca-43a6-4471-9038-acba9770fa26', 'Luxembourg', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('9b09470b-308a-4742-9003-fbc296f31a26', 'Paris', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('adbdb57a-5a70-4456-a074-fa80270ca63d', 'Rome', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('c491a895-9072-4baa-b213-03209d1bd9ed', 'Vienna', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('cd1a0356-9594-4fc7-9e7c-57dba78b40d9', 'Madrid', TIMESTAMP '2025-02-14 12:50:31', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('056cd6b6-9d66-4c45-b50f-a84d32f8d617', 'EUR', TIMESTAMP '2025-02-14 12:50:31', 2, TRUE, 'Euro', '€', NULL),
('5b171e0d-a946-4890-a5b4-eba30afe231c', 'USD', TIMESTAMP '2025-02-14 12:50:31', 2, TRUE, 'US Dollar', '$', NULL),
('8bf4f54b-0f11-4341-9c10-f8b38b7de63a', 'GBP', TIMESTAMP '2025-02-14 12:50:31', 2, TRUE, 'British Pound', '£', NULL),
('f17011a9-f22a-485c-9b69-db93fcadf042', 'CHF', TIMESTAMP '2025-02-14 12:50:31', 2, TRUE, 'Swiss Franc', 'Fr.', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('146bf1df-102f-4edd-9fa5-5aabffc66978', TIMESTAMP '2025-02-14 12:50:31', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL),
('38c79b2e-ddc6-416d-a6c4-539dca9dc688', TIMESTAMP '2025-02-14 12:50:31', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('b11768ad-74db-4497-be93-afd6b154c433', TIMESTAMP '2025-02-14 12:50:31', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL),
('bf02c6e1-94fa-4551-8be7-d7eca9e33f12', TIMESTAMP '2025-02-14 12:50:31', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('3980b986-8c96-451c-a050-a7924969b0c6', TIMESTAMP '2025-02-14 12:50:31', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('58521f44-f883-423e-af8d-2c51f3d682e9', TIMESTAMP '2025-02-14 12:50:31', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('d5f65b01-a3a5-496e-81ff-ee8034e11a77', TIMESTAMP '2025-02-14 12:50:31', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('f24dd29e-d780-4832-9c6d-843f51997841', TIMESTAMP '2025-02-14 12:50:31', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL),
('f95cda4d-9ee6-4047-bdcb-3457ec21e8f6', TIMESTAMP '2025-02-14 12:50:31', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('fec3e351-095e-40c2-88ef-eff9104e8293', TIMESTAMP '2025-02-14 12:50:31', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('c4489a12-6b2e-46e8-9ef9-d7312d421b47', TIMESTAMP '2025-02-14 12:50:31', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('38410c74-65f0-4b8c-9560-70c86defe428', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL),
('45a6d3fa-0de8-49aa-a85b-637b2ccb2412', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('500d9d46-2f56-4625-ad55-5be06dbd9985', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('6318494f-4efd-4880-b06f-00ae603ca890', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('6c35982a-e703-4f2b-a973-4b9f8e976bc8', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('7dc19212-3ab1-4abb-9c85-76fac248265d', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('28683387-597e-4334-af73-dfd17ae0548a', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('7367b635-b175-48f3-b8ee-ec2277e2894b', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('dff24815-be6f-42bc-b043-3a6ecaeec9c1', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL),
('f0649060-7d35-4d78-9a6a-095207e2e31d', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('3448dd99-0358-4601-9a75-62218b239331', TIMESTAMP '2025-02-14 12:50:31', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('423b0fd3-e4a4-4a92-a316-c4416cc81543', TIMESTAMP '2025-02-14 12:50:31', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('87cae171-0e0b-4dee-9eb4-779e7a7f37c0', TIMESTAMP '2025-02-14 12:50:31', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('ba9bd6ba-5780-4cfa-8e6d-e927d31d08e6', TIMESTAMP '2025-02-14 12:50:31', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('dc934346-b5da-4e49-a754-6a73797e3c51', TIMESTAMP '2025-02-14 12:50:31', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('7bf6cec5-7c34-4ca3-b6c7-84f48c5d6a7e', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('ad3dfac2-6514-4c90-9016-e34041331c7c', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('e7d16743-73a0-43b2-832d-6a66ca78e874', TIMESTAMP '2025-02-14 12:50:31', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL);

UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-02 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_1', `PasswordHash` = 'TiRT5ZwOnZk76oqmvyl2z4Hc2g9wSZV2Ik2OfQc//ByspmwAQxPAPkWSk3xHQ0TY', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-03 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_2', `PasswordHash` = 'FFksrN2F7dVk9xdrwtcCkp8CU9Wvee8qA9FgVTtt6w4W4ZHbjt8WtSE0UwG0gANl', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-04 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_3', `PasswordHash` = 'SunmPMGlZ1OAEo8y5GtXLDVR2uM49ZQp0GpJOnCT8JmT7dO/04bx+ug91mbH4TWQ', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-05 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_4', `PasswordHash` = 'p+kGaPnwCcPjb6W7t3DUfAjSotsRrRCFzvbx7FycV96B58KsL6h3CpB1aFD3+8Jo', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-06 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_5', `PasswordHash` = 'vSof7o9f1+JG1qz+1IjWvmezZbtLFZTs6OboeqbHvfh7RUvLik0eUYxBjiN6zYGT', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-07 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_6', `PasswordHash` = 'ggKgXsVqw6Pu/JaypNv3/RDNXg62bHeRkkzOzL4P30Q81dGm0cKB9mjbvjGXBkST', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-08 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_7', `PasswordHash` = 'refxK/hsj/5P2fdsSbhuCvY4TPwIvme9CtgBO3EfaLsBy+J4M68BWkzl2arFHq7W', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-09 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_8', `PasswordHash` = 'UNxJ75OeWbyK+Idm0XttjSV6dqchD+iWC4wFlu8/cpyl8L2Hgy9U0hmTA4GjVy+5', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-10 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_9', `PasswordHash` = '4V7kDw5PzOP7lhFcE3x/tMruNreua/QE5witMx3EfD7Emg2R5W/irnPJd78CbSsK', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `DateOfBirth` = TIMESTAMP '1975-07-11 00:00:00', `IsAdmin` = FALSE, `IsGuest` = FALSE, `IsStandardUser` = TRUE, `IsVerified` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'USER_10', `PasswordHash` = 'hAPe0BUg+Kia4cIiStBPQitShRojUC1Dx6X2r+scKRsaq36hAswYqtht3LMojyxq', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'user_10'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:50:31', `LastLogin` = TIMESTAMP '2025-02-14 12:50:31', `NormalizedUserName` = 'ALI', `UpdatedAt` = TIMESTAMP '2025-02-14 12:50:31', `UserName` = 'ali'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `Users` (`Id`, `AccessFailedCount`, `Biography`, `ConcurrencyStamp`, `CreatedAt`, `CreatedBy`, `DateOfBirth`, `DeletedAt`, `DeletedBy`, `Email`, `EmailConfirmed`, `FailedLoginAttempts`, `FirstName`, `ForgotPasswordToken`, `ForgotPasswordTokenExpiration`, `IsActive`, `IsAdmin`, `IsBannedByAdmin`, `IsBlocked`, `IsDeleted`, `IsEditor`, `IsGuest`, `IsLockedOut`, `IsModerator`, `IsPending`, `IsStandardUser`, `IsSuperAdmin`, `IsVerified`, `LastLogin`, `LastName`, `LinkUrl`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PasswordResetToken`, `PenName`, `PhoneNumber`, `PhoneNumberConfirmed`, `PostId`, `ProfilePicture`, `SecurityStamp`, `TwoFactorEnabled`, `UpdatedAt`, `UpdatedBy`, `UserName`, `Website`)
VALUES ('1048da39-cdaf-47a9-9fb1-960d81dd704b', 0, NULL, 'user@example.com', TIMESTAMP '2025-02-14 12:50:31', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-07-15 00:00:00', NULL, NULL, 'user@example.com', FALSE, 0, 'User', NULL, NULL, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TIMESTAMP '2025-02-14 12:50:31', 'Example', NULL, FALSE, NULL, NULL, 'USER@EXAMPLE.COM', 'USER', 'HwsJkiGqv/T0oEg46QI5yAdTMR9o4VPIAkopxveUzRj+R05NNLiRHo9ltSZzTBFm', NULL, NULL, '+1234567890', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user@example.com', FALSE, TIMESTAMP '2025-02-14 12:50:31', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user', NULL);

CREATE UNIQUE INDEX `IX_ProgressHistories_StatusReason` ON `ProgressHistories` (`StatusReason`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250214125033_SeedUpdated', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '17eb3cea-de68-480c-9865-4a054760ba98';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3697cee4-a8fb-465e-8320-41db2f6130cf';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '592d1fa1-aecb-447c-80a1-ec63199a25a9';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '69105467-07af-4acb-9f57-4e19c3cd3290';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6b6391ec-29aa-45b3-9c92-0cc0bc84b8fd';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '951f0fca-43a6-4471-9038-acba9770fa26';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9b09470b-308a-4742-9003-fbc296f31a26';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'adbdb57a-5a70-4456-a074-fa80270ca63d';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c491a895-9072-4baa-b213-03209d1bd9ed';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'cd1a0356-9594-4fc7-9e7c-57dba78b40d9';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '056cd6b6-9d66-4c45-b50f-a84d32f8d617';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '5b171e0d-a946-4890-a5b4-eba30afe231c';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '8bf4f54b-0f11-4341-9c10-f8b38b7de63a';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'f17011a9-f22a-485c-9b69-db93fcadf042';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '146bf1df-102f-4edd-9fa5-5aabffc66978';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '38c79b2e-ddc6-416d-a6c4-539dca9dc688';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'b11768ad-74db-4497-be93-afd6b154c433';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'bf02c6e1-94fa-4551-8be7-d7eca9e33f12';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '3980b986-8c96-451c-a050-a7924969b0c6';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '58521f44-f883-423e-af8d-2c51f3d682e9';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'd5f65b01-a3a5-496e-81ff-ee8034e11a77';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f24dd29e-d780-4832-9c6d-843f51997841';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f95cda4d-9ee6-4047-bdcb-3457ec21e8f6';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'fec3e351-095e-40c2-88ef-eff9104e8293';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'c4489a12-6b2e-46e8-9ef9-d7312d421b47';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '38410c74-65f0-4b8c-9560-70c86defe428';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '45a6d3fa-0de8-49aa-a85b-637b2ccb2412';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '500d9d46-2f56-4625-ad55-5be06dbd9985';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '6318494f-4efd-4880-b06f-00ae603ca890';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '6c35982a-e703-4f2b-a973-4b9f8e976bc8';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '7dc19212-3ab1-4abb-9c85-76fac248265d';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '28683387-597e-4334-af73-dfd17ae0548a';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '7367b635-b175-48f3-b8ee-ec2277e2894b';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'dff24815-be6f-42bc-b043-3a6ecaeec9c1';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'f0649060-7d35-4d78-9a6a-095207e2e31d';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '3448dd99-0358-4601-9a75-62218b239331';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '423b0fd3-e4a4-4a92-a316-c4416cc81543';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '87cae171-0e0b-4dee-9eb4-779e7a7f37c0';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'ba9bd6ba-5780-4cfa-8e6d-e927d31d08e6';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'dc934346-b5da-4e49-a754-6a73797e3c51';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '7bf6cec5-7c34-4ca3-b6c7-84f48c5d6a7e';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'ad3dfac2-6514-4c90-9016-e34041331c7c';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'e7d16743-73a0-43b2-832d-6a66ca78e874';
SELECT ROW_COUNT();


INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('1ed2c4aa-037b-45d1-a520-d248d0b37aab', 'Vienna', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('449f1e52-a8b7-4d2a-b8fb-a6dd3650451f', 'Amsterdam', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('4848ad02-b004-4699-945e-89fef4d140bf', 'Madrid', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('5a7a435d-01dd-4c82-8cac-07847a442da4', 'Rome', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('61b6f335-aecd-402d-b51b-e442f355d414', 'London', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('70ac55f2-a9a7-4f25-976f-6deb9be134d3', 'Paris', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('8ecae63e-8ca2-4087-875e-152570de3c6e', 'Brussels', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('9451593d-5378-49d9-a688-cc01bdcdd1dc', 'Bern', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('9901be28-4ceb-4655-99ce-282fa086315d', 'Berlin', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('f02728d2-7418-421a-8017-07dbfd0527da', 'Luxembourg', TIMESTAMP '2025-02-14 12:56:29', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('241db133-719d-41e3-874c-a45942c00729', 'GBP', TIMESTAMP '2025-02-14 12:56:29', 2, TRUE, 'British Pound', '£', NULL),
('6aafd072-630b-4cf5-a226-84335a9bd91f', 'EUR', TIMESTAMP '2025-02-14 12:56:29', 2, TRUE, 'Euro', '€', NULL),
('b10518b5-0bef-43f0-b123-c090c4eaea91', 'USD', TIMESTAMP '2025-02-14 12:56:29', 2, TRUE, 'US Dollar', '$', NULL),
('cc6e0501-ff30-4f9e-9d82-129cf41a4bee', 'CHF', TIMESTAMP '2025-02-14 12:56:29', 2, TRUE, 'Swiss Franc', 'Fr.', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('1fee1144-78c4-4b11-8d85-a556c21e513e', TIMESTAMP '2025-02-14 12:56:29', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL),
('c3681633-0f6c-47a3-b2bf-a95df39aeb4b', TIMESTAMP '2025-02-14 12:56:29', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL),
('d8b6c2c8-b3f2-4d19-88f4-235cba844a19', TIMESTAMP '2025-02-14 12:56:29', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('f4654dd7-a2b1-47ad-8179-a2bb77deee21', TIMESTAMP '2025-02-14 12:56:29', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('10ffe8c7-2ad2-4dd1-9722-adbafbb5453c', TIMESTAMP '2025-02-14 12:56:29', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('5d6f6345-61ee-4fab-a85d-1167ff7de056', TIMESTAMP '2025-02-14 12:56:29', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('61fb1b62-63be-465b-970a-467420bd7cfa', TIMESTAMP '2025-02-14 12:56:29', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('81325055-e094-48fb-9b1a-529024273d5f', TIMESTAMP '2025-02-14 12:56:29', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('8e581443-531d-4065-9a63-ee7cc93a84e1', TIMESTAMP '2025-02-14 12:56:29', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('e36b174a-d761-4a71-ab6d-8ef9b34e2a6e', TIMESTAMP '2025-02-14 12:56:29', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('debdb566-067e-47f1-a262-e3d0a7b28569', TIMESTAMP '2025-02-14 12:56:29', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('24adf3eb-cba7-4738-b035-38f49808ac40', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('285a37c4-7f25-4060-9493-0f630b538d8c', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('7159c0c9-38b2-4921-9413-e1a0c312d321', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('8ce7c3b0-626b-417f-8350-5b86155d8da3', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL),
('b22e342d-2369-4088-aa06-7284897d961c', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('dbefd6f2-d673-4155-9150-cf46f3041f05', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('00277422-6bfd-4157-be28-7e26f72f3f49', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('11a1332f-85ac-458d-a272-fd9b7b411171', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('44ff8e1b-4b38-4f9a-ab2b-b77cbee44fff', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL),
('fc6265c0-10b8-4bf8-a6a3-7a3d51538607', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('18bd07c5-2c7c-4c17-8de3-888f5b63e1e0', TIMESTAMP '2025-02-14 12:56:29', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('20ea42af-4c4f-42a8-b750-23d1d218438d', TIMESTAMP '2025-02-14 12:56:29', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('7b6ab23b-6eb1-4039-a8e3-d866cadd1630', TIMESTAMP '2025-02-14 12:56:29', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('7c368677-cf1c-46b5-a40d-d681dd2f981b', TIMESTAMP '2025-02-14 12:56:29', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('afddfdfb-c695-488f-b6e0-2ff5ecf042a5', TIMESTAMP '2025-02-14 12:56:29', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1d77f898-2a90-4cae-a8d5-eb4c98db2dcc', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('601763c7-8497-4100-94cd-12e001374f89', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('a1471090-996e-4816-8c24-598afacbcea6', TIMESTAMP '2025-02-14 12:56:29', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL);

UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `PasswordHash` = '/Pm0tb+EbtZ5PFm9KV7nh7IfTtadgpcXMsn8OCdCOKmGPdlulVje35xmYcp0VfOG', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_1@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_1@EXAMPLE.COM', `PasswordHash` = '+BMF1ik/R6y5HUpYdK6E3zHRLuIs3tIUPIfXsg5RIv5KgCugIY+x35M7DydVfENw', `SecurityStamp` = 'user_1@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_2@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_2@EXAMPLE.COM', `PasswordHash` = 'QEWERsjUcypZcOcwCPOsYK8Ch6wjQuN/89Ppfe9fPTD58VYw/D7VyB7Z7Py1N58h', `SecurityStamp` = 'user_2@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_3@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_3@EXAMPLE.COM', `PasswordHash` = 'xcDuj6ugmilc/LqZnn7DGFy9ZqZI4dx752tGSJzux0V+sq80s7EhyOdxAaYooJHA', `SecurityStamp` = 'user_3@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_4@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_4@EXAMPLE.COM', `PasswordHash` = 'dgrVOHmKZRl8rC1JrCPWHbxIyasdhh6GEK+25z7S3CPAYIQL/J5O8VTe7yXS4RjW', `SecurityStamp` = 'user_4@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_5@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_5@EXAMPLE.COM', `PasswordHash` = 'bU12w8sXel3MzLy0r+F10Kgn+ExAofgCEH9HRykpaJ/d7raWP4xUUhjYHaIZvClS', `SecurityStamp` = 'user_5@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_6@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_6@EXAMPLE.COM', `PasswordHash` = 'xJ7lwgE0tBv4zz2hRSrDD4/5xePUDIPDLaWuSnzWIE/P/YRBSA/rx19VK89+7Jl5', `SecurityStamp` = 'user_6@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_7@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_7@EXAMPLE.COM', `PasswordHash` = 'GtH93ZdjW8rlvyvGee8/3LoJ4dSgOXuHUUFH9UPQeuHKhgZjH41zWSAXGMHWCwso', `SecurityStamp` = 'user_7@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_8@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_8@EXAMPLE.COM', `PasswordHash` = 'dp3Ci4FZ1CYbDu3YEs9OCMxle+MGh9an/gkNT8SXO6dmRds3+de99WeFhUmVSwbB', `SecurityStamp` = 'user_8@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_9@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_9@EXAMPLE.COM', `PasswordHash` = '/hplP/HOx2tsDWX3Qp+9IiZ7983IfUzDfvEBcguDFQMiEb4VD2I4glIlRRdCGD3C', `SecurityStamp` = 'user_9@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `Email` = 'user_10@example.com', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `NormalizedEmail` = 'USER_10@EXAMPLE.COM', `PasswordHash` = 'wCTGND6dGiq17alq4pof6sr31wBYarD+o4Q5iGEDssqLF9+smJSYCRmuge2k+kp0', `SecurityStamp` = 'user_10@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 12:56:29', `LastLogin` = TIMESTAMP '2025-02-14 12:56:29', `UpdatedAt` = TIMESTAMP '2025-02-14 12:56:29'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250214125631_SeedUsernameFixed', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '1ed2c4aa-037b-45d1-a520-d248d0b37aab';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '449f1e52-a8b7-4d2a-b8fb-a6dd3650451f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '4848ad02-b004-4699-945e-89fef4d140bf';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '5a7a435d-01dd-4c82-8cac-07847a442da4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '61b6f335-aecd-402d-b51b-e442f355d414';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '70ac55f2-a9a7-4f25-976f-6deb9be134d3';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '8ecae63e-8ca2-4087-875e-152570de3c6e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9451593d-5378-49d9-a688-cc01bdcdd1dc';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9901be28-4ceb-4655-99ce-282fa086315d';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f02728d2-7418-421a-8017-07dbfd0527da';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '241db133-719d-41e3-874c-a45942c00729';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '6aafd072-630b-4cf5-a226-84335a9bd91f';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'b10518b5-0bef-43f0-b123-c090c4eaea91';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'cc6e0501-ff30-4f9e-9d82-129cf41a4bee';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '1fee1144-78c4-4b11-8d85-a556c21e513e';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'c3681633-0f6c-47a3-b2bf-a95df39aeb4b';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'd8b6c2c8-b3f2-4d19-88f4-235cba844a19';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'f4654dd7-a2b1-47ad-8179-a2bb77deee21';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '10ffe8c7-2ad2-4dd1-9722-adbafbb5453c';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5d6f6345-61ee-4fab-a85d-1167ff7de056';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '61fb1b62-63be-465b-970a-467420bd7cfa';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '81325055-e094-48fb-9b1a-529024273d5f';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '8e581443-531d-4065-9a63-ee7cc93a84e1';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'e36b174a-d761-4a71-ab6d-8ef9b34e2a6e';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'debdb566-067e-47f1-a262-e3d0a7b28569';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '24adf3eb-cba7-4738-b035-38f49808ac40';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '285a37c4-7f25-4060-9493-0f630b538d8c';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '7159c0c9-38b2-4921-9413-e1a0c312d321';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '8ce7c3b0-626b-417f-8350-5b86155d8da3';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b22e342d-2369-4088-aa06-7284897d961c';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'dbefd6f2-d673-4155-9150-cf46f3041f05';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '00277422-6bfd-4157-be28-7e26f72f3f49';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '11a1332f-85ac-458d-a272-fd9b7b411171';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '44ff8e1b-4b38-4f9a-ab2b-b77cbee44fff';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'fc6265c0-10b8-4bf8-a6a3-7a3d51538607';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '18bd07c5-2c7c-4c17-8de3-888f5b63e1e0';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '20ea42af-4c4f-42a8-b750-23d1d218438d';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '7b6ab23b-6eb1-4039-a8e3-d866cadd1630';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '7c368677-cf1c-46b5-a40d-d681dd2f981b';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'afddfdfb-c695-488f-b6e0-2ff5ecf042a5';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '1d77f898-2a90-4cae-a8d5-eb4c98db2dcc';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '601763c7-8497-4100-94cd-12e001374f89';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'a1471090-996e-4816-8c24-598afacbcea6';
SELECT ROW_COUNT();


UPDATE `Users` SET `UserName` = ''
WHERE `UserName` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Users` MODIFY COLUMN `UserName` varchar(50) CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Users` MODIFY COLUMN `NormalizedEmail` varchar(255) CHARACTER SET utf8mb4 NULL;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('11195222-1910-488b-98b5-197377303d10', 'Berlin', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('42905c6b-9cc2-4723-8c51-b7c9c2f11430', 'Vienna', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('5c2c4777-be05-446d-bb56-26cbfe8f1a21', 'Bern', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('6cc0a5b4-99dd-4fbb-9336-3faa02bcc87f', 'Paris', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('859752a7-f92f-4f41-8345-8c2603a42ba7', 'London', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('9e681651-3f8e-498f-99b0-3f196c88a616', 'Brussels', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('af4b0629-e2d1-4805-8f18-d1425decf075', 'Madrid', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('b33d1172-a109-4a03-87b1-55e648f8e7db', 'Rome', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('ce867af2-bdb8-4d61-9498-d7fe9d965458', 'Amsterdam', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('f01697ae-3d19-4bb7-8849-358ccc8cb6e3', 'Luxembourg', TIMESTAMP '2025-02-14 13:13:22', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('b94b53df-983d-49ee-8aab-e65b8c796b5a', 'EUR', TIMESTAMP '2025-02-14 13:13:22', 2, TRUE, 'Euro', '€', NULL),
('bc6ef463-ba69-4133-b540-30e375aabaf5', 'USD', TIMESTAMP '2025-02-14 13:13:22', 2, TRUE, 'US Dollar', '$', NULL),
('ca96ef27-868a-4981-a1f0-c4df23eb6ca8', 'CHF', TIMESTAMP '2025-02-14 13:13:22', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('f83fabae-9f7c-411c-8849-a146834efc3b', 'GBP', TIMESTAMP '2025-02-14 13:13:22', 2, TRUE, 'British Pound', '£', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('19b858eb-c42e-44ad-a636-518f9a529606', TIMESTAMP '2025-02-14 13:13:22', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('2c0bddff-b45f-4837-9e95-4a6bbcf45119', TIMESTAMP '2025-02-14 13:13:22', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL),
('cccc55d7-d5d5-4a07-ab58-38a50c261322', TIMESTAMP '2025-02-14 13:13:22', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('ccd2fcb8-f043-44ad-9b1b-dd7c89eff63a', TIMESTAMP '2025-02-14 13:13:22', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('0fdc2587-2425-4516-9cb3-d90a8b2dd653', TIMESTAMP '2025-02-14 13:13:22', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL),
('285ca1b9-22ae-45a2-85ec-bf346deca57a', TIMESTAMP '2025-02-14 13:13:22', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('4dc35326-88b6-42be-b943-0a41e6937585', TIMESTAMP '2025-02-14 13:13:22', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('a3db5f4b-713d-424a-921c-4d1287f3aa4d', TIMESTAMP '2025-02-14 13:13:22', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('af0668c3-19c6-483b-9d52-eb8ba41092cb', TIMESTAMP '2025-02-14 13:13:22', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('d6987a20-0bb9-4c4b-9478-af118d5a43ec', TIMESTAMP '2025-02-14 13:13:22', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('b7943343-5153-43b6-896e-86e84deab981', TIMESTAMP '2025-02-14 13:13:22', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('18d2073c-18df-428e-85cb-d40b116bfcbc', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL),
('3aad1ea8-4e31-4baa-97b4-44638dacbb4e', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('4d90cdbf-5f88-4e67-bfdc-1465c20f1edf', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('8f9cc908-3a04-49b7-b8b5-e381abc770f1', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('acd96219-b79d-488d-9cea-241571d061e0', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('ca2144a0-bf2a-45d2-a054-8b2485eccd5d', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('50d88ee1-6518-4d4f-b9df-91dce466983b', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL),
('622fcb6f-8859-40be-8230-3ceb1c6f77fe', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('aba70367-2324-4c4d-a88f-6602e5e5da8a', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('cdd25436-de12-40b4-8d4f-5c6d10a5c3cc', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('35289622-b39e-44f0-8d2d-7c800373659a', TIMESTAMP '2025-02-14 13:13:22', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('4c95384d-e490-43c2-9a6f-5f8466480dc5', TIMESTAMP '2025-02-14 13:13:22', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('581bb615-3722-45eb-91a6-0ebdef84b2d9', TIMESTAMP '2025-02-14 13:13:22', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('5c8d70ed-7bcc-4a5c-b5e5-0028d2325e3d', TIMESTAMP '2025-02-14 13:13:22', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('9e507964-a0cd-45f3-a5ef-dd57d2b06770', TIMESTAMP '2025-02-14 13:13:22', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('2a5d9c5d-5c8a-432d-8b24-90a0cbff1c05', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('94427b7c-6a1c-41ee-86b7-c12eb597bec3', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('fdaa37d2-672a-4884-a3cc-8527fd35a55a', TIMESTAMP '2025-02-14 13:13:22', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `PasswordHash` = 'uolP1gu/qGbU93kcPNR5a5xobk+XOzPthlf2DpyYdzZrkZ0wTrX6YY99R8KFAylY', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_5dbb@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_1_5dbb@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_1_5DBB@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_5DBB', `PasswordHash` = '/p2RQi6tYfYRlYI2GS1ywooL4xIsjwQltgxyoPALNwoIa1oO089fIwOLSj3MWEh3', `SecurityStamp` = 'user_1_5dbb@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_1_5dbb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_e17d@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_2_e17d@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_2_E17D@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_E17D', `PasswordHash` = 'kb3VpDikGZKzUVgWvED06p1BLZrK5AGKLHhfCBDJcAvOnOHeFh0V19HGZDi8VScF', `SecurityStamp` = 'user_2_e17d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_2_e17d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_75c9@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_3_75c9@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_3_75C9@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_75C9', `PasswordHash` = 'Pg/7Zecdg+Cwj1iVjtFzxdy+Ihu+lf/s4ostdWGm4SRJEI2gZOgz349xK02zlPUY', `SecurityStamp` = 'user_3_75c9@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_3_75c9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_9dc3@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_4_9dc3@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_4_9DC3@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_9DC3', `PasswordHash` = 'hZAKWgHjlLglVEIvYTIqkAKMr1Xz0/kFv22AIAGcxh1QeL3fUISQccsnbx5Ix+O+', `SecurityStamp` = 'user_4_9dc3@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_4_9dc3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_0340@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_5_0340@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_5_0340@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_0340', `PasswordHash` = 'ojnqT9py/k1H4c1gHCJGI/lTF84/bo59dHjVlsMwNouXidt0C2taffS5sD/AS0wu', `SecurityStamp` = 'user_5_0340@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_5_0340'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_1205@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_6_1205@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_6_1205@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_1205', `PasswordHash` = 'UEbVF8lrJGMw1NdqEEI8bmSNp+3K8UuxjZnySfnFKu79j44j75HDUDlRbs/8yn29', `SecurityStamp` = 'user_6_1205@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_6_1205'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_3765@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_7_3765@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_7_3765@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_3765', `PasswordHash` = 'H3kky7IfpH1V2dpEIC+oaOYelXonYZxF52CdoTBvZ0pUVKtw7mb1B6rl2YTwB5uW', `SecurityStamp` = 'user_7_3765@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_7_3765'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_2966@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_8_2966@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_8_2966@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_2966', `PasswordHash` = 'kr5pvfVbsJP9BKNUVdcdubdbaARJS/nPVyc4kpARZAj9Zs0R+PW1cNN8QFtA/Q2+', `SecurityStamp` = 'user_8_2966@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_8_2966'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_cf0c@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_9_cf0c@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_9_CF0C@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_CF0C', `PasswordHash` = 'fK5+FqGPRa64sI+T3zUZViWs6QijGsCrB9EGDBkFgLLotpait8Bp2+9TF9NA/uIv', `SecurityStamp` = 'user_9_cf0c@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_9_cf0c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_efc0@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `Email` = 'user_10_efc0@example.com', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `NormalizedEmail` = 'USER_10_EFC0@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_EFC0', `PasswordHash` = '5gT6MYI9eWxIPcPglgxHIUvmgqNB2FIRYDy7WBIGwI+UvGX89Qt4aGhwVEJI+JhO', `SecurityStamp` = 'user_10_efc0@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22', `UserName` = 'user_10_efc0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 13:13:22', `LastLogin` = TIMESTAMP '2025-02-14 13:13:22', `UpdatedAt` = TIMESTAMP '2025-02-14 13:13:22'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


CREATE UNIQUE INDEX `IX_Users_Email` ON `Users` (`Email`);

CREATE UNIQUE INDEX `IX_Users_NormalizedEmail` ON `Users` (`NormalizedEmail`);

CREATE UNIQUE INDEX `IX_Users_NormalizedUserName` ON `Users` (`NormalizedUserName`);

CREATE UNIQUE INDEX `IX_Users_UserName` ON `Users` (`UserName`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250214131323_AddUserUniqueConstraints', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '11195222-1910-488b-98b5-197377303d10';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '42905c6b-9cc2-4723-8c51-b7c9c2f11430';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '5c2c4777-be05-446d-bb56-26cbfe8f1a21';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6cc0a5b4-99dd-4fbb-9336-3faa02bcc87f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '859752a7-f92f-4f41-8345-8c2603a42ba7';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9e681651-3f8e-498f-99b0-3f196c88a616';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'af4b0629-e2d1-4805-8f18-d1425decf075';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b33d1172-a109-4a03-87b1-55e648f8e7db';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'ce867af2-bdb8-4d61-9498-d7fe9d965458';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f01697ae-3d19-4bb7-8849-358ccc8cb6e3';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'b94b53df-983d-49ee-8aab-e65b8c796b5a';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'bc6ef463-ba69-4133-b540-30e375aabaf5';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'ca96ef27-868a-4981-a1f0-c4df23eb6ca8';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'f83fabae-9f7c-411c-8849-a146834efc3b';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '19b858eb-c42e-44ad-a636-518f9a529606';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '2c0bddff-b45f-4837-9e95-4a6bbcf45119';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'cccc55d7-d5d5-4a07-ab58-38a50c261322';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'ccd2fcb8-f043-44ad-9b1b-dd7c89eff63a';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '0fdc2587-2425-4516-9cb3-d90a8b2dd653';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '285ca1b9-22ae-45a2-85ec-bf346deca57a';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '4dc35326-88b6-42be-b943-0a41e6937585';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'a3db5f4b-713d-424a-921c-4d1287f3aa4d';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'af0668c3-19c6-483b-9d52-eb8ba41092cb';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'd6987a20-0bb9-4c4b-9478-af118d5a43ec';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'b7943343-5153-43b6-896e-86e84deab981';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '18d2073c-18df-428e-85cb-d40b116bfcbc';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '3aad1ea8-4e31-4baa-97b4-44638dacbb4e';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4d90cdbf-5f88-4e67-bfdc-1465c20f1edf';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '8f9cc908-3a04-49b7-b8b5-e381abc770f1';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'acd96219-b79d-488d-9cea-241571d061e0';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'ca2144a0-bf2a-45d2-a054-8b2485eccd5d';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '50d88ee1-6518-4d4f-b9df-91dce466983b';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '622fcb6f-8859-40be-8230-3ceb1c6f77fe';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'aba70367-2324-4c4d-a88f-6602e5e5da8a';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'cdd25436-de12-40b4-8d4f-5c6d10a5c3cc';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '35289622-b39e-44f0-8d2d-7c800373659a';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '4c95384d-e490-43c2-9a6f-5f8466480dc5';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '581bb615-3722-45eb-91a6-0ebdef84b2d9';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '5c8d70ed-7bcc-4a5c-b5e5-0028d2325e3d';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '9e507964-a0cd-45f3-a5ef-dd57d2b06770';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '2a5d9c5d-5c8a-432d-8b24-90a0cbff1c05';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '94427b7c-6a1c-41ee-86b7-c12eb597bec3';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'fdaa37d2-672a-4884-a3cc-8527fd35a55a';
SELECT ROW_COUNT();


ALTER TABLE `Users` ADD `IsUser` tinyint(1) NOT NULL DEFAULT FALSE;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('0e22ddab-717e-42bf-8533-c8221f5302a3', 'Berlin', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('12b41a91-d6cc-4a8b-a263-e7fd36ff37a4', 'Rome', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('30689c8b-29fd-45e0-99aa-7a93e40b9218', 'Paris', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('4f8ed61b-17f0-4a53-a59e-5533bd1ca9ad', 'Bern', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('6b75fb1c-84d0-4d16-b3f5-e65bc9c23607', 'Amsterdam', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('76da300c-537e-4dd5-8aba-d9085bc142d2', 'Vienna', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('96c2c97d-690e-4234-818a-78d58c8cd08f', 'Brussels', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('9e5e9851-1a22-4fad-b438-2f01b12510c8', 'London', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('edfedafd-f09c-4715-a4e4-c89aa513b612', 'Madrid', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('f94b65af-8e26-4870-8115-80dda4caf41c', 'Luxembourg', TIMESTAMP '2025-02-14 14:15:07', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('172d42a2-4f40-4060-9f3d-8fbb49a7f674', 'USD', TIMESTAMP '2025-02-14 14:15:07', 2, TRUE, 'US Dollar', '$', NULL),
('3af61412-c3a7-426b-bf2b-43775fab8b53', 'EUR', TIMESTAMP '2025-02-14 14:15:07', 2, TRUE, 'Euro', '€', NULL),
('636775eb-d830-4d46-a042-1d55b675b342', 'CHF', TIMESTAMP '2025-02-14 14:15:07', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('fb1e9bb4-6d0b-407b-9077-c74793c33cac', 'GBP', TIMESTAMP '2025-02-14 14:15:07', 2, TRUE, 'British Pound', '£', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('430c3357-4abf-42aa-a395-4f160d9105ae', TIMESTAMP '2025-02-14 14:15:07', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL),
('48579b09-f674-41f3-909c-aabff0f21a62', TIMESTAMP '2025-02-14 14:15:07', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL),
('5fe0543d-7e70-4a83-9947-2ae5aa8a0e3e', TIMESTAMP '2025-02-14 14:15:07', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('e2031a74-33a7-404c-b6af-c95d5b41f331', TIMESTAMP '2025-02-14 14:15:07', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('16b949e7-b4a6-4a78-ad49-22082bad122b', TIMESTAMP '2025-02-14 14:15:07', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('2529ef8d-6d83-4af1-afe0-4e179f9cad88', TIMESTAMP '2025-02-14 14:15:07', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL),
('56daa222-05de-4dac-8c69-0770058dfb39', TIMESTAMP '2025-02-14 14:15:07', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('5c3e3197-0d7d-43a7-bf55-f2b88530e3e4', TIMESTAMP '2025-02-14 14:15:07', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('e31f149a-385b-4423-9498-a472dd5c38d1', TIMESTAMP '2025-02-14 14:15:07', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('fac3f6f8-84e6-4ec2-81bb-8eabe665869e', TIMESTAMP '2025-02-14 14:15:07', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('791601e7-db1b-4c47-943f-d39b13442b74', TIMESTAMP '2025-02-14 14:15:07', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('132f6378-c3b0-4a4b-ae1e-48758a54d1c4', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('6097b82f-2f65-4b4a-8365-610f329da128', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('671be8aa-b4ad-4bd8-b6f2-81147194c46e', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('7777983f-583f-4e81-8b95-9a464d991461', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL),
('a5a91b25-1d64-449e-8e8e-c667aa14a7f0', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL),
('e0232132-93e8-42be-a765-008707d82627', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('5e45c6b0-5adb-4d70-a92f-7866a09338fc', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('89beac11-2705-48a8-ad88-0f57a44cd400', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL),
('8b235b63-017c-4a2a-bcb6-2398dcdb0515', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL),
('f098f1a3-8692-4ce9-86f0-92557bfe3329', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('566319c2-4d49-4c7c-bc6a-3aaf3e506a3a', TIMESTAMP '2025-02-14 14:15:07', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('6b14cab7-7ab8-4ad9-8321-f52646782c0a', TIMESTAMP '2025-02-14 14:15:07', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('a28ebd2a-ec51-4776-b42f-124179b7b2af', TIMESTAMP '2025-02-14 14:15:07', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('c3b21ece-fe8e-4f06-82b5-68741eaed073', TIMESTAMP '2025-02-14 14:15:07', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('efcecd78-a5e8-4c46-9e18-7d8ecad2cbb9', TIMESTAMP '2025-02-14 14:15:07', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('4335f708-81f5-4978-9656-297f431dcb53', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('7e97d66c-db54-47f2-a37e-3c54d4f1b96d', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('e67b25cd-6079-4bb6-a9a1-2cd718f118bc', TIMESTAMP '2025-02-14 14:15:07', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL);

UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `PasswordHash` = '21O0ZZzxUly48wQU1wbHwpkiDgGnUaBVIsYDDw50zTQLRGEgkjnrIdkyoRaGxS2R', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_27ac@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_1_27ac@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_1_27AC@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_27AC', `PasswordHash` = 'TPYvYMTD2MT0HF2rtf8Dg1DYO6bbEea56ZK+UxfUh2J2rxsT5syDLHuscaadOLNZ', `SecurityStamp` = 'user_1_27ac@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_1_27ac'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_0e2b@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_2_0e2b@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_2_0E2B@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_0E2B', `PasswordHash` = '+QmUyNzGT/ENRiVHBAr3vp0flurbbVNsH9dya+8xB50yWMj6L5Hryy+RXScPbWGr', `SecurityStamp` = 'user_2_0e2b@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_2_0e2b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_05e6@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_3_05e6@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_3_05E6@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_05E6', `PasswordHash` = 'xFK5BIiuQsLAw+kkNrxtDMzGvkJHaIWvp4MM+sFOPgL4i/xQawPMQ56IEieTKveo', `SecurityStamp` = 'user_3_05e6@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_3_05e6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_8b11@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_4_8b11@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_4_8B11@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_8B11', `PasswordHash` = 'CF+Ud3s3kIpjf7JWp4BwFHtL0Ys1VeJ0B+We7M7n8htUvEBysazMcg6quUOZkXgQ', `SecurityStamp` = 'user_4_8b11@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_4_8b11'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_b7b7@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_5_b7b7@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_5_B7B7@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_B7B7', `PasswordHash` = 'Isd4uFid1hiCX8F5rYwsxiNSi1C4LWPzpCqgNcHnRmaRu96KIkJlKcI7zx75hKJD', `SecurityStamp` = 'user_5_b7b7@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_5_b7b7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_b911@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_6_b911@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_6_B911@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_B911', `PasswordHash` = 'y4jzrUyYijyNQQ6IGo+PZWtBRe+p+40gejUj0dRh/rSfo1xlLoPwnZy80Erlf7iT', `SecurityStamp` = 'user_6_b911@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_6_b911'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_672d@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_7_672d@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_7_672D@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_672D', `PasswordHash` = 'bezFTDkcW/tWp0+JHlNzFpCtsSoCGt50ZTP/yk6yLMuJSJPRiVtA1j2Ovh+WVgDR', `SecurityStamp` = 'user_7_672d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_7_672d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_be02@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_8_be02@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_8_BE02@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_BE02', `PasswordHash` = 'j4J5a0kvbRCkpSMuRyOfEWaMjMk5lCIRbixteCVEUCIjIhvssNfmtxZW0EPfcCsG', `SecurityStamp` = 'user_8_be02@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_8_be02'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_3b00@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_9_3b00@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_9_3B00@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_3B00', `PasswordHash` = '/oGrAHb5BryniXLN1fYE0v9XMOtgYPqbaco3gUnAiJKhifEWJssD68Fnb9FabHlA', `SecurityStamp` = 'user_9_3b00@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_9_3b00'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_7f38@example.com', `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `Email` = 'user_10_7f38@example.com', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `NormalizedEmail` = 'USER_10_7F38@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_7F38', `PasswordHash` = '5kON/sirrfwYdjLGgPy5S6w3tdQBQKgPzEQjn6XL2jmQRrWzXR8Nva8EIVFB7t3R', `SecurityStamp` = 'user_10_7f38@example.com', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07', `UserName` = 'user_10_7f38'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-14 14:15:07', `IsUser` = TRUE, `LastLogin` = TIMESTAMP '2025-02-14 14:15:07', `UpdatedAt` = TIMESTAMP '2025-02-14 14:15:07'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250214141510_UserUpdated', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '0e22ddab-717e-42bf-8533-c8221f5302a3';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '12b41a91-d6cc-4a8b-a263-e7fd36ff37a4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '30689c8b-29fd-45e0-99aa-7a93e40b9218';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '4f8ed61b-17f0-4a53-a59e-5533bd1ca9ad';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6b75fb1c-84d0-4d16-b3f5-e65bc9c23607';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '76da300c-537e-4dd5-8aba-d9085bc142d2';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '96c2c97d-690e-4234-818a-78d58c8cd08f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9e5e9851-1a22-4fad-b438-2f01b12510c8';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'edfedafd-f09c-4715-a4e4-c89aa513b612';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f94b65af-8e26-4870-8115-80dda4caf41c';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '172d42a2-4f40-4060-9f3d-8fbb49a7f674';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '3af61412-c3a7-426b-bf2b-43775fab8b53';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '636775eb-d830-4d46-a042-1d55b675b342';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'fb1e9bb4-6d0b-407b-9077-c74793c33cac';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '430c3357-4abf-42aa-a395-4f160d9105ae';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '48579b09-f674-41f3-909c-aabff0f21a62';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '5fe0543d-7e70-4a83-9947-2ae5aa8a0e3e';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'e2031a74-33a7-404c-b6af-c95d5b41f331';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '16b949e7-b4a6-4a78-ad49-22082bad122b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '2529ef8d-6d83-4af1-afe0-4e179f9cad88';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '56daa222-05de-4dac-8c69-0770058dfb39';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5c3e3197-0d7d-43a7-bf55-f2b88530e3e4';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'e31f149a-385b-4423-9498-a472dd5c38d1';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'fac3f6f8-84e6-4ec2-81bb-8eabe665869e';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '791601e7-db1b-4c47-943f-d39b13442b74';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '132f6378-c3b0-4a4b-ae1e-48758a54d1c4';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '6097b82f-2f65-4b4a-8365-610f329da128';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '671be8aa-b4ad-4bd8-b6f2-81147194c46e';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '7777983f-583f-4e81-8b95-9a464d991461';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'a5a91b25-1d64-449e-8e8e-c667aa14a7f0';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'e0232132-93e8-42be-a765-008707d82627';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '5e45c6b0-5adb-4d70-a92f-7866a09338fc';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '89beac11-2705-48a8-ad88-0f57a44cd400';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '8b235b63-017c-4a2a-bcb6-2398dcdb0515';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'f098f1a3-8692-4ce9-86f0-92557bfe3329';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '566319c2-4d49-4c7c-bc6a-3aaf3e506a3a';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '6b14cab7-7ab8-4ad9-8321-f52646782c0a';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'a28ebd2a-ec51-4776-b42f-124179b7b2af';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'c3b21ece-fe8e-4f06-82b5-68741eaed073';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'efcecd78-a5e8-4c46-9e18-7d8ecad2cbb9';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '4335f708-81f5-4978-9656-297f431dcb53';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '7e97d66c-db54-47f2-a37e-3c54d4f1b96d';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'e67b25cd-6079-4bb6-a9a1-2cd718f118bc';
SELECT ROW_COUNT();


ALTER TABLE `Users` MODIFY COLUMN `TwoFactorEnabled` tinyint(1) NULL;

ALTER TABLE `Users` MODIFY COLUMN `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` MODIFY COLUMN `EmailConfirmed` tinyint(1) NULL;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('0d190222-df5f-42e2-a505-8bd7566ba780', 'Brussels', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('118d9594-b6e0-4cf4-a898-2625d127eaca', 'Vienna', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('2d760cf0-93ba-44fe-b2e5-0cd7c8cabadc', 'Paris', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('34794100-f600-46ee-80ff-47b4de8da420', 'Amsterdam', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('46a63f03-b2e4-4c77-9ba3-c842eac92c95', 'Berlin', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('5385ccc9-961d-4862-bb7c-946ad1a71f8b', 'London', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('8df10e8e-0241-4d04-a0a4-1b482c86ed75', 'Luxembourg', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('a1688413-bd58-4da0-844d-9a2b5cc73675', 'Rome', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('b27bc846-2d6e-45d4-8366-393577d1a1c2', 'Madrid', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('eab8146e-abb6-4ea6-955e-d94554013def', 'Bern', TIMESTAMP '2025-02-15 16:25:28', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('1e8bfac0-3da4-4540-ac2c-8c39eb437620', 'GBP', TIMESTAMP '2025-02-15 16:25:28', 2, TRUE, 'British Pound', '£', NULL),
('7af89fdd-7c7f-4b54-b1f5-7db8257991f4', 'CHF', TIMESTAMP '2025-02-15 16:25:28', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('cca36f58-dd18-4117-a2fa-87b352312c2c', 'EUR', TIMESTAMP '2025-02-15 16:25:28', 2, TRUE, 'Euro', '€', NULL),
('f2da445d-91b1-4f77-9b9e-48a9238c56b5', 'USD', TIMESTAMP '2025-02-15 16:25:28', 2, TRUE, 'US Dollar', '$', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('6c4bb5b6-6a39-4e78-8df9-a8e228c7bf15', TIMESTAMP '2025-02-15 16:25:28', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('81439e93-7b04-45c4-86b9-e3035ccfd23f', TIMESTAMP '2025-02-15 16:25:28', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('eaa22042-94ba-458c-a0fb-f36fc5d1b155', TIMESTAMP '2025-02-15 16:25:28', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL),
('ee633307-9113-4278-a563-cc530bdb0435', TIMESTAMP '2025-02-15 16:25:28', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('19c5c181-4bef-4285-a233-64c26094f48f', TIMESTAMP '2025-02-15 16:25:28', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('6d5dc4e9-cc72-428d-8f0c-578865efe08b', TIMESTAMP '2025-02-15 16:25:28', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('a09d4c9f-7c3a-4885-9261-35d67ac4bf7b', TIMESTAMP '2025-02-15 16:25:28', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL),
('b30ba797-6e74-4c2e-8ad5-0b717e8c7829', TIMESTAMP '2025-02-15 16:25:28', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('de05f47e-e17d-46ef-b2a5-4c2321227655', TIMESTAMP '2025-02-15 16:25:28', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('e1fb25ea-bd0d-43be-847c-167103600a8e', TIMESTAMP '2025-02-15 16:25:28', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('e6cdf2ed-3516-4af5-b893-f3e1e7d8a0a9', TIMESTAMP '2025-02-15 16:25:28', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('431b2b60-a935-4303-9d5e-f63cb8726222', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL),
('9a1af83f-7753-49eb-8a61-1686cf6d07e8', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('b3f3dc5b-7bc4-4f90-b9d4-3289a704d285', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('c820b086-98d0-4b8c-ac13-c0b2e12c3e5d', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('f1d34870-9cf8-40d0-8909-c389cc7aedac', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL),
('fe86db55-3a8b-487d-9343-9fab843b7e8f', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('27481fe8-561b-41fe-89b3-c3dbd30d38d5', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('290a8a46-03b2-4ae0-abe3-89b7a2192d61', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('60fc34c7-2163-45aa-96a1-53e018aaa2d7', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL),
('d93b5d79-600c-41ef-822e-730de11759ec', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('359fc307-c83b-406d-aceb-3cb783a2a491', TIMESTAMP '2025-02-15 16:25:28', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('4875a43d-130e-4f74-88cc-e1ec67cb42d2', TIMESTAMP '2025-02-15 16:25:28', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('5bfe6331-1f0c-4397-8044-f2ee6c3ba56f', TIMESTAMP '2025-02-15 16:25:28', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('9a11634d-1a59-42a9-9011-a08f2fec9fa6', TIMESTAMP '2025-02-15 16:25:28', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('bcf404a8-ac63-4b04-a98b-1d760c72fd78', TIMESTAMP '2025-02-15 16:25:28', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('23912e1a-7aa0-4408-bf38-775966da4bc0', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('9576ab1b-7002-40e2-9998-2adbb8003f3a', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('e354948c-ba09-4984-abc1-b40e495b4ae5', TIMESTAMP '2025-02-15 16:25:28', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `ConcurrencyStamp` = 'demo_user@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `Email` = 'demo_user@example.com', `FirstName` = 'Demo User', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `LastName` = 'Account', `NormalizedEmail` = 'DEMO_USER@EXAMPLE.COM', `NormalizedUserName` = 'DEMO_USER', `PasswordHash` = 'nSNzsvmEqdFK2I3Y8M0okoVi3q0PnBpsJxPriLE6W6sodI7kkrMI3LNAK5qiKZKD', `SecurityStamp` = 'demo_user@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'demo_user'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_9a95@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-02-02 00:00:00', `Email` = 'user_1_9a95@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_1_9A95@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_9A95', `PasswordHash` = '66lBqJJ99GOEbNQxWmnc9yYswRzgw0hPuRWTdhIfp9577R+sQHHr+K8a+6zHb14r', `SecurityStamp` = 'user_1_9a95@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_1_9a95'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_b9fe@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-03-03 00:00:00', `Email` = 'user_2_b9fe@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_2_B9FE@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_B9FE', `PasswordHash` = 'pDukZBL3wuSsj58O8odS3EmkwOM09qHnCxZjvby5IjIp9O5Z10iH3tT0shsfTra3', `SecurityStamp` = 'user_2_b9fe@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_2_b9fe'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_5e90@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-04-04 00:00:00', `Email` = 'user_3_5e90@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_3_5E90@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_5E90', `PasswordHash` = 'mz/g/wLCNESBF7O9t43y3MSweHrROcLpuVf21HqUjCL2sDY+nyifAdo9pDtyaVs8', `SecurityStamp` = 'user_3_5e90@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_3_5e90'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_3d7e@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-05-05 00:00:00', `Email` = 'user_4_3d7e@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_4_3D7E@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_3D7E', `PasswordHash` = 'v77E12dkw1jG2ogSTCWpexfgHccGg0KvU16Gmcjc8BbF8UJCnD3Gqb/GcAXtt28h', `SecurityStamp` = 'user_4_3d7e@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_4_3d7e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_b182@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-06-06 00:00:00', `Email` = 'user_5_b182@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_5_B182@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_B182', `PasswordHash` = '1SxkNjR0ZC55Ho17dwzNhnTDusRYGC3SvCCBsq9/U8oBDikkidRbcaxCVw8yxu+o', `SecurityStamp` = 'user_5_b182@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_5_b182'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_e30e@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `Email` = 'user_6_e30e@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_6_E30E@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_E30E', `PasswordHash` = 'IWVBw6Pv8EO67f6XezvUZ1cBcDwP1MCUFyOJY10dXBYsQraHNOOHNwsufhSs+LDA', `SecurityStamp` = 'user_6_e30e@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_6_e30e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_2e2e@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-08-08 00:00:00', `Email` = 'user_7_2e2e@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_7_2E2E@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_2E2E', `PasswordHash` = 'l+8/C1ofkzgQvSHxDyOyu9zepftI50r0hCWlfl8KyQ4bjLOUOgBvTRKtqbKVLWz5', `SecurityStamp` = 'user_7_2e2e@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_7_2e2e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_798a@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-09-09 00:00:00', `Email` = 'user_8_798a@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_8_798A@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_798A', `PasswordHash` = 'Xagquy4Om74oGS0tNvXuKPX6U8BZRuR2dIm/55le2iPpQJxLUODPPKxmBqTabIZS', `SecurityStamp` = 'user_8_798a@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_8_798a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_2622@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-10-10 00:00:00', `Email` = 'user_9_2622@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_9_2622@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_2622', `PasswordHash` = '7tzeaZFqSKcgIDvc4KgEDFo+aBWgWL/yV670de7y5NPj/fIxOyvUikbk1DE27ts+', `SecurityStamp` = 'user_9_2622@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_9_2622'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_3f81@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `DateOfBirth` = TIMESTAMP '1975-11-11 00:00:00', `Email` = 'user_10_3f81@example.com', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `NormalizedEmail` = 'USER_10_3F81@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_3F81', `PasswordHash` = 'boyvrywVhiFLKAdaM4Y6iNQQ/DDsQtwHFemVHz9LdqhaGtqjtrgToU3TDpl/30EM', `SecurityStamp` = 'user_10_3f81@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'user_10_3f81'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'demo_admin@example.com', `CreatedAt` = TIMESTAMP '2025-02-15 16:25:28', `Email` = 'demo_admin@example.com', `FirstName` = 'Demo Admin', `LastLogin` = TIMESTAMP '2025-02-15 16:25:28', `LastName` = 'Account', `NormalizedEmail` = 'DEMO_ADMIN@EXAMPLE.COM', `NormalizedUserName` = 'DEMO_ADMIN', `PasswordHash` = '6mzry1T7QCj28LxTQqKZQkgSJ8K37EWReeW/DGm6LneB7II8Y/qFI3IVxJ1iyHwc', `SecurityStamp` = 'demo_admin@example.com', `UpdatedAt` = TIMESTAMP '2025-02-15 16:25:28', `UserName` = 'demo_admin'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `Users` (`Id`, `AccessFailedCount`, `Biography`, `ConcurrencyStamp`, `CreatedAt`, `CreatedBy`, `DateOfBirth`, `DeletedAt`, `DeletedBy`, `Email`, `EmailConfirmed`, `FailedLoginAttempts`, `FirstName`, `ForgotPasswordToken`, `ForgotPasswordTokenExpiration`, `IsActive`, `IsAdmin`, `IsBannedByAdmin`, `IsBlocked`, `IsDeleted`, `IsEditor`, `IsGuest`, `IsLockedOut`, `IsModerator`, `IsPending`, `IsStandardUser`, `IsSuperAdmin`, `IsUser`, `IsVerified`, `LastLogin`, `LastName`, `LinkUrl`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PasswordResetToken`, `PenName`, `PhoneNumber`, `PhoneNumberConfirmed`, `PostId`, `ProfilePicture`, `SecurityStamp`, `TwoFactorEnabled`, `UpdatedAt`, `UpdatedBy`, `UserName`, `Website`)
VALUES ('7fb725c6-3250-b856-604e-69f27e228fbf', 0, NULL, 'user_11_65ad@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1975-12-12 00:00:00', NULL, NULL, 'user_11_65ad@example.com', FALSE, 0, 'User 11', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_11_65AD@EXAMPLE.COM', 'USER_11_65AD', 'FQJ4ccjgY9/lW78oZUb6jP/31b53CdbRORcz0CjWWfTsqHWWaDtunQEOuGEmbL5U', NULL, NULL, '+1234567811', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_11_65ad@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_11_65ad', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc0', 0, NULL, 'user_12_c27d@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-01-13 00:00:00', NULL, NULL, 'user_12_c27d@example.com', FALSE, 0, 'User 12', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_12_C27D@EXAMPLE.COM', 'USER_12_C27D', '0JDXORWfhbZ0Rm/GdDYcOKVvaeSm43LT1rsoGdADGOTLCcdguhi1IziIaVnxy9eS', NULL, NULL, '+1234567812', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_12_c27d@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_12_c27d', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc1', 0, NULL, 'user_13_59a0@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-02-14 00:00:00', NULL, NULL, 'user_13_59a0@example.com', FALSE, 0, 'User 13', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_13_59A0@EXAMPLE.COM', 'USER_13_59A0', 'x37eaMDcpotQ0Twl4bw97jkPlBwMjhpHdDt5twssrdT4v7AHNG8nZ8PaR55UZuFg', NULL, NULL, '+1234567813', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_13_59a0@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_13_59a0', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc2', 0, NULL, 'user_14_a3b2@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-03-15 00:00:00', NULL, NULL, 'user_14_a3b2@example.com', FALSE, 0, 'User 14', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_14_A3B2@EXAMPLE.COM', 'USER_14_A3B2', 'nNeLReednPeBoGGJky9Lrstn3hFmNpfdQj1Zfyrcp+dUrqD9pNbhPD0cO4gk4vP7', NULL, NULL, '+1234567814', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_14_a3b2@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_14_a3b2', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc3', 0, NULL, 'user_15_9fdb@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-04-16 00:00:00', NULL, NULL, 'user_15_9fdb@example.com', FALSE, 0, 'User 15', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_15_9FDB@EXAMPLE.COM', 'USER_15_9FDB', 'fJroLo4AsHe6vOl7pE1TdFVjbQIVVqtcWHPITxwPNPGeXB8gikmB7ywnGvS9SjRS', NULL, NULL, '+1234567815', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_15_9fdb@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_15_9fdb', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc4', 0, NULL, 'user_16_15b4@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-05-17 00:00:00', NULL, NULL, 'user_16_15b4@example.com', FALSE, 0, 'User 16', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_16_15B4@EXAMPLE.COM', 'USER_16_15B4', 'VcAB/5+k/9S8I6uENm438ZRkaKglcZrzbNOA6zb+9c9u99cMj8rLHDIHtBUfUByG', NULL, NULL, '+1234567816', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_16_15b4@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_16_15b4', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc5', 0, NULL, 'user_17_6cfa@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-06-18 00:00:00', NULL, NULL, 'user_17_6cfa@example.com', FALSE, 0, 'User 17', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_17_6CFA@EXAMPLE.COM', 'USER_17_6CFA', 'sGXIAG9vdKr7SVyZm4WDfz1/4/M0x28JnmQHkBdHsoriuigvOtv1AI0R+mTUk0l8', NULL, NULL, '+1234567817', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_17_6cfa@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_17_6cfa', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc6', 0, NULL, 'user_18_9f12@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-07-19 00:00:00', NULL, NULL, 'user_18_9f12@example.com', FALSE, 0, 'User 18', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_18_9F12@EXAMPLE.COM', 'USER_18_9F12', 'WeK1CpqKvUDXlRXxrTprujfKGmPOe/kZ1s7UijEfHrAv2kuH/S+vGJoup01QnP2n', NULL, NULL, '+1234567818', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_18_9f12@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_18_9f12', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc7', 0, NULL, 'user_19_51d7@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-08-20 00:00:00', NULL, NULL, 'user_19_51d7@example.com', FALSE, 0, 'User 19', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_19_51D7@EXAMPLE.COM', 'USER_19_51D7', 'iaE2ZMHYGxU27OSdI9OKRkJtLIdlLq7RDVEdGTPlY2seqrhnwSe7shPIKw/AH/Lj', NULL, NULL, '+1234567819', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_19_51d7@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_19_51d7', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc8', 0, NULL, 'user_20_9e16@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-09-21 00:00:00', NULL, NULL, 'user_20_9e16@example.com', FALSE, 0, 'User 20', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_20_9E16@EXAMPLE.COM', 'USER_20_9E16', 'vFKWdPDZb8YPx1Y7G/Ae+hU+leeVvofWTCmrWYofaOaig3z3e67Zb1ATJxJ0v7pZ', NULL, NULL, '+1234567820', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_20_9e16@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_20_9e16', NULL),
('7fb725c6-3250-b856-604e-69f27e228fc9', 0, NULL, 'user_21_51b1@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-10-22 00:00:00', NULL, NULL, 'user_21_51b1@example.com', FALSE, 0, 'User 21', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_21_51B1@EXAMPLE.COM', 'USER_21_51B1', 'nMLxWAmIWtvI3OpMuJPFgNk5vOBTCbvQenNPIgjx9941QedIfVfbBwN1MonHFLzN', NULL, NULL, '+1234567821', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_21_51b1@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_21_51b1', NULL),
('7fb725c6-3250-b856-604e-69f27e228fca', 0, NULL, 'user_22_ab97@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-11-23 00:00:00', NULL, NULL, 'user_22_ab97@example.com', FALSE, 0, 'User 22', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_22_AB97@EXAMPLE.COM', 'USER_22_AB97', 'g1PBD/jj3hRY3LbDWA2l12QWNIoGzLB4HJuyrEFOupiGygIapOc0FJpS8TuJHbuu', NULL, NULL, '+1234567822', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_22_ab97@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_22_ab97', NULL),
('7fb725c6-3250-b856-604e-69f27e228fcb', 0, NULL, 'user_23_4bbb@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1976-12-24 00:00:00', NULL, NULL, 'user_23_4bbb@example.com', FALSE, 0, 'User 23', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_23_4BBB@EXAMPLE.COM', 'USER_23_4BBB', 'giHdyRpLDAVYuD0EQBqa0HLUUdk6RvTpya7yHIX/ZSEL/gQOCiAxpst4jQ9vt5u2', NULL, NULL, '+1234567823', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_23_4bbb@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_23_4bbb', NULL),
('7fb725c6-3250-b856-604e-69f27e228fcc', 0, NULL, 'user_24_8205@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-01-25 00:00:00', NULL, NULL, 'user_24_8205@example.com', FALSE, 0, 'User 24', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_24_8205@EXAMPLE.COM', 'USER_24_8205', 'aTeGRf/v5mfsPEWR48hPCklZwX1W9uwkL57af0Iz0iCArUVro0L9W8ETltO0Gv8z', NULL, NULL, '+1234567824', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_24_8205@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_24_8205', NULL),
('7fb725c6-3250-b856-604e-69f27e228fcd', 0, NULL, 'user_25_aee0@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-02-26 00:00:00', NULL, NULL, 'user_25_aee0@example.com', FALSE, 0, 'User 25', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_25_AEE0@EXAMPLE.COM', 'USER_25_AEE0', 'mb1ow7CL/1CEmYJ+MLX0rvHtkMIf/FDoJkCqVZVGjK70zzzdElp/WMfmJO/NzU4e', NULL, NULL, '+1234567825', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_25_aee0@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_25_aee0', NULL),
('7fb725c6-3250-b856-604e-69f27e228fce', 0, NULL, 'user_26_9360@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-03-27 00:00:00', NULL, NULL, 'user_26_9360@example.com', FALSE, 0, 'User 26', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_26_9360@EXAMPLE.COM', 'USER_26_9360', '/tFq8osDmkaYRwc+y3ueoMjxOH2vFLWqr93LJcvSmkncQnZigpoa/9ZbAxXj6tir', NULL, NULL, '+1234567826', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_26_9360@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_26_9360', NULL),
('7fb725c6-3250-b856-604e-69f27e228fcf', 0, NULL, 'user_27_dedf@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-04-28 00:00:00', NULL, NULL, 'user_27_dedf@example.com', FALSE, 0, 'User 27', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_27_DEDF@EXAMPLE.COM', 'USER_27_DEDF', 'P21DV2O8pdfUoLyzBqgpswWgVtIPrso98OmIBoBdcdZQlRBmJW3wis1k65p0GvIs', NULL, NULL, '+1234567827', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_27_dedf@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_27_dedf', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd0', 0, NULL, 'user_28_739d@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-05-01 00:00:00', NULL, NULL, 'user_28_739d@example.com', FALSE, 0, 'User 28', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_28_739D@EXAMPLE.COM', 'USER_28_739D', 'yRxNHzOr53IcU+SpzLuhG9vlNFBOHoiJqHbKKw4HXd/Zrudv1COCpNVGI+UW9Ir2', NULL, NULL, '+1234567828', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_28_739d@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_28_739d', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd1', 0, NULL, 'user_29_6b2b@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-06-02 00:00:00', NULL, NULL, 'user_29_6b2b@example.com', FALSE, 0, 'User 29', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_29_6B2B@EXAMPLE.COM', 'USER_29_6B2B', 'iyVK4+Z2PSTQlllJMS8Z1fFRRLDGiDE/pcvUsvYVPj6rR3YFy4kZteGIcO3pv4kg', NULL, NULL, '+1234567829', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_29_6b2b@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_29_6b2b', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd2', 0, NULL, 'user_30_5fed@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-07-03 00:00:00', NULL, NULL, 'user_30_5fed@example.com', FALSE, 0, 'User 30', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_30_5FED@EXAMPLE.COM', 'USER_30_5FED', 'OvZxG9glds8HTMSPYbxU+eFW2uQyf2sXzEHSQCMbVwU7sTd5uFKZveSNoag7/doF', NULL, NULL, '+1234567830', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_30_5fed@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_30_5fed', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd3', 0, NULL, 'user_31_9eaa@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-08-04 00:00:00', NULL, NULL, 'user_31_9eaa@example.com', FALSE, 0, 'User 31', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_31_9EAA@EXAMPLE.COM', 'USER_31_9EAA', 'H4VCywLJE53DhyTbdPLiv1/QpOG6xXUVkUd64SZIdDmV6wwA61ejp7FnI4I7F+hu', NULL, NULL, '+1234567831', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_31_9eaa@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_31_9eaa', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd4', 0, NULL, 'user_32_ebf6@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-09-05 00:00:00', NULL, NULL, 'user_32_ebf6@example.com', FALSE, 0, 'User 32', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_32_EBF6@EXAMPLE.COM', 'USER_32_EBF6', '69r8Umjdu8cB47loE0rRRFD1chkBZZeGa7au7595ueSUrFAETPQs8Peec24OPXnG', NULL, NULL, '+1234567832', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_32_ebf6@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_32_ebf6', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd5', 0, NULL, 'user_33_b17c@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-10-06 00:00:00', NULL, NULL, 'user_33_b17c@example.com', FALSE, 0, 'User 33', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_33_B17C@EXAMPLE.COM', 'USER_33_B17C', 'rgxJx0Oc1t/dBBqlvsyTl5Mshtorbale4wUHp6I+fmBdxjYDFPiZNjD+5VzDZc9U', NULL, NULL, '+1234567833', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_33_b17c@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_33_b17c', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd6', 0, NULL, 'user_34_01f4@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-11-07 00:00:00', NULL, NULL, 'user_34_01f4@example.com', FALSE, 0, 'User 34', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_34_01F4@EXAMPLE.COM', 'USER_34_01F4', 'HkR3iScO7+aPqJtrUKdETSol1KZx6gjW70g5H/nlNNz1qU9+5qi61FvVXvuwalu5', NULL, NULL, '+1234567834', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_34_01f4@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_34_01f4', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd7', 0, NULL, 'user_35_5c05@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1977-12-08 00:00:00', NULL, NULL, 'user_35_5c05@example.com', FALSE, 0, 'User 35', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_35_5C05@EXAMPLE.COM', 'USER_35_5C05', '1zGBJ437JOCa8YK4++f/U3rABb9VR6rmTBibi8NMyskHAOduXAU2zQ599lDHrDPq', NULL, NULL, '+1234567835', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_35_5c05@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_35_5c05', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd8', 0, NULL, 'user_36_5073@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-01-09 00:00:00', NULL, NULL, 'user_36_5073@example.com', FALSE, 0, 'User 36', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_36_5073@EXAMPLE.COM', 'USER_36_5073', 'rDsotMhFM1EMqjQ/pP7ZCtraYAh29QvW2/5iIJnTv2BuZ7oUqOeZJ0s7rTRX20ej', NULL, NULL, '+1234567836', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_36_5073@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_36_5073', NULL),
('7fb725c6-3250-b856-604e-69f27e228fd9', 0, NULL, 'user_37_376c@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-02-10 00:00:00', NULL, NULL, 'user_37_376c@example.com', FALSE, 0, 'User 37', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_37_376C@EXAMPLE.COM', 'USER_37_376C', 'wa1PETGMs4epFBtGaLuc80UbO5eaBhTZnDxBpm7FIpZrTBViEoV8e+gi/ChF/+lM', NULL, NULL, '+1234567837', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_37_376c@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_37_376c', NULL),
('7fb725c6-3250-b856-604e-69f27e228fda', 0, NULL, 'user_38_df74@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-03-11 00:00:00', NULL, NULL, 'user_38_df74@example.com', FALSE, 0, 'User 38', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_38_DF74@EXAMPLE.COM', 'USER_38_DF74', '5J4XGlqcIkBaES9sVeCDj6+abE1aSJesVqVjjo2R81mvkiKQ2PJs/VqtVJ+5QDzy', NULL, NULL, '+1234567838', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_38_df74@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_38_df74', NULL),
('7fb725c6-3250-b856-604e-69f27e228fdb', 0, NULL, 'user_39_335c@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-04-12 00:00:00', NULL, NULL, 'user_39_335c@example.com', FALSE, 0, 'User 39', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_39_335C@EXAMPLE.COM', 'USER_39_335C', 'M8+QSjgTkvO8MhkoL8ofHDSkuQuyBWyNqyCevUOTdR7MkbPevs1XU2UUawrmvavg', NULL, NULL, '+1234567839', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_39_335c@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_39_335c', NULL),
('7fb725c6-3250-b856-604e-69f27e228fdc', 0, NULL, 'user_40_74dd@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-05-13 00:00:00', NULL, NULL, 'user_40_74dd@example.com', FALSE, 0, 'User 40', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_40_74DD@EXAMPLE.COM', 'USER_40_74DD', '2kp/MxmabHFJ7URnZJuK17qFlIR2Dk7yohS4+mC9dyTvl8pJ6OE9pWEziiPqcmtP', NULL, NULL, '+1234567840', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_40_74dd@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_40_74dd', NULL),
('7fb725c6-3250-b856-604e-69f27e228fdd', 0, NULL, 'user_41_dbf6@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-06-14 00:00:00', NULL, NULL, 'user_41_dbf6@example.com', FALSE, 0, 'User 41', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_41_DBF6@EXAMPLE.COM', 'USER_41_DBF6', 'dLsQI4F9REf8mL3SMM4o5UrEoGQxi+sIYh+IAfU9an+l7c1D5e1dSwMs5rBQlLoG', NULL, NULL, '+1234567841', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_41_dbf6@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_41_dbf6', NULL),
('7fb725c6-3250-b856-604e-69f27e228fde', 0, NULL, 'user_42_ac54@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-07-15 00:00:00', NULL, NULL, 'user_42_ac54@example.com', FALSE, 0, 'User 42', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_42_AC54@EXAMPLE.COM', 'USER_42_AC54', 'Ljw+9Q71UN7vkoonuMGUjSmLprIlv/04GKayUPCvf7m1whTuP1sggdBghqp0cCBm', NULL, NULL, '+1234567842', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_42_ac54@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_42_ac54', NULL),
('7fb725c6-3250-b856-604e-69f27e228fdf', 0, NULL, 'user_43_e64a@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-08-16 00:00:00', NULL, NULL, 'user_43_e64a@example.com', FALSE, 0, 'User 43', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_43_E64A@EXAMPLE.COM', 'USER_43_E64A', '0Nmy+nAno0EorsgqDi5DjbL1sNlnl4zJNMOqF9UetruGHTdYuWeweLH3774gGIEf', NULL, NULL, '+1234567843', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_43_e64a@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_43_e64a', NULL),
('7fb725c6-3250-b856-604e-69f27e228fe0', 0, NULL, 'user_44_e037@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-09-17 00:00:00', NULL, NULL, 'user_44_e037@example.com', FALSE, 0, 'User 44', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_44_E037@EXAMPLE.COM', 'USER_44_E037', 'kYYR/iQQfGL/9zmte75dB88Unhk3R/rksRSuQCU7Aam/BN9VK+AZ0vMfVtjAn7BQ', NULL, NULL, '+1234567844', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_44_e037@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_44_e037', NULL),
('7fb725c6-3250-b856-604e-69f27e228fe1', 0, NULL, 'user_45_8568@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-10-18 00:00:00', NULL, NULL, 'user_45_8568@example.com', FALSE, 0, 'User 45', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_45_8568@EXAMPLE.COM', 'USER_45_8568', 'c8IrhAohbETi/TcKLVYqAoaG0i9HdyoeuoeEv8cEprgacdn1D+EEILDbF2NY0L65', NULL, NULL, '+1234567845', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_45_8568@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_45_8568', NULL),
('7fb725c6-3250-b856-604e-69f27e228fe2', 0, NULL, 'user_46_b6bc@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-11-19 00:00:00', NULL, NULL, 'user_46_b6bc@example.com', FALSE, 0, 'User 46', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_46_B6BC@EXAMPLE.COM', 'USER_46_B6BC', '9/TzGahAhOoIMD9nvSNa6g5jdPO/k8mtmmpgvxu55ggd3GouMJhD7rIF/YTy6hZR', NULL, NULL, '+1234567846', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_46_b6bc@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_46_b6bc', NULL),
('7fb725c6-3250-b856-604e-69f27e228fe3', 0, NULL, 'user_47_345b@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1978-12-20 00:00:00', NULL, NULL, 'user_47_345b@example.com', FALSE, 0, 'User 47', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_47_345B@EXAMPLE.COM', 'USER_47_345B', 'mXdpcOEDo3V6Bh4XP6ugg/8FByAYI5GXZ/qMpHlpY6KIgSwcNV2y617guSgjOpn2', NULL, NULL, '+1234567847', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_47_345b@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_47_345b', NULL),
('7fb725c6-3250-b856-604e-69f27e228fe4', 0, NULL, 'user_48_1cb6@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1979-01-21 00:00:00', NULL, NULL, 'user_48_1cb6@example.com', FALSE, 0, 'User 48', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_48_1CB6@EXAMPLE.COM', 'USER_48_1CB6', 'h3JtrotqGHhYunJSsCfRJyWXPt/DaCR/p3ITkEPHkW9SlQUbnbAcUvge6RtvW6qR', NULL, NULL, '+1234567848', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_48_1cb6@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_48_1cb6', NULL),
('7fb725c6-3250-b856-604e-69f27e228fe5', 0, NULL, 'user_49_bc45@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1979-02-22 00:00:00', NULL, NULL, 'user_49_bc45@example.com', FALSE, 0, 'User 49', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_49_BC45@EXAMPLE.COM', 'USER_49_BC45', 'u8bRYouTzDZnirCzKgrhZUFE/WPqNcmO5qZoCrG/0ZJzGcTU6S4BusWY8fyyEW+E', NULL, NULL, '+1234567849', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_49_bc45@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_49_bc45', NULL),
('7fb725c6-3250-b856-604e-69f27e228fe6', 0, NULL, 'user_50_cafc@example.com', TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1979-03-23 00:00:00', NULL, NULL, 'user_50_cafc@example.com', FALSE, 0, 'User 50', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-15 16:25:28', 'Example', NULL, FALSE, NULL, NULL, 'USER_50_CAFC@EXAMPLE.COM', 'USER_50_CAFC', 'PzjkNgaGlQxBliveK8khASoy7zxQl3/DJdSpaXhNBzf8gS51STyOKVZ9eBlkLzzG', NULL, NULL, '+1234567850', TRUE, NULL, 'https://asafarim.com/logoT.svg', 'user_50_cafc@example.com', FALSE, TIMESTAMP '2025-02-15 16:25:28', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'user_50_cafc', NULL);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250215162530_UserSeeded', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '0d190222-df5f-42e2-a505-8bd7566ba780';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '118d9594-b6e0-4cf4-a898-2625d127eaca';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '2d760cf0-93ba-44fe-b2e5-0cd7c8cabadc';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '34794100-f600-46ee-80ff-47b4de8da420';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '46a63f03-b2e4-4c77-9ba3-c842eac92c95';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '5385ccc9-961d-4862-bb7c-946ad1a71f8b';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '8df10e8e-0241-4d04-a0a4-1b482c86ed75';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a1688413-bd58-4da0-844d-9a2b5cc73675';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b27bc846-2d6e-45d4-8366-393577d1a1c2';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'eab8146e-abb6-4ea6-955e-d94554013def';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '1e8bfac0-3da4-4540-ac2c-8c39eb437620';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '7af89fdd-7c7f-4b54-b1f5-7db8257991f4';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'cca36f58-dd18-4117-a2fa-87b352312c2c';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'f2da445d-91b1-4f77-9b9e-48a9238c56b5';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '6c4bb5b6-6a39-4e78-8df9-a8e228c7bf15';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '81439e93-7b04-45c4-86b9-e3035ccfd23f';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'eaa22042-94ba-458c-a0fb-f36fc5d1b155';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'ee633307-9113-4278-a563-cc530bdb0435';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '19c5c181-4bef-4285-a233-64c26094f48f';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '6d5dc4e9-cc72-428d-8f0c-578865efe08b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'a09d4c9f-7c3a-4885-9261-35d67ac4bf7b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'b30ba797-6e74-4c2e-8ad5-0b717e8c7829';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'de05f47e-e17d-46ef-b2a5-4c2321227655';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'e1fb25ea-bd0d-43be-847c-167103600a8e';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'e6cdf2ed-3516-4af5-b893-f3e1e7d8a0a9';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '431b2b60-a935-4303-9d5e-f63cb8726222';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '9a1af83f-7753-49eb-8a61-1686cf6d07e8';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b3f3dc5b-7bc4-4f90-b9d4-3289a704d285';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'c820b086-98d0-4b8c-ac13-c0b2e12c3e5d';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'f1d34870-9cf8-40d0-8909-c389cc7aedac';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'fe86db55-3a8b-487d-9343-9fab843b7e8f';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '27481fe8-561b-41fe-89b3-c3dbd30d38d5';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '290a8a46-03b2-4ae0-abe3-89b7a2192d61';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '60fc34c7-2163-45aa-96a1-53e018aaa2d7';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'd93b5d79-600c-41ef-822e-730de11759ec';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '359fc307-c83b-406d-aceb-3cb783a2a491';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '4875a43d-130e-4f74-88cc-e1ec67cb42d2';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '5bfe6331-1f0c-4397-8044-f2ee6c3ba56f';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '9a11634d-1a59-42a9-9011-a08f2fec9fa6';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'bcf404a8-ac63-4b04-a98b-1d760c72fd78';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '23912e1a-7aa0-4408-bf38-775966da4bc0';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '9576ab1b-7002-40e2-9998-2adbb8003f3a';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'e354948c-ba09-4984-abc1-b40e495b4ae5';
SELECT ROW_COUNT();


ALTER TABLE `Users` ADD `PasswordResetTokenExpiration` datetime(6) NULL;

ALTER TABLE `Users` ADD `ReactivationReason` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Users` ADD `ReactivationRequestedAt` datetime(6) NULL;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('06c8a551-c8c5-49cd-b643-c1a3971a1859', 'Rome', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('36a3043a-b8d1-4e79-8c5e-619fc3392d8a', 'Bern', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('3d28ea38-e147-4360-b0af-19a88135d6f7', 'London', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('778154a8-7a17-4fad-b70c-04390b7269ae', 'Brussels', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('7f60492c-f6d6-4b01-95c7-2d344f4131c1', 'Paris', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('a595695e-7244-4dba-91da-ef65d950d6a2', 'Amsterdam', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('b185d158-017e-438f-9084-1f52943931a3', 'Madrid', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('c170a298-0f10-457a-884d-fe4828eb9d1c', 'Vienna', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('c8fec41b-acd7-460d-b387-477ab8b893e4', 'Luxembourg', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('d0e8c398-9641-4198-a35e-af4c8cbf894d', 'Berlin', TIMESTAMP '2025-02-16 14:58:30', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('3ea535f6-e9c7-4203-928d-2662d5f8eaba', 'GBP', TIMESTAMP '2025-02-16 14:58:30', 2, TRUE, 'British Pound', '£', NULL),
('6393799a-4356-43b7-ab67-fee9a3b76eae', 'USD', TIMESTAMP '2025-02-16 14:58:30', 2, TRUE, 'US Dollar', '$', NULL),
('6deefca2-8c56-453e-ab03-ee777f61187b', 'CHF', TIMESTAMP '2025-02-16 14:58:30', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('b9981069-f25e-4b60-8b7e-ae63f6844ef7', 'EUR', TIMESTAMP '2025-02-16 14:58:30', 2, TRUE, 'Euro', '€', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('055e9e01-e069-42d2-94cb-4e0c75f2fbd9', TIMESTAMP '2025-02-16 14:58:30', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('70a7c311-d893-4dce-8ea9-e919c11a88a6', TIMESTAMP '2025-02-16 14:58:30', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL),
('ace5e81f-42da-42ef-90a1-dc8a770c8103', TIMESTAMP '2025-02-16 14:58:30', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('eb319d94-2c87-4db3-aecb-bb35c30b6d3f', TIMESTAMP '2025-02-16 14:58:30', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('0fd17864-0a05-4134-97c8-e5788d06284c', TIMESTAMP '2025-02-16 14:58:30', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('32ad67d2-1c3c-4054-b74b-6147620f8eee', TIMESTAMP '2025-02-16 14:58:30', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('64284b75-1b9c-4696-b1da-cd9bfd44897b', TIMESTAMP '2025-02-16 14:58:30', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('9741619e-0617-4fd4-9b06-69f430fc0d3f', TIMESTAMP '2025-02-16 14:58:30', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('ab1c444d-d4aa-4062-93a9-c0640063ad47', TIMESTAMP '2025-02-16 14:58:30', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL),
('d2ea900f-5cf0-4730-9029-db46f160257e', TIMESTAMP '2025-02-16 14:58:30', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('2afb9d8a-0632-44d6-9b84-9d2fdd45286e', TIMESTAMP '2025-02-16 14:58:30', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0d4dc5d6-dc85-414f-843f-a2dbf413fa03', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL),
('4d38ea0e-1978-4ca2-84c4-82a6e241adc4', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('83793248-a7da-4910-8874-ba32daa8e31b', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('8eaf27f8-ae32-4593-b1b8-fadcdd0ef1b4', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('9f22226c-5b44-4a9c-88ff-4b0e7f172979', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL),
('c7766dfb-fefa-41fe-a936-4b9ef505dffb', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('0b941b36-14a8-493c-971d-c5429ddd35cd', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL),
('137af052-56e7-454b-bfe2-30c187c29ed5', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL),
('33c48aeb-01fd-4e44-8a72-0d1706eef070', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('53468b15-3b44-4927-acb8-2a5cbed415c4', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('361211cf-b50a-45ba-9eac-4e8fc8bc32ee', TIMESTAMP '2025-02-16 14:58:30', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('4453b21c-2b72-4f74-998d-a0d2ab98d09b', TIMESTAMP '2025-02-16 14:58:30', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('62e9040b-0376-4bd9-8404-0f14c8199ea7', TIMESTAMP '2025-02-16 14:58:30', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('8944f0c6-4566-488a-a1e4-0d192c08f6c6', TIMESTAMP '2025-02-16 14:58:30', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('d2ec402e-7000-48bd-b290-43ffffdf70d0', TIMESTAMP '2025-02-16 14:58:30', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1dd7f781-a870-4b61-b855-6a5e9792fe54', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('27736283-a5eb-41aa-9f8c-f3295430d698', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('ffe9503a-9b24-4875-8ef6-9ef423bcd1c3', TIMESTAMP '2025-02-16 14:58:30', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `IsAdmin` = FALSE, `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `PasswordHash` = 'nMzZyX9BL3fOz7xr19tm26hZSToATMS7FoTUHVH4yoFxfU5UqnxwYjOn0gSXyX5M', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_332e@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_1_332e@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_1_332E@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_332E', `PasswordHash` = '3bu7OICkfpZ78Stk2cAc6Lu/ue/wZPMK8/kzWOI/GXd6N898FqB0nCd6Gh1VaA7q', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_1_332e@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_1_332e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_1d32@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_2_1d32@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_2_1D32@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_1D32', `PasswordHash` = 'sY6TzmtYfeRstuEMMgmxbov0p2O/G9K3DzO6hiqlTh1BfGhkAvvtGEae7faJAHeV', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_2_1d32@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_2_1d32'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_7ee4@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_3_7ee4@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_3_7EE4@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_7EE4', `PasswordHash` = '2IFuFA/vEQH6/RICZ41ehDjvb77Jc5L8mH/kMf9qahxvAnNAMVrysOsD+dkokeET', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_3_7ee4@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_3_7ee4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_655b@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_4_655b@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_4_655B@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_655B', `PasswordHash` = '8YYignsoCTPPIte7WPen6P5rEj7os1p5usont1i6vX/2uslcgN53iImI4cs9g6JC', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_4_655b@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_4_655b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_306b@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_5_306b@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_5_306B@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_306B', `PasswordHash` = 'rzoISCS5cHPJ8a8coWTsFLVCI3hMUKUmc3rugHGKAiAmexBAC+FJoPipQ+pJieN5', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_5_306b@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_5_306b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_5cf7@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_6_5cf7@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_6_5CF7@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_5CF7', `PasswordHash` = 'oSFkIc5cwOSufrOolw1+K67vJPmlQye5vbn7saa6GwNQ9FBwbWMl0nvqiv+Na/uP', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_6_5cf7@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_6_5cf7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_82d8@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_7_82d8@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_7_82D8@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_82D8', `PasswordHash` = 'crkIYykeuzGNfUJll6B6kCA0XfDiIJwIqMCRCSpX8DDTpCEgvJ/JWYcc4RD8TQJ+', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_7_82d8@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_7_82d8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_d28d@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_8_d28d@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_8_D28D@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_D28D', `PasswordHash` = 'ZIeT0UNMHDmmDpAvzFnoXpJE+1ERKoUH+jtGoOt7N/49ubewuj/IjNBsjifT5uB7', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_8_d28d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_8_d28d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_7e20@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_9_7e20@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_9_7E20@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_7E20', `PasswordHash` = 'vrm5E09OoHMnozqcWCV5hk9C1cCwpL3LQv/MpPN9L0Ck0Eq9nt7sDP0DjH7CvXIj', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_9_7e20@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_9_7e20'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_c6ad@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_10_c6ad@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_10_C6AD@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_C6AD', `PasswordHash` = 'RjUhvqmj/R2xYdw3Fh5lqrJQnr06sWLrlHhV1Q7icscx2km/yj47ibQ5ZEsPCGtc', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_10_c6ad@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_10_c6ad'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_dba4@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_11_dba4@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_11_DBA4@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_DBA4', `PasswordHash` = 'TGJvWfxL1npRHKFS+nw2DcP4dDWd4nslVXsO/WTTnTQU37EfVTUg6jwawNNplL1d', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_11_dba4@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_11_dba4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_ab1a@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_12_ab1a@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_12_AB1A@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_AB1A', `PasswordHash` = 'LI6IZQH8UP7PNVzQBq1z43UMZX03hYSpWsHGTu08L7wO0sZvpcOHi+vccGqr9KNX', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_12_ab1a@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_12_ab1a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_9921@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_13_9921@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_13_9921@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_9921', `PasswordHash` = 'msX+c1AtcYQ2xy5HeSw2cfQSmbbAAM9JM/NSQ10Ip3mbrwQWh3plBGlDs5R1TipQ', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_13_9921@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_13_9921'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_9b76@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_14_9b76@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_14_9B76@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_9B76', `PasswordHash` = 'IVk1pa5K0tYTOQpND3+ea5ioPeBgmLcDwLOE9OyDU0mAqG7BbiZQWSATe3b6duPm', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_14_9b76@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_14_9b76'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_9588@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_15_9588@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_15_9588@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_9588', `PasswordHash` = 'v+lcUKFZK7dgcL7QvcHPSOBS9dp0pY//J6Tls5bAH8N+Iblv9df7nWH6dFZDBlAI', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_15_9588@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_15_9588'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_aaba@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_16_aaba@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_16_AABA@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_AABA', `PasswordHash` = '1fqdyEqNAx8/dUa5KUprS+C3ZnJxOvTlDvLoexb2rUph9qJRFvU4h3gtgZO0sx+x', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_16_aaba@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_16_aaba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_daac@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_17_daac@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_17_DAAC@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_DAAC', `PasswordHash` = '0Pf1v0gxtKk23P8i+2UtnqhiGnIK9tR5cyDKUg11+wAbCS/uSuAqnGPNB4Daw7HH', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_17_daac@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_17_daac'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_425d@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_18_425d@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_18_425D@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_425D', `PasswordHash` = '89e/jgRr8dd+368apHERuZPY9sEyP3meS3Xj/nMY+itcuUn7R39hXyHCCXZn+31p', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_18_425d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_18_425d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_37b1@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_19_37b1@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_19_37B1@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_37B1', `PasswordHash` = '5Thiy90jgTr9Wv+Vm4eZXUXh2VpfVWOCAOXI/jjixstOMrroKzNeJvwSAz6PJHyM', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_19_37b1@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_19_37b1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_a0c7@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_20_a0c7@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_20_A0C7@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_A0C7', `PasswordHash` = 'WcGiw4bkfHrsXMMr5Z2j5ISIVc0GEBZpbkKVeDQ6OawK0GcXquthJOUOINmhdurQ', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_20_a0c7@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_20_a0c7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_84c9@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_21_84c9@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_21_84C9@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_84C9', `PasswordHash` = '7xGXTs5cGlRAX2McvYm9reOwVJqGpSye18cXzzWMY0LlQWTrto38wmJb9EKrgoEg', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_21_84c9@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_21_84c9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_6fe0@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_22_6fe0@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_22_6FE0@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_6FE0', `PasswordHash` = 'D4PNw6C/BIRlVoH0kf0lnQu4L+0T0mEC6jvLD/POpF9nif6jB1FYUQUyIyz4pqCa', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_22_6fe0@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_22_6fe0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_273d@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_23_273d@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_23_273D@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_273D', `PasswordHash` = 'j4TNxmwPQH9vJrBXuYNlrMF2TUIm/YYE8ZkjAAcBue08LeAfmqkUASSws9sZSZM3', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_23_273d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_23_273d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_a0a3@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_24_a0a3@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_24_A0A3@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_A0A3', `PasswordHash` = 'qLrlm9PLeovyx/0E6jqYJWnSqDIPKTSf2rSvI25dK9WgUb+ZHw3OvsU5XlgQyG8d', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_24_a0a3@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_24_a0a3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_2709@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_25_2709@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_25_2709@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_2709', `PasswordHash` = '76VidI8xon36d9sBhB5eoQDb3TeqVRz1w3nT91UNaE8ToYAaXluFlp9eje+/oNhh', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_25_2709@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_25_2709'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_f15e@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_26_f15e@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_26_F15E@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_F15E', `PasswordHash` = 'c50iSrbzLdFKaCN91SLwJ2s6cbnZUZVezL133l4XxHdYPTDMxYOv8WtgvUVBtOZ5', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_26_f15e@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_26_f15e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_786b@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_27_786b@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_27_786B@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_786B', `PasswordHash` = '8DZKLRBTQ6wM70+0h0wyfxi8Mb9HrhpEaF7fjAT4SA9SUqF20wrPYFFdzoUnRp6f', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_27_786b@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_27_786b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_b52f@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_28_b52f@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_28_B52F@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_B52F', `PasswordHash` = 'YDJRVuMe3eRgcseJ0A9NQyM6WHRJFjZYW2z16pGq86dUFZpcsnG81KTCJU9xj5of', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_28_b52f@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_28_b52f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_f37f@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_29_f37f@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_29_F37F@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_F37F', `PasswordHash` = '3VEH5hhuhpc9N02sH3It+mzEQO9ganXGDBGxGr3QKVZwQjph4AC+NyAKI8FbZ+/2', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_29_f37f@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_29_f37f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_c4c7@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_30_c4c7@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_30_C4C7@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_C4C7', `PasswordHash` = 'hLJR4djFmOlYBHPA7mxDPfB8LM0FynQOZh1ETweObvGJILgMERlKSrp/SO6GqmEh', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_30_c4c7@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_30_c4c7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_18ee@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_31_18ee@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_31_18EE@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_18EE', `PasswordHash` = '4gS04y1Js5cZExm1uE4NXHbYpiZT+O2kJ7/n6a1Xt9y1OHBpsLSayqABGod5twpz', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_31_18ee@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_31_18ee'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_06ba@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_32_06ba@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_32_06BA@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_06BA', `PasswordHash` = 'WYDamRCmCqDCg0qs+fb+Mf6MQUp/Mf9gIAqIvSgGhej9P4xqjCr7N5SbUnddzfZb', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_32_06ba@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_32_06ba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_c69d@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_33_c69d@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_33_C69D@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_C69D', `PasswordHash` = 'vJTmDgwRiBjgFfGvKRmlvIGr/OQdhWNK3hVfPHW5Wo98pxwf7kPrd8X6kqXXi0H6', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_33_c69d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_33_c69d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_3660@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_34_3660@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_34_3660@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_3660', `PasswordHash` = 'zFOcJtfMa8fG8BmuMcrqTCbMSRxRlF9ONna/7+4oiXBoZqrz7tRRLWb13W22F3O3', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_34_3660@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_34_3660'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_1174@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_35_1174@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_35_1174@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_1174', `PasswordHash` = 'q4+UOCYKGOGM6/Q0zpW4KY9AHfi1yXy/hUkPQateawiBbjBBGp9OcMfTSXy9nn1t', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_35_1174@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_35_1174'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_ce26@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_36_ce26@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_36_CE26@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_CE26', `PasswordHash` = '5TGWj+Dh/kz79iRmPQw0JqOG4s37KxzFR5nuYUxyHKabR2JD9Jx/iTTWgMTW6PWX', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_36_ce26@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_36_ce26'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_1cb7@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_37_1cb7@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_37_1CB7@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_1CB7', `PasswordHash` = 'lz4ny9g+vyfgQVq50qW4dtZlf5RwKnSOTDOz2Tc6C1AHwc2EBC7AU2vhaeAR6ed/', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_37_1cb7@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_37_1cb7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_ea87@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_38_ea87@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_38_EA87@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_EA87', `PasswordHash` = 'G37uShdARkkGOp0sG82ala0E/uOQnAqvM8yx8MR7PN3HGLkV5x64q+6kFwKaSRwE', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_38_ea87@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_38_ea87'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_33fc@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_39_33fc@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_39_33FC@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_33FC', `PasswordHash` = 'BgdYRlla2PbtLiaRaWHmFtXhr5rx060U3axyJWeFIP0HyODqI52ZJu/bPllsry+U', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_39_33fc@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_39_33fc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_0768@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_40_0768@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_40_0768@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_0768', `PasswordHash` = 'BbG/sVVNfA49P2y0LDSij8OZwIGr+li/2FcGGNKpR8xOb7g9nkOiKILjMM8Xk7xy', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_40_0768@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_40_0768'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_9211@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_41_9211@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_41_9211@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_9211', `PasswordHash` = 'Z3QYMC0ltgozy+K2XMMG/FRNog1yD1BmQVawcKH2yHHDguf2Qv5qOffyppgJnJAc', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_41_9211@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_41_9211'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_39b4@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_42_39b4@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_42_39B4@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_39B4', `PasswordHash` = 'lrnpbfpRBsZ8O7J4jYdJ7xe9sO9K6tP+sModJJxtwGgL6aE8UbSuYbCaN5ToWjSu', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_42_39b4@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_42_39b4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_1f1e@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_43_1f1e@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_43_1F1E@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_1F1E', `PasswordHash` = 'H3AOdjOxohBcAq8QrjvmIDqF1WvptEIsM6W/i5ZRjEv5UzY7pVZUg06BzpMQbPMS', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_43_1f1e@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_43_1f1e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_015d@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_44_015d@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_44_015D@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_015D', `PasswordHash` = 'lLH35CSD1t7TZ6EfW9X3UTYLlP8YVbsPlgyFR92uqidYDG+k97K4IjLci0sxEnYP', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_44_015d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_44_015d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_6359@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_45_6359@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_45_6359@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_6359', `PasswordHash` = 'veifljGaztp066nNX6jQkrYo8dN1LE8lc1DNvAPckCixKtuA2p1wuvb8WMsbELv6', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_45_6359@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_45_6359'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_47ab@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_46_47ab@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_46_47AB@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_47AB', `PasswordHash` = 'Fh2CoGG88uWogXovL0RLuPFZfcNkYUnAnXzHLNZxbcMEiC06OO7wAYTzCeev4oDP', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_46_47ab@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_46_47ab'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_07ab@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_47_07ab@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_47_07AB@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_07AB', `PasswordHash` = 'qkTKWuzznvPPu3jwxbXimRWVDW1ZpCoSh69wtYiTtPX4OotafyScZQ1RRFvvRNjU', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_47_07ab@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_47_07ab'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_e965@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_48_e965@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_48_E965@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_E965', `PasswordHash` = '+KLBEcRg+Xb52rSZnAnYnspWlPZflNwz+3BmhWkzMBwUFqTXctCXka57WLZGdiqZ', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_48_e965@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_48_e965'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_2c6a@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_49_2c6a@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_49_2C6A@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_2C6A', `PasswordHash` = 'rMRToWPyAp/mjBd2ouzjCtEhDxnJvnv1LXf6v3WmQjHBLeaqZT/sqzaBe2cel9Pq', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_49_2c6a@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_49_2c6a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_462e@example.com', `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `Email` = 'user_50_462e@example.com', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `NormalizedEmail` = 'USER_50_462E@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_462E', `PasswordHash` = '2h1GQdYeiJ01IdCgWbuJ4cOPE8wr2ZXHQWEfhddsLENQ9xYjKY0TlefAVIrle+25', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `SecurityStamp` = 'user_50_462e@example.com', `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30', `UserName` = 'user_50_462e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-16 14:58:30', `LastLogin` = TIMESTAMP '2025-02-16 14:58:30', `PasswordHash` = 'SndPAruXUwqEOT6I+OLMGIFRz3zk76cMFb583M9mqojvYEa8NgcsERzd9GpxqzuJ', `PasswordResetTokenExpiration` = NULL, `ReactivationReason` = NULL, `ReactivationRequestedAt` = NULL, `UpdatedAt` = TIMESTAMP '2025-02-16 14:58:30'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `Users` (`Id`, `AccessFailedCount`, `Biography`, `ConcurrencyStamp`, `CreatedAt`, `CreatedBy`, `DateOfBirth`, `DeletedAt`, `DeletedBy`, `Email`, `EmailConfirmed`, `FailedLoginAttempts`, `FirstName`, `ForgotPasswordToken`, `ForgotPasswordTokenExpiration`, `IsActive`, `IsAdmin`, `IsBannedByAdmin`, `IsBlocked`, `IsDeleted`, `IsEditor`, `IsGuest`, `IsLockedOut`, `IsModerator`, `IsPending`, `IsStandardUser`, `IsSuperAdmin`, `IsUser`, `IsVerified`, `LastLogin`, `LastName`, `LinkUrl`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PasswordResetToken`, `PasswordResetTokenExpiration`, `PenName`, `PhoneNumber`, `PhoneNumberConfirmed`, `PostId`, `ProfilePicture`, `ReactivationReason`, `ReactivationRequestedAt`, `SecurityStamp`, `TwoFactorEnabled`, `UpdatedAt`, `UpdatedBy`, `UserName`, `Website`)
VALUES ('1448da39-cdaf-47a9-9fb1-960d81dd704b', 0, NULL, 'asafarim.it@gmail.com', TIMESTAMP '2025-02-16 14:58:30', '8048da39-cdaf-47a9-9fb1-960d81dd704a', TIMESTAMP '1990-09-15 00:00:00', NULL, NULL, 'asafarim.it@gmail.com', FALSE, 0, 'Deleted User', NULL, NULL, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, TRUE, TRUE, TIMESTAMP '2025-02-16 14:58:30', 'Account', NULL, FALSE, NULL, NULL, 'ASAFARIM.IT@GMAIL.COM', 'DELETED_USER', '6KEhQSe/8Q7X+/267eQwcU79b3IOqx6B4ZnlK+qIHqb2mk40hXiyJVUyUNljw2DM', NULL, NULL, NULL, '+1234567890', TRUE, NULL, 'https://asafarim.com/logoT.svg', NULL, NULL, 'asafarim.it@gmail.com', FALSE, TIMESTAMP '2025-02-16 14:58:30', '8048da39-cdaf-47a9-9fb1-960d81dd704a', 'deleted_user', NULL);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250216145832_UserReactivation', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '06c8a551-c8c5-49cd-b643-c1a3971a1859';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '36a3043a-b8d1-4e79-8c5e-619fc3392d8a';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3d28ea38-e147-4360-b0af-19a88135d6f7';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '778154a8-7a17-4fad-b70c-04390b7269ae';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7f60492c-f6d6-4b01-95c7-2d344f4131c1';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a595695e-7244-4dba-91da-ef65d950d6a2';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b185d158-017e-438f-9084-1f52943931a3';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c170a298-0f10-457a-884d-fe4828eb9d1c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c8fec41b-acd7-460d-b387-477ab8b893e4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'd0e8c398-9641-4198-a35e-af4c8cbf894d';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '3ea535f6-e9c7-4203-928d-2662d5f8eaba';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '6393799a-4356-43b7-ab67-fee9a3b76eae';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '6deefca2-8c56-453e-ab03-ee777f61187b';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'b9981069-f25e-4b60-8b7e-ae63f6844ef7';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '055e9e01-e069-42d2-94cb-4e0c75f2fbd9';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '70a7c311-d893-4dce-8ea9-e919c11a88a6';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'ace5e81f-42da-42ef-90a1-dc8a770c8103';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'eb319d94-2c87-4db3-aecb-bb35c30b6d3f';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '0fd17864-0a05-4134-97c8-e5788d06284c';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '32ad67d2-1c3c-4054-b74b-6147620f8eee';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '64284b75-1b9c-4696-b1da-cd9bfd44897b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '9741619e-0617-4fd4-9b06-69f430fc0d3f';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'ab1c444d-d4aa-4062-93a9-c0640063ad47';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'd2ea900f-5cf0-4730-9029-db46f160257e';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '2afb9d8a-0632-44d6-9b84-9d2fdd45286e';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '0d4dc5d6-dc85-414f-843f-a2dbf413fa03';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4d38ea0e-1978-4ca2-84c4-82a6e241adc4';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '83793248-a7da-4910-8874-ba32daa8e31b';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '8eaf27f8-ae32-4593-b1b8-fadcdd0ef1b4';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '9f22226c-5b44-4a9c-88ff-4b0e7f172979';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'c7766dfb-fefa-41fe-a936-4b9ef505dffb';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '0b941b36-14a8-493c-971d-c5429ddd35cd';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '137af052-56e7-454b-bfe2-30c187c29ed5';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '33c48aeb-01fd-4e44-8a72-0d1706eef070';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '53468b15-3b44-4927-acb8-2a5cbed415c4';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '361211cf-b50a-45ba-9eac-4e8fc8bc32ee';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '4453b21c-2b72-4f74-998d-a0d2ab98d09b';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '62e9040b-0376-4bd9-8404-0f14c8199ea7';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '8944f0c6-4566-488a-a1e4-0d192c08f6c6';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'd2ec402e-7000-48bd-b290-43ffffdf70d0';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '1dd7f781-a870-4b61-b855-6a5e9792fe54';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '27736283-a5eb-41aa-9f8c-f3295430d698';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'ffe9503a-9b24-4875-8ef6-9ef423bcd1c3';
SELECT ROW_COUNT();


INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('03d56106-5458-4634-a9ac-2b63c98d21f4', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('121391ed-b992-4768-93b3-87bb2ca7c29a', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('1e73e38a-4295-4e6e-b756-6d6a658f937e', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('299a1453-669e-4db8-b882-0335598784a8', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('338857c7-aca1-42a4-994c-6ecd87c8e772', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('3efb797e-9e62-4e86-b05e-5037e461be9f', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('52752fd1-6850-4d46-b396-ac94a79a5380', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('8219507a-dc5a-4a02-b8c0-ba7ad1d1e835', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('b3bd33d2-150d-4b9d-bff0-dc257ba3f079', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('dde8c486-12e6-4fca-87a0-8b31bcf70050', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('796fad72-78ac-44bb-a3e1-2f4f3a5299b3', 'CHF', TIMESTAMP '2025-02-26 08:46:55', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('815b2eef-ed9c-4acc-a7bb-5a8aab2ad3da', 'USD', TIMESTAMP '2025-02-26 08:46:55', 2, TRUE, 'US Dollar', '$', NULL),
('8b4e227b-1136-4b13-b83d-1655311188d2', 'EUR', TIMESTAMP '2025-02-26 08:46:55', 2, TRUE, 'Euro', '€', NULL),
('b44d5f45-4546-4f46-b964-8307b31cfcfc', 'GBP', TIMESTAMP '2025-02-26 08:46:55', 2, TRUE, 'British Pound', '£', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('0014142f-aa02-479b-bed1-410b7275b9c9', TIMESTAMP '2025-02-26 08:46:55', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('1d4dce87-947e-4483-ae34-8ff1729b276e', TIMESTAMP '2025-02-26 08:46:55', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('9550dee8-5d36-42ec-8407-ed59508a6a53', TIMESTAMP '2025-02-26 08:46:55', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL),
('fc4b405a-5579-4877-8e22-cee84044b62d', TIMESTAMP '2025-02-26 08:46:55', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('16589182-3c84-4c2e-9af8-ee4f33a3022d', TIMESTAMP '2025-02-26 08:46:55', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL),
('5524fb23-d494-4511-961e-b9088806138b', TIMESTAMP '2025-02-26 08:46:55', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('55a26735-9e42-4a43-ae18-83aac29d8543', TIMESTAMP '2025-02-26 08:46:55', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('5cb67213-fdcf-4719-a897-5147401d75c8', TIMESTAMP '2025-02-26 08:46:55', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('64f25bd2-e453-4d41-a8ba-95d1b3fdd4f8', TIMESTAMP '2025-02-26 08:46:55', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('d8ee0a7a-ceb9-4810-a9eb-7706007d468b', TIMESTAMP '2025-02-26 08:46:55', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('6193ac30-14b2-4c4d-be56-442ae714a47a', TIMESTAMP '2025-02-26 08:46:55', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1f410b04-92a2-4e72-97e5-f02ec4b0039f', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('29a914f5-0d34-4aca-a2af-2a8d1090e12b', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL),
('3475bb84-3db4-4030-8895-cdd6b764938b', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('3bebe8c9-adcf-47cb-8c87-3a4ee7e9ceeb', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('413bbb51-64b3-4c52-8c91-667606c2aba4', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL),
('bbbf5bb9-deec-4f2a-b705-861e5123ea5e', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('01920b21-024d-4c6b-96f2-91235baf8a33', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL),
('07679d34-90b3-4d50-9848-3c2b96a6c1ec', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('1fee52c8-5ed1-4218-aa16-a92f6d4ee17c', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL),
('73f7bac7-2c73-4869-b782-32a7f0979879', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('037a08e2-1b3c-42aa-9865-4ebebb77cf8e', TIMESTAMP '2025-02-26 08:46:55', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('2988f9fb-364a-4aae-928f-7ed10e181422', TIMESTAMP '2025-02-26 08:46:55', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('39b77345-c09e-4982-98d3-f6dc9ea26ecf', TIMESTAMP '2025-02-26 08:46:55', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('5f6d88c8-c02b-419d-b4c3-b57e8d8915ef', TIMESTAMP '2025-02-26 08:46:55', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('ac5cff22-6ec5-46a7-86c5-f782ba2a47fa', TIMESTAMP '2025-02-26 08:46:55', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-02-26 08:46:55'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0e7c8fb9-ec48-4db2-a935-01b1fff7a35c', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('ca75b08f-c5fa-48e5-bc55-fb60642bed4a', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('e1ffebc9-e2ab-4fbc-9af0-6f5a1929418d', TIMESTAMP '2025-02-26 08:46:55', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL);

UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `PasswordHash` = '2eglRDK78LC4haZrynmOc1dmaf5RooOP+eFO6GcS1/YXWjvZDGS9xkqSy2DuIx46', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `PasswordHash` = 'jO0au6lVKdVs10F8s5J7DYvHcjD/LXI1LCHyHMa1Aozh8T5GS5WZaYlu1pbGVNM6', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_8414@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_1_8414@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_1_8414@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_8414', `PasswordHash` = 'diJWpmmujBhDQ6o0IFohPJLPvQStz1ESqDxDlSwQWhl3PuAtJV2JiDUoRUzA8FlW', `SecurityStamp` = 'user_1_8414@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_1_8414'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_225b@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_2_225b@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_2_225B@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_225B', `PasswordHash` = '7iuGKLN/XkzcMJTqc+Kr1n2X3AzybNRYhtaKkRdK19OpM37x9rlR4adMJlH0fK0E', `SecurityStamp` = 'user_2_225b@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_2_225b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_e36f@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_3_e36f@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_3_E36F@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_E36F', `PasswordHash` = 'KJvTzFbx56ib2mjMLOboRONhcR7sguyJOaKd21DDtfEDR7j7UYO997PMNYFiE7qq', `SecurityStamp` = 'user_3_e36f@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_3_e36f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_3b3b@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_4_3b3b@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_4_3B3B@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_3B3B', `PasswordHash` = 'IhXbUmddQDJMnS74+tSAtObBL59q2SNDcXd/gupqFg75fQ8mRF3MV5DTZS/d+HBk', `SecurityStamp` = 'user_4_3b3b@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_4_3b3b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_dd11@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_5_dd11@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_5_DD11@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_DD11', `PasswordHash` = 'Cu65hyp/K7eKppJjHfm9/+8n1SX56KhC+Jmen7dv3Tgv1STwQE4KDE8XIOiFZDIH', `SecurityStamp` = 'user_5_dd11@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_5_dd11'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_239d@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_6_239d@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_6_239D@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_239D', `PasswordHash` = '3JzCXyP/wTAuSYsZ0EqYpXGKoLfLmjO1YT7lIQvi73wPa269Rj+djogp5D8d3wcF', `SecurityStamp` = 'user_6_239d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_6_239d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_1c66@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_7_1c66@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_7_1C66@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_1C66', `PasswordHash` = 'FsatcwSSJ3ZKCZIigQSja1HHgtIeEqSNphfBOYbCAiJM2xxTGKDOBwRoeH0Fgonl', `SecurityStamp` = 'user_7_1c66@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_7_1c66'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_0c79@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_8_0c79@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_8_0C79@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_0C79', `PasswordHash` = 'V949JdTxn2rA+0pCrXB95NwOjcZdyd3kXZECihHG40ulPGOBEmGqMuFZolYJ/N8z', `SecurityStamp` = 'user_8_0c79@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_8_0c79'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_b29b@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_9_b29b@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_9_B29B@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_B29B', `PasswordHash` = 'Yjnz2CwNKX7CRtDTQDSVsSxag+EcMREMhWjfA8UBFG+2vEBW7umVf9Ca7QekxwBR', `SecurityStamp` = 'user_9_b29b@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_9_b29b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_9d1e@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_10_9d1e@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_10_9D1E@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_9D1E', `PasswordHash` = 'G8t3+A4TYHzCth+T1es4Ly6+cEloOjiu5crR4gnBRR5IoK4AEzKj6A7kom85c25b', `SecurityStamp` = 'user_10_9d1e@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_10_9d1e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_f125@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_11_f125@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_11_F125@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_F125', `PasswordHash` = 'qR/EkuzQcJ2ertSsHyszxbDgArgu6THnfd7HSvQGjwVodNLcrG8fRDZ2cDahbHEt', `SecurityStamp` = 'user_11_f125@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_11_f125'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_7be9@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_12_7be9@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_12_7BE9@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_7BE9', `PasswordHash` = 'DAx6BgDq5167rYcNqH1rHqE1DRi2Su3EtIZeuiu4uA7WlQnpHhPk8nSGzunEmF4P', `SecurityStamp` = 'user_12_7be9@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_12_7be9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_3417@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_13_3417@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_13_3417@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_3417', `PasswordHash` = 'AKbkBBhCP30oRHZcR38mOEao31Ol7O5qiWICmTTTJOeddag8D99ot7A5z1QZ76Y6', `SecurityStamp` = 'user_13_3417@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_13_3417'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_e999@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_14_e999@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_14_E999@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_E999', `PasswordHash` = 'IHLMJYJoLXyRRkfeBVbs31O2A4sr7oiUmsooq0EZmmcSSr6cBYqv2bJDpmndcCys', `SecurityStamp` = 'user_14_e999@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_14_e999'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_afcb@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_15_afcb@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_15_AFCB@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_AFCB', `PasswordHash` = '8YXtfsjM+27sZ2ixS3Hi1o6+zG0DBMxSFk+hL6aNm4HG5IKCLn73N7jCZNr4EMEb', `SecurityStamp` = 'user_15_afcb@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_15_afcb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_a028@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_16_a028@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_16_A028@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_A028', `PasswordHash` = 'nDmmpwqE0vGKW2JNtIe0SMn4Ac32LcDEHbB3yvilTDZpNdpE5zBa284FKXh+B21g', `SecurityStamp` = 'user_16_a028@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_16_a028'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_575a@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_17_575a@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_17_575A@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_575A', `PasswordHash` = 'wro25MbdSugpXG/EHCwTpN4BBzhDwGQ8Y7BAKGHXuQ5ZLl/uztwpvGde6k3oK+xI', `SecurityStamp` = 'user_17_575a@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_17_575a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_e474@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_18_e474@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_18_E474@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_E474', `PasswordHash` = 'vLl4vilrSpnf/6GFHMz7vzBKeUr/ZwvwWj4hH3fJHVHvV6YR4S1R4kKPyLY9SKQB', `SecurityStamp` = 'user_18_e474@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_18_e474'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_6100@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_19_6100@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_19_6100@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_6100', `PasswordHash` = '2gK20OJS8p6KS8m7pvG5Nz3VGgmXySdX8jCTWyn3pqyE7ao/M5580vNPl4FuOpip', `SecurityStamp` = 'user_19_6100@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_19_6100'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_098a@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_20_098a@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_20_098A@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_098A', `PasswordHash` = '6V11c1T3FDZZ4sSdvEuWMBDzOllXNDxxnWUiRWr9+MFRt1GvZlIw12+yGwLpcG3o', `SecurityStamp` = 'user_20_098a@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_20_098a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_fb9d@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_21_fb9d@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_21_FB9D@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_FB9D', `PasswordHash` = 'JvnX8PDnRt59+sV16aJ0CF4U68490PhtWQQt1auUnFRdo9lJnz0/Z8G4tn8HS4RZ', `SecurityStamp` = 'user_21_fb9d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_21_fb9d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_82f4@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_22_82f4@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_22_82F4@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_82F4', `PasswordHash` = 'OTcNlqVBgrJLQ1x/kSUbhheqJy5Ngz4MdHQFggcVEdXP2IqDavfZJ1P2CIhm0dzN', `SecurityStamp` = 'user_22_82f4@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_22_82f4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_fe48@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_23_fe48@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_23_FE48@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_FE48', `PasswordHash` = 'rKGZ9FMDsb3Hf0TZUicVdnQLTp1lvK1aCZ5X5djXJ8Fbnd283IZbe1VlsoFzZufU', `SecurityStamp` = 'user_23_fe48@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_23_fe48'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_6118@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_24_6118@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_24_6118@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_6118', `PasswordHash` = 'TJwaIGhM9R1PYKJFxNvc6ErJt7DVn6+XbMpzeZLohoG4X+9XEJJku0bRtVK+ylNg', `SecurityStamp` = 'user_24_6118@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_24_6118'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_fd2c@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_25_fd2c@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_25_FD2C@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_FD2C', `PasswordHash` = '0Wp3c0pWjonEIckHuJ3I84B/OXkKbvzQQMZhSp0Nh1yT/UehajrtTTClVot7HEgQ', `SecurityStamp` = 'user_25_fd2c@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_25_fd2c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_74e2@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_26_74e2@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_26_74E2@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_74E2', `PasswordHash` = 'J36yQvRge51D7jdlxX2CkgMFR84QUBt/fc163r9Wz8Y+U3QbwWztVJHdRfYNZa+b', `SecurityStamp` = 'user_26_74e2@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_26_74e2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_aced@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_27_aced@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_27_ACED@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_ACED', `PasswordHash` = 'h3j82f7Olc6Ek4rEb6ZnN8oO2HjHAuoE1iilbpYiqtA/W/7Y6LVtZw96nilxHT6r', `SecurityStamp` = 'user_27_aced@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_27_aced'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_9573@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_28_9573@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_28_9573@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_9573', `PasswordHash` = 'q2oE7AL95cz8e43fjNkSvJy8LPt+4Y8h5hCGce59rlg0fjQ/VrM11qkYXMdQlLNg', `SecurityStamp` = 'user_28_9573@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_28_9573'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_8b86@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_29_8b86@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_29_8B86@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_8B86', `PasswordHash` = 'I7YsYm0E07mC7bLTWHfIdHifofVsLH95EyBzFC7zShBzJttw0EGUHyIvaWb3IxpR', `SecurityStamp` = 'user_29_8b86@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_29_8b86'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_d639@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_30_d639@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_30_D639@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_D639', `PasswordHash` = 'hlNxifdC24rQlvyeDD96XI8jk2TQ7m1PVajniPLzH0i6wgYaLT8VjcFf4iPM18q9', `SecurityStamp` = 'user_30_d639@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_30_d639'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_3e53@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_31_3e53@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_31_3E53@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_3E53', `PasswordHash` = 'z8CoIuKMpWyoFBjtrHOGKbaK3UnMbdu+/sWa3lDuUHaw6Uj1Xh1pMo23adxNNFB6', `SecurityStamp` = 'user_31_3e53@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_31_3e53'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_4114@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_32_4114@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_32_4114@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_4114', `PasswordHash` = '568jXMRIO6/4indsJJUg4jN1STEAhmldI0cQ9Y/VqeOTPW3VjzHiasQfXjE0mTRi', `SecurityStamp` = 'user_32_4114@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_32_4114'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_4f7c@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_33_4f7c@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_33_4F7C@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_4F7C', `PasswordHash` = 'wohaiHIXUlIoeyG5HlpCgxEMjqD0VgyXWFJxGPBiEKmoOWXIMJXxDddURbCd6ugM', `SecurityStamp` = 'user_33_4f7c@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_33_4f7c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_7587@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_34_7587@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_34_7587@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_7587', `PasswordHash` = 'fqvf5gLLFMTnDU2fRsK1trFy9mJVbPtGQd4i5cKkeuLavODm7yIk5KEkfoOSUewS', `SecurityStamp` = 'user_34_7587@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_34_7587'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_57f9@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_35_57f9@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_35_57F9@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_57F9', `PasswordHash` = 'hhFh3mBiDZWmLaPh9UN2k/UqIVxklf3p2L14kDCwOiquGdKn/bB54xL5/4Ma5SkO', `SecurityStamp` = 'user_35_57f9@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_35_57f9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_bf10@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_36_bf10@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_36_BF10@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_BF10', `PasswordHash` = 'EMnZgFJ2wJ1gcX9xG3KNNidWyzhXQq4qYB4W2X8qFBo9Z/GdDicE3mPKjZIOuxZJ', `SecurityStamp` = 'user_36_bf10@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_36_bf10'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_713d@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_37_713d@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_37_713D@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_713D', `PasswordHash` = 'PQB8Wzxq2UgPQDXdc4UBzKXQdsAgtMM6net3Fx8krmxunx7lsiY7A65O8I0ZBWZN', `SecurityStamp` = 'user_37_713d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_37_713d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_abd4@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_38_abd4@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_38_ABD4@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_ABD4', `PasswordHash` = 'FTG36Tz6RZfb9klFPcKJLnLdaqoJbs02qOdBnx6WB4Px47WG0mS8hoDA6tIg8Uaa', `SecurityStamp` = 'user_38_abd4@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_38_abd4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_dd7d@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_39_dd7d@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_39_DD7D@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_DD7D', `PasswordHash` = 'Y+wka8WuAqYWjuuFJY3SWXzmWnya/15DHssX4mGgEo+68x6o1Y741ONt9igBMlYl', `SecurityStamp` = 'user_39_dd7d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_39_dd7d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_685d@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_40_685d@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_40_685D@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_685D', `PasswordHash` = 'h18KUK1S4S5U5seuLe6RxXJ6YCBtRUs4uH5msZP2QfXi96c/SHY+/5RnAr9Ge9J9', `SecurityStamp` = 'user_40_685d@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_40_685d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_6ec2@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_41_6ec2@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_41_6EC2@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_6EC2', `PasswordHash` = 'fZGUFBwBjry0GVIgr4UG3rAu5l+TimDEtWqJPY1jT3BhqOzCLTYJvlDCQWfqBAFe', `SecurityStamp` = 'user_41_6ec2@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_41_6ec2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_d7e9@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_42_d7e9@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_42_D7E9@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_D7E9', `PasswordHash` = 'SGueps9XgbXgE7+JRMwvK4fpziqRiqqmXhg7n3lcENLCHdx+gfo+T6Q/Uw8of6WT', `SecurityStamp` = 'user_42_d7e9@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_42_d7e9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_ddb4@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_43_ddb4@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_43_DDB4@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_DDB4', `PasswordHash` = 'T7AyP2llSeHusNOSEea5k2uqkRbR6J5XC/jwcxfzdfcO5Otpp7RndSES2IvX9EpJ', `SecurityStamp` = 'user_43_ddb4@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_43_ddb4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_7025@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_44_7025@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_44_7025@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_7025', `PasswordHash` = 'c4kdS9Mt2W5LFtQbDiCs+NUxV4Kd0+Oou2WBZLH/1os9FCZjWpcyVR05/bgOZUjk', `SecurityStamp` = 'user_44_7025@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_44_7025'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_fe9a@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_45_fe9a@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_45_FE9A@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_FE9A', `PasswordHash` = 'cuq0drW4773ycBbQb//Jf8JdyKbhGqZbA8BZuT1BvBwcOeZVfnsDod3AJ7ODjgtA', `SecurityStamp` = 'user_45_fe9a@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_45_fe9a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_4eb8@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_46_4eb8@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_46_4EB8@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_4EB8', `PasswordHash` = '4k5g318JivTJYdP1XEZwZRcHzOMZeSh6+0dFjd0AtFbBN3/16y49KMnrXoZjGtuf', `SecurityStamp` = 'user_46_4eb8@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_46_4eb8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_c723@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_47_c723@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_47_C723@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_C723', `PasswordHash` = '8wEPjdUitjS5izbFXNgh586qPWC2CGAmAAEcMYBgG7MpqM15LU6jvb+MgGCLpKzz', `SecurityStamp` = 'user_47_c723@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_47_c723'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_5591@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_48_5591@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_48_5591@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_5591', `PasswordHash` = 'iS0G/2ewwIOLl3VkWTDgN62pUPb2JmNVT3mLQ7Ia87B1CS7FwDaBxS2hVfhdBD3/', `SecurityStamp` = 'user_48_5591@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_48_5591'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_58b4@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_49_58b4@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_49_58B4@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_58B4', `PasswordHash` = 'H3c9/HTMWmdwmXp5u4aoMSx33WXAcJoFm1DkueXPTJhgG7joR27S3bIwKaYCtx6+', `SecurityStamp` = 'user_49_58b4@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_49_58b4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_23e7@example.com', `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `Email` = 'user_50_23e7@example.com', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `NormalizedEmail` = 'USER_50_23E7@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_23E7', `PasswordHash` = 'HuGq0ZjpjtbZKYvZuucmSOcrM4rjhYcjgfz7RIhVZKzx4bxAr8Pa6G4zJNCJMolN', `SecurityStamp` = 'user_50_23e7@example.com', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00', `UserName` = 'user_50_23e7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `CreatedAt` = TIMESTAMP '2025-02-17 10:00:00', `LastLogin` = TIMESTAMP '2025-02-17 10:00:00', `PasswordHash` = 'FbJXQ7XOvSrmQeqm0VkXF0NNDCozdx5693yLqqhF1G8qXhWVuEs2Vly9CiLTAW7G', `UpdatedAt` = TIMESTAMP '2025-02-17 10:00:00'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250226084701_ProjectUpdated', '9.0.1');

DROP TABLE `AttachmentPost`;

DELETE FROM `Countries`
WHERE `Id` = '03d56106-5458-4634-a9ac-2b63c98d21f4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '121391ed-b992-4768-93b3-87bb2ca7c29a';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '1e73e38a-4295-4e6e-b756-6d6a658f937e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '299a1453-669e-4db8-b882-0335598784a8';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '338857c7-aca1-42a4-994c-6ecd87c8e772';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3efb797e-9e62-4e86-b05e-5037e461be9f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '52752fd1-6850-4d46-b396-ac94a79a5380';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '8219507a-dc5a-4a02-b8c0-ba7ad1d1e835';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b3bd33d2-150d-4b9d-bff0-dc257ba3f079';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'dde8c486-12e6-4fca-87a0-8b31bcf70050';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '796fad72-78ac-44bb-a3e1-2f4f3a5299b3';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '815b2eef-ed9c-4acc-a7bb-5a8aab2ad3da';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '8b4e227b-1136-4b13-b83d-1655311188d2';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'b44d5f45-4546-4f46-b964-8307b31cfcfc';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '0014142f-aa02-479b-bed1-410b7275b9c9';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '1d4dce87-947e-4483-ae34-8ff1729b276e';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '9550dee8-5d36-42ec-8407-ed59508a6a53';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'fc4b405a-5579-4877-8e22-cee84044b62d';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '16589182-3c84-4c2e-9af8-ee4f33a3022d';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5524fb23-d494-4511-961e-b9088806138b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '55a26735-9e42-4a43-ae18-83aac29d8543';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5cb67213-fdcf-4719-a897-5147401d75c8';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '64f25bd2-e453-4d41-a8ba-95d1b3fdd4f8';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'd8ee0a7a-ceb9-4810-a9eb-7706007d468b';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '6193ac30-14b2-4c4d-be56-442ae714a47a';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '1f410b04-92a2-4e72-97e5-f02ec4b0039f';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '29a914f5-0d34-4aca-a2af-2a8d1090e12b';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '3475bb84-3db4-4030-8895-cdd6b764938b';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '3bebe8c9-adcf-47cb-8c87-3a4ee7e9ceeb';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '413bbb51-64b3-4c52-8c91-667606c2aba4';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'bbbf5bb9-deec-4f2a-b705-861e5123ea5e';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '01920b21-024d-4c6b-96f2-91235baf8a33';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '07679d34-90b3-4d50-9848-3c2b96a6c1ec';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '1fee52c8-5ed1-4218-aa16-a92f6d4ee17c';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '73f7bac7-2c73-4869-b782-32a7f0979879';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '037a08e2-1b3c-42aa-9865-4ebebb77cf8e';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '2988f9fb-364a-4aae-928f-7ed10e181422';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '39b77345-c09e-4982-98d3-f6dc9ea26ecf';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '5f6d88c8-c02b-419d-b4c3-b57e8d8915ef';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'ac5cff22-6ec5-46a7-86c5-f782ba2a47fa';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '0e7c8fb9-ec48-4db2-a935-01b1fff7a35c';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'ca75b08f-c5fa-48e5-bc55-fb60642bed4a';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'e1ffebc9-e2ab-4fbc-9af0-6f5a1929418d';
SELECT ROW_COUNT();


ALTER TABLE `Users` MODIFY COLUMN `TwoFactorEnabled` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` MODIFY COLUMN `PhoneNumberConfirmed` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` MODIFY COLUMN `EmailConfirmed` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Attachment` ADD `PostId` char(36) COLLATE ascii_general_ci NULL;

CREATE TABLE `Assignments` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Title` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Description` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DueDate` datetime(6) NULL,
    `Assignee` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Status` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NULL,
    `CreatedBy` char(36) COLLATE ascii_general_ci NULL,
    `UpdatedAt` datetime(6) NULL,
    `UpdatedBy` char(36) COLLATE ascii_general_ci NULL,
    `DeletedAt` datetime(6) NULL,
    `DeletedBy` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_Assignments` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Initiatives` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `StartDate` datetime(6) NULL,
    `EndDate` datetime(6) NULL,
    `TeamMembers` longtext CHARACTER SET utf8mb4 NOT NULL,
    `GoalItems` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NULL,
    `CreatedBy` char(36) COLLATE ascii_general_ci NULL,
    `UpdatedAt` datetime(6) NULL,
    `UpdatedBy` char(36) COLLATE ascii_general_ci NULL,
    `DeletedAt` datetime(6) NULL,
    `DeletedBy` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_Initiatives` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('06976aeb-2233-4591-9a55-1bf00ba61520', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('08dc6c56-1243-4b3a-9d66-a09ec49685c5', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('4968cf0a-036a-4f74-bfe4-b24fdbb48abd', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('5973cabb-fa1b-40ca-9081-847d47492232', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('7164ddac-1966-46f1-99da-62eda65f2cda', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('86493dcc-3595-43a2-83f5-4469bd2dfb85', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('b4596d0f-31b7-47a6-b9d4-1c8b8b1cb241', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('bc8ca7e4-35dc-4ed1-8a41-2b23fb860766', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('cc2b2edf-ec66-40bc-a864-f32999efd3de', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('ea20214d-e69e-4bbc-868f-529596e36214', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('56f13d74-7afe-410d-bc7f-62acd52c756c', 'CHF', TIMESTAMP '2025-03-04 12:21:00', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('a2a34e68-a880-45b3-a868-f731f390038f', 'EUR', TIMESTAMP '2025-03-04 12:21:00', 2, TRUE, 'Euro', '€', NULL),
('ab8f1928-536f-4068-acd1-258a0f6f50e8', 'GBP', TIMESTAMP '2025-03-04 12:21:00', 2, TRUE, 'British Pound', '£', NULL),
('f0d3a31b-1ebb-4b22-b942-ecdc9050ba1b', 'USD', TIMESTAMP '2025-03-04 12:21:00', 2, TRUE, 'US Dollar', '$', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `UpdatedAt`)
VALUES ('0f329c06-a920-4cc8-adc5-3a5ddffff41b', TIMESTAMP '2025-03-04 12:21:00', 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, NULL),
('2e6180fc-e813-4822-bb66-e72ea656259f', TIMESTAMP '2025-03-04 12:21:00', 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, NULL),
('f6a0c83c-69b8-481c-920e-7d6ec1f1c887', TIMESTAMP '2025-03-04 12:21:00', 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, NULL),
('ffd4fbe6-e361-46f4-a85b-00e569753862', TIMESTAMP '2025-03-04 12:21:00', 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `Description`, `Extension`, `IsActive`, `IsDefault`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`)
VALUES ('2c24f28b-f064-48f3-bf1e-369891dcac9f', TIMESTAMP '2025-03-04 12:21:00', 'JavaScript source code file', '.js', TRUE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL),
('4f29221a-0e8d-4f10-90c0-0fe285ccf54d', TIMESTAMP '2025-03-04 12:21:00', 'Markdown text format', '.md', TRUE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL),
('5f563a52-ce64-4c0b-9696-b6fe609ff579', TIMESTAMP '2025-03-04 12:21:00', 'TypeScript source code file', '.ts', TRUE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL),
('a1393f59-abc5-4005-be32-a51d150d7a17', TIMESTAMP '2025-03-04 12:21:00', 'Simple text document format', '.txt', TRUE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL),
('c976a642-60b7-40ce-a31b-93ef40ac5ec2', TIMESTAMP '2025-03-04 12:21:00', 'JavaScript Object Notation data file', '.json', TRUE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL),
('d637dd52-19ce-4a33-bca7-ce92589fe92e', TIMESTAMP '2025-03-04 12:21:00', 'TypeScript React component file', '.tsx', TRUE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('5d5e7f0d-0349-421f-b273-0698c4a4fdc4', TIMESTAMP '2025-03-04 12:21:00', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('77ed25c4-f8ca-48a4-acae-bc6bf5f597b6', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'Guest role is the least privileged role. They can only view public articles.', 'Guest', NULL, NULL),
('7c7ffc6d-4323-4f22-b068-3b202d9ebf98', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'Has full control over the application and can manage all aspects.', 'SuperAdmin', NULL, NULL),
('89cd5c88-32af-4c5c-b169-0882a4cfd5cd', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', 'Moderator', NULL, NULL),
('c0f979f2-2ac3-4374-8722-44469dd163a5', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', 'User', NULL, NULL),
('d11b4409-ad67-471c-b0d7-6f3ecd33c9e1', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', 'Editor', NULL, NULL),
('dc72a8d2-b8c6-42b5-bff7-b705a9273bbb', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'Admin role has full administrative privileges, except for application management.', 'Admin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CreatedAt`, `Description`, `Name`, `Slug`, `UpdatedAt`)
VALUES ('2dd144bc-8a4b-4db5-8f0f-fcb912faf93d', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 3', 'Test Tag name 3', 'test-tag-slug-3', NULL),
('3255b64e-4b7b-4949-9608-3cf9a6b6ce63', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description', 'Test Tag name', 'test-tag-slug', NULL),
('419d27b0-951c-4c85-b010-8e5f45ac9762', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 2', 'Test Tag name 2', 'test-tag-slug-2', NULL),
('64e9d0be-99c6-4b38-9ad3-7068ac511ae8', TIMESTAMP '0001-01-01 00:00:00', 'Test Tag description 4', 'Test Tag name 4', 'test-tag-slug-4', NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('0ce61777-082c-42f5-824e-4e40f83886ac', TIMESTAMP '2025-03-04 12:21:00', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('49177106-28a4-4cb4-8e98-b2a61bfecef2', TIMESTAMP '2025-03-04 12:21:00', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('7ef76c32-1364-4d8f-89dd-ffdd14facc26', TIMESTAMP '2025-03-04 12:21:00', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('7f366be1-2a39-4446-96e0-7fd2915914ef', TIMESTAMP '2025-03-04 12:21:00', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('b6ea92d5-ebac-4cbf-8ce2-0720f67276ae', TIMESTAMP '2025-03-04 12:21:00', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-04 12:21:00'
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `Description`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('aa5298b1-d78d-4608-8a29-fdda63c96eec', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'Test Topic description 3', 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('e83cb273-49ff-406b-97a1-9ff5f705babd', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'Test Topic description 4', 'Test Topic name 4', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('eadb7ea5-97b0-4572-9b4f-1dbd5644eb98', TIMESTAMP '2025-03-04 12:21:00', '00000000-0000-0000-0000-000000000000', 'Test Topic description 2', 'Test Topic name 2', '3fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL);

UPDATE `Users` SET `LockoutEnd` = NULL, `PasswordHash` = 'oy0WAvMjmUD5Ys4hv4s/mpjw4LT4ifoWQmne6mtu1+uszrxAG3xcdqWk86ZzAmEA'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `LockoutEnd` = NULL, `PasswordHash` = 'E+rYeoP+vZP1j4NTaNzB9+6ucUHjZMewgc9QbZvcBcqyLYfC9RI8FWQbRWByU3OD'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_60a5@example.com', `Email` = 'user_1_60a5@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_1_60A5@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_60A5', `PasswordHash` = 'g9G4+PjoNxzhPXPVa27I3gV4flgijjOMpD7MRG25RAjE2xpPN1TSyX0sSmPNi5MJ', `SecurityStamp` = 'user_1_60a5@example.com', `UserName` = 'user_1_60a5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_3fed@example.com', `Email` = 'user_2_3fed@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_2_3FED@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_3FED', `PasswordHash` = '2tmS1JWTrtp+5emqnPgsfFQ0HG3CgDa8BSm79sIU972H+XngH9FJc1VYp46Ttipv', `SecurityStamp` = 'user_2_3fed@example.com', `UserName` = 'user_2_3fed'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_8c9a@example.com', `Email` = 'user_3_8c9a@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_3_8C9A@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_8C9A', `PasswordHash` = 'ZcgGjLkbhSFLaJIkjW+EG+JOADeUjoAHb5ADoEfqqdTU87u4gIkaF7blxAcDRG3p', `SecurityStamp` = 'user_3_8c9a@example.com', `UserName` = 'user_3_8c9a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_d1bf@example.com', `Email` = 'user_4_d1bf@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_4_D1BF@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_D1BF', `PasswordHash` = '9Ow51xBS4duDEay3ttcHywDEgaqpoy/+Mfju9XcJc1fIkFMhiVlH3SYU1Cipsh7c', `SecurityStamp` = 'user_4_d1bf@example.com', `UserName` = 'user_4_d1bf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_400c@example.com', `Email` = 'user_5_400c@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_5_400C@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_400C', `PasswordHash` = 'zrePXuwN6V60x3UeZ3lzSoF+QFuStOiLA6E6p22X10c4cqPJcvCinCYCEAUlfh7H', `SecurityStamp` = 'user_5_400c@example.com', `UserName` = 'user_5_400c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_b14f@example.com', `Email` = 'user_6_b14f@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_6_B14F@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_B14F', `PasswordHash` = 'XHxghaQURobYoIJXQz6g7paGbv1OLo1cvtIpSmUYK/LVanIRtxLin8iPcjMacgXA', `SecurityStamp` = 'user_6_b14f@example.com', `UserName` = 'user_6_b14f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_8f43@example.com', `Email` = 'user_7_8f43@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_7_8F43@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_8F43', `PasswordHash` = 'Y+AsEpB3hDShXGcE44R+F7TegjQ8blFWGvTICep81+Ys0C0EHxtlUvpQszIAvGRS', `SecurityStamp` = 'user_7_8f43@example.com', `UserName` = 'user_7_8f43'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_a0d3@example.com', `Email` = 'user_8_a0d3@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_8_A0D3@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_A0D3', `PasswordHash` = 'VGPa10kTn+e5oPHuPJeyZ2WmYmzq+RTcOHzErlQJmoKcdjn6TgEnKzKxi+/+KtJN', `SecurityStamp` = 'user_8_a0d3@example.com', `UserName` = 'user_8_a0d3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_cc4d@example.com', `Email` = 'user_9_cc4d@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_9_CC4D@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_CC4D', `PasswordHash` = 'd4AYRpvr3BwkwobCYVqOTN+Hzd6lPJMYy5d1TGx+F7gjrHJnIWQ2+jkn5kfUAyBa', `SecurityStamp` = 'user_9_cc4d@example.com', `UserName` = 'user_9_cc4d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_53e3@example.com', `Email` = 'user_10_53e3@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_10_53E3@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_53E3', `PasswordHash` = 'hh3YfzQpeDXlpGfRjFfo3VFbJR1cwjJJspXbU+/dkH4MXBJH367Nifv6rI1rXMMG', `SecurityStamp` = 'user_10_53e3@example.com', `UserName` = 'user_10_53e3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_8316@example.com', `Email` = 'user_11_8316@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_11_8316@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_8316', `PasswordHash` = 'asUAXuajLzgTat3ojyY1Oc2hnrsyW/H5du4JPNJuhJBSLCpkMt6FxosiprGWytX4', `SecurityStamp` = 'user_11_8316@example.com', `UserName` = 'user_11_8316'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_09f3@example.com', `Email` = 'user_12_09f3@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_12_09F3@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_09F3', `PasswordHash` = '4Lsv/fHRm7GABBqMl5cBvji6bhd0UbGwJAE5VsvxyrzHXFEONoP2PPypDaNTjMuk', `SecurityStamp` = 'user_12_09f3@example.com', `UserName` = 'user_12_09f3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_07a6@example.com', `Email` = 'user_13_07a6@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_13_07A6@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_07A6', `PasswordHash` = 'km9zIDnfJSL9DDh/yMdFTf9JSjrnMXpmBZxhR2RS75QUJsiCEP6M/9+z3CO7HAF+', `SecurityStamp` = 'user_13_07a6@example.com', `UserName` = 'user_13_07a6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_398b@example.com', `Email` = 'user_14_398b@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_14_398B@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_398B', `PasswordHash` = 'TVBCt40VSR7bNkqAJKuq+ai6faAlAy1G3eRIrzxa1HXHaULlGf0ZV/PSs8wGqzue', `SecurityStamp` = 'user_14_398b@example.com', `UserName` = 'user_14_398b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_7e57@example.com', `Email` = 'user_15_7e57@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_15_7E57@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_7E57', `PasswordHash` = 'NJpfzjBj2M2phjwDvs7Q+/cSOoN/TZkggXCkYOnIOAi/ffxMmb29PBNF8OzpOV8Z', `SecurityStamp` = 'user_15_7e57@example.com', `UserName` = 'user_15_7e57'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_e2ba@example.com', `Email` = 'user_16_e2ba@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_16_E2BA@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_E2BA', `PasswordHash` = 'VPgIEQyRxxcj7HXm3mY50bRHhkWqAuJE3sD7v+ttAejN+QK8LTGl6n4kDllTxBFs', `SecurityStamp` = 'user_16_e2ba@example.com', `UserName` = 'user_16_e2ba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_d062@example.com', `Email` = 'user_17_d062@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_17_D062@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_D062', `PasswordHash` = 'kclOfEg8lHW/E5eUc7wGxRomHyPHfc2/aShNZ+yvLvn6SfXOdwDrMFyhAzk9VChF', `SecurityStamp` = 'user_17_d062@example.com', `UserName` = 'user_17_d062'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_072e@example.com', `Email` = 'user_18_072e@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_18_072E@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_072E', `PasswordHash` = 'h699mLAh/P3D+JCDU4bsTLfup7wEJfVNDPof3PKrWiuxSgjpsi9AC6ThedsIYBW5', `SecurityStamp` = 'user_18_072e@example.com', `UserName` = 'user_18_072e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_79e8@example.com', `Email` = 'user_19_79e8@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_19_79E8@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_79E8', `PasswordHash` = 'iAY6bKw4yiWflsMwG/PRR45LQH7+33PZQp0/J7SVC8Hy+7Jqw2rlpXsMd0V7sDV7', `SecurityStamp` = 'user_19_79e8@example.com', `UserName` = 'user_19_79e8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_3f5f@example.com', `Email` = 'user_20_3f5f@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_20_3F5F@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_3F5F', `PasswordHash` = 'h1lBx/NosC25r1pB9XD6vR77BU/PGgdPl3dBT5QhzZEIrQv3YBYPPMKDwxc61MB0', `SecurityStamp` = 'user_20_3f5f@example.com', `UserName` = 'user_20_3f5f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_ade0@example.com', `Email` = 'user_21_ade0@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_21_ADE0@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_ADE0', `PasswordHash` = 'NKRag2A1XMvwbRHSuxruM+nxxoWb6+RG9RfpqA3156od2WCAyTmFfdgNzhMdkycw', `SecurityStamp` = 'user_21_ade0@example.com', `UserName` = 'user_21_ade0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_e74b@example.com', `Email` = 'user_22_e74b@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_22_E74B@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_E74B', `PasswordHash` = 'ndoEpBoxkJ6sapRu/RbpuFC2M0fidJcs9N+gV/HlBPaIET5Ht28QWNIiX+DGPHHp', `SecurityStamp` = 'user_22_e74b@example.com', `UserName` = 'user_22_e74b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_1fb4@example.com', `Email` = 'user_23_1fb4@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_23_1FB4@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_1FB4', `PasswordHash` = 'sqCN/4mvDmOkviK8JzkfZCfpeX1RuE4OoFdifApolH839NJMUENZC8+YCu/Ud4g5', `SecurityStamp` = 'user_23_1fb4@example.com', `UserName` = 'user_23_1fb4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_f89b@example.com', `Email` = 'user_24_f89b@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_24_F89B@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_F89B', `PasswordHash` = 'klItneCnXYcRmz55eJdOx68S44ym4zXPPUPI0y4kf7jRo4VQqfzjP/1EFHEecU6U', `SecurityStamp` = 'user_24_f89b@example.com', `UserName` = 'user_24_f89b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_0bf6@example.com', `Email` = 'user_25_0bf6@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_25_0BF6@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_0BF6', `PasswordHash` = 'l3cwRBELuwhxwGuOa9pN/EMrjcbrlpZ3Fcmd5SIIGvPH0+89a2fJ/nIvxdRAQ1n9', `SecurityStamp` = 'user_25_0bf6@example.com', `UserName` = 'user_25_0bf6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_5a1a@example.com', `Email` = 'user_26_5a1a@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_26_5A1A@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_5A1A', `PasswordHash` = 'n11hSnFklpAtP7VtSR2TXic6IO4TV49aZE1GSNwqPwaS5tErR4GG7Wa8cLXQpXeW', `SecurityStamp` = 'user_26_5a1a@example.com', `UserName` = 'user_26_5a1a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_9893@example.com', `Email` = 'user_27_9893@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_27_9893@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_9893', `PasswordHash` = 'mAlhcGE/nvrHOS5k9R+HXwYeapNk6ETpqpNvn571+XWYm/R2geMlhv9/4smOWaHe', `SecurityStamp` = 'user_27_9893@example.com', `UserName` = 'user_27_9893'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_9c22@example.com', `Email` = 'user_28_9c22@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_28_9C22@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_9C22', `PasswordHash` = 'A8hYvW4eovoe8wHg/8eqF3yJHvTRKR5VTDzSdRwJac8x5MieKFd9tQWPCT9n5gBt', `SecurityStamp` = 'user_28_9c22@example.com', `UserName` = 'user_28_9c22'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_a4e8@example.com', `Email` = 'user_29_a4e8@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_29_A4E8@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_A4E8', `PasswordHash` = 'r2+07FBEZIfBkTfIOjMvT5RNFovpv6UlaRHwFMoGXngJ/xgCVjrzxAkoPDmqcExo', `SecurityStamp` = 'user_29_a4e8@example.com', `UserName` = 'user_29_a4e8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_f57f@example.com', `Email` = 'user_30_f57f@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_30_F57F@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_F57F', `PasswordHash` = 'VOBS4LOyNRF7Pv/gjW7wb5vyQH/dtY7RO8huvCgCMX7EvTRdzpPQbhQJck1enbD5', `SecurityStamp` = 'user_30_f57f@example.com', `UserName` = 'user_30_f57f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_304e@example.com', `Email` = 'user_31_304e@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_31_304E@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_304E', `PasswordHash` = 'ZqDBRFDn/dlEy0s1r9YSxuX9w9rHX5NVqeVmoKqdSRUUEwOTdU3pedZII0ahkx2b', `SecurityStamp` = 'user_31_304e@example.com', `UserName` = 'user_31_304e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_fdff@example.com', `Email` = 'user_32_fdff@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_32_FDFF@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_FDFF', `PasswordHash` = 'RcRfOecTxrO/ONp2YaKS8Y+hyQsCZ6XWx1WWmWN9MJa4H14SRcvLjGIUeUb7b3ay', `SecurityStamp` = 'user_32_fdff@example.com', `UserName` = 'user_32_fdff'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_e5ca@example.com', `Email` = 'user_33_e5ca@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_33_E5CA@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_E5CA', `PasswordHash` = 'ujgKT3oECqkCEiyCRRhG9CjE9EF5EJJsiC3s9b1+9HdntRmnKb9qmU4zfDKcS8He', `SecurityStamp` = 'user_33_e5ca@example.com', `UserName` = 'user_33_e5ca'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_a475@example.com', `Email` = 'user_34_a475@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_34_A475@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_A475', `PasswordHash` = 'MXzVv9leNUSLsIbkFNsW+RL9CFd1Od3Fd0DugGYw2UCSLQrSej3w+ut6llfy2Sym', `SecurityStamp` = 'user_34_a475@example.com', `UserName` = 'user_34_a475'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_ccb0@example.com', `Email` = 'user_35_ccb0@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_35_CCB0@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_CCB0', `PasswordHash` = 'zM/FnMFizjzCogAnLTxk8/rILqP751tJtnxIeTVrfX2hfwg/gg7N/v/75VYnJW1t', `SecurityStamp` = 'user_35_ccb0@example.com', `UserName` = 'user_35_ccb0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_1679@example.com', `Email` = 'user_36_1679@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_36_1679@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_1679', `PasswordHash` = 'xs2wmFtgibAoRa18kr7YDCBrlCAavzz1pzs+SFL9uMLMVtUjbx0kno4Wi+gSh7Wj', `SecurityStamp` = 'user_36_1679@example.com', `UserName` = 'user_36_1679'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_9a40@example.com', `Email` = 'user_37_9a40@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_37_9A40@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_9A40', `PasswordHash` = 'YKrDlqGH8iICGCgzUac8KF0WaYf8FGgHwL7CNQBpb32H5zLqugapVIUBg6aV/i55', `SecurityStamp` = 'user_37_9a40@example.com', `UserName` = 'user_37_9a40'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_4879@example.com', `Email` = 'user_38_4879@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_38_4879@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_4879', `PasswordHash` = 'sfUCMAqacL2O8ypCBkRGCgLCb2qxI/5Yi4OyDyBTcCdfeKvs/Hi9rFXXSwVaDYne', `SecurityStamp` = 'user_38_4879@example.com', `UserName` = 'user_38_4879'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_09ea@example.com', `Email` = 'user_39_09ea@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_39_09EA@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_09EA', `PasswordHash` = 'aqMbYqFvrGlP6IZG/73fh948pOU7NKM7Va8mW1D+nm9hVoTQaSwfX8gTP5fvOccm', `SecurityStamp` = 'user_39_09ea@example.com', `UserName` = 'user_39_09ea'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_95cb@example.com', `Email` = 'user_40_95cb@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_40_95CB@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_95CB', `PasswordHash` = 'AwRQ7WIUHkMEbuiwD/aiTlLFtD7cjYtSoTmyTM3pB7TThqKhVvdIvQByyowf6Mqj', `SecurityStamp` = 'user_40_95cb@example.com', `UserName` = 'user_40_95cb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_74ee@example.com', `Email` = 'user_41_74ee@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_41_74EE@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_74EE', `PasswordHash` = 'EUdK0UVt6Lf+wR8Ue6wBbhoQoJjB7gVGNbM2QYCXAqiiA67TB6rteJnS7RtE2gNe', `SecurityStamp` = 'user_41_74ee@example.com', `UserName` = 'user_41_74ee'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_7d25@example.com', `Email` = 'user_42_7d25@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_42_7D25@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_7D25', `PasswordHash` = 'hCNkIjf50Nu9gEWLkGBBBM47VWEgksSh4hK4t3yKDEUfFw3WvAvvzUAhiF1UdNUp', `SecurityStamp` = 'user_42_7d25@example.com', `UserName` = 'user_42_7d25'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_2b44@example.com', `Email` = 'user_43_2b44@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_43_2B44@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_2B44', `PasswordHash` = 'wO9b0QRuxWxslXqWPdFHFHNbV6SjyynSwlE2kwlvZpNOgZAnj0T7b19GqYSwe+ym', `SecurityStamp` = 'user_43_2b44@example.com', `UserName` = 'user_43_2b44'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_b3ce@example.com', `Email` = 'user_44_b3ce@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_44_B3CE@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_B3CE', `PasswordHash` = 'e6q6zob4uj+Q7lYDROEKbgyXTdcpRK6s+0/zxLRWk8lgpoWxi59vSGgtADY9nI0F', `SecurityStamp` = 'user_44_b3ce@example.com', `UserName` = 'user_44_b3ce'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_9019@example.com', `Email` = 'user_45_9019@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_45_9019@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_9019', `PasswordHash` = 'PNNJ4+iLd4VjjDxqmWpOgWNobSXXttavh/MLEZcp9H+eHiIM8fQPQLo8YJIlKhcc', `SecurityStamp` = 'user_45_9019@example.com', `UserName` = 'user_45_9019'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_51bb@example.com', `Email` = 'user_46_51bb@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_46_51BB@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_51BB', `PasswordHash` = 'r2Tsrri1uCTUzJYfKuO8aWTKNvVbH1CRdY1OOso42n4auvyDinbDuhT/VYXoKaxZ', `SecurityStamp` = 'user_46_51bb@example.com', `UserName` = 'user_46_51bb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_e85a@example.com', `Email` = 'user_47_e85a@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_47_E85A@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_E85A', `PasswordHash` = 'zU7aAt4ovktNG8poMDRUa83d1I1PaHoFjMOHU47KesZsNfrNxaUe8f7DWRyqSIXa', `SecurityStamp` = 'user_47_e85a@example.com', `UserName` = 'user_47_e85a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_ed15@example.com', `Email` = 'user_48_ed15@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_48_ED15@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_ED15', `PasswordHash` = 'fXRy/C/EPeM4V/sbDOeUzbQoCL3UXpKt66g8ahydKKfNL8ZuAxCw5ag7quw8gEpA', `SecurityStamp` = 'user_48_ed15@example.com', `UserName` = 'user_48_ed15'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_d1d6@example.com', `Email` = 'user_49_d1d6@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_49_D1D6@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_D1D6', `PasswordHash` = 'DHBHIS0iazMmsUcsCb9i4r+zAETzK+Y5CFUe4Vk2GLFHLOsLpF2D8Oc2XyNIS9FY', `SecurityStamp` = 'user_49_d1d6@example.com', `UserName` = 'user_49_d1d6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_2fda@example.com', `Email` = 'user_50_2fda@example.com', `LockoutEnd` = NULL, `NormalizedEmail` = 'USER_50_2FDA@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_2FDA', `PasswordHash` = 'LMkOFvtBJaklF7JeB29hv1xCe0wLiWf9sYWvtfZ1KNaXt5FxSsLRM9Oon98HkGbv', `SecurityStamp` = 'user_50_2fda@example.com', `UserName` = 'user_50_2fda'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `LockoutEnd` = NULL, `PasswordHash` = 'bdeWk6paX//hcNa8NitdoKS79pTpWPtV9SFZhF5uxJqt/dExn3YkKQOM4fJzpMYI'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


CREATE INDEX `IX_Attachment_PostId` ON `Attachment` (`PostId`);

ALTER TABLE `Attachment` ADD CONSTRAINT `FK_Attachment_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250304122105_FixUserAndEntityImplementations', '9.0.1');

DROP PROCEDURE IF EXISTS `POMELO_BEFORE_DROP_PRIMARY_KEY`;
DELIMITER //
CREATE PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY`(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255))
BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID TINYINT(1);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `Extra` = 'auto_increment'
			AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END //
DELIMITER ;

DROP PROCEDURE IF EXISTS `POMELO_AFTER_ADD_PRIMARY_KEY`;
DELIMITER //
CREATE PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY`(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255), IN `COLUMN_NAME_ARGUMENT` VARCHAR(255))
BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID INT(11);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
			AND `COLUMN_TYPE` LIKE '%int%'
			AND `COLUMN_KEY` = 'PRI';
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL AUTO_INCREMENT;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END //
DELIMITER ;

ALTER TABLE `PostAttachment` DROP FOREIGN KEY `FK_PostAttachment_MarkdownFiles_AttachmentId`;

ALTER TABLE `PostComment` DROP FOREIGN KEY `FK_PostComment_Users_CommenterId`;

ALTER TABLE `PostRelatedPost` DROP FOREIGN KEY `FK_PostRelatedPost_Posts_PostId`;

ALTER TABLE `Posts` DROP FOREIGN KEY `FK_Posts_Posts_PostId`;

DROP TABLE `PostTag`;

ALTER TABLE `Posts` DROP INDEX `IX_Posts_PostId`;

CALL POMELO_BEFORE_DROP_PRIMARY_KEY(NULL, 'PostRelatedPost');
ALTER TABLE `PostRelatedPost` DROP PRIMARY KEY;

ALTER TABLE `PostRelatedPost` DROP INDEX `IX_PostRelatedPost_PostId`;

DELETE FROM `Countries`
WHERE `Id` = '06976aeb-2233-4591-9a55-1bf00ba61520';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '08dc6c56-1243-4b3a-9d66-a09ec49685c5';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '4968cf0a-036a-4f74-bfe4-b24fdbb48abd';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '5973cabb-fa1b-40ca-9081-847d47492232';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7164ddac-1966-46f1-99da-62eda65f2cda';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '86493dcc-3595-43a2-83f5-4469bd2dfb85';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b4596d0f-31b7-47a6-b9d4-1c8b8b1cb241';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'bc8ca7e4-35dc-4ed1-8a41-2b23fb860766';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'cc2b2edf-ec66-40bc-a864-f32999efd3de';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'ea20214d-e69e-4bbc-868f-529596e36214';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '56f13d74-7afe-410d-bc7f-62acd52c756c';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'a2a34e68-a880-45b3-a868-f731f390038f';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'ab8f1928-536f-4068-acd1-258a0f6f50e8';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'f0d3a31b-1ebb-4b22-b942-ecdc9050ba1b';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '0f329c06-a920-4cc8-adc5-3a5ddffff41b';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '2e6180fc-e813-4822-bb66-e72ea656259f';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'f6a0c83c-69b8-481c-920e-7d6ec1f1c887';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'ffd4fbe6-e361-46f4-a85b-00e569753862';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '2c24f28b-f064-48f3-bf1e-369891dcac9f';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '4f29221a-0e8d-4f10-90c0-0fe285ccf54d';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5f563a52-ce64-4c0b-9696-b6fe609ff579';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'a1393f59-abc5-4005-be32-a51d150d7a17';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'c976a642-60b7-40ce-a31b-93ef40ac5ec2';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'd637dd52-19ce-4a33-bca7-ce92589fe92e';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '5d5e7f0d-0349-421f-b273-0698c4a4fdc4';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '77ed25c4-f8ca-48a4-acae-bc6bf5f597b6';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '7c7ffc6d-4323-4f22-b068-3b202d9ebf98';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '89cd5c88-32af-4c5c-b169-0882a4cfd5cd';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'c0f979f2-2ac3-4374-8722-44469dd163a5';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'd11b4409-ad67-471c-b0d7-6f3ecd33c9e1';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'dc72a8d2-b8c6-42b5-bff7-b705a9273bbb';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '2dd144bc-8a4b-4db5-8f0f-fcb912faf93d';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '3255b64e-4b7b-4949-9608-3cf9a6b6ce63';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '419d27b0-951c-4c85-b010-8e5f45ac9762';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '64e9d0be-99c6-4b38-9ad3-7068ac511ae8';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '0ce61777-082c-42f5-824e-4e40f83886ac';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '49177106-28a4-4cb4-8e98-b2a61bfecef2';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '7ef76c32-1364-4d8f-89dd-ffdd14facc26';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '7f366be1-2a39-4446-96e0-7fd2915914ef';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'b6ea92d5-ebac-4cbf-8ce2-0720f67276ae';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'aa5298b1-d78d-4608-8a29-fdda63c96eec';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'e83cb273-49ff-406b-97a1-9ff5f705babd';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'eadb7ea5-97b0-4572-9b4f-1dbd5644eb98';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '3fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


ALTER TABLE `Posts` DROP COLUMN `PostId`;

ALTER TABLE `PostComment` DROP COLUMN `Comment`;

ALTER TABLE `Projects` RENAME COLUMN `IsPausedTo` TO `PausedUntil`;

ALTER TABLE `Projects` RENAME COLUMN `IsExtendedTo` TO `ExtendedUntil`;

ALTER TABLE `Projects` RENAME COLUMN `IsCompletedBy` TO `CompletedBy`;

ALTER TABLE `Projects` RENAME COLUMN `IsCompletedAt` TO `DeletedAt`;

ALTER TABLE `Projects` RENAME COLUMN `IsCancelledby` TO `CancelledBy`;

ALTER TABLE `Projects` RENAME COLUMN `IsCancelledAt` TO `CompletedAt`;

ALTER TABLE `PostRelatedPost` RENAME COLUMN `Id` TO `RelatedPostId`;

ALTER TABLE `PostComment` RENAME COLUMN `CommenterId` TO `CommentId`;

ALTER TABLE `PostComment` RENAME INDEX `IX_PostComment_CommenterId` TO `IX_PostComment_CommentId`;

ALTER TABLE `Topics` MODIFY COLUMN `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

UPDATE `Topics` SET `Slug` = ''
WHERE `Slug` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Topics` MODIFY COLUMN `Slug` varchar(255) CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Topics` MODIFY COLUMN `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Topics` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `Topics` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Topics` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Topics` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Topics` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Tags` ADD `CommentId` char(36) COLLATE ascii_general_ci NULL;

ALTER TABLE `Tags` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Tags` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `Tags` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Tags` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Tags` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Tags` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Tags` ADD `PostId` char(36) COLLATE ascii_general_ci NULL;

ALTER TABLE `Tags` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Roles` MODIFY COLUMN `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Roles` MODIFY COLUMN `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Roles` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `Roles` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Roles` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Roles` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Roles` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Projects` ADD `CancelledAt` datetime(6) NULL;

ALTER TABLE `Projects` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Projects` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Projects` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Projects` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Projects` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Projects` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `ProjectMembers` ADD `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `ProjectMembers` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `ProjectMembers` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `ProjectMembers` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `ProjectMembers` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `ProjectMembers` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `ProjectMembers` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `ProjectMembers` ADD `UpdatedAt` datetime(6) NULL;

ALTER TABLE `ProjectMembers` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `ProgressHistories` MODIFY COLUMN `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `ProgressHistories` MODIFY COLUMN `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `ProgressHistories` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `ProgressHistories` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `ProgressHistories` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `ProgressHistories` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `ProgressHistories` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `PrivacyPreferences` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `PrivacyPreferences` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `PrivacyPreferences` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `PrivacyPreferences` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `PrivacyPreferences` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `PrivacyPreferences` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `PrivacyPreferences` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `PostTags` ADD `Id` char(36) COLLATE ascii_general_ci NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

UPDATE `Posts` SET `CreatedBy` = ''
WHERE `CreatedBy` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Posts` MODIFY COLUMN `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Posts` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `PostLink` ADD `LinkedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `PostCategory` ADD `AssignedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `PostCategory` ADD `IsPrimary` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `PostAttachment` ADD `AttachedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `PostAttachment` ADD `IsPrimary` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `MarkdownFiles` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `MarkdownFiles` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `MarkdownFiles` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `MarkdownFiles` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `MarkdownFiles` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `MarkdownFileHistories` ADD `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `MarkdownFileHistories` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `MarkdownFileHistories` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `MarkdownFileHistories` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `MarkdownFileHistories` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `MarkdownFileHistories` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `MarkdownFileHistories` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `MarkdownFileHistories` ADD `UpdatedAt` datetime(6) NULL;

ALTER TABLE `MarkdownFileHistories` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

UPDATE `Link` SET `Url` = ''
WHERE `Url` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Link` MODIFY COLUMN `Url` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Link` MODIFY COLUMN `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

UPDATE `Link` SET `Name` = ''
WHERE `Name` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Link` MODIFY COLUMN `Name` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Link` MODIFY COLUMN `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Link` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Initiatives` MODIFY COLUMN `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Initiatives` MODIFY COLUMN `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

UPDATE `Initiatives` SET `CreatedBy` = ''
WHERE `CreatedBy` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Initiatives` MODIFY COLUMN `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Initiatives` MODIFY COLUMN `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `Initiatives` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Initiatives` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Initiatives` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `GeographicalPreferences` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `GeographicalPreferences` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `GeographicalPreferences` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `GeographicalPreferences` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `GeographicalPreferences` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `GeographicalPreferences` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `GeographicalPreferences` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `FileFormats` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `FileFormats` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `FileFormats` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `FileFormats` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `FileFormats` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `FileFormats` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `DateFormats` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `DateFormats` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `DateFormats` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `DateFormats` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `DateFormats` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `DateFormats` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Comment` MODIFY COLUMN `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

UPDATE `Comment` SET `Text` = ''
WHERE `Text` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Comment` MODIFY COLUMN `Text` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Comment` MODIFY COLUMN `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Comment` ADD `ParentCommentId` char(36) COLLATE ascii_general_ci NULL;

ALTER TABLE `Comment` ADD `UserId` char(36) COLLATE ascii_general_ci NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

UPDATE `Category` SET `Name` = ''
WHERE `Name` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Category` MODIFY COLUMN `Name` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Category` ADD `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `Category` ADD `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Category` ADD `DeletedAt` datetime(6) NULL;

ALTER TABLE `Category` ADD `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Category` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Category` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Category` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Category` ADD `UpdatedAt` datetime(6) NULL;

ALTER TABLE `Category` ADD `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

UPDATE `Attachment` SET `Url` = ''
WHERE `Url` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Attachment` MODIFY COLUMN `Url` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Attachment` MODIFY COLUMN `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

UPDATE `Attachment` SET `FileName` = ''
WHERE `FileName` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Attachment` MODIFY COLUMN `FileName` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Attachment` MODIFY COLUMN `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Attachment` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Assignments` MODIFY COLUMN `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Assignments` MODIFY COLUMN `DeletedBy` longtext CHARACTER SET utf8mb4 NULL;

UPDATE `Assignments` SET `CreatedBy` = ''
WHERE `CreatedBy` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Assignments` MODIFY COLUMN `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Assignments` MODIFY COLUMN `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `Assignments` ADD `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Assignments` ADD `IsActive` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Assignments` ADD `IsDeleted` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `PostRelatedPost` ADD CONSTRAINT `PK_PostRelatedPost` PRIMARY KEY (`PostId`, `RelatedPostId`);

CREATE TABLE `PostTopic` (
    `PostId` char(36) COLLATE ascii_general_ci NOT NULL,
    `TopicId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `DeletedAt` datetime(6) NULL,
    `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL,
    `DeletedBy` longtext CHARACTER SET utf8mb4 NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_PostTopic` PRIMARY KEY (`PostId`, `TopicId`),
    CONSTRAINT `FK_PostTopic_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_PostTopic_Topics_TopicId` FOREIGN KEY (`TopicId`) REFERENCES `Topics` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('178fb5c9-0e15-4590-853d-60f1a6254722', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('1f97ec75-15b1-43c0-8e92-fbcf8adcfad4', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('33cc27d0-453b-490c-a84c-0463ba6cc55e', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('49703bb1-5422-45f4-8350-c38bc715c34d', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('49dc1c42-25c3-4773-9e25-844fed18e64d', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('62308f13-07f3-498e-9103-41b5ef334450', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('6232278d-e7b7-46ad-832d-b19e178a5e65', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('acc0e240-2422-4cbd-98b5-df581430b10e', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('e214a56d-c348-4cbe-bf7a-e4c798ae7495', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('ea7567dd-11db-4414-877b-df4c2c216c86', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('0afb6230-629a-425c-84e6-a448f12c13fe', 'GBP', TIMESTAMP '2025-03-04 15:39:06', 2, TRUE, 'British Pound', '£', NULL),
('29242680-ba1e-4d6e-8854-8fd194f28166', 'USD', TIMESTAMP '2025-03-04 15:39:06', 2, TRUE, 'US Dollar', '$', NULL),
('5b6fbb5a-6ba5-4d4b-aaa1-6104430f6443', 'CHF', TIMESTAMP '2025-03-04 15:39:06', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('f4613664-22ae-4f2c-8d01-be6260b38c39', 'EUR', TIMESTAMP '2025-03-04 15:39:06', 2, TRUE, 'Euro', '€', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('59cb0ed6-bac1-4af4-adc5-2819c0f02eda', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL),
('94c93979-b739-41ab-9be2-5cbbfb639c76', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('b1d971b5-7c2b-4fef-b4ae-ed26829d49e4', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('f44fd3dc-5878-46fc-b822-df3348435779', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0ed17047-9715-4031-b5cb-d9020eda4654', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('19607e5f-6efa-45fe-94fc-eb503849b6c1', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('21ebfdaa-fd22-44b5-9b1e-02f3256a842a', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('6d99caca-5806-4be8-b6f1-d7c23c1af2d5', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('89b14cc1-7c20-4acc-ab30-3bb970fcb6d2', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('928a387d-40d1-4212-94b3-5d2e34a4334c', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('48cb7ade-f2bb-4426-8d02-b912876e4cca', TIMESTAMP '2025-03-04 15:39:06', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('03d2cf8f-beb8-4455-ade0-efc5635e5c6a', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('4fbba298-ccbc-4f2d-b394-ff33b23fe274', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('61e4acc8-fc16-43e3-80ac-80bda54b2cfb', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('b4d0e151-3155-4508-9ee7-5110e74b2ce1', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('b53b026d-ae7b-497c-a851-e02c4fba9892', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('fb62843b-9af4-4be7-ac4d-5bae89f98695', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('4245e448-8c62-45dd-961d-29892f7eb482', NULL, TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL),
('8e21f077-05a1-4fce-ab74-6967fd7e4eec', NULL, TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('cff3246d-a9c3-4807-811d-a8a23eb0cfb7', NULL, TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('fc4840eb-149b-4b6d-afaa-3c13376c3694', NULL, TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('04405d90-002a-4f4f-9d90-33a4a086f334', TIMESTAMP '2025-03-04 15:39:06', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('71839c3f-b9eb-435b-a3e2-d770ed71f5e1', TIMESTAMP '2025-03-04 15:39:06', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('c2bb72b8-ee0e-4233-9206-da0a1f040fc1', TIMESTAMP '2025-03-04 15:39:06', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('f1860167-41bf-4f7b-8cea-0e5022a98c25', TIMESTAMP '2025-03-04 15:39:06', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('f378bf36-407d-4e6d-b07e-5a0c64fb7c01', TIMESTAMP '2025-03-04 15:39:06', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00');

INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1fa85f64-5717-4562-b3fc-2c963f66afa6', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Test Topic description', TRUE, FALSE, 'Test Topic name', NULL, 'test-topic-slug', NULL, NULL),
('33bd44b3-77b1-4387-91fc-89dfe23cc74b', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'pBJO16ZRczDcsw7FaG1xmMsy0zfjB4vHQirDRcIw2zB43qADu0P3PNBPiLUkwE9A'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = '+7hN3xXgEpCAr6b4IV/Dwou/jjHRbGi24sUvn7YEgY/cBH2q6GIByRzD1HfEDmSM'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_896b@example.com', `Email` = 'user_1_896b@example.com', `NormalizedEmail` = 'USER_1_896B@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_896B', `PasswordHash` = 'IeXh6bndC0xxyMCBjDviM4cl0EHB0QB6aSfz2uWTe+TR7uAZgcDhXZ49IwEIFqjw', `SecurityStamp` = 'user_1_896b@example.com', `UserName` = 'user_1_896b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_bf21@example.com', `Email` = 'user_2_bf21@example.com', `NormalizedEmail` = 'USER_2_BF21@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_BF21', `PasswordHash` = 'mMGexvN+vZne5JnXekyNGtjDx1sCVmZL0kUZPwdSVp0MqtrGlhSLD9EpezmdJzba', `SecurityStamp` = 'user_2_bf21@example.com', `UserName` = 'user_2_bf21'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_0be1@example.com', `Email` = 'user_3_0be1@example.com', `NormalizedEmail` = 'USER_3_0BE1@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_0BE1', `PasswordHash` = 'rnIyZtmtVAM52XYp67QhyrZY0l7ghT4bQ9zWwZ+C+jotha5mUEX9KM7Qrhyc0Oyg', `SecurityStamp` = 'user_3_0be1@example.com', `UserName` = 'user_3_0be1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_32ea@example.com', `Email` = 'user_4_32ea@example.com', `NormalizedEmail` = 'USER_4_32EA@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_32EA', `PasswordHash` = 'KsjOSwrhIUzq96yRBNEIkAIkP1NacE4T6urJVM3Bo74gF5eAgYRd++JHKDJEHR9b', `SecurityStamp` = 'user_4_32ea@example.com', `UserName` = 'user_4_32ea'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_2889@example.com', `Email` = 'user_5_2889@example.com', `NormalizedEmail` = 'USER_5_2889@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_2889', `PasswordHash` = 'Sx9h4ySHPULmFAIhAlQ7qbx7Yo/EBksB8OuA6RNMdikTqFSX8O7C4uEy7yeCzwKf', `SecurityStamp` = 'user_5_2889@example.com', `UserName` = 'user_5_2889'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_3e29@example.com', `Email` = 'user_6_3e29@example.com', `NormalizedEmail` = 'USER_6_3E29@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_3E29', `PasswordHash` = 'CR4ujjFPrn5sIzTnWWlMh8FBndWfZbJW0ZdfYzjWbXOiZmc15/HZoS3Un2BtRDHE', `SecurityStamp` = 'user_6_3e29@example.com', `UserName` = 'user_6_3e29'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_47b1@example.com', `Email` = 'user_7_47b1@example.com', `NormalizedEmail` = 'USER_7_47B1@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_47B1', `PasswordHash` = 'rBlJ63Zm5OdLQSuR2gkT5V09WtVdWVaAXV+tzK7jnILAUYdA0TgJup3096tgSFhV', `SecurityStamp` = 'user_7_47b1@example.com', `UserName` = 'user_7_47b1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_fda4@example.com', `Email` = 'user_8_fda4@example.com', `NormalizedEmail` = 'USER_8_FDA4@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_FDA4', `PasswordHash` = 'ze1jkMRYfdvyO6e0W2fq82KVkqipe7EwF7Qrm1gGk4qLA4IHyUdNVKo2NWq0TEeZ', `SecurityStamp` = 'user_8_fda4@example.com', `UserName` = 'user_8_fda4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_da72@example.com', `Email` = 'user_9_da72@example.com', `NormalizedEmail` = 'USER_9_DA72@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_DA72', `PasswordHash` = 'WF4bf9zIO/DSMTtjiEi5UUK8PLs+ayUSzD7/6d2etUUxw0fwBQN9uZm53TOhjxDU', `SecurityStamp` = 'user_9_da72@example.com', `UserName` = 'user_9_da72'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_57b0@example.com', `Email` = 'user_10_57b0@example.com', `NormalizedEmail` = 'USER_10_57B0@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_57B0', `PasswordHash` = 'fd0uYVp5FWuVq3SUUz/wxBObQdBOgiKucFzemob2GpTRM+wWa1c+jE2kyZmAfPXV', `SecurityStamp` = 'user_10_57b0@example.com', `UserName` = 'user_10_57b0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_56cc@example.com', `Email` = 'user_11_56cc@example.com', `NormalizedEmail` = 'USER_11_56CC@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_56CC', `PasswordHash` = '/m+ZaWx+HmUQOo1txRt+M3m0Iahg2R6ZNlA20on5FBMippnC6TPr+K5EQhva21lL', `SecurityStamp` = 'user_11_56cc@example.com', `UserName` = 'user_11_56cc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_3dec@example.com', `Email` = 'user_12_3dec@example.com', `NormalizedEmail` = 'USER_12_3DEC@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_3DEC', `PasswordHash` = 'OK4hcbZVadEB45y8jqn/6Zk1dxGvjY2Rs3POTCjv4Mm9qqIfTvolnBjXqbLeKSei', `SecurityStamp` = 'user_12_3dec@example.com', `UserName` = 'user_12_3dec'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_88a1@example.com', `Email` = 'user_13_88a1@example.com', `NormalizedEmail` = 'USER_13_88A1@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_88A1', `PasswordHash` = 'VEWK9shyhD0gDAFDC5CsdrI9Nmf1gkF7PpaxeZwSacYvGHgFdbHuRk6g+BqZKGL+', `SecurityStamp` = 'user_13_88a1@example.com', `UserName` = 'user_13_88a1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_debe@example.com', `Email` = 'user_14_debe@example.com', `NormalizedEmail` = 'USER_14_DEBE@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_DEBE', `PasswordHash` = 'sJ52sSso1mRoV7t5A4xpFm+lkwlHGnlfwmHeMXJFqWg65i4dVcO5LTrarPTVUbIR', `SecurityStamp` = 'user_14_debe@example.com', `UserName` = 'user_14_debe'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_c5bf@example.com', `Email` = 'user_15_c5bf@example.com', `NormalizedEmail` = 'USER_15_C5BF@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_C5BF', `PasswordHash` = 'ZnLU1k+ZcUI07TfnE/IAMTK6+GE4mgXAyjRtoCwUCGh6bLkar355fVz+tNcLgkmt', `SecurityStamp` = 'user_15_c5bf@example.com', `UserName` = 'user_15_c5bf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_4142@example.com', `Email` = 'user_16_4142@example.com', `NormalizedEmail` = 'USER_16_4142@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_4142', `PasswordHash` = 'rRwe+VqApBR/lSsrkOpcZ1UKz5RuL3Qr6ToEV0WXr1MWWDYHEnSA4JYp0BoJfOyQ', `SecurityStamp` = 'user_16_4142@example.com', `UserName` = 'user_16_4142'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_bc80@example.com', `Email` = 'user_17_bc80@example.com', `NormalizedEmail` = 'USER_17_BC80@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_BC80', `PasswordHash` = 'mkkaDosje8sb0Dn09ly5EDgOqCnQeCGxHR+vQBoqa2sVTYEB1fcFFb3Ia/D5JAfT', `SecurityStamp` = 'user_17_bc80@example.com', `UserName` = 'user_17_bc80'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_3588@example.com', `Email` = 'user_18_3588@example.com', `NormalizedEmail` = 'USER_18_3588@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_3588', `PasswordHash` = 'zO9r/cAceL1klt6IP6Wm7t26fLo0iNi3R96Q90isUmmBufk3f+vXmAg7WfuUAM17', `SecurityStamp` = 'user_18_3588@example.com', `UserName` = 'user_18_3588'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_dca4@example.com', `Email` = 'user_19_dca4@example.com', `NormalizedEmail` = 'USER_19_DCA4@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_DCA4', `PasswordHash` = 'OfNuA1WcWyOuQuZCcyc2amsXvIkwO+aY3EkZ+JTH9JCuYZ6aOU3bhRru/dL5prEK', `SecurityStamp` = 'user_19_dca4@example.com', `UserName` = 'user_19_dca4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_7868@example.com', `Email` = 'user_20_7868@example.com', `NormalizedEmail` = 'USER_20_7868@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_7868', `PasswordHash` = 'M9MDtnudq0Tjsj4gO2+kRAgfDlOspZ89XKukvlstOPJ9pq/fyd+wRPW9V2ktWNEu', `SecurityStamp` = 'user_20_7868@example.com', `UserName` = 'user_20_7868'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_53f6@example.com', `Email` = 'user_21_53f6@example.com', `NormalizedEmail` = 'USER_21_53F6@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_53F6', `PasswordHash` = 'aCKZc6ZntRiBKLOrF9nE71kCfUE+e9YHrzuKCWjhaGBRwmuWsykEGeRUr4a0ZWTQ', `SecurityStamp` = 'user_21_53f6@example.com', `UserName` = 'user_21_53f6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_3adf@example.com', `Email` = 'user_22_3adf@example.com', `NormalizedEmail` = 'USER_22_3ADF@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_3ADF', `PasswordHash` = '1EW7Wdlanm4E/Eu2/11epSb+gauk6XZmj+SdsNQcSB1rw7lmKhg6jQ9Fm0xWtyN3', `SecurityStamp` = 'user_22_3adf@example.com', `UserName` = 'user_22_3adf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_de6d@example.com', `Email` = 'user_23_de6d@example.com', `NormalizedEmail` = 'USER_23_DE6D@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_DE6D', `PasswordHash` = 'bLCtiP5cTPS1RMyKQ5gabkRHK44k6hFKMaNhfBHd13r/5zOou4iHLD7Aepat/Fxl', `SecurityStamp` = 'user_23_de6d@example.com', `UserName` = 'user_23_de6d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_bb5c@example.com', `Email` = 'user_24_bb5c@example.com', `NormalizedEmail` = 'USER_24_BB5C@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_BB5C', `PasswordHash` = 'ToI43Cdn/IBx8Wy7z7cZukrhwt2VvSruOQaAeQWsai0mfCUM08oBQlMltJ561Xp3', `SecurityStamp` = 'user_24_bb5c@example.com', `UserName` = 'user_24_bb5c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_4abf@example.com', `Email` = 'user_25_4abf@example.com', `NormalizedEmail` = 'USER_25_4ABF@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_4ABF', `PasswordHash` = 'eQUhbCBGhnM1qd/E8XdosaxY7FDmb2Qa5wSAi0ZiAx+VGQwqwo2hKZ163Xtv7Bdy', `SecurityStamp` = 'user_25_4abf@example.com', `UserName` = 'user_25_4abf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_c9f2@example.com', `Email` = 'user_26_c9f2@example.com', `NormalizedEmail` = 'USER_26_C9F2@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_C9F2', `PasswordHash` = '3IZCYi0gYyy9sWdlAIIqryTdh56lhDeFWnawtNKMJzYZTaOgzoXLh2F5XnRrdwAq', `SecurityStamp` = 'user_26_c9f2@example.com', `UserName` = 'user_26_c9f2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_9dfe@example.com', `Email` = 'user_27_9dfe@example.com', `NormalizedEmail` = 'USER_27_9DFE@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_9DFE', `PasswordHash` = 'VyOSEHhdYzHYygeoxjGiVlI6BVFcGorPtXU1IZ6exJAtIjwrll+8peaZq3qL/TGX', `SecurityStamp` = 'user_27_9dfe@example.com', `UserName` = 'user_27_9dfe'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_6a7f@example.com', `Email` = 'user_28_6a7f@example.com', `NormalizedEmail` = 'USER_28_6A7F@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_6A7F', `PasswordHash` = '1F817PGCTBgWRANTkdFM2SYr9xjh3yLoxQJ1pl6UofdkJP4D3r+3Tu8R0QieYGue', `SecurityStamp` = 'user_28_6a7f@example.com', `UserName` = 'user_28_6a7f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_3d12@example.com', `Email` = 'user_29_3d12@example.com', `NormalizedEmail` = 'USER_29_3D12@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_3D12', `PasswordHash` = 'O3x9xZ6IWZGzYX724bQiNlozWEmPoqBRkJk1u/oa8I4aVryXVxSt05BdL8P3mcig', `SecurityStamp` = 'user_29_3d12@example.com', `UserName` = 'user_29_3d12'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_1639@example.com', `Email` = 'user_30_1639@example.com', `NormalizedEmail` = 'USER_30_1639@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_1639', `PasswordHash` = 'esz+Mnsin+pljtYPoW9Xc5vBHa8PeXCziGp3WYG6W4YLCwaKYFJTSGSrW6U1s9rz', `SecurityStamp` = 'user_30_1639@example.com', `UserName` = 'user_30_1639'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_d3b0@example.com', `Email` = 'user_31_d3b0@example.com', `NormalizedEmail` = 'USER_31_D3B0@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_D3B0', `PasswordHash` = 'YELgst2a7OYX3CA3N+IQPrb5ml4D5bPDgOGuUDwDW5wF4g3e9TxWE+ND+vqcqII2', `SecurityStamp` = 'user_31_d3b0@example.com', `UserName` = 'user_31_d3b0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_3926@example.com', `Email` = 'user_32_3926@example.com', `NormalizedEmail` = 'USER_32_3926@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_3926', `PasswordHash` = 'OZ4nEs2mQ1EtkXeG5h28L8ZNq4yo9O3uVAPTtZ0v48mUPPzJ0Zbcdknj1kpmH45t', `SecurityStamp` = 'user_32_3926@example.com', `UserName` = 'user_32_3926'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_1305@example.com', `Email` = 'user_33_1305@example.com', `NormalizedEmail` = 'USER_33_1305@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_1305', `PasswordHash` = 'tTOSZJupBW9CzxAZlN20aR1kEOMkw1ec9ZAru3svm0XWX4qD+OsbuBHhl0zCJw4r', `SecurityStamp` = 'user_33_1305@example.com', `UserName` = 'user_33_1305'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_1f71@example.com', `Email` = 'user_34_1f71@example.com', `NormalizedEmail` = 'USER_34_1F71@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_1F71', `PasswordHash` = 'aQuuEFumeXtBMkAntpRgl7y2gOsmDARHAH/iv6Px1/1PaOzy4M+yuZNZz6cZsM4P', `SecurityStamp` = 'user_34_1f71@example.com', `UserName` = 'user_34_1f71'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_1017@example.com', `Email` = 'user_35_1017@example.com', `NormalizedEmail` = 'USER_35_1017@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_1017', `PasswordHash` = 'bEWiFExXreyabXbAziAyJZytP8tug2THafKp4JO+Qs4bp51llh4lRNY0EWAD5Ihj', `SecurityStamp` = 'user_35_1017@example.com', `UserName` = 'user_35_1017'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_3652@example.com', `Email` = 'user_36_3652@example.com', `NormalizedEmail` = 'USER_36_3652@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_3652', `PasswordHash` = 'GjB54KJWGcKNitUGoA29RyLpnTyJWyPeVc4A4FwdPL1Q5elc6/plEtPQ1c545mR/', `SecurityStamp` = 'user_36_3652@example.com', `UserName` = 'user_36_3652'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_4eab@example.com', `Email` = 'user_37_4eab@example.com', `NormalizedEmail` = 'USER_37_4EAB@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_4EAB', `PasswordHash` = 'qmBprZFQCbfHhc0Z7Mnt2iKnyiZtO2Z3Mw1fpzHvJPTn+1z4Y38Iloepa+I7rxBt', `SecurityStamp` = 'user_37_4eab@example.com', `UserName` = 'user_37_4eab'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_190e@example.com', `Email` = 'user_38_190e@example.com', `NormalizedEmail` = 'USER_38_190E@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_190E', `PasswordHash` = '9Jp1RmEhq88L2y5QHFEnRIpTbcpLbA3CEy/IHdmdy4e81EN3DJn3HoD6ktt2MTKN', `SecurityStamp` = 'user_38_190e@example.com', `UserName` = 'user_38_190e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_53ba@example.com', `Email` = 'user_39_53ba@example.com', `NormalizedEmail` = 'USER_39_53BA@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_53BA', `PasswordHash` = 'LYXdIWFff5e+uOgYn0+3kp+c4MTWRhUunCTWJ3fo0Sp3Pfmh35WZkWreiwT1be8C', `SecurityStamp` = 'user_39_53ba@example.com', `UserName` = 'user_39_53ba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_c5a4@example.com', `Email` = 'user_40_c5a4@example.com', `NormalizedEmail` = 'USER_40_C5A4@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_C5A4', `PasswordHash` = 'C9sOMGH8ziKqW2UeVjbwsDgHimEa19aT1fQwn3StdXVfZJJjhtUm0u1dI/X1KzPD', `SecurityStamp` = 'user_40_c5a4@example.com', `UserName` = 'user_40_c5a4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_da8a@example.com', `Email` = 'user_41_da8a@example.com', `NormalizedEmail` = 'USER_41_DA8A@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_DA8A', `PasswordHash` = 'k/xo4rJPa7PlMuuBdzaWngflhPTctR+0U/QtOk23qQiWDCbRxEo/PrsjlwdfwQlj', `SecurityStamp` = 'user_41_da8a@example.com', `UserName` = 'user_41_da8a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_ea20@example.com', `Email` = 'user_42_ea20@example.com', `NormalizedEmail` = 'USER_42_EA20@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_EA20', `PasswordHash` = 'SUSEaOKtXCI08nhdUfzYPNpBn/UjNyW//np42TMpHexoX2kJownT4ETZDXHvTbj2', `SecurityStamp` = 'user_42_ea20@example.com', `UserName` = 'user_42_ea20'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_7fa1@example.com', `Email` = 'user_43_7fa1@example.com', `NormalizedEmail` = 'USER_43_7FA1@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_7FA1', `PasswordHash` = 'C6s9RVGLluhJAvPcWs6mMN2ktnqs42qQJdGAiPawT3oq00608cpcbBZYt80l0dCv', `SecurityStamp` = 'user_43_7fa1@example.com', `UserName` = 'user_43_7fa1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_594c@example.com', `Email` = 'user_44_594c@example.com', `NormalizedEmail` = 'USER_44_594C@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_594C', `PasswordHash` = 'LGEs+TUNW7UB+mCvmkYAHjw7tD9d9k/4wDl1NZ1y9HVlI7w4rNqkXaujZtMSl1hs', `SecurityStamp` = 'user_44_594c@example.com', `UserName` = 'user_44_594c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_cab6@example.com', `Email` = 'user_45_cab6@example.com', `NormalizedEmail` = 'USER_45_CAB6@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_CAB6', `PasswordHash` = '0Lt914cDw62yNm6jrFhB2+0IOOk73pRE4qaD2YZF+xXE8W8u5ZOYxpG9XGGYIFj8', `SecurityStamp` = 'user_45_cab6@example.com', `UserName` = 'user_45_cab6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_7d3e@example.com', `Email` = 'user_46_7d3e@example.com', `NormalizedEmail` = 'USER_46_7D3E@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_7D3E', `PasswordHash` = '8pIngPE+FWxNKszTgJp30jPo+wQ/tZpQezxAbwZxrFVlgv6uzy6i60l7GqGU6mDu', `SecurityStamp` = 'user_46_7d3e@example.com', `UserName` = 'user_46_7d3e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_7e67@example.com', `Email` = 'user_47_7e67@example.com', `NormalizedEmail` = 'USER_47_7E67@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_7E67', `PasswordHash` = 'umCqeJxA4EtqSIZ6rGQQGlvd4IM/CZNZC/jyzeT9zrGZBFDHOjaoVcLN+88jIe77', `SecurityStamp` = 'user_47_7e67@example.com', `UserName` = 'user_47_7e67'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_80dd@example.com', `Email` = 'user_48_80dd@example.com', `NormalizedEmail` = 'USER_48_80DD@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_80DD', `PasswordHash` = 'oTBt3/6O4vP1F3T8qPGYW6qXy/DtbVW+5evizhogC46QcU4qoVKHLqOCJTg2F5GR', `SecurityStamp` = 'user_48_80dd@example.com', `UserName` = 'user_48_80dd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_c4a4@example.com', `Email` = 'user_49_c4a4@example.com', `NormalizedEmail` = 'USER_49_C4A4@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_C4A4', `PasswordHash` = 'Sq9FQwzGSDo3Z5wsGnlWqj9xdPxti9XBmO054brWv1UqcW4rBOs2GlRkhLHv+u9m', `SecurityStamp` = 'user_49_c4a4@example.com', `UserName` = 'user_49_c4a4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_b2fe@example.com', `Email` = 'user_50_b2fe@example.com', `NormalizedEmail` = 'USER_50_B2FE@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_B2FE', `PasswordHash` = 'MEDaJwOxNnn1Tzc/M0nVYgsl8C4DcqUPP7pmTmkJNaZNoD/L69tVTCRFzW7YRk3q', `SecurityStamp` = 'user_50_b2fe@example.com', `UserName` = 'user_50_b2fe'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'UZynG9It5F5OEZBDRFivIriozPvGEKrwSJF+tmaDB7vlFaRZNMujNPJrwZcX59Qz'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('46ca0aa4-6554-4af2-a727-2c0827ea5e98', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('f96c65f7-fa93-455b-aea2-5690680b1f6d', TIMESTAMP '2025-03-04 15:39:06', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL);

CREATE INDEX `IX_Tags_CommentId` ON `Tags` (`CommentId`);

CREATE INDEX `IX_Tags_PostId` ON `Tags` (`PostId`);

CREATE INDEX `IX_PostRelatedPost_RelatedPostId` ON `PostRelatedPost` (`RelatedPostId`);

CREATE INDEX `IX_Comment_ParentCommentId` ON `Comment` (`ParentCommentId`);

CREATE INDEX `IX_Comment_UserId` ON `Comment` (`UserId`);

CREATE INDEX `IX_PostTopic_TopicId` ON `PostTopic` (`TopicId`);

ALTER TABLE `Comment` ADD CONSTRAINT `FK_Comment_Comment_ParentCommentId` FOREIGN KEY (`ParentCommentId`) REFERENCES `Comment` (`Id`);

ALTER TABLE `Comment` ADD CONSTRAINT `FK_Comment_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostAttachment` ADD CONSTRAINT `FK_PostAttachment_Attachment_AttachmentId` FOREIGN KEY (`AttachmentId`) REFERENCES `Attachment` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostComment` ADD CONSTRAINT `FK_PostComment_Comment_CommentId` FOREIGN KEY (`CommentId`) REFERENCES `Comment` (`Id`) ON DELETE CASCADE;

ALTER TABLE `PostRelatedPost` ADD CONSTRAINT `FK_PostRelatedPost_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `PostRelatedPost` ADD CONSTRAINT `FK_PostRelatedPost_Posts_RelatedPostId` FOREIGN KEY (`RelatedPostId`) REFERENCES `Posts` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Tags` ADD CONSTRAINT `FK_Tags_Comment_CommentId` FOREIGN KEY (`CommentId`) REFERENCES `Comment` (`Id`);

ALTER TABLE `Tags` ADD CONSTRAINT `FK_Tags_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250304153912_AddPostRelatedPostRelationship', '9.0.1');

DROP PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY`;

DROP PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY`;

DELETE FROM `Countries`
WHERE `Id` = '178fb5c9-0e15-4590-853d-60f1a6254722';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '1f97ec75-15b1-43c0-8e92-fbcf8adcfad4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '33cc27d0-453b-490c-a84c-0463ba6cc55e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '49703bb1-5422-45f4-8350-c38bc715c34d';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '49dc1c42-25c3-4773-9e25-844fed18e64d';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '62308f13-07f3-498e-9103-41b5ef334450';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6232278d-e7b7-46ad-832d-b19e178a5e65';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'acc0e240-2422-4cbd-98b5-df581430b10e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'e214a56d-c348-4cbe-bf7a-e4c798ae7495';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'ea7567dd-11db-4414-877b-df4c2c216c86';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '0afb6230-629a-425c-84e6-a448f12c13fe';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '29242680-ba1e-4d6e-8854-8fd194f28166';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '5b6fbb5a-6ba5-4d4b-aaa1-6104430f6443';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'f4613664-22ae-4f2c-8d01-be6260b38c39';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '59cb0ed6-bac1-4af4-adc5-2819c0f02eda';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '94c93979-b739-41ab-9be2-5cbbfb639c76';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'b1d971b5-7c2b-4fef-b4ae-ed26829d49e4';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'f44fd3dc-5878-46fc-b822-df3348435779';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '0ed17047-9715-4031-b5cb-d9020eda4654';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '19607e5f-6efa-45fe-94fc-eb503849b6c1';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '21ebfdaa-fd22-44b5-9b1e-02f3256a842a';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '6d99caca-5806-4be8-b6f1-d7c23c1af2d5';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '89b14cc1-7c20-4acc-ab30-3bb970fcb6d2';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '928a387d-40d1-4212-94b3-5d2e34a4334c';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '48cb7ade-f2bb-4426-8d02-b912876e4cca';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '03d2cf8f-beb8-4455-ade0-efc5635e5c6a';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4fbba298-ccbc-4f2d-b394-ff33b23fe274';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '61e4acc8-fc16-43e3-80ac-80bda54b2cfb';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b4d0e151-3155-4508-9ee7-5110e74b2ce1';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b53b026d-ae7b-497c-a851-e02c4fba9892';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'fb62843b-9af4-4be7-ac4d-5bae89f98695';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '4245e448-8c62-45dd-961d-29892f7eb482';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '8e21f077-05a1-4fce-ab74-6967fd7e4eec';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'cff3246d-a9c3-4807-811d-a8a23eb0cfb7';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'fc4840eb-149b-4b6d-afaa-3c13376c3694';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '04405d90-002a-4f4f-9d90-33a4a086f334';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '71839c3f-b9eb-435b-a3e2-d770ed71f5e1';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'c2bb72b8-ee0e-4233-9206-da0a1f040fc1';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'f1860167-41bf-4f7b-8cea-0e5022a98c25';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'f378bf36-407d-4e6d-b07e-5a0c64fb7c01';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '33bd44b3-77b1-4387-91fc-89dfe23cc74b';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '46ca0aa4-6554-4af2-a727-2c0827ea5e98';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'f96c65f7-fa93-455b-aea2-5690680b1f6d';
SELECT ROW_COUNT();


INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('011253c8-cfce-4750-b3d5-3e797827b04c', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('0aa6454b-b170-4ef3-9955-074552a091a4', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('31a9eecb-74ec-4025-be74-3b1047015a9b', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('358c142e-f64e-4710-b04f-7bd007938dba', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('6449babe-9203-41dc-82ae-8d18d309c860', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('68cffb7f-f817-4483-9afb-131d7f170220', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('6ad1314a-629d-44f6-8bb8-503ea7623a93', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('a1315eed-4fb4-4592-af8b-be0edaf70a68', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('a2fab4ba-6694-4737-852a-7510607d65a0', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('ca629a9b-541b-4e62-bf14-4eeaa940f93b', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('050d0499-3795-41b4-87a9-9fa6577ee5f4', 'USD', TIMESTAMP '2025-03-04 15:49:43', 2, TRUE, 'US Dollar', '$', NULL),
('678ef4ca-43f8-444e-9678-32da5e99048a', 'EUR', TIMESTAMP '2025-03-04 15:49:43', 2, TRUE, 'Euro', '€', NULL),
('84f74f9b-5f0f-4a52-b9ca-6436f389472d', 'GBP', TIMESTAMP '2025-03-04 15:49:43', 2, TRUE, 'British Pound', '£', NULL),
('c6b6339c-1cf0-4e33-9a9e-ef6311eac7a9', 'CHF', TIMESTAMP '2025-03-04 15:49:43', 2, TRUE, 'Swiss Franc', 'Fr.', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('4e3c6cde-06f5-4c7a-9ce9-19e36ec207eb', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('548bc3de-c579-4d46-b364-af245e7e9aef', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('713e7ac2-66a3-4889-a410-0f92fcb00fc0', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('e1e83529-63ff-4b3b-b04b-cccd7f894376', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('05b4fc28-386d-40f5-a132-094bc595fdf0', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('5dcc69cc-166b-4b6a-8bec-cb6808d7dbc3', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('65684e84-040b-48ff-846e-922f44061a45', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL),
('68d7e228-925e-4171-824c-56b011ec5374', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('a8cf6a52-c1ad-4634-99d3-35436c71a7da', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('def9c465-a8fc-4675-816f-51160b78ac58', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('04628364-2237-4b7c-9e8a-3d0276aae865', TIMESTAMP '2025-03-04 15:49:43', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('404261da-076d-405e-bc64-e1055d951968', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('60b334cd-6d23-401a-985c-da15e5775633', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('9c32452d-e161-4af7-80fd-e6a32bf9f206', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('a7b8462a-6e51-4d1c-bb26-f4d29fde880b', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('b2d0cc30-e83b-46a7-a08d-3d5b2c7fe87e', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('dc9f631f-3887-4546-9017-b5b35863d006', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('05e534fd-00d7-418c-8102-dd2c49362caf', NULL, TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('157a0609-1869-4a68-aef3-cb80683c7e14', NULL, TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL),
('3bf231c7-a949-41ca-8bf3-2e568eabfad7', NULL, TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL),
('58a5301a-e352-4c03-87d1-81e885c4bbcb', NULL, TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('2ebe7412-55ac-4764-b1e0-76ba82adf2b8', TIMESTAMP '2025-03-04 15:49:43', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('8c45398a-1fd3-43a2-9c6f-797f4122f505', TIMESTAMP '2025-03-04 15:49:43', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('9b6782e6-c5f1-4cca-b05b-9459bb738b26', TIMESTAMP '2025-03-04 15:49:43', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('d597cf52-2d8c-44a9-bb31-eae48cdf0378', TIMESTAMP '2025-03-04 15:49:43', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('e7fdc66b-b37d-46e8-9fd6-a58f5b01bde3', TIMESTAMP '2025-03-04 15:49:43', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-04 15:49:43'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('42e02350-61f8-4a32-bc80-3a09b23f179b', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('868ab308-b684-46ef-9d10-13fd66621269', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('b5f21e17-e9bc-430a-81de-d326ab6b557c', TIMESTAMP '2025-03-04 15:49:43', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'BsVRcsi00100r0G43ROzsLjVmaoDLWtcCv4fX6Di+XED75BtJ3/HpBUuV2Ijo29D'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'ImyVR4iotWt/QnBoUl4kDwxBYEiwftNG3FnOV8Lqy71q6jCd2EXBrQVo5HsFWZOE'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_4ebf@example.com', `Email` = 'user_1_4ebf@example.com', `NormalizedEmail` = 'USER_1_4EBF@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_4EBF', `PasswordHash` = 'ro5nHj3m2qEolv27Kc9l7C5t8ziveeVB+QflGwAFhKeqANfTGTtK66I1/9PPnfH6', `SecurityStamp` = 'user_1_4ebf@example.com', `UserName` = 'user_1_4ebf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_9518@example.com', `Email` = 'user_2_9518@example.com', `NormalizedEmail` = 'USER_2_9518@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_9518', `PasswordHash` = 'tP6vJXtHeRZ9o5AVCEfwlw6wthHXrm8f8irsDH0iIviN+SGg0jjHWEY0e0hl700B', `SecurityStamp` = 'user_2_9518@example.com', `UserName` = 'user_2_9518'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_2ac6@example.com', `Email` = 'user_3_2ac6@example.com', `NormalizedEmail` = 'USER_3_2AC6@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_2AC6', `PasswordHash` = 'WRVg3EUdgHtO6kDHAIKmdRH1yxZTZEGoLDcOekmszH/bFnTCBdAfYM8AILpQCxC2', `SecurityStamp` = 'user_3_2ac6@example.com', `UserName` = 'user_3_2ac6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_e289@example.com', `Email` = 'user_4_e289@example.com', `NormalizedEmail` = 'USER_4_E289@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_E289', `PasswordHash` = 'dZIAy78gKQCFLK6ATIxThArCXv6wGI+OISyaoU62uaUHZn5euYnuRjCAa4k8t1Nq', `SecurityStamp` = 'user_4_e289@example.com', `UserName` = 'user_4_e289'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_49ba@example.com', `Email` = 'user_5_49ba@example.com', `NormalizedEmail` = 'USER_5_49BA@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_49BA', `PasswordHash` = 'HH4tdwiihJ1rvhO4dxUwAeUuSHFI+SlQcRbQreb+fuZWH9LsnCZxx5sY7U/u9TZ9', `SecurityStamp` = 'user_5_49ba@example.com', `UserName` = 'user_5_49ba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_4659@example.com', `Email` = 'user_6_4659@example.com', `NormalizedEmail` = 'USER_6_4659@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_4659', `PasswordHash` = 'RZRaV6/XW+IHKp3g4pelJ5xwmdeJyYGb1SDQLa77+15gYNrTA6dN6+jU4S2VrFkS', `SecurityStamp` = 'user_6_4659@example.com', `UserName` = 'user_6_4659'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_9c94@example.com', `Email` = 'user_7_9c94@example.com', `NormalizedEmail` = 'USER_7_9C94@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_9C94', `PasswordHash` = 'woNEQtLRZOXMDRQ/kE8AIPn52o2B5cBdktY7DqeJwrTaY+Xd/0aMVZB6hf9EKIP5', `SecurityStamp` = 'user_7_9c94@example.com', `UserName` = 'user_7_9c94'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_6edd@example.com', `Email` = 'user_8_6edd@example.com', `NormalizedEmail` = 'USER_8_6EDD@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_6EDD', `PasswordHash` = 'rtvtyeNaCenu8lFPQaG9R3rHjldrJCxPOXqy2k0AjYAw3dQOsXJ5IYXL6r+k+Ju7', `SecurityStamp` = 'user_8_6edd@example.com', `UserName` = 'user_8_6edd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_95ff@example.com', `Email` = 'user_9_95ff@example.com', `NormalizedEmail` = 'USER_9_95FF@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_95FF', `PasswordHash` = 's9qYPbRfH9Pns6ZBeGe7mz1Fkic9fiamTr8Fkqs8lMV32bI35ArfAeahJE3ovjf4', `SecurityStamp` = 'user_9_95ff@example.com', `UserName` = 'user_9_95ff'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_ceed@example.com', `Email` = 'user_10_ceed@example.com', `NormalizedEmail` = 'USER_10_CEED@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_CEED', `PasswordHash` = 'imA/Bd7zVkCIw/m9T38oIlh9yH9Gb7riozV/nHNqDNcoUNq1QE49+Yp0acnXxsZI', `SecurityStamp` = 'user_10_ceed@example.com', `UserName` = 'user_10_ceed'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_688c@example.com', `Email` = 'user_11_688c@example.com', `NormalizedEmail` = 'USER_11_688C@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_688C', `PasswordHash` = 'X58ZD6zhm38AZ9wxZEofGfKubcKBC/RP924AJSVDDAMagmo70O/Nr8Dk5Cv2WivO', `SecurityStamp` = 'user_11_688c@example.com', `UserName` = 'user_11_688c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_1a9e@example.com', `Email` = 'user_12_1a9e@example.com', `NormalizedEmail` = 'USER_12_1A9E@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_1A9E', `PasswordHash` = 'kALM19LFaanN5IZNwXiC+tzkYOpf63wqbjogO8lYfRm2LFFBWoPlK38TqA+d1mOV', `SecurityStamp` = 'user_12_1a9e@example.com', `UserName` = 'user_12_1a9e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_248e@example.com', `Email` = 'user_13_248e@example.com', `NormalizedEmail` = 'USER_13_248E@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_248E', `PasswordHash` = 'Ji7mZD8iF9b20oABIXKPqWoiS9Rnh2Vd+SeUuZtMgQM/3pkh7h7mMv3F8/hboDuO', `SecurityStamp` = 'user_13_248e@example.com', `UserName` = 'user_13_248e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_1e80@example.com', `Email` = 'user_14_1e80@example.com', `NormalizedEmail` = 'USER_14_1E80@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_1E80', `PasswordHash` = 't9Zmvc9mXRrs4uMYRB4vXhEYiPcD19VJnGlKq1iVUH6pC2XAgj9rGl9xzY8KkMJ8', `SecurityStamp` = 'user_14_1e80@example.com', `UserName` = 'user_14_1e80'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_e704@example.com', `Email` = 'user_15_e704@example.com', `NormalizedEmail` = 'USER_15_E704@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_E704', `PasswordHash` = '7WFRy8J2iSmMcRI+ir7VwNcrQHF7weD1l0Smo5uiEa/bC34lusPUs0eF1C1vre4r', `SecurityStamp` = 'user_15_e704@example.com', `UserName` = 'user_15_e704'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_3423@example.com', `Email` = 'user_16_3423@example.com', `NormalizedEmail` = 'USER_16_3423@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_3423', `PasswordHash` = 'Hh5n+rgMNsv2FlVERtPMKR2+8zYPIclSTmZhtasbZ9l0jnPecLrDG+Dqrnq5/Bec', `SecurityStamp` = 'user_16_3423@example.com', `UserName` = 'user_16_3423'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_f047@example.com', `Email` = 'user_17_f047@example.com', `NormalizedEmail` = 'USER_17_F047@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_F047', `PasswordHash` = 'UjyBK8wDiIXCxbDDp9laQNlRCzyCdBSfvBJGhpMfGlPIT529bqOgvFX9/Gq+gYlx', `SecurityStamp` = 'user_17_f047@example.com', `UserName` = 'user_17_f047'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_3dee@example.com', `Email` = 'user_18_3dee@example.com', `NormalizedEmail` = 'USER_18_3DEE@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_3DEE', `PasswordHash` = 'uqY3100xnMX2ZX1UO7Bq/LPiRAmS6ibffKoxeHSu9gY8N2YqPrB/OL2DON9Kwpcu', `SecurityStamp` = 'user_18_3dee@example.com', `UserName` = 'user_18_3dee'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_d4ba@example.com', `Email` = 'user_19_d4ba@example.com', `NormalizedEmail` = 'USER_19_D4BA@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_D4BA', `PasswordHash` = 'MTK/oRSUOLZEngLMSw4g7JtgbaeF6bNdMzmqiQxr+/EbjO1zMUKUy3LXWkuEi42F', `SecurityStamp` = 'user_19_d4ba@example.com', `UserName` = 'user_19_d4ba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_e039@example.com', `Email` = 'user_20_e039@example.com', `NormalizedEmail` = 'USER_20_E039@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_E039', `PasswordHash` = 'N1hN3KF2vAsMBS5f309ExxmfeZqS/WXhL1WTxHa+RNZFoU4W15RzoX3T50CKps4m', `SecurityStamp` = 'user_20_e039@example.com', `UserName` = 'user_20_e039'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_3426@example.com', `Email` = 'user_21_3426@example.com', `NormalizedEmail` = 'USER_21_3426@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_3426', `PasswordHash` = '0YteI/D8JjrynJbisMLQD6Ud4pOHnjLOXVToxrGpS3H396xsh8k0R9wZhML7GBdf', `SecurityStamp` = 'user_21_3426@example.com', `UserName` = 'user_21_3426'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_5eda@example.com', `Email` = 'user_22_5eda@example.com', `NormalizedEmail` = 'USER_22_5EDA@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_5EDA', `PasswordHash` = 'znhJrLq3cIX2u3CbXLPk9dhHVSNNPB5ARukXMugHFH859Vf/AdCLFfsyjixa9B8d', `SecurityStamp` = 'user_22_5eda@example.com', `UserName` = 'user_22_5eda'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_d289@example.com', `Email` = 'user_23_d289@example.com', `NormalizedEmail` = 'USER_23_D289@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_D289', `PasswordHash` = 'olX6N+J2LCTt8IdXBwYnoq5cRWCi82v9hEgOe3n/kJtBEmP3Yon8JBFldi6uTwQK', `SecurityStamp` = 'user_23_d289@example.com', `UserName` = 'user_23_d289'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_7014@example.com', `Email` = 'user_24_7014@example.com', `NormalizedEmail` = 'USER_24_7014@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_7014', `PasswordHash` = 'vpLKP3ApYX2gaD06zYZopR06ZyuPAwC/0bHjzASew26MVkx4GhiVQQWjAWi74XIi', `SecurityStamp` = 'user_24_7014@example.com', `UserName` = 'user_24_7014'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_1dbf@example.com', `Email` = 'user_25_1dbf@example.com', `NormalizedEmail` = 'USER_25_1DBF@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_1DBF', `PasswordHash` = 'Cfmm6wQNMGwlZ2t6za1xafjyQ3y2IC9o8aDJ7IY/nYYXofPslZUyEguT/T6BX5Aj', `SecurityStamp` = 'user_25_1dbf@example.com', `UserName` = 'user_25_1dbf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_71b9@example.com', `Email` = 'user_26_71b9@example.com', `NormalizedEmail` = 'USER_26_71B9@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_71B9', `PasswordHash` = 'uQlvkLhRzzeX5s/pT+ZEX8EHZ4VVrQ97DXsaoQ8pTnpgpTCDWyEVE6a7VVl2wGm3', `SecurityStamp` = 'user_26_71b9@example.com', `UserName` = 'user_26_71b9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_35a3@example.com', `Email` = 'user_27_35a3@example.com', `NormalizedEmail` = 'USER_27_35A3@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_35A3', `PasswordHash` = 'd1ATBm4m5lIdTyXW/0SoQuh3E629YhGIvQeYC1qd371MsKO8/lkjQjCVRnp16uiq', `SecurityStamp` = 'user_27_35a3@example.com', `UserName` = 'user_27_35a3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_f1dc@example.com', `Email` = 'user_28_f1dc@example.com', `NormalizedEmail` = 'USER_28_F1DC@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_F1DC', `PasswordHash` = 'hKcZRnGsuUTkIBH4P2b2kxWtKQbdR3o5T/QTydX9XaDGNLeX0UHFcz1zajQzD8cx', `SecurityStamp` = 'user_28_f1dc@example.com', `UserName` = 'user_28_f1dc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_82ee@example.com', `Email` = 'user_29_82ee@example.com', `NormalizedEmail` = 'USER_29_82EE@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_82EE', `PasswordHash` = 'Sf74mRCa9fGgP/EbvUqSYY4jQ32Xc0l54hyYwoMc9OFUMXT9XnSXnl9sItP9r9/C', `SecurityStamp` = 'user_29_82ee@example.com', `UserName` = 'user_29_82ee'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_bd17@example.com', `Email` = 'user_30_bd17@example.com', `NormalizedEmail` = 'USER_30_BD17@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_BD17', `PasswordHash` = 'L0QcYlwfHqQGWNTnBDhSUCzrLBaTY5KTRcyaJ21gqwd4JfH6b6iz161qa29Imhh1', `SecurityStamp` = 'user_30_bd17@example.com', `UserName` = 'user_30_bd17'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_497d@example.com', `Email` = 'user_31_497d@example.com', `NormalizedEmail` = 'USER_31_497D@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_497D', `PasswordHash` = 'tzt76lAvWxCxSHkbsqBUpb5gPNY8pFggDc/XQUBAxPDi7mEDD/HZxJ9HzftQbidK', `SecurityStamp` = 'user_31_497d@example.com', `UserName` = 'user_31_497d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_247f@example.com', `Email` = 'user_32_247f@example.com', `NormalizedEmail` = 'USER_32_247F@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_247F', `PasswordHash` = 'llOUvkMFYvGcIOLynGjmLnJGcZqOA7SaeejLxnW/76e2xPwpYmXOhtX/1HvGd4QK', `SecurityStamp` = 'user_32_247f@example.com', `UserName` = 'user_32_247f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_c5dc@example.com', `Email` = 'user_33_c5dc@example.com', `NormalizedEmail` = 'USER_33_C5DC@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_C5DC', `PasswordHash` = '8e5RuvspBGpfuGyaU5ljoj1iZHL7Fuqg3D09XQgoODdIZ/B5PsZ7v3kvo/YqoeQJ', `SecurityStamp` = 'user_33_c5dc@example.com', `UserName` = 'user_33_c5dc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_ae42@example.com', `Email` = 'user_34_ae42@example.com', `NormalizedEmail` = 'USER_34_AE42@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_AE42', `PasswordHash` = 'D1rsUJZnJ8JiQQLfHmgJAdb2V3V6ll+60Xz785RoZ06H1fsbIriihrJuNc5Q6e09', `SecurityStamp` = 'user_34_ae42@example.com', `UserName` = 'user_34_ae42'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_6c7b@example.com', `Email` = 'user_35_6c7b@example.com', `NormalizedEmail` = 'USER_35_6C7B@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_6C7B', `PasswordHash` = 'wyMjIc0HbxtCeRgf4TISPcDvMA4f5Ise51KVUzqDxPdSvUfaV+N4xH71W7R2NFzF', `SecurityStamp` = 'user_35_6c7b@example.com', `UserName` = 'user_35_6c7b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_6e02@example.com', `Email` = 'user_36_6e02@example.com', `NormalizedEmail` = 'USER_36_6E02@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_6E02', `PasswordHash` = 'HzMvnpoO134ZIRd/7kqweShW7JUa2+DESi3qksuuJNmqcIMtDKP98a1gh3BxwE1s', `SecurityStamp` = 'user_36_6e02@example.com', `UserName` = 'user_36_6e02'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_839b@example.com', `Email` = 'user_37_839b@example.com', `NormalizedEmail` = 'USER_37_839B@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_839B', `PasswordHash` = 'pSyjOv5Nwa4JfCHKgDaJlx8LjKVxEvZHFW/HiTay5wtsq4KOU43h9j1r3V6f9mQU', `SecurityStamp` = 'user_37_839b@example.com', `UserName` = 'user_37_839b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_bc98@example.com', `Email` = 'user_38_bc98@example.com', `NormalizedEmail` = 'USER_38_BC98@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_BC98', `PasswordHash` = 'UZgWNkLaZ5ed2DxzSBRA3BadlGL9keoNeCMaui6Vtkzxv5B7D7N2vF/TW1IClXi3', `SecurityStamp` = 'user_38_bc98@example.com', `UserName` = 'user_38_bc98'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_4bfe@example.com', `Email` = 'user_39_4bfe@example.com', `NormalizedEmail` = 'USER_39_4BFE@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_4BFE', `PasswordHash` = 'ro3FUgiFrOl13AtlIkSunoOGQUV3atNgsnCGm2zDDxAwB0cxkat0CyWqxx1+eXuY', `SecurityStamp` = 'user_39_4bfe@example.com', `UserName` = 'user_39_4bfe'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_4520@example.com', `Email` = 'user_40_4520@example.com', `NormalizedEmail` = 'USER_40_4520@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_4520', `PasswordHash` = '2CkAUE02brP6yQtgBFSaxWowkHZAv+xTiak2pxAmVCOJ4Ld4IiHSV2VzkG0GBaBt', `SecurityStamp` = 'user_40_4520@example.com', `UserName` = 'user_40_4520'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_164c@example.com', `Email` = 'user_41_164c@example.com', `NormalizedEmail` = 'USER_41_164C@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_164C', `PasswordHash` = 'CdrP+MIDuE0AicWG4wtpHKmsToo34T5PY2R9Mb+HdKx4r3+qnO+zp+T2wHbe4WIQ', `SecurityStamp` = 'user_41_164c@example.com', `UserName` = 'user_41_164c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_8f17@example.com', `Email` = 'user_42_8f17@example.com', `NormalizedEmail` = 'USER_42_8F17@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_8F17', `PasswordHash` = 'P8D/lH8cYpcgXYpxCGgecjqdNVTPr/G/KphYkAlKbQKRh629TOsUvzsi2cVJYIMd', `SecurityStamp` = 'user_42_8f17@example.com', `UserName` = 'user_42_8f17'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_0e46@example.com', `Email` = 'user_43_0e46@example.com', `NormalizedEmail` = 'USER_43_0E46@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_0E46', `PasswordHash` = 'pdHebHARqBdLsV3fmx79WDkwgc8k4yHt9dR/bJ4E3zKqrF3IYFnnfNXyIUrZn4wX', `SecurityStamp` = 'user_43_0e46@example.com', `UserName` = 'user_43_0e46'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_e80a@example.com', `Email` = 'user_44_e80a@example.com', `NormalizedEmail` = 'USER_44_E80A@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_E80A', `PasswordHash` = 'VjoG0ERPrjLGPHAl95gg8TreR1eAAlKL9rIWpxiyHXKCv6JAUiRs1IhrAeVLQecA', `SecurityStamp` = 'user_44_e80a@example.com', `UserName` = 'user_44_e80a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_7303@example.com', `Email` = 'user_45_7303@example.com', `NormalizedEmail` = 'USER_45_7303@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_7303', `PasswordHash` = '+jY4vtzx7+WUP/DnVrGKUqcIfg8pa7KItDggg6a4n7O4t0uWMf5kY2BF09gugvuh', `SecurityStamp` = 'user_45_7303@example.com', `UserName` = 'user_45_7303'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_08c4@example.com', `Email` = 'user_46_08c4@example.com', `NormalizedEmail` = 'USER_46_08C4@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_08C4', `PasswordHash` = 'atEMFgLX8fqSsdFLL8eFRut4agNQ52HQsgcy/MaJX+1kOa6UZ0bM/50KC1iLHrev', `SecurityStamp` = 'user_46_08c4@example.com', `UserName` = 'user_46_08c4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_a0f7@example.com', `Email` = 'user_47_a0f7@example.com', `NormalizedEmail` = 'USER_47_A0F7@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_A0F7', `PasswordHash` = 'heXD+TVq+71pbC/VaM1NsxpVXz2LpUyEVEwz/GTNzuFqTvmPVCi09nj8iSsU+9uF', `SecurityStamp` = 'user_47_a0f7@example.com', `UserName` = 'user_47_a0f7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_a17f@example.com', `Email` = 'user_48_a17f@example.com', `NormalizedEmail` = 'USER_48_A17F@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_A17F', `PasswordHash` = 'rLQ+fzUe9l4ADMLG+WvrvDjveS8lA+fuaSXiVQOAJ+Sq5Phb9RoAa5CmkDYobHGl', `SecurityStamp` = 'user_48_a17f@example.com', `UserName` = 'user_48_a17f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_4955@example.com', `Email` = 'user_49_4955@example.com', `NormalizedEmail` = 'USER_49_4955@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_4955', `PasswordHash` = 'q3pVo/ErDfuZS7jU2BkvvHAJk6Pol8BSny85ROJ0F5yUfTLSvjOcM5SO4/F9H/4I', `SecurityStamp` = 'user_49_4955@example.com', `UserName` = 'user_49_4955'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_c847@example.com', `Email` = 'user_50_c847@example.com', `NormalizedEmail` = 'USER_50_C847@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_C847', `PasswordHash` = '0lX8Eb5Fby7BG6/TIaKQINvDjzffd7HMizciACRzBtU5XUFiZVmatIQU4ONqrJK3', `SecurityStamp` = 'user_50_c847@example.com', `UserName` = 'user_50_c847'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'x+Lxhj3wtli5B26c7G54RGnfGY5mAL0MnvCqm0806i37E1PWiU0968j7XhcidXru'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250304154945_UpdateProjectSchema', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '011253c8-cfce-4750-b3d5-3e797827b04c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '0aa6454b-b170-4ef3-9955-074552a091a4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '31a9eecb-74ec-4025-be74-3b1047015a9b';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '358c142e-f64e-4710-b04f-7bd007938dba';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6449babe-9203-41dc-82ae-8d18d309c860';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '68cffb7f-f817-4483-9afb-131d7f170220';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6ad1314a-629d-44f6-8bb8-503ea7623a93';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a1315eed-4fb4-4592-af8b-be0edaf70a68';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a2fab4ba-6694-4737-852a-7510607d65a0';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'ca629a9b-541b-4e62-bf14-4eeaa940f93b';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '050d0499-3795-41b4-87a9-9fa6577ee5f4';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '678ef4ca-43f8-444e-9678-32da5e99048a';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '84f74f9b-5f0f-4a52-b9ca-6436f389472d';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'c6b6339c-1cf0-4e33-9a9e-ef6311eac7a9';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '4e3c6cde-06f5-4c7a-9ce9-19e36ec207eb';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '548bc3de-c579-4d46-b364-af245e7e9aef';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '713e7ac2-66a3-4889-a410-0f92fcb00fc0';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'e1e83529-63ff-4b3b-b04b-cccd7f894376';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '05b4fc28-386d-40f5-a132-094bc595fdf0';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5dcc69cc-166b-4b6a-8bec-cb6808d7dbc3';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '65684e84-040b-48ff-846e-922f44061a45';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '68d7e228-925e-4171-824c-56b011ec5374';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'a8cf6a52-c1ad-4634-99d3-35436c71a7da';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'def9c465-a8fc-4675-816f-51160b78ac58';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '04628364-2237-4b7c-9e8a-3d0276aae865';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '404261da-076d-405e-bc64-e1055d951968';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '60b334cd-6d23-401a-985c-da15e5775633';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '9c32452d-e161-4af7-80fd-e6a32bf9f206';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'a7b8462a-6e51-4d1c-bb26-f4d29fde880b';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b2d0cc30-e83b-46a7-a08d-3d5b2c7fe87e';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'dc9f631f-3887-4546-9017-b5b35863d006';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '05e534fd-00d7-418c-8102-dd2c49362caf';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '157a0609-1869-4a68-aef3-cb80683c7e14';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '3bf231c7-a949-41ca-8bf3-2e568eabfad7';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '58a5301a-e352-4c03-87d1-81e885c4bbcb';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '2ebe7412-55ac-4764-b1e0-76ba82adf2b8';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '8c45398a-1fd3-43a2-9c6f-797f4122f505';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '9b6782e6-c5f1-4cca-b05b-9459bb738b26';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'd597cf52-2d8c-44a9-bb31-eae48cdf0378';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'e7fdc66b-b37d-46e8-9fd6-a58f5b01bde3';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '42e02350-61f8-4a32-bc80-3a09b23f179b';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '868ab308-b684-46ef-9d10-13fd66621269';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'b5f21e17-e9bc-430a-81de-d326ab6b557c';
SELECT ROW_COUNT();


UPDATE `Users` SET `PhoneNumber` = ''
WHERE `PhoneNumber` IS NULL;
SELECT ROW_COUNT();


ALTER TABLE `Users` MODIFY COLUMN `PhoneNumber` longtext CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Users` ADD `IsLoggedIn` tinyint(1) NOT NULL DEFAULT FALSE;

ALTER TABLE `Users` ADD `RefreshToken` varchar(255) CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Users` ADD `RefreshTokenExpiration` datetime(6) NULL;

ALTER TABLE `Users` ADD `Token` longtext CHARACTER SET utf8mb4 NULL;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('04e1db5c-cea8-4e76-83c7-677b3e32099e', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('13d70ed8-dd46-46fe-99e1-b9871081e52c', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('2e949d35-83bf-41f8-85c6-e9a6747a67c4', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('44e8b866-9ffe-4f06-b594-dac8e1811027', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('7b11d086-90bb-4367-846b-cfb864015231', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('7cd492c6-e788-46d2-908b-7ead9fcebdbf', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('9038ff90-b290-42f9-9e43-5988434ee8fa', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('b2fb8e8b-7686-4ce4-a84c-6b9ac9a4bfe6', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('c00b6594-2ba3-4c5b-b15c-ab1098cc4e39', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('c95c47c6-6be3-4dd3-b5e4-c39e20676f9e', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('025cd1b3-1b4c-44e8-b7f0-85dda33415b0', 'GBP', TIMESTAMP '2025-03-05 12:21:20', 2, TRUE, 'British Pound', '£', NULL),
('36ccc6f8-216c-43dd-b8f5-6a76eebccde9', 'EUR', TIMESTAMP '2025-03-05 12:21:20', 2, TRUE, 'Euro', '€', NULL),
('a92fe68a-cd1d-4cdf-ac23-066b417e4ca9', 'CHF', TIMESTAMP '2025-03-05 12:21:20', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('b4a32afe-e33e-4b2e-b65b-25b250624e7a', 'USD', TIMESTAMP '2025-03-05 12:21:20', 2, TRUE, 'US Dollar', '$', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('03aae2f9-6474-4911-8033-79308ffd0994', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('74396458-b0b9-4e80-9d7c-f6c6e25c49d5', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('afd53535-29bf-4524-8e82-261039722a6b', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('bbe459b6-2a42-4f82-a615-2b188fc96212', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('6d041bd2-a8f6-44ca-8cb3-bf4cc5be9e40', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL),
('872c3ce2-b353-4820-933d-2aa2b0d076ad', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('db7b1a06-3dc7-41c6-8630-c6c6fffdd59f', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('dc61eef6-59f1-4458-9ac5-6fc71849eb86', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('ecf7f88d-ac91-40c6-b7a2-8f48723fd5a5', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('f49f6bff-92fa-4319-bdd7-f25c3ff97231', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('23fc22be-1347-4a18-b5bf-133dbb7c5580', TIMESTAMP '2025-03-05 12:21:20', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('203efa20-ec83-416c-8c7c-e15db60b3376', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('5c916406-a240-4bf7-b060-9246a2e2ed95', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('a55c57c8-3483-4d7f-bec0-6d469b9e6bbc', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('d8a359ac-1643-44b1-bed9-28e05753a181', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('f02b99e7-b2ed-485c-8360-1658750d3ad5', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('fb6235ea-c95f-4995-b3e1-e51b144f7987', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0c2e195b-1b62-4623-9c14-fa82eccf8dbf', NULL, TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL),
('43416a93-2167-4354-9cc4-bbf72f34ea28', NULL, TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL),
('75dfe181-65f9-4a1e-8bcc-ddfc8d0db817', NULL, TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('97426829-0bdb-455c-a1af-435318d4f660', NULL, TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('3179aad1-c782-4fd0-9cb4-f10fc79c5360', TIMESTAMP '2025-03-05 12:21:20', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('406c64f6-5439-407b-971a-c028897f2974', TIMESTAMP '2025-03-05 12:21:20', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('579147fc-2f60-46dd-802d-1bcc30c66324', TIMESTAMP '2025-03-05 12:21:20', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('a352502c-19d8-4b9e-8527-05828a70bb84', TIMESTAMP '2025-03-05 12:21:20', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('c1e54dc8-d803-4f56-b645-4e4c2a3a4eb1', TIMESTAMP '2025-03-05 12:21:20', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-05 12:21:20'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0802724c-918b-44b0-a3b1-a37e40307d40', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('a759b72a-bb37-449c-869b-5629502b1726', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('ceea4503-d173-48aa-819a-19439e1a8cc6', TIMESTAMP '2025-03-05 12:21:20', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL);

UPDATE `Users` SET `IsLoggedIn` = FALSE, `PasswordHash` = 'EjyQZaD4xfWePoQcDJz8/86p7s8PoDJvGr4bmpmpsrkQJur0OrNcFwRcoz1Yu9WV', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `Token` = NULL
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `IsLoggedIn` = FALSE, `PasswordHash` = 'xWJrziqhQlHM3vLzx0tQJ+2Svj6G7JOYJPeyRILsAzwvAIlfYEZfjVkXIkcTEo2d', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `Token` = NULL
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_d958@example.com', `Email` = 'user_1_d958@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_1_D958@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_D958', `PasswordHash` = '6TvORFsLaSBq8BH45KySJqbNyd+YuzPYt/mfzKpfUD0eNjyyJOh1oWZznOVaGYfv', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_1_d958@example.com', `Token` = NULL, `UserName` = 'user_1_d958'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_132a@example.com', `Email` = 'user_2_132a@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_2_132A@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_132A', `PasswordHash` = 'yKRVt4zfxhSozDISxxNEIse9W9YP8vpwJrMV3mFYua6zBT9DoeS+7vk9De6mmvZy', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_2_132a@example.com', `Token` = NULL, `UserName` = 'user_2_132a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_12c0@example.com', `Email` = 'user_3_12c0@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_3_12C0@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_12C0', `PasswordHash` = '/o7MToGCgPXaT1rqy4hiotykChFo+ESeKPM+cTW6t00wDRdYvOpfF6eqwywpYnOb', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_3_12c0@example.com', `Token` = NULL, `UserName` = 'user_3_12c0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_76c1@example.com', `Email` = 'user_4_76c1@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_4_76C1@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_76C1', `PasswordHash` = 'KjHflMytHwC4q2ZcEsW/W+N7v+sPVdBjcNwaatiUl+L7hdjEpaxzmYOHB9ms7JW9', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_4_76c1@example.com', `Token` = NULL, `UserName` = 'user_4_76c1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_842a@example.com', `Email` = 'user_5_842a@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_5_842A@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_842A', `PasswordHash` = 'pUCGF58VzSKvMN3Gphe6hWjBHAUwx2zMfBikiJo9/K+W1OOlrtp6SQeQWqb6nnaD', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_5_842a@example.com', `Token` = NULL, `UserName` = 'user_5_842a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_38b3@example.com', `Email` = 'user_6_38b3@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_6_38B3@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_38B3', `PasswordHash` = 'TKkoeiph53LFDZEBWyBWqoHvo+qXg3k9d8bwNVMQs6JxziqwrONyKX1iBdBS5sHK', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_6_38b3@example.com', `Token` = NULL, `UserName` = 'user_6_38b3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_a81b@example.com', `Email` = 'user_7_a81b@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_7_A81B@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_A81B', `PasswordHash` = 'nkv+yV7Y3cw+gWTCDt2/qo0ft5nO0Sl/y8m/cFGoV8CRdRzMRed0PSzwjmYhrSo3', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_7_a81b@example.com', `Token` = NULL, `UserName` = 'user_7_a81b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_faff@example.com', `Email` = 'user_8_faff@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_8_FAFF@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_FAFF', `PasswordHash` = 'shJZLWoO3TUXXZO2h8muwOmfhue5JUAf3cT5MZjYB2kc7owc7ch2kcPlVUgXZJIL', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_8_faff@example.com', `Token` = NULL, `UserName` = 'user_8_faff'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_5066@example.com', `Email` = 'user_9_5066@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_9_5066@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_5066', `PasswordHash` = '5ynoa761JP/Z3U5t0r4hthDtacG24gF5qSLDQk4LERDp6Za80LjqUdtkjx2dCCTB', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_9_5066@example.com', `Token` = NULL, `UserName` = 'user_9_5066'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_b422@example.com', `Email` = 'user_10_b422@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_10_B422@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_B422', `PasswordHash` = 'sDbAOlcAOdkJQX8/TufhJrCCk5xraixmZrchveK/fj7PaN2NhsVZjLB7HqnrY3zW', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_10_b422@example.com', `Token` = NULL, `UserName` = 'user_10_b422'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_ccdb@example.com', `Email` = 'user_11_ccdb@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_11_CCDB@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_CCDB', `PasswordHash` = 'cDuAJmEZaGUsNZ22aLvOIYHurGkYOccc52daSwWJYib0XYlgzdSu9W1Zo0pFoc/s', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_11_ccdb@example.com', `Token` = NULL, `UserName` = 'user_11_ccdb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_b26e@example.com', `Email` = 'user_12_b26e@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_12_B26E@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_B26E', `PasswordHash` = 'wm8//XPIh6C1eTgJwqyp8S+kCX6fOS7XpyltASFasvXxN1IjH0e3RjJnWT+fbZIr', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_12_b26e@example.com', `Token` = NULL, `UserName` = 'user_12_b26e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_47df@example.com', `Email` = 'user_13_47df@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_13_47DF@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_47DF', `PasswordHash` = 'nFgU5NcOJdmBaMYfGjmZkjd/AiB2kzYFt5i8h6ceyXNJggJgp02rM9SviQDIt7Zi', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_13_47df@example.com', `Token` = NULL, `UserName` = 'user_13_47df'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_88c4@example.com', `Email` = 'user_14_88c4@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_14_88C4@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_88C4', `PasswordHash` = '80HBM3fezuNUgikHn/LL3/UP2Rycd0hqSx5uFOH/lEvvY9A0WwL1jZ8luIEtDWr6', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_14_88c4@example.com', `Token` = NULL, `UserName` = 'user_14_88c4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_9e93@example.com', `Email` = 'user_15_9e93@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_15_9E93@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_9E93', `PasswordHash` = 'w2baZ9b1azKav/GKxSefrQ9AvtkuCwRoAHw5quJ1i5OBM/aYPeY2ANi2aPdOCfXW', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_15_9e93@example.com', `Token` = NULL, `UserName` = 'user_15_9e93'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_9ac0@example.com', `Email` = 'user_16_9ac0@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_16_9AC0@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_9AC0', `PasswordHash` = 'Hx5RwTNkeHSRYNgx634BKKAp0q1zkb0sm1mjB6G0RjBIprKkRHG0FKrcfN2YfB1h', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_16_9ac0@example.com', `Token` = NULL, `UserName` = 'user_16_9ac0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_40b9@example.com', `Email` = 'user_17_40b9@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_17_40B9@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_40B9', `PasswordHash` = 'ZGKqaXoRDRRTphMhMTaxbNOTeTQvTBYN/GQfoQ2hXm44pzs7KXf7FghkRdpl+Ehh', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_17_40b9@example.com', `Token` = NULL, `UserName` = 'user_17_40b9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_dcfb@example.com', `Email` = 'user_18_dcfb@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_18_DCFB@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_DCFB', `PasswordHash` = 'L6FnRL1AQBmcuAlMiRHrAth9jp8W5XGx2Udr4Co5kE20IBzoZy+nZXWphzx5M0yV', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_18_dcfb@example.com', `Token` = NULL, `UserName` = 'user_18_dcfb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_afa7@example.com', `Email` = 'user_19_afa7@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_19_AFA7@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_AFA7', `PasswordHash` = 'CxPMzm/8WGqojzGYDXM+CeQdPnLwzMBtPQpDpd0McsmZuH9+oWcWn6ktrN9JqgF/', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_19_afa7@example.com', `Token` = NULL, `UserName` = 'user_19_afa7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_4f30@example.com', `Email` = 'user_20_4f30@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_20_4F30@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_4F30', `PasswordHash` = 'FEc6e+6bfSUmeE7J1Nq2v8mQobLGRSvyfZ3Io19Hjm9wvCFNfD/GMyS0I5AxF3mM', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_20_4f30@example.com', `Token` = NULL, `UserName` = 'user_20_4f30'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_1bcd@example.com', `Email` = 'user_21_1bcd@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_21_1BCD@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_1BCD', `PasswordHash` = 'vQHlrhfoFrB4edZ7zMFgoTuUuvfKfyQ8X4wSL+5agzBlFmG21Ag71up8Dqlj3V6T', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_21_1bcd@example.com', `Token` = NULL, `UserName` = 'user_21_1bcd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_9d67@example.com', `Email` = 'user_22_9d67@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_22_9D67@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_9D67', `PasswordHash` = '8xLaWriHhicfhStBoeVNLUaXUi+57fUWytSxUTDLV/hAmeob22XXWKxi8h421ZIt', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_22_9d67@example.com', `Token` = NULL, `UserName` = 'user_22_9d67'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_6120@example.com', `Email` = 'user_23_6120@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_23_6120@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_6120', `PasswordHash` = 'N9MKvmqnJPYv35kVNDacYbAdEzg1s1GbBEg88e7L5D13FaLjAOKvvsxrHsusl0JJ', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_23_6120@example.com', `Token` = NULL, `UserName` = 'user_23_6120'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_4c25@example.com', `Email` = 'user_24_4c25@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_24_4C25@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_4C25', `PasswordHash` = 'k4/jH9qVx4WEVrYriV4jQIOgCeCplGPHY0GhuHITwGqQg5ICKMwcdkQzTlPYdAlX', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_24_4c25@example.com', `Token` = NULL, `UserName` = 'user_24_4c25'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_d164@example.com', `Email` = 'user_25_d164@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_25_D164@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_D164', `PasswordHash` = 'wEAzVP/m+YfXWlhfiYMve/aECmlwvvd5YQr8kEwmaIpFwAMnqjX119F4vv3vjJYu', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_25_d164@example.com', `Token` = NULL, `UserName` = 'user_25_d164'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_7cdd@example.com', `Email` = 'user_26_7cdd@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_26_7CDD@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_7CDD', `PasswordHash` = '2iAkqv6Vy5Nd2/DVTBqqOk9c22xcRfn6G+wh60AOygG1rzHqPINOSpH2uziSP0oA', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_26_7cdd@example.com', `Token` = NULL, `UserName` = 'user_26_7cdd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_4688@example.com', `Email` = 'user_27_4688@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_27_4688@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_4688', `PasswordHash` = 'k7Gh9XQsTGMVD1vcmhR2rnuMzjF6ExD54wM47fLlliB+K3/kqaDNz6uPOC8MSz3V', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_27_4688@example.com', `Token` = NULL, `UserName` = 'user_27_4688'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_eee7@example.com', `Email` = 'user_28_eee7@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_28_EEE7@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_EEE7', `PasswordHash` = '2GdBwqneWDvJKmx+JG4QjTIpXOqPWgObyKksShCbYTzl4oz3f9MRZVjezmB/iqrY', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_28_eee7@example.com', `Token` = NULL, `UserName` = 'user_28_eee7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_3b8e@example.com', `Email` = 'user_29_3b8e@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_29_3B8E@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_3B8E', `PasswordHash` = 'U82mYp251q0WiOEPQ18r73r35ikNpD6Nsk0bNnJZwAeEsqR8nUOstT1nmjWAJGcI', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_29_3b8e@example.com', `Token` = NULL, `UserName` = 'user_29_3b8e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_25b9@example.com', `Email` = 'user_30_25b9@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_30_25B9@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_25B9', `PasswordHash` = 'TVq5g05jhNfJeiBz5/lV07d7F+x4wofuoTFxmffIaJnRgTcgpuM4wWA3quBuwahg', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_30_25b9@example.com', `Token` = NULL, `UserName` = 'user_30_25b9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_a522@example.com', `Email` = 'user_31_a522@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_31_A522@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_A522', `PasswordHash` = '+5YxeFhI2E/k8kTRfhEbzZul3Noa9dRUO9vdPRGY61Ieb7oACZmPhipjFKuU6/HN', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_31_a522@example.com', `Token` = NULL, `UserName` = 'user_31_a522'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_14d0@example.com', `Email` = 'user_32_14d0@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_32_14D0@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_14D0', `PasswordHash` = 'iZtMxHSj7cPho0fOX3hedgmMrLkS35a0OZ/qIdFZ3JPMEnTWEpx8I4qdT7T5GmyC', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_32_14d0@example.com', `Token` = NULL, `UserName` = 'user_32_14d0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_960e@example.com', `Email` = 'user_33_960e@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_33_960E@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_960E', `PasswordHash` = 'sfFS2osevMBE2wLAv8LM4BqQXjYTrCX39zJf9AI8Xgxc+sxVaZBAIDtcCdszJllV', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_33_960e@example.com', `Token` = NULL, `UserName` = 'user_33_960e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_5a05@example.com', `Email` = 'user_34_5a05@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_34_5A05@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_5A05', `PasswordHash` = 'JhUesarVkPhkHzS4VeI4nGxEKdduUtSG23HOY1E6TaEMuT28vCAiYn8SOUAxGG5L', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_34_5a05@example.com', `Token` = NULL, `UserName` = 'user_34_5a05'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_5913@example.com', `Email` = 'user_35_5913@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_35_5913@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_5913', `PasswordHash` = 'db2xeo6b1mcJsr+L4m45X+ixpX1ZFQ7fRqBZ0zMB0EZ3qXEyPGLMmm657i9wLVOL', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_35_5913@example.com', `Token` = NULL, `UserName` = 'user_35_5913'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_4ce9@example.com', `Email` = 'user_36_4ce9@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_36_4CE9@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_4CE9', `PasswordHash` = 'RsJEUjTSZdHNlofho+Ji7A7ACHLZ+3pzSkBFH6EXEEumPplwsylmfvL4KR3AUqRp', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_36_4ce9@example.com', `Token` = NULL, `UserName` = 'user_36_4ce9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_3222@example.com', `Email` = 'user_37_3222@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_37_3222@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_3222', `PasswordHash` = '94Iam5KRnwiTWrA9nnOvcGYz2KPY60BHt2C+EN77JaMCh4PLnjlMBBRAEP+92hbq', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_37_3222@example.com', `Token` = NULL, `UserName` = 'user_37_3222'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_4139@example.com', `Email` = 'user_38_4139@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_38_4139@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_4139', `PasswordHash` = 'neyizr7/t9lMzksxwtjag+G0awIoAoHkAR+UFARNbIyQvyWdL3H6m9zfCOUl6mWF', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_38_4139@example.com', `Token` = NULL, `UserName` = 'user_38_4139'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_8ea4@example.com', `Email` = 'user_39_8ea4@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_39_8EA4@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_8EA4', `PasswordHash` = 'NoGoD/yFpS03UW15LYfnEwKWdg8Np54CpBd93+bmJxod4NsVOs/4ZYBgaER19BAa', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_39_8ea4@example.com', `Token` = NULL, `UserName` = 'user_39_8ea4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_0d27@example.com', `Email` = 'user_40_0d27@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_40_0D27@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_0D27', `PasswordHash` = 'edWKWxYFyt3koV1zCfMlq5Eb0mX71m99g2duwmYX7nq7o23QwAhHRSJ0LIzXcp6T', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_40_0d27@example.com', `Token` = NULL, `UserName` = 'user_40_0d27'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_50a3@example.com', `Email` = 'user_41_50a3@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_41_50A3@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_50A3', `PasswordHash` = 'hEVCPiO0Xj+p8AUkXKuv/3zORZwy62yBt9fzVwaHwyNzgl+V1gINin//7gf62B4N', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_41_50a3@example.com', `Token` = NULL, `UserName` = 'user_41_50a3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_57d1@example.com', `Email` = 'user_42_57d1@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_42_57D1@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_57D1', `PasswordHash` = 'kSaIn4AsK39PMh23xF8C+R0bZf7VOoQodO7qURSAvzuhxIXpVYBmc8uzeW0Big8+', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_42_57d1@example.com', `Token` = NULL, `UserName` = 'user_42_57d1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_bcff@example.com', `Email` = 'user_43_bcff@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_43_BCFF@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_BCFF', `PasswordHash` = 'xo8d8V5MBwOKFZm6dq4wLtPk1Kn3OZnjj6pUqN5OQvtr58VBfMWmhtFuiRg/G9XO', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_43_bcff@example.com', `Token` = NULL, `UserName` = 'user_43_bcff'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_02cf@example.com', `Email` = 'user_44_02cf@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_44_02CF@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_02CF', `PasswordHash` = 'xOM35WqcwCyF7KgfzuEcfQuSuWmbIGibPgmn3wwzvPgdkgLvmbdGmV+Q0MHNt44Q', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_44_02cf@example.com', `Token` = NULL, `UserName` = 'user_44_02cf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_9055@example.com', `Email` = 'user_45_9055@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_45_9055@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_9055', `PasswordHash` = 'CrlKKTnZPaUHFKiCEiH12P/fSfpXVLsbpvX7yR228ewSqNEgCQUOwDyvrv5ptday', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_45_9055@example.com', `Token` = NULL, `UserName` = 'user_45_9055'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_7b22@example.com', `Email` = 'user_46_7b22@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_46_7B22@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_7B22', `PasswordHash` = 'xRxR0hojkF0NHi2GlBBrhQu+WQKJYApEgKOnB7lJ1r63jNNmCukCbIgKAx11MmU0', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_46_7b22@example.com', `Token` = NULL, `UserName` = 'user_46_7b22'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_f85e@example.com', `Email` = 'user_47_f85e@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_47_F85E@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_F85E', `PasswordHash` = '2elNfJh0rIavuP8RYujI7yjrHupxUvD5HwDmVnJcmRIXXp1IO3v8WLU1DHQ3rl49', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_47_f85e@example.com', `Token` = NULL, `UserName` = 'user_47_f85e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_42a9@example.com', `Email` = 'user_48_42a9@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_48_42A9@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_42A9', `PasswordHash` = 'iXmI9ZEAU6Eh30UTap+xg5La5oKL5bdQofjOc4ap4+cE+pBydsRDo0wC/CKWr5Gr', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_48_42a9@example.com', `Token` = NULL, `UserName` = 'user_48_42a9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_18f1@example.com', `Email` = 'user_49_18f1@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_49_18F1@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_18F1', `PasswordHash` = 'Ec57BeDnSoN99bMKeQX0hjeY7OtEAeLeJIGenSutJfjdwWr6nlq/RTym4AtzuAWU', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_49_18f1@example.com', `Token` = NULL, `UserName` = 'user_49_18f1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_1fc8@example.com', `Email` = 'user_50_1fc8@example.com', `IsLoggedIn` = FALSE, `NormalizedEmail` = 'USER_50_1FC8@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_1FC8', `PasswordHash` = 'yzhSI3CavXdzt2Ocxwqg4vpnOAdpWLcZ6+fs/x4iMv+x+w9tl1XogHN0KmQW9bdu', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `SecurityStamp` = 'user_50_1fc8@example.com', `Token` = NULL, `UserName` = 'user_50_1fc8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `IsLoggedIn` = FALSE, `PasswordHash` = 'zudIu8WdFPOfFXQQsqOhEhOTlmp5+MMJO0OC+pCIl8GbIwRwn3+O9QoK3KvdbBgu', `RefreshToken` = NULL, `RefreshTokenExpiration` = NULL, `Token` = NULL
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250305122127_ColumnIsLoggedInAdded', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '04e1db5c-cea8-4e76-83c7-677b3e32099e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '13d70ed8-dd46-46fe-99e1-b9871081e52c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '2e949d35-83bf-41f8-85c6-e9a6747a67c4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '44e8b866-9ffe-4f06-b594-dac8e1811027';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7b11d086-90bb-4367-846b-cfb864015231';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7cd492c6-e788-46d2-908b-7ead9fcebdbf';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9038ff90-b290-42f9-9e43-5988434ee8fa';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b2fb8e8b-7686-4ce4-a84c-6b9ac9a4bfe6';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c00b6594-2ba3-4c5b-b15c-ab1098cc4e39';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c95c47c6-6be3-4dd3-b5e4-c39e20676f9e';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '025cd1b3-1b4c-44e8-b7f0-85dda33415b0';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '36ccc6f8-216c-43dd-b8f5-6a76eebccde9';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'a92fe68a-cd1d-4cdf-ac23-066b417e4ca9';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'b4a32afe-e33e-4b2e-b65b-25b250624e7a';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '03aae2f9-6474-4911-8033-79308ffd0994';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '74396458-b0b9-4e80-9d7c-f6c6e25c49d5';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'afd53535-29bf-4524-8e82-261039722a6b';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'bbe459b6-2a42-4f82-a615-2b188fc96212';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '6d041bd2-a8f6-44ca-8cb3-bf4cc5be9e40';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '872c3ce2-b353-4820-933d-2aa2b0d076ad';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'db7b1a06-3dc7-41c6-8630-c6c6fffdd59f';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'dc61eef6-59f1-4458-9ac5-6fc71849eb86';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'ecf7f88d-ac91-40c6-b7a2-8f48723fd5a5';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f49f6bff-92fa-4319-bdd7-f25c3ff97231';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '23fc22be-1347-4a18-b5bf-133dbb7c5580';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '203efa20-ec83-416c-8c7c-e15db60b3376';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '5c916406-a240-4bf7-b060-9246a2e2ed95';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'a55c57c8-3483-4d7f-bec0-6d469b9e6bbc';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'd8a359ac-1643-44b1-bed9-28e05753a181';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'f02b99e7-b2ed-485c-8360-1658750d3ad5';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'fb6235ea-c95f-4995-b3e1-e51b144f7987';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '0c2e195b-1b62-4623-9c14-fa82eccf8dbf';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '43416a93-2167-4354-9cc4-bbf72f34ea28';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '75dfe181-65f9-4a1e-8bcc-ddfc8d0db817';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '97426829-0bdb-455c-a1af-435318d4f660';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '3179aad1-c782-4fd0-9cb4-f10fc79c5360';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '406c64f6-5439-407b-971a-c028897f2974';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '579147fc-2f60-46dd-802d-1bcc30c66324';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'a352502c-19d8-4b9e-8527-05828a70bb84';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'c1e54dc8-d803-4f56-b645-4e4c2a3a4eb1';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '0802724c-918b-44b0-a3b1-a37e40307d40';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'a759b72a-bb37-449c-869b-5629502b1726';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'ceea4503-d173-48aa-819a-19439e1a8cc6';
SELECT ROW_COUNT();


ALTER TABLE `Users` MODIFY COLUMN `IsLoggedIn` tinyint(1) NOT NULL DEFAULT FALSE;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('2fd30469-a260-408d-b12c-ad5b4dcc4c99', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('4416080f-b075-4b72-b7a0-9d00a30bf28b', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('4c24fbde-c8cf-46be-ae37-b8cef62181a3', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('73c2795b-5ff4-48c8-aeb6-0c7dfdc394a6', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('755c4c3a-d6b6-49e1-9a88-d41997e93dc4', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('7761667e-f5da-4d8a-922e-6edde8a57922', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('a0d0f4f1-00ff-4884-abb6-7f630373e99d', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('ad40d064-d94d-4181-8eb7-20a65ae7090f', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('cb561671-80b3-45af-b821-328524fca94e', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('f82be211-d963-4345-a6a9-41911764be6a', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('b92f1bd1-65b8-4ac2-96b0-4b203d9d05ba', 'GBP', TIMESTAMP '2025-03-05 13:48:57', 2, TRUE, 'British Pound', '£', NULL),
('c4603961-1c1d-4bb9-85e3-d270e7355fb7', 'USD', TIMESTAMP '2025-03-05 13:48:57', 2, TRUE, 'US Dollar', '$', NULL),
('c6cb1892-35fb-4b8a-b986-f84a628b073f', 'CHF', TIMESTAMP '2025-03-05 13:48:57', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('defb7812-ba6b-4422-8d49-35fb63ab1ed7', 'EUR', TIMESTAMP '2025-03-05 13:48:57', 2, TRUE, 'Euro', '€', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('2f289fab-746e-49ab-a656-88fba8eb74b7', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('6fb08530-f03b-4214-bacf-1784e9b95fbe', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('d7f1ba6a-1d47-49cf-9ed9-de0251f29a51', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('e699923b-a85c-4aa5-aed1-92b8f008a5f1', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1559f988-2183-4ad8-a3e0-bcedddb04bcc', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('26a6ef15-51ef-4ee5-95ea-5dd2d978ebe0', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('3e6f0285-f526-4c0d-a3f1-6471f0e185eb', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('8cb0063d-0f48-4d10-b6bc-89818edb7feb', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('ada9e2ec-87ff-4800-af43-d01d3910504b', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('f4e35ca4-930e-425a-a62b-b59300410ddd', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('7255e35e-ca20-44dd-ba22-36cb282cf850', TIMESTAMP '2025-03-05 13:48:57', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('01d51ca9-4ee1-49c8-bb50-5c8adac72c67', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('12e1f938-b239-4f1d-9573-710e0264a8fa', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('140838c8-5068-4ed4-92e8-99db5112a72a', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('28b57485-a1da-4c45-9f3d-174dd45c9e0a', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('b1a0db22-e7d2-4004-bcfa-35c73274f92f', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('b246cf74-a6ad-44f1-bc5f-98cf82530985', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('128118ce-cacd-49ac-9f55-caf2d42dadad', NULL, TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('abb7dadc-8390-485d-85f8-be01e90bd955', NULL, TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('f63a4e39-4a5c-45e5-95d5-dbf266adc41b', NULL, TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL),
('fc723927-5c70-4e97-a6d2-bbbe357515b1', NULL, TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('1e242dd0-2988-47ef-b06f-0201dfed3242', TIMESTAMP '2025-03-05 13:48:57', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('68eff3da-209b-4e43-8832-cae8b9e1c880', TIMESTAMP '2025-03-05 13:48:57', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('779c1164-4076-43e7-b1fc-e3980575b1cf', TIMESTAMP '2025-03-05 13:48:57', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('93cfbe30-3864-49ae-9d97-3c1342f5030e', TIMESTAMP '2025-03-05 13:48:57', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('f8a229ba-1382-47ab-b8ce-acbe70974fa2', TIMESTAMP '2025-03-05 13:48:57', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-05 13:48:57'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('52eb2e81-426b-4585-9344-d0fade047f45', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('8b0b01d4-3a12-498a-8dbb-ec59d86e2be4', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('8fe1281d-f4c9-45de-bd4a-0c20f4ce1543', TIMESTAMP '2025-03-05 13:48:57', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = '1WShZQnZ9stw/xJRITPECc8Sv64ZPv/QdBSemssp/afRd40LYg0Pnee2Ok38Mdxs'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'rIrP5mO9ND1bJUIzix7Otb4b/UtyaDFt3UmPIab/9DRM7EBnREI9ONfkIR7aGjHw'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_d3eb@example.com', `Email` = 'user_1_d3eb@example.com', `NormalizedEmail` = 'USER_1_D3EB@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_D3EB', `PasswordHash` = 'yLPmvjyv8YmZafNsfQKI2QYbb+ZmpmkptsXCC7KjuInjiyr4W87d/UPd+ItyPeEC', `SecurityStamp` = 'user_1_d3eb@example.com', `UserName` = 'user_1_d3eb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_026c@example.com', `Email` = 'user_2_026c@example.com', `NormalizedEmail` = 'USER_2_026C@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_026C', `PasswordHash` = 'MdaS7dMyZEKpTB8vath8o6OedK4LIMKH/gWWFu8jhOHj5R3c3qdnoPzsZUY2H3D+', `SecurityStamp` = 'user_2_026c@example.com', `UserName` = 'user_2_026c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_bb67@example.com', `Email` = 'user_3_bb67@example.com', `NormalizedEmail` = 'USER_3_BB67@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_BB67', `PasswordHash` = 'APv5uclXw3AiXNj4AjYbIJWKXrJK9AZSQNNR1ivOWgaXRQtZV2mBBjcWzc9VOE/L', `SecurityStamp` = 'user_3_bb67@example.com', `UserName` = 'user_3_bb67'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_1b90@example.com', `Email` = 'user_4_1b90@example.com', `NormalizedEmail` = 'USER_4_1B90@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_1B90', `PasswordHash` = 'ej/+Aj2amur1pTDD/Koiho1Klt7fyijX8zGygdPYBnq9LjLKwXFbKVsizpb/Yelh', `SecurityStamp` = 'user_4_1b90@example.com', `UserName` = 'user_4_1b90'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_718d@example.com', `Email` = 'user_5_718d@example.com', `NormalizedEmail` = 'USER_5_718D@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_718D', `PasswordHash` = 'BDCQHTOphaLNrxUiyNRw62khygCXysg7X1Ur/QOUAdiBoGMjDJxtwnHhLadMEJl9', `SecurityStamp` = 'user_5_718d@example.com', `UserName` = 'user_5_718d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_62f4@example.com', `Email` = 'user_6_62f4@example.com', `NormalizedEmail` = 'USER_6_62F4@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_62F4', `PasswordHash` = 'v5gjZHE6mCQn06sGrWKcWZLDRw/Aj1/YYDUB5od5qqVkGhNTVULDyvDPEoaR1ZkX', `SecurityStamp` = 'user_6_62f4@example.com', `UserName` = 'user_6_62f4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_9ba4@example.com', `Email` = 'user_7_9ba4@example.com', `NormalizedEmail` = 'USER_7_9BA4@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_9BA4', `PasswordHash` = 'cMEiPuOJ5Xhn0OHKKAy+v24xSgo295LMvy/Y1pOFOTJJZTi4jmT2rd26cSQLryji', `SecurityStamp` = 'user_7_9ba4@example.com', `UserName` = 'user_7_9ba4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_88f8@example.com', `Email` = 'user_8_88f8@example.com', `NormalizedEmail` = 'USER_8_88F8@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_88F8', `PasswordHash` = '0WinHzx1iIwU3orZqSTB19dH887QBowOn2ikOvQMXRR49nQUmqm4ak1DFEx3vHX1', `SecurityStamp` = 'user_8_88f8@example.com', `UserName` = 'user_8_88f8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_f52a@example.com', `Email` = 'user_9_f52a@example.com', `NormalizedEmail` = 'USER_9_F52A@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_F52A', `PasswordHash` = 'IV9qmS6Q8K+Jd/F3jNCVHy3fqVtjTraX/qzyPyq4DBm846jcPWPmv7kB+iFFPbMi', `SecurityStamp` = 'user_9_f52a@example.com', `UserName` = 'user_9_f52a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_7c80@example.com', `Email` = 'user_10_7c80@example.com', `NormalizedEmail` = 'USER_10_7C80@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_7C80', `PasswordHash` = '/XluS8nXkIzTvQzyC6JYqLuZpubs9YpGpqeSiizE6bVdnGhT+KggToH99+xJpMXP', `SecurityStamp` = 'user_10_7c80@example.com', `UserName` = 'user_10_7c80'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_a17e@example.com', `Email` = 'user_11_a17e@example.com', `NormalizedEmail` = 'USER_11_A17E@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_A17E', `PasswordHash` = 'hFKNAtwcqMUTpFn7DcbiiSHmQRUiHkHuAgEYk291EFnG61oUc+c4EhxRI9H5/c1+', `SecurityStamp` = 'user_11_a17e@example.com', `UserName` = 'user_11_a17e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_606b@example.com', `Email` = 'user_12_606b@example.com', `NormalizedEmail` = 'USER_12_606B@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_606B', `PasswordHash` = 'PMEVYXTyf+XJ55efK6eCq3zIyDz+lkh40PIARJUqxNAZJqzd3wDvkInI5iKrwevh', `SecurityStamp` = 'user_12_606b@example.com', `UserName` = 'user_12_606b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_2e6f@example.com', `Email` = 'user_13_2e6f@example.com', `NormalizedEmail` = 'USER_13_2E6F@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_2E6F', `PasswordHash` = 'Of+czZdxCwSHcjno0+gWex1EkxF+e/lHikHm4GaRfK6hUiNTPCrFkXvYdg8CxBPm', `SecurityStamp` = 'user_13_2e6f@example.com', `UserName` = 'user_13_2e6f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_9d45@example.com', `Email` = 'user_14_9d45@example.com', `NormalizedEmail` = 'USER_14_9D45@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_9D45', `PasswordHash` = 'kygnJTh3adic/4ja+ZpJGSWx/cpxDDtO5lqMmL+mo1Hoar4ZdjoVdEXylZelTu54', `SecurityStamp` = 'user_14_9d45@example.com', `UserName` = 'user_14_9d45'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_4b03@example.com', `Email` = 'user_15_4b03@example.com', `NormalizedEmail` = 'USER_15_4B03@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_4B03', `PasswordHash` = 'yqcLlRTQXn1cMA5yOxkf7zzY9hVWZ1ENgXOonTjzaeQS2+OZtVA+b0OppZeWEfMQ', `SecurityStamp` = 'user_15_4b03@example.com', `UserName` = 'user_15_4b03'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_40fc@example.com', `Email` = 'user_16_40fc@example.com', `NormalizedEmail` = 'USER_16_40FC@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_40FC', `PasswordHash` = 'bJdnELcUrr/TNGo5/xr9kHPyKdMTA2uRDTmJezXmyU1YN2EkvjOfnbHfv8obmHcl', `SecurityStamp` = 'user_16_40fc@example.com', `UserName` = 'user_16_40fc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_b13b@example.com', `Email` = 'user_17_b13b@example.com', `NormalizedEmail` = 'USER_17_B13B@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_B13B', `PasswordHash` = 'av/PBUEQ6SiwSZtB6zTJERtnHgq6AmlWNwnRpy0yEzE5bOrGeCD0XsB9jOWtrP9y', `SecurityStamp` = 'user_17_b13b@example.com', `UserName` = 'user_17_b13b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_2ef4@example.com', `Email` = 'user_18_2ef4@example.com', `NormalizedEmail` = 'USER_18_2EF4@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_2EF4', `PasswordHash` = '/XBuwTSkuaPxRWr8JWpaLTfRXtagMadD4JpKOX4Ro1s1RKwElo116CW27nQowGDD', `SecurityStamp` = 'user_18_2ef4@example.com', `UserName` = 'user_18_2ef4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_5e25@example.com', `Email` = 'user_19_5e25@example.com', `NormalizedEmail` = 'USER_19_5E25@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_5E25', `PasswordHash` = 'TziUxf8d3tP6+UacldQvlLd38AogQn/pGroMocFPh+slkJBO8QFZTq1BXGZzV6pn', `SecurityStamp` = 'user_19_5e25@example.com', `UserName` = 'user_19_5e25'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_62f7@example.com', `Email` = 'user_20_62f7@example.com', `NormalizedEmail` = 'USER_20_62F7@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_62F7', `PasswordHash` = 'Je9RizBB8DoGTyKitFmwG6N2QAByH7bA1Nd7w+43uc1tTagEVhlwY6Rjj7vRrvyb', `SecurityStamp` = 'user_20_62f7@example.com', `UserName` = 'user_20_62f7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_d326@example.com', `Email` = 'user_21_d326@example.com', `NormalizedEmail` = 'USER_21_D326@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_D326', `PasswordHash` = 'DBS/+OLVQSy2T2u8Ep+wkfdCGYM30gLMojMTZ8mJoQ9WghSjkoLOrUy4HXiMLPDA', `SecurityStamp` = 'user_21_d326@example.com', `UserName` = 'user_21_d326'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_864e@example.com', `Email` = 'user_22_864e@example.com', `NormalizedEmail` = 'USER_22_864E@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_864E', `PasswordHash` = 'NsjjnWfAGKY0UemAteqG8jPrTF0KkhqyJiITpKBk9Ar0aBKfouJdae+WreEkC/o5', `SecurityStamp` = 'user_22_864e@example.com', `UserName` = 'user_22_864e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_e74d@example.com', `Email` = 'user_23_e74d@example.com', `NormalizedEmail` = 'USER_23_E74D@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_E74D', `PasswordHash` = 'kqyjjESKBgux8j3fz5ulw/oeheDKasCCp7GvwTnRvD6QrBpEBn3uYDyjd/q01BI+', `SecurityStamp` = 'user_23_e74d@example.com', `UserName` = 'user_23_e74d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_6216@example.com', `Email` = 'user_24_6216@example.com', `NormalizedEmail` = 'USER_24_6216@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_6216', `PasswordHash` = 'rIWl38bCZVWTBhpCHuO7O+tmwWyiqJy3UXvPqagl57N67j+l7ej0xsflqw8cumEU', `SecurityStamp` = 'user_24_6216@example.com', `UserName` = 'user_24_6216'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_b8cc@example.com', `Email` = 'user_25_b8cc@example.com', `NormalizedEmail` = 'USER_25_B8CC@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_B8CC', `PasswordHash` = 'l18CuqY/S1DZB6rZ2zAgYqPEN7HeyXHf2+8JqmP+qOHO4oKen3JU5/rWflwy/qti', `SecurityStamp` = 'user_25_b8cc@example.com', `UserName` = 'user_25_b8cc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_ed79@example.com', `Email` = 'user_26_ed79@example.com', `NormalizedEmail` = 'USER_26_ED79@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_ED79', `PasswordHash` = 'uilSsvyAi+RlTk8jOYXbxlH3y1016scaWadmD9tEXkSpP8iKj5ncYi+pn/GzMk6A', `SecurityStamp` = 'user_26_ed79@example.com', `UserName` = 'user_26_ed79'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_6448@example.com', `Email` = 'user_27_6448@example.com', `NormalizedEmail` = 'USER_27_6448@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_6448', `PasswordHash` = 'sjezEUyiC+98sNX4sfb8ZrZ4CKtN8WPG/4QnaFQtbvza7yfkfkKgNF0yWF4crBG1', `SecurityStamp` = 'user_27_6448@example.com', `UserName` = 'user_27_6448'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_b8b4@example.com', `Email` = 'user_28_b8b4@example.com', `NormalizedEmail` = 'USER_28_B8B4@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_B8B4', `PasswordHash` = 'KPMSx7acjQZVMBGl23gd+VnMzFXBZuGilN1qP4RYmLhQQrJzR8IbR0UKCTFbDMtB', `SecurityStamp` = 'user_28_b8b4@example.com', `UserName` = 'user_28_b8b4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_92eb@example.com', `Email` = 'user_29_92eb@example.com', `NormalizedEmail` = 'USER_29_92EB@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_92EB', `PasswordHash` = 'V/z3ETjAmrsba++JorzvlUePI5Zc33wdRlfmKqta0hNZaXD1nttxx4KmZP0D8dvT', `SecurityStamp` = 'user_29_92eb@example.com', `UserName` = 'user_29_92eb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_8391@example.com', `Email` = 'user_30_8391@example.com', `NormalizedEmail` = 'USER_30_8391@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_8391', `PasswordHash` = 'YnL418eGNWy1pFnZ2HTb0QnYpfImqfUCXjKw8Cr8x70USqdjWgXJWPLfXzG5HWc9', `SecurityStamp` = 'user_30_8391@example.com', `UserName` = 'user_30_8391'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_754f@example.com', `Email` = 'user_31_754f@example.com', `NormalizedEmail` = 'USER_31_754F@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_754F', `PasswordHash` = 'A1/P4zgtmN5pNzOGj7Jkq4YN4eEAqYV2oDMJzwoteKF1Dj7iBfmOs0DL6sLNyqu0', `SecurityStamp` = 'user_31_754f@example.com', `UserName` = 'user_31_754f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_6899@example.com', `Email` = 'user_32_6899@example.com', `NormalizedEmail` = 'USER_32_6899@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_6899', `PasswordHash` = 'yVYJXmVMvvWXA+zN+sJDEVRBnKaP1Q9Hvfsaby+GpJZkcEz7M+kpxjdQEoh752Ce', `SecurityStamp` = 'user_32_6899@example.com', `UserName` = 'user_32_6899'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_612e@example.com', `Email` = 'user_33_612e@example.com', `NormalizedEmail` = 'USER_33_612E@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_612E', `PasswordHash` = 'OM+2n+IwoQb8mfmwW/uFrA2+H2MA4znWnpdkUPXsKqDWDkZ7HJE9YjCXuTp+TcWm', `SecurityStamp` = 'user_33_612e@example.com', `UserName` = 'user_33_612e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_b6ce@example.com', `Email` = 'user_34_b6ce@example.com', `NormalizedEmail` = 'USER_34_B6CE@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_B6CE', `PasswordHash` = 'kDwbk6Ll1NBdAo7zWidOOnIDoT1zn2eibJo0YuruC3HrpuyVrkwr87y2hiyI37HE', `SecurityStamp` = 'user_34_b6ce@example.com', `UserName` = 'user_34_b6ce'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_2e33@example.com', `Email` = 'user_35_2e33@example.com', `NormalizedEmail` = 'USER_35_2E33@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_2E33', `PasswordHash` = 'XT1BlmsbRiCz86zzqVuZVrl67JwsGTEdmHqUYkv9K9+aKohRlq2+Q+OzwxqZSMb9', `SecurityStamp` = 'user_35_2e33@example.com', `UserName` = 'user_35_2e33'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_0ee7@example.com', `Email` = 'user_36_0ee7@example.com', `NormalizedEmail` = 'USER_36_0EE7@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_0EE7', `PasswordHash` = 'jEzWRqyFbl3a46VaeBuO9Zzv5ipijNCuZZyukOqXfl2Myl5AZ5Vn1PnLIITEPPNY', `SecurityStamp` = 'user_36_0ee7@example.com', `UserName` = 'user_36_0ee7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_39d3@example.com', `Email` = 'user_37_39d3@example.com', `NormalizedEmail` = 'USER_37_39D3@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_39D3', `PasswordHash` = 'AdRbVXW7fbn+o+1RCR5c57/4QFZ9oXA2DV/7AhgO5+5JdYxavlNZ33Y2An8g9F9q', `SecurityStamp` = 'user_37_39d3@example.com', `UserName` = 'user_37_39d3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_8247@example.com', `Email` = 'user_38_8247@example.com', `NormalizedEmail` = 'USER_38_8247@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_8247', `PasswordHash` = 'hF2Q+BqHqz6ReRGfMfIiPxfHL6V9uqh7aIZWExwkqZfzV82z+iLMJABxpK28A5wR', `SecurityStamp` = 'user_38_8247@example.com', `UserName` = 'user_38_8247'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_7fc9@example.com', `Email` = 'user_39_7fc9@example.com', `NormalizedEmail` = 'USER_39_7FC9@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_7FC9', `PasswordHash` = 'C1lX5SGNExtY5B8U0Mxc7KfGlQBkaSNqLidY58zMya6qiCFQkUc08JWIYIDwRH9B', `SecurityStamp` = 'user_39_7fc9@example.com', `UserName` = 'user_39_7fc9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_32c0@example.com', `Email` = 'user_40_32c0@example.com', `NormalizedEmail` = 'USER_40_32C0@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_32C0', `PasswordHash` = 'Qj1EVC41AeS2hWMc+4ydBD8vcuW9kHQJCf2D4QaIAq6eX8Yu+uCdHUT4m72QSrXa', `SecurityStamp` = 'user_40_32c0@example.com', `UserName` = 'user_40_32c0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_0924@example.com', `Email` = 'user_41_0924@example.com', `NormalizedEmail` = 'USER_41_0924@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_0924', `PasswordHash` = 'ebwD2N4rOzegLfz/E9f2m0OIvkS9VRQ2GHdvxJksjxMpvjD5w/3/0z5LGjJTxj2K', `SecurityStamp` = 'user_41_0924@example.com', `UserName` = 'user_41_0924'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_f128@example.com', `Email` = 'user_42_f128@example.com', `NormalizedEmail` = 'USER_42_F128@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_F128', `PasswordHash` = 'XmAqDZxMXw7mqxbnTSSgdVwB94sPkzSmuB4jhqnW5eDdAaEwLVL9Ex39TIDtvBvT', `SecurityStamp` = 'user_42_f128@example.com', `UserName` = 'user_42_f128'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_10e2@example.com', `Email` = 'user_43_10e2@example.com', `NormalizedEmail` = 'USER_43_10E2@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_10E2', `PasswordHash` = 'nhOmgeU3BIe2iqxOQPeT5m74sAbpU0uei8fXdC8IozAuavUKSPk2UIsU9qfs/SAI', `SecurityStamp` = 'user_43_10e2@example.com', `UserName` = 'user_43_10e2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_9321@example.com', `Email` = 'user_44_9321@example.com', `NormalizedEmail` = 'USER_44_9321@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_9321', `PasswordHash` = 'BRHG6dcdxLIANIQkROgnLkripOqHGTCbW64iPP3JkIhZSfs3i+SwcrhBX+WSCPqW', `SecurityStamp` = 'user_44_9321@example.com', `UserName` = 'user_44_9321'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_ceed@example.com', `Email` = 'user_45_ceed@example.com', `NormalizedEmail` = 'USER_45_CEED@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_CEED', `PasswordHash` = 'wEdS964UYmBfVGCXi8wXh9K8dSBed5WMyLdqLctZTrgtxQQFqC3okaAptIA4U7V7', `SecurityStamp` = 'user_45_ceed@example.com', `UserName` = 'user_45_ceed'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_84b2@example.com', `Email` = 'user_46_84b2@example.com', `NormalizedEmail` = 'USER_46_84B2@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_84B2', `PasswordHash` = '/M3emPcbrblx9Z/t37WxwJ/3AW1uscKchTawmz0SFwOz4GHdnZduV2LtwGibFas7', `SecurityStamp` = 'user_46_84b2@example.com', `UserName` = 'user_46_84b2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_7ffb@example.com', `Email` = 'user_47_7ffb@example.com', `NormalizedEmail` = 'USER_47_7FFB@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_7FFB', `PasswordHash` = 'H9SJjeNkLvCmcjp6crgtLlQTTZJA8+xzzcSLlKtl7o5YidVSAJItHNOrf8Ji8Jo4', `SecurityStamp` = 'user_47_7ffb@example.com', `UserName` = 'user_47_7ffb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_7e72@example.com', `Email` = 'user_48_7e72@example.com', `NormalizedEmail` = 'USER_48_7E72@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_7E72', `PasswordHash` = 'h4xUBohJ21Gg5filSGwP5YmUf9FVYOBzwGXdLleimdFhhAKBuKv0PmxlTNTHL1kw', `SecurityStamp` = 'user_48_7e72@example.com', `UserName` = 'user_48_7e72'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_3c8e@example.com', `Email` = 'user_49_3c8e@example.com', `NormalizedEmail` = 'USER_49_3C8E@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_3C8E', `PasswordHash` = 'cuyoZ3Yh8Mtn/SXKxDsL4h/9/eVgFTLkORtcrld39aoDm4HLEUf029eb7JT7sAGM', `SecurityStamp` = 'user_49_3c8e@example.com', `UserName` = 'user_49_3c8e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_ce00@example.com', `Email` = 'user_50_ce00@example.com', `NormalizedEmail` = 'USER_50_CE00@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_CE00', `PasswordHash` = '/4AlCzi1C+ZOToqbeNNotqrAsr0D2mHJn9Kf8sLnBYwvTiHO7uaUvRSgD4SVMsD9', `SecurityStamp` = 'user_50_ce00@example.com', `UserName` = 'user_50_ce00'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'dgk64OinRYFYWE7J8BO9r9X7Ztoet36AAVKumisFmnVGbzQyeICAq3hbykvgv01p'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250305134903_AddIsLoggedInField', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '2fd30469-a260-408d-b12c-ad5b4dcc4c99';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '4416080f-b075-4b72-b7a0-9d00a30bf28b';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '4c24fbde-c8cf-46be-ae37-b8cef62181a3';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '73c2795b-5ff4-48c8-aeb6-0c7dfdc394a6';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '755c4c3a-d6b6-49e1-9a88-d41997e93dc4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7761667e-f5da-4d8a-922e-6edde8a57922';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a0d0f4f1-00ff-4884-abb6-7f630373e99d';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'ad40d064-d94d-4181-8eb7-20a65ae7090f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'cb561671-80b3-45af-b821-328524fca94e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f82be211-d963-4345-a6a9-41911764be6a';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'b92f1bd1-65b8-4ac2-96b0-4b203d9d05ba';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'c4603961-1c1d-4bb9-85e3-d270e7355fb7';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'c6cb1892-35fb-4b8a-b986-f84a628b073f';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'defb7812-ba6b-4422-8d49-35fb63ab1ed7';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '2f289fab-746e-49ab-a656-88fba8eb74b7';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '6fb08530-f03b-4214-bacf-1784e9b95fbe';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'd7f1ba6a-1d47-49cf-9ed9-de0251f29a51';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'e699923b-a85c-4aa5-aed1-92b8f008a5f1';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '1559f988-2183-4ad8-a3e0-bcedddb04bcc';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '26a6ef15-51ef-4ee5-95ea-5dd2d978ebe0';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '3e6f0285-f526-4c0d-a3f1-6471f0e185eb';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '8cb0063d-0f48-4d10-b6bc-89818edb7feb';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'ada9e2ec-87ff-4800-af43-d01d3910504b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f4e35ca4-930e-425a-a62b-b59300410ddd';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '7255e35e-ca20-44dd-ba22-36cb282cf850';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '01d51ca9-4ee1-49c8-bb50-5c8adac72c67';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '12e1f938-b239-4f1d-9573-710e0264a8fa';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '140838c8-5068-4ed4-92e8-99db5112a72a';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '28b57485-a1da-4c45-9f3d-174dd45c9e0a';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b1a0db22-e7d2-4004-bcfa-35c73274f92f';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b246cf74-a6ad-44f1-bc5f-98cf82530985';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '128118ce-cacd-49ac-9f55-caf2d42dadad';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'abb7dadc-8390-485d-85f8-be01e90bd955';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'f63a4e39-4a5c-45e5-95d5-dbf266adc41b';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'fc723927-5c70-4e97-a6d2-bbbe357515b1';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '1e242dd0-2988-47ef-b06f-0201dfed3242';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '68eff3da-209b-4e43-8832-cae8b9e1c880';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '779c1164-4076-43e7-b1fc-e3980575b1cf';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '93cfbe30-3864-49ae-9d97-3c1342f5030e';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'f8a229ba-1382-47ab-b8ce-acbe70974fa2';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '52eb2e81-426b-4585-9344-d0fade047f45';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '8b0b01d4-3a12-498a-8dbb-ec59d86e2be4';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '8fe1281d-f4c9-45de-bd4a-0c20f4ce1543';
SELECT ROW_COUNT();


ALTER TABLE `Link` ADD `ProjectId` char(36) COLLATE ascii_general_ci NULL;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('20a5541a-42ce-4d2b-a176-f2fa9c15a3b4', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('3bb35296-398c-4c58-a06f-4d9cf19585ab', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('42c4fe8d-b538-4a16-ada3-7baf0378ea5a', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('7cd4c509-4a5c-4323-a6f6-7dc4422dd3dd', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('9b88a31b-ec13-4ed3-9ea0-528f92bde9d5', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('9c1425a6-613b-4852-97d6-78e565eaf0a1', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('da1aeb3a-db45-4167-b911-77d4577e2cf0', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('e6340207-ee6f-4c63-b32b-ca3f2988b75a', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('f1620483-7434-493a-971a-38792318494e', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('f4d8f64a-d07d-4322-8496-2598ab7a0178', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('255cb300-3095-4753-89ae-b633dcb1aba8', 'USD', TIMESTAMP '2025-03-12 15:46:45', 2, TRUE, 'US Dollar', '$', NULL),
('a2bd7e0f-f0b8-4ac8-b1e0-2c02159f6c23', 'CHF', TIMESTAMP '2025-03-12 15:46:45', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('d0eef624-5bac-4c55-9d79-10a6dbb5be05', 'EUR', TIMESTAMP '2025-03-12 15:46:45', 2, TRUE, 'Euro', '€', NULL),
('fb9940c6-634c-4ad2-8f40-34e707418447', 'GBP', TIMESTAMP '2025-03-12 15:46:45', 2, TRUE, 'British Pound', '£', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('6d0e0689-22fd-4bb4-a45b-11f29201cec9', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('b93e2793-b767-4259-8df9-2d6e2f0a7f1b', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('c050479c-5497-4011-a423-105241723488', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL),
('ffde1662-3e80-44a1-aec4-ba05be9b483b', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1762b40e-5aae-4fab-b1f0-a6b891f7c217', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('25f9006f-b20c-4239-b3d7-ae1ceeaf903a', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('3886d9ca-0599-417a-ab93-cb4e5aacc5e2', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('6c208b50-3ab1-48f6-bd28-5852dee53592', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('9abfc01b-d85d-421d-b54b-6baa3b16f4e4', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('b52c12af-f127-4e6b-bda1-7cc68bc236d1', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('f1ba79f8-0bdd-4c2c-a7d3-dab0056d1599', TIMESTAMP '2025-03-12 15:46:45', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('251b4f47-9641-4dfe-b8d8-257e6a9792c1', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('36611b4c-caab-404a-bc97-1d6f43d945af', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('48a0c44e-985d-47a9-bee7-341243055ca7', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('798e48f9-e5f8-4b36-a8ee-679f5d512033', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('91b142c8-88a8-4160-9e21-fd9e84f894f9', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('cfe0e731-3b74-4d48-9b8e-1e8c31926a78', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('3f5d6005-de7e-4ffd-b155-9073cd626e54', NULL, TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL),
('5996c08e-9258-4f88-a760-0624b00f83ad', NULL, TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('bf9a0a7b-02b1-442a-9715-9c8ba514f84f', NULL, TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('e86241a8-6932-417f-b6a0-53680e0415b3', NULL, TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('3d7f2a89-20f3-4c13-8160-87e5974279b1', TIMESTAMP '2025-03-12 15:46:45', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('869c53cd-9d21-4c08-8e89-739255e29421', TIMESTAMP '2025-03-12 15:46:45', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('9ee65c27-62ee-4ef9-a289-0c9e2252f4db', TIMESTAMP '2025-03-12 15:46:45', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('a4c6d063-4f3c-4738-a123-32a0b6040c9f', TIMESTAMP '2025-03-12 15:46:45', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('c4549858-3392-4209-8a06-59cf1e2b54f1', TIMESTAMP '2025-03-12 15:46:45', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-12 15:46:45'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('6b80f51f-9729-4ef6-9ebc-c102c9bc47b0', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('abeddc32-5c14-4d63-a91b-66fa6301ac63', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('aee6ccf1-7d98-4119-a8fb-085bfaf0e77a', TIMESTAMP '2025-03-12 15:46:45', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'DUxdAzLnjT9LZmW8kS8jiMYir7ImlGCPJQREVGXEJy89otcvat301L1giXhJtm6+'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'MvvgqrYES0md/uEYG1KYA93rx9ZiP5iXTjMnTJEfvIxq4cjnXeBjj3PmWQepkFSQ'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_1440@example.com', `Email` = 'user_1_1440@example.com', `NormalizedEmail` = 'USER_1_1440@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_1440', `PasswordHash` = 'R1Enq5C8NYkxK0m+KcWQlvo91gnFbTUNOavMme9UDoR9SBcUa3DVGSZ/Rj5Gghi/', `SecurityStamp` = 'user_1_1440@example.com', `UserName` = 'user_1_1440'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_6527@example.com', `Email` = 'user_2_6527@example.com', `NormalizedEmail` = 'USER_2_6527@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_6527', `PasswordHash` = 'tifmQ2bcZb7I7zw2dasUInGlfnyPgL69v3vvfmaIkt9QpOvQu1thwG8HQrZfdkzE', `SecurityStamp` = 'user_2_6527@example.com', `UserName` = 'user_2_6527'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_0346@example.com', `Email` = 'user_3_0346@example.com', `NormalizedEmail` = 'USER_3_0346@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_0346', `PasswordHash` = 'GNCZkTXIVYBwRFa3RCHy2bC154ANBtyGFQ+Efif+FInruRnNfnZZlZOTojslcHxe', `SecurityStamp` = 'user_3_0346@example.com', `UserName` = 'user_3_0346'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_a07f@example.com', `Email` = 'user_4_a07f@example.com', `NormalizedEmail` = 'USER_4_A07F@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_A07F', `PasswordHash` = 'UJTMJsyHA+RrTxEEufiKQZ2P4xAGLcsyKffNIxtaf2EmEtBKtZizcFQeo2q04VrX', `SecurityStamp` = 'user_4_a07f@example.com', `UserName` = 'user_4_a07f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_3b75@example.com', `Email` = 'user_5_3b75@example.com', `NormalizedEmail` = 'USER_5_3B75@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_3B75', `PasswordHash` = 'Oj1elzxkfRodv1Hxf9dX5Xu7heMaA1F0qYjTk3qqqO2qqS0tHIiLhg4RFVSEAccQ', `SecurityStamp` = 'user_5_3b75@example.com', `UserName` = 'user_5_3b75'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_4532@example.com', `Email` = 'user_6_4532@example.com', `NormalizedEmail` = 'USER_6_4532@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_4532', `PasswordHash` = '8OQv10UxHbIeSykcoL3DbLgujYGgjwrIsxL3PmUfftY7TUwqIb56jnF796lNVr4E', `SecurityStamp` = 'user_6_4532@example.com', `UserName` = 'user_6_4532'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_ce26@example.com', `Email` = 'user_7_ce26@example.com', `NormalizedEmail` = 'USER_7_CE26@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_CE26', `PasswordHash` = 'X22dZ7pGYH4qfUlOUKSmGSnseF2KkaQONwJw/Z4eW8ztKzuZZj28ThEvVU4s4IBM', `SecurityStamp` = 'user_7_ce26@example.com', `UserName` = 'user_7_ce26'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_cf8d@example.com', `Email` = 'user_8_cf8d@example.com', `NormalizedEmail` = 'USER_8_CF8D@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_CF8D', `PasswordHash` = 'XzZicNgRg/drx4pgANKjpGKzYgMegRnXrqpHrcCee185Z8CVy1N4vxPfDMYq8ObY', `SecurityStamp` = 'user_8_cf8d@example.com', `UserName` = 'user_8_cf8d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_4299@example.com', `Email` = 'user_9_4299@example.com', `NormalizedEmail` = 'USER_9_4299@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_4299', `PasswordHash` = 'MgkGKLPEUQVJo1vKrXKyyZhZToevNrrKR8ccsOn+6VTDnOnkl9r8/I3k8F7nSSew', `SecurityStamp` = 'user_9_4299@example.com', `UserName` = 'user_9_4299'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_4277@example.com', `Email` = 'user_10_4277@example.com', `NormalizedEmail` = 'USER_10_4277@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_4277', `PasswordHash` = 'FhfhceV+97itKgyMawsO4SW8eJaT9FFxgrjKTw5OMhwPLSzivopVjjZdj2BSEaw1', `SecurityStamp` = 'user_10_4277@example.com', `UserName` = 'user_10_4277'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_fd98@example.com', `Email` = 'user_11_fd98@example.com', `NormalizedEmail` = 'USER_11_FD98@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_FD98', `PasswordHash` = 'xIQFsJOhpXxuPr3J/aJ6CPsjg6y6xd1uR+r7SY8D8ZiQ0aXwNfswW+qZm6ameghI', `SecurityStamp` = 'user_11_fd98@example.com', `UserName` = 'user_11_fd98'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_b3c9@example.com', `Email` = 'user_12_b3c9@example.com', `NormalizedEmail` = 'USER_12_B3C9@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_B3C9', `PasswordHash` = 'KNRm/I3arTbUCyminuVeZdvxR+oehecVegcRKy8kcWmRVg2sfSeZ2QseF/q1IK7a', `SecurityStamp` = 'user_12_b3c9@example.com', `UserName` = 'user_12_b3c9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_5955@example.com', `Email` = 'user_13_5955@example.com', `NormalizedEmail` = 'USER_13_5955@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_5955', `PasswordHash` = 'Y2m2+lrRzAT/fA2IRbqzTyJD37ZTvY4BGALr0HKkYe6f25FIlKPfzPT48v04jz5m', `SecurityStamp` = 'user_13_5955@example.com', `UserName` = 'user_13_5955'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_3de7@example.com', `Email` = 'user_14_3de7@example.com', `NormalizedEmail` = 'USER_14_3DE7@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_3DE7', `PasswordHash` = 'TOekNhJdtsyM/1ENYZwCEGrL118jinvHMX9e/DN2fOeJXM2HArxfcH9Zpl2OFu1U', `SecurityStamp` = 'user_14_3de7@example.com', `UserName` = 'user_14_3de7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_0ce0@example.com', `Email` = 'user_15_0ce0@example.com', `NormalizedEmail` = 'USER_15_0CE0@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_0CE0', `PasswordHash` = 'nYnGefVz6uBons+XR/qXvPz277YDidF8d5W5cCZBYU8zUJIvnLIVbiSxUn6Cec4F', `SecurityStamp` = 'user_15_0ce0@example.com', `UserName` = 'user_15_0ce0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_54a0@example.com', `Email` = 'user_16_54a0@example.com', `NormalizedEmail` = 'USER_16_54A0@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_54A0', `PasswordHash` = 'DU95BsyYTqtB2PLw5/sT25AZ1L69oa1Ijs0CZYs4J1WO+V3cMY4jvpDufr+t5C0A', `SecurityStamp` = 'user_16_54a0@example.com', `UserName` = 'user_16_54a0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_a54c@example.com', `Email` = 'user_17_a54c@example.com', `NormalizedEmail` = 'USER_17_A54C@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_A54C', `PasswordHash` = 'lg0HRdzJJZDddbWWHTvPogms5ef4NXBxAtlhtTebmXO5lP+zmtulBVb8B+SzqlU5', `SecurityStamp` = 'user_17_a54c@example.com', `UserName` = 'user_17_a54c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_4939@example.com', `Email` = 'user_18_4939@example.com', `NormalizedEmail` = 'USER_18_4939@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_4939', `PasswordHash` = 'PRdvdi7cvjzeJUsoEYm6O3dSD8SSsPdYrx3NJFbJVAJuJMgwl22bfi/W5+QcclhG', `SecurityStamp` = 'user_18_4939@example.com', `UserName` = 'user_18_4939'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_cd83@example.com', `Email` = 'user_19_cd83@example.com', `NormalizedEmail` = 'USER_19_CD83@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_CD83', `PasswordHash` = 'zCbhmWoy/gAH9Cq22oCIqTi/xJnGv+XdGeO802s68bdGmFOvw+cz+2BECsjQEt8j', `SecurityStamp` = 'user_19_cd83@example.com', `UserName` = 'user_19_cd83'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_f200@example.com', `Email` = 'user_20_f200@example.com', `NormalizedEmail` = 'USER_20_F200@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_F200', `PasswordHash` = 'XGRBvuVBEUbl6LIBlmMCdIUAt5O5WvDyQv2SPK173k+HfjcstC58pe6EWHoeuiNG', `SecurityStamp` = 'user_20_f200@example.com', `UserName` = 'user_20_f200'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_46f2@example.com', `Email` = 'user_21_46f2@example.com', `NormalizedEmail` = 'USER_21_46F2@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_46F2', `PasswordHash` = 'i/lhZp0i1upfgzBgGad1g8KBye32mvYbn3hCwlMvQpgaiH4ENNUrj+lURvl0hfZS', `SecurityStamp` = 'user_21_46f2@example.com', `UserName` = 'user_21_46f2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_efa6@example.com', `Email` = 'user_22_efa6@example.com', `NormalizedEmail` = 'USER_22_EFA6@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_EFA6', `PasswordHash` = 'hoZq33Bu5kjuvpdKy4uIqtt3eTlRg4nmwOfRXnBJjQ0PNODCubgBKQRURcuo5ofi', `SecurityStamp` = 'user_22_efa6@example.com', `UserName` = 'user_22_efa6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_7012@example.com', `Email` = 'user_23_7012@example.com', `NormalizedEmail` = 'USER_23_7012@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_7012', `PasswordHash` = '6E2s47BECCVttUcoGOu+ySi0205lW2fJ47ntspgx7LQI7r6jht8sLd0IH5yY1lf1', `SecurityStamp` = 'user_23_7012@example.com', `UserName` = 'user_23_7012'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_f2a1@example.com', `Email` = 'user_24_f2a1@example.com', `NormalizedEmail` = 'USER_24_F2A1@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_F2A1', `PasswordHash` = 'OomzGOw7SZ/WevXNxB4DQlmmXvpWc+XrvLHNxrihGVcgiH2rvKfVbbL4i6G+uk6J', `SecurityStamp` = 'user_24_f2a1@example.com', `UserName` = 'user_24_f2a1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_dbbb@example.com', `Email` = 'user_25_dbbb@example.com', `NormalizedEmail` = 'USER_25_DBBB@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_DBBB', `PasswordHash` = 'c0TOLLQEgNUDSatkTt5CcAKD3Fx73dnGD4FszWzOwlAa9uq6qFM2lP7QuzgX1UFp', `SecurityStamp` = 'user_25_dbbb@example.com', `UserName` = 'user_25_dbbb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_c765@example.com', `Email` = 'user_26_c765@example.com', `NormalizedEmail` = 'USER_26_C765@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_C765', `PasswordHash` = 'PTTxLWY5JTtd/myJb6v7iOqvCpm0YyUnMEqxIYDHEcdSGDnUwGLw/5Pz4AgvSRnb', `SecurityStamp` = 'user_26_c765@example.com', `UserName` = 'user_26_c765'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_b627@example.com', `Email` = 'user_27_b627@example.com', `NormalizedEmail` = 'USER_27_B627@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_B627', `PasswordHash` = 'dOzwBOM9HCuuRwZCahCNztMCbEuYKCTe/k83NV5zbFYhPLHleJ4981OF3wKharUn', `SecurityStamp` = 'user_27_b627@example.com', `UserName` = 'user_27_b627'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_742e@example.com', `Email` = 'user_28_742e@example.com', `NormalizedEmail` = 'USER_28_742E@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_742E', `PasswordHash` = 'KOyJ0t87PbrthxlAoTSRuPIrDjGfhbzY7PXFHimKsLdDZZ4BaB97AukiR6+MAh8s', `SecurityStamp` = 'user_28_742e@example.com', `UserName` = 'user_28_742e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_e97d@example.com', `Email` = 'user_29_e97d@example.com', `NormalizedEmail` = 'USER_29_E97D@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_E97D', `PasswordHash` = 'J+C/RLtlgvqEwEJRaFg8R3rxGGlEI7HTuuvmVrHJmfBi9g35xEgnIFU3QREanDMV', `SecurityStamp` = 'user_29_e97d@example.com', `UserName` = 'user_29_e97d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_137f@example.com', `Email` = 'user_30_137f@example.com', `NormalizedEmail` = 'USER_30_137F@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_137F', `PasswordHash` = 'VfN/OOUF7PW3sff9HEq+FIIxi0WHBlOTWf6fFXIX89wAQxr3LkvJbBWVoOL3z7Ox', `SecurityStamp` = 'user_30_137f@example.com', `UserName` = 'user_30_137f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_1351@example.com', `Email` = 'user_31_1351@example.com', `NormalizedEmail` = 'USER_31_1351@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_1351', `PasswordHash` = 'ck8YL8TTuLscGjxuX/lCBaPYOer7SRqifAPFLrr3FK1ySJsLas3EPOpe2Osy7DSA', `SecurityStamp` = 'user_31_1351@example.com', `UserName` = 'user_31_1351'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_e524@example.com', `Email` = 'user_32_e524@example.com', `NormalizedEmail` = 'USER_32_E524@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_E524', `PasswordHash` = '/EIxIsB0oMrPPWNLmWT7nGxeQ57C3A0OFoyST/Y9kYAugE8h3aXbYpt6Vf5qERZo', `SecurityStamp` = 'user_32_e524@example.com', `UserName` = 'user_32_e524'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_5a08@example.com', `Email` = 'user_33_5a08@example.com', `NormalizedEmail` = 'USER_33_5A08@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_5A08', `PasswordHash` = 's2Vo8lhRoObNl8GD0pRlNNambYcuZdvrxkmN1OBdG1dL2rK9cYcgDUtcpwZVt3/v', `SecurityStamp` = 'user_33_5a08@example.com', `UserName` = 'user_33_5a08'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_c96e@example.com', `Email` = 'user_34_c96e@example.com', `NormalizedEmail` = 'USER_34_C96E@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_C96E', `PasswordHash` = 'rGhGX+hucngZRaK0flDukTa9RkOuplFIpXRNhzpfBm+ZfISbBP3CX91UrYVPrB76', `SecurityStamp` = 'user_34_c96e@example.com', `UserName` = 'user_34_c96e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_4ca4@example.com', `Email` = 'user_35_4ca4@example.com', `NormalizedEmail` = 'USER_35_4CA4@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_4CA4', `PasswordHash` = 'yq7lWiOQmP8CzOweuUJvtOAsEZLY4LOiYvq1iB+DOPDP3q8RPAC4MabQn71ibZA5', `SecurityStamp` = 'user_35_4ca4@example.com', `UserName` = 'user_35_4ca4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_42ba@example.com', `Email` = 'user_36_42ba@example.com', `NormalizedEmail` = 'USER_36_42BA@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_42BA', `PasswordHash` = 'siwmTG5QXqSOhlKvwsYX+cr+y8t45KrTzlbYZLeWJb+rWKzUmcComYcjLdE9npFV', `SecurityStamp` = 'user_36_42ba@example.com', `UserName` = 'user_36_42ba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_7347@example.com', `Email` = 'user_37_7347@example.com', `NormalizedEmail` = 'USER_37_7347@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_7347', `PasswordHash` = '7Avpz4iEnnz4+SlxRHwKkguMj6jk+kf/yOQ34PfWKJuCo6+0t//8UCJD+H1AqK5p', `SecurityStamp` = 'user_37_7347@example.com', `UserName` = 'user_37_7347'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_7faf@example.com', `Email` = 'user_38_7faf@example.com', `NormalizedEmail` = 'USER_38_7FAF@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_7FAF', `PasswordHash` = 'USyKY3hMAlMZmZ1QnxcNEbjRl5SnGiffZK9ATNCTIy6pRVhwZkqywbAk0F+B2DCg', `SecurityStamp` = 'user_38_7faf@example.com', `UserName` = 'user_38_7faf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_d777@example.com', `Email` = 'user_39_d777@example.com', `NormalizedEmail` = 'USER_39_D777@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_D777', `PasswordHash` = '47csR9aJL3eF8WwG0k6MnMy1JvWDspJn1Elq3knJetKuzWduE+wpfhgiDC6ULZQt', `SecurityStamp` = 'user_39_d777@example.com', `UserName` = 'user_39_d777'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_da80@example.com', `Email` = 'user_40_da80@example.com', `NormalizedEmail` = 'USER_40_DA80@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_DA80', `PasswordHash` = 'crGfRj4AhCeW3A3LJAfEjZi8DHbusBQ405kbQqppLrngK3KKzxzZRRIk/xF8Hm3J', `SecurityStamp` = 'user_40_da80@example.com', `UserName` = 'user_40_da80'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_fcba@example.com', `Email` = 'user_41_fcba@example.com', `NormalizedEmail` = 'USER_41_FCBA@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_FCBA', `PasswordHash` = 'nQ04PM9zHXGYaqiqAFEDi+8J5ubbpg8ybNP19NoM2EZcAWTpAbmNjbulx61uPR3C', `SecurityStamp` = 'user_41_fcba@example.com', `UserName` = 'user_41_fcba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_ac80@example.com', `Email` = 'user_42_ac80@example.com', `NormalizedEmail` = 'USER_42_AC80@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_AC80', `PasswordHash` = 'OIWryxmFvRqMRu26FiH9/WiQaU3SrDoyNYqITqTMu96ZSJmWgYlFEVe1KGO+Hrg6', `SecurityStamp` = 'user_42_ac80@example.com', `UserName` = 'user_42_ac80'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_7d75@example.com', `Email` = 'user_43_7d75@example.com', `NormalizedEmail` = 'USER_43_7D75@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_7D75', `PasswordHash` = 't+f3ZMpSHyW/yty2gr9apttUBddliDoXsEcsN2Pqi6UFVr53tYG3JGf3GN7SLLfH', `SecurityStamp` = 'user_43_7d75@example.com', `UserName` = 'user_43_7d75'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_2dee@example.com', `Email` = 'user_44_2dee@example.com', `NormalizedEmail` = 'USER_44_2DEE@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_2DEE', `PasswordHash` = '664f/cqi84t8c2XzaXIxryh8PNhY0brlFQXubGjdDCW4zH9UFAjBu+YWeAkToPwT', `SecurityStamp` = 'user_44_2dee@example.com', `UserName` = 'user_44_2dee'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_5325@example.com', `Email` = 'user_45_5325@example.com', `NormalizedEmail` = 'USER_45_5325@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_5325', `PasswordHash` = 'dWMN0LY2fM9bF0W+bQt/4SMgy0ZG19IHqtOhidSCsXvgJHa9RAsWo6IzhQwXX3eP', `SecurityStamp` = 'user_45_5325@example.com', `UserName` = 'user_45_5325'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_9f39@example.com', `Email` = 'user_46_9f39@example.com', `NormalizedEmail` = 'USER_46_9F39@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_9F39', `PasswordHash` = 'f3NBRHwKnpYLu8ivrt1cIt1WNsgt7GPMVREmQSUT8GNKyY4S+WtJ+0aal2MSG58Z', `SecurityStamp` = 'user_46_9f39@example.com', `UserName` = 'user_46_9f39'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_b050@example.com', `Email` = 'user_47_b050@example.com', `NormalizedEmail` = 'USER_47_B050@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_B050', `PasswordHash` = 'Uobve4HczL3Rou77NHWKghaNYuzw/CbA/5UNM6AeDdpUf21cCnwGtfIZwELSPxKK', `SecurityStamp` = 'user_47_b050@example.com', `UserName` = 'user_47_b050'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_bee4@example.com', `Email` = 'user_48_bee4@example.com', `NormalizedEmail` = 'USER_48_BEE4@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_BEE4', `PasswordHash` = 'lRUsUssN4leZVpcOefFXAiq+dt4TbGlaGYW0JvWrKpI3URfJEmwR5rk1Ga5zVXZi', `SecurityStamp` = 'user_48_bee4@example.com', `UserName` = 'user_48_bee4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_6ced@example.com', `Email` = 'user_49_6ced@example.com', `NormalizedEmail` = 'USER_49_6CED@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_6CED', `PasswordHash` = 'HZM4lTcdZkG2Xzo9Kf4IXCoA7Unr4bzWXjaSz1Xbv0yiTq4mzBdsy1to/sInBjcI', `SecurityStamp` = 'user_49_6ced@example.com', `UserName` = 'user_49_6ced'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_ae1d@example.com', `Email` = 'user_50_ae1d@example.com', `NormalizedEmail` = 'USER_50_AE1D@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_AE1D', `PasswordHash` = 'b9pqg8IWlXgmUEYmH1R5WVpye9LnqrF3qPQNh/SugeKKplifNeHQpojC8Dl06cT1', `SecurityStamp` = 'user_50_ae1d@example.com', `UserName` = 'user_50_ae1d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'zbFdaAGMHD7WZS836FjWGZlAKd11PFpMWmED58DQG/5Gb36csat4eEEhHie8T4PF'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


CREATE INDEX `IX_Link_ProjectId` ON `Link` (`ProjectId`);

ALTER TABLE `Link` ADD CONSTRAINT `FK_Link_Projects_ProjectId` FOREIGN KEY (`ProjectId`) REFERENCES `Projects` (`Id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250312154653_AddProjectIdToLinks', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '20a5541a-42ce-4d2b-a176-f2fa9c15a3b4';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3bb35296-398c-4c58-a06f-4d9cf19585ab';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '42c4fe8d-b538-4a16-ada3-7baf0378ea5a';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7cd4c509-4a5c-4323-a6f6-7dc4422dd3dd';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9b88a31b-ec13-4ed3-9ea0-528f92bde9d5';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9c1425a6-613b-4852-97d6-78e565eaf0a1';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'da1aeb3a-db45-4167-b911-77d4577e2cf0';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'e6340207-ee6f-4c63-b32b-ca3f2988b75a';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f1620483-7434-493a-971a-38792318494e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f4d8f64a-d07d-4322-8496-2598ab7a0178';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '255cb300-3095-4753-89ae-b633dcb1aba8';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'a2bd7e0f-f0b8-4ac8-b1e0-2c02159f6c23';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'd0eef624-5bac-4c55-9d79-10a6dbb5be05';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'fb9940c6-634c-4ad2-8f40-34e707418447';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '6d0e0689-22fd-4bb4-a45b-11f29201cec9';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'b93e2793-b767-4259-8df9-2d6e2f0a7f1b';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'c050479c-5497-4011-a423-105241723488';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'ffde1662-3e80-44a1-aec4-ba05be9b483b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '1762b40e-5aae-4fab-b1f0-a6b891f7c217';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '25f9006f-b20c-4239-b3d7-ae1ceeaf903a';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '3886d9ca-0599-417a-ab93-cb4e5aacc5e2';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '6c208b50-3ab1-48f6-bd28-5852dee53592';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '9abfc01b-d85d-421d-b54b-6baa3b16f4e4';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'b52c12af-f127-4e6b-bda1-7cc68bc236d1';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'f1ba79f8-0bdd-4c2c-a7d3-dab0056d1599';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '251b4f47-9641-4dfe-b8d8-257e6a9792c1';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '36611b4c-caab-404a-bc97-1d6f43d945af';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '48a0c44e-985d-47a9-bee7-341243055ca7';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '798e48f9-e5f8-4b36-a8ee-679f5d512033';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '91b142c8-88a8-4160-9e21-fd9e84f894f9';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'cfe0e731-3b74-4d48-9b8e-1e8c31926a78';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '3f5d6005-de7e-4ffd-b155-9073cd626e54';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '5996c08e-9258-4f88-a760-0624b00f83ad';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'bf9a0a7b-02b1-442a-9715-9c8ba514f84f';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'e86241a8-6932-417f-b6a0-53680e0415b3';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '3d7f2a89-20f3-4c13-8160-87e5974279b1';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '869c53cd-9d21-4c08-8e89-739255e29421';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '9ee65c27-62ee-4ef9-a289-0c9e2252f4db';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'a4c6d063-4f3c-4738-a123-32a0b6040c9f';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'c4549858-3392-4209-8a06-59cf1e2b54f1';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '6b80f51f-9729-4ef6-9ebc-c102c9bc47b0';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'abeddc32-5c14-4d63-a91b-66fa6301ac63';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'aee6ccf1-7d98-4119-a8fb-085bfaf0e77a';
SELECT ROW_COUNT();


INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('2e4284ad-fd8f-474d-82d3-36d1106cc6c6', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('812ecb92-00a2-439d-861f-4a2117a8d0c0', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('876f1a18-f0d1-445d-84e7-796781d08f65', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('8a55344c-764c-4da1-89ca-1e56cfef6940', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('9036e690-fd4d-4514-a5a6-42b2b46752e5', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('bf238aae-b8d6-4dba-88fe-9a2cff67625c', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('c407cb0f-fe97-4db1-ae0f-fd03682b4df2', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('cbe44ef0-0f18-419a-b8c1-80a28ff682c9', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('e94bf298-2d7b-4fe5-91db-11131cf5b80f', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('fccb8fb2-b631-4bb5-bc81-72a1c458a281', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('03582c76-c17f-4677-8cad-8e13ced151c6', 'GBP', TIMESTAMP '2025-03-12 15:51:25', 2, TRUE, 'British Pound', '£', NULL),
('5579bd39-36da-4f11-aeb8-276042c6bdff', 'EUR', TIMESTAMP '2025-03-12 15:51:25', 2, TRUE, 'Euro', '€', NULL),
('8d19da2c-4e75-4a7a-a31e-35bf4cfc6568', 'CHF', TIMESTAMP '2025-03-12 15:51:25', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('d8559a39-4758-4fc6-bdf8-a66d3f370854', 'USD', TIMESTAMP '2025-03-12 15:51:25', 2, TRUE, 'US Dollar', '$', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('7d14bbb1-9010-4d82-bdaa-e3fade0cbfe7', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('a3e23bb1-62c1-4cd7-a4c7-c264d1fe872f', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('a5125878-d061-413a-a9be-1d3a16ae533a', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('d31b4d7a-b669-4d11-b78b-5124e08505d3', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('12296854-d3bc-42b6-bab1-b7ab202cf84c', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('1b6483eb-19a8-46a0-ad0b-9c1341dde43f', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('72f1c6a3-926c-4eda-844d-eb28ed65854f', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('ae28a89d-2458-4dda-a55f-1245084f988c', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('d016aece-23eb-4c15-bea7-ef92220c4c0a', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL),
('f473a42b-3386-47f9-9b8e-db6bea11ece2', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('65450286-780c-40c0-81d3-674a9ccf7370', TIMESTAMP '2025-03-12 15:51:25', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('09ea8bb8-022c-4e80-bc26-006a88e7b108', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('273b4568-c74b-4c69-b62e-5dcabb221e76', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('4becdcb1-2286-4d85-9c85-d8742fbbfcaf', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('d08e1f16-81b7-42fa-9c0d-622c2b63e609', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('f83f2142-a10f-438a-80f5-9a68fa3af50f', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('fa3f2f06-84a2-4866-a651-677f72b6e6d3', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0eb354ec-841f-4f6d-9b7e-b9c96b10b9a9', NULL, TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL),
('12b67a2e-1e53-42c8-99b1-aa81f5f5376e', NULL, TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('2b9dff5a-d52f-4d7d-b442-b76221f8b817', NULL, TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('db506e60-2244-4d6c-bbe7-b034bff911b8', NULL, TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('18e20b61-46e7-46d8-a629-fa7027dda505', TIMESTAMP '2025-03-12 15:51:25', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('99b938ee-4268-4284-a4f2-8298530041d0', TIMESTAMP '2025-03-12 15:51:25', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('acd98492-f72b-4af3-b371-a4951c1e803c', TIMESTAMP '2025-03-12 15:51:25', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('dd81e0a3-d9fb-400f-9d05-c2d63f8d744e', TIMESTAMP '2025-03-12 15:51:25', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('f99c1a4b-acae-4392-a098-4f3689d8bdd3', TIMESTAMP '2025-03-12 15:51:25', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-12 15:51:25'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('2a3fdd71-0622-416c-b840-543f90b96fcf', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('7f18202f-5d23-4451-bf07-65aac3666413', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('fcf72864-59b9-4a78-b178-fc146967abcd', TIMESTAMP '2025-03-12 15:51:25', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'aow34bPV2hO5yqZugQuO9+Yam8r4tgoCLHRdNkk9fNBTKsaXkb2+3drd8YrStLsE'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'vBN2kz74uxUaazvh0HeauTN9WS3dXSD9mrcpYB4Leb/NnCSLmPvpFofkeDdnC3qp'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_e7a9@example.com', `Email` = 'user_1_e7a9@example.com', `NormalizedEmail` = 'USER_1_E7A9@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_E7A9', `PasswordHash` = 'XlRTeN5Sxfqxd9AQvzadhXwDmDoCFwabgtAEmJa/m/rUZwlZMIeX1pBQNV6S8agh', `SecurityStamp` = 'user_1_e7a9@example.com', `UserName` = 'user_1_e7a9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_b00f@example.com', `Email` = 'user_2_b00f@example.com', `NormalizedEmail` = 'USER_2_B00F@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_B00F', `PasswordHash` = '5mhl1aZZpn13qM979PiuAxcbEJONvgMQTe2GdXY0BxCKJgCnA5u17C8QFtRkKanI', `SecurityStamp` = 'user_2_b00f@example.com', `UserName` = 'user_2_b00f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_7db3@example.com', `Email` = 'user_3_7db3@example.com', `NormalizedEmail` = 'USER_3_7DB3@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_7DB3', `PasswordHash` = 'kMXGI7FeF7UteiDxIUu8yTahRna2F17Pzq2DFrUjjVkipQDXAIADnYEGS9GV26wE', `SecurityStamp` = 'user_3_7db3@example.com', `UserName` = 'user_3_7db3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_9060@example.com', `Email` = 'user_4_9060@example.com', `NormalizedEmail` = 'USER_4_9060@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_9060', `PasswordHash` = 'S/ekc8qcwyY+UtrTctlpgc6GeEmU9wXVK8X50qmB6F7bSC8CmU5liN3rkUKWVpcZ', `SecurityStamp` = 'user_4_9060@example.com', `UserName` = 'user_4_9060'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_1c9b@example.com', `Email` = 'user_5_1c9b@example.com', `NormalizedEmail` = 'USER_5_1C9B@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_1C9B', `PasswordHash` = '+oEkEYyQXQqQhdoN4MnjSfYYcY8kqo1r52daDVsUWwQmoVhUJC3Y6/MKVwvu7hXs', `SecurityStamp` = 'user_5_1c9b@example.com', `UserName` = 'user_5_1c9b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_28d7@example.com', `Email` = 'user_6_28d7@example.com', `NormalizedEmail` = 'USER_6_28D7@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_28D7', `PasswordHash` = 'KKJa3+gE9PIfD7w+xfhDLcPLF1RgSeZrzdzssTTaeOVGa5JbNbAp2AyJinRYWokL', `SecurityStamp` = 'user_6_28d7@example.com', `UserName` = 'user_6_28d7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_8189@example.com', `Email` = 'user_7_8189@example.com', `NormalizedEmail` = 'USER_7_8189@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_8189', `PasswordHash` = 'BHh37CWEW1yty0gR39Rta5djQQ5/jc3Tp5TgDIPy2LoaCp8YMmcEA1AscLbUv6J4', `SecurityStamp` = 'user_7_8189@example.com', `UserName` = 'user_7_8189'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_cb7e@example.com', `Email` = 'user_8_cb7e@example.com', `NormalizedEmail` = 'USER_8_CB7E@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_CB7E', `PasswordHash` = 'yCXoFLGmYpV9sTvcrqDJH1AhkuS9nlRnGVeteio1WHo7k2sCW/KV8CG1SIpfgR7h', `SecurityStamp` = 'user_8_cb7e@example.com', `UserName` = 'user_8_cb7e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_e557@example.com', `Email` = 'user_9_e557@example.com', `NormalizedEmail` = 'USER_9_E557@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_E557', `PasswordHash` = 'BpgAR99X7lLyVFukXJqvUYhxIn+1E2yKRpIzctLHnPz/WCNKdobrzCd+FMKUNCvM', `SecurityStamp` = 'user_9_e557@example.com', `UserName` = 'user_9_e557'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_4bd7@example.com', `Email` = 'user_10_4bd7@example.com', `NormalizedEmail` = 'USER_10_4BD7@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_4BD7', `PasswordHash` = 'ZYcC9IAPfmHmr0cihaCFSkagKIqm2Z8VowftPIi8Og/ZpBpVCHXKhH3wwHBydnHj', `SecurityStamp` = 'user_10_4bd7@example.com', `UserName` = 'user_10_4bd7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_89f3@example.com', `Email` = 'user_11_89f3@example.com', `NormalizedEmail` = 'USER_11_89F3@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_89F3', `PasswordHash` = 'JqEFD2BcChYy/BvKBvNMno3CeQDxj8/kM++PLuH0t1tV11rfyHJZD0gzJYEXRpf3', `SecurityStamp` = 'user_11_89f3@example.com', `UserName` = 'user_11_89f3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_7572@example.com', `Email` = 'user_12_7572@example.com', `NormalizedEmail` = 'USER_12_7572@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_7572', `PasswordHash` = '4ZgPNYAp7duPrSJleGxGeFyRRyzcu51gm8o5eoFp8htZ6B3R/d8T0EBsK8aZjF9p', `SecurityStamp` = 'user_12_7572@example.com', `UserName` = 'user_12_7572'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_6e95@example.com', `Email` = 'user_13_6e95@example.com', `NormalizedEmail` = 'USER_13_6E95@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_6E95', `PasswordHash` = 'GTAELcXtzQvOG/84NDPkQTUc8vmm8yye2O40Nld/w6z0zrlVYiyQ7/4xJvdMHO3r', `SecurityStamp` = 'user_13_6e95@example.com', `UserName` = 'user_13_6e95'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_2fb2@example.com', `Email` = 'user_14_2fb2@example.com', `NormalizedEmail` = 'USER_14_2FB2@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_2FB2', `PasswordHash` = 'lqrPi7PbRTXaADiON0I5XFsfZAX5rlR++up4QTGnlgSvSMecgEW9YdiRqUJIAMPS', `SecurityStamp` = 'user_14_2fb2@example.com', `UserName` = 'user_14_2fb2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_00e7@example.com', `Email` = 'user_15_00e7@example.com', `NormalizedEmail` = 'USER_15_00E7@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_00E7', `PasswordHash` = 'qpqI7jHaQCJZ8awvaYELmoVbNgYDna+N2jVJLIU5HTAkC7ZlPFFzxuAIfplE2Gc1', `SecurityStamp` = 'user_15_00e7@example.com', `UserName` = 'user_15_00e7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_d88e@example.com', `Email` = 'user_16_d88e@example.com', `NormalizedEmail` = 'USER_16_D88E@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_D88E', `PasswordHash` = 'Znq/wdM29LHqYVyhfdC9vHzyfs6TskU4beTtJyYX6hHUJvbpEm5eaev71CX+CkRn', `SecurityStamp` = 'user_16_d88e@example.com', `UserName` = 'user_16_d88e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_5199@example.com', `Email` = 'user_17_5199@example.com', `NormalizedEmail` = 'USER_17_5199@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_5199', `PasswordHash` = 'JuML9xuj5lCcLonfQeQNPggh8rDNqIGt1EBEti+CfthoaGzOOGuoB3ny6BRCge4o', `SecurityStamp` = 'user_17_5199@example.com', `UserName` = 'user_17_5199'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_8972@example.com', `Email` = 'user_18_8972@example.com', `NormalizedEmail` = 'USER_18_8972@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_8972', `PasswordHash` = 'NlSmkKONK110HPGiuO5T/PVaKRVzqMZaEggjiVNE514ZVfVhUTVXZVGKAy952QS7', `SecurityStamp` = 'user_18_8972@example.com', `UserName` = 'user_18_8972'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_08fe@example.com', `Email` = 'user_19_08fe@example.com', `NormalizedEmail` = 'USER_19_08FE@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_08FE', `PasswordHash` = 'MeMLyJRaOWYvH13D0NrZRK2XW2YsotoLZyvkcyXkQ7n90XOc/Zas6xsK9DPkvrR0', `SecurityStamp` = 'user_19_08fe@example.com', `UserName` = 'user_19_08fe'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_f613@example.com', `Email` = 'user_20_f613@example.com', `NormalizedEmail` = 'USER_20_F613@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_F613', `PasswordHash` = '3SuKFywLFb6160iZYY6hwxoNkEI67w88C2z8aR3xr2Jz0mrEWnZ6yo/6rbHi5Gpb', `SecurityStamp` = 'user_20_f613@example.com', `UserName` = 'user_20_f613'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_c8af@example.com', `Email` = 'user_21_c8af@example.com', `NormalizedEmail` = 'USER_21_C8AF@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_C8AF', `PasswordHash` = '9t67Jrfldwkg6wTgfgirqfKroatoWSnrHVZC8ON2MjDuBlVZr5IN48ErmgnqTU7Z', `SecurityStamp` = 'user_21_c8af@example.com', `UserName` = 'user_21_c8af'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_6e6e@example.com', `Email` = 'user_22_6e6e@example.com', `NormalizedEmail` = 'USER_22_6E6E@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_6E6E', `PasswordHash` = '5Okk1RKFVS/meTIdBLY/vgvme6EHEK1I5RZVak9/p/tbrKksASKuXE8hwkx0WtAi', `SecurityStamp` = 'user_22_6e6e@example.com', `UserName` = 'user_22_6e6e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_20c0@example.com', `Email` = 'user_23_20c0@example.com', `NormalizedEmail` = 'USER_23_20C0@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_20C0', `PasswordHash` = 'mgtPxb0QXzH5iMwjwfnxk+FspYdExqHj82SDJ3znbdq0VyUt7rkC/FMrumG3GGH+', `SecurityStamp` = 'user_23_20c0@example.com', `UserName` = 'user_23_20c0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_6de2@example.com', `Email` = 'user_24_6de2@example.com', `NormalizedEmail` = 'USER_24_6DE2@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_6DE2', `PasswordHash` = 'CetrPFmyYzvUtrm336zCxZ6KhSNVjGIakWG7178tCH4CVVN1AO6WYxdB2NbitpzF', `SecurityStamp` = 'user_24_6de2@example.com', `UserName` = 'user_24_6de2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_5956@example.com', `Email` = 'user_25_5956@example.com', `NormalizedEmail` = 'USER_25_5956@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_5956', `PasswordHash` = 'kX42YO3B/xCmdf/tY2DHY2snhJlZEliXi3cvGDJmme2tPDBcyfeflNR0HUgssh7M', `SecurityStamp` = 'user_25_5956@example.com', `UserName` = 'user_25_5956'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_72ab@example.com', `Email` = 'user_26_72ab@example.com', `NormalizedEmail` = 'USER_26_72AB@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_72AB', `PasswordHash` = 'yl3ULkZUu8+GANAhCPaVsZeN5rKURDmH5Q8LkyCWBRgbwqFGQgkjMjwrmbePZtzR', `SecurityStamp` = 'user_26_72ab@example.com', `UserName` = 'user_26_72ab'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_e25d@example.com', `Email` = 'user_27_e25d@example.com', `NormalizedEmail` = 'USER_27_E25D@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_E25D', `PasswordHash` = 'wXNKZTv6XQtvV+F8OtWyoTpGFkmxQL2hqXwoGIxPhE1ptEmvTuXI60bKu8vjiQx9', `SecurityStamp` = 'user_27_e25d@example.com', `UserName` = 'user_27_e25d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_b059@example.com', `Email` = 'user_28_b059@example.com', `NormalizedEmail` = 'USER_28_B059@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_B059', `PasswordHash` = '7l/PyTe8BXjveOqEgnGkpwbwbyLxGX3/vw2+hKm/Ih4auozvSmzGEMjXCrMh4D/W', `SecurityStamp` = 'user_28_b059@example.com', `UserName` = 'user_28_b059'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_4d5b@example.com', `Email` = 'user_29_4d5b@example.com', `NormalizedEmail` = 'USER_29_4D5B@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_4D5B', `PasswordHash` = 'NJrDalQJA3G3m664HKOWTKfYhKDCHlS/GzratfdTZfaOZj1xTIZoT/BrjuJ5tT84', `SecurityStamp` = 'user_29_4d5b@example.com', `UserName` = 'user_29_4d5b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_be64@example.com', `Email` = 'user_30_be64@example.com', `NormalizedEmail` = 'USER_30_BE64@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_BE64', `PasswordHash` = 'gtc5An73yO7+B5xTCegWIeYkbTJ1q7NYRWia8C+dJWg2ct3QhhX5vv6GIElewZLJ', `SecurityStamp` = 'user_30_be64@example.com', `UserName` = 'user_30_be64'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_ef4e@example.com', `Email` = 'user_31_ef4e@example.com', `NormalizedEmail` = 'USER_31_EF4E@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_EF4E', `PasswordHash` = 'R0unK7GFK1qIhuNlkIGQIT0gudJv6NpgZsR0Eg/dYK53nZ35DPRl2suSC0D991fD', `SecurityStamp` = 'user_31_ef4e@example.com', `UserName` = 'user_31_ef4e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_1e32@example.com', `Email` = 'user_32_1e32@example.com', `NormalizedEmail` = 'USER_32_1E32@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_1E32', `PasswordHash` = 'cKU6XG9vBTm1qI9Giyqsf9gsLiHoH3i1Z3U4NvgihBK5wvy/cHvUItDzr/Ro421H', `SecurityStamp` = 'user_32_1e32@example.com', `UserName` = 'user_32_1e32'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_f003@example.com', `Email` = 'user_33_f003@example.com', `NormalizedEmail` = 'USER_33_F003@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_F003', `PasswordHash` = '5DQAJ2N+cGulGKWLZyme20oWEO0vL5no/gS5VF5umYMUzgn/f6HsWV9lyyqW9DdY', `SecurityStamp` = 'user_33_f003@example.com', `UserName` = 'user_33_f003'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_b5c6@example.com', `Email` = 'user_34_b5c6@example.com', `NormalizedEmail` = 'USER_34_B5C6@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_B5C6', `PasswordHash` = 'UCwSBL0bjZn+g/XRHdH52b9clToofX6BbnGfNLDgHgYzQIl4hu6c8LFU1hKbaEeE', `SecurityStamp` = 'user_34_b5c6@example.com', `UserName` = 'user_34_b5c6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_6834@example.com', `Email` = 'user_35_6834@example.com', `NormalizedEmail` = 'USER_35_6834@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_6834', `PasswordHash` = 'P8E4/w8b/TiVZluyouAYV4JR/2++rFuSSkI5lUjeXxKdk+I4dWU7Ey8mI3nNv7/q', `SecurityStamp` = 'user_35_6834@example.com', `UserName` = 'user_35_6834'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_a4fb@example.com', `Email` = 'user_36_a4fb@example.com', `NormalizedEmail` = 'USER_36_A4FB@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_A4FB', `PasswordHash` = 't5S08pbwQTlCg4tlbuFN2t7GWYia/iLkvNvkCrDMd62JriCU2OaPUVRp4+1i/PAQ', `SecurityStamp` = 'user_36_a4fb@example.com', `UserName` = 'user_36_a4fb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_1166@example.com', `Email` = 'user_37_1166@example.com', `NormalizedEmail` = 'USER_37_1166@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_1166', `PasswordHash` = '+wWTesxIzr/8SRc0G8RJNUEPTNjzbGMh2W9gg0kM4AtltWMJr5quhvsjLnSEYSSt', `SecurityStamp` = 'user_37_1166@example.com', `UserName` = 'user_37_1166'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_31c8@example.com', `Email` = 'user_38_31c8@example.com', `NormalizedEmail` = 'USER_38_31C8@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_31C8', `PasswordHash` = 'TyaY7ROuVd/ggPX7BrgCGS4nVWK5U6eof3I3LiMBXbTDou3wpwbsTa55MlzPQLRM', `SecurityStamp` = 'user_38_31c8@example.com', `UserName` = 'user_38_31c8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_f489@example.com', `Email` = 'user_39_f489@example.com', `NormalizedEmail` = 'USER_39_F489@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_F489', `PasswordHash` = 'SEfxT/KDYunf/0g4FQeeVjKx8zZMAyqtkYc3W2KIRLjrRM7zmMElBrbG0IhgBZjY', `SecurityStamp` = 'user_39_f489@example.com', `UserName` = 'user_39_f489'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_4658@example.com', `Email` = 'user_40_4658@example.com', `NormalizedEmail` = 'USER_40_4658@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_4658', `PasswordHash` = 'LkZm9hsy65RjTcKNQgTCusspCQDLQ5Rz3TsMX2iD2xUyZKJkSs/+vI/1BaH9SnJs', `SecurityStamp` = 'user_40_4658@example.com', `UserName` = 'user_40_4658'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_c2a7@example.com', `Email` = 'user_41_c2a7@example.com', `NormalizedEmail` = 'USER_41_C2A7@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_C2A7', `PasswordHash` = 'fGL2zbxAL8UDATUe9FNOmznVkS6NyxUj9gTeIlrQZisxh2fNySIxjT+i7ddSvrq/', `SecurityStamp` = 'user_41_c2a7@example.com', `UserName` = 'user_41_c2a7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_38d5@example.com', `Email` = 'user_42_38d5@example.com', `NormalizedEmail` = 'USER_42_38D5@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_38D5', `PasswordHash` = 'JH0R5y95ch/sCOqdY9s+KOJOY+TLLCNYorx358Hrs8dWygSo+pwXAcNjDpeJ53Xl', `SecurityStamp` = 'user_42_38d5@example.com', `UserName` = 'user_42_38d5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_73b0@example.com', `Email` = 'user_43_73b0@example.com', `NormalizedEmail` = 'USER_43_73B0@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_73B0', `PasswordHash` = 'TdzvPS7r++s/u4R5wNkREstr1zKgdbUk3swbDofjnOxRF97wFlDVw8JkZEqCKJCw', `SecurityStamp` = 'user_43_73b0@example.com', `UserName` = 'user_43_73b0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_b6bc@example.com', `Email` = 'user_44_b6bc@example.com', `NormalizedEmail` = 'USER_44_B6BC@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_B6BC', `PasswordHash` = 'sg2felbOLFVtcFCMHE8yhffGDwf+iAnWNbnzNtVf/Wq2FH665NRCNZziZ9ZClio3', `SecurityStamp` = 'user_44_b6bc@example.com', `UserName` = 'user_44_b6bc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_2bad@example.com', `Email` = 'user_45_2bad@example.com', `NormalizedEmail` = 'USER_45_2BAD@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_2BAD', `PasswordHash` = 'NgbWYYg/ljpSifPINjd57ms/DF33//nCepCOAeQXFUE3rMtdkGsKGUa88sUW24bt', `SecurityStamp` = 'user_45_2bad@example.com', `UserName` = 'user_45_2bad'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_3a13@example.com', `Email` = 'user_46_3a13@example.com', `NormalizedEmail` = 'USER_46_3A13@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_3A13', `PasswordHash` = 'Dg/I/ORZP4/KaRRxxyiAqrHrXVjJjROyjgyFQ2jHAvnBD7iWft5YNX5kNpxBvlZO', `SecurityStamp` = 'user_46_3a13@example.com', `UserName` = 'user_46_3a13'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_340b@example.com', `Email` = 'user_47_340b@example.com', `NormalizedEmail` = 'USER_47_340B@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_340B', `PasswordHash` = 'RdEaM5gYuT4ATC/DB53Bdo+zUP93E4Usx7jfKuVGBYMWKEeVg5pN+WJy/6cZoELq', `SecurityStamp` = 'user_47_340b@example.com', `UserName` = 'user_47_340b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_c9e3@example.com', `Email` = 'user_48_c9e3@example.com', `NormalizedEmail` = 'USER_48_C9E3@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_C9E3', `PasswordHash` = 'Od1mVNqcTpyo0OSsFhEOKb1wnl8FumxRMNBsDyx2NJ6nvLLJDWFMZX54UksHNomE', `SecurityStamp` = 'user_48_c9e3@example.com', `UserName` = 'user_48_c9e3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_63f6@example.com', `Email` = 'user_49_63f6@example.com', `NormalizedEmail` = 'USER_49_63F6@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_63F6', `PasswordHash` = 'gzla2UHakPCRh+NqKFxeraxXKU68TKXpP5mBGEk8l+FHOZdx7gj/9hCGnk5gtQB9', `SecurityStamp` = 'user_49_63f6@example.com', `UserName` = 'user_49_63f6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_0255@example.com', `Email` = 'user_50_0255@example.com', `NormalizedEmail` = 'USER_50_0255@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_0255', `PasswordHash` = 'RZQWGFv5UTVZMaTDrEB1dFohWWGlZxXIWkCz+ief4RPm3rfdnzt3sBR8/S0COfqt', `SecurityStamp` = 'user_50_0255@example.com', `UserName` = 'user_50_0255'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'g9O3BSapPQCi98t9GNLndjMa8NVIomfhEtBOTVlUc2JumdnDuAZnNJQZ03LQqMxf'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250312155127_AddLinksToProjects', '9.0.1');

DROP PROCEDURE IF EXISTS `POMELO_BEFORE_DROP_PRIMARY_KEY`;
DELIMITER //
CREATE PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY`(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255))
BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID TINYINT(1);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `Extra` = 'auto_increment'
			AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END //
DELIMITER ;

DROP PROCEDURE IF EXISTS `POMELO_AFTER_ADD_PRIMARY_KEY`;
DELIMITER //
CREATE PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY`(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255), IN `COLUMN_NAME_ARGUMENT` VARCHAR(255))
BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID INT(11);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
			AND `COLUMN_TYPE` LIKE '%int%'
			AND `COLUMN_KEY` = 'PRI';
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL AUTO_INCREMENT;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END //
DELIMITER ;

ALTER TABLE `Link` DROP FOREIGN KEY `FK_Link_Projects_ProjectId`;

ALTER TABLE `LinkPost` DROP FOREIGN KEY `FK_LinkPost_Link_LinksId`;

CALL POMELO_BEFORE_DROP_PRIMARY_KEY(NULL, 'Link');
ALTER TABLE `Link` DROP PRIMARY KEY;

DELETE FROM `Countries`
WHERE `Id` = '2e4284ad-fd8f-474d-82d3-36d1106cc6c6';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '812ecb92-00a2-439d-861f-4a2117a8d0c0';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '876f1a18-f0d1-445d-84e7-796781d08f65';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '8a55344c-764c-4da1-89ca-1e56cfef6940';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9036e690-fd4d-4514-a5a6-42b2b46752e5';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'bf238aae-b8d6-4dba-88fe-9a2cff67625c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c407cb0f-fe97-4db1-ae0f-fd03682b4df2';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'cbe44ef0-0f18-419a-b8c1-80a28ff682c9';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'e94bf298-2d7b-4fe5-91db-11131cf5b80f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'fccb8fb2-b631-4bb5-bc81-72a1c458a281';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '03582c76-c17f-4677-8cad-8e13ced151c6';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '5579bd39-36da-4f11-aeb8-276042c6bdff';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '8d19da2c-4e75-4a7a-a31e-35bf4cfc6568';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'd8559a39-4758-4fc6-bdf8-a66d3f370854';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '7d14bbb1-9010-4d82-bdaa-e3fade0cbfe7';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'a3e23bb1-62c1-4cd7-a4c7-c264d1fe872f';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'a5125878-d061-413a-a9be-1d3a16ae533a';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'd31b4d7a-b669-4d11-b78b-5124e08505d3';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '12296854-d3bc-42b6-bab1-b7ab202cf84c';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '1b6483eb-19a8-46a0-ad0b-9c1341dde43f';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '72f1c6a3-926c-4eda-844d-eb28ed65854f';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'ae28a89d-2458-4dda-a55f-1245084f988c';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'd016aece-23eb-4c15-bea7-ef92220c4c0a';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f473a42b-3386-47f9-9b8e-db6bea11ece2';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '65450286-780c-40c0-81d3-674a9ccf7370';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '09ea8bb8-022c-4e80-bc26-006a88e7b108';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '273b4568-c74b-4c69-b62e-5dcabb221e76';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4becdcb1-2286-4d85-9c85-d8742fbbfcaf';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'd08e1f16-81b7-42fa-9c0d-622c2b63e609';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'f83f2142-a10f-438a-80f5-9a68fa3af50f';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'fa3f2f06-84a2-4866-a651-677f72b6e6d3';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '0eb354ec-841f-4f6d-9b7e-b9c96b10b9a9';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '12b67a2e-1e53-42c8-99b1-aa81f5f5376e';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '2b9dff5a-d52f-4d7d-b442-b76221f8b817';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'db506e60-2244-4d6c-bbe7-b034bff911b8';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '18e20b61-46e7-46d8-a629-fa7027dda505';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '99b938ee-4268-4284-a4f2-8298530041d0';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'acd98492-f72b-4af3-b371-a4951c1e803c';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'dd81e0a3-d9fb-400f-9d05-c2d63f8d744e';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'f99c1a4b-acae-4392-a098-4f3689d8bdd3';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '2a3fdd71-0622-416c-b840-543f90b96fcf';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '7f18202f-5d23-4451-bf07-65aac3666413';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'fcf72864-59b9-4a78-b178-fc146967abcd';
SELECT ROW_COUNT();


ALTER TABLE `Link` RENAME `Links`;

ALTER TABLE `Links` RENAME INDEX `IX_Link_ProjectId` TO `IX_Links_ProjectId`;

ALTER TABLE `Links` ADD CONSTRAINT `PK_Links` PRIMARY KEY (`Id`);
CALL POMELO_AFTER_ADD_PRIMARY_KEY(NULL, 'Links', 'Id');

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('09ca5911-7e1d-4498-b085-ade32bfeb3ff', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('1dffda0e-4f01-4fea-9efa-2435c219ccc3', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('58b01a72-5be3-4796-8597-bf4e8534cf74', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('5db6fcf1-f2dc-433b-8c15-9bab99182738', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('61efd147-c690-4b8b-8073-a9004316ca81', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('7163474a-a9c9-4b00-99f0-95eb38d115bd', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('978f842e-2ad3-4e03-b7de-09c7c06b4752', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('c9679668-e538-42c7-af9d-b6a596a64baa', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('e3f03c7b-3a11-4c78-b47d-422156c287f7', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('e8f52ff3-ae7b-43b2-b3e0-79f96ad42d74', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('04001865-57b1-4eb7-ad19-af76b5923ef3', 'USD', TIMESTAMP '2025-03-12 22:28:49', 2, TRUE, 'US Dollar', '$', NULL),
('5bba8cb3-467f-48ab-bbb9-e381360afb5e', 'GBP', TIMESTAMP '2025-03-12 22:28:49', 2, TRUE, 'British Pound', '£', NULL),
('a411507b-5428-4e8c-adaf-47baa5c2f09e', 'CHF', TIMESTAMP '2025-03-12 22:28:49', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('ddf98b3a-303a-43d1-ba87-bb72ce8bbcde', 'EUR', TIMESTAMP '2025-03-12 22:28:49', 2, TRUE, 'Euro', '€', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('18cf105a-4c9c-4e50-8cf8-b4ecf8a219de', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('41850229-3cef-4231-852b-267234648f83', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('6424fe83-9b3b-420c-ae5f-d500451fa799', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('aca80b2f-b8c1-4ac1-8299-bff74cb3a530', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('11c857ca-b852-4aef-b77b-91fd20d976e0', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('41181230-a303-41f0-894f-3009abf19ec1', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('975b73c5-96bc-47a7-85b2-50d476d84c29', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('994fdfe9-15e9-43e4-9887-e64baef6d40b', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('d14d1827-e3c0-4a64-971a-37706246c185', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('f6c8bf6a-0982-44f5-ab07-339cecd4dd21', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('c53deb5b-6b09-4ab4-8a09-6789db25f768', TIMESTAMP '2025-03-12 22:28:49', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('3282f437-2db3-415d-ba5d-25c35b28c702', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('4870d922-4d42-4d34-a7eb-19966205847d', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('488ee5c9-e139-4367-ac93-838d77c852bf', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('78fdd2f3-7ade-4b9e-83b6-038754edd12f', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('8ef4478c-dc1a-4a06-8bbe-a44ceb518ec7', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('9b05b0f7-21db-48e4-9765-3a458ce202a5', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('22648235-8464-4ced-97a1-37e01c302ab6', NULL, TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL),
('40e34147-aa83-4431-a65e-ba2dca57a1fb', NULL, TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('6a52bcfc-d8e4-497a-ac3c-b9d3c1b5fcb1', NULL, TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL),
('92a0991a-d7b9-4cc5-a628-5d3db92e5fe2', NULL, TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('3f8ef595-7fff-4b31-8252-b9d63201c5c6', TIMESTAMP '2025-03-12 22:28:49', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('ab7bfbbb-da12-47fd-9f42-2978d7cbabd6', TIMESTAMP '2025-03-12 22:28:49', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('ce27c274-e52a-4f4c-a65e-143619508631', TIMESTAMP '2025-03-12 22:28:49', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('dc734527-754c-4eaa-846e-27c1e3174ec9', TIMESTAMP '2025-03-12 22:28:49', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('e4e0ba3f-1b2e-4bcb-b002-b043bc287864', TIMESTAMP '2025-03-12 22:28:49', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-12 22:28:49'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('7ea31892-2b92-4634-bcd1-d651669b0d84', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('ca679982-647f-4c78-9714-f4126e4578cb', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('f76306b3-9813-4b91-a92c-5f87d96c4afb', TIMESTAMP '2025-03-12 22:28:49', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'M0jZ6/uhf3+T3KWo8VA45aiua5KpJUGiETkUn7lPXCl0IEx+YOn6YVertRZLYy+/'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'XEae7oVT9FMW7DUb8gWmBwYlGGs/BKLX1Sq7HLUIrhpzNzD1yv0FiLYxtk0KE4uD'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_126d@example.com', `Email` = 'user_1_126d@example.com', `NormalizedEmail` = 'USER_1_126D@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_126D', `PasswordHash` = 'oM/tD8lI6QQy2ppbXq08n4GyZR6j46Ciknov646LPDSWVt2cKTFvIcPFkoyL6Nv5', `SecurityStamp` = 'user_1_126d@example.com', `UserName` = 'user_1_126d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_7019@example.com', `Email` = 'user_2_7019@example.com', `NormalizedEmail` = 'USER_2_7019@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_7019', `PasswordHash` = '6AKPvUjEy0gKkDAy+rCYK6OGGec7xWG80qLnw0dOlDD5uMamdLY+ptPolKei48yX', `SecurityStamp` = 'user_2_7019@example.com', `UserName` = 'user_2_7019'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_b0ff@example.com', `Email` = 'user_3_b0ff@example.com', `NormalizedEmail` = 'USER_3_B0FF@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_B0FF', `PasswordHash` = 'K4oZ4UkC9sS8ZsfHA/fL2iXzL2zbSXJNxRrhN/kCX8H/Cz1VPMAzZhWlmBqfpYh2', `SecurityStamp` = 'user_3_b0ff@example.com', `UserName` = 'user_3_b0ff'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_600d@example.com', `Email` = 'user_4_600d@example.com', `NormalizedEmail` = 'USER_4_600D@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_600D', `PasswordHash` = '8xVd+HLrQUtZ5QsQY6fHZR4Y/erYtAf3mYj5BHN4uAgFL+iqyQYP3YBOuKqQKiL0', `SecurityStamp` = 'user_4_600d@example.com', `UserName` = 'user_4_600d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_c5e4@example.com', `Email` = 'user_5_c5e4@example.com', `NormalizedEmail` = 'USER_5_C5E4@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_C5E4', `PasswordHash` = 'z9+nxcOAGl+RTnRCaD225u+dvAdk5ecuXajJDnzIJnFTQFJCgNHrJ5Y9RVdX0Dcu', `SecurityStamp` = 'user_5_c5e4@example.com', `UserName` = 'user_5_c5e4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_7467@example.com', `Email` = 'user_6_7467@example.com', `NormalizedEmail` = 'USER_6_7467@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_7467', `PasswordHash` = 'k1EHnEkcwkAg90XPl4Kz9wSkwOV08Feq6zFWPz0qRNUZ75G6zRVNI/FQaY5Ary2I', `SecurityStamp` = 'user_6_7467@example.com', `UserName` = 'user_6_7467'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_9f0b@example.com', `Email` = 'user_7_9f0b@example.com', `NormalizedEmail` = 'USER_7_9F0B@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_9F0B', `PasswordHash` = 'Vdom155ko8Lg/YLeKrngImJjfoddv/GmjHlnQY1SBzzzpjd0eDAh69enDxt7HD8e', `SecurityStamp` = 'user_7_9f0b@example.com', `UserName` = 'user_7_9f0b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_bc1e@example.com', `Email` = 'user_8_bc1e@example.com', `NormalizedEmail` = 'USER_8_BC1E@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_BC1E', `PasswordHash` = 'IIbSwLcz8nJPcxH1bgk6phv9YkBAY/VgTc/X5PMgfRWrsY443+ae1gRlcAfcdMPl', `SecurityStamp` = 'user_8_bc1e@example.com', `UserName` = 'user_8_bc1e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_62ab@example.com', `Email` = 'user_9_62ab@example.com', `NormalizedEmail` = 'USER_9_62AB@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_62AB', `PasswordHash` = 'wFzaz16JBFZisdihl1Ku4QsowTz0DaMIUaTKoaljNSTFDr33TD53TFcuCPDln48L', `SecurityStamp` = 'user_9_62ab@example.com', `UserName` = 'user_9_62ab'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_7045@example.com', `Email` = 'user_10_7045@example.com', `NormalizedEmail` = 'USER_10_7045@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_7045', `PasswordHash` = 'YyPBa6tT8rk1Y9AiLsul35PUz4FxGLLBFHBOWDcP9ut/bfonE8q/6RYmzgJ3JDNx', `SecurityStamp` = 'user_10_7045@example.com', `UserName` = 'user_10_7045'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_9058@example.com', `Email` = 'user_11_9058@example.com', `NormalizedEmail` = 'USER_11_9058@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_9058', `PasswordHash` = 'S1vB1jbOvoAiECz7qFo+MR/e0S1rcEBft5bAwcPVulM2Ui//sww3YVMXrjH7EEbd', `SecurityStamp` = 'user_11_9058@example.com', `UserName` = 'user_11_9058'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_041d@example.com', `Email` = 'user_12_041d@example.com', `NormalizedEmail` = 'USER_12_041D@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_041D', `PasswordHash` = 'VdkiHL7HXcb8wcwbNtIJFsc1g0geZplvEeRpURV6ZxaorxQ6MAq6iKN7FneQtvPX', `SecurityStamp` = 'user_12_041d@example.com', `UserName` = 'user_12_041d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_ae6f@example.com', `Email` = 'user_13_ae6f@example.com', `NormalizedEmail` = 'USER_13_AE6F@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_AE6F', `PasswordHash` = 'cPdsbvdnoepnfs1rQXtvOyOppbyPyKYerhOIBpz0nvVjfd5T5O33uzxlfEnlQJnd', `SecurityStamp` = 'user_13_ae6f@example.com', `UserName` = 'user_13_ae6f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_3389@example.com', `Email` = 'user_14_3389@example.com', `NormalizedEmail` = 'USER_14_3389@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_3389', `PasswordHash` = 'mqyK41UUv1XDEdVdW3g7VDmsOcWw0ELYjLRFGaX+grQKSE2IlPELFY8bGYoZXj/h', `SecurityStamp` = 'user_14_3389@example.com', `UserName` = 'user_14_3389'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_3995@example.com', `Email` = 'user_15_3995@example.com', `NormalizedEmail` = 'USER_15_3995@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_3995', `PasswordHash` = 'uvHwfuLm6MUh2JQiVSPXlUR4oeS+vjsup33B4PYIF48FtpTYYxylHxNyx/x/7ibR', `SecurityStamp` = 'user_15_3995@example.com', `UserName` = 'user_15_3995'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_4f0c@example.com', `Email` = 'user_16_4f0c@example.com', `NormalizedEmail` = 'USER_16_4F0C@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_4F0C', `PasswordHash` = 'Qhuce173uxWg/QU1geyhRT/9LDuc0R1oVF6QZIGhr3iVOq7jqGBayPWsptr0nhrz', `SecurityStamp` = 'user_16_4f0c@example.com', `UserName` = 'user_16_4f0c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_7b6a@example.com', `Email` = 'user_17_7b6a@example.com', `NormalizedEmail` = 'USER_17_7B6A@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_7B6A', `PasswordHash` = 'de9HW+VLBQLxakQegPnO+ciW1Jr2dcpGEBHAOuTVT4lxyHYOt31xUpTboZVT0rCX', `SecurityStamp` = 'user_17_7b6a@example.com', `UserName` = 'user_17_7b6a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_9b7d@example.com', `Email` = 'user_18_9b7d@example.com', `NormalizedEmail` = 'USER_18_9B7D@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_9B7D', `PasswordHash` = 'DJCvR5qtgoe6jr06aK48WGx/5bIOBw5M5o87fD2vRkJhwQtjknpl9UyS21cdMz5G', `SecurityStamp` = 'user_18_9b7d@example.com', `UserName` = 'user_18_9b7d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_78d7@example.com', `Email` = 'user_19_78d7@example.com', `NormalizedEmail` = 'USER_19_78D7@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_78D7', `PasswordHash` = 'BHl+pBJBo+r/doRdHvaFZk8micIURnq9N2I3+sZTKxRULU5xJSiGK4nI8Z62wQvs', `SecurityStamp` = 'user_19_78d7@example.com', `UserName` = 'user_19_78d7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_4dfe@example.com', `Email` = 'user_20_4dfe@example.com', `NormalizedEmail` = 'USER_20_4DFE@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_4DFE', `PasswordHash` = 'pedZw/J4ybNtS2PmZwfpvsunwGnY7gs8EjKLGkDGXDEg4xwhsSR/8ZmLzAPPMuy4', `SecurityStamp` = 'user_20_4dfe@example.com', `UserName` = 'user_20_4dfe'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_c949@example.com', `Email` = 'user_21_c949@example.com', `NormalizedEmail` = 'USER_21_C949@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_C949', `PasswordHash` = 'EJG6pcYs1GnY5avArYwBZrPvxWPPpS77pdcmHNd5W9asLfBbUQsMrhVCh0E5F5mo', `SecurityStamp` = 'user_21_c949@example.com', `UserName` = 'user_21_c949'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_4cee@example.com', `Email` = 'user_22_4cee@example.com', `NormalizedEmail` = 'USER_22_4CEE@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_4CEE', `PasswordHash` = 'Ab/Y7aOba/l+oHL8gcjojhg3sDD5zsFEpfmKd8r6uzxQ7cJ8Z6C+QWEqta3RIy4H', `SecurityStamp` = 'user_22_4cee@example.com', `UserName` = 'user_22_4cee'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_99eb@example.com', `Email` = 'user_23_99eb@example.com', `NormalizedEmail` = 'USER_23_99EB@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_99EB', `PasswordHash` = 'u6JhaHZp8vfxy9VH0ZFCuXtl1gzHWWWUQ0UJinW2UTpEMOo7Ouu35KoWgwTQB3Gv', `SecurityStamp` = 'user_23_99eb@example.com', `UserName` = 'user_23_99eb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_4c3c@example.com', `Email` = 'user_24_4c3c@example.com', `NormalizedEmail` = 'USER_24_4C3C@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_4C3C', `PasswordHash` = 'N7u+wowB2HWnpfN4Tx4NbFiltrgwdvfgDsQPBIc1/80cE3cLLuLio+DHr19oD7Ke', `SecurityStamp` = 'user_24_4c3c@example.com', `UserName` = 'user_24_4c3c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_a5fc@example.com', `Email` = 'user_25_a5fc@example.com', `NormalizedEmail` = 'USER_25_A5FC@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_A5FC', `PasswordHash` = '4W3lnFh1NSntMgrfOCxahiLKErek+UTSkRIjOXoTT4ralvHUQz+bQK3fF13So8D4', `SecurityStamp` = 'user_25_a5fc@example.com', `UserName` = 'user_25_a5fc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_1668@example.com', `Email` = 'user_26_1668@example.com', `NormalizedEmail` = 'USER_26_1668@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_1668', `PasswordHash` = '06BIyEskc61cWrMgiwKSGmDULx9Viwxrq/gkLeiQ0MqIdoAL9HApb8HbTsiYXibG', `SecurityStamp` = 'user_26_1668@example.com', `UserName` = 'user_26_1668'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_9be6@example.com', `Email` = 'user_27_9be6@example.com', `NormalizedEmail` = 'USER_27_9BE6@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_9BE6', `PasswordHash` = 'Yttzb8Vm3w4+7lJSe1YFRCWcZh+2Yr39ZBfXA6bZmZFqaU5rOFuZ/YQuO8Pt7lKU', `SecurityStamp` = 'user_27_9be6@example.com', `UserName` = 'user_27_9be6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_a8f4@example.com', `Email` = 'user_28_a8f4@example.com', `NormalizedEmail` = 'USER_28_A8F4@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_A8F4', `PasswordHash` = 'oLlP7Fz7KYviyzvzsREiyJW+dkKwBk87AVnE3f8+MTIj2+ih/2Stl+H/Wa+x1ubP', `SecurityStamp` = 'user_28_a8f4@example.com', `UserName` = 'user_28_a8f4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_3a4a@example.com', `Email` = 'user_29_3a4a@example.com', `NormalizedEmail` = 'USER_29_3A4A@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_3A4A', `PasswordHash` = 'hkVx3xgUBEPlNy8JI2X2L5IVXXCF5mY+DGid6pDDXpQfpX+AaZ+YGs143kiBmtIb', `SecurityStamp` = 'user_29_3a4a@example.com', `UserName` = 'user_29_3a4a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_042c@example.com', `Email` = 'user_30_042c@example.com', `NormalizedEmail` = 'USER_30_042C@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_042C', `PasswordHash` = 'FV+tIr6VHoyVMdaJdVx2ZTYWSMroPUKUcVc7Dio40skeDLdWFw8AB9Jc37bB1gZb', `SecurityStamp` = 'user_30_042c@example.com', `UserName` = 'user_30_042c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_b8bc@example.com', `Email` = 'user_31_b8bc@example.com', `NormalizedEmail` = 'USER_31_B8BC@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_B8BC', `PasswordHash` = 'JeNLHpYd6ESVwuI5NUN65RwiZlSauPmwnEXeZxGGkNC+2OqIqZ3SVghJu7251ot9', `SecurityStamp` = 'user_31_b8bc@example.com', `UserName` = 'user_31_b8bc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_5c06@example.com', `Email` = 'user_32_5c06@example.com', `NormalizedEmail` = 'USER_32_5C06@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_5C06', `PasswordHash` = '6Gdn4Sx1Z4TtWpa25Nfk1tlDsumzAAPyeiTyOfduawnNT3WPkj2BWIpSEcqcxTB5', `SecurityStamp` = 'user_32_5c06@example.com', `UserName` = 'user_32_5c06'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_1a61@example.com', `Email` = 'user_33_1a61@example.com', `NormalizedEmail` = 'USER_33_1A61@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_1A61', `PasswordHash` = 'k0OUm/tXPHnKHo6QPx4457+p9crNj6AXSLnFwOoPuriL5NX7gpnnh4KpPbzLx3LM', `SecurityStamp` = 'user_33_1a61@example.com', `UserName` = 'user_33_1a61'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_7760@example.com', `Email` = 'user_34_7760@example.com', `NormalizedEmail` = 'USER_34_7760@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_7760', `PasswordHash` = 'LzRQiQFJ1JRyMG2wCtLEfzZksXHse2oY2mYoC+9j+LgtUBdaur5mUb3xcvUbQmTY', `SecurityStamp` = 'user_34_7760@example.com', `UserName` = 'user_34_7760'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_ca73@example.com', `Email` = 'user_35_ca73@example.com', `NormalizedEmail` = 'USER_35_CA73@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_CA73', `PasswordHash` = 'baihlDOstpdZUFC1xnKYw1Ch6Xp6y8yybqHn2fWkMb4XIYXVeLvcPebI02ZZAlWt', `SecurityStamp` = 'user_35_ca73@example.com', `UserName` = 'user_35_ca73'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_077a@example.com', `Email` = 'user_36_077a@example.com', `NormalizedEmail` = 'USER_36_077A@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_077A', `PasswordHash` = 'huYnasw7F1aKVCZOl8FWXQTdJTrBeNdV/FAwrZdmxzivMLsPCGY0dsfb8uVB64Gk', `SecurityStamp` = 'user_36_077a@example.com', `UserName` = 'user_36_077a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_3d9f@example.com', `Email` = 'user_37_3d9f@example.com', `NormalizedEmail` = 'USER_37_3D9F@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_3D9F', `PasswordHash` = 'B4EnmBmlDHVJLbRUAhHHPFP/+SmZDcFvE1OgqspJtQyrAioPoJr08oJjzPEsuJ5P', `SecurityStamp` = 'user_37_3d9f@example.com', `UserName` = 'user_37_3d9f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_842e@example.com', `Email` = 'user_38_842e@example.com', `NormalizedEmail` = 'USER_38_842E@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_842E', `PasswordHash` = 'KUSTyTMCfjWOdLl7BaUzHudo7vpa/F5NuehdWWMQsu+9jl/ALcX4MrkUKhAT9G/s', `SecurityStamp` = 'user_38_842e@example.com', `UserName` = 'user_38_842e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_1050@example.com', `Email` = 'user_39_1050@example.com', `NormalizedEmail` = 'USER_39_1050@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_1050', `PasswordHash` = 'igOh5DAK58BQCEl/WIVFdTrjQ6JpmA1GGfHXTK5EBjQD47ldRgqMMaXVYozJhJLt', `SecurityStamp` = 'user_39_1050@example.com', `UserName` = 'user_39_1050'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_b69b@example.com', `Email` = 'user_40_b69b@example.com', `NormalizedEmail` = 'USER_40_B69B@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_B69B', `PasswordHash` = '3t4lqFmrLBebbo3rZvxAlwFvNx7YxHvJ0bb50WFt0Bs22yh02fahsA91iKXhYszr', `SecurityStamp` = 'user_40_b69b@example.com', `UserName` = 'user_40_b69b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_75c0@example.com', `Email` = 'user_41_75c0@example.com', `NormalizedEmail` = 'USER_41_75C0@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_75C0', `PasswordHash` = 'delVpDEIb7q2Z8t78oIBqDKz1uGLZqhO2ugVSxchTeMJtYm/dEBKL4+mTxV1k0rC', `SecurityStamp` = 'user_41_75c0@example.com', `UserName` = 'user_41_75c0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_c5c8@example.com', `Email` = 'user_42_c5c8@example.com', `NormalizedEmail` = 'USER_42_C5C8@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_C5C8', `PasswordHash` = 'lDcPwGhiXbLz+xMofk0+CgaNoniFjU06QsJsqbdz4K9LRxhFCYtq92YzaOAP4Nl4', `SecurityStamp` = 'user_42_c5c8@example.com', `UserName` = 'user_42_c5c8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_9bad@example.com', `Email` = 'user_43_9bad@example.com', `NormalizedEmail` = 'USER_43_9BAD@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_9BAD', `PasswordHash` = 'uJby/Mpy7oQ4u26CmbR0csV9rJ1cbxSE6wSuuZTUvc50M9FmZT7Km+hcTmyr2q4z', `SecurityStamp` = 'user_43_9bad@example.com', `UserName` = 'user_43_9bad'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_694e@example.com', `Email` = 'user_44_694e@example.com', `NormalizedEmail` = 'USER_44_694E@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_694E', `PasswordHash` = 'YbF51p7nhsqFckuKdvYGCWx7G/92WkrnwYz0edh04h113rqsNZ5AeabS2PZ3y63n', `SecurityStamp` = 'user_44_694e@example.com', `UserName` = 'user_44_694e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_dda8@example.com', `Email` = 'user_45_dda8@example.com', `NormalizedEmail` = 'USER_45_DDA8@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_DDA8', `PasswordHash` = 'vZskD1xIwaLbsjPOYmaYapglU9LpZLjxptalGArQmrelbfOedFgJhPCmdXwq1isr', `SecurityStamp` = 'user_45_dda8@example.com', `UserName` = 'user_45_dda8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_8e38@example.com', `Email` = 'user_46_8e38@example.com', `NormalizedEmail` = 'USER_46_8E38@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_8E38', `PasswordHash` = '79sAWp/h/s9FSY8aYP7Pe8dFHL8QjO0JLWGaRCzuK7WgAxajKQvORfAtcWTCEla+', `SecurityStamp` = 'user_46_8e38@example.com', `UserName` = 'user_46_8e38'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_6380@example.com', `Email` = 'user_47_6380@example.com', `NormalizedEmail` = 'USER_47_6380@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_6380', `PasswordHash` = 'gKeE7CcfitbUwOokbKiOooqU942nXBXUL50JOW8cNS1gUjkKqa5glB4r8n3H6lQN', `SecurityStamp` = 'user_47_6380@example.com', `UserName` = 'user_47_6380'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_4788@example.com', `Email` = 'user_48_4788@example.com', `NormalizedEmail` = 'USER_48_4788@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_4788', `PasswordHash` = 'J7UP7csjNGBSvqqhsdvyr3tBYuyfWhZsL8O+FRYPaly0GK53byq8I6XmsJwKD0Vz', `SecurityStamp` = 'user_48_4788@example.com', `UserName` = 'user_48_4788'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_4aff@example.com', `Email` = 'user_49_4aff@example.com', `NormalizedEmail` = 'USER_49_4AFF@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_4AFF', `PasswordHash` = 'gzsr7HRiofMNm3mLqoZhypzQlxOkV1QlKUfxhC0FPlTQK3P3fKyEz820cJIsk0sv', `SecurityStamp` = 'user_49_4aff@example.com', `UserName` = 'user_49_4aff'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_5d94@example.com', `Email` = 'user_50_5d94@example.com', `NormalizedEmail` = 'USER_50_5D94@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_5D94', `PasswordHash` = 'eornIhp/QxUVZRoxuSwBQI6ejntrKWi3by/+lw4f7wHubugIK40jQgBmiegRtQYu', `SecurityStamp` = 'user_50_5d94@example.com', `UserName` = 'user_50_5d94'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = '3Wu+Y1P1CgEl+x548UaeHT6wG/jo3685ycfNzIbw7yGcq1EBXAmsEHxT96RIXmf4'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


ALTER TABLE `LinkPost` ADD CONSTRAINT `FK_LinkPost_Links_LinksId` FOREIGN KEY (`LinksId`) REFERENCES `Links` (`Id`) ON DELETE CASCADE;

ALTER TABLE `Links` ADD CONSTRAINT `FK_Links_Projects_ProjectId` FOREIGN KEY (`ProjectId`) REFERENCES `Projects` (`Id`) ON DELETE CASCADE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250312222857_AddLinksTable', '9.0.1');

DROP PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY`;

DROP PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY`;

DELETE FROM `Countries`
WHERE `Id` = '09ca5911-7e1d-4498-b085-ade32bfeb3ff';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '1dffda0e-4f01-4fea-9efa-2435c219ccc3';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '58b01a72-5be3-4796-8597-bf4e8534cf74';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '5db6fcf1-f2dc-433b-8c15-9bab99182738';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '61efd147-c690-4b8b-8073-a9004316ca81';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7163474a-a9c9-4b00-99f0-95eb38d115bd';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '978f842e-2ad3-4e03-b7de-09c7c06b4752';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c9679668-e538-42c7-af9d-b6a596a64baa';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'e3f03c7b-3a11-4c78-b47d-422156c287f7';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'e8f52ff3-ae7b-43b2-b3e0-79f96ad42d74';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '04001865-57b1-4eb7-ad19-af76b5923ef3';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '5bba8cb3-467f-48ab-bbb9-e381360afb5e';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'a411507b-5428-4e8c-adaf-47baa5c2f09e';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'ddf98b3a-303a-43d1-ba87-bb72ce8bbcde';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '18cf105a-4c9c-4e50-8cf8-b4ecf8a219de';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '41850229-3cef-4231-852b-267234648f83';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '6424fe83-9b3b-420c-ae5f-d500451fa799';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'aca80b2f-b8c1-4ac1-8299-bff74cb3a530';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '11c857ca-b852-4aef-b77b-91fd20d976e0';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '41181230-a303-41f0-894f-3009abf19ec1';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '975b73c5-96bc-47a7-85b2-50d476d84c29';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '994fdfe9-15e9-43e4-9887-e64baef6d40b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'd14d1827-e3c0-4a64-971a-37706246c185';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f6c8bf6a-0982-44f5-ab07-339cecd4dd21';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'c53deb5b-6b09-4ab4-8a09-6789db25f768';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '3282f437-2db3-415d-ba5d-25c35b28c702';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4870d922-4d42-4d34-a7eb-19966205847d';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '488ee5c9-e139-4367-ac93-838d77c852bf';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '78fdd2f3-7ade-4b9e-83b6-038754edd12f';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '8ef4478c-dc1a-4a06-8bbe-a44ceb518ec7';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '9b05b0f7-21db-48e4-9765-3a458ce202a5';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '22648235-8464-4ced-97a1-37e01c302ab6';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '40e34147-aa83-4431-a65e-ba2dca57a1fb';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '6a52bcfc-d8e4-497a-ac3c-b9d3c1b5fcb1';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '92a0991a-d7b9-4cc5-a628-5d3db92e5fe2';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '3f8ef595-7fff-4b31-8252-b9d63201c5c6';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'ab7bfbbb-da12-47fd-9f42-2978d7cbabd6';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'ce27c274-e52a-4f4c-a65e-143619508631';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'dc734527-754c-4eaa-846e-27c1e3174ec9';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'e4e0ba3f-1b2e-4bcb-b002-b043bc287864';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '7ea31892-2b92-4634-bcd1-d651669b0d84';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'ca679982-647f-4c78-9714-f4126e4578cb';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'f76306b3-9813-4b91-a92c-5f87d96c4afb';
SELECT ROW_COUNT();


CREATE TABLE `VisitorLogs` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `IPAddress` longtext CHARACTER SET utf8mb4 NOT NULL,
    `VisitDate` datetime(6) NOT NULL,
    `UserAgent` longtext CHARACTER SET utf8mb4 NULL,
    `Referrer` longtext CHARACTER SET utf8mb4 NULL,
    `Path` longtext CHARACTER SET utf8mb4 NULL,
    `IsUnique` tinyint(1) NOT NULL,
    `SessionId` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_VisitorLogs` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('14cac200-35a8-4508-9c99-3b83f8a51584', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('2226c1b1-eaf2-4fe1-818b-9b9d6d42f64d', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('24affc02-6467-4117-8fcb-772c8663e769', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('3fce737c-cc6c-4865-973b-b84aa6a2ffc8', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('56d4d203-463c-4118-87b4-bef96611e3e2', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('57d7d1b2-91c2-4a71-b447-abe761ad9602', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('6360cf47-6b3d-4909-857c-4c84ece7aefb', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('ae5b2500-f175-46ae-89fa-33624ff428c1', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('c9625c88-129d-4add-9ef3-c5fa71916909', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('f418d13c-91b3-4944-aba4-71789fa9f78a', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('05adbd79-ca57-4670-b1f4-4097e44e2c7d', 'USD', TIMESTAMP '2025-03-13 21:29:47', 2, TRUE, 'US Dollar', '$', NULL),
('2a1bad9b-37a7-4636-bc22-3c49909f502e', 'EUR', TIMESTAMP '2025-03-13 21:29:47', 2, TRUE, 'Euro', '€', NULL),
('c72b6a81-5fdc-4e1d-9e84-1243beae6a7f', 'CHF', TIMESTAMP '2025-03-13 21:29:47', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('e0228447-83ae-4401-8d40-6650fb313e4c', 'GBP', TIMESTAMP '2025-03-13 21:29:47', 2, TRUE, 'British Pound', '£', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('099ed36c-374c-453a-bdb9-e4d24757c001', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('42c9d93e-e77d-4b86-8300-57f82ec25f21', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('a59fecc4-d2ad-4c5b-9200-ee13679f82eb', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('e68efa96-0d18-456b-80b6-2a34a4724b81', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0ef27efd-fdbe-4044-b663-afe8dd2c694b', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('31f54852-828e-499b-b2ba-f0cd46eb4b80', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('8fd817f1-c1ce-4a85-ab5f-f95d7f30ee87', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('9d8a275a-da27-46a1-8c71-ed6e5ced45a1', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('a63f9e0b-a700-4181-94bc-1a5a0b7db87d', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('e91d2b1d-ada0-4183-833a-017c87609671', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('94ca0401-5ef4-42f9-842e-22f45f345acf', TIMESTAMP '2025-03-13 21:29:47', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('064d0c37-b74b-4da5-9d37-94228b0ac0ff', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('09b85713-39c9-4e14-b808-2a04790091bf', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('54d2e64c-69df-4ebc-b9ff-02ee717503ab', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('61951454-bc35-4258-8ccd-ae1fbc7b86f2', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('b33c1c73-8f9e-4b9f-80fc-c383d3deb054', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('db9d4744-a57e-4417-8db3-24bbb3d28fed', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('3f224bf0-934c-4bf3-9e50-bbd9c02438a7', NULL, TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL),
('c0191c90-75b6-468f-89d9-a54493a59510', NULL, TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('f42a31d9-fb90-4b88-81de-0826fa711d69', NULL, TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('fdd3d14f-7492-4bd5-9a20-bce4e6e7cb47', NULL, TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('0d22fc87-8e0c-4fb0-a578-99b701d6a64c', TIMESTAMP '2025-03-13 21:29:47', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('2039c46e-33b8-4ff7-829d-c6d68341047a', TIMESTAMP '2025-03-13 21:29:47', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('27331e4f-da42-46b9-bd11-6994c8e50a39', TIMESTAMP '2025-03-13 21:29:47', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('3a3518cb-cc9e-4d13-a237-902b2ef33e0a', TIMESTAMP '2025-03-13 21:29:47', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('866f3732-d04a-41a3-8589-818a050cd693', TIMESTAMP '2025-03-13 21:29:47', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-13 21:29:47'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1b7cde9b-14a5-4425-abb4-e4ac5833555e', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('980cb001-8867-43fe-8400-596ffd30f4f4', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('d07c3776-e3b6-435d-aace-761c6226f2a2', TIMESTAMP '2025-03-13 21:29:47', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'TLOPT2/tEEgbWHdOlbm0FQ5Fh+v88gchn5bRVkzJbU8F8+TR5ugX2pmHU2O76Rb8'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'N9/BU8FeRW/wLIUs6gpeRQXrVVrwzUoxF+I+iZU8SnjUFrp0ixphdLXnyXTyXQIB'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_0123@example.com', `Email` = 'user_1_0123@example.com', `NormalizedEmail` = 'USER_1_0123@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_0123', `PasswordHash` = 'v3so7EOUPZF4pU6b/9ZysatixY+nCJmBQ/lDnghMyAzIyPG6MFd8VyFB+Gef+R5s', `SecurityStamp` = 'user_1_0123@example.com', `UserName` = 'user_1_0123'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_63ed@example.com', `Email` = 'user_2_63ed@example.com', `NormalizedEmail` = 'USER_2_63ED@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_63ED', `PasswordHash` = 't1tsu8tVOrR/xMP80Wl/xmEXsl7e+MlWg7gtlMAuQryI9OLEtq6DzETgoJtfz4M/', `SecurityStamp` = 'user_2_63ed@example.com', `UserName` = 'user_2_63ed'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_1eff@example.com', `Email` = 'user_3_1eff@example.com', `NormalizedEmail` = 'USER_3_1EFF@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_1EFF', `PasswordHash` = 'i8NWrIFZ+hgGiMU7voUidl75lpOO2z6+KkklGHLO1Js8qMbnCAMq6m+rm//P3To1', `SecurityStamp` = 'user_3_1eff@example.com', `UserName` = 'user_3_1eff'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_9124@example.com', `Email` = 'user_4_9124@example.com', `NormalizedEmail` = 'USER_4_9124@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_9124', `PasswordHash` = 'S7bP0CshkVSN4wUPUtVIXzID9b9eRKSpfnxQ6OX0BXH9rbTtBspe3BPG21zqLilh', `SecurityStamp` = 'user_4_9124@example.com', `UserName` = 'user_4_9124'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_ff48@example.com', `Email` = 'user_5_ff48@example.com', `NormalizedEmail` = 'USER_5_FF48@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_FF48', `PasswordHash` = 'IpNA2IavuHoyJcGBeQRrROklpchpEegIlI9H2DhFVKe4aOsN0RXBqjktGRE/Ahhm', `SecurityStamp` = 'user_5_ff48@example.com', `UserName` = 'user_5_ff48'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_f526@example.com', `Email` = 'user_6_f526@example.com', `NormalizedEmail` = 'USER_6_F526@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_F526', `PasswordHash` = '6NkRjJ34LN/4xkyhqK7y8K4g8NuBoKyMTT2nnxCM8lMphDa6o4ZQfl48SkL+4Yg3', `SecurityStamp` = 'user_6_f526@example.com', `UserName` = 'user_6_f526'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_c7d9@example.com', `Email` = 'user_7_c7d9@example.com', `NormalizedEmail` = 'USER_7_C7D9@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_C7D9', `PasswordHash` = 'ljfd1BZUr0Ox8ryVx0U7U/KS6OnA4SkXKPkfN++9GnrbDz93Yv6QayGR2IuGzkMc', `SecurityStamp` = 'user_7_c7d9@example.com', `UserName` = 'user_7_c7d9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_9184@example.com', `Email` = 'user_8_9184@example.com', `NormalizedEmail` = 'USER_8_9184@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_9184', `PasswordHash` = 'A+dO3V7uq7KQ3a84JLLwlwIR1opqIHdgn4A0I1poAYTGyDyv4AebcrseVwt67NDv', `SecurityStamp` = 'user_8_9184@example.com', `UserName` = 'user_8_9184'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_808c@example.com', `Email` = 'user_9_808c@example.com', `NormalizedEmail` = 'USER_9_808C@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_808C', `PasswordHash` = 'wdtKT+9+HUz1LiIQU0e8QWN3mu7bGhYOI+ZQLIYCLBDvacUKLCY0eI2ywMdXgMDT', `SecurityStamp` = 'user_9_808c@example.com', `UserName` = 'user_9_808c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_9622@example.com', `Email` = 'user_10_9622@example.com', `NormalizedEmail` = 'USER_10_9622@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_9622', `PasswordHash` = 'ehiHObHvY/dXgaWYZSNNDr26zKdiQ92k8bKm0VbNHZpzb7xxE9fpy0Y1VquwYCwi', `SecurityStamp` = 'user_10_9622@example.com', `UserName` = 'user_10_9622'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_0698@example.com', `Email` = 'user_11_0698@example.com', `NormalizedEmail` = 'USER_11_0698@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_0698', `PasswordHash` = 'zwV0Q7/9ikATRH+3CTgGvQB3QeWISKuH0S+Opzz8NNgaNL41yKG/YVplsLh+56l9', `SecurityStamp` = 'user_11_0698@example.com', `UserName` = 'user_11_0698'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_296c@example.com', `Email` = 'user_12_296c@example.com', `NormalizedEmail` = 'USER_12_296C@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_296C', `PasswordHash` = 'ct5u55MUgw8WVvujMGxfECRKmt6JDKisOP20AeK46cp34N/Pfev7G1eG0OU7KAMi', `SecurityStamp` = 'user_12_296c@example.com', `UserName` = 'user_12_296c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_f9fb@example.com', `Email` = 'user_13_f9fb@example.com', `NormalizedEmail` = 'USER_13_F9FB@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_F9FB', `PasswordHash` = 'NYNwELuPAJwQmCvO1w3JFGnSBaPN9xfHqlFx8dvQgvHS2qJ+Uf1fjE6KO8dgjqND', `SecurityStamp` = 'user_13_f9fb@example.com', `UserName` = 'user_13_f9fb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_e418@example.com', `Email` = 'user_14_e418@example.com', `NormalizedEmail` = 'USER_14_E418@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_E418', `PasswordHash` = 'BKmBA2vQQduGBMa1saxeeTi1GlI/AILYhi40i3t3LfJeR1MX72hRYAaedGAaLZ5y', `SecurityStamp` = 'user_14_e418@example.com', `UserName` = 'user_14_e418'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_a52f@example.com', `Email` = 'user_15_a52f@example.com', `NormalizedEmail` = 'USER_15_A52F@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_A52F', `PasswordHash` = 'u2XZ4FgevC3uD+jLd8BqZ+/w4iT3OtED1jDvhY1Qd0r2ORQzD98TO/6UKc5EUvxs', `SecurityStamp` = 'user_15_a52f@example.com', `UserName` = 'user_15_a52f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_8a7d@example.com', `Email` = 'user_16_8a7d@example.com', `NormalizedEmail` = 'USER_16_8A7D@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_8A7D', `PasswordHash` = 'PHBRpOCuHv8anskDvpWMwY2f8zyD61PlxqksK5Znx4o8fQynfsNkhS0vosa9UAI9', `SecurityStamp` = 'user_16_8a7d@example.com', `UserName` = 'user_16_8a7d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_026f@example.com', `Email` = 'user_17_026f@example.com', `NormalizedEmail` = 'USER_17_026F@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_026F', `PasswordHash` = 'JpyajlZf1trKld8qXw2y1F4qfME2Elx3YQa8CTtLv68aiBeAFlHyoe6M45CpN/S6', `SecurityStamp` = 'user_17_026f@example.com', `UserName` = 'user_17_026f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_fd9c@example.com', `Email` = 'user_18_fd9c@example.com', `NormalizedEmail` = 'USER_18_FD9C@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_FD9C', `PasswordHash` = '4AbtG7jlTnWB1byMkDtuUJEdhhfsSFsAO+DngKakx+BIzsvsYOH9iS4AOxisNEhR', `SecurityStamp` = 'user_18_fd9c@example.com', `UserName` = 'user_18_fd9c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_acb8@example.com', `Email` = 'user_19_acb8@example.com', `NormalizedEmail` = 'USER_19_ACB8@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_ACB8', `PasswordHash` = 'tp1n2tgKl6wqhe96RUqrCvn2KBnE2lco4aa/DF8l1CUXo5oM3Bn+6kxBMpls6fPE', `SecurityStamp` = 'user_19_acb8@example.com', `UserName` = 'user_19_acb8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_a2c1@example.com', `Email` = 'user_20_a2c1@example.com', `NormalizedEmail` = 'USER_20_A2C1@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_A2C1', `PasswordHash` = 'LgGhSLpBenbNOqT19mjqilc9voogZSuQU1TyP3rIwWM3yv8sRujEs91Ip1bMHKlA', `SecurityStamp` = 'user_20_a2c1@example.com', `UserName` = 'user_20_a2c1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_f856@example.com', `Email` = 'user_21_f856@example.com', `NormalizedEmail` = 'USER_21_F856@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_F856', `PasswordHash` = 'EQY/iCqAJ0LCE7pWOH0UGxq0iBrShWFiYdMFlMul2E3ZSM6v0NgkvMAzvq/Fg/fu', `SecurityStamp` = 'user_21_f856@example.com', `UserName` = 'user_21_f856'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_a61a@example.com', `Email` = 'user_22_a61a@example.com', `NormalizedEmail` = 'USER_22_A61A@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_A61A', `PasswordHash` = 'joBDC7wwgnMFpvfenoCZvqaR2tBHiWkuXL1WeYGXfPzmgfHf3blMrcaBclCQ6nDA', `SecurityStamp` = 'user_22_a61a@example.com', `UserName` = 'user_22_a61a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_8de4@example.com', `Email` = 'user_23_8de4@example.com', `NormalizedEmail` = 'USER_23_8DE4@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_8DE4', `PasswordHash` = 'vFJwbYXIOAuCm0Tk+eTz3Y/a0tsdYG4SNwTZkfpBK0J0ncH8xdDbjBP+47wYm99c', `SecurityStamp` = 'user_23_8de4@example.com', `UserName` = 'user_23_8de4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_76cc@example.com', `Email` = 'user_24_76cc@example.com', `NormalizedEmail` = 'USER_24_76CC@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_76CC', `PasswordHash` = '0jPBWYPCsOiVyFnE9DhW1MEFWvRLqyfUonmZVTeHdY7HuA8gYg0e45PILNgPuCLK', `SecurityStamp` = 'user_24_76cc@example.com', `UserName` = 'user_24_76cc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_830b@example.com', `Email` = 'user_25_830b@example.com', `NormalizedEmail` = 'USER_25_830B@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_830B', `PasswordHash` = 'ktW/6+x/1E1llyrUaTwYpnn/ZvgIfYicruC/Zb4os3Mr1hsaqwI1+2AN5ldpABQt', `SecurityStamp` = 'user_25_830b@example.com', `UserName` = 'user_25_830b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_55d4@example.com', `Email` = 'user_26_55d4@example.com', `NormalizedEmail` = 'USER_26_55D4@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_55D4', `PasswordHash` = 'GqFP42J2PFzYsJ5ieOsMI/tnPmaKWg/qoFvh/SyYc0vna9ZdwSpMBH3HcuVhVlxn', `SecurityStamp` = 'user_26_55d4@example.com', `UserName` = 'user_26_55d4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_d9b6@example.com', `Email` = 'user_27_d9b6@example.com', `NormalizedEmail` = 'USER_27_D9B6@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_D9B6', `PasswordHash` = 'wyVk6cWxeRXjXvhYED6NMC0klW5e2PuEuqBe654r94bJN2ytwtoGBfrbYwRg6nfT', `SecurityStamp` = 'user_27_d9b6@example.com', `UserName` = 'user_27_d9b6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_a2fc@example.com', `Email` = 'user_28_a2fc@example.com', `NormalizedEmail` = 'USER_28_A2FC@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_A2FC', `PasswordHash` = '8BXpbXAVZ9iC1ZP2D99NMDymYmp2tFiY5l/+OB5JzqIz6rI/pUhZeN4nVCLQe40l', `SecurityStamp` = 'user_28_a2fc@example.com', `UserName` = 'user_28_a2fc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_c4fc@example.com', `Email` = 'user_29_c4fc@example.com', `NormalizedEmail` = 'USER_29_C4FC@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_C4FC', `PasswordHash` = 'Xiry4OyeEV+w3kSC0TmcHNtB1PB12DgQih1/bBXDstfLpbK68Oo8XRKqXpNTTEXo', `SecurityStamp` = 'user_29_c4fc@example.com', `UserName` = 'user_29_c4fc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_5e1b@example.com', `Email` = 'user_30_5e1b@example.com', `NormalizedEmail` = 'USER_30_5E1B@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_5E1B', `PasswordHash` = 'vOFEQsA+vbqTKR0WGCTy0MrCiAn66KV0lqUCMD2gMPDbSG8b2uLZaxDcoiVKMZ+f', `SecurityStamp` = 'user_30_5e1b@example.com', `UserName` = 'user_30_5e1b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_cc28@example.com', `Email` = 'user_31_cc28@example.com', `NormalizedEmail` = 'USER_31_CC28@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_CC28', `PasswordHash` = 'WvBQ0jDscxaH7GbWLhu5zxZvO8pxh8whsvq1Wkfk1/H3e6QpjQ35a0rXwt611/V4', `SecurityStamp` = 'user_31_cc28@example.com', `UserName` = 'user_31_cc28'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_52d4@example.com', `Email` = 'user_32_52d4@example.com', `NormalizedEmail` = 'USER_32_52D4@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_52D4', `PasswordHash` = 'AmNMM85AebM5YU8/KkRdyYuT2zN6CbKkbEeO9/J59GWesnxDmRhoxXb4hCbslIWi', `SecurityStamp` = 'user_32_52d4@example.com', `UserName` = 'user_32_52d4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_bc39@example.com', `Email` = 'user_33_bc39@example.com', `NormalizedEmail` = 'USER_33_BC39@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_BC39', `PasswordHash` = 'LYjGwGnBbcUENYvdKv5GidphkPSnBZMII4ej6JOkXguMOnL3xqvDSsoDu4IxL1li', `SecurityStamp` = 'user_33_bc39@example.com', `UserName` = 'user_33_bc39'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_0042@example.com', `Email` = 'user_34_0042@example.com', `NormalizedEmail` = 'USER_34_0042@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_0042', `PasswordHash` = '/lFsFeGAWVnTqMcCXXyLLa/Obnp1MjFCTY9aDCad88E6uu4swhhFCcX0SgEGR1u9', `SecurityStamp` = 'user_34_0042@example.com', `UserName` = 'user_34_0042'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_85bb@example.com', `Email` = 'user_35_85bb@example.com', `NormalizedEmail` = 'USER_35_85BB@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_85BB', `PasswordHash` = 'EeOZzm2qxpr76GOvVznXDXfi7PGD1x3PMo2WPRrJUtN5oepj//6P5OkMqut14z6m', `SecurityStamp` = 'user_35_85bb@example.com', `UserName` = 'user_35_85bb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_6c7f@example.com', `Email` = 'user_36_6c7f@example.com', `NormalizedEmail` = 'USER_36_6C7F@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_6C7F', `PasswordHash` = 'xBjyEPQ0lo3qsJXX4DCm4mq/G0qume2Q35wfrRUqJh6nDyfF/7sKBd5ZV0aBg6z0', `SecurityStamp` = 'user_36_6c7f@example.com', `UserName` = 'user_36_6c7f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_1851@example.com', `Email` = 'user_37_1851@example.com', `NormalizedEmail` = 'USER_37_1851@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_1851', `PasswordHash` = 'lsA2WAk8pxR0vSHjRKciso/LEsYGmlo2GC/WV9qGs6xpLNJIhjFA5ZC+T/zMDvLp', `SecurityStamp` = 'user_37_1851@example.com', `UserName` = 'user_37_1851'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_f47e@example.com', `Email` = 'user_38_f47e@example.com', `NormalizedEmail` = 'USER_38_F47E@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_F47E', `PasswordHash` = 'w6IsanUKdNYmZ5HZUUs8KUs/tHufRSjoeZcC5WsLKvSzm5/LC+kAIO6s8LY50NqW', `SecurityStamp` = 'user_38_f47e@example.com', `UserName` = 'user_38_f47e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_afb4@example.com', `Email` = 'user_39_afb4@example.com', `NormalizedEmail` = 'USER_39_AFB4@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_AFB4', `PasswordHash` = 'XhrkWH7jzAS7VCgaGqQEDTdZhbmldPQ2QarUBNnSVSFBo+mHb6gwBwlQdncMEIXR', `SecurityStamp` = 'user_39_afb4@example.com', `UserName` = 'user_39_afb4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_2855@example.com', `Email` = 'user_40_2855@example.com', `NormalizedEmail` = 'USER_40_2855@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_2855', `PasswordHash` = 'yaq4C1ywuiY7MyIW/oyo7icmXk8NsxhOEerRMbrk9kIcSu4qtmgumoJU2XPsu1j9', `SecurityStamp` = 'user_40_2855@example.com', `UserName` = 'user_40_2855'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_c21a@example.com', `Email` = 'user_41_c21a@example.com', `NormalizedEmail` = 'USER_41_C21A@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_C21A', `PasswordHash` = 'u8MC0iY8lpviuK9bzOn+j8pDIPcaZ/RlsDgucpNHa3V3q9LDPceiYxbitVlGevvt', `SecurityStamp` = 'user_41_c21a@example.com', `UserName` = 'user_41_c21a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_143f@example.com', `Email` = 'user_42_143f@example.com', `NormalizedEmail` = 'USER_42_143F@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_143F', `PasswordHash` = 'Hhz3mACB7FM+95PDFWkoIPZ03dqhmWYGDNkRnYMIQGBu10MbjO0XCVYSii6Pn52W', `SecurityStamp` = 'user_42_143f@example.com', `UserName` = 'user_42_143f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_55f6@example.com', `Email` = 'user_43_55f6@example.com', `NormalizedEmail` = 'USER_43_55F6@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_55F6', `PasswordHash` = 'P12qpCXHdCOw3Lhud9IOv9wW663PhbiOl0ByzFbjZNEbZjTD8DWGb+EBbkH6GKNI', `SecurityStamp` = 'user_43_55f6@example.com', `UserName` = 'user_43_55f6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_791b@example.com', `Email` = 'user_44_791b@example.com', `NormalizedEmail` = 'USER_44_791B@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_791B', `PasswordHash` = '8P1W1dNa+Ax6DBwOa7UQOWFOme6IqzgiJ176Yun9SWLogM3yOfbjma8lx/vNRbkE', `SecurityStamp` = 'user_44_791b@example.com', `UserName` = 'user_44_791b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_8816@example.com', `Email` = 'user_45_8816@example.com', `NormalizedEmail` = 'USER_45_8816@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_8816', `PasswordHash` = 'B2857LaaPMEJGApBl0VXcvi47cFglVd8yQl/UJuL4ad4E/jqxMksFGbW1aaGojXJ', `SecurityStamp` = 'user_45_8816@example.com', `UserName` = 'user_45_8816'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_3e26@example.com', `Email` = 'user_46_3e26@example.com', `NormalizedEmail` = 'USER_46_3E26@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_3E26', `PasswordHash` = '8oA5ppxM8DieKvAVeHmX9oxErHHIq9YZv6Y3RSVhlQkjy2UmWUNJJesFmzMvlTtT', `SecurityStamp` = 'user_46_3e26@example.com', `UserName` = 'user_46_3e26'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_2433@example.com', `Email` = 'user_47_2433@example.com', `NormalizedEmail` = 'USER_47_2433@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_2433', `PasswordHash` = 'XP5Ws2H13sK25F07DZBewLTn+u12XJyJVGHey+v4CsrMFHyyEjx2L/pYPhDn0hus', `SecurityStamp` = 'user_47_2433@example.com', `UserName` = 'user_47_2433'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_7f54@example.com', `Email` = 'user_48_7f54@example.com', `NormalizedEmail` = 'USER_48_7F54@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_7F54', `PasswordHash` = '1gYq+MQTetU2diGnw9xu/yCtnH66ROphQQ9Q3y6xPoMJKHnD/0a4D4tBmK30UpLC', `SecurityStamp` = 'user_48_7f54@example.com', `UserName` = 'user_48_7f54'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_d7e3@example.com', `Email` = 'user_49_d7e3@example.com', `NormalizedEmail` = 'USER_49_D7E3@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_D7E3', `PasswordHash` = '1Eq/pAI636DiQ6P/1Qxqz8JuKnQFbduqZiDv2CJdB/6nRGBw0ai6l1KsQLIayS82', `SecurityStamp` = 'user_49_d7e3@example.com', `UserName` = 'user_49_d7e3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_d1dd@example.com', `Email` = 'user_50_d1dd@example.com', `NormalizedEmail` = 'USER_50_D1DD@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_D1DD', `PasswordHash` = 'izZxtxbMJslA5bkduDlQpO/rLcmKud8qRyfirliDMiFavN6dRjP6vbZCjvIJ7Tit', `SecurityStamp` = 'user_50_d1dd@example.com', `UserName` = 'user_50_d1dd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = '2ouKwvSi01ZRN7tnLmHuC5wyHdKDCLRcnVU2ebjqZ6htvYEihjjkcKrh5WiN0/tz'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250313212953_visitorlogsAdded', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '14cac200-35a8-4508-9c99-3b83f8a51584';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '2226c1b1-eaf2-4fe1-818b-9b9d6d42f64d';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '24affc02-6467-4117-8fcb-772c8663e769';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3fce737c-cc6c-4865-973b-b84aa6a2ffc8';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '56d4d203-463c-4118-87b4-bef96611e3e2';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '57d7d1b2-91c2-4a71-b447-abe761ad9602';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6360cf47-6b3d-4909-857c-4c84ece7aefb';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'ae5b2500-f175-46ae-89fa-33624ff428c1';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c9625c88-129d-4add-9ef3-c5fa71916909';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f418d13c-91b3-4944-aba4-71789fa9f78a';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '05adbd79-ca57-4670-b1f4-4097e44e2c7d';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '2a1bad9b-37a7-4636-bc22-3c49909f502e';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'c72b6a81-5fdc-4e1d-9e84-1243beae6a7f';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'e0228447-83ae-4401-8d40-6650fb313e4c';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '099ed36c-374c-453a-bdb9-e4d24757c001';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '42c9d93e-e77d-4b86-8300-57f82ec25f21';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'a59fecc4-d2ad-4c5b-9200-ee13679f82eb';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'e68efa96-0d18-456b-80b6-2a34a4724b81';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '0ef27efd-fdbe-4044-b663-afe8dd2c694b';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '31f54852-828e-499b-b2ba-f0cd46eb4b80';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '8fd817f1-c1ce-4a85-ab5f-f95d7f30ee87';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '9d8a275a-da27-46a1-8c71-ed6e5ced45a1';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'a63f9e0b-a700-4181-94bc-1a5a0b7db87d';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'e91d2b1d-ada0-4183-833a-017c87609671';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '94ca0401-5ef4-42f9-842e-22f45f345acf';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '064d0c37-b74b-4da5-9d37-94228b0ac0ff';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '09b85713-39c9-4e14-b808-2a04790091bf';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '54d2e64c-69df-4ebc-b9ff-02ee717503ab';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '61951454-bc35-4258-8ccd-ae1fbc7b86f2';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b33c1c73-8f9e-4b9f-80fc-c383d3deb054';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'db9d4744-a57e-4417-8db3-24bbb3d28fed';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '3f224bf0-934c-4bf3-9e50-bbd9c02438a7';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'c0191c90-75b6-468f-89d9-a54493a59510';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'f42a31d9-fb90-4b88-81de-0826fa711d69';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'fdd3d14f-7492-4bd5-9a20-bce4e6e7cb47';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '0d22fc87-8e0c-4fb0-a578-99b701d6a64c';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '2039c46e-33b8-4ff7-829d-c6d68341047a';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '27331e4f-da42-46b9-bd11-6994c8e50a39';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '3a3518cb-cc9e-4d13-a237-902b2ef33e0a';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '866f3732-d04a-41a3-8589-818a050cd693';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '1b7cde9b-14a5-4425-abb4-e4ac5833555e';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '980cb001-8867-43fe-8400-596ffd30f4f4';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'd07c3776-e3b6-435d-aace-761c6226f2a2';
SELECT ROW_COUNT();


INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('031c1f64-7f45-4c21-a34c-f030fe9f3c2e', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('03474e38-8728-4f82-833c-7ce6ff178b68', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('1898bf28-f229-41d7-abc1-3bdbe79be147', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('472da88f-ede0-404f-8ccf-5eb42a74cf65', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('7c0804ea-70f3-43ca-8a27-b807b8d2a649', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('9f522f71-cb71-4f02-8fe2-a6201caed6d7', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('acaebef8-96ac-47df-850a-3c7040f4264c', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('bef0cd91-8ff4-4075-bd62-20144192b8f9', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('f2d1477d-0831-4246-8de5-22c31198e7d8', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('f3d4ac90-7cf3-4877-8ff2-83aafd003118', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('010d6d03-cb7b-4247-bdf2-e03313519348', 'CHF', TIMESTAMP '2025-03-13 21:34:00', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('6b3b6dc2-0ecb-4693-b3c5-6b6b4aaff3b6', 'USD', TIMESTAMP '2025-03-13 21:34:00', 2, TRUE, 'US Dollar', '$', NULL),
('7ca5880b-7431-4e80-991b-b3849291d8bc', 'GBP', TIMESTAMP '2025-03-13 21:34:00', 2, TRUE, 'British Pound', '£', NULL),
('c62e64f2-60ed-4b5f-8d10-bf9802303f16', 'EUR', TIMESTAMP '2025-03-13 21:34:00', 2, TRUE, 'Euro', '€', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('259502f3-26ba-4243-a515-86721a8588cf', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('996a157a-976f-408b-9ccf-7e12bdb85842', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('9ff7cab2-5295-457f-9d63-220894d4080c', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('f937b5ed-18b6-4178-bc3a-250a602a1d14', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('06922cfa-6028-40e3-9e87-81f4fc1cc973', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('423efa55-3ed8-48f8-a7d4-7615cb4fb6dc', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('6a897abb-dc36-47aa-be89-9b07580e48e0', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('70ac574e-128d-4c92-b27c-6fa9bf691dd5', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('73762a70-3c1f-4429-9cbd-b060cf728cbe', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL),
('ab99ec60-0a9a-494a-8374-814cbeee00e3', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('940dfd58-2978-41c3-ae37-cd2c4cc6b663', TIMESTAMP '2025-03-13 21:34:00', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('4e5204a0-2c04-49d6-8421-fc5cb80a8132', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('548ee064-91f0-4dda-903f-35f96223def2', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('5eb381e5-fe51-4cf5-ac88-cd709c501eca', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('a27e164f-b4cf-43ba-8585-2b7087c2d444', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('de27bb02-b815-43fc-a63f-d5c80d5003a2', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('fc78ed11-4747-4781-bf60-27aa23e59189', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('060f9e2b-32e1-42fc-915d-d5a59b522bfa', NULL, TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('6849dce3-bca7-4792-b9eb-2c2e1baada99', NULL, TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('7c3f650d-2ef1-4add-a598-5b2ee53ea53b', NULL, TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL),
('b1e5c608-a6cc-469b-93a4-96935026a792', NULL, TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('1bdf4e21-72d2-4c71-b7f9-61e818cb4291', TIMESTAMP '2025-03-13 21:34:00', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('4c561244-ee15-468f-a055-39f9dc1f8d44', TIMESTAMP '2025-03-13 21:34:00', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('99ef6acf-2793-4a6b-b8ec-44d35ae22a96', TIMESTAMP '2025-03-13 21:34:00', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('c9ac0ae6-34fb-4a6d-8071-d8e7c0c69962', TIMESTAMP '2025-03-13 21:34:00', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('ee02a935-f89b-4441-b8da-e6ebf5bec34b', TIMESTAMP '2025-03-13 21:34:00', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-13 21:34:00'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('5a5f5edf-c01f-4773-a560-b433fcff49bc', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('980a2257-c668-468f-a986-1341ca929f2d', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('9d542454-6692-40bf-ac29-dd96762d7ffc', TIMESTAMP '2025-03-13 21:34:00', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'BGFJz7sMDSxAbG2xRynLk0a69Y/VYesYorcQSrDrc6+/xfeowLQ4SHFeacpj0y4p'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'v5OqLRm8nQ5w0J5j4JtQFD5PVk6OUFOXEBhfy8JuHwPqhEnxp4MeyEpyPD80KVUz'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_d805@example.com', `Email` = 'user_1_d805@example.com', `NormalizedEmail` = 'USER_1_D805@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_D805', `PasswordHash` = 'hlKtlTWGxUiCXlJ17ZtkqLL0RYiVuV0bdCUQMTeTz1kyP5Ldy4a0sheJHhp+qOVU', `SecurityStamp` = 'user_1_d805@example.com', `UserName` = 'user_1_d805'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_38e6@example.com', `Email` = 'user_2_38e6@example.com', `NormalizedEmail` = 'USER_2_38E6@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_38E6', `PasswordHash` = 'n2aAU3F8vY1fDbwC/go3cfpkRGk5uimC8QFZwGEcCou+GXY2qqPXGzntEbolkI/S', `SecurityStamp` = 'user_2_38e6@example.com', `UserName` = 'user_2_38e6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_4514@example.com', `Email` = 'user_3_4514@example.com', `NormalizedEmail` = 'USER_3_4514@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_4514', `PasswordHash` = 'xfzgirWT9h5t3WvfcTLEMX02UCKMuVuKvsDuhEmHl6KZFPH18CD/H5JtjOMhliyc', `SecurityStamp` = 'user_3_4514@example.com', `UserName` = 'user_3_4514'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_f6cb@example.com', `Email` = 'user_4_f6cb@example.com', `NormalizedEmail` = 'USER_4_F6CB@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_F6CB', `PasswordHash` = 'sjmGUeSm6G6ZtGZSsKGztgJLP6WHUI5lBAUnucu/80vv2KldcK0NavjkHA7fcOvJ', `SecurityStamp` = 'user_4_f6cb@example.com', `UserName` = 'user_4_f6cb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_f3b1@example.com', `Email` = 'user_5_f3b1@example.com', `NormalizedEmail` = 'USER_5_F3B1@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_F3B1', `PasswordHash` = 'ipnSzmxxiyTOWDG1LvF767Rc0yViP1vVlOzTKonHsQCPSrOIh139mnZKYkjI+Euu', `SecurityStamp` = 'user_5_f3b1@example.com', `UserName` = 'user_5_f3b1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_2f52@example.com', `Email` = 'user_6_2f52@example.com', `NormalizedEmail` = 'USER_6_2F52@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_2F52', `PasswordHash` = 'yxMiK6XnZG9mvMzSL21ygUSOelneg9qyigEWaiAXZhotY8kJ08cwR+k5Bg8WAGrG', `SecurityStamp` = 'user_6_2f52@example.com', `UserName` = 'user_6_2f52'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_7e4f@example.com', `Email` = 'user_7_7e4f@example.com', `NormalizedEmail` = 'USER_7_7E4F@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_7E4F', `PasswordHash` = 'FIxKSeGYfcHxg1e93F/rMFU6vZA51CM4euKqY6m7K9VZmOgZe2zBWfNt3YH2gh9K', `SecurityStamp` = 'user_7_7e4f@example.com', `UserName` = 'user_7_7e4f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_2d8e@example.com', `Email` = 'user_8_2d8e@example.com', `NormalizedEmail` = 'USER_8_2D8E@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_2D8E', `PasswordHash` = 'E1ePPz9sbE6MRaYli4RoBdJACAdnaQy485KKIwWKWTOLA+hN0T8ahk3+UWreKJ+L', `SecurityStamp` = 'user_8_2d8e@example.com', `UserName` = 'user_8_2d8e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_a1f7@example.com', `Email` = 'user_9_a1f7@example.com', `NormalizedEmail` = 'USER_9_A1F7@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_A1F7', `PasswordHash` = 'SjBDY/R02e8MWUY2bQd9XC9GiGhT4ZPl1BvH5XKNE6YCrzUyXAaQOAOaC3Rj6Md4', `SecurityStamp` = 'user_9_a1f7@example.com', `UserName` = 'user_9_a1f7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_c8b7@example.com', `Email` = 'user_10_c8b7@example.com', `NormalizedEmail` = 'USER_10_C8B7@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_C8B7', `PasswordHash` = 'rOgr+lpkH7I5HehW79zUYgZiBwtA4ufhbS73lcNTxJoQmCkuoJadg94bncyoGsIE', `SecurityStamp` = 'user_10_c8b7@example.com', `UserName` = 'user_10_c8b7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_babb@example.com', `Email` = 'user_11_babb@example.com', `NormalizedEmail` = 'USER_11_BABB@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_BABB', `PasswordHash` = 'eHcC09FhpGmT9d5Rq46G6z2q2qPbpOI5+AtOADR/3Tusc0FMfOGfJhT4CcpQlztS', `SecurityStamp` = 'user_11_babb@example.com', `UserName` = 'user_11_babb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_8653@example.com', `Email` = 'user_12_8653@example.com', `NormalizedEmail` = 'USER_12_8653@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_8653', `PasswordHash` = 'YU2h0AwrXE8IqpE8+XtBXIt6SUQnq7yzfXQtECyug9X0bOLAWu8UxvPppuionXdY', `SecurityStamp` = 'user_12_8653@example.com', `UserName` = 'user_12_8653'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_2d79@example.com', `Email` = 'user_13_2d79@example.com', `NormalizedEmail` = 'USER_13_2D79@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_2D79', `PasswordHash` = '1sy3OqMQCHxBEoT5HLs367nIgs1hNySi/bpo/z/UVlhG/eN0zbgNkz0n+17cy6SS', `SecurityStamp` = 'user_13_2d79@example.com', `UserName` = 'user_13_2d79'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_3fd1@example.com', `Email` = 'user_14_3fd1@example.com', `NormalizedEmail` = 'USER_14_3FD1@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_3FD1', `PasswordHash` = '8jkLBzN04SXSwPsJ/XTusLa11EA5Tcl6dgu3KWvF+01QYK8L2zFWxHOVehvYlBCp', `SecurityStamp` = 'user_14_3fd1@example.com', `UserName` = 'user_14_3fd1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_ac60@example.com', `Email` = 'user_15_ac60@example.com', `NormalizedEmail` = 'USER_15_AC60@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_AC60', `PasswordHash` = 'yPk/FmgmtNkxnCPV4qW+3vnBnTOYm9UjqJYKK2wnpSgwXoryvGTyWMuHPZT8ftxY', `SecurityStamp` = 'user_15_ac60@example.com', `UserName` = 'user_15_ac60'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_0b82@example.com', `Email` = 'user_16_0b82@example.com', `NormalizedEmail` = 'USER_16_0B82@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_0B82', `PasswordHash` = 'KCUYYzWye5NoJlj/BS6gIwkgMhE8uwSVXZaSGEQ2WgaRJj5mjARnuxmMXDFkmidH', `SecurityStamp` = 'user_16_0b82@example.com', `UserName` = 'user_16_0b82'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_1133@example.com', `Email` = 'user_17_1133@example.com', `NormalizedEmail` = 'USER_17_1133@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_1133', `PasswordHash` = 'YAPgPx+bz2TPg7zpd62sJug9Fch83CXS19UyJ1+qF9dLr+sg38JxmoigqS7VvkAL', `SecurityStamp` = 'user_17_1133@example.com', `UserName` = 'user_17_1133'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_1ce4@example.com', `Email` = 'user_18_1ce4@example.com', `NormalizedEmail` = 'USER_18_1CE4@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_1CE4', `PasswordHash` = 'BTqQpAIKwlt/a4bkmfNJ+olhCXtoN++//44EjiCq8Zg2cUiO2FSQ8pZu2FdP4Dlv', `SecurityStamp` = 'user_18_1ce4@example.com', `UserName` = 'user_18_1ce4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_96f1@example.com', `Email` = 'user_19_96f1@example.com', `NormalizedEmail` = 'USER_19_96F1@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_96F1', `PasswordHash` = 'ucctA8svbs2b9gzAjGQIpclVSs8jEL21VGGL3f4Tjp2fonzUwvscfzXxndivvm4z', `SecurityStamp` = 'user_19_96f1@example.com', `UserName` = 'user_19_96f1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_76b7@example.com', `Email` = 'user_20_76b7@example.com', `NormalizedEmail` = 'USER_20_76B7@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_76B7', `PasswordHash` = 'IlHpylLc0SKFDcnD5We3vDHt4Ulpo+U83Ca292Plec5TyXKfKFWgkvs8zFegBtTJ', `SecurityStamp` = 'user_20_76b7@example.com', `UserName` = 'user_20_76b7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_a21c@example.com', `Email` = 'user_21_a21c@example.com', `NormalizedEmail` = 'USER_21_A21C@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_A21C', `PasswordHash` = '7fhxr/gxJr4swMiessOYL5jP2hO8zJJ4j7Y33ivZ4ATSY68RsXLiXg9Kjgfnpf2a', `SecurityStamp` = 'user_21_a21c@example.com', `UserName` = 'user_21_a21c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_2b6c@example.com', `Email` = 'user_22_2b6c@example.com', `NormalizedEmail` = 'USER_22_2B6C@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_2B6C', `PasswordHash` = 'm7xXVBS5ey1/2gGJtvg8pwUVekRvBRDh3wEhn5FRxNljtr/eIBVz7W7c8smBH7uM', `SecurityStamp` = 'user_22_2b6c@example.com', `UserName` = 'user_22_2b6c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_646a@example.com', `Email` = 'user_23_646a@example.com', `NormalizedEmail` = 'USER_23_646A@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_646A', `PasswordHash` = 'tPIE3f2nSXHfpd6xjwXEo5ZrpLkqdvDsB1V2UhR6XC3kGU9BzVcY31jjGxjiyVS5', `SecurityStamp` = 'user_23_646a@example.com', `UserName` = 'user_23_646a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_ee59@example.com', `Email` = 'user_24_ee59@example.com', `NormalizedEmail` = 'USER_24_EE59@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_EE59', `PasswordHash` = 'prs0lgKrJbZBs/H/z7EcCkFgpgbD3v7aaCvV8p7iN3vHXygBcrjc+Lw9GcwBTfww', `SecurityStamp` = 'user_24_ee59@example.com', `UserName` = 'user_24_ee59'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_42a4@example.com', `Email` = 'user_25_42a4@example.com', `NormalizedEmail` = 'USER_25_42A4@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_42A4', `PasswordHash` = 'JzvUfmt12ax+iuuWu40zcG4mahZua4KT/+pyb81P4lIb2KM1OsnUW53jotckQsIJ', `SecurityStamp` = 'user_25_42a4@example.com', `UserName` = 'user_25_42a4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_d1f4@example.com', `Email` = 'user_26_d1f4@example.com', `NormalizedEmail` = 'USER_26_D1F4@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_D1F4', `PasswordHash` = 'OmsXtL21wAWA/p/P/ldYVzNnxt+CSNA2gzFEJHbrt5bffEH2COWzvb7KFEKKYf12', `SecurityStamp` = 'user_26_d1f4@example.com', `UserName` = 'user_26_d1f4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_db02@example.com', `Email` = 'user_27_db02@example.com', `NormalizedEmail` = 'USER_27_DB02@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_DB02', `PasswordHash` = 'LBFGQyMDHEJQutcLXLuLBQRltwvnfL21jQiOZfeiIkxrrb0dG7JA23SQ3cEQl/FY', `SecurityStamp` = 'user_27_db02@example.com', `UserName` = 'user_27_db02'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_ec21@example.com', `Email` = 'user_28_ec21@example.com', `NormalizedEmail` = 'USER_28_EC21@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_EC21', `PasswordHash` = 'BI27jdM3THGOhAIXbTA1mZ1j7Y2JEOzmiqqnMdSkoyU16QmC0Mfxm3Dffos0vjL7', `SecurityStamp` = 'user_28_ec21@example.com', `UserName` = 'user_28_ec21'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_79bc@example.com', `Email` = 'user_29_79bc@example.com', `NormalizedEmail` = 'USER_29_79BC@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_79BC', `PasswordHash` = 'gUZtjqK5/8r3tFJhiJyt2A56ZuCdPNqw4oNCJYCTlzF4IkMEQfWObHUceuC5MnTu', `SecurityStamp` = 'user_29_79bc@example.com', `UserName` = 'user_29_79bc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_817b@example.com', `Email` = 'user_30_817b@example.com', `NormalizedEmail` = 'USER_30_817B@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_817B', `PasswordHash` = 'W2pZ2erelZP2lDXglZBB5xa83baD/oFfXane+1K3euBfGCpPmaFOmZL0i4YH0YtZ', `SecurityStamp` = 'user_30_817b@example.com', `UserName` = 'user_30_817b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_ce67@example.com', `Email` = 'user_31_ce67@example.com', `NormalizedEmail` = 'USER_31_CE67@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_CE67', `PasswordHash` = 'Rr5MtWa+LJFor4V8kbVXgKbCy3fchRaYH16s6xmR2d173WGhLg7si/2qqQ2HoPYs', `SecurityStamp` = 'user_31_ce67@example.com', `UserName` = 'user_31_ce67'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_9e1b@example.com', `Email` = 'user_32_9e1b@example.com', `NormalizedEmail` = 'USER_32_9E1B@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_9E1B', `PasswordHash` = 'mdaK9KzC9wj6iuuLaJm95fWjtHCGo8kIW2YOrUPflVXxBRNFRzY86gzjBKzUZEWW', `SecurityStamp` = 'user_32_9e1b@example.com', `UserName` = 'user_32_9e1b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_1d41@example.com', `Email` = 'user_33_1d41@example.com', `NormalizedEmail` = 'USER_33_1D41@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_1D41', `PasswordHash` = 'COPjFOFH4dWR//1JcE8C5YVxXlkNEyuex2xoQcWzITt5h+/lhY9BiuYLfAX58pLo', `SecurityStamp` = 'user_33_1d41@example.com', `UserName` = 'user_33_1d41'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_c29a@example.com', `Email` = 'user_34_c29a@example.com', `NormalizedEmail` = 'USER_34_C29A@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_C29A', `PasswordHash` = 'D3OSq3nAD5dUMERPL6XvAp1MZ9tIA6v7TLyA4BHXCjxD0y2SRqzPqWLIJPUUt3Ru', `SecurityStamp` = 'user_34_c29a@example.com', `UserName` = 'user_34_c29a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_117d@example.com', `Email` = 'user_35_117d@example.com', `NormalizedEmail` = 'USER_35_117D@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_117D', `PasswordHash` = 'CmSsXZPDwnWCW4qxC3p9cGQoOFrarvWVlblHLi3R8YIRvIEZqqUr8dztj3tht6sz', `SecurityStamp` = 'user_35_117d@example.com', `UserName` = 'user_35_117d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_7181@example.com', `Email` = 'user_36_7181@example.com', `NormalizedEmail` = 'USER_36_7181@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_7181', `PasswordHash` = '8gaA4a1qIQb9ZtBuNE868KHF7FE14XFJtCtyekA02AnN3eKsJs1E9+iI3Yl2yTWY', `SecurityStamp` = 'user_36_7181@example.com', `UserName` = 'user_36_7181'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_5073@example.com', `Email` = 'user_37_5073@example.com', `NormalizedEmail` = 'USER_37_5073@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_5073', `PasswordHash` = 'cWetF5VRo4m24dMHkENsuPgZgF4x2xMvROlSuxayJLxV2ypvx4A4T/oPmhHR1tC/', `SecurityStamp` = 'user_37_5073@example.com', `UserName` = 'user_37_5073'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_8521@example.com', `Email` = 'user_38_8521@example.com', `NormalizedEmail` = 'USER_38_8521@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_8521', `PasswordHash` = 'Dbe+v7P184EgiLlQ/yCdAUkMTKNYpJ9CZkNUtRpJQlqQ1mdpPXNgH5qV2BnbsrIJ', `SecurityStamp` = 'user_38_8521@example.com', `UserName` = 'user_38_8521'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_2efd@example.com', `Email` = 'user_39_2efd@example.com', `NormalizedEmail` = 'USER_39_2EFD@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_2EFD', `PasswordHash` = 'z1bubtwmxIgyW1dkZYxqJ1+7TjspmQ2yH00Ki/kFf9eGb8ZWAVdScCubIiT2WySw', `SecurityStamp` = 'user_39_2efd@example.com', `UserName` = 'user_39_2efd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_05ea@example.com', `Email` = 'user_40_05ea@example.com', `NormalizedEmail` = 'USER_40_05EA@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_05EA', `PasswordHash` = 'NgsM9DJDL7VSuF/oOJGPp8Hp0jH3n7EPfI17PP4H0qxFzB8ccCjlU5+g8FrMIKoF', `SecurityStamp` = 'user_40_05ea@example.com', `UserName` = 'user_40_05ea'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_f824@example.com', `Email` = 'user_41_f824@example.com', `NormalizedEmail` = 'USER_41_F824@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_F824', `PasswordHash` = 'ZRPdKhJCqLvYWN1S2NuCXxkKWltFJLOts6995MT+c6QLCCBlNaltcHNyGcPMbsx5', `SecurityStamp` = 'user_41_f824@example.com', `UserName` = 'user_41_f824'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_04df@example.com', `Email` = 'user_42_04df@example.com', `NormalizedEmail` = 'USER_42_04DF@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_04DF', `PasswordHash` = 'kxCm5UOQw6NhQs/TfhRWTzJXLDaKGOuqMXjUtjkzdSkWgkMpbvyYyrwMh/G5P3K+', `SecurityStamp` = 'user_42_04df@example.com', `UserName` = 'user_42_04df'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_831f@example.com', `Email` = 'user_43_831f@example.com', `NormalizedEmail` = 'USER_43_831F@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_831F', `PasswordHash` = '4wsLNqRL+ajUwYlrivM/adH58yod7RM7gTqc9Kln9l1+1yWQpA+jSFQYVBQs31Aj', `SecurityStamp` = 'user_43_831f@example.com', `UserName` = 'user_43_831f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_a4d3@example.com', `Email` = 'user_44_a4d3@example.com', `NormalizedEmail` = 'USER_44_A4D3@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_A4D3', `PasswordHash` = 'D/17Yi6BPsFRTnCUUYdyTai68nHu2V4kYr2ETn2LO1pRE7tjK9J/Lirn62QrCaYM', `SecurityStamp` = 'user_44_a4d3@example.com', `UserName` = 'user_44_a4d3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_bd10@example.com', `Email` = 'user_45_bd10@example.com', `NormalizedEmail` = 'USER_45_BD10@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_BD10', `PasswordHash` = 'Q6BufOfmV+0vpHEoYcc8zPjB007A/RLkYAt1Klh9Jjo1vF39Duerp4V5/IyPFLpf', `SecurityStamp` = 'user_45_bd10@example.com', `UserName` = 'user_45_bd10'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_ab17@example.com', `Email` = 'user_46_ab17@example.com', `NormalizedEmail` = 'USER_46_AB17@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_AB17', `PasswordHash` = 'MevUzEvh/I+7wvQmcrabW2RcmomJKJC0qpfQ2JIcw9t/k0+W0ulncfejjGkl51e0', `SecurityStamp` = 'user_46_ab17@example.com', `UserName` = 'user_46_ab17'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_65e8@example.com', `Email` = 'user_47_65e8@example.com', `NormalizedEmail` = 'USER_47_65E8@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_65E8', `PasswordHash` = 'ux2FT4ez4ja6lnxVI2gYunsMNVAYrkXmnX5Lp827aZeKjci1ePaTkult2GCSTith', `SecurityStamp` = 'user_47_65e8@example.com', `UserName` = 'user_47_65e8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_99b1@example.com', `Email` = 'user_48_99b1@example.com', `NormalizedEmail` = 'USER_48_99B1@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_99B1', `PasswordHash` = 'fyeHsv5s6Ve8HFrJ+i0QAZU2WSyfb0tJZ3uLHf0CC5JEk8udbNOHQSWi709xyJ8p', `SecurityStamp` = 'user_48_99b1@example.com', `UserName` = 'user_48_99b1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_e89b@example.com', `Email` = 'user_49_e89b@example.com', `NormalizedEmail` = 'USER_49_E89B@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_E89B', `PasswordHash` = '8vdSnPfpEEmAEaYYmOgrdUFyU7vYEUB/EYNtSDxCcFz7uHSLDm6suRsAuTvYBPTe', `SecurityStamp` = 'user_49_e89b@example.com', `UserName` = 'user_49_e89b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_1153@example.com', `Email` = 'user_50_1153@example.com', `NormalizedEmail` = 'USER_50_1153@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_1153', `PasswordHash` = 'g9ZBOcVV22+5xewhPW94zFV5/bJkTT06vT9hyaAEJkshNxg3Ajtbg4srJVvEyAMK', `SecurityStamp` = 'user_50_1153@example.com', `UserName` = 'user_50_1153'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'bs4DCnvOGhsUuoobUjxxJzKtgtqlaAc2WxkDNoFoUabw8qkjSCQ+zCzvD0Bthh+T'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250313213406_AddVisitorLogsTable', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '031c1f64-7f45-4c21-a34c-f030fe9f3c2e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '03474e38-8728-4f82-833c-7ce6ff178b68';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '1898bf28-f229-41d7-abc1-3bdbe79be147';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '472da88f-ede0-404f-8ccf-5eb42a74cf65';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7c0804ea-70f3-43ca-8a27-b807b8d2a649';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9f522f71-cb71-4f02-8fe2-a6201caed6d7';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'acaebef8-96ac-47df-850a-3c7040f4264c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'bef0cd91-8ff4-4075-bd62-20144192b8f9';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f2d1477d-0831-4246-8de5-22c31198e7d8';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'f3d4ac90-7cf3-4877-8ff2-83aafd003118';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '010d6d03-cb7b-4247-bdf2-e03313519348';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '6b3b6dc2-0ecb-4693-b3c5-6b6b4aaff3b6';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '7ca5880b-7431-4e80-991b-b3849291d8bc';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'c62e64f2-60ed-4b5f-8d10-bf9802303f16';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '259502f3-26ba-4243-a515-86721a8588cf';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '996a157a-976f-408b-9ccf-7e12bdb85842';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '9ff7cab2-5295-457f-9d63-220894d4080c';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'f937b5ed-18b6-4178-bc3a-250a602a1d14';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '06922cfa-6028-40e3-9e87-81f4fc1cc973';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '423efa55-3ed8-48f8-a7d4-7615cb4fb6dc';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '6a897abb-dc36-47aa-be89-9b07580e48e0';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '70ac574e-128d-4c92-b27c-6fa9bf691dd5';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '73762a70-3c1f-4429-9cbd-b060cf728cbe';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'ab99ec60-0a9a-494a-8374-814cbeee00e3';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '940dfd58-2978-41c3-ae37-cd2c4cc6b663';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4e5204a0-2c04-49d6-8421-fc5cb80a8132';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '548ee064-91f0-4dda-903f-35f96223def2';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '5eb381e5-fe51-4cf5-ac88-cd709c501eca';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'a27e164f-b4cf-43ba-8585-2b7087c2d444';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'de27bb02-b815-43fc-a63f-d5c80d5003a2';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'fc78ed11-4747-4781-bf60-27aa23e59189';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '060f9e2b-32e1-42fc-915d-d5a59b522bfa';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '6849dce3-bca7-4792-b9eb-2c2e1baada99';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '7c3f650d-2ef1-4add-a598-5b2ee53ea53b';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'b1e5c608-a6cc-469b-93a4-96935026a792';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '1bdf4e21-72d2-4c71-b7f9-61e818cb4291';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '4c561244-ee15-468f-a055-39f9dc1f8d44';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '99ef6acf-2793-4a6b-b8ec-44d35ae22a96';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'c9ac0ae6-34fb-4a6d-8071-d8e7c0c69962';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'ee02a935-f89b-4441-b8da-e6ebf5bec34b';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '5a5f5edf-c01f-4773-a560-b433fcff49bc';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '980a2257-c668-468f-a986-1341ca929f2d';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '9d542454-6692-40bf-ac29-dd96762d7ffc';
SELECT ROW_COUNT();


CREATE TABLE `BibliographyItems` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Title` varchar(200) CHARACTER SET utf8mb4 NOT NULL,
    `Author` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Year` int NOT NULL,
    `Genre` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `IsRead` tinyint(1) NOT NULL,
    `AttachmentId` char(36) COLLATE ascii_general_ci NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `DeletedAt` datetime(6) NULL,
    `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL,
    `DeletedBy` longtext CHARACTER SET utf8mb4 NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_BibliographyItems` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_BibliographyItems_Attachment_AttachmentId` FOREIGN KEY (`AttachmentId`) REFERENCES `Attachment` (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('35944d40-feb8-4fd8-b673-70346b321a25', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('5c8f343f-5914-4c64-a428-47970298ef7a', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('6bcca60b-1424-4be6-baf9-421d6b5ac415', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('76bc22ef-3379-4436-b671-043d3f6c4f9b', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('79adc72c-f1f5-4550-b48e-4465aeb4fdcb', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('7c19952b-71f7-4bd3-8405-3a5bee85d7a1', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('891baeb1-1fcb-4dcf-b21a-97387ba4f0b0', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('a0ad9da0-60a5-4574-8f7b-a25ffab4937c', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('d3546e39-8721-4976-bc90-35cffb988e81', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('e290474b-b9e8-4f0c-8f9c-96ffbdfb89a9', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('1952c020-3ab9-4796-a7cd-46b472a3074f', 'GBP', TIMESTAMP '2025-03-23 01:13:57', 2, TRUE, 'British Pound', '£', NULL),
('27255123-5644-494b-922f-9efa44b10a40', 'EUR', TIMESTAMP '2025-03-23 01:13:57', 2, TRUE, 'Euro', '€', NULL),
('82cdec4c-c5d1-44ce-a7f5-51be054f8475', 'USD', TIMESTAMP '2025-03-23 01:13:57', 2, TRUE, 'US Dollar', '$', NULL),
('e92a3e69-2cea-417e-8bd4-9254d0205416', 'CHF', TIMESTAMP '2025-03-23 01:13:57', 2, TRUE, 'Swiss Franc', 'Fr.', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('37632803-2a2e-44fc-b6cd-a1b2c64dfec7', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('df6aa845-828e-43fe-904f-cef89c73a164', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('eea07e5c-3e16-4f3b-862e-d21bb48ce96c', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('fb181e0e-3ac6-4ab8-b39e-c7c4032709b4', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('36be0c4b-9608-4aad-8543-68fe334982ad', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('3f287a47-88b9-455a-8fa9-6ba6c97eee18', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('4a419f2b-9800-44ef-8b99-58cf0f145896', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL),
('72fae67d-1702-4e1d-8ba5-78b488d11f39', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('dff69e38-ab61-4de0-ab01-76963124e5cf', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('e6d41327-300d-4123-9ca4-608a44e63f9d', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('9edaa34d-fa82-4e71-8071-36cb10c785d6', TIMESTAMP '2025-03-23 01:13:57', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0e0c0f46-841e-477d-85f4-264ea4ae71e6', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('42b98c09-bfd3-46e6-a8b6-b08344b78bc6', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('52122f0f-91b8-48bd-b114-31df8e171ccd', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('a8977581-3261-4902-9a2d-29f01cc55c78', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('c925054c-66ed-430a-bc24-22710800b8c8', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('e1af8e8d-fd6c-4aa0-bb6e-5b893f0fb5cc', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1677ee84-7d66-49cb-a3da-348596683b39', NULL, TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('54553c22-b421-4036-82fb-8311511d6fc5', NULL, TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL),
('722cb86d-7297-4c57-b687-f51a2a474281', NULL, TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('7c518be1-4544-4455-8d97-deacf81d066f', NULL, TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('299446a2-0a25-4ad0-b0fa-dd2e16677fc8', TIMESTAMP '2025-03-23 01:13:57', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('6caddd46-2da8-4947-85d0-da131f96c474', TIMESTAMP '2025-03-23 01:13:57', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('9908d0f6-f9dd-4d0a-aa5d-a0664936ff45', TIMESTAMP '2025-03-23 01:13:57', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('ae95545d-0739-40d2-93b2-b32c0129e586', TIMESTAMP '2025-03-23 01:13:57', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('eec4a504-bf48-4cbc-a952-9dc7227e87df', TIMESTAMP '2025-03-23 01:13:57', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-23 01:13:57'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('79105d96-6927-4f95-9ae7-dde544f173a8', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('847ff9a5-daa5-44c2-8f97-0f545567c614', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('fd31f39d-cbfe-492b-a491-78b2223f9769', TIMESTAMP '2025-03-23 01:13:57', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = '+yAem5X+eV8X3hi2wmRwh1t7ngcZRgUSGcTt1WaZmtvzRPXREHO6L+HwSlpSnQzV'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'WjTyAKhY4cjBJDzkO+cI9WKDmV6XOf8r1+pwed3Dcp1/X0o1vF5Snv5KYN4INqj9'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_b2d5@example.com', `Email` = 'user_1_b2d5@example.com', `NormalizedEmail` = 'USER_1_B2D5@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_B2D5', `PasswordHash` = 'gcd8qBfP2y3rRWX1mM12hKHAUD07V6X7s5MfhYQ8Kz2QSNtd6BscHU8IDDr7FjSg', `SecurityStamp` = 'user_1_b2d5@example.com', `UserName` = 'user_1_b2d5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_d3de@example.com', `Email` = 'user_2_d3de@example.com', `NormalizedEmail` = 'USER_2_D3DE@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_D3DE', `PasswordHash` = 'eeG+P6cgO83HYYwrJQOJzOfbg6NzSI+tjFhIZ4hfMjcXcuXa3vmvRgo5WTqLTP1Q', `SecurityStamp` = 'user_2_d3de@example.com', `UserName` = 'user_2_d3de'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_b989@example.com', `Email` = 'user_3_b989@example.com', `NormalizedEmail` = 'USER_3_B989@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_B989', `PasswordHash` = 'in62FPfW9jDSIEDsEkOnH1yvWPmrglt2p01qZGJfjiOiG7V4Rz9Y9RpFN+fIGOV0', `SecurityStamp` = 'user_3_b989@example.com', `UserName` = 'user_3_b989'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_228f@example.com', `Email` = 'user_4_228f@example.com', `NormalizedEmail` = 'USER_4_228F@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_228F', `PasswordHash` = 'IBY97V2KgWk8t8y3Ixp7OW2ZXuZ7sTB7hlqo6nUxIlmRVXjEvMx/MS0yVSnNXjoi', `SecurityStamp` = 'user_4_228f@example.com', `UserName` = 'user_4_228f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_9d9c@example.com', `Email` = 'user_5_9d9c@example.com', `NormalizedEmail` = 'USER_5_9D9C@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_9D9C', `PasswordHash` = 'qBwU7FY0Yh4qEEaJM1lfM27jRi0Q6cORjis00bktCzA2lB1Q7jQdshBrtraaG86/', `SecurityStamp` = 'user_5_9d9c@example.com', `UserName` = 'user_5_9d9c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_0dd4@example.com', `Email` = 'user_6_0dd4@example.com', `NormalizedEmail` = 'USER_6_0DD4@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_0DD4', `PasswordHash` = 'A59kPI4GOZhkEuB7ZwGhKGO69lYiIHm2I5GK/QO2rURcKC9KcgHHuKhlMai7zqh4', `SecurityStamp` = 'user_6_0dd4@example.com', `UserName` = 'user_6_0dd4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_6511@example.com', `Email` = 'user_7_6511@example.com', `NormalizedEmail` = 'USER_7_6511@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_6511', `PasswordHash` = '8xkf1uxP6D78kqgZ/C6bHddHXSzpxMcKqp1tp1+jrqxcHog6z021uqcdLAP8sy1q', `SecurityStamp` = 'user_7_6511@example.com', `UserName` = 'user_7_6511'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_3962@example.com', `Email` = 'user_8_3962@example.com', `NormalizedEmail` = 'USER_8_3962@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_3962', `PasswordHash` = 'x4Y5PflRhoWLuviiDAMqMYTD2zq7Zg03V8wbTu2x0INj3VBMf8dK/ScNYZhohQw4', `SecurityStamp` = 'user_8_3962@example.com', `UserName` = 'user_8_3962'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_b3cd@example.com', `Email` = 'user_9_b3cd@example.com', `NormalizedEmail` = 'USER_9_B3CD@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_B3CD', `PasswordHash` = '6I20PfS+/KoiQ9oHYFEpdAcI0iNWpCb9GQnw9EuSV3cOdYEhImKcExO1+cTpKU0v', `SecurityStamp` = 'user_9_b3cd@example.com', `UserName` = 'user_9_b3cd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_1e85@example.com', `Email` = 'user_10_1e85@example.com', `NormalizedEmail` = 'USER_10_1E85@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_1E85', `PasswordHash` = 'xU19xPq3arsiP6JFyvSQLOIDLz9AgU4FvoD0a3XG/4TxliQHBTUb0YqFadyR8TnM', `SecurityStamp` = 'user_10_1e85@example.com', `UserName` = 'user_10_1e85'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_d206@example.com', `Email` = 'user_11_d206@example.com', `NormalizedEmail` = 'USER_11_D206@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_D206', `PasswordHash` = 'GEph0heVWSdnYa7j4wWsRmCmKK6nqVvXzLoiPYYrS+bvbtOerTsrrcBXSxfyXnNq', `SecurityStamp` = 'user_11_d206@example.com', `UserName` = 'user_11_d206'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_cce9@example.com', `Email` = 'user_12_cce9@example.com', `NormalizedEmail` = 'USER_12_CCE9@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_CCE9', `PasswordHash` = 'tbuaXTK7VmTeoBUSBsSPRmYPLaH8UT84wW22BaGfETKwxpSG0o63zN5MOqkkAewM', `SecurityStamp` = 'user_12_cce9@example.com', `UserName` = 'user_12_cce9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_3e79@example.com', `Email` = 'user_13_3e79@example.com', `NormalizedEmail` = 'USER_13_3E79@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_3E79', `PasswordHash` = 'LzlEGg/Fjlwb828ldtW+4Z9eD1aPMpa+d9bOJcksoUTNHJv44jb7W9rVhgyS8TPv', `SecurityStamp` = 'user_13_3e79@example.com', `UserName` = 'user_13_3e79'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_43a2@example.com', `Email` = 'user_14_43a2@example.com', `NormalizedEmail` = 'USER_14_43A2@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_43A2', `PasswordHash` = 'NoFg7ITR1BzDpTdohMpo19OyLEzMjAeCMrJk0THYEclrmOrx+1lVkUrhqbylyXhz', `SecurityStamp` = 'user_14_43a2@example.com', `UserName` = 'user_14_43a2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_7865@example.com', `Email` = 'user_15_7865@example.com', `NormalizedEmail` = 'USER_15_7865@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_7865', `PasswordHash` = 'n9SwwHSNcD9eC9nviKPBqpor4P3o9Phb3it2rswSFidAk7ldvoQeVJYbQS9nm6pd', `SecurityStamp` = 'user_15_7865@example.com', `UserName` = 'user_15_7865'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_2554@example.com', `Email` = 'user_16_2554@example.com', `NormalizedEmail` = 'USER_16_2554@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_2554', `PasswordHash` = 'ewXq7Rb971uh/jUl1J4wenZHDFce05m9YMqRV/tOci4LvH/vnHgruAdgoF8znD1U', `SecurityStamp` = 'user_16_2554@example.com', `UserName` = 'user_16_2554'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_16f5@example.com', `Email` = 'user_17_16f5@example.com', `NormalizedEmail` = 'USER_17_16F5@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_16F5', `PasswordHash` = '0ToAwVhie8Me81Cqj6q8TjhIEFdkVd+PFj1Mo3/x+3GWBur6glUQ5k+LM4OBKRbY', `SecurityStamp` = 'user_17_16f5@example.com', `UserName` = 'user_17_16f5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_3697@example.com', `Email` = 'user_18_3697@example.com', `NormalizedEmail` = 'USER_18_3697@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_3697', `PasswordHash` = 'FeptgQ8lWO61DTYSe5gI6VTmzBMY72e0HdtIQ1mZgeCD5RTf/t2NKgrcyTqYTLqM', `SecurityStamp` = 'user_18_3697@example.com', `UserName` = 'user_18_3697'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_751e@example.com', `Email` = 'user_19_751e@example.com', `NormalizedEmail` = 'USER_19_751E@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_751E', `PasswordHash` = 'yWGSMSAAhyLNiouFoUrNKzO/oGzkWh1Uoak+8OSEi4VYW2Sovc8D7mYfoHBZmE1u', `SecurityStamp` = 'user_19_751e@example.com', `UserName` = 'user_19_751e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_397a@example.com', `Email` = 'user_20_397a@example.com', `NormalizedEmail` = 'USER_20_397A@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_397A', `PasswordHash` = '37odvCYnhf1Qa01u/Vo0wsndpWlkPqOVVcJXLzdRDnR76ne6sjSpom6KW0g95hL5', `SecurityStamp` = 'user_20_397a@example.com', `UserName` = 'user_20_397a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_9f38@example.com', `Email` = 'user_21_9f38@example.com', `NormalizedEmail` = 'USER_21_9F38@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_9F38', `PasswordHash` = 'WvVdWVIYXXJVOukyMA9yBLac8gI0NMEwMRVM6gPOdxKfijNS5BVMih28NrF6598v', `SecurityStamp` = 'user_21_9f38@example.com', `UserName` = 'user_21_9f38'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_2b9b@example.com', `Email` = 'user_22_2b9b@example.com', `NormalizedEmail` = 'USER_22_2B9B@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_2B9B', `PasswordHash` = 'H8GOylU0akOsBcUAP4V5HYKP+3zDWsQ3ytu3iDOysHFKVyydtJKQrFlAm6CQpao6', `SecurityStamp` = 'user_22_2b9b@example.com', `UserName` = 'user_22_2b9b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_ba31@example.com', `Email` = 'user_23_ba31@example.com', `NormalizedEmail` = 'USER_23_BA31@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_BA31', `PasswordHash` = 'tNloaEl3zlD3OGU3FgzgoP4DHoJRiEvswpDHE48wcYdaYG0NRSHEOvKETGNCEMe+', `SecurityStamp` = 'user_23_ba31@example.com', `UserName` = 'user_23_ba31'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_71c1@example.com', `Email` = 'user_24_71c1@example.com', `NormalizedEmail` = 'USER_24_71C1@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_71C1', `PasswordHash` = 'WB6iYQ7d6KVyseOjIrn4CfPwAZJ2fPJI4dEsJloWR7VEWGQvgQSvo8LYt5a1EPvn', `SecurityStamp` = 'user_24_71c1@example.com', `UserName` = 'user_24_71c1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_1d1e@example.com', `Email` = 'user_25_1d1e@example.com', `NormalizedEmail` = 'USER_25_1D1E@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_1D1E', `PasswordHash` = 'o803OTGnaEEHJsJF4K00GWYUVfWMPLugJ8SqKh+B9Vr+Qsde0Ml7DmjiRf7+K5vl', `SecurityStamp` = 'user_25_1d1e@example.com', `UserName` = 'user_25_1d1e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_5242@example.com', `Email` = 'user_26_5242@example.com', `NormalizedEmail` = 'USER_26_5242@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_5242', `PasswordHash` = 'mJVqpDhKw37rzTtTzv7GilyWmD9ktMU37Y6M56lHa9ZWXAKoKJIPGsoByrPWbzrT', `SecurityStamp` = 'user_26_5242@example.com', `UserName` = 'user_26_5242'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_937a@example.com', `Email` = 'user_27_937a@example.com', `NormalizedEmail` = 'USER_27_937A@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_937A', `PasswordHash` = 'Ucnd5mkuQf2Tr7zLH33wDtroBHNup6rhCGHm9FH6fnPV+hzM3YKzyzE+jFIGU43Q', `SecurityStamp` = 'user_27_937a@example.com', `UserName` = 'user_27_937a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_4927@example.com', `Email` = 'user_28_4927@example.com', `NormalizedEmail` = 'USER_28_4927@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_4927', `PasswordHash` = '+teUv7dtfMi2rdTk8K/epgkUT9Q0KB41Mkz5Q5qSGF4yiRe0ygqlrEFX1b2R8bts', `SecurityStamp` = 'user_28_4927@example.com', `UserName` = 'user_28_4927'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_ba4c@example.com', `Email` = 'user_29_ba4c@example.com', `NormalizedEmail` = 'USER_29_BA4C@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_BA4C', `PasswordHash` = 'ncNn0vtXiIE44RylCzGpT9WXfEvj+v4146q5Iy0JGQusw/OFyOU4ggUsg2V5F15h', `SecurityStamp` = 'user_29_ba4c@example.com', `UserName` = 'user_29_ba4c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_0b5f@example.com', `Email` = 'user_30_0b5f@example.com', `NormalizedEmail` = 'USER_30_0B5F@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_0B5F', `PasswordHash` = 'UUxbPuVbwkjsgud5/pgsUiPLR1Wpia0ZflNQpeXFxyQR/MA3REjHP4pCH7YqhJQX', `SecurityStamp` = 'user_30_0b5f@example.com', `UserName` = 'user_30_0b5f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_fc1f@example.com', `Email` = 'user_31_fc1f@example.com', `NormalizedEmail` = 'USER_31_FC1F@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_FC1F', `PasswordHash` = '5rmeNdFCwwI17nQBn0BSM38pnIswE+mUOOjY6lW0Ry/rwwOK3yaf4rUpdbqbj1+S', `SecurityStamp` = 'user_31_fc1f@example.com', `UserName` = 'user_31_fc1f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_83b9@example.com', `Email` = 'user_32_83b9@example.com', `NormalizedEmail` = 'USER_32_83B9@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_83B9', `PasswordHash` = 'R9QNaktJauFK4AZLh3Rx6Vq1r1/K0PLEyyuDCFt2KsWVQ2qFMttnNddzGgDl1sVX', `SecurityStamp` = 'user_32_83b9@example.com', `UserName` = 'user_32_83b9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_3eab@example.com', `Email` = 'user_33_3eab@example.com', `NormalizedEmail` = 'USER_33_3EAB@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_3EAB', `PasswordHash` = 'ApSUF9eVFir85jOsSwHUifis+gqa0FbW3SqdzQbXaCGyWZT7jL9bdoBiCV47dLrI', `SecurityStamp` = 'user_33_3eab@example.com', `UserName` = 'user_33_3eab'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_c6cc@example.com', `Email` = 'user_34_c6cc@example.com', `NormalizedEmail` = 'USER_34_C6CC@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_C6CC', `PasswordHash` = 'GO2bb1xHeC1KH4fxlkrPDhXhnbzOFsVCF6xd77HV2O0uZpuvkW9Gud/IFGlwVtiF', `SecurityStamp` = 'user_34_c6cc@example.com', `UserName` = 'user_34_c6cc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_f5d4@example.com', `Email` = 'user_35_f5d4@example.com', `NormalizedEmail` = 'USER_35_F5D4@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_F5D4', `PasswordHash` = 'avduyIuQZWh6CuuhgK/iDI9yhdxgKWELRiI+g6OATR9Jh54GaH1pvDDdldD9mzYa', `SecurityStamp` = 'user_35_f5d4@example.com', `UserName` = 'user_35_f5d4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_f820@example.com', `Email` = 'user_36_f820@example.com', `NormalizedEmail` = 'USER_36_F820@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_F820', `PasswordHash` = 'p9daqmwVATjTl2xh4zQVjqZDje1OowbGiVig6D0x+fsu35+HvahMu/Ppw4UWSSCL', `SecurityStamp` = 'user_36_f820@example.com', `UserName` = 'user_36_f820'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_acce@example.com', `Email` = 'user_37_acce@example.com', `NormalizedEmail` = 'USER_37_ACCE@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_ACCE', `PasswordHash` = 'IMpp2jaMCb9391ZHRNEliWIi0r40Uw7TqAO9Ommglh/5i5pZl8G60giov+8/ToMN', `SecurityStamp` = 'user_37_acce@example.com', `UserName` = 'user_37_acce'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_07e2@example.com', `Email` = 'user_38_07e2@example.com', `NormalizedEmail` = 'USER_38_07E2@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_07E2', `PasswordHash` = '3iwpzasKBGtj6AOyPuueKB77WXANzTrTIM4zzOMHAQr2wv6OitNW2KkKVrJl2egn', `SecurityStamp` = 'user_38_07e2@example.com', `UserName` = 'user_38_07e2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_aecd@example.com', `Email` = 'user_39_aecd@example.com', `NormalizedEmail` = 'USER_39_AECD@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_AECD', `PasswordHash` = 'L7crs13eVl8xand0v0NKdJed9YEDmNTGE2uGEiyobvfbFnfH1q5oJ6Rk9w/x3du+', `SecurityStamp` = 'user_39_aecd@example.com', `UserName` = 'user_39_aecd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_368a@example.com', `Email` = 'user_40_368a@example.com', `NormalizedEmail` = 'USER_40_368A@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_368A', `PasswordHash` = 'f97zBrTtUmvOwVRw2F2WU3V6MpVYlZZyj9se85jRODPubYhnA0vaK4SI+F/l5Sv7', `SecurityStamp` = 'user_40_368a@example.com', `UserName` = 'user_40_368a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_3803@example.com', `Email` = 'user_41_3803@example.com', `NormalizedEmail` = 'USER_41_3803@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_3803', `PasswordHash` = 'Hr+2Bz0zjRs3SJNvITXRKOFbx65DUsEQ+CRAIJwe2oF42CJcTqpBn9k3bxesfYwN', `SecurityStamp` = 'user_41_3803@example.com', `UserName` = 'user_41_3803'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_46b0@example.com', `Email` = 'user_42_46b0@example.com', `NormalizedEmail` = 'USER_42_46B0@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_46B0', `PasswordHash` = '1KxWRtK+ZbNxtjoHAvjBw24b/vVRQC3JvSqeeyaiN6Ef/mKTHBiHr0Hi1RHsvnuu', `SecurityStamp` = 'user_42_46b0@example.com', `UserName` = 'user_42_46b0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_d49e@example.com', `Email` = 'user_43_d49e@example.com', `NormalizedEmail` = 'USER_43_D49E@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_D49E', `PasswordHash` = 'zPxCidhDPm+Nk+LChwLeQL+AuAcasgrf5hmVayusMbIfd1w/nTfyWk1yxSMu78iZ', `SecurityStamp` = 'user_43_d49e@example.com', `UserName` = 'user_43_d49e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_f76f@example.com', `Email` = 'user_44_f76f@example.com', `NormalizedEmail` = 'USER_44_F76F@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_F76F', `PasswordHash` = 'szWjaTFNGvzwLgcbLe29d7aCbE9B3yUqGCRTAcyIWGc+i3ipZJ/BfpJdq2QHGzNo', `SecurityStamp` = 'user_44_f76f@example.com', `UserName` = 'user_44_f76f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_6c58@example.com', `Email` = 'user_45_6c58@example.com', `NormalizedEmail` = 'USER_45_6C58@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_6C58', `PasswordHash` = 'pTAfJsJWYu6R/vgoaxBHRDuCkZYeaFcMM4xnyfNzt40DXsfrF88+FIUyOvmkDTIp', `SecurityStamp` = 'user_45_6c58@example.com', `UserName` = 'user_45_6c58'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_df63@example.com', `Email` = 'user_46_df63@example.com', `NormalizedEmail` = 'USER_46_DF63@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_DF63', `PasswordHash` = 'uVC01KCaAXN4igJsQ8Hx7n3eqzqE0ryuqtWTqg8UfBEK9HsGP8ndUR60uYeAMr0s', `SecurityStamp` = 'user_46_df63@example.com', `UserName` = 'user_46_df63'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_4525@example.com', `Email` = 'user_47_4525@example.com', `NormalizedEmail` = 'USER_47_4525@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_4525', `PasswordHash` = 'iF6YzmkMhd8fBfpd4zq1WBQi2G6jCDCCzH/5K/Fz7pKALrnfKVrB8f8OfdJJnlzH', `SecurityStamp` = 'user_47_4525@example.com', `UserName` = 'user_47_4525'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_096e@example.com', `Email` = 'user_48_096e@example.com', `NormalizedEmail` = 'USER_48_096E@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_096E', `PasswordHash` = '2Xsp5tWKELpQudxXVoQQz/3PSI4oTPaf+mgvKliNbAJKR/wc9ZO2Erx1v0X10Nsv', `SecurityStamp` = 'user_48_096e@example.com', `UserName` = 'user_48_096e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_48c7@example.com', `Email` = 'user_49_48c7@example.com', `NormalizedEmail` = 'USER_49_48C7@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_48C7', `PasswordHash` = 'ovEjGTUAhd/ssWT2mGft+xaiclxBk8pPRXe8vQOYRIUsZmwmn/48mLqdb9vwKfph', `SecurityStamp` = 'user_49_48c7@example.com', `UserName` = 'user_49_48c7'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_d56a@example.com', `Email` = 'user_50_d56a@example.com', `NormalizedEmail` = 'USER_50_D56A@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_D56A', `PasswordHash` = 'CSrW4iw/ZcXC5u7I4xhG8CCO91FB6qhZdGmMAMdO5IIWoGBJovyZw2xdpAr6ZMyz', `SecurityStamp` = 'user_50_d56a@example.com', `UserName` = 'user_50_d56a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'PicdUQxGFbomS1kZr8Vjh8njgp4vMdPSuPWGhmkQ8Hq3CamfK7Adp3cw0BBVduJE'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


CREATE INDEX `IX_BibliographyItems_AttachmentId` ON `BibliographyItems` (`AttachmentId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250323011405_BibliographyItems', '9.0.1');

DELETE FROM `Countries`
WHERE `Id` = '35944d40-feb8-4fd8-b673-70346b321a25';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '5c8f343f-5914-4c64-a428-47970298ef7a';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6bcca60b-1424-4be6-baf9-421d6b5ac415';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '76bc22ef-3379-4436-b671-043d3f6c4f9b';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '79adc72c-f1f5-4550-b48e-4465aeb4fdcb';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7c19952b-71f7-4bd3-8405-3a5bee85d7a1';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '891baeb1-1fcb-4dcf-b21a-97387ba4f0b0';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a0ad9da0-60a5-4574-8f7b-a25ffab4937c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'd3546e39-8721-4976-bc90-35cffb988e81';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'e290474b-b9e8-4f0c-8f9c-96ffbdfb89a9';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '1952c020-3ab9-4796-a7cd-46b472a3074f';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '27255123-5644-494b-922f-9efa44b10a40';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '82cdec4c-c5d1-44ce-a7f5-51be054f8475';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'e92a3e69-2cea-417e-8bd4-9254d0205416';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '37632803-2a2e-44fc-b6cd-a1b2c64dfec7';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'df6aa845-828e-43fe-904f-cef89c73a164';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'eea07e5c-3e16-4f3b-862e-d21bb48ce96c';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'fb181e0e-3ac6-4ab8-b39e-c7c4032709b4';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '36be0c4b-9608-4aad-8543-68fe334982ad';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '3f287a47-88b9-455a-8fa9-6ba6c97eee18';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '4a419f2b-9800-44ef-8b99-58cf0f145896';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '72fae67d-1702-4e1d-8ba5-78b488d11f39';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'dff69e38-ab61-4de0-ab01-76963124e5cf';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'e6d41327-300d-4123-9ca4-608a44e63f9d';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '9edaa34d-fa82-4e71-8071-36cb10c785d6';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '0e0c0f46-841e-477d-85f4-264ea4ae71e6';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '42b98c09-bfd3-46e6-a8b6-b08344b78bc6';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '52122f0f-91b8-48bd-b114-31df8e171ccd';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'a8977581-3261-4902-9a2d-29f01cc55c78';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'c925054c-66ed-430a-bc24-22710800b8c8';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'e1af8e8d-fd6c-4aa0-bb6e-5b893f0fb5cc';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '1677ee84-7d66-49cb-a3da-348596683b39';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '54553c22-b421-4036-82fb-8311511d6fc5';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '722cb86d-7297-4c57-b687-f51a2a474281';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '7c518be1-4544-4455-8d97-deacf81d066f';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '299446a2-0a25-4ad0-b0fa-dd2e16677fc8';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '6caddd46-2da8-4947-85d0-da131f96c474';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '9908d0f6-f9dd-4d0a-aa5d-a0664936ff45';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'ae95545d-0739-40d2-93b2-b32c0129e586';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'eec4a504-bf48-4cbc-a952-9dc7227e87df';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '79105d96-6927-4f95-9ae7-dde544f173a8';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '847ff9a5-daa5-44c2-8f97-0f545567c614';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'fd31f39d-cbfe-492b-a491-78b2223f9769';
SELECT ROW_COUNT();


INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('058ac7ea-0fa1-49a1-9aee-eec8bd95a099', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('0af6ddf2-fc14-4e80-aeb8-e7374ff31532', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('4104b34e-1d5f-4c09-a4bf-53b649ab5902', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('4773d13c-a6a4-46da-b589-53daa6027edb', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('512dddda-8b69-48bc-a4ed-abcea791117f', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('6fc6c4f6-f5f0-4ef4-aad4-4e07aefb2c51', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('7e40ff57-d825-4136-9c4e-f2a3d9d6f975', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('8cdcce16-0d4a-42ed-a11d-a14db328e2e2', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('b0eb49c6-4484-4427-8496-e2f0dd50bd94', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('e7357a5a-ed1c-4630-9bef-68726e77cb69', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('02d16b39-068f-4e9b-9f83-5edf2138ed06', 'CHF', TIMESTAMP '2025-03-23 01:20:36', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('144e5560-6754-4a81-a1b1-545c59537696', 'EUR', TIMESTAMP '2025-03-23 01:20:36', 2, TRUE, 'Euro', '€', NULL),
('536c3a5d-bd72-4e51-8537-f3b51372a88e', 'USD', TIMESTAMP '2025-03-23 01:20:36', 2, TRUE, 'US Dollar', '$', NULL),
('ecb5265f-d365-4c05-8924-e292a21bda89', 'GBP', TIMESTAMP '2025-03-23 01:20:36', 2, TRUE, 'British Pound', '£', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('157357bd-edd5-4611-9c24-739f70980a38', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL),
('326bff6c-7c23-4c17-b5e7-86a11450e290', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('737d2787-2a1f-4571-b509-860beb7a98ae', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('d642684a-4c47-47a1-8109-f126f537efb9', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('6b7faddb-0152-494c-8108-08fddd931166', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('a5540390-cb48-4fc0-94a0-5438ab352523', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('b8c075e0-09a1-449a-8cad-37a2006bbfe1', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('c8c20fd6-4956-4e24-b21e-3cd3ccd88ec7', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('dc43b813-08ed-45fa-ba6a-80de59d85591', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL),
('dda9e46f-4b95-4dc7-b42c-151e87e0408e', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('2e3f723e-b24d-4d37-94a6-03d6ffff0de5', TIMESTAMP '2025-03-23 01:20:36', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('2598e53c-199e-48e5-9e6d-e6c7c8aff8a6', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('4d3918ed-0929-4d16-9b76-578832ed3669', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('88f9c01e-d6c4-4cfe-9b6b-166f0e1570d4', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('943bf88a-a95c-478d-b4e1-965115f81923', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('d8918f70-37a9-454f-9026-8591ecddb906', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('ebea86cf-6d3d-4dd0-a7fc-b762427b1ec1', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('2a6fc865-8476-4796-b6d4-456005259a2c', NULL, TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('c34adfef-528c-48bd-8d36-634977b924a2', NULL, TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('e2ff127b-c38f-46e5-afe6-685bb7d8f9d5', NULL, TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL),
('e49d36d9-e87d-4ff4-97a8-e0cb9b7f1483', NULL, TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('6e0e428c-8961-44a1-86ad-af24c2d31f36', TIMESTAMP '2025-03-23 01:20:36', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('9bb4f5c3-c216-4ac2-914b-f29eebcc3abe', TIMESTAMP '2025-03-23 01:20:36', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('bc9c578e-e25b-43ae-aae2-741657fde460', TIMESTAMP '2025-03-23 01:20:36', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('c9ed37f3-f886-4ed3-847f-71f66503a3a7', TIMESTAMP '2025-03-23 01:20:36', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('e506c17b-9d79-4b92-ba2d-30eff6501335', TIMESTAMP '2025-03-23 01:20:36', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-03-23 01:20:36'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1334022d-4e6e-4325-a5dd-58f4a301e801', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('6fbefcaf-0251-46a4-87dd-fc7727e9f832', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('c93703ad-1c7e-4b29-a748-f9a6238bf9e2', TIMESTAMP '2025-03-23 01:20:36', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = '/Nez0ZfaApOnLYezCYqgVWfytTwTnsu6b9iuJzh1+tiqC/ppnysCUIN4tpJVBRR3'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'b5k6HID6gJPstLpJPRKbcZyLhenwdMuOGs0WcC3+ZK8JmPWgKGDKDukRdJZfJR5l'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_47ae@example.com', `Email` = 'user_1_47ae@example.com', `NormalizedEmail` = 'USER_1_47AE@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_47AE', `PasswordHash` = 'X4uDwWM2lCrTk5eUI0XLQgKRjn4rou8av8H2LFZZ8fsIWcOLIWhL3eX8pIBuFbIl', `SecurityStamp` = 'user_1_47ae@example.com', `UserName` = 'user_1_47ae'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_719c@example.com', `Email` = 'user_2_719c@example.com', `NormalizedEmail` = 'USER_2_719C@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_719C', `PasswordHash` = 'kwA6y+ooYcLH7aNm+KlAdNirVdZY24Pxq2HcAJbllTKBG1sA2ggA8A/Pxc5QLeUA', `SecurityStamp` = 'user_2_719c@example.com', `UserName` = 'user_2_719c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_f7d6@example.com', `Email` = 'user_3_f7d6@example.com', `NormalizedEmail` = 'USER_3_F7D6@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_F7D6', `PasswordHash` = 'uUlQJnY82bknLfMWtJUnw+9+kB+VLVa3Yzu3k4TPByvHx/D9G2/3FFTWTwoxfx8d', `SecurityStamp` = 'user_3_f7d6@example.com', `UserName` = 'user_3_f7d6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_c955@example.com', `Email` = 'user_4_c955@example.com', `NormalizedEmail` = 'USER_4_C955@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_C955', `PasswordHash` = '/BmqP1L5D6MyTAMygXz98lYyZlMTOePsuMUazzB/Iysr5RW/RlbAtK2yUcvm2J/v', `SecurityStamp` = 'user_4_c955@example.com', `UserName` = 'user_4_c955'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_2a86@example.com', `Email` = 'user_5_2a86@example.com', `NormalizedEmail` = 'USER_5_2A86@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_2A86', `PasswordHash` = 'LwUdLRCndgVe4AkIuHcRp7vNgMvf48olrywfdujEatLSDn0FIQ8ouQEctIaC7xAC', `SecurityStamp` = 'user_5_2a86@example.com', `UserName` = 'user_5_2a86'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_b933@example.com', `Email` = 'user_6_b933@example.com', `NormalizedEmail` = 'USER_6_B933@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_B933', `PasswordHash` = 'gjqvPu1IjG/JQnhIEYYyeQEnKlC0QnYl0SUIbto8rUd7qdh3BFOSeBUEl2L8Q6us', `SecurityStamp` = 'user_6_b933@example.com', `UserName` = 'user_6_b933'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_33b1@example.com', `Email` = 'user_7_33b1@example.com', `NormalizedEmail` = 'USER_7_33B1@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_33B1', `PasswordHash` = 'Llj2TA8LjNYgqAQLq2owctDhEmgXyhRk9PzVivAu4+/uqydXaRS5DCIVN47Av0qc', `SecurityStamp` = 'user_7_33b1@example.com', `UserName` = 'user_7_33b1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_20b2@example.com', `Email` = 'user_8_20b2@example.com', `NormalizedEmail` = 'USER_8_20B2@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_20B2', `PasswordHash` = 'fImW9QG1mp9vQrftQmO+DxY39lpfwBLkuBS0q+LD1gY6hXvKHV+qJBaufV78sWgn', `SecurityStamp` = 'user_8_20b2@example.com', `UserName` = 'user_8_20b2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_a230@example.com', `Email` = 'user_9_a230@example.com', `NormalizedEmail` = 'USER_9_A230@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_A230', `PasswordHash` = '6t8SYWYnnVrLxrdhYnK6e/naa5/pYPAzNj3kUnCXwOs+JG12nhRKX1awfsCGqzDd', `SecurityStamp` = 'user_9_a230@example.com', `UserName` = 'user_9_a230'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_02f2@example.com', `Email` = 'user_10_02f2@example.com', `NormalizedEmail` = 'USER_10_02F2@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_02F2', `PasswordHash` = '4MRrPvC+STULZENnuzT4NMiixdyv0xGsl1NXihAvdf49WqWaySf0ovSfZjt3KGLY', `SecurityStamp` = 'user_10_02f2@example.com', `UserName` = 'user_10_02f2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_7a86@example.com', `Email` = 'user_11_7a86@example.com', `NormalizedEmail` = 'USER_11_7A86@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_7A86', `PasswordHash` = 'vih1H9menqF4T6N6oidczPOH2/Cu5Q6ooDwJSIWAAk7jBsc9WyJWb1SVrWgYNUzV', `SecurityStamp` = 'user_11_7a86@example.com', `UserName` = 'user_11_7a86'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_73cc@example.com', `Email` = 'user_12_73cc@example.com', `NormalizedEmail` = 'USER_12_73CC@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_73CC', `PasswordHash` = 'FjhHaOB0r85hY7n1i5UwnjmvLUbjoQXEIONoLfoeif+8oktmMS+aO7j0DpVyFMtG', `SecurityStamp` = 'user_12_73cc@example.com', `UserName` = 'user_12_73cc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_c05e@example.com', `Email` = 'user_13_c05e@example.com', `NormalizedEmail` = 'USER_13_C05E@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_C05E', `PasswordHash` = 'nhUkY+lHNPXYfZlBqpsZ3nx63zzlc3fezNSr/suUdRGGLPs0pI0pdwGMngMjSbib', `SecurityStamp` = 'user_13_c05e@example.com', `UserName` = 'user_13_c05e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_ee69@example.com', `Email` = 'user_14_ee69@example.com', `NormalizedEmail` = 'USER_14_EE69@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_EE69', `PasswordHash` = '3t2dFPMu3tlgOUjthM3ZQioQ+A3L3F7bZKUA6Sy1ppJotS4iSRryDyu5LMHlJ0Jo', `SecurityStamp` = 'user_14_ee69@example.com', `UserName` = 'user_14_ee69'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_9347@example.com', `Email` = 'user_15_9347@example.com', `NormalizedEmail` = 'USER_15_9347@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_9347', `PasswordHash` = 'h7RChsgGTqcResnr9zLzNePnnoEiJxPhGWTDM0xG+ZkcCBL904DnL1mNKRKJq3j4', `SecurityStamp` = 'user_15_9347@example.com', `UserName` = 'user_15_9347'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_c077@example.com', `Email` = 'user_16_c077@example.com', `NormalizedEmail` = 'USER_16_C077@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_C077', `PasswordHash` = 'k3FAFWuDJRx+TY2iA5V6t9OX9woFUhXFKsiZ+8+6Mx9HXp9kzT+hGPQxzRoJd0+c', `SecurityStamp` = 'user_16_c077@example.com', `UserName` = 'user_16_c077'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_7a2c@example.com', `Email` = 'user_17_7a2c@example.com', `NormalizedEmail` = 'USER_17_7A2C@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_7A2C', `PasswordHash` = 'ZbDitljPeFqitxW+m0jm4ry3VZYHgJ+FHyncMfdJHmv6VzL4sticbtK3XPRs91PV', `SecurityStamp` = 'user_17_7a2c@example.com', `UserName` = 'user_17_7a2c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_b46d@example.com', `Email` = 'user_18_b46d@example.com', `NormalizedEmail` = 'USER_18_B46D@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_B46D', `PasswordHash` = 'XnlgUTWM1fk+EP0rdBM4jCMH1g+/gmcdhLxfJGY5kfLzs4LAUwFbo5INxDlmupyN', `SecurityStamp` = 'user_18_b46d@example.com', `UserName` = 'user_18_b46d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_f825@example.com', `Email` = 'user_19_f825@example.com', `NormalizedEmail` = 'USER_19_F825@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_F825', `PasswordHash` = 'ue+7nMetdbPzWoBKUdt+DbkoGgTPL3Cox2SoD2X0a+BRit+nb+eLNDV82Dr89/oN', `SecurityStamp` = 'user_19_f825@example.com', `UserName` = 'user_19_f825'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_d5c5@example.com', `Email` = 'user_20_d5c5@example.com', `NormalizedEmail` = 'USER_20_D5C5@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_D5C5', `PasswordHash` = 'PYuZaPvwYLFi3zw7K+4iIMErpUdUfjmLJiV7C04gypFCgF258VYy+IBbg0hV2vBi', `SecurityStamp` = 'user_20_d5c5@example.com', `UserName` = 'user_20_d5c5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_041a@example.com', `Email` = 'user_21_041a@example.com', `NormalizedEmail` = 'USER_21_041A@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_041A', `PasswordHash` = 'uvGk9q8p3BA7LCyfe5nnuN+GG97D7YDN/yqowhHnNbYEj3a+32s28v3vvuqJq10H', `SecurityStamp` = 'user_21_041a@example.com', `UserName` = 'user_21_041a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_c40a@example.com', `Email` = 'user_22_c40a@example.com', `NormalizedEmail` = 'USER_22_C40A@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_C40A', `PasswordHash` = 'V2ITgoMNsAvO4BPqM07bzstfutOMSsZIiQYYoxXv6fwu2Dug8jP3zAE4v704EpBn', `SecurityStamp` = 'user_22_c40a@example.com', `UserName` = 'user_22_c40a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_f163@example.com', `Email` = 'user_23_f163@example.com', `NormalizedEmail` = 'USER_23_F163@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_F163', `PasswordHash` = 'XTYUM4YzrKfVQPk34tXCola7ZUkAcYxorESF2SkrSTUEQGH2uQPflU48WTxr321U', `SecurityStamp` = 'user_23_f163@example.com', `UserName` = 'user_23_f163'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_3849@example.com', `Email` = 'user_24_3849@example.com', `NormalizedEmail` = 'USER_24_3849@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_3849', `PasswordHash` = 'E7Of5nkgw7Yv02sCA50AVMG2V0NPEWOy9IusVtQX9WJOLo3jCzKo9OyQnSkz0T6d', `SecurityStamp` = 'user_24_3849@example.com', `UserName` = 'user_24_3849'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_ac40@example.com', `Email` = 'user_25_ac40@example.com', `NormalizedEmail` = 'USER_25_AC40@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_AC40', `PasswordHash` = 'rAq4q8KTrNhcDIoRBIZGI24oUA3gHOq+PqgQD/jIaMfZZSbuTeVfbMRZ8JdPAnl7', `SecurityStamp` = 'user_25_ac40@example.com', `UserName` = 'user_25_ac40'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_ba0b@example.com', `Email` = 'user_26_ba0b@example.com', `NormalizedEmail` = 'USER_26_BA0B@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_BA0B', `PasswordHash` = 'MKg5rqv7rnCVLSRC8zwTY92p4zNoFfNG4nbaqBJPDpS68j9JkhnXO+tORoy6az7h', `SecurityStamp` = 'user_26_ba0b@example.com', `UserName` = 'user_26_ba0b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_b779@example.com', `Email` = 'user_27_b779@example.com', `NormalizedEmail` = 'USER_27_B779@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_B779', `PasswordHash` = 'npnfFhUc6FIybW3dWTM+YUKN58CVqBbNxW/+RhAxdQic3uLMGPJOIszw/fpb2DTh', `SecurityStamp` = 'user_27_b779@example.com', `UserName` = 'user_27_b779'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_7b36@example.com', `Email` = 'user_28_7b36@example.com', `NormalizedEmail` = 'USER_28_7B36@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_7B36', `PasswordHash` = '8kHg0uYGu6gxDedHCTzhe7apSX4QoBieQpHhqBn+gIY7Su31guvyLVRQmp9rRX/M', `SecurityStamp` = 'user_28_7b36@example.com', `UserName` = 'user_28_7b36'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_f8bc@example.com', `Email` = 'user_29_f8bc@example.com', `NormalizedEmail` = 'USER_29_F8BC@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_F8BC', `PasswordHash` = 'L7qjSpX3YlllhY5RVdmZeVBcQJn+P+cCdw/+I1l8kbSBVy1vhtrAGr2OTebIldSS', `SecurityStamp` = 'user_29_f8bc@example.com', `UserName` = 'user_29_f8bc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_dbd2@example.com', `Email` = 'user_30_dbd2@example.com', `NormalizedEmail` = 'USER_30_DBD2@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_DBD2', `PasswordHash` = 'qe5jyNMrgxs9ZDZf/VJfSm3WqflGMFHz1VVJain3bgYw298M+O3BlOytx3VSKDyT', `SecurityStamp` = 'user_30_dbd2@example.com', `UserName` = 'user_30_dbd2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_7ef4@example.com', `Email` = 'user_31_7ef4@example.com', `NormalizedEmail` = 'USER_31_7EF4@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_7EF4', `PasswordHash` = 'GM4Oi4ib9lzNSlgf0r7nI0Gph22ASyDo8kAqq+kf6RLJwAJJwEBNYfbZrrYb807N', `SecurityStamp` = 'user_31_7ef4@example.com', `UserName` = 'user_31_7ef4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_3ce3@example.com', `Email` = 'user_32_3ce3@example.com', `NormalizedEmail` = 'USER_32_3CE3@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_3CE3', `PasswordHash` = 'N8mP3ishwVSFxg1T4JPiHjNMLlFu2miRJVnBS1GxJpW16LqO4eA4TV99PJb8ZiOf', `SecurityStamp` = 'user_32_3ce3@example.com', `UserName` = 'user_32_3ce3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_c8d2@example.com', `Email` = 'user_33_c8d2@example.com', `NormalizedEmail` = 'USER_33_C8D2@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_C8D2', `PasswordHash` = 'pEQp9/YZs8ehoI2wY7CqgWNI5LrU3f/EAKUHJ8blSZ4TKcpthEZqN0WqSJzD6aZ+', `SecurityStamp` = 'user_33_c8d2@example.com', `UserName` = 'user_33_c8d2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_cde6@example.com', `Email` = 'user_34_cde6@example.com', `NormalizedEmail` = 'USER_34_CDE6@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_CDE6', `PasswordHash` = 'TeKmii9zUxXyEgjy9NIo3xLZRGIUOkkFHsEz7ae/2XkIaZ/Ws06hTzO92qR+cGp1', `SecurityStamp` = 'user_34_cde6@example.com', `UserName` = 'user_34_cde6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_6f91@example.com', `Email` = 'user_35_6f91@example.com', `NormalizedEmail` = 'USER_35_6F91@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_6F91', `PasswordHash` = '3TdjdPP/vzBE6hHyGpsXtW61wIieuxrdGIfRlPbdxFy0s6CIBRQLL9KcUt9FKEAd', `SecurityStamp` = 'user_35_6f91@example.com', `UserName` = 'user_35_6f91'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_f87e@example.com', `Email` = 'user_36_f87e@example.com', `NormalizedEmail` = 'USER_36_F87E@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_F87E', `PasswordHash` = '56gHgOubGxbt/Veq8DAlsN12JeeN2FCjLIWIe7lWlIPXeXeD/eVB3VFvRfq3XiEf', `SecurityStamp` = 'user_36_f87e@example.com', `UserName` = 'user_36_f87e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_522d@example.com', `Email` = 'user_37_522d@example.com', `NormalizedEmail` = 'USER_37_522D@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_522D', `PasswordHash` = 'oUGfM4suzGFvDkasNHV/HbPLzd276jjiLP14aoj07EbYYUzKxzKHLG7YAR/il6y+', `SecurityStamp` = 'user_37_522d@example.com', `UserName` = 'user_37_522d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_0cee@example.com', `Email` = 'user_38_0cee@example.com', `NormalizedEmail` = 'USER_38_0CEE@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_0CEE', `PasswordHash` = 'vYlff7xxZ7L4YETjBm57+yL0kn3K6SEaC6i/kNpRK0+MvF2vMbAJhvXGLd/uGydf', `SecurityStamp` = 'user_38_0cee@example.com', `UserName` = 'user_38_0cee'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_5999@example.com', `Email` = 'user_39_5999@example.com', `NormalizedEmail` = 'USER_39_5999@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_5999', `PasswordHash` = 'MnE6YOEpE+Of+l7G8NY4K8a2tllrauZMF00UewLG5TM304coJiwUOFHG0WN8LqNv', `SecurityStamp` = 'user_39_5999@example.com', `UserName` = 'user_39_5999'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_7c58@example.com', `Email` = 'user_40_7c58@example.com', `NormalizedEmail` = 'USER_40_7C58@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_7C58', `PasswordHash` = 'gl5d8J3pj7B7h140yfyer7Qs5NWkAvVd0tID0NCSatPl4yK/WuqigWKKwYtPj5n7', `SecurityStamp` = 'user_40_7c58@example.com', `UserName` = 'user_40_7c58'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_fc2b@example.com', `Email` = 'user_41_fc2b@example.com', `NormalizedEmail` = 'USER_41_FC2B@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_FC2B', `PasswordHash` = 'zPv0FhZi4rHdsYWmsZ9RbZZ/mtRFIKbpYUEALrOCruimdci/HTMmuR6zOeD8HxMh', `SecurityStamp` = 'user_41_fc2b@example.com', `UserName` = 'user_41_fc2b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_873a@example.com', `Email` = 'user_42_873a@example.com', `NormalizedEmail` = 'USER_42_873A@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_873A', `PasswordHash` = '/v6MkD9lsCpNQrRT0yRxWJRa+9prJAhmQT/+GOw3reVYVZfEQgjy+DIxSfrBttuo', `SecurityStamp` = 'user_42_873a@example.com', `UserName` = 'user_42_873a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_f4d8@example.com', `Email` = 'user_43_f4d8@example.com', `NormalizedEmail` = 'USER_43_F4D8@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_F4D8', `PasswordHash` = 'mPQYMKtSbauhm8V6DKrdJdpOBhYg33+FAmPz8JPJAThua3LQVZ9CrNorDKzuya/0', `SecurityStamp` = 'user_43_f4d8@example.com', `UserName` = 'user_43_f4d8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_d28f@example.com', `Email` = 'user_44_d28f@example.com', `NormalizedEmail` = 'USER_44_D28F@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_D28F', `PasswordHash` = 'zBQ/sLNea5xkCmTGLodPqgjocG0cfcuvkCre81v/ZgupW03mV0gqoOIT9GrkA4fE', `SecurityStamp` = 'user_44_d28f@example.com', `UserName` = 'user_44_d28f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_9bdd@example.com', `Email` = 'user_45_9bdd@example.com', `NormalizedEmail` = 'USER_45_9BDD@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_9BDD', `PasswordHash` = 'odC2aiYfN0cqk+JtUZRkaQg7/ruLXXfXfTv3ti6HtUOzca/95Wwg/K6akZ+6FarJ', `SecurityStamp` = 'user_45_9bdd@example.com', `UserName` = 'user_45_9bdd'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_7d45@example.com', `Email` = 'user_46_7d45@example.com', `NormalizedEmail` = 'USER_46_7D45@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_7D45', `PasswordHash` = '3JkkvoN0KO+ufKskUJdQ8MdoBwbTtmTbpmfHyXyBGMuY2KtO6k3KFG4yrIVuf9iD', `SecurityStamp` = 'user_46_7d45@example.com', `UserName` = 'user_46_7d45'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_48cc@example.com', `Email` = 'user_47_48cc@example.com', `NormalizedEmail` = 'USER_47_48CC@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_48CC', `PasswordHash` = '5VY06uC2klzrxcHu1kuFZVwF0zcsTklTFe2MKmBw+nP0+dubaYt+ajZvZAzCT1Oc', `SecurityStamp` = 'user_47_48cc@example.com', `UserName` = 'user_47_48cc'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_fb05@example.com', `Email` = 'user_48_fb05@example.com', `NormalizedEmail` = 'USER_48_FB05@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_FB05', `PasswordHash` = '27f4q+0cQRnZKbECr68YNndqdmkeSic60hLwVRMPID62PN/CrfNWNDYBuGsUy1fS', `SecurityStamp` = 'user_48_fb05@example.com', `UserName` = 'user_48_fb05'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_813f@example.com', `Email` = 'user_49_813f@example.com', `NormalizedEmail` = 'USER_49_813F@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_813F', `PasswordHash` = 'IdQIfn8XE3aOS+jTGkdKU7m0P9Z8vRXHMMCsYlFylcuEpuqsQpUPBliByFbxEw6J', `SecurityStamp` = 'user_49_813f@example.com', `UserName` = 'user_49_813f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_6a52@example.com', `Email` = 'user_50_6a52@example.com', `NormalizedEmail` = 'USER_50_6A52@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_6A52', `PasswordHash` = '//057DRCgEvvFP7Zi7VYGMaCMUkqHRYQk492G3OR8FU6YfL+ZR5t+jsPLmw0OMSs', `SecurityStamp` = 'user_50_6a52@example.com', `UserName` = 'user_50_6a52'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = '+k+H6GPl4XJagn3kndeKw3FJ+tZhN6aYJsMSUX89XsC+kzwR74XLQ+8w5GgNwd89'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250323012038_BibliographyTable', '9.0.1');

CREATE TABLE `BibliographyItems` (
    `Id` char(36) NOT NULL,
    `Title` varchar(200) NOT NULL,
    `Author` varchar(100) NOT NULL,
    `Year` int NOT NULL,
    `Genre` varchar(50) NULL,
    `IsRead` tinyint(1) NOT NULL,
    `AttachmentId` char(36) NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `DeletedAt` datetime(6) NULL,
    `CreatedBy` longtext NOT NULL,
    `UpdatedBy` longtext NULL,
    `DeletedBy` longtext NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeletedMessage` longtext NULL,
    CONSTRAINT `PK_BibliographyItems` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_BibliographyItems_Attachments_AttachmentId` FOREIGN KEY (`AttachmentId`) REFERENCES `Attachments` (`Id`)
);

CREATE INDEX `IX_BibliographyItems_AttachmentId` ON `BibliographyItems` (`AttachmentId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250323020500_AddBibliographyItemsTableManually', '9.0.1');


                SET @tableExists = (SELECT COUNT(1) FROM information_schema.tables 
                                   WHERE table_schema = DATABASE() 
                                   AND table_name = 'ProjectMembers');
                
                SET @pkExists = (SELECT COUNT(1) FROM information_schema.table_constraints 
                               WHERE table_schema = DATABASE() 
                               AND table_name = 'ProjectMembers' 
                               AND constraint_type = 'PRIMARY KEY');
                
                SET @sql = IF(@tableExists > 0 AND @pkExists = 0, 
                            'ALTER TABLE `ProjectMembers` ADD PRIMARY KEY (`Id`)', 
                            'SELECT 1');
                
                PREPARE stmt FROM @sql;
                EXECUTE stmt;
                DEALLOCATE PREPARE stmt;
            

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250325090500_FixProjectMembersPrimaryKey', '9.0.1');

DROP PROCEDURE IF EXISTS `POMELO_BEFORE_DROP_PRIMARY_KEY`;
DELIMITER //
CREATE PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY`(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255))
BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID TINYINT(1);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `Extra` = 'auto_increment'
			AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END //
DELIMITER ;

DROP PROCEDURE IF EXISTS `POMELO_AFTER_ADD_PRIMARY_KEY`;
DELIMITER //
CREATE PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY`(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255), IN `COLUMN_NAME_ARGUMENT` VARCHAR(255))
BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID INT(11);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
			AND `COLUMN_TYPE` LIKE '%int%'
			AND `COLUMN_KEY` = 'PRI';
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL AUTO_INCREMENT;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END //
DELIMITER ;

ALTER TABLE `BibliographyItems` DROP FOREIGN KEY `FK_BibliographyItems_Attachment_AttachmentId`;

CALL POMELO_BEFORE_DROP_PRIMARY_KEY(NULL, 'ProjectMembers');
ALTER TABLE `ProjectMembers` DROP PRIMARY KEY;

ALTER TABLE `ProjectMembers` DROP INDEX `IX_ProjectMembers_UserId`;

DELETE FROM `Countries`
WHERE `Id` = '058ac7ea-0fa1-49a1-9aee-eec8bd95a099';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '0af6ddf2-fc14-4e80-aeb8-e7374ff31532';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '4104b34e-1d5f-4c09-a4bf-53b649ab5902';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '4773d13c-a6a4-46da-b589-53daa6027edb';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '512dddda-8b69-48bc-a4ed-abcea791117f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '6fc6c4f6-f5f0-4ef4-aad4-4e07aefb2c51';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7e40ff57-d825-4136-9c4e-f2a3d9d6f975';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '8cdcce16-0d4a-42ed-a11d-a14db328e2e2';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b0eb49c6-4484-4427-8496-e2f0dd50bd94';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'e7357a5a-ed1c-4630-9bef-68726e77cb69';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '02d16b39-068f-4e9b-9f83-5edf2138ed06';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '144e5560-6754-4a81-a1b1-545c59537696';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '536c3a5d-bd72-4e51-8537-f3b51372a88e';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'ecb5265f-d365-4c05-8924-e292a21bda89';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '157357bd-edd5-4611-9c24-739f70980a38';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '326bff6c-7c23-4c17-b5e7-86a11450e290';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '737d2787-2a1f-4571-b509-860beb7a98ae';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'd642684a-4c47-47a1-8109-f126f537efb9';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '6b7faddb-0152-494c-8108-08fddd931166';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'a5540390-cb48-4fc0-94a0-5438ab352523';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'b8c075e0-09a1-449a-8cad-37a2006bbfe1';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'c8c20fd6-4956-4e24-b21e-3cd3ccd88ec7';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'dc43b813-08ed-45fa-ba6a-80de59d85591';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'dda9e46f-4b95-4dc7-b42c-151e87e0408e';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = '2e3f723e-b24d-4d37-94a6-03d6ffff0de5';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '2598e53c-199e-48e5-9e6d-e6c7c8aff8a6';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '4d3918ed-0929-4d16-9b76-578832ed3669';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '88f9c01e-d6c4-4cfe-9b6b-166f0e1570d4';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '943bf88a-a95c-478d-b4e1-965115f81923';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'd8918f70-37a9-454f-9026-8591ecddb906';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'ebea86cf-6d3d-4dd0-a7fc-b762427b1ec1';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '2a6fc865-8476-4796-b6d4-456005259a2c';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'c34adfef-528c-48bd-8d36-634977b924a2';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'e2ff127b-c38f-46e5-afe6-685bb7d8f9d5';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'e49d36d9-e87d-4ff4-97a8-e0cb9b7f1483';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '6e0e428c-8961-44a1-86ad-af24c2d31f36';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '9bb4f5c3-c216-4ac2-914b-f29eebcc3abe';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'bc9c578e-e25b-43ae-aae2-741657fde460';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'c9ed37f3-f886-4ed3-847f-71f66503a3a7';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'e506c17b-9d79-4b92-ba2d-30eff6501335';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '1334022d-4e6e-4325-a5dd-58f4a301e801';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '6fbefcaf-0251-46a4-87dd-fc7727e9f832';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'c93703ad-1c7e-4b29-a748-f9a6238bf9e2';
SELECT ROW_COUNT();


ALTER TABLE `ProjectMembers` ADD `ProjectId1` char(36) COLLATE ascii_general_ci NULL;

ALTER TABLE `ProjectMembers` ADD CONSTRAINT `PK_ProjectMembers` PRIMARY KEY (`UserId`, `ProjectId`);

INSERT INTO `BibliographyItems` (`Id`, `AttachmentId`, `Author`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Genre`, `IsActive`, `IsDeleted`, `IsRead`, `Title`, `UpdatedAt`, `UpdatedBy`, `Year`)
VALUES ('61c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Robert C. Martin', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Software Development', TRUE, FALSE, TRUE, 'Clean Code: A Handbook of Agile Software Craftsmanship', NULL, NULL, 2008),
('71c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Andrew Hunt, David Thomas', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Software Development', TRUE, FALSE, TRUE, 'The Pragmatic Programmer', NULL, NULL, 1999),
('81c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Object-Oriented Programming', TRUE, FALSE, TRUE, 'Design Patterns: Elements of Reusable Object-Oriented Software', NULL, NULL, 1994),
('91c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Jon Skeet', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, '.NET', TRUE, FALSE, FALSE, 'C# in Depth', NULL, NULL, 2019),
('a1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Andrew Lock', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, '.NET', TRUE, FALSE, FALSE, 'ASP.NET Core in Action', NULL, NULL, 2021),
('b1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Eric Evans', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Software Architecture', TRUE, FALSE, TRUE, 'Domain-Driven Design: Tackling Complexity in the Heart of Software', NULL, NULL, 2003),
('c1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Martin Fowler', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Software Development', TRUE, FALSE, FALSE, 'Refactoring: Improving the Design of Existing Code', NULL, NULL, 2018),
('d1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Jon P Smith', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, '.NET', TRUE, FALSE, TRUE, 'Entity Framework Core in Action', NULL, NULL, 2018),
('e1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Robert C. Martin', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Software Architecture', TRUE, FALSE, TRUE, 'Clean Architecture: A Craftsman''s Guide to Software Structure and Design', NULL, NULL, 2017),
('f1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a', NULL, 'Martin Fowler', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Software Architecture', TRUE, FALSE, FALSE, 'Patterns of Enterprise Application Architecture', NULL, NULL, 2002);

INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('0cc46e58-47b1-45f9-86f5-284030c8e11c', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('200a8455-0f72-4c7c-82cb-88675715e23a', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('2e65ee89-dc6e-4db3-9302-46fae6f55aad', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('3c2d1b9e-aeea-4cc3-9974-0d9caf668a4b', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('403d0c06-5d1d-4673-8f5f-1cf1a3a836c9', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('4f08d041-9c36-44ab-ae4c-b02a4029e3e8', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('53d10411-e144-4215-91dd-360af9ec74fc', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL),
('5929cad3-9204-4b8f-a21f-a0b0a8a467c1', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('94ac6dcb-0180-4b82-9ea6-d7a62c51b28d', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('bef58820-204a-4f07-8cf3-fdea3b935dbf', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('1b86dde1-2092-4abe-9192-46bcff04c578', 'CHF', TIMESTAMP '2025-04-01 11:50:58', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('20f11132-4529-45c1-92da-adeeedd8bc23', 'GBP', TIMESTAMP '2025-04-01 11:50:58', 2, TRUE, 'British Pound', '£', NULL),
('5d65b1f3-c974-4a1e-bb78-4225065082ea', 'USD', TIMESTAMP '2025-04-01 11:50:58', 2, TRUE, 'US Dollar', '$', NULL),
('fd050ffa-5482-4f0f-9927-e23d7275dff6', 'EUR', TIMESTAMP '2025-04-01 11:50:58', 2, TRUE, 'Euro', '€', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('0916ab96-246e-47e4-a06b-febc9eb4d64d', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('96c23f59-45d3-4734-8894-eea79d8d811b', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('c9bbf220-dc03-4e10-8b87-66b0f4ccc629', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('cb204c93-59a6-43d3-8f29-258d047fe1de', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('3d96deae-d6e5-43d2-89b7-2b00ec491d5e', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL),
('b6231be4-d11b-42c1-9847-4e58c2648ea9', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('b7eae529-8cc7-43ac-beca-67b455061b38', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('ce59b538-8634-4f15-b65b-6ee7ad26cfb7', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('d33e6a09-fedb-49b1-a028-7a929a18ee37', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL),
('f046dd1a-5f1f-4841-86c7-0317b3876f89', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('fbbff75b-6ac8-45bd-b3a7-07373e22bd76', TIMESTAMP '2025-04-01 11:50:58', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1b61dfb5-49a0-4588-ae40-d17fbcdc8407', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL),
('6ad459ad-7a80-4bc8-b23a-465b845fbf03', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('8f74b354-db81-4667-8a6d-9f9fdc997ca6', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('ba7a14ee-244e-4cc3-8941-b4a79d63b258', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('e7bca87b-5862-4516-8c02-6148cac0f80d', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('fe07d465-fbc7-42e0-a28f-b9d9dcb15458', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('a7c13f04-56d4-46f0-b806-8a2f3c64ff51', NULL, TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL),
('ae9a985a-6451-4d85-916a-9aa6671d4035', NULL, TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('b84e9b02-59b9-40fa-a0a3-49160431fb8d', NULL, TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('eb2abc03-c95b-4264-89e4-827dcbdf91d0', NULL, TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('170475f5-d41e-46ac-ba6a-dd917c4ae77e', TIMESTAMP '2025-04-01 11:50:58', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('613f8cf1-1725-4b3b-ac0b-8551bc4770de', TIMESTAMP '2025-04-01 11:50:58', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00'),
('72148966-fa79-4e3e-954a-b5e8acd0334a', TIMESTAMP '2025-04-01 11:50:58', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('cdb17851-b58a-4b7c-a8e8-33c7ca72a39d', TIMESTAMP '2025-04-01 11:50:58', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('f784af2a-03b7-41de-9f7f-c436b610567a', TIMESTAMP '2025-04-01 11:50:58', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-04-01 11:50:58'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('52c2b275-b99e-453a-af41-c1d634338158', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL),
('6f1d6e4b-d8f0-4486-832f-769d25b4e0e2', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('867f2491-a693-4c28-a56c-5bdb123f5200', TIMESTAMP '2025-04-01 11:50:58', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'Sx5zAw4hfvKYNYDhWwph5gEysYgyEdWUxSgx+nF6USJA0ArWXboLt4fgKxchjNv3'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = '3SSROBJk8vxcuotrMv4du2kc5X4Tgq9dc1IxEmnYgtYfB/HD7696/6+C7ApZX1OM'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_9111@example.com', `Email` = 'user_1_9111@example.com', `NormalizedEmail` = 'USER_1_9111@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_9111', `PasswordHash` = '/+XHc3XwvKD3Llmqmhs9YSOHsmr1NUNWqps4V9RgJR2yaGNC/4+V9MAcFMAsuzDx', `SecurityStamp` = 'user_1_9111@example.com', `UserName` = 'user_1_9111'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_fc14@example.com', `Email` = 'user_2_fc14@example.com', `NormalizedEmail` = 'USER_2_FC14@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_FC14', `PasswordHash` = 'ryOTDDDKG82VO4UH4bWn0yJYFQv6jDkJSTYc7HqJuQVv088zMAFA6dy+RljB/j5L', `SecurityStamp` = 'user_2_fc14@example.com', `UserName` = 'user_2_fc14'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_955c@example.com', `Email` = 'user_3_955c@example.com', `NormalizedEmail` = 'USER_3_955C@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_955C', `PasswordHash` = 'jkSR2/M8oV1qBzSZRLj23hbu84r5Xwfc+JmZNKZc9vFG+jBDO4V2xqM90vfNouY+', `SecurityStamp` = 'user_3_955c@example.com', `UserName` = 'user_3_955c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_f59f@example.com', `Email` = 'user_4_f59f@example.com', `NormalizedEmail` = 'USER_4_F59F@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_F59F', `PasswordHash` = 'H54XRfJR6pEHOyh3rfOt64VB21FhSuNF+TK66YVGQKSk2EwQsti9xsAk7DPT6vLI', `SecurityStamp` = 'user_4_f59f@example.com', `UserName` = 'user_4_f59f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_af31@example.com', `Email` = 'user_5_af31@example.com', `NormalizedEmail` = 'USER_5_AF31@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_AF31', `PasswordHash` = '3WaESMbS4sQVYpWO/ZCGpRIrvl8onRmpXxw+VN3bWiARy0KEOoSh8WKPxE/zowxe', `SecurityStamp` = 'user_5_af31@example.com', `UserName` = 'user_5_af31'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_1c6f@example.com', `Email` = 'user_6_1c6f@example.com', `NormalizedEmail` = 'USER_6_1C6F@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_1C6F', `PasswordHash` = 'bGpGH07paiLCy6+26CdbcWki5bq5/S8PFVa5akt1+sNEYrYhWjL6McKzl7nB4DR6', `SecurityStamp` = 'user_6_1c6f@example.com', `UserName` = 'user_6_1c6f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_a16f@example.com', `Email` = 'user_7_a16f@example.com', `NormalizedEmail` = 'USER_7_A16F@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_A16F', `PasswordHash` = 'XOWq4fQltpDhlbuvUZ466hSlPiDGdtQdnNEzVYIvsXXpFt8DsAPsDhi0c27hEpto', `SecurityStamp` = 'user_7_a16f@example.com', `UserName` = 'user_7_a16f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_497e@example.com', `Email` = 'user_8_497e@example.com', `NormalizedEmail` = 'USER_8_497E@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_497E', `PasswordHash` = 'uAjsHI5c9aNVtSCpt/C3hnHdEHRWK7gHHKlmAjqOYnO0vj7MULLDWLczhEPweg5u', `SecurityStamp` = 'user_8_497e@example.com', `UserName` = 'user_8_497e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_53ea@example.com', `Email` = 'user_9_53ea@example.com', `NormalizedEmail` = 'USER_9_53EA@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_53EA', `PasswordHash` = 'J6rD7hozFN+dfAGMVuMRWrLLKX37iL741eZekbl+Ww55mYRJVSjFEzra66r5B18L', `SecurityStamp` = 'user_9_53ea@example.com', `UserName` = 'user_9_53ea'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_e9ba@example.com', `Email` = 'user_10_e9ba@example.com', `NormalizedEmail` = 'USER_10_E9BA@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_E9BA', `PasswordHash` = 'HgzFuA6es6vdq2hRWvIGRXShKYF6/EMTPes0z2+/APARmQks0Gd5s7y+n3Pn3XrI', `SecurityStamp` = 'user_10_e9ba@example.com', `UserName` = 'user_10_e9ba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_b054@example.com', `Email` = 'user_11_b054@example.com', `NormalizedEmail` = 'USER_11_B054@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_B054', `PasswordHash` = '+oJpj/aohnB1D2+tD8/zbpSA024NFoeQMjOaAhNCp9Iq9AZQME5zRuhhiM+Ym9PF', `SecurityStamp` = 'user_11_b054@example.com', `UserName` = 'user_11_b054'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_980e@example.com', `Email` = 'user_12_980e@example.com', `NormalizedEmail` = 'USER_12_980E@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_980E', `PasswordHash` = 'heR0A+8K9G5ghAJWDFSpJFDqr5vD8nlHO0FXPAE1WtlwDLKxC+D7oBIbI4CZzFIj', `SecurityStamp` = 'user_12_980e@example.com', `UserName` = 'user_12_980e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_92c3@example.com', `Email` = 'user_13_92c3@example.com', `NormalizedEmail` = 'USER_13_92C3@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_92C3', `PasswordHash` = 'j2Td0V+6KXYYKPYyX8q622uEFGrtv8GKeGdbd8CrwjklXr3wY3xma1Si7+54YObI', `SecurityStamp` = 'user_13_92c3@example.com', `UserName` = 'user_13_92c3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_9efa@example.com', `Email` = 'user_14_9efa@example.com', `NormalizedEmail` = 'USER_14_9EFA@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_9EFA', `PasswordHash` = 'xdnv+pH7x21zs5xxHU/b3oNA/gAMPf0pACi7aKHUE9g0DHr5i0nPZplM3lLY+7Cj', `SecurityStamp` = 'user_14_9efa@example.com', `UserName` = 'user_14_9efa'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_024b@example.com', `Email` = 'user_15_024b@example.com', `NormalizedEmail` = 'USER_15_024B@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_024B', `PasswordHash` = '6vf30BUFBgLzn6dtACiJMOVm9NVvCHQ5WympDFL8wWgLFc7Pck1HrrV0VxDSTJEa', `SecurityStamp` = 'user_15_024b@example.com', `UserName` = 'user_15_024b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_a93a@example.com', `Email` = 'user_16_a93a@example.com', `NormalizedEmail` = 'USER_16_A93A@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_A93A', `PasswordHash` = 'SsMRzC3Q0dMSLe8xraCATcrah3eXobz7Bbz3lrlzZJRH3KlbyeTlq4lNo0EGHbJd', `SecurityStamp` = 'user_16_a93a@example.com', `UserName` = 'user_16_a93a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_8f6e@example.com', `Email` = 'user_17_8f6e@example.com', `NormalizedEmail` = 'USER_17_8F6E@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_8F6E', `PasswordHash` = 'HkHvC9Q6mUTcVeZcOz5oQ6aJEvV5wVuN3/0i1uw5/p1CG/97GEZtp3CuhpZnQICg', `SecurityStamp` = 'user_17_8f6e@example.com', `UserName` = 'user_17_8f6e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_5ca0@example.com', `Email` = 'user_18_5ca0@example.com', `NormalizedEmail` = 'USER_18_5CA0@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_5CA0', `PasswordHash` = 'n8Geg1dNtxEmTE/22tR05Ofak31rnZqBC+ekHCpKiYV9bSyD8vY0OG2TGWVI7nVD', `SecurityStamp` = 'user_18_5ca0@example.com', `UserName` = 'user_18_5ca0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_3377@example.com', `Email` = 'user_19_3377@example.com', `NormalizedEmail` = 'USER_19_3377@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_3377', `PasswordHash` = 'asY1CPVC95SnH/hTdhfe7PepUpzYA4sl0QUHChDin7CLIk4384c3UyjScYuihVVw', `SecurityStamp` = 'user_19_3377@example.com', `UserName` = 'user_19_3377'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_c580@example.com', `Email` = 'user_20_c580@example.com', `NormalizedEmail` = 'USER_20_C580@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_C580', `PasswordHash` = 'f5wSPUWCjUDWMsp2dOoyowrMidEN18USesmGlgSs4KIwtqeEPJ6A3IVDh+EjPOgM', `SecurityStamp` = 'user_20_c580@example.com', `UserName` = 'user_20_c580'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_2ae4@example.com', `Email` = 'user_21_2ae4@example.com', `NormalizedEmail` = 'USER_21_2AE4@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_2AE4', `PasswordHash` = 'BU0yR+U+ZnPyaBCwoZ5DfO1yELZ8SABqfImmnJQao4eQh7JiN9XGej48lylZmmB7', `SecurityStamp` = 'user_21_2ae4@example.com', `UserName` = 'user_21_2ae4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_d930@example.com', `Email` = 'user_22_d930@example.com', `NormalizedEmail` = 'USER_22_D930@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_D930', `PasswordHash` = '1AfdRq8+3li0fDJ4YShlADH68fUNPlgSBWMV/gAH9wodUYpcgDssrcOYdwiLnmCA', `SecurityStamp` = 'user_22_d930@example.com', `UserName` = 'user_22_d930'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_629e@example.com', `Email` = 'user_23_629e@example.com', `NormalizedEmail` = 'USER_23_629E@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_629E', `PasswordHash` = '40l1b/K1XHBH34eTd14apfCdNhen/Yv05bZEnJ8qmAHws3/XX1WB3/2zpG6zT2Fx', `SecurityStamp` = 'user_23_629e@example.com', `UserName` = 'user_23_629e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_e4e4@example.com', `Email` = 'user_24_e4e4@example.com', `NormalizedEmail` = 'USER_24_E4E4@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_E4E4', `PasswordHash` = 'y0sZaHOdu7KazZjqIXf9ekvWP/qZaJHc4JVdSvBqLo4SU+tiVnrbUqeiUSwCgAWy', `SecurityStamp` = 'user_24_e4e4@example.com', `UserName` = 'user_24_e4e4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_1d7e@example.com', `Email` = 'user_25_1d7e@example.com', `NormalizedEmail` = 'USER_25_1D7E@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_1D7E', `PasswordHash` = 'GkRzUpYKH8ciiIl+4zEtGXwF0TyJGYvi4s8FqCIlfMsfJ9ploSm4C8qlY0jf0bDL', `SecurityStamp` = 'user_25_1d7e@example.com', `UserName` = 'user_25_1d7e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_db32@example.com', `Email` = 'user_26_db32@example.com', `NormalizedEmail` = 'USER_26_DB32@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_DB32', `PasswordHash` = 'k6GS03kiXEeXoAcmfjx86Fyp0/mZYrbnF6xLeCtDlIx+7PM562QlGvZLOBUhpaG5', `SecurityStamp` = 'user_26_db32@example.com', `UserName` = 'user_26_db32'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_5685@example.com', `Email` = 'user_27_5685@example.com', `NormalizedEmail` = 'USER_27_5685@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_5685', `PasswordHash` = 'DjiJjPUwtQQklDjKoPt4XuxaFnn2edAWNBwWbEiukYI10ZML+Q/s37rgpkpehMhy', `SecurityStamp` = 'user_27_5685@example.com', `UserName` = 'user_27_5685'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_2df5@example.com', `Email` = 'user_28_2df5@example.com', `NormalizedEmail` = 'USER_28_2DF5@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_2DF5', `PasswordHash` = 'F4Nzn1HyIZ/1gKknHVwedXQvBJnJhFrzYXpM8PGjtAIIvk/iwHgik30Fo3o1BpU9', `SecurityStamp` = 'user_28_2df5@example.com', `UserName` = 'user_28_2df5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_2fde@example.com', `Email` = 'user_29_2fde@example.com', `NormalizedEmail` = 'USER_29_2FDE@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_2FDE', `PasswordHash` = '9vHFHaj46gD4TgAQ6xs5N+mefWoCH4xVUHPT8gDks3o6UuXKGrSkrkF5mMOaWIv/', `SecurityStamp` = 'user_29_2fde@example.com', `UserName` = 'user_29_2fde'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_697a@example.com', `Email` = 'user_30_697a@example.com', `NormalizedEmail` = 'USER_30_697A@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_697A', `PasswordHash` = 'yRXdtLbjZwI4EkCeWzka/65DBmk/P3XTlpqtP70iBl61Azhu8k8TBF9VYPXxf53A', `SecurityStamp` = 'user_30_697a@example.com', `UserName` = 'user_30_697a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_a80a@example.com', `Email` = 'user_31_a80a@example.com', `NormalizedEmail` = 'USER_31_A80A@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_A80A', `PasswordHash` = 'tsfYOfQTGLDueCSzU6mjvP0rj1XXTBBiIJ6vwn9LMXIOXrfbuS0r/Hwkc+/DTall', `SecurityStamp` = 'user_31_a80a@example.com', `UserName` = 'user_31_a80a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_322a@example.com', `Email` = 'user_32_322a@example.com', `NormalizedEmail` = 'USER_32_322A@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_322A', `PasswordHash` = 'Wzv7GGo+u9BHqbYDP0d3w8H89jijcf9DUzuu5vNltsCDyllc0QkTpgtPJQwOUjdg', `SecurityStamp` = 'user_32_322a@example.com', `UserName` = 'user_32_322a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_7cba@example.com', `Email` = 'user_33_7cba@example.com', `NormalizedEmail` = 'USER_33_7CBA@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_7CBA', `PasswordHash` = 'Rq0vsVVLq3FdGmhA3PVIc7HkfI7Csn9KpAiAMaEn9FPcQkiEyRnf25JAG5lNfwPG', `SecurityStamp` = 'user_33_7cba@example.com', `UserName` = 'user_33_7cba'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_ee12@example.com', `Email` = 'user_34_ee12@example.com', `NormalizedEmail` = 'USER_34_EE12@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_EE12', `PasswordHash` = '/r13BSxFJyjF+w2nqnhajgKtseMRSSzqkYuelFVAfSMH0W58znhT3XJrqbRZRUL7', `SecurityStamp` = 'user_34_ee12@example.com', `UserName` = 'user_34_ee12'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_1afb@example.com', `Email` = 'user_35_1afb@example.com', `NormalizedEmail` = 'USER_35_1AFB@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_1AFB', `PasswordHash` = 'vmIxQph0MmYLPhazjdmEndP/2GUF6B2Th+rfFiVTF3VCGukg1X3A7GC5Z2FcdUe7', `SecurityStamp` = 'user_35_1afb@example.com', `UserName` = 'user_35_1afb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_d903@example.com', `Email` = 'user_36_d903@example.com', `NormalizedEmail` = 'USER_36_D903@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_D903', `PasswordHash` = 'HmZdngQY0iNivqtiAckl3UBGk7WZ0XyhAc2Ee4Kek9zs7/sKMkXsOxckOzEcDTNy', `SecurityStamp` = 'user_36_d903@example.com', `UserName` = 'user_36_d903'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_1cd4@example.com', `Email` = 'user_37_1cd4@example.com', `NormalizedEmail` = 'USER_37_1CD4@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_1CD4', `PasswordHash` = 'fo1Sy0jFnOrYyKoApFscrUqzLCVXa8PuONguQ8Ehkmv8dpmkh280NB3LzHiEtV64', `SecurityStamp` = 'user_37_1cd4@example.com', `UserName` = 'user_37_1cd4'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_ca26@example.com', `Email` = 'user_38_ca26@example.com', `NormalizedEmail` = 'USER_38_CA26@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_CA26', `PasswordHash` = 'SU0hnYZStTwAv3dzSFT34GMMnv6urguOLRFFI2W0wyZz3rWSN3xKkWW909AXOGeV', `SecurityStamp` = 'user_38_ca26@example.com', `UserName` = 'user_38_ca26'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_d222@example.com', `Email` = 'user_39_d222@example.com', `NormalizedEmail` = 'USER_39_D222@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_D222', `PasswordHash` = '5fEUgAzXTezSrSOvSSd80LMRIDb5G2ko+2fvR09AWkRDrQmegaoXEwjAA1scPS/j', `SecurityStamp` = 'user_39_d222@example.com', `UserName` = 'user_39_d222'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_a76b@example.com', `Email` = 'user_40_a76b@example.com', `NormalizedEmail` = 'USER_40_A76B@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_A76B', `PasswordHash` = 'xhnQ4dFyCts20atePTa1sqDghMNDRygC0KQIPCLXqY8w+yfu6t6BeOU7LP3w4fkW', `SecurityStamp` = 'user_40_a76b@example.com', `UserName` = 'user_40_a76b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_4855@example.com', `Email` = 'user_41_4855@example.com', `NormalizedEmail` = 'USER_41_4855@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_4855', `PasswordHash` = 'gu/5O7LnZrM7F5ii762XXUHWOE2kiN1Cv4tPpU49prum7JjvgVlYJk+4/31Tah4R', `SecurityStamp` = 'user_41_4855@example.com', `UserName` = 'user_41_4855'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_daf5@example.com', `Email` = 'user_42_daf5@example.com', `NormalizedEmail` = 'USER_42_DAF5@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_DAF5', `PasswordHash` = 'zx3iX954ajNRd6VVd9bJJtdw7g/vcU02bddwxbvyHvYUuI1YCA/qteF0hLZ922ny', `SecurityStamp` = 'user_42_daf5@example.com', `UserName` = 'user_42_daf5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_d096@example.com', `Email` = 'user_43_d096@example.com', `NormalizedEmail` = 'USER_43_D096@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_D096', `PasswordHash` = '6ZixlLvaVV7tRNr5PupEFwuRgNJWwOOqyOlllYhvErvgJHMtZVPle9OQFsqp/7MV', `SecurityStamp` = 'user_43_d096@example.com', `UserName` = 'user_43_d096'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_30f5@example.com', `Email` = 'user_44_30f5@example.com', `NormalizedEmail` = 'USER_44_30F5@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_30F5', `PasswordHash` = '7RMeI2cAyeJM4XxRJckc9H2LPtYDAZv720TlJjpHBzwB7+4JYAhdMRXm5/smzueL', `SecurityStamp` = 'user_44_30f5@example.com', `UserName` = 'user_44_30f5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_4771@example.com', `Email` = 'user_45_4771@example.com', `NormalizedEmail` = 'USER_45_4771@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_4771', `PasswordHash` = 'R0r/pZfzw3uKA6qw+wuQrPuEDQaL+Mzuwjoig6YJjiHpowhwlehWu2lailMuSIS1', `SecurityStamp` = 'user_45_4771@example.com', `UserName` = 'user_45_4771'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_e224@example.com', `Email` = 'user_46_e224@example.com', `NormalizedEmail` = 'USER_46_E224@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_E224', `PasswordHash` = 'deF7exCgdiRx8Xsg0RDeGRrs5SEmGAUDgp6MddzihZq9OtYL2K5JgKySU6PzzxlL', `SecurityStamp` = 'user_46_e224@example.com', `UserName` = 'user_46_e224'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_2156@example.com', `Email` = 'user_47_2156@example.com', `NormalizedEmail` = 'USER_47_2156@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_2156', `PasswordHash` = 'Q5OK8KV1MTewBFFazJe7IVLOb5ZpY1ljZQzKgVMlFtOhc5illzvdFI6vtl3vQllW', `SecurityStamp` = 'user_47_2156@example.com', `UserName` = 'user_47_2156'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_a143@example.com', `Email` = 'user_48_a143@example.com', `NormalizedEmail` = 'USER_48_A143@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_A143', `PasswordHash` = 'EO5LN0PHh/8/KSKNX1EgdQXDkRJs/jcWifNOzntkS2BKL2SsjPqFMDrNvC46QW6r', `SecurityStamp` = 'user_48_a143@example.com', `UserName` = 'user_48_a143'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_a2e9@example.com', `Email` = 'user_49_a2e9@example.com', `NormalizedEmail` = 'USER_49_A2E9@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_A2E9', `PasswordHash` = '6BTQuiEDBaP4zbV7Y3mKche4QnaZNuKJVBRpnG/iKedqXVrNSRkgkhXo/jJmXnqX', `SecurityStamp` = 'user_49_a2e9@example.com', `UserName` = 'user_49_a2e9'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_ce97@example.com', `Email` = 'user_50_ce97@example.com', `NormalizedEmail` = 'USER_50_CE97@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_CE97', `PasswordHash` = 'rymaZFm0ArXTo5kQbm2Cpnyo5ErqIcLbXDQ+peeWJ3cSaJzqfqRKGLleIkR8MRkK', `SecurityStamp` = 'user_50_ce97@example.com', `UserName` = 'user_50_ce97'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'ydtgl2iBisMeZI8EkgWEsMP5gm8jiqp2GgQ/8An+sOcBwxI9Dc1RDQRDo+mXpmUT'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


CREATE INDEX `IX_ProjectMembers_ProjectId1` ON `ProjectMembers` (`ProjectId1`);

ALTER TABLE `BibliographyItems` ADD CONSTRAINT `FK_BibliographyItems_Attachment_AttachmentId` FOREIGN KEY (`AttachmentId`) REFERENCES `Attachment` (`Id`) ON DELETE SET NULL;

ALTER TABLE `ProjectMembers` ADD CONSTRAINT `FK_ProjectMembers_Projects_ProjectId1` FOREIGN KEY (`ProjectId1`) REFERENCES `Projects` (`Id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250401115104_AddPortfolioEntity', '9.0.1');

DROP PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY`;

DROP PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY`;

DELETE FROM `Countries`
WHERE `Id` = '0cc46e58-47b1-45f9-86f5-284030c8e11c';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '200a8455-0f72-4c7c-82cb-88675715e23a';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '2e65ee89-dc6e-4db3-9302-46fae6f55aad';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3c2d1b9e-aeea-4cc3-9974-0d9caf668a4b';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '403d0c06-5d1d-4673-8f5f-1cf1a3a836c9';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '4f08d041-9c36-44ab-ae4c-b02a4029e3e8';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '53d10411-e144-4215-91dd-360af9ec74fc';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '5929cad3-9204-4b8f-a21f-a0b0a8a467c1';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '94ac6dcb-0180-4b82-9ea6-d7a62c51b28d';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'bef58820-204a-4f07-8cf3-fdea3b935dbf';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '1b86dde1-2092-4abe-9192-46bcff04c578';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '20f11132-4529-45c1-92da-adeeedd8bc23';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '5d65b1f3-c974-4a1e-bb78-4225065082ea';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'fd050ffa-5482-4f0f-9927-e23d7275dff6';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '0916ab96-246e-47e4-a06b-febc9eb4d64d';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '96c23f59-45d3-4734-8894-eea79d8d811b';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'c9bbf220-dc03-4e10-8b87-66b0f4ccc629';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'cb204c93-59a6-43d3-8f29-258d047fe1de';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '3d96deae-d6e5-43d2-89b7-2b00ec491d5e';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'b6231be4-d11b-42c1-9847-4e58c2648ea9';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'b7eae529-8cc7-43ac-beca-67b455061b38';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'ce59b538-8634-4f15-b65b-6ee7ad26cfb7';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'd33e6a09-fedb-49b1-a028-7a929a18ee37';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = 'f046dd1a-5f1f-4841-86c7-0317b3876f89';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'fbbff75b-6ac8-45bd-b3a7-07373e22bd76';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '1b61dfb5-49a0-4588-ae40-d17fbcdc8407';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '6ad459ad-7a80-4bc8-b23a-465b845fbf03';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '8f74b354-db81-4667-8a6d-9f9fdc997ca6';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'ba7a14ee-244e-4cc3-8941-b4a79d63b258';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'e7bca87b-5862-4516-8c02-6148cac0f80d';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'fe07d465-fbc7-42e0-a28f-b9d9dcb15458';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'a7c13f04-56d4-46f0-b806-8a2f3c64ff51';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'ae9a985a-6451-4d85-916a-9aa6671d4035';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'b84e9b02-59b9-40fa-a0a3-49160431fb8d';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'eb2abc03-c95b-4264-89e4-827dcbdf91d0';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '170475f5-d41e-46ac-ba6a-dd917c4ae77e';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '613f8cf1-1725-4b3b-ac0b-8551bc4770de';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '72148966-fa79-4e3e-954a-b5e8acd0334a';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'cdb17851-b58a-4b7c-a8e8-33c7ca72a39d';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'f784af2a-03b7-41de-9f7f-c436b610567a';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '52c2b275-b99e-453a-af41-c1d634338158';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '6f1d6e4b-d8f0-4486-832f-769d25b4e0e2';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '867f2491-a693-4c28-a56c-5bdb123f5200';
SELECT ROW_COUNT();


CREATE TABLE `Portfolios` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `OwnerId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Title` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Summary` longtext CHARACTER SET utf8mb4 NOT NULL,
    `AboutMarkdown` longtext CHARACTER SET utf8mb4 NOT NULL,
    `ExperienceMarkdown` longtext CHARACTER SET utf8mb4 NOT NULL,
    `PublicationsMarkdown` longtext CHARACTER SET utf8mb4 NOT NULL,
    `FundingMarkdown` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Visibility` int NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `DeletedAt` datetime(6) NULL,
    `CreatedBy` longtext CHARACTER SET utf8mb4 NOT NULL,
    `UpdatedBy` longtext CHARACTER SET utf8mb4 NULL,
    `DeletedBy` longtext CHARACTER SET utf8mb4 NULL,
    `IsActive` tinyint(1) NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeletedMessage` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Portfolios` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Portfolios_Users_OwnerId` FOREIGN KEY (`OwnerId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = '61c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = '71c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = '81c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = '91c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = 'a1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = 'b1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = 'c1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = 'd1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = 'e1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


UPDATE `BibliographyItems` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = 'f1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


INSERT INTO `Countries` (`Id`, `Capital`, `CreatedAt`, `IsActive`, `IsoCode`, `IsoCode3`, `Name`, `NativeName`, `PhoneCode`, `UpdatedAt`)
VALUES ('109fad37-2acb-405b-aea0-c29f78f87ff6', 'Amsterdam', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'NL', 'NLD', 'Netherlands', 'Nederland', '+31', NULL),
('21e4e312-f5f8-4fd0-a741-5ae68deec96e', 'Brussels', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'BE', 'BEL', 'Belgium', 'België', '+32', NULL),
('3a21f453-68ca-4034-852f-bb78345ecfba', 'Vienna', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'AT', 'AUT', 'Austria', 'Österreich', '+43', NULL),
('7ced98c7-412a-49d7-b99a-9bc6b762dd08', 'Madrid', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'ES', 'ESP', 'Spain', 'España', '+34', NULL),
('9a65046f-5f7c-4c5d-a010-99dac6d6fb3f', 'Paris', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'FR', 'FRA', 'France', 'France', '+33', NULL),
('a2d99c11-f214-47fa-9e80-beac0d41801a', 'Bern', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'CH', 'CHE', 'Switzerland', 'Schweiz', '+41', NULL),
('b7f15f04-5fc6-4082-9056-2b2092022f4e', 'London', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'GB', 'GBR', 'United Kingdom', 'United Kingdom', '+44', NULL),
('c5497f55-053e-4a40-b2ea-7e9000fdc395', 'Berlin', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'DE', 'DEU', 'Germany', 'Deutschland', '+49', NULL),
('cec2f4df-1527-42f3-89ec-645799fc8000', 'Rome', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'IT', 'ITA', 'Italy', 'Italia', '+39', NULL),
('fc1a87f1-99b7-4a34-966c-f33c27bffbee', 'Luxembourg', TIMESTAMP '2025-02-17 10:00:00', TRUE, 'LU', 'LUX', 'Luxembourg', 'Luxembourg', '+352', NULL);

INSERT INTO `Currencies` (`Id`, `Code`, `CreatedAt`, `DecimalPlaces`, `IsActive`, `Name`, `Symbol`, `UpdatedAt`)
VALUES ('00952b7a-2e63-4f27-b41e-cc050f33679c', 'CHF', TIMESTAMP '2025-04-01 16:05:27', 2, TRUE, 'Swiss Franc', 'Fr.', NULL),
('177a9999-f3ac-4b10-9ff4-49cd1bf3211c', 'GBP', TIMESTAMP '2025-04-01 16:05:27', 2, TRUE, 'British Pound', '£', NULL),
('b80920c1-15a4-4d3b-8450-5c314546f6c8', 'EUR', TIMESTAMP '2025-04-01 16:05:27', 2, TRUE, 'Euro', '€', NULL),
('f03fd365-388d-42ac-b6c0-b83fe5ece1bb', 'USD', TIMESTAMP '2025-04-01 16:05:27', 2, TRUE, 'US Dollar', '$', NULL);

INSERT INTO `DateFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `DisplayName`, `Example`, `Format`, `IsActive`, `IsDefault`, `IsDeleted`, `UpdatedAt`, `UpdatedBy`)
VALUES ('218574f2-4981-4aad-af41-94645297ea5e', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'ISO Date Format', '2024-12-31', 'yyyy-MM-dd', TRUE, FALSE, FALSE, NULL, NULL),
('2cfdadaa-e697-492b-a546-6412a82b5d1c', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Belgian Date Format (Dot)', '31.12.2024', 'dd.MM.yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('983b576e-6935-4d42-9a9a-09de0d3a197e', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'US Date Format', '12/31/2024', 'MM/dd/yyyy', TRUE, FALSE, FALSE, NULL, NULL),
('a194c629-dd6c-4c93-b7af-c41d7f65f562', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Belgian/European Date Format', '31/12/2024', 'dd/MM/yyyy', TRUE, FALSE, FALSE, NULL, NULL);

INSERT INTO `FileFormats` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `Extension`, `IsActive`, `IsDefault`, `IsDeleted`, `MaxSizeInMB`, `MimeType`, `Name`, `SupportsAnnotations`, `SupportsEditing`, `UpdatedAt`, `UpdatedBy`)
VALUES ('47f6b5e6-78ac-445f-b960-322d87a241e4', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Markdown text format', '.md', TRUE, FALSE, FALSE, 10, 'text/markdown', 'Markdown', TRUE, FALSE, NULL, NULL),
('5c7f476d-9650-4951-a930-b9bd8d5cea34', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'TypeScript React component file', '.tsx', TRUE, FALSE, FALSE, 10, 'application/typescript+react', 'TypeScript React', TRUE, FALSE, NULL, NULL),
('5eaa0e01-1cd2-4ae1-91ac-edebbbc10719', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'JavaScript source code file', '.js', TRUE, FALSE, FALSE, 10, 'application/javascript', 'JavaScript', TRUE, FALSE, NULL, NULL),
('63fd0ead-3f90-4aa5-92c2-e6075a2cc91c', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'TypeScript source code file', '.ts', TRUE, FALSE, FALSE, 10, 'application/typescript', 'TypeScript', TRUE, FALSE, NULL, NULL),
('7099462e-9e6f-4eb3-ad33-ade03a10b912', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Simple text document format', '.txt', TRUE, FALSE, FALSE, 10, 'text/plain', 'Plain Text', TRUE, FALSE, NULL, NULL),
('72e49c06-df15-41e9-875e-0565ae278a84', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'JavaScript Object Notation data file', '.json', TRUE, FALSE, FALSE, 10, 'application/json', 'JSON', TRUE, FALSE, NULL, NULL);

INSERT INTO `PaginationSettings` (`Id`, `CreatedAt`, `EnableInfiniteScroll`, `IsActive`, `IsDefault`, `ItemsPerPage`, `PageSizeOptions`, `ShowFirstLastButtons`, `ShowItemsCount`, `ShowPageNumbers`, `ShowPageSizeSelector`, `UpdatedAt`, `VisiblePageRange`)
VALUES ('f07c8a09-77b1-4742-a8ba-e62e52b46011', TIMESTAMP '2025-04-01 16:05:27', FALSE, TRUE, FALSE, 10, '[10,20,50,100]', TRUE, TRUE, TRUE, TRUE, NULL, 5);

INSERT INTO `Roles` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `UpdatedAt`, `UpdatedBy`)
VALUES ('1b288cb6-6948-4cfc-8d15-78774f6f149a', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Guest role is the least privileged role. They can only view public articles.', TRUE, FALSE, 'Guest', NULL, NULL),
('7fefe91f-29b4-4ca6-8dde-f2765c29830b', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.', TRUE, FALSE, 'Moderator', NULL, NULL),
('b0d10fdc-5fa6-4f4f-924e-1df51bbdaf68', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Has full control over the application and can manage all aspects.', TRUE, FALSE, 'SuperAdmin', NULL, NULL),
('d7286970-b68b-47b7-868d-d0f2ec5b1b68', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.', TRUE, FALSE, 'Editor', NULL, NULL),
('ea15de58-cff6-481f-886a-fc9223ab9bdf', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Admin role has full administrative privileges, except for application management.', TRUE, FALSE, 'Admin', NULL, NULL),
('ff9ce8bb-2ecc-40ea-8f31-124868b67b9e', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.', TRUE, FALSE, 'User', NULL, NULL);

INSERT INTO `Tags` (`Id`, `CommentId`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `PostId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('4cbb9c30-397f-4dc6-a8bb-c91bd18f5af4', NULL, TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Test Tag description', TRUE, FALSE, 'Test Tag name', NULL, 'test-tag-slug', NULL, NULL),
('5ef570e9-b9fd-49e6-a542-ab29ea5cf72b', NULL, TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Test Tag description 2', TRUE, FALSE, 'Test Tag name 2', NULL, 'test-tag-slug-2', NULL, NULL),
('64a15ff6-5753-43e1-8ad3-78710fd6a9f3', NULL, TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Test Tag description 4', TRUE, FALSE, 'Test Tag name 4', NULL, 'test-tag-slug-4', NULL, NULL),
('fd0c394b-4fbc-4330-ac37-50130d8d8843', NULL, TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Test Tag description 3', TRUE, FALSE, 'Test Tag name 3', NULL, 'test-tag-slug-3', NULL, NULL);

INSERT INTO `TimeZones` (`Id`, `CreatedAt`, `DstOffset`, `IsActive`, `Name`, `StandardName`, `UpdatedAt`, `UsesDaylightSaving`, `UtcOffset`)
VALUES ('38768416-1754-4b77-bcee-578340316f06', TIMESTAMP '2025-04-01 16:05:27', '+02:00', TRUE, 'UTC', 'Coordinated Universal Time', NULL, TRUE, '+00:00'),
('6648f55d-5e1f-48d8-bae4-f068a52017f9', TIMESTAMP '2025-04-01 16:05:27', '+02:00', TRUE, 'CEST', 'Central European Summer Time', NULL, TRUE, '+02:00'),
('930f8817-12f1-447f-a8da-fe6bb3cd156f', TIMESTAMP '2025-04-01 16:05:27', '+01:00', TRUE, 'WET', 'Western European Time', NULL, TRUE, '+00:00'),
('c8214769-c5c5-4b96-8d5e-2e28f53e67b2', TIMESTAMP '2025-04-01 16:05:27', '+02:00', TRUE, 'CET', 'Central European Time (Belgium)', NULL, TRUE, '+01:00'),
('df933175-638f-4831-89ce-9564b2df3797', TIMESTAMP '2025-04-01 16:05:27', '+03:00', TRUE, 'EET', 'Eastern European Time', NULL, TRUE, '+02:00');

UPDATE `Topics` SET `CreatedAt` = TIMESTAMP '2025-04-01 16:05:27'
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


INSERT INTO `Topics` (`Id`, `CreatedAt`, `CreatedBy`, `DeletedAt`, `DeletedBy`, `DeletedMessage`, `Description`, `IsActive`, `IsDeleted`, `Name`, `ParentTopicId`, `Slug`, `UpdatedAt`, `UpdatedBy`)
VALUES ('3d82ed20-fa3e-43ce-8cd7-82aab30f7594', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Test Topic description 4', TRUE, FALSE, 'Test Topic name 4', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-4', NULL, NULL),
('b9fe97ed-7a3b-4770-a9cb-c9e502bcaaab', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Test Topic description 2', TRUE, FALSE, 'Test Topic name 2', '1fa85f64-5717-4562-b3fc-2c963f66afa6', 'test-topic-slug-2', NULL, NULL),
('f67be590-6d8e-4d1c-a389-1954a3a04af4', TIMESTAMP '2025-04-01 16:05:27', 'System', NULL, NULL, NULL, 'Test Topic description 3', TRUE, FALSE, 'Test Topic name 3', NULL, 'test-topic-slug-3', NULL, NULL);

UPDATE `Users` SET `PasswordHash` = 'z1o14fDMFFAF5shoM0EneW8zvRjo7E8fOC3a9umNaeZ9oJIqQnvVEbkfxdtWD1Tn'
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = 'qut7PgRa+BNJs7QJAsuR0YLGhWl4bUbqhNk9EB5J4mSEoB9qim1CrGlQ2lEJ1Tgu'
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_1_45a5@example.com', `Email` = 'user_1_45a5@example.com', `NormalizedEmail` = 'USER_1_45A5@EXAMPLE.COM', `NormalizedUserName` = 'USER_1_45A5', `PasswordHash` = '94XEbRAO5sjM6+uSgN/aCTq/W8iIj/EejG8d6Gvcp1t/0nKcBzg8VoUhXm7mD3eX', `SecurityStamp` = 'user_1_45a5@example.com', `UserName` = 'user_1_45a5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_2_d8f6@example.com', `Email` = 'user_2_d8f6@example.com', `NormalizedEmail` = 'USER_2_D8F6@EXAMPLE.COM', `NormalizedUserName` = 'USER_2_D8F6', `PasswordHash` = 'k3jKYRq1znktMF+PqY/6MMXtrxFblqxc2SSEUPvhCNSUXfLlysvt+2hVUL4nvMJ5', `SecurityStamp` = 'user_2_d8f6@example.com', `UserName` = 'user_2_d8f6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_3_c6aa@example.com', `Email` = 'user_3_c6aa@example.com', `NormalizedEmail` = 'USER_3_C6AA@EXAMPLE.COM', `NormalizedUserName` = 'USER_3_C6AA', `PasswordHash` = 'z0sGY0QYLH9cF8LNkXEW6cq5b0XcIH6JKUrO1jEowgB+7Jvta2nIL7SLvSYk4a5r', `SecurityStamp` = 'user_3_c6aa@example.com', `UserName` = 'user_3_c6aa'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_4_e0d8@example.com', `Email` = 'user_4_e0d8@example.com', `NormalizedEmail` = 'USER_4_E0D8@EXAMPLE.COM', `NormalizedUserName` = 'USER_4_E0D8', `PasswordHash` = '2R/vxa45LXGqo4b8vAoTKhdFPtRjUjyB0F+k3+PM4Q5w3F+8QisBY83aBMO9U5/s', `SecurityStamp` = 'user_4_e0d8@example.com', `UserName` = 'user_4_e0d8'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_5_f0be@example.com', `Email` = 'user_5_f0be@example.com', `NormalizedEmail` = 'USER_5_F0BE@EXAMPLE.COM', `NormalizedUserName` = 'USER_5_F0BE', `PasswordHash` = 'j/L64mz6OvC0SbuzWi1f0Q9oPZ5GsvAOOrusNkoTwqipFHveWR6z9LPjFasLvuub', `SecurityStamp` = 'user_5_f0be@example.com', `UserName` = 'user_5_f0be'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_6_7fdb@example.com', `Email` = 'user_6_7fdb@example.com', `NormalizedEmail` = 'USER_6_7FDB@EXAMPLE.COM', `NormalizedUserName` = 'USER_6_7FDB', `PasswordHash` = 'LmFMAznjfIs/DW3H97rVQEIZBrtGN+L+s0dKg6vm6z6VXyuTy78Sj7uRV94BGndX', `SecurityStamp` = 'user_6_7fdb@example.com', `UserName` = 'user_6_7fdb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_7_9a99@example.com', `Email` = 'user_7_9a99@example.com', `NormalizedEmail` = 'USER_7_9A99@EXAMPLE.COM', `NormalizedUserName` = 'USER_7_9A99', `PasswordHash` = 'SNFb6UQKLcpliq0ebs/PH4vWhkA7enVjvFJkgP5GBq1uEIITNT4XZlOYWZFIfTF8', `SecurityStamp` = 'user_7_9a99@example.com', `UserName` = 'user_7_9a99'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_8_5760@example.com', `Email` = 'user_8_5760@example.com', `NormalizedEmail` = 'USER_8_5760@EXAMPLE.COM', `NormalizedUserName` = 'USER_8_5760', `PasswordHash` = 'TpwAonxJ8oYrSr0Mzl64N0eDppdwXn1L6yDVhMK4PhDUvVP73HWImYQVU11s9ARX', `SecurityStamp` = 'user_8_5760@example.com', `UserName` = 'user_8_5760'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_9_e5cf@example.com', `Email` = 'user_9_e5cf@example.com', `NormalizedEmail` = 'USER_9_E5CF@EXAMPLE.COM', `NormalizedUserName` = 'USER_9_E5CF', `PasswordHash` = '/ofDOL3NLHZQcmN3t0xvAmBiyeoRV5mdf14jb6oVXLo+oAFwGxlaRJhyyVVkufFP', `SecurityStamp` = 'user_9_e5cf@example.com', `UserName` = 'user_9_e5cf'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_10_d224@example.com', `Email` = 'user_10_d224@example.com', `NormalizedEmail` = 'USER_10_D224@EXAMPLE.COM', `NormalizedUserName` = 'USER_10_D224', `PasswordHash` = 'yPlCGO0DIGZErckh9FJrLjZzHnqb+I0S4r09AlcQNDDCRRVGo2w4djiqZEReSGAN', `SecurityStamp` = 'user_10_d224@example.com', `UserName` = 'user_10_d224'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_11_c69d@example.com', `Email` = 'user_11_c69d@example.com', `NormalizedEmail` = 'USER_11_C69D@EXAMPLE.COM', `NormalizedUserName` = 'USER_11_C69D', `PasswordHash` = '0mCa/qlV1vemzBAp3JSyxLJNm1gDc7BzMBMWQXyOSFykXwEFkRvduk8/48W70kpF', `SecurityStamp` = 'user_11_c69d@example.com', `UserName` = 'user_11_c69d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_12_d0d3@example.com', `Email` = 'user_12_d0d3@example.com', `NormalizedEmail` = 'USER_12_D0D3@EXAMPLE.COM', `NormalizedUserName` = 'USER_12_D0D3', `PasswordHash` = 'JFrsoh3KreW313ihR0bomQV/nltPBx4eyEZ710iaH/C++CgMWpvGznKPaTHjc2pc', `SecurityStamp` = 'user_12_d0d3@example.com', `UserName` = 'user_12_d0d3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_13_56b2@example.com', `Email` = 'user_13_56b2@example.com', `NormalizedEmail` = 'USER_13_56B2@EXAMPLE.COM', `NormalizedUserName` = 'USER_13_56B2', `PasswordHash` = 'Yc4woH94ICN5p8gJ4h9dm9B6FSNNCASkoY0RYe90jVj79uS/3Z55kiEpfGtwFBUg', `SecurityStamp` = 'user_13_56b2@example.com', `UserName` = 'user_13_56b2'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_14_f552@example.com', `Email` = 'user_14_f552@example.com', `NormalizedEmail` = 'USER_14_F552@EXAMPLE.COM', `NormalizedUserName` = 'USER_14_F552', `PasswordHash` = 'hafqs/bqfQFvdXmA4EiHuJp2Ny898TuYgICSTniwMaPx2SdmTwmn1+1v/fbm1XVM', `SecurityStamp` = 'user_14_f552@example.com', `UserName` = 'user_14_f552'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_15_f53e@example.com', `Email` = 'user_15_f53e@example.com', `NormalizedEmail` = 'USER_15_F53E@EXAMPLE.COM', `NormalizedUserName` = 'USER_15_F53E', `PasswordHash` = 'plv71I1fyJwDrHycTXengZaeRMH/QXmWXK8HDSDSG/ziX9lt24gz0Znurb5Mji1h', `SecurityStamp` = 'user_15_f53e@example.com', `UserName` = 'user_15_f53e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_16_00a6@example.com', `Email` = 'user_16_00a6@example.com', `NormalizedEmail` = 'USER_16_00A6@EXAMPLE.COM', `NormalizedUserName` = 'USER_16_00A6', `PasswordHash` = 'wJmW0fTVQWe6LaBhS9T75LhfGDL9Fk5f2Fuv1XkBOxuVxAiaQUg/DhTvBwI1U8ms', `SecurityStamp` = 'user_16_00a6@example.com', `UserName` = 'user_16_00a6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_17_c198@example.com', `Email` = 'user_17_c198@example.com', `NormalizedEmail` = 'USER_17_C198@EXAMPLE.COM', `NormalizedUserName` = 'USER_17_C198', `PasswordHash` = 'v0CfVvouUU8koO3mL2YJHAmoXSLgzPv2nn1MYBBMTRVVZqKDiowrKUttbNNtYNyG', `SecurityStamp` = 'user_17_c198@example.com', `UserName` = 'user_17_c198'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_18_ba62@example.com', `Email` = 'user_18_ba62@example.com', `NormalizedEmail` = 'USER_18_BA62@EXAMPLE.COM', `NormalizedUserName` = 'USER_18_BA62', `PasswordHash` = 'HrRFuG3APIPwt8Yhe3UhbdzSS+FafnZB1KKj83OlZK3tMkNij9Jy0A6s3ry4XJl0', `SecurityStamp` = 'user_18_ba62@example.com', `UserName` = 'user_18_ba62'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_19_eceb@example.com', `Email` = 'user_19_eceb@example.com', `NormalizedEmail` = 'USER_19_ECEB@EXAMPLE.COM', `NormalizedUserName` = 'USER_19_ECEB', `PasswordHash` = 'T07z/gl3fO6Y1jKBAUO2nLdIyAZV3I6xGHXgUicVhfyvk69Jy4EN2E5hNO8sj9Gu', `SecurityStamp` = 'user_19_eceb@example.com', `UserName` = 'user_19_eceb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_20_29f3@example.com', `Email` = 'user_20_29f3@example.com', `NormalizedEmail` = 'USER_20_29F3@EXAMPLE.COM', `NormalizedUserName` = 'USER_20_29F3', `PasswordHash` = 'VxvtQo/macrdtjRgAolGc/4Ds/jr2s0QuFv5X143GF+CiuzTWU3XfYv8q3v02kST', `SecurityStamp` = 'user_20_29f3@example.com', `UserName` = 'user_20_29f3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_21_29e3@example.com', `Email` = 'user_21_29e3@example.com', `NormalizedEmail` = 'USER_21_29E3@EXAMPLE.COM', `NormalizedUserName` = 'USER_21_29E3', `PasswordHash` = 'XbROUfy44h2GSmrSOwK0GwefjZdufSpRPa+X+1ZhK2BR+17MCVFh51YT1bd2yHox', `SecurityStamp` = 'user_21_29e3@example.com', `UserName` = 'user_21_29e3'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_22_3111@example.com', `Email` = 'user_22_3111@example.com', `NormalizedEmail` = 'USER_22_3111@EXAMPLE.COM', `NormalizedUserName` = 'USER_22_3111', `PasswordHash` = 'GzjxyEUIyk1rWSzWcLg94hDhLoXlbs9ZYrQxIkZRrJvu4IXqPFRZn3XuRrLmt+fD', `SecurityStamp` = 'user_22_3111@example.com', `UserName` = 'user_22_3111'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_23_8403@example.com', `Email` = 'user_23_8403@example.com', `NormalizedEmail` = 'USER_23_8403@EXAMPLE.COM', `NormalizedUserName` = 'USER_23_8403', `PasswordHash` = 'lSIBkWJ2HeLemjeXGtV3U2CNk2lTVl1aJFtxJpUlkPS/IB+sYadl7+RfMc7LmATD', `SecurityStamp` = 'user_23_8403@example.com', `UserName` = 'user_23_8403'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_24_ae17@example.com', `Email` = 'user_24_ae17@example.com', `NormalizedEmail` = 'USER_24_AE17@EXAMPLE.COM', `NormalizedUserName` = 'USER_24_AE17', `PasswordHash` = 'MZtMmPcSHg++HbABagsimVzCVY97xa1f6WPbn5K1qQJ7lCTlU6Ew28EgET5f0Bjp', `SecurityStamp` = 'user_24_ae17@example.com', `UserName` = 'user_24_ae17'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_25_40f5@example.com', `Email` = 'user_25_40f5@example.com', `NormalizedEmail` = 'USER_25_40F5@EXAMPLE.COM', `NormalizedUserName` = 'USER_25_40F5', `PasswordHash` = '9wHqbbvf4/yTg7CTJn0qqk3owB6IrWWYWh97rLgtMkQqn2t7pNxhr1CC3Jbw7F8g', `SecurityStamp` = 'user_25_40f5@example.com', `UserName` = 'user_25_40f5'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_26_307d@example.com', `Email` = 'user_26_307d@example.com', `NormalizedEmail` = 'USER_26_307D@EXAMPLE.COM', `NormalizedUserName` = 'USER_26_307D', `PasswordHash` = 'UVq2BGGkfmyDPYFlbVV1XDw9aRTQNPA6+EZ/PZwMeFTVNxiCQ37DmQdlvXz1U2pb', `SecurityStamp` = 'user_26_307d@example.com', `UserName` = 'user_26_307d'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_27_0b0a@example.com', `Email` = 'user_27_0b0a@example.com', `NormalizedEmail` = 'USER_27_0B0A@EXAMPLE.COM', `NormalizedUserName` = 'USER_27_0B0A', `PasswordHash` = 'BGOEB43jdQeJVLREMmC6lylHB+fBZB03w2V5Y555ef5Cbu9Mu50bAlyUViHujaoT', `SecurityStamp` = 'user_27_0b0a@example.com', `UserName` = 'user_27_0b0a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_28_0a11@example.com', `Email` = 'user_28_0a11@example.com', `NormalizedEmail` = 'USER_28_0A11@EXAMPLE.COM', `NormalizedUserName` = 'USER_28_0A11', `PasswordHash` = 'M2bgHZwbvFCyI0vfWnmZLg30wOzLUKf2RZTzWAJSOT1JO1W4C5MiEeohZ8tFvhJt', `SecurityStamp` = 'user_28_0a11@example.com', `UserName` = 'user_28_0a11'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_29_ca1e@example.com', `Email` = 'user_29_ca1e@example.com', `NormalizedEmail` = 'USER_29_CA1E@EXAMPLE.COM', `NormalizedUserName` = 'USER_29_CA1E', `PasswordHash` = 'vMl5qPjDBxd08v/8p+bYem0WdZukOKIKKp5Hxg9k3j8s19QHABl0Au2LGnblWhjF', `SecurityStamp` = 'user_29_ca1e@example.com', `UserName` = 'user_29_ca1e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_30_2711@example.com', `Email` = 'user_30_2711@example.com', `NormalizedEmail` = 'USER_30_2711@EXAMPLE.COM', `NormalizedUserName` = 'USER_30_2711', `PasswordHash` = '9L01GiwR3iSX4rs88EPq+KQhJ1V9/m3HBf2Ly70vtDVzclPhLOnd8X8BI9ut18gt', `SecurityStamp` = 'user_30_2711@example.com', `UserName` = 'user_30_2711'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_31_2522@example.com', `Email` = 'user_31_2522@example.com', `NormalizedEmail` = 'USER_31_2522@EXAMPLE.COM', `NormalizedUserName` = 'USER_31_2522', `PasswordHash` = 'g3rFDuh2TjMWH1onad33C+oYuRt7uHjF+bTwt94YR/56LJS/OvNBRJTnV2nxg51k', `SecurityStamp` = 'user_31_2522@example.com', `UserName` = 'user_31_2522'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_32_c27c@example.com', `Email` = 'user_32_c27c@example.com', `NormalizedEmail` = 'USER_32_C27C@EXAMPLE.COM', `NormalizedUserName` = 'USER_32_C27C', `PasswordHash` = 'xtgJ5BQ8ClI8bGgBrWr02HvG0VEwbVaw/MxpxY2Vhlj9/dLhAfQ8fF7WUozHblT7', `SecurityStamp` = 'user_32_c27c@example.com', `UserName` = 'user_32_c27c'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_33_da9a@example.com', `Email` = 'user_33_da9a@example.com', `NormalizedEmail` = 'USER_33_DA9A@EXAMPLE.COM', `NormalizedUserName` = 'USER_33_DA9A', `PasswordHash` = 'YQIVRrIhCXQxPulRFsfHiIYbk4GQ2h9DUlSUEaNPXjCYDKWwHu1XdWaymV1dMW2r', `SecurityStamp` = 'user_33_da9a@example.com', `UserName` = 'user_33_da9a'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_34_80ad@example.com', `Email` = 'user_34_80ad@example.com', `NormalizedEmail` = 'USER_34_80AD@EXAMPLE.COM', `NormalizedUserName` = 'USER_34_80AD', `PasswordHash` = 'c0jethrTYcJkxLgbP6y3SfMeOvz7gxxK1A7h/sFeUZMnmSb0HZY63ZVzjyoLC3Ro', `SecurityStamp` = 'user_34_80ad@example.com', `UserName` = 'user_34_80ad'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_35_c43e@example.com', `Email` = 'user_35_c43e@example.com', `NormalizedEmail` = 'USER_35_C43E@EXAMPLE.COM', `NormalizedUserName` = 'USER_35_C43E', `PasswordHash` = '45bucARY+oSYMCclBjwH/TiCdF5S7w1pbO02im+Isrni1gHo6wJbHCB3fK/J2d9g', `SecurityStamp` = 'user_35_c43e@example.com', `UserName` = 'user_35_c43e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_36_b16e@example.com', `Email` = 'user_36_b16e@example.com', `NormalizedEmail` = 'USER_36_B16E@EXAMPLE.COM', `NormalizedUserName` = 'USER_36_B16E', `PasswordHash` = 'jckJbKCzVs/g0yibKDGBG4UyqJhWZ6cJnqXvoprkrk51Dy8G1pQrhrjLcEZqQxjh', `SecurityStamp` = 'user_36_b16e@example.com', `UserName` = 'user_36_b16e'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_37_700f@example.com', `Email` = 'user_37_700f@example.com', `NormalizedEmail` = 'USER_37_700F@EXAMPLE.COM', `NormalizedUserName` = 'USER_37_700F', `PasswordHash` = 'Tw5qyKiaKk01+rO8Ok/i0sjwoHn9fnbFfPOfgmSpPJHMPMerHP7y8V6ExRh8nEw/', `SecurityStamp` = 'user_37_700f@example.com', `UserName` = 'user_37_700f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_38_808f@example.com', `Email` = 'user_38_808f@example.com', `NormalizedEmail` = 'USER_38_808F@EXAMPLE.COM', `NormalizedUserName` = 'USER_38_808F', `PasswordHash` = 'X0onDdvJssQk73KhOMF7N0LZff3mf6hP4cQhXCf7i08V0ht9+n+lSlFfoNAo8l4Z', `SecurityStamp` = 'user_38_808f@example.com', `UserName` = 'user_38_808f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_39_8424@example.com', `Email` = 'user_39_8424@example.com', `NormalizedEmail` = 'USER_39_8424@EXAMPLE.COM', `NormalizedUserName` = 'USER_39_8424', `PasswordHash` = 'AUWc6DRemfyPUPYJI7X7ZBHokMOPx2FCbVcCjwUuMpMcIiBT1v3B4l6GwvRCI06K', `SecurityStamp` = 'user_39_8424@example.com', `UserName` = 'user_39_8424'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_40_b3f0@example.com', `Email` = 'user_40_b3f0@example.com', `NormalizedEmail` = 'USER_40_B3F0@EXAMPLE.COM', `NormalizedUserName` = 'USER_40_B3F0', `PasswordHash` = '7sRrdzTamgGZBaQGirbjpAwG/UYd8VvvLv065inzw1LpHOUNh+ZjZnJcZkLn7ceT', `SecurityStamp` = 'user_40_b3f0@example.com', `UserName` = 'user_40_b3f0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_41_25bb@example.com', `Email` = 'user_41_25bb@example.com', `NormalizedEmail` = 'USER_41_25BB@EXAMPLE.COM', `NormalizedUserName` = 'USER_41_25BB', `PasswordHash` = 'FwMNY+inSod2CkKyg7gNJtkX7i6L+MTl7aadl33ZO6j3ebHGlew7do0AdifQmo7g', `SecurityStamp` = 'user_41_25bb@example.com', `UserName` = 'user_41_25bb'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_42_7f1b@example.com', `Email` = 'user_42_7f1b@example.com', `NormalizedEmail` = 'USER_42_7F1B@EXAMPLE.COM', `NormalizedUserName` = 'USER_42_7F1B', `PasswordHash` = 'qUaK5vXZuCjz+w/gaeiXKuygsP82UsLdeiVWq+WAKGs1fym45h0cWRY1PWgaPjk6', `SecurityStamp` = 'user_42_7f1b@example.com', `UserName` = 'user_42_7f1b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_43_3470@example.com', `Email` = 'user_43_3470@example.com', `NormalizedEmail` = 'USER_43_3470@EXAMPLE.COM', `NormalizedUserName` = 'USER_43_3470', `PasswordHash` = 'Td5g1NVP9cR0rvmYb12a2zlLaq/nTSy0rHYIUnfpipvqN8L+MG11K30ye3N2HGnj', `SecurityStamp` = 'user_43_3470@example.com', `UserName` = 'user_43_3470'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_44_4da0@example.com', `Email` = 'user_44_4da0@example.com', `NormalizedEmail` = 'USER_44_4DA0@EXAMPLE.COM', `NormalizedUserName` = 'USER_44_4DA0', `PasswordHash` = 'eCREwbiwN8StF0jnRquVbIt2O2SQZMkSsDp0QiME7SBCgi+UxX09lvNBVLdouUdU', `SecurityStamp` = 'user_44_4da0@example.com', `UserName` = 'user_44_4da0'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_45_1bb1@example.com', `Email` = 'user_45_1bb1@example.com', `NormalizedEmail` = 'USER_45_1BB1@EXAMPLE.COM', `NormalizedUserName` = 'USER_45_1BB1', `PasswordHash` = '8yooLrl79RG8BRS2LJyeeEbiJbWX0HQBVgew6pQH3wHdw3mEqWmmDvpOkCF/RMhO', `SecurityStamp` = 'user_45_1bb1@example.com', `UserName` = 'user_45_1bb1'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_46_7ac6@example.com', `Email` = 'user_46_7ac6@example.com', `NormalizedEmail` = 'USER_46_7AC6@EXAMPLE.COM', `NormalizedUserName` = 'USER_46_7AC6', `PasswordHash` = 'IxY5dhLD1+LPRAtlRgCia3AFGWp47Atns/TVAv0ilFYjy2VdsflFLTq2irW110rp', `SecurityStamp` = 'user_46_7ac6@example.com', `UserName` = 'user_46_7ac6'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_47_4853@example.com', `Email` = 'user_47_4853@example.com', `NormalizedEmail` = 'USER_47_4853@EXAMPLE.COM', `NormalizedUserName` = 'USER_47_4853', `PasswordHash` = 'lgIB2IBPo3hsi0BD74ntqmv5ZjbTKLmrJkGTI3Pk7UePcMn7+EKMvGTGGJHsVn40', `SecurityStamp` = 'user_47_4853@example.com', `UserName` = 'user_47_4853'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_48_5869@example.com', `Email` = 'user_48_5869@example.com', `NormalizedEmail` = 'USER_48_5869@EXAMPLE.COM', `NormalizedUserName` = 'USER_48_5869', `PasswordHash` = 's8USoDqKoAPKIUS7KOU7rF+wq8mum3+Wiz2jgxJC5hJ4kNtAjZRfJx7HTUaTb6nh', `SecurityStamp` = 'user_48_5869@example.com', `UserName` = 'user_48_5869'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_49_326f@example.com', `Email` = 'user_49_326f@example.com', `NormalizedEmail` = 'USER_49_326F@EXAMPLE.COM', `NormalizedUserName` = 'USER_49_326F', `PasswordHash` = 'KO4tRj9LimBl2eKqi59Kac03NUcBC/fJQ3UrGCotmqlGzguW9RXLL0Qq+V6+d77Z', `SecurityStamp` = 'user_49_326f@example.com', `UserName` = 'user_49_326f'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


UPDATE `Users` SET `ConcurrencyStamp` = 'user_50_aa3b@example.com', `Email` = 'user_50_aa3b@example.com', `NormalizedEmail` = 'USER_50_AA3B@EXAMPLE.COM', `NormalizedUserName` = 'USER_50_AA3B', `PasswordHash` = 'Qa42BdVctKszkrbEAVEuoe9gPvZd/LLVZSu5ChyMla6CqBC1jGwfocnqaPSRfjko', `SecurityStamp` = 'user_50_aa3b@example.com', `UserName` = 'user_50_aa3b'
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


UPDATE `Users` SET `PasswordHash` = '/iaNYV8qRjwsy+shsob4Rixcz7Qy03uGNWCEcUtUqSA6N0LrdUR2mpKQHx+qSSYm'
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


CREATE INDEX `IX_Portfolios_OwnerId` ON `Portfolios` (`OwnerId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250401160532_AddPortfoliosTable', '9.0.1');

DELETE FROM `BibliographyItems`
WHERE `Id` = '61c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = '71c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = '81c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = '91c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = 'a1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = 'b1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = 'c1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = 'd1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = 'e1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `BibliographyItems`
WHERE `Id` = 'f1c5d8f0-e3f5-4e7a-9cbb-6b178b2f5e7a';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '109fad37-2acb-405b-aea0-c29f78f87ff6';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '21e4e312-f5f8-4fd0-a741-5ae68deec96e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '3a21f453-68ca-4034-852f-bb78345ecfba';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '7ced98c7-412a-49d7-b99a-9bc6b762dd08';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = '9a65046f-5f7c-4c5d-a010-99dac6d6fb3f';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'a2d99c11-f214-47fa-9e80-beac0d41801a';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'b7f15f04-5fc6-4082-9056-2b2092022f4e';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'c5497f55-053e-4a40-b2ea-7e9000fdc395';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'cec2f4df-1527-42f3-89ec-645799fc8000';
SELECT ROW_COUNT();


DELETE FROM `Countries`
WHERE `Id` = 'fc1a87f1-99b7-4a34-966c-f33c27bffbee';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '00952b7a-2e63-4f27-b41e-cc050f33679c';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = '177a9999-f3ac-4b10-9ff4-49cd1bf3211c';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'b80920c1-15a4-4d3b-8450-5c314546f6c8';
SELECT ROW_COUNT();


DELETE FROM `Currencies`
WHERE `Id` = 'f03fd365-388d-42ac-b6c0-b83fe5ece1bb';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '218574f2-4981-4aad-af41-94645297ea5e';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '2cfdadaa-e697-492b-a546-6412a82b5d1c';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = '983b576e-6935-4d42-9a9a-09de0d3a197e';
SELECT ROW_COUNT();


DELETE FROM `DateFormats`
WHERE `Id` = 'a194c629-dd6c-4c93-b7af-c41d7f65f562';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '47f6b5e6-78ac-445f-b960-322d87a241e4';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5c7f476d-9650-4951-a930-b9bd8d5cea34';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '5eaa0e01-1cd2-4ae1-91ac-edebbbc10719';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '63fd0ead-3f90-4aa5-92c2-e6075a2cc91c';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '7099462e-9e6f-4eb3-ad33-ade03a10b912';
SELECT ROW_COUNT();


DELETE FROM `FileFormats`
WHERE `Id` = '72e49c06-df15-41e9-875e-0565ae278a84';
SELECT ROW_COUNT();


DELETE FROM `PaginationSettings`
WHERE `Id` = 'f07c8a09-77b1-4742-a8ba-e62e52b46011';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '1b288cb6-6948-4cfc-8d15-78774f6f149a';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = '7fefe91f-29b4-4ca6-8dde-f2765c29830b';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'b0d10fdc-5fa6-4f4f-924e-1df51bbdaf68';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'd7286970-b68b-47b7-868d-d0f2ec5b1b68';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'ea15de58-cff6-481f-886a-fc9223ab9bdf';
SELECT ROW_COUNT();


DELETE FROM `Roles`
WHERE `Id` = 'ff9ce8bb-2ecc-40ea-8f31-124868b67b9e';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '4cbb9c30-397f-4dc6-a8bb-c91bd18f5af4';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '5ef570e9-b9fd-49e6-a542-ab29ea5cf72b';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = '64a15ff6-5753-43e1-8ad3-78710fd6a9f3';
SELECT ROW_COUNT();


DELETE FROM `Tags`
WHERE `Id` = 'fd0c394b-4fbc-4330-ac37-50130d8d8843';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '38768416-1754-4b77-bcee-578340316f06';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '6648f55d-5e1f-48d8-bae4-f068a52017f9';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = '930f8817-12f1-447f-a8da-fe6bb3cd156f';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'c8214769-c5c5-4b96-8d5e-2e28f53e67b2';
SELECT ROW_COUNT();


DELETE FROM `TimeZones`
WHERE `Id` = 'df933175-638f-4831-89ce-9564b2df3797';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '3d82ed20-fa3e-43ce-8cd7-82aab30f7594';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'b9fe97ed-7a3b-4770-a9cb-c9e502bcaaab';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = 'f67be590-6d8e-4d1c-a389-1954a3a04af4';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '1048da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '1448da39-cdaf-47a9-9fb1-960d81dd704b';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb5';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb6';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb7';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb8';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fb9';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fba';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbb';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbc';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbd';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbe';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fbf';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc0';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc1';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc2';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc3';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc4';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc5';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc6';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc7';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc8';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fc9';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fca';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcb';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcc';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcd';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fce';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fcf';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd0';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd1';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd2';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd3';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd4';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd5';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd6';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd7';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd8';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fd9';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fda';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdb';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdc';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdd';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fde';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fdf';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe0';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe1';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe2';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe3';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe4';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe5';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '7fb725c6-3250-b856-604e-69f27e228fe6';
SELECT ROW_COUNT();


DELETE FROM `Users`
WHERE `Id` = '8048da39-cdaf-47a9-9fb1-960d81dd704a';
SELECT ROW_COUNT();


DELETE FROM `Topics`
WHERE `Id` = '1fa85f64-5717-4562-b3fc-2c963f66afa6';
SELECT ROW_COUNT();


ALTER TABLE `Portfolios` MODIFY COLUMN `Title` varchar(200) CHARACTER SET utf8mb4 NOT NULL;

ALTER TABLE `Portfolios` MODIFY COLUMN `Summary` varchar(500) CHARACTER SET utf8mb4 NOT NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250401171911_CreatePortfoliosTable', '9.0.1');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250606153225_UpdateDatabaseUser', '9.0.1');

COMMIT;

