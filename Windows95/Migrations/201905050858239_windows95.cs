namespace Windows95.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class windows95 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        PrimaryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Icon = c.Binary(),
                    })
                .PrimaryKey(t => t.PrimaryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applications");
        }
    }
}
