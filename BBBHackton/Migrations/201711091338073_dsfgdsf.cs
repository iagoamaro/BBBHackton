namespace BBBHackton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dsfgdsf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Perfils",
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
                "dbo.Cursoes",
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
                .ForeignKey("dbo.Perfils", t => t.PerfilId, cascadeDelete: true)
                .Index(t => t.PerfilId);
            
            CreateTable(
                "dbo.ExpProfissionals",
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
                .ForeignKey("dbo.Perfils", t => t.PerfilId, cascadeDelete: true)
                .Index(t => t.PerfilId);
            
            AddColumn("dbo.AspNetUsers", "PerfilId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "PerfilId");
            AddForeignKey("dbo.AspNetUsers", "PerfilId", "dbo.Perfils", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "PerfilId", "dbo.Perfils");
            DropForeignKey("dbo.ExpProfissionals", "PerfilId", "dbo.Perfils");
            DropForeignKey("dbo.Cursoes", "PerfilId", "dbo.Perfils");
            DropIndex("dbo.ExpProfissionals", new[] { "PerfilId" });
            DropIndex("dbo.Cursoes", new[] { "PerfilId" });
            DropIndex("dbo.AspNetUsers", new[] { "PerfilId" });
            DropColumn("dbo.AspNetUsers", "PerfilId");
            DropTable("dbo.ExpProfissionals");
            DropTable("dbo.Cursoes");
            DropTable("dbo.Perfils");
        }
    }
}
