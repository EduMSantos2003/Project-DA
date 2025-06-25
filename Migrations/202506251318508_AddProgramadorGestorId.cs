namespace iTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProgramadorGestorId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilizadors", "GestorId", c => c.Int());
            CreateIndex("dbo.Utilizadors", "GestorId");
            AddForeignKey("dbo.Utilizadors", "GestorId", "dbo.Utilizadors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Utilizadors", "GestorId", "dbo.Utilizadors");
            DropIndex("dbo.Utilizadors", new[] { "GestorId" });
            DropColumn("dbo.Utilizadors", "GestorId");
        }
    }
}
