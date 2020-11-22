namespace MoviesEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Directors", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Directors", "Surname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Movies", "ProductionYear", c => c.String(maxLength: 4));
            AlterColumn("dbo.Reviews", "Reviewer", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Reviewer", c => c.String());
            AlterColumn("dbo.Movies", "ProductionYear", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            AlterColumn("dbo.Directors", "Surname", c => c.String());
            AlterColumn("dbo.Directors", "Name", c => c.String());
        }
    }
}
