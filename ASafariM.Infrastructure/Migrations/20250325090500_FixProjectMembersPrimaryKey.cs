using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASafariM.Infrastructure.Migrations
{
    public partial class FixProjectMembersPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Check if the ProjectMembers table exists
            migrationBuilder.Sql(@"
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
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // No need to do anything in Down as this is a fix migration
        }
    }
}
