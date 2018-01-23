namespace UpdateServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFileKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Files");
            AddColumn("dbo.Files", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Files", "Path", c => c.String(nullable: false, maxLength: 300));
            AddPrimaryKey("dbo.Files", "Id");
            CreateIndex("dbo.Files", "Path", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Files", new[] { "Path" });
            DropPrimaryKey("dbo.Files");
            AlterColumn("dbo.Files", "Path", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Files", "Id");
            AddPrimaryKey("dbo.Files", "Path");
        }
    }
}
