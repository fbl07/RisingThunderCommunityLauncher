namespace UpdateServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialInsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Path = c.String(nullable: false, maxLength: 128),
                        PatchLastUpdated_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Path)
                .ForeignKey("dbo.Patches", t => t.PatchLastUpdated_Id)
                .Index(t => t.PatchLastUpdated_Id);
            
            CreateTable(
                "dbo.Patches",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "PatchLastUpdated_Id", "dbo.Patches");
            DropIndex("dbo.Files", new[] { "PatchLastUpdated_Id" });
            DropTable("dbo.Patches");
            DropTable("dbo.Files");
        }
    }
}
