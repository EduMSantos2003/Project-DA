namespace iTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Departamento = c.Int(),
                        GereUtilizadores = c.Boolean(),
                        NivelExperiencia = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projetoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tarefas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        EstadoAtual = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataPrevistaInicio = c.DateTime(nullable: false),
                        DataPrevistaFim = c.DateTime(nullable: false),
                        DataRealInicio = c.DateTime(),
                        DataRealFim = c.DateTime(),
                        OrdemExecucao = c.Int(nullable: false),
                        TipoTarefaId = c.Int(nullable: false),
                        ProgramadorId = c.Int(nullable: false),
                        GestorId = c.Int(nullable: false),
                        ProjetoId = c.Int(nullable: false),
                        StoryPoints = c.Int(nullable: false),
                        Projeto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.GestorId)
                .ForeignKey("dbo.Utilizadors", t => t.ProgramadorId)
                .ForeignKey("dbo.Projetoes", t => t.ProjetoId)
                .ForeignKey("dbo.TipoTarefas", t => t.TipoTarefaId)
                .ForeignKey("dbo.Projetoes", t => t.Projeto_Id)
                .Index(t => t.TipoTarefaId)
                .Index(t => t.ProgramadorId)
                .Index(t => t.GestorId)
                .Index(t => t.ProjetoId)
                .Index(t => t.Projeto_Id);
            
            CreateTable(
                "dbo.TipoTarefas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeTarefa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarefas", "Projeto_Id", "dbo.Projetoes");
            DropForeignKey("dbo.Tarefas", "TipoTarefaId", "dbo.TipoTarefas");
            DropForeignKey("dbo.Tarefas", "ProjetoId", "dbo.Projetoes");
            DropForeignKey("dbo.Tarefas", "ProgramadorId", "dbo.Utilizadors");
            DropForeignKey("dbo.Tarefas", "GestorId", "dbo.Utilizadors");
            DropIndex("dbo.Tarefas", new[] { "Projeto_Id" });
            DropIndex("dbo.Tarefas", new[] { "ProjetoId" });
            DropIndex("dbo.Tarefas", new[] { "GestorId" });
            DropIndex("dbo.Tarefas", new[] { "ProgramadorId" });
            DropIndex("dbo.Tarefas", new[] { "TipoTarefaId" });
            DropTable("dbo.TipoTarefas");
            DropTable("dbo.Tarefas");
            DropTable("dbo.Projetoes");
            DropTable("dbo.Utilizadors");
        }
    }
}
