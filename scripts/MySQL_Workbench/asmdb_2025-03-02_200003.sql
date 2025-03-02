-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: asmdb
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20250209203021_AddLanguageId','9.0.1'),('20250210185953_AddUserFields','9.0.1'),('20250214094625_UpdateUserAndSerilogConfig','9.0.1'),('20250214125033_SeedUpdated','9.0.1'),('20250214125631_SeedUsernameFixed','9.0.1'),('20250214131323_AddUserUniqueConstraints','9.0.1'),('20250214141510_UserUpdated','9.0.1'),('20250215162530_UserSeeded','9.0.1'),('20250216145832_UserReactivation','9.0.1'),('20250226084701_ProjectUpdated','9.0.1');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;

--
-- Table structure for table `accessibilitypreferences`
--

DROP TABLE IF EXISTS `accessibilitypreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accessibilitypreferences` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `EnableHighContrastMode` tinyint(1) NOT NULL,
  `EnableScreenReaderSupport` tinyint(1) NOT NULL,
  `TextScalingFactor` int NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accessibilitypreferences`
--

/*!40000 ALTER TABLE `accessibilitypreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `accessibilitypreferences` ENABLE KEYS */;

--
-- Table structure for table `attachment`
--

DROP TABLE IF EXISTS `attachment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attachment` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Url` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `FileName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Type` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Size` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `CreatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UpdatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `IsDeleted` tinyint(1) NOT NULL,
  `DeletedAt` datetime(6) DEFAULT NULL,
  `DeletedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attachment`
--

/*!40000 ALTER TABLE `attachment` DISABLE KEYS */;
/*!40000 ALTER TABLE `attachment` ENABLE KEYS */;

--
-- Table structure for table `attachmentpost`
--

DROP TABLE IF EXISTS `attachmentpost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attachmentpost` (
  `AttachmentsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`AttachmentsId`,`PostsId`),
  KEY `IX_AttachmentPost_PostsId` (`PostsId`),
  CONSTRAINT `FK_AttachmentPost_Attachment_AttachmentsId` FOREIGN KEY (`AttachmentsId`) REFERENCES `attachment` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AttachmentPost_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attachmentpost`
--

/*!40000 ALTER TABLE `attachmentpost` DISABLE KEYS */;
/*!40000 ALTER TABLE `attachmentpost` ENABLE KEYS */;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

/*!40000 ALTER TABLE `category` DISABLE KEYS */;
/*!40000 ALTER TABLE `category` ENABLE KEYS */;

--
-- Table structure for table `categorypost`
--

DROP TABLE IF EXISTS `categorypost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorypost` (
  `CategoriesId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`CategoriesId`,`PostsId`),
  KEY `IX_CategoryPost_PostsId` (`PostsId`),
  CONSTRAINT `FK_CategoryPost_Category_CategoriesId` FOREIGN KEY (`CategoriesId`) REFERENCES `category` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_CategoryPost_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorypost`
--

/*!40000 ALTER TABLE `categorypost` DISABLE KEYS */;
/*!40000 ALTER TABLE `categorypost` ENABLE KEYS */;

--
-- Table structure for table `comment`
--

DROP TABLE IF EXISTS `comment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comment` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Text` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `CreatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UpdatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `IsDeleted` tinyint(1) NOT NULL,
  `DeletedAt` datetime(6) DEFAULT NULL,
  `DeletedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DeletedMessage` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comment`
--

/*!40000 ALTER TABLE `comment` DISABLE KEYS */;
/*!40000 ALTER TABLE `comment` ENABLE KEYS */;

--
-- Table structure for table `commentpost`
--

