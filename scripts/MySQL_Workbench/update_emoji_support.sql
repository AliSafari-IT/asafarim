-- SQL Script to update database for emoji support

-- First, we need to update all related tables to maintain foreign key integrity
-- Change the MarkdownFiles table character set first (since Projects references it)
ALTER TABLE MarkdownFiles CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Now we can safely update the Projects table
ALTER TABLE Projects CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Update specific columns in Projects table
ALTER TABLE Projects MODIFY COLUMN Description TEXT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
ALTER TABLE Projects MODIFY COLUMN Name VARCHAR(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Update specific columns in MarkdownFiles table if needed
ALTER TABLE MarkdownFiles MODIFY COLUMN Content LONGTEXT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
ALTER TABLE MarkdownFiles MODIFY COLUMN Title VARCHAR(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Finally, change the database character set
ALTER DATABASE asmDB CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Check if the changes were applied
SHOW CREATE TABLE Projects;
SHOW CREATE TABLE MarkdownFiles;

-- Note: If you have other tables that need to store emoji characters,
-- you should apply similar changes to those tables as well.
