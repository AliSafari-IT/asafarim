-- Create BibliographyItems table
CREATE TABLE IF NOT EXISTS `BibliographyItems` (
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
    PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

-- Create index for AttachmentId (without foreign key constraint for now)
CREATE INDEX `IX_BibliographyItems_AttachmentId` ON `BibliographyItems` (`AttachmentId`);
