namespace iTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizarModelo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tarefas", "Projeto_Id", "dbo.Projetoes");
            DropIndex("dbo.Tarefas", new[] { "Projeto_Id" });
            DropColumn("dbo.Tarefas", "Projeto_Id");
            DropTable("dbo.Projetoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Projetoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tarefas", "Projeto_Id", c => c.Int());
            CreateIndex("dbo.Tarefas", "Projeto_Id");
            AddForeignKey("dbo.Tarefas", "Projeto_Id", "dbo.Projetoes", "Id");
        }
    }
}
