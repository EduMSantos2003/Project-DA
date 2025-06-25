namespace iTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoverProjeto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tarefas", "ProjetoId", "dbo.Projetoes");
            DropIndex("dbo.Tarefas", new[] { "ProjetoId" });
            DropColumn("dbo.Tarefas", "ProjetoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tarefas", "ProjetoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tarefas", "ProjetoId");
            AddForeignKey("dbo.Tarefas", "ProjetoId", "dbo.Projetoes", "Id");
        }
    }
}
