namespace UpdateServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatchNameIndex : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patches", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Patches", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Patches", new[] { "Name" });
            AlterColumn("dbo.Patches", "Name", c => c.String());
        }
    }
}