DROP TABLE IF EXISTS `commentpost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commentpost` (
  `CommentsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`CommentsId`,`PostsId`),
  KEY `IX_CommentPost_PostsId` (`PostsId`),
  CONSTRAINT `FK_CommentPost_Comment_CommentsId` FOREIGN KEY (`CommentsId`) REFERENCES `comment` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_CommentPost_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commentpost`
--

/*!40000 ALTER TABLE `commentpost` DISABLE KEYS */;
/*!40000 ALTER TABLE `commentpost` ENABLE KEYS */;

--
-- Table structure for table `countries`
--

DROP TABLE IF EXISTS `countries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `countries` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `IsoCode` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsoCode3` varchar(3) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Capital` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NativeName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PhoneCode` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_Countries_IsoCode` (`IsoCode`),
  UNIQUE KEY `IX_Countries_IsoCode3` (`IsoCode3`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `countries`
--

/*!40000 ALTER TABLE `countries` DISABLE KEYS */;
INSERT INTO `countries` VALUES ('03d56106-5458-4634-a9ac-2b63c98d21f4','GB','GBR','United Kingdom','London','United Kingdom','+44',1,'2025-02-17 10:00:00.000000',NULL),('121391ed-b992-4768-93b3-87bb2ca7c29a','DE','DEU','Germany','Berlin','Deutschland','+49',1,'2025-02-17 10:00:00.000000',NULL),('1e73e38a-4295-4e6e-b756-6d6a658f937e','LU','LUX','Luxembourg','Luxembourg','Luxembourg','+352',1,'2025-02-17 10:00:00.000000',NULL),('299a1453-669e-4db8-b882-0335598784a8','IT','ITA','Italy','Rome','Italia','+39',1,'2025-02-17 10:00:00.000000',NULL),('338857c7-aca1-42a4-994c-6ecd87c8e772','ES','ESP','Spain','Madrid','España','+34',1,'2025-02-17 10:00:00.000000',NULL),('3efb797e-9e62-4e86-b05e-5037e461be9f','FR','FRA','France','Paris','France','+33',1,'2025-02-17 10:00:00.000000',NULL),('52752fd1-6850-4d46-b396-ac94a79a5380','NL','NLD','Netherlands','Amsterdam','Nederland','+31',1,'2025-02-17 10:00:00.000000',NULL),('8219507a-dc5a-4a02-b8c0-ba7ad1d1e835','CH','CHE','Switzerland','Bern','Schweiz','+41',1,'2025-02-17 10:00:00.000000',NULL),('b3bd33d2-150d-4b9d-bff0-dc257ba3f079','AT','AUT','Austria','Vienna','Österreich','+43',1,'2025-02-17 10:00:00.000000',NULL),('dde8c486-12e6-4fca-87a0-8b31bcf70050','BE','BEL','Belgium','Brussels','België','+32',1,'2025-02-17 10:00:00.000000',NULL);
/*!40000 ALTER TABLE `countries` ENABLE KEYS */;

--
-- Table structure for table `currencies`
--

DROP TABLE IF EXISTS `currencies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `currencies` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Code` varchar(3) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Symbol` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DecimalPlaces` int NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_Currencies_Code` (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `currencies`
--

/*!40000 ALTER TABLE `currencies` DISABLE KEYS */;
INSERT INTO `currencies` VALUES ('796fad72-78ac-44bb-a3e1-2f4f3a5299b3','CHF','Swiss Franc','Fr.',2,1,'2025-02-26 08:46:55.000000',NULL),('815b2eef-ed9c-4acc-a7bb-5a8aab2ad3da','USD','US Dollar','$',2,1,'2025-02-26 08:46:55.000000',NULL),('8b4e227b-1136-4b13-b83d-1655311188d2','EUR','Euro','€',2,1,'2025-02-26 08:46:55.000000',NULL),('b44d5f45-4546-4f46-b964-8307b31cfcfc','GBP','British Pound','£',2,1,'2025-02-26 08:46:55.000000',NULL);
/*!40000 ALTER TABLE `currencies` ENABLE KEYS */;

--
-- Table structure for table `dateformats`
--

DROP TABLE IF EXISTS `dateformats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dateformats` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Format` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DisplayName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Example` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsDefault` tinyint(1) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_DateFormats_Format` (`Format`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dateformats`
--

/*!40000 ALTER TABLE `dateformats` DISABLE KEYS */;
INSERT INTO `dateformats` VALUES ('0014142f-aa02-479b-bed1-410b7275b9c9','yyyy-MM-dd','ISO Date Format','2024-12-31',0,1,'2025-02-26 08:46:55.000000',NULL),('1d4dce87-947e-4483-ae34-8ff1729b276e','MM/dd/yyyy','US Date Format','12/31/2024',0,1,'2025-02-26 08:46:55.000000',NULL),('9550dee8-5d36-42ec-8407-ed59508a6a53','dd/MM/yyyy','Belgian/European Date Format','31/12/2024',0,1,'2025-02-26 08:46:55.000000',NULL),('fc4b405a-5579-4877-8e22-cee84044b62d','dd.MM.yyyy','Belgian Date Format (Dot)','31.12.2024',0,1,'2025-02-26 08:46:55.000000',NULL);
/*!40000 ALTER TABLE `dateformats` ENABLE KEYS */;

--
-- Table structure for table `fileformats`
--

DROP TABLE IF EXISTS `fileformats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fileformats` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Extension` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `MimeType` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `SupportsEditing` tinyint(1) NOT NULL,
  `SupportsAnnotations` tinyint(1) NOT NULL,
  `MaxSizeInMB` int NOT NULL,
  `IsDefault` tinyint(1) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_FileFormats_Extension` (`Extension`),
  UNIQUE KEY `IX_FileFormats_MimeType` (`MimeType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fileformats`
--

/*!40000 ALTER TABLE `fileformats` DISABLE KEYS */;
INSERT INTO `fileformats` VALUES ('16589182-3c84-4c2e-9af8-ee4f33a3022d','.tsx','TypeScript React','application/typescript+react','TypeScript React component file',0,1,10,0,1,'2025-02-26 08:46:55.000000',NULL),('5524fb23-d494-4511-961e-b9088806138b','.txt','Plain Text','text/plain','Simple text document format',0,1,10,0,1,'2025-02-26 08:46:55.000000',NULL),('55a26735-9e42-4a43-ae18-83aac29d8543','.md','Markdown','text/markdown','Markdown text format',0,1,10,0,1,'2025-02-26 08:46:55.000000',NULL),('5cb67213-fdcf-4719-a897-5147401d75c8','.ts','TypeScript','application/typescript','TypeScript source code file',0,1,10,0,1,'2025-02-26 08:46:55.000000',NULL),('64f25bd2-e453-4d41-a8ba-95d1b3fdd4f8','.js','JavaScript','application/javascript','JavaScript source code file',0,1,10,0,1,'2025-02-26 08:46:55.000000',NULL),('d8ee0a7a-ceb9-4810-a9eb-7706007d468b','.json','JSON','application/json','JavaScript Object Notation data file',0,1,10,0,1,'2025-02-26 08:46:55.000000',NULL);
/*!40000 ALTER TABLE `fileformats` ENABLE KEYS */;

--
-- Table structure for table `geographicalpreferences`
--

DROP TABLE IF EXISTS `geographicalpreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `geographicalpreferences` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `CountryId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `CurrencyId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `TimeZoneId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `DateFormatId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_GeographicalPreferences_CountryId` (`CountryId`),
  KEY `IX_GeographicalPreferences_CurrencyId` (`CurrencyId`),
  KEY `IX_GeographicalPreferences_DateFormatId` (`DateFormatId`),
  KEY `IX_GeographicalPreferences_TimeZoneId` (`TimeZoneId`),
  CONSTRAINT `FK_GeographicalPreferences_Countries_CountryId` FOREIGN KEY (`CountryId`) REFERENCES `countries` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_GeographicalPreferences_Currencies_CurrencyId` FOREIGN KEY (`CurrencyId`) REFERENCES `currencies` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_GeographicalPreferences_DateFormats_DateFormatId` FOREIGN KEY (`DateFormatId`) REFERENCES `dateformats` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_GeographicalPreferences_TimeZones_TimeZoneId` FOREIGN KEY (`TimeZoneId`) REFERENCES `timezones` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `geographicalpreferences`
--

/*!40000 ALTER TABLE `geographicalpreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `geographicalpreferences` ENABLE KEYS */;

--
-- Table structure for table `languagepreferences`
--

DROP TABLE IF EXISTS `languagepreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `languagepreferences` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Language` int NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `languagepreferences`
--

/*!40000 ALTER TABLE `languagepreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `languagepreferences` ENABLE KEYS */;

--
-- Table structure for table `link`
--

DROP TABLE IF EXISTS `link`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `link` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Url` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `CreatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UpdatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `IsDeleted` tinyint(1) NOT NULL,
  `DeletedAt` datetime(6) DEFAULT NULL,
  `DeletedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `link`
--

/*!40000 ALTER TABLE `link` DISABLE KEYS */;
/*!40000 ALTER TABLE `link` ENABLE KEYS */;

--
-- Table structure for table `linkpost`
--

DROP TABLE IF EXISTS `linkpost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `linkpost` (
  `LinksId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`LinksId`,`PostsId`),
  KEY `IX_LinkPost_PostsId` (`PostsId`),
  CONSTRAINT `FK_LinkPost_Link_LinksId` FOREIGN KEY (`LinksId`) REFERENCES `link` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_LinkPost_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `linkpost`
--

/*!40000 ALTER TABLE `linkpost` DISABLE KEYS */;
/*!40000 ALTER TABLE `linkpost` ENABLE KEYS */;

--
-- Table structure for table `markdownfilehistories`
--

DROP TABLE IF EXISTS `markdownfilehistories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `markdownfilehistories` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `MarkdownFileId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ContentSnapshot` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ChangedByUserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ChangedAt` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_MarkdownFileHistories_MarkdownFileId` (`MarkdownFileId`),
  CONSTRAINT `FK_MarkdownFileHistories_MarkdownFiles_MarkdownFileId` FOREIGN KEY (`MarkdownFileId`) REFERENCES `markdownfiles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `markdownfilehistories`
--

/*!40000 ALTER TABLE `markdownfilehistories` DISABLE KEYS */;
/*!40000 ALTER TABLE `markdownfilehistories` ENABLE KEYS */;

--
-- Table structure for table `markdownfiles`
--

DROP TABLE IF EXISTS `markdownfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `markdownfiles` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Title` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Content` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Visibility` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `AuthorName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `CreatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `UpdatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ProjectId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `ParentMdFileId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `Path` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_MarkdownFiles_CreatedBy` (`CreatedBy`),
  KEY `IX_MarkdownFiles_ParentMdFileId` (`ParentMdFileId`),
  KEY `IX_MarkdownFiles_ProjectId` (`ProjectId`),
  CONSTRAINT `FK_MarkdownFiles_MarkdownFiles_ParentMdFileId` FOREIGN KEY (`ParentMdFileId`) REFERENCES `markdownfiles` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_MarkdownFiles_Projects_ProjectId` FOREIGN KEY (`ProjectId`) REFERENCES `projects` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_MarkdownFiles_Users_CreatedBy` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `markdownfiles`
--

/*!40000 ALTER TABLE `markdownfiles` DISABLE KEYS */;
/*!40000 ALTER TABLE `markdownfiles` ENABLE KEYS */;

--
-- Table structure for table `markdownfileusers`
--

DROP TABLE IF EXISTS `markdownfileusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `markdownfileusers` (
  `MarkdownFileId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `DateCollaborated` datetime(6) NOT NULL,
  `CollaborationStopDate` datetime(6) DEFAULT NULL,
  `CollaborationRole` int NOT NULL,
  PRIMARY KEY (`MarkdownFileId`,`UserId`),
  KEY `IX_MarkdownFileUsers_UserId` (`UserId`),
  CONSTRAINT `FK_MarkdownFileUsers_MarkdownFiles_MarkdownFileId` FOREIGN KEY (`MarkdownFileId`) REFERENCES `markdownfiles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_MarkdownFileUsers_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `markdownfileusers`
--

/*!40000 ALTER TABLE `markdownfileusers` DISABLE KEYS */;
/*!40000 ALTER TABLE `markdownfileusers` ENABLE KEYS */;

--
-- Table structure for table `miscellaneouspreferences`
--

DROP TABLE IF EXISTS `miscellaneouspreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `miscellaneouspreferences` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `FileFormatId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PaginationSettingsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `EnableAutoSave` tinyint(1) NOT NULL,
  `EnableRealTimeUpdates` tinyint(1) NOT NULL,
  `DefaultDashboardView` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ShowActivityTimeline` tinyint(1) NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_MiscellaneousPreferences_FileFormatId` (`FileFormatId`),
  KEY `IX_MiscellaneousPreferences_PaginationSettingsId` (`PaginationSettingsId`),
  CONSTRAINT `FK_MiscellaneousPreferences_FileFormats_FileFormatId` FOREIGN KEY (`FileFormatId`) REFERENCES `fileformats` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_MiscellaneousPreferences_PaginationSettings_PaginationSettin~` FOREIGN KEY (`PaginationSettingsId`) REFERENCES `paginationsettings` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `miscellaneouspreferences`
--

/*!40000 ALTER TABLE `miscellaneouspreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `miscellaneouspreferences` ENABLE KEYS */;

--
-- Table structure for table `notificationpreferences`
--

DROP TABLE IF EXISTS `notificationpreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notificationpreferences` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ReceiveEmailNotifications` tinyint(1) NOT NULL,
  `ReceiveSmsNotifications` tinyint(1) NOT NULL,
  `IsSubscribedToNewsletter` tinyint(1) NOT NULL,
  `NotificationFrequencyInHours` int NOT NULL,
  `AllowMarketingEmails` tinyint(1) NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notificationpreferences`
--

/*!40000 ALTER TABLE `notificationpreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `notificationpreferences` ENABLE KEYS */;

--
-- Table structure for table `paginationsettings`
--

DROP TABLE IF EXISTS `paginationsettings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paginationsettings` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ItemsPerPage` int NOT NULL,
  `ShowPageNumbers` tinyint(1) NOT NULL,
  `ShowFirstLastButtons` tinyint(1) NOT NULL,
  `VisiblePageRange` int NOT NULL,
  `EnableInfiniteScroll` tinyint(1) NOT NULL,
  `ShowItemsCount` tinyint(1) NOT NULL,
  `ShowPageSizeSelector` tinyint(1) NOT NULL,
  `PageSizeOptions` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsDefault` tinyint(1) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paginationsettings`
--

/*!40000 ALTER TABLE `paginationsettings` DISABLE KEYS */;
INSERT INTO `paginationsettings` VALUES ('6193ac30-14b2-4c4d-be56-442ae714a47a',10,1,1,5,0,1,1,'[10,20,50,100]',0,1,'2025-02-26 08:46:55.000000',NULL);
/*!40000 ALTER TABLE `paginationsettings` ENABLE KEYS */;

--
-- Table structure for table `postattachment`
--

DROP TABLE IF EXISTS `postattachment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `postattachment` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `AttachmentId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PostAttachment_AttachmentId` (`AttachmentId`),
  KEY `IX_PostAttachment_PostId` (`PostId`),
  CONSTRAINT `FK_PostAttachment_MarkdownFiles_AttachmentId` FOREIGN KEY (`AttachmentId`) REFERENCES `markdownfiles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PostAttachment_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `postattachment`
--

/*!40000 ALTER TABLE `postattachment` DISABLE KEYS */;
/*!40000 ALTER TABLE `postattachment` ENABLE KEYS */;

--
-- Table structure for table `postcategory`
--

DROP TABLE IF EXISTS `postcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `postcategory` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `CategoryId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PostCategory_CategoryId` (`CategoryId`),
  KEY `IX_PostCategory_PostId` (`PostId`),
  CONSTRAINT `FK_PostCategory_Category_CategoryId` FOREIGN KEY (`CategoryId`) REFERENCES `category` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PostCategory_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `postcategory`
--

/*!40000 ALTER TABLE `postcategory` DISABLE KEYS */;
/*!40000 ALTER TABLE `postcategory` ENABLE KEYS */;

--
-- Table structure for table `postcollaborator`
--

DROP TABLE IF EXISTS `postcollaborator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `postcollaborator` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `CollaboratorId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `IsAdmin` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PostCollaborator_CollaboratorId` (`CollaboratorId`),
  KEY `IX_PostCollaborator_PostId` (`PostId`),
  CONSTRAINT `FK_PostCollaborator_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PostCollaborator_Users_CollaboratorId` FOREIGN KEY (`CollaboratorId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `postcollaborator`
--

/*!40000 ALTER TABLE `postcollaborator` DISABLE KEYS */;
/*!40000 ALTER TABLE `postcollaborator` ENABLE KEYS */;

--
-- Table structure for table `postcomment`
--

DROP TABLE IF EXISTS `postcomment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `postcomment` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Comment` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CommenterId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `CommentedAt` datetime(6) NOT NULL,
  `IsDeleted` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PostComment_CommenterId` (`CommenterId`),
  KEY `IX_PostComment_PostId` (`PostId`),
  CONSTRAINT `FK_PostComment_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PostComment_Users_CommenterId` FOREIGN KEY (`CommenterId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `postcomment`
--

/*!40000 ALTER TABLE `postcomment` DISABLE KEYS */;
/*!40000 ALTER TABLE `postcomment` ENABLE KEYS */;

--
-- Table structure for table `postlink`
--

DROP TABLE IF EXISTS `postlink`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `postlink` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `LinkId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PostLink_LinkId` (`LinkId`),
  KEY `IX_PostLink_PostId` (`PostId`),
  CONSTRAINT `FK_PostLink_MarkdownFiles_LinkId` FOREIGN KEY (`LinkId`) REFERENCES `markdownfiles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PostLink_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `postlink`
--

/*!40000 ALTER TABLE `postlink` DISABLE KEYS */;
/*!40000 ALTER TABLE `postlink` ENABLE KEYS */;

--
-- Table structure for table `postrelatedpost`
--

DROP TABLE IF EXISTS `postrelatedpost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `postrelatedpost` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PostRelatedPost_PostId` (`PostId`),
  CONSTRAINT `FK_PostRelatedPost_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `postrelatedpost`
--

/*!40000 ALTER TABLE `postrelatedpost` DISABLE KEYS */;
/*!40000 ALTER TABLE `postrelatedpost` ENABLE KEYS */;

--
-- Table structure for table `posts`
--

DROP TABLE IF EXISTS `posts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posts` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Title` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Content` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Summary` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Excerpt` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Slug` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `PublishedDate` datetime(6) DEFAULT NULL,
  `AuthorId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ViewCount` int NOT NULL,
  `CommentCount` int NOT NULL,
  `IsPublished` tinyint(1) NOT NULL,
  `IsDraft` tinyint(1) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `IsDeleted` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `DeletedAt` datetime(6) DEFAULT NULL,
  `CreatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UpdatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `DeletedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Status` int NOT NULL,
  `StatusMessage` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `StatusColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `StatusIcon` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `StatusTooltip` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `IsArchived` tinyint(1) NOT NULL,
  `AudioUrls` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `VideoUrls` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ImageUrls` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `MetaDescription` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Posts_AuthorId` (`AuthorId`),
  KEY `IX_Posts_PostId` (`PostId`),
  CONSTRAINT `FK_Posts_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`),
  CONSTRAINT `FK_Posts_Users_AuthorId` FOREIGN KEY (`AuthorId`) REFERENCES `users` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posts`
--

/*!40000 ALTER TABLE `posts` DISABLE KEYS */;
/*!40000 ALTER TABLE `posts` ENABLE KEYS */;

--
-- Table structure for table `posttag`
--

DROP TABLE IF EXISTS `posttag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posttag` (
  `PostsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `TagsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`PostsId`,`TagsId`),
  KEY `IX_PostTag_TagsId` (`TagsId`),
  CONSTRAINT `FK_PostTag_Posts_PostsId` FOREIGN KEY (`PostsId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PostTag_Tags_TagsId` FOREIGN KEY (`TagsId`) REFERENCES `tags` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posttag`
--

/*!40000 ALTER TABLE `posttag` DISABLE KEYS */;
/*!40000 ALTER TABLE `posttag` ENABLE KEYS */;

--
-- Table structure for table `posttags`
--

DROP TABLE IF EXISTS `posttags`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posttags` (
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `TagId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`PostId`,`TagId`),
  KEY `IX_PostTags_TagId` (`TagId`),
  CONSTRAINT `FK_PostTags_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PostTags_Tags_TagId` FOREIGN KEY (`TagId`) REFERENCES `tags` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posttags`
--

/*!40000 ALTER TABLE `posttags` DISABLE KEYS */;
/*!40000 ALTER TABLE `posttags` ENABLE KEYS */;

--
-- Table structure for table `privacypreferences`
--

DROP TABLE IF EXISTS `privacypreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `privacypreferences` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `IsProfilePublic` tinyint(1) NOT NULL,
  `AllowSearchByEmail` tinyint(1) NOT NULL,
  `EnableTwoFactorAuthentication` tinyint(1) NOT NULL,
  `AllowDataSharing` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `privacypreferences`
--

/*!40000 ALTER TABLE `privacypreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `privacypreferences` ENABLE KEYS */;

--
-- Table structure for table `progresshistories`
--

DROP TABLE IF EXISTS `progresshistories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `progresshistories` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ProjectId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ProgressPercentage` int NOT NULL,
  `Description` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Notes` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `PlannedBudget` double DEFAULT NULL,
  `ActualCost` double DEFAULT NULL,
  `BudgetVariance` double DEFAULT NULL,
  `PlannedStartDate` datetime(6) DEFAULT NULL,
  `ActualStartDate` datetime(6) DEFAULT NULL,
  `PlannedEndDate` datetime(6) DEFAULT NULL,
  `ActualEndDate` datetime(6) DEFAULT NULL,
  `TimeVarianceInDays` int DEFAULT NULL,
  `TotalMilestones` int NOT NULL,
  `CompletedMilestones` int NOT NULL,
  `CurrentStatus` int NOT NULL,
  `StatusReason` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `RiskLevel` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `RiskDescription` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `MitigationPlan` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `CreatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `UpdatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_ProgressHistories_ProjectId` (`ProjectId`),
  UNIQUE KEY `IX_ProgressHistories_StatusReason` (`StatusReason`),
  CONSTRAINT `FK_ProgressHistories_Projects_ProjectId` FOREIGN KEY (`ProjectId`) REFERENCES `projects` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `progresshistories`
--

/*!40000 ALTER TABLE `progresshistories` DISABLE KEYS */;
/*!40000 ALTER TABLE `progresshistories` ENABLE KEYS */;

--
-- Table structure for table `projectmembers`
--

DROP TABLE IF EXISTS `projectmembers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projectmembers` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ProjectId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ProjectMemberType` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProjectMembers_ProjectId` (`ProjectId`),
  KEY `IX_ProjectMembers_UserId` (`UserId`),
  CONSTRAINT `FK_ProjectMembers_Projects_ProjectId` FOREIGN KEY (`ProjectId`) REFERENCES `projects` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProjectMembers_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projectmembers`
--

/*!40000 ALTER TABLE `projectmembers` DISABLE KEYS */;
/*!40000 ALTER TABLE `projectmembers` ENABLE KEYS */;

--
-- Table structure for table `projects`
--

DROP TABLE IF EXISTS `projects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projects` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Name` varchar(120) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Description` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Visibility` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `OwnerId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `StartDate` datetime(6) DEFAULT NULL,
  `EndDate` datetime(6) DEFAULT NULL,
  `Status` int NOT NULL,
  `Budget` double DEFAULT NULL,
  `ActualBudget` double DEFAULT NULL,
  `RemainingBudget` double DEFAULT NULL,
  `IsCancelled` tinyint(1) NOT NULL,
  `IsCancelledby` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `IsCancelledAt` datetime(6) DEFAULT NULL,
  `IsCompleted` tinyint(1) NOT NULL,
  `IsCompletedAt` datetime(6) DEFAULT NULL,
  `IsCompletedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `IsPaused` tinyint(1) NOT NULL,
  `IsPausedTo` datetime(6) DEFAULT NULL,
  `IsExtended` tinyint(1) NOT NULL,
  `IsExtendedTo` datetime(6) DEFAULT NULL,
  `MarkdownFileId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Projects_MarkdownFileId` (`MarkdownFileId`),
  KEY `IX_Projects_OwnerId` (`OwnerId`),
  KEY `IX_Projects_UserId` (`UserId`),
  CONSTRAINT `FK_Projects_MarkdownFiles_MarkdownFileId` FOREIGN KEY (`MarkdownFileId`) REFERENCES `markdownfiles` (`Id`),
  CONSTRAINT `FK_Projects_Users_OwnerId` FOREIGN KEY (`OwnerId`) REFERENCES `users` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Projects_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projects`
--

/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
INSERT INTO `projects` VALUES ('5ba6b75f-467c-4593-97b5-288d6867bad5','qsd','sdf','Private','8048da39-cdaf-47a9-9fb1-960d81dd704a','2025-03-01 12:45:39.037184',NULL,'2025-02-24 00:00:00.000000','2025-03-26 00:00:00.000000',0,2,NULL,NULL,0,NULL,NULL,0,NULL,NULL,0,NULL,0,NULL,NULL,NULL),('69ba4277-783a-41a7-b45c-9ec2f8f104e3','sfhdfhfh',' ghfghf ','Private','8048da39-cdaf-47a9-9fb1-960d81dd704a','2025-03-01 12:51:49.038387',NULL,'2022-01-01 00:00:00.000000','2025-04-06 00:00:00.000000',4,10000,NULL,NULL,0,NULL,NULL,0,NULL,NULL,0,NULL,0,NULL,NULL,NULL),('868bdd95-944e-45dd-bdaf-3237ac3e5add','wxcv','xcvb','Private','8048da39-cdaf-47a9-9fb1-960d81dd704a','2025-02-26 11:47:17.528072',NULL,'2025-01-30 00:00:00.000000','2025-03-09 00:00:00.000000',0,3,NULL,NULL,0,NULL,NULL,0,NULL,NULL,0,NULL,0,NULL,NULL,NULL);
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `CreatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `UpdatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES ('1f410b04-92a2-4e72-97e5-f02ec4b0039f','Editor','Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.','2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL),('29a914f5-0d34-4aca-a2af-2a8d1090e12b','User','User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.','2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL),('3475bb84-3db4-4030-8895-cdd6b764938b','Moderator','Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.','2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL),('3bebe8c9-adcf-47cb-8c87-3a4ee7e9ceeb','SuperAdmin','Has full control over the application and can manage all aspects.','2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL),('413bbb51-64b3-4c52-8c91-667606c2aba4','Admin','Admin role has full administrative privileges, except for application management.','2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL),('bbbf5bb9-deec-4f2a-b705-861e5123ea5e','Guest','Guest role is the least privileged role. They can only view public articles.','2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL);
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;

--
-- Table structure for table `sitemapitems`
--

DROP TABLE IF EXISTS `sitemapitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sitemapitems` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PageName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Slug` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AccessByRole` int NOT NULL,
  `ParentId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `Order` int NOT NULL,
  `Icon` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `IsExternalLink` tinyint(1) NOT NULL,
  `ExternalLink` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsHidden` tinyint(1) NOT NULL,
  `IsDisabled` tinyint(1) NOT NULL,
  `IsDeleted` tinyint(1) NOT NULL,
  `CreatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UpdatedAt` datetime(6) NOT NULL,
  `DeletedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DeletedAt` datetime(6) DEFAULT NULL,
  `Version` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsPublished` tinyint(1) NOT NULL,
  `PublishedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PublishedDate` datetime(6) DEFAULT NULL,
  `UnpublishBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UnpublishDate` datetime(6) DEFAULT NULL,
  `IsUnpublished` tinyint(1) NOT NULL,
  `IsDraft` tinyint(1) NOT NULL,
  `IsArchived` tinyint(1) NOT NULL,
  `ArchivedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ArchivedDate` datetime(6) DEFAULT NULL,
  `ParentItemId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `Url` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastModified` datetime(6) NOT NULL,
  `ChangeFrequency` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Priority` double NOT NULL,
  `SitemapItemId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_SitemapItems_ParentItemId` (`ParentItemId`),
  KEY `IX_SitemapItems_SitemapItemId` (`SitemapItemId`),
  CONSTRAINT `FK_SitemapItems_SitemapItems_ParentItemId` FOREIGN KEY (`ParentItemId`) REFERENCES `sitemapitems` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_SitemapItems_SitemapItems_SitemapItemId` FOREIGN KEY (`SitemapItemId`) REFERENCES `sitemapitems` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sitemapitems`
--

/*!40000 ALTER TABLE `sitemapitems` DISABLE KEYS */;
/*!40000 ALTER TABLE `sitemapitems` ENABLE KEYS */;

--
-- Table structure for table `sitemapitemtopic`
--

DROP TABLE IF EXISTS `sitemapitemtopic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sitemapitemtopic` (
  `SitemapItemId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `TopicsId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`SitemapItemId`,`TopicsId`),
  KEY `IX_SitemapItemTopic_TopicsId` (`TopicsId`),
  CONSTRAINT `FK_SitemapItemTopic_SitemapItems_SitemapItemId` FOREIGN KEY (`SitemapItemId`) REFERENCES `sitemapitems` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_SitemapItemTopic_Topics_TopicsId` FOREIGN KEY (`TopicsId`) REFERENCES `topics` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sitemapitemtopic`
--

/*!40000 ALTER TABLE `sitemapitemtopic` DISABLE KEYS */;
/*!40000 ALTER TABLE `sitemapitemtopic` ENABLE KEYS */;

--
-- Table structure for table `tags`
--

DROP TABLE IF EXISTS `tags`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tags` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Slug` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_Tags_Slug` (`Slug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tags`
--

/*!40000 ALTER TABLE `tags` DISABLE KEYS */;
INSERT INTO `tags` VALUES ('01920b21-024d-4c6b-96f2-91235baf8a33','Test Tag name','Test Tag description','test-tag-slug','0001-01-01 00:00:00.000000',NULL),('07679d34-90b3-4d50-9848-3c2b96a6c1ec','Test Tag name 2','Test Tag description 2','test-tag-slug-2','0001-01-01 00:00:00.000000',NULL),('1fee52c8-5ed1-4218-aa16-a92f6d4ee17c','Test Tag name 4','Test Tag description 4','test-tag-slug-4','0001-01-01 00:00:00.000000',NULL),('73f7bac7-2c73-4869-b782-32a7f0979879','Test Tag name 3','Test Tag description 3','test-tag-slug-3','0001-01-01 00:00:00.000000',NULL);
/*!40000 ALTER TABLE `tags` ENABLE KEYS */;

--
-- Table structure for table `themepreferences`
--

DROP TABLE IF EXISTS `themepreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `themepreferences` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `IsDarkTheme` tinyint(1) NOT NULL,
  `FontSize` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LanguageId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `AccentColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BackgroundColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PrimaryColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `SecondaryColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TertiaryColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DarkModeTextColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LightModeTextColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DarkModeBackgroundColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LightModeBackgroundColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DarkModePrimaryColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LightModePrimaryColor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `CreatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `UpdatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `IsDarkModeEnabled` tinyint(1) NOT NULL,
  `IsHighContrastModeEnabled` tinyint(1) NOT NULL,
  `IsReducedMotionEnabled` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ThemePreferences_LanguageId` (`LanguageId`),
  CONSTRAINT `FK_ThemePreferences_LanguagePreferences_LanguageId` FOREIGN KEY (`LanguageId`) REFERENCES `languagepreferences` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `themepreferences`
--

/*!40000 ALTER TABLE `themepreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `themepreferences` ENABLE KEYS */;

--
-- Table structure for table `timezones`
--

DROP TABLE IF EXISTS `timezones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `timezones` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `StandardName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UtcOffset` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UsesDaylightSaving` tinyint(1) NOT NULL,
  `DstOffset` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_TimeZones_StandardName` (`StandardName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `timezones`
--

/*!40000 ALTER TABLE `timezones` DISABLE KEYS */;
INSERT INTO `timezones` VALUES ('037a08e2-1b3c-42aa-9865-4ebebb77cf8e','UTC','Coordinated Universal Time','+00:00',1,'+02:00',1,'2025-02-26 08:46:55.000000',NULL),('2988f9fb-364a-4aae-928f-7ed10e181422','CEST','Central European Summer Time','+02:00',1,'+02:00',1,'2025-02-26 08:46:55.000000',NULL),('39b77345-c09e-4982-98d3-f6dc9ea26ecf','WET','Western European Time','+00:00',1,'+01:00',1,'2025-02-26 08:46:55.000000',NULL),('5f6d88c8-c02b-419d-b4c3-b57e8d8915ef','EET','Eastern European Time','+02:00',1,'+03:00',1,'2025-02-26 08:46:55.000000',NULL),('ac5cff22-6ec5-46a7-86c5-f782ba2a47fa','CET','Central European Time (Belgium)','+01:00',1,'+02:00',1,'2025-02-26 08:46:55.000000',NULL);
/*!40000 ALTER TABLE `timezones` ENABLE KEYS */;

--
-- Table structure for table `topics`
--

DROP TABLE IF EXISTS `topics`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `topics` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Slug` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `ParentTopicId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `CreatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `UpdatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_Topics_Slug` (`Slug`),
  KEY `IX_Topics_ParentTopicId` (`ParentTopicId`),
  CONSTRAINT `FK_Topics_Topics_ParentTopicId` FOREIGN KEY (`ParentTopicId`) REFERENCES `topics` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `topics`
--

/*!40000 ALTER TABLE `topics` DISABLE KEYS */;
INSERT INTO `topics` VALUES ('0e7c8fb9-ec48-4db2-a935-01b1fff7a35c','Test Topic name 2','Test Topic description 2','test-topic-slug-2','3fa85f64-5717-4562-b3fc-2c963f66afa6','2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL),('3fa85f64-5717-4562-b3fc-2c963f66afa6','Test Topic name','Test Topic description','test-topic-slug',NULL,'2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL),('ca75b08f-c5fa-48e5-bc55-fb60642bed4a','Test Topic name 3','Test Topic description 3','test-topic-slug-3',NULL,'2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL),('e1ffebc9-e2ab-4fbc-9af0-6f5a1929418d','Test Topic name 4','Test Topic description 4','test-topic-slug-4','3fa85f64-5717-4562-b3fc-2c963f66afa6','2025-02-26 08:46:55.000000',NULL,'00000000-0000-0000-0000-000000000000',NULL);
/*!40000 ALTER TABLE `topics` ENABLE KEYS */;

--
-- Table structure for table `useraccessibilitypreferences`
--

DROP TABLE IF EXISTS `useraccessibilitypreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `useraccessibilitypreferences` (
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `AccessibilityPreferenceId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`AccessibilityPreferenceId`),
  KEY `IX_UserAccessibilityPreferences_AccessibilityPreferenceId` (`AccessibilityPreferenceId`),
  CONSTRAINT `FK_UserAccessibilityPreferences_AccessibilityPreferences_Access~` FOREIGN KEY (`AccessibilityPreferenceId`) REFERENCES `accessibilitypreferences` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_UserAccessibilityPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useraccessibilitypreferences`
--

/*!40000 ALTER TABLE `useraccessibilitypreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `useraccessibilitypreferences` ENABLE KEYS */;

--
-- Table structure for table `usergeographicalpreferences`
--

DROP TABLE IF EXISTS `usergeographicalpreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usergeographicalpreferences` (
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `GeographicalPreferenceId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`GeographicalPreferenceId`),
  KEY `IX_UserGeographicalPreferences_GeographicalPreferenceId` (`GeographicalPreferenceId`),
  CONSTRAINT `FK_UserGeographicalPreferences_GeographicalPreferences_Geograph~` FOREIGN KEY (`GeographicalPreferenceId`) REFERENCES `geographicalpreferences` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_UserGeographicalPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usergeographicalpreferences`
--

/*!40000 ALTER TABLE `usergeographicalpreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `usergeographicalpreferences` ENABLE KEYS */;

--
-- Table structure for table `userlanguagepreferences`
--

DROP TABLE IF EXISTS `userlanguagepreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userlanguagepreferences` (
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `LanguagePreferenceId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`LanguagePreferenceId`),
  KEY `IX_UserLanguagePreferences_LanguagePreferenceId` (`LanguagePreferenceId`),
  CONSTRAINT `FK_UserLanguagePreferences_LanguagePreferences_LanguagePreferen~` FOREIGN KEY (`LanguagePreferenceId`) REFERENCES `languagepreferences` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_UserLanguagePreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlanguagepreferences`
--

/*!40000 ALTER TABLE `userlanguagepreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `userlanguagepreferences` ENABLE KEYS */;

--
-- Table structure for table `usermiscellaneouspreferences`
--

DROP TABLE IF EXISTS `usermiscellaneouspreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usermiscellaneouspreferences` (
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `MiscellaneousPreferenceId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`MiscellaneousPreferenceId`),
  KEY `IX_UserMiscellaneousPreferences_MiscellaneousPreferenceId` (`MiscellaneousPreferenceId`),
  CONSTRAINT `FK_UserMiscellaneousPreferences_MiscellaneousPreferences_Miscel~` FOREIGN KEY (`MiscellaneousPreferenceId`) REFERENCES `miscellaneouspreferences` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_UserMiscellaneousPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usermiscellaneouspreferences`
--

/*!40000 ALTER TABLE `usermiscellaneouspreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `usermiscellaneouspreferences` ENABLE KEYS */;

--
-- Table structure for table `usernotificationpreferences`
--

DROP TABLE IF EXISTS `usernotificationpreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usernotificationpreferences` (
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `NotificationPreferenceId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`NotificationPreferenceId`),
  KEY `IX_UserNotificationPreferences_NotificationPreferenceId` (`NotificationPreferenceId`),
  CONSTRAINT `FK_UserNotificationPreferences_NotificationPreferences_Notifica~` FOREIGN KEY (`NotificationPreferenceId`) REFERENCES `notificationpreferences` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_UserNotificationPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usernotificationpreferences`
--

/*!40000 ALTER TABLE `usernotificationpreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `usernotificationpreferences` ENABLE KEYS */;

--
-- Table structure for table `userprivacypreferences`
--

DROP TABLE IF EXISTS `userprivacypreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userprivacypreferences` (
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `PrivacyPreferenceId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`PrivacyPreferenceId`),
  KEY `IX_UserPrivacyPreferences_PrivacyPreferenceId` (`PrivacyPreferenceId`),
  CONSTRAINT `FK_UserPrivacyPreferences_PrivacyPreferences_PrivacyPreferenceId` FOREIGN KEY (`PrivacyPreferenceId`) REFERENCES `privacypreferences` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_UserPrivacyPreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userprivacypreferences`
--

/*!40000 ALTER TABLE `userprivacypreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `userprivacypreferences` ENABLE KEYS */;

--
-- Table structure for table `userroles`
--

DROP TABLE IF EXISTS `userroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userroles` (
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `RoleId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_UserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_UserRoles_Roles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `roles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_UserRoles_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userroles`
--

/*!40000 ALTER TABLE `userroles` DISABLE KEYS */;
INSERT INTO `userroles` VALUES ('7fb725c6-3250-b856-604e-69f27e228fb5','1f410b04-92a2-4e72-97e5-f02ec4b0039f'),('7fb725c6-3250-b856-604e-69f27e228fb5','29a914f5-0d34-4aca-a2af-2a8d1090e12b'),('7fb725c6-3250-b856-604e-69f27e228fb9','3475bb84-3db4-4030-8895-cdd6b764938b');
/*!40000 ALTER TABLE `userroles` ENABLE KEYS */;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsAdmin` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `ProfilePicture` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `DateOfBirth` datetime(6) DEFAULT NULL,
  `LastLogin` datetime(6) DEFAULT NULL,
  `FailedLoginAttempts` int NOT NULL,
  `IsLockedOut` tinyint(1) NOT NULL,
  `PenName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Website` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Biography` varchar(1500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `FirstName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LinkUrl` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UpdatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `CreatedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `IsDeleted` tinyint(1) NOT NULL DEFAULT '0',
  `UpdatedAt` datetime(6) DEFAULT NULL,
  `DeletedBy` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `DeletedAt` datetime(6) DEFAULT NULL,
  `IsActive` tinyint(1) DEFAULT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) DEFAULT NULL,
  `PostId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci DEFAULT NULL,
  `UserName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NormalizedUserName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NormalizedEmail` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `EmailConfirmed` tinyint(1) DEFAULT NULL,
  `PasswordHash` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `SecurityStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PhoneNumber` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `TwoFactorEnabled` tinyint(1) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int NOT NULL,
  `IsBannedByAdmin` tinyint(1) NOT NULL DEFAULT '0',
  `IsBlocked` tinyint(1) NOT NULL DEFAULT '0',
  `IsEditor` tinyint(1) NOT NULL DEFAULT '0',
  `IsModerator` tinyint(1) NOT NULL DEFAULT '0',
  `IsPending` tinyint(1) NOT NULL DEFAULT '0',
  `IsStandardUser` tinyint(1) NOT NULL DEFAULT '0',
  `IsSuperAdmin` tinyint(1) NOT NULL DEFAULT '0',
  `IsVerified` tinyint(1) NOT NULL DEFAULT '0',
  `ForgotPasswordToken` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ForgotPasswordTokenExpiration` datetime(6) DEFAULT NULL,
  `IsGuest` tinyint(1) NOT NULL DEFAULT '0',
  `PasswordResetToken` datetime(6) DEFAULT NULL,
  `IsUser` tinyint(1) NOT NULL DEFAULT '0',
  `PasswordResetTokenExpiration` datetime(6) DEFAULT NULL,
  `ReactivationReason` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ReactivationRequestedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_Users_Email` (`Email`),
  UNIQUE KEY `IX_Users_UserName` (`UserName`),
  UNIQUE KEY `IX_Users_NormalizedEmail` (`NormalizedEmail`),
  UNIQUE KEY `IX_Users_NormalizedUserName` (`NormalizedUserName`),
  KEY `IX_Users_PostId` (`PostId`),
  CONSTRAINT `FK_Users_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('1048da39-cdaf-47a9-9fb1-960d81dd704b','demo_user@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-07-15 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'Demo User','Account',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'demo_user','DEMO_USER','DEMO_USER@EXAMPLE.COM',0,'2eglRDK78LC4haZrynmOc1dmaf5RooOP+eFO6GcS1/YXWjvZDGS9xkqSy2DuIx46','demo_user@example.com','demo_user@example.com','+1234567890',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('1448da39-cdaf-47a9-9fb1-960d81dd704b','asafarim.it@gmail.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1990-09-15 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'Deleted User','Account',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',1,'2025-03-01 15:44:14.995050',NULL,'2025-03-01 15:44:14.945372',1,NULL,1,NULL,'deleted_user','DELETED_USER','ASAFARIM.IT@GMAIL.COM',0,'jO0au6lVKdVs10F8s5J7DYvHcjD/LXI1LCHyHMa1Aozh8T5GS5WZaYlu1pbGVNM6','asafarim.it@gmail.com','asafarim.it@gmail.com','+1234567890',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fb5','user_1_8414@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-02-01 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 1','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-03-01 15:45:19.956783',NULL,NULL,1,NULL,1,NULL,'user_1_8414','USER_1_8414','USER_1_8414@EXAMPLE.COM',0,'diJWpmmujBhDQ6o0IFohPJLPvQStz1ESqDxDlSwQWhl3PuAtJV2JiDUoRUzA8FlW','user_1_8414@example.com','user_1_8414@example.com','+123456781',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fb6','user_2_225b@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-03-03 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 2','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_2_225b','USER_2_225B','USER_2_225B@EXAMPLE.COM',0,'7iuGKLN/XkzcMJTqc+Kr1n2X3AzybNRYhtaKkRdK19OpM37x9rlR4adMJlH0fK0E','user_2_225b@example.com','user_2_225b@example.com','+123456782',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fb7','user_3_e36f@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-04-04 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 3','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_3_e36f','USER_3_E36F','USER_3_E36F@EXAMPLE.COM',0,'KJvTzFbx56ib2mjMLOboRONhcR7sguyJOaKd21DDtfEDR7j7UYO997PMNYFiE7qq','user_3_e36f@example.com','user_3_e36f@example.com','+123456783',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fb8','user_4_3b3b@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-05-05 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 4','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_4_3b3b','USER_4_3B3B','USER_4_3B3B@EXAMPLE.COM',0,'IhXbUmddQDJMnS74+tSAtObBL59q2SNDcXd/gupqFg75fQ8mRF3MV5DTZS/d+HBk','user_4_3b3b@example.com','user_4_3b3b@example.com','+123456784',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fb9','user_5_dd11@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-06-05 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 5','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-03-01 15:44:51.285504',NULL,NULL,1,NULL,1,NULL,'user_5_dd11','USER_5_DD11','USER_5_DD11@EXAMPLE.COM',0,'Cu65hyp/K7eKppJjHfm9/+8n1SX56KhC+Jmen7dv3Tgv1STwQE4KDE8XIOiFZDIH','user_5_dd11@example.com','user_5_dd11@example.com','+123456785',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fba','user_6_239d@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-07-07 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 6','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_6_239d','USER_6_239D','USER_6_239D@EXAMPLE.COM',0,'3JzCXyP/wTAuSYsZ0EqYpXGKoLfLmjO1YT7lIQvi73wPa269Rj+djogp5D8d3wcF','user_6_239d@example.com','user_6_239d@example.com','+123456786',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fbb','user_7_1c66@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-08-08 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 7','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_7_1c66','USER_7_1C66','USER_7_1C66@EXAMPLE.COM',0,'FsatcwSSJ3ZKCZIigQSja1HHgtIeEqSNphfBOYbCAiJM2xxTGKDOBwRoeH0Fgonl','user_7_1c66@example.com','user_7_1c66@example.com','+123456787',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fbc','user_8_0c79@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-09-09 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 8','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_8_0c79','USER_8_0C79','USER_8_0C79@EXAMPLE.COM',0,'V949JdTxn2rA+0pCrXB95NwOjcZdyd3kXZECihHG40ulPGOBEmGqMuFZolYJ/N8z','user_8_0c79@example.com','user_8_0c79@example.com','+123456788',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fbd','user_9_b29b@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-10-10 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 9','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_9_b29b','USER_9_B29B','USER_9_B29B@EXAMPLE.COM',0,'Yjnz2CwNKX7CRtDTQDSVsSxag+EcMREMhWjfA8UBFG+2vEBW7umVf9Ca7QekxwBR','user_9_b29b@example.com','user_9_b29b@example.com','+123456789',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fbe','user_10_9d1e@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-11-11 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 10','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_10_9d1e','USER_10_9D1E','USER_10_9D1E@EXAMPLE.COM',0,'G8t3+A4TYHzCth+T1es4Ly6+cEloOjiu5crR4gnBRR5IoK4AEzKj6A7kom85c25b','user_10_9d1e@example.com','user_10_9d1e@example.com','+1234567810',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fbf','user_11_f125@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-12-12 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 11','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_11_f125','USER_11_F125','USER_11_F125@EXAMPLE.COM',0,'qR/EkuzQcJ2ertSsHyszxbDgArgu6THnfd7HSvQGjwVodNLcrG8fRDZ2cDahbHEt','user_11_f125@example.com','user_11_f125@example.com','+1234567811',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc0','user_12_7be9@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-01-13 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 12','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_12_7be9','USER_12_7BE9','USER_12_7BE9@EXAMPLE.COM',0,'DAx6BgDq5167rYcNqH1rHqE1DRi2Su3EtIZeuiu4uA7WlQnpHhPk8nSGzunEmF4P','user_12_7be9@example.com','user_12_7be9@example.com','+1234567812',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc1','user_13_3417@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-02-14 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 13','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_13_3417','USER_13_3417','USER_13_3417@EXAMPLE.COM',0,'AKbkBBhCP30oRHZcR38mOEao31Ol7O5qiWICmTTTJOeddag8D99ot7A5z1QZ76Y6','user_13_3417@example.com','user_13_3417@example.com','+1234567813',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc2','user_14_e999@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-03-15 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 14','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_14_e999','USER_14_E999','USER_14_E999@EXAMPLE.COM',0,'IHLMJYJoLXyRRkfeBVbs31O2A4sr7oiUmsooq0EZmmcSSr6cBYqv2bJDpmndcCys','user_14_e999@example.com','user_14_e999@example.com','+1234567814',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc3','user_15_afcb@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-04-16 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 15','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_15_afcb','USER_15_AFCB','USER_15_AFCB@EXAMPLE.COM',0,'8YXtfsjM+27sZ2ixS3Hi1o6+zG0DBMxSFk+hL6aNm4HG5IKCLn73N7jCZNr4EMEb','user_15_afcb@example.com','user_15_afcb@example.com','+1234567815',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc4','user_16_a028@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-05-17 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 16','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_16_a028','USER_16_A028','USER_16_A028@EXAMPLE.COM',0,'nDmmpwqE0vGKW2JNtIe0SMn4Ac32LcDEHbB3yvilTDZpNdpE5zBa284FKXh+B21g','user_16_a028@example.com','user_16_a028@example.com','+1234567816',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc5','user_17_575a@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-06-18 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 17','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_17_575a','USER_17_575A','USER_17_575A@EXAMPLE.COM',0,'wro25MbdSugpXG/EHCwTpN4BBzhDwGQ8Y7BAKGHXuQ5ZLl/uztwpvGde6k3oK+xI','user_17_575a@example.com','user_17_575a@example.com','+1234567817',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc6','user_18_e474@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-07-19 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 18','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_18_e474','USER_18_E474','USER_18_E474@EXAMPLE.COM',0,'vLl4vilrSpnf/6GFHMz7vzBKeUr/ZwvwWj4hH3fJHVHvV6YR4S1R4kKPyLY9SKQB','user_18_e474@example.com','user_18_e474@example.com','+1234567818',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc7','user_19_6100@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-08-20 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 19','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_19_6100','USER_19_6100','USER_19_6100@EXAMPLE.COM',0,'2gK20OJS8p6KS8m7pvG5Nz3VGgmXySdX8jCTWyn3pqyE7ao/M5580vNPl4FuOpip','user_19_6100@example.com','user_19_6100@example.com','+1234567819',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc8','user_20_098a@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-09-21 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 20','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_20_098a','USER_20_098A','USER_20_098A@EXAMPLE.COM',0,'6V11c1T3FDZZ4sSdvEuWMBDzOllXNDxxnWUiRWr9+MFRt1GvZlIw12+yGwLpcG3o','user_20_098a@example.com','user_20_098a@example.com','+1234567820',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fc9','user_21_fb9d@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-10-22 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 21','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_21_fb9d','USER_21_FB9D','USER_21_FB9D@EXAMPLE.COM',0,'JvnX8PDnRt59+sV16aJ0CF4U68490PhtWQQt1auUnFRdo9lJnz0/Z8G4tn8HS4RZ','user_21_fb9d@example.com','user_21_fb9d@example.com','+1234567821',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fca','user_22_82f4@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-11-23 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 22','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_22_82f4','USER_22_82F4','USER_22_82F4@EXAMPLE.COM',0,'OTcNlqVBgrJLQ1x/kSUbhheqJy5Ngz4MdHQFggcVEdXP2IqDavfZJ1P2CIhm0dzN','user_22_82f4@example.com','user_22_82f4@example.com','+1234567822',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fcb','user_23_fe48@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1976-12-24 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 23','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_23_fe48','USER_23_FE48','USER_23_FE48@EXAMPLE.COM',0,'rKGZ9FMDsb3Hf0TZUicVdnQLTp1lvK1aCZ5X5djXJ8Fbnd283IZbe1VlsoFzZufU','user_23_fe48@example.com','user_23_fe48@example.com','+1234567823',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fcc','user_24_6118@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-01-25 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 24','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_24_6118','USER_24_6118','USER_24_6118@EXAMPLE.COM',0,'TJwaIGhM9R1PYKJFxNvc6ErJt7DVn6+XbMpzeZLohoG4X+9XEJJku0bRtVK+ylNg','user_24_6118@example.com','user_24_6118@example.com','+1234567824',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fcd','user_25_fd2c@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-02-26 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 25','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_25_fd2c','USER_25_FD2C','USER_25_FD2C@EXAMPLE.COM',0,'0Wp3c0pWjonEIckHuJ3I84B/OXkKbvzQQMZhSp0Nh1yT/UehajrtTTClVot7HEgQ','user_25_fd2c@example.com','user_25_fd2c@example.com','+1234567825',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fce','user_26_74e2@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-03-27 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 26','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_26_74e2','USER_26_74E2','USER_26_74E2@EXAMPLE.COM',0,'J36yQvRge51D7jdlxX2CkgMFR84QUBt/fc163r9Wz8Y+U3QbwWztVJHdRfYNZa+b','user_26_74e2@example.com','user_26_74e2@example.com','+1234567826',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fcf','user_27_aced@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-04-28 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 27','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_27_aced','USER_27_ACED','USER_27_ACED@EXAMPLE.COM',0,'h3j82f7Olc6Ek4rEb6ZnN8oO2HjHAuoE1iilbpYiqtA/W/7Y6LVtZw96nilxHT6r','user_27_aced@example.com','user_27_aced@example.com','+1234567827',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd0','user_28_9573@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-05-01 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 28','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_28_9573','USER_28_9573','USER_28_9573@EXAMPLE.COM',0,'q2oE7AL95cz8e43fjNkSvJy8LPt+4Y8h5hCGce59rlg0fjQ/VrM11qkYXMdQlLNg','user_28_9573@example.com','user_28_9573@example.com','+1234567828',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd1','user_29_8b86@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-06-02 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 29','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_29_8b86','USER_29_8B86','USER_29_8B86@EXAMPLE.COM',0,'I7YsYm0E07mC7bLTWHfIdHifofVsLH95EyBzFC7zShBzJttw0EGUHyIvaWb3IxpR','user_29_8b86@example.com','user_29_8b86@example.com','+1234567829',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd2','user_30_d639@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-07-03 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 30','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_30_d639','USER_30_D639','USER_30_D639@EXAMPLE.COM',0,'hlNxifdC24rQlvyeDD96XI8jk2TQ7m1PVajniPLzH0i6wgYaLT8VjcFf4iPM18q9','user_30_d639@example.com','user_30_d639@example.com','+1234567830',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd3','user_31_3e53@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-08-04 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 31','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_31_3e53','USER_31_3E53','USER_31_3E53@EXAMPLE.COM',0,'z8CoIuKMpWyoFBjtrHOGKbaK3UnMbdu+/sWa3lDuUHaw6Uj1Xh1pMo23adxNNFB6','user_31_3e53@example.com','user_31_3e53@example.com','+1234567831',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd4','user_32_4114@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-09-05 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 32','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_32_4114','USER_32_4114','USER_32_4114@EXAMPLE.COM',0,'568jXMRIO6/4indsJJUg4jN1STEAhmldI0cQ9Y/VqeOTPW3VjzHiasQfXjE0mTRi','user_32_4114@example.com','user_32_4114@example.com','+1234567832',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd5','user_33_4f7c@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-10-06 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 33','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_33_4f7c','USER_33_4F7C','USER_33_4F7C@EXAMPLE.COM',0,'wohaiHIXUlIoeyG5HlpCgxEMjqD0VgyXWFJxGPBiEKmoOWXIMJXxDddURbCd6ugM','user_33_4f7c@example.com','user_33_4f7c@example.com','+1234567833',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd6','user_34_7587@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-11-07 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 34','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_34_7587','USER_34_7587','USER_34_7587@EXAMPLE.COM',0,'fqvf5gLLFMTnDU2fRsK1trFy9mJVbPtGQd4i5cKkeuLavODm7yIk5KEkfoOSUewS','user_34_7587@example.com','user_34_7587@example.com','+1234567834',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd7','user_35_57f9@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1977-12-08 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 35','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_35_57f9','USER_35_57F9','USER_35_57F9@EXAMPLE.COM',0,'hhFh3mBiDZWmLaPh9UN2k/UqIVxklf3p2L14kDCwOiquGdKn/bB54xL5/4Ma5SkO','user_35_57f9@example.com','user_35_57f9@example.com','+1234567835',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd8','user_36_bf10@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-01-09 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 36','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_36_bf10','USER_36_BF10','USER_36_BF10@EXAMPLE.COM',0,'EMnZgFJ2wJ1gcX9xG3KNNidWyzhXQq4qYB4W2X8qFBo9Z/GdDicE3mPKjZIOuxZJ','user_36_bf10@example.com','user_36_bf10@example.com','+1234567836',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fd9','user_37_713d@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-02-10 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 37','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_37_713d','USER_37_713D','USER_37_713D@EXAMPLE.COM',0,'PQB8Wzxq2UgPQDXdc4UBzKXQdsAgtMM6net3Fx8krmxunx7lsiY7A65O8I0ZBWZN','user_37_713d@example.com','user_37_713d@example.com','+1234567837',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fda','user_38_abd4@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-03-11 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 38','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_38_abd4','USER_38_ABD4','USER_38_ABD4@EXAMPLE.COM',0,'FTG36Tz6RZfb9klFPcKJLnLdaqoJbs02qOdBnx6WB4Px47WG0mS8hoDA6tIg8Uaa','user_38_abd4@example.com','user_38_abd4@example.com','+1234567838',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fdb','user_39_dd7d@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-04-12 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 39','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_39_dd7d','USER_39_DD7D','USER_39_DD7D@EXAMPLE.COM',0,'Y+wka8WuAqYWjuuFJY3SWXzmWnya/15DHssX4mGgEo+68x6o1Y741ONt9igBMlYl','user_39_dd7d@example.com','user_39_dd7d@example.com','+1234567839',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fdc','user_40_685d@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-05-13 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 40','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_40_685d','USER_40_685D','USER_40_685D@EXAMPLE.COM',0,'h18KUK1S4S5U5seuLe6RxXJ6YCBtRUs4uH5msZP2QfXi96c/SHY+/5RnAr9Ge9J9','user_40_685d@example.com','user_40_685d@example.com','+1234567840',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fdd','user_41_6ec2@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-06-14 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 41','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_41_6ec2','USER_41_6EC2','USER_41_6EC2@EXAMPLE.COM',0,'fZGUFBwBjry0GVIgr4UG3rAu5l+TimDEtWqJPY1jT3BhqOzCLTYJvlDCQWfqBAFe','user_41_6ec2@example.com','user_41_6ec2@example.com','+1234567841',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fde','user_42_d7e9@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-07-15 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 42','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_42_d7e9','USER_42_D7E9','USER_42_D7E9@EXAMPLE.COM',0,'SGueps9XgbXgE7+JRMwvK4fpziqRiqqmXhg7n3lcENLCHdx+gfo+T6Q/Uw8of6WT','user_42_d7e9@example.com','user_42_d7e9@example.com','+1234567842',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fdf','user_43_ddb4@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-08-16 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 43','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_43_ddb4','USER_43_DDB4','USER_43_DDB4@EXAMPLE.COM',0,'T7AyP2llSeHusNOSEea5k2uqkRbR6J5XC/jwcxfzdfcO5Otpp7RndSES2IvX9EpJ','user_43_ddb4@example.com','user_43_ddb4@example.com','+1234567843',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fe0','user_44_7025@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-09-17 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 44','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_44_7025','USER_44_7025','USER_44_7025@EXAMPLE.COM',0,'c4kdS9Mt2W5LFtQbDiCs+NUxV4Kd0+Oou2WBZLH/1os9FCZjWpcyVR05/bgOZUjk','user_44_7025@example.com','user_44_7025@example.com','+1234567844',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fe1','user_45_fe9a@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-10-18 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 45','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_45_fe9a','USER_45_FE9A','USER_45_FE9A@EXAMPLE.COM',0,'cuq0drW4773ycBbQb//Jf8JdyKbhGqZbA8BZuT1BvBwcOeZVfnsDod3AJ7ODjgtA','user_45_fe9a@example.com','user_45_fe9a@example.com','+1234567845',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fe2','user_46_4eb8@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-11-19 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 46','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_46_4eb8','USER_46_4EB8','USER_46_4EB8@EXAMPLE.COM',0,'4k5g318JivTJYdP1XEZwZRcHzOMZeSh6+0dFjd0AtFbBN3/16y49KMnrXoZjGtuf','user_46_4eb8@example.com','user_46_4eb8@example.com','+1234567846',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fe3','user_47_c723@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1978-12-20 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 47','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_47_c723','USER_47_C723','USER_47_C723@EXAMPLE.COM',0,'8wEPjdUitjS5izbFXNgh586qPWC2CGAmAAEcMYBgG7MpqM15LU6jvb+MgGCLpKzz','user_47_c723@example.com','user_47_c723@example.com','+1234567847',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fe4','user_48_5591@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1979-01-21 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 48','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_48_5591','USER_48_5591','USER_48_5591@EXAMPLE.COM',0,'iS0G/2ewwIOLl3VkWTDgN62pUPb2JmNVT3mLQ7Ia87B1CS7FwDaBxS2hVfhdBD3/','user_48_5591@example.com','user_48_5591@example.com','+1234567848',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fe5','user_49_58b4@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1979-02-22 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 49','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_49_58b4','USER_49_58B4','USER_49_58B4@EXAMPLE.COM',0,'H3c9/HTMWmdwmXp5u4aoMSx33WXAcJoFm1DkueXPTJhgG7joR27S3bIwKaYCtx6+','user_49_58b4@example.com','user_49_58b4@example.com','+1234567849',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('7fb725c6-3250-b856-604e-69f27e228fe6','user_50_23e7@example.com',0,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1979-03-23 00:00:00.000000','2025-02-17 10:00:00.000000',0,0,NULL,NULL,NULL,NULL,'User 50','Example',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-02-17 10:00:00.000000',NULL,NULL,1,NULL,1,NULL,'user_50_23e7','USER_50_23E7','USER_50_23E7@EXAMPLE.COM',0,'HuGq0ZjpjtbZKYvZuucmSOcrM4rjhYcjgfz7RIhVZKzx4bxAr8Pa6G4zJNCJMolN','user_50_23e7@example.com','user_50_23e7@example.com','+1234567850',0,0,0,0,0,0,0,0,1,0,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL),('8048da39-cdaf-47a9-9fb1-960d81dd704a','demo_admin@example.com',1,'2025-02-17 10:00:00.000000','https://asafarim.com/logoT.svg','1975-07-15 00:00:00.000000','2025-03-02 17:57:31.298686',0,0,NULL,NULL,NULL,NULL,'Demo Admin','Account',NULL,'8048da39-cdaf-47a9-9fb1-960d81dd704a','8048da39-cdaf-47a9-9fb1-960d81dd704a',0,'2025-03-02 17:57:31.302898',NULL,NULL,1,NULL,1,NULL,'demo_admin','DEMO_ADMIN','DEMO_ADMIN@EXAMPLE.COM',0,'FbJXQ7XOvSrmQeqm0VkXF0NNDCozdx5693yLqqhF1G8qXhWVuEs2Vly9CiLTAW7G','demo_admin@example.com','demo_admin@example.com','+123456789',0,0,0,0,0,0,0,0,1,1,1,NULL,NULL,0,NULL,1,NULL,NULL,NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

--
-- Table structure for table `userthemepreferences`
--

DROP TABLE IF EXISTS `userthemepreferences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userthemepreferences` (
  `UserId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `ThemePreferenceId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`ThemePreferenceId`),
  KEY `IX_UserThemePreferences_ThemePreferenceId` (`ThemePreferenceId`),
  CONSTRAINT `FK_UserThemePreferences_ThemePreferences_ThemePreferenceId` FOREIGN KEY (`ThemePreferenceId`) REFERENCES `themepreferences` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_UserThemePreferences_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userthemepreferences`
--

/*!40000 ALTER TABLE `userthemepreferences` DISABLE KEYS */;
/*!40000 ALTER TABLE `userthemepreferences` ENABLE KEYS */;

--
-- Dumping routines for database 'asmdb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-02 20:00:16
