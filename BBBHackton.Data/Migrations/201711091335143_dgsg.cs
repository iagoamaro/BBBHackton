namespace BBBHackton.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dgsg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCurso = c.String(nullable: false),
                        Universidade = c.String(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataConclusao = c.DateTime(nullable: false),
                        PerfilId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Perfil", t => t.PerfilId)
                .Index(t => t.PerfilId);
            
            CreateTable(
                "dbo.Perfil",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Foto = c.String(),
                        LinkSocialMedia = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpProfissional",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cargo = c.String(nullable: false),
                        Empresa = c.String(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        PerfilId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Perfil", t => t.PerfilId)
                .Index(t => t.PerfilId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpProfissional", "PerfilId", "dbo.Perfil");
            DropForeignKey("dbo.Curso", "PerfilId", "dbo.Perfil");
            DropIndex("dbo.ExpProfissional", new[] { "PerfilId" });
            DropIndex("dbo.Curso", new[] { "PerfilId" });
            DropTable("dbo.ExpProfissional");
            DropTable("dbo.Perfil");
            DropTable("dbo.Curso");
        }
    }
}
